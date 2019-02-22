using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("105442D9-4BFE-4375-835D-8FED7F095615")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadApi13
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    string GetExtendedEFreqError([In] int TermId);
  }
}