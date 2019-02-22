using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("FB3DB41C-577C-4037-98E9-606E32A7CA43")]
  [ComImport]
  public interface IARadIncludedModifiers
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    IncludedModifier[] GetIncludedModifiers();
  }
}