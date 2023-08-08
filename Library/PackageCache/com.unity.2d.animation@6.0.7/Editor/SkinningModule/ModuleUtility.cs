v0 = __builtin_shufflevector(__p0, __p0, 3, 2, 1, 0);
  float16x4_t __rev1;  __rev1 = __builtin_shufflevector(__p1, __p1, 3, 2, 1, 0);
  float16x4_t __ret;
  __ret = (float16x4_t) __builtin_neon_vmax_v((int8x8_t)__rev0, (int8x8_t)__rev1, 8);
  __ret = __builtin_shufflevector(__ret, __ret, 3, 2, 1, 0);
  return __ret;
}
#endif

#ifdef __LITTLE_ENDIAN__
__ai float16x8_t vminq_f16(float16x8_t __p0, float16x8_t __p1) {
  float16x8_t __ret;
  __ret = (float16x8_t) __builtin_neon_vminq_v((int8x16_t)__p0, (int8x16_t)__p1, 40);
  return __ret;
}
#else
__ai float16x8_t vminq_f16(float16x8_t __p0, float16x8_t __p1) {
  float16x8_t __rev0;  __rev0 = __builtin_shufflevector(__p0, __p0, 7, 6, 5, 4, 3, 2, 1, 0);
  float16x8_t __rev1;  __rev1 = __builtin_shufflevector(__p1, __p1, 7, 6, 5, 4, 3, 2, 1, 0);
  float16x8_t __ret;
  __ret = (float16x8_t) __builtin_neon_vminq_v((int8x16_t)__rev0, (int8x16_t)__rev1, 40);
  __ret = __builtin_shufflevector(__ret, __ret, 7, 6, 5, 4, 3, 2, 1, 0);
  return __ret;
}
#endif

#ifdef __LITTLE_ENDIAN__
__ai float16x4_t vmin_f16(float16x4_t __p0, float16x4_t __p1) {
  float16x4_t __ret;
  __ret = (float16x4_t) __builtin_neon_vmin_v((int8x8_t)__p0, (int8x8_t)__p1, 8);
  return __ret;
}
#else
__ai float16x4_t vmin_f16(float16x4_t __p0, float16x4_t __p1) {
  float16x4_t __rev0;  __rev0 = __builtin_shufflevector(__p0, __p0, 3, 2, 1, 0);
  float16x4_t __rev1;  __rev1 = __builtin_shufflevector(__p1, __p1, 3, 2, 1, 0);
  float16x4_t __ret;
  __ret = (float16x4_t) __builtin_neon_vmin_v((int8x8_t)__rev0, (int8x8_t)__rev1, 8);
  __ret = __builtin_shufflevector(__ret, __ret, 3, 2, 1, 0);
  return __ret;
}
#endif

#ifdef __LITTLE_ENDIAN__
__ai float16x8_t vmulq_f16(float16x8_t __p0, float16x8_t __p1) {
  float16x8_t __ret;
  __ret = __p0 * __p1;
  return __ret;
}
#else
__ai float16x8_t vmulq_f16(float16x8_t __p0, float16x8_t __p1) {
  float16x8_t __rev0;  __rev0 = __builtin_shufflevector(__p0, __p0, 7, 6, 5, 4, 3, 2, 1, 0);
  float16x8_t __rev1;  __rev1 = __builtin_shufflevector(__p1, __p1, 7, 6, 5, 4, 3, 2, 1, 0);
  float16x8_t __ret;
  __ret = __rev0 * __rev1;
  __ret = __builtin_shufflevector(__ret, __ret, 7, 6, 5, 4, 3, 2, 1, 0);
  return __ret;
}
#endif

