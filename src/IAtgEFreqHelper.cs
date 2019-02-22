using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("812776B7-0108-4C45-812E-64B16BF7E157")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IAtgEFreqHelper
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ApplyRealTimeDiscountsFromEFreq(
      [In] int TermId,
      [In] int EmployeeId,
      [In] int CheckId,
      [In] int CompTypeId,
      [In] int PromotionId,
      [In] int priceChangeCount,
      [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD), In] ref eFreqPriceChange[] priceChanges);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RemoveRealTimeEFrequencyDiscounts([In] int TermId, [In] int CheckId);
  }
}