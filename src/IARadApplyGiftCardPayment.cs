using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("8256AD37-DB24-4EC9-8A2B-487381CE320E")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadApplyGiftCardPayment
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int ApplyGiftCardPayment(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string validationCode,
      [In] uint cvvPresenceIndicator);
  }
}