#ifndef DO_API_NO_RETURN
#define DO_API_NO_RETURN(r, n, p) DO_API(r,n,p)
#endif

DO_API(int, il2cpp_init, (const char* domain_name));
DO_API(int, il2cpp_init_utf16, (const Il2CppChar * domain_name));
DO_API(void, il2cpp_shutdown, ());
DO_API(void, il2cpp_set_config_dir, (const char *config_path));
DO_API(void, il2cpp_set_data_dir, (const char *data_path));
DO_API(void, il2cpp_set_temp_dir, (const char *temp_path));
DO_API(void, il2cpp_set_commandline_arguments, (int argc, const char* const argv[], const char* basedir));
DO_API(void, il2cpp_set_commandline_arguments_utf16, (int argc, const Il2CppChar * const argv[], const char* basedir));
DO_API(void, il2cpp_set_config_utf16, (const Il2CppChar * executablePath));
DO_API(void, il2cpp_set_config, (const char* executablePath));

DO_API(void, il2cpp_set_memory_callbacks, (Il2CppMemoryCallbacks * callbacks));
DO_API(const Il2CppImage*, il2cpp_get_corlib, ());
DO_API(void, il2cpp_add_internal_call, (const char* name, Il2CppMethodPointer method));
DO_API(Il2CppMethodPointer, il2cpp_resolve_icall, (const char* name));

DO_API(void*, il2cpp_alloc, (size_t size));
DO_API(void, il2cpp_free, (void* ptr));

// array
DO_API(Il2CppClass*, il2cpp_array_class_get, (Il2CppClass * element_class, uint32_t rank));
DO_API(uint32_t, il2cpp_array_length, (Il2CppArray * array));
DO_API(uint32_t, il2cpp_array_get_byte_length, (Il2CppArray * array));
DO_API(Il2CppArray*, il2cpp_array_new, (Il2CppClass * elementTypeInfo, il2cpp_array_size_t length));
DO_API(Il2CppArray*, il2cpp_array_new_specific, (Il2CppClass * arrayTypeInfo, il2cpp_array_size_t length));
DO_API(Il2CppArray*, il2cpp_array_new_full, (Il2CppClass * array_class, il2cpp_array_size_t * lengths, il2cpp_array_size_t * lower_bounds));
DO_API(Il2CppClass*, il2cpp_bounded_array_class_get, (Il2CppClass * element_class, uint32_t rank, bool bounded));
DO_API(int, il2cpp_array_element_size, (const Il2CppClass * array_class));

// assembly
DO_API(const Il2CppImage*, il2cpp_assembly_get_image, (const Il2CppAssembly * assembly));

