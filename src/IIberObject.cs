using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("41DB98B3-03F6-11D3-8AA4-0090270D933E")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IIberObject
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int GetLongVal([MarshalAs(UnmanagedType.BStr), In] string attr_name);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    double GetDoubleVal([MarshalAs(UnmanagedType.BStr), In] string attr_name);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int GetBoolVal([MarshalAs(UnmanagedType.BStr), In] string attr_name);

    [DispId(4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    string GetStringVal([MarshalAs(UnmanagedType.BStr), In] string attr_name);

    [DispId(5)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void InitializeDbf([In] uint pDbf, [In] uint pData);

    [DispId(6)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void InitializeBin([In] uint pDbf, [In] uint pData);

    [DispId(7)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    IberEnum GetEnum([In] int FieldId);
  }
}
