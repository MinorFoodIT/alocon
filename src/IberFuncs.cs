using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("7011F530-8728-4B8C-87CD-2BB928BC94FD")]
  [CoClass(typeof (IberFuncsClass))]
  [ComImport]
  public interface IberFuncs : IIberFuncs20
  {
  }
}
