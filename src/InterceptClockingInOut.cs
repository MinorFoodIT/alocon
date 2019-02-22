using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [CoClass(typeof (InterceptClockingInOutClass))]
  [Guid("4D3D9547-9CF2-471B-B0B0-7EEF7C0F0D41")]
  [ComImport]
  public interface InterceptClockingInOut : IInterceptClockingInOut
  {
  }
}
