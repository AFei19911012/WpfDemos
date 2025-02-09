using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlotPoints
/// </summary>
/// <remarks>
///    Class for drawing an points given two columns from a
/// vtkTable.
///
///
/// This class draws points in a plot given two columns from a table. If you need
/// a line as well you should use vtkPlotLine which derives from vtkPlotPoints
/// and is capable of drawing both points and a line.
///
/// </remarks>
/// <seealso>
///
/// vtkPlotLine
/// </seealso>
public class vtkPlotPoints : vtkPlot
{
	/// <summary>
	/// Enum containing various marker styles that can be used in a plot.
	/// </summary>
	public enum CIRCLE_WrapperEnum
	{
		/// <summary>enum member</summary>
		CIRCLE = 4,
		/// <summary>enum member</summary>
		CROSS = 1,
		/// <summary>enum member</summary>
		DIAMOND = 5,
		/// <summary>enum member</summary>
		NONE = 0,
		/// <summary>enum member</summary>
		PLUS = 2,
		/// <summary>enum member</summary>
		SQUARE = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlotPoints";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlotPoints()
	{
		MRClassNameKey = "class vtkPlotPoints";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotPoints"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlotPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a 2D Chart object.
	/// </summary>
	public new static vtkPlotPoints New()
	{
		vtkPlotPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlotPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a 2D Chart object.
	/// </summary>
	public vtkPlotPoints()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPlotPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPlotPoints_CreateDefaultLookupTable_01(HandleRef pThis);

	/// <summary>
	/// Create default lookup table. Generally used to create one when none
	/// is available with the scalar data.
	/// </summary>
	public virtual void CreateDefaultLookupTable()
	{
		vtkPlotPoints_CreateDefaultLookupTable_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotPoints_GetBounds_02(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the bounds for this plot as (Xmin, Xmax, Ymin, Ymax).
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkPlotPoints_GetBounds_02(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkPlotPoints_GetColorArrayName_03(HandleRef pThis);

	/// <summary>
	/// Get the array name to color by.
	/// </summary>
	public string GetColorArrayName()
	{
		return vtkPlotPoints_GetColorArrayName_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotPoints_GetLookupTable_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a lookup table for the mapper to use.
	/// </summary>
	public vtkScalarsToColors GetLookupTable()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotPoints_GetLookupTable_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern float vtkPlotPoints_GetMarkerSize_05(HandleRef pThis);

	/// <summary>
	/// Get/set the marker size that should be used. The default is negative, and
	/// in that case it is 2.3 times the pen width, if less than 8 will be used.
	/// </summary>
	public virtual float GetMarkerSize()
	{
		return vtkPlotPoints_GetMarkerSize_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotPoints_GetMarkerStyle_06(HandleRef pThis);

	/// <summary>
	/// Get/set the marker style that should be used. The default is none, the enum
	/// in this class is used as a parameter.
	/// </summary>
	public virtual int GetMarkerStyle()
	{
		return vtkPlotPoints_GetMarkerStyle_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotPoints_GetNearestPoint_07(HandleRef pThis, HandleRef point, HandleRef tolerance, HandleRef location, IntPtr segmentId);

	/// <summary>
	/// Function to query a plot for the nearest point to the specified coordinate.
	/// Returns the index of the data series with which the point is associated or
	/// -1.
	/// </summary>
	public override long GetNearestPoint(vtkVector2f point, vtkVector2f tolerance, vtkVector2f location, IntPtr segmentId)
	{
		return vtkPlotPoints_GetNearestPoint_07(GetCppThis(), point?.GetCppThis() ?? default(HandleRef), tolerance?.GetCppThis() ?? default(HandleRef), location?.GetCppThis() ?? default(HandleRef), segmentId);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotPoints_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlotPoints_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotPoints_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlotPoints_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotPoints_GetScalarVisibility_10(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual int GetScalarVisibility()
	{
		return vtkPlotPoints_GetScalarVisibility_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotPoints_GetUnscaledInputBounds_11(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the non-log-scaled bounds on chart inputs for this plot as (Xmin, Xmax, Ymin, Ymax).
	/// </summary>
	public override void GetUnscaledInputBounds(IntPtr bounds)
	{
		vtkPlotPoints_GetUnscaledInputBounds_11(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkPlotPoints_GetValidPointMaskName_12(HandleRef pThis);

	/// <summary>
	/// Get/set the valid point mask array name.
	/// </summary>
	public virtual string GetValidPointMaskName()
	{
		return vtkPlotPoints_GetValidPointMaskName_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotPoints_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlotPoints_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotPoints_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlotPoints_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotPoints_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPlotPoints NewInstance()
	{
		vtkPlotPoints result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotPoints_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlotPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotPoints_Paint_17(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the XY plot, called whenever the chart needs to be drawn
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkPlotPoints_Paint_17(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotPoints_PaintLegend_18(HandleRef pThis, HandleRef painter, HandleRef rect, int legendIndex);

	/// <summary>
	/// Paint legend event for the XY plot, called whenever the legend needs the
	/// plot items symbol/mark/line drawn. A rect is supplied with the lower left
	/// corner of the rect (elements 0 and 1) and with width x height (elements 2
	/// and 3). The plot can choose how to fill the space supplied.
	/// </summary>
	public override bool PaintLegend(vtkContext2D painter, vtkRectf rect, int legendIndex)
	{
		return (vtkPlotPoints_PaintLegend_18(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef), rect?.GetCppThis() ?? default(HandleRef), legendIndex) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotPoints_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlotPoints SafeDownCast(vtkObjectBase o)
	{
		vtkPlotPoints vtkPlotPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotPoints_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlotPoints2 = (vtkPlotPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlotPoints2.Register(null);
			}
		}
		return vtkPlotPoints2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotPoints_ScalarVisibilityOff_20(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual void ScalarVisibilityOff()
	{
		vtkPlotPoints_ScalarVisibilityOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotPoints_ScalarVisibilityOn_21(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual void ScalarVisibilityOn()
	{
		vtkPlotPoints_ScalarVisibilityOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotPoints_SelectColorArray_22(HandleRef pThis, long arrayNum);

	/// <summary>
	/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
	/// you can specify which array to use for coloring using these methods.
	/// The lookup table will decide how to convert vectors to colors.
	/// </summary>
	public void SelectColorArray(long arrayNum)
	{
		vtkPlotPoints_SelectColorArray_22(GetCppThis(), arrayNum);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotPoints_SelectColorArray_23(HandleRef pThis, string arrayName);

	/// <summary>
	/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
	/// you can specify which array to use for coloring using these methods.
	/// The lookup table will decide how to convert vectors to colors.
	/// </summary>
	public void SelectColorArray(string arrayName)
	{
		vtkPlotPoints_SelectColorArray_23(GetCppThis(), arrayName);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotPoints_SelectPoints_24(HandleRef pThis, HandleRef min, HandleRef max);

	/// <summary>
	/// Select all points in the specified rectangle.
	/// </summary>
	public override bool SelectPoints(vtkVector2f min, vtkVector2f max)
	{
		return (vtkPlotPoints_SelectPoints_24(GetCppThis(), min?.GetCppThis() ?? default(HandleRef), max?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotPoints_SetLookupTable_25(HandleRef pThis, HandleRef lut);

	/// <summary>
	/// Specify a lookup table for the mapper to use.
	/// </summary>
	public void SetLookupTable(vtkScalarsToColors lut)
	{
		vtkPlotPoints_SetLookupTable_25(GetCppThis(), lut?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotPoints_SetMarkerSize_26(HandleRef pThis, float _arg);

	/// <summary>
	/// Get/set the marker size that should be used. The default is negative, and
	/// in that case it is 2.3 times the pen width, if less than 8 will be used.
	/// </summary>
	public virtual void SetMarkerSize(float _arg)
	{
		vtkPlotPoints_SetMarkerSize_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotPoints_SetMarkerStyle_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/set the marker style that should be used. The default is none, the enum
	/// in this class is used as a parameter.
	/// </summary>
	public virtual void SetMarkerStyle(int _arg)
	{
		vtkPlotPoints_SetMarkerStyle_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotPoints_SetScalarVisibility_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual void SetScalarVisibility(int _arg)
	{
		vtkPlotPoints_SetScalarVisibility_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotPoints_SetValidPointMaskName_29(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/set the valid point mask array name.
	/// </summary>
	public virtual void SetValidPointMaskName(string _arg)
	{
		vtkPlotPoints_SetValidPointMaskName_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotPoints_UpdateCache_30(HandleRef pThis);

	/// <summary>
	/// Update the internal cache. Returns true if cache was successfully updated. Default does
	/// nothing.
	/// This method is called by Update() when either the plot's data has changed or
	/// CacheRequiresUpdate() returns true. It is not necessary to call this method explicitly.
	/// </summary>
	public override bool UpdateCache()
	{
		return (vtkPlotPoints_UpdateCache_30(GetCppThis()) != 0) ? true : false;
	}
}
