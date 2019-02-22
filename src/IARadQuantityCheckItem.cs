using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("E8260132-3C6F-482F-8644-CF12B25CF61F")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadQuantityCheckItem
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)]
    string[] RepeatSelectedEntries([In] int TermId, [In] int TableId, [In] int Quantity);
  }
}