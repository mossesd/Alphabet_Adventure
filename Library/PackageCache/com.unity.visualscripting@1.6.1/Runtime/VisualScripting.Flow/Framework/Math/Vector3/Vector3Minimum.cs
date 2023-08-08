        result = d(arg0);
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        private delegate ulong R_UInt64_P_0_UInt64_Ref_Delegate(ref ulong arg0);
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        private unsafe static object Call_R_UInt64_P_0_UInt64_Ref_Delegate(object delegateObj, object[] p)
        {
            var d = (R_UInt64_P_0_UInt64_Ref_Delegate)delegateObj;
            object result = null;
            var arg0 = (ulong)p[0];
            result = d(ref arg0);
            return result;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        private unsafe delegate ulong R_UInt64_P_0_UInt64_Ptr_1_UInt64_2_UInt64_Delegate(ulong* arg0, ulong arg1, ulong arg2);
        [System.ComponentModel.EditorB