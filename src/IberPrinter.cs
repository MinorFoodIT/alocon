using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [CoClass(typeof (IberPrinterClass))]
  [Guid("C63C0BEF-FBA8-11D4-8688-00B0D02A2DF6")]
  [ComImport]
  public interface IberPrinter : IIberPrinter
  {
  }
}