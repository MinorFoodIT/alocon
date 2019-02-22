using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("334C57A9-831A-4043-B66A-F21459584AE8")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IAtgLaborData
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    AtgLaborDataObject[] AtgGetLaborData([In] int LaborGroupId);
  }
}

