using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("CC07A669-F410-4586-A12E-749D6CA64528")]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct EntryObject
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
  }
}
