using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("11E06180-B530-4CE8-8746-DE01C72A4098")]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct TippablePayment
  {
    public int PaymentId;
    public int CheckId;
    public int TenderId;
    [MarshalAs(UnmanagedType.BStr)]
    public string CustomerName;
    [MarshalAs(UnmanagedType.BStr)]
    public string CardTypeName;
    [MarshalAs(UnmanagedType.BStr)]
    public string MaskedCCNumber;
    public uint PaymentTime;
    public double amount;
    public double Tip;
  }
}
