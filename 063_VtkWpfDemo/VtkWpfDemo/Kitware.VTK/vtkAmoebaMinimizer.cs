using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAmoebaMinimizer
/// </summary>
/// <remarks>
///    nonlinear optimization with a simplex
///
/// vtkAmoebaMinimizer will modify a set of parameters in order to find
/// the minimum of a specified function.  The method used is commonly
/// known as the amoeba method, it constructs an n-dimensional simplex
/// in parameter space (i.e. a tetrahedron if the number or parameters
/// is 3) and moves the vertices around parameter space until a local
/// minimum is found.  The amoeba method is robust, reasonably efficient,
/// but is not guaranteed to find the global minimum if several local
/// minima exist.
/// </remarks>
public class vtkAmoebaMinimizer : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAmoebaMinimizer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAmoebaMinimizer()
	{
		MRClassNameKey = "class vtkAmoebaMinimizer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAmoebaMinimizer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAmoebaMinimizer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAmoebaMinimizer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAmoebaMinimizer New()
	{
		vtkAmoebaMinimizer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAmoebaMinimizer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAmoebaMinimizer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAmoebaMinimizer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAmoebaMinimizer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAmoebaMinimizer_EvaluateFunction_01(HandleRef pThis);

	/// <summary>
	/// Evaluate the function.  This is usually called internally by the
	/// minimization code, but it is provided here as a public method.
	/// </summary>
	public void EvaluateFunction()
	{
		vtkAmoebaMinimizer_EvaluateFunction_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAmoebaMinimizer_GetContractionRatio_02(HandleRef pThis);

	/// <summary>
	/// Set the amoeba contraction ratio.  The default value of 0.5 gives
	/// fast convergence, but larger values such as 0.6 or 0.7 provide
	/// greater stability.
	/// </summary>
	public virtual double GetContractionRatio()
	{
		return vtkAmoebaMinimizer_GetContractionRatio_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAmoebaMinimizer_GetContractionRatioMaxValue_03(HandleRef pThis);

	/// <summary>
	/// Set the amoeba contraction ratio.  The default value of 0.5 gives
	/// fast convergence, but larger values such as 0.6 or 0.7 provide
	/// greater stability.
	/// </summary>
	public virtual double GetContractionRatioMaxValue()
	{
		return vtkAmoebaMinimizer_GetContractionRatioMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAmoebaMinimizer_GetContractionRatioMinValue_04(HandleRef pThis);

	/// <summary>
	/// Set the amoeba contraction ratio.  The default value of 0.5 gives
	/// fast convergence, but larger values such as 0.6 or 0.7 provide
	/// greater stability.
	/// </summary>
	public virtual double GetContractionRatioMinValue()
	{
		return vtkAmoebaMinimizer_GetContractionRatioMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAmoebaMinimizer_GetExpansionRatio_05(HandleRef pThis);

	/// <summary>
	/// Set the amoeba expansion ratio.  The default value is 2.0, which
	/// provides rapid expansion.  Values between 1.1 and 2.0 are valid.
	/// </summary>
	public virtual double GetExpansionRatio()
	{
		return vtkAmoebaMinimizer_GetExpansionRatio_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAmoebaMinimizer_GetExpansionRatioMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Set the amoeba expansion ratio.  The default value is 2.0, which
	/// provides rapid expansion.  Values between 1.1 and 2.0 are valid.
	/// </summary>
	public virtual double GetExpansionRatioMaxValue()
	{
		return vtkAmoebaMinimizer_GetExpansionRatioMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAmoebaMinimizer_GetExpansionRatioMinValue_07(HandleRef pThis);

	/// <summary>
	/// Set the amoeba expansion ratio.  The default value is 2.0, which
	/// provides rapid expansion.  Values between 1.1 and 2.0 are valid.
	/// </summary>
	public virtual double GetExpansionRatioMinValue()
	{
		return vtkAmoebaMinimizer_GetExpansionRatioMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAmoebaMinimizer_GetFunctionEvaluations_08(HandleRef pThis);

	/// <summary>
	/// Return the number of times that the function has been evaluated.
	/// </summary>
	public virtual int GetFunctionEvaluations()
	{
		return vtkAmoebaMinimizer_GetFunctionEvaluations_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAmoebaMinimizer_GetFunctionValue_09(HandleRef pThis);

	/// <summary>
	/// Get the function value resulting from the minimization.
	/// </summary>
	public double GetFunctionValue()
	{
		return vtkAmoebaMinimizer_GetFunctionValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAmoebaMinimizer_GetIterations_10(HandleRef pThis);

	/// <summary>
	/// Return the number of iterations that have been performed.  This
	/// is not necessarily the same as the number of function evaluations.
	/// </summary>
	public virtual int GetIterations()
	{
		return vtkAmoebaMinimizer_GetIterations_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAmoebaMinimizer_GetMaxIterations_11(HandleRef pThis);

	/// <summary>
	/// Specify the maximum number of iterations to try before giving up.
	/// </summary>
	public virtual int GetMaxIterations()
	{
		return vtkAmoebaMinimizer_GetMaxIterations_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAmoebaMinimizer_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAmoebaMinimizer_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAmoebaMinimizer_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAmoebaMinimizer_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAmoebaMinimizer_GetNumberOfParameters_14(HandleRef pThis);

	/// <summary>
	/// Get the number of parameters that have been set.
	/// </summary>
	public int GetNumberOfParameters()
	{
		return vtkAmoebaMinimizer_GetNumberOfParameters_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAmoebaMinimizer_GetParameterName_15(HandleRef pThis, int i);

	/// <summary>
	/// For completeness, an unchecked method to get the name for particular
	/// parameter (the result will be nullptr if no name was set).
	/// </summary>
	public string GetParameterName(int i)
	{
		return Marshal.PtrToStringAnsi(vtkAmoebaMinimizer_GetParameterName_15(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAmoebaMinimizer_GetParameterScale_16(HandleRef pThis, string name);

	/// <summary>
	/// Set the scale to use when modifying a parameter, i.e. the
	/// initial amount by which the parameter will be modified
	/// during the search for the minimum.  It is preferable to
	/// identify scalars by name rather than by number.
	/// </summary>
	public double GetParameterScale(string name)
	{
		return vtkAmoebaMinimizer_GetParameterScale_16(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAmoebaMinimizer_GetParameterScale_17(HandleRef pThis, int i);

	/// <summary>
	/// Set the scale to use when modifying a parameter, i.e. the
	/// initial amount by which the parameter will be modified
	/// during the search for the minimum.  It is preferable to
	/// identify scalars by name rather than by number.
	/// </summary>
	public double GetParameterScale(int i)
	{
		return vtkAmoebaMinimizer_GetParameterScale_17(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAmoebaMinimizer_GetParameterTolerance_18(HandleRef pThis);

	/// <summary>
	/// Specify the parameter tolerance to aim for during the minimization.
	/// </summary>
	public virtual double GetParameterTolerance()
	{
		return vtkAmoebaMinimizer_GetParameterTolerance_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAmoebaMinimizer_GetParameterValue_19(HandleRef pThis, string name);

	/// <summary>
	/// Get the value of a parameter at the current stage of the minimization.
	/// Call this method within the function that you are minimizing in order
	/// to get the current parameter values.  It is preferable to specify
	/// parameters by name rather than by index.
	/// </summary>
	public double GetParameterValue(string name)
	{
		return vtkAmoebaMinimizer_GetParameterValue_19(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAmoebaMinimizer_GetParameterValue_20(HandleRef pThis, int i);

	/// <summary>
	/// Get the value of a parameter at the current stage of the minimization.
	/// Call this method within the function that you are minimizing in order
	/// to get the current parameter values.  It is preferable to specify
	/// parameters by name rather than by index.
	/// </summary>
	public double GetParameterValue(int i)
	{
		return vtkAmoebaMinimizer_GetParameterValue_20(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAmoebaMinimizer_GetTolerance_21(HandleRef pThis);

	/// <summary>
	/// Specify the value tolerance to aim for during the minimization.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkAmoebaMinimizer_GetTolerance_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAmoebaMinimizer_Initialize_22(HandleRef pThis);

	/// <summary>
	/// Initialize the minimizer.  This will reset the number of parameters to
	/// zero so that the minimizer can be reused.
	/// </summary>
	public void Initialize()
	{
		vtkAmoebaMinimizer_Initialize_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAmoebaMinimizer_IsA_23(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAmoebaMinimizer_IsA_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAmoebaMinimizer_IsTypeOf_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAmoebaMinimizer_IsTypeOf_24(type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAmoebaMinimizer_Iterate_25(HandleRef pThis);

	/// <summary>
	/// Perform one iteration of minimization.  Returns zero if the tolerance
	/// stopping criterion has been met.
	/// </summary>
	public virtual int Iterate()
	{
		return vtkAmoebaMinimizer_Iterate_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAmoebaMinimizer_Minimize_26(HandleRef pThis);

	/// <summary>
	/// Iterate until the minimum is found to within the specified tolerance,
	/// or until the MaxIterations has been reached.
	/// </summary>
	public virtual void Minimize()
	{
		vtkAmoebaMinimizer_Minimize_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAmoebaMinimizer_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAmoebaMinimizer NewInstance()
	{
		vtkAmoebaMinimizer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAmoebaMinimizer_NewInstance_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAmoebaMinimizer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAmoebaMinimizer_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAmoebaMinimizer SafeDownCast(vtkObjectBase o)
	{
		vtkAmoebaMinimizer vtkAmoebaMinimizer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAmoebaMinimizer_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAmoebaMinimizer2 = (vtkAmoebaMinimizer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAmoebaMinimizer2.Register(null);
			}
		}
		return vtkAmoebaMinimizer2;
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAmoebaMinimizer_SetContractionRatio_30(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the amoeba contraction ratio.  The default value of 0.5 gives
	/// fast convergence, but larger values such as 0.6 or 0.7 provide
	/// greater stability.
	/// </summary>
	public virtual void SetContractionRatio(double _arg)
	{
		vtkAmoebaMinimizer_SetContractionRatio_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAmoebaMinimizer_SetExpansionRatio_31(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the amoeba expansion ratio.  The default value is 2.0, which
	/// provides rapid expansion.  Values between 1.1 and 2.0 are valid.
	/// </summary>
	public virtual void SetExpansionRatio(double _arg)
	{
		vtkAmoebaMinimizer_SetExpansionRatio_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAmoebaMinimizer_SetFunctionValue_32(HandleRef pThis, double _arg);

	/// <summary>
	/// Get the function value resulting from the minimization.
	/// </summary>
	public virtual void SetFunctionValue(double _arg)
	{
		vtkAmoebaMinimizer_SetFunctionValue_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAmoebaMinimizer_SetMaxIterations_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the maximum number of iterations to try before giving up.
	/// </summary>
	public virtual void SetMaxIterations(int _arg)
	{
		vtkAmoebaMinimizer_SetMaxIterations_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAmoebaMinimizer_SetParameterScale_34(HandleRef pThis, string name, double scale);

	/// <summary>
	/// Set the scale to use when modifying a parameter, i.e. the
	/// initial amount by which the parameter will be modified
	/// during the search for the minimum.  It is preferable to
	/// identify scalars by name rather than by number.
	/// </summary>
	public void SetParameterScale(string name, double scale)
	{
		vtkAmoebaMinimizer_SetParameterScale_34(GetCppThis(), name, scale);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAmoebaMinimizer_SetParameterScale_35(HandleRef pThis, int i, double scale);

	/// <summary>
	/// Set the scale to use when modifying a parameter, i.e. the
	/// initial amount by which the parameter will be modified
	/// during the search for the minimum.  It is preferable to
	/// identify scalars by name rather than by number.
	/// </summary>
	public void SetParameterScale(int i, double scale)
	{
		vtkAmoebaMinimizer_SetParameterScale_35(GetCppThis(), i, scale);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAmoebaMinimizer_SetParameterTolerance_36(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the parameter tolerance to aim for during the minimization.
	/// </summary>
	public virtual void SetParameterTolerance(double _arg)
	{
		vtkAmoebaMinimizer_SetParameterTolerance_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAmoebaMinimizer_SetParameterValue_37(HandleRef pThis, string name, double value);

	/// <summary>
	/// Set the initial value for the specified parameter.  Calling
	/// this function for any parameter will reset the Iterations
	/// and the FunctionEvaluations counts to zero.  You must also
	/// use SetParameterScale() to specify the step size by which the
	/// parameter will be modified during the minimization.  It is
	/// preferable to specify parameters by name, rather than by
	/// number.
	/// </summary>
	public void SetParameterValue(string name, double value)
	{
		vtkAmoebaMinimizer_SetParameterValue_37(GetCppThis(), name, value);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAmoebaMinimizer_SetParameterValue_38(HandleRef pThis, int i, double value);

	/// <summary>
	/// Set the initial value for the specified parameter.  Calling
	/// this function for any parameter will reset the Iterations
	/// and the FunctionEvaluations counts to zero.  You must also
	/// use SetParameterScale() to specify the step size by which the
	/// parameter will be modified during the minimization.  It is
	/// preferable to specify parameters by name, rather than by
	/// number.
	/// </summary>
	public void SetParameterValue(int i, double value)
	{
		vtkAmoebaMinimizer_SetParameterValue_38(GetCppThis(), i, value);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAmoebaMinimizer_SetTolerance_39(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the value tolerance to aim for during the minimization.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkAmoebaMinimizer_SetTolerance_39(GetCppThis(), _arg);
	}
}
