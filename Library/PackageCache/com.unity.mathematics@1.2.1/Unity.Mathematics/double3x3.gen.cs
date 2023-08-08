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
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          DCMPA30���ޱ� b#� �g�� �Y��     L�e���B�p���5��:���Z�e��F�ќHD �B����-���>��s�[>�`��?��c,Ÿ��s�z^�ɋ`��u�i��M��rL�pb�4TNڈ&}B��ih��I��ַn�4a��s�����4y��|�mt�[mQ�" �	�G`*2��E��Ed2��ޢ�6�G
U�D�-�X
�?���N�������''X 0C�@0N��{3����P$n�8���07f�1mv��ڈsSc�3^��qo�h68�x����Tۤo�:�94b�F������x3��&&��ڲ������K�;ґ��bwا~�#�=��H$%�]E��=���D@ݼ,��0B �4����F̙���'��=�N����#��R!�����K�b$\��~�+R�低�T�"ͨ:�vfT4�:���(����x�Ov��vR����X���J��exS�b�vE�G�	�|u���%�Һ�I�6����?�!�O��+�L���B�r���y�\�|����qtܗhX�!mrKW���8�.-�]���f*;g�!��r���7.Ǹ���x�pzq��P�����<��?����B������%���'�(h^��v�$��BR@$����bޟ�eRT�zs� �k�?��v󄸤j^�B�/W/|�o�q��=���K���X��GJfʻֆ�2�z�s�O"��j'y�eg��Ӽع�|��.�g�=�$b�h�-":P�]�ބ�
�w�k{O��YM3-�G�/����h�oյ�4Ǡ��\yi�=���]ڨ�f�W��|���^��L���a��<�W<'�^�y��(w+�6��r�W�ݕ�\��S�k=�Z�w	����h�����q�<m��r����/�Bb��!,��C�"�k8��7�}�g���P�]/��}	�V����K�KGn���U*��7Naϲ�j~ي���p���O�
s������U�`��i���	u;��;������!� Nv���
�n&:A!�O����+��0	��q7���޽������$���j����V�)+��4�l�6�i3�ޟ���麘�t"��<v�~)����Ӿ;�K�dEz�h�wEO��tܛ�
c4;��}\h��?}Uy�+�^����T<�0�����*+���[_+�;�۞q
�&t{�D�B|��[,=�)���P�*���p�;�P�@�{�}�+�#�o؅��
I��wA1���Δ{>�xVL8 �-((ݑ���T��lI2�eO;x�?ݱ;Zp������ͤ�[ ,Ѝ��ogW������"�v[Z(YO�#��ɟ��EL�ݏF���L�w����l?�L��"O>T����% T��_>O��鶋�S��=ov��@_`s
~���w�������YTj���C�qo"M�M�V�A����V�X����>/�W��q�O�;x͟�ox�'�A7cy(,(�Gխ�-�ia�X��|ȧp���4c���)��"TV���j�ru@d���Τ&�pY7̲Π�%�`�7�Ta����Ef�&�0�7,��f臂Ug�(�*`KnV��r�qd֣��<֓=��/k��q���z���n��O!_�8�X9��|�!�?V��n�>d���C��P�&|ɽ��a��� ǈϞv�& ��x�n�3�T�?B�V{���J�}�x�4���+cR
+���"��!R:����|�.^���u|Y�a���@�]F	 ��)�J��Ie��2(@�A^�/``�	'�~I�6b�2��uj�R�$z�!�k�m�#5sI6�BvY�Hͺ!�皕� y�/��a	�fV��Sl<���6}s%q�C4��qe]`#;�B�R� C~���Z��S��	�٬ﻌ[&x�(L�@�� ���w�_���tyn�[}N߹��o��p�Jdќ
��\���;���"܀"$\���@�C�ʡFD@ "f��>`�U����QJ��f��1�RO�M4�ڀ�P ?fak���3ݗG�=���&eh+�n�_-bىZb��F崫ig��Հ���4��k� ���hH�h2}4�
	�����U��n� H���Ӊ6�k���B��`t�v�� 3K��C1 ��pj7v ��N7���2,z�2c��,���YL׶�{_A�m�в��z����Ċ�j�N@�8�z4"%����x�t"��k��*T��<kQڣ�`�G�ua�݆'��2���+ �o�g�����<��s}�@�w'���B�y�},���]�q�Е;���V���8���>��R�g��W0{��E~�W�6��}D(D[�"�?�gڐ�E��O��G�0���?Jȫ�k�<��|O4F�F�ZD���*�mG��ZQe����F]�j��mT�ɾ���
R�o�
y���	�XǀV���t��R�J����H���kKk�G��=��/
	�c��`���	Y�3��V������V�QS.#�s�]n��H%1�������垒8�/8�
<!<SE_�EȦ�� ������h^J2r�jT�����Q�Z��m�Ѫ�;ǣ��K������w,�_9yޫ�ޅه}���7���6^�����y�S0	�0����cĹ�SԼ�vTn�ީV�� �K�e�?x-����Ւ~���[��QdV}���m�o9&Bi��vd��mH��=s=���pъ�qS�sG6����uܖM�-�t��(b́r[O��I�u�S����@�2�wr�v�+���~,rn-�5�l�se�&2"|c�g��������6$p�Ӫ��Í�AĜ������a�9T��_�������w-��\4�0^�"�[E�m��nH���ūu,�M�pbK#?������iy���ӊ���s؋�+:f��6"�H4��b(�����(jLj6C��ݕ��Xڔ�;�D%��ݴ��H���+?er�L�l(h��`�~�}������b�q~���&OY����p+a�я��e����WS����B�X�Qq��ÙH�Yq�J�h#�6<���GD ��Z�d����p3K�����̾�$���bڔ��R%f�+�3��Z@7�>R��e\؀d��`}�{�"9>e��ČS��Jނ���$D�PSa�ԨxQT~�2�����/7�/ӵV�Ō��q�����!�%�[��B�G,nɵ	#8�%tC~{�^^˄}I0���{E'�
�A5�c&%Տ��]ֳ�<��;���R��(H��s-�:����+ =FbU�җDx�fQ9��ߛ�	��(��-(�ը&8Z�a2ڈ�'5�P�(k�k+�@5c���tL��,����ѠM�xr�y�,���9��z7eq^Dط̵b�s���r�OlF�("l%ܯ0grKG�o�����Т��BI�:��$�"T�Zk�QT(^W��@Ǒ*&G��W$�4S���C����4ǋ"�:���o:��yJ�!|�#��RYF��������
�2����A�$��(��,�$�X}�UUV�t8�4t���o�6D*s�G_�c}" XQ���(lRhKB36�w���/Fz�S�n�ȷI�7��V��,��A���P�>_��V�&�|5�Zs勯h�W�)7s�]F����QˈgP;�PwZi���ϊ��$y*S5 ��s�Pj�i����*�f~���ӏ��˺�Әyf��ϲ-�2��Uҿn��q!>�H�4�����\(
e���-�I�\E*�Hu�� �o�����Q��2.��J+���w4/���TQ8�����?�'p��C��� ��b��xZ�/c�	�c�d#������)QK��PZ������B�1��H��m��t���&��L��_Y����e���P8_$a�*<��_|����T�c5�6����;c��fb�ۙ��c٠�NW����USc�<�L��]�,��8�7"�z��*�향h�ø�4@)U}56� &%��jT���p��,m�a��5i� Tk�(]]��Va:�`%���B`l�J�z�)ࠑF90�n����M2 �� �1q�oPi����ߓ�an�� L�Vs�^��/M����`�e~�?�8N����G�^%տ��*	� ��{�[}L��5��L嫹&RIU��9o�MйU���Nޛ8�D! �Ֆ�ڮ��萱'��I�����Ü̚��\l���嘬�����LLe꜖Þ�N�A�+�[i�e�*� J{��7�
m�*�zy�Al�C���z��m�=��c�5�?Q)md�Fh��_$�W�RD�(��un�Z�5                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            