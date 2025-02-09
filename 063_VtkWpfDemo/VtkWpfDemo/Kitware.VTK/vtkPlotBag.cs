using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlotBag
/// </summary>
/// <remarks>
///    Class for drawing an a bagplot.
///
///
/// This class allows to draw a bagplot given three columns from
/// a vtkTable. The first two columns will represent X,Y as it is for
/// vtkPlotPoints. The third one will have to specify if the density
/// assigned to each point (generally obtained by the
/// vtkHighestDensityRegionsStatistics filter).
/// Points are drawn in a plot points fashion and 2 convex hull polygons
/// are drawn around the median and the 3 quartile of the density field.
///
/// </remarks>
/// <seealso>
///
/// vtkHighestDensityRegionsStatistics
/// </seealso>
public class vtkPlotBag : vtkPlotPoints
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlotBag";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlotBag()
	{
		MRClassNameKey = "class vtkPlotBag";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotBag"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlotBag(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotBag_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a new Bag Plot object.
	/// </summary>
	public new static vtkPlotBag New()
	{
		vtkPlotBag result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotBag_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlotBag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a new Bag Plot object.
	/// </summary>
	public vtkPlotBag()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPlotBag_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkPlotBag_GetBagVisible_01(HandleRef pThis);

	/// <summary>
	/// Set/get the visibility of the bags.
	/// True by default.
	/// </summary>
	public virtual bool GetBagVisible()
	{
		return (vtkPlotBag_GetBagVisible_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotBag_GetLabels_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the plot labels. If this array has a length greater than 1 the index
	/// refers to the stacked objects in the plot. See vtkPlotBar for example.
	/// </summary>
	public override vtkStringArray GetLabels()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotBag_GetLabels_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPlotBag_GetLinePen_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the vtkPen object that controls how this plot draws boundary lines.
	/// </summary>
	public virtual vtkPen GetLinePen()
	{
		vtkPen vtkPen2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotBag_GetLinePen_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPen2 = (vtkPen)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPen2.Register(null);
			}
		}
		return vtkPen2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotBag_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlotBag_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotBag_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlotBag_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotBag_GetPointPen_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the vtkPen object that controls how this plot draws points.
	/// Those are just helpers functions:
	/// this pen is actually the default Plot pen.
	/// </summary>
	public vtkPen GetPointPen()
	{
		vtkPen vtkPen2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotBag_GetPointPen_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPen2 = (vtkPen)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPen2.Register(null);
			}
		}
		return vtkPen2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkPlotBag_GetTooltipLabel_07(HandleRef pThis, HandleRef plotPos, long seriesIndex, long segmentIndex);

	/// <summary>
	/// Generate and return the tooltip label string for this plot
	/// The segmentIndex parameter is ignored, except for vtkPlotBar
	/// </summary>
	public override string GetTooltipLabel(vtkVector2d plotPos, long seriesIndex, long segmentIndex)
	{
		return vtkPlotBag_GetTooltipLabel_07(GetCppThis(), plotPos?.GetCppThis() ?? default(HandleRef), seriesIndex, segmentIndex);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotBag_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlotBag_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotBag_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlotBag_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotBag_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPlotBag NewInstance()
	{
		vtkPlotBag result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotBag_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlotBag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotBag_Paint_12(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the XY plot, called whenever the chart needs to be drawn.
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkPlotBag_Paint_12(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotBag_PaintLegend_13(HandleRef pThis, HandleRef painter, HandleRef rect, int legendIndex);

	/// <summary>
	/// Paint legend event for the XY plot, called whenever the legend needs the
	/// plot items symbol/mark/line drawn. A rect is supplied with the lower left
	/// corner of the rect (elements 0 and 1) and with width x height (elements 2
	/// and 3). The plot can choose how to fill the space supplied.
	/// </summary>
	public override bool PaintLegend(vtkContext2D painter, vtkRectf rect, int legendIndex)
	{
		return (vtkPlotBag_PaintLegend_13(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef), rect?.GetCppThis() ?? default(HandleRef), legendIndex) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotBag_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlotBag SafeDownCast(vtkObjectBase o)
	{
		vtkPlotBag vtkPlotBag2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotBag_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlotBag2 = (vtkPlotBag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlotBag2.Register(null);
			}
		}
		return vtkPlotBag2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBag_SetBagVisible_15(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/get the visibility of the bags.
	/// True by default.
	/// </summary>
	public virtual void SetBagVisible(bool _arg)
	{
		vtkPlotBag_SetBagVisible_15(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBag_SetInputData_16(HandleRef pThis, HandleRef table);

	/// <summary>
	/// Set the input, we are expecting a vtkTable with three columns. The first
	/// column and the second represent the x,y position . The five others
	/// columns represent the quartiles used to display the box.
	/// Inherited method will call the last SetInputData method with default
	/// parameters.
	/// </summary>
	public override void SetInputData(vtkTable table)
	{
		vtkPlotBag_SetInputData_16(GetCppThis(), table?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBag_SetInputData_17(HandleRef pThis, HandleRef table, string yColumn, string densityColumn);

	/// <summary>
	/// Set the input, we are expecting a vtkTable with three columns. The first
	/// column and the second represent the x,y position . The five others
	/// columns represent the quartiles used to display the box.
	/// Inherited method will call the last SetInputData method with default
	/// parameters.
	/// </summary>
	public override void SetInputData(vtkTable table, string yColumn, string densityColumn)
	{
		vtkPlotBag_SetInputData_17(GetCppThis(), table?.GetCppThis() ?? default(HandleRef), yColumn, densityColumn);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBag_SetInputData_18(HandleRef pThis, HandleRef table, string xColumn, string yColumn, string densityColumn);

	/// <summary>
	/// Set the input, we are expecting a vtkTable with three columns. The first
	/// column and the second represent the x,y position . The five others
	/// columns represent the quartiles used to display the box.
	/// Inherited method will call the last SetInputData method with default
	/// parameters.
	/// </summary>
	public virtual void SetInputData(vtkTable table, string xColumn, string yColumn, string densityColumn)
	{
		vtkPlotBag_SetInputData_18(GetCppThis(), table?.GetCppThis() ?? default(HandleRef), xColumn, yColumn, densityColumn);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBag_SetInputData_19(HandleRef pThis, HandleRef table, long xColumn, long yColumn, long densityColumn);

	/// <summary>
	/// Set the input, we are expecting a vtkTable with three columns. The first
	/// column and the second represent the x,y position . The five others
	/// columns represent the quartiles used to display the box.
	/// Inherited method will call the last SetInputData method with default
	/// parameters.
	/// </summary>
	public virtual void SetInputData(vtkTable table, long xColumn, long yColumn, long densityColumn)
	{
		vtkPlotBag_SetInputData_19(GetCppThis(), table?.GetCppThis() ?? default(HandleRef), xColumn, yColumn, densityColumn);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBag_SetLinePen_20(HandleRef pThis, HandleRef pen);

	/// <summary>
	/// Set/get the vtkPen object that controls how this plot draws boundary lines.
	/// </summary>
	public void SetLinePen(vtkPen pen)
	{
		vtkPlotBag_SetLinePen_20(GetCppThis(), pen?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBag_SetPointPen_21(HandleRef pThis, HandleRef pen);

	/// <summary>
	/// Set/get the vtkPen object that controls how this plot draws points.
	/// Those are just helpers functions:
	/// this pen is actually the default Plot pen.
	/// </summary>
	public void SetPointPen(vtkPen pen)
	{
		vtkPlotBag_SetPointPen_21(GetCppThis(), pen?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotBag_UpdateCache_22(HandleRef pThis);

	/// <summary>
	/// Update the internal cache. Returns true if cache was successfully updated. Default does
	/// nothing.
	/// This method is called by Update() when either the plot's data has changed or
	/// CacheRequiresUpdate() returns true. It is not necessary to call this method explicitly.
	/// </summary>
	public override bool UpdateCache()
	{
		return (vtkPlotBag_UpdateCache_22(GetCppThis()) != 0) ? true : false;
	}
}
