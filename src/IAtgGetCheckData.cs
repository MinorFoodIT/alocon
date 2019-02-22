using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("292C3FDD-0C22-4F11-99A6-7C144923B958")]
  [ComImport]
  public interface IAtgGetCheckData
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    AtgGetSeatDataObject[] AtgGetSeatData([In] int CheckId);
  }
}
