using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("3F5A2E91-6C53-4B4A-824E-F5EB03DF1319")]
  [ComImport]
  public interface IARadApi9
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetHoldTime([In] int TermId, [In] int CheckId, [In] int HoldMinutes, [In] int OrderMode);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SplitSeatMoveSelection(
      [In] int TermId,
      [In] int CheckId,
      [In] int SourceSeat,
      [In] int TargetSeat,
      [In] int EntryId);
  }
}