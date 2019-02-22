using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("A582F70E-E632-4245-AFD7-1A540CA01F61")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadApiGetTable2
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void BeginGetTable2([In] int TermId, [In] int TableId);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void EndGetTable2([In] int TermId);
  }
}
