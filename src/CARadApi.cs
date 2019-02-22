using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("27153306-A013-4D86-AD01-6A99BB95D1A7")]
  [CoClass(typeof (CARadApiClass))]
  [ComImport]
  public interface CARadApi : IARadApi
  {
  }
}