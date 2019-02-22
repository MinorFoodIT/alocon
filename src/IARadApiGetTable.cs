using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("1A3D45A1-781D-4128-B90C-FD5120D837D0")]
  [ComImport]
  public interface IARadApiGetTable
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void BeginGetTable([In] int TermId, [In] int TableNum, [MarshalAs(UnmanagedType.BStr), In] string TableNameAsBSTR);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void EndGetTable([In] int TermId);
  }
}
