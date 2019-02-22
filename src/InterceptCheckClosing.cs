using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [CoClass(typeof (InterceptCheckClosingClass))]
  [Guid("3CB40680-E524-11E1-AFF1-0800200C9A66")]
  [ComImport]
  public interface InterceptCheckClosing : IInterceptCheckClosing
  {
  }
}