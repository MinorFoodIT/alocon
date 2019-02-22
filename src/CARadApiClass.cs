using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("CB7D7FBF-B50F-4DAC-884E-516C99EAE7C6")]
  [TypeLibType(2)]
  [ClassInterface(0)]
  [ComImport]
  public class CARadApiClass : IARadApi, CARadApi, IARadApi2, IARadApi3, IARadApi4, IARadApi5, IARadApi6, IARadApi7, IARadApi8, IARadApi9, IARadApi10, IARadApi11, IARadApi12, IARadApi13, IARadRit, IARadApiSetSeatName, IARadApiAddRefundTable, IARadApiSuspendOrderingOnTable, IARadApiGetTable, IARadApiClearDanglingOrderLock, IARadOrderModeCharge, IARadIberFuncs21, IARadIberFuncs22, IARadIberFuncs23, IARadGetExtendedCheckData, IARadQuantityCheckItem, IAtgModifiers, IAtgIberHelper, IAtgAlohaBusinessObjects, IAtgAlohaBusinessObjects2, IARadIberFuncs24, IARadIberFuncs25, IARadIberFuncs26, IARadIberFuncs27, IAtgGetCheckData, IAtgCheckInteraction, IARadTableTransfer, IAtgLaborData, IAtgLaborData2, IAtgSalesData, IAtgSalesData2, IAtgGetTableGuestCount, IAtgCashDrawer, IAtgEFreqHelper, IARadApiGetTable2, IAtgGetAlohaLicense, IAtgBeginItems, IARadApiItemAvailability, IARadApiItemAvailability2, IARadInterfaceTerminalManager, IARadTenderGroups, IARadCheckRounding, IARadTableTransfer2, IARadTippablePayments, IARadCheckItems, IARadIncludedModifiers, IARadApiSeats2, IARadApplyGiftCardPayment, IARadCombineTables, IARadApiQuickComboLevel, IARadGiftCardBalance, IARadVideoBump, IATGDeferredModifiers
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern CARadApiClass();

    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AssignDeliveryDriver([In] int TermId, [In] int DriverId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void RecallOrder([In] int TermId, [In] int QueueId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AddCheckInfo([In] int TermId, [In] int CheckId, [MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.BStr), In] string Value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void QuantityPriceItem(
      [In] int TermId,
      [In] int EntryId,
      [In] double Units,
      [In] bool Weight);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void BeginGetCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void EndGetCheck([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ChangePromiseTime([In] int TermId, [In] int CheckId, [In] int PromiseMinutes);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void TaxExemptCheck([In] int TermId, [In] int CheckId, [MarshalAs(UnmanagedType.BStr), In] string TaxId, [In] bool Exempt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern ICheckEntry[] GetCheckEntries([In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ClearAndCloseCheck([In] int TermId, [In] int CheckId, [In] int VoidReasonId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SetDriverStartMileage([In] int TermId, [In] int DriverId, [In] int Mileage);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SetDriverEndMileage([In] int TermId, [In] int DriverId, [In] int Mileage);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SetHoldTime(
      [In] int TermId,
      [In] int CheckId,
      [In] int HoldMinutes,
      [In] int OrderMode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SplitSeatMoveSelection(
      [In] int TermId,
      [In] int CheckId,
      [In] int SourceSeat,
      [In] int TargetSeat,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AddGratuity([In] int TermId, [In] int CheckId, [In] double dGratuityPercent);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AddEqualPay([In] int TermId, [In] int CheckId, [In] int NumberOfSplits);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int CheckCategoryRequirements([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string GetExtendedEFreqError([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void InitializeRIT(int RitId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SetSeatName(
      [In] int TermId,
      [In] int TableId,
      [In] int CheckId,
      [In] int SeatNumber,
      [MarshalAs(UnmanagedType.BStr), In] string SeatName);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int AddRefundTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableNameAsBSTR,
      [In] int NumGuests,
      [In] uint Reason,
      [In] int ManagerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SuspendOrderingOnTable([In] int TermId, [In] int TableId, [In] int bSuspend);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void BeginGetTable([In] int TermId, [In] int TableNum, [MarshalAs(UnmanagedType.BStr), In] string TableNameAsBSTR);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void EndGetTable([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ClearDanglingOrderLock([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void OverrideOrderModeCharge(
      [In] int TermId,
      [In] int CheckId,
      [In] int OrderModeId,
      [In] double OrderModeCharge);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void RemoveOverrideOrderModeCharge(
      [In] int TermId,
      [In] int CheckId,
      [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double GetCheckTotalWithOrderModeCharge([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SwitchAndDisplayFOHScreen([In] int TermId, [In] int CheckId, [In] int screenID);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void LockTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void UnlockTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int AddTableSavedCard(
      [In] int TermId,
      [In] int QueueId,
      [MarshalAs(UnmanagedType.BStr), In] string trackInfoForTableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int ApplyPaymentSavedCard(
      [In] int TermId,
      [In] int CheckId,
      [In] int TenderId,
      [In] double amount,
      [In] double Tip);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string GetCheckEntriesNew([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void TransferATOOrderToServer([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AddSavedCardToTable([In] int TermId, [In] int TableId, [MarshalAs(UnmanagedType.BStr), In] string TrackInfo);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int IsSavedCardAttached([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DisableHoldFunctionOnFOH(
      [In] int TermId,
      [In] int TableId,
      [In] bool disableFeature);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern ICheckEntryNewEx[] GetCheckEntriesNewEx(
      [In] int TermId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double GetEmployeeCheckoutTotal([In] int TermId, [In] int EmployeeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int GetCloseCheckTermID([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)]
    public virtual extern string[] RepeatSelectedEntries([In] int TermId, [In] int TableId, [In] int Quantity);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int ReplaceModifier(
      [In] int TermId,
      [In] int CheckId,
      [In] int ExistingEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int AddModifier(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [In] int ModifierGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DeleteModifier([In] int TermId, [In] int CheckId, [In] int ModifierEntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ShutdownIber([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ResetLogoutTimer([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern LocalStateObject[] GetCurrentLocalState([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern ItemInfoObject[] GetCurrentLocalStateItemInfo([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_INT)]
    public virtual extern int[] GetAllEntryIdsInLocalState([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern LocalStateObject[] GetLocalStateObjectForCheck(
      [In] int TermId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern LocalStateObject[] GetLocalStateObjectForCheckTable(
      [In] int TermId,
      [In] int CheckId,
      [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_INT)]
    public virtual extern int[] GetPromoItemIds([In] int TermId, [In] int CheckId, [In] int PromoId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_INT)]
    public virtual extern int[] GetAllEntryIdsOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_INT)]
    public virtual extern int[] GetAllCheckIdsOnTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern CompObject[] GetCompObjectOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern PaymentObjectOnCheck[] GetPaymentObjectOnCheck(
      [In] int TermId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern TableObject[] GetTableObject([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern CheckObject[] GetCheckObject([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern EntryObject[] GetEntryObject(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern PromoObject[] GetPromoObjectOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int PromoId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern EntryObject[] GetEntryObjectsOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern PromoObject[] GetPromoObjectsOnCheck([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern LocalStateObject[] IAtgAlohaBusinessObjects2_GetCurrentLocalState(
      [In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern ItemInfoObject[] IAtgAlohaBusinessObjects2_GetCurrentLocalStateItemInfo(
      [In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_INT)]
    public virtual extern int[] IAtgAlohaBusinessObjects2_GetAllEntryIdsInLocalState([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern LocalStateObject[] IAtgAlohaBusinessObjects2_GetLocalStateObjectForCheck(
      [In] int TermId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern LocalStateObject[] IAtgAlohaBusinessObjects2_GetLocalStateObjectForCheckTable(
      [In] int TermId,
      [In] int CheckId,
      [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_INT)]
    public virtual extern int[] IAtgAlohaBusinessObjects2_GetPromoItemIds(
      [In] int TermId,
      [In] int CheckId,
      [In] int PromoId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_INT)]
    public virtual extern int[] IAtgAlohaBusinessObjects2_GetAllEntryIdsOnCheck(
      [In] int TermId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_INT)]
    public virtual extern int[] IAtgAlohaBusinessObjects2_GetAllCheckIdsOnTable(
      [In] int TermId,
      [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern CompObject[] IAtgAlohaBusinessObjects2_GetCompObjectOnCheck(
      [In] int TermId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern PaymentObjectOnCheck[] IAtgAlohaBusinessObjects2_GetPaymentObjectOnCheck(
      [In] int TermId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern TableObject[] IAtgAlohaBusinessObjects2_GetTableObject(
      [In] int TermId,
      [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern CheckObject[] IAtgAlohaBusinessObjects2_GetCheckObject(
      [In] int TermId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern EntryObject[] IAtgAlohaBusinessObjects2_GetEntryObject(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern PromoObject[] IAtgAlohaBusinessObjects2_GetPromoObjectOnCheck(
      [In] int TermId,
      [In] int CheckId,
      [In] int PromoId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern EntryObject[] IAtgAlohaBusinessObjects2_GetEntryObjectsOnCheck(
      [In] int TermId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern PromoObject[] IAtgAlohaBusinessObjects2_GetPromoObjectsOnCheck(
      [In] int TermId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern EntryObject2[] GetEntryObject2(
      [In] int TermId,
      [In] int CheckId,
      [In] int EntryId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern EntryObject2[] GetEntryObjects2OnCheck(
      [In] int TermId,
      [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void TransferTable(
      [In] int TermId,
      [In] int TableId,
      [In] int fromEmployeeId,
      [In] int toEmployeeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AcceptTable(
      [In] int TermId,
      [In] int EmpId,
      [In] int SourceTableId,
      [In] int targetTableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ForcedLockTable([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int AddTableForcedLocked(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ApplyPaymentRoundupAmount(
      [In] int TermId,
      [In] int CheckId,
      [In] int PaymentId,
      [In] double amount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern AtgGetSeatDataObject[] AtgGetSeatData([In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AtgOrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern ITransferDetail[] GetTableTransferDetails([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern AtgLaborDataObject[] AtgGetLaborData([In] int LaborGroupId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern AtgLaborDataObject[] AtgGetLaborData2(
      [In] int IntervalMinutes,
      [In] int LaborGroupId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern AtgSalesDataObject[] AtgGetSalesData([In] int IntervalMinutes);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern AtgSalesDataObject2[] AtgGetSalesData2(
      [In] int IntervalMinutes,
      [In] int unitCountCategory,
      [In] int addOnSalesCategory);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int AtgGetTableGuestCount([In] int EmployeeId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int AtgAssignDrawer(
      [In] int ManagerId,
      [In] int EmployeeId,
      [In] int DrawerId,
      [In] int drawerAction);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int AtgOpenDrawer([In] int DrawerId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ApplyRealTimeDiscountsFromEFreq(
      [In] int TermId,
      [In] int EmployeeId,
      [In] int CheckId,
      [In] int CompTypeId,
      [In] int PromotionId,
      [In] int priceChangeCount,
      [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD), In] ref eFreqPriceChange[] priceChanges);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void RemoveRealTimeEFrequencyDiscounts([In] int TermId, [In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void BeginGetTable2([In] int TermId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void EndGetTable2([In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int GetHaspCode();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int GetNumberLicensedTerminals();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum,
      [In] int MenuID,
      [In] int subMenuId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern ITEM_AVAILABILITY_TYPE GetItemAvailability(
      [In] int TermId,
      [In] int ItemId,
      out int ItemCount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern ITEM_AVAILABILITY_TYPE IARadApiItemAvailability2_GetItemAvailability(
      [In] int TermId,
      [In] int ItemId,
      out int ItemCount);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SetItemAvailability(
      [In] int TermId,
      [In] int EmployeeId,
      [In] int ItemId,
      [In] byte available,
      [In] uint numAvailable);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void MoveAllInterfaceTerminals([In] int fromHost, [In] int toHost);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void MoveInterfaceTerminals([MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_I4), In] int[] interfaceTerminalIds, [In] int toHost);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern AlohaTenderGroup[] GetTenderGroups();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern AlohaTenderGroupTender[] GetTenderGroupTenders();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool IsRoundingActive([In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool IsRoundingAdjustmentDisplayed([In] int CheckId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void GetCheckTotals(
      [In] int CheckId,
      out double Subtotal,
      out double Tax,
      out double RoundingAdjustment);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double GetCheckBalance([In] int CheckId, [In] int TenderId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int AcceptTransfer(
      [In] int TermId,
      [In] int EmpId,
      [In] int SourceTableId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableNameAsBSTR);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern TippablePayment[] GetTippablePayments([In] int EmployeeId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ChangeSize([In] int TermId, [In] int CheckId, [In] int EntryId, [In] int Action);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double GetMenuItemPrice(
      [In] int ItemId,
      [In] int subMenuId,
      [In] int position,
      out bool isItemFound);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern IncludedModifier[] GetIncludedModifiers();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ChangeCurrentlySelectedSeat([In] int TermId, [In] int seatIndex);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int ApplyGiftCardPayment(
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

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void CombineTables(
      [In] int TermId,
      [In] int EmployeeId,
      [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_INT), In] int[] combinedTableDefIdsList);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DetachTables(
      [In] int TermId,
      [In] int EmployeeId,
      [In] int oldPrimaryTableId,
      [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_INT), In] int[] remainingTableDefIdsList);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    public virtual extern CombinedTableGroupDetails[] GetAllCombinedTableGroups(
      [In] int TermId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void QuickComboLevel(
      [In] int TermId,
      [In] int CheckId,
      [In] int Level,
      [In] int currentUpsellPromoID);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void GetGiftCardBalance([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string GiftCardData, [In] int IsSwipe);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void FinalBump([In] int TermId, [In] int VideoId, [In] int TableId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int AddDeferredModifier(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [In] int ModifierGroupId);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DeleteDeferredModifier(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [In] int ModifierGroupId);
  }
}
