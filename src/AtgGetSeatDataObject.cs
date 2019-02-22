using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("0A042FFE-018A-4976-8C4A-0F829AEFC5D3")]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct AtgGetSeatDataObject
  {
    public int SeatId;
    public double SeatTotal;
    public double SeatSubtotal;
    public double SeatTax;
    public double SeatSecondaryTax;
    public double SeatSurcharge;
    public double SeatAdditionalCharge;
    public double SeatOrderModeCharge;
    public double SeatGratuity;
    public double SeatDiscount;
  }
}