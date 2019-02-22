using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("193B40BE-9106-46F5-B9E5-17EC71BC164A")]
  [TypeLibType(2)]
  [ClassInterface(0)]
  [ComImport]
  public class CUpiFohUtilClass : IUpiFohUtil3, CUpiFohUtil, IUpiFohUtil2, IUpiFohUtil
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern CUpiFohUtilClass();

    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int ApplyDebitPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string PinBlock);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int ApplyGiftCardPayment(
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
    public virtual extern int PMSInquiry([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string AccountID, [MarshalAs(UnmanagedType.BStr)] out string xmlResponse);

    [DispId(4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int PMSPreauth(
      [In] int TermId,
      [MarshalAs(UnmanagedType.BStr), In] string AccountID,
      [In] double amount,
      [MarshalAs(UnmanagedType.BStr)] out string xmlResponse);

    [DispId(5)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int PMSPostTxn(
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
    public virtual extern int ApplyPreAuth(
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
    public virtual extern void IncreasePreAuth(
      [In] int TermId,
      [In] int CheckId,
      [In] double amount,
      [In] int PaymentId);

    [DispId(8)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ClosePreAuth(
      [In] int TermId,
      [In] int CheckId,
      [In] double amount,
      [In] double Tip,
      [In] int PaymentId);

    [DispId(9)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void PrintPreAuth([In] int TermId, [In] int CheckId, [In] double amount, [In] int PaymentId);

    [DispId(10)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int GetTenderIDFromCardNumber([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string CardNumber);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IUpiFohUtil2_ApplyDebitPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string PinBlock);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IUpiFohUtil2_ApplyGiftCardPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IUpiFohUtil2_PMSInquiry(
      [In] int TermId,
      [MarshalAs(UnmanagedType.BStr), In] string AccountID,
      [MarshalAs(UnmanagedType.BStr)] out string xmlResponse);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IUpiFohUtil2_PMSPreauth(
      [In] int TermId,
      [MarshalAs(UnmanagedType.BStr), In] string AccountID,
      [In] double amount,
      [MarshalAs(UnmanagedType.BStr)] out string xmlResponse);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IUpiFohUtil2_PMSPostTxn(
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

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IUpiFohUtil_ApplyDebitPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string PinBlock);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IUpiFohUtil_ApplyGiftCardPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo);
  }
}
