using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("EB0D0FD0-8B44-481C-A16F-0300A2E16946")]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct CompObject
  {
    public uint Id;
    public uint CompTypeId;
    public double amount;
    public double Temp;
    public double Original;
    [MarshalAs(UnmanagedType.BStr)]
    public string Unit;
    [MarshalAs(UnmanagedType.BStr)]
    public string Name;
    public uint NumItems;
    public uint TimeApplied;
    public uint ManagerNumber;
  }
}