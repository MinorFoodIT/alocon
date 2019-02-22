using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(2)]
  [Guid("18944D93-2BBF-43E0-9882-58EA694EA583")]
  [ClassInterface(0)]
  [ComImport]
  public class InterceptCashingIOClass : IInterceptCashingIO, InterceptCashingIO
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern InterceptCashingIOClass();

    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int CashingIO([In] int EmployeeId, [In] int DrawerId, [In] double amount);
  }
}