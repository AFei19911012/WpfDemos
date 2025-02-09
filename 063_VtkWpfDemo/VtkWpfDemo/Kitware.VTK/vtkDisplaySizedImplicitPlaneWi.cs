using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDisplaySizedImplicitPlaneWidget
/// </summary>
/// <remarks>
///    3D widget for manipulating a display sized plane
///
/// This 3D widget defines a display sized plane represented as a disk,
/// that can be interactively placed in a scene. The widget is assumed
/// to consist of three parts: 1) a disk plane with a 2) plane normal, which
/// is rooted at a 3) point on the plane. (The representation paired
/// with this widget determines the actual geometry of the widget.)
///
/// To use this widget, you generally pair it with a vtkDisplaySizedImplicitPlaneRepresentation
/// (or a subclass). Various options are available for controlling how the
/// representation appears, and how the widget functions.
///
/// @par Event Bindings:
/// By default, the widget responds to the following VTK events (i.e., it
/// watches the vtkRenderWindowInteractor for these events):
/// &lt;pre&gt;
/// If the mouse is over the plane normal:
///   LeftButtonPressEvent - select normal
///   LeftButtonReleaseEvent - release normal
///   MouseMoveEvent - orient the normal vector
/// If the mouse is over the origin point (handle):
///   LeftButtonPressEvent - select handle
///   LeftButtonReleaseEvent - release handle (if selected)
///   MouseMoveEvent - move the origin point (constrained to the plane)
/// If the mouse is over the plane:
///   LeftButtonPressEvent - select plane
///   LeftButtonReleaseEvent - release plane (if selected)
///   MouseMoveEvent - move the plane
/// If the mouse is over the perimeter of the disk plane:
///   LeftButtonPressEvent - select perimeter
///   LeftButtonReleaseEvent - release perimeter (if selected)
///   MouseMoveEvent - resize the perimeter -&gt; radius of the disk plane
/// If the keypress characters are used
///   'Down/Left' Move plane down
///   'Up/Right' Move plane up
///   'P/p' Pick a new origin from the intersection with a mesh cell rendered by the renderer
///   'Ctrl' + 'P/p' Snap to a new origin from the closest mesh point rendered by the renderer
///   'N/n' Pick a new normal from the intersection with a mesh cell rendered by the renderer
///   'Ctrl' + 'N/n' Snap to a new normal from the closest mesh point rendered by the renderer
/// In all the cases, independent of what is picked, the widget responds to the following VTK events:
///   MiddleButtonPressEvent - move the plane
///   MiddleButtonReleaseEvent - release the plane
///   RightButtonPressEvent - scale the widget's representation
///   RightButtonReleaseEvent - stop scaling the widget
///   MouseMoveEvent - scale (if right button) or move (if middle button) the widget
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// Note that the event bindings described above can be changed using this
/// class's vtkWidgetEventTranslator. This class translates VTK events
/// into the vtkDisplaySizedImplicitPlaneWidget's widget events:
/// &lt;pre&gt;
///   vtkWidgetEvent::Select -- some part of the widget has been selected
///   vtkWidgetEvent::EndSelect -- the selection process has completed
///   vtkWidgetEvent::Move -- a request for widget motion has been invoked
///   vtkWidgetEvent::Up and vtkWidgetEvent::Down -- MovePlaneAction
///   vtkWidgetEvent::PickPoint -- PickOriginAction
///   vtkWidgetEvent::PickNormal -- PickNormalAction
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// In turn, when these widget events are processed, the vtkDisplaySizedImplicitPlaneWidget
/// invokes the following VTK events on itself (which observers can listen for):
/// &lt;pre&gt;
///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
/// &lt;/pre&gt;
///
///
/// @par Event Bindings:
/// This class, and vtkDisplaySizedImplicitPlaneRepresentation, are next generation VTK
/// widgets.
///
/// </remarks>
/// <seealso>
///
/// vtk3DWidget vtkBoxWidget vtkPlaneWidget vtkLineWidget vtkPointWidget
/// vtkSphereWidget vtkImagePlaneWidget vtkImplicitCylinderWidget, vtkImplicitPlaneWidget2
/// </seealso>
public class vtkDisplaySizedImplicitPlaneWidget : vtkAbstractWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDisplaySizedImplicitPlaneWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDisplaySizedImplicitPlaneWidget()
	{
		MRClassNameKey = "class vtkDisplaySizedImplicitPlaneWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDisplaySizedImplicitPlaneWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDisplaySizedImplicitPlaneWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkDisplaySizedImplicitPlaneWidget New()
	{
		vtkDisplaySizedImplicitPlaneWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDisplaySizedImplicitPlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkDisplaySizedImplicitPlaneWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDisplaySizedImplicitPlaneWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDisplaySizedImplicitPlaneWidget_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkDisplaySizedImplicitPlaneWidget_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneWidget_GetDisplaySizedImplicitPlaneRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the representation as a vtkDisplaySizedImplicitPlaneRepresentation.
	/// </summary>
	public vtkDisplaySizedImplicitPlaneRepresentation GetDisplaySizedImplicitPlaneRepresentation()
	{
		vtkDisplaySizedImplicitPlaneRepresentation vtkDisplaySizedImplicitPlaneRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneWidget_GetDisplaySizedImplicitPlaneRepresentation_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkDisplaySizedImplicitPlaneWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDisplaySizedImplicitPlaneWidget_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDisplaySizedImplicitPlaneWidget_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDisplaySizedImplicitPlaneWidget_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDisplaySizedImplicitPlaneWidget_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDisplaySizedImplicitPlaneWidget_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDisplaySizedImplicitPlaneWidget_IsTypeOf_06(string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDisplaySizedImplicitPlaneWidget_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new vtkDisplaySizedImplicitPlaneWidget NewInstance()
	{
		vtkDisplaySizedImplicitPlaneWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneWidget_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDisplaySizedImplicitPlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDisplaySizedImplicitPlaneWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static vtkDisplaySizedImplicitPlaneWidget SafeDownCast(vtkObjectBase o)
	{
		vtkDisplaySizedImplicitPlaneWidget vtkDisplaySizedImplicitPlaneWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDisplaySizedImplicitPlaneWidget_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDisplaySizedImplicitPlaneWidget2 = (vtkDisplaySizedImplicitPlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDisplaySizedImplicitPlaneWidget2.Register(null);
			}
		}
		return vtkDisplaySizedImplicitPlaneWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneWidget_SetEnabled_10(HandleRef pThis, int enabling);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public override void SetEnabled(int enabling)
	{
		vtkDisplaySizedImplicitPlaneWidget_SetEnabled_10(GetCppThis(), enabling);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneWidget_SetLockNormalToCamera_11(HandleRef pThis, int arg0);

	/// <summary>
	/// Observe/Unobserve the camera if the widget is locked/unlocked to update the
	/// vtkImplicitePlaneRepresentation's normal.
	/// </summary>
	public void SetLockNormalToCamera(int arg0)
	{
		vtkDisplaySizedImplicitPlaneWidget_SetLockNormalToCamera_11(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDisplaySizedImplicitPlaneWidget_SetRepresentation_12(HandleRef pThis, HandleRef rep);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkDisplaySizedImplicitPlaneRepresentation rep)
	{
		vtkDisplaySizedImplicitPlaneWidget_SetRepresentation_12(GetCppThis(), rep?.GetCppThis() ?? default(HandleRef));
	}
}
