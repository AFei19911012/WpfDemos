using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRungeKutta2
/// </summary>
/// <remarks>
///    Integrate an initial value problem using 2nd
/// order Runge-Kutta method.
///
///
/// This is a concrete sub-class of vtkInitialValueProblemSolver.
/// It uses a 2nd order Runge-Kutta method to obtain the values of
/// a set of functions at the next time step.
///
/// </remarks>
/// <seealso>
///
/// vtkInitialValueProblemSolver vtkRungeKutta4 vtkRungeKutta45 vtkFunctionSet
/// </seealso>
public class vtkRungeKutta2 : vtkInitialValueProblemSolver
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRungeKutta2";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRungeKutta2()
	{
		MRClassNameKey = "class vtkRungeKutta2";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRungeKutta2"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRungeKutta2(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRungeKutta2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a vtkRungeKutta2 with no initial FunctionSet.
	/// </summary>
	public new static vtkRungeKutta2 New()
	{
		vtkRungeKutta2 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRungeKutta2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRungeKutta2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a vtkRungeKutta2 with no initial FunctionSet.
	/// </summary>
	public vtkRungeKutta2()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRungeKutta2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkRungeKutta2_ComputeNextStep_01(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData);

	/// <summary>
	/// Given initial values, xprev , initial time, t and a requested time
	/// interval, delT calculate values of x at t+delT (xnext).
	/// delTActual is always equal to delT.
	/// Since this class can not provide an estimate for the error error
	/// is set to 0.
	/// maxStep, minStep and maxError are unused.
	/// This method returns an error code representing the nature of
	/// the failure:
	/// OutOfDomain = 1,
	/// NotInitialized = 2,
	/// UnexpectedValue = 3
	/// </summary>
	public override int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData)
	{
		return vtkRungeKutta2_ComputeNextStep_01(GetCppThis(), xprev, xnext, t, ref delT, maxError, ref error, userData);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRungeKutta2_ComputeNextStep_02(HandleRef pThis, IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData);

	/// <summary>
	/// Given initial values, xprev , initial time, t and a requested time
	/// interval, delT calculate values of x at t+delT (xnext).
	/// delTActual is always equal to delT.
	/// Since this class can not provide an estimate for the error error
	/// is set to 0.
	/// maxStep, minStep and maxError are unused.
	/// This method returns an error code representing the nature of
	/// the failure:
	/// OutOfDomain = 1,
	/// NotInitialized = 2,
	/// UnexpectedValue = 3
	/// </summary>
	public override int ComputeNextStep(IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error, IntPtr userData)
	{
		return vtkRungeKutta2_ComputeNextStep_02(GetCppThis(), xprev, dxprev, xnext, t, ref delT, maxError, ref error, userData);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRungeKutta2_ComputeNextStep_03(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error, IntPtr userData);

	/// <summary>
	/// Given initial values, xprev , initial time, t and a requested time
	/// interval, delT calculate values of x at t+delT (xnext).
	/// delTActual is always equal to delT.
	/// Since this class can not provide an estimate for the error error
	/// is set to 0.
	/// maxStep, minStep and maxError are unused.
	/// This method returns an error code representing the nature of
	/// the failure:
	/// OutOfDomain = 1,
	/// NotInitialized = 2,
	/// UnexpectedValue = 3
	/// </summary>
	public override int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error, IntPtr userData)
	{
		return vtkRungeKutta2_ComputeNextStep_03(GetCppThis(), xprev, xnext, t, ref delT, ref delTActual, minStep, maxStep, maxError, ref error, userData);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRungeKutta2_ComputeNextStep_04(HandleRef pThis, IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error, IntPtr userData);

	/// <summary>
	/// Given initial values, xprev , initial time, t and a requested time
	/// interval, delT calculate values of x at t+delT (xnext).
	/// delTActual is always equal to delT.
	/// Since this class can not provide an estimate for the error error
	/// is set to 0.
	/// maxStep, minStep and maxError are unused.
	/// This method returns an error code representing the nature of
	/// the failure:
	/// OutOfDomain = 1,
	/// NotInitialized = 2,
	/// UnexpectedValue = 3
	/// </summary>
	public override int ComputeNextStep(IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error, IntPtr userData)
	{
		return vtkRungeKutta2_ComputeNextStep_04(GetCppThis(), xprev, dxprev, xnext, t, ref delT, ref delTActual, minStep, maxStep, maxError, ref error, userData);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRungeKutta2_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRungeKutta2_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRungeKutta2_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRungeKutta2_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRungeKutta2_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRungeKutta2_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRungeKutta2_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRungeKutta2_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRungeKutta2_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRungeKutta2 NewInstance()
	{
		vtkRungeKutta2 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRungeKutta2_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRungeKutta2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRungeKutta2_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRungeKutta2 SafeDownCast(vtkObjectBase o)
	{
		vtkRungeKutta2 vtkRungeKutta46 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRungeKutta2_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRungeKutta46 = (vtkRungeKutta2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRungeKutta46.Register(null);
			}
		}
		return vtkRungeKutta46;
	}
}
