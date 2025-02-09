using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDisplaySizedImplicitPlaneRepresentation
/// </summary>
/// <remarks>
///    a class defining the representation for a vtkDisplaySizedImplicitPlaneWidget
///
/// This class is a concrete representation for the
/// vtkDisplaySizedImplicitPlaneWidget. It represents an display sized disk plane defined
/// by a normal and point. Through interaction with the widget, the plane can be manipulated
/// by adjusting the plane normal, disk radius or moving/picking the origin point.
///
/// To use this representation, you normally define a (plane) origin and (plane)
/// normal. The PlaceWidget() method is also used to initially position the
/// representation.
///
/// @warning
/// This class, and vtkDisplaySizedImplicitPlaneWidget, are next generation VTK
/// widgets.
///
/// </remarks>
/// <seealso>
///
/// vtkDisplaySizedImplicitPlaneWidget vtkImplicitPlaneWidget2 vtkImplicitPlaneWidget
/// vtkImplicitImageRepresentation
/// </seealso>
public class vtkDisplaySizedImplicitPlaneRepresentation : vtkWidgetRepresentation
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
		ResizeDiskRadius = 6,
		/// <summary>enum member</summary>
		Rotating = 4,
		/// <summary>enum member</summary>
		Scaling = 7
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDisplaySizedImplicitPlaneRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDisplaySizedImplicitPlaneRepresentation()
	{
		MRClassNameKey = "class vtkDisplaySizedImplicitPlaneRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDisplaySizedImplicitPlaneRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDisplaySizedImplicitPlaneRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkDisplaySizedImplicitPlaneRepresentation New()
	{
		vtkDisplaySizedImplicitPlaneRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDisplaySizedImplicitPlaneRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkDisplaySizedImplicitPlaneRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDisplaySizedImplicitPlaneRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Methods to interface with the vtkDisplaySizedImplicitPlaneWidget.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_BumpPlane_02(HandleRef pThis, int dir, double factor);

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
		vtkDisplaySizedImplicitPlaneRepresentation_BumpPlane_02(GetCppThis(), dir, factor);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_ComplexInteraction_03(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

	/// <summary>
	/// Methods to interface with the vtkDisplaySizedImplicitPlaneWidget.
	/// </summary>
	public override void ComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_ComplexInteraction_03(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_ComputeComplexInteractionState_04(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata, int modify);

	/// <summary>
	/// Methods to interface with the vtkDisplaySizedImplicitPlaneWidget.
	/// </summary>
	public override int ComputeComplexInteractionState(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata, int modify)
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_ComputeComplexInteractionState_04(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_ComputeInteractionState_05(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// Methods to interface with the vtkDisplaySizedImplicitPlaneWidget.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_ComputeInteractionState_05(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_ConstrainMaximumSizeToWidgetBoundsOff_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether the maximum widget size should be constrained to the widget bounds.
	/// If on, the radius of the disk plane and plane normal arrow will not be allowed to be larger
	/// than the half diagonal of the bounding box formed by the widget bounds.
	/// If off, the radius of the disk plane and plane normal arrow can be arbitrary big
	/// The default behaviour is off.
	/// </summary>
	public virtual void ConstrainMaximumSizeToWidgetBoundsOff()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_ConstrainMaximumSizeToWidgetBoundsOff_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_ConstrainMaximumSizeToWidgetBoundsOn_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether the maximum widget size should be constrained to the widget bounds.
	/// If on, the radius of the disk plane and plane normal arrow will not be allowed to be larger
	/// than the half diagonal of the bounding box formed by the widget bounds.
	/// If off, the radius of the disk plane and plane normal arrow can be arbitrary big
	/// The default behaviour is off.
	/// </summary>
	public virtual void ConstrainMaximumSizeToWidgetBoundsOn()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_ConstrainMaximumSizeToWidgetBoundsOn_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_ConstrainToWidgetBoundsOff_08(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether the plane should be constrained to the widget bounds.
	/// If on, the origin will not be allowed to move outside the set widget bounds.
	/// The default behaviour is off.
	/// If off, the origin can be freely moved and the widget outline will change
	/// accordingly.
	/// </summary>
	public virtual void ConstrainToWidgetBoundsOff()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_ConstrainToWidgetBoundsOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_ConstrainToWidgetBoundsOn_09(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether the plane should be constrained to the widget bounds.
	/// If on, the origin will not be allowed to move outside the set widget bounds.
	/// The default behaviour is off.
	/// If off, the origin can be freely moved and the widget outline will change
	/// accordingly.
	/// </summary>
	public virtual void ConstrainToWidgetBoundsOn()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_ConstrainToWidgetBoundsOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_DrawIntersectionEdgesOff_10(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the intersection edges. Default is off.
	///
	/// Note: drawing the intersection edges requires DrawOutline to be on.
	/// </summary>
	public virtual void DrawIntersectionEdgesOff()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_DrawIntersectionEdgesOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_DrawIntersectionEdgesOn_11(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the intersection edges. Default is off.
	///
	/// Note: drawing the intersection edges requires DrawOutline to be on.
	/// </summary>
	public virtual void DrawIntersectionEdgesOn()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_DrawIntersectionEdgesOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_DrawOutlineOff_12(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the outline. Default is off.
	/// </summary>
	public virtual void DrawOutlineOff()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_DrawOutlineOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_DrawOutlineOn_13(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the outline. Default is off.
	/// </summary>
	public virtual void DrawOutlineOn()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_DrawOutlineOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_DrawPlaneOff_14(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the plane. In some cases the plane
	/// interferes with the object that it is operating on (i.e., the
	/// plane interferes with the cut surface it produces producing
	/// z-buffer artifacts.)
	/// </summary>
	public virtual void DrawPlaneOff()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_DrawPlaneOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_DrawPlaneOn_15(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the plane. In some cases the plane
	/// interferes with the object that it is operating on (i.e., the
	/// plane interferes with the cut surface it produces producing
	/// z-buffer artifacts.)
	/// </summary>
	public virtual void DrawPlaneOn()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_DrawPlaneOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_EndComplexInteraction_16(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

	/// <summary>
	/// Methods to interface with the vtkDisplaySizedImplicitPlaneWidget.
	/// </summary>
	public override void EndComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_EndComplexInteraction_16(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_EndWidgetInteraction_17(HandleRef pThis, IntPtr newEventPos);

	/// <summary>
	/// Methods to interface with the vtkDisplaySizedImplicitPlaneWidget.
	/// </summary>
	public override void EndWidgetInteraction(IntPtr newEventPos)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_EndWidgetInteraction_17(GetCppThis(), newEventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_GetActors_18(HandleRef pThis, HandleRef pc);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override void GetActors(vtkPropCollection pc)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_GetActors_18(GetCppThis(), pc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDisplaySizedImplicitPlaneRepresentation_GetAlwaysSnapToNearestAxis_19(HandleRef pThis);

	/// <summary>
	/// Forces the plane's normal to be aligned with x, y or z axis.
	/// The alignment happens when calling SetNormal.
	/// It defers with SnapToAxes from it is always applicable, and SnapToAxes
	/// only snaps when the angle difference exceeds 16 degrees in complex interactions.
	/// </summary>
	public virtual bool GetAlwaysSnapToNearestAxis()
	{
		return (vtkDisplaySizedImplicitPlaneRepresentation_GetAlwaysSnapToNearestAxis_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetBounds_20(HandleRef pThis);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation_GetBounds_20(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDisplaySizedImplicitPlaneRepresentation_GetBumpDistance_21(HandleRef pThis);

	/// <summary>
	/// Specify a translation distance used by the BumpPlane() method. Note that the
	/// distance is normalized; it is the fraction of the length of the bounding
	/// box of the wire outline.
	/// </summary>
	public virtual double GetBumpDistance()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetBumpDistance_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDisplaySizedImplicitPlaneRepresentation_GetBumpDistanceMaxValue_22(HandleRef pThis);

	/// <summary>
	/// Specify a translation distance used by the BumpPlane() method. Note that the
	/// distance is normalized; it is the fraction of the length of the bounding
	/// box of the wire outline.
	/// </summary>
	public virtual double GetBumpDistanceMaxValue()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetBumpDistanceMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDisplaySizedImplicitPlaneRepresentation_GetBumpDistanceMinValue_23(HandleRef pThis);

	/// <summary>
	/// Specify a translation distance used by the BumpPlane() method. Note that the
	/// distance is normalized; it is the fraction of the length of the bounding
	/// box of the wire outline.
	/// </summary>
	public virtual double GetBumpDistanceMinValue()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetBumpDistanceMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetConstrainMaximumSizeToWidgetBounds_24(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether the maximum widget size should be constrained to the widget bounds.
	/// If on, the radius of the disk plane and plane normal arrow will not be allowed to be larger
	/// than the half diagonal of the bounding box formed by the widget bounds.
	/// If off, the radius of the disk plane and plane normal arrow can be arbitrary big
	/// The default behaviour is off.
	/// </summary>
	public virtual int GetConstrainMaximumSizeToWidgetBounds()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetConstrainMaximumSizeToWidgetBounds_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetConstrainToWidgetBounds_25(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether the plane should be constrained to the widget bounds.
	/// If on, the origin will not be allowed to move outside the set widget bounds.
	/// The default behaviour is off.
	/// If off, the origin can be freely moved and the widget outline will change
	/// accordingly.
	/// </summary>
	public virtual int GetConstrainToWidgetBounds()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetConstrainToWidgetBounds_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetDrawIntersectionEdges_26(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the intersection edges. Default is off.
	///
	/// Note: drawing the intersection edges requires DrawOutline to be on.
	/// </summary>
	public virtual int GetDrawIntersectionEdges()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetDrawIntersectionEdges_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetDrawOutline_27(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the outline. Default is off.
	/// </summary>
	public virtual int GetDrawOutline()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetDrawOutline_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetDrawPlane_28(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the plane. In some cases the plane
	/// interferes with the object that it is operating on (i.e., the
	/// plane interferes with the cut surface it produces producing
	/// z-buffer artifacts.)
	/// </summary>
	public virtual int GetDrawPlane()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetDrawPlane_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetEdgesProperty_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the property of the disk edges. The properties of the edges when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetEdgesProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation_GetEdgesProperty_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetInteractionStateMaxValue_30(HandleRef pThis);

	/// <summary>
	/// The interaction state may be set from a widget (e.g.,
	/// vtkDisplaySizedImplicitPlaneWidget) or other object. This controls how the
	/// interaction with the widget proceeds. Normally this method is used as
	/// part of a handshaking process with the widget: First
	/// ComputeInteractionState() is invoked that returns a state based on
	/// geometric considerations (i.e., cursor near a widget feature), then
	/// based on events, the widget may modify this further.
	/// </summary>
	public virtual int GetInteractionStateMaxValue()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetInteractionStateMaxValue_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetInteractionStateMinValue_31(HandleRef pThis);

	/// <summary>
	/// The interaction state may be set from a widget (e.g.,
	/// vtkDisplaySizedImplicitPlaneWidget) or other object. This controls how the
	/// interaction with the widget proceeds. Normally this method is used as
	/// part of a handshaking process with the widget: First
	/// ComputeInteractionState() is invoked that returns a state based on
	/// geometric considerations (i.e., cursor near a widget feature), then
	/// based on events, the widget may modify this further.
	/// </summary>
	public virtual int GetInteractionStateMinValue()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetInteractionStateMinValue_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetIntersectionEdgesProperty_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the property of the intersection edges of the plane with the outline.
	/// </summary>
	public virtual vtkProperty GetIntersectionEdgesProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation_GetIntersectionEdgesProperty_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetLockNormalToCamera_33(HandleRef pThis);

	/// <summary>
	/// If enabled, and a vtkCamera is available through the renderer, then
	/// LockNormalToCamera will cause the normal to follow the camera's
	/// normal.
	/// </summary>
	public virtual int GetLockNormalToCamera()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetLockNormalToCamera_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetNormal_34(HandleRef pThis);

	/// <summary>
	/// Set/Get the normal to the plane.
	/// </summary>
	public IntPtr GetNormal()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetNormal_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_GetNormal_35(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Set/Get the normal to the plane.
	/// </summary>
	public void GetNormal(IntPtr xyz)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_GetNormal_35(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetNormalProperty_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the normal (line and cone). The properties of the normal when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetNormalProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation_GetNormalProperty_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetNormalToXAxis_37(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual int GetNormalToXAxis()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetNormalToXAxis_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetNormalToYAxis_38(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual int GetNormalToYAxis()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetNormalToYAxis_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetNormalToZAxis_39(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual int GetNormalToZAxis()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetNormalToZAxis_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDisplaySizedImplicitPlaneRepresentation_GetNumberOfGenerationsFromBase_40(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetNumberOfGenerationsFromBase_40(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDisplaySizedImplicitPlaneRepresentation_GetNumberOfGenerationsFromBaseType_41(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetNumberOfGenerationsFromBaseType_41(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetOrigin_42(HandleRef pThis);

	/// <summary>
	/// Set/Get the origin of the plane.
	/// </summary>
	public IntPtr GetOrigin()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetOrigin_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_GetOrigin_43(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Set/Get the origin of the plane.
	/// </summary>
	public void GetOrigin(IntPtr xyz)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_GetOrigin_43(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetOutlineProperty_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the property of the outline.
	/// </summary>
	public virtual vtkProperty GetOutlineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation_GetOutlineProperty_44(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetOutlineTranslation_45(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to translate the bounding box by grabbing it
	/// with the left mouse button. Default is off.
	/// </summary>
	public virtual int GetOutlineTranslation()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetOutlineTranslation_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetOutsideBounds_46(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to move the widget outside of the bounds
	/// specified in the initial PlaceWidget() invocation.
	/// </summary>
	public virtual int GetOutsideBounds()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetOutsideBounds_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDisplaySizedImplicitPlaneRepresentation_GetPickCameraFocalInfo_47(HandleRef pThis);

	/// <summary>
	/// Enable/Disable picking camera focal info if no result is available for PickOrigin and
	/// PickNormal. The default is disabled.
	/// </summary>
	public virtual bool GetPickCameraFocalInfo()
	{
		return (vtkDisplaySizedImplicitPlaneRepresentation_GetPickCameraFocalInfo_47(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_GetPlane_48(HandleRef pThis, HandleRef plane);

	/// <summary>
	/// Get the implicit function for the plane by copying the origin and normal
	/// of the cut plane into the provided vtkPlane. The user must provide the
	/// instance of the class vtkPlane. Note that vtkPlane is a subclass of
	/// vtkImplicitFunction, meaning that it can be used by a variety of filters
	/// to perform clipping, cutting, and selection of data.
	/// </summary>
	public void GetPlane(vtkPlane plane)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_GetPlane_48(GetCppThis(), plane?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetPlaneProperty_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation_GetPlaneProperty_49(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_GetPolyData_50(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Grab the polydata that defines the plane. The polydata contains a single
	/// polygon that is clipped by the bounding box.
	/// </summary>
	public void GetPolyData(vtkPolyData pd)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_GetPolyData_50(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetPolyDataAlgorithm_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation_GetPolyDataAlgorithm_51(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkDisplaySizedImplicitPlaneRepresentation_GetRadiusMultiplier_52(HandleRef pThis);

	/// <summary>
	/// Set/Get the Radius Multiplier value. Default is 1.0.
	/// </summary>
	public virtual double GetRadiusMultiplier()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetRadiusMultiplier_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDisplaySizedImplicitPlaneRepresentation_GetRadiusMultiplierMaxValue_53(HandleRef pThis);

	/// <summary>
	/// Set/Get the Radius Multiplier value. Default is 1.0.
	/// </summary>
	public virtual double GetRadiusMultiplierMaxValue()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetRadiusMultiplierMaxValue_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDisplaySizedImplicitPlaneRepresentation_GetRadiusMultiplierMinValue_54(HandleRef pThis);

	/// <summary>
	/// Set/Get the Radius Multiplier value. Default is 1.0.
	/// </summary>
	public virtual double GetRadiusMultiplierMinValue()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetRadiusMultiplierMinValue_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetRepresentationState_55(HandleRef pThis);

	/// <summary>
	/// Sets the visual appearance of the representation based on the
	/// state it is in. This state is usually the same as InteractionState.
	/// </summary>
	public virtual int GetRepresentationState()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetRepresentationState_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetScaleEnabled_56(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to scale the widget with the mouse.
	/// </summary>
	public virtual int GetScaleEnabled()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_GetScaleEnabled_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetSelectedEdgesProperty_57(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the property of the disk edges. The properties of the edges when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedEdgesProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation_GetSelectedEdgesProperty_57(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetSelectedNormalProperty_58(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the normal (line and cone). The properties of the normal when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedNormalProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation_GetSelectedNormalProperty_58(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetSelectedOutlineProperty_59(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the property of the outline.
	/// </summary>
	public virtual vtkProperty GetSelectedOutlineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation_GetSelectedOutlineProperty_59(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetSelectedPlaneProperty_60(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation_GetSelectedPlaneProperty_60(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetSelectedSphereProperty_61(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the sphere. The properties of the sphere when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedSphereProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation_GetSelectedSphereProperty_61(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkDisplaySizedImplicitPlaneRepresentation_GetSnapToAxes_62(HandleRef pThis);

	/// <summary>
	/// For complex events should we snap orientations to
	/// be aligned with the x y z axes.
	/// </summary>
	public virtual bool GetSnapToAxes()
	{
		return (vtkDisplaySizedImplicitPlaneRepresentation_GetSnapToAxes_62(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetSphereProperty_63(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the sphere. The properties of the sphere when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSphereProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation_GetSphereProperty_63(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetUnderlyingPlane_64(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation_GetUnderlyingPlane_64(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetWidgetBounds_65(HandleRef pThis);

	/// <summary>
	/// Set/Get the bounds of the widget representation. PlaceWidget can also be
	/// used to set the bounds of the widget but it may also have other effects
	/// on the internal state of the representation. Use this function when only
	/// the widget bounds need to be modified.
	/// </summary>
	public virtual double[] GetWidgetBounds()
	{
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation_GetWidgetBounds_65(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_GetWidgetBounds_66(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

	/// <summary>
	/// Set/Get the bounds of the widget representation. PlaceWidget can also be
	/// used to set the bounds of the widget but it may also have other effects
	/// on the internal state of the representation. Use this function when only
	/// the widget bounds need to be modified.
	/// </summary>
	public virtual void GetWidgetBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_GetWidgetBounds_66(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_GetWidgetBounds_67(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the bounds of the widget representation. PlaceWidget can also be
	/// used to set the bounds of the widget but it may also have other effects
	/// on the internal state of the representation. Use this function when only
	/// the widget bounds need to be modified.
	/// </summary>
	public virtual void GetWidgetBounds(IntPtr _arg)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_GetWidgetBounds_67(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_HasTranslucentPolygonalGeometry_68(HandleRef pThis);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_HasTranslucentPolygonalGeometry_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_IsA_69(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_IsA_69(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDisplaySizedImplicitPlaneRepresentation_IsTranslationConstrained_70(HandleRef pThis);

	/// <summary>
	/// Returns true if ConstrainedAxis
	/// </summary>
	public bool IsTranslationConstrained()
	{
		return (vtkDisplaySizedImplicitPlaneRepresentation_IsTranslationConstrained_70(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_IsTypeOf_71(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_IsTypeOf_71(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_LockNormalToCameraOff_72(HandleRef pThis);

	/// <summary>
	/// If enabled, and a vtkCamera is available through the renderer, then
	/// LockNormalToCamera will cause the normal to follow the camera's
	/// normal.
	/// </summary>
	public virtual void LockNormalToCameraOff()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_LockNormalToCameraOff_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_LockNormalToCameraOn_73(HandleRef pThis);

	/// <summary>
	/// If enabled, and a vtkCamera is available through the renderer, then
	/// LockNormalToCamera will cause the normal to follow the camera's
	/// normal.
	/// </summary>
	public virtual void LockNormalToCameraOn()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_LockNormalToCameraOn_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_NewInstance_75(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new vtkDisplaySizedImplicitPlaneRepresentation NewInstance()
	{
		vtkDisplaySizedImplicitPlaneRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation_NewInstance_75(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDisplaySizedImplicitPlaneRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_NormalToXAxisOff_76(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToXAxisOff()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_NormalToXAxisOff_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_NormalToXAxisOn_77(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToXAxisOn()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_NormalToXAxisOn_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_NormalToYAxisOff_78(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToYAxisOff()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_NormalToYAxisOff_78(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_NormalToYAxisOn_79(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToYAxisOn()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_NormalToYAxisOn_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_NormalToZAxisOff_80(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToZAxisOff()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_NormalToZAxisOff_80(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_NormalToZAxisOn_81(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToZAxisOn()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_NormalToZAxisOn_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_OutlineTranslationOff_82(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to translate the bounding box by grabbing it
	/// with the left mouse button. Default is off.
	/// </summary>
	public virtual void OutlineTranslationOff()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_OutlineTranslationOff_82(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_OutlineTranslationOn_83(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to translate the bounding box by grabbing it
	/// with the left mouse button. Default is off.
	/// </summary>
	public virtual void OutlineTranslationOn()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_OutlineTranslationOn_83(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_OutsideBoundsOff_84(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to move the widget outside of the bounds
	/// specified in the initial PlaceWidget() invocation.
	/// </summary>
	public virtual void OutsideBoundsOff()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_OutsideBoundsOff_84(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_OutsideBoundsOn_85(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to move the widget outside of the bounds
	/// specified in the initial PlaceWidget() invocation.
	/// </summary>
	public virtual void OutsideBoundsOn()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_OutsideBoundsOn_85(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_PickCameraFocalInfoOff_86(HandleRef pThis);

	/// <summary>
	/// Enable/Disable picking camera focal info if no result is available for PickOrigin and
	/// PickNormal. The default is disabled.
	/// </summary>
	public virtual void PickCameraFocalInfoOff()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_PickCameraFocalInfoOff_86(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_PickCameraFocalInfoOn_87(HandleRef pThis);

	/// <summary>
	/// Enable/Disable picking camera focal info if no result is available for PickOrigin and
	/// PickNormal. The default is disabled.
	/// </summary>
	public virtual void PickCameraFocalInfoOn()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_PickCameraFocalInfoOn_87(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDisplaySizedImplicitPlaneRepresentation_PickNormal_88(HandleRef pThis, int X, int Y, byte snapToMeshPoint);

	/// <summary>
	/// Given the X, Y display coordinates, pick a new normal for the plane
	/// from a point that is on the objects rendered by the renderer.
	///
	/// Note: if a normal from a rendered object is not picked, the camera plane normal can optionally
	/// be set.
	/// </summary>
	public bool PickNormal(int X, int Y, bool snapToMeshPoint)
	{
		return (vtkDisplaySizedImplicitPlaneRepresentation_PickNormal_88(GetCppThis(), X, Y, (byte)(snapToMeshPoint ? 1u : 0u)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDisplaySizedImplicitPlaneRepresentation_PickOrigin_89(HandleRef pThis, int X, int Y, byte snapToMeshPoint);

	/// <summary>
	/// Given the X, Y display coordinates, pick a new origin for the plane
	/// from a point that is on the objects rendered by the renderer.
	///
	/// Note: if a point from a rendered object is not picked, the camera focal point can optionally be
	/// set.
	/// </summary>
	public bool PickOrigin(int X, int Y, bool snapToMeshPoint)
	{
		return (vtkDisplaySizedImplicitPlaneRepresentation_PickOrigin_89(GetCppThis(), X, Y, (byte)(snapToMeshPoint ? 1u : 0u)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_PlaceWidget_90(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods to interface with the vtkDisplaySizedImplicitPlaneWidget.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_PlaceWidget_90(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_PushPlane_91(HandleRef pThis, double distance);

	/// <summary>
	/// Push the plane the distance specified along the normal. Positive
	/// values are in the direction of the normal; negative values are
	/// in the opposite direction of the normal. The distance value is
	/// expressed in world coordinates.
	/// </summary>
	public void PushPlane(double distance)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_PushPlane_91(GetCppThis(), distance);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_ReleaseGraphicsResources_92(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_ReleaseGraphicsResources_92(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_RenderOpaqueGeometry_93(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_RenderOpaqueGeometry_93(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_RenderTranslucentPolygonalGeometry_94(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkDisplaySizedImplicitPlaneRepresentation_RenderTranslucentPolygonalGeometry_94(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_SafeDownCast_95(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static vtkDisplaySizedImplicitPlaneRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkDisplaySizedImplicitPlaneRepresentation vtkDisplaySizedImplicitPlaneRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation_SafeDownCast_95(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDisplaySizedImplicitPlaneRepresentation2 = (vtkDisplaySizedImplicitPlaneRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDisplaySizedImplicitPlaneRepresentation2.Register(null);
			}
		}
		return vtkDisplaySizedImplicitPlaneRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_ScaleEnabledOff_96(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to scale the widget with the mouse.
	/// </summary>
	public virtual void ScaleEnabledOff()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_ScaleEnabledOff_96(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_ScaleEnabledOn_97(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to scale the widget with the mouse.
	/// </summary>
	public virtual void ScaleEnabledOn()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_ScaleEnabledOn_97(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetAlwaysSnapToNearestAxis_98(HandleRef pThis, byte snap);

	/// <summary>
	/// Forces the plane's normal to be aligned with x, y or z axis.
	/// The alignment happens when calling SetNormal.
	/// It defers with SnapToAxes from it is always applicable, and SnapToAxes
	/// only snaps when the angle difference exceeds 16 degrees in complex interactions.
	/// </summary>
	public virtual void SetAlwaysSnapToNearestAxis(bool snap)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetAlwaysSnapToNearestAxis_98(GetCppThis(), (byte)(snap ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetBumpDistance_99(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify a translation distance used by the BumpPlane() method. Note that the
	/// distance is normalized; it is the fraction of the length of the bounding
	/// box of the wire outline.
	/// </summary>
	public virtual void SetBumpDistance(double _arg)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetBumpDistance_99(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetConstrainMaximumSizeToWidgetBounds_100(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off whether the maximum widget size should be constrained to the widget bounds.
	/// If on, the radius of the disk plane and plane normal arrow will not be allowed to be larger
	/// than the half diagonal of the bounding box formed by the widget bounds.
	/// If off, the radius of the disk plane and plane normal arrow can be arbitrary big
	/// The default behaviour is off.
	/// </summary>
	public virtual void SetConstrainMaximumSizeToWidgetBounds(int _arg)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetConstrainMaximumSizeToWidgetBounds_100(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetConstrainToWidgetBounds_101(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off whether the plane should be constrained to the widget bounds.
	/// If on, the origin will not be allowed to move outside the set widget bounds.
	/// The default behaviour is off.
	/// If off, the origin can be freely moved and the widget outline will change
	/// accordingly.
	/// </summary>
	public virtual void SetConstrainToWidgetBounds(int _arg)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetConstrainToWidgetBounds_101(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetDrawIntersectionEdges_102(HandleRef pThis, int intersectionEdges);

	/// <summary>
	/// Enable/disable the drawing of the intersection edges. Default is off.
	///
	/// Note: drawing the intersection edges requires DrawOutline to be on.
	/// </summary>
	public void SetDrawIntersectionEdges(int intersectionEdges)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetDrawIntersectionEdges_102(GetCppThis(), intersectionEdges);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetDrawOutline_103(HandleRef pThis, int outline);

	/// <summary>
	/// Enable/disable the drawing of the outline. Default is off.
	/// </summary>
	public void SetDrawOutline(int outline)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetDrawOutline_103(GetCppThis(), outline);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetDrawPlane_104(HandleRef pThis, int plane);

	/// <summary>
	/// Enable/disable the drawing of the plane. In some cases the plane
	/// interferes with the object that it is operating on (i.e., the
	/// plane interferes with the cut surface it produces producing
	/// z-buffer artifacts.)
	/// </summary>
	public void SetDrawPlane(int plane)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetDrawPlane_104(GetCppThis(), plane);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetInteractionState_105(HandleRef pThis, int _arg);

	/// <summary>
	/// The interaction state may be set from a widget (e.g.,
	/// vtkDisplaySizedImplicitPlaneWidget) or other object. This controls how the
	/// interaction with the widget proceeds. Normally this method is used as
	/// part of a handshaking process with the widget: First
	/// ComputeInteractionState() is invoked that returns a state based on
	/// geometric considerations (i.e., cursor near a widget feature), then
	/// based on events, the widget may modify this further.
	/// </summary>
	public virtual void SetInteractionState(int _arg)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetInteractionState_105(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetLockNormalToCamera_106(HandleRef pThis, int arg0);

	/// <summary>
	/// If enabled, and a vtkCamera is available through the renderer, then
	/// LockNormalToCamera will cause the normal to follow the camera's
	/// normal.
	/// </summary>
	public virtual void SetLockNormalToCamera(int arg0)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetLockNormalToCamera_106(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetNormal_107(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the normal to the plane.
	/// </summary>
	public void SetNormal(double x, double y, double z)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetNormal_107(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetNormal_108(HandleRef pThis, IntPtr n);

	/// <summary>
	/// Set/Get the normal to the plane.
	/// </summary>
	public void SetNormal(IntPtr n)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetNormal_108(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetNormalToCamera_109(HandleRef pThis);

	/// <summary>
	/// Set/Get the normal to the plane.
	/// </summary>
	public void SetNormalToCamera()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetNormalToCamera_109(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetNormalToXAxis_110(HandleRef pThis, int arg0);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public void SetNormalToXAxis(int arg0)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetNormalToXAxis_110(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetNormalToYAxis_111(HandleRef pThis, int arg0);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public void SetNormalToYAxis(int arg0)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetNormalToYAxis_111(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetNormalToZAxis_112(HandleRef pThis, int arg0);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public void SetNormalToZAxis(int arg0)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetNormalToZAxis_112(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetOrigin_113(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the origin of the plane.
	/// </summary>
	public void SetOrigin(double x, double y, double z)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetOrigin_113(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetOrigin_114(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Set/Get the origin of the plane.
	/// </summary>
	public void SetOrigin(IntPtr x)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetOrigin_114(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetOutlineTranslation_115(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the ability to translate the bounding box by grabbing it
	/// with the left mouse button. Default is off.
	/// </summary>
	public virtual void SetOutlineTranslation(int _arg)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetOutlineTranslation_115(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetOutsideBounds_116(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the ability to move the widget outside of the bounds
	/// specified in the initial PlaceWidget() invocation.
	/// </summary>
	public virtual void SetOutsideBounds(int _arg)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetOutsideBounds_116(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetPickCameraFocalInfo_117(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable/Disable picking camera focal info if no result is available for PickOrigin and
	/// PickNormal. The default is disabled.
	/// </summary>
	public virtual void SetPickCameraFocalInfo(bool _arg)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetPickCameraFocalInfo_117(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetPlane_118(HandleRef pThis, HandleRef plane);

	/// <summary>
	/// Alternative way to define the cutting plane. The normal and origin of
	/// the plane provided is copied into the internal instance of the class
	/// cutting vtkPlane.
	/// </summary>
	public void SetPlane(vtkPlane plane)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetPlane_118(GetCppThis(), plane?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetRadiusMultiplier_119(HandleRef pThis, double radiusMultiplier);

	/// <summary>
	/// Set/Get the Radius Multiplier value. Default is 1.0.
	/// </summary>
	public virtual void SetRadiusMultiplier(double radiusMultiplier)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetRadiusMultiplier_119(GetCppThis(), radiusMultiplier);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetRepresentationState_120(HandleRef pThis, int arg0);

	/// <summary>
	/// Sets the visual appearance of the representation based on the
	/// state it is in. This state is usually the same as InteractionState.
	/// </summary>
	public virtual void SetRepresentationState(int arg0)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetRepresentationState_120(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetScaleEnabled_121(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the ability to scale the widget with the mouse.
	/// </summary>
	public virtual void SetScaleEnabled(int _arg)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetScaleEnabled_121(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetSelectedWidgetColor_122(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Set the color of all the widgets objects (edges, cone1, cone2, line, sphere, except plane)
	/// when unselected or selected.
	/// </summary>
	public void SetSelectedWidgetColor(double arg0, double arg1, double arg2)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetSelectedWidgetColor_122(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetSelectedWidgetColor_123(HandleRef pThis, IntPtr c);

	/// <summary>
	/// Set the color of all the widgets objects (edges, cone1, cone2, line, sphere, except plane)
	/// when unselected or selected.
	/// </summary>
	public void SetSelectedWidgetColor(IntPtr c)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetSelectedWidgetColor_123(GetCppThis(), c);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetSnapToAxes_124(HandleRef pThis, byte _arg);

	/// <summary>
	/// For complex events should we snap orientations to
	/// be aligned with the x y z axes.
	/// </summary>
	public virtual void SetSnapToAxes(bool _arg)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetSnapToAxes_124(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetTranslationAxisOff_125(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetTranslationAxisOff()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetTranslationAxisOff_125(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetUnselectedWidgetColor_126(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Set the color of all the widgets objects (edges, cone1, cone2, line, sphere, except plane)
	/// when unselected or selected.
	/// </summary>
	public void SetUnselectedWidgetColor(double arg0, double arg1, double arg2)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetUnselectedWidgetColor_126(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetUnselectedWidgetColor_127(HandleRef pThis, IntPtr c);

	/// <summary>
	/// Set the color of all the widgets objects (edges, cone1, cone2, line, sphere, except plane)
	/// when unselected or selected.
	/// </summary>
	public void SetUnselectedWidgetColor(IntPtr c)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetUnselectedWidgetColor_127(GetCppThis(), c);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetWidgetBounds_128(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set/Get the bounds of the widget representation. PlaceWidget can also be
	/// used to set the bounds of the widget but it may also have other effects
	/// on the internal state of the representation. Use this function when only
	/// the widget bounds need to be modified.
	/// </summary>
	public virtual void SetWidgetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetWidgetBounds_128(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetWidgetBounds_129(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the bounds of the widget representation. PlaceWidget can also be
	/// used to set the bounds of the widget but it may also have other effects
	/// on the internal state of the representation. Use this function when only
	/// the widget bounds need to be modified.
	/// </summary>
	public virtual void SetWidgetBounds(IntPtr _arg)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetWidgetBounds_129(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetXTranslationAxisOn_130(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetXTranslationAxisOn()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetXTranslationAxisOn_130(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetYTranslationAxisOn_131(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetYTranslationAxisOn()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetYTranslationAxisOn_131(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetZTranslationAxisOn_132(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetZTranslationAxisOn()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SetZTranslationAxisOn_132(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SnapToAxesOff_133(HandleRef pThis);

	/// <summary>
	/// For complex events should we snap orientations to
	/// be aligned with the x y z axes.
	/// </summary>
	public virtual void SnapToAxesOff()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SnapToAxesOff_133(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SnapToAxesOn_134(HandleRef pThis);

	/// <summary>
	/// For complex events should we snap orientations to
	/// be aligned with the x y z axes.
	/// </summary>
	public virtual void SnapToAxesOn()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_SnapToAxesOn_134(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_StartComplexInteraction_135(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

	/// <summary>
	/// Methods to interface with the vtkDisplaySizedImplicitPlaneWidget.
	/// </summary>
	public override void StartComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_StartComplexInteraction_135(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_StartWidgetInteraction_136(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to interface with the vtkDisplaySizedImplicitPlaneWidget.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr eventPos)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_StartWidgetInteraction_136(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_UpdatePlacement_137(HandleRef pThis);

	/// <summary>
	/// Satisfies the superclass API.  This will change the state of the widget
	/// to match changes that have been made to the underlying PolyDataSource
	/// </summary>
	public void UpdatePlacement()
	{
		vtkDisplaySizedImplicitPlaneRepresentation_UpdatePlacement_137(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_WidgetInteraction_138(HandleRef pThis, IntPtr newEventPos);

	/// <summary>
	/// Methods to interface with the vtkDisplaySizedImplicitPlaneWidget.
	/// </summary>
	public override void WidgetInteraction(IntPtr newEventPos)
	{
		vtkDisplaySizedImplicitPlaneRepresentation_WidgetInteraction_138(GetCppThis(), newEventPos);
	}
}
