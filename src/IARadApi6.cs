using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("07101ECA-3F91-4F53-8E71-3831A80126C7")]
  [ComImport]
  public interface IARadApi6
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ChangePromiseTime([In] int TermId, [In] int CheckId, [In] int PromiseMinutes);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void TaxExemptCheck([In] int TermId, [In] int CheckId, [MarshalAs(UnmanagedType.BStr), In] string TaxId, [In] bool Exempt);
  }
}
