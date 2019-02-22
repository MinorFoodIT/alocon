using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [CoClass(typeof (FiscalManagerClass))]
  [Guid("F65729BD-DF54-4A0F-8905-5F2A1A4EFE8C")]
  [ComImport]
  public interface FiscalManager : IFiscalManager
  {
  }
}