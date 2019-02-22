using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("14738399-C3CA-4A04-B465-2E5DE5D68E4C")]
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct IncludedModifier
  {
    public int ItemId;
    public int ModGroup;
    public int ModItem;
    public int ImpliedModifier;
    public int AutoAdd;
    public int SequenceNumber;
    public int ChargeMode;
    public int PrintInKitchen;
  }
}