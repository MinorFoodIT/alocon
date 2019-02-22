using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("5354281F-BDA3-45E4-A289-BF9538C28B8B")]
  [ComImport]
  public interface IAtgGetTableGuestCount
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int AtgGetTableGuestCount([In] int EmployeeId, [In] int TableId);
  }
}
