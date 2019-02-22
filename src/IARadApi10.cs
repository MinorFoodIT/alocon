using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("34D2DE11-EB7B-40DB-AC21-DEC4F92409AC")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadApi10
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddGratuity([In] int TermId, [In] int CheckId, [In] double dGratuityPercent);
  }
}