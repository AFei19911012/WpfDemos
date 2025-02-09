using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlotBar
/// </summary>
/// <remarks>
///    Class for drawing an XY plot given two columns from a
/// vtkTable.
///
///
///
/// </remarks>
public class vtkPlotBar : vtkPlot
{
	/// <summary>
	/// Enum of bar chart oritentation types
	/// </summary>
	public enum HORIZONTAL_WrapperEnum
	{
		/// <summary>enum member</summary>
		HORIZONTAL = 1,
		/// <summary>enum member</summary>
		VERTICAL = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlotBar";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlotBar()
	{
		MRClassNameKey = "class vtkPlotBar";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotBar"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlotBar(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotBar_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a 2D Chart object.
	/// </summary>
	public new static vtkPlotBar New()
	{
		vtkPlotBar result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotBar_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlotBar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a 2D Chart object.
	/// </summary>
	public vtkPlotBar()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPlotBar_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPlotBar_CreateDefaultLookupTable_01(HandleRef pThis);

	/// <summary>
	/// Create default lookup table. Generally used to create one when none
	/// is available with the scalar data.
	/// </summary>
	public virtual void CreateDefaultLookupTable()
	{
		vtkPlotBar_CreateDefaultLookupTable_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_EnableOpacityMappingOff_02(HandleRef pThis);

	/// <summary>
	/// Enable/disable mapping of the opacity values. Default is set to true.
	/// </summary>
	public virtual void EnableOpacityMappingOff()
	{
		vtkPlotBar_EnableOpacityMappingOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_EnableOpacityMappingOn_03(HandleRef pThis);

	/// <summary>
	/// Enable/disable mapping of the opacity values. Default is set to true.
	/// </summary>
	public virtual void EnableOpacityMappingOn()
	{
		vtkPlotBar_EnableOpacityMappingOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotBar_GetBarsCount_04(HandleRef pThis);

	/// <summary>
	/// Get amount of plotted bars.
	/// </summary>
	public int GetBarsCount()
	{
		return vtkPlotBar_GetBarsCount_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_GetBounds_05(HandleRef pThis, IntPtr bounds, byte unscaled);

	/// <summary>
	/// A helper used by both GetUnscaledBounds and GetBounds(double[4]).
	/// </summary>
	public virtual void GetBounds(IntPtr bounds, bool unscaled)
	{
		vtkPlotBar_GetBounds_05(GetCppThis(), bounds, (byte)(unscaled ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_GetBounds_06(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the bounds for this mapper as (Xmin,Xmax,Ymin,Ymax).
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkPlotBar_GetBounds_06(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkPlotBar_GetColorArrayName_07(HandleRef pThis);

	/// <summary>
	/// Get the array name to color by.
	/// </summary>
	public string GetColorArrayName()
	{
		return vtkPlotBar_GetColorArrayName_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_GetColorF_08(HandleRef pThis, IntPtr rgb);

	/// <summary>
	/// Get the plot color as floating rgb values (comprised between 0.0 and 1.0)
	/// </summary>
	public override void GetColorF(IntPtr rgb)
	{
		vtkPlotBar_GetColorF_08(GetCppThis(), rgb);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotBar_GetColorSeries_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the color series used if when this is a stacked bar plot.
	/// </summary>
	public vtkColorSeries GetColorSeries()
	{
		vtkColorSeries vtkColorSeries2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotBar_GetColorSeries_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPlotBar_GetDataBounds_10(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the data bounds for this mapper as (Xmin,Xmax).
	/// </summary>
	public void GetDataBounds(IntPtr bounds)
	{
		vtkPlotBar_GetDataBounds_10(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotBar_GetEnableOpacityMapping_11(HandleRef pThis);

	/// <summary>
	/// Enable/disable mapping of the opacity values. Default is set to true.
	/// </summary>
	public virtual bool GetEnableOpacityMapping()
	{
		return (vtkPlotBar_GetEnableOpacityMapping_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkPlotBar_GetGroupName_12(HandleRef pThis);

	/// <summary>
	/// Get the group name of the bar char - can be displayed on the X axis.
	/// </summary>
	public virtual string GetGroupName()
	{
		return vtkPlotBar_GetGroupName_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotBar_GetLabels_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the plot labels.
	/// </summary>
	public override vtkStringArray GetLabels()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotBar_GetLabels_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPlotBar_GetLookupTable_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a lookup table for the mapper to use.
	/// </summary>
	public virtual vtkScalarsToColors GetLookupTable()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotBar_GetLookupTable_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkPlotBar_GetNearestPoint_15(HandleRef pThis, HandleRef point, HandleRef arg1, HandleRef location, IntPtr segmentIndex);

	/// <summary>
	/// Function to query a plot for the nearest point to the specified coordinate.
	/// Returns the index of the data series with which the point is associated or
	/// -1.
	/// If a vtkIdType* is passed, its referent will be set to index of the bar
	/// segment with which a point is associated, or -1.
	/// </summary>
	public override long GetNearestPoint(vtkVector2f point, vtkVector2f arg1, vtkVector2f location, IntPtr segmentIndex)
	{
		return vtkPlotBar_GetNearestPoint_15(GetCppThis(), point?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef), location?.GetCppThis() ?? default(HandleRef), segmentIndex);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotBar_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlotBar_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotBar_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlotBar_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkPlotBar_GetOffset_18(HandleRef pThis);

	/// <summary>
	/// Set/get the horizontal offset of the bars.
	/// Positive values move the bars leftward.
	/// For HORIZONTAL orientation, offsets bars vertically,
	/// with a positive value moving bars downward.
	/// </summary>
	public virtual float GetOffset()
	{
		return vtkPlotBar_GetOffset_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotBar_GetOrientation_19(HandleRef pThis);

	/// <summary>
	/// Set/get the orientation of the bars.
	/// Valid orientations are VERTICAL (default) and HORIZONTAL.
	/// </summary>
	public virtual int GetOrientation()
	{
		return vtkPlotBar_GetOrientation_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotBar_GetScalarVisibility_20(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual bool GetScalarVisibility()
	{
		return (vtkPlotBar_GetScalarVisibility_20(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkPlotBar_GetTooltipLabel_21(HandleRef pThis, HandleRef plotPos, long seriesIndex, long segmentIndex);

	/// <summary>
	/// Generate and return the tooltip label string for this plot
	/// The segmentIndex is implemented here.
	/// </summary>
	public override string GetTooltipLabel(vtkVector2d plotPos, long seriesIndex, long segmentIndex)
	{
		return vtkPlotBar_GetTooltipLabel_21(GetCppThis(), plotPos?.GetCppThis() ?? default(HandleRef), seriesIndex, segmentIndex);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_GetUnscaledInputBounds_22(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get un-log-scaled bounds for this mapper as (Xmin,Xmax,Ymin,Ymax).
	/// </summary>
	public override void GetUnscaledInputBounds(IntPtr bounds)
	{
		vtkPlotBar_GetUnscaledInputBounds_22(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkPlotBar_GetWidth_23(HandleRef pThis);

	/// <summary>
	/// Get the width of the line.
	/// </summary>
	public override float GetWidth()
	{
		return vtkPlotBar_GetWidth_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotBar_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlotBar_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotBar_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlotBar_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotBar_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPlotBar NewInstance()
	{
		vtkPlotBar result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotBar_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlotBar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotBar_Paint_28(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the XY plot, called whenever the chart needs to be drawn
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkPlotBar_Paint_28(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotBar_PaintLegend_29(HandleRef pThis, HandleRef painter, HandleRef rect, int legendIndex);

	/// <summary>
	/// Paint legend event for the XY plot, called whenever the legend needs the
	/// plot items symbol/mark/line drawn. A rect is supplied with the lower left
	/// corner of the rect (elements 0 and 1) and with width x height (elements 2
	/// and 3). The plot can choose how to fill the space supplied.
	/// </summary>
	public override bool PaintLegend(vtkContext2D painter, vtkRectf rect, int legendIndex)
	{
		return (vtkPlotBar_PaintLegend_29(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef), rect?.GetCppThis() ?? default(HandleRef), legendIndex) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotBar_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlotBar SafeDownCast(vtkObjectBase o)
	{
		vtkPlotBar vtkPlotBar2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotBar_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlotBar2 = (vtkPlotBar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlotBar2.Register(null);
			}
		}
		return vtkPlotBar2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_ScalarVisibilityOff_31(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual void ScalarVisibilityOff()
	{
		vtkPlotBar_ScalarVisibilityOff_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_ScalarVisibilityOn_32(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual void ScalarVisibilityOn()
	{
		vtkPlotBar_ScalarVisibilityOn_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_SelectColorArray_33(HandleRef pThis, long arrayNum);

	/// <summary>
	/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
	/// you can specify which array to use for coloring using these methods.
	/// The lookup table will decide how to convert vectors to colors.
	/// </summary>
	public void SelectColorArray(long arrayNum)
	{
		vtkPlotBar_SelectColorArray_33(GetCppThis(), arrayNum);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_SelectColorArray_34(HandleRef pThis, string arrayName);

	/// <summary>
	/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
	/// you can specify which array to use for coloring using these methods.
	/// The lookup table will decide how to convert vectors to colors.
	/// </summary>
	public void SelectColorArray(string arrayName)
	{
		vtkPlotBar_SelectColorArray_34(GetCppThis(), arrayName);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotBar_SelectPoints_35(HandleRef pThis, HandleRef min, HandleRef max);

	/// <summary>
	/// Select all points in the specified rectangle.
	/// </summary>
	public override bool SelectPoints(vtkVector2f min, vtkVector2f max)
	{
		return (vtkPlotBar_SelectPoints_35(GetCppThis(), min?.GetCppThis() ?? default(HandleRef), max?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_SetColor_36(HandleRef pThis, byte r, byte g, byte b, byte a);

	/// <summary>
	/// Set the plot color with integer values (comprised between 0 and 255)
	/// </summary>
	public override void SetColor(byte r, byte g, byte b, byte a)
	{
		vtkPlotBar_SetColor_36(GetCppThis(), r, g, b, a);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_SetColorF_37(HandleRef pThis, double r, double g, double b, double a);

	/// <summary>
	/// Set the plot color with floating values (comprised between 0.0 and 1.0)
	/// </summary>
	public override void SetColorF(double r, double g, double b, double a)
	{
		vtkPlotBar_SetColorF_37(GetCppThis(), r, g, b, a);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_SetColorF_38(HandleRef pThis, double r, double g, double b);

	/// <summary>
	/// Set the plot color with floating values (comprised between 0.0 and 1.0)
	/// </summary>
	public override void SetColorF(double r, double g, double b)
	{
		vtkPlotBar_SetColorF_38(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_SetColorSeries_39(HandleRef pThis, HandleRef colorSeries);

	/// <summary>
	/// Set the color series to use if this becomes a stacked bar plot.
	/// </summary>
	public void SetColorSeries(vtkColorSeries colorSeries)
	{
		vtkPlotBar_SetColorSeries_39(GetCppThis(), colorSeries?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_SetEnableOpacityMapping_40(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable/disable mapping of the opacity values. Default is set to true.
	/// </summary>
	public virtual void SetEnableOpacityMapping(bool _arg)
	{
		vtkPlotBar_SetEnableOpacityMapping_40(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_SetGroupName_41(HandleRef pThis, string name);

	/// <summary>
	/// Set the group name of the bar chart - can be displayed on the X axis.
	/// </summary>
	public virtual void SetGroupName(string name)
	{
		vtkPlotBar_SetGroupName_41(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_SetInputArray_42(HandleRef pThis, int index, string name);

	/// <summary>
	/// When used to set additional arrays, stacked bars are created.
	/// </summary>
	public override void SetInputArray(int index, string name)
	{
		vtkPlotBar_SetInputArray_42(GetCppThis(), index, name);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_SetLookupTable_43(HandleRef pThis, HandleRef lut);

	/// <summary>
	/// Specify a lookup table for the mapper to use.
	/// </summary>
	public virtual void SetLookupTable(vtkScalarsToColors lut)
	{
		vtkPlotBar_SetLookupTable_43(GetCppThis(), lut?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_SetOffset_44(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/get the horizontal offset of the bars.
	/// Positive values move the bars leftward.
	/// For HORIZONTAL orientation, offsets bars vertically,
	/// with a positive value moving bars downward.
	/// </summary>
	public virtual void SetOffset(float _arg)
	{
		vtkPlotBar_SetOffset_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_SetOrientation_45(HandleRef pThis, int orientation);

	/// <summary>
	/// Set/get the orientation of the bars.
	/// Valid orientations are VERTICAL (default) and HORIZONTAL.
	/// </summary>
	public virtual void SetOrientation(int orientation)
	{
		vtkPlotBar_SetOrientation_45(GetCppThis(), orientation);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_SetScalarVisibility_46(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual void SetScalarVisibility(bool _arg)
	{
		vtkPlotBar_SetScalarVisibility_46(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBar_SetWidth_47(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the width of the line.
	/// </summary>
	public override void SetWidth(float _arg)
	{
		vtkPlotBar_SetWidth_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotBar_UpdateCache_48(HandleRef pThis);

	/// <summary>
	/// Update the internal cache. Returns true if cache was successfully updated. Default does
	/// nothing.
	/// This method is called by Update() when either the plot's data has changed or
	/// CacheRequiresUpdate() returns true. It is not necessary to call this method explicitly.
	/// </summary>
	public override bool UpdateCache()
	{
		return (vtkPlotBar_UpdateCache_48(GetCppThis()) != 0) ? true : false;
	}
}
