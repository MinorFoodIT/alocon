using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("FB45A2F5-6B48-4C83-A292-CB9A6AD50DA5")]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct AtgSalesDataObject2
  {
    public double Units;
    public double AddOnSales;
    public double GrossSales;
    public double NetSales;
    public double Tax;
  }
}