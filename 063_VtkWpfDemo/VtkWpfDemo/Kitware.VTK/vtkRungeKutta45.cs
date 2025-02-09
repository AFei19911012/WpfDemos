using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRungeKutta45
/// </summary>
/// <remarks>
///    Integrate an initial value problem using 5th
/// order Runge-Kutta method with adaptive stepsize control.
///
///
/// This is a concrete sub-class of vtkInitialValueProblemSolver.
/// It uses a 5th order Runge-Kutta method with stepsize control to obtain
/// the values of a set of functions at the next time step. The stepsize
/// is adjusted by calculating an estimated error using an embedded 4th
/// order Runge-Kutta formula:
/// Press, W. H. et al., 1992, Numerical Recipes in Fortran, Second
/// Edition, Cambridge University Press
/// Cash, J.R. and Karp, A.H. 1990, ACM Transactions on Mathematical
/// Software, vol 16, pp 201-222
///
/// </remarks>
/// <seealso>
///
/// vtkInitialValueProblemSolver vtkRungeKutta4 vtkRungeKutta2 vtkFunctionSet
/// </seealso>
public class vtkRungeKutta45 : vtkInitialValueProblemSolver
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRungeKutta45";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRungeKutta45()
	{
		MRClassNameKey = "class vtkRungeKutta45";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRungeKutta45"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRungeKutta45(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRungeKutta45_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a vtkRungeKutta45 with no initial FunctionSet.
	/// </summary>
	public new static vtkRungeKutta45 New()
	{
		vtkRungeKutta45 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRungeKutta45_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRungeKutta45)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a vtkRungeKutta45 with no initial FunctionSet.
	/// </summary>
	public vtkRungeKutta45()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRungeKutta45_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkRungeKutta45_ComputeNextStep_01(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData);

	/// <summary>
	/// Given initial values, xprev , initial time, t and a requested time
	/// interval, delT calculate values of x at t+delTActual (xnext).
	/// Possibly delTActual != delT. This may occur
	/// because this solver supports adaptive stepsize control. It tries
	/// to change to stepsize such that
	/// the (estimated) error of the integration is less than maxError.
	/// The solver will not set the stepsize smaller than minStep or
	/// larger than maxStep (note that maxStep and minStep should both
	/// be positive, whereas delT can be negative).
	/// Also note that delT is an in/out argument. vtkRungeKutta45
	/// will modify delT to reflect the best (estimated) size for the next
	/// integration step.
	/// An estimated value for the error is returned (by reference) in error.
	/// This is the norm of the error vector if there are more than
	/// one function to be integrated.
	/// This method returns an error code representing the nature of
	/// the failure:
	/// OutOfDomain = 1,
	/// NotInitialized = 2,
	/// UnexpectedValue = 3
	/// </summary>
	public override int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData)
	{
		return vtkRungeKutta45_ComputeNextStep_01(GetCppThis(), xprev, xnext, t, ref delT, maxError, ref error, userData);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRungeKutta45_ComputeNextStep_02(HandleRef pThis, IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData);

	/// <summary>
	/// Given initial values, xprev , initial time, t and a requested time
	/// interval, delT calculate values of x at t+delTActual (xnext).
	/// Possibly delTActual != delT. This may occur
	/// because this solver supports adaptive stepsize control. It tries
	/// to change to stepsize such that
	/// the (estimated) error of the integration is less than maxError.
	/// The solver will not set the stepsize smaller than minStep or
	/// larger than maxStep (note that maxStep and minStep should both
	/// be positive, whereas delT can be negative).
	/// Also note that delT is an in/out argument. vtkRungeKutta45
	/// will modify delT to reflect the best (estimated) size for the next
	/// integration step.
	/// An estimated value for the error is returned (by reference) in error.
	/// This is the norm of the error vector if there are more than
	/// one function to be integrated.
	/// This method returns an error code representing the nature of
	/// the failure:
	/// OutOfDomain = 1,
	/// NotInitialized = 2,
	/// UnexpectedValue = 3
	/// </summary>
	public override int ComputeNextStep(IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData)
	{
		return vtkRungeKutta45_ComputeNextStep_02(GetCppThis(), xprev, dxprev, xnext, t, ref delT, maxError, ref error, userData);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRungeKutta45_ComputeNextStep_03(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error, IntPtr userData);

	/// <summary>
	/// Given initial values, xprev , initial time, t and a requested time
	/// interval, delT calculate values of x at t+delTActual (xnext).
	/// Possibly delTActual != delT. This may occur
	/// because this solver supports adaptive stepsize control. It tries
	/// to change to stepsize such that
	/// the (estimated) error of the integration is less than maxError.
	/// The solver will not set the stepsize smaller than minStep or
	/// larger than maxStep (note that maxStep and minStep should both
	/// be positive, whereas delT can be negative).
	/// Also note that delT is an in/out argument. vtkRungeKutta45
	/// will modify delT to reflect the best (estimated) size for the next
	/// integration step.
	/// An estimated value for the error is returned (by reference) in error.
	/// This is the norm of the error vector if there are more than
	/// one function to be integrated.
	/// This method returns an error code representing the nature of
	/// the failure:
	/// OutOfDomain = 1,
	/// NotInitialized = 2,
	/// UnexpectedValue = 3
	/// </summary>
	public override int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error, IntPtr userData)
	{
		return vtkRungeKutta45_ComputeNextStep_03(GetCppThis(), xprev, xnext, t, ref delT, ref delTActual, minStep, maxStep, maxError, ref error, userData);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRungeKutta45_ComputeNextStep_04(HandleRef pThis, IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double estErr, IntPtr userData);

	/// <summary>
	/// Given initial values, xprev , initial time, t and a requested time
	/// interval, delT calculate values of x at t+delTActual (xnext).
	/// Possibly delTActual != delT. This may occur
	/// because this solver supports adaptive stepsize control. It tries
	/// to change to stepsize such that
	/// the (estimated) error of the integration is less than maxError.
	/// The solver will not set the stepsize smaller than minStep or
	/// larger than maxStep (note that maxStep and minStep should both
	/// be positive, whereas delT can be negative).
	/// Also note that delT is an in/out argument. vtkRungeKutta45
	/// will modify delT to reflect the best (estimated) size for the next
	/// integration step.
	/// An estimated value for the error is returned (by reference) in error.
	/// This is the norm of the error vector if there are more than
	/// one function to be integrated.
	/// This method returns an error code representing the nature of
	/// the failure:
	/// OutOfDomain = 1,
	/// NotInitialized = 2,
	/// UnexpectedValue = 3
	/// </summary>
	public override int ComputeNextStep(IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double estErr, IntPtr userData)
	{
		return vtkRungeKutta45_ComputeNextStep_04(GetCppThis(), xprev, dxprev, xnext, t, ref delT, ref delTActual, minStep, maxStep, maxError, ref estErr, userData);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRungeKutta45_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRungeKutta45_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRungeKutta45_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRungeKutta45_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRungeKutta45_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRungeKutta45_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRungeKutta45_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRungeKutta45_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRungeKutta45_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRungeKutta45 NewInstance()
	{
		vtkRungeKutta45 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRungeKutta45_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRungeKutta45)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRungeKutta45_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRungeKutta45 SafeDownCast(vtkObjectBase o)
	{
		vtkRungeKutta45 vtkRungeKutta46 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRungeKutta45_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRungeKutta46 = (vtkRungeKutta45)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRungeKutta46.Register(null);
			}
		}
		return vtkRungeKutta46;
	}
}
