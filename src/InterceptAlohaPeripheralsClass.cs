using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("75C5D768-4089-4853-8CD8-9F02F00F54F5")]
  [TypeLibType(2)]
  [ClassInterface(0)]
  [ComImport]
  public class InterceptAlohaPeripheralsClass : IInterceptAlohaPeripherals, InterceptAlohaPeripherals
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern InterceptAlohaPeripheralsClass();

    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void RegisterMagcardInterceptor([MarshalAs(UnmanagedType.Interface), In] IInterceptMagcard pIInterceptMagcard);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ReleaseMagcardInterceptor([MarshalAs(UnmanagedType.Interface), In] IInterceptMagcard pIInterceptMagcard);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void RegisterBarcodeInterceptor([MarshalAs(UnmanagedType.Interface), In] IInterceptBarcode pIInterceptBarcode);

    [DispId(4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ReleaseBarcodeInterceptor([MarshalAs(UnmanagedType.Interface), In] IInterceptBarcode pIInterceptBarcode);
  }
}