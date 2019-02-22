using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("B1349DC7-8EBB-4662-AB5E-0CF862CB7377")]
  [ComImport]
  public interface IIberTransLog
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PersistMessage([In] Guid appGUID, [In] int uniqueId, [In] int sizeBlob, [In] ref byte blob);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RegisterNotifyExternalMessage(
      [In] Guid appGUID,
      [In] NOTIFYTRANSLOG_IDS whatToNotify,
      [MarshalAs(UnmanagedType.IUnknown), In] object pIberTransLogNotify);
  }
}