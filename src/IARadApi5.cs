using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("75CAB4A8-9EF7-4F52-A765-419BD0F2C388")]
  [ComImport]
  public interface IARadApi5
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void BeginGetCheck([In] int TermId, [In] int CheckId);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void EndGetCheck([In] int TermId);
  }
}
