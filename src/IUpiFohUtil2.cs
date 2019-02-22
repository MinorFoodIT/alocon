using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("6FC9A29D-0E58-43EE-9E10-742B0CD866F8")]
  [ComImport]
  public interface IUpiFohUtil2 : IUpiFohUtil
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int ApplyDebitPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string PinBlock);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int ApplyGiftCardPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int PMSInquiry([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string AccountID, [MarshalAs(UnmanagedType.BStr)] out string xmlResponse);

    [DispId(4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int PMSPreauth([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string AccountID, [In] double amount, [MarshalAs(UnmanagedType.BStr)] out string xmlResponse);

    [DispId(5)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int PMSPostTxn(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] int PostType,
      [In] int PaymentId,
      [MarshalAs(UnmanagedType.BStr), In] string AccountID,
      [MarshalAs(UnmanagedType.BStr), In] string Selection,
      [In] int SelectionNum,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr)] out string xmlResponse);
  }
}
