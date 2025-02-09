using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInitialValueProblemSolver
/// </summary>
/// <remarks>
///    Integrate a set of ordinary
/// differential equations (initial value problem) in time.
///
///
/// Given a vtkFunctionSet which returns dF_i(x_j, t)/dt given x_j and
/// t, vtkInitialValueProblemSolver computes the value of F_i at t+deltat.
///
/// @warning
/// vtkInitialValueProblemSolver and it's subclasses are not thread-safe.
/// You should create a new integrator for each thread.
///
/// </remarks>
/// <seealso>
///
/// vtkRungeKutta2 vtkRungeKutta4
/// </seealso>
public class vtkInitialValueProblemSolver : vtkObject
{
	/// <summary>
	/// Returns 1 if the solver uses adaptive stepsize control,
	/// 0 otherwise
	/// </summary>
	public enum ErrorCodes
	{
		/// <summary>enum member</summary>
		NOT_INITIALIZED = 2,
		/// <summary>enum member</summary>
		OUT_OF_DOMAIN = 1,
		/// <summary>enum member</summary>
		UNEXPECTED_VALUE = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInitialValueProblemSolver";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInitialValueProblemSolver()
	{
		MRClassNameKey = "class vtkInitialValueProblemSolver";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInitialValueProblemSolver"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInitialValueProblemSolver(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInitialValueProblemSolver_ComputeNextStep_01(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error);

	/// <summary>
	/// Given initial values, xprev , initial time, t and a requested time
	/// interval, delT calculate values of x at t+delTActual (xnext).
	/// For certain concrete sub-classes delTActual != delT. This occurs
	/// when the solver supports adaptive stepsize control. If this
	/// is the case, the solver tries to change to stepsize such that
	/// the (estimated) error of the integration is less than maxError.
	/// The solver will not set the stepsize smaller than minStep or
	/// larger than maxStep.
	/// Also note that delT is an in/out argument. Adaptive solvers
	/// will modify delT to reflect the best (estimated) size for the next
	/// integration step.
	/// An estimated value for the error is returned (by reference) in error.
	/// Note that only some concrete sub-classes support this. Otherwise,
	/// the error is set to 0.
	/// This method returns an error code representing the nature of
	/// the failure:
	/// OutOfDomain = 1,
	/// NotInitialized = 2,
	/// UnexpectedValue = 3
	/// </summary>
	public virtual int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error)
	{
		return vtkInitialValueProblemSolver_ComputeNextStep_01(GetCppThis(), xprev, xnext, t, ref delT, maxError, ref error);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInitialValueProblemSolver_ComputeNextStep_02(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData);

	/// <summary>
	/// Given initial values, xprev , initial time, t and a requested time
	/// interval, delT calculate values of x at t+delTActual (xnext).
	/// For certain concrete sub-classes delTActual != delT. This occurs
	/// when the solver supports adaptive stepsize control. If this
	/// is the case, the solver tries to change to stepsize such that
	/// the (estimated) error of the integration is less than maxError.
	/// The solver will not set the stepsize smaller than minStep or
	/// larger than maxStep.
	/// Also note that delT is an in/out argument. Adaptive solvers
	/// will modify delT to reflect the best (estimated) size for the next
	/// integration step.
	/// An estimated value for the error is returned (by reference) in error.
	/// Note that only some concrete sub-classes support this. Otherwise,
	/// the error is set to 0.
	/// This method returns an error code representing the nature of
	/// the failure:
	/// OutOfDomain = 1,
	/// NotInitialized = 2,
	/// UnexpectedValue = 3
	/// </summary>
	public virtual int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData)
	{
		return vtkInitialValueProblemSolver_ComputeNextStep_02(GetCppThis(), xprev, xnext, t, ref delT, maxError, ref error, userData);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInitialValueProblemSolver_ComputeNextStep_03(HandleRef pThis, IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error);

	/// <summary>
	/// Given initial values, xprev , initial time, t and a requested time
	/// interval, delT calculate values of x at t+delTActual (xnext).
	/// For certain concrete sub-classes delTActual != delT. This occurs
	/// when the solver supports adaptive stepsize control. If this
	/// is the case, the solver tries to change to stepsize such that
	/// the (estimated) error of the integration is less than maxError.
	/// The solver will not set the stepsize smaller than minStep or
	/// larger than maxStep.
	/// Also note that delT is an in/out argument. Adaptive solvers
	/// will modify delT to reflect the best (estimated) size for the next
	/// integration step.
	/// An estimated value for the error is returned (by reference) in error.
	/// Note that only some concrete sub-classes support this. Otherwise,
	/// the error is set to 0.
	/// This method returns an error code representing the nature of
	/// the failure:
	/// OutOfDomain = 1,
	/// NotInitialized = 2,
	/// UnexpectedValue = 3
	/// </summary>
	public virtual int ComputeNextStep(IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error)
	{
		return vtkInitialValueProblemSolver_ComputeNextStep_03(GetCppThis(), xprev, dxprev, xnext, t, ref delT, maxError, ref error);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInitialValueProblemSolver_ComputeNextStep_04(HandleRef pThis, IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData);

	/// <summary>
	/// Given initial values, xprev , initial time, t and a requested time
	/// interval, delT calculate values of x at t+delTActual (xnext).
	/// For certain concrete sub-classes delTActual != delT. This occurs
	/// when the solver supports adaptive stepsize control. If this
	/// is the case, the solver tries to change to stepsize such that
	/// the (estimated) error of the integration is less than maxError.
	/// The solver will not set the stepsize smaller than minStep or
	/// larger than maxStep.
	/// Also note that delT is an in/out argument. Adaptive solvers
	/// will modify delT to reflect the best (estimated) size for the next
	/// integration step.
	/// An estimated value for the error is returned (by reference) in error.
	/// Note that only some concrete sub-classes support this. Otherwise,
	/// the error is set to 0.
	/// This method returns an error code representing the nature of
	/// the failure:
	/// OutOfDomain = 1,
	/// NotInitialized = 2,
	/// UnexpectedValue = 3
	/// </summary>
	public virtual int ComputeNextStep(IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData)
	{
		return vtkInitialValueProblemSolver_ComputeNextStep_04(GetCppThis(), xprev, dxprev, xnext, t, ref delT, maxError, ref error, userData);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInitialValueProblemSolver_ComputeNextStep_05(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error);

	/// <summary>
	/// Given initial values, xprev , initial time, t and a requested time
	/// interval, delT calculate values of x at t+delTActual (xnext).
	/// For certain concrete sub-classes delTActual != delT. This occurs
	/// when the solver supports adaptive stepsize control. If this
	/// is the case, the solver tries to change to stepsize such that
	/// the (estimated) error of the integration is less than maxError.
	/// The solver will not set the stepsize smaller than minStep or
	/// larger than maxStep.
	/// Also note that delT is an in/out argument. Adaptive solvers
	/// will modify delT to reflect the best (estimated) size for the next
	/// integration step.
	/// An estimated value for the error is returned (by reference) in error.
	/// Note that only some concrete sub-classes support this. Otherwise,
	/// the error is set to 0.
	/// This method returns an error code representing the nature of
	/// the failure:
	/// OutOfDomain = 1,
	/// NotInitialized = 2,
	/// UnexpectedValue = 3
	/// </summary>
	public virtual int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error)
	{
		return vtkInitialValueProblemSolver_ComputeNextStep_05(GetCppThis(), xprev, xnext, t, ref delT, ref delTActual, minStep, maxStep, maxError, ref error);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInitialValueProblemSolver_ComputeNextStep_06(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error, IntPtr userData);

	/// <summary>
	/// Given initial values, xprev , initial time, t and a requested time
	/// interval, delT calculate values of x at t+delTActual (xnext).
	/// For certain concrete sub-classes delTActual != delT. This occurs
	/// when the solver supports adaptive stepsize control. If this
	/// is the case, the solver tries to change to stepsize such that
	/// the (estimated) error of the integration is less than maxError.
	/// The solver will not set the stepsize smaller than minStep or
	/// larger than maxStep.
	/// Also note that delT is an in/out argument. Adaptive solvers
	/// will modify delT to reflect the best (estimated) size for the next
	/// integration step.
	/// An estimated value for the error is returned (by reference) in error.
	/// Note that only some concrete sub-classes support this. Otherwise,
	/// the error is set to 0.
	/// This method returns an error code representing the nature of
	/// the failure:
	/// OutOfDomain = 1,
	/// NotInitialized = 2,
	/// UnexpectedValue = 3
	/// </summary>
	public virtual int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error, IntPtr userData)
	{
		return vtkInitialValueProblemSolver_ComputeNextStep_06(GetCppThis(), xprev, xnext, t, ref delT, ref delTActual, minStep, maxStep, maxError, ref error, userData);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInitialValueProblemSolver_ComputeNextStep_07(HandleRef pThis, IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error);

	/// <summary>
	/// Given initial values, xprev , initial time, t and a requested time
	/// interval, delT calculate values of x at t+delTActual (xnext).
	/// For certain concrete sub-classes delTActual != delT. This occurs
	/// when the solver supports adaptive stepsize control. If this
	/// is the case, the solver tries to change to stepsize such that
	/// the (estimated) error of the integration is less than maxError.
	/// The solver will not set the stepsize smaller than minStep or
	/// larger than maxStep.
	/// Also note that delT is an in/out argument. Adaptive solvers
	/// will modify delT to reflect the best (estimated) size for the next
	/// integration step.
	/// An estimated value for the error is returned (by reference) in error.
	/// Note that only some concrete sub-classes support this. Otherwise,
	/// the error is set to 0.
	/// This method returns an error code representing the nature of
	/// the failure:
	/// OutOfDomain = 1,
	/// NotInitialized = 2,
	/// UnexpectedValue = 3
	/// </summary>
	public virtual int ComputeNextStep(IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error)
	{
		return vtkInitialValueProblemSolver_ComputeNextStep_07(GetCppThis(), xprev, dxprev, xnext, t, ref delT, ref delTActual, minStep, maxStep, maxError, ref error);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInitialValueProblemSolver_ComputeNextStep_08(HandleRef pThis, IntPtr arg0, IntPtr arg1, IntPtr arg2, double arg3, ref double arg4, ref double arg5, double arg6, double arg7, double arg8, ref double arg9, IntPtr arg10);

	/// <summary>
	/// Given initial values, xprev , initial time, t and a requested time
	/// interval, delT calculate values of x at t+delTActual (xnext).
	/// For certain concrete sub-classes delTActual != delT. This occurs
	/// when the solver supports adaptive stepsize control. If this
	/// is the case, the solver tries to change to stepsize such that
	/// the (estimated) error of the integration is less than maxError.
	/// The solver will not set the stepsize smaller than minStep or
	/// larger than maxStep.
	/// Also note that delT is an in/out argument. Adaptive solvers
	/// will modify delT to reflect the best (estimated) size for the next
	/// integration step.
	/// An estimated value for the error is returned (by reference) in error.
	/// Note that only some concrete sub-classes support this. Otherwise,
	/// the error is set to 0.
	/// This method returns an error code representing the nature of
	/// the failure:
	/// OutOfDomain = 1,
	/// NotInitialized = 2,
	/// UnexpectedValue = 3
	/// </summary>
	public virtual int ComputeNextStep(IntPtr arg0, IntPtr arg1, IntPtr arg2, double arg3, ref double arg4, ref double arg5, double arg6, double arg7, double arg8, ref double arg9, IntPtr arg10)
	{
		return vtkInitialValueProblemSolver_ComputeNextStep_08(GetCppThis(), arg0, arg1, arg2, arg3, ref arg4, ref arg5, arg6, arg7, arg8, ref arg9, arg10);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInitialValueProblemSolver_GetFunctionSet_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / get the dataset used for the implicit function evaluation.
	/// </summary>
	public virtual vtkFunctionSet GetFunctionSet()
	{
		vtkFunctionSet vtkFunctionSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInitialValueProblemSolver_GetFunctionSet_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFunctionSet2 = (vtkFunctionSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFunctionSet2.Register(null);
			}
		}
		return vtkFunctionSet2;
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInitialValueProblemSolver_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInitialValueProblemSolver_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInitialValueProblemSolver_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInitialValueProblemSolver_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInitialValueProblemSolver_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInitialValueProblemSolver_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInitialValueProblemSolver_IsAdaptive_13(HandleRef pThis);

	/// <summary>
	/// Returns 1 if the solver uses adaptive stepsize control,
	/// 0 otherwise
	/// </summary>
	public virtual int IsAdaptive()
	{
		return vtkInitialValueProblemSolver_IsAdaptive_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInitialValueProblemSolver_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInitialValueProblemSolver_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInitialValueProblemSolver_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInitialValueProblemSolver NewInstance()
	{
		vtkInitialValueProblemSolver result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInitialValueProblemSolver_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInitialValueProblemSolver)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInitialValueProblemSolver_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInitialValueProblemSolver SafeDownCast(vtkObjectBase o)
	{
		vtkInitialValueProblemSolver vtkInitialValueProblemSolver2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInitialValueProblemSolver_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInitialValueProblemSolver2 = (vtkInitialValueProblemSolver)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInitialValueProblemSolver2.Register(null);
			}
		}
		return vtkInitialValueProblemSolver2;
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInitialValueProblemSolver_SetFunctionSet_17(HandleRef pThis, HandleRef fset);

	/// <summary>
	/// Set / get the dataset used for the implicit function evaluation.
	/// </summary>
	public virtual void SetFunctionSet(vtkFunctionSet fset)
	{
		vtkInitialValueProblemSolver_SetFunctionSet_17(GetCppThis(), fset?.GetCppThis() ?? default(HandleRef));
	}
}
