  w[0] = k;

    return (w[1] | ((U64)w[0] << 32)) + (w[3] | ((U64)w[2] << 32));

#else /* Portable scalar version */

    /* emulate 64x64->128b multiplication, using four 32x32->64 */
    U32 const h1 = (U32)(ll1 >> 32);
    U32 const h2 = (U32)(ll2 >> 32);
    U32 const l1 = (U32)ll1;
    U32 const l2 = (U32)ll2;

    U64 const llh  = XXH_mult32to64(h1, h2);
    U64 const llm1 = XXH_mult32to64(l1, h2);
    U64 const llm2 = XXH_mult32to64(h1, l2);
    U64 const lll  = XXH_mult32to64(l1, l2);

    U64 const t = lll + (llm1 << 32);
    U64 const carry1 = t < lll;

    U64 const lllow = t + (llm2 << 32);
    U64 const carry2 = lllow < t;
    U64 const llhigh = llh + (llm1 >> 32) + (llm2 >> 32) + carry1 + carry2;

    return llhigh + lllow;

#endif
}


static XXH64_hash_t XXH3_avalanche(U64 h64)
{
    h64 ^= h64 >> 29;
    h64 *= PRIME64_3;
    h64 ^= h64 >> 32;
    return h64;
}


/* ==========================================
 * Short keys
 * ========================================== */

XXH_FORCE_INLINE XXH64_hash_t
XXH3_len_1to3_64b(const void* data, size_t len, const void* keyPtr, XXH64_hash_t seed)
{
    assert(data != NULL);
    assert(len > 0 && len <= 3);
    assert(keyPtr != NULL);
    {   const U32* const key32 = (const U32*) keyPtr;
        BYTE const c1 = ((const BYTE*)data)[0];
        BYTE const c2 = ((const BYTE*)data)[len >> 1];
        BYTE const c3 = ((const BYTE*)data)[len - 1];
        U32  const l1 = (U32)(c1) + ((U32)(c2) << 8);
        U32  const l2 = (U32)(len) + ((U32)(c3) << 2);
        U64  const ll11 = XXH_mult32to64((l1 + seed + key32[0]), (l2 + key32[1]));
        return XXH3_avalanche(ll11);
    }
}

XXH_FORCE_INLINE XXH64_hash_t
XXH3_len_4to8_64b(const void* data, size_t len, const void* keyPtr, XXH64_hash_t seed)
{
    assert(data != NULL);
    assert(len >= 4 && len <= 8);
    {   const U32* const key32 = (const U32*) keyPtr;
        U64 acc = PRIME64_1 * (len + seed);
        U32 const l1 = XXH_readLE32(data) + key32[0];
        U32 const l2 = XXH_readLE32((const BYTE*)data + len - 4) + key32[1];
        acc += XXH_mult32to64(l1, l2);
        return XXH3_avalanche(acc);
    }
}

XXH_FORCE_INLINE U64
XXH3_readKey64(const void* ptr)
{
    assert(((size_t)ptr & 7) == 0);   /* aligned on 8-bytes boundaries */
    if (XXH_CPU_LITTLE_ENDIAN) {
        return *(const U64*)ptr;
    } else {
        const U32* const ptr32 = (const U32*)ptr;
        return (U64)ptr32[0] + (((U64)ptr32[1]) << 32);
    }
}

XXH_FORCE_INLINE XXH64_hash_t
XXH3_len_9to16_64b(const void* data, size_t len, const void* keyPtr, XXH64_hash_t seed)
{
    assert(data != NULL);
    assert(key != NULL);
    assert(len >= 9 && len <= 16);
    {   const U64* const key64 = (const U64*) keyPtr;
        U64 acc = PRIME64_1 * (len + seed);
        U64 const ll1 = XXH_readLE64(data) + XXH3_readKey64(key64);
        U64 const ll2 = XXH_readLE64((const BYTE*)data + len - 8) + XXH3_readKey64(key64+1);
        acc += XXH3_mul128(ll1, ll2);
        return XXH3_avalanche(acc);
    }
}

XXH_FORCE_INLINE XXH64_hash_t
XXH3_len_0to16_64b(const void* data, size_t len, XXH64_hash_t seed)
{
    assert(data != NULL);
    assert(len <= 16);
    {   if (len > 8) return XXH3_len_9to16_64b(data, len, kKey, seed);
        if (len >= 4) return XXH3_len_4to8_64b(data, len, kKey, seed);
        if (len) return XXH3_len_1to3_64b(data, len, kKey, seed);
        return seed;
    }
}


/* ===    Long Keys    === */

#define STRIPE_LEN 64
#define STRIPE_ELTS (STRIPE_LEN / sizeof(U32))
#define ACC_NB (STRIPE_LEN / sizeof(U64))

XXH_FORCE_INLINE void
XXH3_accumulate_512(void* acc, const void *restrict data, const void *restrict key)
{
#if (XXH_VECTOR == XXH_AVX2)

    assert(((size_t)acc) & 31 == 0);
    {   ALIGN(32) __m256i* const xacc  =       (__m256i *) acc;
        const     __m256i* const xdata = (const __m256i *) data;
        const     __m256i* const xkey  = (const __m256i *) key;

        size_t i;
        for (i=0; i < STRIPE_LEN/sizeof(__m256i); i++) {
            __m256i const d   = _mm256_loadu_si256 (xdata+i);
            __m256i const k   = _mm256_loadu_si256 (xkey+i);
            __m256i const dk  = _mm256_add_epi32 (d,k);                                  /* uint32 dk[8]  = {d0+k0, d1+k1, d2+k2, d3+k3, ...} */
            __m256i const res = _mm256_mul_epu32 (dk, _mm256_shuffle_epi32 (dk, 0x31));  /* uint64 res[4] = {dk0*dk1, dk2*dk3, ...} */
            __m256i const add = _mm256_add_epi64(d, xacc[i]);
            xacc[i]  = _mm256_add_epi64(res, add);
        }
    }

#elif (XXH_VECTOR == XXH_SSE2)

    assert(((size_t)acc) & 15 == 0);
    {   ALIGN(16) __m128i* const xacc  =       (__m128i *) acc;
        const     __m128i* const xdata = (const __m128i *) data;
        const     __m128i* const xkey  = (const __m128i *) key;

        size_t i;
        for (i=0; i < STRIPE_LEN/sizeof(__m128i); i++) {
            __m128i const d   = _mm_loadu_si128 (xdata+i);
            __m128i const k   = _mm_loadu_si128 (xkey+i);
            __m128i const dk  = _mm_add_epi32 (d,k);                                 /* uint32 dk[4]  = {d0+k0, d1+k1, d2+k2, d3+k3} */
            __m128i const res = _mm_mul_epu32 (dk, _mm_shuffle_epi32 (dk, 0x31));    /* uint64 res[2] = {dk0*dk1,dk2*dk3} */
            __m128i const add = _mm_add_epi64(d, xacc[i]);
            xacc[i]  = _mm_add_epi64(res, add);
        }
    }

#elif (XXH_VECTOR == XXH_NEON)

    assert(((size_t)acc) & 15 == 0);
    {       uint64x2_t* const xacc  =     (uint64x2_t *)acc;
        const uint32_t* const xdata = (const uint32_t *)data;
        const uint32_t* const xkey  = (const uint32_t *)key;

        size_t i;
        for (i=0; i < STRIPE_LEN / sizeof(uint64x2_