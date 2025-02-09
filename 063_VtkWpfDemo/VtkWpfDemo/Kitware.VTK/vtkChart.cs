using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkChart
/// </summary>
/// <remarks>
///    Factory class for drawing 2D charts
///
///
/// This defines the interface for a chart.
/// </remarks>
public abstract class vtkChart : vtkContextItem
{
	/// <summary>
	/// Enum of the available chart types
	/// </summary>
	public enum AREA_WrapperEnum
	{
		/// <summary>enum member</summary>
		AREA = 6,
		/// <summary>enum member</summary>
		BAG = 4,
		/// <summary>enum member</summary>
		BAR = 2,
		/// <summary>enum member</summary>
		FUNCTIONALBAG = 5,
		/// <summary>enum member</summary>
		LINE = 0,
		/// <summary>enum member</summary>
		POINTS = 1,
		/// <summary>enum member</summary>
		STACKED = 3
	}

	/// <summary>
	/// Enum of valid chart action types.
	///
	/// PAN - moves the axis range
	/// ZOOM - zooms to a selected rectangle
	/// ZOOM_AXIS - zooms the x and y axis range
	/// SELECT_RECTANGLE - selects points within a rectangle
	/// SELECT_POLYGON - selects points within a polygon
	/// SELECT - alias for SELECT_RECTANGLE
	/// CLICKANDDRAG - move one point selected by a click
	/// NOTIFY - Post vtkCommand::InteractionEvent on selection of a point
	/// </summary>
	public enum CLICK_AND_DRAG_WrapperEnum
	{
		/// <summary>enum member</summary>
		CLICK_AND_DRAG = 5,
		/// <summary>enum member</summary>
		NOTIFY = 6,
		/// <summary>enum member</summary>
		PAN = 0,
		/// <summary>enum member</summary>
		SELECT = 3,
		/// <summary>enum member</summary>
		SELECT_POLYGON = 4,
		/// <summary>enum member</summary>
		SELECT_RECTANGLE = 3,
		/// <summary>enum member</summary>
		ZOOM = 1,
		/// <summary>enum member</summary>
		ZOOM_AXIS = 2
	}

	/// <summary>
	/// Enumeration of the possible selection methods in a chart. SELECTION_ROWS
	/// is the default and simply selects the row in a table in all plots showing
	/// that table. SELECTION_PLOTS will make a selection in each plot, and that
	/// selection remains specific to the plot object. SELECTION_COLUMNS selects
	/// the plots that use as input the selected columns of a table.
	/// </summary>
	public enum SELECTION_COLUMNS_WrapperEnum
	{
		/// <summary>enum member</summary>
		SELECTION_COLUMNS = 2,
		/// <summary>enum member</summary>
		SELECTION_PLOTS = 1,
		/// <summary>enum member</summary>
		SELECTION_ROWS = 0
	}

	/// <summary>
	/// Enum of the available layout strategies for the charts.
	/// </summary>
	public enum AXES_TO_RECT_WrapperEnum
	{
		/// <summary>enum member</summary>
		AXES_TO_RECT = 2,
		/// <summary>enum member</summary>
		FILL_RECT = 1,
		/// <summary>enum member</summary>
		FILL_SCENE = 0
	}

