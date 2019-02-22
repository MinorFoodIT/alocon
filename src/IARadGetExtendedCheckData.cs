using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("8A18390D-F2CC-4E04-8036-0E95C626E7BF")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadGetExtendedCheckData
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int GetCloseCheckTermID([In] int TermId, [In] int CheckId);
  }
}
