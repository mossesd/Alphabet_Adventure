odulePCTable[i].Start) 	NEW_FUNC[%zd/%zd]:  %p %F %L %p uintptr_t fuzzer::TracePC::PCTableEntryIdx(const fuzzer::TracePC::PCTableEntry *) 0 void fuzzer::TracePC::SetFocusFunction(const std::string &) !FocusFunctionCounterPtr %F INFO: Focus function is set to '%s'
 INFO: __sanitizer_symbolize_pc or __sanitizer_get_module_and_offset_for_pc is not available, not printing coverage
 COVERAGE:
  is no longer supported by libFuzzer.
Please either migrate to a compiler that supports -fsanitize=fuzzer
or use an older version of libFuzzer
 -fsanitize-coverage=trace-pc-guard -fsanitize-coverage=trace-pc 	NEW_PC: %p %F %L 	NEW_PC: %p /buildbot/src/android/llvm-r365631/toolchain/llvm-project/compiler-rt/lib/fuzzer/FuzzerTracePC.h size_t fuzzer::TracePC::Module::Idx(uint8_t *) P >= Start() && P < Stop() void fuzzer::TracePC::IterateCoveredFunctions(CallBack) [CallBack = (lambda at /buildbot/src/android/llvm-r365631/toolchain/llvm-project/compiler-rt/lib/fuzzer/FuzzerTracePC.cpp:313:34)] M.Start < M.Stop PcIsFuncEntry(FE) && "Not a function entry point"  auto fuzzer::TracePC::PrintCoverage()::(anonymous class)::operator()(const fuzzer::TracePC::PCTableEntry *, const fuzzer::TracePC::PCTableEntry *, uintptr_t) const First < Last %s in  %l %sCOVERED_FUNC: hits: %zd UN  edges: %zd/%zd  %s %s:%s
   UNCOVERED_PC: %s
 %s:%l /buildbot/src/android/llvm-r365631/toolchain/llvm-project/compiler-rt/lib/fuzzer/FuzzerDictionary.h void fuzzer::FixedWord<64>::Set(const uint8_t *, uint8_t) [kMaxSizeT = 64] S <= kMaxSize                                         Android (6454773 based on r365631c2) clang version 9.0.8 (https://android.googlesource.com/toolchain/llvm-project 98c855489587874b2a325e7a516b99d838599c6f) (based on LLVM 9.0.8svn) /toolchain/llvm-project/compiler-rt/lib/fuzzer/FuzzerTracePC.cpp /out/lib/libfuzzer-aarch64-ndk-cxx FixedWord Pair TableOfRecentCompares MemMemTable __compressed_pair_elem<int, void> __compressed_pair<int, const std::__ndk1::less<const fuzzer::TracePC::PCTableEntry *> &> __tree set __get first __end_node __compressed_pair<int, true> __hash_table unordered_map __compressed_pair_elem<float, void> __compressed_pair<float, true> ~__hash_table ~unordered_map __deallocate_node __do_call __do_deallocate_handle_size __do_deallocate_handle_size_align __libcpp_deallocate deallocate reset ~unique_ptr operator() __root ~__tree ~set size Start RoundUpByPage RoundDownByPage Stop Size IterateCounterRegions<(lambda at /toolchain/llvm-project/compiler-rt/lib/fuzzer/FuzzerTracePC.cpp:79:25)> IterateCounterRegions<(lambda at /toolchain/llvm-project/compiler-rt/lib/fuzzer/FuzzerTracePC.cpp:98:25)> AddValueModPrime AddValue __compressed_pair_elem<nullptr_t, void> __compressed_pair<nullptr_t, true> __vector_base vector __find_equal<const fuzzer::TracePC::PCTableEntry *> __emplace_unique_key_args<const fuzzer::TracePC::PCTableEntry *, const fuzzer::TracePC::PCTableEntry *const &> __insert_unique insert operator[] Idx __libcpp_allocate allocate __construct_node<const fuzzer::TracePC::PCTableEntry *const &> construct<const fuzzer::TracePC::PCTableEntry *, const fuzzer::TracePC::PCTableEntry *const &> __construct<const fuzzer::TracePC::PCTableEntry *, const fuzzer::TracePC::PCTableEntry *const &> __insert_node_at push_back construct<unsigned long, const unsigned long &> __construct<unsigned long, const unsigned long &> GetNextInstructionPc Min<unsigned long> ~__vector_base ~vector __destruct_at_end clear __is_long empty __get_pointer data operator==<std::__ndk1::allocator<char> > operator!=<char, std::__ndk1::char_traits<char>, std::__ndk1::allocator<char> > __get_short_pointer __init basic_string substr PcIsFuncEntry __compressed_pair_elem __compressed_pair<const std::__ndk1::allocator<char> &> __set_short_size copy assign __clear_and_shrink __move_assign operator= __align_it<16> __recommend __set_long_cap __set_long_pointer __get_long_pointer __set_long_size compare ~basic_string c_str IterateCoveredFunctions<(lambda at /toolchain/llvm-project/compiler-rt/lib/fuzzer/FuzzerTracePC.cpp:313:34)> GetModuleName find length __search_substring<char, std::__ndk1::char_traits<char> > __str_find<char, unsigned long, std::__ndk1::char_traits<char>, 18446744073709551615> __count_unique<const fuzzer::TracePC::PCTableEntry *> count __push_back_slow_path<const unsigned long &> capacity __split_buffer __construct_backward<unsigned long *> __swap_out_circular_buffer construct<unsigned long, unsigned long> __construct<unsigned long, unsigned long> swap<unsigned long *> ~__split_buffer operator++ Popcountll Set Insert IterateCounterRegions<(lambda at /toolchain/llvm-project/compiler-rt/lib/fuzzer/FuzzerTracePC.cpp:416:25)> HandlePCsInit HandleCallerCallee HandleCmp<unsigned long> Clzll HandleCmp<unsigned int> HandleCmp<unsigned short> HandleCmp<unsigned char> InternalStrnlen InternalStrnlen2 __sanitizer_weak_hook_strncmp __sanitizer_weak_hook_strcmp Add bucket_count __constrain_hash __hash __construct_node_hash<const std::__ndk1::piecewise_construct_t &, std::__ndk1::tuple<const unsigned long &>, std::__ndk1::tuple<> > construct<std::__ndk1::pair<const unsigned long, unsigned long>, const std::__ndk1::piecewise_construct_t &, std::__ndk1::tuple<const unsigned long &>, std::__ndk1::tuple<> > __construct<std::__ndk1::pair<const unsigned long, unsigned long>, const std::__ndk1::piecewise_construct_t &, std::__ndk1::tuple<const unsigned long &>, std::__ndk1::tuple<> > pair<const unsigned long &, 0> pair<const unsigned long &> __is_hash_power2 ceil __next_hash_pow2 __clz reset<std::__ndk1::__hash_node_base<std::__ndk1::__hash_node<std::__ndk1::__hash_value_type<unsigned long, unsigned long>, void *> *> **> __throw_length_error __parent_unsafe __tree_is_left_child<std::__ndk1::__tree_node_base<void *> *> __tree_left_rotate<std::__ndk1::__tree_node_base<void *> *> __set_parent __tree_right_rotate<std::__ndk1::__tree_node_base<void *> *> __cxx_global_var_init TracePC ~TracePC GetTotalPCCoverage HandleInline8bitCountersInit ProtectLazyCounters UnprotectLazyCounters PrintModuleInfo UpdateObservedPCs SetFocusFunction PrintCoverage AddValueForMemcmp ClearInlineCounters __sanitizer_cov_pcs_init __sanitizer_cov_trace_pc_indir __sanitizer_cov_trace_cmp8 __sanitizer_cov_trace_const_cmp8 __sanitizer_cov_trace_cmp4 __sanitizer_cov_trace_const_cmp4 __sanitizer_cov_trace_cmp2 __sanitizer_cov_trace_const_cmp2 __sanitizer_cov_trace_cmp1 __sanitizer_cov_trace_const_cmp1 __sanitizer_cov_trace_switch __sanitizer_cov_trace_div4 __sanitizer_cov_trace_div8 __sanitizer_cov_trace_gep __sanitizer_weak_hook_strncasecmp __sanitizer_weak_hook_strcasecmp __sanitizer_weak_hook_strstr __sanitizer_weak_hook_strcasestr __sanitizer_weak_hook_memmem destroy __emplace_unique_key_args<unsigned long, const std::__ndk1::piecewise_construct_t &, std::__ndk1::tuple<const unsigned long &>, std::__ndk1::tuple<> > rehash __rehash __tree_balance_after_insert<std::__ndk1::__tree_node_base<void *> *> %U  .   .  1UXY   1UXY   1XY  1UXY   1UXY  	1XY  
 1XY  1XY  .1  .   a-                                                                                                            �      4       F/       *       !*       !  9       F*              1*              1 M       FH       �C       �>       � 	\              �	W              
R              �    k       Ff       �	a              �
>              � 	u              �
p              �                                                                                p       �          4   F	�          4   J	�             	�             B	�             	�             	�             F�             �
�                   	�             	�             G	             	             *	�             	�             	�             F�             �
�                                    F      �
             2                      �             	"                             H                   	)             	.             	/      	@      �             �                  ,      �          �   	O�      �                  0      �          �   	b�      �          �            	{      �             �                  `   �  B          @   	�G          (   ,                                                                                                                                                                  T      �             	�	�             �	�             �
�             �   �      	��      	��      	��      ��      ��      g      �	�             4	�             
�             �   �      � 	�             m	�             �	�             
�               	�             �	�             
�             �   �      q                	� �      	��      	�	             a	             
             �          	�      �             � �      	�             �             �              	�             	�      	�              	�             	�*             	�	%             ,	4             �
/             r 	>             �	9             	�             	�             F�             �
�                                                                                                                                                                             x      	�	             		�	             �
�	             �  �	      	$�	      A�	      �	      � �	      �	      � �	      
�	             � �	      �	      � 
t
               �	      	"�	      ��	      �  
      	#
      �
      �
�	             �

             �$
      )
      	G
             
