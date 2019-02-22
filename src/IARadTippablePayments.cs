using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("215EAE2B-B841-468E-A62A-BCD068180FD1")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadTippablePayments
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    TippablePayment[] GetTippablePayments([In] int EmployeeId);
  }
}
