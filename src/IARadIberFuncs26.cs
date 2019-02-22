using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("AD676CEE-4363-4B0B-8DD4-12AD64E06369")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadIberFuncs26
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int AddTableForcedLocked(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableName,
      [In] int NumGuests);
  }
}