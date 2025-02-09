using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImplicitPlaneWidget2
/// </summary>
/// <remarks>
///    3D widget for manipulating an infinite plane
///
/// This 3D widget defines an infinite plane that can be interactively placed
/// in a scene. The widget is assumed to consist of four parts: 1) a plane
/// contained in a 2) bounding box, with a 3) plane normal, which is rooted
/// at a 4) point on the plane. (The representation paired with this widget
/// determines the actual geometry of the widget.)
///
/// To use this widget, you generally pair it with a vtkImplicitPlaneRepresentation
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
/// If the mouse is over the outline:
///   LeftButtonPressEvent - select outline
///   LeftButtonReleaseEvent - release outline (if selected)
///   MouseMoveEvent - move the outline
/// If the keypress characters are used
///   'Down/Left' Move plane down
///   'Up/Right' Move plane up
/// In all the cases, independent of what is picked, the widget responds to the
/// following VTK events:
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
/// into the vtkImplicitPlaneWidget2's widget events:
/// &lt;pre&gt;
///   vtkWidgetEvent::Select -- some part of the widget has been selected
///   vtkWidgetEvent::EndSelect -- the selection process has completed
///   vtkWidgetEvent::Move -- a request for widget motion has been invoked
///   vtkWidgetEvent::Up and vtkWidgetEvent::Down -- MovePlaneAction
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// In turn, when these widget events are processed, the vtkImplicitPlaneWidget2
/// invokes the following VTK events on itself (which observers can listen for):
/// &lt;pre&gt;
///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
/// &lt;/pre&gt;
///
///
/// @par Event Bindings:
/// This class, and vtkImplicitPlaneRepresentation, are next generation VTK
/// widgets. An earlier version of this functionality was defined in the class
/// vtkImplicitPlaneWidget.
///
/// </remarks>
/// <seealso>
///
/// vtk3DWidget vtkBoxWidget vtkPlaneWidget vtkLineWidget vtkPointWidget
/// vtkSphereWidget vtkImagePlaneWidget vtkImplicitCylinderWidget
/// </seealso>
public class vtkImplicitPlaneWidget2 : vtkAbstractWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitPlaneWidget2";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImplicitPlaneWidget2()
	{
		MRClassNameKey = "class vtkImplicitPlaneWidget2";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitPlaneWidget2"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImplicitPlaneWidget2(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneWidget2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkImplicitPlaneWidget2 New()
	{
		vtkImplicitPlaneWidget2 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneWidget2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitPlaneWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkImplicitPlaneWidget2()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImplicitPlaneWidget2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImplicitPlaneWidget2_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkImplicitPlaneWidget2_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneWidget2_GetImplicitPlaneRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the representation as a vtkImplicitPlaneRepresentation.
	/// </summary>
	public vtkImplicitPlaneRepresentation GetImplicitPlaneRepresentation()
	{
		vtkImplicitPlaneRepresentation vtkImplicitPlaneRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneWidget2_GetImplicitPlaneRepresentation_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitPlaneRepresentation2 = (vtkImplicitPlaneRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitPlaneRepresentation2.Register(null);
			}
		}
		return vtkImplicitPlaneRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitPlaneWidget2_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImplicitPlaneWidget2_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitPlaneWidget2_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImplicitPlaneWidget2_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneWidget2_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImplicitPlaneWidget2_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPlaneWidget2_IsTypeOf_06(string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImplicitPlaneWidget2_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneWidget2_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new vtkImplicitPlaneWidget2 NewInstance()
	{
		vtkImplicitPlaneWidget2 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneWidget2_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitPlaneWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPlaneWidget2_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static vtkImplicitPlaneWidget2 SafeDownCast(vtkObjectBase o)
	{
		vtkImplicitPlaneWidget2 vtkImplicitPlaneWidget3 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPlaneWidget2_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitPlaneWidget3 = (vtkImplicitPlaneWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitPlaneWidget3.Register(null);
			}
		}
		return vtkImplicitPlaneWidget3;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget2_SetEnabled_10(HandleRef pThis, int enabling);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public override void SetEnabled(int enabling)
	{
		vtkImplicitPlaneWidget2_SetEnabled_10(GetCppThis(), enabling);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget2_SetLockNormalToCamera_11(HandleRef pThis, int arg0);

	/// <summary>
	/// Observe/Unobserve the camera if the widget is locked/unlocked to update the
	/// vtkImplicitePlaneRepresentation's normal.
	/// </summary>
	public void SetLockNormalToCamera(int arg0)
	{
		vtkImplicitPlaneWidget2_SetLockNormalToCamera_11(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPlaneWidget2_SetRepresentation_12(HandleRef pThis, HandleRef rep);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkImplicitPlaneRepresentation rep)
	{
		vtkImplicitPlaneWidget2_SetRepresentation_12(GetCppThis(), rep?.GetCppThis() ?? default(HandleRef));
	}
}