#ifdef __LITTLE_ENDIAN__
__ai float16x4_t vmul_f16(float16x4_t __p0, float16x4_t __p1) {
  float16x4_t __ret;
  __ret = __p0 * __p1;
  return __ret;
}
#else
__ai float16x4_t vmul_f16(float16x4_t __p0, float16x4_t __p1) {
  float16x4_t __rev0;  __rev0 = __builtin_shufflevector(__p0, __p0, 3, 2, 1, 0);
  float16x4_t __rev1;  __rev1 = __builtin_shufflevector(__p1, __p1, 3, 2, 1, 0);
  float16x4_t __ret;
  __ret = __rev0 * __rev1;
  __ret = __builtin_shufflevector(__ret, __ret, 3, 2, 1, 0);
  return __ret;
}
#endif

#ifdef __LITTLE_ENDIAN__
#define vmulq_lane_f16(__p0, __p1, __p2) __extension__ ({ \
  float16x8_t __s0 = __p0; \
  float16x4_t __s1 = __p1; \
  float16x8_t __ret; \
  __ret = __s0 * __builtin_shufflevector(__s1, __s1, __p2, __p2, __p2, __p2, __p2, __p2, __p2, __p2); \
  __ret; \
})
#else
#define vmulq_lane_f16(__p0, __p1, __p2) __extension__ ({ \
  float16x8_t __s0 = __p0; \
  float16x4_t __s1 = __p1; \
  float16x8_t __rev0;  __rev0 = __builtin_shufflevector(__s0, __s0, 7, 6, 5, 4, 3, 2, 1, 0); \
  float16x4_t __rev1;  __rev1 = __builtin_shufflevector(__s1, __s1, 3, 2, 1, 0); \
  float16x8_t __ret; \
  __ret = __rev0 * __builtin_shufflevector(__rev1, __rev1, __p2, __p2, __p2, __p2, __p2, __p2, __p2, __p2); \
  __ret = __builtin_shufflevector(__ret, __ret, 7, 6, 5, 4, 3, 2, 1, 0); \
  __ret; \
})
#endif

#ifdef __LITTLE_ENDIAN__
#define vmul_lane_f16(__p0, __p1, __p2) __extension__ ({ \
  float16x4_t __s0 = __p0; \
  float16x4_t __s1 = __p1; \
  float16x4_t __ret; \
  __ret = __s0 * __builtin_shufflevector(__s1, __s1, __p2, __p2, __p2, __p2); \
  __ret; \
})
#else
#define vmul_lane_f16(__p0, __p1, __p2) __extension__ ({ \
  float16x4_t __s0 = __p0; \
  float16x4_t __s1 = __p1; \
  float16x4_t __rev0;  __rev0 = __builtin_shufflevector(__s0, __s0, 3, 2, 1, 0); \
  float16x4_t __rev1;  __rev1 = __builtin_shufflevector(__s1, __s1, 3, 2, 1, 0); \
  float16x4_t __ret; \
  __ret = __rev0 * __builtin_shufflevector(__rev1, __rev1, __p2, __p2, __p2, __p2); \
  __ret = __builtin_shufflevector(__ret, __ret, 3, 2, 1, 0); \
  __ret; \
})
#endif

#ifdef __LITTLE_ENDIAN__
#define vmulq_n_f16(__p0, __p1) __extension__ ({ \
  float16x8_t __s0 = __p0; \
  float16_t __s1 = __p1; \
  float16x8_t __ret; \
  __ret = __s0 * (float16x8_t) {__s1, __s1, __s1, __s1, __s1, __s1, __s1, __s1}; \
  __ret; \
})
#else
#define vmulq_n_f16(__p0, __p1) __extension__ ({ \
  float16x8_t __s0 = __p0; \
  float16_t __s1 = __p1; \
  float16x8_t __rev0;  __rev0 = __builtin_shufflevector(__s0, __s0, 7, 6, 5, 4, 3, 2, 1, 0); \
  float16x8_t __ret; \
  __ret = __rev0 * (float16x8_t) {__s1, __s1, __s1, __s1, __s1, __s1, __s1, __s1}; \
  __ret = __builtin_shufflevector(__ret, __ret, 7, 6, 5, 4, 3, 2, 1, 0); \
  __ret; \
})
#endif

#ifdef __LITTLE_