using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("E901AC13-23D8-4856-A856-EACB67B7551E")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadApiSetSeatName
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetSeatName([In] int TermId, [In] int TableId, [In] int CheckId, [In] int SeatNumber, [MarshalAs(UnmanagedType.BStr), In] string SeatName);
  }
}