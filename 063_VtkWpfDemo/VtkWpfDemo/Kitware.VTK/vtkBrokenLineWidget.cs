using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBrokenLineWidget
/// </summary>
/// <remarks>
///    3D widget for manipulating a broken line
///
/// This 3D widget defines a broken line that can be interactively placed in a
/// scene. The broken line has handles, the number of which can be changed, plus it
/// can be picked on the broken line itself to translate or rotate it in the scene.
/// A nice feature of the object is that the vtkBrokenLineWidget, like any 3D
/// widget, will work with the current interactor style. That is, if
/// vtkBrokenLineWidget does not handle an event, then all other registered
/// observers (including the interactor style) have an opportunity to process
/// the event. Otherwise, the vtkBrokenLineWidget will terminate the processing of
/// the event that it handles.
///
/// To use this object, just invoke SetInteractor() with the argument of the
/// method a vtkRenderWindowInteractor.  You may also wish to invoke
/// "PlaceWidget()" to initially position the widget. The interactor will act
/// normally until the "i" key (for "interactor") is pressed, at which point the
/// vtkBrokenLineWidget will appear. (See superclass documentation for information
/// about changing this behavior.) Events that occur outside of the widget
/// (i.e., no part of the widget is picked) are propagated to any other
/// registered obsevers (such as the interaction style).  Turn off the widget
/// by pressing the "i" key again (or invoke the Off() method).
///
/// The button actions and key modifiers are as follows for controlling the
/// widget:
/// 1) left button down on and drag one of the spherical handles to change the
/// shape of the broken line: the handles act as "control points".
/// 2) left button or middle button down on a line segment forming the broken line
/// allows uniform translation of the widget.
/// 3) ctrl + middle button down on the widget enables spinning of the widget
/// about its center.
/// 4) right button down on the widget enables scaling of the widget. By moving
/// the mouse "up" the render window the broken line will be made bigger; by moving
/// "down" the render window the widget will be made smaller.
/// 5) ctrl key + right button down on any handle will erase it providing there
/// will be two or more points remaining to form a broken line.
/// 6) shift key + right button down on any line segment will insert a handle
/// onto the broken line at the cursor position.
///
/// The vtkBrokenLineWidget has several methods that can be used in conjunction with
/// other VTK objects. The GetPolyData() method can be used to get the
/// polygonal representation and can be used for things like seeding
/// streamlines or probing other data sets. Typical usage of the widget is to
/// make use of the StartInteractionEvent, InteractionEvent, and
/// EndInteractionEvent events. The InteractionEvent is called on mouse motion;
/// the other two events are called on button down and button up (either left or
/// right button).
///
/// Some additional features of this class include the ability to control the
/// properties of the widget. You can set the properties of the selected and
/// unselected representations of the broken line. For example, you can set the
/// property for the handles and broken line. In addition there are methods to
/// constrain the broken line so that it is aligned with a plane.  Note that a simple
/// ruler widget can be derived by setting the resolution to 1, the number of
/// handles to 2, and calling the GetSummedLength method!
///
/// @par Thanks:
/// This class was written by Philippe Pebay, Kitware SAS 2012
/// This work was supported by CEA/DIF - Commissariat a l'Energie Atomique,
/// Centre DAM Ile-De-France, BP12, F-91297 Arpajon, France.
///
/// </remarks>
/// <seealso>
///
/// vtk3DWidget vtkBoxWidget vtkLineWidget vtkPointWidget vtkSphereWidget
/// vtkImagePlaneWidget vtkImplicitPlaneWidget vtkPlaneWidget
/// </seealso>
public class vtkBrokenLineWidget : vtk3DWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBrokenLineWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBrokenLineWidget()
	{
		MRClassNameKey = "class vtkBrokenLineWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBrokenLineWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBrokenLineWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBrokenLineWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkBrokenLineWidget New()
	{
		vtkBrokenLineWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBrokenLineWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBrokenLineWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkBrokenLineWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBrokenLineWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBrokenLineWidget_GetHandlePosition_01(HandleRef pThis, int handle, IntPtr xyz);

	/// <summary>
	/// Set/Get the position of the broken line handles. Call GetNumberOfHandles
	/// to determine the valid range of handle indices.
	/// </summary>
	public void GetHandlePosition(int handle, IntPtr xyz)
	{
		vtkBrokenLineWidget_GetHandlePosition_01(GetCppThis(), handle, xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBrokenLineWidget_GetHandlePosition_02(HandleRef pThis, int handle);

	/// <summary>
	/// Set/Get the position of the broken line handles. Call GetNumberOfHandles
	/// to determine the valid range of handle indices.
	/// </summary>
	public IntPtr GetHandlePosition(int handle)
	{
		return vtkBrokenLineWidget_GetHandlePosition_02(GetCppThis(), handle);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBrokenLineWidget_GetHandleProperty_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkBrokenLineWidget_GetHandleProperty_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkBrokenLineWidget_GetHandleSizeFactor_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the size factor to be applied to the handle radii.
	/// Default: 1.
	/// </summary>
	public virtual double GetHandleSizeFactor()
	{
		return vtkBrokenLineWidget_GetHandleSizeFactor_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBrokenLineWidget_GetHandleSizeFactorMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the size factor to be applied to the handle radii.
	/// Default: 1.
	/// </summary>
	public virtual double GetHandleSizeFactorMaxValue()
	{
		return vtkBrokenLineWidget_GetHandleSizeFactorMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBrokenLineWidget_GetHandleSizeFactorMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the size factor to be applied to the handle radii.
	/// Default: 1.
	/// </summary>
	public virtual double GetHandleSizeFactorMinValue()
	{
		return vtkBrokenLineWidget_GetHandleSizeFactorMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBrokenLineWidget_GetLineProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkBrokenLineWidget_GetLineProperty_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkBrokenLineWidget_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBrokenLineWidget_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBrokenLineWidget_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBrokenLineWidget_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBrokenLineWidget_GetNumberOfHandles_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of handles for this widget.
	/// </summary>
	public virtual int GetNumberOfHandles()
	{
		return vtkBrokenLineWidget_GetNumberOfHandles_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_GetPolyData_11(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Grab the polydata (including points) that defines the broken line.  The
	/// polydata consists of points and line segments numbering nHandles
	/// and nHandles - 1, respectively. Points are guaranteed to be up-to-date when
	/// either the InteractionEvent or EndInteraction events are invoked. The
	/// user provides the vtkPolyData and the points and polyline are added to it.
	/// </summary>
	public void GetPolyData(vtkPolyData pd)
	{
		vtkBrokenLineWidget_GetPolyData_11(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBrokenLineWidget_GetProcessEvents_12(HandleRef pThis);

	/// <summary>
	/// Turn on / off event processing for this widget. If off, the widget will
	/// not respond to user interaction
	/// </summary>
	public virtual int GetProcessEvents()
	{
		return vtkBrokenLineWidget_GetProcessEvents_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBrokenLineWidget_GetProcessEventsMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Turn on / off event processing for this widget. If off, the widget will
	/// not respond to user interaction
	/// </summary>
	public virtual int GetProcessEventsMaxValue()
	{
		return vtkBrokenLineWidget_GetProcessEventsMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBrokenLineWidget_GetProcessEventsMinValue_14(HandleRef pThis);

	/// <summary>
	/// Turn on / off event processing for this widget. If off, the widget will
	/// not respond to user interaction
	/// </summary>
	public virtual int GetProcessEventsMinValue()
	{
		return vtkBrokenLineWidget_GetProcessEventsMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBrokenLineWidget_GetProjectToPlane_15(HandleRef pThis);

	/// <summary>
	/// Force the broken line widget to be projected onto one of the orthogonal planes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the broken line to the plane if it is originally
	/// not aligned.  The normal in SetProjectionNormal is 0,1,2 for YZ,XZ,XY
	/// planes respectively and 3 for arbitrary oblique planes when the widget
	/// is tied to a vtkPlaneSource.
	/// </summary>
	public virtual int GetProjectToPlane()
	{
		return vtkBrokenLineWidget_GetProjectToPlane_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBrokenLineWidget_GetProjectionNormal_16(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public virtual int GetProjectionNormal()
	{
		return vtkBrokenLineWidget_GetProjectionNormal_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBrokenLineWidget_GetProjectionNormalMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public virtual int GetProjectionNormalMaxValue()
	{
		return vtkBrokenLineWidget_GetProjectionNormalMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBrokenLineWidget_GetProjectionNormalMinValue_18(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public virtual int GetProjectionNormalMinValue()
	{
		return vtkBrokenLineWidget_GetProjectionNormalMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBrokenLineWidget_GetProjectionPosition_19(HandleRef pThis);

	/// <summary>
	/// Set the position of broken line handles and points in terms of a plane's
	/// position. i.e., if ProjectionNormal is 0, all of the x-coordinate
	/// values of the points are set to position. Any value can be passed (and is
	/// ignored) to update the broken line points when Projection normal is set to 3
	/// for arbitrary plane orientations.
	/// </summary>
	public virtual double GetProjectionPosition()
	{
		return vtkBrokenLineWidget_GetProjectionPosition_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBrokenLineWidget_GetSelectedHandleProperty_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkBrokenLineWidget_GetSelectedHandleProperty_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkBrokenLineWidget_GetSelectedLineProperty_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkBrokenLineWidget_GetSelectedLineProperty_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkBrokenLineWidget_GetSummedLength_22(HandleRef pThis);

	/// <summary>
	/// Get the summed lengths of the individual straight line segments.
	/// </summary>
	public double GetSummedLength()
	{
		return vtkBrokenLineWidget_GetSummedLength_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_InitializeHandles_23(HandleRef pThis, HandleRef points);

	/// <summary>
	/// Convenience method to allocate and set the handles from a vtkPoints
	/// instance.
	/// </summary>
	public void InitializeHandles(vtkPoints points)
	{
		vtkBrokenLineWidget_InitializeHandles_23(GetCppThis(), points?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBrokenLineWidget_IsA_24(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBrokenLineWidget_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBrokenLineWidget_IsTypeOf_25(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBrokenLineWidget_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBrokenLineWidget_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new vtkBrokenLineWidget NewInstance()
	{
		vtkBrokenLineWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBrokenLineWidget_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBrokenLineWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_PlaceWidget_28(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkBrokenLineWidget_PlaceWidget_28(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_PlaceWidget_29(HandleRef pThis);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget()
	{
		vtkBrokenLineWidget_PlaceWidget_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_PlaceWidget_30(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtkBrokenLineWidget_PlaceWidget_30(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_ProcessEventsOff_31(HandleRef pThis);

	/// <summary>
	/// Turn on / off event processing for this widget. If off, the widget will
	/// not respond to user interaction
	/// </summary>
	public virtual void ProcessEventsOff()
	{
		vtkBrokenLineWidget_ProcessEventsOff_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_ProcessEventsOn_32(HandleRef pThis);

	/// <summary>
	/// Turn on / off event processing for this widget. If off, the widget will
	/// not respond to user interaction
	/// </summary>
	public virtual void ProcessEventsOn()
	{
		vtkBrokenLineWidget_ProcessEventsOn_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_ProjectToPlaneOff_33(HandleRef pThis);

	/// <summary>
	/// Force the broken line widget to be projected onto one of the orthogonal planes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the broken line to the plane if it is originally
	/// not aligned.  The normal in SetProjectionNormal is 0,1,2 for YZ,XZ,XY
	/// planes respectively and 3 for arbitrary oblique planes when the widget
	/// is tied to a vtkPlaneSource.
	/// </summary>
	public virtual void ProjectToPlaneOff()
	{
		vtkBrokenLineWidget_ProjectToPlaneOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_ProjectToPlaneOn_34(HandleRef pThis);

	/// <summary>
	/// Force the broken line widget to be projected onto one of the orthogonal planes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the broken line to the plane if it is originally
	/// not aligned.  The normal in SetProjectionNormal is 0,1,2 for YZ,XZ,XY
	/// planes respectively and 3 for arbitrary oblique planes when the widget
	/// is tied to a vtkPlaneSource.
	/// </summary>
	public virtual void ProjectToPlaneOn()
	{
		vtkBrokenLineWidget_ProjectToPlaneOn_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBrokenLineWidget_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkBrokenLineWidget SafeDownCast(vtkObjectBase o)
	{
		vtkBrokenLineWidget vtkBrokenLineWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBrokenLineWidget_SafeDownCast_35(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBrokenLineWidget2 = (vtkBrokenLineWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBrokenLineWidget2.Register(null);
			}
		}
		return vtkBrokenLineWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_SetEnabled_36(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkBrokenLineWidget_SetEnabled_36(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_SetHandlePosition_37(HandleRef pThis, int handle, double x, double y, double z);

	/// <summary>
	/// Set/Get the position of the broken line handles. Call GetNumberOfHandles
	/// to determine the valid range of handle indices.
	/// </summary>
	public void SetHandlePosition(int handle, double x, double y, double z)
	{
		vtkBrokenLineWidget_SetHandlePosition_37(GetCppThis(), handle, x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_SetHandlePosition_38(HandleRef pThis, int handle, IntPtr xyz);

	/// <summary>
	/// Set/Get the position of the broken line handles. Call GetNumberOfHandles
	/// to determine the valid range of handle indices.
	/// </summary>
	public void SetHandlePosition(int handle, IntPtr xyz)
	{
		vtkBrokenLineWidget_SetHandlePosition_38(GetCppThis(), handle, xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_SetHandleProperty_39(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the handle properties (the spheres are the handles). The
	/// properties of the handles when selected and unselected can be manipulated.
	/// </summary>
	public virtual void SetHandleProperty(vtkProperty arg0)
	{
		vtkBrokenLineWidget_SetHandleProperty_39(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_SetHandleSizeFactor_40(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the size factor to be applied to the handle radii.
	/// Default: 1.
	/// </summary>
	public virtual void SetHandleSizeFactor(double _arg)
	{
		vtkBrokenLineWidget_SetHandleSizeFactor_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_SetLineProperty_41(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the line properties. The properties of the line when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual void SetLineProperty(vtkProperty arg0)
	{
		vtkBrokenLineWidget_SetLineProperty_41(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_SetNumberOfHandles_42(HandleRef pThis, int npts);

	/// <summary>
	/// Set/Get the number of handles for this widget.
	/// </summary>
	public virtual void SetNumberOfHandles(int npts)
	{
		vtkBrokenLineWidget_SetNumberOfHandles_42(GetCppThis(), npts);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_SetPlaneSource_43(HandleRef pThis, HandleRef plane);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public void SetPlaneSource(vtkPlaneSource plane)
	{
		vtkBrokenLineWidget_SetPlaneSource_43(GetCppThis(), plane?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_SetProcessEvents_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on / off event processing for this widget. If off, the widget will
	/// not respond to user interaction
	/// </summary>
	public virtual void SetProcessEvents(int _arg)
	{
		vtkBrokenLineWidget_SetProcessEvents_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_SetProjectToPlane_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Force the broken line widget to be projected onto one of the orthogonal planes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the broken line to the plane if it is originally
	/// not aligned.  The normal in SetProjectionNormal is 0,1,2 for YZ,XZ,XY
	/// planes respectively and 3 for arbitrary oblique planes when the widget
	/// is tied to a vtkPlaneSource.
	/// </summary>
	public virtual void SetProjectToPlane(int _arg)
	{
		vtkBrokenLineWidget_SetProjectToPlane_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_SetProjectionNormal_46(HandleRef pThis, int _arg);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public virtual void SetProjectionNormal(int _arg)
	{
		vtkBrokenLineWidget_SetProjectionNormal_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_SetProjectionNormalToOblique_47(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public void SetProjectionNormalToOblique()
	{
		vtkBrokenLineWidget_SetProjectionNormalToOblique_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_SetProjectionNormalToXAxes_48(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public void SetProjectionNormalToXAxes()
	{
		vtkBrokenLineWidget_SetProjectionNormalToXAxes_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_SetProjectionNormalToYAxes_49(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public void SetProjectionNormalToYAxes()
	{
		vtkBrokenLineWidget_SetProjectionNormalToYAxes_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_SetProjectionNormalToZAxes_50(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public void SetProjectionNormalToZAxes()
	{
		vtkBrokenLineWidget_SetProjectionNormalToZAxes_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_SetProjectionPosition_51(HandleRef pThis, double position);

	/// <summary>
	/// Set the position of broken line handles and points in terms of a plane's
	/// position. i.e., if ProjectionNormal is 0, all of the x-coordinate
	/// values of the points are set to position. Any value can be passed (and is
	/// ignored) to update the broken line points when Projection normal is set to 3
	/// for arbitrary plane orientations.
	/// </summary>
	public void SetProjectionPosition(double position)
	{
		vtkBrokenLineWidget_SetProjectionPosition_51(GetCppThis(), position);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_SetSelectedHandleProperty_52(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the handle properties (the spheres are the handles). The
	/// properties of the handles when selected and unselected can be manipulated.
	/// </summary>
	public virtual void SetSelectedHandleProperty(vtkProperty arg0)
	{
		vtkBrokenLineWidget_SetSelectedHandleProperty_52(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrokenLineWidget_SetSelectedLineProperty_53(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the line properties. The properties of the line when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual void SetSelectedLineProperty(vtkProperty arg0)
	{
		vtkBrokenLineWidget_SetSelectedLineProperty_53(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
