using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTransformInterpolator
/// </summary>
/// <remarks>
///    interpolate a series of transformation matrices
///
/// This class is used to interpolate a series of 4x4 transformation
/// matrices. Position, scale and orientation (i.e., rotations) are
/// interpolated separately, and can be interpolated linearly or with a spline
/// function. Note that orientation is interpolated using quaternions via
/// SLERP (spherical linear interpolation) or the special vtkQuaternionSpline
/// class.
///
/// To use this class, specify at least two pairs of (t,transformation matrix)
/// with the AddTransform() method.  Then interpolated the transforms with the
/// InterpolateTransform(t,transform) method, where "t" must be in the range
/// of (min,max) times specified by the AddTransform() method.
///
/// By default, spline interpolation is used for the interpolation of the
/// transformation matrices. The position, scale and orientation of the
/// matrices are interpolated with instances of the classes
/// vtkTupleInterpolator (position,scale) and vtkQuaternionInterpolator
/// (rotation). The user can override the interpolation behavior by gaining
/// access to these separate interpolation classes.  These interpolator
/// classes (vtkTupleInterpolator and vtkQuaternionInterpolator) can be
/// modified to perform linear versus spline interpolation, and/or different
/// spline basis functions can be specified.
///
/// @warning
/// The interpolator classes are initialized when the InterpolateTransform()
/// is called. Any changes to the interpolators, or additions to the list of
/// transforms to be interpolated, causes a reinitialization of the
/// interpolators the next time InterpolateTransform() is invoked. Thus the
/// best performance is obtained by 1) configuring the interpolators, 2) adding
/// all the transforms, and 3) finally performing interpolation.
/// </remarks>
public class vtkTransformInterpolator : vtkObject
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
	public new const string MRFullTypeName = "Kitware.VTK.vtkTransformInterpolator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTransformInterpolator()
	{
		MRClassNameKey = "class vtkTransformInterpolator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransformInterpolator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTransformInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkTransformInterpolator New()
	{
		vtkTransformInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTransformInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkTransformInterpolator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTransformInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTransformInterpolator_AddTransform_01(HandleRef pThis, double t, HandleRef xform);

	/// <summary>
	/// Add another transform to the list of transformations defining
	/// the transform function. Note that using the same time t value
	/// more than once replaces the previous transform value at t.
	/// At least two transforms must be added to define a function.
	/// There are variants to this method depending on whether you are
	/// adding a vtkTransform, vtkMaxtirx4x4, and/or vtkProp3D.
	/// </summary>
	public void AddTransform(double t, vtkTransform xform)
	{
		vtkTransformInterpolator_AddTransform_01(GetCppThis(), t, xform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformInterpolator_AddTransform_02(HandleRef pThis, double t, HandleRef matrix);

	/// <summary>
	/// Add another transform to the list of transformations defining
	/// the transform function. Note that using the same time t value
	/// more than once replaces the previous transform value at t.
	/// At least two transforms must be added to define a function.
	/// There are variants to this method depending on whether you are
	/// adding a vtkTransform, vtkMaxtirx4x4, and/or vtkProp3D.
	/// </summary>
	public void AddTransform(double t, vtkMatrix4x4 matrix)
	{
		vtkTransformInterpolator_AddTransform_02(GetCppThis(), t, matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformInterpolator_AddTransform_03(HandleRef pThis, double t, HandleRef prop3D);

	/// <summary>
	/// Add another transform to the list of transformations defining
	/// the transform function. Note that using the same time t value
	/// more than once replaces the previous transform value at t.
	/// At least two transforms must be added to define a function.
	/// There are variants to this method depending on whether you are
	/// adding a vtkTransform, vtkMaxtirx4x4, and/or vtkProp3D.
	/// </summary>
	public void AddTransform(double t, vtkProp3D prop3D)
	{
		vtkTransformInterpolator_AddTransform_03(GetCppThis(), t, prop3D?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransformInterpolator_GetInterpolationType_04(HandleRef pThis);

	/// <summary>
	/// These are convenience methods to switch between linear and spline
	/// interpolation. The methods simply forward the request for linear or
	/// spline interpolation to the position, scale and orientation
	/// interpolators. Note that if the InterpolationType is set to "Manual",
	/// then the interpolators are expected to be directly manipulated and
	/// this class does not forward the request for interpolation type to its
	/// interpolators.
	/// </summary>
	public virtual int GetInterpolationType()
	{
		return vtkTransformInterpolator_GetInterpolationType_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransformInterpolator_GetInterpolationTypeMaxValue_05(HandleRef pThis);

	/// <summary>
	/// These are convenience methods to switch between linear and spline
	/// interpolation. The methods simply forward the request for linear or
	/// spline interpolation to the position, scale and orientation
	/// interpolators. Note that if the InterpolationType is set to "Manual",
	/// then the interpolators are expected to be directly manipulated and
	/// this class does not forward the request for interpolation type to its
	/// interpolators.
	/// </summary>
	public virtual int GetInterpolationTypeMaxValue()
	{
		return vtkTransformInterpolator_GetInterpolationTypeMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransformInterpolator_GetInterpolationTypeMinValue_06(HandleRef pThis);

	/// <summary>
	/// These are convenience methods to switch between linear and spline
	/// interpolation. The methods simply forward the request for linear or
	/// spline interpolation to the position, scale and orientation
	/// interpolators. Note that if the InterpolationType is set to "Manual",
	/// then the interpolators are expected to be directly manipulated and
	/// this class does not forward the request for interpolation type to its
	/// interpolators.
	/// </summary>
	public virtual int GetInterpolationTypeMinValue()
	{
		return vtkTransformInterpolator_GetInterpolationTypeMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkTransformInterpolator_GetMTime_07(HandleRef pThis);

	/// <summary>
	/// Override GetMTime() because we depend on the interpolators which may be
	/// modified outside of this class.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkTransformInterpolator_GetMTime_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTransformInterpolator_GetMaximumT_08(HandleRef pThis);

	/// <summary>
	/// Obtain some information about the interpolation range. The numbers
	/// returned (corresponding to parameter t, usually thought of as time)
	/// are undefined if the list of transforms is empty.
	/// </summary>
	public double GetMaximumT()
	{
		return vtkTransformInterpolator_GetMaximumT_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTransformInterpolator_GetMinimumT_09(HandleRef pThis);

	/// <summary>
	/// Obtain some information about the interpolation range. The numbers
	/// returned (corresponding to parameter t, usually thought of as time)
	/// are undefined if the list of transforms is empty.
	/// </summary>
	public double GetMinimumT()
	{
		return vtkTransformInterpolator_GetMinimumT_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTransformInterpolator_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTransformInterpolator_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTransformInterpolator_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTransformInterpolator_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransformInterpolator_GetNumberOfTransforms_12(HandleRef pThis);

	/// <summary>
	/// Return the number of transforms in the list of transforms.
	/// </summary>
	public int GetNumberOfTransforms()
	{
		return vtkTransformInterpolator_GetNumberOfTransforms_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformInterpolator_GetPositionInterpolator_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the tuple interpolator used to interpolate the position portion
	/// of the transformation matrix. Note that you can modify the behavior of
	/// the interpolator (linear vs spline interpolation; change spline basis)
	/// by manipulating the interpolator instances.
	/// </summary>
	public virtual vtkTupleInterpolator GetPositionInterpolator()
	{
		vtkTupleInterpolator vtkTupleInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformInterpolator_GetPositionInterpolator_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkTransformInterpolator_GetRotationInterpolator_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the tuple interpolator used to interpolate the orientation portion
	/// of the transformation matrix. Note that you can modify the behavior of
	/// the interpolator (linear vs spline interpolation; change spline basis)
	/// by manipulating the interpolator instances.
	/// </summary>
	public virtual vtkQuaternionInterpolator GetRotationInterpolator()
	{
		vtkQuaternionInterpolator vtkQuaternionInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformInterpolator_GetRotationInterpolator_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkQuaternionInterpolator2 = (vtkQuaternionInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkQuaternionInterpolator2.Register(null);
			}
		}
		return vtkQuaternionInterpolator2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformInterpolator_GetScaleInterpolator_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the tuple interpolator used to interpolate the scale portion
	/// of the transformation matrix. Note that you can modify the behavior of
	/// the interpolator (linear vs spline interpolation; change spline basis)
	/// by manipulating the interpolator instances.
	/// </summary>
	public virtual vtkTupleInterpolator GetScaleInterpolator()
	{
		vtkTupleInterpolator vtkTupleInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformInterpolator_GetScaleInterpolator_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTransformInterpolator_Initialize_16(HandleRef pThis);

	/// <summary>
	/// Clear the list of transforms.
	/// </summary>
	public void Initialize()
	{
		vtkTransformInterpolator_Initialize_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformInterpolator_InterpolateTransform_17(HandleRef pThis, double t, HandleRef xform);

	/// <summary>
	/// Interpolate the list of transforms and determine a new transform (i.e.,
	/// fill in the transformation provided). If t is outside the range of
	/// (min,max) values, then t is clamped.
	/// </summary>
	public void InterpolateTransform(double t, vtkTransform xform)
	{
		vtkTransformInterpolator_InterpolateTransform_17(GetCppThis(), t, xform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransformInterpolator_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTransformInterpolator_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransformInterpolator_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTransformInterpolator_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformInterpolator_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTransformInterpolator NewInstance()
	{
		vtkTransformInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformInterpolator_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTransformInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformInterpolator_RemoveTransform_22(HandleRef pThis, double t);

	/// <summary>
	/// Delete the transform at a particular parameter t. If there is no
	/// transform defined at location t, then the method does nothing.
	/// </summary>
	public void RemoveTransform(double t)
	{
		vtkTransformInterpolator_RemoveTransform_22(GetCppThis(), t);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransformInterpolator_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTransformInterpolator SafeDownCast(vtkObjectBase o)
	{
		vtkTransformInterpolator vtkTransformInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransformInterpolator_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransformInterpolator2 = (vtkTransformInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransformInterpolator2.Register(null);
			}
		}
		return vtkTransformInterpolator2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformInterpolator_SetInterpolationType_24(HandleRef pThis, int _arg);

	/// <summary>
	/// These are convenience methods to switch between linear and spline
	/// interpolation. The methods simply forward the request for linear or
	/// spline interpolation to the position, scale and orientation
	/// interpolators. Note that if the InterpolationType is set to "Manual",
	/// then the interpolators are expected to be directly manipulated and
	/// this class does not forward the request for interpolation type to its
	/// interpolators.
	/// </summary>
	public virtual void SetInterpolationType(int _arg)
	{
		vtkTransformInterpolator_SetInterpolationType_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformInterpolator_SetInterpolationTypeToLinear_25(HandleRef pThis);

	/// <summary>
	/// These are convenience methods to switch between linear and spline
	/// interpolation. The methods simply forward the request for linear or
	/// spline interpolation to the position, scale and orientation
	/// interpolators. Note that if the InterpolationType is set to "Manual",
	/// then the interpolators are expected to be directly manipulated and
	/// this class does not forward the request for interpolation type to its
	/// interpolators.
	/// </summary>
	public void SetInterpolationTypeToLinear()
	{
		vtkTransformInterpolator_SetInterpolationTypeToLinear_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformInterpolator_SetInterpolationTypeToManual_26(HandleRef pThis);

	/// <summary>
	/// These are convenience methods to switch between linear and spline
	/// interpolation. The methods simply forward the request for linear or
	/// spline interpolation to the position, scale and orientation
	/// interpolators. Note that if the InterpolationType is set to "Manual",
	/// then the interpolators are expected to be directly manipulated and
	/// this class does not forward the request for interpolation type to its
	/// interpolators.
	/// </summary>
	public void SetInterpolationTypeToManual()
	{
		vtkTransformInterpolator_SetInterpolationTypeToManual_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformInterpolator_SetInterpolationTypeToSpline_27(HandleRef pThis);

	/// <summary>
	/// These are convenience methods to switch between linear and spline
	/// interpolation. The methods simply forward the request for linear or
	/// spline interpolation to the position, scale and orientation
	/// interpolators. Note that if the InterpolationType is set to "Manual",
	/// then the interpolators are expected to be directly manipulated and
	/// this class does not forward the request for interpolation type to its
	/// interpolators.
	/// </summary>
	public void SetInterpolationTypeToSpline()
	{
		vtkTransformInterpolator_SetInterpolationTypeToSpline_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformInterpolator_SetPositionInterpolator_28(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the tuple interpolator used to interpolate the position portion
	/// of the transformation matrix. Note that you can modify the behavior of
	/// the interpolator (linear vs spline interpolation; change spline basis)
	/// by manipulating the interpolator instances.
	/// </summary>
	public virtual void SetPositionInterpolator(vtkTupleInterpolator arg0)
	{
		vtkTransformInterpolator_SetPositionInterpolator_28(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformInterpolator_SetRotationInterpolator_29(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the tuple interpolator used to interpolate the orientation portion
	/// of the transformation matrix. Note that you can modify the behavior of
	/// the interpolator (linear vs spline interpolation; change spline basis)
	/// by manipulating the interpolator instances.
	/// </summary>
	public virtual void SetRotationInterpolator(vtkQuaternionInterpolator arg0)
	{
		vtkTransformInterpolator_SetRotationInterpolator_29(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransformInterpolator_SetScaleInterpolator_30(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the tuple interpolator used to interpolate the scale portion
	/// of the transformation matrix. Note that you can modify the behavior of
	/// the interpolator (linear vs spline interpolation; change spline basis)
	/// by manipulating the interpolator instances.
	/// </summary>
	public virtual void SetScaleInterpolator(vtkTupleInterpolator arg0)
	{
		vtkTransformInterpolator_SetScaleInterpolator_30(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
