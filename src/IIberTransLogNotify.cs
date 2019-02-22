using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("66C46198-7656-4AA4-88C7-2C46395B09B8")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IIberTransLogNotify
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void NotifyExternalMessage(
      [In] Guid appGUID,
      [In] int uniqueId,
      [In] TRANSLOGSATE_IDS state,
      [In] int sizeBlob,
      [In] ref byte blob);
  }
}
