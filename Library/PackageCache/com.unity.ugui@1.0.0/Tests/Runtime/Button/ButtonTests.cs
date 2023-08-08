subclass)\n\n   Return true if *subclass* should be considered a (direct or\n   indirect) subclass of *class*.  If defined, called to implement\n   ``issubclass(subclass, class)``.\n\nNote that these methods are looked up on the type (metaclass) of a\nclass.  They cannot be defined as class methods in the actual class.\nThis is consistent with the lookup of special methods that are called\non instances, only in this case the instance is itself a class.\n\nSee also:\n\n   **PEP 3119** - Introducing Abstract Base Classes\n      Includes the specification for customizing ``isinstance()`` and\n      ``issubclass()`` behavior through ``__instancecheck__()`` and\n      ``__subclasscheck__()``, with motivation for this functionality\n      in the context of adding Abstract Base Classes (see the ``abc``\n      module) to the language.\n\n\nEmulating callable objects\n==========================\n\nobject.__call__(self[, args...])\n\n   Called when the instance is "called" as a function; if this method\n   is defined, ``x(arg1, arg2, ...)`` is a shorthand for\n   ``x.__call__(arg1, arg2, ...)``.\n\n\nEmulating container types\n=========================\n\nThe following methods can be defined to implement container objects.\nContainers usually are sequences (such as lists or tuples) or mappings\n(like dictionaries), but can represent other containers as well.  The\nfirst set of methods is used either to emulate a sequence or to\nemulate a mapping; the difference is that for a sequence, the\nallowable keys should be the integers *k* for which ``0 <= k < N``\nwhere *N* is the length of the sequence, or slice objects, which\ndefine a range of items. (For backwards compatibility, the method\n``__getslice__()`` (see below) can also be defined to handle simple,\nbut not extended slices.) It is also recommended that mappings provide\nthe methods ``keys()``, ``values()``, ``items()``, ``has_key()``,\n``get()``, ``clear()``, ``setdefault()``, ``iterkeys()``,\n``itervalues()``, ``iteritems()``, ``pop()``, ``popitem()``,\n``copy()``, and ``update()`` behaving similar to those for Python\'s\nstandard dictionary objects.  The ``UserDict`` module provides a\n``DictMixin`` class to help create those methods from a base set of\n``__getitem__()``, ``__setitem__()``, ``__delitem__()``, and\n``keys()``. Mutable sequences should provide methods ``append()``,\n``count()``, ``index()``, ``extend()``, ``insert()``, ``pop()``,\n``remove()``, ``reverse()`` and ``sort()``, like Python standard list\nobjects.  Finally, sequence types should implement addition (meaning\nconcatenation) and multiplication (meaning repetition) by defining the\nmethods ``__add__()``, ``__radd__()``, ``__iadd__()``, ``__mul__()``,\n``__rmul__()`` and ``__imul__()`` described below; they should not\ndefine ``__coerce__()`` or other numerical operators.  It is\nrecommended that both mappings and sequences implement the\n``__contains__()`` method to allow efficient use of the ``in``\noperator; for mappings, ``in`` should be equivalent of ``has_key()``;\nfor sequences, it should search through the values.  It is further\nrecommended that both mappings and sequences implement the\n``__iter__()`` method to allow efficient iteration through the\ncontainer; for mappings, ``__iter__()`` should be the same as\n``iterkeys()``; for sequences, it should iterate through the values.\n\nobject.__len__(self)\n\n   Called to implement the built-in function ``len()``.  Should return\n   the length of the object, an integer ``>=`` 0.  Also, an object\n   that doesn\'t define a ``__nonzero__()`` method and whose\n   ``__len__()`` method returns zero is considered to be false in a\n   Boolean context.\n\nobject.__getitem__(self, key)\n\n   Called to implement evaluation of ``self[key]``. For sequence\n   types, the accepted keys should be integers and slice objects.\n   Note that the special interpretation of negative indexes (if the\n   class wishes to emulate a sequence type) is up to the\n   ``__getitem__()`` method. If *key* is of an inappropriate type,\n   ``TypeError`` may be raised; if of a value outside the set of\n   indexes for the sequence (after any special interpretation of\n   negative values), ``IndexError`` should be raised. For mapping\n   types, if *key* is missing (not in the container), ``KeyError``\n   should be raised.\n\n   Note: ``for`` loops expect that an ``IndexError`` will be raised for\n     illegal indexes to allow proper detection of the end of the\n     sequence.\n\nobject.__setitem__(self, key, value)\n\n   Called to implement assignment to ``self[key]``.  Same note as for\n   ``__getitem__()``.  This should only be implemented for mappings if\n   the objects support changes to the values for keys, or if new keys\n   can be added, or for sequences if elements can be replaced.  The\n   same exceptions should be raised for improper *key* values as for\n   the ``__getitem__()`` method.\n\nobject.__delitem__(self, key)\n\n   Called to implement deletion of ``self[key]``.  Same note as for\n   ``__getitem__()``.  This should only be implemented for mappings if\n   the objects support removal of keys, or for sequences if elements\n   can be removed from the sequence.  The same exceptions should be\n   raised for improper *key* values as for the ``__getitem__()``\n   method.\n\nobject.__iter__(self)\n\n   This method is called when an iterator is required for a