using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("41DB98B3-03F6-11D3-8AA4-0090270D933E")]
  [CoClass(typeof (IberObjectClass))]
  [ComImport]
  public interface IberObject : IIberObject
  {
  }
}