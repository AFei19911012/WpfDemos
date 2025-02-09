using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkContourWidget
/// </summary>
/// <remarks>
///    create a contour with a set of points
///
/// The vtkContourWidget is used to select a set of points, and draw lines
/// between these points. The contour may be opened or closed, depending on
/// how the last point is added. The widget handles all processing of widget
/// events (that are triggered by VTK events). The vtkContourRepresentation is
/// responsible for all placement of the points, calculation of the lines, and
/// contour manipulation. This is done through two main helper classes:
/// vtkPointPlacer and vtkContourLineInterpolator. The representation is also
/// responsible for drawing the points and lines.
///
/// @par Event Bindings:
/// By default, the widget responds to the following VTK events (i.e., it
/// watches the vtkRenderWindowInteractor for these events):
/// &lt;pre&gt;
///   LeftButtonPressEvent - triggers a Select event
///   RightButtonPressEvent - triggers a AddFinalPoint event
///   MouseMoveEvent - triggers a Move event
///   LeftButtonReleaseEvent - triggers an EndSelect event
///   Delete key event - triggers a Delete event
///   Shift + Delete key event - triggers a Reset event
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// Note that the event bindings described above can be changed using this
/// class's vtkWidgetEventTranslator. This class translates VTK events
/// into the vtkContourWidget's widget events:
/// &lt;pre&gt;
///   vtkWidgetEvent::Select
///        widget state is:
///            Start or
///            Define: If we already have at least 2 nodes, test
///                 whether the current (X,Y) location is near an existing
///                 node. If so, close the contour and change to Manipulate
///                 state. Otherwise, attempt to add a node at this (X,Y)
///                 location.
///            Manipulate: If this (X,Y) location activates a node, then
///                 set the current operation to Translate. Otherwise, if
///                 this location is near the contour, attempt to add a
///                 new node on the contour at this (X,Y) location.
///
/// @par Event Bindings:
///   vtkWidgetEvent::AddFinalPoint
///        widget state is:
///            Start: Do nothing.
///            Define: If we already have at least 2 nodes, test
///                 whether the current (X,Y) location is near an existing
///                 node. If so, close the contour and change to Manipulate
///                 state. Otherwise, attempt to add a node at this (X,Y)
///                 location. If we do, then leave the contour open and
///                 change to Manipulate state.
///            Manipulate: Do nothing.
///
/// @par Event Bindings:
///   vtkWidgetEvent::Move
///        widget state is:
///            Start or
///            Define: Do nothing.
///            Manipulate: If our operation is Translate, then invoke
///                  WidgetInteraction() on the representation. If our
///                  operation is Inactive, then just attempt to activate
///                  a node at this (X,Y) location.
///
/// @par Event Bindings:
///   vtkWidgetEvent::EndSelect
///        widget state is:
///            Start or
///            Define: Do nothing.
///            Manipulate: If our operation is not Inactive, set it to
///                  Inactive.
///
/// @par Event Bindings:
///   vtkWidgetEvent::Delete
///        widget state is:
///            Start: Do nothing.
///            Define: Remove the last point on the contour.
///            Manipulate: Attempt to activate a node at (X,Y). If
///                   we do activate a node, delete it. If we now
///                   have less than 3 nodes, go back to Define state.
///
/// @par Event Bindings:
///   vtkWidgetEvent::Reset
///        widget state is:
///            Start: Do nothing.
///            Define: Remove all points and line segments of the contour.
///                 Essentially calls Initialize(nullptr)
///            Manipulate: Do nothing.
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
///   vtkCommand::WidgetValueChangedEvent (Invoked when the contour is closed
///                                        for the first time. )
/// &lt;/pre&gt;
///
/// </remarks>
/// <seealso>
///
/// vtkHandleWidget
/// </seealso>
public class vtkContourWidget : vtkAbstractWidget
{
	/// <summary>
	/// Initialize the contour widget from a user supplied set of points. The
	/// state of the widget decides if you are still defining the widget, or
	/// if you've finished defining (added the last point) are manipulating
	/// it. Note that if the polydata supplied is closed, the state will be
	/// set to manipulate.
	/// State: Define = 0, Manipulate = 1.
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
	public new const string MRFullTypeName = "Kitware.VTK.vtkContourWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkContourWidget()
	{
		MRClassNameKey = "class vtkContourWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkContourWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkContourWidget New()
	{
		vtkContourWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContourWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkContourWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkContourWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkContourWidget_AllowNodePickingOff_01(HandleRef pThis);

	/// <summary>
	/// Set / Get the AllowNodePicking value. This ivar indicates whether the nodes
	/// and points between nodes can be picked/un-picked by Ctrl+Click on the node.
	/// </summary>
	public virtual void AllowNodePickingOff()
	{
		vtkContourWidget_AllowNodePickingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourWidget_AllowNodePickingOn_02(HandleRef pThis);

	/// <summary>
	/// Set / Get the AllowNodePicking value. This ivar indicates whether the nodes
	/// and points between nodes can be picked/un-picked by Ctrl+Click on the node.
	/// </summary>
	public virtual void AllowNodePickingOn()
	{
		vtkContourWidget_AllowNodePickingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourWidget_CloseLoop_03(HandleRef pThis);

	/// <summary>
	/// Convenient method to close the contour loop.
	/// </summary>
	public void CloseLoop()
	{
		vtkContourWidget_CloseLoop_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourWidget_ContinuousDrawOff_04(HandleRef pThis);

	/// <summary>
	/// Define a contour by continuously drawing with the mouse cursor.
	/// Press and hold the left mouse button down to continuously draw.
	/// Releasing the left mouse button switches into a snap drawing mode.
	/// Terminate the contour by pressing the right mouse button.  If you
	/// do not want to see the nodes as they are added to the contour, set the
	/// opacity to 0 of the representation's property.  If you do not want to
	/// see the last active node as it is being added, set the opacity to 0
	/// of the representation's active property.
	/// </summary>
	public virtual void ContinuousDrawOff()
	{
		vtkContourWidget_ContinuousDrawOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourWidget_ContinuousDrawOn_05(HandleRef pThis);

	/// <summary>
	/// Define a contour by continuously drawing with the mouse cursor.
	/// Press and hold the left mouse button down to continuously draw.
	/// Releasing the left mouse button switches into a snap drawing mode.
	/// Terminate the contour by pressing the right mouse button.  If you
	/// do not want to see the nodes as they are added to the contour, set the
	/// opacity to 0 of the representation's property.  If you do not want to
	/// see the last active node as it is being added, set the opacity to 0
	/// of the representation's active property.
	/// </summary>
	public virtual void ContinuousDrawOn()
	{
		vtkContourWidget_ContinuousDrawOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourWidget_CreateDefaultRepresentation_06(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkContourWidget_CreateDefaultRepresentation_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourWidget_FollowCursorOff_07(HandleRef pThis);

	/// <summary>
	/// Follow the cursor ? If this is ON, during definition, the last node of the
	/// contour will automatically follow the cursor, without waiting for the
	/// point to be dropped. This may be useful for some interpolators, such as the
	/// live-wire interpolator to see the shape of the contour that will be placed
	/// as you move the mouse cursor.
	/// </summary>
	public virtual void FollowCursorOff()
	{
		vtkContourWidget_FollowCursorOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourWidget_FollowCursorOn_08(HandleRef pThis);

	/// <summary>
	/// Follow the cursor ? If this is ON, during definition, the last node of the
	/// contour will automatically follow the cursor, without waiting for the
	/// point to be dropped. This may be useful for some interpolators, such as the
	/// live-wire interpolator to see the shape of the contour that will be placed
	/// as you move the mouse cursor.
	/// </summary>
	public virtual void FollowCursorOn()
	{
		vtkContourWidget_FollowCursorOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourWidget_GetAllowNodePicking_09(HandleRef pThis);

	/// <summary>
	/// Set / Get the AllowNodePicking value. This ivar indicates whether the nodes
	/// and points between nodes can be picked/un-picked by Ctrl+Click on the node.
	/// </summary>
	public virtual int GetAllowNodePicking()
	{
		return vtkContourWidget_GetAllowNodePicking_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourWidget_GetContinuousDraw_10(HandleRef pThis);

	/// <summary>
	/// Define a contour by continuously drawing with the mouse cursor.
	/// Press and hold the left mouse button down to continuously draw.
	/// Releasing the left mouse button switches into a snap drawing mode.
	/// Terminate the contour by pressing the right mouse button.  If you
	/// do not want to see the nodes as they are added to the contour, set the
	/// opacity to 0 of the representation's property.  If you do not want to
	/// see the last active node as it is being added, set the opacity to 0
	/// of the representation's active property.
	/// </summary>
	public virtual int GetContinuousDraw()
	{
		return vtkContourWidget_GetContinuousDraw_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourWidget_GetContourRepresentation_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the representation as a vtkContourRepresentation.
	/// </summary>
	public vtkContourRepresentation GetContourRepresentation()
	{
		vtkContourRepresentation vtkContourRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourWidget_GetContourRepresentation_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContourRepresentation2 = (vtkContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContourRepresentation2.Register(null);
			}
		}
		return vtkContourRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourWidget_GetFollowCursor_12(HandleRef pThis);

	/// <summary>
	/// Follow the cursor ? If this is ON, during definition, the last node of the
	/// contour will automatically follow the cursor, without waiting for the
	/// point to be dropped. This may be useful for some interpolators, such as the
	/// live-wire interpolator to see the shape of the contour that will be placed
	/// as you move the mouse cursor.
	/// </summary>
	public virtual int GetFollowCursor()
	{
		return vtkContourWidget_GetFollowCursor_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContourWidget_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkContourWidget_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContourWidget_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkContourWidget_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourWidget_GetWidgetState_15(HandleRef pThis);

	/// <summary>
	/// Convenient method to determine the state of the method
	/// </summary>
	public virtual int GetWidgetState()
	{
		return vtkContourWidget_GetWidgetState_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourWidget_Initialize_16(HandleRef pThis, HandleRef poly, int state, HandleRef idList);

	/// <summary>
	/// Initialize the contour widget from a user supplied set of points. The
	/// state of the widget decides if you are still defining the widget, or
	/// if you've finished defining (added the last point) are manipulating
	/// it. Note that if the polydata supplied is closed, the state will be
	/// set to manipulate.
	/// State: Define = 0, Manipulate = 1.
	/// </summary>
	public virtual void Initialize(vtkPolyData poly, int state, vtkIdList idList)
	{
		vtkContourWidget_Initialize_16(GetCppThis(), poly?.GetCppThis() ?? default(HandleRef), state, idList?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourWidget_Initialize_17(HandleRef pThis);

	/// <summary>
	/// Initialize the contour widget from a user supplied set of points. The
	/// state of the widget decides if you are still defining the widget, or
	/// if you've finished defining (added the last point) are manipulating
	/// it. Note that if the polydata supplied is closed, the state will be
	/// set to manipulate.
	/// State: Define = 0, Manipulate = 1.
	/// </summary>
	public virtual void Initialize()
	{
		vtkContourWidget_Initialize_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourWidget_IsA_18(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkContourWidget_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourWidget_IsTypeOf_19(string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkContourWidget_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourWidget_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new vtkContourWidget NewInstance()
	{
		vtkContourWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourWidget_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContourWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourWidget_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static vtkContourWidget SafeDownCast(vtkObjectBase o)
	{
		vtkContourWidget vtkContourWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourWidget_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContourWidget2 = (vtkContourWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContourWidget2.Register(null);
			}
		}
		return vtkContourWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourWidget_SetAllowNodePicking_23(HandleRef pThis, int arg0);

	/// <summary>
	/// Set / Get the AllowNodePicking value. This ivar indicates whether the nodes
	/// and points between nodes can be picked/un-picked by Ctrl+Click on the node.
	/// </summary>
	public void SetAllowNodePicking(int arg0)
	{
		vtkContourWidget_SetAllowNodePicking_23(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourWidget_SetContinuousDraw_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Define a contour by continuously drawing with the mouse cursor.
	/// Press and hold the left mouse button down to continuously draw.
	/// Releasing the left mouse button switches into a snap drawing mode.
	/// Terminate the contour by pressing the right mouse button.  If you
	/// do not want to see the nodes as they are added to the contour, set the
	/// opacity to 0 of the representation's property.  If you do not want to
	/// see the last active node as it is being added, set the opacity to 0
	/// of the representation's active property.
	/// </summary>
	public virtual void SetContinuousDraw(int _arg)
	{
		vtkContourWidget_SetContinuousDraw_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourWidget_SetEnabled_25(HandleRef pThis, int arg0);

	/// <summary>
	/// The method for activating and deactivating this widget. This method
	/// must be overridden because it is a composite widget and does more than
	/// its superclasses' vtkAbstractWidget::SetEnabled() method.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkContourWidget_SetEnabled_25(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourWidget_SetFollowCursor_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Follow the cursor ? If this is ON, during definition, the last node of the
	/// contour will automatically follow the cursor, without waiting for the
	/// point to be dropped. This may be useful for some interpolators, such as the
	/// live-wire interpolator to see the shape of the contour that will be placed
	/// as you move the mouse cursor.
	/// </summary>
	public virtual void SetFollowCursor(int _arg)
	{
		vtkContourWidget_SetFollowCursor_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourWidget_SetRepresentation_27(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkContourRepresentation r)
	{
		vtkContourWidget_SetRepresentation_27(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourWidget_SetWidgetState_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Convenient method to change what state the widget is in.
	/// </summary>
	public virtual void SetWidgetState(int _arg)
	{
		vtkContourWidget_SetWidgetState_28(GetCppThis(), _arg);
	}
}
