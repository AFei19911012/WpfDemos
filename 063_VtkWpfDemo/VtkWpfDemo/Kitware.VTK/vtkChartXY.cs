using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkChartXY
/// </summary>
/// <remarks>
///    Factory class for drawing XY charts
///
///
/// This class implements an XY chart.
///
/// </remarks>
/// <seealso>
///
/// vtkBarChartActor
/// </seealso>
public class vtkChartXY : vtkChart
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkChartXY";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkChartXY()
	{
		MRClassNameKey = "class vtkChartXY";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkChartXY"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkChartXY(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartXY_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a 2D Chart object.
	/// </summary>
	public new static vtkChartXY New()
	{
		vtkChartXY result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartXY_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkChartXY)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a 2D Chart object.
	/// </summary>
	public vtkChartXY()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkChartXY_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkChartXY_AddPlot_01(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Add a plot to the chart, defaults to using the name of the y column
	/// </summary>
	public override vtkPlot AddPlot(int type)
	{
		vtkPlot vtkPlot2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartXY_AddPlot_01(GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkChartXY_AddPlot_02(HandleRef pThis, int type, uint blockIndex, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Adds a plot to the chart holding data specific to a block in a vtkMultiBlockDataSet.
	/// </summary>
	public virtual vtkPlot AddPlot(int type, uint blockIndex)
	{
		vtkPlot vtkPlot2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartXY_AddPlot_02(GetCppThis(), type, blockIndex, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkChartXY_AddPlot_03(HandleRef pThis, HandleRef plot);

	/// <summary>
	/// Adds a plot to the chart
	/// </summary>
	public override long AddPlot(vtkPlot plot)
	{
		return vtkChartXY_AddPlot_03(GetCppThis(), plot?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartXY_AddPlot_04(HandleRef pThis, HandleRef plot, uint blockIndex);

	/// <summary>
	/// Adds a plot to the chart holding data specific to a block in a vtkMultiBlockDataSet.
	/// </summary>
	public virtual long AddPlot(vtkPlot plot, uint blockIndex)
	{
		return vtkChartXY_AddPlot_04(GetCppThis(), plot?.GetCppThis() ?? default(HandleRef), blockIndex);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_AddSelection_05(HandleRef selection, HandleRef oldSelection);

	/// <summary>
	/// Add the supplied selection from the oldSelection.
	/// </summary>
	public static void AddSelection(vtkIdTypeArray selection, vtkIdTypeArray oldSelection)
	{
		vtkChartXY_AddSelection_05(selection?.GetCppThis() ?? default(HandleRef), oldSelection?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_AdjustLowerBoundForLogPlotOff_06(HandleRef pThis);

	/// <summary>
	/// Adjust the minimum of a logarithmic axis to be greater than 0, regardless
	/// of the minimum data value.
	/// False by default.
	/// </summary>
	public virtual void AdjustLowerBoundForLogPlotOff()
	{
		vtkChartXY_AdjustLowerBoundForLogPlotOff_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_AdjustLowerBoundForLogPlotOn_07(HandleRef pThis);

	/// <summary>
	/// Adjust the minimum of a logarithmic axis to be greater than 0, regardless
	/// of the minimum data value.
	/// False by default.
	/// </summary>
	public virtual void AdjustLowerBoundForLogPlotOn()
	{
		vtkChartXY_AdjustLowerBoundForLogPlotOn_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_AutoAxesOff_08(HandleRef pThis);

	/// <summary>
	/// If true then the axes will be turned on and off depending upon whether
	/// any plots are in that corner. Defaults to true.
	/// </summary>
	public virtual void AutoAxesOff()
	{
		vtkChartXY_AutoAxesOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_AutoAxesOn_09(HandleRef pThis);

	/// <summary>
	/// If true then the axes will be turned on and off depending upon whether
	/// any plots are in that corner. Defaults to true.
	/// </summary>
	public virtual void AutoAxesOn()
	{
		vtkChartXY_AutoAxesOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_BuildSelection_10(HandleRef link, int selectionMode, HandleRef plotSelection, HandleRef oldSelection, HandleRef plot);

	/// <summary>
	/// Build a selection based on the supplied selectionMode using the new
	/// plotSelection and combining it with the oldSelection. If link is not nullptr
	/// then the resulting selection will be set on the link.
	/// This is used in the plot or the column based selection.
	/// </summary>
	public static void BuildSelection(vtkAnnotationLink link, int selectionMode, vtkIdTypeArray plotSelection, vtkIdTypeArray oldSelection, vtkPlot plot)
	{
		vtkChartXY_BuildSelection_10(link?.GetCppThis() ?? default(HandleRef), selectionMode, plotSelection?.GetCppThis() ?? default(HandleRef), oldSelection?.GetCppThis() ?? default(HandleRef), plot?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_ClearPlots_11(HandleRef pThis);

	/// <summary>
	/// Remove all plots from the chart.
	/// </summary>
	public override void ClearPlots()
	{
		vtkChartXY_ClearPlots_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_DragPointAlongXOff_12(HandleRef pThis);

	/// <summary>
	/// Set if the point can be dragged along X
	/// by the ClickAndDrag Action
	/// True by default.
	/// </summary>
	public virtual void DragPointAlongXOff()
	{
		vtkChartXY_DragPointAlongXOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_DragPointAlongXOn_13(HandleRef pThis);

	/// <summary>
	/// Set if the point can be dragged along X
	/// by the ClickAndDrag Action
	/// True by default.
	/// </summary>
	public virtual void DragPointAlongXOn()
	{
		vtkChartXY_DragPointAlongXOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_DragPointAlongYOff_14(HandleRef pThis);

	/// <summary>
	/// Set if the point can be dragged along Y
	/// by the ClickAndDrag Action
	/// True by default.
	/// </summary>
	public virtual void DragPointAlongYOff()
	{
		vtkChartXY_DragPointAlongYOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_DragPointAlongYOn_15(HandleRef pThis);

	/// <summary>
	/// Set if the point can be dragged along Y
	/// by the ClickAndDrag Action
	/// True by default.
	/// </summary>
	public virtual void DragPointAlongYOn()
	{
		vtkChartXY_DragPointAlongYOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_DrawAxesAtOriginOff_16(HandleRef pThis);

	/// <summary>
	/// If true then the axes will be drawn at the origin (scientific style).
	/// </summary>
	public virtual void DrawAxesAtOriginOff()
	{
		vtkChartXY_DrawAxesAtOriginOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_DrawAxesAtOriginOn_17(HandleRef pThis);

	/// <summary>
	/// If true then the axes will be drawn at the origin (scientific style).
	/// </summary>
	public virtual void DrawAxesAtOriginOn()
	{
		vtkChartXY_DrawAxesAtOriginOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_ForceAxesToBoundsOff_18(HandleRef pThis);

	/// <summary>
	/// Force the axes to have their Minimum and Maximum properties inside the
	/// plot boundaries. It constrains pan and zoom interaction.
	/// False by default.
	/// </summary>
	public virtual void ForceAxesToBoundsOff()
	{
		vtkChartXY_ForceAxesToBoundsOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_ForceAxesToBoundsOn_19(HandleRef pThis);

	/// <summary>
	/// Force the axes to have their Minimum and Maximum properties inside the
	/// plot boundaries. It constrains pan and zoom interaction.
	/// False by default.
	/// </summary>
	public virtual void ForceAxesToBoundsOn()
	{
		vtkChartXY_ForceAxesToBoundsOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartXY_GetAdjustLowerBoundForLogPlot_20(HandleRef pThis);

	/// <summary>
	/// Adjust the minimum of a logarithmic axis to be greater than 0, regardless
	/// of the minimum data value.
	/// False by default.
	/// </summary>
	public virtual bool GetAdjustLowerBoundForLogPlot()
	{
		return (vtkChartXY_GetAdjustLowerBoundForLogPlot_20(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartXY_GetAutoAxes_21(HandleRef pThis);

	/// <summary>
	/// If true then the axes will be turned on and off depending upon whether
	/// any plots are in that corner. Defaults to true.
	/// </summary>
	public virtual bool GetAutoAxes()
	{
		return (vtkChartXY_GetAutoAxes_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartXY_GetAxis_22(HandleRef pThis, int axisIndex, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the axis specified by axisIndex. This is specified with the vtkAxis
	/// position enum, valid values are vtkAxis::LEFT, vtkAxis::BOTTOM,
	/// vtkAxis::RIGHT and vtkAxis::TOP.
	/// </summary>
	public override vtkAxis GetAxis(int axisIndex)
	{
		vtkAxis vtkAxis2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartXY_GetAxis_22(GetCppThis(), axisIndex, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkChartXY_GetAxisZoom_23(HandleRef pThis, int index);

	/// <summary>
	/// Set the behavior of the mouse wheel for individual axes. ZoomWithMouseWheel
	/// must be enabled to allow zooming; individual axes can be set to ignore zoom.
	/// The default value for all axes is true.
	/// </summary>
	public bool GetAxisZoom(int index)
	{
		return (vtkChartXY_GetAxisZoom_23(GetCppThis(), index) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkChartXY_GetBarWidthFraction_24(HandleRef pThis);

	/// <summary>
	/// Set the width fraction for any bar charts drawn in this chart. It is
	/// assumed that all bar plots will use the same array for the X axis, and that
	/// this array is regularly spaced. The delta between the first two x values is
	/// used to calculated the width of the bars, and subdivided between each bar.
	/// The default value is 0.8, 1.0 would lead to bars that touch.
	/// </summary>
	public virtual float GetBarWidthFraction()
	{
		return vtkChartXY_GetBarWidthFraction_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartXY_GetDragPointAlongX_25(HandleRef pThis);

	/// <summary>
	/// Set if the point can be dragged along X
	/// by the ClickAndDrag Action
	/// True by default.
	/// </summary>
	public virtual bool GetDragPointAlongX()
	{
		return (vtkChartXY_GetDragPointAlongX_25(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartXY_GetDragPointAlongY_26(HandleRef pThis);

	/// <summary>
	/// Set if the point can be dragged along Y
	/// by the ClickAndDrag Action
	/// True by default.
	/// </summary>
	public virtual bool GetDragPointAlongY()
	{
		return (vtkChartXY_GetDragPointAlongY_26(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartXY_GetDrawAxesAtOrigin_27(HandleRef pThis);

	/// <summary>
	/// If true then the axes will be drawn at the origin (scientific style).
	/// </summary>
	public virtual bool GetDrawAxesAtOrigin()
	{
		return (vtkChartXY_GetDrawAxesAtOrigin_27(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartXY_GetForceAxesToBounds_28(HandleRef pThis);

	/// <summary>
	/// Force the axes to have their Minimum and Maximum properties inside the
	/// plot boundaries. It constrains pan and zoom interaction.
	/// False by default.
	/// </summary>
	public virtual bool GetForceAxesToBounds()
	{
		return (vtkChartXY_GetForceAxesToBounds_28(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChartXY_GetHiddenAxisBorder_29(HandleRef pThis);

	/// <summary>
	/// Border size of the axes that are hidden (vtkAxis::GetVisible())
	/// </summary>
	public virtual int GetHiddenAxisBorder()
	{
		return vtkChartXY_GetHiddenAxisBorder_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartXY_GetIgnoreNanInBounds_30(HandleRef pThis);

	/// <summary>
	/// Ignore NaN in RecalculateBounds().
	/// Prevents the final bounds to contain NaN if one of the plots contains NaN
	/// in its bounds.
	/// False by default.
	/// </summary>
	public virtual bool GetIgnoreNanInBounds()
	{
		return (vtkChartXY_GetIgnoreNanInBounds_30(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartXY_GetLegend_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vtkChartLegend object that will be displayed by the chart.
	/// </summary>
	public override vtkChartLegend GetLegend()
	{
		vtkChartLegend vtkChartLegend2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartXY_GetLegend_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkChartLegend2 = (vtkChartLegend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkChartLegend2.Register(null);
			}
		}
		return vtkChartLegend2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartXY_GetNumberOfAxes_32(HandleRef pThis);

	/// <summary>
	/// Get the number of axes in the current chart.
	/// </summary>
	public override long GetNumberOfAxes()
	{
		return vtkChartXY_GetNumberOfAxes_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartXY_GetNumberOfGenerationsFromBase_33(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkChartXY_GetNumberOfGenerationsFromBase_33(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartXY_GetNumberOfGenerationsFromBaseType_34(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkChartXY_GetNumberOfGenerationsFromBaseType_34(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartXY_GetNumberOfPlots_35(HandleRef pThis);

	/// <summary>
	/// Get the number of plots the chart contains.
	/// </summary>
	public override long GetNumberOfPlots()
	{
		return vtkChartXY_GetNumberOfPlots_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartXY_GetPlot_36(HandleRef pThis, long index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the plot at the specified index, returns null if the index is invalid.
	/// </summary>
	public override vtkPlot GetPlot(long index)
	{
		vtkPlot vtkPlot2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartXY_GetPlot_36(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkChartXY_GetPlotCorner_37(HandleRef pThis, HandleRef plot);

	/// <summary>
	/// Figure out which quadrant the plot is in.
	/// </summary>
	public int GetPlotCorner(vtkPlot plot)
	{
		return vtkChartXY_GetPlotCorner_37(GetCppThis(), plot?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartXY_GetPlotIndex_38(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get the index of the specified plot, returns -1 if the plot does not
	/// belong to the chart.
	/// </summary>
	public virtual long GetPlotIndex(vtkPlot arg0)
	{
		return vtkChartXY_GetPlotIndex_38(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartXY_GetTooltip_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vtkTooltipItem object that will be displayed by the chart.
	/// </summary>
	public virtual vtkTooltipItem GetTooltip()
	{
		vtkTooltipItem vtkTooltipItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartXY_GetTooltip_39(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTooltipItem2 = (vtkTooltipItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTooltipItem2.Register(null);
			}
		}
		return vtkTooltipItem2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartXY_GetZoomWithMouseWheel_40(HandleRef pThis);

	/// <summary>
	/// Set the behavior of the mouse wheel.  If true, the mouse wheel zooms in/out
	/// on the chart.  Otherwise, unless MouseWheelEvent is overridden by a subclass
	/// the mouse wheel does nothing.
	/// The default value is true.
	/// </summary>
	public virtual bool GetZoomWithMouseWheel()
	{
		return (vtkChartXY_GetZoomWithMouseWheel_40(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_IgnoreNanInBoundsOff_41(HandleRef pThis);

	/// <summary>
	/// Ignore NaN in RecalculateBounds().
	/// Prevents the final bounds to contain NaN if one of the plots contains NaN
	/// in its bounds.
	/// False by default.
	/// </summary>
	public virtual void IgnoreNanInBoundsOff()
	{
		vtkChartXY_IgnoreNanInBoundsOff_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_IgnoreNanInBoundsOn_42(HandleRef pThis);

	/// <summary>
	/// Ignore NaN in RecalculateBounds().
	/// Prevents the final bounds to contain NaN if one of the plots contains NaN
	/// in its bounds.
	/// False by default.
	/// </summary>
	public virtual void IgnoreNanInBoundsOn()
	{
		vtkChartXY_IgnoreNanInBoundsOn_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChartXY_IsA_43(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkChartXY_IsA_43(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChartXY_IsTypeOf_44(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkChartXY_IsTypeOf_44(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartXY_LowerPlot_45(HandleRef pThis, HandleRef plot);

	/// <summary>
	/// Lowers the \a plot to the bottom of the plot's stack.
	/// \return The new index of the plot
	/// \sa StackPlotUnder(), RaisePlot(), StackPlotAbove()
	/// </summary>
	public long LowerPlot(vtkPlot plot)
	{
		return vtkChartXY_LowerPlot_45(GetCppThis(), plot?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_MakeSelection_46(HandleRef link, HandleRef selectionIds, HandleRef plot);

	/// <summary>
	/// Populate the annotation link with the supplied selectionIds array, and set
	/// the appropriate node properties for a plot based chart selection.
	/// </summary>
	public static void MakeSelection(vtkAnnotationLink link, vtkIdTypeArray selectionIds, vtkPlot plot)
	{
		vtkChartXY_MakeSelection_46(link?.GetCppThis() ?? default(HandleRef), selectionIds?.GetCppThis() ?? default(HandleRef), plot?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_MinusSelection_47(HandleRef selection, HandleRef oldSelection);

	/// <summary>
	/// Subtract the supplied selection from the oldSelection.
	/// </summary>
	public static void MinusSelection(vtkIdTypeArray selection, vtkIdTypeArray oldSelection)
	{
		vtkChartXY_MinusSelection_47(selection?.GetCppThis() ?? default(HandleRef), oldSelection?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartXY_NewInstance_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkChartXY NewInstance()
	{
		vtkChartXY result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartXY_NewInstance_49(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkChartXY)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartXY_Paint_50(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the chart, called whenever the chart needs to be drawn
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkChartXY_Paint_50(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartXY_RaisePlot_51(HandleRef pThis, HandleRef plot);

	/// <summary>
	/// Raises the \a plot to the top of the plot's stack.
	/// \return The new index of the plot
	/// \sa StackPlotAbove(), LowerPlot(), StackPlotUnder()
	/// </summary>
	public long RaisePlot(vtkPlot plot)
	{
		return vtkChartXY_RaisePlot_51(GetCppThis(), plot?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_RecalculateBounds_52(HandleRef pThis);

	/// <summary>
	/// Request that the chart recalculates the range of its axes. Especially
	/// useful in applications after the parameters of plots have been modified.
	/// </summary>
	public override void RecalculateBounds()
	{
		vtkChartXY_RecalculateBounds_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartXY_RemovePlot_53(HandleRef pThis, long index);

	/// <summary>
	/// Remove the plot at the specified index, returns true if successful,
	/// false if the index was invalid.
	/// </summary>
	public override bool RemovePlot(long index)
	{
		return (vtkChartXY_RemovePlot_53(GetCppThis(), index) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_RemovePlotSelections_54(HandleRef pThis);

	/// <summary>
	/// Remove all the selection from Plots
	/// </summary>
	public void RemovePlotSelections()
	{
		vtkChartXY_RemovePlotSelections_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartXY_SafeDownCast_55(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkChartXY SafeDownCast(vtkObjectBase o)
	{
		vtkChartXY vtkChartXY2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartXY_SafeDownCast_55(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkChartXY2 = (vtkChartXY)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkChartXY2.Register(null);
			}
		}
		return vtkChartXY2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_SetAdjustLowerBoundForLogPlot_56(HandleRef pThis, byte _arg);

	/// <summary>
	/// Adjust the minimum of a logarithmic axis to be greater than 0, regardless
	/// of the minimum data value.
	/// False by default.
	/// </summary>
	public virtual void SetAdjustLowerBoundForLogPlot(bool _arg)
	{
		vtkChartXY_SetAdjustLowerBoundForLogPlot_56(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_SetAutoAxes_57(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true then the axes will be turned on and off depending upon whether
	/// any plots are in that corner. Defaults to true.
	/// </summary>
	public virtual void SetAutoAxes(bool _arg)
	{
		vtkChartXY_SetAutoAxes_57(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_SetAxis_58(HandleRef pThis, int axisIndex, HandleRef arg1);

	/// <summary>
	/// Set the axis specified by axisIndex. This is specified with the vtkAxis
	/// position enum, valid values are vtkAxis::LEFT, vtkAxis::BOTTOM,
	/// vtkAxis::RIGHT and vtkAxis::TOP.
	/// </summary>
	public override void SetAxis(int axisIndex, vtkAxis arg1)
	{
		vtkChartXY_SetAxis_58(GetCppThis(), axisIndex, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_SetAxisZoom_59(HandleRef pThis, int index, byte v);

	/// <summary>
	/// Set the behavior of the mouse wheel for individual axes. ZoomWithMouseWheel
	/// must be enabled to allow zooming; individual axes can be set to ignore zoom.
	/// The default value for all axes is true.
	/// </summary>
	public void SetAxisZoom(int index, bool v)
	{
		vtkChartXY_SetAxisZoom_59(GetCppThis(), index, (byte)(v ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_SetBarWidthFraction_60(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the width fraction for any bar charts drawn in this chart. It is
	/// assumed that all bar plots will use the same array for the X axis, and that
	/// this array is regularly spaced. The delta between the first two x values is
	/// used to calculated the width of the bars, and subdivided between each bar.
	/// The default value is 0.8, 1.0 would lead to bars that touch.
	/// </summary>
	public virtual void SetBarWidthFraction(float _arg)
	{
		vtkChartXY_SetBarWidthFraction_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_SetDragPointAlongX_61(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set if the point can be dragged along X
	/// by the ClickAndDrag Action
	/// True by default.
	/// </summary>
	public virtual void SetDragPointAlongX(bool _arg)
	{
		vtkChartXY_SetDragPointAlongX_61(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_SetDragPointAlongY_62(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set if the point can be dragged along Y
	/// by the ClickAndDrag Action
	/// True by default.
	/// </summary>
	public virtual void SetDragPointAlongY(bool _arg)
	{
		vtkChartXY_SetDragPointAlongY_62(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_SetDrawAxesAtOrigin_63(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true then the axes will be drawn at the origin (scientific style).
	/// </summary>
	public virtual void SetDrawAxesAtOrigin(bool _arg)
	{
		vtkChartXY_SetDrawAxesAtOrigin_63(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_SetForceAxesToBounds_64(HandleRef pThis, byte _arg);

	/// <summary>
	/// Force the axes to have their Minimum and Maximum properties inside the
	/// plot boundaries. It constrains pan and zoom interaction.
	/// False by default.
	/// </summary>
	public virtual void SetForceAxesToBounds(bool _arg)
	{
		vtkChartXY_SetForceAxesToBounds_64(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_SetHiddenAxisBorder_65(HandleRef pThis, int _arg);

	/// <summary>
	/// Border size of the axes that are hidden (vtkAxis::GetVisible())
	/// </summary>
	public virtual void SetHiddenAxisBorder(int _arg)
	{
		vtkChartXY_SetHiddenAxisBorder_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_SetIgnoreNanInBounds_66(HandleRef pThis, byte _arg);

	/// <summary>
	/// Ignore NaN in RecalculateBounds().
	/// Prevents the final bounds to contain NaN if one of the plots contains NaN
	/// in its bounds.
	/// False by default.
	/// </summary>
	public virtual void SetIgnoreNanInBounds(bool _arg)
	{
		vtkChartXY_SetIgnoreNanInBounds_66(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_SetPlotCorner_67(HandleRef pThis, HandleRef plot, int corner);

	/// <summary>
	/// Figure out which quadrant the plot is in.
	/// </summary>
	public void SetPlotCorner(vtkPlot plot, int corner)
	{
		vtkChartXY_SetPlotCorner_67(GetCppThis(), plot?.GetCppThis() ?? default(HandleRef), corner);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_SetSelectionMethod_68(HandleRef pThis, int method);

	/// <summary>
	/// Set the selection method, which controls how selections are handled by the
	/// chart. The default is SELECTION_ROWS which selects all points in all plots
	/// in a chart that have values in the rows selected. SELECTION_PLOTS allows
	/// for finer-grained selections specific to each plot, and so to each XY
	/// column pair.
	/// </summary>
	public override void SetSelectionMethod(int method)
	{
		vtkChartXY_SetSelectionMethod_68(GetCppThis(), method);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_SetShowLegend_69(HandleRef pThis, byte visible);

	/// <summary>
	/// Set whether the chart should draw a legend.
	/// </summary>
	public override void SetShowLegend(bool visible)
	{
		vtkChartXY_SetShowLegend_69(GetCppThis(), (byte)(visible ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_SetTooltip_70(HandleRef pThis, HandleRef tooltip);

	/// <summary>
	/// Set the vtkTooltipItem object that will be displayed by the chart.
	/// </summary>
	public virtual void SetTooltip(vtkTooltipItem tooltip)
	{
		vtkChartXY_SetTooltip_70(GetCppThis(), tooltip?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_SetZoomWithMouseWheel_71(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set the behavior of the mouse wheel.  If true, the mouse wheel zooms in/out
	/// on the chart.  Otherwise, unless MouseWheelEvent is overridden by a subclass
	/// the mouse wheel does nothing.
	/// The default value is true.
	/// </summary>
	public virtual void SetZoomWithMouseWheel(bool _arg)
	{
		vtkChartXY_SetZoomWithMouseWheel_71(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartXY_StackPlotAbove_72(HandleRef pThis, HandleRef plot, HandleRef under);

	/// <summary>
	/// Raises the \a plot above the \a under plot. If \a under is null,
	/// the plot is raised to the top of the plot's stack.
	/// \return The new index of the plot
	/// \sa RaisePlot(), LowerPlot(), StackPlotUnder()
	/// </summary>
	public virtual long StackPlotAbove(vtkPlot plot, vtkPlot under)
	{
		return vtkChartXY_StackPlotAbove_72(GetCppThis(), plot?.GetCppThis() ?? default(HandleRef), under?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartXY_StackPlotUnder_73(HandleRef pThis, HandleRef plot, HandleRef above);

	/// <summary>
	/// Lowers the \a plot under the \a above plot. If \a above is null,
	/// the plot is lowered to the bottom of the plot's stack
	/// \return The new index of the plot
	/// \sa StackPlotUnder(), RaisePlot(), StackPlotAbove()
	/// </summary>
	public virtual long StackPlotUnder(vtkPlot plot, vtkPlot above)
	{
		return vtkChartXY_StackPlotUnder_73(GetCppThis(), plot?.GetCppThis() ?? default(HandleRef), above?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_ToggleSelection_74(HandleRef selection, HandleRef oldSelection);

	/// <summary>
	/// Toggle the supplied selection from the oldSelection.
	/// </summary>
	public static void ToggleSelection(vtkIdTypeArray selection, vtkIdTypeArray oldSelection)
	{
		vtkChartXY_ToggleSelection_74(selection?.GetCppThis() ?? default(HandleRef), oldSelection?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_Update_75(HandleRef pThis);

	/// <summary>
	/// Perform any updates to the item that may be necessary before rendering.
	/// The scene should take care of calling this on all items before their
	/// Paint function is invoked.
	/// </summary>
	public override void Update()
	{
		vtkChartXY_Update_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_ZoomWithMouseWheelOff_76(HandleRef pThis);

	/// <summary>
	/// Set the behavior of the mouse wheel.  If true, the mouse wheel zooms in/out
	/// on the chart.  Otherwise, unless MouseWheelEvent is overridden by a subclass
	/// the mouse wheel does nothing.
	/// The default value is true.
	/// </summary>
	public virtual void ZoomWithMouseWheelOff()
	{
		vtkChartXY_ZoomWithMouseWheelOff_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXY_ZoomWithMouseWheelOn_77(HandleRef pThis);

	/// <summary>
	/// Set the behavior of the mouse wheel.  If true, the mouse wheel zooms in/out
	/// on the chart.  Otherwise, unless MouseWheelEvent is overridden by a subclass
	/// the mouse wheel does nothing.
	/// The default value is true.
	/// </summary>
	public virtual void ZoomWithMouseWheelOn()
	{
		vtkChartXY_ZoomWithMouseWheelOn_77(GetCppThis());
	}
}
