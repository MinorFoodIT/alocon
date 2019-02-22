using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("242ED3B1-B825-46FB-96C5-F7539D0A2DE3")]
  [ComImport]
  public interface IARadApiItemAvailability2 : IARadApiItemAvailability
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new ITEM_AVAILABILITY_TYPE GetItemAvailability(
      [In] int TermId,
      [In] int ItemId,
      out int ItemCount);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetItemAvailability(
      [In] int TermId,
      [In] int EmployeeId,
      [In] int ItemId,
      [In] byte available,
      [In] uint numAvailable);
  }
}