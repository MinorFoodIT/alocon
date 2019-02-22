using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("EFC2A979-489D-11D5-B852-00B0D0A185BE")]
  [ComImport]
  public interface IInterceptAlohaPrinting
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    string PrintXML([In] int FOHDocumentType, [MarshalAs(UnmanagedType.BStr), In] string xmlIn);
  }
}