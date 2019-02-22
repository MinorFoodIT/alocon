using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("72FF9416-B23A-4C9A-8088-0C4E034B3158")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadApiItemAvailability
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    ITEM_AVAILABILITY_TYPE GetItemAvailability(
      [In] int TermId,
      [In] int ItemId,
      out int ItemCount);
  }
}