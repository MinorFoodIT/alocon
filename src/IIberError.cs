using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("DBB71752-7417-4BDF-9899-0BD67CC7A226")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IIberError
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    string GetComErrorMessage([MarshalAs(UnmanagedType.Error), In] int errorCode);
  }
}