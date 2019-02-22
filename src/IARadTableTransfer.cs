using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("0C324D98-0007-4D85-B99B-073B8069FCAB")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadTableTransfer
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    ITransferDetail[] GetTableTransferDetails([In] int TermId);
  }
}