namespace LibcWrapper;

// ClangSharp could not emit this type (system va_list builtin); only used behind pointers
// in vasprintf/vdprintf/obstack_vprintf, so an opaque struct is enough.
public struct __va_list_tag
{
}
