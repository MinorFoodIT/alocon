using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("8B076245-0F1F-45DF-B9DC-4B2EB212E4A1")]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct CombinedTableGroupDetails
  {
    public int TabledefId;
    public int EmployeeId;
    public int TableId;
    [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_INT)]
    public int[] CombinedTableDefIdList;
  }
}