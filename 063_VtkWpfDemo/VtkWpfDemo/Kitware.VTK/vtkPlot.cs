using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlot
/// </summary>
/// <remarks>
///    Abstract class for 2D plots.
///
///
/// The base class for all plot types used in vtkChart derived charts.
///
/// </remarks>
/// <seealso>
///
/// vtkPlotPoints vtkPlotLine vtkPlotBar vtkChart vtkChartXY
/// </seealso>
public class vtkPlot : vtkContextItem
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlot";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlot()
	{
		MRClassNameKey = "class vtkPlot";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlot"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlot(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern byte vtkPlot_ClampPos_01(IntPtr pos, IntPtr bounds);

	/// <summary>
	/// Clamp the given 2D pos into the provided bounds
	/// Return true if the pos has been clamped, false otherwise.
	/// </summary>
	public static bool ClampPos(IntPtr pos, IntPtr bounds)
	{
		return (vtkPlot_ClampPos_01(pos, bounds) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlot_ClampPos_02(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Clamp the given 2D pos into the provided bounds
	/// Return true if the pos has been clamped, false otherwise.
	/// </summary>
	public virtual bool ClampPos(IntPtr pos)
	{
		return (vtkPlot_ClampPos_02(GetCppThis(), pos) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_GetBounds_03(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the bounds for this plot as (Xmin, Xmax, Ymin, Ymax).
	///
	/// See \a GetUnscaledInputBounds for more information.
	/// </summary>
	public virtual void GetBounds(IntPtr bounds)
	{
		vtkPlot_GetBounds_03(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlot_GetBrush_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the vtkBrush object that controls how this plot fills shapes.
	/// </summary>
	public vtkBrush GetBrush()
	{
		vtkBrush vtkBrush2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot_GetBrush_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPlot_GetColor_05(HandleRef pThis, IntPtr rgb);

	/// <summary>
	/// Get the plot color as integer rgb values (comprised between 0 and 255)
	/// </summary>
	public void GetColor(IntPtr rgb)
	{
		vtkPlot_GetColor_05(GetCppThis(), rgb);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_GetColorF_06(HandleRef pThis, IntPtr rgb);

	/// <summary>
	/// Get the plot color as floating rgb values (comprised between 0.0 and 1.0)
	/// </summary>
	public virtual void GetColorF(IntPtr rgb)
	{
		vtkPlot_GetColorF_06(GetCppThis(), rgb);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlot_GetData_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the data object that the plot will draw.
	/// </summary>
	public vtkContextMapper2D GetData()
	{
		vtkContextMapper2D vtkContextMapper2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot_GetData_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContextMapper2D2 = (vtkContextMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContextMapper2D2.Register(null);
			}
		}
		return vtkContextMapper2D2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlot_GetIndexedLabels_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the indexed labels array.
	/// </summary>
	public virtual vtkStringArray GetIndexedLabels()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot_GetIndexedLabels_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPlot_GetInput_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input table used by the plot.
	/// </summary>
	public virtual vtkTable GetInput()
	{
		vtkTable vtkTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot_GetInput_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTable2 = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTable2.Register(null);
			}
		}
		return vtkTable2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlot_GetInputConnection_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input connection used by the plot.
	/// </summary>
	public vtkAlgorithmOutput GetInputConnection()
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot_GetInputConnection_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkPlot_GetLabel_11(HandleRef pThis);

	/// <summary>
	/// Get the label of this plot.
	/// </summary>
	public virtual string GetLabel()
	{
		return vtkPlot_GetLabel_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkPlot_GetLabel_12(HandleRef pThis, long index);

	/// <summary>
	/// Get the label at the specified index.
	/// </summary>
	public string GetLabel(long index)
	{
		return vtkPlot_GetLabel_12(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlot_GetLabels_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the plot labels. If this array has a length greater than 1 the index
	/// refers to the stacked objects in the plot. See vtkPlotBar for example.
	/// </summary>
	public virtual vtkStringArray GetLabels()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot_GetLabels_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkPlot_GetLegendVisibility_14(HandleRef pThis);

	/// <summary>
	/// Set whether the plot renders an entry in the legend. Default is true.
	/// vtkPlot::PaintLegend will get called to render the legend marker on when
	/// this is true.
	/// </summary>
	public virtual bool GetLegendVisibility()
	{
		return (vtkPlot_GetLegendVisibility_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlot_GetNearestPoint_15(HandleRef pThis, HandleRef point, HandleRef tolerance, HandleRef location, IntPtr segmentId);

	/// <summary>
	/// Function to query a plot for the nearest point to the specified coordinate.
	/// Returns the index of the data series with which the point is associated, or
	/// -1 if no point was found.
	/// </summary>
	public virtual long GetNearestPoint(vtkVector2f point, vtkVector2f tolerance, vtkVector2f location, IntPtr segmentId)
	{
		return vtkPlot_GetNearestPoint_15(GetCppThis(), point?.GetCppThis() ?? default(HandleRef), tolerance?.GetCppThis() ?? default(HandleRef), location?.GetCppThis() ?? default(HandleRef), segmentId);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlot_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlot_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlot_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlot_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlot_GetNumberOfLabels_18(HandleRef pThis);

	/// <summary>
	/// Get the number of labels associated with this plot.
	/// </summary>
	public virtual int GetNumberOfLabels()
	{
		return vtkPlot_GetNumberOfLabels_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlot_GetPen_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the vtkPen object that controls how this plot draws (out)lines.
	/// </summary>
	public vtkPen GetPen()
	{
		vtkPen vtkPen2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot_GetPen_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPlot_GetProperty_20(HandleRef pThis, string property, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// A General setter/getter that should be overridden. It can silently drop
	/// options, case is important
	/// </summary>
	public virtual vtkVariant GetProperty(string property)
	{
		vtkVariant result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot_GetProperty_20(GetCppThis(), property, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlot_GetSelectable_21(HandleRef pThis);

	/// <summary>
	/// Set whether the plot can be selected. True by default.
	/// If not, then SetSelection(), SelectPoints() or SelectPointsInPolygon()
	/// won't have any effect.
	/// \sa SetSelection(), SelectPoints(), SelectPointsInPolygon()
	/// </summary>
	public virtual bool GetSelectable()
	{
		return (vtkPlot_GetSelectable_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlot_GetSelection_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Sets the list of points that must be selected.
	/// If Selectable is false, then this method does nothing.
	/// \sa SetSelectable()
	/// </summary>
	public virtual vtkIdTypeArray GetSelection()
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot_GetSelection_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdTypeArray2 = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdTypeArray2.Register(null);
			}
		}
		return vtkIdTypeArray2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlot_GetSelectionBrush_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the vtkBrush object that controls how this plot fills selected
	/// shapes.
	/// </summary>
	public vtkBrush GetSelectionBrush()
	{
		vtkBrush vtkBrush2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot_GetSelectionBrush_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPlot_GetSelectionPen_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the vtkBrush object that controls how this plot fills selected
	/// shapes.
	/// </summary>
	public vtkPen GetSelectionPen()
	{
		vtkPen vtkPen2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot_GetSelectionPen_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPlot_GetShiftScale_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/set the origin shift and scaling factor used by the plot, this is
	/// normally 0.0 offset and 1.0 scaling, but can be used to render data outside
	/// of the single precision range. The chart that owns the plot should set this
	/// and ensure the appropriate matrix is used when rendering the plot.
	/// </summary>
	public vtkRectd GetShiftScale()
	{
		vtkRectd result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot_GetShiftScale_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectd)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkPlot_GetTooltipLabel_26(HandleRef pThis, HandleRef plotPos, long seriesIndex, long segmentIndex);

	/// <summary>
	/// Generate and return the tooltip label string for this plot
	/// The segmentIndex parameter is ignored, except for vtkPlotBar
	/// </summary>
	public virtual string GetTooltipLabel(vtkVector2d plotPos, long seriesIndex, long segmentIndex)
	{
		return vtkPlot_GetTooltipLabel_26(GetCppThis(), plotPos?.GetCppThis() ?? default(HandleRef), seriesIndex, segmentIndex);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkPlot_GetTooltipLabelFormat_27(HandleRef pThis);

	/// <summary>
	/// Sets/gets a printf-style string to build custom tooltip labels from.
	/// An empty string generates the default tooltip labels.
	/// The following case-sensitive format tags (without quotes) are recognized:
	/// '%x' The X value of the plot element
	/// '%y' The Y value of the plot element
	/// '%i' The IndexedLabels entry for the plot element
	/// '%l' The value of the plot's GetLabel() function
	/// '%s' (vtkPlotBar only) The Labels entry for the bar segment
	/// Any other characters or unrecognized format tags are printed in the
	/// tooltip label verbatim.
	/// </summary>
	public virtual string GetTooltipLabelFormat()
	{
		return vtkPlot_GetTooltipLabelFormat_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlot_GetTooltipNotation_28(HandleRef pThis);

	/// <summary>
	/// Sets/gets the tooltip notation style.
	/// </summary>
	public virtual int GetTooltipNotation()
	{
		return vtkPlot_GetTooltipNotation_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlot_GetTooltipPrecision_29(HandleRef pThis);

	/// <summary>
	/// Sets/gets the tooltip precision.
	/// </summary>
	public virtual int GetTooltipPrecision()
	{
		return vtkPlot_GetTooltipPrecision_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_GetUnscaledInputBounds_30(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Provide un-log-scaled bounds for the plot inputs.
	///
	/// This function is analogous to GetBounds() with 2 exceptions:
	/// 1. It will never return log-scaled bounds even when the
	/// x- and/or y-axes are log-scaled.
	/// 2. It will always return the bounds along the *input* axes
	/// rather than the output chart coordinates. Thus GetXAxis()
	/// returns the axis associated with the first 2 bounds entries
	/// and GetYAxis() returns the axis associated with the next 2
	/// bounds entries.
	///
	/// For example, vtkPlotBar's GetBounds() method
	/// will swap axis bounds when its orientation is vertical while
	/// its GetUnscaledInputBounds() will not swap axis bounds.
	///
	/// This method is provided so user interfaces can determine
	/// whether or not to allow log-scaling of a particular vtkAxis.
	///
	/// Subclasses of vtkPlot are responsible for implementing this
	/// function to transform input plot data.
	///
	/// The returned \a bounds are stored as (Xmin, Xmax, Ymin, Ymax).
	/// </summary>
	public virtual void GetUnscaledInputBounds(IntPtr bounds)
	{
		vtkPlot_GetUnscaledInputBounds_30(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlot_GetUseIndexForXSeries_31(HandleRef pThis);

	/// <summary>
	/// Use the Y array index for the X value. If true any X column setting will be
	/// ignored, and the X values will simply be the index of the Y column.
	/// </summary>
	public virtual bool GetUseIndexForXSeries()
	{
		return (vtkPlot_GetUseIndexForXSeries_31(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkPlot_GetWidth_32(HandleRef pThis);

	/// <summary>
	/// Get the width of the line.
	/// </summary>
	public virtual float GetWidth()
	{
		return vtkPlot_GetWidth_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlot_GetXAxis_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/set the X axis associated with this plot.
	/// </summary>
	public virtual vtkAxis GetXAxis()
	{
		vtkAxis vtkAxis2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot_GetXAxis_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPlot_GetYAxis_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/set the Y axis associated with this plot.
	/// </summary>
	public virtual vtkAxis GetYAxis()
	{
		vtkAxis vtkAxis2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot_GetYAxis_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPlot_IsA_35(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlot_IsA_35(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlot_IsTypeOf_36(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlot_IsTypeOf_36(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_LegendVisibilityOff_37(HandleRef pThis);

	/// <summary>
	/// Set whether the plot renders an entry in the legend. Default is true.
	/// vtkPlot::PaintLegend will get called to render the legend marker on when
	/// this is true.
	/// </summary>
	public virtual void LegendVisibilityOff()
	{
		vtkPlot_LegendVisibilityOff_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_LegendVisibilityOn_38(HandleRef pThis);

	/// <summary>
	/// Set whether the plot renders an entry in the legend. Default is true.
	/// vtkPlot::PaintLegend will get called to render the legend marker on when
	/// this is true.
	/// </summary>
	public virtual void LegendVisibilityOn()
	{
		vtkPlot_LegendVisibilityOn_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlot_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPlot NewInstance()
	{
		vtkPlot result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot_NewInstance_39(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlot)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlot_PaintLegend_40(HandleRef pThis, HandleRef painter, HandleRef rect, int legendIndex);

	/// <summary>
	/// Paint legend event for the plot, called whenever the legend needs the
	/// plot items symbol/mark/line drawn. A rect is supplied with the lower left
	/// corner of the rect (elements 0 and 1) and with width x height (elements 2
	/// and 3). The plot can choose how to fill the space supplied. The index is used
	/// by Plots that return more than one label.
	/// </summary>
	public virtual bool PaintLegend(vtkContext2D painter, vtkRectf rect, int legendIndex)
	{
		return (vtkPlot_PaintLegend_40(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef), rect?.GetCppThis() ?? default(HandleRef), legendIndex) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlot_SafeDownCast_41(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlot SafeDownCast(vtkObjectBase o)
	{
		vtkPlot vtkPlot2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlot_SafeDownCast_41(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkPlot_SelectPoints_42(HandleRef pThis, HandleRef min, HandleRef max);

	/// <summary>
	/// Select all points in the specified rectangle.
	/// </summary>
	public virtual bool SelectPoints(vtkVector2f min, vtkVector2f max)
	{
		return (vtkPlot_SelectPoints_42(GetCppThis(), min?.GetCppThis() ?? default(HandleRef), max?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SelectableOff_43(HandleRef pThis);

	/// <summary>
	/// Set whether the plot can be selected. True by default.
	/// If not, then SetSelection(), SelectPoints() or SelectPointsInPolygon()
	/// won't have any effect.
	/// \sa SetSelection(), SelectPoints(), SelectPointsInPolygon()
	/// </summary>
	public virtual void SelectableOff()
	{
		vtkPlot_SelectableOff_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SelectableOn_44(HandleRef pThis);

	/// <summary>
	/// Set whether the plot can be selected. True by default.
	/// If not, then SetSelection(), SelectPoints() or SelectPointsInPolygon()
	/// won't have any effect.
	/// \sa SetSelection(), SelectPoints(), SelectPointsInPolygon()
	/// </summary>
	public virtual void SelectableOn()
	{
		vtkPlot_SelectableOn_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetBrush_45(HandleRef pThis, HandleRef brush);

	/// <summary>
	/// Set/get the vtkBrush object that controls how this plot fills shapes.
	/// </summary>
	public void SetBrush(vtkBrush brush)
	{
		vtkPlot_SetBrush_45(GetCppThis(), brush?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetColor_46(HandleRef pThis, byte r, byte g, byte b, byte a);

	/// <summary>
	/// Set the plot color with integer values (comprised between 0 and 255)
	/// </summary>
	public virtual void SetColor(byte r, byte g, byte b, byte a)
	{
		vtkPlot_SetColor_46(GetCppThis(), r, g, b, a);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetColorF_47(HandleRef pThis, double r, double g, double b, double a);

	/// <summary>
	/// Set the plot color with floating values (comprised between 0.0 and 1.0)
	/// </summary>
	public virtual void SetColorF(double r, double g, double b, double a)
	{
		vtkPlot_SetColorF_47(GetCppThis(), r, g, b, a);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetColorF_48(HandleRef pThis, double r, double g, double b);

	/// <summary>
	/// Set the plot color with floating values (comprised between 0.0 and 1.0)
	/// </summary>
	public virtual void SetColorF(double r, double g, double b)
	{
		vtkPlot_SetColorF_48(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetIndexedLabels_49(HandleRef pThis, HandleRef labels);

	/// <summary>
	/// Set indexed labels for the plot. If set, this array can be used to provide
	/// custom labels for each point in a plot. This array should be the same
	/// length as the points array. Default is null (no indexed labels).
	/// </summary>
	public void SetIndexedLabels(vtkStringArray labels)
	{
		vtkPlot_SetIndexedLabels_49(GetCppThis(), labels?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetInputArray_50(HandleRef pThis, int index, string name);

	/// <summary>
	/// Convenience function to set the input arrays. For most plots index 0
	/// is the x axis, and index 1 is the y axis. The name is the name of the
	/// column in the vtkTable.
	/// </summary>
	public virtual void SetInputArray(int index, string name)
	{
		vtkPlot_SetInputArray_50(GetCppThis(), index, name);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetInputConnection_51(HandleRef pThis, HandleRef input);

	/// <summary>
	/// This is a convenience function to set the input connection for the plot.
	/// </summary>
	public virtual void SetInputConnection(vtkAlgorithmOutput input)
	{
		vtkPlot_SetInputConnection_51(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetInputData_52(HandleRef pThis, HandleRef table);

	/// <summary>
	/// This is a convenience function to set the input table and the x, y column
	/// for the plot.
	/// </summary>
	public virtual void SetInputData(vtkTable table)
	{
		vtkPlot_SetInputData_52(GetCppThis(), table?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetInputData_53(HandleRef pThis, HandleRef table, string xColumn, string yColumn);

	/// <summary>
	/// This is a convenience function to set the input table and the x, y column
	/// for the plot.
	/// </summary>
	public virtual void SetInputData(vtkTable table, string xColumn, string yColumn)
	{
		vtkPlot_SetInputData_53(GetCppThis(), table?.GetCppThis() ?? default(HandleRef), xColumn, yColumn);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetInputData_54(HandleRef pThis, HandleRef table, long xColumn, long yColumn);

	/// <summary>
	/// This is a convenience function to set the input table and the x, y column
	/// for the plot.
	/// </summary>
	public void SetInputData(vtkTable table, long xColumn, long yColumn)
	{
		vtkPlot_SetInputData_54(GetCppThis(), table?.GetCppThis() ?? default(HandleRef), xColumn, yColumn);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetLabel_55(HandleRef pThis, string label);

	/// <summary>
	/// Set the label of this plot.
	/// </summary>
	public virtual void SetLabel(string label)
	{
		vtkPlot_SetLabel_55(GetCppThis(), label);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetLabels_56(HandleRef pThis, HandleRef labels);

	/// <summary>
	/// Set the plot labels, these are used for stacked chart variants, with the
	/// index referring to the stacking index.
	/// </summary>
	public virtual void SetLabels(vtkStringArray labels)
	{
		vtkPlot_SetLabels_56(GetCppThis(), labels?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetLegendVisibility_57(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set whether the plot renders an entry in the legend. Default is true.
	/// vtkPlot::PaintLegend will get called to render the legend marker on when
	/// this is true.
	/// </summary>
	public virtual void SetLegendVisibility(bool _arg)
	{
		vtkPlot_SetLegendVisibility_57(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetPen_58(HandleRef pThis, HandleRef pen);

	/// <summary>
	/// Set/get the vtkPen object that controls how this plot draws (out)lines.
	/// </summary>
	public void SetPen(vtkPen pen)
	{
		vtkPlot_SetPen_58(GetCppThis(), pen?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetProperty_59(HandleRef pThis, string property, HandleRef var);

	/// <summary>
	/// A General setter/getter that should be overridden. It can silently drop
	/// options, case is important
	/// </summary>
	public virtual void SetProperty(string property, vtkVariant var)
	{
		vtkPlot_SetProperty_59(GetCppThis(), property, var?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetSelectable_60(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set whether the plot can be selected. True by default.
	/// If not, then SetSelection(), SelectPoints() or SelectPointsInPolygon()
	/// won't have any effect.
	/// \sa SetSelection(), SelectPoints(), SelectPointsInPolygon()
	/// </summary>
	public virtual void SetSelectable(bool _arg)
	{
		vtkPlot_SetSelectable_60(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetSelection_61(HandleRef pThis, HandleRef id);

	/// <summary>
	/// Sets the list of points that must be selected.
	/// If Selectable is false, then this method does nothing.
	/// \sa SetSelectable()
	/// </summary>
	public virtual void SetSelection(vtkIdTypeArray id)
	{
		vtkPlot_SetSelection_61(GetCppThis(), id?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetSelectionBrush_62(HandleRef pThis, HandleRef brush);

	/// <summary>
	/// Set/get the vtkBrush object that controls how this plot fills selected
	/// shapes.
	/// </summary>
	public void SetSelectionBrush(vtkBrush brush)
	{
		vtkPlot_SetSelectionBrush_62(GetCppThis(), brush?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetSelectionPen_63(HandleRef pThis, HandleRef pen);

	/// <summary>
	/// Set/get the vtkBrush object that controls how this plot fills selected
	/// shapes.
	/// </summary>
	public void SetSelectionPen(vtkPen pen)
	{
		vtkPlot_SetSelectionPen_63(GetCppThis(), pen?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetShiftScale_64(HandleRef pThis, HandleRef shiftScale);

	/// <summary>
	/// Get/set the origin shift and scaling factor used by the plot, this is
	/// normally 0.0 offset and 1.0 scaling, but can be used to render data outside
	/// of the single precision range. The chart that owns the plot should set this
	/// and ensure the appropriate matrix is used when rendering the plot.
	/// </summary>
	public void SetShiftScale(vtkRectd shiftScale)
	{
		vtkPlot_SetShiftScale_64(GetCppThis(), shiftScale?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetTooltipLabelFormat_65(HandleRef pThis, string label);

	/// <summary>
	/// Sets/gets a printf-style string to build custom tooltip labels from.
	/// An empty string generates the default tooltip labels.
	/// The following case-sensitive format tags (without quotes) are recognized:
	/// '%x' The X value of the plot element
	/// '%y' The Y value of the plot element
	/// '%i' The IndexedLabels entry for the plot element
	/// '%l' The value of the plot's GetLabel() function
	/// '%s' (vtkPlotBar only) The Labels entry for the bar segment
	/// Any other characters or unrecognized format tags are printed in the
	/// tooltip label verbatim.
	/// </summary>
	public virtual void SetTooltipLabelFormat(string label)
	{
		vtkPlot_SetTooltipLabelFormat_65(GetCppThis(), label);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetTooltipNotation_66(HandleRef pThis, int notation);

	/// <summary>
	/// Sets/gets the tooltip notation style.
	/// </summary>
	public virtual void SetTooltipNotation(int notation)
	{
		vtkPlot_SetTooltipNotation_66(GetCppThis(), notation);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetTooltipPrecision_67(HandleRef pThis, int precision);

	/// <summary>
	/// Sets/gets the tooltip precision.
	/// </summary>
	public virtual void SetTooltipPrecision(int precision)
	{
		vtkPlot_SetTooltipPrecision_67(GetCppThis(), precision);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetUseIndexForXSeries_68(HandleRef pThis, byte _arg);

	/// <summary>
	/// Use the Y array index for the X value. If true any X column setting will be
	/// ignored, and the X values will simply be the index of the Y column.
	/// </summary>
	public virtual void SetUseIndexForXSeries(bool _arg)
	{
		vtkPlot_SetUseIndexForXSeries_68(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetWidth_69(HandleRef pThis, float width);

	/// <summary>
	/// Set the width of the line.
	/// </summary>
	public virtual void SetWidth(float width)
	{
		vtkPlot_SetWidth_69(GetCppThis(), width);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetXAxis_70(HandleRef pThis, HandleRef axis);

	/// <summary>
	/// Get/set the X axis associated with this plot.
	/// </summary>
	public virtual void SetXAxis(vtkAxis axis)
	{
		vtkPlot_SetXAxis_70(GetCppThis(), axis?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_SetYAxis_71(HandleRef pThis, HandleRef axis);

	/// <summary>
	/// Get/set the Y axis associated with this plot.
	/// </summary>
	public virtual void SetYAxis(vtkAxis axis)
	{
		vtkPlot_SetYAxis_71(GetCppThis(), axis?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlot_Update_72(HandleRef pThis);

	/// <summary>
	/// Perform any updates to the item that may be necessary before rendering.
	/// The scene should take care of calling this on all items before their
	/// Paint function is invoked.
	/// </summary>
	public override void Update()
	{
		vtkPlot_Update_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlot_UpdateCache_73(HandleRef pThis);

	/// <summary>
	/// Update the internal cache. Returns true if cache was successfully updated. Default does
	/// nothing.
	/// This method is called by Update() when either the plot's data has changed or
	/// CacheRequiresUpdate() returns true. It is not necessary to call this method explicitly.
	/// </summary>
	public virtual bool UpdateCache()
	{
		return (vtkPlot_UpdateCache_73(GetCppThis()) != 0) ? true : false;
	}
}
