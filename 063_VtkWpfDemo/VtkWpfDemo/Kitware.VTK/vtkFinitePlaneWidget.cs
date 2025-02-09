using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFinitePlaneWidget
/// </summary>
/// <remarks>
///    3D widget for manipulating a finite plane
///
/// This 3D widget interacts with a vtkFinitePlaneRepresentation class (i.e., it
/// handles the events that drive its corresponding representation). This 3D
/// widget defines a finite plane that can be interactively placed in a scene.
/// The widget is assumed to consist of four parts: 1) a plane with 2) a normal
/// and 3) three handles that can be moused on and manipulated.
/// The green and red handles represent the semi finite plane definition,
/// the third is in the center of the plane.
/// Operation like rotation of the plane (using normal), origin translation and
/// geometry plane modification using green and red handles are availables.
///
/// To use this widget, you generally pair it with a vtkFinitePlaneRepresentation
/// (or a subclass). Various options are available in the representation for
/// controlling how the widget appears, and how the widget reacts.
///
/// @par Event Bindings:
/// By default, the widget responds to the following VTK events (i.e., it
/// watches the vtkRenderWindowInteractor for these events):
/// &lt;pre&gt;
/// If one of the 3 handles are selected:
///   LeftButtonPressEvent - select the appropriate handle
///   LeftButtonReleaseEvent - release the currently selected handle
///   MouseMoveEvent - move the handle
/// In all the cases, independent of what is picked, the widget responds to the
/// following VTK events:
///   LeftButtonPressEvent - start select action
///   LeftButtonReleaseEvent - stop select action
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// Note that the event bindings described above can be changed using this
/// class's vtkWidgetEventTranslator. This class translates VTK events
/// into the vtkFinitePlaneWidget's widget events:
/// &lt;pre&gt;
///   vtkWidgetEvent::Select -- some part of the widget has been selected
///   vtkWidgetEvent::EndSelect -- the selection process has completed
///   vtkWidgetEvent::Move -- a request for motion has been invoked
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// In turn, when these widget events are processed, the vtkFinitePlaneWidget
/// invokes the following VTK events on itself (which observers can listen for):
/// &lt;pre&gt;
///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
/// &lt;/pre&gt;
/// </remarks>
/// <seealso>
///
/// vtkFinitePlaneRepresentation
/// </seealso>
public class vtkFinitePlaneWidget : vtkAbstractWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFinitePlaneWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFinitePlaneWidget()
	{
		MRClassNameKey = "class vtkFinitePlaneWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFinitePlaneWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFinitePlaneWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFinitePlaneWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkFinitePlaneWidget New()
	{
		vtkFinitePlaneWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFinitePlaneWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFinitePlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkFinitePlaneWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFinitePlaneWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkFinitePlaneWidget_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set. By default,
	/// this is an instance of the vtkFinitePlaneRepresentation class.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkFinitePlaneWidget_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFinitePlaneWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFinitePlaneWidget_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFinitePlaneWidget_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFinitePlaneWidget_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFinitePlaneWidget_IsA_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFinitePlaneWidget_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFinitePlaneWidget_IsTypeOf_05(string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFinitePlaneWidget_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFinitePlaneWidget_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new vtkFinitePlaneWidget NewInstance()
	{
		vtkFinitePlaneWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFinitePlaneWidget_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFinitePlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFinitePlaneWidget_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static vtkFinitePlaneWidget SafeDownCast(vtkObjectBase o)
	{
		vtkFinitePlaneWidget vtkFinitePlaneWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFinitePlaneWidget_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFinitePlaneWidget2 = (vtkFinitePlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFinitePlaneWidget2.Register(null);
			}
		}
		return vtkFinitePlaneWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneWidget_SetRepresentation_09(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkFinitePlaneRepresentation r)
	{
		vtkFinitePlaneWidget_SetRepresentation_09(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}
}
