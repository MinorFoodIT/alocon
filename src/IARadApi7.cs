using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("D0FB5FC8-BD47-4380-9C6B-89318B412307")]
  [ComImport]
  public interface IARadApi7
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    ICheckEntry[] GetCheckEntries([In] int CheckId);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ClearAndCloseCheck([In] int TermId, [In] int CheckId, [In] int VoidReasonId);
  }
}