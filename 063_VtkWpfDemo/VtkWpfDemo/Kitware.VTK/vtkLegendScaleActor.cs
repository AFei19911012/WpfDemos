using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLegendScaleActor
/// </summary>
/// <remarks>
///    annotate the render window with scale and distance information
///
/// This class is used to annotate the render window. Its basic goal is to
/// provide an indication of the scale of the scene. Four axes surrounding the
/// render window indicate (in a variety of ways) the scale of what the camera
/// is viewing. An option also exists for displaying a scale legend.
///
/// The axes can be programmed either to display distance scales or x-y
/// coordinate values. By default, the scales display a distance. However,
/// if you know that the view is down the z-axis, the scales can be programmed
/// to display x-y coordinate values.
///
/// @warning
/// Please be aware that the axes and scale values are subject to perspective
/// effects. The distances are computed in the focal plane of the camera.
/// When there are large view angles (i.e., perspective projection), the
/// computed distances may provide users the wrong sense of scale. These
/// effects are not present when parallel projection is enabled.
/// </remarks>
public class vtkLegendScaleActor : vtkProp
{
	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public enum AttributeLocation
	{
		/// <summary>enum member</summary>
		DISTANCE,
		/// <summary>enum member</summary>
		XY_COORDINATES
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLegendScaleActor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLegendScaleActor()
	{
		MRClassNameKey = "class vtkLegendScaleActor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLegendScaleActor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLegendScaleActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLegendScaleActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkLegendScaleActor New()
	{
		vtkLegendScaleActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLegendScaleActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLegendScaleActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkLegendScaleActor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLegendScaleActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkLegendScaleActor_AllAnnotationsOff_01(HandleRef pThis);

	/// <summary>
	/// Convenience method that turns all the axes and the legend scale.
	/// </summary>
	public void AllAnnotationsOff()
	{
		vtkLegendScaleActor_AllAnnotationsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_AllAnnotationsOn_02(HandleRef pThis);

	/// <summary>
	/// Convenience method that turns all the axes and the legend scale.
	/// </summary>
	public void AllAnnotationsOn()
	{
		vtkLegendScaleActor_AllAnnotationsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_AllAxesOff_03(HandleRef pThis);

	/// <summary>
	/// Convenience method that turns all the axes either on or off.
	/// </summary>
	public void AllAxesOff()
	{
		vtkLegendScaleActor_AllAxesOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_AllAxesOn_04(HandleRef pThis);

	/// <summary>
	/// Convenience method that turns all the axes either on or off.
	/// </summary>
	public void AllAxesOn()
	{
		vtkLegendScaleActor_AllAxesOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_BottomAxisVisibilityOff_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the flags that control which of the four axes to display (top,
	/// bottom, left and right). By default, all the axes are displayed.
	/// </summary>
	public virtual void BottomAxisVisibilityOff()
	{
		vtkLegendScaleActor_BottomAxisVisibilityOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_BottomAxisVisibilityOn_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the flags that control which of the four axes to display (top,
	/// bottom, left and right). By default, all the axes are displayed.
	/// </summary>
	public virtual void BottomAxisVisibilityOn()
	{
		vtkLegendScaleActor_BottomAxisVisibilityOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_BuildRepresentation_07(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Standard methods supporting the rendering process.
	/// </summary>
	public virtual void BuildRepresentation(vtkViewport viewport)
	{
		vtkLegendScaleActor_BuildRepresentation_07(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_GetActors2D_08(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Standard methods supporting the rendering process.
	/// </summary>
	public override void GetActors2D(vtkPropCollection arg0)
	{
		vtkLegendScaleActor_GetActors2D_08(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLegendScaleActor_GetBottomAxis_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// These are methods to retrieve the vtkAxisActors used to represent
	/// the four axes that form this representation. Users may retrieve and
	/// then modify these axes to control their appearance.
	/// </summary>
	public virtual vtkAxisActor2D GetBottomAxis()
	{
		vtkAxisActor2D vtkAxisActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLegendScaleActor_GetBottomAxis_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAxisActor2D2 = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAxisActor2D2.Register(null);
			}
		}
		return vtkAxisActor2D2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_GetBottomAxisVisibility_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the flags that control which of the four axes to display (top,
	/// bottom, left and right). By default, all the axes are displayed.
	/// </summary>
	public virtual int GetBottomAxisVisibility()
	{
		return vtkLegendScaleActor_GetBottomAxisVisibility_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_GetBottomBorderOffset_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the offset of the bottom axis from the border. This number is expressed in
	/// pixels, and represents the approximate distance of the axes from the sides
	/// of the renderer. The default is 30.
	/// </summary>
	public virtual int GetBottomBorderOffset()
	{
		return vtkLegendScaleActor_GetBottomBorderOffset_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_GetBottomBorderOffsetMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the offset of the bottom axis from the border. This number is expressed in
	/// pixels, and represents the approximate distance of the axes from the sides
	/// of the renderer. The default is 30.
	/// </summary>
	public virtual int GetBottomBorderOffsetMaxValue()
	{
		return vtkLegendScaleActor_GetBottomBorderOffsetMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_GetBottomBorderOffsetMinValue_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the offset of the bottom axis from the border. This number is expressed in
	/// pixels, and represents the approximate distance of the axes from the sides
	/// of the renderer. The default is 30.
	/// </summary>
	public virtual int GetBottomBorderOffsetMinValue()
	{
		return vtkLegendScaleActor_GetBottomBorderOffsetMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLegendScaleActor_GetCornerOffsetFactor_14(HandleRef pThis);

	/// <summary>
	/// Get/Set the corner offset. This is the offset factor used to offset the
	/// axes at the corners. Default value is 2.0.
	/// </summary>
	public virtual double GetCornerOffsetFactor()
	{
		return vtkLegendScaleActor_GetCornerOffsetFactor_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLegendScaleActor_GetCornerOffsetFactorMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Get/Set the corner offset. This is the offset factor used to offset the
	/// axes at the corners. Default value is 2.0.
	/// </summary>
	public virtual double GetCornerOffsetFactorMaxValue()
	{
		return vtkLegendScaleActor_GetCornerOffsetFactorMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLegendScaleActor_GetCornerOffsetFactorMinValue_16(HandleRef pThis);

	/// <summary>
	/// Get/Set the corner offset. This is the offset factor used to offset the
	/// axes at the corners. Default value is 2.0.
	/// </summary>
	public virtual double GetCornerOffsetFactorMinValue()
	{
		return vtkLegendScaleActor_GetCornerOffsetFactorMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_GetLabelMode_17(HandleRef pThis);

	/// <summary>
	/// Specify the mode for labeling the scale axes. By default, the axes are
	/// labeled with the distance between points (centered at a distance of
	/// 0.0). Alternatively if you know that the view is down the z-axis; the
	/// axes can be labeled with x-y coordinate values.
	/// </summary>
	public virtual int GetLabelMode()
	{
		return vtkLegendScaleActor_GetLabelMode_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_GetLabelModeMaxValue_18(HandleRef pThis);

	/// <summary>
	/// Specify the mode for labeling the scale axes. By default, the axes are
	/// labeled with the distance between points (centered at a distance of
	/// 0.0). Alternatively if you know that the view is down the z-axis; the
	/// axes can be labeled with x-y coordinate values.
	/// </summary>
	public virtual int GetLabelModeMaxValue()
	{
		return vtkLegendScaleActor_GetLabelModeMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_GetLabelModeMinValue_19(HandleRef pThis);

	/// <summary>
	/// Specify the mode for labeling the scale axes. By default, the axes are
	/// labeled with the distance between points (centered at a distance of
	/// 0.0). Alternatively if you know that the view is down the z-axis; the
	/// axes can be labeled with x-y coordinate values.
	/// </summary>
	public virtual int GetLabelModeMinValue()
	{
		return vtkLegendScaleActor_GetLabelModeMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLegendScaleActor_GetLeftAxis_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// These are methods to retrieve the vtkAxisActors used to represent
	/// the four axes that form this representation. Users may retrieve and
	/// then modify these axes to control their appearance.
	/// </summary>
	public virtual vtkAxisActor2D GetLeftAxis()
	{
		vtkAxisActor2D vtkAxisActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLegendScaleActor_GetLeftAxis_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAxisActor2D2 = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAxisActor2D2.Register(null);
			}
		}
		return vtkAxisActor2D2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_GetLeftAxisVisibility_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the flags that control which of the four axes to display (top,
	/// bottom, left and right). By default, all the axes are displayed.
	/// </summary>
	public virtual int GetLeftAxisVisibility()
	{
		return vtkLegendScaleActor_GetLeftAxisVisibility_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_GetLeftBorderOffset_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the offset of the left axis from the border. This number is expressed in
	/// pixels, and represents the approximate distance of the axes from the sides
	/// of the renderer. The default is 50.
	/// </summary>
	public virtual int GetLeftBorderOffset()
	{
		return vtkLegendScaleActor_GetLeftBorderOffset_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_GetLeftBorderOffsetMaxValue_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the offset of the left axis from the border. This number is expressed in
	/// pixels, and represents the approximate distance of the axes from the sides
	/// of the renderer. The default is 50.
	/// </summary>
	public virtual int GetLeftBorderOffsetMaxValue()
	{
		return vtkLegendScaleActor_GetLeftBorderOffsetMaxValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_GetLeftBorderOffsetMinValue_24(HandleRef pThis);

	/// <summary>
	/// Set/Get the offset of the left axis from the border. This number is expressed in
	/// pixels, and represents the approximate distance of the axes from the sides
	/// of the renderer. The default is 50.
	/// </summary>
	public virtual int GetLeftBorderOffsetMinValue()
	{
		return vtkLegendScaleActor_GetLeftBorderOffsetMinValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLegendScaleActor_GetLegendLabelProperty_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the labels text properties for the legend title and labels.
	/// </summary>
	public virtual vtkTextProperty GetLegendLabelProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLegendScaleActor_GetLegendLabelProperty_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkLegendScaleActor_GetLegendTitleProperty_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the labels text properties for the legend title and labels.
	/// </summary>
	public virtual vtkTextProperty GetLegendTitleProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLegendScaleActor_GetLegendTitleProperty_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkLegendScaleActor_GetLegendVisibility_27(HandleRef pThis);

	/// <summary>
	/// Indicate whether the legend scale should be displayed or not.
	/// The default is On.
	/// </summary>
	public virtual int GetLegendVisibility()
	{
		return vtkLegendScaleActor_GetLegendVisibility_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLegendScaleActor_GetNumberOfGenerationsFromBase_28(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLegendScaleActor_GetNumberOfGenerationsFromBase_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLegendScaleActor_GetNumberOfGenerationsFromBaseType_29(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLegendScaleActor_GetNumberOfGenerationsFromBaseType_29(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLegendScaleActor_GetRightAxis_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// These are methods to retrieve the vtkAxisActors used to represent
	/// the four axes that form this representation. Users may retrieve and
	/// then modify these axes to control their appearance.
	/// </summary>
	public virtual vtkAxisActor2D GetRightAxis()
	{
		vtkAxisActor2D vtkAxisActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLegendScaleActor_GetRightAxis_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAxisActor2D2 = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAxisActor2D2.Register(null);
			}
		}
		return vtkAxisActor2D2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_GetRightAxisVisibility_31(HandleRef pThis);

	/// <summary>
	/// Set/Get the flags that control which of the four axes to display (top,
	/// bottom, left and right). By default, all the axes are displayed.
	/// </summary>
	public virtual int GetRightAxisVisibility()
	{
		return vtkLegendScaleActor_GetRightAxisVisibility_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_GetRightBorderOffset_32(HandleRef pThis);

	/// <summary>
	/// Set/Get the offset of the right axis from the border. This number is expressed in
	/// pixels, and represents the approximate distance of the axes from the sides
	/// of the renderer. The default is 50.
	/// </summary>
	public virtual int GetRightBorderOffset()
	{
		return vtkLegendScaleActor_GetRightBorderOffset_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_GetRightBorderOffsetMaxValue_33(HandleRef pThis);

	/// <summary>
	/// Set/Get the offset of the right axis from the border. This number is expressed in
	/// pixels, and represents the approximate distance of the axes from the sides
	/// of the renderer. The default is 50.
	/// </summary>
	public virtual int GetRightBorderOffsetMaxValue()
	{
		return vtkLegendScaleActor_GetRightBorderOffsetMaxValue_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_GetRightBorderOffsetMinValue_34(HandleRef pThis);

	/// <summary>
	/// Set/Get the offset of the right axis from the border. This number is expressed in
	/// pixels, and represents the approximate distance of the axes from the sides
	/// of the renderer. The default is 50.
	/// </summary>
	public virtual int GetRightBorderOffsetMinValue()
	{
		return vtkLegendScaleActor_GetRightBorderOffsetMinValue_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLegendScaleActor_GetTopAxis_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// These are methods to retrieve the vtkAxisActors used to represent
	/// the four axes that form this representation. Users may retrieve and
	/// then modify these axes to control their appearance.
	/// </summary>
	public virtual vtkAxisActor2D GetTopAxis()
	{
		vtkAxisActor2D vtkAxisActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLegendScaleActor_GetTopAxis_35(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAxisActor2D2 = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAxisActor2D2.Register(null);
			}
		}
		return vtkAxisActor2D2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_GetTopAxisVisibility_36(HandleRef pThis);

	/// <summary>
	/// Set/Get the flags that control which of the four axes to display (top,
	/// bottom, left and right). By default, all the axes are displayed.
	/// </summary>
	public virtual int GetTopAxisVisibility()
	{
		return vtkLegendScaleActor_GetTopAxisVisibility_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_GetTopBorderOffset_37(HandleRef pThis);

	/// <summary>
	/// Set/Get the offset of the top axis from the border. This number is expressed in
	/// pixels, and represents the approximate distance of the axes from the sides
	/// of the renderer. The default is 30.
	/// </summary>
	public virtual int GetTopBorderOffset()
	{
		return vtkLegendScaleActor_GetTopBorderOffset_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_GetTopBorderOffsetMaxValue_38(HandleRef pThis);

	/// <summary>
	/// Set/Get the offset of the top axis from the border. This number is expressed in
	/// pixels, and represents the approximate distance of the axes from the sides
	/// of the renderer. The default is 30.
	/// </summary>
	public virtual int GetTopBorderOffsetMaxValue()
	{
		return vtkLegendScaleActor_GetTopBorderOffsetMaxValue_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_GetTopBorderOffsetMinValue_39(HandleRef pThis);

	/// <summary>
	/// Set/Get the offset of the top axis from the border. This number is expressed in
	/// pixels, and represents the approximate distance of the axes from the sides
	/// of the renderer. The default is 30.
	/// </summary>
	public virtual int GetTopBorderOffsetMinValue()
	{
		return vtkLegendScaleActor_GetTopBorderOffsetMinValue_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_IsA_40(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLegendScaleActor_IsA_40(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_IsTypeOf_41(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLegendScaleActor_IsTypeOf_41(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_LeftAxisVisibilityOff_42(HandleRef pThis);

	/// <summary>
	/// Set/Get the flags that control which of the four axes to display (top,
	/// bottom, left and right). By default, all the axes are displayed.
	/// </summary>
	public virtual void LeftAxisVisibilityOff()
	{
		vtkLegendScaleActor_LeftAxisVisibilityOff_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_LeftAxisVisibilityOn_43(HandleRef pThis);

	/// <summary>
	/// Set/Get the flags that control which of the four axes to display (top,
	/// bottom, left and right). By default, all the axes are displayed.
	/// </summary>
	public virtual void LeftAxisVisibilityOn()
	{
		vtkLegendScaleActor_LeftAxisVisibilityOn_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_LegendVisibilityOff_44(HandleRef pThis);

	/// <summary>
	/// Indicate whether the legend scale should be displayed or not.
	/// The default is On.
	/// </summary>
	public virtual void LegendVisibilityOff()
	{
		vtkLegendScaleActor_LegendVisibilityOff_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_LegendVisibilityOn_45(HandleRef pThis);

	/// <summary>
	/// Indicate whether the legend scale should be displayed or not.
	/// The default is On.
	/// </summary>
	public virtual void LegendVisibilityOn()
	{
		vtkLegendScaleActor_LegendVisibilityOn_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLegendScaleActor_NewInstance_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new vtkLegendScaleActor NewInstance()
	{
		vtkLegendScaleActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLegendScaleActor_NewInstance_47(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLegendScaleActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_ReleaseGraphicsResources_48(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Standard methods supporting the rendering process.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkLegendScaleActor_ReleaseGraphicsResources_48(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_RenderOpaqueGeometry_49(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Standard methods supporting the rendering process.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkLegendScaleActor_RenderOpaqueGeometry_49(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendScaleActor_RenderOverlay_50(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Standard methods supporting the rendering process.
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkLegendScaleActor_RenderOverlay_50(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_RightAxisVisibilityOff_51(HandleRef pThis);

	/// <summary>
	/// Set/Get the flags that control which of the four axes to display (top,
	/// bottom, left and right). By default, all the axes are displayed.
	/// </summary>
	public virtual void RightAxisVisibilityOff()
	{
		vtkLegendScaleActor_RightAxisVisibilityOff_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_RightAxisVisibilityOn_52(HandleRef pThis);

	/// <summary>
	/// Set/Get the flags that control which of the four axes to display (top,
	/// bottom, left and right). By default, all the axes are displayed.
	/// </summary>
	public virtual void RightAxisVisibilityOn()
	{
		vtkLegendScaleActor_RightAxisVisibilityOn_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLegendScaleActor_SafeDownCast_53(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static vtkLegendScaleActor SafeDownCast(vtkObjectBase o)
	{
		vtkLegendScaleActor vtkLegendScaleActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLegendScaleActor_SafeDownCast_53(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLegendScaleActor2 = (vtkLegendScaleActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLegendScaleActor2.Register(null);
			}
		}
		return vtkLegendScaleActor2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_SetBottomAxisVisibility_54(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flags that control which of the four axes to display (top,
	/// bottom, left and right). By default, all the axes are displayed.
	/// </summary>
	public virtual void SetBottomAxisVisibility(int _arg)
	{
		vtkLegendScaleActor_SetBottomAxisVisibility_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_SetBottomBorderOffset_55(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the offset of the bottom axis from the border. This number is expressed in
	/// pixels, and represents the approximate distance of the axes from the sides
	/// of the renderer. The default is 30.
	/// </summary>
	public virtual void SetBottomBorderOffset(int _arg)
	{
		vtkLegendScaleActor_SetBottomBorderOffset_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_SetCornerOffsetFactor_56(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/Set the corner offset. This is the offset factor used to offset the
	/// axes at the corners. Default value is 2.0.
	/// </summary>
	public virtual void SetCornerOffsetFactor(double _arg)
	{
		vtkLegendScaleActor_SetCornerOffsetFactor_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_SetLabelMode_57(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the mode for labeling the scale axes. By default, the axes are
	/// labeled with the distance between points (centered at a distance of
	/// 0.0). Alternatively if you know that the view is down the z-axis; the
	/// axes can be labeled with x-y coordinate values.
	/// </summary>
	public virtual void SetLabelMode(int _arg)
	{
		vtkLegendScaleActor_SetLabelMode_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_SetLabelModeToDistance_58(HandleRef pThis);

	/// <summary>
	/// Specify the mode for labeling the scale axes. By default, the axes are
	/// labeled with the distance between points (centered at a distance of
	/// 0.0). Alternatively if you know that the view is down the z-axis; the
	/// axes can be labeled with x-y coordinate values.
	/// </summary>
	public void SetLabelModeToDistance()
	{
		vtkLegendScaleActor_SetLabelModeToDistance_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_SetLabelModeToXYCoordinates_59(HandleRef pThis);

	/// <summary>
	/// Specify the mode for labeling the scale axes. By default, the axes are
	/// labeled with the distance between points (centered at a distance of
	/// 0.0). Alternatively if you know that the view is down the z-axis; the
	/// axes can be labeled with x-y coordinate values.
	/// </summary>
	public void SetLabelModeToXYCoordinates()
	{
		vtkLegendScaleActor_SetLabelModeToXYCoordinates_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_SetLeftAxisVisibility_60(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flags that control which of the four axes to display (top,
	/// bottom, left and right). By default, all the axes are displayed.
	/// </summary>
	public virtual void SetLeftAxisVisibility(int _arg)
	{
		vtkLegendScaleActor_SetLeftAxisVisibility_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_SetLeftBorderOffset_61(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the offset of the left axis from the border. This number is expressed in
	/// pixels, and represents the approximate distance of the axes from the sides
	/// of the renderer. The default is 50.
	/// </summary>
	public virtual void SetLeftBorderOffset(int _arg)
	{
		vtkLegendScaleActor_SetLeftBorderOffset_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_SetLegendVisibility_62(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether the legend scale should be displayed or not.
	/// The default is On.
	/// </summary>
	public virtual void SetLegendVisibility(int _arg)
	{
		vtkLegendScaleActor_SetLegendVisibility_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_SetRightAxisVisibility_63(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flags that control which of the four axes to display (top,
	/// bottom, left and right). By default, all the axes are displayed.
	/// </summary>
	public virtual void SetRightAxisVisibility(int _arg)
	{
		vtkLegendScaleActor_SetRightAxisVisibility_63(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_SetRightBorderOffset_64(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the offset of the right axis from the border. This number is expressed in
	/// pixels, and represents the approximate distance of the axes from the sides
	/// of the renderer. The default is 50.
	/// </summary>
	public virtual void SetRightBorderOffset(int _arg)
	{
		vtkLegendScaleActor_SetRightBorderOffset_64(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_SetTopAxisVisibility_65(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flags that control which of the four axes to display (top,
	/// bottom, left and right). By default, all the axes are displayed.
	/// </summary>
	public virtual void SetTopAxisVisibility(int _arg)
	{
		vtkLegendScaleActor_SetTopAxisVisibility_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_SetTopBorderOffset_66(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the offset of the top axis from the border. This number is expressed in
	/// pixels, and represents the approximate distance of the axes from the sides
	/// of the renderer. The default is 30.
	/// </summary>
	public virtual void SetTopBorderOffset(int _arg)
	{
		vtkLegendScaleActor_SetTopBorderOffset_66(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_TopAxisVisibilityOff_67(HandleRef pThis);

	/// <summary>
	/// Set/Get the flags that control which of the four axes to display (top,
	/// bottom, left and right). By default, all the axes are displayed.
	/// </summary>
	public virtual void TopAxisVisibilityOff()
	{
		vtkLegendScaleActor_TopAxisVisibilityOff_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendScaleActor_TopAxisVisibilityOn_68(HandleRef pThis);

	/// <summary>
	/// Set/Get the flags that control which of the four axes to display (top,
	/// bottom, left and right). By default, all the axes are displayed.
	/// </summary>
	public virtual void TopAxisVisibilityOn()
	{
		vtkLegendScaleActor_TopAxisVisibilityOn_68(GetCppThis());
	}
}
