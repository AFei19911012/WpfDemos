using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBiDimensionalWidget
/// </summary>
/// <remarks>
///    measure the bi-dimensional lengths of an object
///
/// The vtkBiDimensionalWidget is used to measure the bi-dimensional length of
/// an object. The bi-dimensional measure is defined by two finite, orthogonal
/// lines that intersect within the finite extent of both lines.
/// The lengths of these two lines gives the bi-dimensional measure. Each line
/// is defined by two handle widgets at the end points of each line.
///
/// The orthogonal constraint on the two lines limits how the four end points
/// can be positioned. The first two points can be placed arbitrarily to define
/// the first line (similar to vtkDistanceWidget). The placement of the third
/// point is limited by the finite extent of the first line. As the third point
/// is placed, the fourth point is placed on the opposite side of the first
/// line. Once the third point is placed, the second line is defined since the
/// fourth point is defined at the same time, but the fourth point can be moved
/// along the second line (i.e., maintaining the orthogonal relationship between
/// the two lines). Once defined, any of the four points can be moved along
/// their constraint lines. Also, each line can be translated along the other
/// line (in an orthogonal direction), and the whole bi-dimensional widget can
/// be rotated about its center point (see the description of the event
/// bindings). Finally, selecting the point where the two orthogonal axes
/// intersect, the entire widget can be translated in any direction.
///
/// Placement of any point results in a special PlacePointEvent invocation so
/// that special operations may be performed to reposition the point. Motion of
/// any point, moving the lines, or rotating the widget cause InteractionEvents
/// to be invoked. Note that the widget has two fundamental modes: a define mode
/// (when initially placing the points) and a manipulate mode (after the points
/// are placed). Line translation and rotation are only possible in manipulate
/// mode.
///
/// To use this widget, specify an instance of vtkBiDimensionalWidget and a
/// representation (e.g., vtkBiDimensionalRepresentation2D). The widget is
/// implemented using four instances of vtkHandleWidget which are used to
/// position the end points of the two intersecting lines. The representations
/// for these handle widgets are provided by the vtkBiDimensionalRepresentation
/// class.
///
/// @par Event Bindings:
/// By default, the widget responds to the following VTK events (i.e., it
/// watches the vtkRenderWindowInteractor for these events):
/// &lt;pre&gt;
///   LeftButtonPressEvent - define a point or manipulate a handle, line,
///                          perform rotation or translate the widget.
///   MouseMoveEvent - position the points, move a line, rotate or translate the widget
///   LeftButtonReleaseEvent - release the selected handle and end interaction
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// Note that the event bindings described above can be changed using this
/// class's vtkWidgetEventTranslator. This class translates VTK events
/// into the vtkBiDimensionalWidget's widget events:
/// &lt;pre&gt;
///   vtkWidgetEvent::AddPoint -- (In Define mode:) Add one point; depending on the
///                               state it may the first, second, third or fourth
///                               point added. (In Manipulate mode:) If near a handle,
///                               select the handle. Or if near a line, select the line.
///   vtkWidgetEvent::Move -- (In Define mode:) Position the second, third or fourth
///                           point. (In Manipulate mode:) Move the handle, line or widget.
///   vtkWidgetEvent::EndSelect -- the manipulation process has completed.
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// This widget invokes the following VTK events on itself (which observers
/// can listen for):
/// &lt;pre&gt;
///   vtkCommand::StartInteractionEvent (beginning to interact)
///   vtkCommand::EndInteractionEvent (completing interaction)
///   vtkCommand::InteractionEvent (moving a handle, line or performing rotation)
///   vtkCommand::PlacePointEvent (after a point is positioned;
///                                call data includes handle id (0,1,2,4))
/// &lt;/pre&gt;
///
/// </remarks>
/// <seealso>
///
/// vtkHandleWidget vtkDistanceWidget
/// </seealso>
public class vtkBiDimensionalWidget : vtkAbstractWidget
{
	/// <summary>
	/// Events.
	/// </summary>
	public enum EndWidgetSelectEvent_WrapperEnum
	{
		/// <summary>enum member</summary>
		EndWidgetSelectEvent = 10050
	}

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
	public new const string MRFullTypeName = "Kitware.VTK.vtkBiDimensionalWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBiDimensionalWidget()
	{
		MRClassNameKey = "class vtkBiDimensionalWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBiDimensionalWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBiDimensionalWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkBiDimensionalWidget New()
	{
		vtkBiDimensionalWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiDimensionalWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBiDimensionalWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkBiDimensionalWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBiDimensionalWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBiDimensionalWidget_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkBiDimensionalWidget_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalWidget_GetBiDimensionalRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the representation as a vtkBiDimensionalRepresentation.
	/// </summary>
	public vtkBiDimensionalRepresentation GetBiDimensionalRepresentation()
	{
		vtkBiDimensionalRepresentation vtkBiDimensionalRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiDimensionalWidget_GetBiDimensionalRepresentation_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBiDimensionalRepresentation2 = (vtkBiDimensionalRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBiDimensionalRepresentation2.Register(null);
			}
		}
		return vtkBiDimensionalRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBiDimensionalWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBiDimensionalWidget_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBiDimensionalWidget_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBiDimensionalWidget_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiDimensionalWidget_GetWidgetState_05(HandleRef pThis);

	/// <summary>
	/// Return the current widget state.
	/// </summary>
	public virtual int GetWidgetState()
	{
		return vtkBiDimensionalWidget_GetWidgetState_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiDimensionalWidget_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBiDimensionalWidget_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiDimensionalWidget_IsMeasureValid_07(HandleRef pThis);

	/// <summary>
	/// A flag indicates whether the bi-dimensional measure is valid. The widget
	/// becomes valid after two of the four points are placed.
	/// </summary>
	public int IsMeasureValid()
	{
		return vtkBiDimensionalWidget_IsMeasureValid_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiDimensionalWidget_IsTypeOf_08(string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBiDimensionalWidget_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalWidget_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new vtkBiDimensionalWidget NewInstance()
	{
		vtkBiDimensionalWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiDimensionalWidget_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBiDimensionalWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalWidget_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static vtkBiDimensionalWidget SafeDownCast(vtkObjectBase o)
	{
		vtkBiDimensionalWidget vtkBiDimensionalWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiDimensionalWidget_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBiDimensionalWidget2 = (vtkBiDimensionalWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBiDimensionalWidget2.Register(null);
			}
		}
		return vtkBiDimensionalWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalWidget_SetEnabled_12(HandleRef pThis, int arg0);

	/// <summary>
	/// The method for activating and deactivating this widget. This method
	/// must be overridden because it is a composite widget and does more than
	/// its superclasses' vtkAbstractWidget::SetEnabled() method.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkBiDimensionalWidget_SetEnabled_12(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalWidget_SetProcessEvents_13(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods to change the whether the widget responds to interaction.
	/// Overridden to pass the state to component widgets.
	/// </summary>
	public override void SetProcessEvents(int arg0)
	{
		vtkBiDimensionalWidget_SetProcessEvents_13(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalWidget_SetRepresentation_14(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkBiDimensionalRepresentation r)
	{
		vtkBiDimensionalWidget_SetRepresentation_14(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalWidget_SetWidgetStateToManipulate_15(HandleRef pThis);

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
		vtkBiDimensionalWidget_SetWidgetStateToManipulate_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalWidget_SetWidgetStateToStart_16(HandleRef pThis);

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
		vtkBiDimensionalWidget_SetWidgetStateToStart_16(GetCppThis());
	}
}
