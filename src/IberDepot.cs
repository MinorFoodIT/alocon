using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("41DB98B1-03F6-11D3-8AA4-0090270D933E")]
  [CoClass(typeof (IberDepotClass))]
  [ComImport]
  public interface IberDepot : IIberDepot
  {
  }
}