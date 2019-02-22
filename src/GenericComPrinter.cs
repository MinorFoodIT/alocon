using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("046BF6DA-5B1F-4B96-BAA6-2D794CA37B7B")]
  [CoClass(typeof (GenericComPrinterClass))]
  [ComImport]
  public interface GenericComPrinter : IGenericComPrinter
  {
  }
}