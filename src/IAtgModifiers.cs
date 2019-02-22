using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("D346A4E6-C354-4612-B80A-18F01F1CC86A")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IAtgModifiers
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int ReplaceModifier(
      [In] int TermId,
      [In] int CheckId,
      [In] int ExistingEntryId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int AddModifier(
      [In] int TermId,
      [In] int CheckId,
      [In] int ParentEntryId,
      [In] int ModifierGroupId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int ModCodeId);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeleteModifier([In] int TermId, [In] int CheckId, [In] int ModifierEntryId);
  }
}
