using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("3A4623CE-128F-4450-91DD-B7F1ACC55B0C")]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct TableObject
  {
    public uint AskedForGuestCount;
    public uint Changed;
    public uint ClosedChecks;
    public uint ClosedData;
    public uint ClosedGuests;
    public double ClosedSales;
    public uint CloseTime;
    public uint FirstBumpTime;
    public uint FirstOrderTime;
    public uint FirstPaymentTime;
    public double Gratuity;
    public uint Id;
    public uint Jobcode;
    public uint LastBumpTime;
    public uint LastOrderTime;
    public uint LastPaymentTime;
    public uint Locked;
    public uint LockTerminal;
    [MarshalAs(UnmanagedType.BStr)]
    public string Name;
    public uint Named;
    public uint NeedToPrintChits;
    public uint Number;
    public uint NumSeats;
    public uint NumGuests;
    public uint OpenTime;
    public uint OrderMode;
    public uint OwnerShiftNum;
    public uint OwnerCheckoutNum;
    public uint Period;
    public uint PrintedChits;
    public uint Refund;
    public uint RevenueId;
    public uint SeatTime;
    public uint Selected;
    public uint Started;
    public uint state;
    public uint SourceTableId;
    public uint SurveyId;
    public uint TabledefId;
    public uint Training;
    public uint TypeValue;
    public uint WaitTime;
  }
}
