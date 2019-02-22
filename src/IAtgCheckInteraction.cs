using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("DF1B5C04-8D22-4712-865E-69596CCB8879")]
  [ComImport]
  public interface IAtgCheckInteraction
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AtgOrderItems([In] int TermId, [In] int TableId, [In] int OrderModeId);
  }
}
