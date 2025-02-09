using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTableToStructuredGrid
/// </summary>
/// <remarks>
///    converts vtkTable to a vtkStructuredGrid.
///
/// vtkTableToStructuredGrid is a filter that converts an input
/// vtkTable to a vtkStructuredGrid. It provides API to select columns to use as
/// points in the output structured grid. The specified dimensions of the output
/// (specified using SetWholeExtent()) must match the number of rows in the input
/// table.
/// </remarks>
public class vtkTableToStructuredGrid : vtkStructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTableToStructuredGrid";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTableToStructuredGrid()
	{
		MRClassNameKey = "class vtkTableToStructuredGrid";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableToStructuredGrid"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTableToStructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableToStructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTableToStructuredGrid New()
	{
		vtkTableToStructuredGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTableToStructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTableToStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTableToStructuredGrid()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTableToStructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTableToStructuredGrid_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTableToStructuredGrid_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTableToStructuredGrid_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTableToStructuredGrid_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableToStructuredGrid_GetWholeExtent_03(HandleRef pThis);

	/// <summary>
	/// Get/Set the whole extents for the image to produce. The size of the image
	/// must match the number of rows in the input table.
	/// </summary>
	public virtual int[] GetWholeExtent()
	{
		IntPtr intPtr = vtkTableToStructuredGrid_GetWholeExtent_03(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToStructuredGrid_GetWholeExtent_04(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Get/Set the whole extents for the image to produce. The size of the image
	/// must match the number of rows in the input table.
	/// </summary>
	public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkTableToStructuredGrid_GetWholeExtent_04(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToStructuredGrid_GetWholeExtent_05(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the whole extents for the image to produce. The size of the image
	/// must match the number of rows in the input table.
	/// </summary>
	public virtual void GetWholeExtent(IntPtr _arg)
	{
		vtkTableToStructuredGrid_GetWholeExtent_05(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableToStructuredGrid_GetXColumn_06(HandleRef pThis);

	/// <summary>
	/// Set the name of the column to use as the X coordinate for the points.
	/// </summary>
	public virtual string GetXColumn()
	{
		return Marshal.PtrToStringAnsi(vtkTableToStructuredGrid_GetXColumn_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToStructuredGrid_GetXComponent_07(HandleRef pThis);

	/// <summary>
	/// Specify the component for the column specified using SetXColumn() to
	/// use as the xcoordinate in case the column is a multi-component array.
	/// Default is 0.
	/// </summary>
	public virtual int GetXComponent()
	{
		return vtkTableToStructuredGrid_GetXComponent_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToStructuredGrid_GetXComponentMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Specify the component for the column specified using SetXColumn() to
	/// use as the xcoordinate in case the column is a multi-component array.
	/// Default is 0.
	/// </summary>
	public virtual int GetXComponentMaxValue()
	{
		return vtkTableToStructuredGrid_GetXComponentMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToStructuredGrid_GetXComponentMinValue_09(HandleRef pThis);

	/// <summary>
	/// Specify the component for the column specified using SetXColumn() to
	/// use as the xcoordinate in case the column is a multi-component array.
	/// Default is 0.
	/// </summary>
	public virtual int GetXComponentMinValue()
	{
		return vtkTableToStructuredGrid_GetXComponentMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableToStructuredGrid_GetYColumn_10(HandleRef pThis);

	/// <summary>
	/// Set the name of the column to use as the Y coordinate for the points.
	/// Default is 0.
	/// </summary>
	public virtual string GetYColumn()
	{
		return Marshal.PtrToStringAnsi(vtkTableToStructuredGrid_GetYColumn_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToStructuredGrid_GetYComponent_11(HandleRef pThis);

	/// <summary>
	/// Specify the component for the column specified using SetYColumn() to
	/// use as the Ycoordinate in case the column is a multi-component array.
	/// </summary>
	public virtual int GetYComponent()
	{
		return vtkTableToStructuredGrid_GetYComponent_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToStructuredGrid_GetYComponentMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Specify the component for the column specified using SetYColumn() to
	/// use as the Ycoordinate in case the column is a multi-component array.
	/// </summary>
	public virtual int GetYComponentMaxValue()
	{
		return vtkTableToStructuredGrid_GetYComponentMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToStructuredGrid_GetYComponentMinValue_13(HandleRef pThis);

	/// <summary>
	/// Specify the component for the column specified using SetYColumn() to
	/// use as the Ycoordinate in case the column is a multi-component array.
	/// </summary>
	public virtual int GetYComponentMinValue()
	{
		return vtkTableToStructuredGrid_GetYComponentMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableToStructuredGrid_GetZColumn_14(HandleRef pThis);

	/// <summary>
	/// Set the name of the column to use as the Z coordinate for the points.
	/// Default is 0.
	/// </summary>
	public virtual string GetZColumn()
	{
		return Marshal.PtrToStringAnsi(vtkTableToStructuredGrid_GetZColumn_14(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToStructuredGrid_GetZComponent_15(HandleRef pThis);

	/// <summary>
	/// Specify the component for the column specified using SetZColumn() to
	/// use as the Zcoordinate in case the column is a multi-component array.
	/// </summary>
	public virtual int GetZComponent()
	{
		return vtkTableToStructuredGrid_GetZComponent_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToStructuredGrid_GetZComponentMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Specify the component for the column specified using SetZColumn() to
	/// use as the Zcoordinate in case the column is a multi-component array.
	/// </summary>
	public virtual int GetZComponentMaxValue()
	{
		return vtkTableToStructuredGrid_GetZComponentMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToStructuredGrid_GetZComponentMinValue_17(HandleRef pThis);

	/// <summary>
	/// Specify the component for the column specified using SetZColumn() to
	/// use as the Zcoordinate in case the column is a multi-component array.
	/// </summary>
	public virtual int GetZComponentMinValue()
	{
		return vtkTableToStructuredGrid_GetZComponentMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToStructuredGrid_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTableToStructuredGrid_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToStructuredGrid_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTableToStructuredGrid_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableToStructuredGrid_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTableToStructuredGrid NewInstance()
	{
		vtkTableToStructuredGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTableToStructuredGrid_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTableToStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableToStructuredGrid_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTableToStructuredGrid SafeDownCast(vtkObjectBase o)
	{
		vtkTableToStructuredGrid vtkTableToStructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTableToStructuredGrid_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTableToStructuredGrid2 = (vtkTableToStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTableToStructuredGrid2.Register(null);
			}
		}
		return vtkTableToStructuredGrid2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToStructuredGrid_SetWholeExtent_23(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Get/Set the whole extents for the image to produce. The size of the image
	/// must match the number of rows in the input table.
	/// </summary>
	public virtual void SetWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkTableToStructuredGrid_SetWholeExtent_23(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToStructuredGrid_SetWholeExtent_24(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the whole extents for the image to produce. The size of the image
	/// must match the number of rows in the input table.
	/// </summary>
	public virtual void SetWholeExtent(IntPtr _arg)
	{
		vtkTableToStructuredGrid_SetWholeExtent_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToStructuredGrid_SetXColumn_25(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the name of the column to use as the X coordinate for the points.
	/// </summary>
	public virtual void SetXColumn(string _arg)
	{
		vtkTableToStructuredGrid_SetXColumn_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToStructuredGrid_SetXComponent_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the component for the column specified using SetXColumn() to
	/// use as the xcoordinate in case the column is a multi-component array.
	/// Default is 0.
	/// </summary>
	public virtual void SetXComponent(int _arg)
	{
		vtkTableToStructuredGrid_SetXComponent_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToStructuredGrid_SetYColumn_27(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the name of the column to use as the Y coordinate for the points.
	/// Default is 0.
	/// </summary>
	public virtual void SetYColumn(string _arg)
	{
		vtkTableToStructuredGrid_SetYColumn_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToStructuredGrid_SetYComponent_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the component for the column specified using SetYColumn() to
	/// use as the Ycoordinate in case the column is a multi-component array.
	/// </summary>
	public virtual void SetYComponent(int _arg)
	{
		vtkTableToStructuredGrid_SetYComponent_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToStructuredGrid_SetZColumn_29(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the name of the column to use as the Z coordinate for the points.
	/// Default is 0.
	/// </summary>
	public virtual void SetZColumn(string _arg)
	{
		vtkTableToStructuredGrid_SetZColumn_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToStructuredGrid_SetZComponent_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the component for the column specified using SetZColumn() to
	/// use as the Zcoordinate in case the column is a multi-component array.
	/// </summary>
	public virtual void SetZComponent(int _arg)
	{
		vtkTableToStructuredGrid_SetZComponent_30(GetCppThis(), _arg);
	}
}
