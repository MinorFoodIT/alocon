using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("7B446816-F06A-4996-8F98-06BA78AC627F")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadIberFuncs21
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SwitchAndDisplayFOHScreen([In] int TermId, [In] int CheckId, [In] int screenID);
  }
}