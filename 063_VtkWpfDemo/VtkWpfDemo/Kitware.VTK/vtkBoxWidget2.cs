using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBoxWidget2
/// </summary>
/// <remarks>
///    3D widget for manipulating a box
///
/// This 3D widget interacts with a vtkBoxRepresentation class (i.e., it
/// handles the events that drive its corresponding representation). The
/// representation is assumed to represent a region of interest that is
/// represented by an arbitrarily oriented hexahedron (or box) with interior
/// face angles of 90 degrees (i.e., orthogonal faces). The representation
/// manifests seven handles that can be moused on and manipulated, plus the
/// six faces can also be interacted with. The first six handles are placed on
/// the six faces, the seventh is in the center of the box. In addition, a
/// bounding box outline is shown, the "faces" of which can be selected for
/// object rotation or scaling. A nice feature of vtkBoxWidget2, like any 3D
/// widget, will work with the current interactor style. That is, if
/// vtkBoxWidget2 does not handle an event, then all other registered
/// observers (including the interactor style) have an opportunity to process
/// the event. Otherwise, the vtkBoxWidget will terminate the processing of
/// the event that it handles.
///
/// To use this widget, you generally pair it with a vtkBoxRepresentation
/// (or a subclass). Various options are available in the representation for
/// controlling how the widget appears, and how the widget functions.
///
/// @par Event Bindings:
/// By default, the widget responds to the following VTK events (i.e., it
/// watches the vtkRenderWindowInteractor for these events):
/// &lt;pre&gt;
/// If one of the seven handles are selected:
///   LeftButtonPressEvent - select the appropriate handle
///   LeftButtonReleaseEvent - release the currently selected handle
///   MouseMoveEvent - move the handle
/// If one of the faces is selected:
///   LeftButtonPressEvent - select a box face
///   LeftButtonReleaseEvent - release the box face
///   MouseMoveEvent - rotate the box
/// In all the cases, independent of what is picked, the widget responds to the
/// following VTK events:
///   MiddleButtonPressEvent - translate the widget
///   MiddleButtonReleaseEvent - release the widget
///   RightButtonPressEvent - scale the widget's representation
///   RightButtonReleaseEvent - stop scaling the widget
///   MouseMoveEvent - scale (if right button) or move (if middle button) the widget
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// Note that the event bindings described above can be changed using this
/// class's vtkWidgetEventTranslator. This class translates VTK events
/// into the vtkBoxWidget2's widget events:
/// &lt;pre&gt;
///   vtkWidgetEvent::Select -- some part of the widget has been selected
///   vtkWidgetEvent::EndSelect -- the selection process has completed
///   vtkWidgetEvent::Scale -- some part of the widget has been selected
///   vtkWidgetEvent::EndScale -- the selection process has completed
///   vtkWidgetEvent::Translate -- some part of the widget has been selected
///   vtkWidgetEvent::EndTranslate -- the selection process has completed
///   vtkWidgetEvent::Move -- a request for motion has been invoked
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// In turn, when these widget events are processed, the vtkBoxWidget2
/// invokes the following VTK events on itself (which observers can listen for):
/// &lt;pre&gt;
///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
/// &lt;/pre&gt;
///
///
/// @par Event Bindings:
/// This class, and the affiliated vtkBoxRepresentation, are second generation
/// VTK widgets. An earlier version of this functionality was defined in the
/// class vtkBoxWidget.
///
/// </remarks>
/// <seealso>
///
/// vtkBoxRepresentation vtkBoxWidget
/// </seealso>
public class vtkBoxWidget2 : vtkAbstractWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBoxWidget2";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBoxWidget2()
	{
		MRClassNameKey = "class vtkBoxWidget2";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoxWidget2"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBoxWidget2(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxWidget2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkBoxWidget2 New()
	{
		vtkBoxWidget2 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxWidget2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBoxWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkBoxWidget2()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBoxWidget2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBoxWidget2_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set. By default,
	/// this is an instance of the vtkBoxRepresentation class.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkBoxWidget2_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxWidget2_GetMoveFacesEnabled_02(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be enabled and
	/// disabled. Scaling refers to scaling of the whole widget at once,
	/// (default is through right mouse button) while face movement refers to
	/// scaling of the widget one face (axis) at a time (default through grabbing
	/// one of the representation spherical handles).
	/// </summary>
	public virtual int GetMoveFacesEnabled()
	{
		return vtkBoxWidget2_GetMoveFacesEnabled_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBoxWidget2_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard class methods for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBoxWidget2_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBoxWidget2_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard class methods for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBoxWidget2_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxWidget2_GetRotationEnabled_05(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be enabled and
	/// disabled. Scaling refers to scaling of the whole widget at once,
	/// (default is through right mouse button) while face movement refers to
	/// scaling of the widget one face (axis) at a time (default through grabbing
	/// one of the representation spherical handles).
	/// </summary>
	public virtual int GetRotationEnabled()
	{
		return vtkBoxWidget2_GetRotationEnabled_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxWidget2_GetScalingEnabled_06(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be enabled and
	/// disabled. Scaling refers to scaling of the whole widget at once,
	/// (default is through right mouse button) while face movement refers to
	/// scaling of the widget one face (axis) at a time (default through grabbing
	/// one of the representation spherical handles).
	/// </summary>
	public virtual int GetScalingEnabled()
	{
		return vtkBoxWidget2_GetScalingEnabled_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxWidget2_GetTranslationEnabled_07(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be enabled and
	/// disabled. Scaling refers to scaling of the whole widget at once,
	/// (default is through right mouse button) while face movement refers to
	/// scaling of the widget one face (axis) at a time (default through grabbing
	/// one of the representation spherical handles).
	/// </summary>
	public virtual int GetTranslationEnabled()
	{
		return vtkBoxWidget2_GetTranslationEnabled_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxWidget2_IsA_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard class methods for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBoxWidget2_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxWidget2_IsTypeOf_09(string type);

	/// <summary>
	/// Standard class methods for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBoxWidget2_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget2_MoveFacesEnabledOff_10(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be enabled and
	/// disabled. Scaling refers to scaling of the whole widget at once,
	/// (default is through right mouse button) while face movement refers to
	/// scaling of the widget one face (axis) at a time (default through grabbing
	/// one of the representation spherical handles).
	/// </summary>
	public virtual void MoveFacesEnabledOff()
	{
		vtkBoxWidget2_MoveFacesEnabledOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget2_MoveFacesEnabledOn_11(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be enabled and
	/// disabled. Scaling refers to scaling of the whole widget at once,
	/// (default is through right mouse button) while face movement refers to
	/// scaling of the widget one face (axis) at a time (default through grabbing
	/// one of the representation spherical handles).
	/// </summary>
	public virtual void MoveFacesEnabledOn()
	{
		vtkBoxWidget2_MoveFacesEnabledOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxWidget2_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard class methods for type information and printing.
	/// </summary>
	public new vtkBoxWidget2 NewInstance()
	{
		vtkBoxWidget2 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxWidget2_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBoxWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget2_RotationEnabledOff_14(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be enabled and
	/// disabled. Scaling refers to scaling of the whole widget at once,
	/// (default is through right mouse button) while face movement refers to
	/// scaling of the widget one face (axis) at a time (default through grabbing
	/// one of the representation spherical handles).
	/// </summary>
	public virtual void RotationEnabledOff()
	{
		vtkBoxWidget2_RotationEnabledOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget2_RotationEnabledOn_15(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be enabled and
	/// disabled. Scaling refers to scaling of the whole widget at once,
	/// (default is through right mouse button) while face movement refers to
	/// scaling of the widget one face (axis) at a time (default through grabbing
	/// one of the representation spherical handles).
	/// </summary>
	public virtual void RotationEnabledOn()
	{
		vtkBoxWidget2_RotationEnabledOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxWidget2_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard class methods for type information and printing.
	/// </summary>
	public new static vtkBoxWidget2 SafeDownCast(vtkObjectBase o)
	{
		vtkBoxWidget2 vtkBoxWidget3 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxWidget2_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBoxWidget3 = (vtkBoxWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBoxWidget3.Register(null);
			}
		}
		return vtkBoxWidget3;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget2_ScalingEnabledOff_17(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be enabled and
	/// disabled. Scaling refers to scaling of the whole widget at once,
	/// (default is through right mouse button) while face movement refers to
	/// scaling of the widget one face (axis) at a time (default through grabbing
	/// one of the representation spherical handles).
	/// </summary>
	public virtual void ScalingEnabledOff()
	{
		vtkBoxWidget2_ScalingEnabledOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget2_ScalingEnabledOn_18(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be enabled and
	/// disabled. Scaling refers to scaling of the whole widget at once,
	/// (default is through right mouse button) while face movement refers to
	/// scaling of the widget one face (axis) at a time (default through grabbing
	/// one of the representation spherical handles).
	/// </summary>
	public virtual void ScalingEnabledOn()
	{
		vtkBoxWidget2_ScalingEnabledOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget2_SetEnabled_19(HandleRef pThis, int enabling);

	/// <summary>
	/// Override superclasses' SetEnabled() method because the line
	/// widget must enable its internal handle widgets.
	/// </summary>
	public override void SetEnabled(int enabling)
	{
		vtkBoxWidget2_SetEnabled_19(GetCppThis(), enabling);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget2_SetMoveFacesEnabled_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be enabled and
	/// disabled. Scaling refers to scaling of the whole widget at once,
	/// (default is through right mouse button) while face movement refers to
	/// scaling of the widget one face (axis) at a time (default through grabbing
	/// one of the representation spherical handles).
	/// </summary>
	public virtual void SetMoveFacesEnabled(int _arg)
	{
		vtkBoxWidget2_SetMoveFacesEnabled_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget2_SetRepresentation_21(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkBoxRepresentation r)
	{
		vtkBoxWidget2_SetRepresentation_21(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget2_SetRotationEnabled_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be enabled and
	/// disabled. Scaling refers to scaling of the whole widget at once,
	/// (default is through right mouse button) while face movement refers to
	/// scaling of the widget one face (axis) at a time (default through grabbing
	/// one of the representation spherical handles).
	/// </summary>
	public virtual void SetRotationEnabled(int _arg)
	{
		vtkBoxWidget2_SetRotationEnabled_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget2_SetScalingEnabled_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be enabled and
	/// disabled. Scaling refers to scaling of the whole widget at once,
	/// (default is through right mouse button) while face movement refers to
	/// scaling of the widget one face (axis) at a time (default through grabbing
	/// one of the representation spherical handles).
	/// </summary>
	public virtual void SetScalingEnabled(int _arg)
	{
		vtkBoxWidget2_SetScalingEnabled_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget2_SetTranslationEnabled_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be enabled and
	/// disabled. Scaling refers to scaling of the whole widget at once,
	/// (default is through right mouse button) while face movement refers to
	/// scaling of the widget one face (axis) at a time (default through grabbing
	/// one of the representation spherical handles).
	/// </summary>
	public virtual void SetTranslationEnabled(int _arg)
	{
		vtkBoxWidget2_SetTranslationEnabled_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget2_TranslationEnabledOff_25(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be enabled and
	/// disabled. Scaling refers to scaling of the whole widget at once,
	/// (default is through right mouse button) while face movement refers to
	/// scaling of the widget one face (axis) at a time (default through grabbing
	/// one of the representation spherical handles).
	/// </summary>
	public virtual void TranslationEnabledOff()
	{
		vtkBoxWidget2_TranslationEnabledOff_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget2_TranslationEnabledOn_26(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be enabled and
	/// disabled. Scaling refers to scaling of the whole widget at once,
	/// (default is through right mouse button) while face movement refers to
	/// scaling of the widget one face (axis) at a time (default through grabbing
	/// one of the representation spherical handles).
	/// </summary>
	public virtual void TranslationEnabledOn()
	{
		vtkBoxWidget2_TranslationEnabledOn_26(GetCppThis());
	}
}
