using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("68A409A6-7F0D-457F-884A-EB143DCCAE24")]
  [ComImport]
  public interface IARadOrderModeCharge
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OverrideOrderModeCharge([In] int TermId, [In] int CheckId, [In] int OrderModeId, [In] double OrderModeCharge);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RemoveOverrideOrderModeCharge([In] int TermId, [In] int CheckId, [In] int OrderModeId);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    double GetCheckTotalWithOrderModeCharge([In] int TermId, [In] int CheckId);
  }
}