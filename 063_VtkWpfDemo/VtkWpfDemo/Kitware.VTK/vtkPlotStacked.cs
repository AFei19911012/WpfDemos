using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlotStacked
/// </summary>
/// <remarks>
///    Class for drawing an stacked polygon plot
/// given an X, Ybase, Yextent  in a vtkTable.
///
///
///
/// </remarks>
public class vtkPlotStacked : vtkPlot
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlotStacked";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlotStacked()
	{
		MRClassNameKey = "class vtkPlotStacked";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotStacked"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlotStacked(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotStacked_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a Stacked Plot Object
	/// </summary>
	public new static vtkPlotStacked New()
	{
		vtkPlotStacked result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotStacked_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlotStacked)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a Stacked Plot Object
	/// </summary>
	public vtkPlotStacked()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPlotStacked_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPlotStacked_GetBounds_01(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the bounds for this mapper as (Xmin,Xmax,Ymin,Ymax).
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkPlotStacked_GetBounds_01(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotStacked_GetColorF_02(HandleRef pThis, IntPtr rgb);

	/// <summary>
	/// Get the plot color as floating rgb values (comprised between 0.0 and 1.0)
	/// </summary>
	public override void GetColorF(IntPtr rgb)
	{
		vtkPlotStacked_GetColorF_02(GetCppThis(), rgb);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotStacked_GetColorSeries_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the color series used if when this is a stacked bar plot.
	/// </summary>
	public vtkColorSeries GetColorSeries()
	{
		vtkColorSeries vtkColorSeries2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotStacked_GetColorSeries_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkColorSeries2 = (vtkColorSeries)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkColorSeries2.Register(null);
			}
		}
		return vtkColorSeries2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotStacked_GetLabels_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the plot labels.
	/// </summary>
	public override vtkStringArray GetLabels()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotStacked_GetLabels_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkPlotStacked_GetNearestPoint_05(HandleRef pThis, HandleRef point, HandleRef tolerance, HandleRef location, IntPtr segmentId);

	/// <summary>
	/// Function to query a plot for the nearest point to the specified coordinate.
	/// Returns the index of the data series with which the point is associated or
	/// -1.
	/// </summary>
	public override long GetNearestPoint(vtkVector2f point, vtkVector2f tolerance, vtkVector2f location, IntPtr segmentId)
	{
		return vtkPlotStacked_GetNearestPoint_05(GetCppThis(), point?.GetCppThis() ?? default(HandleRef), tolerance?.GetCppThis() ?? default(HandleRef), location?.GetCppThis() ?? default(HandleRef), segmentId);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotStacked_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlotStacked_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotStacked_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlotStacked_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotStacked_GetUnscaledInputBounds_08(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the unscaled input bounds for this mapper as (Xmin,Xmax,Ymin,Ymax).
	/// See vtkPlot for more information.
	/// </summary>
	public override void GetUnscaledInputBounds(IntPtr bounds)
	{
		vtkPlotStacked_GetUnscaledInputBounds_08(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotStacked_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlotStacked_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotStacked_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlotStacked_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotStacked_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPlotStacked NewInstance()
	{
		vtkPlotStacked result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotStacked_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlotStacked)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotStacked_Paint_13(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the Stacked plot, called whenever the chart needs to be drawn
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkPlotStacked_Paint_13(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotStacked_PaintLegend_14(HandleRef pThis, HandleRef painter, HandleRef rect, int legendIndex);

	/// <summary>
	/// Paint legend event for the Stacked plot, called whenever the legend needs the
	/// plot items symbol/mark/line drawn. A rect is supplied with the lower left
	/// corner of the rect (elements 0 and 1) and with width x height (elements 2
	/// and 3). The plot can choose how to fill the space supplied.
	/// </summary>
	public override bool PaintLegend(vtkContext2D painter, vtkRectf rect, int legendIndex)
	{
		return (vtkPlotStacked_PaintLegend_14(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef), rect?.GetCppThis() ?? default(HandleRef), legendIndex) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotStacked_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlotStacked SafeDownCast(vtkObjectBase o)
	{
		vtkPlotStacked vtkPlotStacked2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotStacked_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlotStacked2 = (vtkPlotStacked)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlotStacked2.Register(null);
			}
		}
		return vtkPlotStacked2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotStacked_SelectPoints_16(HandleRef pThis, HandleRef min, HandleRef max);

	/// <summary>
	/// Select all points in the specified rectangle.
	/// </summary>
	public override bool SelectPoints(vtkVector2f min, vtkVector2f max)
	{
		return (vtkPlotStacked_SelectPoints_16(GetCppThis(), min?.GetCppThis() ?? default(HandleRef), max?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotStacked_SetColor_17(HandleRef pThis, byte r, byte g, byte b, byte a);

	/// <summary>
	/// Set the plot color with integer values (comprised between 0 and 255)
	/// </summary>
	public override void SetColor(byte r, byte g, byte b, byte a)
	{
		vtkPlotStacked_SetColor_17(GetCppThis(), r, g, b, a);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotStacked_SetColorF_18(HandleRef pThis, double r, double g, double b, double a);

	/// <summary>
	/// Set the plot color with floating values (comprised between 0.0 and 1.0)
	/// </summary>
	public override void SetColorF(double r, double g, double b, double a)
	{
		vtkPlotStacked_SetColorF_18(GetCppThis(), r, g, b, a);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotStacked_SetColorF_19(HandleRef pThis, double r, double g, double b);

	/// <summary>
	/// Set the plot color with floating values (comprised between 0.0 and 1.0)
	/// </summary>
	public override void SetColorF(double r, double g, double b)
	{
		vtkPlotStacked_SetColorF_19(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotStacked_SetColorSeries_20(HandleRef pThis, HandleRef colorSeries);

	/// <summary>
	/// Set the color series to use if this becomes a stacked bar plot.
	/// </summary>
	public void SetColorSeries(vtkColorSeries colorSeries)
	{
		vtkPlotStacked_SetColorSeries_20(GetCppThis(), colorSeries?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotStacked_SetInputArray_21(HandleRef pThis, int index, string name);

	/// <summary>
	/// When used to set additional arrays, stacked bars are created.
	/// </summary>
	public override void SetInputArray(int index, string name)
	{
		vtkPlotStacked_SetInputArray_21(GetCppThis(), index, name);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotStacked_UpdateCache_22(HandleRef pThis);

	/// <summary>
	/// Update the internal cache. Returns true if cache was successfully updated. Default does
	/// nothing.
	/// This method is called by Update() when either the plot's data has changed or
	/// CacheRequiresUpdate() returns true. It is not necessary to call this method explicitly.
	/// </summary>
	public override bool UpdateCache()
	{
		return (vtkPlotStacked_UpdateCache_22(GetCppThis()) != 0) ? true : false;
	}
}
