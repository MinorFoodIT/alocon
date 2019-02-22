using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("72BFDCCB-3F46-42BF-BDBD-E81CFA185949")]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct EntryObject2
  {
    public uint Id;
    public uint EmpNumber;
    public uint TypeValue;
    public uint Mode;
    public uint Quantity;
    public uint Level;
    public uint Selected;
    public uint Seat;
    public uint Period;
    public uint Routing;
    public uint VRouting;
    public uint TaxId;
    public uint TaxId2;
    public uint ModCode;
    public uint Menu;
    public uint RevenueId;
    public uint TermId;
    public uint Split;
    public uint Origin;
    public double Price;
    public double OPrice;
    public uint Time;
    public uint Changed;
    public uint NoDisplay;
    public uint Stored;
    public uint AffectAvailability;
    public double Weight;
    public uint ItemId;
    [MarshalAs(UnmanagedType.BStr)]
    public string DisplayName;
    [MarshalAs(UnmanagedType.BStr)]
    public string DisplayLongName;
    [MarshalAs(UnmanagedType.BStr)]
    public string DisplayChitName;
    [MarshalAs(UnmanagedType.BStr)]
    public string DisplayPrice;
    [MarshalAs(UnmanagedType.BStr)]
    public string ModString;
    public uint ModChanged;
    public uint ModGroupIdx;
    public double XPrice;
    public uint CashcardAlreadySold;
    public uint PrintedOnHardCheck;
    public uint PrintedVoidOnHardCheck;
    public double Units;
    public double UnitsExtended;
    public uint PromoRealId;
    public double EntryIncGst;
    public double EntryDisc;
    public double EntrySurcharge;
    public double EntrySurchargeUnits;
    public double EntrySurchargeDisc;
    public uint SurchargeId;
    public uint SubtypeValue;
    public uint SubtypeId;
    public uint IsPLU;
    public double amount;
    public double OAmount;
    public double TaxableAmount;
    public double OTaxableAmount;
    public uint StatusMask;
    public double ModAmount;
    public uint ModPosition;
    public uint ExcludeFromDiscount;
    public uint SortLevel;
    public uint ModifierOverride;
    public double OriginalPriceBeforePackagePromo;
    public double OriginalOPriceBeforePackagePromo;
    public double EntryInclusiveTax;
    public double EntryExemptInclusiveTaxable;
    public uint ExemptIncTaxId;
    public uint AutoSendTimeInSecs;
    public uint AutoSendOrderMode;
    public uint PlacedOnHoldCount;
    public uint OriginalTaxId;
    public uint Refill;
    public uint RefillCount;
    public uint PrintRefillCount;
    public uint ModeOfRefillOnHold;
    public uint EntrySplit;
    public uint SKUIndex;
    public uint CourseNumber;
    public uint EntryTime;
    public uint ApplyItmQtyToMods;
    public uint ManualWtUnitPrice;
    public uint InclModPriceSubstItemId;
    public double UnsubPrice;
    public uint IsEntryQualifiedInQC;
    public uint GratuityId;
    public uint PercentGratuity;
    public uint ItemMultiplier;
    public uint DisplayMultiplier;
    public uint IsFamilyStyleAddedItem;
    public uint IsFamilyStyleReorderedItem;
    public uint FamilyStyleAdultCount;
    public uint FamilyStyleChildCount;
    public uint FamilyStyleOrderedAdultCount;
    public uint FamilyStyleOrderedChildCount;
    public uint ReorderApprovalManager;
    public uint ReorderEntryParent;
    public uint FamilyStyleGroupId;
    public uint FamilyStyleSubstituteGroupId;
    public double FamilyStyleMenuItemAdultPrice;
    public double FamilyStyleMenuItemChildPrice;
  }
}
