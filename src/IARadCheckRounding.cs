using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("FE82505D-0FD7-4AE4-AB40-017183662336")]
  [ComImport]
  public interface IARadCheckRounding
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    bool IsRoundingActive([In] int CheckId);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    bool IsRoundingAdjustmentDisplayed([In] int CheckId);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetCheckTotals(
      [In] int CheckId,
      out double Subtotal,
      out double Tax,
      out double RoundingAdjustment);

    [DispId(4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    double GetCheckBalance([In] int CheckId, [In] int TenderId);
  }
}