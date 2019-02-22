using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("57A5E34D-1B3D-449C-9F42-3557F6FF07B9")]
  [ComImport]
  public interface IAtgSalesData2
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    AtgSalesDataObject2[] AtgGetSalesData2(
      [In] int IntervalMinutes,
      [In] int unitCountCategory,
      [In] int addOnSalesCategory);
  }
}