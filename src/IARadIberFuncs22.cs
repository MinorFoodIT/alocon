using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("2E3E87C8-DB0D-45A1-96AE-1BE2FD0EC8E1")]
  [ComImport]
  public interface IARadIberFuncs22
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void LockTable([In] int TermId, [In] int TableId);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void UnlockTable([In] int TermId, [In] int TableId);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int AddTableSavedCard([In] int TermId, [In] int QueueId, [MarshalAs(UnmanagedType.BStr), In] string trackInfoForTableName, [In] int NumGuests);

    [DispId(4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int ApplyPaymentSavedCard([In] int TermId, [In] int CheckId, [In] int TenderId, [In] double amount, [In] double Tip);

    [DispId(5)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    string GetCheckEntriesNew([In] int TermId, [In] int CheckId);

    [DispId(6)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void TransferATOOrderToServer([In] int TermId, [In] int TableId);

    [DispId(7)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddSavedCardToTable([In] int TermId, [In] int TableId, [MarshalAs(UnmanagedType.BStr), In] string TrackInfo);

    [DispId(8)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int IsSavedCardAttached([In] int TermId, [In] int TableId);

    [DispId(9)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DisableHoldFunctionOnFOH([In] int TermId, [In] int TableId, [In] bool disableFeature);
  }
}
