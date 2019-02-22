using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("F65729BD-DF54-4A0F-8905-5F2A1A4EFE8C")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IFiscalManager
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int InitStartup();

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int FinishStartup([In] int RegisteredInterceptors);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Cleanup();

    [DispId(4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    Guid GetInterceptHandlerCLSID([In] FISCALMANAGER_INTERCEPTORS InterceptorId);
  }
}