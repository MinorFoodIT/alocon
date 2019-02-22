using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("383DF8EE-F7DE-47C9-BD7E-CA967FBB02D8")]
  [ComImport]
  public interface IInterceptAlohaPeripherals
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RegisterMagcardInterceptor([MarshalAs(UnmanagedType.Interface), In] IInterceptMagcard pIInterceptMagcard);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ReleaseMagcardInterceptor([MarshalAs(UnmanagedType.Interface), In] IInterceptMagcard pIInterceptMagcard);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RegisterBarcodeInterceptor([MarshalAs(UnmanagedType.Interface), In] IInterceptBarcode pIInterceptBarcode);

    [DispId(4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ReleaseBarcodeInterceptor([MarshalAs(UnmanagedType.Interface), In] IInterceptBarcode pIInterceptBarcode);
  }
}