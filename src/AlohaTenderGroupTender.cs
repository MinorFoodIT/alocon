using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("CBA0AF95-45A9-4E1F-A013-94C93496E026")]
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct AlohaTenderGroupTender
  {
    public uint GroupId;
    public uint TenderId;
  }
}