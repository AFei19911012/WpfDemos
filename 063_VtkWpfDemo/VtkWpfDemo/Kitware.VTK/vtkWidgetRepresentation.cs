using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWidgetRepresentation
/// </summary>
/// <remarks>
///    abstract class defines interface between the widget and widget representation classes
///
/// This class is used to define the API for, and partially implement, a
/// representation for different types of widgets. Note that the widget
/// representation (i.e., subclasses of vtkWidgetRepresentation) are a type of
/// vtkProp; meaning that they can be associated with a vtkRenderer end
/// embedded in a scene like any other vtkActor. However,
/// vtkWidgetRepresentation also defines an API that enables it to be paired
/// with a subclass vtkAbstractWidget, meaning that it can be driven by a
/// widget, serving to represent the widget as the widget responds to
/// registered events.
///
/// The API defined here should be regarded as a guideline for implementing
/// widgets and widget representations. Widget behavior is complex, as is the
/// way the representation responds to the registered widget events, so the API
/// may vary from widget to widget to reflect this complexity.
///
/// @warning
/// The separation of the widget event handling and representation enables
/// users and developers to create new appearances for the widget. It also
/// facilitates parallel processing, where the client application handles
/// events, and remote representations of the widget are slaves to the
/// client (and do not handle events).
/// </remarks>
public abstract class vtkWidgetRepresentation : vtkProp
{
	/// <summary>
	/// Axis labels
	/// </summary>
	public enum Axis
	{
		/// <summary>enum member</summary>
		Custom = 3,
		/// <summary>enum member</summary>
		NONE = -1,
		/// <summary>enum member</summary>
		XAxis = 0,
		/// <summary>enum member</summary>
		YAxis = 1,
		/// <summary>enum member</summary>
		ZAxis = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWidgetRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWidgetRepresentation()
	{
		MRClassNameKey = "class vtkWidgetRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWidgetRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWidgetRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Subclasses of vtkWidgetRepresentation must implement these methods. This is
	/// considered the minimum API for a widget representation.
	/// &lt;pre&gt;
	/// SetRenderer() - the renderer in which the representations draws itself.
	/// Typically the renderer is set by the associated widget.
	/// Use the widget's SetCurrentRenderer() method in most cases;
	/// otherwise there is a risk of inconsistent behavior as events
	/// and drawing may be performed in different viewports.
	/// BuildRepresentation() - update the geometry of the widget based on its
	/// current state.
	/// &lt;/pre&gt;
	/// WARNING: The renderer is NOT reference counted by the representation,
	/// in order to avoid reference loops.  Be sure that the representation
	/// lifetime does not extend beyond the renderer lifetime.
	/// </summary>
	public virtual void BuildRepresentation()
	{
		vtkWidgetRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_ComplexInteraction_02(HandleRef pThis, HandleRef arg0, HandleRef arg1, uint arg2, IntPtr arg3);

	/// <summary>
	/// The following is a suggested API for widget representations. These methods
	/// define the communication between the widget and its representation. These
	/// methods are only suggestions because widgets take on so many different
	/// forms that a universal API is not deemed practical. However, these methods
	/// should be implemented when possible to ensure that the VTK widget hierarchy
	/// remains self-consistent.
	/// &lt;pre&gt;
	/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
	/// the widget inside of it. The current orientation of the widget
	/// is preserved, only scaling and translation is performed.
	/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
	/// mouse down) that starts the interaction process
	/// with the widget.
	/// WidgetInteraction() - invoked when an event causes the widget to change
	/// appearance.
	/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
	/// and completes the interaction sequence.
	/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
	/// possible flag that modifies the computation,
	/// what is the state of the widget?
	/// GetInteractionState() - return the current state of the widget. Note that the
	/// value of "0" typically refers to "outside". The
	/// interaction state is strictly a function of the
	/// representation, and the widget/represent must agree
	/// on what they mean.
	/// Highlight() - turn on or off any highlights associated with the widget.
	/// Highlights are generally turned on when the widget is selected.
	/// &lt;/pre&gt;
	/// Note that subclasses may ignore some of these methods and implement their own
	/// depending on the specifics of the widget.
	/// </summary>
	public virtual void ComplexInteraction(vtkRenderWindowInteractor arg0, vtkAbstractWidget arg1, uint arg2, IntPtr arg3)
	{
		vtkWidgetRepresentation_ComplexInteraction_02(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef), arg2, arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetRepresentation_ComputeComplexInteractionState_03(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr callData, int modify);

	/// <summary>
	/// The following is a suggested API for widget representations. These methods
	/// define the communication between the widget and its representation. These
	/// methods are only suggestions because widgets take on so many different
	/// forms that a universal API is not deemed practical. However, these methods
	/// should be implemented when possible to ensure that the VTK widget hierarchy
	/// remains self-consistent.
	/// &lt;pre&gt;
	/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
	/// the widget inside of it. The current orientation of the widget
	/// is preserved, only scaling and translation is performed.
	/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
	/// mouse down) that starts the interaction process
	/// with the widget.
	/// WidgetInteraction() - invoked when an event causes the widget to change
	/// appearance.
	/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
	/// and completes the interaction sequence.
	/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
	/// possible flag that modifies the computation,
	/// what is the state of the widget?
	/// GetInteractionState() - return the current state of the widget. Note that the
	/// value of "0" typically refers to "outside". The
	/// interaction state is strictly a function of the
	/// representation, and the widget/represent must agree
	/// on what they mean.
	/// Highlight() - turn on or off any highlights associated with the widget.
	/// Highlights are generally turned on when the widget is selected.
	/// &lt;/pre&gt;
	/// Note that subclasses may ignore some of these methods and implement their own
	/// depending on the specifics of the widget.
	/// </summary>
	public virtual int ComputeComplexInteractionState(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr callData, int modify)
	{
		return vtkWidgetRepresentation_ComputeComplexInteractionState_03(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, callData, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetRepresentation_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// The following is a suggested API for widget representations. These methods
	/// define the communication between the widget and its representation. These
	/// methods are only suggestions because widgets take on so many different
	/// forms that a universal API is not deemed practical. However, these methods
	/// should be implemented when possible to ensure that the VTK widget hierarchy
	/// remains self-consistent.
	/// &lt;pre&gt;
	/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
	/// the widget inside of it. The current orientation of the widget
	/// is preserved, only scaling and translation is performed.
	/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
	/// mouse down) that starts the interaction process
	/// with the widget.
	/// WidgetInteraction() - invoked when an event causes the widget to change
	/// appearance.
	/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
	/// and completes the interaction sequence.
	/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
	/// possible flag that modifies the computation,
	/// what is the state of the widget?
	/// GetInteractionState() - return the current state of the widget. Note that the
	/// value of "0" typically refers to "outside". The
	/// interaction state is strictly a function of the
	/// representation, and the widget/represent must agree
	/// on what they mean.
	/// Highlight() - turn on or off any highlights associated with the widget.
	/// Highlights are generally turned on when the widget is selected.
	/// &lt;/pre&gt;
	/// Note that subclasses may ignore some of these methods and implement their own
	/// depending on the specifics of the widget.
	/// </summary>
	public virtual int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkWidgetRepresentation_ComputeInteractionState_04(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_EndComplexInteraction_05(HandleRef pThis, HandleRef arg0, HandleRef arg1, uint arg2, IntPtr arg3);

	/// <summary>
	/// The following is a suggested API for widget representations. These methods
	/// define the communication between the widget and its representation. These
	/// methods are only suggestions because widgets take on so many different
	/// forms that a universal API is not deemed practical. However, these methods
	/// should be implemented when possible to ensure that the VTK widget hierarchy
	/// remains self-consistent.
	/// &lt;pre&gt;
	/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
	/// the widget inside of it. The current orientation of the widget
	/// is preserved, only scaling and translation is performed.
	/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
	/// mouse down) that starts the interaction process
	/// with the widget.
	/// WidgetInteraction() - invoked when an event causes the widget to change
	/// appearance.
	/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
	/// and completes the interaction sequence.
	/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
	/// possible flag that modifies the computation,
	/// what is the state of the widget?
	/// GetInteractionState() - return the current state of the widget. Note that the
	/// value of "0" typically refers to "outside". The
	/// interaction state is strictly a function of the
	/// representation, and the widget/represent must agree
	/// on what they mean.
	/// Highlight() - turn on or off any highlights associated with the widget.
	/// Highlights are generally turned on when the widget is selected.
	/// &lt;/pre&gt;
	/// Note that subclasses may ignore some of these methods and implement their own
	/// depending on the specifics of the widget.
	/// </summary>
	public virtual void EndComplexInteraction(vtkRenderWindowInteractor arg0, vtkAbstractWidget arg1, uint arg2, IntPtr arg3)
	{
		vtkWidgetRepresentation_EndComplexInteraction_05(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef), arg2, arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_EndWidgetInteraction_06(HandleRef pThis, IntPtr newEventPos);

	/// <summary>
	/// The following is a suggested API for widget representations. These methods
	/// define the communication between the widget and its representation. These
	/// methods are only suggestions because widgets take on so many different
	/// forms that a universal API is not deemed practical. However, these methods
	/// should be implemented when possible to ensure that the VTK widget hierarchy
	/// remains self-consistent.
	/// &lt;pre&gt;
	/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
	/// the widget inside of it. The current orientation of the widget
	/// is preserved, only scaling and translation is performed.
	/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
	/// mouse down) that starts the interaction process
	/// with the widget.
	/// WidgetInteraction() - invoked when an event causes the widget to change
	/// appearance.
	/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
	/// and completes the interaction sequence.
	/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
	/// possible flag that modifies the computation,
	/// what is the state of the widget?
	/// GetInteractionState() - return the current state of the widget. Note that the
	/// value of "0" typically refers to "outside". The
	/// interaction state is strictly a function of the
	/// representation, and the widget/represent must agree
	/// on what they mean.
	/// Highlight() - turn on or off any highlights associated with the widget.
	/// Highlights are generally turned on when the widget is selected.
	/// &lt;/pre&gt;
	/// Note that subclasses may ignore some of these methods and implement their own
	/// depending on the specifics of the widget.
	/// </summary>
	public virtual void EndWidgetInteraction(IntPtr newEventPos)
	{
		vtkWidgetRepresentation_EndWidgetInteraction_06(GetCppThis(), newEventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_GetActors_07(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp. They are repeated here (from the
	/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
	/// these methods properly may result in the representation not appearing in the scene
	/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
	/// (i.e., not implementing ReleaseGraphicsResources() properly).
	/// </summary>
	public override void GetActors(vtkPropCollection arg0)
	{
		vtkWidgetRepresentation_GetActors_07(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_GetActors2D_08(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp. They are repeated here (from the
	/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
	/// these methods properly may result in the representation not appearing in the scene
	/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
	/// (i.e., not implementing ReleaseGraphicsResources() properly).
	/// </summary>
	public override void GetActors2D(vtkPropCollection arg0)
	{
		vtkWidgetRepresentation_GetActors2D_08(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWidgetRepresentation_GetBounds_09(HandleRef pThis);

	/// <summary>
	/// Methods to make this class behave as a vtkProp. They are repeated here (from the
	/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
	/// these methods properly may result in the representation not appearing in the scene
	/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
	/// (i.e., not implementing ReleaseGraphicsResources() properly).
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkWidgetRepresentation_GetBounds_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWidgetRepresentation_GetHandleSize_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the size of the handles that appear as
	/// part of the widget (if any). These handles (like spheres, etc.)  are
	/// used to manipulate the widget. The HandleSize data member allows you
	/// to change the relative size of the handles. Note that while the handle
	/// size is typically expressed in pixels, some subclasses may use a relative size
	/// with respect to the viewport. (As a corollary, the value of this ivar is often
	/// set by subclasses of this class during instance instantiation.)
	/// </summary>
	public virtual double GetHandleSize()
	{
		return vtkWidgetRepresentation_GetHandleSize_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWidgetRepresentation_GetHandleSizeMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the size of the handles that appear as
	/// part of the widget (if any). These handles (like spheres, etc.)  are
	/// used to manipulate the widget. The HandleSize data member allows you
	/// to change the relative size of the handles. Note that while the handle
	/// size is typically expressed in pixels, some subclasses may use a relative size
	/// with respect to the viewport. (As a corollary, the value of this ivar is often
	/// set by subclasses of this class during instance instantiation.)
	/// </summary>
	public virtual double GetHandleSizeMaxValue()
	{
		return vtkWidgetRepresentation_GetHandleSizeMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWidgetRepresentation_GetHandleSizeMinValue_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the size of the handles that appear as
	/// part of the widget (if any). These handles (like spheres, etc.)  are
	/// used to manipulate the widget. The HandleSize data member allows you
	/// to change the relative size of the handles. Note that while the handle
	/// size is typically expressed in pixels, some subclasses may use a relative size
	/// with respect to the viewport. (As a corollary, the value of this ivar is often
	/// set by subclasses of this class during instance instantiation.)
	/// </summary>
	public virtual double GetHandleSizeMinValue()
	{
		return vtkWidgetRepresentation_GetHandleSizeMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetRepresentation_GetInteractionState_13(HandleRef pThis);

	/// <summary>
	/// The following is a suggested API for widget representations. These methods
	/// define the communication between the widget and its representation. These
	/// methods are only suggestions because widgets take on so many different
	/// forms that a universal API is not deemed practical. However, these methods
	/// should be implemented when possible to ensure that the VTK widget hierarchy
	/// remains self-consistent.
	/// &lt;pre&gt;
	/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
	/// the widget inside of it. The current orientation of the widget
	/// is preserved, only scaling and translation is performed.
	/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
	/// mouse down) that starts the interaction process
	/// with the widget.
	/// WidgetInteraction() - invoked when an event causes the widget to change
	/// appearance.
	/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
	/// and completes the interaction sequence.
	/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
	/// possible flag that modifies the computation,
	/// what is the state of the widget?
	/// GetInteractionState() - return the current state of the widget. Note that the
	/// value of "0" typically refers to "outside". The
	/// interaction state is strictly a function of the
	/// representation, and the widget/represent must agree
	/// on what they mean.
	/// Highlight() - turn on or off any highlights associated with the widget.
	/// Highlights are generally turned on when the widget is selected.
	/// &lt;/pre&gt;
	/// Note that subclasses may ignore some of these methods and implement their own
	/// depending on the specifics of the widget.
	/// </summary>
	public virtual int GetInteractionState()
	{
		return vtkWidgetRepresentation_GetInteractionState_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetRepresentation_GetNeedToRender_14(HandleRef pThis);

	/// <summary>
	/// Some subclasses use this data member to keep track of whether to render
	/// or not (i.e., to minimize the total number of renders).
	/// </summary>
	public virtual int GetNeedToRender()
	{
		return vtkWidgetRepresentation_GetNeedToRender_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetRepresentation_GetNeedToRenderMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Some subclasses use this data member to keep track of whether to render
	/// or not (i.e., to minimize the total number of renders).
	/// </summary>
	public virtual int GetNeedToRenderMaxValue()
	{
		return vtkWidgetRepresentation_GetNeedToRenderMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetRepresentation_GetNeedToRenderMinValue_16(HandleRef pThis);

	/// <summary>
	/// Some subclasses use this data member to keep track of whether to render
	/// or not (i.e., to minimize the total number of renders).
	/// </summary>
	public virtual int GetNeedToRenderMinValue()
	{
		return vtkWidgetRepresentation_GetNeedToRenderMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWidgetRepresentation_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWidgetRepresentation_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWidgetRepresentation_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWidgetRepresentation_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkWidgetRepresentation_GetPickingManaged_19(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the use of a manager to process the picking.
	/// Enabled by default.
	/// </summary>
	public virtual bool GetPickingManaged()
	{
		return (vtkWidgetRepresentation_GetPickingManaged_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWidgetRepresentation_GetPlaceFactor_20(HandleRef pThis);

	/// <summary>
	/// Set/Get a factor representing the scaling of the widget upon placement
	/// (via the PlaceWidget() method). Normally the widget is placed so that
	/// it just fits within the bounding box defined in PlaceWidget(bounds).
	/// The PlaceFactor will make the widget larger (PlaceFactor &gt; 1) or smaller
	/// (PlaceFactor &lt; 1). By default, PlaceFactor is set to 0.5.
	/// </summary>
	public virtual double GetPlaceFactor()
	{
		return vtkWidgetRepresentation_GetPlaceFactor_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWidgetRepresentation_GetPlaceFactorMaxValue_21(HandleRef pThis);

	/// <summary>
	/// Set/Get a factor representing the scaling of the widget upon placement
	/// (via the PlaceWidget() method). Normally the widget is placed so that
	/// it just fits within the bounding box defined in PlaceWidget(bounds).
	/// The PlaceFactor will make the widget larger (PlaceFactor &gt; 1) or smaller
	/// (PlaceFactor &lt; 1). By default, PlaceFactor is set to 0.5.
	/// </summary>
	public virtual double GetPlaceFactorMaxValue()
	{
		return vtkWidgetRepresentation_GetPlaceFactorMaxValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWidgetRepresentation_GetPlaceFactorMinValue_22(HandleRef pThis);

	/// <summary>
	/// Set/Get a factor representing the scaling of the widget upon placement
	/// (via the PlaceWidget() method). Normally the widget is placed so that
	/// it just fits within the bounding box defined in PlaceWidget(bounds).
	/// The PlaceFactor will make the widget larger (PlaceFactor &gt; 1) or smaller
	/// (PlaceFactor &lt; 1). By default, PlaceFactor is set to 0.5.
	/// </summary>
	public virtual double GetPlaceFactorMinValue()
	{
		return vtkWidgetRepresentation_GetPlaceFactorMinValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWidgetRepresentation_GetRenderer_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Subclasses of vtkWidgetRepresentation must implement these methods. This is
	/// considered the minimum API for a widget representation.
	/// &lt;pre&gt;
	/// SetRenderer() - the renderer in which the representations draws itself.
	/// Typically the renderer is set by the associated widget.
	/// Use the widget's SetCurrentRenderer() method in most cases;
	/// otherwise there is a risk of inconsistent behavior as events
	/// and drawing may be performed in different viewports.
	/// BuildRepresentation() - update the geometry of the widget based on its
	/// current state.
	/// &lt;/pre&gt;
	/// WARNING: The renderer is NOT reference counted by the representation,
	/// in order to avoid reference loops.  Be sure that the representation
	/// lifetime does not extend beyond the renderer lifetime.
	/// </summary>
	public virtual vtkRenderer GetRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWidgetRepresentation_GetRenderer_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_GetVolumes_24(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp. They are repeated here (from the
	/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
	/// these methods properly may result in the representation not appearing in the scene
	/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
	/// (i.e., not implementing ReleaseGraphicsResources() properly).
	/// </summary>
	public override void GetVolumes(vtkPropCollection arg0)
	{
		vtkWidgetRepresentation_GetVolumes_24(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetRepresentation_HasTranslucentPolygonalGeometry_25(HandleRef pThis);

	/// <summary>
	/// Methods to make this class behave as a vtkProp. They are repeated here (from the
	/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
	/// these methods properly may result in the representation not appearing in the scene
	/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
	/// (i.e., not implementing ReleaseGraphicsResources() properly).
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkWidgetRepresentation_HasTranslucentPolygonalGeometry_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_Highlight_26(HandleRef pThis, int arg0);

	/// <summary>
	/// The following is a suggested API for widget representations. These methods
	/// define the communication between the widget and its representation. These
	/// methods are only suggestions because widgets take on so many different
	/// forms that a universal API is not deemed practical. However, these methods
	/// should be implemented when possible to ensure that the VTK widget hierarchy
	/// remains self-consistent.
	/// &lt;pre&gt;
	/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
	/// the widget inside of it. The current orientation of the widget
	/// is preserved, only scaling and translation is performed.
	/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
	/// mouse down) that starts the interaction process
	/// with the widget.
	/// WidgetInteraction() - invoked when an event causes the widget to change
	/// appearance.
	/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
	/// and completes the interaction sequence.
	/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
	/// possible flag that modifies the computation,
	/// what is the state of the widget?
	/// GetInteractionState() - return the current state of the widget. Note that the
	/// value of "0" typically refers to "outside". The
	/// interaction state is strictly a function of the
	/// representation, and the widget/represent must agree
	/// on what they mean.
	/// Highlight() - turn on or off any highlights associated with the widget.
	/// Highlights are generally turned on when the widget is selected.
	/// &lt;/pre&gt;
	/// Note that subclasses may ignore some of these methods and implement their own
	/// depending on the specifics of the widget.
	/// </summary>
	public virtual void Highlight(int arg0)
	{
		vtkWidgetRepresentation_Highlight_26(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetRepresentation_IsA_27(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWidgetRepresentation_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetRepresentation_IsTypeOf_28(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWidgetRepresentation_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_NeedToRenderOff_29(HandleRef pThis);

	/// <summary>
	/// Some subclasses use this data member to keep track of whether to render
	/// or not (i.e., to minimize the total number of renders).
	/// </summary>
	public virtual void NeedToRenderOff()
	{
		vtkWidgetRepresentation_NeedToRenderOff_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_NeedToRenderOn_30(HandleRef pThis);

	/// <summary>
	/// Some subclasses use this data member to keep track of whether to render
	/// or not (i.e., to minimize the total number of renders).
	/// </summary>
	public virtual void NeedToRenderOn()
	{
		vtkWidgetRepresentation_NeedToRenderOn_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWidgetRepresentation_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkWidgetRepresentation NewInstance()
	{
		vtkWidgetRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWidgetRepresentation_NewInstance_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWidgetRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_PickingManagedOff_32(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the use of a manager to process the picking.
	/// Enabled by default.
	/// </summary>
	public virtual void PickingManagedOff()
	{
		vtkWidgetRepresentation_PickingManagedOff_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_PickingManagedOn_33(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the use of a manager to process the picking.
	/// Enabled by default.
	/// </summary>
	public virtual void PickingManagedOn()
	{
		vtkWidgetRepresentation_PickingManagedOn_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_PlaceWidget_34(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// The following is a suggested API for widget representations. These methods
	/// define the communication between the widget and its representation. These
	/// methods are only suggestions because widgets take on so many different
	/// forms that a universal API is not deemed practical. However, these methods
	/// should be implemented when possible to ensure that the VTK widget hierarchy
	/// remains self-consistent.
	/// &lt;pre&gt;
	/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
	/// the widget inside of it. The current orientation of the widget
	/// is preserved, only scaling and translation is performed.
	/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
	/// mouse down) that starts the interaction process
	/// with the widget.
	/// WidgetInteraction() - invoked when an event causes the widget to change
	/// appearance.
	/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
	/// and completes the interaction sequence.
	/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
	/// possible flag that modifies the computation,
	/// what is the state of the widget?
	/// GetInteractionState() - return the current state of the widget. Note that the
	/// value of "0" typically refers to "outside". The
	/// interaction state is strictly a function of the
	/// representation, and the widget/represent must agree
	/// on what they mean.
	/// Highlight() - turn on or off any highlights associated with the widget.
	/// Highlights are generally turned on when the widget is selected.
	/// &lt;/pre&gt;
	/// Note that subclasses may ignore some of these methods and implement their own
	/// depending on the specifics of the widget.
	/// </summary>
	public virtual void PlaceWidget(IntPtr arg0)
	{
		vtkWidgetRepresentation_PlaceWidget_34(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_RegisterPickers_35(HandleRef pThis);

	/// <summary>
	/// Register internal Pickers in the Picking Manager.
	/// Must be reimplemented by concrete widget representations to register
	/// their pickers.
	/// </summary>
	public virtual void RegisterPickers()
	{
		vtkWidgetRepresentation_RegisterPickers_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_ReleaseGraphicsResources_36(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp. They are repeated here (from the
	/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
	/// these methods properly may result in the representation not appearing in the scene
	/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
	/// (i.e., not implementing ReleaseGraphicsResources() properly).
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkWidgetRepresentation_ReleaseGraphicsResources_36(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetRepresentation_RenderOpaqueGeometry_37(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp. They are repeated here (from the
	/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
	/// these methods properly may result in the representation not appearing in the scene
	/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
	/// (i.e., not implementing ReleaseGraphicsResources() properly).
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkWidgetRepresentation_RenderOpaqueGeometry_37(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetRepresentation_RenderOverlay_38(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp. They are repeated here (from the
	/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
	/// these methods properly may result in the representation not appearing in the scene
	/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
	/// (i.e., not implementing ReleaseGraphicsResources() properly).
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkWidgetRepresentation_RenderOverlay_38(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetRepresentation_RenderTranslucentPolygonalGeometry_39(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp. They are repeated here (from the
	/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
	/// these methods properly may result in the representation not appearing in the scene
	/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
	/// (i.e., not implementing ReleaseGraphicsResources() properly).
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkWidgetRepresentation_RenderTranslucentPolygonalGeometry_39(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetRepresentation_RenderVolumetricGeometry_40(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp. They are repeated here (from the
	/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
	/// these methods properly may result in the representation not appearing in the scene
	/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
	/// (i.e., not implementing ReleaseGraphicsResources() properly).
	/// </summary>
	public override int RenderVolumetricGeometry(vtkViewport arg0)
	{
		return vtkWidgetRepresentation_RenderVolumetricGeometry_40(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWidgetRepresentation_SafeDownCast_41(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkWidgetRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkWidgetRepresentation vtkWidgetRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWidgetRepresentation_SafeDownCast_41(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWidgetRepresentation2 = (vtkWidgetRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWidgetRepresentation2.Register(null);
			}
		}
		return vtkWidgetRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_SetHandleSize_42(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the factor that controls the size of the handles that appear as
	/// part of the widget (if any). These handles (like spheres, etc.)  are
	/// used to manipulate the widget. The HandleSize data member allows you
	/// to change the relative size of the handles. Note that while the handle
	/// size is typically expressed in pixels, some subclasses may use a relative size
	/// with respect to the viewport. (As a corollary, the value of this ivar is often
	/// set by subclasses of this class during instance instantiation.)
	/// </summary>
	public virtual void SetHandleSize(double _arg)
	{
		vtkWidgetRepresentation_SetHandleSize_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_SetNeedToRender_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Some subclasses use this data member to keep track of whether to render
	/// or not (i.e., to minimize the total number of renders).
	/// </summary>
	public virtual void SetNeedToRender(int _arg)
	{
		vtkWidgetRepresentation_SetNeedToRender_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_SetPickingManaged_44(HandleRef pThis, byte managed);

	/// <summary>
	/// Enable/Disable the use of a manager to process the picking.
	/// Enabled by default.
	/// </summary>
	public void SetPickingManaged(bool managed)
	{
		vtkWidgetRepresentation_SetPickingManaged_44(GetCppThis(), (byte)(managed ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_SetPlaceFactor_45(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get a factor representing the scaling of the widget upon placement
	/// (via the PlaceWidget() method). Normally the widget is placed so that
	/// it just fits within the bounding box defined in PlaceWidget(bounds).
	/// The PlaceFactor will make the widget larger (PlaceFactor &gt; 1) or smaller
	/// (PlaceFactor &lt; 1). By default, PlaceFactor is set to 0.5.
	/// </summary>
	public virtual void SetPlaceFactor(double _arg)
	{
		vtkWidgetRepresentation_SetPlaceFactor_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_SetRenderer_46(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Subclasses of vtkWidgetRepresentation must implement these methods. This is
	/// considered the minimum API for a widget representation.
	/// &lt;pre&gt;
	/// SetRenderer() - the renderer in which the representations draws itself.
	/// Typically the renderer is set by the associated widget.
	/// Use the widget's SetCurrentRenderer() method in most cases;
	/// otherwise there is a risk of inconsistent behavior as events
	/// and drawing may be performed in different viewports.
	/// BuildRepresentation() - update the geometry of the widget based on its
	/// current state.
	/// &lt;/pre&gt;
	/// WARNING: The renderer is NOT reference counted by the representation,
	/// in order to avoid reference loops.  Be sure that the representation
	/// lifetime does not extend beyond the renderer lifetime.
	/// </summary>
	public virtual void SetRenderer(vtkRenderer ren)
	{
		vtkWidgetRepresentation_SetRenderer_46(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_ShallowCopy_47(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Methods to make this class behave as a vtkProp. They are repeated here (from the
	/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
	/// these methods properly may result in the representation not appearing in the scene
	/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
	/// (i.e., not implementing ReleaseGraphicsResources() properly).
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkWidgetRepresentation_ShallowCopy_47(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_StartComplexInteraction_48(HandleRef pThis, HandleRef arg0, HandleRef arg1, uint arg2, IntPtr arg3);

	/// <summary>
	/// The following is a suggested API for widget representations. These methods
	/// define the communication between the widget and its representation. These
	/// methods are only suggestions because widgets take on so many different
	/// forms that a universal API is not deemed practical. However, these methods
	/// should be implemented when possible to ensure that the VTK widget hierarchy
	/// remains self-consistent.
	/// &lt;pre&gt;
	/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
	/// the widget inside of it. The current orientation of the widget
	/// is preserved, only scaling and translation is performed.
	/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
	/// mouse down) that starts the interaction process
	/// with the widget.
	/// WidgetInteraction() - invoked when an event causes the widget to change
	/// appearance.
	/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
	/// and completes the interaction sequence.
	/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
	/// possible flag that modifies the computation,
	/// what is the state of the widget?
	/// GetInteractionState() - return the current state of the widget. Note that the
	/// value of "0" typically refers to "outside". The
	/// interaction state is strictly a function of the
	/// representation, and the widget/represent must agree
	/// on what they mean.
	/// Highlight() - turn on or off any highlights associated with the widget.
	/// Highlights are generally turned on when the widget is selected.
	/// &lt;/pre&gt;
	/// Note that subclasses may ignore some of these methods and implement their own
	/// depending on the specifics of the widget.
	/// </summary>
	public virtual void StartComplexInteraction(vtkRenderWindowInteractor arg0, vtkAbstractWidget arg1, uint arg2, IntPtr arg3)
	{
		vtkWidgetRepresentation_StartComplexInteraction_48(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef), arg2, arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_StartWidgetInteraction_49(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// The following is a suggested API for widget representations. These methods
	/// define the communication between the widget and its representation. These
	/// methods are only suggestions because widgets take on so many different
	/// forms that a universal API is not deemed practical. However, these methods
	/// should be implemented when possible to ensure that the VTK widget hierarchy
	/// remains self-consistent.
	/// &lt;pre&gt;
	/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
	/// the widget inside of it. The current orientation of the widget
	/// is preserved, only scaling and translation is performed.
	/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
	/// mouse down) that starts the interaction process
	/// with the widget.
	/// WidgetInteraction() - invoked when an event causes the widget to change
	/// appearance.
	/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
	/// and completes the interaction sequence.
	/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
	/// possible flag that modifies the computation,
	/// what is the state of the widget?
	/// GetInteractionState() - return the current state of the widget. Note that the
	/// value of "0" typically refers to "outside". The
	/// interaction state is strictly a function of the
	/// representation, and the widget/represent must agree
	/// on what they mean.
	/// Highlight() - turn on or off any highlights associated with the widget.
	/// Highlights are generally turned on when the widget is selected.
	/// &lt;/pre&gt;
	/// Note that subclasses may ignore some of these methods and implement their own
	/// depending on the specifics of the widget.
	/// </summary>
	public virtual void StartWidgetInteraction(IntPtr eventPos)
	{
		vtkWidgetRepresentation_StartWidgetInteraction_49(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_UnRegisterPickers_50(HandleRef pThis);

	/// <summary>
	/// Unregister internal pickers from the Picking Manager.
	/// </summary>
	public virtual void UnRegisterPickers()
	{
		vtkWidgetRepresentation_UnRegisterPickers_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetRepresentation_WidgetInteraction_51(HandleRef pThis, IntPtr newEventPos);

	/// <summary>
	/// The following is a suggested API for widget representations. These methods
	/// define the communication between the widget and its representation. These
	/// methods are only suggestions because widgets take on so many different
	/// forms that a universal API is not deemed practical. However, these methods
	/// should be implemented when possible to ensure that the VTK widget hierarchy
	/// remains self-consistent.
	/// &lt;pre&gt;
	/// PlaceWidget() - given a bounding box (xmin,xmax,ymin,ymax,zmin,zmax), place
	/// the widget inside of it. The current orientation of the widget
	/// is preserved, only scaling and translation is performed.
	/// StartWidgetInteraction() - generally corresponds to a initial event (e.g.,
	/// mouse down) that starts the interaction process
	/// with the widget.
	/// WidgetInteraction() - invoked when an event causes the widget to change
	/// appearance.
	/// EndWidgetInteraction() - generally corresponds to a final event (e.g., mouse up)
	/// and completes the interaction sequence.
	/// ComputeInteractionState() - given (X,Y) display coordinates in a renderer, with a
	/// possible flag that modifies the computation,
	/// what is the state of the widget?
	/// GetInteractionState() - return the current state of the widget. Note that the
	/// value of "0" typically refers to "outside". The
	/// interaction state is strictly a function of the
	/// representation, and the widget/represent must agree
	/// on what they mean.
	/// Highlight() - turn on or off any highlights associated with the widget.
	/// Highlights are generally turned on when the widget is selected.
	/// &lt;/pre&gt;
	/// Note that subclasses may ignore some of these methods and implement their own
	/// depending on the specifics of the widget.
	/// </summary>
	public virtual void WidgetInteraction(IntPtr newEventPos)
	{
		vtkWidgetRepresentation_WidgetInteraction_51(GetCppThis(), newEventPos);
	}
}
