using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("20C7EB73-96E1-4D68-95EF-F917525BD7C9")]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct AlohaTenderGroup
  {
    public uint Id;
    [MarshalAs(UnmanagedType.BStr)]
    public string Name;
  }
}
