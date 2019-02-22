using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("BA64DECC-0E7C-4E0B-88C3-BD171F971893")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadApiSeats2
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ChangeCurrentlySelectedSeat([In] int TermId, [In] int seatIndex);
  }
}