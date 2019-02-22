using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("91420DE1-5E58-472C-A810-2E7E7E5A53BF")]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct ITransferDetail
  {
    public int fromEmployeeId;
    public int fromJobCode;
    public int fromShift;
    public int toEmployeeId;
    public int toJobCode;
    public int toShift;
    public int TableId;
    public double amount;
  }
}