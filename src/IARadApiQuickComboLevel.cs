using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("0AD7695E-7C7F-491C-A37E-EB3083EB1483")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadApiQuickComboLevel
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void QuickComboLevel([In] int TermId, [In] int CheckId, [In] int Level, [In] int currentUpsellPromoID);
  }
}