using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("3CB40680-E524-11E1-AFF1-0800200C9A66")]
  [ComImport]
  public interface IInterceptCheckClosing
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int InterceptCheckClosing([In] int EmployeeId, [In] int QueueId, [In] int TableId, [In] int CheckId);
  }
}