// class
DO_API(void, il2cpp_class_for_each, (void(*klassReportFunc)(Il2CppClass* klass, void* userData), void* userData));
DO_API(const Il2CppType*, il2cpp_class_enum_basetype, (Il2CppClass * klass));
DO_API(bool, il2cpp_class_is_generic, (const Il2CppClass * klass));
DO_API(bool, il2cpp_class_is_inflated, (const Il2CppClass * klass));
DO_API(bool, il2cpp_class_is_assignable_from, (Il2CppClass * klass, Il2CppClass * oklass));
DO_API(bool, il2cpp_class_is_subclass_of, (Il2CppClass * klass, Il2CppClass * klassc, bool check_interfaces));
DO_API(bool, il2cpp_class_has_parent, (Il2CppClass * klass, Il2CppClass * klassc));
DO_API(Il2CppClass*, il2cpp_class_from_il2cpp_type, (const Il2CppType * type));
DO_API(Il2CppClass*, il2cpp_class_from_name, (const Il2CppImage * image, const char* namespaze, const char *name));
DO_API(Il2CppClass*, il2cpp_class_from_system_type, (Il2CppReflectionType * type));
DO_API(Il2CppClass*, il2cpp_class_get_element_class, (Il2CppClass * klass));
DO_API(const EventInfo*, il2cpp_class_get_events, (Il2CppClass * klass, void* *iter));
DO_API(FieldInfo*, il2cpp_class_get_fields, (Il2CppClass * klass, void* *iter));
DO_API(Il2CppClass*, il2cpp_class_get_nested_types, (Il2CppClass * klass, void* *iter));
DO_API(Il2CppClass*, il2cpp_class_get_interfaces, (Il2CppClass * klass, void* *iter));
DO_API(const PropertyInfo*, il2cpp_class_get_properties, (Il2CppClass * klass, void* *iter));
DO_API(const PropertyInfo*, il2cpp_class_get_property_from_name, (Il2CppClass * klass, const char *name));
DO_API(FieldInfo*, il2cpp_class_get_field_from_name, (Il2CppClass * klass, const char *name));
DO_API(const MethodInfo*, il2cpp_class_get_methods, (Il2CppClass * klass, void* *iter));
DO_API(const MethodInfo*, il2cpp_class_get_method_from_name, (Il2CppClass * klass, const char* name, int argsCount));
DO_API(const char*, il2cpp_class_get_name, (Il2CppClass * klass));
DO_API(void, il2cpp_type_get_name_chunked, (const Il2CppType * type, void(*chunkReportFunc)(void* data, void* userData), void* userData));
DO_API(const char*, il2cpp_class_get_namespace, (Il2CppClass * klass));
DO_API(Il2CppClass*, il2cpp_class_get_parent, (Il2CppClass * klass));
DO_API(Il2CppClass*, il2cpp_class_get_declaring_type, (Il2CppClass * klass));
DO_API(int32_t, il2cpp_class_instance_size, (Il2CppClass * klass));
DO_API(size_t, il2cpp_class_num_fields, (const Il2CppClass * enumKlass));
DO_API(bool, il2cpp_class_is_valuetype, (const Il2CppClass * klass));
DO_API(int32_t, il2cpp_class_value_size, (Il2CppClass * klass, uint32_t * align));
DO_API(bool, il2cpp_class_is_blittable, (const Il2CppClass * klass));
DO_API(int, il2cpp_class_get_flags, (const Il2CppClass * klass));
DO_API(bool, il2cpp_class_is_abstract, (const Il2CppClass * klass));
DO_API(bool, il2cpp_class_is_interface, (const Il2CppClass * klass));
DO_API(int, il2cpp_class_array_element_size, (const Il2CppClass * klass));
DO_API(Il2CppClass*, il2cpp_class_from_type, (const Il2CppType * type));
DO_API(const Il2CppType*, il2cpp_class_get_type, (Il2CppClass * klass));
DO_API(uint32_t, il2cpp_class_get_type_token, (Il2CppClass * klass));
DO_API(bool, il2cpp_class_has_attribute, (Il2CppClass * klass, Il2CppClass * attr_class));
DO_API(bool, il2cpp_class_has_references, (Il2CppClass * klass));
DO_API(bool, il2cpp_class_is_enum, (const Il2CppClass * klass));
DO_API(const Il2CppImage*, il2cpp_class_get_image, (Il2CppClass * klass));
DO_API(const char*, il2cpp_class_get_assemblyname, (const Il2CppClass * klass));
DO_API(int, il2cpp_class_get_rank, (const Il2CppClass * klass));
DO_API(uint32_t, il2cpp_class_get_data_size, (const Il2CppClass * klass));
DO_API(void*, il2cpp_class_get_static_field_data, (const Il2CppClass * klass));

// testing only
DO_API(size_t, il2cpp_class_get_bitmap_size, (const Il2CppClass * klass));
DO_API(void, il2cpp_class_get_bitmap, (Il2CppClass * klass, size_t * bitmap));

// stats
DO_API(bool, il2cpp_stats_dump_to_file, (const char *path));
DO_API(uint64_t, il2cpp_stats_get_value, (Il2CppStat stat));

// domain
DO_API(Il2CppDomain*, il2cpp_domain_get, ());
DO_API(const Il2CppAssembly*, il2cpp_domain_assembly_open, (Il2CppDomain * domain, const char* name));
DO_API(const Il2CppAssembly**, il2cpp_domain_get_assemblies, (const Il2CppDomain * domain, size_t * size));

// exception
DO_API_NO_RETURN(void, il2cpp_raise_exception, (Il2CppException*));
DO_API(Il2CppException*, il2cpp_exception_from_name_msg, (const Il2CppImage * image, const char *name_space, const char *name, const char *msg));
DO_API(Il2CppException*, il2cpp_get_exception_argument_null, (const char *arg));
DO_API(void, il2cpp_format_exception, (const Il2CppException * ex, char* message, int message_size));
DO_API(void, il2cpp_format_stack_trace, (const Il2CppException * ex, char* output, int output_size));
DO_API(void, il2cpp_unhandled_exception, (Il2CppException*));
DO_API(void, il2cpp_native_stack_trace, (const Il2CppException * ex, uintptr_t** addresses, int* numFrames, char** imageUUID, char** imageName));

