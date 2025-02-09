using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkChartBox
/// </summary>
/// <remarks>
///    Factory class for drawing box plot charts
///
///
/// This defines the interface for a box plot chart.
/// </remarks>
public class vtkChartBox : vtkChart
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkChartBox";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkChartBox()
	{
		MRClassNameKey = "class vtkChartBox";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkChartBox"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkChartBox(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartBox_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a box chart
	/// </summary>
	public new static vtkChartBox New()
	{
		vtkChartBox result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartBox_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkChartBox)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a box chart
	/// </summary>
	public vtkChartBox()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkChartBox_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkChartBox_GetColumnId_01(HandleRef pThis, string name);

	/// <summary>
	/// Get the input table column id of a column by its name.
	/// </summary>
	public long GetColumnId(string name)
	{
		return vtkChartBox_GetColumnId_01(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartBox_GetColumnVisibility_02(HandleRef pThis, string name);

	/// <summary>
	/// Get the visibility of the specified column.
	/// </summary>
	public bool GetColumnVisibility(string name)
	{
		return (vtkChartBox_GetColumnVisibility_02(GetCppThis(), name) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartBox_GetColumnVisibility_03(HandleRef pThis, long column);

	/// <summary>
	/// Get the visibility of the specified column.
	/// </summary>
	public bool GetColumnVisibility(long column)
	{
		return (vtkChartBox_GetColumnVisibility_03(GetCppThis(), column) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartBox_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkChartBox_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartBox_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkChartBox_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartBox_GetNumberOfPlots_06(HandleRef pThis);

	/// <summary>
	/// Get the number of plots the chart contains.
	/// </summary>
	public override long GetNumberOfPlots()
	{
		return vtkChartBox_GetNumberOfPlots_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartBox_GetNumberOfVisibleColumns_07(HandleRef pThis);

	/// <summary>
	/// Get the number of visible box plots in the current chart.
	/// </summary>
	public virtual long GetNumberOfVisibleColumns()
	{
		return vtkChartBox_GetNumberOfVisibleColumns_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartBox_GetPlot_08(HandleRef pThis, long index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the plot at the specified index, returns null if the index is invalid.
	/// </summary>
	public override vtkPlot GetPlot(long index)
	{
		vtkPlot vtkPlot2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartBox_GetPlot_08(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkChartBox_GetSelectedColumn_09(HandleRef pThis);

	/// <summary>
	/// Get a list of the columns, and the order in which they are displayed.
	/// </summary>
	public virtual int GetSelectedColumn()
	{
		return vtkChartBox_GetSelectedColumn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartBox_GetTooltip_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vtkTooltipItem object that will be displayed by the chart.
	/// </summary>
	public virtual vtkTooltipItem GetTooltip()
	{
		vtkTooltipItem vtkTooltipItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartBox_GetTooltip_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkChartBox_GetVisibleColumns_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a list of the columns, and the order in which they are displayed.
	/// </summary>
	public virtual vtkStringArray GetVisibleColumns()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartBox_GetVisibleColumns_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern float vtkChartBox_GetXPosition_12(HandleRef pThis, int index);

	/// <summary>
	/// Get the column X position by index in the visible set.
	/// </summary>
	public virtual float GetXPosition(int index)
	{
		return vtkChartBox_GetXPosition_12(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartBox_GetYAxis_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the chart Y axis
	/// </summary>
	public virtual vtkAxis GetYAxis()
	{
		vtkAxis vtkAxis2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartBox_GetYAxis_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkChartBox_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkChartBox_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChartBox_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkChartBox_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartBox_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkChartBox NewInstance()
	{
		vtkChartBox result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartBox_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkChartBox)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartBox_Paint_18(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the chart, called whenever the chart needs to be drawn
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkChartBox_Paint_18(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartBox_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkChartBox SafeDownCast(vtkObjectBase o)
	{
		vtkChartBox vtkChartBox2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartBox_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkChartBox2 = (vtkChartBox)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkChartBox2.Register(null);
			}
		}
		return vtkChartBox2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartBox_SetColumnVisibility_20(HandleRef pThis, string name, byte visible);

	/// <summary>
	/// Set the visibility of the specified column.
	/// </summary>
	public void SetColumnVisibility(string name, bool visible)
	{
		vtkChartBox_SetColumnVisibility_20(GetCppThis(), name, (byte)(visible ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartBox_SetColumnVisibility_21(HandleRef pThis, long column, byte visible);

	/// <summary>
	/// Set the visibility of the specified column.
	/// </summary>
	public void SetColumnVisibility(long column, bool visible)
	{
		vtkChartBox_SetColumnVisibility_21(GetCppThis(), column, (byte)(visible ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartBox_SetColumnVisibilityAll_22(HandleRef pThis, byte visible);

	/// <summary>
	/// Set the visibility of all columns (true will make them all visible, false
	/// will remove all visible columns).
	/// </summary>
	public void SetColumnVisibilityAll(bool visible)
	{
		vtkChartBox_SetColumnVisibilityAll_22(GetCppThis(), (byte)(visible ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartBox_SetGeometry_23(HandleRef pThis, int arg1, int arg2);

	/// <summary>
	/// Calls superclass implementation and sets GeometryValid to False, causing
	/// the chart's geometry to be updated on the next Paint call.
	/// </summary>
	public override void SetGeometry(int arg1, int arg2)
	{
		vtkChartBox_SetGeometry_23(GetCppThis(), arg1, arg2);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartBox_SetLayoutStrategy_24(HandleRef pThis, int strategy);

	/// <summary>
	/// Calls superclass implementation and sets GeometryValid to False, causing
	/// the chart's geometry to be updated on the next Paint call.
	/// </summary>
	public override void SetLayoutStrategy(int strategy)
	{
		vtkChartBox_SetLayoutStrategy_24(GetCppThis(), strategy);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartBox_SetPlot_25(HandleRef pThis, HandleRef plot);

	/// <summary>
	/// Set plot to use for the chart. Since this type of chart can
	/// only contain one plot, this will replace the previous plot.
	/// </summary>
	public virtual void SetPlot(vtkPlotBox plot)
	{
		vtkChartBox_SetPlot_25(GetCppThis(), plot?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartBox_SetSelectedColumn_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Get a list of the columns, and the order in which they are displayed.
	/// </summary>
	public virtual void SetSelectedColumn(int _arg)
	{
		vtkChartBox_SetSelectedColumn_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartBox_SetSize_27(HandleRef pThis, HandleRef rect);

	/// <summary>
	/// Calls superclass implementation and sets GeometryValid to False, causing
	/// the chart's geometry to be updated on the next Paint call.
	/// </summary>
	public override void SetSize(vtkRectf rect)
	{
		vtkChartBox_SetSize_27(GetCppThis(), rect?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartBox_SetTooltip_28(HandleRef pThis, HandleRef tooltip);

	/// <summary>
	/// Set the vtkTooltipItem object that will be displayed by the chart.
	/// </summary>
	public virtual void SetTooltip(vtkTooltipItem tooltip)
	{
		vtkChartBox_SetTooltip_28(GetCppThis(), tooltip?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartBox_Update_29(HandleRef pThis);

	/// <summary>
	/// Perform any updates to the item that may be necessary before rendering.
	/// The scene should take care of calling this on all items before their
	/// Paint function is invoked.
	/// </summary>
	public override void Update()
	{
		vtkChartBox_Update_29(GetCppThis());
	}
}
