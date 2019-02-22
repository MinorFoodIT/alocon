using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("AF5AA334-FA17-48B8-905A-B5B34D70EE15")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IAtgLaborData2
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    AtgLaborDataObject[] AtgGetLaborData2([In] int IntervalMinutes, [In] int LaborGroupId);
  }
}
