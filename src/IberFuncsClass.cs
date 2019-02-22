using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [ClassInterface(0)]
  [TypeLibType(2)]
  [Guid("7F12571F-1A8A-11D3-9225-00105ACA290D")]
  [ComImport]
  public class IberFuncsClass : IIberFuncs20, IberFuncs, IIberFuncs19, IIberFuncs18, IIberFuncs17, IIberFuncs16, IIberFuncs15, IIberFuncs14, IIberFuncs13, IIberFuncs12, IIberFuncs11, IIberFuncs10, IIberFuncs9, IIberFuncs8, IIberFuncs7, IIberFuncs6, IIberFuncs5, IIberFuncs4, IIberFuncs3, IIberFuncs2, IIberFuncs, IIberGiftCardActivation, IIberError
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern IberFuncsClass();

    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void GetCheckTotal([In] int CheckId, out double Subtotal, out double Tax);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double GetDrawerBalance([In] int DrawerId);

    [DispId(4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int LogIn(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [DispId(5)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void LogOut([In] int TermId);

    [DispId(6)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ClockIn([In] int TermId, [In] int JobCodeId);

    [DispId(7)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ClockOut([In] int TermId, [In] double DeclaredTips);

    [DispId(8)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [DispId(9)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int AddTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [DispId(10)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void CloseTable([In] int TermId, [In] int TableId);

    [DispId(11)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int AddCheck([In] int TermId, [In] int TableId);

    [DispId(12)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void CloseCheck([In] int TermId, [In] int CheckId);

    [DispId(13)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [DispId(14)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int ApplyPayment(
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
    public virtual extern int GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [DispId(16)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double GetCheckBalance([In] int TermId, [In] int CheckId);

    [DispId(17)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void PrintCheck([In] int TermId, [In] int CheckId);

    [DispId(18)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price);

    [DispId(19)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [DispId(20)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void EndItem([In] int TermId);

    [DispId(21)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [DispId(22)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void VoidItem([In] int TermId, [In] int CheckId, [In] int EntryId, [In] int VoidReasonId);

    [DispId(23)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ResetTerminal([In] int TermId);

    [DispId(24)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void RefreshCheckDisplay();

    [DispId(25)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SelectAllEntriesOnCheck([In] int TermId, [In] int CheckId);

    [DispId(26)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SelectEntry([In] int TermId, [In] int CheckId, [In] int EntryId);

    [DispId(27)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SelectEntryAndChildren([In] int TermId, [In] int CheckId, [In] int EntryId);

    [DispId(28)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DeselectAllEntries([In] int TermId);

    [DispId(29)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DeselectEntry([In] int TermId, [In] int EntryId);

    [DispId(30)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DeselectEntryAndChildren([In] int TermId, [In] int CheckId, [In] int EntryId);

    [DispId(31)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void HoldUnorderedEntriesOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int SelectedOnly);

    [DispId(32)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int ApplySpecialMessage(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [MarshalAs(UnmanagedType.BStr), In] string Message);

    [DispId(33)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int BeginPivotSeatItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum);

    [DispId(34)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int GetMenuID([In] int TermId);

    [DispId(35)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [DispId(36)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string GetObjectAttribute([In] int ObjectClassId, [In] int ObjectId, [MarshalAs(UnmanagedType.BStr), In] string Name);

    [DispId(37)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string Authenticate([MarshalAs(UnmanagedType.BStr), In] string Input);

    [DispId(38)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AdjustPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int PaymentId,
      [In] double amount,
      [In] double Tip);

    [DispId(39)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DeletePayment([In] int TermId, [In] int CheckId, [In] int PaymentId);

    [DispId(40)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DisplayMessage([MarshalAs(UnmanagedType.BStr), In] string Message);

    [DispId(41)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SendStringToHardware(
      [In] int TermId,
      [In] DEVICE_IDS TypeOfDevice,
      [In] int DeviceID,
      [MarshalAs(UnmanagedType.BStr), In] string StringToSend);

    [DispId(42)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void LogDeboutMessage([MarshalAs(UnmanagedType.BStr), In] string Text);

    [DispId(43)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void GetSeatTotal(
      [In] int EmpId,
      [In] int TableId,
      [In] int SeatNum,
      out double Subtotal,
      out double Tax);

    [DispId(44)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IsPivotSeating([In] int EmpId, [In] int RevId);

    [DispId(45)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int ExceptionModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ExceptionModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [DispId(46)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int GetNewOrder([In] int TermId);

    [DispId(47)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IsDrawerConfirmationNeeded([In] int TermId, [In] int EmployeeId);

    [DispId(48)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int ConfirmDrawerBalance([In] int TermId, [In] int EmployeeId, [In] double dBalance);

    [DispId(49)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int ApplyPromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromotionId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Ident);

    [DispId(50)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DeletePromo([In] int TermId, [In] int ManagerId, [In] int CheckId, [In] int PromoId);

    [DispId(51)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int ApplyComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompTypeId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Unit,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [DispId(52)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DeleteComp([In] int TermId, [In] int ManagerId, [In] int CheckId, [In] int CompId);

    [DispId(53)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void MoveSelectedEntries(
      [In] int TermId,
      [In] int ManagerId,
      [In] int FromCheckId,
      [In] int ToCheckId);

    [DispId(54)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ManagerVoidItem(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [DispId(55)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int ModItemEx(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [DispId(56)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SelectAllEntriesOnCheckWithValue([In] int TermId, [In] int CheckId, [In] int Value);

    [DispId(57)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SelectEntryWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [DispId(58)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SelectEntryAndChildrenWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [DispId(59)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int GetEFreqStatus([In] int TermId, [In] int CheckId);

    [DispId(60)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AssignEFreqMember(
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
    public virtual extern void UnassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [DispId(62)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ReassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [DispId(63)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DeleteEFreqMember([In] int TermId, [In] int EmpId, [In] int TableId, [In] int CheckId);

    [DispId(64)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int TransferEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int OldCheckId,
      [In] int NewCheckId,
      [In] DateTime OldDOB,
      [In] DateTime NewDOB);

    [DispId(65)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ReportOnEFreqMember([In] int TermId, [In] int EmpId, [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId);

    [DispId(66)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void LookupEFreqMember([In] int TermId, [In] int EmpId, [MarshalAs(UnmanagedType.BStr), In] string LookupText);

    [DispId(67)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void PerformCashDrawerPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] int DrawerId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit);

    [DispId(68)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void PerformCheckoutPaidInOut(
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
    public virtual extern void ReportOnEFreqMemberOnCheck([In] int TermId, [In] int EmpId, [In] int CheckId);

    [DispId(70)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int GetEmployeeIdFromLoginInfo(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string EmpMagCardPwd);

    [DispId(71)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int AuthorizeOverrideMgr(
      [In] int TermId,
      [In] int ManualMgrNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualMgrPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MgrMagCardPwd);

    [DispId(72)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void StartBreak([In] int TermId, [In] int bIsBreakPaid, [In] int TypeOfBreak);

    [DispId(73)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void EndBreak([In] int TermId);

    [DispId(74)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ChangePassword(
      [In] int TermId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard,
      [In] int bClearOtherEmpsWithSameMagcard);

    [DispId(75)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ClearPassword([In] int TermId, [In] int EmpId);

    [DispId(76)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DeleteClockout([In] int TermId, [In] int EmpId);

    [DispId(77)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DeleteCheckout([In] int TermId, [In] int EmpId);

    [DispId(78)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SetExpiredPassword(
      [In] int TermId,
      [In] int EmployeeId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard);

    [DispId(79)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string LookupDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string QueryXML);

    [DispId(80)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string AddDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [DispId(81)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void EditDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [DispId(82)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DeleteDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [DispId(83)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AssignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [DispId(84)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void UnassignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [DispId(85)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ReopenCheck([In] int TermId, [In] int EmployeeId, [In] int CheckId);

    [DispId(86)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool IsTableService();

    [DispId(87)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void RecallOrder([In] int TermId, [In] int QueueId, [In] int TableId);

    [DispId(88)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AssignDeliveryDriver([In] int TermId, [In] int DriverId, [In] int TableId);

    [DispId(89)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AddCheckInfo([In] int TermId, [In] int CheckId, [MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.BStr), In] string Value);

    [DispId(90)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void BeginGetCheck([In] int TermId, [In] int CheckId);

    [DispId(91)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void EndGetCheck([In] int TermId);

    [DispId(92)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void StartBreakEx([In] int TermId, [In] int BreakRuleId, [In] int BreakDetailIndex);

    [DispId(93)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ChangePromiseTime([In] int TermId, [In] int CheckId, [In] int PromiseMinutes);

    [DispId(94)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void TaxExemptCheck([In] int TermId, [In] int CheckId, [MarshalAs(UnmanagedType.BStr), In] string TaxId, [In] bool Exempt);

    [DispId(95)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SetSeatName(
      [In] int TermId,
      [In] int TableId,
      [In] int CheckId,
      [In] int SeatNumber,
      [MarshalAs(UnmanagedType.BStr), In] string SeatName);

    [DispId(96)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int ApplyMemberPayment(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string MemberNumber,
      [MarshalAs(UnmanagedType.BStr), In] string MagcardData,
      [In] double amount);

    [DispId(97)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void GetEqualPaySplitGuestCount(
      [In] int TermId,
      [In] int CheckId,
      out int NumberOfSplits);

    [DispId(98)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SelectEqualPayGuest([In] int TermId, [In] int CheckId, [In] int GuestToSelect);

    [DispId(99)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int AddRefundTable(
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
    public virtual extern string GetExtendedEFreqError([In] int TermId);

    [DispId(101)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int CheckCategoryRequirements([In] int TermId, [In] int CheckId);

    [DispId(102)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void BeginGetTable([In] int TermId, [In] int TableNum, [MarshalAs(UnmanagedType.BStr), In] string TableNameAsBSTR);

    [DispId(103)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void EndGetTable([In] int TermId);

    [DispId(104)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ClearDanglingOrderLock([In] int TermId);

    [DispId(109)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AssignPriceChangeToTable(
      [In] int terminalId,
      [In] int TableId,
      [In] int QueueId,
      [In] int priceChangeId);

    [DispId(105)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ManagerVoidSelectedItems(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int VoidReasonId);

    [DispId(106)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void VoidSelectedItems([In] int TermId, [In] int CheckId, [In] int VoidReasonId);

    [DispId(107)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_I4)]
    public virtual extern int[] GetDrawersAssignedToEmployee([In] int EmpId);

    [DispId(108)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_I4)]
    public virtual extern int[] GetEmployeesAssignedToDrawer([In] int DrawerId);

    [DispId(110)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void RenameTab([In] int TermId, [In] int TableId, [MarshalAs(UnmanagedType.BStr), In] string tabNameAsBSTR);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_GetCheckTotal(
      [In] int CheckId,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs19_GetDrawerBalance([In] int DrawerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_LogIn(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_LogOut([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_ClockIn([In] int TermId, [In] int JobCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_ClockOut([In] int TermId, [In] double DeclaredTips);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_AddTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_CloseTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_AddCheck([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_CloseCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_ApplyPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string AuthCode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs19_GetCheckBalance([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_PrintCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_EndItem([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_VoidItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_ResetTerminal([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_RefreshCheckDisplay();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_SelectAllEntriesOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_SelectEntry([In] int TermId, [In] int CheckId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_SelectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_DeselectAllEntries([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_DeselectEntry([In] int TermId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_DeselectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_HoldUnorderedEntriesOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int SelectedOnly);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_ApplySpecialMessage(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_BeginPivotSeatItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_GetMenuID([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_SetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs19_GetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs19_Authenticate([MarshalAs(UnmanagedType.BStr), In] string Input);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_AdjustPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int PaymentId,
      [In] double amount,
      [In] double Tip);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_DeletePayment([In] int TermId, [In] int CheckId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_DisplayMessage([MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_SendStringToHardware(
      [In] int TermId,
      [In] DEVICE_IDS TypeOfDevice,
      [In] int DeviceID,
      [MarshalAs(UnmanagedType.BStr), In] string StringToSend);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_LogDeboutMessage([MarshalAs(UnmanagedType.BStr), In] string Text);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_GetSeatTotal(
      [In] int EmpId,
      [In] int TableId,
      [In] int SeatNum,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_IsPivotSeating([In] int EmpId, [In] int RevId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_ExceptionModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ExceptionModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_GetNewOrder([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_IsDrawerConfirmationNeeded([In] int TermId, [In] int EmployeeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_ConfirmDrawerBalance(
      [In] int TermId,
      [In] int EmployeeId,
      [In] double dBalance);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_ApplyPromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromotionId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Ident);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_DeletePromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromoId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_ApplyComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompTypeId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Unit,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_DeleteComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_MoveSelectedEntries(
      [In] int TermId,
      [In] int ManagerId,
      [In] int FromCheckId,
      [In] int ToCheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_ManagerVoidItem(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_ModItemEx(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_SelectAllEntriesOnCheckWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_SelectEntryWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_SelectEntryAndChildrenWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_GetEFreqStatus([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_AssignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqTrackInfo,
      [In] int MgrIdOverrideMaxChecks,
      [In] int MgrIdOverrideMagCardOnly,
      [In] int MgrIdOverrideSeriesUse);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_UnassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_ReassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_DeleteEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_TransferEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int OldCheckId,
      [In] int NewCheckId,
      [In] DateTime OldDOB,
      [In] DateTime NewDOB);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_ReportOnEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_LookupEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string LookupText);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_PerformCashDrawerPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] int DrawerId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_PerformCheckoutPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit,
      [In] int DrawerId,
      [In] int TipEmpId,
      [In] double dSales);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_ReportOnEFreqMemberOnCheck(
      [In] int TermId,
      [In] int EmpId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_GetEmployeeIdFromLoginInfo(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string EmpMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_AuthorizeOverrideMgr(
      [In] int TermId,
      [In] int ManualMgrNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualMgrPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MgrMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_StartBreak(
      [In] int TermId,
      [In] int bIsBreakPaid,
      [In] int TypeOfBreak);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_EndBreak([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_ChangePassword(
      [In] int TermId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard,
      [In] int bClearOtherEmpsWithSameMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_ClearPassword([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_DeleteClockout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_DeleteCheckout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_SetExpiredPassword(
      [In] int TermId,
      [In] int EmployeeId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs19_LookupDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string QueryXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs19_AddDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_EditDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_DeleteDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_AssignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_UnassignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_ReopenCheck([In] int TermId, [In] int EmployeeId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool IIberFuncs19_IsTableService();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_RecallOrder([In] int TermId, [In] int QueueId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_AssignDeliveryDriver(
      [In] int TermId,
      [In] int DriverId,
      [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_AddCheckInfo(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_BeginGetCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_EndGetCheck([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_StartBreakEx(
      [In] int TermId,
      [In] int BreakRuleId,
      [In] int BreakDetailIndex);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_ChangePromiseTime(
      [In] int TermId,
      [In] int CheckId,
      [In] int PromiseMinutes);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_TaxExemptCheck(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string TaxId,
      [In] bool Exempt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_SetSeatName(
      [In] int TermId,
      [In] int TableId,
      [In] int CheckId,
      [In] int SeatNumber,
      [MarshalAs(UnmanagedType.BStr), In] string SeatName);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_ApplyMemberPayment(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string MemberNumber,
      [MarshalAs(UnmanagedType.BStr), In] string MagcardData,
      [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_GetEqualPaySplitGuestCount(
      [In] int TermId,
      [In] int CheckId,
      out int NumberOfSplits);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_SelectEqualPayGuest(
      [In] int TermId,
      [In] int CheckId,
      [In] int GuestToSelect);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_AddRefundTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableNameAsBSTR,
      [In] int NumGuests,
      [In] uint Reason,
      [In] int ManagerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs19_GetExtendedEFreqError([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs19_CheckCategoryRequirements([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_BeginGetTable(
      [In] int TermId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableNameAsBSTR);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_EndGetTable([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_ClearDanglingOrderLock([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs19_AssignPriceChangeToTable(
      [In] int terminalId,
      [In] int TableId,
      [In] int QueueId,
      [In] int priceChangeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_GetCheckTotal(
      [In] int CheckId,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs18_GetDrawerBalance([In] int DrawerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_LogIn(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_LogOut([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_ClockIn([In] int TermId, [In] int JobCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_ClockOut([In] int TermId, [In] double DeclaredTips);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_AddTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_CloseTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_AddCheck([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_CloseCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_ApplyPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string AuthCode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs18_GetCheckBalance([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_PrintCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_EndItem([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_VoidItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_ResetTerminal([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_RefreshCheckDisplay();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_SelectAllEntriesOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_SelectEntry([In] int TermId, [In] int CheckId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_SelectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_DeselectAllEntries([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_DeselectEntry([In] int TermId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_DeselectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_HoldUnorderedEntriesOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int SelectedOnly);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_ApplySpecialMessage(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_BeginPivotSeatItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_GetMenuID([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_SetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs18_GetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs18_Authenticate([MarshalAs(UnmanagedType.BStr), In] string Input);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_AdjustPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int PaymentId,
      [In] double amount,
      [In] double Tip);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_DeletePayment([In] int TermId, [In] int CheckId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_DisplayMessage([MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_SendStringToHardware(
      [In] int TermId,
      [In] DEVICE_IDS TypeOfDevice,
      [In] int DeviceID,
      [MarshalAs(UnmanagedType.BStr), In] string StringToSend);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_LogDeboutMessage([MarshalAs(UnmanagedType.BStr), In] string Text);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_GetSeatTotal(
      [In] int EmpId,
      [In] int TableId,
      [In] int SeatNum,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_IsPivotSeating([In] int EmpId, [In] int RevId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_ExceptionModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ExceptionModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_GetNewOrder([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_IsDrawerConfirmationNeeded([In] int TermId, [In] int EmployeeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_ConfirmDrawerBalance(
      [In] int TermId,
      [In] int EmployeeId,
      [In] double dBalance);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_ApplyPromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromotionId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Ident);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_DeletePromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromoId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_ApplyComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompTypeId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Unit,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_DeleteComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_MoveSelectedEntries(
      [In] int TermId,
      [In] int ManagerId,
      [In] int FromCheckId,
      [In] int ToCheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_ManagerVoidItem(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_ModItemEx(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_SelectAllEntriesOnCheckWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_SelectEntryWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_SelectEntryAndChildrenWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_GetEFreqStatus([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_AssignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqTrackInfo,
      [In] int MgrIdOverrideMaxChecks,
      [In] int MgrIdOverrideMagCardOnly,
      [In] int MgrIdOverrideSeriesUse);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_UnassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_ReassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_DeleteEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_TransferEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int OldCheckId,
      [In] int NewCheckId,
      [In] DateTime OldDOB,
      [In] DateTime NewDOB);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_ReportOnEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_LookupEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string LookupText);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_PerformCashDrawerPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] int DrawerId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_PerformCheckoutPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit,
      [In] int DrawerId,
      [In] int TipEmpId,
      [In] double dSales);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_ReportOnEFreqMemberOnCheck(
      [In] int TermId,
      [In] int EmpId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_GetEmployeeIdFromLoginInfo(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string EmpMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_AuthorizeOverrideMgr(
      [In] int TermId,
      [In] int ManualMgrNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualMgrPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MgrMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_StartBreak(
      [In] int TermId,
      [In] int bIsBreakPaid,
      [In] int TypeOfBreak);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_EndBreak([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_ChangePassword(
      [In] int TermId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard,
      [In] int bClearOtherEmpsWithSameMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_ClearPassword([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_DeleteClockout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_DeleteCheckout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_SetExpiredPassword(
      [In] int TermId,
      [In] int EmployeeId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs18_LookupDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string QueryXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs18_AddDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_EditDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_DeleteDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_AssignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_UnassignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_ReopenCheck([In] int TermId, [In] int EmployeeId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool IIberFuncs18_IsTableService();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_RecallOrder([In] int TermId, [In] int QueueId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_AssignDeliveryDriver(
      [In] int TermId,
      [In] int DriverId,
      [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_AddCheckInfo(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_BeginGetCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_EndGetCheck([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_StartBreakEx(
      [In] int TermId,
      [In] int BreakRuleId,
      [In] int BreakDetailIndex);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_ChangePromiseTime(
      [In] int TermId,
      [In] int CheckId,
      [In] int PromiseMinutes);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_TaxExemptCheck(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string TaxId,
      [In] bool Exempt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_SetSeatName(
      [In] int TermId,
      [In] int TableId,
      [In] int CheckId,
      [In] int SeatNumber,
      [MarshalAs(UnmanagedType.BStr), In] string SeatName);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_ApplyMemberPayment(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string MemberNumber,
      [MarshalAs(UnmanagedType.BStr), In] string MagcardData,
      [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_GetEqualPaySplitGuestCount(
      [In] int TermId,
      [In] int CheckId,
      out int NumberOfSplits);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_SelectEqualPayGuest(
      [In] int TermId,
      [In] int CheckId,
      [In] int GuestToSelect);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_AddRefundTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableNameAsBSTR,
      [In] int NumGuests,
      [In] uint Reason,
      [In] int ManagerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs18_GetExtendedEFreqError([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs18_CheckCategoryRequirements([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_BeginGetTable(
      [In] int TermId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableNameAsBSTR);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_EndGetTable([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs18_ClearDanglingOrderLock([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_GetCheckTotal(
      [In] int CheckId,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs17_GetDrawerBalance([In] int DrawerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_LogIn(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_LogOut([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_ClockIn([In] int TermId, [In] int JobCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_ClockOut([In] int TermId, [In] double DeclaredTips);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_AddTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_CloseTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_AddCheck([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_CloseCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_ApplyPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string AuthCode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs17_GetCheckBalance([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_PrintCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_EndItem([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_VoidItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_ResetTerminal([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_RefreshCheckDisplay();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_SelectAllEntriesOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_SelectEntry([In] int TermId, [In] int CheckId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_SelectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_DeselectAllEntries([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_DeselectEntry([In] int TermId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_DeselectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_HoldUnorderedEntriesOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int SelectedOnly);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_ApplySpecialMessage(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_BeginPivotSeatItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_GetMenuID([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_SetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs17_GetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs17_Authenticate([MarshalAs(UnmanagedType.BStr), In] string Input);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_AdjustPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int PaymentId,
      [In] double amount,
      [In] double Tip);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_DeletePayment([In] int TermId, [In] int CheckId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_DisplayMessage([MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_SendStringToHardware(
      [In] int TermId,
      [In] DEVICE_IDS TypeOfDevice,
      [In] int DeviceID,
      [MarshalAs(UnmanagedType.BStr), In] string StringToSend);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_LogDeboutMessage([MarshalAs(UnmanagedType.BStr), In] string Text);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_GetSeatTotal(
      [In] int EmpId,
      [In] int TableId,
      [In] int SeatNum,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_IsPivotSeating([In] int EmpId, [In] int RevId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_ExceptionModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ExceptionModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_GetNewOrder([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_IsDrawerConfirmationNeeded([In] int TermId, [In] int EmployeeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_ConfirmDrawerBalance(
      [In] int TermId,
      [In] int EmployeeId,
      [In] double dBalance);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_ApplyPromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromotionId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Ident);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_DeletePromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromoId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_ApplyComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompTypeId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Unit,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_DeleteComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_MoveSelectedEntries(
      [In] int TermId,
      [In] int ManagerId,
      [In] int FromCheckId,
      [In] int ToCheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_ManagerVoidItem(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_ModItemEx(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_SelectAllEntriesOnCheckWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_SelectEntryWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_SelectEntryAndChildrenWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_GetEFreqStatus([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_AssignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqTrackInfo,
      [In] int MgrIdOverrideMaxChecks,
      [In] int MgrIdOverrideMagCardOnly,
      [In] int MgrIdOverrideSeriesUse);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_UnassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_ReassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_DeleteEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_TransferEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int OldCheckId,
      [In] int NewCheckId,
      [In] DateTime OldDOB,
      [In] DateTime NewDOB);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_ReportOnEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_LookupEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string LookupText);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_PerformCashDrawerPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] int DrawerId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_PerformCheckoutPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit,
      [In] int DrawerId,
      [In] int TipEmpId,
      [In] double dSales);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_ReportOnEFreqMemberOnCheck(
      [In] int TermId,
      [In] int EmpId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_GetEmployeeIdFromLoginInfo(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string EmpMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_AuthorizeOverrideMgr(
      [In] int TermId,
      [In] int ManualMgrNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualMgrPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MgrMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_StartBreak(
      [In] int TermId,
      [In] int bIsBreakPaid,
      [In] int TypeOfBreak);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_EndBreak([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_ChangePassword(
      [In] int TermId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard,
      [In] int bClearOtherEmpsWithSameMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_ClearPassword([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_DeleteClockout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_DeleteCheckout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_SetExpiredPassword(
      [In] int TermId,
      [In] int EmployeeId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs17_LookupDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string QueryXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs17_AddDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_EditDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_DeleteDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_AssignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_UnassignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_ReopenCheck([In] int TermId, [In] int EmployeeId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool IIberFuncs17_IsTableService();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_RecallOrder([In] int TermId, [In] int QueueId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_AssignDeliveryDriver(
      [In] int TermId,
      [In] int DriverId,
      [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_AddCheckInfo(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_BeginGetCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_EndGetCheck([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_StartBreakEx(
      [In] int TermId,
      [In] int BreakRuleId,
      [In] int BreakDetailIndex);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_ChangePromiseTime(
      [In] int TermId,
      [In] int CheckId,
      [In] int PromiseMinutes);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_TaxExemptCheck(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string TaxId,
      [In] bool Exempt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_SetSeatName(
      [In] int TermId,
      [In] int TableId,
      [In] int CheckId,
      [In] int SeatNumber,
      [MarshalAs(UnmanagedType.BStr), In] string SeatName);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_ApplyMemberPayment(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string MemberNumber,
      [MarshalAs(UnmanagedType.BStr), In] string MagcardData,
      [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_GetEqualPaySplitGuestCount(
      [In] int TermId,
      [In] int CheckId,
      out int NumberOfSplits);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_SelectEqualPayGuest(
      [In] int TermId,
      [In] int CheckId,
      [In] int GuestToSelect);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_AddRefundTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableNameAsBSTR,
      [In] int NumGuests,
      [In] uint Reason,
      [In] int ManagerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs17_GetExtendedEFreqError([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs17_CheckCategoryRequirements([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_BeginGetTable(
      [In] int TermId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableNameAsBSTR);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs17_EndGetTable([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_GetCheckTotal(
      [In] int CheckId,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs16_GetDrawerBalance([In] int DrawerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_LogIn(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_LogOut([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_ClockIn([In] int TermId, [In] int JobCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_ClockOut([In] int TermId, [In] double DeclaredTips);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_AddTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_CloseTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_AddCheck([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_CloseCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_ApplyPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string AuthCode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs16_GetCheckBalance([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_PrintCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_EndItem([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_VoidItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_ResetTerminal([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_RefreshCheckDisplay();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_SelectAllEntriesOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_SelectEntry([In] int TermId, [In] int CheckId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_SelectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_DeselectAllEntries([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_DeselectEntry([In] int TermId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_DeselectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_HoldUnorderedEntriesOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int SelectedOnly);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_ApplySpecialMessage(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_BeginPivotSeatItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_GetMenuID([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_SetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs16_GetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs16_Authenticate([MarshalAs(UnmanagedType.BStr), In] string Input);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_AdjustPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int PaymentId,
      [In] double amount,
      [In] double Tip);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_DeletePayment([In] int TermId, [In] int CheckId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_DisplayMessage([MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_SendStringToHardware(
      [In] int TermId,
      [In] DEVICE_IDS TypeOfDevice,
      [In] int DeviceID,
      [MarshalAs(UnmanagedType.BStr), In] string StringToSend);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_LogDeboutMessage([MarshalAs(UnmanagedType.BStr), In] string Text);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_GetSeatTotal(
      [In] int EmpId,
      [In] int TableId,
      [In] int SeatNum,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_IsPivotSeating([In] int EmpId, [In] int RevId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_ExceptionModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ExceptionModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_GetNewOrder([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_IsDrawerConfirmationNeeded([In] int TermId, [In] int EmployeeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_ConfirmDrawerBalance(
      [In] int TermId,
      [In] int EmployeeId,
      [In] double dBalance);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_ApplyPromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromotionId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Ident);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_DeletePromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromoId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_ApplyComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompTypeId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Unit,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_DeleteComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_MoveSelectedEntries(
      [In] int TermId,
      [In] int ManagerId,
      [In] int FromCheckId,
      [In] int ToCheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_ManagerVoidItem(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_ModItemEx(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_SelectAllEntriesOnCheckWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_SelectEntryWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_SelectEntryAndChildrenWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_GetEFreqStatus([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_AssignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqTrackInfo,
      [In] int MgrIdOverrideMaxChecks,
      [In] int MgrIdOverrideMagCardOnly,
      [In] int MgrIdOverrideSeriesUse);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_UnassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_ReassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_DeleteEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_TransferEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int OldCheckId,
      [In] int NewCheckId,
      [In] DateTime OldDOB,
      [In] DateTime NewDOB);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_ReportOnEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_LookupEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string LookupText);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_PerformCashDrawerPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] int DrawerId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_PerformCheckoutPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit,
      [In] int DrawerId,
      [In] int TipEmpId,
      [In] double dSales);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_ReportOnEFreqMemberOnCheck(
      [In] int TermId,
      [In] int EmpId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_GetEmployeeIdFromLoginInfo(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string EmpMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_AuthorizeOverrideMgr(
      [In] int TermId,
      [In] int ManualMgrNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualMgrPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MgrMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_StartBreak(
      [In] int TermId,
      [In] int bIsBreakPaid,
      [In] int TypeOfBreak);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_EndBreak([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_ChangePassword(
      [In] int TermId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard,
      [In] int bClearOtherEmpsWithSameMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_ClearPassword([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_DeleteClockout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_DeleteCheckout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_SetExpiredPassword(
      [In] int TermId,
      [In] int EmployeeId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs16_LookupDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string QueryXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs16_AddDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_EditDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_DeleteDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_AssignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_UnassignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_ReopenCheck([In] int TermId, [In] int EmployeeId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool IIberFuncs16_IsTableService();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_RecallOrder([In] int TermId, [In] int QueueId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_AssignDeliveryDriver(
      [In] int TermId,
      [In] int DriverId,
      [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_AddCheckInfo(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_BeginGetCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_EndGetCheck([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_StartBreakEx(
      [In] int TermId,
      [In] int BreakRuleId,
      [In] int BreakDetailIndex);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_ChangePromiseTime(
      [In] int TermId,
      [In] int CheckId,
      [In] int PromiseMinutes);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_TaxExemptCheck(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string TaxId,
      [In] bool Exempt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_SetSeatName(
      [In] int TermId,
      [In] int TableId,
      [In] int CheckId,
      [In] int SeatNumber,
      [MarshalAs(UnmanagedType.BStr), In] string SeatName);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_ApplyMemberPayment(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string MemberNumber,
      [MarshalAs(UnmanagedType.BStr), In] string MagcardData,
      [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_GetEqualPaySplitGuestCount(
      [In] int TermId,
      [In] int CheckId,
      out int NumberOfSplits);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs16_SelectEqualPayGuest(
      [In] int TermId,
      [In] int CheckId,
      [In] int GuestToSelect);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_AddRefundTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableNameAsBSTR,
      [In] int NumGuests,
      [In] uint Reason,
      [In] int ManagerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs16_GetExtendedEFreqError([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs16_CheckCategoryRequirements([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_GetCheckTotal(
      [In] int CheckId,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs15_GetDrawerBalance([In] int DrawerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_LogIn(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_LogOut([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_ClockIn([In] int TermId, [In] int JobCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_ClockOut([In] int TermId, [In] double DeclaredTips);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_AddTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_CloseTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_AddCheck([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_CloseCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_ApplyPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string AuthCode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs15_GetCheckBalance([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_PrintCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_EndItem([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_VoidItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_ResetTerminal([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_RefreshCheckDisplay();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_SelectAllEntriesOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_SelectEntry([In] int TermId, [In] int CheckId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_SelectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_DeselectAllEntries([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_DeselectEntry([In] int TermId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_DeselectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_HoldUnorderedEntriesOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int SelectedOnly);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_ApplySpecialMessage(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_BeginPivotSeatItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_GetMenuID([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_SetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs15_GetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs15_Authenticate([MarshalAs(UnmanagedType.BStr), In] string Input);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_AdjustPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int PaymentId,
      [In] double amount,
      [In] double Tip);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_DeletePayment([In] int TermId, [In] int CheckId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_DisplayMessage([MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_SendStringToHardware(
      [In] int TermId,
      [In] DEVICE_IDS TypeOfDevice,
      [In] int DeviceID,
      [MarshalAs(UnmanagedType.BStr), In] string StringToSend);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_LogDeboutMessage([MarshalAs(UnmanagedType.BStr), In] string Text);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_GetSeatTotal(
      [In] int EmpId,
      [In] int TableId,
      [In] int SeatNum,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_IsPivotSeating([In] int EmpId, [In] int RevId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_ExceptionModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ExceptionModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_GetNewOrder([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_IsDrawerConfirmationNeeded([In] int TermId, [In] int EmployeeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_ConfirmDrawerBalance(
      [In] int TermId,
      [In] int EmployeeId,
      [In] double dBalance);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_ApplyPromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromotionId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Ident);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_DeletePromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromoId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_ApplyComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompTypeId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Unit,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_DeleteComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_MoveSelectedEntries(
      [In] int TermId,
      [In] int ManagerId,
      [In] int FromCheckId,
      [In] int ToCheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_ManagerVoidItem(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_ModItemEx(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_SelectAllEntriesOnCheckWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_SelectEntryWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_SelectEntryAndChildrenWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_GetEFreqStatus([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_AssignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqTrackInfo,
      [In] int MgrIdOverrideMaxChecks,
      [In] int MgrIdOverrideMagCardOnly,
      [In] int MgrIdOverrideSeriesUse);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_UnassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_ReassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_DeleteEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_TransferEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int OldCheckId,
      [In] int NewCheckId,
      [In] DateTime OldDOB,
      [In] DateTime NewDOB);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_ReportOnEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_LookupEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string LookupText);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_PerformCashDrawerPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] int DrawerId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_PerformCheckoutPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit,
      [In] int DrawerId,
      [In] int TipEmpId,
      [In] double dSales);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_ReportOnEFreqMemberOnCheck(
      [In] int TermId,
      [In] int EmpId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_GetEmployeeIdFromLoginInfo(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string EmpMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_AuthorizeOverrideMgr(
      [In] int TermId,
      [In] int ManualMgrNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualMgrPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MgrMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_StartBreak(
      [In] int TermId,
      [In] int bIsBreakPaid,
      [In] int TypeOfBreak);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_EndBreak([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_ChangePassword(
      [In] int TermId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard,
      [In] int bClearOtherEmpsWithSameMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_ClearPassword([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_DeleteClockout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_DeleteCheckout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_SetExpiredPassword(
      [In] int TermId,
      [In] int EmployeeId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs15_LookupDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string QueryXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs15_AddDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_EditDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_DeleteDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_AssignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_UnassignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_ReopenCheck([In] int TermId, [In] int EmployeeId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool IIberFuncs15_IsTableService();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_RecallOrder([In] int TermId, [In] int QueueId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_AssignDeliveryDriver(
      [In] int TermId,
      [In] int DriverId,
      [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_AddCheckInfo(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_BeginGetCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_EndGetCheck([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_StartBreakEx(
      [In] int TermId,
      [In] int BreakRuleId,
      [In] int BreakDetailIndex);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_ChangePromiseTime(
      [In] int TermId,
      [In] int CheckId,
      [In] int PromiseMinutes);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_TaxExemptCheck(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string TaxId,
      [In] bool Exempt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_SetSeatName(
      [In] int TermId,
      [In] int TableId,
      [In] int CheckId,
      [In] int SeatNumber,
      [MarshalAs(UnmanagedType.BStr), In] string SeatName);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs15_ApplyMemberPayment(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string MemberNumber,
      [MarshalAs(UnmanagedType.BStr), In] string MagcardData,
      [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_GetEqualPaySplitGuestCount(
      [In] int TermId,
      [In] int CheckId,
      out int NumberOfSplits);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs15_SelectEqualPayGuest(
      [In] int TermId,
      [In] int CheckId,
      [In] int GuestToSelect);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_GetCheckTotal(
      [In] int CheckId,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs14_GetDrawerBalance([In] int DrawerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_LogIn(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_LogOut([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_ClockIn([In] int TermId, [In] int JobCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_ClockOut([In] int TermId, [In] double DeclaredTips);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_AddTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_CloseTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_AddCheck([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_CloseCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_ApplyPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string AuthCode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs14_GetCheckBalance([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_PrintCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_EndItem([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_VoidItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_ResetTerminal([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_RefreshCheckDisplay();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_SelectAllEntriesOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_SelectEntry([In] int TermId, [In] int CheckId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_SelectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_DeselectAllEntries([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_DeselectEntry([In] int TermId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_DeselectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_HoldUnorderedEntriesOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int SelectedOnly);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_ApplySpecialMessage(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_BeginPivotSeatItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_GetMenuID([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_SetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs14_GetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs14_Authenticate([MarshalAs(UnmanagedType.BStr), In] string Input);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_AdjustPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int PaymentId,
      [In] double amount,
      [In] double Tip);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_DeletePayment([In] int TermId, [In] int CheckId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_DisplayMessage([MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_SendStringToHardware(
      [In] int TermId,
      [In] DEVICE_IDS TypeOfDevice,
      [In] int DeviceID,
      [MarshalAs(UnmanagedType.BStr), In] string StringToSend);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_LogDeboutMessage([MarshalAs(UnmanagedType.BStr), In] string Text);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_GetSeatTotal(
      [In] int EmpId,
      [In] int TableId,
      [In] int SeatNum,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_IsPivotSeating([In] int EmpId, [In] int RevId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_ExceptionModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ExceptionModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_GetNewOrder([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_IsDrawerConfirmationNeeded([In] int TermId, [In] int EmployeeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_ConfirmDrawerBalance(
      [In] int TermId,
      [In] int EmployeeId,
      [In] double dBalance);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_ApplyPromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromotionId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Ident);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_DeletePromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromoId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_ApplyComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompTypeId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Unit,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_DeleteComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_MoveSelectedEntries(
      [In] int TermId,
      [In] int ManagerId,
      [In] int FromCheckId,
      [In] int ToCheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_ManagerVoidItem(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_ModItemEx(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_SelectAllEntriesOnCheckWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_SelectEntryWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_SelectEntryAndChildrenWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_GetEFreqStatus([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_AssignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqTrackInfo,
      [In] int MgrIdOverrideMaxChecks,
      [In] int MgrIdOverrideMagCardOnly,
      [In] int MgrIdOverrideSeriesUse);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_UnassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_ReassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_DeleteEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_TransferEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int OldCheckId,
      [In] int NewCheckId,
      [In] DateTime OldDOB,
      [In] DateTime NewDOB);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_ReportOnEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_LookupEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string LookupText);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_PerformCashDrawerPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] int DrawerId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_PerformCheckoutPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit,
      [In] int DrawerId,
      [In] int TipEmpId,
      [In] double dSales);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_ReportOnEFreqMemberOnCheck(
      [In] int TermId,
      [In] int EmpId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_GetEmployeeIdFromLoginInfo(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string EmpMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs14_AuthorizeOverrideMgr(
      [In] int TermId,
      [In] int ManualMgrNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualMgrPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MgrMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_StartBreak(
      [In] int TermId,
      [In] int bIsBreakPaid,
      [In] int TypeOfBreak);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_EndBreak([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_ChangePassword(
      [In] int TermId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard,
      [In] int bClearOtherEmpsWithSameMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_ClearPassword([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_DeleteClockout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_DeleteCheckout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_SetExpiredPassword(
      [In] int TermId,
      [In] int EmployeeId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs14_LookupDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string QueryXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs14_AddDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_EditDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_DeleteDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_AssignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_UnassignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_ReopenCheck([In] int TermId, [In] int EmployeeId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool IIberFuncs14_IsTableService();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_RecallOrder([In] int TermId, [In] int QueueId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_AssignDeliveryDriver(
      [In] int TermId,
      [In] int DriverId,
      [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_AddCheckInfo(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_BeginGetCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_EndGetCheck([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_StartBreakEx(
      [In] int TermId,
      [In] int BreakRuleId,
      [In] int BreakDetailIndex);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_ChangePromiseTime(
      [In] int TermId,
      [In] int CheckId,
      [In] int PromiseMinutes);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_TaxExemptCheck(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string TaxId,
      [In] bool Exempt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs14_SetSeatName(
      [In] int TermId,
      [In] int TableId,
      [In] int CheckId,
      [In] int SeatNumber,
      [MarshalAs(UnmanagedType.BStr), In] string SeatName);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_GetCheckTotal(
      [In] int CheckId,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs13_GetDrawerBalance([In] int DrawerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_LogIn(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_LogOut([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_ClockIn([In] int TermId, [In] int JobCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_ClockOut([In] int TermId, [In] double DeclaredTips);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_AddTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_CloseTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_AddCheck([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_CloseCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_ApplyPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string AuthCode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs13_GetCheckBalance([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_PrintCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_EndItem([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_VoidItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_ResetTerminal([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_RefreshCheckDisplay();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_SelectAllEntriesOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_SelectEntry([In] int TermId, [In] int CheckId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_SelectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_DeselectAllEntries([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_DeselectEntry([In] int TermId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_DeselectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_HoldUnorderedEntriesOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int SelectedOnly);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_ApplySpecialMessage(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_BeginPivotSeatItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_GetMenuID([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_SetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs13_GetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs13_Authenticate([MarshalAs(UnmanagedType.BStr), In] string Input);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_AdjustPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int PaymentId,
      [In] double amount,
      [In] double Tip);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_DeletePayment([In] int TermId, [In] int CheckId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_DisplayMessage([MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_SendStringToHardware(
      [In] int TermId,
      [In] DEVICE_IDS TypeOfDevice,
      [In] int DeviceID,
      [MarshalAs(UnmanagedType.BStr), In] string StringToSend);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_LogDeboutMessage([MarshalAs(UnmanagedType.BStr), In] string Text);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_GetSeatTotal(
      [In] int EmpId,
      [In] int TableId,
      [In] int SeatNum,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_IsPivotSeating([In] int EmpId, [In] int RevId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_ExceptionModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ExceptionModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_GetNewOrder([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_IsDrawerConfirmationNeeded([In] int TermId, [In] int EmployeeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_ConfirmDrawerBalance(
      [In] int TermId,
      [In] int EmployeeId,
      [In] double dBalance);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_ApplyPromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromotionId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Ident);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_DeletePromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromoId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_ApplyComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompTypeId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Unit,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_DeleteComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_MoveSelectedEntries(
      [In] int TermId,
      [In] int ManagerId,
      [In] int FromCheckId,
      [In] int ToCheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_ManagerVoidItem(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_ModItemEx(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_SelectAllEntriesOnCheckWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_SelectEntryWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_SelectEntryAndChildrenWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_GetEFreqStatus([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_AssignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqTrackInfo,
      [In] int MgrIdOverrideMaxChecks,
      [In] int MgrIdOverrideMagCardOnly,
      [In] int MgrIdOverrideSeriesUse);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_UnassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_ReassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_DeleteEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_TransferEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int OldCheckId,
      [In] int NewCheckId,
      [In] DateTime OldDOB,
      [In] DateTime NewDOB);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_ReportOnEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_LookupEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string LookupText);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_PerformCashDrawerPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] int DrawerId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_PerformCheckoutPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit,
      [In] int DrawerId,
      [In] int TipEmpId,
      [In] double dSales);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_ReportOnEFreqMemberOnCheck(
      [In] int TermId,
      [In] int EmpId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_GetEmployeeIdFromLoginInfo(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string EmpMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs13_AuthorizeOverrideMgr(
      [In] int TermId,
      [In] int ManualMgrNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualMgrPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MgrMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_StartBreak(
      [In] int TermId,
      [In] int bIsBreakPaid,
      [In] int TypeOfBreak);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_EndBreak([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_ChangePassword(
      [In] int TermId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard,
      [In] int bClearOtherEmpsWithSameMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_ClearPassword([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_DeleteClockout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_DeleteCheckout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_SetExpiredPassword(
      [In] int TermId,
      [In] int EmployeeId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs13_LookupDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string QueryXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs13_AddDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_EditDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_DeleteDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_AssignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_UnassignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_ReopenCheck([In] int TermId, [In] int EmployeeId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool IIberFuncs13_IsTableService();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_RecallOrder([In] int TermId, [In] int QueueId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_AssignDeliveryDriver(
      [In] int TermId,
      [In] int DriverId,
      [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_AddCheckInfo(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_BeginGetCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_EndGetCheck([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_StartBreakEx(
      [In] int TermId,
      [In] int BreakRuleId,
      [In] int BreakDetailIndex);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_ChangePromiseTime(
      [In] int TermId,
      [In] int CheckId,
      [In] int PromiseMinutes);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs13_TaxExemptCheck(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string TaxId,
      [In] bool Exempt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_GetCheckTotal(
      [In] int CheckId,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs12_GetDrawerBalance([In] int DrawerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_LogIn(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_LogOut([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_ClockIn([In] int TermId, [In] int JobCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_ClockOut([In] int TermId, [In] double DeclaredTips);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_AddTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_CloseTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_AddCheck([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_CloseCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_ApplyPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string AuthCode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs12_GetCheckBalance([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_PrintCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_EndItem([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_VoidItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_ResetTerminal([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_RefreshCheckDisplay();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_SelectAllEntriesOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_SelectEntry([In] int TermId, [In] int CheckId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_SelectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_DeselectAllEntries([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_DeselectEntry([In] int TermId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_DeselectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_HoldUnorderedEntriesOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int SelectedOnly);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_ApplySpecialMessage(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_BeginPivotSeatItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_GetMenuID([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_SetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs12_GetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs12_Authenticate([MarshalAs(UnmanagedType.BStr), In] string Input);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_AdjustPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int PaymentId,
      [In] double amount,
      [In] double Tip);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_DeletePayment([In] int TermId, [In] int CheckId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_DisplayMessage([MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_SendStringToHardware(
      [In] int TermId,
      [In] DEVICE_IDS TypeOfDevice,
      [In] int DeviceID,
      [MarshalAs(UnmanagedType.BStr), In] string StringToSend);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_LogDeboutMessage([MarshalAs(UnmanagedType.BStr), In] string Text);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_GetSeatTotal(
      [In] int EmpId,
      [In] int TableId,
      [In] int SeatNum,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_IsPivotSeating([In] int EmpId, [In] int RevId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_ExceptionModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ExceptionModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_GetNewOrder([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_IsDrawerConfirmationNeeded([In] int TermId, [In] int EmployeeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_ConfirmDrawerBalance(
      [In] int TermId,
      [In] int EmployeeId,
      [In] double dBalance);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_ApplyPromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromotionId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Ident);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_DeletePromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromoId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_ApplyComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompTypeId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Unit,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_DeleteComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_MoveSelectedEntries(
      [In] int TermId,
      [In] int ManagerId,
      [In] int FromCheckId,
      [In] int ToCheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_ManagerVoidItem(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_ModItemEx(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_SelectAllEntriesOnCheckWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_SelectEntryWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_SelectEntryAndChildrenWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_GetEFreqStatus([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_AssignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqTrackInfo,
      [In] int MgrIdOverrideMaxChecks,
      [In] int MgrIdOverrideMagCardOnly,
      [In] int MgrIdOverrideSeriesUse);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_UnassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_ReassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_DeleteEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_TransferEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int OldCheckId,
      [In] int NewCheckId,
      [In] DateTime OldDOB,
      [In] DateTime NewDOB);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_ReportOnEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_LookupEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string LookupText);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_PerformCashDrawerPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] int DrawerId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_PerformCheckoutPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit,
      [In] int DrawerId,
      [In] int TipEmpId,
      [In] double dSales);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_ReportOnEFreqMemberOnCheck(
      [In] int TermId,
      [In] int EmpId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_GetEmployeeIdFromLoginInfo(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string EmpMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs12_AuthorizeOverrideMgr(
      [In] int TermId,
      [In] int ManualMgrNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualMgrPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MgrMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_StartBreak(
      [In] int TermId,
      [In] int bIsBreakPaid,
      [In] int TypeOfBreak);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_EndBreak([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_ChangePassword(
      [In] int TermId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard,
      [In] int bClearOtherEmpsWithSameMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_ClearPassword([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_DeleteClockout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_DeleteCheckout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_SetExpiredPassword(
      [In] int TermId,
      [In] int EmployeeId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs12_LookupDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string QueryXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs12_AddDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_EditDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_DeleteDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_AssignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_UnassignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_ReopenCheck([In] int TermId, [In] int EmployeeId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool IIberFuncs12_IsTableService();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_RecallOrder([In] int TermId, [In] int QueueId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_AssignDeliveryDriver(
      [In] int TermId,
      [In] int DriverId,
      [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_AddCheckInfo(
      [In] int TermId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_BeginGetCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_EndGetCheck([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs12_StartBreakEx(
      [In] int TermId,
      [In] int BreakRuleId,
      [In] int BreakDetailIndex);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_GetCheckTotal(
      [In] int CheckId,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs11_GetDrawerBalance([In] int DrawerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_LogIn(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_LogOut([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_ClockIn([In] int TermId, [In] int JobCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_ClockOut([In] int TermId, [In] double DeclaredTips);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_AddTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_CloseTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_AddCheck([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_CloseCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_ApplyPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string AuthCode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs11_GetCheckBalance([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_PrintCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_EndItem([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_VoidItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_ResetTerminal([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_RefreshCheckDisplay();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_SelectAllEntriesOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_SelectEntry([In] int TermId, [In] int CheckId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_SelectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_DeselectAllEntries([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_DeselectEntry([In] int TermId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_DeselectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_HoldUnorderedEntriesOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int SelectedOnly);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_ApplySpecialMessage(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_BeginPivotSeatItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_GetMenuID([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_SetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs11_GetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs11_Authenticate([MarshalAs(UnmanagedType.BStr), In] string Input);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_AdjustPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int PaymentId,
      [In] double amount,
      [In] double Tip);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_DeletePayment([In] int TermId, [In] int CheckId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_DisplayMessage([MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_SendStringToHardware(
      [In] int TermId,
      [In] DEVICE_IDS TypeOfDevice,
      [In] int DeviceID,
      [MarshalAs(UnmanagedType.BStr), In] string StringToSend);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_LogDeboutMessage([MarshalAs(UnmanagedType.BStr), In] string Text);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_GetSeatTotal(
      [In] int EmpId,
      [In] int TableId,
      [In] int SeatNum,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_IsPivotSeating([In] int EmpId, [In] int RevId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_ExceptionModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ExceptionModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_GetNewOrder([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_IsDrawerConfirmationNeeded([In] int TermId, [In] int EmployeeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_ConfirmDrawerBalance(
      [In] int TermId,
      [In] int EmployeeId,
      [In] double dBalance);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_ApplyPromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromotionId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Ident);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_DeletePromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromoId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_ApplyComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompTypeId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Unit,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_DeleteComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_MoveSelectedEntries(
      [In] int TermId,
      [In] int ManagerId,
      [In] int FromCheckId,
      [In] int ToCheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_ManagerVoidItem(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_ModItemEx(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_SelectAllEntriesOnCheckWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_SelectEntryWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_SelectEntryAndChildrenWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_GetEFreqStatus([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_AssignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqTrackInfo,
      [In] int MgrIdOverrideMaxChecks,
      [In] int MgrIdOverrideMagCardOnly,
      [In] int MgrIdOverrideSeriesUse);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_UnassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_ReassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_DeleteEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_TransferEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int OldCheckId,
      [In] int NewCheckId,
      [In] DateTime OldDOB,
      [In] DateTime NewDOB);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_ReportOnEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_LookupEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string LookupText);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_PerformCashDrawerPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] int DrawerId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_PerformCheckoutPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit,
      [In] int DrawerId,
      [In] int TipEmpId,
      [In] double dSales);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_ReportOnEFreqMemberOnCheck(
      [In] int TermId,
      [In] int EmpId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_GetEmployeeIdFromLoginInfo(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string EmpMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs11_AuthorizeOverrideMgr(
      [In] int TermId,
      [In] int ManualMgrNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualMgrPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MgrMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_StartBreak(
      [In] int TermId,
      [In] int bIsBreakPaid,
      [In] int TypeOfBreak);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_EndBreak([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_ChangePassword(
      [In] int TermId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard,
      [In] int bClearOtherEmpsWithSameMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_ClearPassword([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_DeleteClockout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_DeleteCheckout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_SetExpiredPassword(
      [In] int TermId,
      [In] int EmployeeId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs11_LookupDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string QueryXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs11_AddDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_EditDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_DeleteDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_AssignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_UnassignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_ReopenCheck([In] int TermId, [In] int EmployeeId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool IIberFuncs11_IsTableService();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_RecallOrder([In] int TermId, [In] int QueueId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs11_AssignDeliveryDriver(
      [In] int TermId,
      [In] int DriverId,
      [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_GetCheckTotal(
      [In] int CheckId,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs10_GetDrawerBalance([In] int DrawerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_LogIn(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_LogOut([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_ClockIn([In] int TermId, [In] int JobCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_ClockOut([In] int TermId, [In] double DeclaredTips);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_AddTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_CloseTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_AddCheck([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_CloseCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_ApplyPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string AuthCode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs10_GetCheckBalance([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_PrintCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_EndItem([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_VoidItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_ResetTerminal([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_RefreshCheckDisplay();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_SelectAllEntriesOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_SelectEntry([In] int TermId, [In] int CheckId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_SelectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_DeselectAllEntries([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_DeselectEntry([In] int TermId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_DeselectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_HoldUnorderedEntriesOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int SelectedOnly);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_ApplySpecialMessage(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_BeginPivotSeatItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_GetMenuID([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_SetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs10_GetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs10_Authenticate([MarshalAs(UnmanagedType.BStr), In] string Input);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_AdjustPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int PaymentId,
      [In] double amount,
      [In] double Tip);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_DeletePayment([In] int TermId, [In] int CheckId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_DisplayMessage([MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_SendStringToHardware(
      [In] int TermId,
      [In] DEVICE_IDS TypeOfDevice,
      [In] int DeviceID,
      [MarshalAs(UnmanagedType.BStr), In] string StringToSend);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_LogDeboutMessage([MarshalAs(UnmanagedType.BStr), In] string Text);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_GetSeatTotal(
      [In] int EmpId,
      [In] int TableId,
      [In] int SeatNum,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_IsPivotSeating([In] int EmpId, [In] int RevId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_ExceptionModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ExceptionModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_GetNewOrder([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_IsDrawerConfirmationNeeded([In] int TermId, [In] int EmployeeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_ConfirmDrawerBalance(
      [In] int TermId,
      [In] int EmployeeId,
      [In] double dBalance);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_ApplyPromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromotionId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Ident);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_DeletePromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromoId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_ApplyComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompTypeId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Unit,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_DeleteComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_MoveSelectedEntries(
      [In] int TermId,
      [In] int ManagerId,
      [In] int FromCheckId,
      [In] int ToCheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_ManagerVoidItem(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_ModItemEx(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_SelectAllEntriesOnCheckWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_SelectEntryWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_SelectEntryAndChildrenWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_GetEFreqStatus([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_AssignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqTrackInfo,
      [In] int MgrIdOverrideMaxChecks,
      [In] int MgrIdOverrideMagCardOnly,
      [In] int MgrIdOverrideSeriesUse);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_UnassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_ReassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_DeleteEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_TransferEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int OldCheckId,
      [In] int NewCheckId,
      [In] DateTime OldDOB,
      [In] DateTime NewDOB);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_ReportOnEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_LookupEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string LookupText);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_PerformCashDrawerPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] int DrawerId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_PerformCheckoutPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit,
      [In] int DrawerId,
      [In] int TipEmpId,
      [In] double dSales);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_ReportOnEFreqMemberOnCheck(
      [In] int TermId,
      [In] int EmpId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_GetEmployeeIdFromLoginInfo(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string EmpMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs10_AuthorizeOverrideMgr(
      [In] int TermId,
      [In] int ManualMgrNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualMgrPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MgrMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_StartBreak(
      [In] int TermId,
      [In] int bIsBreakPaid,
      [In] int TypeOfBreak);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_EndBreak([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_ChangePassword(
      [In] int TermId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard,
      [In] int bClearOtherEmpsWithSameMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_ClearPassword([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_DeleteClockout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_DeleteCheckout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_SetExpiredPassword(
      [In] int TermId,
      [In] int EmployeeId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs10_LookupDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string QueryXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs10_AddDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_EditDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_DeleteDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_AssignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_UnassignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs10_ReopenCheck([In] int TermId, [In] int EmployeeId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_GetCheckTotal(
      [In] int CheckId,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs9_GetDrawerBalance([In] int DrawerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_LogIn(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_LogOut([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_ClockIn([In] int TermId, [In] int JobCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_ClockOut([In] int TermId, [In] double DeclaredTips);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_AddTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_CloseTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_AddCheck([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_CloseCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_ApplyPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string AuthCode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs9_GetCheckBalance([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_PrintCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_EndItem([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_VoidItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_ResetTerminal([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_RefreshCheckDisplay();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_SelectAllEntriesOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_SelectEntry([In] int TermId, [In] int CheckId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_SelectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_DeselectAllEntries([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_DeselectEntry([In] int TermId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_DeselectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_HoldUnorderedEntriesOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int SelectedOnly);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_ApplySpecialMessage(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_BeginPivotSeatItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_GetMenuID([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_SetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs9_GetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs9_Authenticate([MarshalAs(UnmanagedType.BStr), In] string Input);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_AdjustPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int PaymentId,
      [In] double amount,
      [In] double Tip);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_DeletePayment([In] int TermId, [In] int CheckId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_DisplayMessage([MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_SendStringToHardware(
      [In] int TermId,
      [In] DEVICE_IDS TypeOfDevice,
      [In] int DeviceID,
      [MarshalAs(UnmanagedType.BStr), In] string StringToSend);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_LogDeboutMessage([MarshalAs(UnmanagedType.BStr), In] string Text);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_GetSeatTotal(
      [In] int EmpId,
      [In] int TableId,
      [In] int SeatNum,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_IsPivotSeating([In] int EmpId, [In] int RevId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_ExceptionModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ExceptionModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_GetNewOrder([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_IsDrawerConfirmationNeeded([In] int TermId, [In] int EmployeeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_ConfirmDrawerBalance(
      [In] int TermId,
      [In] int EmployeeId,
      [In] double dBalance);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_ApplyPromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromotionId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Ident);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_DeletePromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromoId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_ApplyComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompTypeId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Unit,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_DeleteComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_MoveSelectedEntries(
      [In] int TermId,
      [In] int ManagerId,
      [In] int FromCheckId,
      [In] int ToCheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_ManagerVoidItem(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_ModItemEx(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_SelectAllEntriesOnCheckWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_SelectEntryWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_SelectEntryAndChildrenWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_GetEFreqStatus([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_AssignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqTrackInfo,
      [In] int MgrIdOverrideMaxChecks,
      [In] int MgrIdOverrideMagCardOnly,
      [In] int MgrIdOverrideSeriesUse);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_UnassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_ReassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_DeleteEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_TransferEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int OldCheckId,
      [In] int NewCheckId,
      [In] DateTime OldDOB,
      [In] DateTime NewDOB);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_ReportOnEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_LookupEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string LookupText);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_PerformCashDrawerPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] int DrawerId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_PerformCheckoutPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit,
      [In] int DrawerId,
      [In] int TipEmpId,
      [In] double dSales);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_ReportOnEFreqMemberOnCheck(
      [In] int TermId,
      [In] int EmpId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_GetEmployeeIdFromLoginInfo(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string EmpMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs9_AuthorizeOverrideMgr(
      [In] int TermId,
      [In] int ManualMgrNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualMgrPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MgrMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_StartBreak(
      [In] int TermId,
      [In] int bIsBreakPaid,
      [In] int TypeOfBreak);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_EndBreak([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_ChangePassword(
      [In] int TermId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard,
      [In] int bClearOtherEmpsWithSameMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_ClearPassword([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_DeleteClockout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_DeleteCheckout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_SetExpiredPassword(
      [In] int TermId,
      [In] int EmployeeId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs9_LookupDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string QueryXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs9_AddDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_EditDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_DeleteDeliveryCustomer([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_AssignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs9_UnassignDeliveryCustomer(
      [In] int TermId,
      [In] int CheckId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string DataXML);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_GetCheckTotal(
      [In] int CheckId,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs8_GetDrawerBalance([In] int DrawerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_LogIn(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_LogOut([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_ClockIn([In] int TermId, [In] int JobCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_ClockOut([In] int TermId, [In] double DeclaredTips);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_AddTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_CloseTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_AddCheck([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_CloseCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_ApplyPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string AuthCode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs8_GetCheckBalance([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_PrintCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_EndItem([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_VoidItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_ResetTerminal([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_RefreshCheckDisplay();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_SelectAllEntriesOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_SelectEntry([In] int TermId, [In] int CheckId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_SelectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_DeselectAllEntries([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_DeselectEntry([In] int TermId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_DeselectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_HoldUnorderedEntriesOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int SelectedOnly);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_ApplySpecialMessage(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_BeginPivotSeatItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_GetMenuID([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_SetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs8_GetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs8_Authenticate([MarshalAs(UnmanagedType.BStr), In] string Input);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_AdjustPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int PaymentId,
      [In] double amount,
      [In] double Tip);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_DeletePayment([In] int TermId, [In] int CheckId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_DisplayMessage([MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_SendStringToHardware(
      [In] int TermId,
      [In] DEVICE_IDS TypeOfDevice,
      [In] int DeviceID,
      [MarshalAs(UnmanagedType.BStr), In] string StringToSend);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_LogDeboutMessage([MarshalAs(UnmanagedType.BStr), In] string Text);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_GetSeatTotal(
      [In] int EmpId,
      [In] int TableId,
      [In] int SeatNum,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_IsPivotSeating([In] int EmpId, [In] int RevId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_ExceptionModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ExceptionModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_GetNewOrder([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_IsDrawerConfirmationNeeded([In] int TermId, [In] int EmployeeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_ConfirmDrawerBalance(
      [In] int TermId,
      [In] int EmployeeId,
      [In] double dBalance);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_ApplyPromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromotionId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Ident);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_DeletePromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromoId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_ApplyComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompTypeId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Unit,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_DeleteComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_MoveSelectedEntries(
      [In] int TermId,
      [In] int ManagerId,
      [In] int FromCheckId,
      [In] int ToCheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_ManagerVoidItem(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_ModItemEx(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_SelectAllEntriesOnCheckWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_SelectEntryWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_SelectEntryAndChildrenWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_GetEFreqStatus([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_AssignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqTrackInfo,
      [In] int MgrIdOverrideMaxChecks,
      [In] int MgrIdOverrideMagCardOnly,
      [In] int MgrIdOverrideSeriesUse);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_UnassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_ReassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_DeleteEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_TransferEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int OldCheckId,
      [In] int NewCheckId,
      [In] DateTime OldDOB,
      [In] DateTime NewDOB);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_ReportOnEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_LookupEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string LookupText);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_PerformCashDrawerPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] int DrawerId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_PerformCheckoutPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit,
      [In] int DrawerId,
      [In] int TipEmpId,
      [In] double dSales);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_ReportOnEFreqMemberOnCheck(
      [In] int TermId,
      [In] int EmpId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_GetEmployeeIdFromLoginInfo(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string EmpMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs8_AuthorizeOverrideMgr(
      [In] int TermId,
      [In] int ManualMgrNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualMgrPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MgrMagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_StartBreak(
      [In] int TermId,
      [In] int bIsBreakPaid,
      [In] int TypeOfBreak);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_EndBreak([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_ChangePassword(
      [In] int TermId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard,
      [In] int bClearOtherEmpsWithSameMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_ClearPassword([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_DeleteClockout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_DeleteCheckout([In] int TermId, [In] int EmpId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs8_SetExpiredPassword(
      [In] int TermId,
      [In] int EmployeeId,
      [MarshalAs(UnmanagedType.BStr), In] string Password,
      [In] int bIsMagcard);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_GetCheckTotal(
      [In] int CheckId,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs7_GetDrawerBalance([In] int DrawerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_LogIn(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_LogOut([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_ClockIn([In] int TermId, [In] int JobCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_ClockOut([In] int TermId, [In] double DeclaredTips);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_AddTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_CloseTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_AddCheck([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_CloseCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_ApplyPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string AuthCode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs7_GetCheckBalance([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_PrintCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_EndItem([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_VoidItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_ResetTerminal([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_RefreshCheckDisplay();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_SelectAllEntriesOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_SelectEntry([In] int TermId, [In] int CheckId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_SelectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_DeselectAllEntries([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_DeselectEntry([In] int TermId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_DeselectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_HoldUnorderedEntriesOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int SelectedOnly);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_ApplySpecialMessage(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_BeginPivotSeatItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_GetMenuID([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_SetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs7_GetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs7_Authenticate([MarshalAs(UnmanagedType.BStr), In] string Input);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_AdjustPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int PaymentId,
      [In] double amount,
      [In] double Tip);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_DeletePayment([In] int TermId, [In] int CheckId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_DisplayMessage([MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_SendStringToHardware(
      [In] int TermId,
      [In] DEVICE_IDS TypeOfDevice,
      [In] int DeviceID,
      [MarshalAs(UnmanagedType.BStr), In] string StringToSend);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_LogDeboutMessage([MarshalAs(UnmanagedType.BStr), In] string Text);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_GetSeatTotal(
      [In] int EmpId,
      [In] int TableId,
      [In] int SeatNum,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_IsPivotSeating([In] int EmpId, [In] int RevId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_ExceptionModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ExceptionModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_GetNewOrder([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_IsDrawerConfirmationNeeded([In] int TermId, [In] int EmployeeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_ConfirmDrawerBalance(
      [In] int TermId,
      [In] int EmployeeId,
      [In] double dBalance);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_ApplyPromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromotionId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Ident);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_DeletePromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromoId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_ApplyComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompTypeId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Unit,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_DeleteComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_MoveSelectedEntries(
      [In] int TermId,
      [In] int ManagerId,
      [In] int FromCheckId,
      [In] int ToCheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_ManagerVoidItem(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_ModItemEx(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_SelectAllEntriesOnCheckWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_SelectEntryWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_SelectEntryAndChildrenWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_GetEFreqStatus([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_AssignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqTrackInfo,
      [In] int MgrIdOverrideMaxChecks,
      [In] int MgrIdOverrideMagCardOnly,
      [In] int MgrIdOverrideSeriesUse);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_UnassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_ReassignEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_DeleteEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs7_TransferEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [In] int TableId,
      [In] int OldCheckId,
      [In] int NewCheckId,
      [In] DateTime OldDOB,
      [In] DateTime NewDOB);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_ReportOnEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string EFreqMemberId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_LookupEFreqMember(
      [In] int TermId,
      [In] int EmpId,
      [MarshalAs(UnmanagedType.BStr), In] string LookupText);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_PerformCashDrawerPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] int DrawerId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_PerformCheckoutPaidInOut(
      [In] int TermId,
      [In] int EmpId,
      [In] int MgrId,
      [In] double dAmount,
      [In] int PetId,
      [In] int bPrintChit,
      [In] int DrawerId,
      [In] int TipEmpId,
      [In] double dSales);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs7_ReportOnEFreqMemberOnCheck(
      [In] int TermId,
      [In] int EmpId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs6_EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_GetCheckTotal(
      [In] int CheckId,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs6_GetDrawerBalance([In] int DrawerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs6_LogIn(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_LogOut([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_ClockIn([In] int TermId, [In] int JobCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_ClockOut([In] int TermId, [In] double DeclaredTips);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs6_AddTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_CloseTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs6_AddCheck([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_CloseCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs6_ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs6_ApplyPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string AuthCode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs6_GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs6_GetCheckBalance([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_PrintCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs6_BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs6_ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_EndItem([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_VoidItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_ResetTerminal([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_RefreshCheckDisplay();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_SelectAllEntriesOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_SelectEntry([In] int TermId, [In] int CheckId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_SelectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_DeselectAllEntries([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_DeselectEntry([In] int TermId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_DeselectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_HoldUnorderedEntriesOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int SelectedOnly);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs6_ApplySpecialMessage(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs6_BeginPivotSeatItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs6_GetMenuID([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_SetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs6_GetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs6_Authenticate([MarshalAs(UnmanagedType.BStr), In] string Input);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_AdjustPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int PaymentId,
      [In] double amount,
      [In] double Tip);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_DeletePayment([In] int TermId, [In] int CheckId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_DisplayMessage([MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_SendStringToHardware(
      [In] int TermId,
      [In] DEVICE_IDS TypeOfDevice,
      [In] int DeviceID,
      [MarshalAs(UnmanagedType.BStr), In] string StringToSend);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_LogDeboutMessage([MarshalAs(UnmanagedType.BStr), In] string Text);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_GetSeatTotal(
      [In] int EmpId,
      [In] int TableId,
      [In] int SeatNum,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs6_IsPivotSeating([In] int EmpId, [In] int RevId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs6_ExceptionModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ExceptionModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs6_GetNewOrder([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs6_IsDrawerConfirmationNeeded([In] int TermId, [In] int EmployeeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs6_ConfirmDrawerBalance(
      [In] int TermId,
      [In] int EmployeeId,
      [In] double dBalance);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs6_ApplyPromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromotionId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Ident);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_DeletePromo(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int PromoId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs6_ApplyComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompTypeId,
      [In] double dAmount,
      [MarshalAs(UnmanagedType.BStr), In] string Unit,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_DeleteComp(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int CompId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_MoveSelectedEntries(
      [In] int TermId,
      [In] int ManagerId,
      [In] int FromCheckId,
      [In] int ToCheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_ManagerVoidItem(
      [In] int TermId,
      [In] int ManagerId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs6_ModItemEx(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ModGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_SelectAllEntriesOnCheckWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_SelectEntryWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs6_SelectEntryAndChildrenWithValue(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs5_EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_GetCheckTotal(
      [In] int CheckId,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs5_GetDrawerBalance([In] int DrawerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs5_LogIn(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_LogOut([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_ClockIn([In] int TermId, [In] int JobCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_ClockOut([In] int TermId, [In] double DeclaredTips);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs5_AddTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_CloseTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs5_AddCheck([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_CloseCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs5_ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs5_ApplyPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string AuthCode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs5_GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs5_GetCheckBalance([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_PrintCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs5_BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs5_ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_EndItem([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_VoidItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_ResetTerminal([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_RefreshCheckDisplay();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_SelectAllEntriesOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_SelectEntry([In] int TermId, [In] int CheckId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_SelectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_DeselectAllEntries([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_DeselectEntry([In] int TermId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_DeselectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_HoldUnorderedEntriesOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int SelectedOnly);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs5_ApplySpecialMessage(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs5_BeginPivotSeatItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs5_GetMenuID([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_SetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs5_GetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs5_Authenticate([MarshalAs(UnmanagedType.BStr), In] string Input);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_AdjustPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int PaymentId,
      [In] double amount,
      [In] double Tip);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_DeletePayment([In] int TermId, [In] int CheckId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_DisplayMessage([MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_SendStringToHardware(
      [In] int TermId,
      [In] DEVICE_IDS TypeOfDevice,
      [In] int DeviceID,
      [MarshalAs(UnmanagedType.BStr), In] string StringToSend);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_LogDeboutMessage([MarshalAs(UnmanagedType.BStr), In] string Text);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs5_GetSeatTotal(
      [In] int EmpId,
      [In] int TableId,
      [In] int SeatNum,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs5_IsPivotSeating([In] int EmpId, [In] int RevId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs4_EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_GetCheckTotal(
      [In] int CheckId,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs4_GetDrawerBalance([In] int DrawerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs4_LogIn(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_LogOut([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_ClockIn([In] int TermId, [In] int JobCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_ClockOut([In] int TermId, [In] double DeclaredTips);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs4_AddTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_CloseTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs4_AddCheck([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_CloseCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs4_ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs4_ApplyPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string AuthCode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs4_GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs4_GetCheckBalance([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_PrintCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs4_BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs4_ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_EndItem([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_VoidItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_ResetTerminal([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_RefreshCheckDisplay();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_SelectAllEntriesOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_SelectEntry([In] int TermId, [In] int CheckId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_SelectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_DeselectAllEntries([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_DeselectEntry([In] int TermId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_DeselectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_HoldUnorderedEntriesOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int SelectedOnly);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs4_ApplySpecialMessage(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs4_BeginPivotSeatItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs4_GetMenuID([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_SetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name,
      [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs4_GetObjectAttribute(
      [In] int ObjectClassId,
      [In] int ObjectId,
      [MarshalAs(UnmanagedType.BStr), In] string Name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string IIberFuncs4_Authenticate([MarshalAs(UnmanagedType.BStr), In] string Input);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_AdjustPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int PaymentId,
      [In] double amount,
      [In] double Tip);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_DeletePayment([In] int TermId, [In] int CheckId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs4_DisplayMessage([MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs3_EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs3_GetCheckTotal(
      [In] int CheckId,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs3_GetDrawerBalance([In] int DrawerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs3_LogIn(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs3_LogOut([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs3_ClockIn([In] int TermId, [In] int JobCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs3_ClockOut([In] int TermId, [In] double DeclaredTips);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs3_PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs3_AddTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs3_CloseTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs3_AddCheck([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs3_CloseCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs3_ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs3_ApplyPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string AuthCode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs3_GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs3_GetCheckBalance([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs3_PrintCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs3_BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs3_ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs3_EndItem([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs3_OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs3_VoidItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs3_ResetTerminal([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs3_RefreshCheckDisplay();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs3_SelectAllEntriesOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs3_SelectEntry([In] int TermId, [In] int CheckId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs3_SelectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs3_DeselectAllEntries([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs3_DeselectEntry([In] int TermId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs3_DeselectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs3_HoldUnorderedEntriesOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int SelectedOnly);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs3_ApplySpecialMessage(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs3_BeginPivotSeatItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs3_GetMenuID([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs2_EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs2_GetCheckTotal(
      [In] int CheckId,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs2_GetDrawerBalance([In] int DrawerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs2_LogIn(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs2_LogOut([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs2_ClockIn([In] int TermId, [In] int JobCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs2_ClockOut([In] int TermId, [In] double DeclaredTips);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs2_PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs2_AddTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs2_CloseTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs2_AddCheck([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs2_CloseCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs2_ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs2_ApplyPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string AuthCode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs2_GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs2_GetCheckBalance([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs2_PrintCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs2_BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs2_ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs2_EndItem([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs2_OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs2_VoidItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs2_ResetTerminal([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs2_RefreshCheckDisplay();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs2_SelectAllEntriesOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs2_SelectEntry([In] int TermId, [In] int CheckId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs2_SelectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs2_DeselectAllEntries([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs2_DeselectEntry([In] int TermId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs2_DeselectEntryAndChildren(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs2_HoldUnorderedEntriesOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int SelectedOnly);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs2_ApplySpecialMessage(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [MarshalAs(UnmanagedType.BStr), In] string Message);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs_EnterItem([In] int CheckId, [In] int ItemNum, [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs_GetCheckTotal(
      [In] int CheckId,
      out double Subtotal,
      out double Tax);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs_GetDrawerBalance([In] int DrawerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs_LogIn(
      [In] int TermId,
      [In] int ManualEmpNum,
      [MarshalAs(UnmanagedType.BStr), In] string ManualEmpPwd,
      [MarshalAs(UnmanagedType.BStr), In] string MagCardPwd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs_LogOut([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs_ClockIn([In] int TermId, [In] int JobCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs_ClockOut([In] int TermId, [In] double DeclaredTips);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs_PerformCheckout([In] int TermId, [In] double DeclaredCash);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs_AddTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs_CloseTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs_AddCheck([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs_CloseCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs_ApplyCashPayment([In] int TermId, [In] int CheckId, [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs_ApplyPayment(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip,
      [MarshalAs(UnmanagedType.BStr), In] string CardId,
      [MarshalAs(UnmanagedType.BStr), In] string ExpDate,
      [MarshalAs(UnmanagedType.BStr), In] string TrackInfo,
      [MarshalAs(UnmanagedType.BStr), In] string AuthCode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs_GetPaymentStatus([In] int TermId, [In] int PaymentId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double IIberFuncs_GetCheckBalance([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs_PrintCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs_BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IIberFuncs_ModItem(
      [In] int TermId,
      [In] int ParentEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs_EndItem([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs_OrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs_VoidItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId,
      [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs_ResetTerminal([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IIberFuncs_RefreshCheckDisplay();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void QueryGiftCardBalance([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string GiftCardData, [In] bool IsSwipe);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void VoidGiftCard([In] int TermId, [In] int TableId, [In] int CheckId, [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int GetGiftCardActivationStatus(
      [In] int TermId,
      [In] int GiftCardId,
      [MarshalAs(UnmanagedType.BStr)] out string Reason);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int SaleGiftCard(
      [In] int TermId,
      [In] int TableId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string GiftCardData,
      [In] bool IsSwipe,
      [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int SaleGiftCardRange(
      [In] int TermId,
      [In] int TableId,
      [In] int CheckId,
      [In] int ItemId,
      [In] double amount,
      [In] int Quantity,
      [MarshalAs(UnmanagedType.BStr), In] string GiftCardDataStart,
      [MarshalAs(UnmanagedType.BStr), In] string GiftCardDataEnd,
      [In] bool IsSwipe);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string GetComErrorMessage([MarshalAs(UnmanagedType.Error), In] int errorCode);
  }
}
