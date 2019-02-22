using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [Guid("6C65E3B1-F8F3-4EDE-BD59-BC491154635B")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IARadRit
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void InitializeRIT(int RitId);
  }
}