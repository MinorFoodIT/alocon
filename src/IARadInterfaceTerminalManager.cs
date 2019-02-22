using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("97D03B8A-8585-438E-A582-05408AF9A053")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadInterfaceTerminalManager
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MoveAllInterfaceTerminals([In] int fromHost, [In] int toHost);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MoveInterfaceTerminals([MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_I4), In] int[] interfaceTerminalIds, [In] int toHost);
  }
}