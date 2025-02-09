using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPixelExtent
///
/// Representation of a cartesian pixel plane and common operations
/// on it. The implementation is intended to be fast and light
/// so that it may be used in place of int[4] with little or no
/// performance penalty.
///
/// NOTE in most cases operation on an empty object produces
/// incorrect results. If it an issue query Empty() first.
/// </summary>
public class vtkPixelExtent : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPixelExtent";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPixelExtent()
	{
		MRClassNameKey = "class vtkPixelExtent";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPixelExtent"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPixelExtent(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_CellToNode_01(HandleRef pThis);

	/// <summary>
	/// In-place conversion from cell based to node based extent, and vise-versa.
	/// </summary>
	public void CellToNode()
	{
		vtkPixelExtent_CellToNode_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkPixelExtent vtkPixelExtent_CellToNode_02(vtkPixelExtent inputExt);

	/// <summary>
	/// Convert from cell extent to point extent
	/// while respecting the dimensionality of the data.
	/// </summary>
	public static vtkPixelExtent CellToNode(vtkPixelExtent inputExt)
	{
		return vtkPixelExtent_CellToNode_02(inputExt);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_Clear_03(HandleRef pThis);

	/// <summary>
	/// Set the extent.
	/// </summary>
	public void Clear()
	{
		vtkPixelExtent_Clear_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPixelExtent_Contains_04(HandleRef pThis, vtkPixelExtent other);

	/// <summary>
	/// Return non-zero if this extent contains the other.
	/// </summary>
	public int Contains(vtkPixelExtent other)
	{
		return vtkPixelExtent_Contains_04(GetCppThis(), other);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPixelExtent_Contains_05(HandleRef pThis, int i, int j);

	/// <summary>
	/// Return non-zero if this extent contains the other.
	/// </summary>
	public int Contains(int i, int j)
	{
		return vtkPixelExtent_Contains_05(GetCppThis(), i, j);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPixelExtent_Disjoint_06(HandleRef pThis, vtkPixelExtent other);

	/// <summary>
	/// Return non-zero if the extent is disjoint from the other
	/// </summary>
	public int Disjoint(vtkPixelExtent other)
	{
		return vtkPixelExtent_Disjoint_06(GetCppThis(), other);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPixelExtent_Empty_07(HandleRef pThis);

	/// <summary>
	/// Return true if empty.
	/// </summary>
	public int Empty()
	{
		return vtkPixelExtent_Empty_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPixelExtent_GetData_08(HandleRef pThis);

	/// <summary>
	/// Direct access to internal data.
	/// </summary>
	public IntPtr GetData()
	{
		return vtkPixelExtent_GetData_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPixelExtent_GetDataU_09(HandleRef pThis);

	/// <summary>
	/// Direct access to internal data.
	/// </summary>
	public IntPtr GetDataU()
	{
		return vtkPixelExtent_GetDataU_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_GetEndIndex_10(HandleRef pThis, IntPtr last);

	/// <summary>
	/// Get the start/end index.
	/// </summary>
	public void GetEndIndex(IntPtr last)
	{
		vtkPixelExtent_GetEndIndex_10(GetCppThis(), last);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_GetStartIndex_11(HandleRef pThis, IntPtr first);

	/// <summary>
	/// Get the start/end index.
	/// </summary>
	public void GetStartIndex(IntPtr first)
	{
		vtkPixelExtent_GetStartIndex_11(GetCppThis(), first);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_GetStartIndex_12(HandleRef pThis, IntPtr first, IntPtr origin);

	/// <summary>
	/// Get the start/end index.
	/// </summary>
	public void GetStartIndex(IntPtr first, IntPtr origin)
	{
		vtkPixelExtent_GetStartIndex_12(GetCppThis(), first, origin);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_Grow_13(HandleRef pThis, int n);

	/// <summary>
	/// Expand the extents by n.
	/// </summary>
	public void Grow(int n)
	{
		vtkPixelExtent_Grow_13(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_Grow_14(HandleRef pThis, int q, int n);

	/// <summary>
	/// Expand the extents by n.
	/// </summary>
	public void Grow(int q, int n)
	{
		vtkPixelExtent_Grow_14(GetCppThis(), q, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkPixelExtent vtkPixelExtent_Grow_15(vtkPixelExtent inputExt, int n);

	/// <summary>
	/// Add or remove ghost cells. If a problem domain is
	/// provided then the result is clipled to be within the
	/// problem domain.
	/// </summary>
	public static vtkPixelExtent Grow(vtkPixelExtent inputExt, int n)
	{
		return vtkPixelExtent_Grow_15(inputExt, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkPixelExtent vtkPixelExtent_Grow_16(vtkPixelExtent inputExt, vtkPixelExtent problemDomain, int n);

	/// <summary>
	/// Add or remove ghost cells. If a problem domain is
	/// provided then the result is clipled to be within the
	/// problem domain.
	/// </summary>
	public static vtkPixelExtent Grow(vtkPixelExtent inputExt, vtkPixelExtent problemDomain, int n)
	{
		return vtkPixelExtent_Grow_16(inputExt, problemDomain, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_GrowHigh_17(HandleRef pThis, int q, int n);

	/// <summary>
	/// Expand the extents by n.
	/// </summary>
	public void GrowHigh(int q, int n)
	{
		vtkPixelExtent_GrowHigh_17(GetCppThis(), q, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkPixelExtent vtkPixelExtent_GrowHigh_18(vtkPixelExtent ext, int q, int n);

	/// <summary>
	/// Add or remove ghost cells. If a problem domain is
	/// provided then the result is clipled to be within the
	/// problem domain.
	/// </summary>
	public static vtkPixelExtent GrowHigh(vtkPixelExtent ext, int q, int n)
	{
		return vtkPixelExtent_GrowHigh_18(ext, q, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_GrowLow_19(HandleRef pThis, int q, int n);

	/// <summary>
	/// Expand the extents by n.
	/// </summary>
	public void GrowLow(int q, int n)
	{
		vtkPixelExtent_GrowLow_19(GetCppThis(), q, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkPixelExtent vtkPixelExtent_GrowLow_20(vtkPixelExtent ext, int q, int n);

	/// <summary>
	/// Add or remove ghost cells. If a problem domain is
	/// provided then the result is clipled to be within the
	/// problem domain.
	/// </summary>
	public static vtkPixelExtent GrowLow(vtkPixelExtent ext, int q, int n)
	{
		return vtkPixelExtent_GrowLow_20(ext, q, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_NodeToCell_21(HandleRef pThis);

	/// <summary>
	/// In-place conversion from cell based to node based extent, and vise-versa.
	/// </summary>
	public void NodeToCell()
	{
		vtkPixelExtent_NodeToCell_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkPixelExtent vtkPixelExtent_NodeToCell_22(vtkPixelExtent inputExt);

	/// <summary>
	/// Convert from point extent to cell extent
	/// while respecting the dimensionality of the data.
	/// </summary>
	public static vtkPixelExtent NodeToCell(vtkPixelExtent inputExt)
	{
		return vtkPixelExtent_NodeToCell_22(inputExt);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_SetData_23(HandleRef pThis, vtkPixelExtent ext);

	/// <summary>
	/// Set the extent.
	/// </summary>
	public void SetData(vtkPixelExtent ext)
	{
		vtkPixelExtent_SetData_23(GetCppThis(), ext);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_SetData_24(HandleRef pThis, IntPtr ext);

	/// <summary>
	/// Stream insertion operator for formatted output of pixel extents.
	/// </summary>
	public void SetData(IntPtr ext)
	{
		vtkPixelExtent_SetData_24(GetCppThis(), ext);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_SetData_25(HandleRef pThis, int ilo, int ihi, int jlo, int jhi);

	/// <summary>
	/// Stream insertion operator for formatted output of pixel extents.
	/// </summary>
	public void SetData(int ilo, int ihi, int jlo, int jhi)
	{
		vtkPixelExtent_SetData_25(GetCppThis(), ilo, ihi, jlo, jhi);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_Shift_26(HandleRef pThis);

	/// <summary>
	/// Shifts by low corner of this, moving to the origin.
	/// </summary>
	public void Shift()
	{
		vtkPixelExtent_Shift_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_Shift_27(HandleRef pThis, vtkPixelExtent ext);

	/// <summary>
	/// Shift by low corner of the given extent.
	/// </summary>
	public void Shift(vtkPixelExtent ext)
	{
		vtkPixelExtent_Shift_27(GetCppThis(), ext);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_Shift_28(HandleRef pThis, IntPtr n);

	/// <summary>
	/// Shift by the given amount.
	/// </summary>
	public void Shift(IntPtr n)
	{
		vtkPixelExtent_Shift_28(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_Shift_29(HandleRef pThis, int q, int n);

	/// <summary>
	/// Shift by the given amount in the given direction.
	/// </summary>
	public void Shift(int q, int n)
	{
		vtkPixelExtent_Shift_29(GetCppThis(), q, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_Shift_30(IntPtr ij, int n);

	/// <summary>
	/// Shift by the given amount while respecting mode.
	/// </summary>
	public static void Shift(IntPtr ij, int n)
	{
		vtkPixelExtent_Shift_30(ij, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_Shift_31(IntPtr ij, IntPtr n);

	/// <summary>
	/// Shift by the given amount while respecting mode.
	/// </summary>
	public static void Shift(IntPtr ij, IntPtr n)
	{
		vtkPixelExtent_Shift_31(ij, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_Shrink_32(HandleRef pThis, int n);

	/// <summary>
	/// Shrink the extent by n.
	/// </summary>
	public void Shrink(int n)
	{
		vtkPixelExtent_Shrink_32(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPixelExtent_Shrink_33(HandleRef pThis, int q, int n);

	/// <summary>
	/// Shrink the extent by n.
	/// </summary>
	public void Shrink(int q, int n)
	{
		vtkPixelExtent_Shrink_33(GetCppThis(), q, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkPixelExtent vtkPixelExtent_Shrink_34(vtkPixelExtent inputExt, vtkPixelExtent problemDomain, int n);

	/// <summary>
	/// Remove ghost cells. If a problem domain is
	/// provided the input is pinned at the domain.
	/// </summary>
	public static vtkPixelExtent Shrink(vtkPixelExtent inputExt, vtkPixelExtent problemDomain, int n)
	{
		return vtkPixelExtent_Shrink_34(inputExt, problemDomain, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkPixelExtent vtkPixelExtent_Shrink_35(vtkPixelExtent inputExt, int n);

	/// <summary>
	/// Remove ghost cells. If a problem domain is
	/// provided the input is pinned at the domain.
	/// </summary>
	public static vtkPixelExtent Shrink(vtkPixelExtent inputExt, int n)
	{
		return vtkPixelExtent_Shrink_35(inputExt, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkPixelExtent_Size_36(HandleRef pThis);

	/// <summary>
	/// Get the total number.
	/// </summary>
	public ulong Size()
	{
		return vtkPixelExtent_Size_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkPixelExtent_Size_37(vtkPixelExtent ext);

	/// <summary>
	/// Get the total number.
	/// </summary>
	public static ulong Size(vtkPixelExtent ext)
	{
		return vtkPixelExtent_Size_37(ext);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkPixelExtent vtkPixelExtent_Split_38(HandleRef pThis, int dir);

	/// <summary>
	/// Divide the extent in half in the given direction. The
	/// operation is done in-place the other half of the split
	/// extent is returned. The return will be empty if the split
	/// could not be made.
	/// </summary>
	public vtkPixelExtent Split(int dir)
	{
		return vtkPixelExtent_Split_38(GetCppThis(), dir);
	}
}
