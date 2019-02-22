using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [ClassInterface(0)]
  [Guid("C64D3F2A-D5F5-4E9D-A2F8-267F178DCEA9")]
  [TypeLibType(18)]
  [ComImport]
  public class CEnumVBDotNetClass : IEnumVBDotNet, CEnumVBDotNet
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern CEnumVBDotNetClass();

    [DispId(1610743808)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool MoveNext();

    [DispId(1610743809)]
    public virtual extern object Current { [DispId(1610743809), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

    [DispId(1610743810)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void Reset2();
  }
}