using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("F6ADBEE9-7D32-4982-883F-F6C5F2F9EB2E")]
  [ComImport]
  public interface IInterceptMagcard
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int InterceptMagcard(
      [MarshalAs(UnmanagedType.BStr), In] string bstrAccountNumber,
      [MarshalAs(UnmanagedType.BStr), In] string bstrCustomerName,
      [MarshalAs(UnmanagedType.BStr), In] string bstrExpirationDate,
      [MarshalAs(UnmanagedType.BStr), In] string bstrTrack1Info,
      [MarshalAs(UnmanagedType.BStr), In] string bstrTrack2Info,
      [MarshalAs(UnmanagedType.BStr), In] string bstrTrack3Info,
      [MarshalAs(UnmanagedType.BStr), In] string bstrRawMagcardData);
  }
}
