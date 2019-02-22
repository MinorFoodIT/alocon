using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("927B3321-D3ED-4CC6-A3AA-B097764DD693")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadIberFuncs27
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ApplyPaymentRoundupAmount([In] int TermId, [In] int CheckId, [In] int PaymentId, [In] double amount);
  }
}