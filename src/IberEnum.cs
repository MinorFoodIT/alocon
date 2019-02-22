using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [CoClass(typeof (IberEnumClass))]
  [Guid("41DB98B5-03F6-11D3-8AA4-0090270D933E")]
  [ComImport]
  public interface IberEnum : IIberEnum
  {
  }
}