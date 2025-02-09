using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlotFunctionalBag
/// </summary>
/// <remarks>
///    Class for drawing an XY line plot or bag
/// given two columns from a vtkTable.
///
///
/// Depending on the number of components, this class will draw either
/// a line plot (for 1 component column) or, for two components columns,
/// a filled polygonal band (the bag) going from the first to the second
/// component on the Y-axis along the X-axis. The filter
/// vtkExtractFunctionalBagPlot is intended to create such "bag" columns.
///
/// </remarks>
/// <seealso>
///
/// vtkExtractFunctionalBagPlot
/// </seealso>
public class vtkPlotFunctionalBag : vtkPlot
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlotFunctionalBag";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlotFunctionalBag()
	{
		MRClassNameKey = "class vtkPlotFunctionalBag";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotFunctionalBag"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlotFunctionalBag(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotFunctionalBag_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a functional bag plot object.
	/// </summary>
	public new static vtkPlotFunctionalBag New()
	{
		vtkPlotFunctionalBag result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotFunctionalBag_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlotFunctionalBag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a functional bag plot object.
	/// </summary>
	public vtkPlotFunctionalBag()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPlotFunctionalBag_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPlotFunctionalBag_CreateDefaultLookupTable_01(HandleRef pThis);

	/// <summary>
	/// Create default lookup table. Generally used to create one when none
	/// is available with the scalar data.
	/// </summary>
	public virtual void CreateDefaultLookupTable()
	{
		vtkPlotFunctionalBag_CreateDefaultLookupTable_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotFunctionalBag_GetBounds_02(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the bounds for this plot as (Xmin, Xmax, Ymin, Ymax).
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkPlotFunctionalBag_GetBounds_02(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotFunctionalBag_GetLookupTable_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a lookup table for the mapper to use.
	/// </summary>
	public vtkScalarsToColors GetLookupTable()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotFunctionalBag_GetLookupTable_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkPlotFunctionalBag_GetNearestPoint_04(HandleRef pThis, HandleRef point, HandleRef tolerance, HandleRef location, IntPtr segmentId);

	/// <summary>
	/// Function to query a plot for the nearest point to the specified coordinate.
	/// Returns the index of the data series with which the point is associated or
	/// -1.
	/// </summary>
	public override long GetNearestPoint(vtkVector2f point, vtkVector2f tolerance, vtkVector2f location, IntPtr segmentId)
	{
		return vtkPlotFunctionalBag_GetNearestPoint_04(GetCppThis(), point?.GetCppThis() ?? default(HandleRef), tolerance?.GetCppThis() ?? default(HandleRef), location?.GetCppThis() ?? default(HandleRef), segmentId);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotFunctionalBag_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlotFunctionalBag_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotFunctionalBag_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlotFunctionalBag_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotFunctionalBag_GetUnscaledInputBounds_07(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the non-log-scaled bounds on chart inputs for this plot as
	/// (Xmin, Xmax, Ymin, Ymax).
	/// </summary>
	public override void GetUnscaledInputBounds(IntPtr bounds)
	{
		vtkPlotFunctionalBag_GetUnscaledInputBounds_07(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotFunctionalBag_GetVisible_08(HandleRef pThis);

	/// <summary>
	/// Reimplemented to enforce visibility when selected.
	/// </summary>
	public override bool GetVisible()
	{
		return (vtkPlotFunctionalBag_GetVisible_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotFunctionalBag_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlotFunctionalBag_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotFunctionalBag_IsBag_10(HandleRef pThis);

	/// <summary>
	/// Returns true if the plot is a functional bag, false if it is a simple
	/// line.
	/// </summary>
	public virtual bool IsBag()
	{
		return (vtkPlotFunctionalBag_IsBag_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotFunctionalBag_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlotFunctionalBag_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotFunctionalBag_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPlotFunctionalBag NewInstance()
	{
		vtkPlotFunctionalBag result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotFunctionalBag_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlotFunctionalBag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotFunctionalBag_Paint_14(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the plot, called whenever the chart needs to be drawn.
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkPlotFunctionalBag_Paint_14(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotFunctionalBag_PaintLegend_15(HandleRef pThis, HandleRef painter, HandleRef rect, int legendIndex);

	/// <summary>
	/// Paint legend event for the plot, called whenever the legend needs the
	/// plot items symbol/mark/line drawn. A rect is supplied with the lower left
	/// corner of the rect (elements 0 and 1) and with width x height (elements 2
	/// and 3). The plot can choose how to fill the space supplied.
	/// </summary>
	public override bool PaintLegend(vtkContext2D painter, vtkRectf rect, int legendIndex)
	{
		return (vtkPlotFunctionalBag_PaintLegend_15(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef), rect?.GetCppThis() ?? default(HandleRef), legendIndex) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotFunctionalBag_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlotFunctionalBag SafeDownCast(vtkObjectBase o)
	{
		vtkPlotFunctionalBag vtkPlotFunctionalBag2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotFunctionalBag_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlotFunctionalBag2 = (vtkPlotFunctionalBag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlotFunctionalBag2.Register(null);
			}
		}
		return vtkPlotFunctionalBag2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotFunctionalBag_SelectPoints_17(HandleRef pThis, HandleRef min, HandleRef max);

	/// <summary>
	/// Select all points in the specified rectangle.
	/// </summary>
	public override bool SelectPoints(vtkVector2f min, vtkVector2f max)
	{
		return (vtkPlotFunctionalBag_SelectPoints_17(GetCppThis(), min?.GetCppThis() ?? default(HandleRef), max?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotFunctionalBag_SetLookupTable_18(HandleRef pThis, HandleRef lut);

	/// <summary>
	/// Specify a lookup table for the mapper to use.
	/// </summary>
	public void SetLookupTable(vtkScalarsToColors lut)
	{
		vtkPlotFunctionalBag_SetLookupTable_18(GetCppThis(), lut?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotFunctionalBag_UpdateCache_19(HandleRef pThis);

	/// <summary>
	/// Update the internal cache. Returns true if cache was successfully updated. Default does
	/// nothing.
	/// This method is called by Update() when either the plot's data has changed or
	/// CacheRequiresUpdate() returns true. It is not necessary to call this method explicitly.
	/// </summary>
	public override bool UpdateCache()
	{
		return (vtkPlotFunctionalBag_UpdateCache_19(GetCppThis()) != 0) ? true : false;
	}
}
