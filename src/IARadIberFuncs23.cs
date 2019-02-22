using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("21B0494D-C14E-4964-A89A-70C89FD24A31")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadIberFuncs23
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_RECORD)]
    ICheckEntryNewEx[] GetCheckEntriesNewEx([In] int TermId, [In] int CheckId);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    double GetEmployeeCheckoutTotal([In] int TermId, [In] int EmployeeId);
  }
}
