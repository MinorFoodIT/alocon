using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("519A4A27-0278-40A2-9CCB-E11004B6884D")]
  [ComImport]
  public interface IARadApi8
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetDriverStartMileage([In] int TermId, [In] int DriverId, [In] int Mileage);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetDriverEndMileage([In] int TermId, [In] int DriverId, [In] int Mileage);
  }
}