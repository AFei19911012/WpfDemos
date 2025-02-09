using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTensorWidget
/// </summary>
/// <remarks>
///    3D widget for manipulating a tensor glyph
///
/// This 3D widget interacts with a vtkTensorRepresentation class (i.e., it
/// handles the events that drive its corresponding representation). The
/// widget is assumed to operate on a single 3x3 real, symmetric tensor
/// located at a specified position. The tensor implicitly defines three
/// orthogonal eigenvectors which indicate the orientation and relative
/// scaling of the widget's representation.
///
/// The widget has the appearance of an oriented box with seven handles: one
/// at the center of the box, and six located at the center of each face. The
/// box can be translated by selecting its center handle; rotated by selecting
/// and rotating one of the box faces around the box center; and scaled (in a
/// particular direction) by selecting the face handles (located on each face)
/// and moving the faces in/out in the direction of the face normal. Uniform
/// scaling is also possible by (default) using the right mouse button (unless
/// the binding has been redefined).
///
/// To use this widget, you generally pair it with a
/// vtkTensorRepresentation (or a subclass). Various options are
/// available in the representation for controlling the widgets' size and
/// position; how the widget appears; and how the widget functions.
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
/// into the vtkTensorWidget's widget events:
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
/// In turn, when these widget events are processed, the vtkTensorWidget
/// invokes the following VTK events on itself (which observers can listen for):
/// &lt;pre&gt;
///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
/// &lt;/pre&gt;
///
///
/// </remarks>
/// <seealso>
///
/// vtkTensorRepresentation vtkBoxWidget2
/// </seealso>
public class vtkTensorWidget : vtkAbstractWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTensorWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTensorWidget()
	{
		MRClassNameKey = "class vtkTensorWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTensorWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTensorWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTensorWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkTensorWidget New()
	{
		vtkTensorWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTensorWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTensorWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public vtkTensorWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTensorWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTensorWidget_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set. By default,
	/// this is an instance of the vtkTensorRepresentation class.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkTensorWidget_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorWidget_GetMoveFacesEnabled_02(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be
	/// enabled and disabled. Scaling refers to scaling of the whole widget at
	/// once, (default is through right mouse button) while face movement refers
	/// to scaling of the widget one face (axis) at a time (default through
	/// grabbing one of the representation spherical handles).
	/// </summary>
	public virtual int GetMoveFacesEnabled()
	{
		return vtkTensorWidget_GetMoveFacesEnabled_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTensorWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTensorWidget_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTensorWidget_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTensorWidget_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorWidget_GetRotationEnabled_05(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be
	/// enabled and disabled. Scaling refers to scaling of the whole widget at
	/// once, (default is through right mouse button) while face movement refers
	/// to scaling of the widget one face (axis) at a time (default through
	/// grabbing one of the representation spherical handles).
	/// </summary>
	public virtual int GetRotationEnabled()
	{
		return vtkTensorWidget_GetRotationEnabled_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorWidget_GetScalingEnabled_06(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be
	/// enabled and disabled. Scaling refers to scaling of the whole widget at
	/// once, (default is through right mouse button) while face movement refers
	/// to scaling of the widget one face (axis) at a time (default through
	/// grabbing one of the representation spherical handles).
	/// </summary>
	public virtual int GetScalingEnabled()
	{
		return vtkTensorWidget_GetScalingEnabled_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorWidget_GetTranslationEnabled_07(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be
	/// enabled and disabled. Scaling refers to scaling of the whole widget at
	/// once, (default is through right mouse button) while face movement refers
	/// to scaling of the widget one face (axis) at a time (default through
	/// grabbing one of the representation spherical handles).
	/// </summary>
	public virtual int GetTranslationEnabled()
	{
		return vtkTensorWidget_GetTranslationEnabled_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorWidget_IsA_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTensorWidget_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorWidget_IsTypeOf_09(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTensorWidget_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorWidget_MoveFacesEnabledOff_10(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be
	/// enabled and disabled. Scaling refers to scaling of the whole widget at
	/// once, (default is through right mouse button) while face movement refers
	/// to scaling of the widget one face (axis) at a time (default through
	/// grabbing one of the representation spherical handles).
	/// </summary>
	public virtual void MoveFacesEnabledOff()
	{
		vtkTensorWidget_MoveFacesEnabledOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorWidget_MoveFacesEnabledOn_11(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be
	/// enabled and disabled. Scaling refers to scaling of the whole widget at
	/// once, (default is through right mouse button) while face movement refers
	/// to scaling of the widget one face (axis) at a time (default through
	/// grabbing one of the representation spherical handles).
	/// </summary>
	public virtual void MoveFacesEnabledOn()
	{
		vtkTensorWidget_MoveFacesEnabledOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTensorWidget_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new vtkTensorWidget NewInstance()
	{
		vtkTensorWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTensorWidget_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTensorWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorWidget_RotationEnabledOff_14(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be
	/// enabled and disabled. Scaling refers to scaling of the whole widget at
	/// once, (default is through right mouse button) while face movement refers
	/// to scaling of the widget one face (axis) at a time (default through
	/// grabbing one of the representation spherical handles).
	/// </summary>
	public virtual void RotationEnabledOff()
	{
		vtkTensorWidget_RotationEnabledOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorWidget_RotationEnabledOn_15(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be
	/// enabled and disabled. Scaling refers to scaling of the whole widget at
	/// once, (default is through right mouse button) while face movement refers
	/// to scaling of the widget one face (axis) at a time (default through
	/// grabbing one of the representation spherical handles).
	/// </summary>
	public virtual void RotationEnabledOn()
	{
		vtkTensorWidget_RotationEnabledOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTensorWidget_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkTensorWidget SafeDownCast(vtkObjectBase o)
	{
		vtkTensorWidget vtkTensorWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTensorWidget_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTensorWidget2 = (vtkTensorWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTensorWidget2.Register(null);
			}
		}
		return vtkTensorWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorWidget_ScalingEnabledOff_17(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be
	/// enabled and disabled. Scaling refers to scaling of the whole widget at
	/// once, (default is through right mouse button) while face movement refers
	/// to scaling of the widget one face (axis) at a time (default through
	/// grabbing one of the representation spherical handles).
	/// </summary>
	public virtual void ScalingEnabledOff()
	{
		vtkTensorWidget_ScalingEnabledOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorWidget_ScalingEnabledOn_18(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be
	/// enabled and disabled. Scaling refers to scaling of the whole widget at
	/// once, (default is through right mouse button) while face movement refers
	/// to scaling of the widget one face (axis) at a time (default through
	/// grabbing one of the representation spherical handles).
	/// </summary>
	public virtual void ScalingEnabledOn()
	{
		vtkTensorWidget_ScalingEnabledOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorWidget_SetEnabled_19(HandleRef pThis, int enabling);

	/// <summary>
	/// Override superclasses' SetEnabled() method because the line
	/// widget must enable its internal handle widgets.
	/// </summary>
	public override void SetEnabled(int enabling)
	{
		vtkTensorWidget_SetEnabled_19(GetCppThis(), enabling);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorWidget_SetMoveFacesEnabled_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be
	/// enabled and disabled. Scaling refers to scaling of the whole widget at
	/// once, (default is through right mouse button) while face movement refers
	/// to scaling of the widget one face (axis) at a time (default through
	/// grabbing one of the representation spherical handles).
	/// </summary>
	public virtual void SetMoveFacesEnabled(int _arg)
	{
		vtkTensorWidget_SetMoveFacesEnabled_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorWidget_SetRepresentation_21(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkTensorRepresentation r)
	{
		vtkTensorWidget_SetRepresentation_21(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorWidget_SetRotationEnabled_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be
	/// enabled and disabled. Scaling refers to scaling of the whole widget at
	/// once, (default is through right mouse button) while face movement refers
	/// to scaling of the widget one face (axis) at a time (default through
	/// grabbing one of the representation spherical handles).
	/// </summary>
	public virtual void SetRotationEnabled(int _arg)
	{
		vtkTensorWidget_SetRotationEnabled_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorWidget_SetScalingEnabled_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be
	/// enabled and disabled. Scaling refers to scaling of the whole widget at
	/// once, (default is through right mouse button) while face movement refers
	/// to scaling of the widget one face (axis) at a time (default through
	/// grabbing one of the representation spherical handles).
	/// </summary>
	public virtual void SetScalingEnabled(int _arg)
	{
		vtkTensorWidget_SetScalingEnabled_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorWidget_SetTranslationEnabled_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be
	/// enabled and disabled. Scaling refers to scaling of the whole widget at
	/// once, (default is through right mouse button) while face movement refers
	/// to scaling of the widget one face (axis) at a time (default through
	/// grabbing one of the representation spherical handles).
	/// </summary>
	public virtual void SetTranslationEnabled(int _arg)
	{
		vtkTensorWidget_SetTranslationEnabled_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorWidget_TranslationEnabledOff_25(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be
	/// enabled and disabled. Scaling refers to scaling of the whole widget at
	/// once, (default is through right mouse button) while face movement refers
	/// to scaling of the widget one face (axis) at a time (default through
	/// grabbing one of the representation spherical handles).
	/// </summary>
	public virtual void TranslationEnabledOff()
	{
		vtkTensorWidget_TranslationEnabledOff_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorWidget_TranslationEnabledOn_26(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, rotation, scaling and face movement can all be
	/// enabled and disabled. Scaling refers to scaling of the whole widget at
	/// once, (default is through right mouse button) while face movement refers
	/// to scaling of the widget one face (axis) at a time (default through
	/// grabbing one of the representation spherical handles).
	/// </summary>
	public virtual void TranslationEnabledOn()
	{
		vtkTensorWidget_TranslationEnabledOn_26(GetCppThis());
	}
}
