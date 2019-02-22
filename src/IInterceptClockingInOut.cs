using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("4D3D9547-9CF2-471B-B0B0-7EEF7C0F0D41")]
  [ComImport]
  public interface IInterceptClockingInOut
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int ClockingIn([In] int EmployeeId);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int ClockingOut([In] int EmployeeId);
  }
}