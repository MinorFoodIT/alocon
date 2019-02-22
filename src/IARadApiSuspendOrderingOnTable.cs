using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("B83798FD-F40E-40B5-A48E-24C84088285D")]
  [ComImport]
  public interface IARadApiSuspendOrderingOnTable
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SuspendOrderingOnTable([In] int TermId, [In] int TableId, [In] int bSuspend);
  }
}