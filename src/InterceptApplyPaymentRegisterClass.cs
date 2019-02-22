using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("66B5B2AB-EAE1-4F94-BA66-0CAC20717A14")]
  [TypeLibType(2)]
  [ClassInterface(0)]
  [ComImport]
  public class InterceptApplyPaymentRegisterClass : IInterceptApplyPaymentRegister, InterceptApplyPaymentRegister
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern InterceptApplyPaymentRegisterClass();

    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void RegisterApplyPaymentInterceptor(
      [MarshalAs(UnmanagedType.Interface), In] IInterceptApplyPayment pIInterceptApplyPayment);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ReleaseApplyPaymentInterceptor(
      [MarshalAs(UnmanagedType.Interface), In] IInterceptApplyPayment pIInterceptApplyPayment);
  }
}