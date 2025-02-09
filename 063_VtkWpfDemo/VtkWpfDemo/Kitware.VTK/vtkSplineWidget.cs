using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSplineWidget
/// </summary>
/// <remarks>
///    3D widget for manipulating a spline
///
/// This 3D widget defines a spline that can be interactively placed in a
/// scene. The spline has handles, the number of which can be changed, plus it
/// can be picked on the spline itself to translate or rotate it in the scene.
/// A nice feature of the object is that the vtkSplineWidget, like any 3D
/// widget, will work with the current interactor style. That is, if
/// vtkSplineWidget does not handle an event, then all other registered
/// observers (including the interactor style) have an opportunity to process
/// the event. Otherwise, the vtkSplineWidget will terminate the processing of
/// the event that it handles.
///
/// To use this object, just invoke SetInteractor() with the argument of the
/// method a vtkRenderWindowInteractor.  You may also wish to invoke
/// "PlaceWidget()" to initially position the widget. The interactor will act
/// normally until the "i" key (for "interactor") is pressed, at which point the
/// vtkSplineWidget will appear. (See superclass documentation for information
/// about changing this behavior.) Events that occur outside of the widget
/// (i.e., no part of the widget is picked) are propagated to any other
/// registered obsevers (such as the interaction style).  Turn off the widget
/// by pressing the "i" key again (or invoke the Off() method).
///
/// The button actions and key modifiers are as follows for controlling the
/// widget:
/// 1) left button down on and drag one of the spherical handles to change the
/// shape of the spline: the handles act as "control points".
/// 2) left button or middle button down on a line segment forming the spline
/// allows uniform translation of the widget.
/// 3) ctrl + middle button down on the widget enables spinning of the widget
/// about its center.
/// 4) right button down on the widget enables scaling of the widget. By moving
/// the mouse "up" the render window the spline will be made bigger; by moving
/// "down" the render window the widget will be made smaller.
/// 5) ctrl key + right button down on any handle will erase it providing there
/// will be two or more points remaining to form a spline.
/// 6) shift key + right button down on any line segment will insert a handle
/// onto the spline at the cursor position.
///
/// The vtkSplineWidget has several methods that can be used in conjunction with
/// other VTK objects. The Set/GetResolution() methods control the number of
/// subdivisions of the spline; the GetPolyData() method can be used to get the
/// polygonal representation and can be used for things like seeding
/// streamlines or probing other data sets. Typical usage of the widget is to
/// make use of the StartInteractionEvent, InteractionEvent, and
/// EndInteractionEvent events. The InteractionEvent is called on mouse motion;
/// the other two events are called on button down and button up (either left or
/// right button).
///
/// Some additional features of this class include the ability to control the
/// properties of the widget. You can set the properties of the selected and
/// unselected representations of the spline. For example, you can set the
/// property for the handles and spline. In addition there are methods to
/// constrain the spline so that it is aligned with a plane.  Note that a simple
/// ruler widget can be derived by setting the resolution to 1, the number of
/// handles to 2, and calling the GetSummedLength method!
///
/// @par Thanks:
/// Thanks to Dean Inglis for developing and contributing this class.
///
/// </remarks>
/// <seealso>
///
/// vtk3DWidget vtkBoxWidget vtkLineWidget vtkPointWidget vtkSphereWidget
/// vtkImagePlaneWidget vtkImplicitPlaneWidget vtkPlaneWidget
/// </seealso>
public class vtkSplineWidget : vtk3DWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSplineWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSplineWidget()
	{
		MRClassNameKey = "class vtkSplineWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplineWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSplineWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplineWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkSplineWidget New()
	{
		vtkSplineWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplineWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSplineWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkSplineWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSplineWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSplineWidget_ClosedOff_01(HandleRef pThis);

	/// <summary>
	/// Control whether the spline is open or closed. A closed spline forms
	/// a continuous loop: the first and last points are the same, and
	/// derivatives are continuous.  A minimum of 3 handles are required to
	/// form a closed loop.  This method enforces consistency with
	/// user supplied subclasses of vtkSpline.
	/// </summary>
	public virtual void ClosedOff()
	{
		vtkSplineWidget_ClosedOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_ClosedOn_02(HandleRef pThis);

	/// <summary>
	/// Control whether the spline is open or closed. A closed spline forms
	/// a continuous loop: the first and last points are the same, and
	/// derivatives are continuous.  A minimum of 3 handles are required to
	/// form a closed loop.  This method enforces consistency with
	/// user supplied subclasses of vtkSpline.
	/// </summary>
	public virtual void ClosedOn()
	{
		vtkSplineWidget_ClosedOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineWidget_GetClosed_03(HandleRef pThis);

	/// <summary>
	/// Control whether the spline is open or closed. A closed spline forms
	/// a continuous loop: the first and last points are the same, and
	/// derivatives are continuous.  A minimum of 3 handles are required to
	/// form a closed loop.  This method enforces consistency with
	/// user supplied subclasses of vtkSpline.
	/// </summary>
	public virtual int GetClosed()
	{
		return vtkSplineWidget_GetClosed_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_GetHandlePosition_04(HandleRef pThis, int handle, IntPtr xyz);

	/// <summary>
	/// Set/Get the position of the spline handles. Call GetNumberOfHandles
	/// to determine the valid range of handle indices.
	/// </summary>
	public void GetHandlePosition(int handle, IntPtr xyz)
	{
		vtkSplineWidget_GetHandlePosition_04(GetCppThis(), handle, xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplineWidget_GetHandlePosition_05(HandleRef pThis, int handle);

	/// <summary>
	/// Set/Get the position of the spline handles. Call GetNumberOfHandles
	/// to determine the valid range of handle indices.
	/// </summary>
	public double[] GetHandlePosition(int handle)
	{
		IntPtr intPtr = vtkSplineWidget_GetHandlePosition_05(GetCppThis(), handle);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplineWidget_GetHandleProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle properties (the spheres are the handles). The
	/// properties of the handles when selected and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetHandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplineWidget_GetHandleProperty_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplineWidget_GetLineProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the line properties. The properties of the line when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetLineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplineWidget_GetLineProperty_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSplineWidget_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSplineWidget_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSplineWidget_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSplineWidget_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineWidget_GetNumberOfHandles_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of handles for this widget.
	/// </summary>
	public virtual int GetNumberOfHandles()
	{
		return vtkSplineWidget_GetNumberOfHandles_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplineWidget_GetParametricSpline_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the parametric spline object. Through vtkParametricSpline's API, the
	/// user can supply and configure one of currently two types of spline:
	/// vtkCardinalSpline, vtkKochanekSpline. The widget controls the open
	/// or closed configuration of the spline.
	/// WARNING: The widget does not enforce internal consistency so that all
	/// three are of the same type.
	/// </summary>
	public virtual vtkParametricSpline GetParametricSpline()
	{
		vtkParametricSpline vtkParametricSpline2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplineWidget_GetParametricSpline_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParametricSpline2 = (vtkParametricSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParametricSpline2.Register(null);
			}
		}
		return vtkParametricSpline2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_GetPolyData_12(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Grab the polydata (including points) that defines the spline.  The
	/// polydata consists of points and line segments numbering Resolution + 1
	/// and Resolution, respectively. Points are guaranteed to be up-to-date when
	/// either the InteractionEvent or EndInteraction events are invoked. The
	/// user provides the vtkPolyData and the points and polyline are added to it.
	/// </summary>
	public void GetPolyData(vtkPolyData pd)
	{
		vtkSplineWidget_GetPolyData_12(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineWidget_GetProcessEvents_13(HandleRef pThis);

	/// <summary>
	/// Turn on / off event processing for this widget. If off, the widget will
	/// not respond to user interaction
	/// </summary>
	public virtual int GetProcessEvents()
	{
		return vtkSplineWidget_GetProcessEvents_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineWidget_GetProcessEventsMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Turn on / off event processing for this widget. If off, the widget will
	/// not respond to user interaction
	/// </summary>
	public virtual int GetProcessEventsMaxValue()
	{
		return vtkSplineWidget_GetProcessEventsMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineWidget_GetProcessEventsMinValue_15(HandleRef pThis);

	/// <summary>
	/// Turn on / off event processing for this widget. If off, the widget will
	/// not respond to user interaction
	/// </summary>
	public virtual int GetProcessEventsMinValue()
	{
		return vtkSplineWidget_GetProcessEventsMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineWidget_GetProjectToPlane_16(HandleRef pThis);

	/// <summary>
	/// Force the spline widget to be projected onto one of the orthogonal planes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the spline to the plane if it is originally
	/// not aligned.  The normal in SetProjectionNormal is 0,1,2 for YZ,XZ,XY
	/// planes respectively and 3 for arbitrary oblique planes when the widget
	/// is tied to a vtkPlaneSource.
	/// </summary>
	public virtual int GetProjectToPlane()
	{
		return vtkSplineWidget_GetProjectToPlane_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineWidget_GetProjectionNormal_17(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public virtual int GetProjectionNormal()
	{
		return vtkSplineWidget_GetProjectionNormal_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineWidget_GetProjectionNormalMaxValue_18(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public virtual int GetProjectionNormalMaxValue()
	{
		return vtkSplineWidget_GetProjectionNormalMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineWidget_GetProjectionNormalMinValue_19(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public virtual int GetProjectionNormalMinValue()
	{
		return vtkSplineWidget_GetProjectionNormalMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSplineWidget_GetProjectionPosition_20(HandleRef pThis);

	/// <summary>
	/// Set the position of spline handles and points in terms of a plane's
	/// position. i.e., if ProjectionNormal is 0, all of the x-coordinate
	/// values of the points are set to position. Any value can be passed (and is
	/// ignored) to update the spline points when Projection normal is set to 3
	/// for arbitrary plane orientations.
	/// </summary>
	public virtual double GetProjectionPosition()
	{
		return vtkSplineWidget_GetProjectionPosition_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineWidget_GetResolution_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of line segments representing the spline for
	/// this widget.
	/// </summary>
	public virtual int GetResolution()
	{
		return vtkSplineWidget_GetResolution_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplineWidget_GetSelectedHandleProperty_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle properties (the spheres are the handles). The
	/// properties of the handles when selected and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedHandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplineWidget_GetSelectedHandleProperty_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplineWidget_GetSelectedLineProperty_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the line properties. The properties of the line when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedLineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplineWidget_GetSelectedLineProperty_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSplineWidget_GetSummedLength_24(HandleRef pThis);

	/// <summary>
	/// Get the approximate vs. the true arc length of the spline. Calculated as
	/// the summed lengths of the individual straight line segments. Use
	/// SetResolution to control the accuracy.
	/// </summary>
	public double GetSummedLength()
	{
		return vtkSplineWidget_GetSummedLength_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_InitializeHandles_25(HandleRef pThis, HandleRef points);

	/// <summary>
	/// Convenience method to allocate and set the handles from a vtkPoints
	/// instance.  If the first and last points are the same, the spline sets
	/// Closed to the on state and disregards the last point, otherwise Closed
	/// remains unchanged.
	/// </summary>
	public void InitializeHandles(vtkPoints points)
	{
		vtkSplineWidget_InitializeHandles_25(GetCppThis(), points?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineWidget_IsA_26(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSplineWidget_IsA_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineWidget_IsClosed_27(HandleRef pThis);

	/// <summary>
	/// Convenience method to determine whether the spline is
	/// closed in a geometric sense.  The widget may be set "closed" but still
	/// be geometrically open (e.g., a straight line).
	/// </summary>
	public int IsClosed()
	{
		return vtkSplineWidget_IsClosed_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplineWidget_IsTypeOf_28(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSplineWidget_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplineWidget_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new vtkSplineWidget NewInstance()
	{
		vtkSplineWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplineWidget_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSplineWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_PlaceWidget_31(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkSplineWidget_PlaceWidget_31(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_PlaceWidget_32(HandleRef pThis);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget()
	{
		vtkSplineWidget_PlaceWidget_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_PlaceWidget_33(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtkSplineWidget_PlaceWidget_33(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_ProcessEventsOff_34(HandleRef pThis);

	/// <summary>
	/// Turn on / off event processing for this widget. If off, the widget will
	/// not respond to user interaction
	/// </summary>
	public virtual void ProcessEventsOff()
	{
		vtkSplineWidget_ProcessEventsOff_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_ProcessEventsOn_35(HandleRef pThis);

	/// <summary>
	/// Turn on / off event processing for this widget. If off, the widget will
	/// not respond to user interaction
	/// </summary>
	public virtual void ProcessEventsOn()
	{
		vtkSplineWidget_ProcessEventsOn_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_ProjectToPlaneOff_36(HandleRef pThis);

	/// <summary>
	/// Force the spline widget to be projected onto one of the orthogonal planes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the spline to the plane if it is originally
	/// not aligned.  The normal in SetProjectionNormal is 0,1,2 for YZ,XZ,XY
	/// planes respectively and 3 for arbitrary oblique planes when the widget
	/// is tied to a vtkPlaneSource.
	/// </summary>
	public virtual void ProjectToPlaneOff()
	{
		vtkSplineWidget_ProjectToPlaneOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_ProjectToPlaneOn_37(HandleRef pThis);

	/// <summary>
	/// Force the spline widget to be projected onto one of the orthogonal planes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the spline to the plane if it is originally
	/// not aligned.  The normal in SetProjectionNormal is 0,1,2 for YZ,XZ,XY
	/// planes respectively and 3 for arbitrary oblique planes when the widget
	/// is tied to a vtkPlaneSource.
	/// </summary>
	public virtual void ProjectToPlaneOn()
	{
		vtkSplineWidget_ProjectToPlaneOn_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplineWidget_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkSplineWidget SafeDownCast(vtkObjectBase o)
	{
		vtkSplineWidget vtkSplineWidget3 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplineWidget_SafeDownCast_38(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSplineWidget3 = (vtkSplineWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSplineWidget3.Register(null);
			}
		}
		return vtkSplineWidget3;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_SetClosed_39(HandleRef pThis, int closed);

	/// <summary>
	/// Control whether the spline is open or closed. A closed spline forms
	/// a continuous loop: the first and last points are the same, and
	/// derivatives are continuous.  A minimum of 3 handles are required to
	/// form a closed loop.  This method enforces consistency with
	/// user supplied subclasses of vtkSpline.
	/// </summary>
	public void SetClosed(int closed)
	{
		vtkSplineWidget_SetClosed_39(GetCppThis(), closed);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_SetEnabled_40(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkSplineWidget_SetEnabled_40(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_SetHandlePosition_41(HandleRef pThis, int handle, double x, double y, double z);

	/// <summary>
	/// Set/Get the position of the spline handles. Call GetNumberOfHandles
	/// to determine the valid range of handle indices.
	/// </summary>
	public void SetHandlePosition(int handle, double x, double y, double z)
	{
		vtkSplineWidget_SetHandlePosition_41(GetCppThis(), handle, x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_SetHandlePosition_42(HandleRef pThis, int handle, IntPtr xyz);

	/// <summary>
	/// Set/Get the position of the spline handles. Call GetNumberOfHandles
	/// to determine the valid range of handle indices.
	/// </summary>
	public void SetHandlePosition(int handle, IntPtr xyz)
	{
		vtkSplineWidget_SetHandlePosition_42(GetCppThis(), handle, xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_SetHandleProperty_43(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the handle properties (the spheres are the handles). The
	/// properties of the handles when selected and unselected can be manipulated.
	/// </summary>
	public virtual void SetHandleProperty(vtkProperty arg0)
	{
		vtkSplineWidget_SetHandleProperty_43(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_SetLineProperty_44(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the line properties. The properties of the line when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual void SetLineProperty(vtkProperty arg0)
	{
		vtkSplineWidget_SetLineProperty_44(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_SetNumberOfHandles_45(HandleRef pThis, int npts);

	/// <summary>
	/// Set/Get the number of handles for this widget.
	/// </summary>
	public virtual void SetNumberOfHandles(int npts)
	{
		vtkSplineWidget_SetNumberOfHandles_45(GetCppThis(), npts);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_SetParametricSpline_46(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the parametric spline object. Through vtkParametricSpline's API, the
	/// user can supply and configure one of currently two types of spline:
	/// vtkCardinalSpline, vtkKochanekSpline. The widget controls the open
	/// or closed configuration of the spline.
	/// WARNING: The widget does not enforce internal consistency so that all
	/// three are of the same type.
	/// </summary>
	public virtual void SetParametricSpline(vtkParametricSpline arg0)
	{
		vtkSplineWidget_SetParametricSpline_46(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_SetPlaneSource_47(HandleRef pThis, HandleRef plane);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public void SetPlaneSource(vtkPlaneSource plane)
	{
		vtkSplineWidget_SetPlaneSource_47(GetCppThis(), plane?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_SetProcessEvents_48(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on / off event processing for this widget. If off, the widget will
	/// not respond to user interaction
	/// </summary>
	public virtual void SetProcessEvents(int _arg)
	{
		vtkSplineWidget_SetProcessEvents_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_SetProjectToPlane_49(HandleRef pThis, int _arg);

	/// <summary>
	/// Force the spline widget to be projected onto one of the orthogonal planes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the spline to the plane if it is originally
	/// not aligned.  The normal in SetProjectionNormal is 0,1,2 for YZ,XZ,XY
	/// planes respectively and 3 for arbitrary oblique planes when the widget
	/// is tied to a vtkPlaneSource.
	/// </summary>
	public virtual void SetProjectToPlane(int _arg)
	{
		vtkSplineWidget_SetProjectToPlane_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_SetProjectionNormal_50(HandleRef pThis, int _arg);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public virtual void SetProjectionNormal(int _arg)
	{
		vtkSplineWidget_SetProjectionNormal_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_SetProjectionNormalToOblique_51(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public void SetProjectionNormalToOblique()
	{
		vtkSplineWidget_SetProjectionNormalToOblique_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_SetProjectionNormalToXAxes_52(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public void SetProjectionNormalToXAxes()
	{
		vtkSplineWidget_SetProjectionNormalToXAxes_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_SetProjectionNormalToYAxes_53(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public void SetProjectionNormalToYAxes()
	{
		vtkSplineWidget_SetProjectionNormalToYAxes_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_SetProjectionNormalToZAxes_54(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public void SetProjectionNormalToZAxes()
	{
		vtkSplineWidget_SetProjectionNormalToZAxes_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_SetProjectionPosition_55(HandleRef pThis, double position);

	/// <summary>
	/// Set the position of spline handles and points in terms of a plane's
	/// position. i.e., if ProjectionNormal is 0, all of the x-coordinate
	/// values of the points are set to position. Any value can be passed (and is
	/// ignored) to update the spline points when Projection normal is set to 3
	/// for arbitrary plane orientations.
	/// </summary>
	public void SetProjectionPosition(double position)
	{
		vtkSplineWidget_SetProjectionPosition_55(GetCppThis(), position);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_SetResolution_56(HandleRef pThis, int resolution);

	/// <summary>
	/// Set/Get the number of line segments representing the spline for
	/// this widget.
	/// </summary>
	public void SetResolution(int resolution)
	{
		vtkSplineWidget_SetResolution_56(GetCppThis(), resolution);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_SetSelectedHandleProperty_57(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the handle properties (the spheres are the handles). The
	/// properties of the handles when selected and unselected can be manipulated.
	/// </summary>
	public virtual void SetSelectedHandleProperty(vtkProperty arg0)
	{
		vtkSplineWidget_SetSelectedHandleProperty_57(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplineWidget_SetSelectedLineProperty_58(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the line properties. The properties of the line when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual void SetSelectedLineProperty(vtkProperty arg0)
	{
		vtkSplineWidget_SetSelectedLineProperty_58(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
