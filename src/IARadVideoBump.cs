using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("D0431A1A-A738-42B9-8685-3EE0C9E7BA03")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadVideoBump
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void FinalBump([In] int TermId, [In] int VideoId, [In] int TableId);
  }
}