using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("804C5B95-DDC1-49AB-AED9-E07C594F4395")]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct AtgSalesDataObject
  {
    public double GrossSales;
    public double NetSales;
    public double Tax;
  }
}