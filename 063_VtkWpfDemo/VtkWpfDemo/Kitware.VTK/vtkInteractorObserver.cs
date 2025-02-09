using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorObserver
/// </summary>
/// <remarks>
///    an abstract superclass for classes observing events invoked by vtkRenderWindowInteractor
///
/// vtkInteractorObserver is an abstract superclass for subclasses that observe
/// events invoked by vtkRenderWindowInteractor. These subclasses are
/// typically things like 3D widgets; objects that interact with actors
/// in the scene, or interactively probe the scene for information.
///
/// vtkInteractorObserver defines the method SetInteractor() and enables and
/// disables the processing of events by the vtkInteractorObserver. Use the
/// methods EnabledOn() or SetEnabled(1) to turn on the interactor observer,
/// and the methods EnabledOff() or SetEnabled(0) to turn off the interactor.
/// Initial value is 0.
///
/// To support interactive manipulation of objects, this class (and
/// subclasses) invoke the events StartInteractionEvent, InteractionEvent, and
/// EndInteractionEvent.  These events are invoked when the
/// vtkInteractorObserver enters a state where rapid response is desired:
/// mouse motion, etc. The events can be used, for example, to set the desired
/// update frame rate (StartInteractionEvent), operate on data or update a
/// pipeline (InteractionEvent), and set the desired frame rate back to normal
/// values (EndInteractionEvent). Two other events, EnableEvent and
/// DisableEvent, are invoked when the interactor observer is enabled or
/// disabled.
///
/// </remarks>
/// <seealso>
///
/// vtk3DWidget vtkBoxWidget vtkLineWidget
/// </seealso>
public class vtkInteractorObserver : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorObserver";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorObserver()
	{
		MRClassNameKey = "class vtkInteractorObserver";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorObserver"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorObserver(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_ComputeDisplayToWorld_01(HandleRef ren, double x, double y, double z, IntPtr worldPt);

	/// <summary>
	/// Convenience methods for outside classes. Make sure that the
	/// parameter "ren" is not-null.
	/// </summary>
	public static void ComputeDisplayToWorld(vtkRenderer ren, double x, double y, double z, IntPtr worldPt)
	{
		vtkInteractorObserver_ComputeDisplayToWorld_01(ren?.GetCppThis() ?? default(HandleRef), x, y, z, worldPt);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_ComputeWorldToDisplay_02(HandleRef ren, double x, double y, double z, IntPtr displayPt);

	/// <summary>
	/// Convenience methods for outside classes. Make sure that the
	/// parameter "ren" is not-null.
	/// </summary>
	public static void ComputeWorldToDisplay(vtkRenderer ren, double x, double y, double z, IntPtr displayPt)
	{
		vtkInteractorObserver_ComputeWorldToDisplay_02(ren?.GetCppThis() ?? default(HandleRef), x, y, z, displayPt);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_EnabledOff_03(HandleRef pThis);

	/// <summary>
	/// Methods for turning the interactor observer on and off, and determining
	/// its state. All subclasses must provide the SetEnabled() method.
	/// Enabling a vtkInteractorObserver has the side effect of adding
	/// observers; disabling it removes the observers. Prior to enabling the
	/// vtkInteractorObserver you must set the render window interactor (via
	/// SetInteractor()). Initial value is 0.
	/// </summary>
	public void EnabledOff()
	{
		vtkInteractorObserver_EnabledOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_EnabledOn_04(HandleRef pThis);

	/// <summary>
	/// Methods for turning the interactor observer on and off, and determining
	/// its state. All subclasses must provide the SetEnabled() method.
	/// Enabling a vtkInteractorObserver has the side effect of adding
	/// observers; disabling it removes the observers. Prior to enabling the
	/// vtkInteractorObserver you must set the render window interactor (via
	/// SetInteractor()). Initial value is 0.
	/// </summary>
	public void EnabledOn()
	{
		vtkInteractorObserver_EnabledOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorObserver_GetCurrentRenderer_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the current renderer. Normally when the widget is activated
	/// (SetEnabled(1) or when keypress activation takes place), the renderer
	/// over which the mouse pointer is positioned is used and assigned to
	/// this Ivar. Alternatively, you might want to set the CurrentRenderer
	/// explicitly. This is especially true with multiple viewports (renderers).
	/// WARNING: note that if the DefaultRenderer Ivar is set (see above),
	/// it will always override the parameter passed to SetCurrentRenderer,
	/// unless it is NULL.
	/// (i.e., SetCurrentRenderer(foo) = SetCurrentRenderer(DefaultRenderer).
	/// </summary>
	public virtual vtkRenderer GetCurrentRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorObserver_GetCurrentRenderer_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderer2 = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderer2.Register(null);
			}
		}
		return vtkRenderer2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorObserver_GetDefaultRenderer_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the default renderer to use when activating the interactor
	/// observer. Normally when the widget is activated (SetEnabled(1) or when
	/// keypress activation takes place), the renderer over which the mouse
	/// pointer is positioned is used. Alternatively, you can specify the
	/// renderer to bind the interactor to when the interactor observer is
	/// activated.
	/// </summary>
	public virtual vtkRenderer GetDefaultRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorObserver_GetDefaultRenderer_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderer2 = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderer2.Register(null);
			}
		}
		return vtkRenderer2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorObserver_GetEnabled_07(HandleRef pThis);

	/// <summary>
	/// Methods for turning the interactor observer on and off, and determining
	/// its state. All subclasses must provide the SetEnabled() method.
	/// Enabling a vtkInteractorObserver has the side effect of adding
	/// observers; disabling it removes the observers. Prior to enabling the
	/// vtkInteractorObserver you must set the render window interactor (via
	/// SetInteractor()). Initial value is 0.
	/// </summary>
	public int GetEnabled()
	{
		return vtkInteractorObserver_GetEnabled_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorObserver_GetInteractor_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This method is used to associate the widget with the render window
	/// interactor.  Observers of the appropriate events invoked in the render
	/// window interactor are set up as a result of this method invocation.
	/// The SetInteractor() method must be invoked prior to enabling the
	/// vtkInteractorObserver.
	/// It automatically registers available pickers to the Picking Manager.
	/// </summary>
	public virtual vtkRenderWindowInteractor GetInteractor()
	{
		vtkRenderWindowInteractor vtkRenderWindowInteractor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorObserver_GetInteractor_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderWindowInteractor2 = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderWindowInteractor2.Register(null);
			}
		}
		return vtkRenderWindowInteractor2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorObserver_GetKeyPressActivation_09(HandleRef pThis);

	/// <summary>
	/// Enable/Disable of the use of a keypress to turn on and off the
	/// interactor observer. (By default, the keypress is 'i' for "interactor
	/// observer".)  Set the KeyPressActivationValue to change which key
	/// activates the widget.)
	/// </summary>
	public virtual int GetKeyPressActivation()
	{
		return vtkInteractorObserver_GetKeyPressActivation_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern sbyte vtkInteractorObserver_GetKeyPressActivationValue_10(HandleRef pThis);

	/// <summary>
	/// Specify which key press value to use to activate the interactor observer
	/// (if key press activation is enabled). By default, the key press
	/// activation value is 'i'. Note: once the SetInteractor() method is
	/// invoked, changing the key press activation value will not affect the key
	/// press until SetInteractor(NULL)/SetInteractor(iren) is called.
	/// </summary>
	public virtual sbyte GetKeyPressActivationValue()
	{
		return vtkInteractorObserver_GetKeyPressActivationValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorObserver_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorObserver_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorObserver_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorObserver_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkInteractorObserver_GetPickingManaged_13(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the use of a manager to process the picking.
	/// Enabled by default.
	/// </summary>
	public virtual bool GetPickingManaged()
	{
		return (vtkInteractorObserver_GetPickingManaged_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkInteractorObserver_GetPriority_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the priority at which events are processed. This is used when
	/// multiple interactor observers are used simultaneously. The default value
	/// is 0.0 (lowest priority.) Note that when multiple interactor observer
	/// have the same priority, then the last observer added will process the
	/// event first. (Note: once the SetInteractor() method has been called,
	/// changing the priority does not effect event processing. You will have
	/// to SetInteractor(NULL), change priority, and then SetInteractor(iren)
	/// to have the priority take effect.)
	/// </summary>
	public virtual float GetPriority()
	{
		return vtkInteractorObserver_GetPriority_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkInteractorObserver_GetPriorityMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the priority at which events are processed. This is used when
	/// multiple interactor observers are used simultaneously. The default value
	/// is 0.0 (lowest priority.) Note that when multiple interactor observer
	/// have the same priority, then the last observer added will process the
	/// event first. (Note: once the SetInteractor() method has been called,
	/// changing the priority does not effect event processing. You will have
	/// to SetInteractor(NULL), change priority, and then SetInteractor(iren)
	/// to have the priority take effect.)
	/// </summary>
	public virtual float GetPriorityMaxValue()
	{
		return vtkInteractorObserver_GetPriorityMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkInteractorObserver_GetPriorityMinValue_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the priority at which events are processed. This is used when
	/// multiple interactor observers are used simultaneously. The default value
	/// is 0.0 (lowest priority.) Note that when multiple interactor observer
	/// have the same priority, then the last observer added will process the
	/// event first. (Note: once the SetInteractor() method has been called,
	/// changing the priority does not effect event processing. You will have
	/// to SetInteractor(NULL), change priority, and then SetInteractor(iren)
	/// to have the priority take effect.)
	/// </summary>
	public virtual float GetPriorityMinValue()
	{
		return vtkInteractorObserver_GetPriorityMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_GrabFocus_17(HandleRef pThis, HandleRef mouseEvents, HandleRef keypressEvents);

	/// <summary>
	/// These methods enable an interactor observer to exclusively grab all
	/// events invoked by its associated vtkRenderWindowInteractor. (This method
	/// is typically used by widgets to grab events once an event sequence
	/// begins.) The GrabFocus() signature takes up to two vtkCommands
	/// corresponding to mouse events and keypress events. (These two commands
	/// are separated so that the widget can listen for its activation keypress,
	/// as well as listening for DeleteEvents, without actually having to process
	/// mouse events.)
	/// </summary>
	public void GrabFocus(vtkCommand mouseEvents, vtkCommand keypressEvents)
	{
		vtkInteractorObserver_GrabFocus_17(GetCppThis(), mouseEvents?.GetCppThis() ?? default(HandleRef), keypressEvents?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorObserver_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorObserver_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorObserver_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorObserver_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_KeyPressActivationOff_20(HandleRef pThis);

	/// <summary>
	/// Enable/Disable of the use of a keypress to turn on and off the
	/// interactor observer. (By default, the keypress is 'i' for "interactor
	/// observer".)  Set the KeyPressActivationValue to change which key
	/// activates the widget.)
	/// </summary>
	public virtual void KeyPressActivationOff()
	{
		vtkInteractorObserver_KeyPressActivationOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_KeyPressActivationOn_21(HandleRef pThis);

	/// <summary>
	/// Enable/Disable of the use of a keypress to turn on and off the
	/// interactor observer. (By default, the keypress is 'i' for "interactor
	/// observer".)  Set the KeyPressActivationValue to change which key
	/// activates the widget.)
	/// </summary>
	public virtual void KeyPressActivationOn()
	{
		vtkInteractorObserver_KeyPressActivationOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorObserver_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInteractorObserver NewInstance()
	{
		vtkInteractorObserver result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorObserver_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorObserver)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_Off_23(HandleRef pThis);

	/// <summary>
	/// Methods for turning the interactor observer on and off, and determining
	/// its state. All subclasses must provide the SetEnabled() method.
	/// Enabling a vtkInteractorObserver has the side effect of adding
	/// observers; disabling it removes the observers. Prior to enabling the
	/// vtkInteractorObserver you must set the render window interactor (via
	/// SetInteractor()). Initial value is 0.
	/// </summary>
	public void Off()
	{
		vtkInteractorObserver_Off_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_On_24(HandleRef pThis);

	/// <summary>
	/// Methods for turning the interactor observer on and off, and determining
	/// its state. All subclasses must provide the SetEnabled() method.
	/// Enabling a vtkInteractorObserver has the side effect of adding
	/// observers; disabling it removes the observers. Prior to enabling the
	/// vtkInteractorObserver you must set the render window interactor (via
	/// SetInteractor()). Initial value is 0.
	/// </summary>
	public void On()
	{
		vtkInteractorObserver_On_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_OnChar_25(HandleRef pThis);

	/// <summary>
	/// Sets up the keypress-i event.
	/// </summary>
	public virtual void OnChar()
	{
		vtkInteractorObserver_OnChar_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_PickingManagedOff_26(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the use of a manager to process the picking.
	/// Enabled by default.
	/// </summary>
	public virtual void PickingManagedOff()
	{
		vtkInteractorObserver_PickingManagedOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_PickingManagedOn_27(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the use of a manager to process the picking.
	/// Enabled by default.
	/// </summary>
	public virtual void PickingManagedOn()
	{
		vtkInteractorObserver_PickingManagedOn_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_ReleaseFocus_28(HandleRef pThis);

	/// <summary>
	/// These methods enable an interactor observer to exclusively grab all
	/// events invoked by its associated vtkRenderWindowInteractor. (This method
	/// is typically used by widgets to grab events once an event sequence
	/// begins.) The GrabFocus() signature takes up to two vtkCommands
	/// corresponding to mouse events and keypress events. (These two commands
	/// are separated so that the widget can listen for its activation keypress,
	/// as well as listening for DeleteEvents, without actually having to process
	/// mouse events.)
	/// </summary>
	public void ReleaseFocus()
	{
		vtkInteractorObserver_ReleaseFocus_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorObserver_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorObserver SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorObserver vtkInteractorObserver2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorObserver_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorObserver2 = (vtkInteractorObserver)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorObserver2.Register(null);
			}
		}
		return vtkInteractorObserver2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_SetCurrentRenderer_30(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the current renderer. Normally when the widget is activated
	/// (SetEnabled(1) or when keypress activation takes place), the renderer
	/// over which the mouse pointer is positioned is used and assigned to
	/// this Ivar. Alternatively, you might want to set the CurrentRenderer
	/// explicitly. This is especially true with multiple viewports (renderers).
	/// WARNING: note that if the DefaultRenderer Ivar is set (see above),
	/// it will always override the parameter passed to SetCurrentRenderer,
	/// unless it is NULL.
	/// (i.e., SetCurrentRenderer(foo) = SetCurrentRenderer(DefaultRenderer).
	/// </summary>
	public virtual void SetCurrentRenderer(vtkRenderer arg0)
	{
		vtkInteractorObserver_SetCurrentRenderer_30(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_SetDefaultRenderer_31(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the default renderer to use when activating the interactor
	/// observer. Normally when the widget is activated (SetEnabled(1) or when
	/// keypress activation takes place), the renderer over which the mouse
	/// pointer is positioned is used. Alternatively, you can specify the
	/// renderer to bind the interactor to when the interactor observer is
	/// activated.
	/// </summary>
	public virtual void SetDefaultRenderer(vtkRenderer arg0)
	{
		vtkInteractorObserver_SetDefaultRenderer_31(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_SetEnabled_32(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods for turning the interactor observer on and off, and determining
	/// its state. All subclasses must provide the SetEnabled() method.
	/// Enabling a vtkInteractorObserver has the side effect of adding
	/// observers; disabling it removes the observers. Prior to enabling the
	/// vtkInteractorObserver you must set the render window interactor (via
	/// SetInteractor()). Initial value is 0.
	/// </summary>
	public virtual void SetEnabled(int arg0)
	{
		vtkInteractorObserver_SetEnabled_32(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_SetInteractor_33(HandleRef pThis, HandleRef iren);

	/// <summary>
	/// This method is used to associate the widget with the render window
	/// interactor.  Observers of the appropriate events invoked in the render
	/// window interactor are set up as a result of this method invocation.
	/// The SetInteractor() method must be invoked prior to enabling the
	/// vtkInteractorObserver.
	/// It automatically registers available pickers to the Picking Manager.
	/// </summary>
	public virtual void SetInteractor(vtkRenderWindowInteractor iren)
	{
		vtkInteractorObserver_SetInteractor_33(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_SetKeyPressActivation_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/Disable of the use of a keypress to turn on and off the
	/// interactor observer. (By default, the keypress is 'i' for "interactor
	/// observer".)  Set the KeyPressActivationValue to change which key
	/// activates the widget.)
	/// </summary>
	public virtual void SetKeyPressActivation(int _arg)
	{
		vtkInteractorObserver_SetKeyPressActivation_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_SetKeyPressActivationValue_35(HandleRef pThis, sbyte _arg);

	/// <summary>
	/// Specify which key press value to use to activate the interactor observer
	/// (if key press activation is enabled). By default, the key press
	/// activation value is 'i'. Note: once the SetInteractor() method is
	/// invoked, changing the key press activation value will not affect the key
	/// press until SetInteractor(NULL)/SetInteractor(iren) is called.
	/// </summary>
	public virtual void SetKeyPressActivationValue(sbyte _arg)
	{
		vtkInteractorObserver_SetKeyPressActivationValue_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_SetPickingManaged_36(HandleRef pThis, byte managed);

	/// <summary>
	/// Enable/Disable the use of a manager to process the picking.
	/// Enabled by default.
	/// </summary>
	public virtual void SetPickingManaged(bool managed)
	{
		vtkInteractorObserver_SetPickingManaged_36(GetCppThis(), (byte)(managed ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorObserver_SetPriority_37(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the priority at which events are processed. This is used when
	/// multiple interactor observers are used simultaneously. The default value
	/// is 0.0 (lowest priority.) Note that when multiple interactor observer
	/// have the same priority, then the last observer added will process the
	/// event first. (Note: once the SetInteractor() method has been called,
	/// changing the priority does not effect event processing. You will have
	/// to SetInteractor(NULL), change priority, and then SetInteractor(iren)
	/// to have the priority take effect.)
	/// </summary>
	public virtual void SetPriority(float _arg)
	{
		vtkInteractorObserver_SetPriority_37(GetCppThis(), _arg);
	}
}
