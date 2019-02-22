using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("041EF2F2-6A4A-41F8-BFD4-16293FF97288")]
  [ComImport]
  public interface IARadApi2
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RecallOrder([In] int TermId, [In] int QueueId, [In] int TableId);
  }
}
