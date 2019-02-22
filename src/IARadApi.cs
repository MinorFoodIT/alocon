using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("27153306-A013-4D86-AD01-6A99BB95D1A7")]
  [ComImport]
  public interface IARadApi
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AssignDeliveryDriver([In] int TermId, [In] int DriverId, [In] int TableId);
  }
}
