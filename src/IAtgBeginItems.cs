using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlohaFOHLib
{
  [TypeLibType(4160)]
  [Guid("C49A18F1-E5D3-4604-A3E4-5FFF16014509")]
  [ComImport]
  public interface IAtgBeginItems
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int BeginItem(
      [In] int TermId,
      [In] int CheckId,
      [In] int ItemId,
      [MarshalAs(UnmanagedType.BStr), In] string ItemName,
      [In] double Price,
      [In] int SeatNum,
      [In] int MenuID,
      [In] int subMenuId);
  }
}