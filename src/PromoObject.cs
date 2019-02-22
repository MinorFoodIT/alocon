using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("F6D2ABF8-6B07-4F6E-89B8-4BBE9F50A4C0")]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct PromoObject
  {
    public uint Id;
    public uint PromotionId;
    public double amount;
    public double Nr;
    public double Temp;
    public double Original;
    [MarshalAs(UnmanagedType.BStr)]
    public string Ident;
    public uint NumItems;
    public uint TimeApplied;
    public uint MangerNumber;
    public uint QuickComboLevel;
  }
}