	/// <summary>
	/// Enum of event type that are triggered by the charts
	/// </summary>
	public enum EventIds
	{
		/// <summary>enum member</summary>
		UpdateRange = 1002
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkChart";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkChart()
	{
		MRClassNameKey = "class vtkChart";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkChart"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkChart(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChart_AddPlot_01(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Add a plot to the chart, defaults to using the name of the y column
	/// </summary>
	public virtual vtkPlot AddPlot(int type)
	{
		vtkPlot vtkPlot2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChart_AddPlot_01(GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkChart_AddPlot_02(HandleRef pThis, HandleRef plot);

	/// <summary>
	/// Add a plot to the chart. Return the index of the plot, -1 if it failed.
	/// </summary>
	public virtual long AddPlot(vtkPlot plot)
	{
		return vtkChart_AddPlot_02(GetCppThis(), plot?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_ClearPlots_03(HandleRef pThis);

	/// <summary>
	/// Remove all plots from the chart.
	/// </summary>
	public virtual void ClearPlots()
	{
		vtkChart_ClearPlots_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChart_GetActionToButton_04(HandleRef pThis, int action);

	/// <summary>
	/// Get the mouse button associated with the supplied action. The mouse button
	/// enum is from vtkContextMouseEvent, and the action enum is from vtkChart.
	/// </summary>
	public virtual int GetActionToButton(int action)
	{
		return vtkChart_GetActionToButton_04(GetCppThis(), action);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChart_GetAnnotationLink_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vtkAnnotationLink for the chart.
	/// </summary>
	public virtual vtkAnnotationLink GetAnnotationLink()
	{
		vtkAnnotationLink vtkAnnotationLink2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChart_GetAnnotationLink_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAnnotationLink2 = (vtkAnnotationLink)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAnnotationLink2.Register(null);
			}
		}
		return vtkAnnotationLink2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChart_GetAutoSize_06(HandleRef pThis);

	/// <summary>
	/// Set/get whether the chart should automatically resize to fill the current
	/// render window. Default is true.
	/// </summary>
	public virtual bool GetAutoSize()
	{
		return (vtkChart_GetAutoSize_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChart_GetAxis_07(HandleRef pThis, int axisIndex, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the axis specified by axisIndex. 0 is x, 1 is y. This should probably
	/// be improved either using a string or enum to select the axis.
	/// </summary>
	public virtual vtkAxis GetAxis(int axisIndex)
	{
		vtkAxis vtkAxis2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChart_GetAxis_07(GetCppThis(), axisIndex, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkChart_GetBackgroundBrush_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the brush to use for the background color.
	/// </summary>
	public vtkBrush GetBackgroundBrush()
	{
		vtkBrush vtkBrush2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChart_GetBackgroundBrush_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBrush2 = (vtkBrush)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBrush2.Register(null);
			}
		}
		return vtkBrush2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChart_GetClickActionToButton_09(HandleRef pThis, int action);

	/// <summary>
	/// Get the mouse button associated with the supplied click action. The mouse
	/// button enum is from vtkContextMouseEvent, and the action enum is from
	/// vtkChart.
	/// </summary>
	public virtual int GetClickActionToButton(int action)
	{
		return vtkChart_GetClickActionToButton_09(GetCppThis(), action);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChart_GetGeometry_10(HandleRef pThis);

	/// <summary>
	/// Set/get the width and the height of the chart.
	/// </summary>
	public virtual int[] GetGeometry()
	{
		IntPtr intPtr = vtkChart_GetGeometry_10(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_GetGeometry_11(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Set/get the width and the height of the chart.
	/// </summary>
	public virtual void GetGeometry(ref int _arg1, ref int _arg2)
	{
		vtkChart_GetGeometry_11(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_GetGeometry_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the width and the height of the chart.
	/// </summary>
	public virtual void GetGeometry(IntPtr _arg)
	{
		vtkChart_GetGeometry_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChart_GetLayoutStrategy_13(HandleRef pThis);

	/// <summary>
	/// Set/get the layout strategy that should be used by the chart. As we don't
	/// support enums this can take any value in the integer range, but the only
	/// valid enums are FILL_SCENE, FILL_RECT and AXES_TO_RECT.
	/// </summary>
	public virtual int GetLayoutStrategy()
	{
		return vtkChart_GetLayoutStrategy_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChart_GetLegend_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the legend for the chart, if available. Can return null if there is no
	/// legend.
	/// </summary>
	public virtual vtkChartLegend GetLegend()
	{
		vtkChartLegend vtkChartLegend2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChart_GetLegend_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkChart_GetNumberOfAxes_15(HandleRef pThis);

	/// <summary>
	/// Get the number of axes in the current chart.
	/// </summary>
	public virtual long GetNumberOfAxes()
	{
		return vtkChart_GetNumberOfAxes_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChart_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkChart_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChart_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkChart_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChart_GetNumberOfPlots_18(HandleRef pThis);

	/// <summary>
	/// Get the number of plots the chart contains.
	/// </summary>
	public virtual long GetNumberOfPlots()
	{
		return vtkChart_GetNumberOfPlots_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChart_GetPlot_19(HandleRef pThis, long index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the plot at the specified index, returns null if the index is invalid.
	/// </summary>
	public virtual vtkPlot GetPlot(long index)
	{
		vtkPlot vtkPlot2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChart_GetPlot_19(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkChart_GetPoint1_20(HandleRef pThis);

	/// <summary>
	/// Set/get the first point in the chart (the bottom left).
	/// </summary>
	public virtual int[] GetPoint1()
	{
		IntPtr intPtr = vtkChart_GetPoint1_20(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_GetPoint1_21(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Set/get the first point in the chart (the bottom left).
	/// </summary>
	public virtual void GetPoint1(ref int _arg1, ref int _arg2)
	{
		vtkChart_GetPoint1_21(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_GetPoint1_22(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the first point in the chart (the bottom left).
	/// </summary>
	public virtual void GetPoint1(IntPtr _arg)
	{
		vtkChart_GetPoint1_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChart_GetPoint2_23(HandleRef pThis);

	/// <summary>
	/// Set/get the second point in the chart (the top right).
	/// </summary>
	public virtual int[] GetPoint2()
	{
		IntPtr intPtr = vtkChart_GetPoint2_23(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_GetPoint2_24(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Set/get the second point in the chart (the top right).
	/// </summary>
	public virtual void GetPoint2(ref int _arg1, ref int _arg2)
	{
		vtkChart_GetPoint2_24(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_GetPoint2_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the second point in the chart (the top right).
	/// </summary>
	public virtual void GetPoint2(IntPtr _arg)
	{
		vtkChart_GetPoint2_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChart_GetRenderEmpty_26(HandleRef pThis);

	/// <summary>
	/// Set/get whether the chart should still render its axes and decorations
	/// even if the chart has no visible plots. Default is false (do not render
	/// an empty plot).
	///
	/// Note that if you wish to render axes for an empty plot you should also
	/// set AutoSize to false, as that will hide all axes for an empty plot.
	/// </summary>
	public virtual bool GetRenderEmpty()
	{
		return (vtkChart_GetRenderEmpty_26(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChart_GetSelectionMethod_27(HandleRef pThis);

	/// <summary>
	/// Set the selection method, which controls how selections are handled by the
	/// chart. The default is SELECTION_ROWS which selects all points in all plots
	/// in a chart that have values in the rows selected. SELECTION_PLOTS allows
	/// for finer-grained selections specific to each plot, and so to each XY
	/// column pair. SELECTION_COLUMNS selects all points of plots that
	/// correspond to selected columns.
	/// </summary>
	public virtual int GetSelectionMethod()
	{
		return vtkChart_GetSelectionMethod_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChart_GetSelectionMode_28(HandleRef pThis);

	/// <summary>
	/// Set/get the Selection Mode that will be used by the chart while doing
	/// selection. The only valid enums are vtkContextScene::SelectionModifier.
	/// </summary>
	public virtual int GetSelectionMode()
	{
		return vtkChart_GetSelectionMode_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChart_GetSelectionModeMaxValue_29(HandleRef pThis);

	/// <summary>
	/// Set/get the Selection Mode that will be used by the chart while doing
	/// selection. The only valid enums are vtkContextScene::SelectionModifier.
	/// </summary>
	public virtual int GetSelectionModeMaxValue()
	{
		return vtkChart_GetSelectionModeMaxValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChart_GetSelectionModeMinValue_30(HandleRef pThis);

	/// <summary>
	/// Set/get the Selection Mode that will be used by the chart while doing
	/// selection. The only valid enums are vtkContextScene::SelectionModifier.
	/// </summary>
	public virtual int GetSelectionModeMinValue()
	{
		return vtkChart_GetSelectionModeMinValue_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChart_GetShowLegend_31(HandleRef pThis);

	/// <summary>
	/// Set/get whether the chart should draw a legend.
	/// </summary>
	public virtual bool GetShowLegend()
	{
		return (vtkChart_GetShowLegend_31(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChart_GetSize_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the current size of the chart.
	/// </summary>
	public vtkRectf GetSize()
	{
		vtkRectf result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChart_GetSize_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectf)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkChart_GetTitle_33(HandleRef pThis);

	/// <summary>
	/// Get/set the title text of the chart.
	/// </summary>
	public virtual string GetTitle()
	{
		return vtkChart_GetTitle_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChart_GetTitleProperties_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vtkTextProperty that governs how the chart title is displayed.
	/// </summary>
	public virtual vtkTextProperty GetTitleProperties()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChart_GetTitleProperties_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextProperty2 = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextProperty2.Register(null);
			}
		}
		return vtkTextProperty2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChart_IsA_35(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkChart_IsA_35(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChart_IsTypeOf_36(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkChart_IsTypeOf_36(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChart_NewInstance_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkChart NewInstance()
	{
		vtkChart result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChart_NewInstance_37(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkChart)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChart_Paint_38(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the chart, called whenever the chart needs to be drawn
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkChart_Paint_38(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_RecalculateBounds_39(HandleRef pThis);

	/// <summary>
	/// Request that the chart recalculates the range of its axes. Especially
	/// useful in applications after the parameters of plots have been modified.
	/// </summary>
	public virtual void RecalculateBounds()
	{
		vtkChart_RecalculateBounds_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChart_RemovePlot_40(HandleRef pThis, long index);

	/// <summary>
	/// Remove the plot at the specified index, returns true if successful,
	/// false if the index was invalid.
	/// </summary>
	public virtual bool RemovePlot(long index)
	{
		return (vtkChart_RemovePlot_40(GetCppThis(), index) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChart_RemovePlotInstance_41(HandleRef pThis, HandleRef plot);

	/// <summary>
	/// Remove the given plot.  Returns true if successful, false if the plot
	/// was not contained in this chart.  Note, the base implementation of
	/// this method performs a linear search to locate the plot.
	/// </summary>
	public virtual bool RemovePlotInstance(vtkPlot plot)
	{
		return (vtkChart_RemovePlotInstance_41(GetCppThis(), plot?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChart_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkChart SafeDownCast(vtkObjectBase o)
	{
		vtkChart vtkChart2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChart_SafeDownCast_42(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkChart2 = (vtkChart)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkChart2.Register(null);
			}
		}
		return vtkChart2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetActionToButton_43(HandleRef pThis, int action, int button);

	/// <summary>
	/// Assign action types to mouse buttons. Available action types are PAN, ZOOM
	/// and SELECT in the chart enum, the default assigns the LEFT_BUTTON to
	/// PAN, MIDDLE_BUTTON to ZOOM and RIGHT_BUTTON to SELECT. Valid mouse enums
	/// are in the vtkContextMouseEvent class.
	///
	/// Note that only one mouse button can be assigned to each action, an action
	/// will have -1 (invalid button) assigned if it had the same button as the one
	/// assigned to a different action.
	/// </summary>
	public virtual void SetActionToButton(int action, int button)
	{
		vtkChart_SetActionToButton_43(GetCppThis(), action, button);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetAnnotationLink_44(HandleRef pThis, HandleRef link);

	/// <summary>
	/// Set the vtkAnnotationLink for the chart.
	/// </summary>
	public virtual void SetAnnotationLink(vtkAnnotationLink link)
	{
		vtkChart_SetAnnotationLink_44(GetCppThis(), link?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetAutoSize_45(HandleRef pThis, byte isAutoSized);

	/// <summary>
	/// Set/get whether the chart should automatically resize to fill the current
	/// render window. Default is true.
	/// </summary>
	public virtual void SetAutoSize(bool isAutoSized)
	{
		vtkChart_SetAutoSize_45(GetCppThis(), (byte)(isAutoSized ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetAxis_46(HandleRef pThis, int axisIndex, HandleRef arg1);

	/// <summary>
	/// Set the axis specified by axisIndex. 0 is x, 1 is y. This should probably
	/// be improved either using a string or enum to select the axis.
	/// </summary>
	public virtual void SetAxis(int axisIndex, vtkAxis arg1)
	{
		vtkChart_SetAxis_46(GetCppThis(), axisIndex, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetBackgroundBrush_47(HandleRef pThis, HandleRef brush);

	/// <summary>
	/// Set/Get the brush to use for the background color.
	/// </summary>
	public void SetBackgroundBrush(vtkBrush brush)
	{
		vtkChart_SetBackgroundBrush_47(GetCppThis(), brush?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetBorders_48(HandleRef pThis, int left, int bottom, int right, int top);

	/// <summary>
	/// Set/get the borders of the chart (space in pixels around the chart).
	/// </summary>
	public void SetBorders(int left, int bottom, int right, int top)
	{
		vtkChart_SetBorders_48(GetCppThis(), left, bottom, right, top);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetBottomBorder_49(HandleRef pThis, int border);

	/// <summary>
	/// Set/get the borders of the chart (space in pixels around the chart).
	/// </summary>
	public void SetBottomBorder(int border)
	{
		vtkChart_SetBottomBorder_49(GetCppThis(), border);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetClickActionToButton_50(HandleRef pThis, int action, int button);

	/// <summary>
	/// Assign action types to single mouse clicks. Available action types are
	/// SELECT and NOTIFY in the chart enum. The default assigns the LEFT_BUTTON
	/// to NOTIFY, and the RIGHT_BUTTON to SELECT.
	/// </summary>
	public virtual void SetClickActionToButton(int action, int button)
	{
		vtkChart_SetClickActionToButton_50(GetCppThis(), action, button);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetGeometry_51(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set/get the width and the height of the chart.
	/// </summary>
	public virtual void SetGeometry(int _arg1, int _arg2)
	{
		vtkChart_SetGeometry_51(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetGeometry_52(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the width and the height of the chart.
	/// </summary>
	public void SetGeometry(IntPtr _arg)
	{
		vtkChart_SetGeometry_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetLayoutStrategy_53(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the layout strategy that should be used by the chart. As we don't
	/// support enums this can take any value in the integer range, but the only
	/// valid enums are FILL_SCENE, FILL_RECT and AXES_TO_RECT.
	/// </summary>
	public virtual void SetLayoutStrategy(int _arg)
	{
		vtkChart_SetLayoutStrategy_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetLeftBorder_54(HandleRef pThis, int border);

	/// <summary>
	/// Set/get the borders of the chart (space in pixels around the chart).
	/// </summary>
	public void SetLeftBorder(int border)
	{
		vtkChart_SetLeftBorder_54(GetCppThis(), border);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetPoint1_55(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set/get the first point in the chart (the bottom left).
	/// </summary>
	public virtual void SetPoint1(int _arg1, int _arg2)
	{
		vtkChart_SetPoint1_55(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetPoint1_56(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the first point in the chart (the bottom left).
	/// </summary>
	public void SetPoint1(IntPtr _arg)
	{
		vtkChart_SetPoint1_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetPoint2_57(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set/get the second point in the chart (the top right).
	/// </summary>
	public virtual void SetPoint2(int _arg1, int _arg2)
	{
		vtkChart_SetPoint2_57(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetPoint2_58(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the second point in the chart (the top right).
	/// </summary>
	public void SetPoint2(IntPtr _arg)
	{
		vtkChart_SetPoint2_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetRenderEmpty_59(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/get whether the chart should still render its axes and decorations
	/// even if the chart has no visible plots. Default is false (do not render
	/// an empty plot).
	///
	/// Note that if you wish to render axes for an empty plot you should also
	/// set AutoSize to false, as that will hide all axes for an empty plot.
	/// </summary>
	public virtual void SetRenderEmpty(bool _arg)
	{
		vtkChart_SetRenderEmpty_59(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetRightBorder_60(HandleRef pThis, int border);

	/// <summary>
	/// Set/get the borders of the chart (space in pixels around the chart).
	/// </summary>
	public void SetRightBorder(int border)
	{
		vtkChart_SetRightBorder_60(GetCppThis(), border);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetSelectionMethod_61(HandleRef pThis, int method);

	/// <summary>
	/// Set the selection method, which controls how selections are handled by the
	/// chart. The default is SELECTION_ROWS which selects all points in all plots
	/// in a chart that have values in the rows selected. SELECTION_PLOTS allows
	/// for finer-grained selections specific to each plot, and so to each XY
	/// column pair. SELECTION_COLUMNS selects all points of plots that
	/// correspond to selected columns.
	/// </summary>
	public virtual void SetSelectionMethod(int method)
	{
		vtkChart_SetSelectionMethod_61(GetCppThis(), method);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetSelectionMode_62(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the Selection Mode that will be used by the chart while doing
	/// selection. The only valid enums are vtkContextScene::SelectionModifier.
	/// </summary>
	public virtual void SetSelectionMode(int _arg)
	{
		vtkChart_SetSelectionMode_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetShowLegend_63(HandleRef pThis, byte visible);

	/// <summary>
	/// Set/get whether the chart should draw a legend.
	/// </summary>
	public virtual void SetShowLegend(bool visible)
	{
		vtkChart_SetShowLegend_63(GetCppThis(), (byte)(visible ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetSize_64(HandleRef pThis, HandleRef rect);

	/// <summary>
	/// Set the size of the chart. The rect argument specifies the bottom corner,
	/// width and height of the chart. The borders will be laid out within the
	/// specified rectangle.
	/// </summary>
	public virtual void SetSize(vtkRectf rect)
	{
		vtkChart_SetSize_64(GetCppThis(), rect?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetTitle_65(HandleRef pThis, string title);

	/// <summary>
	/// Get/set the title text of the chart.
	/// </summary>
	public virtual void SetTitle(string title)
	{
		vtkChart_SetTitle_65(GetCppThis(), title);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChart_SetTopBorder_66(HandleRef pThis, int border);

	/// <summary>
	/// Set/get the borders of the chart (space in pixels around the chart).
	/// </summary>
	public void SetTopBorder(int border)
	{
		vtkChart_SetTopBorder_66(GetCppThis(), border);
	}
}
