using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("3D142E31-5C5B-42F8-BA48-825552C2883F")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IInterceptApplyPaymentRegister
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RegisterApplyPaymentInterceptor([MarshalAs(UnmanagedType.Interface), In] IInterceptApplyPayment pIInterceptApplyPayment);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ReleaseApplyPaymentInterceptor([MarshalAs(UnmanagedType.Interface), In] IInterceptApplyPayment pIInterceptApplyPayment);
  }
}
