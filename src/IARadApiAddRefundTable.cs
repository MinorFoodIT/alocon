using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("67CD3EA3-B48A-4FB5-95A4-6C0C52F93848")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadApiAddRefundTable
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int AddRefundTable(
      [In] int TermId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableNameAsBSTR,
      [In] int NumGuests,
      [In] uint Reason,
      [In] int ManagerId);
  }
}