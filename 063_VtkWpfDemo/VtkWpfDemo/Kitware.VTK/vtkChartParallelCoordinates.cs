using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkChartParallelCoordinates
/// </summary>
/// <remarks>
///    Factory class for drawing 2D charts
///
///
/// This defines the interface for a parallel coordinates chart.
/// </remarks>
public class vtkChartParallelCoordinates : vtkChart
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkChartParallelCoordinates";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkChartParallelCoordinates()
	{
		MRClassNameKey = "class vtkChartParallelCoordinates";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkChartParallelCoordinates"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkChartParallelCoordinates(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartParallelCoordinates_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a parallel coordinates chart
	/// </summary>
	public new static vtkChartParallelCoordinates New()
	{
		vtkChartParallelCoordinates result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartParallelCoordinates_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkChartParallelCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a parallel coordinates chart
	/// </summary>
	public vtkChartParallelCoordinates()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkChartParallelCoordinates_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkChartParallelCoordinates_GetAxis_01(HandleRef pThis, int axisIndex, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the axis specified by axisIndex.
	/// </summary>
	public override vtkAxis GetAxis(int axisIndex)
	{
		vtkAxis vtkAxis2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartParallelCoordinates_GetAxis_01(GetCppThis(), axisIndex, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAxis2 = (vtkAxis)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAxis2.Register(null);
			}
		}
		return vtkAxis2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartParallelCoordinates_GetColumnVisibility_02(HandleRef pThis, string name);

	/// <summary>
	/// Get the visibility of the specified column.
	/// </summary>
	public bool GetColumnVisibility(string name)
	{
		return (vtkChartParallelCoordinates_GetColumnVisibility_02(GetCppThis(), name) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartParallelCoordinates_GetNumberOfAxes_03(HandleRef pThis);

	/// <summary>
	/// Get the number of axes in the current chart.
	/// </summary>
	public override long GetNumberOfAxes()
	{
		return vtkChartParallelCoordinates_GetNumberOfAxes_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartParallelCoordinates_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkChartParallelCoordinates_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartParallelCoordinates_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkChartParallelCoordinates_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartParallelCoordinates_GetNumberOfPlots_06(HandleRef pThis);

	/// <summary>
	/// Get the number of plots the chart contains.
	/// </summary>
	public override long GetNumberOfPlots()
	{
		return vtkChartParallelCoordinates_GetNumberOfPlots_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartParallelCoordinates_GetPlot_07(HandleRef pThis, long index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the plot at the specified index, returns null if the index is invalid.
	/// </summary>
	public override vtkPlot GetPlot(long index)
	{
		vtkPlot vtkPlot2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartParallelCoordinates_GetPlot_07(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlot2 = (vtkPlot)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlot2.Register(null);
			}
		}
		return vtkPlot2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartParallelCoordinates_GetVisibleColumns_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a list of the columns, and the order in which they are displayed.
	/// </summary>
	public virtual vtkStringArray GetVisibleColumns()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartParallelCoordinates_GetVisibleColumns_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChartParallelCoordinates_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkChartParallelCoordinates_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChartParallelCoordinates_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkChartParallelCoordinates_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartParallelCoordinates_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkChartParallelCoordinates NewInstance()
	{
		vtkChartParallelCoordinates result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartParallelCoordinates_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkChartParallelCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartParallelCoordinates_Paint_13(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the chart, called whenever the chart needs to be drawn
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkChartParallelCoordinates_Paint_13(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartParallelCoordinates_PaintRect_14(HandleRef pThis, HandleRef painter, int axis, float min, float max);

	/// <summary>
	/// Draw a rect on a specific axis
	/// </summary>
	public bool PaintRect(vtkContext2D painter, int axis, float min, float max)
	{
		return (vtkChartParallelCoordinates_PaintRect_14(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef), axis, min, max) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartParallelCoordinates_RecalculateBounds_15(HandleRef pThis);

	/// <summary>
	/// Request that the chart recalculates the range of its axes. Especially
	/// useful in applications after the parameters of plots have been modified.
	/// </summary>
	public override void RecalculateBounds()
	{
		vtkChartParallelCoordinates_RecalculateBounds_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartParallelCoordinates_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkChartParallelCoordinates SafeDownCast(vtkObjectBase o)
	{
		vtkChartParallelCoordinates vtkChartParallelCoordinates2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartParallelCoordinates_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkChartParallelCoordinates2 = (vtkChartParallelCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkChartParallelCoordinates2.Register(null);
			}
		}
		return vtkChartParallelCoordinates2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartParallelCoordinates_SetColumnVisibility_17(HandleRef pThis, string name, byte visible);

	/// <summary>
	/// Set the visibility of the specified column.
	/// </summary>
	public void SetColumnVisibility(string name, bool visible)
	{
		vtkChartParallelCoordinates_SetColumnVisibility_17(GetCppThis(), name, (byte)(visible ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartParallelCoordinates_SetColumnVisibilityAll_18(HandleRef pThis, byte visible);

	/// <summary>
	/// Set the visibility of all columns (true will make them all visible, false
	/// will remove all visible columns).
	/// </summary>
	public void SetColumnVisibilityAll(bool visible)
	{
		vtkChartParallelCoordinates_SetColumnVisibilityAll_18(GetCppThis(), (byte)(visible ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartParallelCoordinates_SetPlot_19(HandleRef pThis, HandleRef plot);

	/// <summary>
	/// Set plot to use for the chart. Since this type of chart can
	/// only contain one plot, this will replace the previous plot.
	/// </summary>
	public virtual void SetPlot(vtkPlotParallelCoordinates plot)
	{
		vtkChartParallelCoordinates_SetPlot_19(GetCppThis(), plot?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartParallelCoordinates_SetVisibleColumns_20(HandleRef pThis, HandleRef visColumns);

	/// <summary>
	/// Set the list of visible columns, and the order in which they will be displayed.
	/// </summary>
	public virtual void SetVisibleColumns(vtkStringArray visColumns)
	{
		vtkChartParallelCoordinates_SetVisibleColumns_20(GetCppThis(), visColumns?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartParallelCoordinates_Update_21(HandleRef pThis);

	/// <summary>
	/// Perform any updates to the item that may be necessary before rendering.
	/// The scene should take care of calling this on all items before their
	/// Paint function is invoked.
	/// </summary>
	public override void Update()
	{
		vtkChartParallelCoordinates_Update_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartParallelCoordinates_UpdateCurrentAxisSelection_22(HandleRef pThis, int axisId);

	/// <summary>
	/// Update the selection of an axis based on the current selectionMode we
	/// have previously set.
	/// </summary>
	public void UpdateCurrentAxisSelection(int axisId)
	{
		vtkChartParallelCoordinates_UpdateCurrentAxisSelection_22(GetCppThis(), axisId);
	}
}
