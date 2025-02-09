using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTupleInterpolator
/// </summary>
/// <remarks>
///    interpolate a tuple of arbitrary size
///
/// This class is used to interpolate a tuple which may have an arbitrary
/// number of components (but at least one component). The interpolation may
/// be linear in form, or via a subclasses of vtkSpline.
///
/// To use this class, begin by specifying the number of components of the
/// tuple and the interpolation function to use. Then specify at least one
/// pair of (t,tuple) with the AddTuple() method.  Next interpolate the
/// tuples with the InterpolateTuple(t,tuple) method, where "t" must be in the
/// range of (t_min,t_max) parameter values specified by the AddTuple() method
/// (if not then t is clamped), and tuple[] is filled in by the method (make
/// sure that tuple [] is long enough to hold the interpolated data).
///
/// You can control the type of interpolation to use. By default, the
/// interpolation is based on a Kochanek spline. However, other types of
/// splines can be specified. You can also set the interpolation method
/// to linear, in which case the specified spline has no effect on the
/// interpolation.
///
/// @warning
/// Setting the number of components or changing the type of interpolation
/// causes the list of tuples to be reset, so any data inserted up to that
/// point is lost. Bisection methods are used to speed up the search for the
/// interpolation interval.
/// </remarks>
public class vtkTupleInterpolator : vtkObject
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
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTupleInterpolator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTupleInterpolator()
	{
		MRClassNameKey = "class vtkTupleInterpolator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTupleInterpolator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTupleInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTupleInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkTupleInterpolator New()
	{
		vtkTupleInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTupleInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkTupleInterpolator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTupleInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTupleInterpolator_AddTuple_01(HandleRef pThis, double t, IntPtr tuple);

	/// <summary>
	/// Add another tuple to the list of tuples to be interpolated.  Note that
	/// using the same time t value more than once replaces the previous tuple
	/// value at t.  At least two tuples must be added to define an
	/// interpolation function.
	/// </summary>
	public void AddTuple(double t, IntPtr tuple)
	{
		vtkTupleInterpolator_AddTuple_01(GetCppThis(), t, tuple);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTupleInterpolator_GetInterpolatingSpline_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If the InterpolationType is set to spline, then this method applies. By
	/// default Kochanek interpolation is used, but you can specify any instance
	/// of vtkSpline to use. Note that the actual interpolating splines are
	/// created by invoking NewInstance() followed by DeepCopy() on the
	/// interpolating spline specified here, for each tuple component to
	/// interpolate.
	/// </summary>
	public virtual vtkSpline GetInterpolatingSpline()
	{
		vtkSpline vtkSpline2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTupleInterpolator_GetInterpolatingSpline_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSpline2 = (vtkSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSpline2.Register(null);
			}
		}
		return vtkSpline2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTupleInterpolator_GetInterpolationType_03(HandleRef pThis);

	/// <summary>
	/// Specify which type of function to use for interpolation. By default
	/// spline interpolation (SetInterpolationFunctionToSpline()) is used
	/// (i.e., a Kochanek spline) and the InterpolatingSpline instance variable
	/// is used to birth the actual interpolation splines via a combination of
	/// NewInstance() and DeepCopy(). You may also choose to use linear
	/// interpolation by invoking SetInterpolationFunctionToLinear(). Note that
	/// changing the type of interpolation causes previously inserted data
	/// to be discarded.
	/// </summary>
	public virtual int GetInterpolationType()
	{
		return vtkTupleInterpolator_GetInterpolationType_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTupleInterpolator_GetMaximumT_04(HandleRef pThis);

	/// <summary>
	/// Obtain some information about the interpolation range. The numbers
	/// returned (corresponding to parameter t, usually thought of as time)
	/// are undefined if the list of transforms is empty. This is a convenience
	/// method for interpolation.
	/// </summary>
	public double GetMaximumT()
	{
		return vtkTupleInterpolator_GetMaximumT_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTupleInterpolator_GetMinimumT_05(HandleRef pThis);

	/// <summary>
	/// Obtain some information about the interpolation range. The numbers
	/// returned (corresponding to parameter t, usually thought of as time)
	/// are undefined if the list of transforms is empty. This is a convenience
	/// method for interpolation.
	/// </summary>
	public double GetMinimumT()
	{
		return vtkTupleInterpolator_GetMinimumT_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTupleInterpolator_GetNumberOfComponents_06(HandleRef pThis);

	/// <summary>
	/// Specify the number of tuple components to interpolate. Note that setting
	/// this value discards any previously inserted data.
	/// </summary>
	public virtual int GetNumberOfComponents()
	{
		return vtkTupleInterpolator_GetNumberOfComponents_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTupleInterpolator_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTupleInterpolator_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTupleInterpolator_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTupleInterpolator_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTupleInterpolator_GetNumberOfTuples_09(HandleRef pThis);

	/// <summary>
	/// Return the number of tuples in the list of tuples to be
	/// interpolated.
	/// </summary>
	public int GetNumberOfTuples()
	{
		return vtkTupleInterpolator_GetNumberOfTuples_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTupleInterpolator_Initialize_10(HandleRef pThis);

	/// <summary>
	/// Reset the class so that it contains no (t,tuple) information.
	/// </summary>
	public void Initialize()
	{
		vtkTupleInterpolator_Initialize_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTupleInterpolator_InterpolateTuple_11(HandleRef pThis, double t, IntPtr tuple);

	/// <summary>
	/// Interpolate the list of tuples and determine a new tuple (i.e.,
	/// fill in the tuple provided). If t is outside the range of
	/// (min,max) values, then t is clamped. Note that each component
	/// of tuple[] is interpolated independently.
	/// </summary>
	public void InterpolateTuple(double t, IntPtr tuple)
	{
		vtkTupleInterpolator_InterpolateTuple_11(GetCppThis(), t, tuple);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTupleInterpolator_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTupleInterpolator_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTupleInterpolator_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTupleInterpolator_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTupleInterpolator_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTupleInterpolator NewInstance()
	{
		vtkTupleInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTupleInterpolator_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTupleInterpolator_RemoveTuple_16(HandleRef pThis, double t);

	/// <summary>
	/// Delete the tuple at a particular parameter t. If there is no
	/// tuple defined at t, then the method does nothing.
	/// </summary>
	public void RemoveTuple(double t)
	{
		vtkTupleInterpolator_RemoveTuple_16(GetCppThis(), t);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTupleInterpolator_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTupleInterpolator SafeDownCast(vtkObjectBase o)
	{
		vtkTupleInterpolator vtkTupleInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTupleInterpolator_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTupleInterpolator_SetInterpolatingSpline_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// If the InterpolationType is set to spline, then this method applies. By
	/// default Kochanek interpolation is used, but you can specify any instance
	/// of vtkSpline to use. Note that the actual interpolating splines are
	/// created by invoking NewInstance() followed by DeepCopy() on the
	/// interpolating spline specified here, for each tuple component to
	/// interpolate.
	/// </summary>
	public void SetInterpolatingSpline(vtkSpline arg0)
	{
		vtkTupleInterpolator_SetInterpolatingSpline_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTupleInterpolator_SetInterpolationType_19(HandleRef pThis, int type);

	/// <summary>
	/// Specify which type of function to use for interpolation. By default
	/// spline interpolation (SetInterpolationFunctionToSpline()) is used
	/// (i.e., a Kochanek spline) and the InterpolatingSpline instance variable
	/// is used to birth the actual interpolation splines via a combination of
	/// NewInstance() and DeepCopy(). You may also choose to use linear
	/// interpolation by invoking SetInterpolationFunctionToLinear(). Note that
	/// changing the type of interpolation causes previously inserted data
	/// to be discarded.
	/// </summary>
	public void SetInterpolationType(int type)
	{
		vtkTupleInterpolator_SetInterpolationType_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTupleInterpolator_SetInterpolationTypeToLinear_20(HandleRef pThis);

	/// <summary>
	/// Specify which type of function to use for interpolation. By default
	/// spline interpolation (SetInterpolationFunctionToSpline()) is used
	/// (i.e., a Kochanek spline) and the InterpolatingSpline instance variable
	/// is used to birth the actual interpolation splines via a combination of
	/// NewInstance() and DeepCopy(). You may also choose to use linear
	/// interpolation by invoking SetInterpolationFunctionToLinear(). Note that
	/// changing the type of interpolation causes previously inserted data
	/// to be discarded.
	/// </summary>
	public void SetInterpolationTypeToLinear()
	{
		vtkTupleInterpolator_SetInterpolationTypeToLinear_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTupleInterpolator_SetInterpolationTypeToSpline_21(HandleRef pThis);

	/// <summary>
	/// Specify which type of function to use for interpolation. By default
	/// spline interpolation (SetInterpolationFunctionToSpline()) is used
	/// (i.e., a Kochanek spline) and the InterpolatingSpline instance variable
	/// is used to birth the actual interpolation splines via a combination of
	/// NewInstance() and DeepCopy(). You may also choose to use linear
	/// interpolation by invoking SetInterpolationFunctionToLinear(). Note that
	/// changing the type of interpolation causes previously inserted data
	/// to be discarded.
	/// </summary>
	public void SetInterpolationTypeToSpline()
	{
		vtkTupleInterpolator_SetInterpolationTypeToSpline_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTupleInterpolator_SetNumberOfComponents_22(HandleRef pThis, int numComp);

	/// <summary>
	/// Specify the number of tuple components to interpolate. Note that setting
	/// this value discards any previously inserted data.
	/// </summary>
	public void SetNumberOfComponents(int numComp)
	{
		vtkTupleInterpolator_SetNumberOfComponents_22(GetCppThis(), numComp);
	}
}
