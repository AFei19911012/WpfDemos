using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkChartXYZ
/// </summary>
/// <remarks>
///    Factory class for drawing 3D XYZ charts.
///
///
/// </remarks>
public class vtkChartXYZ : vtkContextItem
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkChartXYZ";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkChartXYZ()
	{
		MRClassNameKey = "class vtkChartXYZ";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkChartXYZ"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkChartXYZ(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartXYZ_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkChartXYZ New()
	{
		vtkChartXYZ result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartXYZ_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkChartXYZ)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkChartXYZ()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkChartXYZ_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkChartXYZ_AddPlot_01(HandleRef pThis, HandleRef plot);

	/// <summary>
	/// Adds a plot to the chart.
	/// </summary>
	public virtual long AddPlot(vtkPlot3D plot)
	{
		return vtkChartXYZ_AddPlot_01(GetCppThis(), plot?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXYZ_ClearPlots_02(HandleRef pThis);

	/// <summary>
	/// Remove all the plots from this chart.
	/// </summary>
	public void ClearPlots()
	{
		vtkChartXYZ_ClearPlots_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartXYZ_GetAxesTextProperty_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the text property for axes. Useful for changing font size, font family, font file.
	///
	/// For example to use a larger font which is capable of displaying unicode values change
	/// the property like this:
	///
	///   chart-&gt;GetAxesTextProperty()-&gt;SetFontFamily(VTK_FONT_FILE);
	///   chart-&gt;GetAxesTextProperty()-&gt;SetFontFile("fonts/DejaVuSans.ttf");
	///   chart-&gt;GetAxesTextProperty()-&gt;SetFontSize(32);
	///
	/// You'll need a unicode capable font in a suitable location.
	///
	/// Now to get the X axis to display Theta subscript (0) set the label like this using
	/// the hex unicode representation:
	///
	///   chart-&gt;SetXAxisLabel("\xcf\xb4\xe2\x82\x8d\xe2\x82\x80\xe2\x82\x8e");
	///
	/// @return
	/// </summary>
	public vtkTextProperty GetAxesTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartXYZ_GetAxesTextProperty_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkChartXYZ_GetAxis_04(HandleRef pThis, int axis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the x (0), y (1) or z (2) axis.
	/// </summary>
	public vtkAxis GetAxis(int axis)
	{
		vtkAxis vtkAxis2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartXYZ_GetAxis_04(GetCppThis(), axis, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkChartXYZ_GetAxisColor_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the color for the axes.
	/// </summary>
	public vtkColor4ub GetAxisColor()
	{
		vtkColor4ub result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartXYZ_GetAxisColor_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColor4ub)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartXYZ_GetClippingPlanesEnabled_06(HandleRef pThis);

	/// <summary>
	/// Check whether data outside the box will be hidden or not.
	/// </summary>
	public virtual bool GetClippingPlanesEnabled()
	{
		return (vtkChartXYZ_GetClippingPlanesEnabled_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartXYZ_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkChartXYZ_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartXYZ_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkChartXYZ_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartXYZ_GetScaleBoxWithPlot_09(HandleRef pThis);

	/// <summary>
	/// Check whether scaling the plot will also scale the box.
	/// </summary>
	public virtual bool GetScaleBoxWithPlot()
	{
		return (vtkChartXYZ_GetScaleBoxWithPlot_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChartXYZ_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkChartXYZ_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChartXYZ_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkChartXYZ_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartXYZ_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkChartXYZ NewInstance()
	{
		vtkChartXYZ result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartXYZ_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkChartXYZ)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartXYZ_Paint_14(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the chart, called whenever the chart needs to be drawn.
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkChartXYZ_Paint_14(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXYZ_RecalculateBounds_15(HandleRef pThis);

	/// <summary>
	/// Determine the XYZ bounds of the plots within this chart.
	/// This information is then used to set the range of the axes.
	/// </summary>
	public void RecalculateBounds()
	{
		vtkChartXYZ_RecalculateBounds_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXYZ_RecalculateTransform_16(HandleRef pThis);

	/// <summary>
	/// Use this chart's Geometry to set the endpoints of its axes.
	/// This method also sets up a transformation that is used to
	/// properly render the data within the chart.
	/// </summary>
	public void RecalculateTransform()
	{
		vtkChartXYZ_RecalculateTransform_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartXYZ_RemovePlot_17(HandleRef pThis, HandleRef plot);

	/// <summary>
	/// Removes a plot from the chart.
	/// </summary>
	public virtual bool RemovePlot(vtkPlot3D plot)
	{
		return (vtkChartXYZ_RemovePlot_17(GetCppThis(), plot?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartXYZ_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkChartXYZ SafeDownCast(vtkObjectBase o)
	{
		vtkChartXYZ vtkChartXYZ2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartXYZ_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkChartXYZ2 = (vtkChartXYZ)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkChartXYZ2.Register(null);
			}
		}
		return vtkChartXYZ2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXYZ_SetAngle_19(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the rotation angle for the chart (AutoRotate mode only).
	/// </summary>
	public virtual void SetAngle(double _arg)
	{
		vtkChartXYZ_SetAngle_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXYZ_SetAnnotationLink_20(HandleRef pThis, HandleRef link);

	/// <summary>
	/// Set the vtkAnnotationLink for the chart.
	/// </summary>
	public virtual void SetAnnotationLink(vtkAnnotationLink link)
	{
		vtkChartXYZ_SetAnnotationLink_20(GetCppThis(), link?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXYZ_SetAroundX_21(HandleRef pThis, byte isX);

	/// <summary>
	/// Set whether or not we're rotating about the X axis.
	/// </summary>
	public void SetAroundX(bool isX)
	{
		vtkChartXYZ_SetAroundX_21(GetCppThis(), (byte)(isX ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXYZ_SetAutoRotate_22(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set whether or not we're using this chart to rotate on a timer.
	/// Default value is false.
	/// </summary>
	public virtual void SetAutoRotate(bool _arg)
	{
		vtkChartXYZ_SetAutoRotate_22(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXYZ_SetAxis_23(HandleRef pThis, int axisIndex, HandleRef axis);

	/// <summary>
	/// Set the x (0), y (1) or z (2) axis.
	/// </summary>
	public virtual void SetAxis(int axisIndex, vtkAxis axis)
	{
		vtkChartXYZ_SetAxis_23(GetCppThis(), axisIndex, axis?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXYZ_SetAxisColor_24(HandleRef pThis, HandleRef color);

	/// <summary>
	/// Set the color for the axes.
	/// </summary>
	public void SetAxisColor(vtkColor4ub color)
	{
		vtkChartXYZ_SetAxisColor_24(GetCppThis(), color?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXYZ_SetClippingPlanesEnabled_25(HandleRef pThis, byte arg0);

	/// <summary>
	/// Hide data outside the box.
	/// </summary>
	public void SetClippingPlanesEnabled(bool arg0)
	{
		vtkChartXYZ_SetClippingPlanesEnabled_25(GetCppThis(), (byte)(arg0 ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXYZ_SetDecorateAxes_26(HandleRef pThis, byte b);

	/// <summary>
	/// Set whether or not axes labels &amp; tick marks should be drawn.
	/// Default value is true.
	/// </summary>
	public void SetDecorateAxes(bool b)
	{
		vtkChartXYZ_SetDecorateAxes_26(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXYZ_SetEnsureOuterEdgeAxisLabelling_27(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set to true to ensure that axis labels are always on the outer edges of the chart.
	/// Default is false, the legacy behaviour, for backwards compatibility, where axis
	/// labelling may occur on inner or back edges.
	/// </summary>
	public virtual void SetEnsureOuterEdgeAxisLabelling(bool _arg)
	{
		vtkChartXYZ_SetEnsureOuterEdgeAxisLabelling_27(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXYZ_SetFitToScene_28(HandleRef pThis, byte b);

	/// <summary>
	/// Set whether or not the chart should automatically resize itself to fill
	/// the scene.  Default value is true.
	/// </summary>
	public void SetFitToScene(bool b)
	{
		vtkChartXYZ_SetFitToScene_28(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXYZ_SetGeometry_29(HandleRef pThis, HandleRef bounds);

	/// <summary>
	/// Set the geometry in pixel coordinates (origin and width/height).
	/// This method also sets up the end points of the axes of the chart.
	/// For this reason, if you call SetAroundX(), you should call SetGeometry()
	/// afterwards.
	///
	/// This method will result in a plot with a fixed size. If you want it to scale
	/// with the scene then use SetMargins.
	/// </summary>
	public void SetGeometry(vtkRectf bounds)
	{
		vtkChartXYZ_SetGeometry_29(GetCppThis(), bounds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXYZ_SetMargins_30(HandleRef pThis, vtkVector4i margins);

	/// <summary>
	/// Set the margins in pixels ordered top right bottom left
	/// The box will be drawn inside those margins, but the labels and textdecorations will still
	/// escape. Note that the width and height automatically adapt to those of the scene.
	///
	/// If you want a fixed size instead then use SetGeometry.
	/// </summary>
	public void SetMargins(vtkVector4i margins)
	{
		vtkChartXYZ_SetMargins_30(GetCppThis(), margins);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXYZ_SetScaleBoxWithPlot_31(HandleRef pThis, byte _arg);

	/// <summary>
	/// When rotating the mousewheel, scale not only the plot but also the box.
	/// </summary>
	public virtual void SetScaleBoxWithPlot(bool _arg)
	{
		vtkChartXYZ_SetScaleBoxWithPlot_31(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXYZ_SetXAxisLabel_32(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the X axis label
	/// </summary>
	public virtual void SetXAxisLabel(string _arg)
	{
		vtkChartXYZ_SetXAxisLabel_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXYZ_SetYAxisLabel_33(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the Y axis label
	/// </summary>
	public virtual void SetYAxisLabel(string _arg)
	{
		vtkChartXYZ_SetYAxisLabel_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXYZ_SetZAxisLabel_34(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the Z axis label
	/// </summary>
	public virtual void SetZAxisLabel(string _arg)
	{
		vtkChartXYZ_SetZAxisLabel_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartXYZ_Update_35(HandleRef pThis);

	/// <summary>
	/// Perform any updates to the item that may be necessary before rendering.
	/// </summary>
	public override void Update()
	{
		vtkChartXYZ_Update_35(GetCppThis());
	}
}
