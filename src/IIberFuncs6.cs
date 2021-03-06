using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("5866625D-6610-4370-834B-488255ECC11C")]
  [ComImport]
  public interface IIberFuncs6 : IIberFuncs5
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void GetCheckTotal([In] int CheckId, out double Subtotal, out double Tax);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new double GetDrawerBalance([In] int DrawerId);

    [DispId(4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int LogIn([In] int TermId, [In] int ManualEmpNum, [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd, [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [DispId(5)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void LogOut([In] int TermId);

    [DispId(6)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ClockIn([In] int TermId, [In] int JobCodeId);

    [DispId(7)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ClockOut([In] int TermId, [In] double DeclaredTips);

    [DispId(8)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [DispId(9)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int AddTable([In] int TermId, [In] int QueueId, [In] int TableNum, [MarshalAs(UnmanagedType.BStr), In] string TableName, [In] int NumGuests);

    [DispId(10)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void CloseTable([In] int TermId, [In] int TableId);

    [DispId(11)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int AddCheck([In] int TermId, [In] int TableId);

    [DispId(12)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void CloseCheck([In] int TermId, [In] int CheckId);

    [DispId(13)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [DispId(14)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int ApplyPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string AuthCode);

    [DispId(15)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [DispId(16)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new double GetCheckBalance([In] int TermId, [In] int CheckId);

    [DispId(17)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void PrintCheck([In] int TermId, [In] int CheckId);

    [DispId(18)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int BeginItem([In] int TermId, [In] int CheckId, [In] int ItemId, [MarshalAs(UnmanagedType.BStr), In] string ItemName, [In] double Price);

    [DispId(19)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [DispId(20)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void EndItem([In] int TermId);

    [DispId(21)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [DispId(22)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void VoidItem([In] int TermId, [In] int CheckId, [In] int EntryId, [In] int VoidReasonId);

    [DispId(23)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ResetTerminal([In] int TermId);

    [DispId(24)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void RefreshCheckDisplay();

    [DispId(25)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void SelectAllEntriesOnCheck([In] int TermId, [In] int CheckId);

    [DispId(26)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void SelectEntry([In] int TermId, [In] int CheckId, [In] int EntryId);

    [DispId(27)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void SelectEntryAndChildren([In] int TermId, [In] int CheckId, [In] int EntryId);

    [DispId(28)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void DeselectAllEntries([In] int TermId);

    [DispId(29)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void DeselectEntry([In] int TermId, [In] int EntryId);

    [DispId(30)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void DeselectEntryAndChildren([In] int TermId, [In] int CheckId, [In] int EntryId);

    [DispId(31)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void HoldUnorderedEntriesOnCheck([In] int TermId, [In] int CheckId, [In] int SelectedOnly);

    [DispId(32)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int ApplySpecialMessage([In] int TermId, [In] int CheckId, [In] int ParentEntryId, [MarshalAs(UnmanagedType.BStr), In] string Message);

    [DispId(33)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int BeginPivotSeatItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum);

    [DispId(34)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int GetMenuID([In] int TermId);

    [DispId(35)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void SetObjectAttribute([In] int ObjectClassId, [In] int ObjectId, [MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.BStr), In] string Value);

    [DispId(36)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    new string GetObjectAttribute([In] int ObjectClassId, [In] int ObjectId, [MarshalAs(UnmanagedType.BStr), In] string Name);

    [DispId(37)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    new string Authenticate([MarshalAs(UnmanagedType.BStr), In] string Input);

    [DispId(38)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void AdjustPayment([In] int TermId, [In] int CheckId, [In] int PaymentId, [In] double amount, [In] double Tip);

    [DispId(39)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void DeletePayment([In] int TermId, [In] int CheckId, [In] int PaymentId);

    [DispId(40)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void DisplayMessage([MarshalAs(UnmanagedType.BStr), In] string Message);

    [DispId(41)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void SendStringToHardware(
      [In] int TermId,
      [In] DEVICE_IDS TypeOfDevice,
      [In] int DeviceID,
      [MarshalAs(UnmanagedType.BStr), In] string StringToSend);

    [DispId(42)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void LogDeboutMessage([MarshalAs(UnmanagedType.BStr), In] string Text);

    [DispId(43)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void GetSeatTotal(
      [In] int EmpId,
      [In] int TableId,
      [In] int SeatNum,
      out double Subtotal,
      out double Tax);

    [DispId(44)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int IsPivotSeating([In] int EmpId, [In] int RevId);

    [DispId(45)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int ExceptionModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ExceptionModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [DispId(46)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int GetNewOrder([In] int TermId);

    [DispId(47)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int IsDrawerConfirmationNeeded([In] int TermId, [In] int EmployeeId);

    [DispId(48)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int ConfirmDrawerBalance([In] int TermId, [In] int EmployeeId, [In] double dBalance);

    [DispId(49)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int ApplyPromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromotionId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Ident);

    [DispId(50)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeletePromo([In] int TermId, [In] int ManagerId, [In] int CheckId, [In] int PromoId);

    [DispId(51)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int ApplyComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompTypeId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Unit,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [DispId(52)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeleteComp([In] int TermId, [In] int ManagerId, [In] int CheckId, [In] int CompId);

    [DispId(53)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MoveSelectedEntries([In] int TermId, [In] int ManagerId, [In] int FromCheckId, [In] int ToCheckId);

    [DispId(54)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ManagerVoidItem([In] int TermId, [In] int ManagerId, [In] int CheckId, [In] int EntryId, [In] int VoidReasonId);

    [DispId(55)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int ModItemEx(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [DispId(56)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SelectAllEntriesOnCheckWithValue([In] int TermId, [In] int CheckId, [In] int Value);

    [DispId(57)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SelectEntryWithValue([In] int TermId, [In] int CheckId, [In] int EntryId, [In] int Value);

    [DispId(58)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SelectEntryAndChildrenWithValue([In] int TermId, [In] int CheckId, [In] int EntryId, [In] int Value);
  }
}
