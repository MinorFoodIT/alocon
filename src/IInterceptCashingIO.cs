using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("AB8F63FF-344F-4460-B9FB-3F538B474F90")]
  [ComImport]
  public interface IInterceptCashingIO
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int CashingIO([In] int EmployeeId, [In] int DrawerId, [In] double amount);
  }
}