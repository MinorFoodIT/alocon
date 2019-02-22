using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("F212E976-74E2-467B-88AD-01AB66971DC8")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadTableTransfer2
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int AcceptTransfer(
      [In] int TermId,
      [In] int EmpId,
      [In] int SourceTableId,
      [In] int QueueId,
      [In] int TableNum,
      [MarshalAs(UnmanagedType.BStr), In] string TableNameAsBSTR);
  }
}