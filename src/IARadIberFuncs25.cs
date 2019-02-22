using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("317F998B-0134-4D0E-AC30-34038E2769EA")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadIberFuncs25
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ForcedLockTable([In] int TermId, [In] int TableId);
  }
}