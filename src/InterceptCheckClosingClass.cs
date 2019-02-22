using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(2)]
  [ClassInterface(0)]
  [Guid("54509F30-E536-11E1-AFF1-0800200C9A66")]
  [ComImport]
  public class InterceptCheckClosingClass : IInterceptCheckClosing, InterceptCheckClosing
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern InterceptCheckClosingClass();

    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int InterceptCheckClosing(
      [In] int EmployeeId,
      [In] int QueueId,
      [In] int TableId,
      [In] int CheckId);
  }
}