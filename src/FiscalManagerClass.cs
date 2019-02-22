using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("AA850100-F9CF-460A-8C0B-F45FE4953713")]
  [ClassInterface(0)]
  [TypeLibType(2)]
  [ComImport]
  public class FiscalManagerClass : IFiscalManager, FiscalManager
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern FiscalManagerClass();

    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int InitStartup();

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern int FinishStartup([In] int RegisteredInterceptors);

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void Cleanup();

    [DispId(4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern Guid GetInterceptHandlerCLSID([In] FISCALMANAGER_INTERCEPTORS InterceptorId);
  }
}