using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [ClassInterface(0)]
  [Guid("028C44EB-250F-4CD4-A3A0-DCD9D622D19E")]
  [TypeLibType(2)]
  [ComImport]
  public class GenericComPrinterClass : IGenericComPrinter, GenericComPrinter
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern GenericComPrinterClass();

    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int Initialize([MarshalAs(UnmanagedType.BStr), In] string bPrinterIdentificator);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void Cleanup([MarshalAs(UnmanagedType.BStr), In] string bPrinterIdentificator);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int Print([MarshalAs(UnmanagedType.BStr), In] string bPrinterIdentificator, [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_UI1), In] byte[] data);
  }
}
