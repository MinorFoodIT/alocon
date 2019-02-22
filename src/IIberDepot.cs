using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("41DB98B1-03F6-11D3-8AA4-0090270D933E")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IIberDepot
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    IberEnum GetEnum([In] int TypeId);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    IberEnum FindObjectFromId([In] int TypeId, [In] int IdValue);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int GetIdFromUserNumber([In] int TypeId, [In] int UserNumber);
  }
}

