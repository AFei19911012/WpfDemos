using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAngleWidget
/// </summary>
/// <remarks>
///    measure the angle between two rays (defined by three points)
///
/// The vtkAngleWidget is used to measure the angle between two rays (defined
/// by three points). The three points (two end points and a center)
/// can be positioned independently, and when they are released, a special
/// PlacePointEvent is invoked so that special operations may be take to
/// reposition the point (snap to grid, etc.) The widget has two different
/// modes of interaction: when initially defined (i.e., placing the three
/// points) and then a manipulate mode (adjusting the position of the
/// three points).
///
/// To use this widget, specify an instance of vtkAngleWidget and a
/// representation (a subclass of vtkAngleRepresentation). The widget is
/// implemented using three instances of vtkHandleWidget which are used to
/// position the three points. The representations for these handle widgets
/// are provided by the vtkAngleRepresentation.
///
/// @par Event Bindings:
/// By default, the widget responds to the following VTK events (i.e., it
/// watches the vtkRenderWindowInteractor for these events):
/// &lt;pre&gt;
///   LeftButtonPressEvent - add a point or select a handle
///   MouseMoveEvent - position the second or third point, or move a handle
///   LeftButtonReleaseEvent - release the selected handle
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// Note that the event bindings described above can be changed using this
/// class's vtkWidgetEventTranslator. This class translates VTK events
/// into the vtkAngleWidget's widget events:
/// &lt;pre&gt;
///   vtkWidgetEvent::AddPoint -- add one point; depending on the state
///                               it may the first, second or third point
///                               added. Or, if near a handle, select the handle.
///   vtkWidgetEvent::Move -- position the second or third point, or move the
///                           handle depending on the state.
///   vtkWidgetEvent::EndSelect -- the handle manipulation process has completed.
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// This widget invokes the following VTK events on itself (which observers
/// can listen for):
/// &lt;pre&gt;
///   vtkCommand::StartInteractionEvent (beginning to interact)
///   vtkCommand::EndInteractionEvent (completing interaction)
///   vtkCommand::InteractionEvent (moving a handle)
///   vtkCommand::PlacePointEvent (after a point is positioned;
///                                call data includes handle id (0,1,2))
/// &lt;/pre&gt;
///
/// </remarks>
/// <seealso>
///
/// vtkHandleWidget vtkDistanceWidget
/// </seealso>
public class vtkAngleWidget : vtkAbstractWidget
{
	/// <summary>
	/// Enum defining the state of the widget. By default the widget is in Start mode,
	/// and expects to be interactively placed. While placing the points the widget
	/// transitions to Define state. Once placed, the widget enters the Manipulate state.
	/// </summary>
	public enum Define_WrapperEnum
	{
		/// <summary>enum member</summary>
		Define = 1,
		/// <summary>enum member</summary>
		Manipulate = 2,
		/// <summary>enum member</summary>
		Start = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAngleWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAngleWidget()
	{
		MRClassNameKey = "class vtkAngleWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAngleWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAngleWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkAngleWidget New()
	{
		vtkAngleWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAngleWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkAngleWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAngleWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAngleWidget_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkAngleWidget_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleWidget_GetAngleRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the representation as a vtkAngleRepresentation.
	/// </summary>
	public vtkAngleRepresentation GetAngleRepresentation()
	{
		vtkAngleRepresentation vtkAngleRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleWidget_GetAngleRepresentation_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAngleRepresentation2 = (vtkAngleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAngleRepresentation2.Register(null);
			}
		}
		return vtkAngleRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAngleWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAngleWidget_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAngleWidget_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAngleWidget_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleWidget_GetWidgetState_05(HandleRef pThis);

	/// <summary>
	/// Return the current widget state.
	/// </summary>
	public virtual int GetWidgetState()
	{
		return vtkAngleWidget_GetWidgetState_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleWidget_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAngleWidget_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleWidget_IsAngleValid_07(HandleRef pThis);

	/// <summary>
	/// A flag indicates whether the angle is valid. The angle value only becomes
	/// valid after two of the three points are placed.
	/// </summary>
	public int IsAngleValid()
	{
		return vtkAngleWidget_IsAngleValid_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAngleWidget_IsTypeOf_08(string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAngleWidget_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleWidget_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new vtkAngleWidget NewInstance()
	{
		vtkAngleWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleWidget_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAngleWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAngleWidget_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static vtkAngleWidget SafeDownCast(vtkObjectBase o)
	{
		vtkAngleWidget vtkAngleWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAngleWidget_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAngleWidget2 = (vtkAngleWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAngleWidget2.Register(null);
			}
		}
		return vtkAngleWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleWidget_SetEnabled_12(HandleRef pThis, int arg0);

	/// <summary>
	/// The method for activating and deactivating this widget. This method
	/// must be overridden because it is a composite widget and does more than
	/// its superclasses' vtkAbstractWidget::SetEnabled() method.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkAngleWidget_SetEnabled_12(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleWidget_SetProcessEvents_13(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods to change the whether the widget responds to interaction.
	/// Overridden to pass the state to component widgets.
	/// </summary>
	public override void SetProcessEvents(int arg0)
	{
		vtkAngleWidget_SetProcessEvents_13(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleWidget_SetRepresentation_14(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkAngleRepresentation r)
	{
		vtkAngleWidget_SetRepresentation_14(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleWidget_SetWidgetStateToManipulate_15(HandleRef pThis);

	/// <summary>
	/// Set the state of the widget. If the state is set to "Manipulate" then it
	/// is assumed that the widget and its representation will be initialized
	/// programmatically and is not interactively placed. Initially the widget
	/// state is set to "Start" which means nothing will appear and the user
	/// must interactively place the widget with repeated mouse selections. Set
	/// the state to "Start" if you want interactive placement. Generally state
	/// changes must be followed by a Render() for things to visually take
	/// effect.
	/// </summary>
	public virtual void SetWidgetStateToManipulate()
	{
		vtkAngleWidget_SetWidgetStateToManipulate_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAngleWidget_SetWidgetStateToStart_16(HandleRef pThis);

	/// <summary>
	/// Set the state of the widget. If the state is set to "Manipulate" then it
	/// is assumed that the widget and its representation will be initialized
	/// programmatically and is not interactively placed. Initially the widget
	/// state is set to "Start" which means nothing will appear and the user
	/// must interactively place the widget with repeated mouse selections. Set
	/// the state to "Start" if you want interactive placement. Generally state
	/// changes must be followed by a Render() for things to visually take
	/// effect.
	/// </summary>
	public virtual void SetWidgetStateToStart()
	{
		vtkAngleWidget_SetWidgetStateToStart_16(GetCppThis());
	}
}
