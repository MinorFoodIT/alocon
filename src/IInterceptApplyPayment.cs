using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("00A38998-1DEC-4A7B-884A-3BBC43775225")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IInterceptApplyPayment
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int InterceptApplyPayment(
      [In] int terminalId,
      [In] int ManagerId,
      [In] int EmployeeId,
      [In] int QueueId,
      [In] int TableId,
      [In] int CheckId);
  }
}