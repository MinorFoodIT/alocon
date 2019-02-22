using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("571C01D6-B5EC-41D6-816F-FB207DB59B00")]
  [ComImport]
  public interface IARadApi12
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int CheckCategoryRequirements([In] int TermId, [In] int CheckId);
  }
}