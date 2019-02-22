using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("B1349DC7-8EBB-4662-AB5E-0CF862CB7377")]
  [CoClass(typeof (IberTransLogClass))]
  [ComImport]
  public interface IberTransLog : IIberTransLog
  {
  }
}