using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("D365E1C4-267D-4E5B-BDDA-65E711010FFA")]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct AtgLaborDataObject
  {
    public int DayPartId;
    public double LaborHours;
    public double LaborDollars;
  }
}
