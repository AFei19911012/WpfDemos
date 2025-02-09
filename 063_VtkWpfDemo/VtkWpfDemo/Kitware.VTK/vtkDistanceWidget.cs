using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDistanceWidget
/// </summary>
/// <remarks>
///    measure the distance between two points
///
/// The vtkDistanceWidget is used to measure the distance between two points.
/// The two end points can be positioned independently, and when they are
/// released, a special PlacePointEvent is invoked so that special operations
/// may be take to reposition the point (snap to grid, etc.) The widget has
/// two different modes of interaction: when initially defined (i.e., placing
/// the two points) and then a manipulate mode (adjusting the position of
/// the two points).
///
/// To use this widget, specify an instance of vtkDistanceWidget and a
/// representation (a subclass of vtkDistanceRepresentation). The widget is
/// implemented using two instances of vtkHandleWidget which are used to
/// position the end points of the line. The representations for these two
/// handle widgets are provided by the vtkDistanceRepresentation.
///
/// @par Event Bindings:
/// By default, the widget responds to the following VTK events (i.e., it
/// watches the vtkRenderWindowInteractor for these events):
/// &lt;pre&gt;
///   LeftButtonPressEvent - add a point or select a handle
///   MouseMoveEvent - position the second point or move a handle
///   LeftButtonReleaseEvent - release the handle
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// Note that the event bindings described above can be changed using this
/// class's vtkWidgetEventTranslator. This class translates VTK events
/// into the vtkDistanceWidget's widget events:
/// &lt;pre&gt;
///   vtkWidgetEvent::AddPoint -- add one point; depending on the state
///                               it may the first or second point added. Or,
///                               if near a handle, select the handle.
///   vtkWidgetEvent::Move -- move the second point or handle depending on the state.
///   vtkWidgetEvent::EndSelect -- the handle manipulation process has completed.
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// This widget invokes the following VTK events on itself (which observers
/// can listen for):
/// &lt;pre&gt;
///   vtkCommand::StartInteractionEvent (beginning to interact)
///   vtkCommand::EndInteractionEvent (completing interaction)
///   vtkCommand::InteractionEvent (moving after selecting something)
///   vtkCommand::PlacePointEvent (after point is positioned;
///                                call data includes handle id (0,1))
/// &lt;/pre&gt;
///
/// </remarks>
/// <seealso>
///
/// vtkHandleWidget
/// </seealso>
public class vtkDistanceWidget : vtkAbstractWidget
{
	/// <summary>
	/// Description:
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
	public new const string MRFullTypeName = "Kitware.VTK.vtkDistanceWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDistanceWidget()
	{
		MRClassNameKey = "class vtkDistanceWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistanceWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDistanceWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkDistanceWidget New()
	{
		vtkDistanceWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDistanceWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkDistanceWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDistanceWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDistanceWidget_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkDistanceWidget_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceWidget_GetDistanceRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the representation as a vtkDistanceRepresentation.
	/// </summary>
	public vtkDistanceRepresentation GetDistanceRepresentation()
	{
		vtkDistanceRepresentation vtkDistanceRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceWidget_GetDistanceRepresentation_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDistanceRepresentation2 = (vtkDistanceRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDistanceRepresentation2.Register(null);
			}
		}
		return vtkDistanceRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistanceWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDistanceWidget_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistanceWidget_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDistanceWidget_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceWidget_GetWidgetState_05(HandleRef pThis);

	/// <summary>
	/// Return the current widget state.
	/// </summary>
	public virtual int GetWidgetState()
	{
		return vtkDistanceWidget_GetWidgetState_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceWidget_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDistanceWidget_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceWidget_IsTypeOf_07(string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDistanceWidget_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceWidget_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new vtkDistanceWidget NewInstance()
	{
		vtkDistanceWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceWidget_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDistanceWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceWidget_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static vtkDistanceWidget SafeDownCast(vtkObjectBase o)
	{
		vtkDistanceWidget vtkDistanceWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceWidget_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDistanceWidget2 = (vtkDistanceWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDistanceWidget2.Register(null);
			}
		}
		return vtkDistanceWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceWidget_SetEnabled_11(HandleRef pThis, int arg0);

	/// <summary>
	/// The method for activating and deactivating this widget. This method
	/// must be overridden because it is a composite widget and does more than
	/// its superclasses' vtkAbstractWidget::SetEnabled() method.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkDistanceWidget_SetEnabled_11(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceWidget_SetProcessEvents_12(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods to change the whether the widget responds to interaction.
	/// Overridden to pass the state to component widgets.
	/// </summary>
	public override void SetProcessEvents(int arg0)
	{
		vtkDistanceWidget_SetProcessEvents_12(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceWidget_SetRepresentation_13(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkDistanceRepresentation r)
	{
		vtkDistanceWidget_SetRepresentation_13(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceWidget_SetWidgetStateToManipulate_14(HandleRef pThis);

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
		vtkDistanceWidget_SetWidgetStateToManipulate_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceWidget_SetWidgetStateToStart_15(HandleRef pThis);

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
		vtkDistanceWidget_SetWidgetStateToStart_15(GetCppThis());
	}
}
