using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkArrayRename
/// </summary>
/// <remarks>
///    Rename data arrays.
///
///  This class takes any vtkDataObject as input, shallow copies its content to
///  the output and renames its data arrays.
///
///  For each attributes type, array name should be unique.
///
///  Supported attributes type are the following: POINT, CELL, FIELD, VERTEX, EDGE and ROW.
/// </remarks>
public class vtkArrayRename : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkArrayRename";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkArrayRename()
	{
		MRClassNameKey = "class vtkArrayRename";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayRename"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkArrayRename(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayRename_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkArrayRename New()
	{
		vtkArrayRename result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArrayRename_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkArrayRename)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkArrayRename()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkArrayRename_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		SetCppThis(rawCppThis, callDisposalMethod: true, (mteStatus != 0 && rawRefCount >= 2) ? true : false);
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_ClearAll_01(HandleRef pThis);

	/// <summary>
	/// Clear name mappings for all attribute types.
	/// </summary>
	public void ClearAll()
	{
		vtkArrayRename_ClearAll_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_ClearCellMapping_02(HandleRef pThis);

	/// <summary>
	/// Get / Set array name mapping for CellData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public void ClearCellMapping()
	{
		vtkArrayRename_ClearCellMapping_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_ClearEdgeMapping_03(HandleRef pThis);

	/// <summary>
	/// Get / Set array name mapping for EdgeData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public void ClearEdgeMapping()
	{
		vtkArrayRename_ClearEdgeMapping_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_ClearFieldMapping_04(HandleRef pThis);

	/// <summary>
	/// Get / Set array name mapping for FieldData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public void ClearFieldMapping()
	{
		vtkArrayRename_ClearFieldMapping_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_ClearMapping_05(HandleRef pThis, int attributeType);

	/// <summary>
	/// Clear mapping for the specified attribute type.
	/// </summary>
	public void ClearMapping(int attributeType)
	{
		vtkArrayRename_ClearMapping_05(GetCppThis(), attributeType);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_ClearPointMapping_06(HandleRef pThis);

	/// <summary>
	/// Get / Set array name mapping for PointData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public void ClearPointMapping()
	{
		vtkArrayRename_ClearPointMapping_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_ClearRowMapping_07(HandleRef pThis);

	/// <summary>
	/// Get / Set array name mapping for RowData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public void ClearRowMapping()
	{
		vtkArrayRename_ClearRowMapping_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_ClearVertexMapping_08(HandleRef pThis);

	/// <summary>
	/// Get / Set array name mapping for VertexData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public void ClearVertexMapping()
	{
		vtkArrayRename_ClearVertexMapping_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayRename_GetArrayNewName_09(HandleRef pThis, int attributeType, int idx);

	/// <summary>
	/// Get the new array name from \p idx in \p attributeType field data.
	/// </summary>
	public string GetArrayNewName(int attributeType, int idx)
	{
		return Marshal.PtrToStringAnsi(vtkArrayRename_GetArrayNewName_09(GetCppThis(), attributeType, idx));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayRename_GetArrayOriginalName_10(HandleRef pThis, int attributeType, int idx);

	/// <summary>
	/// Get the input array name from \p idx in \p attributeType field data.
	/// </summary>
	public string GetArrayOriginalName(int attributeType, int idx)
	{
		return Marshal.PtrToStringAnsi(vtkArrayRename_GetArrayOriginalName_10(GetCppThis(), attributeType, idx));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayRename_GetCellArrayNewName_11(HandleRef pThis, int idx);

	/// <summary>
	/// Get / Set array name mapping for CellData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public string GetCellArrayNewName(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkArrayRename_GetCellArrayNewName_11(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayRename_GetCellArrayOriginalName_12(HandleRef pThis, int idx);

	/// <summary>
	/// Get / Set array name mapping for CellData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public string GetCellArrayOriginalName(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkArrayRename_GetCellArrayOriginalName_12(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayRename_GetEdgeArrayNewName_13(HandleRef pThis, int idx);

	/// <summary>
	/// Get / Set array name mapping for EdgeData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public string GetEdgeArrayNewName(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkArrayRename_GetEdgeArrayNewName_13(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayRename_GetEdgeArrayOriginalName_14(HandleRef pThis, int idx);

	/// <summary>
	/// Get / Set array name mapping for EdgeData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public string GetEdgeArrayOriginalName(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkArrayRename_GetEdgeArrayOriginalName_14(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayRename_GetFieldArrayNewName_15(HandleRef pThis, int idx);

	/// <summary>
	/// Get / Set array name mapping for FieldData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public string GetFieldArrayNewName(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkArrayRename_GetFieldArrayNewName_15(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayRename_GetFieldArrayOriginalName_16(HandleRef pThis, int idx);

	/// <summary>
	/// Get / Set array name mapping for FieldData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public string GetFieldArrayOriginalName(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkArrayRename_GetFieldArrayOriginalName_16(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayRename_GetNumberOfArrays_17(HandleRef pThis, int attributeType);

	/// <summary>
	/// Get number of arrays for specified attribute type.
	/// </summary>
	public int GetNumberOfArrays(int attributeType)
	{
		return vtkArrayRename_GetNumberOfArrays_17(GetCppThis(), attributeType);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayRename_GetNumberOfCellArrays_18(HandleRef pThis);

	/// <summary>
	/// Get / Set array name mapping for CellData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public int GetNumberOfCellArrays()
	{
		return vtkArrayRename_GetNumberOfCellArrays_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayRename_GetNumberOfEdgeArrays_19(HandleRef pThis);

	/// <summary>
	/// Get / Set array name mapping for EdgeData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public int GetNumberOfEdgeArrays()
	{
		return vtkArrayRename_GetNumberOfEdgeArrays_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayRename_GetNumberOfFieldArrays_20(HandleRef pThis);

	/// <summary>
	/// Get / Set array name mapping for FieldData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public int GetNumberOfFieldArrays()
	{
		return vtkArrayRename_GetNumberOfFieldArrays_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkArrayRename_GetNumberOfGenerationsFromBase_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkArrayRename_GetNumberOfGenerationsFromBase_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkArrayRename_GetNumberOfGenerationsFromBaseType_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkArrayRename_GetNumberOfGenerationsFromBaseType_22(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayRename_GetNumberOfPointArrays_23(HandleRef pThis);

	/// <summary>
	/// Get / Set array name mapping for PointData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public int GetNumberOfPointArrays()
	{
		return vtkArrayRename_GetNumberOfPointArrays_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayRename_GetNumberOfRowArrays_24(HandleRef pThis);

	/// <summary>
	/// Get / Set array name mapping for RowData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public int GetNumberOfRowArrays()
	{
		return vtkArrayRename_GetNumberOfRowArrays_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayRename_GetNumberOfVertexArrays_25(HandleRef pThis);

	/// <summary>
	/// Get / Set array name mapping for VertexData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public int GetNumberOfVertexArrays()
	{
		return vtkArrayRename_GetNumberOfVertexArrays_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayRename_GetPointArrayNewName_26(HandleRef pThis, int idx);

	/// <summary>
	/// Get / Set array name mapping for PointData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public string GetPointArrayNewName(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkArrayRename_GetPointArrayNewName_26(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayRename_GetPointArrayOriginalName_27(HandleRef pThis, int idx);

	/// <summary>
	/// Get / Set array name mapping for PointData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public string GetPointArrayOriginalName(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkArrayRename_GetPointArrayOriginalName_27(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayRename_GetRowArrayNewName_28(HandleRef pThis, int idx);

	/// <summary>
	/// Get / Set array name mapping for RowData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public string GetRowArrayNewName(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkArrayRename_GetRowArrayNewName_28(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayRename_GetRowArrayOriginalName_29(HandleRef pThis, int idx);

	/// <summary>
	/// Get / Set array name mapping for RowData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public string GetRowArrayOriginalName(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkArrayRename_GetRowArrayOriginalName_29(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayRename_GetVertexArrayNewName_30(HandleRef pThis, int idx);

	/// <summary>
	/// Get / Set array name mapping for VertexData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public string GetVertexArrayNewName(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkArrayRename_GetVertexArrayNewName_30(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayRename_GetVertexArrayOriginalName_31(HandleRef pThis, int idx);

	/// <summary>
	/// Get / Set array name mapping for VertexData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public string GetVertexArrayOriginalName(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkArrayRename_GetVertexArrayOriginalName_31(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayRename_IsA_32(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkArrayRename_IsA_32(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayRename_IsTypeOf_33(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkArrayRename_IsTypeOf_33(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayRename_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkArrayRename NewInstance()
	{
		vtkArrayRename result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArrayRename_NewInstance_35(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkArrayRename)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayRename_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkArrayRename SafeDownCast(vtkObjectBase o)
	{
		vtkArrayRename vtkArrayRename2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArrayRename_SafeDownCast_36(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkArrayRename2 = (vtkArrayRename)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkArrayRename2.Register(null);
			}
		}
		return vtkArrayRename2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_SetArrayName_37(HandleRef pThis, int attributeType, int idx, string newName);

	/// <summary>
	/// Set the new array name from \p idx in \p attributeType field data.
	/// </summary>
	public void SetArrayName(int attributeType, int idx, string newName)
	{
		vtkArrayRename_SetArrayName_37(GetCppThis(), attributeType, idx, newName);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_SetArrayName_38(HandleRef pThis, int attributeType, string inputName, string newName);

	/// <summary>
	/// Set the new array name from \p inputName in \p attributeType field data.
	/// </summary>
	public void SetArrayName(int attributeType, string inputName, string newName)
	{
		vtkArrayRename_SetArrayName_38(GetCppThis(), attributeType, inputName, newName);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_SetCellArrayName_39(HandleRef pThis, int idx, string newName);

	/// <summary>
	/// Get / Set array name mapping for CellData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public void SetCellArrayName(int idx, string newName)
	{
		vtkArrayRename_SetCellArrayName_39(GetCppThis(), idx, newName);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_SetCellArrayName_40(HandleRef pThis, string inputName, string newName);

	/// <summary>
	/// Get / Set array name mapping for CellData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public void SetCellArrayName(string inputName, string newName)
	{
		vtkArrayRename_SetCellArrayName_40(GetCppThis(), inputName, newName);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_SetEdgeArrayName_41(HandleRef pThis, int idx, string newName);

	/// <summary>
	/// Get / Set array name mapping for EdgeData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public void SetEdgeArrayName(int idx, string newName)
	{
		vtkArrayRename_SetEdgeArrayName_41(GetCppThis(), idx, newName);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_SetEdgeArrayName_42(HandleRef pThis, string inputName, string newName);

	/// <summary>
	/// Get / Set array name mapping for EdgeData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public void SetEdgeArrayName(string inputName, string newName)
	{
		vtkArrayRename_SetEdgeArrayName_42(GetCppThis(), inputName, newName);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_SetFieldArrayName_43(HandleRef pThis, int idx, string newName);

	/// <summary>
	/// Get / Set array name mapping for FieldData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public void SetFieldArrayName(int idx, string newName)
	{
		vtkArrayRename_SetFieldArrayName_43(GetCppThis(), idx, newName);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_SetFieldArrayName_44(HandleRef pThis, string inputName, string newName);

	/// <summary>
	/// Get / Set array name mapping for FieldData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public void SetFieldArrayName(string inputName, string newName)
	{
		vtkArrayRename_SetFieldArrayName_44(GetCppThis(), inputName, newName);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_SetPointArrayName_45(HandleRef pThis, int idx, string newName);

	/// <summary>
	/// Get / Set array name mapping for PointData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public void SetPointArrayName(int idx, string newName)
	{
		vtkArrayRename_SetPointArrayName_45(GetCppThis(), idx, newName);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_SetPointArrayName_46(HandleRef pThis, string inputName, string newName);

	/// <summary>
	/// Get / Set array name mapping for PointData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public void SetPointArrayName(string inputName, string newName)
	{
		vtkArrayRename_SetPointArrayName_46(GetCppThis(), inputName, newName);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_SetRowArrayName_47(HandleRef pThis, int idx, string newName);

	/// <summary>
	/// Get / Set array name mapping for RowData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public void SetRowArrayName(int idx, string newName)
	{
		vtkArrayRename_SetRowArrayName_47(GetCppThis(), idx, newName);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_SetRowArrayName_48(HandleRef pThis, string inputName, string newName);

	/// <summary>
	/// Get / Set array name mapping for RowData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public void SetRowArrayName(string inputName, string newName)
	{
		vtkArrayRename_SetRowArrayName_48(GetCppThis(), inputName, newName);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_SetVertexArrayName_49(HandleRef pThis, int idx, string newName);

	/// <summary>
	/// Get / Set array name mapping for VertexData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public void SetVertexArrayName(int idx, string newName)
	{
		vtkArrayRename_SetVertexArrayName_49(GetCppThis(), idx, newName);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayRename_SetVertexArrayName_50(HandleRef pThis, string inputName, string newName);

	/// <summary>
	/// Get / Set array name mapping for VertexData.
	/// Forwarded to the corresponding generic method:
	/// @sa GetNumberOfArrays, GetArrayOriginalName, GetArrayNewName, SetArrayName
	/// </summary>
	public void SetVertexArrayName(string inputName, string newName)
	{
		vtkArrayRename_SetVertexArrayName_50(GetCppThis(), inputName, newName);
	}
}
