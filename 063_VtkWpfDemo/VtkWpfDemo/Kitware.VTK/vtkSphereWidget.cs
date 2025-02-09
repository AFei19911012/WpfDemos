using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSphereWidget
/// </summary>
/// <remarks>
///    3D widget for manipulating a sphere
///
/// This 3D widget defines a sphere that can be interactively placed in a
/// scene.
///
/// To use this object, just invoke SetInteractor() with the argument of the
/// method a vtkRenderWindowInteractor.  You may also wish to invoke
/// "PlaceWidget()" to initially position the widget. The interactor will act
/// normally until the "i" key (for "interactor") is pressed, at which point the
/// vtkSphereWidget will appear. (See superclass documentation for information
/// about changing this behavior.)
/// Events that occur outside of the widget (i.e., no part of
/// the widget is picked) are propagated to any other registered obsevers
/// (such as the interaction style).  Turn off the widget by pressing the "i"
/// key again (or invoke the Off() method).
///
/// The vtkSphereWidget has several methods that can be used in conjunction
/// with other VTK objects. The Set/GetThetaResolution() and
/// Set/GetPhiResolution() methods control the number of subdivisions of the
/// sphere in the theta and phi directions; the GetPolyData() method can be
/// used to get the polygonal representation and can be used for things like
/// seeding streamlines. The GetSphere() method returns a sphere implicit
/// function that can be used for cutting and clipping. Typical usage of the
/// widget is to make use of the StartInteractionEvent, InteractionEvent, and
/// EndInteractionEvent events. The InteractionEvent is called on mouse
/// motion; the other two events are called on button down and button up
/// (any mouse button).
///
/// Some additional features of this class include the ability to control the
/// properties of the widget. You can set the properties of the selected and
/// unselected representations of the sphere.
///
/// </remarks>
/// <seealso>
///
/// vtk3DWidget vtkLineWidget vtkBoxWidget vtkPlaneWidget
/// </seealso>
public class vtkSphereWidget : vtk3DWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSphereWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSphereWidget()
	{
		MRClassNameKey = "class vtkSphereWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphereWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSphereWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkSphereWidget New()
	{
		vtkSphereWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSphereWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkSphereWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSphereWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkSphereWidget_GetCenter_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the center of the sphere.
	/// </summary>
	public double[] GetCenter()
	{
		IntPtr intPtr = vtkSphereWidget_GetCenter_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_GetCenter_02(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Set/Get the center of the sphere.
	/// </summary>
	public void GetCenter(IntPtr xyz)
	{
		vtkSphereWidget_GetCenter_02(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereWidget_GetHandleDirection_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the direction vector of the handle relative to the center of
	/// the sphere. The direction of the handle is from the sphere center to
	/// the handle position.
	/// </summary>
	public virtual double[] GetHandleDirection()
	{
		IntPtr intPtr = vtkSphereWidget_GetHandleDirection_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_GetHandleDirection_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the direction vector of the handle relative to the center of
	/// the sphere. The direction of the handle is from the sphere center to
	/// the handle position.
	/// </summary>
	public virtual void GetHandleDirection(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkSphereWidget_GetHandleDirection_04(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_GetHandleDirection_05(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the direction vector of the handle relative to the center of
	/// the sphere. The direction of the handle is from the sphere center to
	/// the handle position.
	/// </summary>
	public virtual void GetHandleDirection(IntPtr _arg)
	{
		vtkSphereWidget_GetHandleDirection_05(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereWidget_GetHandlePosition_06(HandleRef pThis);

	/// <summary>
	/// Get the position of the handle.
	/// </summary>
	public virtual double[] GetHandlePosition()
	{
		IntPtr intPtr = vtkSphereWidget_GetHandlePosition_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_GetHandlePosition_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get the position of the handle.
	/// </summary>
	public virtual void GetHandlePosition(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkSphereWidget_GetHandlePosition_07(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_GetHandlePosition_08(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the position of the handle.
	/// </summary>
	public virtual void GetHandlePosition(IntPtr _arg)
	{
		vtkSphereWidget_GetHandlePosition_08(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereWidget_GetHandleProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the handle properties (the little ball on the sphere is the
	/// handle). The properties of the handle when selected and unselected
	/// can be manipulated.
	/// </summary>
	public virtual vtkProperty GetHandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereWidget_GetHandleProperty_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkSphereWidget_GetHandleVisibility_10(HandleRef pThis);

	/// <summary>
	/// The handle sits on the surface of the sphere and may be moved around
	/// the surface by picking (left mouse) and then moving. The position
	/// of the handle can be retrieved, this is useful for positioning cameras
	/// and lights. By default, the handle is turned off.
	/// </summary>
	public virtual int GetHandleVisibility()
	{
		return vtkSphereWidget_GetHandleVisibility_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphereWidget_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSphereWidget_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphereWidget_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSphereWidget_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereWidget_GetPhiResolution_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the resolution of the sphere in the Phi direction.
	/// The default is 8.
	/// </summary>
	public int GetPhiResolution()
	{
		return vtkSphereWidget_GetPhiResolution_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_GetPolyData_14(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Grab the polydata (including points) that defines the sphere.  The
	/// polydata consists of n+1 points, where n is the resolution of the
	/// sphere. These point values are guaranteed to be up-to-date when either the
	/// InteractionEvent or EndInteraction events are invoked. The user provides
	/// the vtkPolyData and the points and polysphere are added to it.
	/// </summary>
	public void GetPolyData(vtkPolyData pd)
	{
		vtkSphereWidget_GetPolyData_14(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphereWidget_GetRadius_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the radius of sphere. Default is .5.
	/// </summary>
	public double GetRadius()
	{
		return vtkSphereWidget_GetRadius_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereWidget_GetRepresentation_16(HandleRef pThis);

	/// <summary>
	/// Set the representation of the sphere. Different representations are
	/// useful depending on the application. The default is
	/// VTK_SPHERE_WIREFRAME.
	/// </summary>
	public virtual int GetRepresentation()
	{
		return vtkSphereWidget_GetRepresentation_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereWidget_GetRepresentationMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Set the representation of the sphere. Different representations are
	/// useful depending on the application. The default is
	/// VTK_SPHERE_WIREFRAME.
	/// </summary>
	public virtual int GetRepresentationMaxValue()
	{
		return vtkSphereWidget_GetRepresentationMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereWidget_GetRepresentationMinValue_18(HandleRef pThis);

	/// <summary>
	/// Set the representation of the sphere. Different representations are
	/// useful depending on the application. The default is
	/// VTK_SPHERE_WIREFRAME.
	/// </summary>
	public virtual int GetRepresentationMinValue()
	{
		return vtkSphereWidget_GetRepresentationMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereWidget_GetScale_19(HandleRef pThis);

	/// <summary>
	/// Enable translation and scaling of the widget. By default, the widget
	/// can be translated and rotated.
	/// </summary>
	public virtual int GetScale()
	{
		return vtkSphereWidget_GetScale_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereWidget_GetSelectedHandleProperty_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the handle properties (the little ball on the sphere is the
	/// handle). The properties of the handle when selected and unselected
	/// can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedHandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereWidget_GetSelectedHandleProperty_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkSphereWidget_GetSelectedSphereProperty_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the sphere properties. The properties of the sphere when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedSphereProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereWidget_GetSelectedSphereProperty_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSphereWidget_GetSphere_22(HandleRef pThis, HandleRef sphere);

	/// <summary>
	/// Get the spherical implicit function defined by this widget.  Note that
	/// vtkSphere is a subclass of vtkImplicitFunction, meaning that it can be
	/// used by a variety of filters to perform clipping, cutting, and selection
	/// of data.
	/// </summary>
	public void GetSphere(vtkSphere sphere)
	{
		vtkSphereWidget_GetSphere_22(GetCppThis(), sphere?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereWidget_GetSphereProperty_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the sphere properties. The properties of the sphere when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSphereProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereWidget_GetSphereProperty_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkSphereWidget_GetThetaResolution_24(HandleRef pThis);

	/// <summary>
	/// Set/Get the resolution of the sphere in the Theta direction.
	/// The default is 16.
	/// </summary>
	public int GetThetaResolution()
	{
		return vtkSphereWidget_GetThetaResolution_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereWidget_GetTranslation_25(HandleRef pThis);

	/// <summary>
	/// Enable translation and scaling of the widget. By default, the widget
	/// can be translated and rotated.
	/// </summary>
	public virtual int GetTranslation()
	{
		return vtkSphereWidget_GetTranslation_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_HandleVisibilityOff_26(HandleRef pThis);

	/// <summary>
	/// The handle sits on the surface of the sphere and may be moved around
	/// the surface by picking (left mouse) and then moving. The position
	/// of the handle can be retrieved, this is useful for positioning cameras
	/// and lights. By default, the handle is turned off.
	/// </summary>
	public virtual void HandleVisibilityOff()
	{
		vtkSphereWidget_HandleVisibilityOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_HandleVisibilityOn_27(HandleRef pThis);

	/// <summary>
	/// The handle sits on the surface of the sphere and may be moved around
	/// the surface by picking (left mouse) and then moving. The position
	/// of the handle can be retrieved, this is useful for positioning cameras
	/// and lights. By default, the handle is turned off.
	/// </summary>
	public virtual void HandleVisibilityOn()
	{
		vtkSphereWidget_HandleVisibilityOn_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereWidget_IsA_28(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSphereWidget_IsA_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereWidget_IsTypeOf_29(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSphereWidget_IsTypeOf_29(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereWidget_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new vtkSphereWidget NewInstance()
	{
		vtkSphereWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereWidget_NewInstance_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSphereWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_PlaceWidget_32(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkSphereWidget_PlaceWidget_32(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_PlaceWidget_33(HandleRef pThis);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget()
	{
		vtkSphereWidget_PlaceWidget_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_PlaceWidget_34(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtkSphereWidget_PlaceWidget_34(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereWidget_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkSphereWidget SafeDownCast(vtkObjectBase o)
	{
		vtkSphereWidget vtkSphereWidget3 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereWidget_SafeDownCast_35(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSphereWidget3 = (vtkSphereWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSphereWidget3.Register(null);
			}
		}
		return vtkSphereWidget3;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_ScaleOff_36(HandleRef pThis);

	/// <summary>
	/// Enable translation and scaling of the widget. By default, the widget
	/// can be translated and rotated.
	/// </summary>
	public virtual void ScaleOff()
	{
		vtkSphereWidget_ScaleOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_ScaleOn_37(HandleRef pThis);

	/// <summary>
	/// Enable translation and scaling of the widget. By default, the widget
	/// can be translated and rotated.
	/// </summary>
	public virtual void ScaleOn()
	{
		vtkSphereWidget_ScaleOn_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_SetCenter_38(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the center of the sphere.
	/// </summary>
	public void SetCenter(double x, double y, double z)
	{
		vtkSphereWidget_SetCenter_38(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_SetCenter_39(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Set/Get the center of the sphere.
	/// </summary>
	public void SetCenter(IntPtr x)
	{
		vtkSphereWidget_SetCenter_39(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_SetEnabled_40(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkSphereWidget_SetEnabled_40(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_SetHandleDirection_41(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the direction vector of the handle relative to the center of
	/// the sphere. The direction of the handle is from the sphere center to
	/// the handle position.
	/// </summary>
	public virtual void SetHandleDirection(double _arg1, double _arg2, double _arg3)
	{
		vtkSphereWidget_SetHandleDirection_41(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_SetHandleDirection_42(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the direction vector of the handle relative to the center of
	/// the sphere. The direction of the handle is from the sphere center to
	/// the handle position.
	/// </summary>
	public virtual void SetHandleDirection(IntPtr _arg)
	{
		vtkSphereWidget_SetHandleDirection_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_SetHandleVisibility_43(HandleRef pThis, int _arg);

	/// <summary>
	/// The handle sits on the surface of the sphere and may be moved around
	/// the surface by picking (left mouse) and then moving. The position
	/// of the handle can be retrieved, this is useful for positioning cameras
	/// and lights. By default, the handle is turned off.
	/// </summary>
	public virtual void SetHandleVisibility(int _arg)
	{
		vtkSphereWidget_SetHandleVisibility_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_SetPhiResolution_44(HandleRef pThis, int r);

	/// <summary>
	/// Set/Get the resolution of the sphere in the Phi direction.
	/// The default is 8.
	/// </summary>
	public void SetPhiResolution(int r)
	{
		vtkSphereWidget_SetPhiResolution_44(GetCppThis(), r);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_SetRadius_45(HandleRef pThis, double r);

	/// <summary>
	/// Set/Get the radius of sphere. Default is .5.
	/// </summary>
	public void SetRadius(double r)
	{
		vtkSphereWidget_SetRadius_45(GetCppThis(), r);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_SetRepresentation_46(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the representation of the sphere. Different representations are
	/// useful depending on the application. The default is
	/// VTK_SPHERE_WIREFRAME.
	/// </summary>
	public virtual void SetRepresentation(int _arg)
	{
		vtkSphereWidget_SetRepresentation_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_SetRepresentationToOff_47(HandleRef pThis);

	/// <summary>
	/// Set the representation of the sphere. Different representations are
	/// useful depending on the application. The default is
	/// VTK_SPHERE_WIREFRAME.
	/// </summary>
	public void SetRepresentationToOff()
	{
		vtkSphereWidget_SetRepresentationToOff_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_SetRepresentationToSurface_48(HandleRef pThis);

	/// <summary>
	/// Set the representation of the sphere. Different representations are
	/// useful depending on the application. The default is
	/// VTK_SPHERE_WIREFRAME.
	/// </summary>
	public void SetRepresentationToSurface()
	{
		vtkSphereWidget_SetRepresentationToSurface_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_SetRepresentationToWireframe_49(HandleRef pThis);

	/// <summary>
	/// Set the representation of the sphere. Different representations are
	/// useful depending on the application. The default is
	/// VTK_SPHERE_WIREFRAME.
	/// </summary>
	public void SetRepresentationToWireframe()
	{
		vtkSphereWidget_SetRepresentationToWireframe_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_SetScale_50(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable translation and scaling of the widget. By default, the widget
	/// can be translated and rotated.
	/// </summary>
	public virtual void SetScale(int _arg)
	{
		vtkSphereWidget_SetScale_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_SetThetaResolution_51(HandleRef pThis, int r);

	/// <summary>
	/// Set/Get the resolution of the sphere in the Theta direction.
	/// The default is 16.
	/// </summary>
	public void SetThetaResolution(int r)
	{
		vtkSphereWidget_SetThetaResolution_51(GetCppThis(), r);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_SetTranslation_52(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable translation and scaling of the widget. By default, the widget
	/// can be translated and rotated.
	/// </summary>
	public virtual void SetTranslation(int _arg)
	{
		vtkSphereWidget_SetTranslation_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_TranslationOff_53(HandleRef pThis);

	/// <summary>
	/// Enable translation and scaling of the widget. By default, the widget
	/// can be translated and rotated.
	/// </summary>
	public virtual void TranslationOff()
	{
		vtkSphereWidget_TranslationOff_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereWidget_TranslationOn_54(HandleRef pThis);

	/// <summary>
	/// Enable translation and scaling of the widget. By default, the widget
	/// can be translated and rotated.
	/// </summary>
	public virtual void TranslationOn()
	{
		vtkSphereWidget_TranslationOn_54(GetCppThis());
	}
}
