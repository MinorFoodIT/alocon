using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("00DC5295-3047-4A13-B89A-4722783BA39B")]
  [ComImport]
  public interface IARadApiClearDanglingOrderLock
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ClearDanglingOrderLock([In] int TermId);
  }
}