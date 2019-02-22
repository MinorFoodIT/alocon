using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("3D142E31-5C5B-42F8-BA48-825552C2883F")]
  [CoClass(typeof (InterceptApplyPaymentRegisterClass))]
  [ComImport]
  public interface InterceptApplyPaymentRegister : IInterceptApplyPaymentRegister
  {
  }
}