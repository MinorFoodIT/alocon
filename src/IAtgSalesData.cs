using System.Runtime.CompilerServices;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("66F8D9BC-0966-4D85-9F15-15735A04BAEF")]
  [ComImport]
  public interface IAtgSalesData
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    AtgSalesDataObject[] AtgGetSalesData([In] int IntervalMinutes);
  }
}