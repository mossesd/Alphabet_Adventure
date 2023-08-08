, x.z << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an int3 vector by a number of bits specified by a single int.</summary>
        /// <param name="x">The vector to right shift.</param>
        /// <param name="n">The number of bits to right shift.</param>
        /// <returns>The result of the componentwise right shift.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator >> (int3 x, int n) { return new int3 (x.x >> n, x.y >> n, x.z >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two int3 vectors.</summary>
        /// <param name="lhs">Left hand side int3 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side int3 to use to compute componentwise equality.</param>
        /// <returns>bool3 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (int3 lhs, int3 rhs) { return new bool3 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z); }

        /// <summary>Returns the result of a componentwise equality operation on an int3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side int3 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise equality.</param>
        /// <returns>bool3 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (int3 lhs, int rhs) { return new bool3 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on an int value and an int3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side int3 to use to compute componentwise equality.</param>
        /// <returns>bool3 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (int lhs, int3 rhs) { return new bool3 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z); }


        /// <summary>Returns the result of a componentwise not equal operation on two int3 vectors.</summary>
        /// <param name="lhs">Left hand side int3 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side int3 to use to compute componentwise not equal.</param>
        /// <returns>bool3 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (int3 lhs, int3 rhs) { return new bool3 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z); }

        /// <summary>Returns the result of a componentwise not equal operation on an int3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side int3 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise not equal.</param>
        /// <returns>bool3 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (int3 lhs, int rhs) { return new bool3 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on an int value and an int3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side int3 to use to compute componentwise not equal.</param>
        /// <returns>bool3 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (int lhs, int3 rhs) { return new bool3 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z); }


        /// <summary>Returns the result of a componentwise bitwise not operation on an int3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise bitwise not.</param>
        /// <returns>int3 result of the componentwise bitwise not.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator ~ (int3 val) { return new int3 (~val.x, ~val.y, ~val.z); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two int3 vectors.</summary>
        /// <param name="lhs">Left hand side int3 to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side int3 to use to compute componentwise bitwise and.</param>
        /// <returns>int3 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator & (int3 lhs, int3 rhs) { return new int3 (lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side int3 to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise bitwise and.</param>
        /// <returns>int3 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator & (int3 lhs, int rhs) { return new int3 (lhs.x & rhs, lhs.y & rhs, lhs.z & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int value and an int3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side int3 to use to compute componentwise bitwise and.</param>
        /// <returns>int3 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator & (int lhs, int3 rhs) { return new int3 (lhs & rhs.x, lhs & rhs.y, lhs & rhs.z); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two int3 vectors.</summary>
        /// <param name="lhs">Left hand side int3 to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side int3 to use to compute componentwise bitwise or.</param>
        /// <returns>int3 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator | (int3 lhs, int3 rhs) { return new int3 (lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side int3 to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise bitwise or.</param>
        /// <returns>int3 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator | (int3 lhs, int rhs) { return new int3 (lhs.x | rhs, lhs.y | rhs, lhs.z | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int value and an int3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side int3 to use to compute componentwise bitwise or.</param>
        /// <returns>int3 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator | (int lhs, int3 rhs) { return new int3 (lhs | rhs.x, lhs | rhs.y, lhs | rhs.z); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two int3 vectors.</summary>
        /// <param name="lhs">Left hand side int3 to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side int3 to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>int3 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator ^ (int3 lhs, int3 rhs) { return new int3 (lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side int3 to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>int3 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator ^ (int3 lhs, int rhs) { return new int3 (lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int value and an int3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side int3 to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>int3 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator ^ (int lhs, int3 rhs) { return new int3 (lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z); }




        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, y, x); }
        }


     