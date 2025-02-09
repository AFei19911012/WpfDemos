using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkQuaternionInterpolator
/// </summary>
/// <remarks>
///    interpolate a quaternion
///
/// This class is used to interpolate a series of quaternions representing
/// the rotations of a 3D object.  The interpolation may be linear in form
/// (using spherical linear interpolation SLERP), or via spline interpolation
/// (using SQUAD). In either case the interpolation is specialized to
/// quaternions since the interpolation occurs on the surface of the unit
/// quaternion sphere.
///
/// To use this class, specify at least two pairs of (t,q[4]) with the
/// AddQuaternion() method.  Next interpolate the tuples with the
/// InterpolateQuaternion(t,q[4]) method, where "t" must be in the range of
/// (t_min,t_max) parameter values specified by the AddQuaternion() method (t
/// is clamped otherwise), and q[4] is filled in by the method.
///
/// There are several important background references. Ken Shoemake described
/// the practical application of quaternions for the interpolation of rotation
/// (K. Shoemake, "Animating rotation with quaternion curves", Computer
/// Graphics (Siggraph '85) 19(3):245--254, 1985). Another fine reference
/// (available on-line) is E. B. Dam, M. Koch, and M. Lillholm, Technical
/// Report DIKU-TR-98/5, Dept. of Computer Science, University of Copenhagen,
/// Denmark.
///
/// @warning
/// Note that for two or less quaternions, Slerp (linear) interpolation is
/// performed even if spline interpolation is requested. Also, the tangents to
/// the first and last segments of spline interpolation are (arbitrarily)
/// defined by repeating the first and last quaternions.
///
/// @warning
/// There are several methods particular to quaternions (norms, products,
/// etc.) implemented interior to this class. These may be moved to a separate
/// quaternion class at some point.
///
/// </remarks>
/// <seealso>
///
/// vtkQuaternion
/// </seealso>
public class vtkQuaternionInterpolator : vtkObject
{
	/// <summary>
	/// Enums to control the type of interpolation to use.
	/// </summary>
	public enum INTERPOLATION_TYPE_LINEAR_WrapperEnum
	{
		/// <summary>enum member</summary>
		INTERPOLATION_TYPE_LINEAR,
		/// <summary>enum member</summary>
		INTERPOLATION_TYPE_SPLINE
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public enum vtkQuaternionInterpolationSearchMethod
	{
		/// <summary>enum member</summary>
		BinarySearch,
		/// <summary>enum member</summary>
		LinearSearch,
		/// <summary>enum member</summary>
		MaxEnum
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkQuaternionInterpolator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkQuaternionInterpolator()
	{
		MRClassNameKey = "class vtkQuaternionInterpolator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuaternionInterpolator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkQuaternionInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuaternionInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkQuaternionInterpolator New()
	{
		vtkQuaternionInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuaternionInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkQuaternionInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkQuaternionInterpolator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkQuaternionInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuaternionInterpolator_AddQuaternion_01(HandleRef pThis, double t, IntPtr q);

	/// <summary>
	/// Add another quaternion to the list of quaternions to be interpolated.
	/// Note that using the same time t value more than once replaces the
	/// previous quaternion at t. At least one quaternions must be added to
	/// define an interpolation functions.
	/// </summary>
	public void AddQuaternion(double t, IntPtr q)
	{
		vtkQuaternionInterpolator_AddQuaternion_01(GetCppThis(), t, q);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuaternionInterpolator_GetInterpolationType_02(HandleRef pThis);

	/// <summary>
	/// Specify which type of function to use for interpolation. By default
	/// (SetInterpolationFunctionToSpline()), cubic spline interpolation using a
	/// modified Kochanek basis is employed. Otherwise, if
	/// SetInterpolationFunctionToLinear() is invoked, linear spherical
	/// interpolation
	/// is used between each pair of quaternions.
	/// </summary>
	public virtual int GetInterpolationType()
	{
		return vtkQuaternionInterpolator_GetInterpolationType_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuaternionInterpolator_GetInterpolationTypeMaxValue_03(HandleRef pThis);

	/// <summary>
	/// Specify which type of function to use for interpolation. By default
	/// (SetInterpolationFunctionToSpline()), cubic spline interpolation using a
	/// modified Kochanek basis is employed. Otherwise, if
	/// SetInterpolationFunctionToLinear() is invoked, linear spherical
	/// interpolation
	/// is used between each pair of quaternions.
	/// </summary>
	public virtual int GetInterpolationTypeMaxValue()
	{
		return vtkQuaternionInterpolator_GetInterpolationTypeMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuaternionInterpolator_GetInterpolationTypeMinValue_04(HandleRef pThis);

	/// <summary>
	/// Specify which type of function to use for interpolation. By default
	/// (SetInterpolationFunctionToSpline()), cubic spline interpolation using a
	/// modified Kochanek basis is employed. Otherwise, if
	/// SetInterpolationFunctionToLinear() is invoked, linear spherical
	/// interpolation
	/// is used between each pair of quaternions.
	/// </summary>
	public virtual int GetInterpolationTypeMinValue()
	{
		return vtkQuaternionInterpolator_GetInterpolationTypeMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuaternionInterpolator_GetMaximumT_05(HandleRef pThis);

	/// <summary>
	/// Obtain some information about the interpolation range. The numbers
	/// returned (corresponding to parameter t, usually thought of as time)
	/// are undefined if the list of transforms is empty. This is a convenience
	/// method for interpolation.
	/// </summary>
	public double GetMaximumT()
	{
		return vtkQuaternionInterpolator_GetMaximumT_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuaternionInterpolator_GetMinimumT_06(HandleRef pThis);

	/// <summary>
	/// Obtain some information about the interpolation range. The numbers
	/// returned (corresponding to parameter t, usually thought of as time)
	/// are undefined if the list of transforms is empty. This is a convenience
	/// method for interpolation.
	/// </summary>
	public double GetMinimumT()
	{
		return vtkQuaternionInterpolator_GetMinimumT_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkQuaternionInterpolator_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkQuaternionInterpolator_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkQuaternionInterpolator_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkQuaternionInterpolator_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuaternionInterpolator_GetNumberOfQuaternions_09(HandleRef pThis);

	/// <summary>
	/// Return the number of quaternions in the list of quaternions to be
	/// interpolated.
	/// </summary>
	public int GetNumberOfQuaternions()
	{
		return vtkQuaternionInterpolator_GetNumberOfQuaternions_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuaternionInterpolator_GetSearchMethod_10(HandleRef pThis);

	/// <summary>
	/// Set / Get the search type method. 0 is a binary search method O(log(N))
	/// 1 is a linear search method O(N). Linear search method is kept because
	/// it can be faster than the dichotomous search method in specific cases
	/// </summary>
	public int GetSearchMethod()
	{
		return vtkQuaternionInterpolator_GetSearchMethod_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuaternionInterpolator_Initialize_11(HandleRef pThis);

	/// <summary>
	/// Reset the class so that it contains no data; i.e., the array of (t,q[4])
	/// information is discarded.
	/// </summary>
	public void Initialize()
	{
		vtkQuaternionInterpolator_Initialize_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuaternionInterpolator_InterpolateQuaternion_12(HandleRef pThis, double t, IntPtr q);

	/// <summary>
	/// Interpolate the list of quaternions and determine a new quaternion
	/// (i.e., fill in the quaternion provided). If t is outside the range of
	/// (min,max) values, then t is clamped to lie within the range.
	/// </summary>
	public void InterpolateQuaternion(double t, IntPtr q)
	{
		vtkQuaternionInterpolator_InterpolateQuaternion_12(GetCppThis(), t, q);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuaternionInterpolator_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkQuaternionInterpolator_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuaternionInterpolator_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkQuaternionInterpolator_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuaternionInterpolator_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkQuaternionInterpolator NewInstance()
	{
		vtkQuaternionInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuaternionInterpolator_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkQuaternionInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuaternionInterpolator_RemoveQuaternion_17(HandleRef pThis, double t);

	/// <summary>
	/// Delete the quaternion at a particular parameter t. If there is no
	/// quaternion tuple defined at t, then the method does nothing.
	/// </summary>
	public void RemoveQuaternion(double t)
	{
		vtkQuaternionInterpolator_RemoveQuaternion_17(GetCppThis(), t);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuaternionInterpolator_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkQuaternionInterpolator SafeDownCast(vtkObjectBase o)
	{
		vtkQuaternionInterpolator vtkQuaternionInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuaternionInterpolator_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuaternionInterpolator_SetInterpolationType_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify which type of function to use for interpolation. By default
	/// (SetInterpolationFunctionToSpline()), cubic spline interpolation using a
	/// modified Kochanek basis is employed. Otherwise, if
	/// SetInterpolationFunctionToLinear() is invoked, linear spherical
	/// interpolation
	/// is used between each pair of quaternions.
	/// </summary>
	public virtual void SetInterpolationType(int _arg)
	{
		vtkQuaternionInterpolator_SetInterpolationType_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuaternionInterpolator_SetInterpolationTypeToLinear_20(HandleRef pThis);

	/// <summary>
	/// Specify which type of function to use for interpolation. By default
	/// (SetInterpolationFunctionToSpline()), cubic spline interpolation using a
	/// modified Kochanek basis is employed. Otherwise, if
	/// SetInterpolationFunctionToLinear() is invoked, linear spherical
	/// interpolation
	/// is used between each pair of quaternions.
	/// </summary>
	public void SetInterpolationTypeToLinear()
	{
		vtkQuaternionInterpolator_SetInterpolationTypeToLinear_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuaternionInterpolator_SetInterpolationTypeToSpline_21(HandleRef pThis);

	/// <summary>
	/// Specify which type of function to use for interpolation. By default
	/// (SetInterpolationFunctionToSpline()), cubic spline interpolation using a
	/// modified Kochanek basis is employed. Otherwise, if
	/// SetInterpolationFunctionToLinear() is invoked, linear spherical
	/// interpolation
	/// is used between each pair of quaternions.
	/// </summary>
	public void SetInterpolationTypeToSpline()
	{
		vtkQuaternionInterpolator_SetInterpolationTypeToSpline_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuaternionInterpolator_SetSearchMethod_22(HandleRef pThis, int type);

	/// <summary>
	/// Set / Get the search type method. 0 is a binary search method O(log(N))
	/// 1 is a linear search method O(N). Linear search method is kept because
	/// it can be faster than the dichotomous search method in specific cases
	/// </summary>
	public void SetSearchMethod(int type)
	{
		vtkQuaternionInterpolator_SetSearchMethod_22(GetCppThis(), type);
	}
}