// field
DO_API(int, il2cpp_field_get_flags, (FieldInfo * field));
DO_API(const char*, il2cpp_field_get_name, (FieldInfo * field));
DO_API(Il2CppClass*, il2cpp_field_get_parent, (FieldInfo * field));
DO_API(size_t, il2cpp_field_get_offset, (FieldInfo * field));
DO_API(const Il2CppType*, il2cpp_field_get_type, (FieldInfo * field));
DO_API(void, il2cpp_field_get_value, (Il2CppObject * obj, FieldInfo * field, void *value));
DO_API(Il2CppObject*, il2cpp_field_get_value_object, (FieldInfo * field, Il2CppObject * obj));
DO_API(bool, il2cpp_field_has_attribute, (FieldInfo * field, Il2CppClass * attr_class));
DO_API(void, il2cpp_field_set_value, (Il2CppObject * obj, FieldInfo * field, void *value));
DO_API(void, il2cpp_field_static_get_value, (FieldInfo * field, void *value));
DO_API(void, il2cpp_field_static_set_value, (FieldInfo * field, void *value));
DO_API(void, il2cpp_field_set_value_object, (Il2CppObject * instance, FieldInfo * field, Il2CppObject * value));
DO_API(bool, il2cpp_field_is_literal, (FieldInfo * field));
// gc
DO_API(void, il2cpp_gc_collect, (int maxGenerations));
DO_API(int32_t, il2cpp_gc_collect_a_little, ());
DO_API(void, il2cpp_gc_start_incremental_collection , ());
DO_API(void, il2cpp_gc_disable, ());
DO_API(void, il2cpp_gc_enable, ());
DO_API(bool, il2cpp_gc_is_disabled, ());
DO_API(void, il2cpp_gc_set_mode, (Il2CppGCMode mode));
DO_API(int64_t, il2cpp_gc_get_max_time_slice_ns, ());
DO_API(void, il2cpp_gc_set_max_time_slice_ns, (int64_t maxTimeSlice));
DO_API(bool, il2cpp_gc_is_incremental, ());
DO_API(int64_t, il2cpp_gc_get_used_size, ());
DO_API(int64_t, il2cpp_gc_get_heap_size, ());
DO_API(void, il2cpp_gc_wbarrier_set_field, (Il2CppObject * obj, void **targetAddress, void *object));
DO_API(bool, il2cpp_gc_has_strict_wbarriers, ());
DO_API(void, il2cpp_gc_set_external_allocation_tracker, (void(*func)(void*, size_t, int)));
DO_API(void, il2cpp_gc_set_external_wbarrier_tracker, (void(*func)(void**)));
DO_API(void, il2cpp_gc_foreach_heap, (void(*func)(void* data, void* userData), void* userData));
DO_API(void, il2cpp_stop_gc_world, ());
DO_API(void, il2cpp_start_gc_world, ());
DO_API(void*, il2cpp_gc_alloc_fixed, (size_t size));
DO_API(void, il2cpp_gc_free_fixed, (void* address));
// gchandle
DO_API(uint32_t, il2cpp_gchandle_new, (Il2CppObject * obj, bool pinned));
DO_API(uint32_t, il2cpp_gchandle_new_weakref, (Il2CppObject * obj, bool track_resurrection));
DO_API(Il2CppObject*, il2cpp_gchandle_get_target , (uint32_t gchandle));
DO_API(void, il2cpp_gchandle_free, (uint32_t gchandle));
DO_API(void , il2cpp_gchandle_foreach_get_target, (void(*func)(void* data, void* userData), void* userData));

// vm runtime info
DO_API(uint32_t, il2cpp_object_header_size, ());
DO_API(uint32_t, il2cpp_array_object_header_size, ());
DO_API(uint32_t, il2cpp_offset_of_array_length_in_array_object_header, ());
DO_API(uint32_t, il2cpp_offset_of_array_bounds_in_array_object_header, ());
DO_API(uint32_t, il2cpp_allocation_granularity, ());

// liveness
DO_API(void*, il2cpp_unity_liveness_allocate_struct, (Il2CppClass * filter, int max_object_count, il2cpp_register_object_callback callback, void* userdata, il2cpp_liveness_reallocate_callback reallocate));
DO_API(void, il2cpp_unity_liveness_calculation_from_root, (Il2CppObject * root, void* state));
DO_API(void, il2cpp_unity_liveness_calculation_from_statics, (void* state));
DO_API(void, il2cpp_unity_liveness_finalize, (void* state));
DO_API(void, il2cpp_unity_liveness_free_struct, (void* state));

