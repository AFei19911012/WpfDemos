using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSphereRepresentation
/// </summary>
/// <remarks>
///    a class defining the representation for the vtkSphereWidget2
///
/// This class is a concrete representation for the vtkSphereWidget2. It
/// represents a sphere with an optional handle.  Through interaction with the
/// widget, the sphere can be arbitrarily positioned and scaled in 3D space;
/// and the handle can be moved on the surface of the sphere. Typically the
/// vtkSphereWidget2/vtkSphereRepresentation are used to position a sphere for
/// the purpose of extracting, cutting or clipping data; or the handle is
/// moved on the sphere to position a light or camera.
///
/// To use this representation, you normally use the PlaceWidget() method
/// to position the widget at a specified region in space. It is also possible
/// to set the center of the sphere, a radius, and/or a handle position.
///
/// @warning
/// Note that the representation is overconstrained in that the center and radius
/// of the sphere can be defined, this information plus the handle direction defines
/// the geometry of the representation. Alternatively, the user may specify the center
/// of the sphere plus the handle position.
///
/// @warning
/// This class, and vtkSphereWidget2, are second generation VTK widgets. An
/// earlier version of this functionality was defined in the class
/// vtkSphereWidget.
///
/// </remarks>
/// <seealso>
///
/// vtkSphereWidget2 vtkSphereWidget
/// </seealso>
public class vtkSphereRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Standard methods for type information and to print out the contents of the class.
	/// </summary>
	public enum MovingHandle_WrapperEnum
	{
		/// <summary>enum member</summary>
		MovingHandle = 1,
		/// <summary>enum member</summary>
		OnSphere = 2,
		/// <summary>enum member</summary>
		Outside = 0,
		/// <summary>enum member</summary>
		Scaling = 4,
		/// <summary>enum member</summary>
		Translating = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSphereRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSphereRepresentation()
	{
		MRClassNameKey = "class vtkSphereRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphereRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSphereRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkSphereRepresentation New()
	{
		vtkSphereRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSphereRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkSphereRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSphereRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSphereRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API. Note that a
	/// version of place widget is available where the center and handle position
	/// are specified.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkSphereRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_CenterCursorOff_02(HandleRef pThis);

	/// <summary>
	/// Enable/disable a center cursor
	/// Default is disabled
	/// </summary>
	public virtual void CenterCursorOff()
	{
		vtkSphereRepresentation_CenterCursorOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_CenterCursorOn_03(HandleRef pThis);

	/// <summary>
	/// Enable/disable a center cursor
	/// Default is disabled
	/// </summary>
	public virtual void CenterCursorOn()
	{
		vtkSphereRepresentation_CenterCursorOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereRepresentation_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API. Note that a
	/// version of place widget is available where the center and handle position
	/// are specified.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkSphereRepresentation_ComputeInteractionState_04(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereRepresentation_GetBounds_05(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API. Note that a
	/// version of place widget is available where the center and handle position
	/// are specified.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkSphereRepresentation_GetBounds_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereRepresentation_GetCenter_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the center position of the sphere. Note that this may
	/// adjust the direction from the handle to the center, as well as
	/// the radius of the sphere.
	/// </summary>
	public double[] GetCenter()
	{
		IntPtr intPtr = vtkSphereRepresentation_GetCenter_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_GetCenter_07(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Set/Get the center position of the sphere. Note that this may
	/// adjust the direction from the handle to the center, as well as
	/// the radius of the sphere.
	/// </summary>
	public void GetCenter(IntPtr xyz)
	{
		vtkSphereRepresentation_GetCenter_07(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSphereRepresentation_GetCenterCursor_08(HandleRef pThis);

	/// <summary>
	/// Enable/disable a center cursor
	/// Default is disabled
	/// </summary>
	public virtual bool GetCenterCursor()
	{
		return (vtkSphereRepresentation_GetCenterCursor_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereRepresentation_GetHandleDirection_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the direction vector of the handle relative to the center of
	/// the sphere. Setting the direction may affect the position of the handle
	/// but will not affect the radius or position of the sphere.
	/// </summary>
	public virtual double[] GetHandleDirection()
	{
		IntPtr intPtr = vtkSphereRepresentation_GetHandleDirection_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_GetHandleDirection_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the direction vector of the handle relative to the center of
	/// the sphere. Setting the direction may affect the position of the handle
	/// but will not affect the radius or position of the sphere.
	/// </summary>
	public virtual void GetHandleDirection(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkSphereRepresentation_GetHandleDirection_10(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_GetHandleDirection_11(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the direction vector of the handle relative to the center of
	/// the sphere. Setting the direction may affect the position of the handle
	/// but will not affect the radius or position of the sphere.
	/// </summary>
	public virtual void GetHandleDirection(IntPtr _arg)
	{
		vtkSphereRepresentation_GetHandleDirection_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereRepresentation_GetHandlePosition_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of the handle. Note that this may adjust the radius
	/// of the sphere and the handle direction.
	/// </summary>
	public virtual double[] GetHandlePosition()
	{
		IntPtr intPtr = vtkSphereRepresentation_GetHandlePosition_12(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_GetHandlePosition_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the position of the handle. Note that this may adjust the radius
	/// of the sphere and the handle direction.
	/// </summary>
	public virtual void GetHandlePosition(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkSphereRepresentation_GetHandlePosition_13(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_GetHandlePosition_14(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the position of the handle. Note that this may adjust the radius
	/// of the sphere and the handle direction.
	/// </summary>
	public virtual void GetHandlePosition(IntPtr _arg)
	{
		vtkSphereRepresentation_GetHandlePosition_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereRepresentation_GetHandleProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkSphereRepresentation_GetHandleProperty_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkSphereRepresentation_GetHandleText_16(HandleRef pThis);

	/// <summary>
	/// Enable/disable a label that displays the location of the handle in
	/// spherical coordinates (radius,theta,phi). The two angles, theta and
	/// phi, are displayed in degrees. Note that phi is measured from the
	/// north pole down towards the equator; and theta is the angle around
	/// the north/south axis.
	/// </summary>
	public virtual int GetHandleText()
	{
		return vtkSphereRepresentation_GetHandleText_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereRepresentation_GetHandleTextProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the handle text property. This can be used to control the appearance
	/// of the handle text.
	/// </summary>
	public virtual vtkTextProperty GetHandleTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereRepresentation_GetHandleTextProperty_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextProperty2 = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextProperty2.Register(null);
			}
		}
		return vtkTextProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereRepresentation_GetHandleVisibility_18(HandleRef pThis);

	/// <summary>
	/// The handle sits on the surface of the sphere and may be moved around
	/// the surface by picking (left mouse) and then moving. The position
	/// of the handle can be retrieved, this is useful for positioning cameras
	/// and lights. By default, the handle is turned off.
	/// </summary>
	public virtual int GetHandleVisibility()
	{
		return vtkSphereRepresentation_GetHandleVisibility_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphereRepresentation_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and to print out the contents of the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSphereRepresentation_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphereRepresentation_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	/// Standard methods for type information and to print out the contents of the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSphereRepresentation_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereRepresentation_GetPhiResolution_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the resolution of the sphere in the phi direction.
	/// </summary>
	public int GetPhiResolution()
	{
		return vtkSphereRepresentation_GetPhiResolution_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_GetPolyData_22(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Grab the polydata (including points) that defines the sphere.  The
	/// polydata consists of n+1 points, where n is the resolution of the
	/// sphere. These point values are guaranteed to be up-to-date when either the
	/// InteractionEvent or EndInteraction events are invoked. The user provides
	/// the vtkPolyData and the points and polysphere are added to it.
	/// </summary>
	public void GetPolyData(vtkPolyData pd)
	{
		vtkSphereRepresentation_GetPolyData_22(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereRepresentation_GetRadialLine_23(HandleRef pThis);

	/// <summary>
	/// Enable/disable a radial line segment that joins the center of the
	/// outer sphere and the handle.
	/// </summary>
	public virtual int GetRadialLine()
	{
		return vtkSphereRepresentation_GetRadialLine_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereRepresentation_GetRadialLineProperty_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the property of the radial line. This can be used to control the
	/// appearance of the optional line connecting the center to the handle.
	/// </summary>
	public virtual vtkProperty GetRadialLineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereRepresentation_GetRadialLineProperty_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkSphereRepresentation_GetRadius_25(HandleRef pThis);

	/// <summary>
	/// Set/Get the radius of sphere. Default is 0.5. Note that this may
	/// modify the position of the handle based on the handle direction.
	/// </summary>
	public double GetRadius()
	{
		return vtkSphereRepresentation_GetRadius_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereRepresentation_GetRepresentation_26(HandleRef pThis);

	/// <summary>
	/// Set the representation (i.e., appearance) of the sphere. Different
	/// representations are useful depending on the application.
	/// </summary>
	public virtual int GetRepresentation()
	{
		return vtkSphereRepresentation_GetRepresentation_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereRepresentation_GetRepresentationMaxValue_27(HandleRef pThis);

	/// <summary>
	/// Set the representation (i.e., appearance) of the sphere. Different
	/// representations are useful depending on the application.
	/// </summary>
	public virtual int GetRepresentationMaxValue()
	{
		return vtkSphereRepresentation_GetRepresentationMaxValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereRepresentation_GetRepresentationMinValue_28(HandleRef pThis);

	/// <summary>
	/// Set the representation (i.e., appearance) of the sphere. Different
	/// representations are useful depending on the application.
	/// </summary>
	public virtual int GetRepresentationMinValue()
	{
		return vtkSphereRepresentation_GetRepresentationMinValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereRepresentation_GetSelectedHandleProperty_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkSphereRepresentation_GetSelectedHandleProperty_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkSphereRepresentation_GetSelectedSphereProperty_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkSphereRepresentation_GetSelectedSphereProperty_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSphereRepresentation_GetSphere_31(HandleRef pThis, HandleRef sphere);

	/// <summary>
	/// Get the spherical implicit function defined by this widget.  Note that
	/// vtkSphere is a subclass of vtkImplicitFunction, meaning that it can be
	/// used by a variety of filters to perform clipping, cutting, and selection
	/// of data.
	/// </summary>
	public void GetSphere(vtkSphere sphere)
	{
		vtkSphereRepresentation_GetSphere_31(GetCppThis(), sphere?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereRepresentation_GetSphereProperty_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkSphereRepresentation_GetSphereProperty_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkSphereRepresentation_GetThetaResolution_33(HandleRef pThis);

	/// <summary>
	/// Set/Get the resolution of the sphere in the theta direction.
	/// </summary>
	public int GetThetaResolution()
	{
		return vtkSphereRepresentation_GetThetaResolution_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereRepresentation_GetTranslationAxis_34(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual int GetTranslationAxis()
	{
		return vtkSphereRepresentation_GetTranslationAxis_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereRepresentation_GetTranslationAxisMaxValue_35(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual int GetTranslationAxisMaxValue()
	{
		return vtkSphereRepresentation_GetTranslationAxisMaxValue_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereRepresentation_GetTranslationAxisMinValue_36(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual int GetTranslationAxisMinValue()
	{
		return vtkSphereRepresentation_GetTranslationAxisMinValue_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_HandleTextOff_37(HandleRef pThis);

	/// <summary>
	/// Enable/disable a label that displays the location of the handle in
	/// spherical coordinates (radius,theta,phi). The two angles, theta and
	/// phi, are displayed in degrees. Note that phi is measured from the
	/// north pole down towards the equator; and theta is the angle around
	/// the north/south axis.
	/// </summary>
	public virtual void HandleTextOff()
	{
		vtkSphereRepresentation_HandleTextOff_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_HandleTextOn_38(HandleRef pThis);

	/// <summary>
	/// Enable/disable a label that displays the location of the handle in
	/// spherical coordinates (radius,theta,phi). The two angles, theta and
	/// phi, are displayed in degrees. Note that phi is measured from the
	/// north pole down towards the equator; and theta is the angle around
	/// the north/south axis.
	/// </summary>
	public virtual void HandleTextOn()
	{
		vtkSphereRepresentation_HandleTextOn_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_HandleVisibilityOff_39(HandleRef pThis);

	/// <summary>
	/// The handle sits on the surface of the sphere and may be moved around
	/// the surface by picking (left mouse) and then moving. The position
	/// of the handle can be retrieved, this is useful for positioning cameras
	/// and lights. By default, the handle is turned off.
	/// </summary>
	public virtual void HandleVisibilityOff()
	{
		vtkSphereRepresentation_HandleVisibilityOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_HandleVisibilityOn_40(HandleRef pThis);

	/// <summary>
	/// The handle sits on the surface of the sphere and may be moved around
	/// the surface by picking (left mouse) and then moving. The position
	/// of the handle can be retrieved, this is useful for positioning cameras
	/// and lights. By default, the handle is turned off.
	/// </summary>
	public virtual void HandleVisibilityOn()
	{
		vtkSphereRepresentation_HandleVisibilityOn_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereRepresentation_HasTranslucentPolygonalGeometry_41(HandleRef pThis);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkSphereRepresentation_HasTranslucentPolygonalGeometry_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereRepresentation_IsA_42(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and to print out the contents of the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSphereRepresentation_IsA_42(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSphereRepresentation_IsTranslationConstrained_43(HandleRef pThis);

	/// <summary>
	/// Returns true if ConstrainedAxis
	/// </summary>
	public bool IsTranslationConstrained()
	{
		return (vtkSphereRepresentation_IsTranslationConstrained_43(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereRepresentation_IsTypeOf_44(string type);

	/// <summary>
	/// Standard methods for type information and to print out the contents of the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSphereRepresentation_IsTypeOf_44(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereRepresentation_NewInstance_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and to print out the contents of the class.
	/// </summary>
	public new vtkSphereRepresentation NewInstance()
	{
		vtkSphereRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereRepresentation_NewInstance_46(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSphereRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_PlaceWidget_47(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API. Note that a
	/// version of place widget is available where the center and handle position
	/// are specified.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkSphereRepresentation_PlaceWidget_47(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_PlaceWidget_48(HandleRef pThis, IntPtr center, IntPtr handlePosition);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API. Note that a
	/// version of place widget is available where the center and handle position
	/// are specified.
	/// </summary>
	public virtual void PlaceWidget(IntPtr center, IntPtr handlePosition)
	{
		vtkSphereRepresentation_PlaceWidget_48(GetCppThis(), center, handlePosition);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_RadialLineOff_49(HandleRef pThis);

	/// <summary>
	/// Enable/disable a radial line segment that joins the center of the
	/// outer sphere and the handle.
	/// </summary>
	public virtual void RadialLineOff()
	{
		vtkSphereRepresentation_RadialLineOff_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_RadialLineOn_50(HandleRef pThis);

	/// <summary>
	/// Enable/disable a radial line segment that joins the center of the
	/// outer sphere and the handle.
	/// </summary>
	public virtual void RadialLineOn()
	{
		vtkSphereRepresentation_RadialLineOn_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_RegisterPickers_51(HandleRef pThis);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override void RegisterPickers()
	{
		vtkSphereRepresentation_RegisterPickers_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_ReleaseGraphicsResources_52(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkSphereRepresentation_ReleaseGraphicsResources_52(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereRepresentation_RenderOpaqueGeometry_53(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkSphereRepresentation_RenderOpaqueGeometry_53(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereRepresentation_RenderOverlay_54(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkSphereRepresentation_RenderOverlay_54(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereRepresentation_RenderTranslucentPolygonalGeometry_55(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkSphereRepresentation_RenderTranslucentPolygonalGeometry_55(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereRepresentation_SafeDownCast_56(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and to print out the contents of the class.
	/// </summary>
	public new static vtkSphereRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkSphereRepresentation vtkSphereRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereRepresentation_SafeDownCast_56(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSphereRepresentation2 = (vtkSphereRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSphereRepresentation2.Register(null);
			}
		}
		return vtkSphereRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetCenter_57(HandleRef pThis, IntPtr c);

	/// <summary>
	/// Set/Get the center position of the sphere. Note that this may
	/// adjust the direction from the handle to the center, as well as
	/// the radius of the sphere.
	/// </summary>
	public void SetCenter(IntPtr c)
	{
		vtkSphereRepresentation_SetCenter_57(GetCppThis(), c);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetCenter_58(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the center position of the sphere. Note that this may
	/// adjust the direction from the handle to the center, as well as
	/// the radius of the sphere.
	/// </summary>
	public void SetCenter(double x, double y, double z)
	{
		vtkSphereRepresentation_SetCenter_58(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetCenterCursor_59(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable/disable a center cursor
	/// Default is disabled
	/// </summary>
	public virtual void SetCenterCursor(bool _arg)
	{
		vtkSphereRepresentation_SetCenterCursor_59(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetHandleDirection_60(HandleRef pThis, IntPtr dir);

	/// <summary>
	/// Set/Get the direction vector of the handle relative to the center of
	/// the sphere. Setting the direction may affect the position of the handle
	/// but will not affect the radius or position of the sphere.
	/// </summary>
	public void SetHandleDirection(IntPtr dir)
	{
		vtkSphereRepresentation_SetHandleDirection_60(GetCppThis(), dir);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetHandleDirection_61(HandleRef pThis, double dx, double dy, double dz);

	/// <summary>
	/// Set/Get the direction vector of the handle relative to the center of
	/// the sphere. Setting the direction may affect the position of the handle
	/// but will not affect the radius or position of the sphere.
	/// </summary>
	public void SetHandleDirection(double dx, double dy, double dz)
	{
		vtkSphereRepresentation_SetHandleDirection_61(GetCppThis(), dx, dy, dz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetHandlePosition_62(HandleRef pThis, IntPtr handle);

	/// <summary>
	/// Set/Get the position of the handle. Note that this may adjust the radius
	/// of the sphere and the handle direction.
	/// </summary>
	public void SetHandlePosition(IntPtr handle)
	{
		vtkSphereRepresentation_SetHandlePosition_62(GetCppThis(), handle);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetHandlePosition_63(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the position of the handle. Note that this may adjust the radius
	/// of the sphere and the handle direction.
	/// </summary>
	public void SetHandlePosition(double x, double y, double z)
	{
		vtkSphereRepresentation_SetHandlePosition_63(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetHandleText_64(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable a label that displays the location of the handle in
	/// spherical coordinates (radius,theta,phi). The two angles, theta and
	/// phi, are displayed in degrees. Note that phi is measured from the
	/// north pole down towards the equator; and theta is the angle around
	/// the north/south axis.
	/// </summary>
	public virtual void SetHandleText(int _arg)
	{
		vtkSphereRepresentation_SetHandleText_64(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetHandleVisibility_65(HandleRef pThis, int _arg);

	/// <summary>
	/// The handle sits on the surface of the sphere and may be moved around
	/// the surface by picking (left mouse) and then moving. The position
	/// of the handle can be retrieved, this is useful for positioning cameras
	/// and lights. By default, the handle is turned off.
	/// </summary>
	public virtual void SetHandleVisibility(int _arg)
	{
		vtkSphereRepresentation_SetHandleVisibility_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetInteractionState_66(HandleRef pThis, int state);

	/// <summary>
	/// The interaction state may be set from a widget (e.g., vtkSphereWidget2) or
	/// other object. This controls how the interaction with the widget
	/// proceeds. Normally this method is used as part of a handshaking
	/// process with the widget: First ComputeInteractionState() is invoked that
	/// returns a state based on geometric considerations (i.e., cursor near a
	/// widget feature), then based on events, the widget may modify this
	/// further.
	/// </summary>
	public void SetInteractionState(int state)
	{
		vtkSphereRepresentation_SetInteractionState_66(GetCppThis(), state);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetPhiResolution_67(HandleRef pThis, int r);

	/// <summary>
	/// Set/Get the resolution of the sphere in the phi direction.
	/// </summary>
	public void SetPhiResolution(int r)
	{
		vtkSphereRepresentation_SetPhiResolution_67(GetCppThis(), r);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetRadialLine_68(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable a radial line segment that joins the center of the
	/// outer sphere and the handle.
	/// </summary>
	public virtual void SetRadialLine(int _arg)
	{
		vtkSphereRepresentation_SetRadialLine_68(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetRadius_69(HandleRef pThis, double r);

	/// <summary>
	/// Set/Get the radius of sphere. Default is 0.5. Note that this may
	/// modify the position of the handle based on the handle direction.
	/// </summary>
	public void SetRadius(double r)
	{
		vtkSphereRepresentation_SetRadius_69(GetCppThis(), r);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetRepresentation_70(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the representation (i.e., appearance) of the sphere. Different
	/// representations are useful depending on the application.
	/// </summary>
	public virtual void SetRepresentation(int _arg)
	{
		vtkSphereRepresentation_SetRepresentation_70(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetRepresentationToOff_71(HandleRef pThis);

	/// <summary>
	/// Set the representation (i.e., appearance) of the sphere. Different
	/// representations are useful depending on the application.
	/// </summary>
	public void SetRepresentationToOff()
	{
		vtkSphereRepresentation_SetRepresentationToOff_71(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetRepresentationToSurface_72(HandleRef pThis);

	/// <summary>
	/// Set the representation (i.e., appearance) of the sphere. Different
	/// representations are useful depending on the application.
	/// </summary>
	public void SetRepresentationToSurface()
	{
		vtkSphereRepresentation_SetRepresentationToSurface_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetRepresentationToWireframe_73(HandleRef pThis);

	/// <summary>
	/// Set the representation (i.e., appearance) of the sphere. Different
	/// representations are useful depending on the application.
	/// </summary>
	public void SetRepresentationToWireframe()
	{
		vtkSphereRepresentation_SetRepresentationToWireframe_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetThetaResolution_74(HandleRef pThis, int r);

	/// <summary>
	/// Set/Get the resolution of the sphere in the theta direction.
	/// </summary>
	public void SetThetaResolution(int r)
	{
		vtkSphereRepresentation_SetThetaResolution_74(GetCppThis(), r);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetTranslationAxis_75(HandleRef pThis, int _arg);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual void SetTranslationAxis(int _arg)
	{
		vtkSphereRepresentation_SetTranslationAxis_75(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetTranslationAxisOff_76(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetTranslationAxisOff()
	{
		vtkSphereRepresentation_SetTranslationAxisOff_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetXTranslationAxisOn_77(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetXTranslationAxisOn()
	{
		vtkSphereRepresentation_SetXTranslationAxisOn_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetYTranslationAxisOn_78(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetYTranslationAxisOn()
	{
		vtkSphereRepresentation_SetYTranslationAxisOn_78(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_SetZTranslationAxisOn_79(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetZTranslationAxisOn()
	{
		vtkSphereRepresentation_SetZTranslationAxisOn_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_StartWidgetInteraction_80(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API. Note that a
	/// version of place widget is available where the center and handle position
	/// are specified.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr e)
	{
		vtkSphereRepresentation_StartWidgetInteraction_80(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereRepresentation_WidgetInteraction_81(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API. Note that a
	/// version of place widget is available where the center and handle position
	/// are specified.
	/// </summary>
	public override void WidgetInteraction(IntPtr e)
	{
		vtkSphereRepresentation_WidgetInteraction_81(GetCppThis(), e);
	}
}
