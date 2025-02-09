using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkIdFilter
/// </summary>
/// <remarks>
///    generate scalars or field data from point and cell ids
///
/// vtkIdFilter is a filter to that generates scalars or field data
/// using cell and point ids. That is, the point attribute data scalars
/// or field data are generated from the point ids, and the cell
/// attribute data scalars or field data are generated from the
/// cell ids.
///
/// Typically this filter is used with vtkLabeledDataMapper (and possibly
/// vtkSelectVisiblePoints) to create labels for points and cells, or labels
/// for the point or cell data scalar values.
/// </remarks>
public class vtkIdFilter : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkIdFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkIdFilter()
	{
		MRClassNameKey = "class vtkIdFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkIdFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkIdFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIdFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with PointIds and CellIds on; and ids being generated
	/// as scalars.
	/// </summary>
	public new static vtkIdFilter New()
	{
		vtkIdFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIdFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIdFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with PointIds and CellIds on; and ids being generated
	/// as scalars.
	/// </summary>
	public vtkIdFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkIdFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkIdFilter_CellIdsOff_01(HandleRef pThis);

	/// <summary>
	/// Enable/disable the generation of point ids. Default is on.
	/// </summary>
	public virtual void CellIdsOff()
	{
		vtkIdFilter_CellIdsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdFilter_CellIdsOn_02(HandleRef pThis);

	/// <summary>
	/// Enable/disable the generation of point ids. Default is on.
	/// </summary>
	public virtual void CellIdsOn()
	{
		vtkIdFilter_CellIdsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdFilter_FieldDataOff_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which controls whether to generate scalar data
	/// or field data. If this flag is off, scalar data is generated.
	/// Otherwise, field data is generated. Default is off.
	/// </summary>
	public virtual void FieldDataOff()
	{
		vtkIdFilter_FieldDataOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdFilter_FieldDataOn_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which controls whether to generate scalar data
	/// or field data. If this flag is off, scalar data is generated.
	/// Otherwise, field data is generated. Default is off.
	/// </summary>
	public virtual void FieldDataOn()
	{
		vtkIdFilter_FieldDataOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIdFilter_GetCellIds_05(HandleRef pThis);

	/// <summary>
	/// Enable/disable the generation of point ids. Default is on.
	/// </summary>
	public virtual int GetCellIds()
	{
		return vtkIdFilter_GetCellIds_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIdFilter_GetCellIdsArrayName_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the Ids array for points, if generated. By default,
	/// set to "vtkIdFilter_Ids" for backwards compatibility.
	/// </summary>
	public virtual string GetCellIdsArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkIdFilter_GetCellIdsArrayName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIdFilter_GetFieldData_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag which controls whether to generate scalar data
	/// or field data. If this flag is off, scalar data is generated.
	/// Otherwise, field data is generated. Default is off.
	/// </summary>
	public virtual int GetFieldData()
	{
		return vtkIdFilter_GetFieldData_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIdFilter_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkIdFilter_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIdFilter_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkIdFilter_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIdFilter_GetPointIds_10(HandleRef pThis);

	/// <summary>
	/// Enable/disable the generation of point ids. Default is on.
	/// </summary>
	public virtual int GetPointIds()
	{
		return vtkIdFilter_GetPointIds_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIdFilter_GetPointIdsArrayName_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the Ids array for points, if generated. By default,
	/// set to "vtkIdFilter_Ids" for backwards compatibility.
	/// </summary>
	public virtual string GetPointIdsArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkIdFilter_GetPointIdsArrayName_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIdFilter_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkIdFilter_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIdFilter_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkIdFilter_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIdFilter_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkIdFilter NewInstance()
	{
		vtkIdFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIdFilter_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIdFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdFilter_PointIdsOff_16(HandleRef pThis);

	/// <summary>
	/// Enable/disable the generation of point ids. Default is on.
	/// </summary>
	public virtual void PointIdsOff()
	{
		vtkIdFilter_PointIdsOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdFilter_PointIdsOn_17(HandleRef pThis);

	/// <summary>
	/// Enable/disable the generation of point ids. Default is on.
	/// </summary>
	public virtual void PointIdsOn()
	{
		vtkIdFilter_PointIdsOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIdFilter_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIdFilter SafeDownCast(vtkObjectBase o)
	{
		vtkIdFilter vtkIdFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIdFilter_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdFilter2 = (vtkIdFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdFilter2.Register(null);
			}
		}
		return vtkIdFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdFilter_SetCellIds_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable the generation of point ids. Default is on.
	/// </summary>
	public virtual void SetCellIds(int _arg)
	{
		vtkIdFilter_SetCellIds_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdFilter_SetCellIdsArrayName_20(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of the Ids array for points, if generated. By default,
	/// set to "vtkIdFilter_Ids" for backwards compatibility.
	/// </summary>
	public virtual void SetCellIdsArrayName(string _arg)
	{
		vtkIdFilter_SetCellIdsArrayName_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdFilter_SetFieldData_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag which controls whether to generate scalar data
	/// or field data. If this flag is off, scalar data is generated.
	/// Otherwise, field data is generated. Default is off.
	/// </summary>
	public virtual void SetFieldData(int _arg)
	{
		vtkIdFilter_SetFieldData_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdFilter_SetPointIds_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable the generation of point ids. Default is on.
	/// </summary>
	public virtual void SetPointIds(int _arg)
	{
		vtkIdFilter_SetPointIds_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdFilter_SetPointIdsArrayName_23(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of the Ids array for points, if generated. By default,
	/// set to "vtkIdFilter_Ids" for backwards compatibility.
	/// </summary>
	public virtual void SetPointIdsArrayName(string _arg)
	{
		vtkIdFilter_SetPointIdsArrayName_23(GetCppThis(), _arg);
	}
}
