using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("046BF6DA-5B1F-4B96-BAA6-2D794CA37B7B")]
  [ComImport]
  public interface IGenericComPrinter
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int Initialize([MarshalAs(UnmanagedType.BStr), In] string bPrinterIdentificator);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Cleanup([MarshalAs(UnmanagedType.BStr), In] string bPrinterIdentificator);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int Print([MarshalAs(UnmanagedType.BStr), In] string bPrinterIdentificator, [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_UI1), In] byte[] data);
  }
}
