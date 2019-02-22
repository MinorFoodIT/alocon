using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("383DF8EE-F7DE-47C9-BD7E-CA967FBB02D8")]
  [CoClass(typeof (InterceptAlohaPeripheralsClass))]
  [ComImport]
  public interface InterceptAlohaPeripherals : IInterceptAlohaPeripherals
  {
  }
}