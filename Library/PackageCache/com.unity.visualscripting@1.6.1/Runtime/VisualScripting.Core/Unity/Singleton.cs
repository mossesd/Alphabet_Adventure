eft hand side bool to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side bool4x4 to use to compute componentwise not equal.</param>
        /// <returns>bool4x4 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator != (bool lhs, bool4x4 rhs) { return new bool4x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }


        /// <summary>Returns the result of a componentwise not operation on a bool4x4 matrix.</summary>
        /// <param name="val">Value to use when computing the componentwise not.</param>
        /// <returns>bool4x4 result of the componentwise not.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator ! (bool4x4 val) { return new bool4x4 (!val.c0, !val.c1, !val.c2, !val.c3); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two bool4x4 matrices.</summary>
        /// <param name="lhs">Left hand side bool4x4 to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side bool4x4 to use to compute componentwise bitwise and.</param>
        /// <returns>bool4x4 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator & (bool4x4 lhs, bool4x4 rhs) { return new bool4x4 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2, lhs.c3 & rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool4x4 matrix and a bool value.</summary>
        /// <param name="lhs">Left hand side bool4x4 to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side bool to use to compute componentwise bitwise and.</param>
        /// <returns>bool4x4 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator & (bool4x4 lhs, bool rhs) { return new bool4x4 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs, lhs.c3 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool value and a bool4x4 matrix.</summary>
        /// <param name="lhs">Left hand side bool to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side bool4x4 to use to compute componentwise bitwise and.</param>
        /// <returns>bool4x4 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator & (bool lhs, bool4x4 rhs) { return new bool4x4 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2, lhs & rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two bool4x4 matrices.</summary>
        /// <param name="lhs">Left hand side bool4x4 to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side bool4x4 to use to compute componentwise bitwise or.</param>
        /// <returns>bool4x4 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator | (bool4x4 lhs, bool4x4 rhs) { return new bool4x4 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2, lhs.c3 | rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool4x4 matrix and a bool value.</summary>
        /// <param name="lhs">Left hand side bool4x4 to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side bool to use to compute componentwise bitwise or.</param>
        /// <returns>bool4x4 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator | (bool4x4 lhs, bool rhs) { return new bool4x4 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs, lhs.c3 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool value and a bool4x4 matrix.</summary>
        /// <param name="lhs">Left hand side bool to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side bool4x4 to use to compute componentwise bitwise or.</param>
        /// <returns>bool4x4 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator | (bool lhs, bool4x4 rhs) { return new bool4x4 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2, lhs | rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two bool4x4 matrices.</summary>
        /// <param name="lhs">Left hand side bool4x4 to use to compute componentwise bitwise exclusive or.</param>
        /// <par