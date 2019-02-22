using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("62FDC61A-AC48-41BC-8F80-59B06BF92FB3")]
  [ComImport]
  public interface IARadApi11
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddEqualPay([In] int TermId, [In] int CheckId, [In] int NumberOfSplits);
  }
}
