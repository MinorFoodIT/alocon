using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("A5524CA1-6D86-48E6-A47B-AE3E77F7426F")]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct CheckObject
  {
    public uint Adjusted;
    public uint ApplyModeCharge;
    public uint AskedForGuestCount;
    public uint BeginTime;
    public uint CashierCheckoutNum;
    public uint ChangeToCashCard;
    public uint CheckoutNumber;
    public uint Closed;
    public uint CloseTime;
    public uint DeferredStoreItems;
    public int DeliveryCustomerId;
    public uint DeliveredTime;
    public uint DeliveryOutTime;
    public double DriverFee;
    public double FdTotal;
    public uint FirstBumpTime;
    public int FirstEntryNumber;
    public uint FirstOrderTime;
    public uint FirstPaymentTime;
    public double Gratuity;
    public double GratuityAmount;
    public double GratuityTax;
    public uint Guests;
    public uint Id;
    public uint LastBumpTime;
    public uint LastOrderTime;
    public uint LastPaymentTime;
    public uint NeedToGrind;
    public uint Number;
    public uint OccassionId;
    public uint OpenTime;
    public uint OrderAttribute;
    public uint OrderMode;
    public uint Period;
    public uint PerpetualCheckCounter;
    public uint Printed;
    public uint PromiseTime;
    public uint Reason;
    public uint Reclaimed;
    public uint Refund;
    public uint RevenueId;
    public double RoundingAdjustment;
    public uint ServerCheckoutNum;
    public uint Shift;
    public uint StatusMask;
    public double Subtotal;
    public uint SurveyTableId;
    public uint TableId;
    [MarshalAs(UnmanagedType.BStr)]
    public string TableName;
    public double Tax;
    public uint TaxExempt;
    [MarshalAs(UnmanagedType.BStr)]
    public string TaxNumber;
    public uint terminalId;
    public uint TippableShift;
    public uint Training;
  }
}
