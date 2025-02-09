using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSphereWidget2
/// </summary>
/// <remarks>
///    3D widget for manipulating a point on a sphere
///
/// This 3D widget interacts with a vtkSphereRepresentation class (i.e., it
/// handles the events that drive its corresponding representation). It can be
/// used to position a point on a sphere (for example, to place a light or
/// camera), or to position a sphere in a scene, including translating and
/// scaling the sphere.
///
/// A nice feature of vtkSphereWidget2, like any 3D widget, is that it will
/// work in combination with the current interactor style (or any other
/// interactor observer). That is, if vtkSphereWidget2 does not handle an
/// event, then all other registered observers (including the interactor
/// style) have an opportunity to process the event. Otherwise, the
/// vtkSphereWidget2 will terminate the processing of the event that it
/// handles.
///
/// To use this widget, you generally pair it with a vtkSphereRepresentation
/// (or a subclass). Various options are available in the representation for
/// controlling how the widget appears, and how the widget functions.
///
/// @par Event Bindings:
/// By default, the widget responds to the following VTK events (i.e., it
/// watches the vtkRenderWindowInteractor for these events):
/// &lt;pre&gt;
/// If the handle or sphere are selected:
///   LeftButtonPressEvent - select the handle or sphere
///   LeftButtonReleaseEvent - release the handle to sphere
///   MouseMoveEvent - move the handle or translate the sphere
/// In all the cases, independent of what is picked, the widget responds to the
/// following VTK events:
///   MiddleButtonPressEvent - translate the representation
///   MiddleButtonReleaseEvent - stop translating the representation
///   RightButtonPressEvent - scale the widget's representation
///   RightButtonReleaseEvent - stop scaling the representation
///   MouseMoveEvent - scale (if right button) or move (if middle button) the widget
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// Note that the event bindings described above can be changed using this
/// class's vtkWidgetEventTranslator. This class translates VTK events
/// into the vtkSphereWidget2's widget events:
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
/// In turn, when these widget events are processed, the vtkSphereWidget2
/// invokes the following VTK events on itself (which observers can listen for):
/// &lt;pre&gt;
///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
/// &lt;/pre&gt;
///
///
/// @par Event Bindings:
/// This class, and the affiliated vtkSphereRepresentation, are second generation
/// VTK widgets. An earlier version of this functionality was defined in the
/// class vtkSphereWidget.
///
/// </remarks>
/// <seealso>
///
/// vtkSphereRepresentation vtkSphereWidget
/// </seealso>
public class vtkSphereWidget2 : vtkAbstractWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSphereWidget2";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSphereWidget2()
	{
		MRClassNameKey = "class vtkSphereWidget2";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphereWidget2"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSphereWidget2(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereWidget2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkSphereWidget2 New()
	{
		vtkSphereWidget2 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereWidget2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSphereWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkSphereWidget2()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSphereWidget2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSphereWidget2_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set. By default,
	/// this is an instance of the vtkSphereRepresentation class.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkSphereWidget2_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphereWidget2_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard class methods for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSphereWidget2_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphereWidget2_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard class methods for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSphereWidget2_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereWidget2_GetScalingEnabled_04(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, and scaling can all be enabled and disabled.
	/// </summary>
	public virtual int GetScalingEnabled()
	{
		return vtkSphereWidget2_GetScalingEnabled_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereWidget2_GetTranslationEnabled_05(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, and scaling can all be enabled and disabled.
	/// </summary>
	public virtual int GetTranslationEnabled()
	{
		return vtkSphereWidget2_GetTranslationEnabled_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereWidget2_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard class methods for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSphereWidget2_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereWidget2_IsTypeOf_07(string type);

	/// <summary>
	/// Standard class methods for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSphereWidget2_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereWidget2_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard class methods for type information and printing.
	/// </summary>
	public new vtkSphereWidget2 NewInstance()
	{
		vtkSphereWidget2 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereWidget2_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSphereWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereWidget2_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard class methods for type information and printing.
	/// </summary>
	public new static vtkSphereWidget2 SafeDownCast(vtkObjectBase o)
	{
		vtkSphereWidget2 vtkSphereWidget3 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereWidget2_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSphereWidget3 = (vtkSphereWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSphereWidget3.Register(null);
			}
		}
		return vtkSphereWidget3;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget2_ScalingEnabledOff_11(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, and scaling can all be enabled and disabled.
	/// </summary>
	public virtual void ScalingEnabledOff()
	{
		vtkSphereWidget2_ScalingEnabledOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget2_ScalingEnabledOn_12(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, and scaling can all be enabled and disabled.
	/// </summary>
	public virtual void ScalingEnabledOn()
	{
		vtkSphereWidget2_ScalingEnabledOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget2_SetEnabled_13(HandleRef pThis, int enabling);

	/// <summary>
	/// Override superclasses' SetEnabled() method because the line
	/// widget must enable its internal handle widgets.
	/// </summary>
	public override void SetEnabled(int enabling)
	{
		vtkSphereWidget2_SetEnabled_13(GetCppThis(), enabling);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget2_SetRepresentation_14(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of
	/// vtkProp so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkSphereRepresentation r)
	{
		vtkSphereWidget2_SetRepresentation_14(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget2_SetScalingEnabled_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, and scaling can all be enabled and disabled.
	/// </summary>
	public virtual void SetScalingEnabled(int _arg)
	{
		vtkSphereWidget2_SetScalingEnabled_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget2_SetTranslationEnabled_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, and scaling can all be enabled and disabled.
	/// </summary>
	public virtual void SetTranslationEnabled(int _arg)
	{
		vtkSphereWidget2_SetTranslationEnabled_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget2_TranslationEnabledOff_17(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, and scaling can all be enabled and disabled.
	/// </summary>
	public virtual void TranslationEnabledOff()
	{
		vtkSphereWidget2_TranslationEnabledOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget2_TranslationEnabledOn_18(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget (i.e., how it processes
	/// events). Translation, and scaling can all be enabled and disabled.
	/// </summary>
	public virtual void TranslationEnabledOn()
	{
		vtkSphereWidget2_TranslationEnabledOn_18(GetCppThis());
	}
}
