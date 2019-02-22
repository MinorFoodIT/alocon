using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("859E43E2-E988-4B94-B503-ABAC57AF6DBB")]
  [ComImport]
  public interface IARadApi3
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddCheckInfo([In] int TermId, [In] int CheckId, [MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.BStr), In] string Value);
  }
}
