using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("3625910C-1144-4345-8B09-50FC8DDBD2F8")]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct eFreqPriceChange
  {
    public uint checkEntryId;
    public double newPrice;
  }
}
