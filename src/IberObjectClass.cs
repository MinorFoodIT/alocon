using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [ClassInterface(0)]
  [TypeLibType(2)]
  [Guid("41DB98B4-03F6-11D3-8AA4-0090270D933E")]
  [ComImport]
  public class IberObjectClass : IIberObject, IberObject
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern IberObjectClass();

    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int GetLongVal([MarshalAs(UnmanagedType.BStr), In] string attr_name);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern double GetDoubleVal([MarshalAs(UnmanagedType.BStr), In] string attr_name);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int GetBoolVal([MarshalAs(UnmanagedType.BStr), In] string attr_name);

    [DispId(4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string GetStringVal([MarshalAs(UnmanagedType.BStr), In] string attr_name);

    [DispId(5)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void InitializeDbf([In] uint pDbf, [In] uint pData);

    [DispId(6)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void InitializeBin([In] uint pDbf, [In] uint pData);

    [DispId(7)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    public virtual extern IberEnum GetEnum([In] int FieldId);
  }
}
