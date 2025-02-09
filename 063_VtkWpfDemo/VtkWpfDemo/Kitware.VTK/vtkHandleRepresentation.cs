using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHandleRepresentation
/// </summary>
/// <remarks>
///    abstract class for representing widget handles
///
/// This class defines an API for widget handle representations. These
/// representations interact with vtkHandleWidget. Various representations
/// can be used depending on the nature of the handle. The basic functionality
/// of the handle representation is to maintain a position. The position is
/// represented via a vtkCoordinate, meaning that the position can be easily
/// obtained in a variety of coordinate systems.
///
/// Optional features for this representation include an active mode (the widget
/// appears only when the mouse pointer is close to it). The active distance is
/// expressed in pixels and represents a circle in display space.
///
/// The class may be subclassed so that alternative representations can
/// be created.  The class defines an API and a default implementation that
/// the vtkHandleWidget interacts with to render itself in the scene.
///
/// @warning
/// The separation of the widget event handling and representation enables
/// users and developers to create new appearances for the widget. It also
/// facilitates parallel processing, where the client application handles
/// events, and remote representations of the widget are slaves to the
/// client (and do not handle events).
///
/// </remarks>
/// <seealso>
///
/// vtkRectilinearWipeWidget vtkWidgetRepresentation vtkAbstractWidget
/// </seealso>
public abstract class vtkHandleRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Flag controls whether the widget becomes visible when the mouse pointer
	/// moves close to it (i.e., the widget becomes active). By default,
	/// ActiveRepresentation is off and the representation is always visible.
	/// </summary>
	public enum InteractionStateType
	{
		/// <summary>enum member</summary>
		Nearby = 1,
		/// <summary>enum member</summary>
		Outside = 0,
		/// <summary>enum member</summary>
		Scaling = 4,
		/// <summary>enum member</summary>
		Selecting = 2,
		/// <summary>enum member</summary>
		Translating = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHandleRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHandleRepresentation()
	{
		MRClassNameKey = "class vtkHandleRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHandleRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHandleRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_ActiveRepresentationOff_01(HandleRef pThis);

	/// <summary>
	/// Flag controls whether the widget becomes visible when the mouse pointer
	/// moves close to it (i.e., the widget becomes active). By default,
	/// ActiveRepresentation is off and the representation is always visible.
	/// </summary>
	public virtual void ActiveRepresentationOff()
	{
		vtkHandleRepresentation_ActiveRepresentationOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_ActiveRepresentationOn_02(HandleRef pThis);

	/// <summary>
	/// Flag controls whether the widget becomes visible when the mouse pointer
	/// moves close to it (i.e., the widget becomes active). By default,
	/// ActiveRepresentation is off and the representation is always visible.
	/// </summary>
	public virtual void ActiveRepresentationOn()
	{
		vtkHandleRepresentation_ActiveRepresentationOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleRepresentation_CheckConstraint_03(HandleRef pThis, HandleRef renderer, IntPtr pos);

	/// <summary>
	/// Method has to be overridden in the subclasses which has
	/// constraints on placing the handle
	/// (Ex. vtkConstrainedPointHandleRepresentation). It should return 1
	/// if the position is within the constraint, else it should return
	/// 0. By default it returns 1.
	/// </summary>
	public virtual int CheckConstraint(vtkRenderer renderer, IntPtr pos)
	{
		return vtkHandleRepresentation_CheckConstraint_03(GetCppThis(), renderer?.GetCppThis() ?? default(HandleRef), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_ConstrainedOff_04(HandleRef pThis);

	/// <summary>
	/// Specify whether any motions (such as scale, translate, etc.) are
	/// constrained in some way (along an axis, etc.) Widgets can use this
	/// to control the resulting motion.
	/// </summary>
	public virtual void ConstrainedOff()
	{
		vtkHandleRepresentation_ConstrainedOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_ConstrainedOn_05(HandleRef pThis);

	/// <summary>
	/// Specify whether any motions (such as scale, translate, etc.) are
	/// constrained in some way (along an axis, etc.) Widgets can use this
	/// to control the resulting motion.
	/// </summary>
	public virtual void ConstrainedOn()
	{
		vtkHandleRepresentation_ConstrainedOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_DeepCopy_06(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public virtual void DeepCopy(vtkProp prop)
	{
		vtkHandleRepresentation_DeepCopy_06(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleRepresentation_GetActiveRepresentation_07(HandleRef pThis);

	/// <summary>
	/// Flag controls whether the widget becomes visible when the mouse pointer
	/// moves close to it (i.e., the widget becomes active). By default,
	/// ActiveRepresentation is off and the representation is always visible.
	/// </summary>
	public virtual int GetActiveRepresentation()
	{
		return vtkHandleRepresentation_GetActiveRepresentation_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleRepresentation_GetConstrained_08(HandleRef pThis);

	/// <summary>
	/// Specify whether any motions (such as scale, translate, etc.) are
	/// constrained in some way (along an axis, etc.) Widgets can use this
	/// to control the resulting motion.
	/// </summary>
	public virtual int GetConstrained()
	{
		return vtkHandleRepresentation_GetConstrained_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHandleRepresentation_GetCustomTranslationAxis_09(HandleRef pThis);

	/// <summary>
	/// Get/Set the translation axis used when vtkHandleRepresentation::TranslationAxis
	/// is set to Axis::Custom.
	///
	/// @see SetCustomTranslationAxisOn
	/// </summary>
	public virtual double[] GetCustomTranslationAxis()
	{
		IntPtr intPtr = vtkHandleRepresentation_GetCustomTranslationAxis_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_GetCustomTranslationAxis_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get/Set the translation axis used when vtkHandleRepresentation::TranslationAxis
	/// is set to Axis::Custom.
	///
	/// @see SetCustomTranslationAxisOn
	/// </summary>
	public virtual void GetCustomTranslationAxis(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkHandleRepresentation_GetCustomTranslationAxis_10(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_GetCustomTranslationAxis_11(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the translation axis used when vtkHandleRepresentation::TranslationAxis
	/// is set to Axis::Custom.
	///
	/// @see SetCustomTranslationAxisOn
	/// </summary>
	public virtual void GetCustomTranslationAxis(IntPtr _arg)
	{
		vtkHandleRepresentation_GetCustomTranslationAxis_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_GetDisplayPosition_12(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Handles usually have their coordinates set in display coordinates
	/// (generally by an associated widget) and internally maintain the position
	/// in world coordinates. (Using world coordinates insures that handles are
	/// rendered in the right position when the camera view changes.) These
	/// methods are often subclassed because special constraint operations can
	/// be used to control the actual positioning.
	/// </summary>
	public virtual void GetDisplayPosition(IntPtr pos)
	{
		vtkHandleRepresentation_GetDisplayPosition_12(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHandleRepresentation_GetDisplayPosition_13(HandleRef pThis);

	/// <summary>
	/// Handles usually have their coordinates set in display coordinates
	/// (generally by an associated widget) and internally maintain the position
	/// in world coordinates. (Using world coordinates insures that handles are
	/// rendered in the right position when the camera view changes.) These
	/// methods are often subclassed because special constraint operations can
	/// be used to control the actual positioning.
	/// </summary>
	public virtual double[] GetDisplayPosition()
	{
		IntPtr intPtr = vtkHandleRepresentation_GetDisplayPosition_13(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleRepresentation_GetInteractionStateMaxValue_14(HandleRef pThis);

	/// <summary>
	/// The interaction state may be set from a widget (e.g., HandleWidget) or
	/// other object. This controls how the interaction with the widget
	/// proceeds. Normally this method is used as part of a handshaking
	/// processwith the widget: First ComputeInteractionState() is invoked that
	/// returns a state based on geometric considerations (i.e., cursor near a
	/// widget feature), then based on events, the widget may modify this
	/// further.
	/// </summary>
	public virtual int GetInteractionStateMaxValue()
	{
		return vtkHandleRepresentation_GetInteractionStateMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleRepresentation_GetInteractionStateMinValue_15(HandleRef pThis);

	/// <summary>
	/// The interaction state may be set from a widget (e.g., HandleWidget) or
	/// other object. This controls how the interaction with the widget
	/// proceeds. Normally this method is used as part of a handshaking
	/// processwith the widget: First ComputeInteractionState() is invoked that
	/// returns a state based on geometric considerations (i.e., cursor near a
	/// widget feature), then based on events, the widget may modify this
	/// further.
	/// </summary>
	public virtual int GetInteractionStateMinValue()
	{
		return vtkHandleRepresentation_GetInteractionStateMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkHandleRepresentation_GetMTime_16(HandleRef pThis);

	/// <summary>
	/// Overload the superclasses' GetMTime() because the internal vtkCoordinates
	/// are used to keep the state of the representation.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkHandleRepresentation_GetMTime_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHandleRepresentation_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHandleRepresentation_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHandleRepresentation_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHandleRepresentation_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHandleRepresentation_GetPointPlacer_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the point placer. Point placers can be used to dictate constraints
	/// on the placement of handles. As an example, see vtkBoundedPlanePointPlacer
	/// (constrains the placement of handles to a set of bounded planes)
	/// vtkFocalPlanePointPlacer (constrains placement on the focal plane) etc.
	/// The default point placer is vtkPointPlacer (which does not apply any
	/// constraints, so the handles are free to move anywhere).
	/// </summary>
	public virtual vtkPointPlacer GetPointPlacer()
	{
		vtkPointPlacer vtkPointPlacer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHandleRepresentation_GetPointPlacer_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointPlacer2 = (vtkPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointPlacer2.Register(null);
			}
		}
		return vtkPointPlacer2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleRepresentation_GetTolerance_20(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels)
	/// in which the cursor is considered near enough to the widget to
	/// be active.
	/// </summary>
	public virtual int GetTolerance()
	{
		return vtkHandleRepresentation_GetTolerance_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleRepresentation_GetToleranceMaxValue_21(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels)
	/// in which the cursor is considered near enough to the widget to
	/// be active.
	/// </summary>
	public virtual int GetToleranceMaxValue()
	{
		return vtkHandleRepresentation_GetToleranceMaxValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleRepresentation_GetToleranceMinValue_22(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels)
	/// in which the cursor is considered near enough to the widget to
	/// be active.
	/// </summary>
	public virtual int GetToleranceMinValue()
	{
		return vtkHandleRepresentation_GetToleranceMinValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleRepresentation_GetTranslationAxis_23(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual int GetTranslationAxis()
	{
		return vtkHandleRepresentation_GetTranslationAxis_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleRepresentation_GetTranslationAxisMaxValue_24(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual int GetTranslationAxisMaxValue()
	{
		return vtkHandleRepresentation_GetTranslationAxisMaxValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleRepresentation_GetTranslationAxisMinValue_25(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual int GetTranslationAxisMinValue()
	{
		return vtkHandleRepresentation_GetTranslationAxisMinValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_GetTranslationVector_26(HandleRef pThis, IntPtr p1, IntPtr p2, IntPtr v);

	/// <summary>
	/// Gets the translation vector
	/// </summary>
	public virtual void GetTranslationVector(IntPtr p1, IntPtr p2, IntPtr v)
	{
		vtkHandleRepresentation_GetTranslationVector_26(GetCppThis(), p1, p2, v);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_GetWorldPosition_27(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Handles usually have their coordinates set in display coordinates
	/// (generally by an associated widget) and internally maintain the position
	/// in world coordinates. (Using world coordinates insures that handles are
	/// rendered in the right position when the camera view changes.) These
	/// methods are often subclassed because special constraint operations can
	/// be used to control the actual positioning.
	/// </summary>
	public virtual void GetWorldPosition(IntPtr pos)
	{
		vtkHandleRepresentation_GetWorldPosition_27(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHandleRepresentation_GetWorldPosition_28(HandleRef pThis);

	/// <summary>
	/// Handles usually have their coordinates set in display coordinates
	/// (generally by an associated widget) and internally maintain the position
	/// in world coordinates. (Using world coordinates insures that handles are
	/// rendered in the right position when the camera view changes.) These
	/// methods are often subclassed because special constraint operations can
	/// be used to control the actual positioning.
	/// </summary>
	public virtual double[] GetWorldPosition()
	{
		IntPtr intPtr = vtkHandleRepresentation_GetWorldPosition_28(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleRepresentation_IsA_29(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHandleRepresentation_IsA_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHandleRepresentation_IsTranslationConstrained_30(HandleRef pThis);

	/// <summary>
	/// Returns true if ConstrainedAxis
	/// </summary>
	public bool IsTranslationConstrained()
	{
		return (vtkHandleRepresentation_IsTranslationConstrained_30(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleRepresentation_IsTypeOf_31(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHandleRepresentation_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHandleRepresentation_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkHandleRepresentation NewInstance()
	{
		vtkHandleRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHandleRepresentation_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHandleRepresentation_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkHandleRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkHandleRepresentation vtkHandleRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHandleRepresentation_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHandleRepresentation2 = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHandleRepresentation2.Register(null);
			}
		}
		return vtkHandleRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_SetActiveRepresentation_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Flag controls whether the widget becomes visible when the mouse pointer
	/// moves close to it (i.e., the widget becomes active). By default,
	/// ActiveRepresentation is off and the representation is always visible.
	/// </summary>
	public virtual void SetActiveRepresentation(int _arg)
	{
		vtkHandleRepresentation_SetActiveRepresentation_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_SetConstrained_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether any motions (such as scale, translate, etc.) are
	/// constrained in some way (along an axis, etc.) Widgets can use this
	/// to control the resulting motion.
	/// </summary>
	public virtual void SetConstrained(int _arg)
	{
		vtkHandleRepresentation_SetConstrained_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_SetCustomTranslationAxis_36(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Get/Set the translation axis used when vtkHandleRepresentation::TranslationAxis
	/// is set to Axis::Custom.
	///
	/// @see SetCustomTranslationAxisOn
	/// </summary>
	public virtual void SetCustomTranslationAxis(double _arg1, double _arg2, double _arg3)
	{
		vtkHandleRepresentation_SetCustomTranslationAxis_36(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_SetCustomTranslationAxis_37(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the translation axis used when vtkHandleRepresentation::TranslationAxis
	/// is set to Axis::Custom.
	///
	/// @see SetCustomTranslationAxisOn
	/// </summary>
	public virtual void SetCustomTranslationAxis(IntPtr _arg)
	{
		vtkHandleRepresentation_SetCustomTranslationAxis_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_SetCustomTranslationAxisOn_38(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetCustomTranslationAxisOn()
	{
		vtkHandleRepresentation_SetCustomTranslationAxisOn_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_SetDisplayPosition_39(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Handles usually have their coordinates set in display coordinates
	/// (generally by an associated widget) and internally maintain the position
	/// in world coordinates. (Using world coordinates insures that handles are
	/// rendered in the right position when the camera view changes.) These
	/// methods are often subclassed because special constraint operations can
	/// be used to control the actual positioning.
	/// </summary>
	public virtual void SetDisplayPosition(IntPtr pos)
	{
		vtkHandleRepresentation_SetDisplayPosition_39(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_SetInteractionState_40(HandleRef pThis, int _arg);

	/// <summary>
	/// The interaction state may be set from a widget (e.g., HandleWidget) or
	/// other object. This controls how the interaction with the widget
	/// proceeds. Normally this method is used as part of a handshaking
	/// processwith the widget: First ComputeInteractionState() is invoked that
	/// returns a state based on geometric considerations (i.e., cursor near a
	/// widget feature), then based on events, the widget may modify this
	/// further.
	/// </summary>
	public virtual void SetInteractionState(int _arg)
	{
		vtkHandleRepresentation_SetInteractionState_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_SetPointPlacer_41(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the point placer. Point placers can be used to dictate constraints
	/// on the placement of handles. As an example, see vtkBoundedPlanePointPlacer
	/// (constrains the placement of handles to a set of bounded planes)
	/// vtkFocalPlanePointPlacer (constrains placement on the focal plane) etc.
	/// The default point placer is vtkPointPlacer (which does not apply any
	/// constraints, so the handles are free to move anywhere).
	/// </summary>
	public virtual void SetPointPlacer(vtkPointPlacer arg0)
	{
		vtkHandleRepresentation_SetPointPlacer_41(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_SetRenderer_42(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override void SetRenderer(vtkRenderer ren)
	{
		vtkHandleRepresentation_SetRenderer_42(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_SetTolerance_43(HandleRef pThis, int _arg);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels)
	/// in which the cursor is considered near enough to the widget to
	/// be active.
	/// </summary>
	public virtual void SetTolerance(int _arg)
	{
		vtkHandleRepresentation_SetTolerance_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_SetTranslationAxis_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual void SetTranslationAxis(int _arg)
	{
		vtkHandleRepresentation_SetTranslationAxis_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_SetTranslationAxisOff_45(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetTranslationAxisOff()
	{
		vtkHandleRepresentation_SetTranslationAxisOff_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_SetWorldPosition_46(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Handles usually have their coordinates set in display coordinates
	/// (generally by an associated widget) and internally maintain the position
	/// in world coordinates. (Using world coordinates insures that handles are
	/// rendered in the right position when the camera view changes.) These
	/// methods are often subclassed because special constraint operations can
	/// be used to control the actual positioning.
	/// </summary>
	public virtual void SetWorldPosition(IntPtr pos)
	{
		vtkHandleRepresentation_SetWorldPosition_46(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_SetXTranslationAxisOn_47(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetXTranslationAxisOn()
	{
		vtkHandleRepresentation_SetXTranslationAxisOn_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_SetYTranslationAxisOn_48(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetYTranslationAxisOn()
	{
		vtkHandleRepresentation_SetYTranslationAxisOn_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_SetZTranslationAxisOn_49(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetZTranslationAxisOn()
	{
		vtkHandleRepresentation_SetZTranslationAxisOn_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_ShallowCopy_50(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkHandleRepresentation_ShallowCopy_50(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_Translate_51(HandleRef pThis, IntPtr p1, IntPtr p2);

	/// <summary>
	/// Translates world position by vector p1p2 projected on the constraint axis if any.
	/// </summary>
	public virtual void Translate(IntPtr p1, IntPtr p2)
	{
		vtkHandleRepresentation_Translate_51(GetCppThis(), p1, p2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleRepresentation_Translate_52(HandleRef pThis, IntPtr v);

	/// <summary>
	/// Translates world position by vector v projected on the constraint axis if any.
	/// </summary>
	public virtual void Translate(IntPtr v)
	{
		vtkHandleRepresentation_Translate_52(GetCppThis(), v);
	}
}
