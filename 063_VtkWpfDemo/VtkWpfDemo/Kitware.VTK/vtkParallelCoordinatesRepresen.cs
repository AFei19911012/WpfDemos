using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkParallelCoordinatesRepresentation
/// </summary>
/// <remarks>
///    Data representation that
///  takes generic multivariate data and produces a parallel coordinates plot.
///
///
///  A parallel coordinates plot represents each variable in a multivariate
///  data set as a separate axis.  Individual samples of that data set are
///  represented as a polyline that pass through each variable axis at
///  positions that correspond to data values.  vtkParallelCoordinatesRepresentation
///  generates this plot when added to a vtkParallelCoordinatesView, which handles
///  interaction and highlighting.  Sample polylines can alternatively
///  be represented as s-curves by enabling the UseCurves flag.
///
///  There are three selection modes: lasso, angle, and function. Lasso selection
///  picks sample lines that pass through a polyline.  Angle selection picks sample
///  lines that have similar slope to a line segment.  Function selection picks
///  sample lines that are near a linear function defined on two variables.  This
///  function specified by passing two (x,y) variable value pairs.
///
///  All primitives are plotted in normalized view coordinates [0,1].
///
/// </remarks>
/// <seealso>
///
///  vtkParallelCoordinatesView vtkParallelCoordinatesHistogramRepresentation
///  vtkSCurveSpline
///
/// @par Thanks:
///  Developed by David Feng at Sandia National Laboratories
/// </seealso>
public class vtkParallelCoordinatesRepresentation : vtkRenderedRepresentation
{
	/// <summary>
	/// Do a selection of the lines.  See the main description for how to use these functions.
	/// RangeSelect is currently stubbed out.
	/// </summary>
	public enum InputPorts
	{
		/// <summary>enum member</summary>
		INPUT_DATA,
		/// <summary>enum member</summary>
		INPUT_TITLES,
		/// <summary>enum member</summary>
		NUM_INPUT_PORTS
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkParallelCoordinatesRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkParallelCoordinatesRepresentation()
	{
		MRClassNameKey = "class vtkParallelCoordinatesRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelCoordinatesRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkParallelCoordinatesRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParallelCoordinatesRepresentation New()
	{
		vtkParallelCoordinatesRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelCoordinatesRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParallelCoordinatesRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkParallelCoordinatesRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkParallelCoordinatesRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_AngleSelect_01(HandleRef pThis, int brushClass, int brushOperator, IntPtr p1, IntPtr p2);

	/// <summary>
	/// Do a selection of the lines.  See the main description for how to use these functions.
	/// RangeSelect is currently stubbed out.
	/// </summary>
	public virtual void AngleSelect(int brushClass, int brushOperator, IntPtr p1, IntPtr p2)
	{
		vtkParallelCoordinatesRepresentation_AngleSelect_01(GetCppThis(), brushClass, brushOperator, p1, p2);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_ApplyViewTheme_02(HandleRef pThis, HandleRef theme);

	/// <summary>
	/// Apply the theme to this view.  CellColor is used for line coloring
	/// and titles.  EdgeLabelColor is used for axis color. CellOpacity is
	/// used for line opacity.
	/// </summary>
	public override void ApplyViewTheme(vtkViewTheme theme)
	{
		vtkParallelCoordinatesRepresentation_ApplyViewTheme_02(GetCppThis(), theme?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_FunctionSelect_03(HandleRef pThis, int brushClass, int brushOperator, IntPtr p1, IntPtr p2, IntPtr q1, IntPtr q2);

	/// <summary>
	/// Do a selection of the lines.  See the main description for how to use these functions.
	/// RangeSelect is currently stubbed out.
	/// </summary>
	public virtual void FunctionSelect(int brushClass, int brushOperator, IntPtr p1, IntPtr p2, IntPtr q1, IntPtr q2)
	{
		vtkParallelCoordinatesRepresentation_FunctionSelect_03(GetCppThis(), brushClass, brushOperator, p1, p2, q1, q2);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParallelCoordinatesRepresentation_GetAngleBrushThreshold_04(HandleRef pThis);

	/// <summary>
	/// Maximum angle difference (in degrees) of selection using angle/function brushes
	/// </summary>
	public virtual double GetAngleBrushThreshold()
	{
		return vtkParallelCoordinatesRepresentation_GetAngleBrushThreshold_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesRepresentation_GetAxisColor_05(HandleRef pThis);

	/// <summary>
	/// Access plot properties
	/// </summary>
	public virtual double[] GetAxisColor()
	{
		IntPtr intPtr = vtkParallelCoordinatesRepresentation_GetAxisColor_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_GetAxisColor_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Access plot properties
	/// </summary>
	public virtual void GetAxisColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkParallelCoordinatesRepresentation_GetAxisColor_06(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_GetAxisColor_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Access plot properties
	/// </summary>
	public virtual void GetAxisColor(IntPtr _arg)
	{
		vtkParallelCoordinatesRepresentation_GetAxisColor_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesRepresentation_GetAxisLabelColor_08(HandleRef pThis);

	/// <summary>
	/// Access plot properties
	/// </summary>
	public virtual double[] GetAxisLabelColor()
	{
		IntPtr intPtr = vtkParallelCoordinatesRepresentation_GetAxisLabelColor_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_GetAxisLabelColor_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Access plot properties
	/// </summary>
	public virtual void GetAxisLabelColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkParallelCoordinatesRepresentation_GetAxisLabelColor_09(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_GetAxisLabelColor_10(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Access plot properties
	/// </summary>
	public virtual void GetAxisLabelColor(IntPtr _arg)
	{
		vtkParallelCoordinatesRepresentation_GetAxisLabelColor_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesRepresentation_GetCurveResolution_11(HandleRef pThis);

	/// <summary>
	/// Resolution of the curves displayed, enabled by setting UseCurves
	/// </summary>
	public virtual int GetCurveResolution()
	{
		return vtkParallelCoordinatesRepresentation_GetCurveResolution_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParallelCoordinatesRepresentation_GetFontSize_12(HandleRef pThis);

	/// <summary>
	/// Access plot properties
	/// </summary>
	public virtual double GetFontSize()
	{
		return vtkParallelCoordinatesRepresentation_GetFontSize_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParallelCoordinatesRepresentation_GetFunctionBrushThreshold_13(HandleRef pThis);

	/// <summary>
	/// Maximum angle difference (in degrees) of selection using angle/function brushes
	/// </summary>
	public virtual double GetFunctionBrushThreshold()
	{
		return vtkParallelCoordinatesRepresentation_GetFunctionBrushThreshold_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkParallelCoordinatesRepresentation_GetHoverString_14(HandleRef pThis, HandleRef view, int x, int y);

	/// <summary>
	/// Returns the hover text at an x,y location.
	/// </summary>
	public virtual string GetHoverString(vtkView view, int x, int y)
	{
		return vtkParallelCoordinatesRepresentation_GetHoverString_14(GetCppThis(), view?.GetCppThis() ?? default(HandleRef), x, y);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesRepresentation_GetLineColor_15(HandleRef pThis);

	/// <summary>
	/// Access plot properties
	/// </summary>
	public virtual double[] GetLineColor()
	{
		IntPtr intPtr = vtkParallelCoordinatesRepresentation_GetLineColor_15(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_GetLineColor_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Access plot properties
	/// </summary>
	public virtual void GetLineColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkParallelCoordinatesRepresentation_GetLineColor_16(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_GetLineColor_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Access plot properties
	/// </summary>
	public virtual void GetLineColor(IntPtr _arg)
	{
		vtkParallelCoordinatesRepresentation_GetLineColor_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParallelCoordinatesRepresentation_GetLineOpacity_18(HandleRef pThis);

	/// <summary>
	/// Access plot properties
	/// </summary>
	public virtual double GetLineOpacity()
	{
		return vtkParallelCoordinatesRepresentation_GetLineOpacity_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesRepresentation_GetNumberOfAxes_19(HandleRef pThis);

	/// <summary>
	/// Get the number of axes in the plot
	/// </summary>
	public virtual int GetNumberOfAxes()
	{
		return vtkParallelCoordinatesRepresentation_GetNumberOfAxes_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesRepresentation_GetNumberOfAxisLabels_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of labels to display on each axis
	/// </summary>
	public virtual int GetNumberOfAxisLabels()
	{
		return vtkParallelCoordinatesRepresentation_GetNumberOfAxisLabels_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParallelCoordinatesRepresentation_GetNumberOfGenerationsFromBase_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkParallelCoordinatesRepresentation_GetNumberOfGenerationsFromBase_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParallelCoordinatesRepresentation_GetNumberOfGenerationsFromBaseType_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkParallelCoordinatesRepresentation_GetNumberOfGenerationsFromBaseType_22(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesRepresentation_GetNumberOfSamples_23(HandleRef pThis);

	/// <summary>
	/// Get the number of samples in the plot
	/// </summary>
	public virtual int GetNumberOfSamples()
	{
		return vtkParallelCoordinatesRepresentation_GetNumberOfSamples_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesRepresentation_GetPositionAndSize_24(HandleRef pThis, IntPtr position, IntPtr size);

	/// <summary>
	/// Change the position of the plot
	/// </summary>
	public int GetPositionAndSize(IntPtr position, IntPtr size)
	{
		return vtkParallelCoordinatesRepresentation_GetPositionAndSize_24(GetCppThis(), position, size);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesRepresentation_GetPositionNearXCoordinate_25(HandleRef pThis, double xcoord);

	/// <summary>
	/// Move an axis to a particular screen position.  Using these
	/// methods requires an Update() before they will work properly.
	/// </summary>
	public int GetPositionNearXCoordinate(double xcoord)
	{
		return vtkParallelCoordinatesRepresentation_GetPositionNearXCoordinate_25(GetCppThis(), xcoord);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesRepresentation_GetRangeAtPosition_26(HandleRef pThis, int position, IntPtr range);

	/// <summary>
	/// Set/get the value range of the axis at a particular screen position
	/// </summary>
	public int GetRangeAtPosition(int position, IntPtr range)
	{
		return vtkParallelCoordinatesRepresentation_GetRangeAtPosition_26(GetCppThis(), position, range);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesRepresentation_GetUseCurves_27(HandleRef pThis);

	/// <summary>
	/// Whether or not to display using curves
	/// </summary>
	public virtual int GetUseCurves()
	{
		return vtkParallelCoordinatesRepresentation_GetUseCurves_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParallelCoordinatesRepresentation_GetXCoordinateOfPosition_28(HandleRef pThis, int axis);

	/// <summary>
	/// Move an axis to a particular screen position.  Using these
	/// methods requires an Update() before they will work properly.
	/// </summary>
	public double GetXCoordinateOfPosition(int axis)
	{
		return vtkParallelCoordinatesRepresentation_GetXCoordinateOfPosition_28(GetCppThis(), axis);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_GetXCoordinatesOfPositions_29(HandleRef pThis, IntPtr coords);

	/// <summary>
	/// Move an axis to a particular screen position.  Using these
	/// methods requires an Update() before they will work properly.
	/// </summary>
	public void GetXCoordinatesOfPositions(IntPtr coords)
	{
		vtkParallelCoordinatesRepresentation_GetXCoordinatesOfPositions_29(GetCppThis(), coords);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesRepresentation_IsA_30(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkParallelCoordinatesRepresentation_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesRepresentation_IsTypeOf_31(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkParallelCoordinatesRepresentation_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_LassoSelect_32(HandleRef pThis, int brushClass, int brushOperator, HandleRef brushPoints);

	/// <summary>
	/// Do a selection of the lines.  See the main description for how to use these functions.
	/// RangeSelect is currently stubbed out.
	/// </summary>
	public virtual void LassoSelect(int brushClass, int brushOperator, vtkPoints brushPoints)
	{
		vtkParallelCoordinatesRepresentation_LassoSelect_32(GetCppThis(), brushClass, brushOperator, brushPoints?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesRepresentation_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkParallelCoordinatesRepresentation NewInstance()
	{
		vtkParallelCoordinatesRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelCoordinatesRepresentation_NewInstance_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParallelCoordinatesRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_RangeSelect_35(HandleRef pThis, int brushClass, int brushOperator, IntPtr p1, IntPtr p2);

	/// <summary>
	/// Do a selection of the lines.  See the main description for how to use these functions.
	/// RangeSelect is currently stubbed out.
	/// </summary>
	public virtual void RangeSelect(int brushClass, int brushOperator, IntPtr p1, IntPtr p2)
	{
		vtkParallelCoordinatesRepresentation_RangeSelect_35(GetCppThis(), brushClass, brushOperator, p1, p2);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_ResetAxes_36(HandleRef pThis);

	/// <summary>
	/// Reset the axes to their default positions and orders
	/// </summary>
	public void ResetAxes()
	{
		vtkParallelCoordinatesRepresentation_ResetAxes_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesRepresentation_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParallelCoordinatesRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkParallelCoordinatesRepresentation vtkParallelCoordinatesRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelCoordinatesRepresentation_SafeDownCast_37(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParallelCoordinatesRepresentation2 = (vtkParallelCoordinatesRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParallelCoordinatesRepresentation2.Register(null);
			}
		}
		return vtkParallelCoordinatesRepresentation2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_SetAngleBrushThreshold_38(HandleRef pThis, double _arg);

	/// <summary>
	/// Maximum angle difference (in degrees) of selection using angle/function brushes
	/// </summary>
	public virtual void SetAngleBrushThreshold(double _arg)
	{
		vtkParallelCoordinatesRepresentation_SetAngleBrushThreshold_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_SetAxisColor_39(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Access plot properties
	/// </summary>
	public virtual void SetAxisColor(double _arg1, double _arg2, double _arg3)
	{
		vtkParallelCoordinatesRepresentation_SetAxisColor_39(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_SetAxisColor_40(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Access plot properties
	/// </summary>
	public virtual void SetAxisColor(IntPtr _arg)
	{
		vtkParallelCoordinatesRepresentation_SetAxisColor_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_SetAxisLabelColor_41(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Access plot properties
	/// </summary>
	public virtual void SetAxisLabelColor(double _arg1, double _arg2, double _arg3)
	{
		vtkParallelCoordinatesRepresentation_SetAxisLabelColor_41(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_SetAxisLabelColor_42(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Access plot properties
	/// </summary>
	public virtual void SetAxisLabelColor(IntPtr _arg)
	{
		vtkParallelCoordinatesRepresentation_SetAxisLabelColor_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_SetAxisTitles_43(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the axis titles
	/// </summary>
	public void SetAxisTitles(vtkStringArray arg0)
	{
		vtkParallelCoordinatesRepresentation_SetAxisTitles_43(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_SetAxisTitles_44(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the axis titles
	/// </summary>
	public void SetAxisTitles(vtkAlgorithmOutput arg0)
	{
		vtkParallelCoordinatesRepresentation_SetAxisTitles_44(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_SetCurveResolution_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Resolution of the curves displayed, enabled by setting UseCurves
	/// </summary>
	public virtual void SetCurveResolution(int _arg)
	{
		vtkParallelCoordinatesRepresentation_SetCurveResolution_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_SetFontSize_46(HandleRef pThis, double _arg);

	/// <summary>
	/// Access plot properties
	/// </summary>
	public virtual void SetFontSize(double _arg)
	{
		vtkParallelCoordinatesRepresentation_SetFontSize_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_SetFunctionBrushThreshold_47(HandleRef pThis, double _arg);

	/// <summary>
	/// Maximum angle difference (in degrees) of selection using angle/function brushes
	/// </summary>
	public virtual void SetFunctionBrushThreshold(double _arg)
	{
		vtkParallelCoordinatesRepresentation_SetFunctionBrushThreshold_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_SetLineColor_48(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Access plot properties
	/// </summary>
	public virtual void SetLineColor(double _arg1, double _arg2, double _arg3)
	{
		vtkParallelCoordinatesRepresentation_SetLineColor_48(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_SetLineColor_49(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Access plot properties
	/// </summary>
	public virtual void SetLineColor(IntPtr _arg)
	{
		vtkParallelCoordinatesRepresentation_SetLineColor_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_SetLineOpacity_50(HandleRef pThis, double _arg);

	/// <summary>
	/// Access plot properties
	/// </summary>
	public virtual void SetLineOpacity(double _arg)
	{
		vtkParallelCoordinatesRepresentation_SetLineOpacity_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_SetNumberOfAxisLabels_51(HandleRef pThis, int num);

	/// <summary>
	/// Set/Get the number of labels to display on each axis
	/// </summary>
	public void SetNumberOfAxisLabels(int num)
	{
		vtkParallelCoordinatesRepresentation_SetNumberOfAxisLabels_51(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_SetPlotTitle_52(HandleRef pThis, string arg0);

	/// <summary>
	/// Set the title for the entire plot
	/// </summary>
	public void SetPlotTitle(string arg0)
	{
		vtkParallelCoordinatesRepresentation_SetPlotTitle_52(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesRepresentation_SetPositionAndSize_53(HandleRef pThis, IntPtr position, IntPtr size);

	/// <summary>
	/// Change the position of the plot
	/// </summary>
	public int SetPositionAndSize(IntPtr position, IntPtr size)
	{
		return vtkParallelCoordinatesRepresentation_SetPositionAndSize_53(GetCppThis(), position, size);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesRepresentation_SetRangeAtPosition_54(HandleRef pThis, int position, IntPtr range);

	/// <summary>
	/// Set/get the value range of the axis at a particular screen position
	/// </summary>
	public virtual int SetRangeAtPosition(int position, IntPtr range)
	{
		return vtkParallelCoordinatesRepresentation_SetRangeAtPosition_54(GetCppThis(), position, range);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_SetUseCurves_55(HandleRef pThis, int _arg);

	/// <summary>
	/// Whether or not to display using curves
	/// </summary>
	public virtual void SetUseCurves(int _arg)
	{
		vtkParallelCoordinatesRepresentation_SetUseCurves_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesRepresentation_SetXCoordinateOfPosition_56(HandleRef pThis, int position, double xcoord);

	/// <summary>
	/// Move an axis to a particular screen position.  Using these
	/// methods requires an Update() before they will work properly.
	/// </summary>
	public int SetXCoordinateOfPosition(int position, double xcoord)
	{
		return vtkParallelCoordinatesRepresentation_SetXCoordinateOfPosition_56(GetCppThis(), position, xcoord);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesRepresentation_SwapAxisPositions_57(HandleRef pThis, int position1, int position2);

	/// <summary>
	/// Move an axis to a particular screen position.  Using these
	/// methods requires an Update() before they will work properly.
	/// </summary>
	public virtual int SwapAxisPositions(int position1, int position2)
	{
		return vtkParallelCoordinatesRepresentation_SwapAxisPositions_57(GetCppThis(), position1, position2);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_UseCurvesOff_58(HandleRef pThis);

	/// <summary>
	/// Whether or not to display using curves
	/// </summary>
	public virtual void UseCurvesOff()
	{
		vtkParallelCoordinatesRepresentation_UseCurvesOff_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesRepresentation_UseCurvesOn_59(HandleRef pThis);

	/// <summary>
	/// Whether or not to display using curves
	/// </summary>
	public virtual void UseCurvesOn()
	{
		vtkParallelCoordinatesRepresentation_UseCurvesOn_59(GetCppThis());
	}
}
