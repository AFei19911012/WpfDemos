using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlaneWidget
/// </summary>
/// <remarks>
///    3D widget for manipulating a finite plane
///
/// This 3D widget defines a finite (bounded) plane that can be interactively
/// placed in a scene. The plane has four handles (at its corner vertices), a
/// normal vector, and the plane itself. The handles are used to resize the
/// plane; the normal vector to rotate it, and the plane can be picked and
/// translated. Selecting the plane while pressing CTRL makes it spin around
/// the normal. A nice feature of the object is that the vtkPlaneWidget, like
/// any 3D widget, will work with the current interactor style. That is, if
/// vtkPlaneWidget does not handle an event, then all other registered
/// observers (including the interactor style) have an opportunity to process
/// the event. Otherwise, the vtkPlaneWidget will terminate the processing of
/// the event that it handles.
///
/// To use this object, just invoke SetInteractor() with the argument of the
/// method a vtkRenderWindowInteractor.  You may also wish to invoke
/// "PlaceWidget()" to initially position the widget. If the "i" key (for
/// "interactor") is pressed, the vtkPlaneWidget will appear. (See superclass
/// documentation for information about changing this behavior.) By grabbing
/// the one of the four handles (use the left mouse button), the plane can be
/// resized.  By grabbing the plane itself, the entire plane can be
/// arbitrarily translated. Pressing CTRL while grabbing the plane will spin
/// the plane around the normal. If you select the normal vector, the plane can be
/// arbitrarily rotated. Selecting any part of the widget with the middle
/// mouse button enables translation of the plane along its normal. (Once
/// selected using middle mouse, moving the mouse in the direction of the
/// normal translates the plane in the direction of the normal; moving in the
/// direction opposite the normal translates the plane in the direction
/// opposite the normal.) Scaling (about the center of the plane) is achieved
/// by using the right mouse button. By moving the mouse "up" the render
/// window the plane will be made bigger; by moving "down" the render window
/// the widget will be made smaller. Events that occur outside of the widget
/// (i.e., no part of the widget is picked) are propagated to any other
/// registered obsevers (such as the interaction style).  Turn off the widget
/// by pressing the "i" key again (or invoke the Off() method).
///
/// The vtkPlaneWidget has several methods that can be used in conjunction
/// with other VTK objects. The Set/GetResolution() methods control the number
/// of subdivisions of the plane; the GetPolyData() method can be used to get
/// the polygonal representation and can be used for things like seeding
/// stream lines. GetPlane() can be used to update a vtkPlane implicit
/// function. Typical usage of the widget is to make use of the
/// StartInteractionEvent, InteractionEvent, and EndInteractionEvent
/// events. The InteractionEvent is called on mouse motion; the other two
/// events are called on button down and button up (either left or right
/// button).
///
/// Some additional features of this class include the ability to control the
/// properties of the widget. You can set the properties of the selected and
/// unselected representations of the plane. For example, you can set the
/// property for the handles and plane. In addition there are methods to
/// constrain the plane so that it is perpendicular to the x-y-z axes.
///
/// </remarks>
/// <seealso>
///
/// vtk3DWidget vtkBoxWidget vtkLineWidget vtkSphereWidget
/// vtkImplicitPlaneWidget
/// </seealso>
public class vtkPlaneWidget : vtkPolyDataSourceWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlaneWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlaneWidget()
	{
		MRClassNameKey = "class vtkPlaneWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlaneWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlaneWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkPlaneWidget New()
	{
		vtkPlaneWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlaneWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkPlaneWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPlaneWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPlaneWidget_GetCenter_01(HandleRef pThis);

	/// <summary>
	/// Get the center of the plane.
	/// </summary>
	public double[] GetCenter()
	{
		IntPtr intPtr = vtkPlaneWidget_GetCenter_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_GetCenter_02(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Get the center of the plane.
	/// </summary>
	public void GetCenter(IntPtr xyz)
	{
		vtkPlaneWidget_GetCenter_02(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneWidget_GetHandleProperty_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the handle properties (the little balls are the handles). The
	/// properties of the handles when selected and normal can be
	/// manipulated.
	/// </summary>
	public virtual vtkProperty GetHandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlaneWidget_GetHandleProperty_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPlaneWidget_GetNormal_04(HandleRef pThis);

	/// <summary>
	/// Get the normal to the plane.
	/// </summary>
	public double[] GetNormal()
	{
		IntPtr intPtr = vtkPlaneWidget_GetNormal_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_GetNormal_05(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Get the normal to the plane.
	/// </summary>
	public void GetNormal(IntPtr xyz)
	{
		vtkPlaneWidget_GetNormal_05(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaneWidget_GetNormalToXAxis_06(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual int GetNormalToXAxis()
	{
		return vtkPlaneWidget_GetNormalToXAxis_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaneWidget_GetNormalToYAxis_07(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual int GetNormalToYAxis()
	{
		return vtkPlaneWidget_GetNormalToYAxis_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaneWidget_GetNormalToZAxis_08(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual int GetNormalToZAxis()
	{
		return vtkPlaneWidget_GetNormalToZAxis_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlaneWidget_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlaneWidget_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlaneWidget_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlaneWidget_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneWidget_GetOrigin_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the origin of the plane.
	/// </summary>
	public double[] GetOrigin()
	{
		IntPtr intPtr = vtkPlaneWidget_GetOrigin_11(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_GetOrigin_12(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Set/Get the origin of the plane.
	/// </summary>
	public void GetOrigin(IntPtr xyz)
	{
		vtkPlaneWidget_GetOrigin_12(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_GetPlane_13(HandleRef pThis, HandleRef plane);

	/// <summary>
	/// Get the planes describing the implicit function defined by the plane
	/// widget. The user must provide the instance of the class vtkPlane. Note
	/// that vtkPlane is a subclass of vtkImplicitFunction, meaning that it can
	/// be used by a variety of filters to perform clipping, cutting, and
	/// selection of data.
	/// </summary>
	public void GetPlane(vtkPlane plane)
	{
		vtkPlaneWidget_GetPlane_13(GetCppThis(), plane?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneWidget_GetPlaneProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the plane properties. The properties of the plane when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetPlaneProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlaneWidget_GetPlaneProperty_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPlaneWidget_GetPoint1_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of the point defining the first axis of the plane.
	/// </summary>
	public double[] GetPoint1()
	{
		IntPtr intPtr = vtkPlaneWidget_GetPoint1_15(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_GetPoint1_16(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Set/Get the position of the point defining the first axis of the plane.
	/// </summary>
	public void GetPoint1(IntPtr xyz)
	{
		vtkPlaneWidget_GetPoint1_16(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneWidget_GetPoint2_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of the point defining the second axis of the plane.
	/// </summary>
	public double[] GetPoint2()
	{
		IntPtr intPtr = vtkPlaneWidget_GetPoint2_17(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_GetPoint2_18(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Set/Get the position of the point defining the second axis of the plane.
	/// </summary>
	public void GetPoint2(IntPtr xyz)
	{
		vtkPlaneWidget_GetPoint2_18(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_GetPolyData_19(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Grab the polydata (including points) that defines the plane.  The
	/// polydata consists of (res+1)*(res+1) points, and res*res quadrilateral
	/// polygons, where res is the resolution of the plane. These point values
	/// are guaranteed to be up-to-date when either the InteractionEvent or
	/// EndInteraction events are invoked. The user provides the vtkPolyData and
	/// the points and polyplane are added to it.
	/// </summary>
	public void GetPolyData(vtkPolyData pd)
	{
		vtkPlaneWidget_GetPolyData_19(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneWidget_GetPolyDataAlgorithm_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Satisfies superclass API.  This returns a pointer to the underlying
	/// PolyData.  Make changes to this before calling the initial PlaceWidget()
	/// to have the initial placement follow suit.  Or, make changes after the
	/// widget has been initialised and call UpdatePlacement() to realise.
	/// </summary>
	public override vtkPolyDataAlgorithm GetPolyDataAlgorithm()
	{
		vtkPolyDataAlgorithm vtkPolyDataAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlaneWidget_GetPolyDataAlgorithm_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataAlgorithm2 = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataAlgorithm2.Register(null);
			}
		}
		return vtkPolyDataAlgorithm2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaneWidget_GetRepresentation_21(HandleRef pThis);

	/// <summary>
	/// Control how the plane appears when GetPolyData() is invoked.
	/// If the mode is "outline", then just the outline of the plane
	/// is shown. If the mode is "wireframe" then the plane is drawn
	/// with the outline plus the interior mesh (corresponding to the
	/// resolution specified). If the mode is "surface" then the plane
	/// is drawn as a surface.
	/// </summary>
	public virtual int GetRepresentation()
	{
		return vtkPlaneWidget_GetRepresentation_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaneWidget_GetRepresentationMaxValue_22(HandleRef pThis);

	/// <summary>
	/// Control how the plane appears when GetPolyData() is invoked.
	/// If the mode is "outline", then just the outline of the plane
	/// is shown. If the mode is "wireframe" then the plane is drawn
	/// with the outline plus the interior mesh (corresponding to the
	/// resolution specified). If the mode is "surface" then the plane
	/// is drawn as a surface.
	/// </summary>
	public virtual int GetRepresentationMaxValue()
	{
		return vtkPlaneWidget_GetRepresentationMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaneWidget_GetRepresentationMinValue_23(HandleRef pThis);

	/// <summary>
	/// Control how the plane appears when GetPolyData() is invoked.
	/// If the mode is "outline", then just the outline of the plane
	/// is shown. If the mode is "wireframe" then the plane is drawn
	/// with the outline plus the interior mesh (corresponding to the
	/// resolution specified). If the mode is "surface" then the plane
	/// is drawn as a surface.
	/// </summary>
	public virtual int GetRepresentationMinValue()
	{
		return vtkPlaneWidget_GetRepresentationMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaneWidget_GetResolution_24(HandleRef pThis);

	/// <summary>
	/// Set/Get the resolution (number of subdivisions) of the plane.
	/// </summary>
	public int GetResolution()
	{
		return vtkPlaneWidget_GetResolution_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneWidget_GetSelectedHandleProperty_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the handle properties (the little balls are the handles). The
	/// properties of the handles when selected and normal can be
	/// manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedHandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlaneWidget_GetSelectedHandleProperty_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPlaneWidget_GetSelectedPlaneProperty_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the plane properties. The properties of the plane when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedPlaneProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlaneWidget_GetSelectedPlaneProperty_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPlaneWidget_IsA_27(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlaneWidget_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaneWidget_IsTypeOf_28(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlaneWidget_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneWidget_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new vtkPlaneWidget NewInstance()
	{
		vtkPlaneWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlaneWidget_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_NormalToXAxisOff_31(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToXAxisOff()
	{
		vtkPlaneWidget_NormalToXAxisOff_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_NormalToXAxisOn_32(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToXAxisOn()
	{
		vtkPlaneWidget_NormalToXAxisOn_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_NormalToYAxisOff_33(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToYAxisOff()
	{
		vtkPlaneWidget_NormalToYAxisOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_NormalToYAxisOn_34(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToYAxisOn()
	{
		vtkPlaneWidget_NormalToYAxisOn_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_NormalToZAxisOff_35(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToZAxisOff()
	{
		vtkPlaneWidget_NormalToZAxisOff_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_NormalToZAxisOn_36(HandleRef pThis);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void NormalToZAxisOn()
	{
		vtkPlaneWidget_NormalToZAxisOn_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_PlaceWidget_37(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkPlaneWidget_PlaceWidget_37(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_PlaceWidget_38(HandleRef pThis);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget()
	{
		vtkPlaneWidget_PlaceWidget_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_PlaceWidget_39(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtkPlaneWidget_PlaceWidget_39(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneWidget_SafeDownCast_40(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkPlaneWidget SafeDownCast(vtkObjectBase o)
	{
		vtkPlaneWidget vtkPlaneWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlaneWidget_SafeDownCast_40(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlaneWidget2 = (vtkPlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlaneWidget2.Register(null);
			}
		}
		return vtkPlaneWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetCenter_41(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Get the center of the plane.
	/// </summary>
	public void SetCenter(double x, double y, double z)
	{
		vtkPlaneWidget_SetCenter_41(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetCenter_42(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Get the center of the plane.
	/// </summary>
	public void SetCenter(IntPtr x)
	{
		vtkPlaneWidget_SetCenter_42(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetEnabled_43(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkPlaneWidget_SetEnabled_43(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetNormal_44(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Get the normal to the plane.
	/// </summary>
	public void SetNormal(double x, double y, double z)
	{
		vtkPlaneWidget_SetNormal_44(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetNormal_45(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Get the normal to the plane.
	/// </summary>
	public void SetNormal(IntPtr x)
	{
		vtkPlaneWidget_SetNormal_45(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetNormalToXAxis_46(HandleRef pThis, int _arg);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void SetNormalToXAxis(int _arg)
	{
		vtkPlaneWidget_SetNormalToXAxis_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetNormalToYAxis_47(HandleRef pThis, int _arg);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void SetNormalToYAxis(int _arg)
	{
		vtkPlaneWidget_SetNormalToYAxis_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetNormalToZAxis_48(HandleRef pThis, int _arg);

	/// <summary>
	/// Force the plane widget to be aligned with one of the x-y-z axes.
	/// Remember that when the state changes, a ModifiedEvent is invoked.
	/// This can be used to snap the plane to the axes if it is originally
	/// not aligned.
	/// </summary>
	public virtual void SetNormalToZAxis(int _arg)
	{
		vtkPlaneWidget_SetNormalToZAxis_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetOrigin_49(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the origin of the plane.
	/// </summary>
	public void SetOrigin(double x, double y, double z)
	{
		vtkPlaneWidget_SetOrigin_49(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetOrigin_50(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Set/Get the origin of the plane.
	/// </summary>
	public void SetOrigin(IntPtr x)
	{
		vtkPlaneWidget_SetOrigin_50(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetPlaneProperty_51(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get the plane properties. The properties of the plane when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual void SetPlaneProperty(vtkProperty arg0)
	{
		vtkPlaneWidget_SetPlaneProperty_51(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetPoint1_52(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the position of the point defining the first axis of the plane.
	/// </summary>
	public void SetPoint1(double x, double y, double z)
	{
		vtkPlaneWidget_SetPoint1_52(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetPoint1_53(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Set/Get the position of the point defining the first axis of the plane.
	/// </summary>
	public void SetPoint1(IntPtr x)
	{
		vtkPlaneWidget_SetPoint1_53(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetPoint2_54(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the position of the point defining the second axis of the plane.
	/// </summary>
	public void SetPoint2(double x, double y, double z)
	{
		vtkPlaneWidget_SetPoint2_54(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetPoint2_55(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Set/Get the position of the point defining the second axis of the plane.
	/// </summary>
	public void SetPoint2(IntPtr x)
	{
		vtkPlaneWidget_SetPoint2_55(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetRepresentation_56(HandleRef pThis, int _arg);

	/// <summary>
	/// Control how the plane appears when GetPolyData() is invoked.
	/// If the mode is "outline", then just the outline of the plane
	/// is shown. If the mode is "wireframe" then the plane is drawn
	/// with the outline plus the interior mesh (corresponding to the
	/// resolution specified). If the mode is "surface" then the plane
	/// is drawn as a surface.
	/// </summary>
	public virtual void SetRepresentation(int _arg)
	{
		vtkPlaneWidget_SetRepresentation_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetRepresentationToOff_57(HandleRef pThis);

	/// <summary>
	/// Control how the plane appears when GetPolyData() is invoked.
	/// If the mode is "outline", then just the outline of the plane
	/// is shown. If the mode is "wireframe" then the plane is drawn
	/// with the outline plus the interior mesh (corresponding to the
	/// resolution specified). If the mode is "surface" then the plane
	/// is drawn as a surface.
	/// </summary>
	public void SetRepresentationToOff()
	{
		vtkPlaneWidget_SetRepresentationToOff_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetRepresentationToOutline_58(HandleRef pThis);

	/// <summary>
	/// Control how the plane appears when GetPolyData() is invoked.
	/// If the mode is "outline", then just the outline of the plane
	/// is shown. If the mode is "wireframe" then the plane is drawn
	/// with the outline plus the interior mesh (corresponding to the
	/// resolution specified). If the mode is "surface" then the plane
	/// is drawn as a surface.
	/// </summary>
	public void SetRepresentationToOutline()
	{
		vtkPlaneWidget_SetRepresentationToOutline_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetRepresentationToSurface_59(HandleRef pThis);

	/// <summary>
	/// Control how the plane appears when GetPolyData() is invoked.
	/// If the mode is "outline", then just the outline of the plane
	/// is shown. If the mode is "wireframe" then the plane is drawn
	/// with the outline plus the interior mesh (corresponding to the
	/// resolution specified). If the mode is "surface" then the plane
	/// is drawn as a surface.
	/// </summary>
	public void SetRepresentationToSurface()
	{
		vtkPlaneWidget_SetRepresentationToSurface_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetRepresentationToWireframe_60(HandleRef pThis);

	/// <summary>
	/// Control how the plane appears when GetPolyData() is invoked.
	/// If the mode is "outline", then just the outline of the plane
	/// is shown. If the mode is "wireframe" then the plane is drawn
	/// with the outline plus the interior mesh (corresponding to the
	/// resolution specified). If the mode is "surface" then the plane
	/// is drawn as a surface.
	/// </summary>
	public void SetRepresentationToWireframe()
	{
		vtkPlaneWidget_SetRepresentationToWireframe_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_SetResolution_61(HandleRef pThis, int r);

	/// <summary>
	/// Set/Get the resolution (number of subdivisions) of the plane.
	/// </summary>
	public void SetResolution(int r)
	{
		vtkPlaneWidget_SetResolution_61(GetCppThis(), r);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneWidget_UpdatePlacement_62(HandleRef pThis);

	/// <summary>
	/// Satisfies superclass API.  This will change the state of the widget to
	/// match changes that have been made to the underlying PolyDataSource
	/// </summary>
	public override void UpdatePlacement()
	{
		vtkPlaneWidget_UpdatePlacement_62(GetCppThis());
	}
}
