using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("782B4923-3793-46C3-8AB2-17AD311F88AC")]
  [ComImport]
  public interface IARadApi4
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void QuantityPriceItem([In] int TermId, [In] int EntryId, [In] double Units, [In] bool Weight);
  }
}