using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("F9A891D4-DF00-4862-B636-407E78083921")]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct ItemInfoObject
  {
    public uint EntryId;
    public uint EmpNumber;
    public uint TypeValue;
    public uint ItemId;
    public uint Mode;
    public uint Quantity;
    public uint Level;
    public uint Seat;
    public uint Period;
    public uint Routing;
    public uint VRouting;
    public uint TaxId;
    public uint ModCode;
    public uint Menu;
    public uint RevenueId;
    public uint TermId;
    public uint Split;
    public uint Origin;
    public double Price;
    public double OPrice;
    public uint Time;
    public uint AffectAvailability;
    public uint TaxId2;
  }
}