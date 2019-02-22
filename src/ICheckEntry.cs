using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("9F4D18BE-5B50-4AB4-BA96-75086346511F")]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct ICheckEntry
  {
    public int ItemId;
    public uint Seat;
    public uint ModifierCode;
    public uint Level;
    public double Price;
    public double Units;
    [MarshalAs(UnmanagedType.BStr)]
    public string DisplayName;
    [MarshalAs(UnmanagedType.BStr)]
    public string LongDisplayName;
    public uint MenuItemId;
    public uint ModifierGroupId;
    public uint EntryType;
  }
}