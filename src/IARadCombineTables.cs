using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("F0E3F8CD-AAB6-43B3-B92F-095B7C7A7E7B")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadCombineTables
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CombineTables([In] int TermId, [In] int EmployeeId, [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_INT), In] int[] combinedTableDefIdsList);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DetachTables(
      [In] int TermId,
      [In] int EmployeeId,
      [In] int oldPrimaryTableId,
      [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_INT), In] int[] remainingTableDefIdsList);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    CombinedTableGroupDetails[] GetAllCombinedTableGroups([In] int TermId);
  }
}