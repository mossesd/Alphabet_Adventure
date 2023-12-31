or_ENOMEM:
            return ENOMEM;
        case Error_ENOMSG:
            return ENOMSG;
        case Error_ENOPROTOOPT:
            return ENOPROTOOPT;
        case Error_ENOSPC:
            return ENOSPC;
        case Error_ENOSYS:
            return ENOSYS;
        case Error_ENOTCONN:
            return ENOTCONN;
        case Error_ENOTDIR:
            return ENOTDIR;
        case Error_ENOTEMPTY:
            return ENOTEMPTY;
#ifdef ENOTRECOVERABLE // not available in NetBSD
        case Error_ENOTRECOVERABLE:
            return ENOTRECOVERABLE;
#endif
        case Error_ENOTSOCK:
            return ENOTSOCK;
        case Error_ENOTSUP:
            return ENOTSUP;
        case Error_ENOTTY:
            return ENOTTY;
        case Error_ENXIO:
            return ENXIO;
        case Error_EOVERFLOW:
            return EOVERFLOW;
#ifdef EOWNERDEAD // not available in NetBSD
        case Error_EOWNERDEAD:
            return EOWNERDEAD;
#endif
        case Error_EPERM:
            return EPERM;
        case Error_EPIPE:
            return EPIPE;
        case Error_EPROTO:
            return EPROTO;
        case Error_EPROTONOSUPPORT:
            return EPROTONOSUPPORT;
        case Error_EPROTOTYPE:
            return EPROTOTYPE;
        case Error_ERANGE:
            return ERANGE;
        case Error_EROFS:
            return EROFS;
        case Error_ESPIPE:
            return ESPIPE;
        case Error_ESRCH:
            return ESRCH;
        case Error_ESTALE:
            return ESTALE;
        case Error_ETIMEDOUT:
            return ETIMEDOUT;
        case Error_ETXTBSY:
            return ETXTBSY;
        case Error_EXDEV:
            return EXDEV;
        case Error_EPFNOSUPPORT:
            return EPFNOSUPPORT;
#ifdef ESOCKTNOSUPPORT
        case Error_ESOCKTNOSUPPORT:
            return ESOCKTNOSUPPORT;
#endif
        case Error_ESHUTDOWN:
            return ESHUTDOWN;
        case Error_EHOSTDOWN:
            return EHOSTDOWN;
        case Error_ENODATA:
            return ENODATA;
        case Error_ENONSTANDARD:
            break; // fall through to assert
    }

    // We should not use this function to round-trip platform -> pal
    // -> platform. It's here only to synthesize a platform number
    // from the fixed set above. Note that the assert is outside the
    // switch rather than in a default case block because not
    // having a default will trigger a warning (as error) if there's
    // an enum value we haven't handled. Should that trigger, make
    // note that there is probably a corresponding missing case in the
    // other direction above, but the compiler can't warn in that case
    // because the platform values are not part of an enum.
    IL2CPP_ASSERT(0 && "Unknown error code");
    return -1;
}

#endif
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     