// method
DO_API(const Il2CppType*, il2cpp_method_get_return_type, (const MethodInfo * method));
DO_API(Il2CppClass*, il2cpp_method_get_declaring_type, (const MethodInfo * method));
DO_API(const char*, il2cpp_method_get_name, (const MethodInfo * method));
DO_API(const MethodInfo*, il2cpp_method_get_from_reflection, (const Il2CppReflectionMethod * method));
DO_API(Il2CppReflectionMethod*, il2cpp_method_get_object, (const MethodInfo * method, Il2CppClass * refclass));
DO_API(bool, il2cpp_method_is_generic, (const MethodInfo * method));
DO_API(bool, il2cpp_method_is_inflated, (const MethodInfo * method));
DO_API(bool, il2cpp_method_is_instance, (const MethodInfo * method));
DO_API(uint32_t, il2cpp_method_get_param_count, (const MethodInfo * method));
DO_API(const Il2CppType*, il2cpp_method_get_param, (const MethodInfo * method, uint32_t index));
DO_API(Il2CppClass*, il2cpp_method_get_class, (const MethodInfo * method));
DO_API(bool, il2cpp_method_has_attribute, (const MethodInfo * method, Il2CppClass * attr_class));
DO_API(uint32_t, il2cpp_method_get_flags, (const MethodInfo * method, uint32_t * iflags));
DO_API(uint32_t, il2cpp_method_get_token, (const MethodInfo * method));
DO_API(const char*, il2cpp_method_get_param_name, (const MethodInfo * method, uint32_t index));

// profiler
#if IL2CPP_ENABLE_PROFILER

DO_API(void, il2cpp_profiler_install, (Il2CppProfiler * prof, Il2CppProfileFunc shutdown_callback));
DO_API(void, il2cpp_profiler_set_events, (Il2CppProfileFlags events));
DO_API(void, il2cpp_profiler_install_enter_leave, (Il2CppProfileMethodFunc enter, Il2CppProfileMethodFunc fleave));
DO_API(void, il2cpp_profiler_install_allocation, (Il2CppProfileAllocFunc callback));
DO_API(void, il2cpp_profiler_install_gc, (Il2CppProfileGCFunc callback, Il2CppProfileGCResizeFunc heap_resize_callback));
DO_API(void, il2cpp_profiler_install_fileio, (Il2CppProfileFileIOFunc callback));
DO_API(void, il2cpp_profiler_install_thread, (Il2CppProfileThreadFunc start, Il2CppProfileThreadFunc end));

#endif

// property
DO_API(uint32_t, il2cpp_property_get_flags, (PropertyInfo * prop));
DO_API(const MethodInfo*, il2cpp_property_get_get_method, (PropertyInfo * prop));
DO_API(const MethodInfo*, il2cpp_property_get_set_method, (PropertyInfo * prop));
DO_API(const char*, il2cpp_property_get_name, (PropertyInfo * prop));
DO_API(Il2CppClass*, il2cpp_property_get_parent, (PropertyInfo * prop));

// object
DO_API(Il2CppClass*, il2cpp_object_get_class, (Il2CppObject * obj));
DO_API(uint32_t, il2cpp_object_get_size, (Il2CppObject * obj));
DO_API(const MethodInfo*, il2cpp_object_get_virtual_method, (Il2CppObject * obj, const MethodInfo * method));
DO_API(Il2CppObject*, il2cpp_object_new, (const Il2CppClass * klass));
DO_API(void*, il2cpp_object_unbox, (Il2CppObject * obj));

DO_API(Il2CppObject*, il2cpp_value_box, (Il2CppClass * klass, void* data));

// monitor
DO_API(void, il2cpp_monitor_enter, (Il2CppObject * obj));
DO_API(bool, il2cpp_monitor_try_enter, (Il2CppObject * obj, uint32_t timeout));
DO_API(void, il2cpp_monitor_exit, (Il2CppObject * obj));
DO_API(void, il2cpp_monitor_pulse, (Il2CppObject * obj));
DO_API(void, il2cpp_monitor_pulse_all, (Il2CppObject * obj));
DO_API(void, il2cpp_monitor_wait, (Il2CppObject * obj));
DO_API(bool, il2cpp_monitor_try_wait, (Il2CppObject * obj, uint32_t timeout));

// runtime
DO_API(Il2CppObject*, il2cpp_runtime_invoke, (const MethodInfo * method, void *obj, void **params, Il2CppException **exc));
DO_API(Il2CppObject*, il2cpp_runtime_invoke_convert_args, (const MethodInfo * method, void *obj, Il2CppObject **params, int paramCount, Il2CppException **exc));
DO_API(void, il2cpp_runtime_class_init, (Il2CppClass * klass));
DO_API(void, il2cpp_runtime_object_init, (Il2CppObject * obj));

DO_API(void, il2cpp_runtime_object_init_exception, (Il2CppObject * obj, Il2CppException** exc));

DO_API(void, il2cpp_runtime_unhandled_exception_policy_set, (Il2CppRuntimeUnhandledExceptionPolicy value));

