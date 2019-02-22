using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("33C31882-C273-44EC-B088-0424ACAD3CF0")]
  [TypeLibType(2)]
  [ClassInterface(0)]
  [ComImport]
  public class IberTransLogClass : IIberTransLog, IberTransLog, IIberTransLogNotify
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern IberTransLogClass();

    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void PersistMessage(
      [In] Guid appGUID,
      [In] int uniqueId,
      [In] int sizeBlob,
      [In] ref byte blob);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void RegisterNotifyExternalMessage(
      [In] Guid appGUID,
      [In] NOTIFYTRANSLOG_IDS whatToNotify,
      [MarshalAs(UnmanagedType.IUnknown), In] object pIberTransLogNotify);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void NotifyExternalMessage(
      [In] Guid appGUID,
      [In] int uniqueId,
      [In] TRANSLOGSATE_IDS state,
      [In] int sizeBlob,
      [In] ref byte blob);
  }
}