using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImplicitPlaneRepresentation
/// </summary>
/// <remarks>
///    a class defining the representation for a vtkImplicitPlaneWidget2
///
/// This class is a concrete representation for the
/// vtkImplicitPlaneWidget2. It represents an infinite plane defined by a
/// normal and point in the context of a bounding box. Through interaction
/// with the widget, the plane can be manipulated by adjusting the plane
/// normal or moving the origin point.
///
/// To use this representation, you normally define a (plane) origin and (plane)
/// normal. The PlaceWidget() method is also used to initially position the
/// representation.
///
/// @warning
/// This class, and vtkImplicitPlaneWidget2, are next generation VTK
/// widgets. An earlier version of this functionality was defined in the
/// class vtkImplicitPlaneWidget.
///
/// </remarks>
/// <seealso>
///
/// vtkImplicitPlaneWidget2 vtkImplicitPlaneWidget vtkImplicitImageRepresentation
/// </seealso>
public class vtkImplicitPlaneRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public enum InteractionStateType
	{
		/// <summary>enum member</summary>
		Moving = 1,
		/// <summary>enum member</summary>
		MovingOrigin = 3,
		/// <summary>enum member</summary>
		MovingOutline = 2,
		/// <summary>enum member</summary>
		Outside = 0,
		/// <summary>enum member</summary>
		Pushing = 5,
		/// <summary>enum member</summary>
		Rotating = 4,
		/// <summary>enum member</summary>
		Scaling = 6
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitPlaneRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImplicitPlaneRepresentation()
	{
		MRClassNameKey = "class vtkImplicitPlaneRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitPlaneRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImplicitPlaneRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkImplicitPlaneRepresentation New()
	{
		vtkImplicitPlaneRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitPlaneRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkImplicitPlaneRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImplicitPlaneRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Methods to interface with the vtkImplicitPlaneWidget2.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkImplicitPlaneRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_BumpPlane_02(HandleRef pThis, int dir, double factor);

	/// <summary>
	/// Translate the plane in the direction of the normal by the
	/// specified BumpDistance.  The dir parameter controls which
	/// direction the pushing occurs, either in the same direction
	/// as the normal, or when negative, in the opposite direction.
	/// The factor controls whether what percentage of the bump is
	/// used.
	/// </summary>
	public void BumpPlane(int dir, double factor)
	{
		vtkImplicitPlaneRepresentation_BumpPlane_02(GetCppThis(), dir, factor);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_ComplexInteraction_03(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

	/// <summary>
	/// Methods to interface with the vtkImplicitPlaneWidget2.
	/// </summary>
	public override void ComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
	{
		vtkImplicitPlaneRepresentation_ComplexInteraction_03(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_ComputeComplexInteractionState_04(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata, int modify);

	/// <summary>
	/// Methods to interface with the vtkImplicitPlaneWidget2.
	/// </summary>
	public override int ComputeComplexInteractionState(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata, int modify)
	{
		return vtkImplicitPlaneRepresentation_ComputeComplexInteractionState_04(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_ComputeInteractionState_05(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// Methods to interface with the vtkImplicitPlaneWidget2.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkImplicitPlaneRepresentation_ComputeInteractionState_05(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_ConstrainToWidgetBoundsOff_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether the plane should be constrained to the widget bounds.
	/// If on, the origin will not be allowed to move outside the set widget bounds.
	/// This is the default behaviour.
	/// If off, the origin can be freely moved and the widget outline will change
	/// accordingly.
	/// </summary>
	public virtual void ConstrainToWidgetBoundsOff()
	{
		vtkImplicitPlaneRepresentation_ConstrainToWidgetBoundsOff_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_ConstrainToWidgetBoundsOn_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether the plane should be constrained to the widget bounds.
	/// If on, the origin will not be allowed to move outside the set widget bounds.
	/// This is the default behaviour.
	/// If off, the origin can be freely moved and the widget outline will change
	/// accordingly.
	/// </summary>
	public virtual void ConstrainToWidgetBoundsOn()
	{
		vtkImplicitPlaneRepresentation_ConstrainToWidgetBoundsOn_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_CropPlaneToBoundingBoxOff_08(HandleRef pThis);

	/// <summary>
	/// Control if the plane should be drawn cropped by the bounding box
	/// or without cropping. Defaults to on.
	/// </summary>
	public virtual void CropPlaneToBoundingBoxOff()
	{
		vtkImplicitPlaneRepresentation_CropPlaneToBoundingBoxOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_CropPlaneToBoundingBoxOn_09(HandleRef pThis);

	/// <summary>
	/// Control if the plane should be drawn cropped by the bounding box
	/// or without cropping. Defaults to on.
	/// </summary>
	public virtual void CropPlaneToBoundingBoxOn()
	{
		vtkImplicitPlaneRepresentation_CropPlaneToBoundingBoxOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_DrawOutlineOff_10(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the outline.
	/// </summary>
	public virtual void DrawOutlineOff()
	{
		vtkImplicitPlaneRepresentation_DrawOutlineOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_DrawOutlineOn_11(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the outline.
	/// </summary>
	public virtual void DrawOutlineOn()
	{
		vtkImplicitPlaneRepresentation_DrawOutlineOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_DrawPlaneOff_12(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the plane. In some cases the plane
	/// interferes with the object that it is operating on (i.e., the
	/// plane interferes with the cut surface it produces producing
	/// z-buffer artifacts.)
	/// </summary>
	public virtual void DrawPlaneOff()
	{
		vtkImplicitPlaneRepresentation_DrawPlaneOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_DrawPlaneOn_13(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the plane. In some cases the plane
	/// interferes with the object that it is operating on (i.e., the
	/// plane interferes with the cut surface it produces producing
	/// z-buffer artifacts.)
	/// </summary>
	public virtual void DrawPlaneOn()
	{
		vtkImplicitPlaneRepresentation_DrawPlaneOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_EndComplexInteraction_14(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

	/// <summary>
	/// Methods to interface with the vtkImplicitPlaneWidget2.
	/// </summary>
	public override void EndComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
	{
		vtkImplicitPlaneRepresentation_EndComplexInteraction_14(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_EndWidgetInteraction_15(HandleRef pThis, IntPtr newEventPos);

	/// <summary>
	/// Methods to interface with the vtkImplicitPlaneWidget2.
	/// </summary>
	public override void EndWidgetInteraction(IntPtr newEventPos)
	{
		vtkImplicitPlaneRepresentation_EndWidgetInteraction_15(GetCppThis(), newEventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_GetActors_16(HandleRef pThis, HandleRef pc);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override void GetActors(vtkPropCollection pc)
	{
		vtkImplicitPlaneRepresentation_GetActors_16(GetCppThis(), pc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImplicitPlaneRepresentation_GetAlwaysSnapToNearestAxis_17(HandleRef pThis);

	/// <summary>
	/// Forces the plane's normal to be aligned with x, y or z axis.
	/// The alignment happens when calling SetNormal.
	/// It defers with SnapToAxes from it is always applicable, and SnapToAxes
	/// only snaps when the angle difference exceeds 16 degrees in complex interactions.
	/// </summary>
	public virtual bool GetAlwaysSnapToNearestAxis()
	{
		return (vtkImplicitPlaneRepresentation_GetAlwaysSnapToNearestAxis_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneRepresentation_GetBounds_18(HandleRef pThis);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkImplicitPlaneRepresentation_GetBounds_18(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitPlaneRepresentation_GetBumpDistance_19(HandleRef pThis);

	/// <summary>
	/// Specify a translation distance used by the BumpPlane() method. Note that the
	/// distance is normalized; it is the fraction of the length of the bounding
	/// box of the wire outline.
	/// </summary>
	public virtual double GetBumpDistance()
	{
		return vtkImplicitPlaneRepresentation_GetBumpDistance_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitPlaneRepresentation_GetBumpDistanceMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Specify a translation distance used by the BumpPlane() method. Note that the
	/// distance is normalized; it is the fraction of the length of the bounding
	/// box of the wire outline.
	/// </summary>
	public virtual double GetBumpDistanceMaxValue()
	{
		return vtkImplicitPlaneRepresentation_GetBumpDistanceMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitPlaneRepresentation_GetBumpDistanceMinValue_21(HandleRef pThis);

	/// <summary>
	/// Specify a translation distance used by the BumpPlane() method. Note that the
	/// distance is normalized; it is the fraction of the length of the bounding
	/// box of the wire outline.
	/// </summary>
	public virtual double GetBumpDistanceMinValue()
	{
		return vtkImplicitPlaneRepresentation_GetBumpDistanceMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_GetConstrainToWidgetBounds_22(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether the plane should be constrained to the widget bounds.
	/// If on, the origin will not be allowed to move outside the set widget bounds.
	/// This is the default behaviour.
	/// If off, the origin can be freely moved and the widget outline will change
	/// accordingly.
	/// </summary>
	public virtual int GetConstrainToWidgetBounds()
	{
		return vtkImplicitPlaneRepresentation_GetConstrainToWidgetBounds_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImplicitPlaneRepresentation_GetCropPlaneToBoundingBox_23(HandleRef pThis);

	/// <summary>
	/// Control if the plane should be drawn cropped by the bounding box
	/// or without cropping. Defaults to on.
	/// </summary>
	public virtual bool GetCropPlaneToBoundingBox()
	{
		return (vtkImplicitPlaneRepresentation_GetCropPlaneToBoundingBox_23(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_GetDrawOutline_24(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the outline.
	/// </summary>
	public virtual int GetDrawOutline()
	{
		return vtkImplicitPlaneRepresentation_GetDrawOutline_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_GetDrawPlane_25(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the plane. In some cases the plane
	/// interferes with the object that it is operating on (i.e., the
	/// plane interferes with the cut surface it produces producing
	/// z-buffer artifacts.)
	/// </summary>
	public virtual int GetDrawPlane()
	{
		return vtkImplicitPlaneRepresentation_GetDrawPlane_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneRepresentation_GetEdgesProperty_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the property of the intersection edges. (This property also
	/// applies to the edges when tubed.)
	/// </summary>
	public virtual vtkProperty GetEdgesProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneRepresentation_GetEdgesProperty_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_GetInteractionStateMaxValue_27(HandleRef pThis);

	/// <summary>
	/// The interaction state may be set from a widget (e.g.,
	/// vtkImplicitPlaneWidget2) or other object. This controls how the
	/// interaction with the widget proceeds. Normally this method is used as
	/// part of a handshaking process with the widget: First
	/// ComputeInteractionState() is invoked that returns a state based on
	/// geometric considerations (i.e., cursor near a widget feature), then
	/// based on events, the widget may modify this further.
	/// </summary>
	public virtual int GetInteractionStateMaxValue()
	{
		return vtkImplicitPlaneRepresentation_GetInteractionStateMaxValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_GetInteractionStateMinValue_28(HandleRef pThis);

	/// <summary>
	/// The interaction state may be set from a widget (e.g.,
	/// vtkImplicitPlaneWidget2) or other object. This controls how the
	/// interaction with the widget proceeds. Normally this method is used as
	/// part of a handshaking process with the widget: First
	/// ComputeInteractionState() is invoked that returns a state based on
	/// geometric considerations (i.e., cursor near a widget feature), then
	/// based on events, the widget may modify this further.
	/// </summary>
	public virtual int GetInteractionStateMinValue()
	{
		return vtkImplicitPlaneRepresentation_GetInteractionStateMinValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_GetLockNormalToCamera_29(HandleRef pThis);

	/// <summary>
	/// If enabled, and a vtkCamera is available through the renderer, then
	/// LockNormalToCamera will cause the normal to follow the camera's
	/// normal.
	/// </summary>
	public virtual int GetLockNormalToCamera()
	{
		return vtkImplicitPlaneRepresentation_GetLockNormalToCamera_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneRepresentation_GetNormal_30(HandleRef pThis);

	/// <summary>
	/// Get the normal to the plane.
	/// </summary>
	public double[] GetNormal()
	{
		IntPtr intPtr = vtkImplicitPlaneRepresentation_GetNormal_30(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_GetNormal_31(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Get the normal to the plane.
	/// </summary>
	public void GetNormal(IntPtr xyz)
	{
		vtkImplicitPlaneRepresentation_GetNormal_31(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneRepresentation_GetNormalProperty_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the normal (line and cone).
	/// </summary>
	public virtual vtkProperty GetNormalProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneRepresentation_GetNormalProperty_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_GetNormalToXAxis_33(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual int GetNormalToXAxis()
	{
		return vtkImplicitPlaneRepresentation_GetNormalToXAxis_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_GetNormalToYAxis_34(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual int GetNormalToYAxis()
	{
		return vtkImplicitPlaneRepresentation_GetNormalToYAxis_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_GetNormalToZAxis_35(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual int GetNormalToZAxis()
	{
		return vtkImplicitPlaneRepresentation_GetNormalToZAxis_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitPlaneRepresentation_GetNumberOfGenerationsFromBase_36(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImplicitPlaneRepresentation_GetNumberOfGenerationsFromBase_36(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitPlaneRepresentation_GetNumberOfGenerationsFromBaseType_37(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImplicitPlaneRepresentation_GetNumberOfGenerationsFromBaseType_37(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneRepresentation_GetOrigin_38(HandleRef pThis);

	/// <summary>
	/// Get the origin of the plane.
	/// </summary>
	public double[] GetOrigin()
	{
		IntPtr intPtr = vtkImplicitPlaneRepresentation_GetOrigin_38(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_GetOrigin_39(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Get the origin of the plane.
	/// </summary>
	public void GetOrigin(IntPtr xyz)
	{
		vtkImplicitPlaneRepresentation_GetOrigin_39(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneRepresentation_GetOutlineProperty_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the property of the outline.
	/// </summary>
	public virtual vtkProperty GetOutlineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneRepresentation_GetOutlineProperty_40(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_GetOutlineTranslation_41(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to translate the bounding box by grabbing it
	/// with the left mouse button.
	/// </summary>
	public virtual int GetOutlineTranslation()
	{
		return vtkImplicitPlaneRepresentation_GetOutlineTranslation_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_GetOutsideBounds_42(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to move the widget outside of the bounds
	/// specified in the initial PlaceWidget() invocation.
	/// </summary>
	public virtual int GetOutsideBounds()
	{
		return vtkImplicitPlaneRepresentation_GetOutsideBounds_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_GetPlane_43(HandleRef pThis, HandleRef plane);

	/// <summary>
	/// Get the implicit function for the plane by copying the origin and normal
	/// of the cut plane into the provided vtkPlane. The user must provide the
	/// instance of the class vtkPlane. Note that vtkPlane is a subclass of
	/// vtkImplicitFunction, meaning that it can be used by a variety of filters
	/// to perform clipping, cutting, and selection of data.
	/// </summary>
	public void GetPlane(vtkPlane plane)
	{
		vtkImplicitPlaneRepresentation_GetPlane_43(GetCppThis(), plane?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneRepresentation_GetPlaneProperty_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the plane properties. The properties of the plane when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetPlaneProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneRepresentation_GetPlaneProperty_44(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_GetPolyData_45(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Grab the polydata that defines the plane. The polydata contains a single
	/// polygon that is clipped by the bounding box.
	/// </summary>
	public void GetPolyData(vtkPolyData pd)
	{
		vtkImplicitPlaneRepresentation_GetPolyData_45(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneRepresentation_GetPolyDataAlgorithm_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Satisfies superclass API.  This returns a pointer to the underlying
	/// PolyData (which represents the plane).
	/// </summary>
	public vtkPolyDataAlgorithm GetPolyDataAlgorithm()
	{
		vtkPolyDataAlgorithm vtkPolyDataAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneRepresentation_GetPolyDataAlgorithm_46(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataAlgorithm2 = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataAlgorithm2.Register(null);
			}
		}
		return vtkPolyDataAlgorithm2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_GetRepresentationState_47(HandleRef pThis);

	/// <summary>
	/// Sets the visual appearance of the representation based on the
	/// state it is in. This state is usually the same as InteractionState.
	/// </summary>
	public virtual int GetRepresentationState()
	{
		return vtkImplicitPlaneRepresentation_GetRepresentationState_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_GetScaleEnabled_48(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to scale the widget with the mouse.
	/// </summary>
	public virtual int GetScaleEnabled()
	{
		return vtkImplicitPlaneRepresentation_GetScaleEnabled_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneRepresentation_GetSelectedNormalProperty_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the normal (line and cone).
	/// </summary>
	public virtual vtkProperty GetSelectedNormalProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneRepresentation_GetSelectedNormalProperty_49(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneRepresentation_GetSelectedOutlineProperty_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the property of the outline.
	/// </summary>
	public virtual vtkProperty GetSelectedOutlineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneRepresentation_GetSelectedOutlineProperty_50(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneRepresentation_GetSelectedPlaneProperty_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the plane properties. The properties of the plane when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedPlaneProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneRepresentation_GetSelectedPlaneProperty_51(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImplicitPlaneRepresentation_GetSnapToAxes_52(HandleRef pThis);

	/// <summary>
	/// For complex events should we snap orientations to
	/// be aligned with the x y z axes
	/// </summary>
	public virtual bool GetSnapToAxes()
	{
		return (vtkImplicitPlaneRepresentation_GetSnapToAxes_52(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_GetTubing_53(HandleRef pThis);

	/// <summary>
	/// Turn on/off tubing of the wire outline of the plane. The tube thickens
	/// the line by wrapping with a vtkTubeFilter.
	/// </summary>
	public virtual int GetTubing()
	{
		return vtkImplicitPlaneRepresentation_GetTubing_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneRepresentation_GetUnderlyingPlane_54(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Sets the visual appearance of the representation based on the
	/// state it is in. This state is usually the same as InteractionState.
	/// </summary>
	public vtkPlane GetUnderlyingPlane()
	{
		vtkPlane vtkPlane2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneRepresentation_GetUnderlyingPlane_54(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlane2 = (vtkPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlane2.Register(null);
			}
		}
		return vtkPlane2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneRepresentation_GetWidgetBounds_55(HandleRef pThis);

	/// <summary>
	/// Set/Get the bounds of the widget representation. PlaceWidget can also be
	/// used to set the bounds of the widget but it may also have other effects
	/// on the internal state of the representation. Use this function when only
	/// the widget bounds are needs to be modified.
	/// </summary>
	public virtual double[] GetWidgetBounds()
	{
		IntPtr intPtr = vtkImplicitPlaneRepresentation_GetWidgetBounds_55(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_GetWidgetBounds_56(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

	/// <summary>
	/// Set/Get the bounds of the widget representation. PlaceWidget can also be
	/// used to set the bounds of the widget but it may also have other effects
	/// on the internal state of the representation. Use this function when only
	/// the widget bounds are needs to be modified.
	/// </summary>
	public virtual void GetWidgetBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
	{
		vtkImplicitPlaneRepresentation_GetWidgetBounds_56(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_GetWidgetBounds_57(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the bounds of the widget representation. PlaceWidget can also be
	/// used to set the bounds of the widget but it may also have other effects
	/// on the internal state of the representation. Use this function when only
	/// the widget bounds are needs to be modified.
	/// </summary>
	public virtual void GetWidgetBounds(IntPtr _arg)
	{
		vtkImplicitPlaneRepresentation_GetWidgetBounds_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_HasTranslucentPolygonalGeometry_58(HandleRef pThis);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkImplicitPlaneRepresentation_HasTranslucentPolygonalGeometry_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_IsA_59(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImplicitPlaneRepresentation_IsA_59(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImplicitPlaneRepresentation_IsTranslationConstrained_60(HandleRef pThis);

	/// <summary>
	/// Returns true if ConstrainedAxis
	/// </summary>
	public bool IsTranslationConstrained()
	{
		return (vtkImplicitPlaneRepresentation_IsTranslationConstrained_60(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_IsTypeOf_61(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImplicitPlaneRepresentation_IsTypeOf_61(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_LockNormalToCameraOff_62(HandleRef pThis);

	/// <summary>
	/// If enabled, and a vtkCamera is available through the renderer, then
	/// LockNormalToCamera will cause the normal to follow the camera's
	/// normal.
	/// </summary>
	public virtual void LockNormalToCameraOff()
	{
		vtkImplicitPlaneRepresentation_LockNormalToCameraOff_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_LockNormalToCameraOn_63(HandleRef pThis);

	/// <summary>
	/// If enabled, and a vtkCamera is available through the renderer, then
	/// LockNormalToCamera will cause the normal to follow the camera's
	/// normal.
	/// </summary>
	public virtual void LockNormalToCameraOn()
	{
		vtkImplicitPlaneRepresentation_LockNormalToCameraOn_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneRepresentation_NewInstance_65(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new vtkImplicitPlaneRepresentation NewInstance()
	{
		vtkImplicitPlaneRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneRepresentation_NewInstance_65(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitPlaneRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_NormalToXAxisOff_66(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToXAxisOff()
	{
		vtkImplicitPlaneRepresentation_NormalToXAxisOff_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_NormalToXAxisOn_67(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToXAxisOn()
	{
		vtkImplicitPlaneRepresentation_NormalToXAxisOn_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_NormalToYAxisOff_68(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToYAxisOff()
	{
		vtkImplicitPlaneRepresentation_NormalToYAxisOff_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_NormalToYAxisOn_69(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToYAxisOn()
	{
		vtkImplicitPlaneRepresentation_NormalToYAxisOn_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_NormalToZAxisOff_70(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToZAxisOff()
	{
		vtkImplicitPlaneRepresentation_NormalToZAxisOff_70(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_NormalToZAxisOn_71(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToZAxisOn()
	{
		vtkImplicitPlaneRepresentation_NormalToZAxisOn_71(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_OutlineTranslationOff_72(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to translate the bounding box by grabbing it
	/// with the left mouse button.
	/// </summary>
	public virtual void OutlineTranslationOff()
	{
		vtkImplicitPlaneRepresentation_OutlineTranslationOff_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_OutlineTranslationOn_73(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to translate the bounding box by grabbing it
	/// with the left mouse button.
	/// </summary>
	public virtual void OutlineTranslationOn()
	{
		vtkImplicitPlaneRepresentation_OutlineTranslationOn_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_OutsideBoundsOff_74(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to move the widget outside of the bounds
	/// specified in the initial PlaceWidget() invocation.
	/// </summary>
	public virtual void OutsideBoundsOff()
	{
		vtkImplicitPlaneRepresentation_OutsideBoundsOff_74(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_OutsideBoundsOn_75(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to move the widget outside of the bounds
	/// specified in the initial PlaceWidget() invocation.
	/// </summary>
	public virtual void OutsideBoundsOn()
	{
		vtkImplicitPlaneRepresentation_OutsideBoundsOn_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_PlaceWidget_76(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods to interface with the vtkImplicitPlaneWidget2.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkImplicitPlaneRepresentation_PlaceWidget_76(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_PushPlane_77(HandleRef pThis, double distance);

	/// <summary>
	/// Push the plane the distance specified along the normal. Positive
	/// values are in the direction of the normal; negative values are
	/// in the opposite direction of the normal. The distance value is
	/// expressed in world coordinates.
	/// </summary>
	public void PushPlane(double distance)
	{
		vtkImplicitPlaneRepresentation_PushPlane_77(GetCppThis(), distance);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_ReleaseGraphicsResources_78(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkImplicitPlaneRepresentation_ReleaseGraphicsResources_78(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_RenderOpaqueGeometry_79(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkImplicitPlaneRepresentation_RenderOpaqueGeometry_79(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneRepresentation_RenderTranslucentPolygonalGeometry_80(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkImplicitPlaneRepresentation_RenderTranslucentPolygonalGeometry_80(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneRepresentation_SafeDownCast_81(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static vtkImplicitPlaneRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkImplicitPlaneRepresentation vtkImplicitPlaneRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneRepresentation_SafeDownCast_81(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitPlaneRepresentation2 = (vtkImplicitPlaneRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitPlaneRepresentation2.Register(null);
			}
		}
		return vtkImplicitPlaneRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_ScaleEnabledOff_82(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to scale the widget with the mouse.
	/// </summary>
	public virtual void ScaleEnabledOff()
	{
		vtkImplicitPlaneRepresentation_ScaleEnabledOff_82(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_ScaleEnabledOn_83(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to scale the widget with the mouse.
	/// </summary>
	public virtual void ScaleEnabledOn()
	{
		vtkImplicitPlaneRepresentation_ScaleEnabledOn_83(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetAlwaysSnapToNearestAxis_84(HandleRef pThis, byte snap);

	/// <summary>
	/// Forces the plane's normal to be aligned with x, y or z axis.
	/// The alignment happens when calling SetNormal.
	/// It defers with SnapToAxes from it is always applicable, and SnapToAxes
	/// only snaps when the angle difference exceeds 16 degrees in complex interactions.
	/// </summary>
	public virtual void SetAlwaysSnapToNearestAxis(bool snap)
	{
		vtkImplicitPlaneRepresentation_SetAlwaysSnapToNearestAxis_84(GetCppThis(), (byte)(snap ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetBumpDistance_85(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify a translation distance used by the BumpPlane() method. Note that the
	/// distance is normalized; it is the fraction of the length of the bounding
	/// box of the wire outline.
	/// </summary>
	public virtual void SetBumpDistance(double _arg)
	{
		vtkImplicitPlaneRepresentation_SetBumpDistance_85(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetConstrainToWidgetBounds_86(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off whether the plane should be constrained to the widget bounds.
	/// If on, the origin will not be allowed to move outside the set widget bounds.
	/// This is the default behaviour.
	/// If off, the origin can be freely moved and the widget outline will change
	/// accordingly.
	/// </summary>
	public virtual void SetConstrainToWidgetBounds(int _arg)
	{
		vtkImplicitPlaneRepresentation_SetConstrainToWidgetBounds_86(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetCropPlaneToBoundingBox_87(HandleRef pThis, byte arg0);

	/// <summary>
	/// Control if the plane should be drawn cropped by the bounding box
	/// or without cropping. Defaults to on.
	/// </summary>
	public virtual void SetCropPlaneToBoundingBox(bool arg0)
	{
		vtkImplicitPlaneRepresentation_SetCropPlaneToBoundingBox_87(GetCppThis(), (byte)(arg0 ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetDrawOutline_88(HandleRef pThis, int plane);

	/// <summary>
	/// Enable/disable the drawing of the outline.
	/// </summary>
	public void SetDrawOutline(int plane)
	{
		vtkImplicitPlaneRepresentation_SetDrawOutline_88(GetCppThis(), plane);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetDrawPlane_89(HandleRef pThis, int plane);

	/// <summary>
	/// Enable/disable the drawing of the plane. In some cases the plane
	/// interferes with the object that it is operating on (i.e., the
	/// plane interferes with the cut surface it produces producing
	/// z-buffer artifacts.)
	/// </summary>
	public void SetDrawPlane(int plane)
	{
		vtkImplicitPlaneRepresentation_SetDrawPlane_89(GetCppThis(), plane);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetEdgeColor_90(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set color to the edge
	/// </summary>
	public void SetEdgeColor(vtkLookupTable arg0)
	{
		vtkImplicitPlaneRepresentation_SetEdgeColor_90(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetEdgeColor_91(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Set color to the edge
	/// </summary>
	public void SetEdgeColor(double arg0, double arg1, double arg2)
	{
		vtkImplicitPlaneRepresentation_SetEdgeColor_91(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetEdgeColor_92(HandleRef pThis, IntPtr c);

	/// <summary>
	/// Set color to the edge
	/// </summary>
	public void SetEdgeColor(IntPtr c)
	{
		vtkImplicitPlaneRepresentation_SetEdgeColor_92(GetCppThis(), c);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetInteractionState_93(HandleRef pThis, int _arg);

	/// <summary>
	/// The interaction state may be set from a widget (e.g.,
	/// vtkImplicitPlaneWidget2) or other object. This controls how the
	/// interaction with the widget proceeds. Normally this method is used as
	/// part of a handshaking process with the widget: First
	/// ComputeInteractionState() is invoked that returns a state based on
	/// geometric considerations (i.e., cursor near a widget feature), then
	/// based on events, the widget may modify this further.
	/// </summary>
	public virtual void SetInteractionState(int _arg)
	{
		vtkImplicitPlaneRepresentation_SetInteractionState_93(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetLockNormalToCamera_94(HandleRef pThis, int arg0);

	/// <summary>
	/// If enabled, and a vtkCamera is available through the renderer, then
	/// LockNormalToCamera will cause the normal to follow the camera's
	/// normal.
	/// </summary>
	public virtual void SetLockNormalToCamera(int arg0)
	{
		vtkImplicitPlaneRepresentation_SetLockNormalToCamera_94(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetNormal_95(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Get the normal to the plane.
	/// </summary>
	public void SetNormal(double x, double y, double z)
	{
		vtkImplicitPlaneRepresentation_SetNormal_95(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetNormal_96(HandleRef pThis, IntPtr n);

	/// <summary>
	/// Get the normal to the plane.
	/// </summary>
	public void SetNormal(IntPtr n)
	{
		vtkImplicitPlaneRepresentation_SetNormal_96(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetNormalToCamera_97(HandleRef pThis);

	/// <summary>
	/// Get the normal to the plane.
	/// </summary>
	public void SetNormalToCamera()
	{
		vtkImplicitPlaneRepresentation_SetNormalToCamera_97(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetNormalToXAxis_98(HandleRef pThis, int arg0);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public void SetNormalToXAxis(int arg0)
	{
		vtkImplicitPlaneRepresentation_SetNormalToXAxis_98(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetNormalToYAxis_99(HandleRef pThis, int arg0);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public void SetNormalToYAxis(int arg0)
	{
		vtkImplicitPlaneRepresentation_SetNormalToYAxis_99(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetNormalToZAxis_100(HandleRef pThis, int arg0);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public void SetNormalToZAxis(int arg0)
	{
		vtkImplicitPlaneRepresentation_SetNormalToZAxis_100(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetOrigin_101(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Get the origin of the plane.
	/// </summary>
	public void SetOrigin(double x, double y, double z)
	{
		vtkImplicitPlaneRepresentation_SetOrigin_101(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetOrigin_102(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Get the origin of the plane.
	/// </summary>
	public void SetOrigin(IntPtr x)
	{
		vtkImplicitPlaneRepresentation_SetOrigin_102(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetOutlineTranslation_103(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the ability to translate the bounding box by grabbing it
	/// with the left mouse button.
	/// </summary>
	public virtual void SetOutlineTranslation(int _arg)
	{
		vtkImplicitPlaneRepresentation_SetOutlineTranslation_103(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetOutsideBounds_104(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the ability to move the widget outside of the bounds
	/// specified in the initial PlaceWidget() invocation.
	/// </summary>
	public virtual void SetOutsideBounds(int _arg)
	{
		vtkImplicitPlaneRepresentation_SetOutsideBounds_104(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetPlane_105(HandleRef pThis, HandleRef plane);

	/// <summary>
	/// Alternative way to define the cutting plane. The normal and origin of
	/// the plane provided is copied into the internal instance of the class
	/// cutting vtkPlane.
	/// </summary>
	public void SetPlane(vtkPlane plane)
	{
		vtkImplicitPlaneRepresentation_SetPlane_105(GetCppThis(), plane?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetRepresentationState_106(HandleRef pThis, int arg0);

	/// <summary>
	/// Sets the visual appearance of the representation based on the
	/// state it is in. This state is usually the same as InteractionState.
	/// </summary>
	public virtual void SetRepresentationState(int arg0)
	{
		vtkImplicitPlaneRepresentation_SetRepresentationState_106(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetScaleEnabled_107(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the ability to scale the widget with the mouse.
	/// </summary>
	public virtual void SetScaleEnabled(int _arg)
	{
		vtkImplicitPlaneRepresentation_SetScaleEnabled_107(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetSnapToAxes_108(HandleRef pThis, byte _arg);

	/// <summary>
	/// For complex events should we snap orientations to
	/// be aligned with the x y z axes
	/// </summary>
	public virtual void SetSnapToAxes(bool _arg)
	{
		vtkImplicitPlaneRepresentation_SetSnapToAxes_108(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetTranslationAxisOff_109(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetTranslationAxisOff()
	{
		vtkImplicitPlaneRepresentation_SetTranslationAxisOff_109(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetTubing_110(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off tubing of the wire outline of the plane. The tube thickens
	/// the line by wrapping with a vtkTubeFilter.
	/// </summary>
	public virtual void SetTubing(int _arg)
	{
		vtkImplicitPlaneRepresentation_SetTubing_110(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetWidgetBounds_111(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set/Get the bounds of the widget representation. PlaceWidget can also be
	/// used to set the bounds of the widget but it may also have other effects
	/// on the internal state of the representation. Use this function when only
	/// the widget bounds are needs to be modified.
	/// </summary>
	public virtual void SetWidgetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkImplicitPlaneRepresentation_SetWidgetBounds_111(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetWidgetBounds_112(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the bounds of the widget representation. PlaceWidget can also be
	/// used to set the bounds of the widget but it may also have other effects
	/// on the internal state of the representation. Use this function when only
	/// the widget bounds are needs to be modified.
	/// </summary>
	public virtual void SetWidgetBounds(IntPtr _arg)
	{
		vtkImplicitPlaneRepresentation_SetWidgetBounds_112(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetXTranslationAxisOn_113(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetXTranslationAxisOn()
	{
		vtkImplicitPlaneRepresentation_SetXTranslationAxisOn_113(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetYTranslationAxisOn_114(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetYTranslationAxisOn()
	{
		vtkImplicitPlaneRepresentation_SetYTranslationAxisOn_114(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_SetZTranslationAxisOn_115(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetZTranslationAxisOn()
	{
		vtkImplicitPlaneRepresentation_SetZTranslationAxisOn_115(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_StartComplexInteraction_116(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

	/// <summary>
	/// Methods to interface with the vtkImplicitPlaneWidget2.
	/// </summary>
	public override void StartComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
	{
		vtkImplicitPlaneRepresentation_StartComplexInteraction_116(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_StartWidgetInteraction_117(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to interface with the vtkImplicitPlaneWidget2.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr eventPos)
	{
		vtkImplicitPlaneRepresentation_StartWidgetInteraction_117(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_TubingOff_118(HandleRef pThis);

	/// <summary>
	/// Turn on/off tubing of the wire outline of the plane. The tube thickens
	/// the line by wrapping with a vtkTubeFilter.
	/// </summary>
	public virtual void TubingOff()
	{
		vtkImplicitPlaneRepresentation_TubingOff_118(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_TubingOn_119(HandleRef pThis);

	/// <summary>
	/// Turn on/off tubing of the wire outline of the plane. The tube thickens
	/// the line by wrapping with a vtkTubeFilter.
	/// </summary>
	public virtual void TubingOn()
	{
		vtkImplicitPlaneRepresentation_TubingOn_119(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_UpdatePlacement_120(HandleRef pThis);

	/// <summary>
	/// Satisfies the superclass API.  This will change the state of the widget
	/// to match changes that have been made to the underlying PolyDataSource
	/// </summary>
	public void UpdatePlacement()
	{
		vtkImplicitPlaneRepresentation_UpdatePlacement_120(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneRepresentation_WidgetInteraction_121(HandleRef pThis, IntPtr newEventPos);

	/// <summary>
	/// Methods to interface with the vtkImplicitPlaneWidget2.
	/// </summary>
	public override void WidgetInteraction(IntPtr newEventPos)
	{
		vtkImplicitPlaneRepresentation_WidgetInteraction_121(GetCppThis(), newEventPos);
	}
}
