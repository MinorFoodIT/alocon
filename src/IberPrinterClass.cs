using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [ClassInterface(0)]
  [Guid("C63C0BF0-FBA8-11D4-8688-00B0D02A2DF6")]
  [TypeLibType(2)]
  [ComImport]
  public class IberPrinterClass : IIberPrinter, IberPrinter
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern IberPrinterClass();

    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string GetAllPrinters();

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void PrintStream([MarshalAs(UnmanagedType.BStr), In] string bszStream);
  }
}