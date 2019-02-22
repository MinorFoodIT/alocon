using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("D14432B9-9605-47A6-B8BA-69E548BA19F6")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IATGDeferredModifiers
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int AddDeferredModifier([In] int TermId, [In] int CheckId, [In] int ParentEntryId, [In] int ModifierGroupId);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeleteDeferredModifier([In] int TermId, [In] int CheckId, [In] int ParentEntryId, [In] int ModifierGroupId);
  }
}