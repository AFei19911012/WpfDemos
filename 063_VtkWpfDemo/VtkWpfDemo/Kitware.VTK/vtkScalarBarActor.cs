using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkScalarBarActor
/// </summary>
/// <remarks>
///    Create a scalar bar with labels
///
/// vtkScalarBarActor creates a scalar bar with tick marks. A scalar
/// bar is a legend that indicates to the viewer the correspondence between
/// color value and data value. The legend consists of a rectangular bar
/// made of rectangular pieces each colored a constant value. Since
/// vtkScalarBarActor is a subclass of vtkActor2D, it is drawn in the image
/// plane (i.e., in the renderer's viewport) on top of the 3D graphics window.
///
/// To use vtkScalarBarActor you must associate a vtkScalarsToColors (or
/// subclass) with it. The lookup table defines the colors and the
/// range of scalar values used to map scalar data.  Typically, the
/// number of colors shown in the scalar bar is not equal to the number
/// of colors in the lookup table, in which case sampling of
/// the lookup table is performed.
///
/// Other optional capabilities include specifying the fraction of the
/// viewport size (both x and y directions) which will control the size
/// of the scalar bar and the number of tick labels. The actual position
/// of the scalar bar on the screen is controlled by using the
/// vtkActor2D::SetPosition() method (by default the scalar bar is
/// centered in the viewport).  Other features include the ability to
/// orient the scalar bar horizontally of vertically and controlling
/// the format (printf style) with which to print the labels on the
/// scalar bar. Also, the vtkScalarBarActor's property is applied to
/// the scalar bar and annotations (including layer, and
/// compositing operator).
///
/// Set the text property/attributes of the title and the labels through the
/// vtkTextProperty objects associated to this actor.
///
/// @warning
/// If a vtkLogLookupTable is specified as the lookup table to use, then the
/// labels are created using a logarithmic scale.
///
/// </remarks>
/// <seealso>
///
/// vtkActor2D vtkTextProperty vtkTextMapper vtkPolyDataMapper2D
/// </seealso>
public class vtkScalarBarActor : vtkActor2D
{
	/// <summary>
	/// Get the texture actor.. you may want to change some properties on it
	/// </summary>
	public enum PrecedeScalarBar_WrapperEnum
	{
		/// <summary>enum member</summary>
		PrecedeScalarBar,
		/// <summary>enum member</summary>
		SucceedScalarBar
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkScalarBarActor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkScalarBarActor()
	{
		MRClassNameKey = "class vtkScalarBarActor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkScalarBarActor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkScalarBarActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with 64 maximum colors; 5 labels; %%-#6.3g label
	/// format, no title, and vertical orientation. The initial scalar bar
	/// size is (0.05 x 0.8) of the viewport size.
	/// </summary>
	public new static vtkScalarBarActor New()
	{
		vtkScalarBarActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarBarActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkScalarBarActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object with 64 maximum colors; 5 labels; %%-#6.3g label
	/// format, no title, and vertical orientation. The initial scalar bar
	/// size is (0.05 x 0.8) of the viewport size.
	/// </summary>
	public vtkScalarBarActor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkScalarBarActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_AnnotationTextScalingOff_01(HandleRef pThis);

	/// <summary>
	/// Set/get whether annotation labels should be scaled with the viewport.
	///
	/// The default value is 0 (no scaling).
	/// If non-zero, the vtkTextActor instances used to render annotation
	/// labels will have their TextScaleMode set to viewport-based scaling,
	/// which nonlinearly scales font size with the viewport size.
	/// </summary>
	public virtual void AnnotationTextScalingOff()
	{
		vtkScalarBarActor_AnnotationTextScalingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_AnnotationTextScalingOn_02(HandleRef pThis);

	/// <summary>
	/// Set/get whether annotation labels should be scaled with the viewport.
	///
	/// The default value is 0 (no scaling).
	/// If non-zero, the vtkTextActor instances used to render annotation
	/// labels will have their TextScaleMode set to viewport-based scaling,
	/// which nonlinearly scales font size with the viewport size.
	/// </summary>
	public virtual void AnnotationTextScalingOn()
	{
		vtkScalarBarActor_AnnotationTextScalingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_DrawAboveRangeSwatchOff_03(HandleRef pThis);

	/// <summary>
	/// Set/get whether the Above range swatch should be rendered or not.
	/// This only affects rendering when \a DrawAnnotations is true.
	/// The default is false.
	/// </summary>
	public virtual void DrawAboveRangeSwatchOff()
	{
		vtkScalarBarActor_DrawAboveRangeSwatchOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_DrawAboveRangeSwatchOn_04(HandleRef pThis);

	/// <summary>
	/// Set/get whether the Above range swatch should be rendered or not.
	/// This only affects rendering when \a DrawAnnotations is true.
	/// The default is false.
	/// </summary>
	public virtual void DrawAboveRangeSwatchOn()
	{
		vtkScalarBarActor_DrawAboveRangeSwatchOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_DrawAnnotationsOff_05(HandleRef pThis);

	/// <summary>
	/// Set/get whether text annotations should be rendered or not.
	/// Currently, this only affects rendering when \a IndexedLookup is true.
	/// The default is true.
	/// </summary>
	public virtual void DrawAnnotationsOff()
	{
		vtkScalarBarActor_DrawAnnotationsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_DrawAnnotationsOn_06(HandleRef pThis);

	/// <summary>
	/// Set/get whether text annotations should be rendered or not.
	/// Currently, this only affects rendering when \a IndexedLookup is true.
	/// The default is true.
	/// </summary>
	public virtual void DrawAnnotationsOn()
	{
		vtkScalarBarActor_DrawAnnotationsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_DrawBackgroundOff_07(HandleRef pThis);

	/// <summary>
	/// Set/Get whether a background should be drawn around the scalar bar.
	/// Default is off.
	/// </summary>
	public virtual void DrawBackgroundOff()
	{
		vtkScalarBarActor_DrawBackgroundOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_DrawBackgroundOn_08(HandleRef pThis);

	/// <summary>
	/// Set/Get whether a background should be drawn around the scalar bar.
	/// Default is off.
	/// </summary>
	public virtual void DrawBackgroundOn()
	{
		vtkScalarBarActor_DrawBackgroundOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_DrawBelowRangeSwatchOff_09(HandleRef pThis);

	/// <summary>
	/// Set/get whether the Below range swatch should be rendered or not.
	/// This only affects rendering when \a DrawAnnotations is true.
	/// The default is false.
	/// </summary>
	public virtual void DrawBelowRangeSwatchOff()
	{
		vtkScalarBarActor_DrawBelowRangeSwatchOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_DrawBelowRangeSwatchOn_10(HandleRef pThis);

	/// <summary>
	/// Set/get whether the Below range swatch should be rendered or not.
	/// This only affects rendering when \a DrawAnnotations is true.
	/// The default is false.
	/// </summary>
	public virtual void DrawBelowRangeSwatchOn()
	{
		vtkScalarBarActor_DrawBelowRangeSwatchOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_DrawColorBarOff_11(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the color bar should be drawn. If off, only the tickmarks
	/// and text will be drawn. Default is on.
	/// </summary>
	public virtual void DrawColorBarOff()
	{
		vtkScalarBarActor_DrawColorBarOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_DrawColorBarOn_12(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the color bar should be drawn. If off, only the tickmarks
	/// and text will be drawn. Default is on.
	/// </summary>
	public virtual void DrawColorBarOn()
	{
		vtkScalarBarActor_DrawColorBarOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_DrawFrameOff_13(HandleRef pThis);

	/// <summary>
	/// Set/Get whether a frame should be drawn around the scalar bar.
	/// Default is off.
	/// </summary>
	public virtual void DrawFrameOff()
	{
		vtkScalarBarActor_DrawFrameOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_DrawFrameOn_14(HandleRef pThis);

	/// <summary>
	/// Set/Get whether a frame should be drawn around the scalar bar.
	/// Default is off.
	/// </summary>
	public virtual void DrawFrameOn()
	{
		vtkScalarBarActor_DrawFrameOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_DrawNanAnnotationOff_15(HandleRef pThis);

	/// <summary>
	/// Set/get whether the NaN annotation should be rendered or not.
	/// This only affects rendering when \a DrawAnnotations is true.
	/// The default is false.
	/// </summary>
	public virtual void DrawNanAnnotationOff()
	{
		vtkScalarBarActor_DrawNanAnnotationOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_DrawNanAnnotationOn_16(HandleRef pThis);

	/// <summary>
	/// Set/get whether the NaN annotation should be rendered or not.
	/// This only affects rendering when \a DrawAnnotations is true.
	/// The default is false.
	/// </summary>
	public virtual void DrawNanAnnotationOn()
	{
		vtkScalarBarActor_DrawNanAnnotationOn_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_DrawTickLabelsOff_17(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the tick labels should be drawn. Default is on.
	/// </summary>
	public virtual void DrawTickLabelsOff()
	{
		vtkScalarBarActor_DrawTickLabelsOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_DrawTickLabelsOn_18(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the tick labels should be drawn. Default is on.
	/// </summary>
	public virtual void DrawTickLabelsOn()
	{
		vtkScalarBarActor_DrawTickLabelsOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_FixedAnnotationLeaderLineColorOff_19(HandleRef pThis);

	/// <summary>
	/// Set/get how leader lines connecting annotations to values should be colored.
	///
	/// When true, leader lines are all the same color (and match the LabelTextProperty color).
	/// When false, leader lines take on the color of the value they correspond to.
	/// This only affects rendering when \a DrawAnnotations is true.
	/// The default is false.
	/// </summary>
	public virtual void FixedAnnotationLeaderLineColorOff()
	{
		vtkScalarBarActor_FixedAnnotationLeaderLineColorOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_FixedAnnotationLeaderLineColorOn_20(HandleRef pThis);

	/// <summary>
	/// Set/get how leader lines connecting annotations to values should be colored.
	///
	/// When true, leader lines are all the same color (and match the LabelTextProperty color).
	/// When false, leader lines take on the color of the value they correspond to.
	/// This only affects rendering when \a DrawAnnotations is true.
	/// The default is false.
	/// </summary>
	public virtual void FixedAnnotationLeaderLineColorOn()
	{
		vtkScalarBarActor_FixedAnnotationLeaderLineColorOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarActor_GetAboveRangeAnnotation_21(HandleRef pThis);

	/// <summary>
	/// Set/get the annotation text for "Above Range Swatch" values.
	/// </summary>
	public virtual string GetAboveRangeAnnotation()
	{
		return Marshal.PtrToStringAnsi(vtkScalarBarActor_GetAboveRangeAnnotation_21(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScalarBarActor_GetAnnotationLeaderPadding_22(HandleRef pThis);

	/// <summary>
	/// Set/get the padding between the scalar bar and the text annotations.
	/// This space is used to draw leader lines.
	/// The default is 8 pixels.
	/// </summary>
	public virtual double GetAnnotationLeaderPadding()
	{
		return vtkScalarBarActor_GetAnnotationLeaderPadding_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarActor_GetAnnotationTextProperty_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the annotation text property.
	/// </summary>
	public virtual vtkTextProperty GetAnnotationTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarBarActor_GetAnnotationTextProperty_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetAnnotationTextScaling_24(HandleRef pThis);

	/// <summary>
	/// Set/get whether annotation labels should be scaled with the viewport.
	///
	/// The default value is 0 (no scaling).
	/// If non-zero, the vtkTextActor instances used to render annotation
	/// labels will have their TextScaleMode set to viewport-based scaling,
	/// which nonlinearly scales font size with the viewport size.
	/// </summary>
	public virtual int GetAnnotationTextScaling()
	{
		return vtkScalarBarActor_GetAnnotationTextScaling_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarActor_GetBackgroundProperty_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the background property.
	/// </summary>
	public virtual vtkProperty2D GetBackgroundProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarBarActor_GetBackgroundProperty_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2D2 = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2D2.Register(null);
			}
		}
		return vtkProperty2D2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScalarBarActor_GetBarRatio_26(HandleRef pThis);

	/// <summary>
	/// Set/get the thickness of the color bar relative to the widget frame.
	/// The default is 0.375 and must always be in the range ]0, 1[.
	/// </summary>
	public virtual double GetBarRatio()
	{
		return vtkScalarBarActor_GetBarRatio_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScalarBarActor_GetBarRatioMaxValue_27(HandleRef pThis);

	/// <summary>
	/// Set/get the thickness of the color bar relative to the widget frame.
	/// The default is 0.375 and must always be in the range ]0, 1[.
	/// </summary>
	public virtual double GetBarRatioMaxValue()
	{
		return vtkScalarBarActor_GetBarRatioMaxValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScalarBarActor_GetBarRatioMinValue_28(HandleRef pThis);

	/// <summary>
	/// Set/get the thickness of the color bar relative to the widget frame.
	/// The default is 0.375 and must always be in the range ]0, 1[.
	/// </summary>
	public virtual double GetBarRatioMinValue()
	{
		return vtkScalarBarActor_GetBarRatioMinValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarActor_GetBelowRangeAnnotation_29(HandleRef pThis);

	/// <summary>
	/// Set/get the annotation text for "Below Range" values.
	/// </summary>
	public virtual string GetBelowRangeAnnotation()
	{
		return Marshal.PtrToStringAnsi(vtkScalarBarActor_GetBelowRangeAnnotation_29(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarActor_GetComponentTitle_30(HandleRef pThis);

	/// <summary>
	/// Set/Get the title for the component that is selected,
	/// </summary>
	public virtual string GetComponentTitle()
	{
		return Marshal.PtrToStringAnsi(vtkScalarBarActor_GetComponentTitle_30(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarActor_GetCustomLabels_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the fixed locations to use.
	/// </summary>
	public virtual vtkDoubleArray GetCustomLabels()
	{
		vtkDoubleArray vtkDoubleArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarBarActor_GetCustomLabels_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDoubleArray2 = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDoubleArray2.Register(null);
			}
		}
		return vtkDoubleArray2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkScalarBarActor_GetDrawAboveRangeSwatch_32(HandleRef pThis);

	/// <summary>
	/// Set/get whether the Above range swatch should be rendered or not.
	/// This only affects rendering when \a DrawAnnotations is true.
	/// The default is false.
	/// </summary>
	public virtual bool GetDrawAboveRangeSwatch()
	{
		return (vtkScalarBarActor_GetDrawAboveRangeSwatch_32(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetDrawAnnotations_33(HandleRef pThis);

	/// <summary>
	/// Set/get whether text annotations should be rendered or not.
	/// Currently, this only affects rendering when \a IndexedLookup is true.
	/// The default is true.
	/// </summary>
	public virtual int GetDrawAnnotations()
	{
		return vtkScalarBarActor_GetDrawAnnotations_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetDrawBackground_34(HandleRef pThis);

	/// <summary>
	/// Set/Get whether a background should be drawn around the scalar bar.
	/// Default is off.
	/// </summary>
	public virtual int GetDrawBackground()
	{
		return vtkScalarBarActor_GetDrawBackground_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkScalarBarActor_GetDrawBelowRangeSwatch_35(HandleRef pThis);

	/// <summary>
	/// Set/get whether the Below range swatch should be rendered or not.
	/// This only affects rendering when \a DrawAnnotations is true.
	/// The default is false.
	/// </summary>
	public virtual bool GetDrawBelowRangeSwatch()
	{
		return (vtkScalarBarActor_GetDrawBelowRangeSwatch_35(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetDrawColorBar_36(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the color bar should be drawn. If off, only the tickmarks
	/// and text will be drawn. Default is on.
	/// </summary>
	public virtual int GetDrawColorBar()
	{
		return vtkScalarBarActor_GetDrawColorBar_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetDrawFrame_37(HandleRef pThis);

	/// <summary>
	/// Set/Get whether a frame should be drawn around the scalar bar.
	/// Default is off.
	/// </summary>
	public virtual int GetDrawFrame()
	{
		return vtkScalarBarActor_GetDrawFrame_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetDrawNanAnnotation_38(HandleRef pThis);

	/// <summary>
	/// Set/get whether the NaN annotation should be rendered or not.
	/// This only affects rendering when \a DrawAnnotations is true.
	/// The default is false.
	/// </summary>
	public virtual int GetDrawNanAnnotation()
	{
		return vtkScalarBarActor_GetDrawNanAnnotation_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetDrawTickLabels_39(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the tick labels should be drawn. Default is on.
	/// </summary>
	public virtual int GetDrawTickLabels()
	{
		return vtkScalarBarActor_GetDrawTickLabels_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetFixedAnnotationLeaderLineColor_40(HandleRef pThis);

	/// <summary>
	/// Set/get how leader lines connecting annotations to values should be colored.
	///
	/// When true, leader lines are all the same color (and match the LabelTextProperty color).
	/// When false, leader lines take on the color of the value they correspond to.
	/// This only affects rendering when \a DrawAnnotations is true.
	/// The default is false.
	/// </summary>
	public virtual int GetFixedAnnotationLeaderLineColor()
	{
		return vtkScalarBarActor_GetFixedAnnotationLeaderLineColor_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarActor_GetFrameProperty_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the frame property.
	/// </summary>
	public virtual vtkProperty2D GetFrameProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarBarActor_GetFrameProperty_41(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2D2 = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2D2.Register(null);
			}
		}
		return vtkProperty2D2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarActor_GetLabelFormat_42(HandleRef pThis);

	/// <summary>
	/// Set/Get the format with which to print the labels on the scalar
	/// bar.
	/// </summary>
	public virtual string GetLabelFormat()
	{
		return Marshal.PtrToStringAnsi(vtkScalarBarActor_GetLabelFormat_42(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarActor_GetLabelTextProperty_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the labels text property.
	/// </summary>
	public virtual vtkTextProperty GetLabelTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarBarActor_GetLabelTextProperty_43(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarActor_GetLookupTable_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the lookup table to use. The lookup table specifies the number
	/// of colors to use in the table (if not overridden), the scalar range,
	/// and any annotated values.
	/// Annotated values are rendered using vtkTextActor.
	/// </summary>
	public virtual vtkScalarsToColors GetLookupTable()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarBarActor_GetLookupTable_44(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetMaximumHeightInPixels_45(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum width and height in pixels. Specifying the size as
	/// a relative fraction of the viewport can sometimes undesirably stretch
	/// the size of the actor too much. These methods allow the user to set
	/// bounds on the maximum size of the scalar bar in pixels along any
	/// direction. Defaults to unbounded.
	/// </summary>
	public virtual int GetMaximumHeightInPixels()
	{
		return vtkScalarBarActor_GetMaximumHeightInPixels_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetMaximumNumberOfColors_46(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of scalar bar segments to show. This may
	/// differ from the number of colors in the lookup table, in which case
	/// the colors are samples from the lookup table.
	/// </summary>
	public virtual int GetMaximumNumberOfColors()
	{
		return vtkScalarBarActor_GetMaximumNumberOfColors_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetMaximumNumberOfColorsMaxValue_47(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of scalar bar segments to show. This may
	/// differ from the number of colors in the lookup table, in which case
	/// the colors are samples from the lookup table.
	/// </summary>
	public virtual int GetMaximumNumberOfColorsMaxValue()
	{
		return vtkScalarBarActor_GetMaximumNumberOfColorsMaxValue_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetMaximumNumberOfColorsMinValue_48(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of scalar bar segments to show. This may
	/// differ from the number of colors in the lookup table, in which case
	/// the colors are samples from the lookup table.
	/// </summary>
	public virtual int GetMaximumNumberOfColorsMinValue()
	{
		return vtkScalarBarActor_GetMaximumNumberOfColorsMinValue_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetMaximumWidthInPixels_49(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum width and height in pixels. Specifying the size as
	/// a relative fraction of the viewport can sometimes undesirably stretch
	/// the size of the actor too much. These methods allow the user to set
	/// bounds on the maximum size of the scalar bar in pixels along any
	/// direction. Defaults to unbounded.
	/// </summary>
	public virtual int GetMaximumWidthInPixels()
	{
		return vtkScalarBarActor_GetMaximumWidthInPixels_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarActor_GetNanAnnotation_50(HandleRef pThis);

	/// <summary>
	/// Set/get the annotation text for "NaN" values.
	/// </summary>
	public virtual string GetNanAnnotation()
	{
		return Marshal.PtrToStringAnsi(vtkScalarBarActor_GetNanAnnotation_50(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScalarBarActor_GetNumberOfGenerationsFromBase_51(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkScalarBarActor_GetNumberOfGenerationsFromBase_51(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScalarBarActor_GetNumberOfGenerationsFromBaseType_52(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkScalarBarActor_GetNumberOfGenerationsFromBaseType_52(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetNumberOfLabels_53(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of automatic tick labels to show.
	/// </summary>
	public virtual int GetNumberOfLabels()
	{
		return vtkScalarBarActor_GetNumberOfLabels_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetNumberOfLabelsMaxValue_54(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of automatic tick labels to show.
	/// </summary>
	public virtual int GetNumberOfLabelsMaxValue()
	{
		return vtkScalarBarActor_GetNumberOfLabelsMaxValue_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetNumberOfLabelsMinValue_55(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of automatic tick labels to show.
	/// </summary>
	public virtual int GetNumberOfLabelsMinValue()
	{
		return vtkScalarBarActor_GetNumberOfLabelsMinValue_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetOrientation_56(HandleRef pThis);

	/// <summary>
	/// Control the orientation of the scalar bar.
	/// </summary>
	public virtual int GetOrientation()
	{
		return vtkScalarBarActor_GetOrientation_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetOrientationMaxValue_57(HandleRef pThis);

	/// <summary>
	/// Control the orientation of the scalar bar.
	/// </summary>
	public virtual int GetOrientationMaxValue()
	{
		return vtkScalarBarActor_GetOrientationMaxValue_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetOrientationMinValue_58(HandleRef pThis);

	/// <summary>
	/// Control the orientation of the scalar bar.
	/// </summary>
	public virtual int GetOrientationMinValue()
	{
		return vtkScalarBarActor_GetOrientationMinValue_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_GetScalarBarRect_59(HandleRef pThis, IntPtr rect, HandleRef viewport);

	/// <summary>
	/// Fills rect with the dimensions of the scalar bar in viewport coordinates.
	/// Only the color bar is considered -- text labels are not considered.
	/// rect is {xmin, xmax, width, height}
	/// </summary>
	public virtual void GetScalarBarRect(IntPtr rect, vtkViewport viewport)
	{
		vtkScalarBarActor_GetScalarBarRect_59(GetCppThis(), rect, viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetTextPad_60(HandleRef pThis);

	/// <summary>
	/// Set/get the amount of padding around text boxes.
	/// The default is 1 pixel.
	/// </summary>
	public virtual int GetTextPad()
	{
		return vtkScalarBarActor_GetTextPad_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetTextPosition_61(HandleRef pThis);

	/// <summary>
	/// Should the title and tick marks precede the scalar bar or succeed it?
	/// This is measured along the viewport coordinate direction perpendicular
	/// to the long axis of the scalar bar, not the reading direction.
	/// Thus, succeed implies the that the text is above scalar bar if
	/// the orientation is horizontal or right of scalar bar if the orientation
	/// is vertical. Precede is the opposite.
	/// </summary>
	public virtual int GetTextPosition()
	{
		return vtkScalarBarActor_GetTextPosition_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetTextPositionMaxValue_62(HandleRef pThis);

	/// <summary>
	/// Should the title and tick marks precede the scalar bar or succeed it?
	/// This is measured along the viewport coordinate direction perpendicular
	/// to the long axis of the scalar bar, not the reading direction.
	/// Thus, succeed implies the that the text is above scalar bar if
	/// the orientation is horizontal or right of scalar bar if the orientation
	/// is vertical. Precede is the opposite.
	/// </summary>
	public virtual int GetTextPositionMaxValue()
	{
		return vtkScalarBarActor_GetTextPositionMaxValue_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetTextPositionMinValue_63(HandleRef pThis);

	/// <summary>
	/// Should the title and tick marks precede the scalar bar or succeed it?
	/// This is measured along the viewport coordinate direction perpendicular
	/// to the long axis of the scalar bar, not the reading direction.
	/// Thus, succeed implies the that the text is above scalar bar if
	/// the orientation is horizontal or right of scalar bar if the orientation
	/// is vertical. Precede is the opposite.
	/// </summary>
	public virtual int GetTextPositionMinValue()
	{
		return vtkScalarBarActor_GetTextPositionMinValue_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarActor_GetTextureActor_64(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the texture actor.. you may want to change some properties on it
	/// </summary>
	public virtual vtkTexturedActor2D GetTextureActor()
	{
		vtkTexturedActor2D vtkTexturedActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarBarActor_GetTextureActor_64(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTexturedActor2D2 = (vtkTexturedActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTexturedActor2D2.Register(null);
			}
		}
		return vtkTexturedActor2D2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScalarBarActor_GetTextureGridWidth_65(HandleRef pThis);

	/// <summary>
	/// Set the width of the texture grid. Used only if UseOpacity is ON.
	/// </summary>
	public virtual double GetTextureGridWidth()
	{
		return vtkScalarBarActor_GetTextureGridWidth_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarActor_GetTitle_66(HandleRef pThis);

	/// <summary>
	/// Set/Get the title of the scalar bar actor,
	/// </summary>
	public virtual string GetTitle()
	{
		return Marshal.PtrToStringAnsi(vtkScalarBarActor_GetTitle_66(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScalarBarActor_GetTitleRatio_67(HandleRef pThis);

	/// <summary>
	/// Set/get the ratio of the title height to the tick label height
	/// (used only when the \a Orientation is horizontal).
	/// The default is 0.5, which attempts to make the labels and title
	/// the same size. This must be a number in the range ]0, 1[.
	/// </summary>
	public virtual double GetTitleRatio()
	{
		return vtkScalarBarActor_GetTitleRatio_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScalarBarActor_GetTitleRatioMaxValue_68(HandleRef pThis);

	/// <summary>
	/// Set/get the ratio of the title height to the tick label height
	/// (used only when the \a Orientation is horizontal).
	/// The default is 0.5, which attempts to make the labels and title
	/// the same size. This must be a number in the range ]0, 1[.
	/// </summary>
	public virtual double GetTitleRatioMaxValue()
	{
		return vtkScalarBarActor_GetTitleRatioMaxValue_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScalarBarActor_GetTitleRatioMinValue_69(HandleRef pThis);

	/// <summary>
	/// Set/get the ratio of the title height to the tick label height
	/// (used only when the \a Orientation is horizontal).
	/// The default is 0.5, which attempts to make the labels and title
	/// the same size. This must be a number in the range ]0, 1[.
	/// </summary>
	public virtual double GetTitleRatioMinValue()
	{
		return vtkScalarBarActor_GetTitleRatioMinValue_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarActor_GetTitleTextProperty_70(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the title text property.
	/// </summary>
	public virtual vtkTextProperty GetTitleTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarBarActor_GetTitleTextProperty_70(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkScalarBarActor_GetUnconstrainedFontSize_71(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the font size of title and labels is unconstrained. Default is off.
	/// When it is constrained, the size of the scalar bar will constrain the font size.
	/// When it is not, the size of the font will always be respected.
	/// Using custom labels will force this mode to be on.
	/// </summary>
	public virtual bool GetUnconstrainedFontSize()
	{
		return (vtkScalarBarActor_GetUnconstrainedFontSize_71(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkScalarBarActor_GetUseCustomLabels_72(HandleRef pThis);

	/// <summary>
	/// Get/Set whether custom labels will be used.
	/// bonds. Default: Off.
	/// </summary>
	public virtual bool GetUseCustomLabels()
	{
		return (vtkScalarBarActor_GetUseCustomLabels_72(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetUseOpacity_73(HandleRef pThis);

	/// <summary>
	/// Should be display the opacity as well. This is displayed by changing
	/// the opacity of the scalar bar in accordance with the opacity of the
	/// given color. For clarity, a texture grid is placed in the background
	/// if Opacity is ON. You might also want to play with SetTextureGridWith
	/// in that case. [Default: off]
	/// </summary>
	public virtual int GetUseOpacity()
	{
		return vtkScalarBarActor_GetUseOpacity_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_GetVerticalTitleSeparation_74(HandleRef pThis);

	/// <summary>
	/// Set/get the margin in pixels, between the title and the bar,
	/// when the \a Orientation is vertical.
	/// The default is 0 pixels.
	/// </summary>
	public virtual int GetVerticalTitleSeparation()
	{
		return vtkScalarBarActor_GetVerticalTitleSeparation_74(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_HasTranslucentPolygonalGeometry_75(HandleRef pThis);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkScalarBarActor_HasTranslucentPolygonalGeometry_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_IsA_76(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkScalarBarActor_IsA_76(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_IsTypeOf_77(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkScalarBarActor_IsTypeOf_77(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarActor_NewInstance_79(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkScalarBarActor NewInstance()
	{
		vtkScalarBarActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarBarActor_NewInstance_79(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkScalarBarActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_ReleaseGraphicsResources_80(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkScalarBarActor_ReleaseGraphicsResources_80(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_RenderOpaqueGeometry_81(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Draw the scalar bar and annotation text to the screen.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkScalarBarActor_RenderOpaqueGeometry_81(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_RenderOverlay_82(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Draw the scalar bar and annotation text to the screen.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkScalarBarActor_RenderOverlay_82(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarActor_RenderTranslucentPolygonalGeometry_83(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the scalar bar and annotation text to the screen.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkScalarBarActor_RenderTranslucentPolygonalGeometry_83(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarActor_SafeDownCast_84(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkScalarBarActor SafeDownCast(vtkObjectBase o)
	{
		vtkScalarBarActor vtkScalarBarActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarBarActor_SafeDownCast_84(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarBarActor2 = (vtkScalarBarActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarBarActor2.Register(null);
			}
		}
		return vtkScalarBarActor2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetAboveRangeAnnotation_85(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/get the annotation text for "Above Range Swatch" values.
	/// </summary>
	public virtual void SetAboveRangeAnnotation(string _arg)
	{
		vtkScalarBarActor_SetAboveRangeAnnotation_85(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetAnnotationLeaderPadding_86(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the padding between the scalar bar and the text annotations.
	/// This space is used to draw leader lines.
	/// The default is 8 pixels.
	/// </summary>
	public virtual void SetAnnotationLeaderPadding(double _arg)
	{
		vtkScalarBarActor_SetAnnotationLeaderPadding_86(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetAnnotationTextProperty_87(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the annotation text property.
	/// </summary>
	public virtual void SetAnnotationTextProperty(vtkTextProperty p)
	{
		vtkScalarBarActor_SetAnnotationTextProperty_87(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetAnnotationTextScaling_88(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get whether annotation labels should be scaled with the viewport.
	///
	/// The default value is 0 (no scaling).
	/// If non-zero, the vtkTextActor instances used to render annotation
	/// labels will have their TextScaleMode set to viewport-based scaling,
	/// which nonlinearly scales font size with the viewport size.
	/// </summary>
	public virtual void SetAnnotationTextScaling(int _arg)
	{
		vtkScalarBarActor_SetAnnotationTextScaling_88(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetBackgroundProperty_89(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the background property.
	/// </summary>
	public virtual void SetBackgroundProperty(vtkProperty2D p)
	{
		vtkScalarBarActor_SetBackgroundProperty_89(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetBarRatio_90(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the thickness of the color bar relative to the widget frame.
	/// The default is 0.375 and must always be in the range ]0, 1[.
	/// </summary>
	public virtual void SetBarRatio(double _arg)
	{
		vtkScalarBarActor_SetBarRatio_90(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetBelowRangeAnnotation_91(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/get the annotation text for "Below Range" values.
	/// </summary>
	public virtual void SetBelowRangeAnnotation(string _arg)
	{
		vtkScalarBarActor_SetBelowRangeAnnotation_91(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetComponentTitle_92(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the title for the component that is selected,
	/// </summary>
	public virtual void SetComponentTitle(string _arg)
	{
		vtkScalarBarActor_SetComponentTitle_92(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetCustomLabels_93(HandleRef pThis, HandleRef labels);

	/// <summary>
	/// Set/Get the fixed locations to use.
	/// </summary>
	public virtual void SetCustomLabels(vtkDoubleArray labels)
	{
		vtkScalarBarActor_SetCustomLabels_93(GetCppThis(), labels?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetDrawAboveRangeSwatch_94(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/get whether the Above range swatch should be rendered or not.
	/// This only affects rendering when \a DrawAnnotations is true.
	/// The default is false.
	/// </summary>
	public virtual void SetDrawAboveRangeSwatch(bool _arg)
	{
		vtkScalarBarActor_SetDrawAboveRangeSwatch_94(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetDrawAnnotations_95(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get whether text annotations should be rendered or not.
	/// Currently, this only affects rendering when \a IndexedLookup is true.
	/// The default is true.
	/// </summary>
	public virtual void SetDrawAnnotations(int _arg)
	{
		vtkScalarBarActor_SetDrawAnnotations_95(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetDrawBackground_96(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether a background should be drawn around the scalar bar.
	/// Default is off.
	/// </summary>
	public virtual void SetDrawBackground(int _arg)
	{
		vtkScalarBarActor_SetDrawBackground_96(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetDrawBelowRangeSwatch_97(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/get whether the Below range swatch should be rendered or not.
	/// This only affects rendering when \a DrawAnnotations is true.
	/// The default is false.
	/// </summary>
	public virtual void SetDrawBelowRangeSwatch(bool _arg)
	{
		vtkScalarBarActor_SetDrawBelowRangeSwatch_97(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetDrawColorBar_98(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether the color bar should be drawn. If off, only the tickmarks
	/// and text will be drawn. Default is on.
	/// </summary>
	public virtual void SetDrawColorBar(int _arg)
	{
		vtkScalarBarActor_SetDrawColorBar_98(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetDrawFrame_99(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether a frame should be drawn around the scalar bar.
	/// Default is off.
	/// </summary>
	public virtual void SetDrawFrame(int _arg)
	{
		vtkScalarBarActor_SetDrawFrame_99(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetDrawNanAnnotation_100(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get whether the NaN annotation should be rendered or not.
	/// This only affects rendering when \a DrawAnnotations is true.
	/// The default is false.
	/// </summary>
	public virtual void SetDrawNanAnnotation(int _arg)
	{
		vtkScalarBarActor_SetDrawNanAnnotation_100(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetDrawTickLabels_101(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether the tick labels should be drawn. Default is on.
	/// </summary>
	public virtual void SetDrawTickLabels(int _arg)
	{
		vtkScalarBarActor_SetDrawTickLabels_101(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetFixedAnnotationLeaderLineColor_102(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get how leader lines connecting annotations to values should be colored.
	///
	/// When true, leader lines are all the same color (and match the LabelTextProperty color).
	/// When false, leader lines take on the color of the value they correspond to.
	/// This only affects rendering when \a DrawAnnotations is true.
	/// The default is false.
	/// </summary>
	public virtual void SetFixedAnnotationLeaderLineColor(int _arg)
	{
		vtkScalarBarActor_SetFixedAnnotationLeaderLineColor_102(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetFrameProperty_103(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the frame property.
	/// </summary>
	public virtual void SetFrameProperty(vtkProperty2D p)
	{
		vtkScalarBarActor_SetFrameProperty_103(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetLabelFormat_104(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the format with which to print the labels on the scalar
	/// bar.
	/// </summary>
	public virtual void SetLabelFormat(string _arg)
	{
		vtkScalarBarActor_SetLabelFormat_104(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetLabelTextProperty_105(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the labels text property.
	/// </summary>
	public virtual void SetLabelTextProperty(vtkTextProperty p)
	{
		vtkScalarBarActor_SetLabelTextProperty_105(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetLookupTable_106(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the lookup table to use. The lookup table specifies the number
	/// of colors to use in the table (if not overridden), the scalar range,
	/// and any annotated values.
	/// Annotated values are rendered using vtkTextActor.
	/// </summary>
	public virtual void SetLookupTable(vtkScalarsToColors arg0)
	{
		vtkScalarBarActor_SetLookupTable_106(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetMaximumHeightInPixels_107(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the maximum width and height in pixels. Specifying the size as
	/// a relative fraction of the viewport can sometimes undesirably stretch
	/// the size of the actor too much. These methods allow the user to set
	/// bounds on the maximum size of the scalar bar in pixels along any
	/// direction. Defaults to unbounded.
	/// </summary>
	public virtual void SetMaximumHeightInPixels(int _arg)
	{
		vtkScalarBarActor_SetMaximumHeightInPixels_107(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetMaximumNumberOfColors_108(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the maximum number of scalar bar segments to show. This may
	/// differ from the number of colors in the lookup table, in which case
	/// the colors are samples from the lookup table.
	/// </summary>
	public virtual void SetMaximumNumberOfColors(int _arg)
	{
		vtkScalarBarActor_SetMaximumNumberOfColors_108(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetMaximumWidthInPixels_109(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the maximum width and height in pixels. Specifying the size as
	/// a relative fraction of the viewport can sometimes undesirably stretch
	/// the size of the actor too much. These methods allow the user to set
	/// bounds on the maximum size of the scalar bar in pixels along any
	/// direction. Defaults to unbounded.
	/// </summary>
	public virtual void SetMaximumWidthInPixels(int _arg)
	{
		vtkScalarBarActor_SetMaximumWidthInPixels_109(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetNanAnnotation_110(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/get the annotation text for "NaN" values.
	/// </summary>
	public virtual void SetNanAnnotation(string _arg)
	{
		vtkScalarBarActor_SetNanAnnotation_110(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetNumberOfLabels_111(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of automatic tick labels to show.
	/// </summary>
	public virtual void SetNumberOfLabels(int _arg)
	{
		vtkScalarBarActor_SetNumberOfLabels_111(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetOrientation_112(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the orientation of the scalar bar.
	/// </summary>
	public virtual void SetOrientation(int _arg)
	{
		vtkScalarBarActor_SetOrientation_112(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetOrientationToHorizontal_113(HandleRef pThis);

	/// <summary>
	/// Control the orientation of the scalar bar.
	/// </summary>
	public void SetOrientationToHorizontal()
	{
		vtkScalarBarActor_SetOrientationToHorizontal_113(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetOrientationToVertical_114(HandleRef pThis);

	/// <summary>
	/// Control the orientation of the scalar bar.
	/// </summary>
	public void SetOrientationToVertical()
	{
		vtkScalarBarActor_SetOrientationToVertical_114(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetTextPad_115(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the amount of padding around text boxes.
	/// The default is 1 pixel.
	/// </summary>
	public virtual void SetTextPad(int _arg)
	{
		vtkScalarBarActor_SetTextPad_115(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetTextPosition_116(HandleRef pThis, int _arg);

	/// <summary>
	/// Should the title and tick marks precede the scalar bar or succeed it?
	/// This is measured along the viewport coordinate direction perpendicular
	/// to the long axis of the scalar bar, not the reading direction.
	/// Thus, succeed implies the that the text is above scalar bar if
	/// the orientation is horizontal or right of scalar bar if the orientation
	/// is vertical. Precede is the opposite.
	/// </summary>
	public virtual void SetTextPosition(int _arg)
	{
		vtkScalarBarActor_SetTextPosition_116(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetTextPositionToPrecedeScalarBar_117(HandleRef pThis);

	/// <summary>
	/// Should the title and tick marks precede the scalar bar or succeed it?
	/// This is measured along the viewport coordinate direction perpendicular
	/// to the long axis of the scalar bar, not the reading direction.
	/// Thus, succeed implies the that the text is above scalar bar if
	/// the orientation is horizontal or right of scalar bar if the orientation
	/// is vertical. Precede is the opposite.
	/// </summary>
	public virtual void SetTextPositionToPrecedeScalarBar()
	{
		vtkScalarBarActor_SetTextPositionToPrecedeScalarBar_117(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetTextPositionToSucceedScalarBar_118(HandleRef pThis);

	/// <summary>
	/// Should the title and tick marks precede the scalar bar or succeed it?
	/// This is measured along the viewport coordinate direction perpendicular
	/// to the long axis of the scalar bar, not the reading direction.
	/// Thus, succeed implies the that the text is above scalar bar if
	/// the orientation is horizontal or right of scalar bar if the orientation
	/// is vertical. Precede is the opposite.
	/// </summary>
	public virtual void SetTextPositionToSucceedScalarBar()
	{
		vtkScalarBarActor_SetTextPositionToSucceedScalarBar_118(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetTextureGridWidth_119(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the width of the texture grid. Used only if UseOpacity is ON.
	/// </summary>
	public virtual void SetTextureGridWidth(double _arg)
	{
		vtkScalarBarActor_SetTextureGridWidth_119(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetTitle_120(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the title of the scalar bar actor,
	/// </summary>
	public virtual void SetTitle(string _arg)
	{
		vtkScalarBarActor_SetTitle_120(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetTitleRatio_121(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the ratio of the title height to the tick label height
	/// (used only when the \a Orientation is horizontal).
	/// The default is 0.5, which attempts to make the labels and title
	/// the same size. This must be a number in the range ]0, 1[.
	/// </summary>
	public virtual void SetTitleRatio(double _arg)
	{
		vtkScalarBarActor_SetTitleRatio_121(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetTitleTextProperty_122(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the title text property.
	/// </summary>
	public virtual void SetTitleTextProperty(vtkTextProperty p)
	{
		vtkScalarBarActor_SetTitleTextProperty_122(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetUnconstrainedFontSize_123(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get whether the font size of title and labels is unconstrained. Default is off.
	/// When it is constrained, the size of the scalar bar will constrain the font size.
	/// When it is not, the size of the font will always be respected.
	/// Using custom labels will force this mode to be on.
	/// </summary>
	public virtual void SetUnconstrainedFontSize(bool _arg)
	{
		vtkScalarBarActor_SetUnconstrainedFontSize_123(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetUseCustomLabels_124(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set whether custom labels will be used.
	/// bonds. Default: Off.
	/// </summary>
	public virtual void SetUseCustomLabels(bool _arg)
	{
		vtkScalarBarActor_SetUseCustomLabels_124(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetUseOpacity_125(HandleRef pThis, int _arg);

	/// <summary>
	/// Should be display the opacity as well. This is displayed by changing
	/// the opacity of the scalar bar in accordance with the opacity of the
	/// given color. For clarity, a texture grid is placed in the background
	/// if Opacity is ON. You might also want to play with SetTextureGridWith
	/// in that case. [Default: off]
	/// </summary>
	public virtual void SetUseOpacity(int _arg)
	{
		vtkScalarBarActor_SetUseOpacity_125(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_SetVerticalTitleSeparation_126(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the margin in pixels, between the title and the bar,
	/// when the \a Orientation is vertical.
	/// The default is 0 pixels.
	/// </summary>
	public virtual void SetVerticalTitleSeparation(int _arg)
	{
		vtkScalarBarActor_SetVerticalTitleSeparation_126(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_ShallowCopy_127(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of a scalar bar actor. Overloads the virtual vtkProp method.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkScalarBarActor_ShallowCopy_127(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_UnconstrainedFontSizeOff_128(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the font size of title and labels is unconstrained. Default is off.
	/// When it is constrained, the size of the scalar bar will constrain the font size.
	/// When it is not, the size of the font will always be respected.
	/// Using custom labels will force this mode to be on.
	/// </summary>
	public virtual void UnconstrainedFontSizeOff()
	{
		vtkScalarBarActor_UnconstrainedFontSizeOff_128(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_UnconstrainedFontSizeOn_129(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the font size of title and labels is unconstrained. Default is off.
	/// When it is constrained, the size of the scalar bar will constrain the font size.
	/// When it is not, the size of the font will always be respected.
	/// Using custom labels will force this mode to be on.
	/// </summary>
	public virtual void UnconstrainedFontSizeOn()
	{
		vtkScalarBarActor_UnconstrainedFontSizeOn_129(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_UseCustomLabelsOff_130(HandleRef pThis);

	/// <summary>
	/// Get/Set whether custom labels will be used.
	/// bonds. Default: Off.
	/// </summary>
	public virtual void UseCustomLabelsOff()
	{
		vtkScalarBarActor_UseCustomLabelsOff_130(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_UseCustomLabelsOn_131(HandleRef pThis);

	/// <summary>
	/// Get/Set whether custom labels will be used.
	/// bonds. Default: Off.
	/// </summary>
	public virtual void UseCustomLabelsOn()
	{
		vtkScalarBarActor_UseCustomLabelsOn_131(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_UseOpacityOff_132(HandleRef pThis);

	/// <summary>
	/// Should be display the opacity as well. This is displayed by changing
	/// the opacity of the scalar bar in accordance with the opacity of the
	/// given color. For clarity, a texture grid is placed in the background
	/// if Opacity is ON. You might also want to play with SetTextureGridWith
	/// in that case. [Default: off]
	/// </summary>
	public virtual void UseOpacityOff()
	{
		vtkScalarBarActor_UseOpacityOff_132(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarActor_UseOpacityOn_133(HandleRef pThis);

	/// <summary>
	/// Should be display the opacity as well. This is displayed by changing
	/// the opacity of the scalar bar in accordance with the opacity of the
	/// given color. For clarity, a texture grid is placed in the background
	/// if Opacity is ON. You might also want to play with SetTextureGridWith
	/// in that case. [Default: off]
	/// </summary>
	public virtual void UseOpacityOn()
	{
		vtkScalarBarActor_UseOpacityOn_133(GetCppThis());
	}
}
