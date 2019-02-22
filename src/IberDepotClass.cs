using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("41DB98B2-03F6-11D3-8AA4-0090270D933E")]
  [ClassInterface(0)]
  [TypeLibType(2)]
  [ComImport]
  public class IberDepotClass : IIberDepot, IberDepot
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern IberDepotClass();

    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    public virtual extern IberEnum GetEnum([In] int TypeId);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    public virtual extern IberEnum FindObjectFromId([In] int TypeId, [In] int IdValue);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int GetIdFromUserNumber([In] int TypeId, [In] int UserNumber);
  }
}