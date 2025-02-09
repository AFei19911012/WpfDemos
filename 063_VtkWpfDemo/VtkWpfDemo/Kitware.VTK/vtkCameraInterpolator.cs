using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCameraInterpolator
/// </summary>
/// <remarks>
///    interpolate a series of cameras to update a new camera
///
/// This class is used to interpolate a series of cameras to update a
/// specified camera. Either linear interpolation or spline interpolation may
/// be used. The instance variables currently interpolated include position,
/// focal point, view up, view angle, parallel scale, and clipping range.
///
/// To use this class, specify the type of interpolation to use, and add a
/// series of cameras at various times "t" to the list of cameras from which to
/// interpolate. Then to interpolate in between cameras, simply invoke the
/// function InterpolateCamera(t,camera) where "camera" is the camera to be
/// updated with interpolated values. Note that "t" should be in the range
/// (min,max) times specified with the AddCamera() method. If outside this
/// range, the interpolation is clamped. This class copies the camera information
/// (as compared to referencing the cameras) so you do not need to keep separate
/// instances of the camera around for each camera added to the list of cameras
/// to interpolate.
///
/// @warning
/// The interpolator classes are initialized the first time InterpolateCamera()
/// is called. Any later changes to the interpolators, or additions to the list of
/// cameras to be interpolated, causes a reinitialization of the
/// interpolators the next time InterpolateCamera() is invoked. Thus the
/// best performance is obtained by 1) configuring the interpolators, 2) adding
/// all the cameras, and 3) finally performing interpolation.
///
/// @warning
/// Currently position, focal point and view up are interpolated to define
/// the orientation of the camera. Quaternion interpolation may be added in the
/// future as an alternative interpolation method for camera orientation.
/// </remarks>
public class vtkCameraInterpolator : vtkObject
{
	/// <summary>
	/// Enums to control the type of interpolation to use.
	/// </summary>
	public enum INTERPOLATION_TYPE_LINEAR_WrapperEnum
	{
		/// <summary>enum member</summary>
		INTERPOLATION_TYPE_LINEAR = 0,
		/// <summary>enum member</summary>
		INTERPOLATION_TYPE_MANUAL = 2,
		/// <summary>enum member</summary>
		INTERPOLATION_TYPE_SPLINE = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCameraInterpolator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCameraInterpolator()
	{
		MRClassNameKey = "class vtkCameraInterpolator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraInterpolator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCameraInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkCameraInterpolator New()
	{
		vtkCameraInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCameraInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkCameraInterpolator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCameraInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraInterpolator_AddCamera_01(HandleRef pThis, double t, HandleRef camera);

	/// <summary>
	/// Add another camera to the list of cameras defining
	/// the camera function. Note that using the same time t value
	/// more than once replaces the previous camera value at t.
	/// At least one camera must be added to define a function.
	/// </summary>
	public void AddCamera(double t, vtkCamera camera)
	{
		vtkCameraInterpolator_AddCamera_01(GetCppThis(), t, camera?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraInterpolator_GetClippingRangeInterpolator_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the tuple interpolator used to interpolate the clipping range portion
	/// of the camera. Note that you can modify the behavior of the interpolator
	/// (linear vs spline interpolation; change spline basis) by manipulating
	/// the interpolator instances directly.
	/// </summary>
	public virtual vtkTupleInterpolator GetClippingRangeInterpolator()
	{
		vtkTupleInterpolator vtkTupleInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraInterpolator_GetClippingRangeInterpolator_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTupleInterpolator2 = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTupleInterpolator2.Register(null);
			}
		}
		return vtkTupleInterpolator2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraInterpolator_GetFocalPointInterpolator_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the tuple interpolator used to interpolate the focal point portion
	/// of the camera. Note that you can modify the behavior of the interpolator
	/// (linear vs spline interpolation; change spline basis) by manipulating
	/// the interpolator instances directly.
	/// </summary>
	public virtual vtkTupleInterpolator GetFocalPointInterpolator()
	{
		vtkTupleInterpolator vtkTupleInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraInterpolator_GetFocalPointInterpolator_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTupleInterpolator2 = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTupleInterpolator2.Register(null);
			}
		}
		return vtkTupleInterpolator2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraInterpolator_GetInterpolationType_04(HandleRef pThis);

	/// <summary>
	/// These are convenience methods to switch between linear and spline
	/// interpolation. The methods simply forward the request for linear or
	/// spline interpolation to the instance variable interpolators (i.e.,
	/// position, focal point, clipping range, orientation, etc.)
	/// interpolators. Note that if the InterpolationType is set to "Manual",
	/// then the interpolators are expected to be directly manipulated and this
	/// class does not forward the request for interpolation type to its
	/// interpolators.
	/// </summary>
	public virtual int GetInterpolationType()
	{
		return vtkCameraInterpolator_GetInterpolationType_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraInterpolator_GetInterpolationTypeMaxValue_05(HandleRef pThis);

	/// <summary>
	/// These are convenience methods to switch between linear and spline
	/// interpolation. The methods simply forward the request for linear or
	/// spline interpolation to the instance variable interpolators (i.e.,
	/// position, focal point, clipping range, orientation, etc.)
	/// interpolators. Note that if the InterpolationType is set to "Manual",
	/// then the interpolators are expected to be directly manipulated and this
	/// class does not forward the request for interpolation type to its
	/// interpolators.
	/// </summary>
	public virtual int GetInterpolationTypeMaxValue()
	{
		return vtkCameraInterpolator_GetInterpolationTypeMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraInterpolator_GetInterpolationTypeMinValue_06(HandleRef pThis);

	/// <summary>
	/// These are convenience methods to switch between linear and spline
	/// interpolation. The methods simply forward the request for linear or
	/// spline interpolation to the instance variable interpolators (i.e.,
	/// position, focal point, clipping range, orientation, etc.)
	/// interpolators. Note that if the InterpolationType is set to "Manual",
	/// then the interpolators are expected to be directly manipulated and this
	/// class does not forward the request for interpolation type to its
	/// interpolators.
	/// </summary>
	public virtual int GetInterpolationTypeMinValue()
	{
		return vtkCameraInterpolator_GetInterpolationTypeMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkCameraInterpolator_GetMTime_07(HandleRef pThis);

	/// <summary>
	/// Override GetMTime() because we depend on the interpolators which may be
	/// modified outside of this class.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkCameraInterpolator_GetMTime_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCameraInterpolator_GetMaximumT_08(HandleRef pThis);

	/// <summary>
	/// Obtain some information about the interpolation range. The numbers
	/// returned are undefined if the list of cameras is empty.
	/// </summary>
	public double GetMaximumT()
	{
		return vtkCameraInterpolator_GetMaximumT_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCameraInterpolator_GetMinimumT_09(HandleRef pThis);

	/// <summary>
	/// Obtain some information about the interpolation range. The numbers
	/// returned are undefined if the list of cameras is empty.
	/// </summary>
	public double GetMinimumT()
	{
		return vtkCameraInterpolator_GetMinimumT_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraInterpolator_GetNumberOfCameras_10(HandleRef pThis);

	/// <summary>
	/// Return the number of cameras in the list of cameras.
	/// </summary>
	public int GetNumberOfCameras()
	{
		return vtkCameraInterpolator_GetNumberOfCameras_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCameraInterpolator_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCameraInterpolator_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCameraInterpolator_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCameraInterpolator_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraInterpolator_GetParallelScaleInterpolator_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the tuple interpolator used to interpolate the parallel scale portion
	/// of the camera. Note that you can modify the behavior of the interpolator
	/// (linear vs spline interpolation; change spline basis) by manipulating
	/// the interpolator instances directly.
	/// </summary>
	public virtual vtkTupleInterpolator GetParallelScaleInterpolator()
	{
		vtkTupleInterpolator vtkTupleInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraInterpolator_GetParallelScaleInterpolator_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTupleInterpolator2 = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTupleInterpolator2.Register(null);
			}
		}
		return vtkTupleInterpolator2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraInterpolator_GetPositionInterpolator_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the tuple interpolator used to interpolate the position portion
	/// of the camera. Note that you can modify the behavior of the interpolator
	/// (linear vs spline interpolation; change spline basis) by manipulating
	/// the interpolator instances directly.
	/// </summary>
	public virtual vtkTupleInterpolator GetPositionInterpolator()
	{
		vtkTupleInterpolator vtkTupleInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraInterpolator_GetPositionInterpolator_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTupleInterpolator2 = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTupleInterpolator2.Register(null);
			}
		}
		return vtkTupleInterpolator2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraInterpolator_GetViewAngleInterpolator_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the tuple interpolator used to interpolate the view angle portion
	/// of the camera. Note that you can modify the behavior of the interpolator
	/// (linear vs spline interpolation; change spline basis) by manipulating
	/// the interpolator instances directly.
	/// </summary>
	public virtual vtkTupleInterpolator GetViewAngleInterpolator()
	{
		vtkTupleInterpolator vtkTupleInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraInterpolator_GetViewAngleInterpolator_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTupleInterpolator2 = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTupleInterpolator2.Register(null);
			}
		}
		return vtkTupleInterpolator2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraInterpolator_GetViewUpInterpolator_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the tuple interpolator used to interpolate the view up portion
	/// of the camera. Note that you can modify the behavior of the interpolator
	/// (linear vs spline interpolation; change spline basis) by manipulating
	/// the interpolator instances directly.
	/// </summary>
	public virtual vtkTupleInterpolator GetViewUpInterpolator()
	{
		vtkTupleInterpolator vtkTupleInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraInterpolator_GetViewUpInterpolator_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTupleInterpolator2 = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTupleInterpolator2.Register(null);
			}
		}
		return vtkTupleInterpolator2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraInterpolator_Initialize_17(HandleRef pThis);

	/// <summary>
	/// Clear the list of cameras.
	/// </summary>
	public void Initialize()
	{
		vtkCameraInterpolator_Initialize_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraInterpolator_InterpolateCamera_18(HandleRef pThis, double t, HandleRef camera);

	/// <summary>
	/// Interpolate the list of cameras and determine a new camera (i.e.,
	/// fill in the camera provided). If t is outside the range of
	/// (min,max) values, then t is clamped to lie within this range.
	/// </summary>
	public void InterpolateCamera(double t, vtkCamera camera)
	{
		vtkCameraInterpolator_InterpolateCamera_18(GetCppThis(), t, camera?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraInterpolator_IsA_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCameraInterpolator_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraInterpolator_IsTypeOf_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCameraInterpolator_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraInterpolator_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCameraInterpolator NewInstance()
	{
		vtkCameraInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraInterpolator_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCameraInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraInterpolator_RemoveCamera_23(HandleRef pThis, double t);

	/// <summary>
	/// Delete the camera at a particular parameter t. If there is no
	/// camera defined at location t, then the method does nothing.
	/// </summary>
	public void RemoveCamera(double t)
	{
		vtkCameraInterpolator_RemoveCamera_23(GetCppThis(), t);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraInterpolator_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCameraInterpolator SafeDownCast(vtkObjectBase o)
	{
		vtkCameraInterpolator vtkCameraInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraInterpolator_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCameraInterpolator2 = (vtkCameraInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCameraInterpolator2.Register(null);
			}
		}
		return vtkCameraInterpolator2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraInterpolator_SetClippingRangeInterpolator_25(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the tuple interpolator used to interpolate the clipping range portion
	/// of the camera. Note that you can modify the behavior of the interpolator
	/// (linear vs spline interpolation; change spline basis) by manipulating
	/// the interpolator instances directly.
	/// </summary>
	public virtual void SetClippingRangeInterpolator(vtkTupleInterpolator arg0)
	{
		vtkCameraInterpolator_SetClippingRangeInterpolator_25(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraInterpolator_SetFocalPointInterpolator_26(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the tuple interpolator used to interpolate the focal point portion
	/// of the camera. Note that you can modify the behavior of the interpolator
	/// (linear vs spline interpolation; change spline basis) by manipulating
	/// the interpolator instances directly.
	/// </summary>
	public virtual void SetFocalPointInterpolator(vtkTupleInterpolator arg0)
	{
		vtkCameraInterpolator_SetFocalPointInterpolator_26(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraInterpolator_SetInterpolationType_27(HandleRef pThis, int _arg);

	/// <summary>
	/// These are convenience methods to switch between linear and spline
	/// interpolation. The methods simply forward the request for linear or
	/// spline interpolation to the instance variable interpolators (i.e.,
	/// position, focal point, clipping range, orientation, etc.)
	/// interpolators. Note that if the InterpolationType is set to "Manual",
	/// then the interpolators are expected to be directly manipulated and this
	/// class does not forward the request for interpolation type to its
	/// interpolators.
	/// </summary>
	public virtual void SetInterpolationType(int _arg)
	{
		vtkCameraInterpolator_SetInterpolationType_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraInterpolator_SetInterpolationTypeToLinear_28(HandleRef pThis);

	/// <summary>
	/// These are convenience methods to switch between linear and spline
	/// interpolation. The methods simply forward the request for linear or
	/// spline interpolation to the instance variable interpolators (i.e.,
	/// position, focal point, clipping range, orientation, etc.)
	/// interpolators. Note that if the InterpolationType is set to "Manual",
	/// then the interpolators are expected to be directly manipulated and this
	/// class does not forward the request for interpolation type to its
	/// interpolators.
	/// </summary>
	public void SetInterpolationTypeToLinear()
	{
		vtkCameraInterpolator_SetInterpolationTypeToLinear_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraInterpolator_SetInterpolationTypeToManual_29(HandleRef pThis);

	/// <summary>
	/// These are convenience methods to switch between linear and spline
	/// interpolation. The methods simply forward the request for linear or
	/// spline interpolation to the instance variable interpolators (i.e.,
	/// position, focal point, clipping range, orientation, etc.)
	/// interpolators. Note that if the InterpolationType is set to "Manual",
	/// then the interpolators are expected to be directly manipulated and this
	/// class does not forward the request for interpolation type to its
	/// interpolators.
	/// </summary>
	public void SetInterpolationTypeToManual()
	{
		vtkCameraInterpolator_SetInterpolationTypeToManual_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraInterpolator_SetInterpolationTypeToSpline_30(HandleRef pThis);

	/// <summary>
	/// These are convenience methods to switch between linear and spline
	/// interpolation. The methods simply forward the request for linear or
	/// spline interpolation to the instance variable interpolators (i.e.,
	/// position, focal point, clipping range, orientation, etc.)
	/// interpolators. Note that if the InterpolationType is set to "Manual",
	/// then the interpolators are expected to be directly manipulated and this
	/// class does not forward the request for interpolation type to its
	/// interpolators.
	/// </summary>
	public void SetInterpolationTypeToSpline()
	{
		vtkCameraInterpolator_SetInterpolationTypeToSpline_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraInterpolator_SetParallelScaleInterpolator_31(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the tuple interpolator used to interpolate the parallel scale portion
	/// of the camera. Note that you can modify the behavior of the interpolator
	/// (linear vs spline interpolation; change spline basis) by manipulating
	/// the interpolator instances directly.
	/// </summary>
	public virtual void SetParallelScaleInterpolator(vtkTupleInterpolator arg0)
	{
		vtkCameraInterpolator_SetParallelScaleInterpolator_31(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraInterpolator_SetPositionInterpolator_32(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the tuple interpolator used to interpolate the position portion
	/// of the camera. Note that you can modify the behavior of the interpolator
	/// (linear vs spline interpolation; change spline basis) by manipulating
	/// the interpolator instances directly.
	/// </summary>
	public virtual void SetPositionInterpolator(vtkTupleInterpolator arg0)
	{
		vtkCameraInterpolator_SetPositionInterpolator_32(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraInterpolator_SetViewAngleInterpolator_33(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the tuple interpolator used to interpolate the view angle portion
	/// of the camera. Note that you can modify the behavior of the interpolator
	/// (linear vs spline interpolation; change spline basis) by manipulating
	/// the interpolator instances directly.
	/// </summary>
	public virtual void SetViewAngleInterpolator(vtkTupleInterpolator arg0)
	{
		vtkCameraInterpolator_SetViewAngleInterpolator_33(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraInterpolator_SetViewUpInterpolator_34(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the tuple interpolator used to interpolate the view up portion
	/// of the camera. Note that you can modify the behavior of the interpolator
	/// (linear vs spline interpolation; change spline basis) by manipulating
	/// the interpolator instances directly.
	/// </summary>
	public virtual void SetViewUpInterpolator(vtkTupleInterpolator arg0)
	{
		vtkCameraInterpolator_SetViewUpInterpolator_34(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
