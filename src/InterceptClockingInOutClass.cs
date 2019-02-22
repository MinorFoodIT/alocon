using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(2)]
  [ClassInterface(0)]
  [Guid("55092F35-0E1B-4EA5-B8D4-BAA156A60629")]
  [ComImport]
  public class InterceptClockingInOutClass : IInterceptClockingInOut, InterceptClockingInOut
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern InterceptClockingInOutClass();

    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int ClockingIn([In] int EmployeeId);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int ClockingOut([In] int EmployeeId);
  }
}