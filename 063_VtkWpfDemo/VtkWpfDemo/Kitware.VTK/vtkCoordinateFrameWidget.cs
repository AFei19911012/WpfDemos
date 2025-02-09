using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCoordinateFrameWidget
/// </summary>
/// <remarks>
///    3D widget for manipulating a display sized coordinate frame widget
///
/// This 3D widget defines a display sized coordinate frame
/// that can be interactively placed in a scene. The widget is assumed
/// to consist of three parts: 1) an origin, 2) 3 axis normals which are rooted at the origin
/// and 3 axis lockers. (The representation paired with this widget determines the actual
/// geometry of the widget.)
///
/// To use this widget, you generally pair it with a vtkCoordinateFrameRepresentation
/// (or a subclass). Various options are available for controlling how the
/// representation appears, and how the widget functions.
///
/// @par Event Bindings:
/// By default, the widget responds to the following VTK events (i.e., it
/// watches the vtkRenderWindowInteractor for these events):
/// &lt;pre&gt;
/// If the mouse is over the one of the axis normals:
///   LeftButtonPressEvent - select normal
///   LeftButtonReleaseEvent - release normal
///   MouseMoveEvent - orient the axis normal vectors (possibly constrained to
///   one of the axis' planes)
/// If the mouse is over the origin point (handle):
///   LeftButtonPressEvent - select handle
///   LeftButtonReleaseEvent - release handle (if selected)
///   MouseMoveEvent - move the origin point (possibly constrained to one of the axis' planes)
/// If the mouse is over one of the axis lockers:
///   LeftButtonPressEvent - select axis locker
///   LeftButtonReleaseEvent - unlock/lock and axis locker (and unlock all the other lockers)
/// If the keypress characters are used
///   'Down/Left' Move plane down
///   'Up/Right' Move plane up
///   'P/p' Pick a new origin from the intersection with a mesh cell rendered by the renderer
///   'Ctrl' + 'P/p' Snap to a new origin from the closest mesh point rendered by the renderer
///   'N/n' Pick a new normal from the intersection with a mesh cell rendered by the renderer
///   'Ctrl' + 'N/n' Snap to a new normal from the closest mesh point rendered by the renderer
///   'D/d' Pick a new point to define the direction normal which will be the new normal
///   'Ctrl' + 'D/d' Snap to a new point to define the direction normal which will be the new normal
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// Note that the event bindings described above can be changed using this
/// class's vtkWidgetEventTranslator. This class translates VTK events
/// into the vtkCoordinateFrameWidget's widget events:
/// &lt;pre&gt;
///   vtkWidgetEvent::Select -- some part of the widget has been selected
///   vtkWidgetEvent::EndSelect -- the selection process has completed
///   vtkWidgetEvent::Move -- a request for widget motion has been invoked
///   vtkWidgetEvent::PickPoint -- PickOriginAction
///   vtkWidgetEvent::PickNormal -- PickNormalAction
///   vtkWidgetEvent::PickDirectionPoint -- PickDirectionPointAction
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// In turn, when these widget events are processed, the vtkCoordinateFrameWidget
/// invokes the following VTK events on itself (which observers can listen for):
/// &lt;pre&gt;
///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
/// &lt;/pre&gt;
///
///
/// @par Event Bindings:
/// This class, and vtkCoordinateFrameRepresentation, are next generation VTK
/// widgets.
///
/// </remarks>
/// <seealso>
///
/// vtk3DWidget vtkBoxWidget vtkPlaneWidget vtkLineWidget vtkPointWidget
/// vtkSphereWidget vtkImagePlaneWidget vtkImplicitCylinderWidget, vtkImplicitPlaneWidget2
/// vtkDisplaySizedImplicitPlaneWidget
/// </seealso>
public class vtkCoordinateFrameWidget : vtkAbstractWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCoordinateFrameWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCoordinateFrameWidget()
	{
		MRClassNameKey = "class vtkCoordinateFrameWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCoordinateFrameWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCoordinateFrameWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkCoordinateFrameWidget New()
	{
		vtkCoordinateFrameWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCoordinateFrameWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkCoordinateFrameWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCoordinateFrameWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCoordinateFrameWidget_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkCoordinateFrameWidget_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameWidget_GetCoordinateFrameRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the representation as a vtkCoordinateFrameRepresentation.
	/// </summary>
	public vtkCoordinateFrameRepresentation GetCoordinateFrameRepresentation()
	{
		vtkCoordinateFrameRepresentation vtkCoordinateFrameRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameWidget_GetCoordinateFrameRepresentation_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCoordinateFrameRepresentation2 = (vtkCoordinateFrameRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCoordinateFrameRepresentation2.Register(null);
			}
		}
		return vtkCoordinateFrameRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCoordinateFrameWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCoordinateFrameWidget_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCoordinateFrameWidget_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCoordinateFrameWidget_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCoordinateFrameWidget_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCoordinateFrameWidget_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCoordinateFrameWidget_IsTypeOf_06(string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCoordinateFrameWidget_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new vtkCoordinateFrameWidget NewInstance()
	{
		vtkCoordinateFrameWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameWidget_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCoordinateFrameWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrameWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static vtkCoordinateFrameWidget SafeDownCast(vtkObjectBase o)
	{
		vtkCoordinateFrameWidget vtkCoordinateFrameWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrameWidget_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCoordinateFrameWidget2 = (vtkCoordinateFrameWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCoordinateFrameWidget2.Register(null);
			}
		}
		return vtkCoordinateFrameWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameWidget_SetEnabled_10(HandleRef pThis, int enabling);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public override void SetEnabled(int enabling)
	{
		vtkCoordinateFrameWidget_SetEnabled_10(GetCppThis(), enabling);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrameWidget_SetRepresentation_11(HandleRef pThis, HandleRef rep);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkCoordinateFrameRepresentation rep)
	{
		vtkCoordinateFrameWidget_SetRepresentation_11(GetCppThis(), rep?.GetCppThis() ?? default(HandleRef));
	}
}
