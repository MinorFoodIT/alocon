using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("453559CD-BE24-4588-A0AD-0D74265BC48F")]
  [TypeLibType(4096)]
  [ComImport]
  public interface IInterceptPrintLicense
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    string GetLicInfo();
  }
}