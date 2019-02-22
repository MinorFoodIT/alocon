using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("C8FD80EC-59E6-4F99-9AC9-BE9A13EF5D82")]
  [ComImport]
  public interface IIberFuncs17 : IIberFuncs16
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
    new int ExceptionModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ExceptionModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [DispId(46)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int GetNewOrder([In] int TermId);

    [DispId(47)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int IsDrawerConfirmationNeeded([In] int TermId, [In] int EmployeeId);

    [DispId(48)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int ConfirmDrawerBalance([In] int TermId, [In] int EmployeeId, [In] double dBalance);

    [DispId(49)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int ApplyPromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromotionId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Ident);

    [DispId(50)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void DeletePromo([In] int TermId, [In] int ManagerId, [In] int CheckId, [In] int PromoId);

    [DispId(51)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int ApplyComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompTypeId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Unit,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [DispId(52)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void DeleteComp([In] int TermId, [In] int ManagerId, [In] int CheckId, [In] int CompId);

    [DispId(53)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void MoveSelectedEntries([In] int TermId, [In] int ManagerId, [In] int FromCheckId, [In] int ToCheckId);

    [DispId(54)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ManagerVoidItem(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [DispId(55)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int ModItemEx(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [DispId(56)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void SelectAllEntriesOnCheckWithValue([In] int TermId, [In] int CheckId, [In] int Value);

    [DispId(57)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void SelectEntryWithValue([In] int TermId, [In] int CheckId, [In] int EntryId, [In] int Value);

    [DispId(58)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void SelectEntryAndChildrenWithValue([In] int TermId, [In] int CheckId, [In] int EntryId, [In] int Value);

    [DispId(59)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int GetEFreqStatus([In] int TermId, [In] int CheckId);

    [DispId(60)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void AssignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqTrackInfo,
      [In] int MgrIdOverrideMaxChecks,
      [In] int MgrIdOverrideMagCardOnly,
      [In] int MgrIdOverrideSeriesUse);

    [DispId(61)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void UnassignEFreqMember([In] int TermId, [In] int EmpId, [In] int TableId, [In] int CheckId);

    [DispId(62)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ReassignEFreqMember([In] int TermId, [In] int EmpId, [In] int TableId, [In] int CheckId);

    [DispId(63)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void DeleteEFreqMember([In] int TermId, [In] int EmpId, [In] int TableId, [In] int CheckId);

    [DispId(64)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int TransferEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int OldCheckId,
      [In] int NewCheckId,
      [In] DateTime OldDOB,
      [In] DateTime NewDOB);

    [DispId(65)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ReportOnEFreqMember([In] int TermId, [In] int EmpId, [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId);

    [DispId(66)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void LookupEFreqMember([In] int TermId, [In] int EmpId, [MarshalAs(UnmanagedType.BStr), In] string LookupText);

    [DispId(67)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void PerformCashDrawerPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] int DrawerId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit);

    [DispId(68)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void PerformCheckoutPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit,
      [In] int DrawerId,
      [In] int TipEmpId,
      [In] double dSales);

    [DispId(69)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ReportOnEFreqMemberOnCheck([In] int TermId, [In] int EmpId, [In] int CheckId);

    [DispId(70)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int GetEmployeeIdFromLoginInfo(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string EmpMagCardPwd);

    [DispId(71)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int AuthorizeOverrideMgr(
      [In] int TermId,
      [In] int ManualMgrNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualMgrPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MgrMagCardPwd);

    [DispId(72)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void StartBreak([In] int TermId, [In] int bIsBreakPaid, [In] int TypeOfBreak);

    [DispId(73)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void EndBreak([In] int TermId);

    [DispId(74)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ChangePassword(
      [In] int TermId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard,
      [In] int bClearOtherEmpsWithSameMagcard);

    [DispId(75)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ClearPassword([In] int TermId, [In] int EmpId);

    [DispId(76)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void DeleteClockout([In] int TermId, [In] int EmpId);

    [DispId(77)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void DeleteCheckout([In] int TermId, [In] int EmpId);

    [DispId(78)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void SetExpiredPassword([In] int TermId, [In] int EmployeeId, [MarshalAs(UnmanagedType.BStr), In] string Password, [In] int bIsMagcard);

    [DispId(79)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    new string LookupDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string QueryXML);

    [DispId(80)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    new string AddDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [DispId(81)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void EditDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [DispId(82)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void DeleteDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [DispId(83)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void AssignDeliveryCustomer([In] int TermId, [In] int CheckId, [In] int QueueId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [DispId(84)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void UnassignDeliveryCustomer([In] int TermId, [In] int CheckId, [In] int QueueId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [DispId(85)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ReopenCheck([In] int TermId, [In] int EmployeeId, [In] int CheckId);

    [DispId(86)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new bool IsTableService();

    [DispId(87)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void RecallOrder([In] int TermId, [In] int QueueId, [In] int TableId);

    [DispId(88)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void AssignDeliveryDriver([In] int TermId, [In] int DriverId, [In] int TableId);

    [DispId(89)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void AddCheckInfo([In] int TermId, [In] int CheckId, [MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.BStr), In] string Value);

    [DispId(90)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void BeginGetCheck([In] int TermId, [In] int CheckId);

    [DispId(91)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void EndGetCheck([In] int TermId);

    [DispId(92)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void StartBreakEx([In] int TermId, [In] int BreakRuleId, [In] int BreakDetailIndex);

    [DispId(93)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ChangePromiseTime([In] int TermId, [In] int CheckId, [In] int PromiseMinutes);

    [DispId(94)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void TaxExemptCheck([In] int TermId, [In] int CheckId, [MarshalAs(UnmanagedType.BStr), In] string TaxId, [In] bool Exempt);

    [DispId(95)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void SetSeatName([In] int TermId, [In] int TableId, [In] int CheckId, [In] int SeatNumber, [MarshalAs(UnmanagedType.BStr), In] string SeatName);

    [DispId(96)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int ApplyMemberPayment(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string MemberNumber,
      [MarshalAs(UnmanagedType.BStr), In] string MagcardData,
      [In] double amount);

    [DispId(97)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void GetEqualPaySplitGuestCount([In] int TermId, [In] int CheckId, out int NumberOfSplits);

    [DispId(98)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void SelectEqualPayGuest([In] int TermId, [In] int CheckId, [In] int GuestToSelect);

    [DispId(99)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int AddRefundTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableNameAsBSTR,
      [In] int NumGuests,
      [In] uint Reason,
      [In] int ManagerId);

    [DispId(100)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    new string GetExtendedEFreqError([In] int TermId);

    [DispId(101)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int CheckCategoryRequirements([In] int TermId, [In] int CheckId);

    [DispId(102)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void BeginGetTable([In] int TermId, [In] int TableNum, [MarshalAs(UnmanagedType.BStr), In] string TableNameAsBSTR);

    [DispId(103)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void EndGetTable([In] int TermId);
  }
}