// string
DO_API(int32_t, il2cpp_string_length, (Il2CppString * str));
DO_API(Il2CppChar*, il2cpp_string_chars, (Il2CppString * str));
DO_API(Il2CppString*, il2cpp_string_new, (const char* str));
DO_API(Il2CppString*, il2cpp_string_new_len, (const char* str, uint32_t length));
DO_API(Il2CppString*, il2cpp_string_new_utf16, (const Il2CppChar * text, int32_t len));
DO_API(Il2CppString*, il2cpp_string_new_wrapper, (const char* str));
DO_API(Il2CppString*, il2cpp_string_intern, (Il2CppString * str));
DO_API(Il2CppString*, il2cpp_string_is_interned, (Il2CppString * str));

// thread
DO_API(Il2CppThread*, il2cpp_thread_current, ());
DO_API(Il2CppThread*, il2cpp_thread_attach, (Il2CppDomain * domain));
DO_API(void, il2cpp_thread_detach, (Il2CppThread * thread));

DO_API(Il2CppThread**, il2cpp_thread_get_all_attached_threads, (size_t * size));
DO_API(bool, il2cpp_is_vm_thread, (Il2CppThread * thread));

// stacktrace
DO_API(void, il2cpp_current_thread_walk_frame_stack, (Il2CppFrameWalkFunc func, void* user_data));
DO_API(void, il2cpp_thread_walk_frame_stack, (Il2CppThread * thread, Il2CppFrameWalkFunc func, void* user_data));
DO_API(bool, il2cpp_current_thread_get_top_frame, (Il2CppStackFrameInfo * frame));
DO_API(bool, il2cpp_thread_get_top_frame, (Il2CppThread * thread, Il2CppStackFrameInfo * frame));
DO_API(bool, il2cpp_current_thread_get_frame_at, (int32_t offset, Il2CppStackFrameInfo * frame));
DO_API(bool, il2cpp_thread_get_frame_at, (Il2CppThread * thread, int32_t offset, Il2CppStackFrameInfo * frame));
DO_API(int32_t, il2cpp_current_thread_get_stack_depth, ());
DO_API(int32_t, il2cpp_thread_get_stack_depth, (Il2CppThread * thread));
DO_API(void, il2cpp_override_stack_backtrace, (Il2CppBacktraceFunc stackBacktraceFunc));

// type
DO_API(Il2CppObject*, il2cpp_type_get_object, (const Il2CppType * type));
DO_API(int, il2cpp_type_get_type, (const Il2CppType * type));
DO_API(Il2CppClass*, il2cpp_type_get_class_or_element_class, (const Il2CppType * type));
DO_API(char*, il2cpp_type_get_name, (const Il2CppType * type));
DO_API(bool, il2cpp_type_is_byref, (const Il2CppType * type));
DO_API(uint32_t, il2cpp_type_get_attrs, (const Il2CppType * type));
DO_API(bool, il2cpp_type_equals, (const Il2CppType * type, const Il2CppType * otherType));
DO_API(char*, il2cpp_type_get_assembly_qualified_name, (const Il2CppType * type));
DO_API(bool, il2cpp_type_is_static, (const Il2CppType * type));
DO_API(bool, il2cpp_type_is_pointer_type, (const Il2CppType * type));

// image
DO_API(const Il2CppAssembly*, il2cpp_image_get_assembly, (const Il2CppImage * image));
DO_API(const char*, il2cpp_image_get_name, (const Il2CppImage * image));
DO_API(const char*, il2cpp_image_get_filename, (const Il2CppImage * image));
DO_API(const MethodInfo*, il2cpp_image_get_entry_point, (const Il2CppImage * image));

DO_API(size_t, il2cpp_image_get_class_count, (const Il2CppImage * image));
DO_API(const Il2CppClass*, il2cpp_image_get_class, (const Il2CppImage * image, size_t index));

// Memory information
DO_API(Il2CppManagedMemorySnapshot*, il2cpp_capture_memory_snapshot, ());
DO_API(void, il2cpp_free_captured_memory_snapshot, (Il2CppManagedMemorySnapshot * snapshot));

DO_API(void, il2cpp_set_find_plugin_callback, (Il2CppSetFindPlugInCallback method));

// Logging
DO_API(void, il2cpp_register_log_callback, (Il2CppLogCallback method));

// Debugger
DO_API(void, il2cpp_debugger_set_agent_options, (const char* options));
DO_API(bool, il2cpp_is_debugger_attached, ());
DO_API(void, il2cpp_register_debugger_agent_transport, (Il2CppDebuggerTransport * debuggerTransport));

// Debug metadata
DO_API(bool, il2cpp_debug_get_method_info, (const MethodInfo*, Il2CppMethodDebugInfo * methodDebugInfo));

// TLS module
DO_API(void, il2cpp_unity_install_unitytls_interface, (const void* unitytlsInterfaceStruct));

// custom attributes
DO_API(Il2CppCustomAttrInfo*, il2cpp_custom_attrs_from_class, (Il2CppClass * klass));
DO_API(Il2CppCustomAttrInfo*, il2cpp_custom_attrs_from_method, (const MethodInfo * method));