B
              Q
      L
      �        V
      
[
              �	      �
      �
      �         	&
      	 
             	!=
      	#8
      	3
      �.
      �

             

�	             
`
             
)
             
e
              
�	             �
`
             �	o
             �	j
             	�             	�             F�             �
�                  
V
             �   y
      	(�	      Z
`
             [	o
             [	j
             	�             	�             F�             �
�                   ~
      	%�	      ��	      ��	      �                                                                                                                    �      �      	T�      	�      	
      6
�	             �

             �$
      	G
             
B
              Q
      L
      �        V
      
[
              
�             6 �      	
�             6
      6

             �$
      	G
             
B
              Q
      L
      �        V
      
[
                �      	�      	�      	B�	      /�	      ��	      �  �      /		          T   .	          T   
             t
         
      	C
      �
      �
�	             �

             �$
      )
      	G
             
B
              Q
      L
      �        V
      
[
              �	      �
�	             � 
      �
      � �	      ��	      �   ~
      	L�	      ��	      �
�	             �   ~
      	Q�	      ��	      �
�	             �   
             	==
      	C8
      	3
      �.
      �

             

�	             
`
             
)
             
e
              
�	             �
`
             �	o
             �	j
             	�             	�             F�             �
�                  
V
             �         	H      
�             @
  �      	I	             a	             
             �        g
             R	"          $   R	,             �
'             �  1      R;      76      
�                      T            �  E      V@      �T      �O      J      �   
Y             � 	^             W	>             W	9             	�             	�             F�             �
�                     
             	K~
      	L�	      ��	      �
�	             �   ~
      	M�	      ��	      �
�	             �   
c             	O
             	Q	y
             	P
�	             Z
`
             [	o
             [	j
             	�             	�             F�             �
�                   	*             	R	%             ,	>             �	9             	�             	�             F�             �
�                    	y
             	R
�	             Z
`
             [	o
             [	j
             	�             	�             F�             �
�                   	y
             	R
�	             Z
`
             [	o
             [	j
             	�             	�             F�             �
�                   	y
             	R
�	             Z
`
             [	o
             [	j
             	�             	�             F�             �
�                    	y
             	
�	             Z
`
             [	o
             [	j
             	�             	�             F�             �
�                                             �      
�             	wG      	~�      	�       �      	�       �      	                 �       	\          �   	�a      �              �       �      	�             h       	�          `   	�B          H   	�G          0   ,                       �       	          �   	�      	��      	�
             	�G      	�G      	�          �       	          �   	�      	��      	�
             	�G      	�G      	�                  �       	�          �   	��      	��      	�
             	�G      	�G      	�          �       	�          �   	�      	��      	�
             	�G      	�G      	�              �       	�          �   	�      	�
             	�G      	�G      	�          �       	�          �   	�      	�
             	�G      	�G      	�              �       	�          �   	�      	�
             	�G      	�G      	�          �       	�          �   	%�      	�
             	�G      	�G      	�          p      �      	H�      	�
             	�G      	�G      	�       	R�      	�      	�
             	�G      	�G      	� �      	M�      	��      	�
             	�G      	�G      	� �      	J�      	� �      	O�      	��      	�       	S      	��      	�
             	�
G          $   	�          �       	�          �   	\�      	�G      	��      	�G      	�          �       	          �   	d�      	�      	�G      	�G      	�          �       	          �   	l�      	�      	�G      	�G      	�              �   D#  
�"             	}
�"              	~             t   �#  !#      	�             �       D#      	�
�"             	}
�"              	~              t       �#      	�!#      	�              �       �#      	��      :          �       �#      	��      :          �       �#      	��      :                  @       	H$             ?	C$             	�             	�             F�             �
�                                                                                                   `      	�$             9
�$             � 
�$             8�$      ?�$      @�$      G�$       �$      D
�$             D	%             N%      �	%      �        %      �	%      %      �&%      "!%      �     �$      Z
+%             T
0%             U	�$             V
�$             � �$      W
�$             c�$      c
�$             c                       �$      L	�$      � 0%              	�&             T	�&             ~                              0      b'      e	]'      
�             
q'               	g'             d		             w	             *	�             	�             	�             F�             �
�                    
�$             j	�$      o	
�$             o	�$      p		g'             d		             w	             *	�             	�             	�             F�             �
�                    �$      u	�$      u	�$      z	l'      �	�$      � �$      �	�$      �	         �     
             R	"          0   R	,             �
'             �  1      R;      76