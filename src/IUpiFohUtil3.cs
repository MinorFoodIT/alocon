using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("71CC9C7D-BFF3-40F1-B02A-7340F6C02DE8")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IUpiFohUtil3 : IUpiFohUtil2
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
    new int PMSInquiry([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string AccountID, [MarshalAs(UnmanagedType.BStr)] out string xmlResponse);

    [DispId(4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int PMSPreauth([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string AccountID, [In] double amount, [MarshalAs(UnmanagedType.BStr)] out string xmlResponse);

    [DispId(5)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int PMSPostTxn(
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

    [DispId(6)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int ApplyPreAuth(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string StartDate,
      [MarshalAs(UnmanagedType.BStr), In] string SecurityCode,
      [MarshalAs(UnmanagedType.BStr), In] string AVS);

    [DispId(7)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void IncreasePreAuth([In] int TermId, [In] int CheckId, [In] double amount, [In] int PaymentId);

    [DispId(8)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ClosePreAuth([In] int TermId, [In] int CheckId, [In] double amount, [In] double Tip, [In] int PaymentId);

    [DispId(9)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PrintPreAuth([In] int TermId, [In] int CheckId, [In] double amount, [In] int PaymentId);

    [DispId(10)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int GetTenderIDFromCardNumber([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string CardNumber);
  }
}
