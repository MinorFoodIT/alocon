using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("83BCBBA6-39C1-465C-BB4F-E28AC7E03EBD")]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct LocalStateObject
  {
    public int terminalId;
    public int TerminalUserNumber;
    public uint CurrentModcode;
    public uint CurrentSeat;
    public int ItemCount;
    public uint OrderEntryStation;
    public int state;
    public int ManagerState;
    public uint DebugFlag;
    public uint EodLock;
    public uint EodTotalLock;
    public uint EodInProgress;
    public uint ForceEodRequested;
    public uint GrindLog;
    public uint IberBOH;
    public uint Limbo;
    public uint LoggedIn;
    public uint NoNet;
    public uint PrintLock;
    public uint PrinterLoop;
    public uint VideoLoop;
    public uint Stressed;
    public uint TestMode;
    public uint TestPrint;
    public uint TestingEod;
    public uint Quitting;
    public uint SecondaryClockInout;
    public int TestPrintPort;
    public int CardReaderState;
    public int OrderValid;
    public int BarValid;
    public int PivotValid;
    public int BarPivotValid;
    public int FastfoodValid;
    public int TablesValid;
    public int TabsValid;
    public uint Training;
    public uint FastFood;
    [MarshalAs(UnmanagedType.BStr)]
    public string IberDir;
    [MarshalAs(UnmanagedType.BStr)]
    public string LocalDir;
    [MarshalAs(UnmanagedType.BStr)]
    public string DataDir;
    public int CurrentCheckId;
    public int CurrentTableId;
  }
}
