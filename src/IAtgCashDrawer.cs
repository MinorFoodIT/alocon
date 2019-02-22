using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("D5BF856F-715A-4FC9-A521-67DB1C618B97")]
  [ComImport]
  public interface IAtgCashDrawer
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int AtgAssignDrawer([In] int ManagerId, [In] int EmployeeId, [In] int DrawerId, [In] int drawerAction);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int AtgOpenDrawer([In] int DrawerId);
  }
}
