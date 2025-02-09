using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLineWidget2
/// </summary>
/// <remarks>
///    3D widget for manipulating a finite, straight line
///
/// This 3D widget defines a straight line that can be interactively placed in
/// a scene. The widget is assumed to consist of two parts: 1) two end points
/// and 2) a straight line connecting the two points. (The representation
/// paired with this widget determines the actual geometry of the widget.) The
/// positioning of the two end points is facilitated by using vtkHandleWidgets
/// to position the points.
///
/// To use this widget, you generally pair it with a vtkLineRepresentation
/// (or a subclass). Various options are available in the representation for
/// controlling how the widget appears, and how the widget functions.
///
/// @par Event Bindings:
/// By default, the widget responds to the following VTK events (i.e., it
/// watches the vtkRenderWindowInteractor for these events):
/// &lt;pre&gt;
/// If one of the two end points are selected:
///   LeftButtonPressEvent - activate the associated handle widget
///   LeftButtonReleaseEvent - release the handle widget associated with the point
///   MouseMoveEvent - move the point
/// If the line is selected:
///   LeftButtonPressEvent - activate a handle widget associated with the line
///   LeftButtonReleaseEvent - release the handle widget associated with the line
///   MouseMoveEvent - translate the line
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
/// into the vtkLineWidget2's widget events:
/// &lt;pre&gt;
///   vtkWidgetEvent::Select -- some part of the widget has been selected
///   vtkWidgetEvent::EndSelect -- the selection process has completed
///   vtkWidgetEvent::Move -- a request for slider motion has been invoked
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// In turn, when these widget events are processed, the vtkLineWidget2
/// invokes the following VTK events on itself (which observers can listen for):
/// &lt;pre&gt;
///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
/// &lt;/pre&gt;
///
///
///
/// @par Event Bindings:
/// This class, and vtkLineRepresentation, are next generation VTK widgets. An
/// earlier version of this functionality was defined in the class
/// vtkLineWidget.
///
/// </remarks>
/// <seealso>
///
/// vtkLineRepresentation vtkLineWidget vtk3DWidget vtkImplicitPlaneWidget
/// vtkImplicitPlaneWidget2
/// </seealso>
public class vtkLineWidget2 : vtkAbstractWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLineWidget2";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLineWidget2()
	{
		MRClassNameKey = "class vtkLineWidget2";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLineWidget2"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLineWidget2(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineWidget2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkLineWidget2 New()
	{
		vtkLineWidget2 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineWidget2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLineWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkLineWidget2()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLineWidget2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkLineWidget2_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkLineWidget2_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineWidget2_GetLineRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the representation as a vtkLineRepresentation.
	/// </summary>
	public vtkLineRepresentation GetLineRepresentation()
	{
		vtkLineRepresentation vtkLineRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineWidget2_GetLineRepresentation_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLineRepresentation2 = (vtkLineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLineRepresentation2.Register(null);
			}
		}
		return vtkLineRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLineWidget2_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLineWidget2_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLineWidget2_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLineWidget2_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineWidget2_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLineWidget2_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLineWidget2_IsTypeOf_06(string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLineWidget2_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineWidget2_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new vtkLineWidget2 NewInstance()
	{
		vtkLineWidget2 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineWidget2_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLineWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLineWidget2_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static vtkLineWidget2 SafeDownCast(vtkObjectBase o)
	{
		vtkLineWidget2 vtkLineWidget3 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLineWidget2_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLineWidget3 = (vtkLineWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLineWidget3.Register(null);
			}
		}
		return vtkLineWidget3;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget2_SetEnabled_10(HandleRef pThis, int enabling);

	/// <summary>
	/// Override superclasses' SetEnabled() method because the line
	/// widget must enable its internal handle widgets.
	/// </summary>
	public override void SetEnabled(int enabling)
	{
		vtkLineWidget2_SetEnabled_10(GetCppThis(), enabling);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget2_SetProcessEvents_11(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods to change the whether the widget responds to interaction.
	/// Overridden to pass the state to component widgets.
	/// </summary>
	public override void SetProcessEvents(int arg0)
	{
		vtkLineWidget2_SetProcessEvents_11(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLineWidget2_SetRepresentation_12(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkLineRepresentation r)
	{
		vtkLineWidget2_SetRepresentation_12(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}
}
