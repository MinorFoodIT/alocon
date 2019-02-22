using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("61DAAED1-20CD-4C33-BC23-9B78AEEE8C09")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IInterceptBarcode
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int InterceptBarcode([MarshalAs(UnmanagedType.BStr), In] string bstrBarcodeData);
  }
}
