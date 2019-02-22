using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [CoClass(typeof (CUpiFohUtilClass))]
  [Guid("71CC9C7D-BFF3-40F1-B02A-7340F6C02DE8")]
  [ComImport]
  public interface CUpiFohUtil : IUpiFohUtil3
  {
  }
}