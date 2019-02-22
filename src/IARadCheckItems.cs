using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("832AFCBA-316D-4F2F-94DC-3073B304B82C")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadCheckItems
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ChangeSize([In] int TermId, [In] int CheckId, [In] int EntryId, [In] int Action);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    double GetMenuItemPrice([In] int ItemId, [In] int subMenuId, [In] int position, out bool isItemFound);
  }
}