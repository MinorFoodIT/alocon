using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("23FDFAFE-8210-4EB4-A631-193EEDD44949")]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct PaymentObjectOnCheck
  {
    public uint Id;
    public uint TenderId;
    [MarshalAs(UnmanagedType.BStr)]
    public string Ident;
    [MarshalAs(UnmanagedType.BStr)]
    public string Auth;
    [MarshalAs(UnmanagedType.BStr)]
    public string Exp;
    [MarshalAs(UnmanagedType.BStr)]
    public string Name;
    public double amount;
    public double AmountFC;
    public double Tip;
    public double TipFC;
    public double Nr;
    public uint HouseId;
    public uint Time;
    public uint AuthCode;
    public uint LastTransactionType;
    public uint Settled;
    public uint Complete;
    public uint ReferenceId;
    public uint ManagerNumber;
    public double AuthAmount;
    public int PmsId;
    public uint CashCardDeviceId;
    [MarshalAs(UnmanagedType.BStr)]
    public string CashcardCardId;
    public double ArBalance;
    [MarshalAs(UnmanagedType.BStr)]
    public string ArPrintData;
    [MarshalAs(UnmanagedType.BStr)]
    public string GcType;
    public double GcAmount;
    public double GcRedeem;
    public uint TermId;
    [MarshalAs(UnmanagedType.BStr)]
    public string ArReference;
  }
}
