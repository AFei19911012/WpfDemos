using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkParametricSpline
/// </summary>
/// <remarks>
///    parametric function for 1D interpolating splines
///
/// vtkParametricSpline is a parametric function for 1D interpolating splines.
/// vtkParametricSpline maps the single parameter u into a 3D point (x,y,z)
/// using three instances of interpolating splines.  This family of 1D splines
/// is guaranteed to be parameterized in the interval [0,1].  Attempting to
/// evaluate outside this interval will cause the parameter u to be clamped in
/// the range [0,1].
///
/// When constructed, this class creates instances of vtkCardinalSpline for
/// each of the x-y-z coordinates. The user may choose to replace these with
/// their own instances of subclasses of vtkSpline.
///
/// @warning
/// If you wish to tessellate the spline, use the class
/// vtkParametricFunctionSource.
///
/// </remarks>
/// <seealso>
///
/// vtkSpline vtkKochanekSpline vtkCardinalSpline
/// </seealso>
public class vtkParametricSpline : vtkParametricFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkParametricSpline";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkParametricSpline()
	{
		MRClassNameKey = "class vtkParametricSpline";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricSpline"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkParametricSpline(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricSpline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct the spline with the following parameters:
	/// MinimumU = 0, MaximumU = 1, JoinU = 0 (unless the spline is
	/// closed, then JoinU = 1), TwistU = 0, DerivativesSupplied = 0
	/// (the other vtkParametricFunction parameters are ignored).
	/// </summary>
	public new static vtkParametricSpline New()
	{
		vtkParametricSpline result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricSpline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParametricSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct the spline with the following parameters:
	/// MinimumU = 0, MaximumU = 1, JoinU = 0 (unless the spline is
	/// closed, then JoinU = 1), TwistU = 0, DerivativesSupplied = 0
	/// (the other vtkParametricFunction parameters are ignored).
	/// </summary>
	public vtkParametricSpline()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkParametricSpline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSpline_ClosedOff_01(HandleRef pThis);

	/// <summary>
	/// Control whether the spline is open or closed. A closed spline forms
	/// a continuous loop: the first and last points are the same, and
	/// derivatives are continuous.
	/// </summary>
	public virtual void ClosedOff()
	{
		vtkParametricSpline_ClosedOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSpline_ClosedOn_02(HandleRef pThis);

	/// <summary>
	/// Control whether the spline is open or closed. A closed spline forms
	/// a continuous loop: the first and last points are the same, and
	/// derivatives are continuous.
	/// </summary>
	public virtual void ClosedOn()
	{
		vtkParametricSpline_ClosedOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSpline_Evaluate_03(HandleRef pThis, IntPtr u, IntPtr Pt, IntPtr Du);

	/// <summary>
	/// Evaluate the spline at parametric coordinate u[0] returning
	/// the point coordinate Pt[3].
	/// </summary>
	public override void Evaluate(IntPtr u, IntPtr Pt, IntPtr Du)
	{
		vtkParametricSpline_Evaluate_03(GetCppThis(), u, Pt, Du);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricSpline_EvaluateScalar_04(HandleRef pThis, IntPtr u, IntPtr Pt, IntPtr Du);

	/// <summary>
	/// Evaluate a scalar value at parametric coordinate u[0] and Pt[3].
	/// The scalar value is just the parameter u[0].
	/// </summary>
	public override double EvaluateScalar(IntPtr u, IntPtr Pt, IntPtr Du)
	{
		return vtkParametricSpline_EvaluateScalar_04(GetCppThis(), u, Pt, Du);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricSpline_GetClosed_05(HandleRef pThis);

	/// <summary>
	/// Control whether the spline is open or closed. A closed spline forms
	/// a continuous loop: the first and last points are the same, and
	/// derivatives are continuous.
	/// </summary>
	public virtual int GetClosed()
	{
		return vtkParametricSpline_GetClosed_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricSpline_GetDimension_06(HandleRef pThis);

	/// <summary>
	/// Return the parametric dimension of the class.
	/// </summary>
	public override int GetDimension()
	{
		return vtkParametricSpline_GetDimension_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricSpline_GetLeftConstraint_07(HandleRef pThis);

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
		return vtkParametricSpline_GetLeftConstraint_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricSpline_GetLeftConstraintMaxValue_08(HandleRef pThis);

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
		return vtkParametricSpline_GetLeftConstraintMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricSpline_GetLeftConstraintMinValue_09(HandleRef pThis);

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
		return vtkParametricSpline_GetLeftConstraintMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricSpline_GetLeftValue_10(HandleRef pThis);

	/// <summary>
	/// The values of the derivative on the left and right sides. The value
	/// is used only if the left(right) constraint is type 1-3.
	/// </summary>
	public virtual double GetLeftValue()
	{
		return vtkParametricSpline_GetLeftValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParametricSpline_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkParametricSpline_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParametricSpline_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkParametricSpline_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricSpline_GetParameterizeByLength_13(HandleRef pThis);

	/// <summary>
	/// Control whether the spline is parameterized by length or by point index.
	/// Default is by length.
	/// </summary>
	public virtual int GetParameterizeByLength()
	{
		return vtkParametricSpline_GetParameterizeByLength_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricSpline_GetPoints_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the list of points defining the spline. Do this by
	/// specifying a vtkPoints array containing the points. Note that
	/// the order of the points in vtkPoints is the order that the
	/// splines will be fit.
	/// </summary>
	public virtual vtkPoints GetPoints()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricSpline_GetPoints_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricSpline_GetRightConstraint_15(HandleRef pThis);

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
		return vtkParametricSpline_GetRightConstraint_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricSpline_GetRightConstraintMaxValue_16(HandleRef pThis);

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
		return vtkParametricSpline_GetRightConstraintMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricSpline_GetRightConstraintMinValue_17(HandleRef pThis);

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
		return vtkParametricSpline_GetRightConstraintMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricSpline_GetRightValue_18(HandleRef pThis);

	/// <summary>
	/// The values of the derivative on the left and right sides. The value
	/// is used only if the left(right) constraint is type 1-3.
	/// </summary>
	public virtual double GetRightValue()
	{
		return vtkParametricSpline_GetRightValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricSpline_GetXSpline_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// By default, this class is constructed with three instances of
	/// vtkCardinalSpline (for each of the x-y-z coordinate axes). The user may
	/// choose to create and assign their own instances of vtkSpline.
	/// </summary>
	public virtual vtkSpline GetXSpline()
	{
		vtkSpline vtkSpline2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricSpline_GetXSpline_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricSpline_GetYSpline_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// By default, this class is constructed with three instances of
	/// vtkCardinalSpline (for each of the x-y-z coordinate axes). The user may
	/// choose to create and assign their own instances of vtkSpline.
	/// </summary>
	public virtual vtkSpline GetYSpline()
	{
		vtkSpline vtkSpline2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricSpline_GetYSpline_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricSpline_GetZSpline_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// By default, this class is constructed with three instances of
	/// vtkCardinalSpline (for each of the x-y-z coordinate axes). The user may
	/// choose to create and assign their own instances of vtkSpline.
	/// </summary>
	public virtual vtkSpline GetZSpline()
	{
		vtkSpline vtkSpline2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricSpline_GetZSpline_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricSpline_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkParametricSpline_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricSpline_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkParametricSpline_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricSpline_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkParametricSpline NewInstance()
	{
		vtkParametricSpline result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricSpline_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParametricSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSpline_ParameterizeByLengthOff_26(HandleRef pThis);

	/// <summary>
	/// Control whether the spline is parameterized by length or by point index.
	/// Default is by length.
	/// </summary>
	public virtual void ParameterizeByLengthOff()
	{
		vtkParametricSpline_ParameterizeByLengthOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSpline_ParameterizeByLengthOn_27(HandleRef pThis);

	/// <summary>
	/// Control whether the spline is parameterized by length or by point index.
	/// Default is by length.
	/// </summary>
	public virtual void ParameterizeByLengthOn()
	{
		vtkParametricSpline_ParameterizeByLengthOn_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricSpline_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParametricSpline SafeDownCast(vtkObjectBase o)
	{
		vtkParametricSpline vtkParametricSpline2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricSpline_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSpline_SetClosed_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether the spline is open or closed. A closed spline forms
	/// a continuous loop: the first and last points are the same, and
	/// derivatives are continuous.
	/// </summary>
	public virtual void SetClosed(int _arg)
	{
		vtkParametricSpline_SetClosed_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSpline_SetLeftConstraint_30(HandleRef pThis, int _arg);

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
		vtkParametricSpline_SetLeftConstraint_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSpline_SetLeftValue_31(HandleRef pThis, double _arg);

	/// <summary>
	/// The values of the derivative on the left and right sides. The value
	/// is used only if the left(right) constraint is type 1-3.
	/// </summary>
	public virtual void SetLeftValue(double _arg)
	{
		vtkParametricSpline_SetLeftValue_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSpline_SetNumberOfPoints_32(HandleRef pThis, long numPts);

	/// <summary>
	/// Another API to set the points. Set the number of points and then set the
	/// individual point coordinates.
	/// </summary>
	public void SetNumberOfPoints(long numPts)
	{
		vtkParametricSpline_SetNumberOfPoints_32(GetCppThis(), numPts);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSpline_SetParameterizeByLength_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Control whether the spline is parameterized by length or by point index.
	/// Default is by length.
	/// </summary>
	public virtual void SetParameterizeByLength(int _arg)
	{
		vtkParametricSpline_SetParameterizeByLength_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSpline_SetPoint_34(HandleRef pThis, long index, double x, double y, double z);

	/// <summary>
	/// Another API to set the points. Set the number of points and then set the
	/// individual point coordinates.
	/// </summary>
	public void SetPoint(long index, double x, double y, double z)
	{
		vtkParametricSpline_SetPoint_34(GetCppThis(), index, x, y, z);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSpline_SetPoints_35(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the list of points defining the spline. Do this by
	/// specifying a vtkPoints array containing the points. Note that
	/// the order of the points in vtkPoints is the order that the
	/// splines will be fit.
	/// </summary>
	public void SetPoints(vtkPoints arg0)
	{
		vtkParametricSpline_SetPoints_35(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSpline_SetRightConstraint_36(HandleRef pThis, int _arg);

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
		vtkParametricSpline_SetRightConstraint_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSpline_SetRightValue_37(HandleRef pThis, double _arg);

	/// <summary>
	/// The values of the derivative on the left and right sides. The value
	/// is used only if the left(right) constraint is type 1-3.
	/// </summary>
	public virtual void SetRightValue(double _arg)
	{
		vtkParametricSpline_SetRightValue_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSpline_SetXSpline_38(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// By default, this class is constructed with three instances of
	/// vtkCardinalSpline (for each of the x-y-z coordinate axes). The user may
	/// choose to create and assign their own instances of vtkSpline.
	/// </summary>
	public void SetXSpline(vtkSpline arg0)
	{
		vtkParametricSpline_SetXSpline_38(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSpline_SetYSpline_39(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// By default, this class is constructed with three instances of
	/// vtkCardinalSpline (for each of the x-y-z coordinate axes). The user may
	/// choose to create and assign their own instances of vtkSpline.
	/// </summary>
	public void SetYSpline(vtkSpline arg0)
	{
		vtkParametricSpline_SetYSpline_39(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricSpline_SetZSpline_40(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// By default, this class is constructed with three instances of
	/// vtkCardinalSpline (for each of the x-y-z coordinate axes). The user may
	/// choose to create and assign their own instances of vtkSpline.
	/// </summary>
	public void SetZSpline(vtkSpline arg0)
	{
		vtkParametricSpline_SetZSpline_40(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
