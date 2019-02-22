using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("D0B1D69C-695B-4166-B67A-99E8F8A1F636")]
  [ComImport]
  public interface IARadGiftCardBalance
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetGiftCardBalance([In] int TermId, [MarshalAs(UnmanagedType.BStr), In] string GiftCardData, [In] int IsSwipe);
  }
}

