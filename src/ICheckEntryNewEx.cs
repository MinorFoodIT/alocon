using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("14A35495-3664-4ABF-8D40-3724C7E2BA1B")]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct ICheckEntryNewEx
  {
    public int entryIdEx;
    public int itemIdEx;
    public uint modeEx;
    public int original_idEx;
    public uint bIsEntryQualifiedInQCEx;
    public uint bIsPLUEx;
    public uint bManualWtUnitPriceEx;
    public uint bModifierOverrideEx;
    public uint bRefillEx;
    public uint bPrintedVoidOnHardCheckEx;
    public uint modGroupIdxEx;
    public uint nCourseNumberEx;
    public int nPlacedOnHoldCountEx;
    public uint seatEx;
    public uint modifierCodeEx;
    public uint levelEx;
    public double priceEx;
    public double unitsEx;
    [MarshalAs(UnmanagedType.BStr)]
    public string displayNameEx;
    [MarshalAs(UnmanagedType.BStr)]
    public string longDisplayNameEx;
    public uint menuItemIdEx;
    public uint modifierGroupIdEx;
    public uint entryTypeEx;
    public uint periodEx;
    public uint routingEx;
    public uint rev_idEx;
    public uint term_idEx;
    public uint originEx;
    public double opriceEx;
    public double xpriceEx;
    public uint splitEx;
    public uint tax_idEx;
    public double entry_inc_gstEx;
    public double entry_discEx;
    public double entry_surchargeEx;
    public double entry_surcharge_unitsEx;
    public double entry_surcharge_discEx;
    public double fAmtEx;
    public double fOAmtEx;
    public double fTaxableAmtEx;
    public double fOTaxableAmtEx;
    public double dModAmtsEx;
    public double fOriginalPriceBeforePackagePromoEx;
    public double fOriginalOPriceBeforePackagePromoEx;
    public double dEntryInclusiveTaxEx;
    public double dEntryExemptInclusiveTaxableEx;
    public uint ExemptIncTaxIdEx;
    public uint nRefillCountEx;
    public uint printRefillCountEx;
    public uint quantityEx;
    public uint selectedEx;
    public uint changedEx;
    public uint cashcard_already_soldEx;
    public uint bPrintedOnHardCheckEx;
    public int promo_real_idEx;
    public int nAutoSendOrderModeEx;
    public uint nModeOfRefillOnHoldEx;
    public uint bApplyItmQtyToModsEx;
    public uint mod_codeEx;
    public uint mod_changedEx;
    public uint menuEx;
    public uint bExcludeFromDiscountEx;
  }
}
