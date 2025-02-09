using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImplicitCylinderRepresentation
/// </summary>
/// <remarks>
///    defining the representation for a vtkImplicitCylinderWidget
///
/// This class is a concrete representation for the
/// vtkImplicitCylinderWidget. It represents an infinite cylinder
/// defined by a radius, a center, and an axis. The cylinder is placed
/// within its associated bounding box and the intersection of the
/// cylinder with the bounding box is shown to visually indicate the
/// orientation and position of the representation. This cylinder
/// representation can be manipulated by using the
/// vtkImplicitCylinderWidget to adjust the cylinder radius, axis,
/// and/or center point. (Note that the bounding box is defined during
/// invocation of the superclass' PlaceWidget() method.)
///
/// To use this representation, you normally specify a radius, center,
/// and axis. Optionally you can specify a minimum and maximum radius,
/// and a resolution for the cylinder. Finally, place the widget and
/// its representation in the scene using PlaceWidget().
///
/// </remarks>
/// <seealso>
///
/// vtkImplicitCylinderWidget vtkImplicitPlaneWidget vtkImplicitPlaneWidget
/// </seealso>
public class vtkImplicitCylinderRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Push the cylinder the distance specified along the view
	/// vector. Positive values are in the direction of the view vector;
	/// negative values are in the opposite direction. The distance value
	/// is expressed in world coordinates.
	/// </summary>
	public enum InteractionStateType
	{
		/// <summary>enum member</summary>
		AdjustingRadius = 5,
		/// <summary>enum member</summary>
		Moving = 1,
		/// <summary>enum member</summary>
		MovingCenter = 3,
		/// <summary>enum member</summary>
		MovingOutline = 2,
		/// <summary>enum member</summary>
		Outside = 0,
		/// <summary>enum member</summary>
		RotatingAxis = 4,
		/// <summary>enum member</summary>
		Scaling = 6,
		/// <summary>enum member</summary>
		TranslatingCenter = 7
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitCylinderRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImplicitCylinderRepresentation()
	{
		MRClassNameKey = "class vtkImplicitCylinderRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitCylinderRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImplicitCylinderRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitCylinderRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkImplicitCylinderRepresentation New()
	{
		vtkImplicitCylinderRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitCylinderRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitCylinderRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkImplicitCylinderRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImplicitCylinderRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImplicitCylinderRepresentation_AlongXAxisOff_01(HandleRef pThis);

	/// <summary>
	/// Force the cylinder widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the cylinder to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void AlongXAxisOff()
	{
		vtkImplicitCylinderRepresentation_AlongXAxisOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_AlongXAxisOn_02(HandleRef pThis);

	/// <summary>
	/// Force the cylinder widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the cylinder to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void AlongXAxisOn()
	{
		vtkImplicitCylinderRepresentation_AlongXAxisOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_AlongYAxisOff_03(HandleRef pThis);

	/// <summary>
	/// Force the cylinder widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the cylinder to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void AlongYAxisOff()
	{
		vtkImplicitCylinderRepresentation_AlongYAxisOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_AlongYAxisOn_04(HandleRef pThis);

	/// <summary>
	/// Force the cylinder widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the cylinder to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void AlongYAxisOn()
	{
		vtkImplicitCylinderRepresentation_AlongYAxisOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_AlongZAxisOff_05(HandleRef pThis);

	/// <summary>
	/// Force the cylinder widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the cylinder to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void AlongZAxisOff()
	{
		vtkImplicitCylinderRepresentation_AlongZAxisOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_AlongZAxisOn_06(HandleRef pThis);

	/// <summary>
	/// Force the cylinder widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the cylinder to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void AlongZAxisOn()
	{
		vtkImplicitCylinderRepresentation_AlongZAxisOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_BuildRepresentation_07(HandleRef pThis);

	/// <summary>
	/// Methods to interface with the vtkImplicitCylinderWidget.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkImplicitCylinderRepresentation_BuildRepresentation_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_BumpCylinder_08(HandleRef pThis, int dir, double factor);

	/// <summary>
	/// Translate the cylinder in the direction of the view vector by the
	/// specified BumpDistance. The dir parameter controls which
	/// direction the pushing occurs, either in the same direction as the
	/// view vector, or when negative, in the opposite direction.  The factor
	/// controls what percentage of the bump is used.
	/// </summary>
	public void BumpCylinder(int dir, double factor)
	{
		vtkImplicitCylinderRepresentation_BumpCylinder_08(GetCppThis(), dir, factor);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitCylinderRepresentation_ComputeInteractionState_09(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// Methods to interface with the vtkImplicitCylinderWidget.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkImplicitCylinderRepresentation_ComputeInteractionState_09(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_ConstrainToWidgetBoundsOff_10(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether the cylinder should be constrained to the widget bounds.
	/// If on, the center will not be allowed to move outside the set widget bounds
	/// and the radius will be limited by MinRadius and MaxRadius. This is the
	/// default behaviour.
	/// If off, the center can be freely moved and the radius can be set to
	/// arbitrary values. The widget outline will change accordingly.
	/// </summary>
	public virtual void ConstrainToWidgetBoundsOff()
	{
		vtkImplicitCylinderRepresentation_ConstrainToWidgetBoundsOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_ConstrainToWidgetBoundsOn_11(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether the cylinder should be constrained to the widget bounds.
	/// If on, the center will not be allowed to move outside the set widget bounds
	/// and the radius will be limited by MinRadius and MaxRadius. This is the
	/// default behaviour.
	/// If off, the center can be freely moved and the radius can be set to
	/// arbitrary values. The widget outline will change accordingly.
	/// </summary>
	public virtual void ConstrainToWidgetBoundsOn()
	{
		vtkImplicitCylinderRepresentation_ConstrainToWidgetBoundsOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_DrawCylinderOff_12(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the cylinder. In some cases the cylinder
	/// interferes with the object that it is operating on (e.g., the
	/// cylinder interferes with the cut surface it produces resulting in
	/// z-buffer artifacts.) By default it is off.
	/// </summary>
	public virtual void DrawCylinderOff()
	{
		vtkImplicitCylinderRepresentation_DrawCylinderOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_DrawCylinderOn_13(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the cylinder. In some cases the cylinder
	/// interferes with the object that it is operating on (e.g., the
	/// cylinder interferes with the cut surface it produces resulting in
	/// z-buffer artifacts.) By default it is off.
	/// </summary>
	public virtual void DrawCylinderOn()
	{
		vtkImplicitCylinderRepresentation_DrawCylinderOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_EndWidgetInteraction_14(HandleRef pThis, IntPtr newEventPos);

	/// <summary>
	/// Methods to interface with the vtkImplicitCylinderWidget.
	/// </summary>
	public override void EndWidgetInteraction(IntPtr newEventPos)
	{
		vtkImplicitCylinderRepresentation_EndWidgetInteraction_14(GetCppThis(), newEventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_GetActors_15(HandleRef pThis, HandleRef pc);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override void GetActors(vtkPropCollection pc)
	{
		vtkImplicitCylinderRepresentation_GetActors_15(GetCppThis(), pc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitCylinderRepresentation_GetAlongXAxis_16(HandleRef pThis);

	/// <summary>
	/// Force the cylinder widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the cylinder to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual int GetAlongXAxis()
	{
		return vtkImplicitCylinderRepresentation_GetAlongXAxis_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitCylinderRepresentation_GetAlongYAxis_17(HandleRef pThis);

	/// <summary>
	/// Force the cylinder widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the cylinder to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual int GetAlongYAxis()
	{
		return vtkImplicitCylinderRepresentation_GetAlongYAxis_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitCylinderRepresentation_GetAlongZAxis_18(HandleRef pThis);

	/// <summary>
	/// Force the cylinder widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the cylinder to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual int GetAlongZAxis()
	{
		return vtkImplicitCylinderRepresentation_GetAlongZAxis_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitCylinderRepresentation_GetAxis_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the axis of rotation for the cylinder. If the axis is not
	/// specified as a unit vector, it will be normalized.
	/// </summary>
	public double[] GetAxis()
	{
		IntPtr intPtr = vtkImplicitCylinderRepresentation_GetAxis_19(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_GetAxis_20(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set/Get the axis of rotation for the cylinder. If the axis is not
	/// specified as a unit vector, it will be normalized.
	/// </summary>
	public void GetAxis(IntPtr a)
	{
		vtkImplicitCylinderRepresentation_GetAxis_20(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitCylinderRepresentation_GetAxisProperty_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the axis (line and cone).
	/// </summary>
	public virtual vtkProperty GetAxisProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitCylinderRepresentation_GetAxisProperty_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkImplicitCylinderRepresentation_GetBounds_22(HandleRef pThis);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkImplicitCylinderRepresentation_GetBounds_22(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitCylinderRepresentation_GetBumpDistance_23(HandleRef pThis);

	/// <summary>
	/// Specify a translation distance used by the BumpCylinder() method. Note that the
	/// distance is normalized; it is the fraction of the length of the bounding
	/// box of the wire outline.
	/// </summary>
	public virtual double GetBumpDistance()
	{
		return vtkImplicitCylinderRepresentation_GetBumpDistance_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitCylinderRepresentation_GetBumpDistanceMaxValue_24(HandleRef pThis);

	/// <summary>
	/// Specify a translation distance used by the BumpCylinder() method. Note that the
	/// distance is normalized; it is the fraction of the length of the bounding
	/// box of the wire outline.
	/// </summary>
	public virtual double GetBumpDistanceMaxValue()
	{
		return vtkImplicitCylinderRepresentation_GetBumpDistanceMaxValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitCylinderRepresentation_GetBumpDistanceMinValue_25(HandleRef pThis);

	/// <summary>
	/// Specify a translation distance used by the BumpCylinder() method. Note that the
	/// distance is normalized; it is the fraction of the length of the bounding
	/// box of the wire outline.
	/// </summary>
	public virtual double GetBumpDistanceMinValue()
	{
		return vtkImplicitCylinderRepresentation_GetBumpDistanceMinValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitCylinderRepresentation_GetCenter_26(HandleRef pThis);

	/// <summary>
	/// Get the center of the cylinder. The center is located along the
	/// cylinder axis.
	/// </summary>
	public double[] GetCenter()
	{
		IntPtr intPtr = vtkImplicitCylinderRepresentation_GetCenter_26(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_GetCenter_27(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Get the center of the cylinder. The center is located along the
	/// cylinder axis.
	/// </summary>
	public void GetCenter(IntPtr xyz)
	{
		vtkImplicitCylinderRepresentation_GetCenter_27(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitCylinderRepresentation_GetConstrainToWidgetBounds_28(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether the cylinder should be constrained to the widget bounds.
	/// If on, the center will not be allowed to move outside the set widget bounds
	/// and the radius will be limited by MinRadius and MaxRadius. This is the
	/// default behaviour.
	/// If off, the center can be freely moved and the radius can be set to
	/// arbitrary values. The widget outline will change accordingly.
	/// </summary>
	public virtual int GetConstrainToWidgetBounds()
	{
		return vtkImplicitCylinderRepresentation_GetConstrainToWidgetBounds_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_GetCylinder_29(HandleRef pThis, HandleRef cyl);

	/// <summary>
	/// Get the implicit function for the cylinder. The user must provide the
	/// instance of the class vtkCylinder. Note that vtkCylinder is a subclass of
	/// vtkImplicitFunction, meaning that it can be used by a variety of filters
	/// to perform clipping, cutting, and selection of data.
	/// </summary>
	public void GetCylinder(vtkCylinder cyl)
	{
		vtkImplicitCylinderRepresentation_GetCylinder_29(GetCppThis(), cyl?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitCylinderRepresentation_GetCylinderProperty_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the cylinder properties. The properties of the cylinder when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetCylinderProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitCylinderRepresentation_GetCylinderProperty_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkImplicitCylinderRepresentation_GetDrawCylinder_31(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the cylinder. In some cases the cylinder
	/// interferes with the object that it is operating on (e.g., the
	/// cylinder interferes with the cut surface it produces resulting in
	/// z-buffer artifacts.) By default it is off.
	/// </summary>
	public virtual int GetDrawCylinder()
	{
		return vtkImplicitCylinderRepresentation_GetDrawCylinder_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitCylinderRepresentation_GetEdgesProperty_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkImplicitCylinderRepresentation_GetEdgesProperty_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkImplicitCylinderRepresentation_GetInteractionStateMaxValue_33(HandleRef pThis);

	/// <summary>
	/// The interaction state may be set from a widget (e.g.,
	/// vtkImplicitCylinderWidget) or other object. This controls how the
	/// interaction with the widget proceeds. Normally this method is used as
	/// part of a handshaking process with the widget: First
	/// ComputeInteractionState() is invoked that returns a state based on
	/// geometric considerations (i.e., cursor near a widget feature), then
	/// based on events, the widget may modify this further.
	/// </summary>
	public virtual int GetInteractionStateMaxValue()
	{
		return vtkImplicitCylinderRepresentation_GetInteractionStateMaxValue_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitCylinderRepresentation_GetInteractionStateMinValue_34(HandleRef pThis);

	/// <summary>
	/// The interaction state may be set from a widget (e.g.,
	/// vtkImplicitCylinderWidget) or other object. This controls how the
	/// interaction with the widget proceeds. Normally this method is used as
	/// part of a handshaking process with the widget: First
	/// ComputeInteractionState() is invoked that returns a state based on
	/// geometric considerations (i.e., cursor near a widget feature), then
	/// based on events, the widget may modify this further.
	/// </summary>
	public virtual int GetInteractionStateMinValue()
	{
		return vtkImplicitCylinderRepresentation_GetInteractionStateMinValue_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitCylinderRepresentation_GetMaxRadius_35(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimum and maximum radius of the cylinder. This
	/// helps prevent the cylinder from "disappearing" during
	/// interaction.  Note that the minimum and maximum radius is
	/// specified as a fraction of the diagonal length of the widget
	/// bounding box.
	/// </summary>
	public virtual double GetMaxRadius()
	{
		return vtkImplicitCylinderRepresentation_GetMaxRadius_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitCylinderRepresentation_GetMaxRadiusMaxValue_36(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimum and maximum radius of the cylinder. This
	/// helps prevent the cylinder from "disappearing" during
	/// interaction.  Note that the minimum and maximum radius is
	/// specified as a fraction of the diagonal length of the widget
	/// bounding box.
	/// </summary>
	public virtual double GetMaxRadiusMaxValue()
	{
		return vtkImplicitCylinderRepresentation_GetMaxRadiusMaxValue_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitCylinderRepresentation_GetMaxRadiusMinValue_37(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimum and maximum radius of the cylinder. This
	/// helps prevent the cylinder from "disappearing" during
	/// interaction.  Note that the minimum and maximum radius is
	/// specified as a fraction of the diagonal length of the widget
	/// bounding box.
	/// </summary>
	public virtual double GetMaxRadiusMinValue()
	{
		return vtkImplicitCylinderRepresentation_GetMaxRadiusMinValue_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitCylinderRepresentation_GetMinRadius_38(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimum and maximum radius of the cylinder. This
	/// helps prevent the cylinder from "disappearing" during
	/// interaction.  Note that the minimum and maximum radius is
	/// specified as a fraction of the diagonal length of the widget
	/// bounding box.
	/// </summary>
	public virtual double GetMinRadius()
	{
		return vtkImplicitCylinderRepresentation_GetMinRadius_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitCylinderRepresentation_GetMinRadiusMaxValue_39(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimum and maximum radius of the cylinder. This
	/// helps prevent the cylinder from "disappearing" during
	/// interaction.  Note that the minimum and maximum radius is
	/// specified as a fraction of the diagonal length of the widget
	/// bounding box.
	/// </summary>
	public virtual double GetMinRadiusMaxValue()
	{
		return vtkImplicitCylinderRepresentation_GetMinRadiusMaxValue_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitCylinderRepresentation_GetMinRadiusMinValue_40(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimum and maximum radius of the cylinder. This
	/// helps prevent the cylinder from "disappearing" during
	/// interaction.  Note that the minimum and maximum radius is
	/// specified as a fraction of the diagonal length of the widget
	/// bounding box.
	/// </summary>
	public virtual double GetMinRadiusMinValue()
	{
		return vtkImplicitCylinderRepresentation_GetMinRadiusMinValue_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitCylinderRepresentation_GetNumberOfGenerationsFromBase_41(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImplicitCylinderRepresentation_GetNumberOfGenerationsFromBase_41(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitCylinderRepresentation_GetNumberOfGenerationsFromBaseType_42(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImplicitCylinderRepresentation_GetNumberOfGenerationsFromBaseType_42(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitCylinderRepresentation_GetOutlineProperty_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the property of the outline.
	/// </summary>
	public virtual vtkProperty GetOutlineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitCylinderRepresentation_GetOutlineProperty_43(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkImplicitCylinderRepresentation_GetOutlineTranslation_44(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to translate the bounding box by moving it
	/// with the mouse.
	/// </summary>
	public virtual int GetOutlineTranslation()
	{
		return vtkImplicitCylinderRepresentation_GetOutlineTranslation_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitCylinderRepresentation_GetOutsideBounds_45(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to move the widget outside of the bounds
	/// specified in the PlaceWidget() invocation.
	/// </summary>
	public virtual int GetOutsideBounds()
	{
		return vtkImplicitCylinderRepresentation_GetOutsideBounds_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_GetPolyData_46(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Grab the polydata that defines the cylinder. The polydata contains
	/// polygons that are clipped by the bounding box.
	/// </summary>
	public void GetPolyData(vtkPolyData pd)
	{
		vtkImplicitCylinderRepresentation_GetPolyData_46(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitCylinderRepresentation_GetRadius_47(HandleRef pThis);

	/// <summary>
	/// Set/Get the radius of the cylinder. Note that if the radius is
	/// too big the cylinder will be outside of the bounding box.
	/// </summary>
	public double GetRadius()
	{
		return vtkImplicitCylinderRepresentation_GetRadius_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitCylinderRepresentation_GetRepresentationState_48(HandleRef pThis);

	/// <summary>
	/// Sets the visual appearance of the representation based on the
	/// state it is in. This state is usually the same as InteractionState.
	/// </summary>
	public virtual int GetRepresentationState()
	{
		return vtkImplicitCylinderRepresentation_GetRepresentationState_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitCylinderRepresentation_GetResolution_49(HandleRef pThis);

	/// <summary>
	/// Set/Get the resolution of the cylinder. This is the number of
	/// polygonal facets used to approximate the curved cylindrical
	/// surface (for rendering purposes). An vtkCylinder is used under
	/// the hood to provide an exact surface representation.
	/// </summary>
	public virtual int GetResolution()
	{
		return vtkImplicitCylinderRepresentation_GetResolution_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitCylinderRepresentation_GetResolutionMaxValue_50(HandleRef pThis);

	/// <summary>
	/// Set/Get the resolution of the cylinder. This is the number of
	/// polygonal facets used to approximate the curved cylindrical
	/// surface (for rendering purposes). An vtkCylinder is used under
	/// the hood to provide an exact surface representation.
	/// </summary>
	public virtual int GetResolutionMaxValue()
	{
		return vtkImplicitCylinderRepresentation_GetResolutionMaxValue_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitCylinderRepresentation_GetResolutionMinValue_51(HandleRef pThis);

	/// <summary>
	/// Set/Get the resolution of the cylinder. This is the number of
	/// polygonal facets used to approximate the curved cylindrical
	/// surface (for rendering purposes). An vtkCylinder is used under
	/// the hood to provide an exact surface representation.
	/// </summary>
	public virtual int GetResolutionMinValue()
	{
		return vtkImplicitCylinderRepresentation_GetResolutionMinValue_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitCylinderRepresentation_GetScaleEnabled_52(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to scale the widget with the mouse.
	/// </summary>
	public virtual int GetScaleEnabled()
	{
		return vtkImplicitCylinderRepresentation_GetScaleEnabled_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitCylinderRepresentation_GetSelectedAxisProperty_53(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the axis (line and cone).
	/// </summary>
	public virtual vtkProperty GetSelectedAxisProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitCylinderRepresentation_GetSelectedAxisProperty_53(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkImplicitCylinderRepresentation_GetSelectedCylinderProperty_54(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the cylinder properties. The properties of the cylinder when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedCylinderProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitCylinderRepresentation_GetSelectedCylinderProperty_54(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkImplicitCylinderRepresentation_GetSelectedOutlineProperty_55(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the property of the outline.
	/// </summary>
	public virtual vtkProperty GetSelectedOutlineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitCylinderRepresentation_GetSelectedOutlineProperty_55(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkImplicitCylinderRepresentation_GetTranslationAxis_56(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual int GetTranslationAxis()
	{
		return vtkImplicitCylinderRepresentation_GetTranslationAxis_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitCylinderRepresentation_GetTranslationAxisMaxValue_57(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual int GetTranslationAxisMaxValue()
	{
		return vtkImplicitCylinderRepresentation_GetTranslationAxisMaxValue_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitCylinderRepresentation_GetTranslationAxisMinValue_58(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual int GetTranslationAxisMinValue()
	{
		return vtkImplicitCylinderRepresentation_GetTranslationAxisMinValue_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitCylinderRepresentation_GetTubing_59(HandleRef pThis);

	/// <summary>
	/// Turn on/off tubing of the wire outline of the cylinder
	/// intersection (against the bounding box). The tube thickens the
	/// line by wrapping with a vtkTubeFilter.
	/// </summary>
	public virtual int GetTubing()
	{
		return vtkImplicitCylinderRepresentation_GetTubing_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitCylinderRepresentation_GetWidgetBounds_60(HandleRef pThis);

	/// <summary>
	/// Set/Get the bounds of the widget representation. PlaceWidget can also be
	/// used to set the bounds of the widget but it may also have other effects
	/// on the internal state of the representation. Use this function when only
	/// the widget bounds are needs to be modified.
	/// </summary>
	public virtual double[] GetWidgetBounds()
	{
		IntPtr intPtr = vtkImplicitCylinderRepresentation_GetWidgetBounds_60(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_GetWidgetBounds_61(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

	/// <summary>
	/// Set/Get the bounds of the widget representation. PlaceWidget can also be
	/// used to set the bounds of the widget but it may also have other effects
	/// on the internal state of the representation. Use this function when only
	/// the widget bounds are needs to be modified.
	/// </summary>
	public virtual void GetWidgetBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
	{
		vtkImplicitCylinderRepresentation_GetWidgetBounds_61(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_GetWidgetBounds_62(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the bounds of the widget representation. PlaceWidget can also be
	/// used to set the bounds of the widget but it may also have other effects
	/// on the internal state of the representation. Use this function when only
	/// the widget bounds are needs to be modified.
	/// </summary>
	public virtual void GetWidgetBounds(IntPtr _arg)
	{
		vtkImplicitCylinderRepresentation_GetWidgetBounds_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitCylinderRepresentation_HasTranslucentPolygonalGeometry_63(HandleRef pThis);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkImplicitCylinderRepresentation_HasTranslucentPolygonalGeometry_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitCylinderRepresentation_IsA_64(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImplicitCylinderRepresentation_IsA_64(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImplicitCylinderRepresentation_IsTranslationConstrained_65(HandleRef pThis);

	/// <summary>
	/// Returns true if ConstrainedAxis
	/// </summary>
	public bool IsTranslationConstrained()
	{
		return (vtkImplicitCylinderRepresentation_IsTranslationConstrained_65(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitCylinderRepresentation_IsTypeOf_66(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImplicitCylinderRepresentation_IsTypeOf_66(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitCylinderRepresentation_NewInstance_68(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new vtkImplicitCylinderRepresentation NewInstance()
	{
		vtkImplicitCylinderRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitCylinderRepresentation_NewInstance_68(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitCylinderRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_OutlineTranslationOff_69(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to translate the bounding box by moving it
	/// with the mouse.
	/// </summary>
	public virtual void OutlineTranslationOff()
	{
		vtkImplicitCylinderRepresentation_OutlineTranslationOff_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_OutlineTranslationOn_70(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to translate the bounding box by moving it
	/// with the mouse.
	/// </summary>
	public virtual void OutlineTranslationOn()
	{
		vtkImplicitCylinderRepresentation_OutlineTranslationOn_70(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_OutsideBoundsOff_71(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to move the widget outside of the bounds
	/// specified in the PlaceWidget() invocation.
	/// </summary>
	public virtual void OutsideBoundsOff()
	{
		vtkImplicitCylinderRepresentation_OutsideBoundsOff_71(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_OutsideBoundsOn_72(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to move the widget outside of the bounds
	/// specified in the PlaceWidget() invocation.
	/// </summary>
	public virtual void OutsideBoundsOn()
	{
		vtkImplicitCylinderRepresentation_OutsideBoundsOn_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_PlaceWidget_73(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods to interface with the vtkImplicitCylinderWidget.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkImplicitCylinderRepresentation_PlaceWidget_73(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_PushCylinder_74(HandleRef pThis, double distance);

	/// <summary>
	/// Push the cylinder the distance specified along the view
	/// vector. Positive values are in the direction of the view vector;
	/// negative values are in the opposite direction. The distance value
	/// is expressed in world coordinates.
	/// </summary>
	public void PushCylinder(double distance)
	{
		vtkImplicitCylinderRepresentation_PushCylinder_74(GetCppThis(), distance);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_RegisterPickers_75(HandleRef pThis);

	/// <summary>
	/// Sets the visual appearance of the representation based on the
	/// state it is in. This state is usually the same as InteractionState.
	/// </summary>
	public override void RegisterPickers()
	{
		vtkImplicitCylinderRepresentation_RegisterPickers_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_ReleaseGraphicsResources_76(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkImplicitCylinderRepresentation_ReleaseGraphicsResources_76(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitCylinderRepresentation_RenderOpaqueGeometry_77(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkImplicitCylinderRepresentation_RenderOpaqueGeometry_77(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitCylinderRepresentation_RenderTranslucentPolygonalGeometry_78(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkImplicitCylinderRepresentation_RenderTranslucentPolygonalGeometry_78(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitCylinderRepresentation_SafeDownCast_79(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static vtkImplicitCylinderRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkImplicitCylinderRepresentation vtkImplicitCylinderRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitCylinderRepresentation_SafeDownCast_79(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitCylinderRepresentation2 = (vtkImplicitCylinderRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitCylinderRepresentation2.Register(null);
			}
		}
		return vtkImplicitCylinderRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_ScaleEnabledOff_80(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to scale the widget with the mouse.
	/// </summary>
	public virtual void ScaleEnabledOff()
	{
		vtkImplicitCylinderRepresentation_ScaleEnabledOff_80(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_ScaleEnabledOn_81(HandleRef pThis);

	/// <summary>
	/// Turn on/off the ability to scale the widget with the mouse.
	/// </summary>
	public virtual void ScaleEnabledOn()
	{
		vtkImplicitCylinderRepresentation_ScaleEnabledOn_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetAlongXAxis_82(HandleRef pThis, int arg0);

	/// <summary>
	/// Force the cylinder widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the cylinder to the axes if it is originally
	/// not aligned.
	/// </summary>
	public void SetAlongXAxis(int arg0)
	{
		vtkImplicitCylinderRepresentation_SetAlongXAxis_82(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetAlongYAxis_83(HandleRef pThis, int arg0);

	/// <summary>
	/// Force the cylinder widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the cylinder to the axes if it is originally
	/// not aligned.
	/// </summary>
	public void SetAlongYAxis(int arg0)
	{
		vtkImplicitCylinderRepresentation_SetAlongYAxis_83(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetAlongZAxis_84(HandleRef pThis, int arg0);

	/// <summary>
	/// Force the cylinder widget to be aligned with one of the x-y-z axes.
	/// If one axis is set on, the other two will be set off.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the cylinder to the axes if it is originally
	/// not aligned.
	/// </summary>
	public void SetAlongZAxis(int arg0)
	{
		vtkImplicitCylinderRepresentation_SetAlongZAxis_84(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetAxis_85(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the axis of rotation for the cylinder. If the axis is not
	/// specified as a unit vector, it will be normalized.
	/// </summary>
	public void SetAxis(double x, double y, double z)
	{
		vtkImplicitCylinderRepresentation_SetAxis_85(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetAxis_86(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set/Get the axis of rotation for the cylinder. If the axis is not
	/// specified as a unit vector, it will be normalized.
	/// </summary>
	public void SetAxis(IntPtr a)
	{
		vtkImplicitCylinderRepresentation_SetAxis_86(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetBumpDistance_87(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify a translation distance used by the BumpCylinder() method. Note that the
	/// distance is normalized; it is the fraction of the length of the bounding
	/// box of the wire outline.
	/// </summary>
	public virtual void SetBumpDistance(double _arg)
	{
		vtkImplicitCylinderRepresentation_SetBumpDistance_87(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetCenter_88(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Get the center of the cylinder. The center is located along the
	/// cylinder axis.
	/// </summary>
	public void SetCenter(double x, double y, double z)
	{
		vtkImplicitCylinderRepresentation_SetCenter_88(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetCenter_89(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Get the center of the cylinder. The center is located along the
	/// cylinder axis.
	/// </summary>
	public void SetCenter(IntPtr x)
	{
		vtkImplicitCylinderRepresentation_SetCenter_89(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetConstrainToWidgetBounds_90(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off whether the cylinder should be constrained to the widget bounds.
	/// If on, the center will not be allowed to move outside the set widget bounds
	/// and the radius will be limited by MinRadius and MaxRadius. This is the
	/// default behaviour.
	/// If off, the center can be freely moved and the radius can be set to
	/// arbitrary values. The widget outline will change accordingly.
	/// </summary>
	public virtual void SetConstrainToWidgetBounds(int _arg)
	{
		vtkImplicitCylinderRepresentation_SetConstrainToWidgetBounds_90(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetDrawCylinder_91(HandleRef pThis, int drawCyl);

	/// <summary>
	/// Enable/disable the drawing of the cylinder. In some cases the cylinder
	/// interferes with the object that it is operating on (e.g., the
	/// cylinder interferes with the cut surface it produces resulting in
	/// z-buffer artifacts.) By default it is off.
	/// </summary>
	public void SetDrawCylinder(int drawCyl)
	{
		vtkImplicitCylinderRepresentation_SetDrawCylinder_91(GetCppThis(), drawCyl);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetEdgeColor_92(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set color to the edge
	/// </summary>
	public void SetEdgeColor(vtkLookupTable arg0)
	{
		vtkImplicitCylinderRepresentation_SetEdgeColor_92(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetEdgeColor_93(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Set color to the edge
	/// </summary>
	public void SetEdgeColor(double arg0, double arg1, double arg2)
	{
		vtkImplicitCylinderRepresentation_SetEdgeColor_93(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetEdgeColor_94(HandleRef pThis, IntPtr c);

	/// <summary>
	/// Set color to the edge
	/// </summary>
	public void SetEdgeColor(IntPtr c)
	{
		vtkImplicitCylinderRepresentation_SetEdgeColor_94(GetCppThis(), c);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetInteractionState_95(HandleRef pThis, int _arg);

	/// <summary>
	/// The interaction state may be set from a widget (e.g.,
	/// vtkImplicitCylinderWidget) or other object. This controls how the
	/// interaction with the widget proceeds. Normally this method is used as
	/// part of a handshaking process with the widget: First
	/// ComputeInteractionState() is invoked that returns a state based on
	/// geometric considerations (i.e., cursor near a widget feature), then
	/// based on events, the widget may modify this further.
	/// </summary>
	public virtual void SetInteractionState(int _arg)
	{
		vtkImplicitCylinderRepresentation_SetInteractionState_95(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetMaxRadius_96(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the minimum and maximum radius of the cylinder. This
	/// helps prevent the cylinder from "disappearing" during
	/// interaction.  Note that the minimum and maximum radius is
	/// specified as a fraction of the diagonal length of the widget
	/// bounding box.
	/// </summary>
	public virtual void SetMaxRadius(double _arg)
	{
		vtkImplicitCylinderRepresentation_SetMaxRadius_96(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetMinRadius_97(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the minimum and maximum radius of the cylinder. This
	/// helps prevent the cylinder from "disappearing" during
	/// interaction.  Note that the minimum and maximum radius is
	/// specified as a fraction of the diagonal length of the widget
	/// bounding box.
	/// </summary>
	public virtual void SetMinRadius(double _arg)
	{
		vtkImplicitCylinderRepresentation_SetMinRadius_97(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetOutlineTranslation_98(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the ability to translate the bounding box by moving it
	/// with the mouse.
	/// </summary>
	public virtual void SetOutlineTranslation(int _arg)
	{
		vtkImplicitCylinderRepresentation_SetOutlineTranslation_98(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetOutsideBounds_99(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the ability to move the widget outside of the bounds
	/// specified in the PlaceWidget() invocation.
	/// </summary>
	public virtual void SetOutsideBounds(int _arg)
	{
		vtkImplicitCylinderRepresentation_SetOutsideBounds_99(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetRadius_100(HandleRef pThis, double r);

	/// <summary>
	/// Set/Get the radius of the cylinder. Note that if the radius is
	/// too big the cylinder will be outside of the bounding box.
	/// </summary>
	public void SetRadius(double r)
	{
		vtkImplicitCylinderRepresentation_SetRadius_100(GetCppThis(), r);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetRepresentationState_101(HandleRef pThis, int arg0);

	/// <summary>
	/// Sets the visual appearance of the representation based on the
	/// state it is in. This state is usually the same as InteractionState.
	/// </summary>
	public virtual void SetRepresentationState(int arg0)
	{
		vtkImplicitCylinderRepresentation_SetRepresentationState_101(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetResolution_102(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the resolution of the cylinder. This is the number of
	/// polygonal facets used to approximate the curved cylindrical
	/// surface (for rendering purposes). An vtkCylinder is used under
	/// the hood to provide an exact surface representation.
	/// </summary>
	public virtual void SetResolution(int _arg)
	{
		vtkImplicitCylinderRepresentation_SetResolution_102(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetScaleEnabled_103(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the ability to scale the widget with the mouse.
	/// </summary>
	public virtual void SetScaleEnabled(int _arg)
	{
		vtkImplicitCylinderRepresentation_SetScaleEnabled_103(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetTranslationAxis_104(HandleRef pThis, int _arg);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual void SetTranslationAxis(int _arg)
	{
		vtkImplicitCylinderRepresentation_SetTranslationAxis_104(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetTranslationAxisOff_105(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetTranslationAxisOff()
	{
		vtkImplicitCylinderRepresentation_SetTranslationAxisOff_105(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetTubing_106(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off tubing of the wire outline of the cylinder
	/// intersection (against the bounding box). The tube thickens the
	/// line by wrapping with a vtkTubeFilter.
	/// </summary>
	public virtual void SetTubing(int _arg)
	{
		vtkImplicitCylinderRepresentation_SetTubing_106(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetWidgetBounds_107(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set/Get the bounds of the widget representation. PlaceWidget can also be
	/// used to set the bounds of the widget but it may also have other effects
	/// on the internal state of the representation. Use this function when only
	/// the widget bounds are needs to be modified.
	/// </summary>
	public virtual void SetWidgetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkImplicitCylinderRepresentation_SetWidgetBounds_107(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetWidgetBounds_108(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the bounds of the widget representation. PlaceWidget can also be
	/// used to set the bounds of the widget but it may also have other effects
	/// on the internal state of the representation. Use this function when only
	/// the widget bounds are needs to be modified.
	/// </summary>
	public virtual void SetWidgetBounds(IntPtr _arg)
	{
		vtkImplicitCylinderRepresentation_SetWidgetBounds_108(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetXTranslationAxisOn_109(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetXTranslationAxisOn()
	{
		vtkImplicitCylinderRepresentation_SetXTranslationAxisOn_109(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetYTranslationAxisOn_110(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetYTranslationAxisOn()
	{
		vtkImplicitCylinderRepresentation_SetYTranslationAxisOn_110(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_SetZTranslationAxisOn_111(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetZTranslationAxisOn()
	{
		vtkImplicitCylinderRepresentation_SetZTranslationAxisOn_111(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_StartWidgetInteraction_112(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to interface with the vtkImplicitCylinderWidget.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr eventPos)
	{
		vtkImplicitCylinderRepresentation_StartWidgetInteraction_112(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_TubingOff_113(HandleRef pThis);

	/// <summary>
	/// Turn on/off tubing of the wire outline of the cylinder
	/// intersection (against the bounding box). The tube thickens the
	/// line by wrapping with a vtkTubeFilter.
	/// </summary>
	public virtual void TubingOff()
	{
		vtkImplicitCylinderRepresentation_TubingOff_113(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_TubingOn_114(HandleRef pThis);

	/// <summary>
	/// Turn on/off tubing of the wire outline of the cylinder
	/// intersection (against the bounding box). The tube thickens the
	/// line by wrapping with a vtkTubeFilter.
	/// </summary>
	public virtual void TubingOn()
	{
		vtkImplicitCylinderRepresentation_TubingOn_114(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_UpdatePlacement_115(HandleRef pThis);

	/// <summary>
	/// Satisfies the superclass API.  This will change the state of the widget
	/// to match changes that have been made to the underlying PolyDataSource.
	/// </summary>
	public void UpdatePlacement()
	{
		vtkImplicitCylinderRepresentation_UpdatePlacement_115(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitCylinderRepresentation_WidgetInteraction_116(HandleRef pThis, IntPtr newEventPos);

	/// <summary>
	/// Methods to interface with the vtkImplicitCylinderWidget.
	/// </summary>
	public override void WidgetInteraction(IntPtr newEventPos)
	{
		vtkImplicitCylinderRepresentation_WidgetInteraction_116(GetCppThis(), newEventPos);
	}
}
