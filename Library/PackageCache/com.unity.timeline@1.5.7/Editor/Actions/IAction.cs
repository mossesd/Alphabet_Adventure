		cached = k;
					break;
				}
			}
			mono_image_set_unlock (image_set);
		} else {
			mono_loader_lock ();
			if (!image->array_cache)
				image->array_cache = g_hash_table_new (mono_aligned_addr_hash, NULL);
			rootlist = (GSList *)g_hash_table_lookup (image->array_cache, eclass);
			for (list = rootlist; list; list = list->next) {
				k = (MonoClass *)list->data;
				if ((k->rank == rank) && (k->byval_arg.type == (((rank > 1) || bounded) ? MONO_TYPE_ARRAY : MONO_TYPE_SZARRAY))) {
					cached = k;
					break;
				}
			}
			mono_loader_unlock ();
		}
	}
	if (cached)
		return cached;

	parent = mono_defaults.array_class;
	if (!parent->inited)
		mono_class_init (parent);

	klass = image_set ? (MonoClass *)mono_image_set_alloc0 (image_set, sizeof (MonoClassArray)) : (MonoClass *)mono_image_alloc0 (image, sizeof (MonoClassArray));

	klass->image = image;
	klass->name_space = eclass->name_space;
	klass->class_kind = MONO_CLASS_ARRAY;

	nsize = strlen (eclass->name);
	name = (char *)g_malloc (nsize + 2 + rank + 1);
	memcpy (name, eclass->name, nsize);
	name [nsize] = '[';
	if (rank > 1)
		memset (name + nsize + 1, ',', rank - 1);
	if (bounded)
		name [nsize + rank] = '*';
	name [nsize + rank + bounded] = ']';
	name [nsize + rank + bounded + 1] = 0;
	klass->name = image_set ? mono_image_set_strdup (image_set, name) : mono_image_strdup (image, name);
	g_free (name);

	klass->type_token = 0;
	klass->parent = parent;
	klass->instance_size = mono_class_instance_size (klass->parent);

	if (eclass->byval_arg.type == MONO_TYPE_TYPEDBYREF) {
		/*Arrays of those two types are invalid.*/
		MonoError prepared_error;
		error_init (&prepared_error);
		mono_error_set_invalid_program (&prepared_error, "Arrays of System.TypedReference types are invalid.");
		mono_class_set_failure (klass, mono_error_box (&prepared_error, klass->image));
		mono_error_cleanup (&prepared_error);
	} else if (eclass->enumtype && !mono_class_enum_basetype (eclass)) {
		guint32 ref_info_handle = mono_class_get_ref_info_handle (eclass);
		if (!ref_info_handle || eclass->wastypebuilder) {
			g_warning ("Only incomplete TypeBuilder objects are allowed to be an enum without base_type");
			g_assert (ref_info_handle && !eclass->wastypebuilder);
		}
		/* element_size -1 is ok as this is not an instantitable type*/
		klass->sizes.element_size = -1;
	} else
		klass->sizes.element_size = -1;

	mono_class_setup_supertypes (klass);

	if (mono_class_is_ginst (eclass))
		mono_class_init (eclass);
	if (!eclass->size_inited)
		mono_class_setup_fields (eclass);
	mono_class_set_type_load_failure_causedby_class (klass, eclass, "Could not load array element type");
	/*FIXME we fail the array type, but we have to let other fields be set.*/

	klass->has_references = MONO_TYPE_IS_REFERENCE (&eclass->byval_arg) || eclass->has_references? TRUE: FALSE;

	klass->rank = rank;
	
	if (eclass->enumtype)
		klass->cast_class = eclass->element_class;
	else
		klass->cast_class = eclass;

	switch (klass->cast_class->byval_arg.type) {
	case MONO_TYPE_I1:
		klass->cast_class = mono_defaults.byte_class;
		break;
	case MONO_TYPE_U2:
		klass->cast_class = mono_defaults.int16_class;
		break;
	case MONO_TYPE_U4:
#if SIZEOF_VOID_P == 4
	case MONO_TYPE_I:
	case MONO_TYPE_U:
#endif
		klass->cast_class = mono_defaults.int32_class;
		break;
	case MONO_TYPE_U8:
#if SIZEOF_VOID_P == 8
	case MONO_TYPE_I:
	case MONO_TYPE_U:
#endif
		klass->cast_class = mono_defaults.int64_class;
		break;
	default:
		break;
	}

	klass->element_class = eclass;

	if ((rank > 1) || bounded) {
		MonoArrayType *at = image_set ? (MonoArrayType *)mono_image_set_alloc0 (image_set, sizeof (MonoArrayType)) : (MonoArrayType *)mono_image_alloc0 (image, sizeof (MonoArrayType));
		klass->byval_arg.type = MONO_TYPE_ARRAY;
		klass->byval_arg.data.array = at;
		at->eklass = eclass;
		at->rank = rank;
		/* FIXME: complete.... */
	} else {
		klass->byval_arg.type = MONO_TYPE_SZARRAY;
		klass->byval_arg.data.klass = eclass;
	}
	klass->this_arg = klass->byval_arg;
	klass->this_arg.byref = 1;

	if (rank > 32) {
		MonoError prepared_error;
		error_init (&prepared_error);
		name = mono_type_get_full_name (klass);
		mono_error_set_type_load_class (&prepared_error, klass, "%s has too many dimensions.", name);
		mono_class_set_failure (klass, mono_error_box (&prepared_error, klass->image));
		mono_error_cleanup (&prepared_error);
		g_free (name);
	}

	mono_loader_lock ();

	/* Check cache again */
	cached = NULL;
	if (rank == 1 && !bounded) {
		if (image_set) {
			mono_image_set_lock (image_set);
			cached = (MonoClass *)g_hash_table_lookup (image_set->s