using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("C4393053-5DE0-4483-9D07-9E8253FB5D62")]
  [ComImport]
  public interface IARadIberFuncs24
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void TransferTable([In] int TermId, [In] int TableId, [In] int fromEmployeeId, [In] int toEmployeeId);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AcceptTable([In] int TermId, [In] int EmpId, [In] int SourceTableId, [In] int targetTableId);
  }
}