DO_API(Il2CppObject*, il2cpp_custom_attrs_get_attr, (Il2CppCustomAttrInfo * ainfo, Il2CppClass * attr_klass));
DO_API(bool, il2cpp_custom_attrs_has_attr, (Il2CppCustomAttrInfo * ainfo, Il2CppClass * attr_klass));
DO_API(Il2CppArray*,  il2cpp_custom_attrs_construct, (Il2CppCustomAttrInfo * cinfo));

DO_API(void, il2cpp_custom_attrs_free, (Il2CppCustomAttrInfo * ainfo));

// Il2CppClass user data for GetComponent optimization
DO_API(void, il2cpp_class_set_userdata, (Il2CppClass * klass, void* userdata));
DO_API(int, il2cpp_class_get_userdata_offset, ());

DO_API(void, il2cpp_set_default_thread_affinity, (int64_t affinity_mask));
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          DCMPA30€×ÕÞ± b#† èg Ú ÀYÍÌ     LeŒ™ÝBpÊçÝ5™È:¯ŒŠZ²eÁ¢FºÑœHD ÑB´ûþ-ãÊá>¬‡sŽ[>¯`´Ó?øãc,Å¸ìós®z^ÃÉ‹`·¡uÂi¥¸MˆšrL”pbÚ4TNÚˆ&}Bä”Úih¯§Ií§åÖ·nî4aßásý†¶º›4yÒò|Çmt‡[mQ†" 	…G`*2Á‚E¨…Ed2‰ˆÞ¢ä6šG
U¤D–-¢X
Å?ÁæçNžÇÁŒæËœ''X 0CÀ@0N»•{3¢ê½ÜP$nÈ8½õœ07fÖ1mv§ãÚˆsSc„3^¼¹qoÖh68™xªŠ˜TÛ¤o”:æ94bÁF¨ÐäæÜì€x3ƒÍ&&šÚ²Ú¢Ô×áÍKÙ;Ò‘©çbwØ§~¢#ä=Êì¹H$%ã]E½®=•–êD@Ý¼,ÿÏ0B ¸4­ÖíúFÌ™Ú‘õ'ÿä=ÀNÇøº#òøR!Þ×îìÖKÉb$\òß~‘+RËä½ŽÜTˆ"Í¨:¾vfT4ä:µ›Ö(ÿÉöˆxúOvîùvR²ÈïÕXöªÇJ¥ˆexS¡bÁvE÷Gìª	ù|u´»–%®Òº£I„6ƒ©Žœ?µ!çOþÉ+ÌLªóB‚r©”ìyÊ\Â|— ãáqtÜ—hX !mrKWœ‡¬8’.-Ô]†Óêf*;gæ!ìèr¹À³7.Ç¸ÌžžxÇpzqÄËPæâøûÏ<ßü?ùáîÃB’­£˜Œñ%ÎÚÅ'ð(h^¢×v„$»ËBR@$À¾êð–bÞŸ£eRTÎzsÿ ¼kþ?Ùévó„¸¤j^ÉB›/W/|‡o¥q–…=¯‘Kñ¹îXëöGJfÊ»Ö†«2Özþs€O"’j'y»eg”×Ó¼Ø¹Ž|ðŠ.»gŠ=ò$bhØ-":PÂ]³Þ„§
¬wük{OªÞYM3-‡GÌ/ÊûŠñh—oÕµœ4Ç ‰Ç\yiÁ=–çþ]Ú¨†f½W¥þ|Ÿ¹›^‚¸LÜ’aî<ÒW<'Ì^Èy£—(w+É6ËÁrƒWªÝ•Å\ëÇS¹k=ŸZºw	Š­š÷hÄÏåâéqç<mý›r¦Ëé/§Bböê!,êØC²"¸k8ñ¾ù7‚}égùÉÅPÑ]/º–}	ÉVÊÕÁäKÚKGnÕ­ŽU*àð7NaÏ²æj~ÙŠîÙÿpÀÿÊOÎ
sžåôˆó÷âUÑ`Ïéi®Æå	u;þŒ;æõÜõ¤·!ð¯ Nv§Ÿ†
n&:A!çOþÉáÎ+òö0	Šðq7‹ÕÔÞ½»’žýöñ»$™°ójðù¥•V©)+ªÊ4Ál¡6Ñi3¢ÞŸù“½éº˜˜t"”ôŒ<vž~)—€ˆ´Ó¾;ÒKõdEzöh±wEOºÉtÜ›è
c4;Ýë}\h²£?}UyË+ò^–ÏçÎT<é0¯¨«é™*+¨® [_+ß;Ûžq
þ&t{›D£B|ìÝ[,=§)ý£Pý*úËÎpœ;‘Pê@Î{¥}Ò+Ÿ#œoØ…øò¿“
Iš­wA1áÙÇÎ”{>öxVL8 È-((Ý‘àâ÷TòêlI2”eO;x†?Ý±;ZpËÊþºµæÍ¤ÿ[ ,Ðº¸ogW²›ª°‹œ"öv[Z(YOä#éÊÉŸˆðELáÝFŠ‘ÙLþw‘ßâþl?ùL§â"O>TÏºŸÂ% T­ò_>Oìâé¶‹íS°Ã=ovžž@_`s
~£…Ûwö¸ µÈè¦—YTj”†™C¼qo"M™MåVÛAø¬˜ÌVªX´Ãôü>/‡WÎÅqÚO‡;xÍŸ©ox¿'¬A7cy(,(·GÕ­¤-±iaÙX¦›|È§p³–À4c¹å‡)ª²"TV¾‚ÁjÎru@dùÖÀÎ¤&ÈpY7Ì²Î ‚%Î`®7œTaè›­³åEfû&¾0Û7, «fè‡‚Ug¡(’*`KnV¢árÖqdÖ£ƒæ<Ö“=Ýã†/k®ë’qïçízœò¥ínûúO!_8äœX9‡’|û!ã?V´×nç>d†žäC»˜P…&|É½´«aÌÂÙ ÇˆÏžvÂ& ´é†xünà3©T?BV{ˆˆ¹J }Êx´4þãã+cR
+žš¸"š±!R:›öâÒ|¡.^ÜûÜu|Yõa©µî@‚]F	 ’í)àJ•¦Ie©Ç2(@¡A^ç/``	'Ü~I°6b¦2ºöujÆRÍ$zÒ!‹k¡m—#5sI6ŽBvY HÍº!Ùçš•Á yƒ/Íáa	™fV¯âSl<ªŸÜ6}s%qûC4¢qe]`#;ýB«R‚ C~¶áZååS¯½	ÑÙ¬ï»Œ[&xŒ(L¬@ç°ç ØÁ»wÌ_žŒýtyn§[}Nß¹ôå’oü píJdÑœ
–ö\î½;ûþŽ"Ü€"$\¸Ãù@ˆCæÊ¡FD@ "fö˜>`‹U§Øÿ–QJ…Äf¡ç1ÉRO†M4­Ú€ÛP ?fak´º3Ý—GÚ=Öóð&eh+ÓnŠ_-bÙ‰Zbà£ðFå´«igŸ¤Õ€À¤ã4åÜkÐ îùýhH²h2}4Ä
	ØùüöU©ºnŠ HŸÁìÓ‰6‡kçÈéBëô`t¢v¡¾ 3K˜—C1 Öpj7v •õN7¸öú2,zØ2cˆù,—þÿYL×¶µ{_AÚmîÐ²¬zïÛÎþÄŠõjÍN@Ä8Ùz4"%Ðî¾àøxèt"¤ÐkÑð*Tçó<kQÚ£¯`àGˆuaËÝ†'®«2ÿ¦ƒ+ âo¦gú¬ÿöý<šõs}ü@Íw'ÅðByÜ},¿ÐÕ]«qÊÐ•;ÿ±ÔVîã8úœß>ºR¿gÚÑW0{ÁªE~œW×6àÞ}D(D[›"ì?ÅgÚ·Eé¿O£ÈGÛ0º±ã?JÈ«·kä<„|O4F¿FÐZDºÍ†*­mG©·ZQeÌðÂÙF]Åj‡ÌmTÙÉ¾ä½ñ
Ré²o¥
y•ê÷	·XÇ€V—Ùßt¹¶R­JÁö„ëHà€„kKkÆGÍ=Ã´/
	¦c˜“`íýß	YÏ3ˆÓVŽ¹Œ¯©ÆV„QS.#äsÇ]n¤…H%1ÆãðùÏäåž’8¬/8¹
<!<SE_©EÈ¦ýè ´úº¯É‘h^J2rÓjTã©ý¢ŠQZÁ‰m¹Ñª¦;Ç£›“KŠˆ È©w,§_9yÞ«’Þ…Ù‡}Á˜Í7¼âÛ6^ß˜¦™ªyÛS0	ß0áÂòácÄ¹÷SÔ¼ñvTnŠÞ©VÓï „KûeÀ?x-ˆ´­è¶Õ’~ ³Ñ[Š¿QdV}›Äôm¥o9&Bi¹þvd²™mH÷=s=îûápÑŠÅqS™sG6½§ÏÛuÜ–Mô-µtš(bÌr[OíIÌu‹SÍòëþ@»2Ýwr­vý+÷ã×~,rn-†5Žlì£seâ&2"|cög«Š°™Áõ¥Ö6$p‡ÓªýíÃÝAÄœÏþ¨ªÖa9T¾õ_¥êÿë²íÿw-¢Ì\4ÿ0^¦"½[E¼m¸§nHª«€Å«u,ÀMpbK#?Á¤½ƒiy·åÔÓŠ«òsØ‹È+:fÝÂ6"êH4Ûë–b(ßåŠþ•Ð(jLj6C£³Ý•¥²XÚ”å;éD%‚½Ý´ü£Hè‡Ú+?erÃL”l(h½Û`”~¶}Ô÷§½‡¡bñq~÷’ð&OYË×Îåp+aÔÑ÷e±¡‚–WSòƒöüúBãXê¥QqÉÝÃ™HÆYqJè´h#Æ6<ñ‘ýìGD ¥ïZŽdìøÐåp3K‰…¸µÌ¾Ô$ÆÍÇbÚ”¦R%fÁ+Ð3©Z@7¦>R•œe\Ø€däÖ`}œ{ý"9>e¼ÃÄŒS®ÕJÞ‚éëÎ$D˜PSa‰Ô¨xQT~Á2ŽÅø½¼/7ï/ÓµVÿÅŒ¤òqøÇÇ¢”!â%¤[¡¹B„G,nÉµ	#8Ž%tC~{¯^^Ë„}I0ƒ×ô{E'Í
ÄA5îc&%ÕŸ”]Ö³˜<ñõ;îõóR¬Ô(HüÂs-ñ:Ø¶ÇÖ+ =FbU’Ò—DxýfQ9˜ñªß›Ô	Éý(ËÖ-(®Õ¨&8Zùa2Úˆã'5ßPÄ(k•k+Ž@5c¹ºÛtLþö,®ø¼˜Ñ M·xrúy§,úØÐ9¹Çz7eq^DØ·Ìµb‹s†»r÷OlFâ("l%Ü¯0grKGâo””ûÐ¢µÔBI:œÞ$õ"T¹ZkÛQT(^WÝß@Ç‘*&Gß×W$Þ4Sëý‘Cœ¨¢×4Ç‹"¢:üŠáo:íÔyJé!|ˆ#¨RYFÀùºŠ˜ªâÕ
’2ÀÿÔÊA¦$Ñú(ëý,¸$ôX}°UUV«t8¦4tÖáÜoª6D*sÑG_òc}" XQøÂÍ(lRhKB36¨wŽÓç¾/FzSÿn€È·IÆ7²¥V§Æ,ÄûAÒáúP‰>_¼´Vƒ&ì|5¢Zså‹¯hžWé)7s¾]FªÛôÛQËˆgP;­PwZi˜„ÏŠýø$y*S5 ±äs®Pjœi›‹ÓÆ*Íf~”öçÓ”ÎËºÊÓ˜yf¹§Ï²-Ž2à„UÒ¿n–òq!>€Hú4¨Ýê”Ú\(
e°ˆ‡-ì†IŽ\E*ÉHu£² Ýoõ à·ÞçQ¸õ2.šJ+þÉw4/ÄßTQ8Ž–…¿…?Ú'p¿ƒCñý‚ ¼Ðb ÐxZˆ/cý	Žc¶d#€”§–žø)QKƒPZ¤ÂÛõ£ÍBŽ1øåH¸†mãÅtåè¤&ºïL£Í_Y‚àÏåe†™ÚP8_$aˆ*<…ô_|ÁÒÃÉT­c5‚6ðúû‘;cÌþfbÜÛ™ÿÎcÙ ªNW»·¨USc˜<ÄL€²]ö,ØÃ8¥7"Æz§€*‘í–¥h«Ã¸÷4@)U}56Ó &%¤³jTŒÃÕp˜¾,mÄa¢Õ5iðž Tk¼(]]—çVa:†`%¾¼ëB`l¼JÑzÅ)à ‘F90Ùnž´ïóM2 Èž ²1q¬oPi×ÃÊÜß“êanê…ß L‹Vsˆ^ø¤/Mõ²©ë`êe~„?‚8Nº‹ÉGÿ^%Õ¿µô*	ý ¦â{¤[}LÖí5ãÎLå«¹&RIUŒ‰9oÍMÐ¹Uö€ýNÞ›8ÖD! ëÕ–ÀÚ®ú›è±'ÆÎIÀà‘ƒùÃœÌšþŠ\l½öÝå˜¬¡†ÆÖáLLeêœ–ÃžòNÌA°+¨[i‡e™*° J{Àª7¹
mí*ÍzyáAl­C¦‚Ãz¹ýmÛ=¬›c¾5¬?Q)mdî´Fh˜¤_$ëW‚RDï(‰²unÞZ’5                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            