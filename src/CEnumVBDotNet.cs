using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("872E4AA6-F72F-4D79-A7B3-95720D15CCFC")]
  [CoClass(typeof (CEnumVBDotNetClass))]
  [ComImport]
  public interface CEnumVBDotNet : IEnumVBDotNet
  {
  }
}