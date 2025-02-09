using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlotParallelCoordinates
/// </summary>
/// <remarks>
///    Class for drawing a parallel coordinate
/// plot given columns from a vtkTable.
///
///
///
/// </remarks>
public class vtkPlotParallelCoordinates : vtkPlot
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlotParallelCoordinates";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlotParallelCoordinates()
	{
		MRClassNameKey = "class vtkPlotParallelCoordinates";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotParallelCoordinates"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlotParallelCoordinates(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotParallelCoordinates_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a parallel coordinates chart
	/// </summary>
	public new static vtkPlotParallelCoordinates New()
	{
		vtkPlotParallelCoordinates result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotParallelCoordinates_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlotParallelCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a parallel coordinates chart
	/// </summary>
	public vtkPlotParallelCoordinates()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPlotParallelCoordinates_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotParallelCoordinates_CreateDefaultLookupTable_01(HandleRef pThis);

	/// <summary>
	/// Create default lookup table. Generally used to create one when none
	/// is available with the scalar data.
	/// </summary>
	public virtual void CreateDefaultLookupTable()
	{
		vtkPlotParallelCoordinates_CreateDefaultLookupTable_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotParallelCoordinates_GetBounds_02(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the bounds for this mapper as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkPlotParallelCoordinates_GetBounds_02(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkPlotParallelCoordinates_GetColorArrayName_03(HandleRef pThis);

	/// <summary>
	/// Get the array name to color by.
	/// </summary>
	public string GetColorArrayName()
	{
		return vtkPlotParallelCoordinates_GetColorArrayName_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotParallelCoordinates_GetLookupTable_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a lookup table for the mapper to use.
	/// </summary>
	public vtkScalarsToColors GetLookupTable()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotParallelCoordinates_GetLookupTable_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarsToColors2 = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarsToColors2.Register(null);
			}
		}
		return vtkScalarsToColors2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotParallelCoordinates_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlotParallelCoordinates_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotParallelCoordinates_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlotParallelCoordinates_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotParallelCoordinates_GetScalarVisibility_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual int GetScalarVisibility()
	{
		return vtkPlotParallelCoordinates_GetScalarVisibility_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotParallelCoordinates_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlotParallelCoordinates_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotParallelCoordinates_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlotParallelCoordinates_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotParallelCoordinates_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPlotParallelCoordinates NewInstance()
	{
		vtkPlotParallelCoordinates result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotParallelCoordinates_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlotParallelCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotParallelCoordinates_Paint_12(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the XY plot, called whenever the chart needs to be drawn
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkPlotParallelCoordinates_Paint_12(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotParallelCoordinates_PaintLegend_13(HandleRef pThis, HandleRef painter, HandleRef rect, int legendIndex);

	/// <summary>
	/// Paint legend event for the XY plot, called whenever the legend needs the
	/// plot items symbol/mark/line drawn. A rect is supplied with the lower left
	/// corner of the rect (elements 0 and 1) and with width x height (elements 2
	/// and 3). The plot can choose how to fill the space supplied.
	/// </summary>
	public override bool PaintLegend(vtkContext2D painter, vtkRectf rect, int legendIndex)
	{
		return (vtkPlotParallelCoordinates_PaintLegend_13(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef), rect?.GetCppThis() ?? default(HandleRef), legendIndex) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotParallelCoordinates_ResetSelectionRange_14(HandleRef pThis);

	/// <summary>
	/// Reset the selection criteria for the chart.
	/// </summary>
	public bool ResetSelectionRange()
	{
		return (vtkPlotParallelCoordinates_ResetSelectionRange_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotParallelCoordinates_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlotParallelCoordinates SafeDownCast(vtkObjectBase o)
	{
		vtkPlotParallelCoordinates vtkPlotParallelCoordinates2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotParallelCoordinates_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlotParallelCoordinates2 = (vtkPlotParallelCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlotParallelCoordinates2.Register(null);
			}
		}
		return vtkPlotParallelCoordinates2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotParallelCoordinates_ScalarVisibilityOff_16(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual void ScalarVisibilityOff()
	{
		vtkPlotParallelCoordinates_ScalarVisibilityOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotParallelCoordinates_ScalarVisibilityOn_17(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual void ScalarVisibilityOn()
	{
		vtkPlotParallelCoordinates_ScalarVisibilityOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotParallelCoordinates_SelectColorArray_18(HandleRef pThis, long arrayNum);

	/// <summary>
	/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
	/// you can specify which array to use for coloring using these methods.
	/// The lookup table will decide how to convert vectors to colors.
	/// </summary>
	public void SelectColorArray(long arrayNum)
	{
		vtkPlotParallelCoordinates_SelectColorArray_18(GetCppThis(), arrayNum);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotParallelCoordinates_SelectColorArray_19(HandleRef pThis, string arrayName);

	/// <summary>
	/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
	/// you can specify which array to use for coloring using these methods.
	/// The lookup table will decide how to convert vectors to colors.
	/// </summary>
	public void SelectColorArray(string arrayName)
	{
		vtkPlotParallelCoordinates_SelectColorArray_19(GetCppThis(), arrayName);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotParallelCoordinates_SetInputData_20(HandleRef pThis, HandleRef table);

	/// <summary>
	/// This is a convenience function to set the input table.
	/// </summary>
	public override void SetInputData(vtkTable table)
	{
		vtkPlotParallelCoordinates_SetInputData_20(GetCppThis(), table?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotParallelCoordinates_SetInputData_21(HandleRef pThis, HandleRef table, string arg1, string arg2);

	/// <summary>
	/// This is a convenience function to set the input table.
	/// </summary>
	public override void SetInputData(vtkTable table, string arg1, string arg2)
	{
		vtkPlotParallelCoordinates_SetInputData_21(GetCppThis(), table?.GetCppThis() ?? default(HandleRef), arg1, arg2);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotParallelCoordinates_SetLookupTable_22(HandleRef pThis, HandleRef lut);

	/// <summary>
	/// Specify a lookup table for the mapper to use.
	/// </summary>
	public void SetLookupTable(vtkScalarsToColors lut)
	{
		vtkPlotParallelCoordinates_SetLookupTable_22(GetCppThis(), lut?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotParallelCoordinates_SetScalarVisibility_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual void SetScalarVisibility(int _arg)
	{
		vtkPlotParallelCoordinates_SetScalarVisibility_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotParallelCoordinates_SetSelectionRange_24(HandleRef pThis, int axis, float low, float high);

	/// <summary>
	/// Set the selection criteria on the given axis in normalized space (0.0 - 1.0) for a specific
	/// range.
	/// </summary>
	public bool SetSelectionRange(int axis, float low, float high)
	{
		return (vtkPlotParallelCoordinates_SetSelectionRange_24(GetCppThis(), axis, low, high) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotParallelCoordinates_UpdateCache_25(HandleRef pThis);

	/// <summary>
	/// Update the internal cache. Returns true if cache was successfully updated. Default does
	/// nothing.
	/// This method is called by Update() when either the plot's data has changed or
	/// CacheRequiresUpdate() returns true. It is not necessary to call this method explicitly.
	/// </summary>
	public override bool UpdateCache()
	{
		return (vtkPlotParallelCoordinates_UpdateCache_25(GetCppThis()) != 0) ? true : false;
	}
}
