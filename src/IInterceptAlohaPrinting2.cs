using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("F9A3D15F-242C-4232-8B71-0CB8859DEF0E")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IInterceptAlohaPrinting2 : IInterceptAlohaPrinting
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    new string PrintXML([In] int FOHDocumentType, [MarshalAs(UnmanagedType.BStr), In] string xmlIn);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_I4)]
    DOCTYPES[] GetSubscribeOptions();

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_I4)]
    NOTIFY_OPTIONS[] GetNotifyOptions();

    [DispId(4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PrePrint([In] DOCTYPES DocType, [MarshalAs(UnmanagedType.BStr), In] string XmlPrintStream);

    [DispId(5)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PostPrint([In] DOCTYPES DocType, [MarshalAs(UnmanagedType.BStr), In] string XmlPrintStream);
  }
}