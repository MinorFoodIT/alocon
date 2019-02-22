using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("DFAE965C-225F-42F6-AC6C-0E058D9D654D")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IIberGiftCardActivation
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void QueryGiftCardBalance([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string GiftCardData, [In] bool IsSwipe);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void VoidGiftCard([In] int TermId, [In] int TableId, [In] int CheckId, [In] int EntryId);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int GetGiftCardActivationStatus([In] int TermId, [In] int GiftCardId, [MarshalAs(UnmanagedType.BStr)] out string Reason);

    [DispId(4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int SaleGiftCard(
      [In] int TermId,
      [In] int TableId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string GiftCardData,
      [In] bool IsSwipe,
      [In] double amount);

    [DispId(5)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int SaleGiftCardRange(
      [In] int TermId,
      [In] int TableId,
      [In] int CheckId,
      [In] int ItemId,
      [In] double amount,
      [In] int Quantity,
      [MarshalAs(UnmanagedType.BStr), In] string GiftCardDataStart,
      [MarshalAs(UnmanagedType.BStr), In] string GiftCardDataEnd,
      [In] bool IsSwipe);
  }
}