nterop  methods "%s",
  "%d",
  namespace   wrapper_type    ,
  %s.json acfg->nshared_got_entries       Dedup Pass: Size Saved From Deduped Wrappers:	%d methods, %uu bytes
    Dedup Pass: Size Saved From Inflated Methods:	%d methods, %uu bytes
    Dedup Pass: Size of Moved But Not Deduped (only 1 copy) Methods:	%d methods, %uu bytes
 %s.dedup    Could not create cache at %s because of error: %s
  cont    fileLength > 0  fileLength >= offset    astate  dedup-inflate   Error: mono was not given an assembly with the provided inflate name
   clang++ The 'direct-extern-calls' option requires the 'llvm' and 'static' options.
 a+  Unable to create file '%s': %s
 --aot=llvmonly requires a runtime compiled with llvm support.
  --aot=llvm requires a runtime compiled with llvm support.
  Mono Ahead of Time compiler - compiling assembly %s
    AOTID %s
   The 'direct-pinvoke' AOT option also requires the 'static' AOT option.
 The soft-debug AOT option requires the --debug option.
 The 'soft-debug' option is not supported when compiling with LLVM.
     Compiling with LLVM and the asm-only option requires the llvm-outfile= option.
 Unable to create logfile: '%s'.
    mono_aot_%s %s_plt  %s_got  %s_llvm_got %s_eh_frame , LLVM: %d (%d%%)       Code: %d(%d%%) Info: %d(%d%%) Ex Info: %d(%d%%) Unwind Info: %d(%d%%) Class Info: %d(%d%%) PLT: %d(%d%%) GOT Info: %d(%d%%) Offsets: %d(%d%%) GOT: %d, BLOB: %d
        Compiled: %d/%d (%d%%)%s, No GOT slots: %d (%d%%), Direct calls: %d (%d%%)
 %d methods failed gsharing (%d%%)
  %d methods contain absolute addresses (%d%%)
   %d methods contain lmf pointers (%d%%)
 %d methods have other problems (%d%%)
  GOT slot distribution:
 	%s: %d (%d)
   GOT SLOTS: %d, INFO SIZE: %d
   
Encoding stats:
   	Method ref: %d (%dk)
  	Class ref: %d (%dk)
   	Ginst: %d (%dk)
   
Method stats:
 	Normal:    %d
 	Instance:  %d
 	GSharedvt: %d
 	Wrapper:   %d
 acfg->aot_opts.llvm_only && acfg->aot_opts.asm_only && acfg->aot_opts.llvm_outfile  depfile %s:      %s %s.s    mono_aot_XXXXXX temp    Unable to open file '%s': %s
   %s%sm_%x    The dwarf AOT option requires the --debug option.
  
.section	.note.GNU-stack,"",@progbits
 Compiled: %d/%d
        JIT time: %d ms, Generation time: %d ms, Assembly+Link time: %d ms.
    rm -r %s    index < amodule->image_table_len    C:\build\output\Unity-Technologies\mono\mono\mini\aot-runtime.c AOT: module %s wants to load image %d: %s   Image out of date: %s   AOT: module %s is unusable because dependency %s is not found.      module '%s' is unusable because dependency %s is not found (error %d).
 AOT: module %s is unusable (GUID of dependent assembly %s doesn't match (expected '%s', got '%s')).     module '%s' is unusable (GUID of dependent assembly %s doesn't match (expected '%s', got '%s')).    Decoding a null class ref: %s   No image associated with the aot module: %s mono_class_is_gtd (gclass)  type == MONO_TYPE_MVAR  type == MONO_TYPE_VAR   Invalid klass reftype %d: %s    Invalid encoded type %d: %s sig->call_convention == MONO_CALL_VARARG    Unknown AOT wrapper type %d: %s     Error: No managed allocator, but we need one for AOT.
Are you using non-standard GC options?
%s
    Invalid STELEMREF subtype %d: %s    Invalid UNKNOWN wrapper subtype %d: %s  target->wrapper_type == MONO_WRAPPER_MANAGED_TO_MANAGED Invalid CASTCLASS wrapper subtype %d: %s    info->d.runtime_invoke.sig  Invalid METHODREF_ARRAY method type %d: %s  No image found for methodref with target: %s    !(amodule->info.flags & MONO_AOT_FILE_FLAG_LLVM_ONLY)   %s.aotdata  map doesn't match assembly      compiled against runtime version '%s' while this runtime has version '%s'   not compiled with --aot=full    compiled with --aot=full    not compiled with --aot=interp  not compiled with --aot=llvmonly    not compiled with --aot=llvm    not compiled for debugging  compiled with unsupported CPU optimizations compiled against GC %s, while the current runtime uses GC %s.
  not compiled with safepoints    compiled targeting a runtime configured as CODE_EXEC_ONLY   patches init_amodule_got    Found statically linked AOT module '%s'.    AOT: image '%s' not found: %s   %s/mono/aot-cache/%s/%s%s   %s/%s%s Failed to load AOT module '%s' in aot-only mode.
   mono_aot_version    wrong file format version (expected %d got %d)      Failed to load AOT module '%s' while running in aot-only mode: %s.
 AOT: module %s is unusable: %s. info->double_align == align_double  info->long_align == align_int64 info->generic_tramp_num == MONO_TRAMPOLINE_NUM  info->card_table_shift_bits == card_table_shift_bits    info->card_table_mask == GPOINTER_TO_UINT (card_table_mask) System.Private.CoreLib  specific_trampolines_page   AOT: Module %s is unusable because a dependency is out-of-date. Failed to load AOT module '%s' while running in aot-only mode because a dependency cannot be found or it is out of date.
   AOT: image '%s' found.  info->version == MONO_AOT_FILE_VERSION  !container_assm_name    Async JIT info size MONO_LASTAOT    %s.exe  assm    decode_cached_class_info    *code_end > *code_start amodule->mono_eh_frame  version == 3    amodule->mono_eh_frame && code  table [(pos * 2)] != -1 table [(pos + 1) * 2] != -1 code >= code_start && code < code_end   jinfo_unwind    clause_index < num_clauses  nindex == ei_len + nested_len   unwind_info < (1 << 30) !async  jinfo->has_try_block_holes  jinfo->has_arch_eh_info jinfo->has_generic_jit_info amodule ji->from_aot    ji_to_amodule   amodule_contains_code_addr (amodule, code)  methods [i] <= methods [i + 1]  addr >= methods [pos]   addr < methods [pos + 1]        (guint8*)code <= (guint8*)addr && (guint8*)addr < (guint8*)code + code_len  pos < table_len AOT runtime could not load method due to %s (guint8*)addr >= (guint8*)jinfo->code_start decode_patch    AOT Runtime could not load method due to %s ji->data.method info->sig   unhandled type %d   AOT: NOT FOUND: %s. NON AOT METHOD: %s.
    NON AOT METHOD: %p %d
  LAST AOT METHOD: %s.
   LAST AOT METHOD: %p %d
 AOT: FOUND method %s [%p - %p %p]   index < code_amodule->info.nmethods method_index == encoded_method_index    got m_class_is_inited (klass)   mono_aot_get_method AOT NOT FOUND: %s.  plt_entry   load_function_full      * Assertion at %s:%d, condition `%s' not met, function:%s, Symbol '%s' not found in AOT file '%s'.

    AOT: FOUND function '%s' in AOT file