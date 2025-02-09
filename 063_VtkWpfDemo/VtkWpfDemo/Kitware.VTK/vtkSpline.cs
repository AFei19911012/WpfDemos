using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSpline
/// </summary>
/// <remarks>
///    spline abstract class for interpolating splines
///
/// vtkSpline interpolates a set of data points (i.e., interpolation means
/// that the spline passes through the points).  vtkSpline is an abstract
/// class: its subclasses vtkCardinalSpline and vtkKochanekSpline do the
/// interpolation. Note that this spline maps the 1D parametric coordinate
/// t into a single value x. Thus if you want to use the spline to
/// interpolate points (i.e. x[3]), you have to create three splines for
/// each of the x-y-z coordinates. Fortunately, the vtkParametricSpline
/// class does this for you.
///
/// Typically a spline is used by adding a sequence of parametric coordinate /
/// data (t,x) values followed by use of an evaluation function (e.g.,
/// vtkCardinalSpline::Evaluate()).  Since these splines are 1D, a point in
/// this context is an independent / dependent variable pair.
///
/// Splines can also be set up to be closed or open. Closed splines continue
/// from the last point to the first point with continuous function and
/// derivative values. (You don't need to duplicate the first point to close
/// the spline, just set ClosedOn.)
///
/// This implementation of splines does not use a normalized parametric
/// coordinate. If the spline is open, then the parameter space is (tMin &lt;= t
/// &lt;= tMax) where tMin and tMax are the minimum and maximum parametric values
/// seen when performing AddPoint(). If the spline is closed, then the
/// parameter space is (tMin &lt;= t &lt;= (tMax+1)) where tMin and tMax are the
/// minimum and maximum parametric values seen when performing AddPoint().
/// Note, however, that this behavior can be changed by explicitly setting
/// the ParametricRange(tMin,tMax). If set, the parameter space remains
/// (tMin &lt;= t &lt;= tMax), except that additions of data with parametric
/// values outside this range are clamped within this range.
///
/// </remarks>
/// <seealso>
///
/// vtkCardinalSpline vtkKochanekSpline vtkParametricSpline
/// vtkParametricFunctionSource
/// </seealso>
public abstract class vtkSpline : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSpline";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSpline()
	{
		MRClassNameKey = "class vtkSpline";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpline"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSpline(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpline_AddPoint_01(HandleRef pThis, double t, double x);

	/// <summary>
	/// Add a pair of points to be fit with the spline.
	/// </summary>
	public void AddPoint(double t, double x)
	{
		vtkSpline_AddPoint_01(GetCppThis(), t, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpline_ClampValueOff_02(HandleRef pThis);

	/// <summary>
	/// Set/Get ClampValue. If On, results of the interpolation will be
	/// clamped to the min/max of the input data.
	/// </summary>
	public virtual void ClampValueOff()
	{
		vtkSpline_ClampValueOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpline_ClampValueOn_03(HandleRef pThis);

	/// <summary>
	/// Set/Get ClampValue. If On, results of the interpolation will be
	/// clamped to the min/max of the input data.
	/// </summary>
	public virtual void ClampValueOn()
	{
		vtkSpline_ClampValueOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpline_ClosedOff_04(HandleRef pThis);

	/// <summary>
	/// Control whether the spline is open or closed. A closed spline forms
	/// a continuous loop: the first and last points are the same, and
	/// derivatives are continuous.
	/// </summary>
	public virtual void ClosedOff()
	{
		vtkSpline_ClosedOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpline_ClosedOn_05(HandleRef pThis);

	/// <summary>
	/// Control whether the spline is open or closed. A closed spline forms
	/// a continuous loop: the first and last points are the same, and
	/// derivatives are continuous.
	/// </summary>
	public virtual void ClosedOn()
	{
		vtkSpline_ClosedOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpline_Compute_06(HandleRef pThis);

	/// <summary>
	/// Compute the coefficients for the spline.
	/// </summary>
	public virtual void Compute()
	{
		vtkSpline_Compute_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpline_DeepCopy_07(HandleRef pThis, HandleRef s);

	/// <summary>
	/// Deep copy of spline data.
	/// </summary>
	public virtual void DeepCopy(vtkSpline s)
	{
		vtkSpline_DeepCopy_07(GetCppThis(), s?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSpline_Evaluate_08(HandleRef pThis, double t);

	/// <summary>
	/// Interpolate the value of the spline at parametric location of t.
	/// </summary>
	public virtual double Evaluate(double t)
	{
		return vtkSpline_Evaluate_08(GetCppThis(), t);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpline_GetClampValue_09(HandleRef pThis);

	/// <summary>
	/// Set/Get ClampValue. If On, results of the interpolation will be
	/// clamped to the min/max of the input data.
	/// </summary>
	public virtual int GetClampValue()
	{
		return vtkSpline_GetClampValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpline_GetClosed_10(HandleRef pThis);

	/// <summary>
	/// Control whether the spline is open or closed. A closed spline forms
	/// a continuous loop: the first and last points are the same, and
	/// derivatives are continuous.
	/// </summary>
	public virtual int GetClosed()
	{
		return vtkSpline_GetClosed_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpline_GetLeftConstraint_11(HandleRef pThis);

	/// <summary>
	/// Set the type of constraint of the left(right) end points. Four
	/// constraints are available:
	///
	/// 0: the first derivative at left(right) most point is determined
	/// from the line defined from the first(last) two points.
	///
	/// 1: the first derivative at left(right) most point is set to
	/// Left(Right)Value.
	///
	/// 2: the second derivative at left(right) most point is set to
	/// Left(Right)Value.
	///
	/// 3: the second derivative at left(right)most points is Left(Right)Value
	/// times second derivative at first interior point.
	/// </summary>
	public virtual int GetLeftConstraint()
	{
		return vtkSpline_GetLeftConstraint_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpline_GetLeftConstraintMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Set the type of constraint of the left(right) end points. Four
	/// constraints are available:
	///
	/// 0: the first derivative at left(right) most point is determined
	/// from the line defined from the first(last) two points.
	///
	/// 1: the first derivative at left(right) most point is set to
	/// Left(Right)Value.
	///
	/// 2: the second derivative at left(right) most point is set to
	/// Left(Right)Value.
	///
	/// 3: the second derivative at left(right)most points is Left(Right)Value
	/// times second derivative at first interior point.
	/// </summary>
	public virtual int GetLeftConstraintMaxValue()
	{
		return vtkSpline_GetLeftConstraintMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpline_GetLeftConstraintMinValue_13(HandleRef pThis);

	/// <summary>
	/// Set the type of constraint of the left(right) end points. Four
	/// constraints are available:
	///
	/// 0: the first derivative at left(right) most point is determined
	/// from the line defined from the first(last) two points.
	///
	/// 1: the first derivative at left(right) most point is set to
	/// Left(Right)Value.
	///
	/// 2: the second derivative at left(right) most point is set to
	/// Left(Right)Value.
	///
	/// 3: the second derivative at left(right)most points is Left(Right)Value
	/// times second derivative at first interior point.
	/// </summary>
	public virtual int GetLeftConstraintMinValue()
	{
		return vtkSpline_GetLeftConstraintMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSpline_GetLeftValue_14(HandleRef pThis);

	/// <summary>
	/// The values of the derivative on the left and right sides. The value
	/// is used only if the left(right) constraint is type 1-3.
	/// </summary>
	public virtual double GetLeftValue()
	{
		return vtkSpline_GetLeftValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkSpline_GetMTime_15(HandleRef pThis);

	/// <summary>
	/// Return the MTime also considering the Piecewise function.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkSpline_GetMTime_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpline_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSpline_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpline_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSpline_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpline_GetNumberOfPoints_18(HandleRef pThis);

	/// <summary>
	/// Return the number of points inserted thus far.
	/// </summary>
	public int GetNumberOfPoints()
	{
		return vtkSpline_GetNumberOfPoints_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpline_GetParametricRange_19(HandleRef pThis, IntPtr tRange);

	/// <summary>
	/// Set/Get the parametric range. If not set, the range is determined
	/// implicitly by keeping track of the (min,max) parameter values for
	/// t. If set, the AddPoint() method will clamp the t value to lie
	/// within the specified range.
	/// </summary>
	public void GetParametricRange(IntPtr tRange)
	{
		vtkSpline_GetParametricRange_19(GetCppThis(), tRange);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpline_GetRightConstraint_20(HandleRef pThis);

	/// <summary>
	/// Set the type of constraint of the left(right) end points. Four
	/// constraints are available:
	///
	/// 0: the first derivative at left(right) most point is determined
	/// from the line defined from the first(last) two points.
	///
	/// 1: the first derivative at left(right) most point is set to
	/// Left(Right)Value.
	///
	/// 2: the second derivative at left(right) most point is set to
	/// Left(Right)Value.
	///
	/// 3: the second derivative at left(right)most points is Left(Right)Value
	/// times second derivative at first interior point.
	/// </summary>
	public virtual int GetRightConstraint()
	{
		return vtkSpline_GetRightConstraint_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpline_GetRightConstraintMaxValue_21(HandleRef pThis);

	/// <summary>
	/// Set the type of constraint of the left(right) end points. Four
	/// constraints are available:
	///
	/// 0: the first derivative at left(right) most point is determined
	/// from the line defined from the first(last) two points.
	///
	/// 1: the first derivative at left(right) most point is set to
	/// Left(Right)Value.
	///
	/// 2: the second derivative at left(right) most point is set to
	/// Left(Right)Value.
	///
	/// 3: the second derivative at left(right)most points is Left(Right)Value
	/// times second derivative at first interior point.
	/// </summary>
	public virtual int GetRightConstraintMaxValue()
	{
		return vtkSpline_GetRightConstraintMaxValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpline_GetRightConstraintMinValue_22(HandleRef pThis);

	/// <summary>
	/// Set the type of constraint of the left(right) end points. Four
	/// constraints are available:
	///
	/// 0: the first derivative at left(right) most point is determined
	/// from the line defined from the first(last) two points.
	///
	/// 1: the first derivative at left(right) most point is set to
	/// Left(Right)Value.
	///
	/// 2: the second derivative at left(right) most point is set to
	/// Left(Right)Value.
	///
	/// 3: the second derivative at left(right)most points is Left(Right)Value
	/// times second derivative at first interior point.
	/// </summary>
	public virtual int GetRightConstraintMinValue()
	{
		return vtkSpline_GetRightConstraintMinValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSpline_GetRightValue_23(HandleRef pThis);

	/// <summary>
	/// The values of the derivative on the left and right sides. The value
	/// is used only if the left(right) constraint is type 1-3.
	/// </summary>
	public virtual double GetRightValue()
	{
		return vtkSpline_GetRightValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpline_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSpline_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpline_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSpline_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpline_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSpline NewInstance()
	{
		vtkSpline result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpline_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpline_RemoveAllPoints_27(HandleRef pThis);

	/// <summary>
	/// Remove all points from the data.
	/// </summary>
	public void RemoveAllPoints()
	{
		vtkSpline_RemoveAllPoints_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpline_RemovePoint_28(HandleRef pThis, double t);

	/// <summary>
	/// Remove a point from the data to be fit with the spline.
	/// </summary>
	public void RemovePoint(double t)
	{
		vtkSpline_RemovePoint_28(GetCppThis(), t);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpline_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSpline SafeDownCast(vtkObjectBase o)
	{
		vtkSpline vtkSpline2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpline_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpline_SetClampValue_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get ClampValue. If On, results of the interpolation will be
	/// clamped to the min/max of the input data.
	/// </summary>
	public virtual void SetClampValue(int _arg)
	{
		vtkSpline_SetClampValue_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpline_SetClosed_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether the spline is open or closed. A closed spline forms
	/// a continuous loop: the first and last points are the same, and
	/// derivatives are continuous.
	/// </summary>
	public virtual void SetClosed(int _arg)
	{
		vtkSpline_SetClosed_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpline_SetLeftConstraint_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the type of constraint of the left(right) end points. Four
	/// constraints are available:
	///
	/// 0: the first derivative at left(right) most point is determined
	/// from the line defined from the first(last) two points.
	///
	/// 1: the first derivative at left(right) most point is set to
	/// Left(Right)Value.
	///
	/// 2: the second derivative at left(right) most point is set to
	/// Left(Right)Value.
	///
	/// 3: the second derivative at left(right)most points is Left(Right)Value
	/// times second derivative at first interior point.
	/// </summary>
	public virtual void SetLeftConstraint(int _arg)
	{
		vtkSpline_SetLeftConstraint_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpline_SetLeftValue_33(HandleRef pThis, double _arg);

	/// <summary>
	/// The values of the derivative on the left and right sides. The value
	/// is used only if the left(right) constraint is type 1-3.
	/// </summary>
	public virtual void SetLeftValue(double _arg)
	{
		vtkSpline_SetLeftValue_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpline_SetParametricRange_34(HandleRef pThis, double tMin, double tMax);

	/// <summary>
	/// Set/Get the parametric range. If not set, the range is determined
	/// implicitly by keeping track of the (min,max) parameter values for
	/// t. If set, the AddPoint() method will clamp the t value to lie
	/// within the specified range.
	/// </summary>
	public void SetParametricRange(double tMin, double tMax)
	{
		vtkSpline_SetParametricRange_34(GetCppThis(), tMin, tMax);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpline_SetParametricRange_35(HandleRef pThis, IntPtr tRange);

	/// <summary>
	/// Set/Get the parametric range. If not set, the range is determined
	/// implicitly by keeping track of the (min,max) parameter values for
	/// t. If set, the AddPoint() method will clamp the t value to lie
	/// within the specified range.
	/// </summary>
	public void SetParametricRange(IntPtr tRange)
	{
		vtkSpline_SetParametricRange_35(GetCppThis(), tRange);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpline_SetRightConstraint_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the type of constraint of the left(right) end points. Four
	/// constraints are available:
	///
	/// 0: the first derivative at left(right) most point is determined
	/// from the line defined from the first(last) two points.
	///
	/// 1: the first derivative at left(right) most point is set to
	/// Left(Right)Value.
	///
	/// 2: the second derivative at left(right) most point is set to
	/// Left(Right)Value.
	///
	/// 3: the second derivative at left(right)most points is Left(Right)Value
	/// times second derivative at first interior point.
	/// </summary>
	public virtual void SetRightConstraint(int _arg)
	{
		vtkSpline_SetRightConstraint_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpline_SetRightValue_37(HandleRef pThis, double _arg);

	/// <summary>
	/// The values of the derivative on the left and right sides. The value
	/// is used only if the left(right) constraint is type 1-3.
	/// </summary>
	public virtual void SetRightValue(double _arg)
	{
		vtkSpline_SetRightValue_37(GetCppThis(), _arg);
	}
}
