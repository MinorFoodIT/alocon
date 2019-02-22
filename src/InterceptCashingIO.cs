using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("AB8F63FF-344F-4460-B9FB-3F538B474F90")]
  [CoClass(typeof (InterceptCashingIOClass))]
  [ComImport]
  public interface InterceptCashingIO : IInterceptCashingIO
  {
  }
}