using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("36050C05-37D3-4B83-B7A8-3D8E71C4150C")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IAtgGetAlohaLicense
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int GetHaspCode();

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int GetNumberLicensedTerminals();
  }
}