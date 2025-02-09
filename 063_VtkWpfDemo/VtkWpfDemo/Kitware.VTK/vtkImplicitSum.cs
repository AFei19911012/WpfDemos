using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImplicitSum
/// </summary>
/// <remarks>
///    implicit sum of other implicit functions
///
/// vtkImplicitSum produces a linear combination of other implicit functions.
/// The contribution of each function is weighted by a scalar coefficient.
/// The NormalizeByWeight option normalizes the output so that the
/// scalar weights add up to 1. Note that this function gives accurate
/// sums and gradients only if the input functions are linear.
/// </remarks>
public class vtkImplicitSum : vtkImplicitFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitSum";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImplicitSum()
	{
		MRClassNameKey = "class vtkImplicitSum";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitSum"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImplicitSum(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitSum_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImplicitSum New()
	{
		vtkImplicitSum result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitSum_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitSum)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImplicitSum()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImplicitSum_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitSum_AddFunction_01(HandleRef pThis, HandleRef arg0, double weight);

	/// <summary>
	/// Add another implicit function to the list of functions, along with a
	/// weighting factor.
	/// </summary>
	public void AddFunction(vtkImplicitFunction arg0, double weight)
	{
		vtkImplicitSum_AddFunction_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), weight);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitSum_AddFunction_02(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add another implicit function to the list of functions, weighting it by
	/// a factor of 1.
	/// </summary>
	public void AddFunction(vtkImplicitFunction arg0)
	{
		vtkImplicitSum_AddFunction_02(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitSum_EvaluateFunction_03(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Evaluate implicit function using current functions and weights.
	/// </summary>
	public override double EvaluateFunction(IntPtr x)
	{
		return vtkImplicitSum_EvaluateFunction_03(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitSum_EvaluateGradient_04(HandleRef pThis, IntPtr x, IntPtr g);

	/// <summary>
	/// Evaluate gradient of the weighted sum of functions.  Input functions
	/// should be linear.
	/// </summary>
	public override void EvaluateGradient(IntPtr x, IntPtr g)
	{
		vtkImplicitSum_EvaluateGradient_04(GetCppThis(), x, g);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImplicitSum_GetMTime_05(HandleRef pThis);

	/// <summary>
	/// Override modified time retrieval because of object dependencies.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImplicitSum_GetMTime_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitSum_GetNormalizeByWeight_06(HandleRef pThis);

	/// <summary>
	/// When calculating the function and gradient values of the
	/// composite function, setting NormalizeByWeight on will divide the
	/// final result by the total weight of the component functions.
	/// This process does not otherwise normalize the gradient vector.
	/// By default, NormalizeByWeight is off.
	/// </summary>
	public virtual int GetNormalizeByWeight()
	{
		return vtkImplicitSum_GetNormalizeByWeight_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitSum_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImplicitSum_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitSum_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImplicitSum_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitSum_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImplicitSum_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitSum_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImplicitSum_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitSum_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImplicitSum NewInstance()
	{
		vtkImplicitSum result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitSum_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitSum)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitSum_NormalizeByWeightOff_13(HandleRef pThis);

	/// <summary>
	/// When calculating the function and gradient values of the
	/// composite function, setting NormalizeByWeight on will divide the
	/// final result by the total weight of the component functions.
	/// This process does not otherwise normalize the gradient vector.
	/// By default, NormalizeByWeight is off.
	/// </summary>
	public virtual void NormalizeByWeightOff()
	{
		vtkImplicitSum_NormalizeByWeightOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitSum_NormalizeByWeightOn_14(HandleRef pThis);

	/// <summary>
	/// When calculating the function and gradient values of the
	/// composite function, setting NormalizeByWeight on will divide the
	/// final result by the total weight of the component functions.
	/// This process does not otherwise normalize the gradient vector.
	/// By default, NormalizeByWeight is off.
	/// </summary>
	public virtual void NormalizeByWeightOn()
	{
		vtkImplicitSum_NormalizeByWeightOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitSum_RemoveAllFunctions_15(HandleRef pThis);

	/// <summary>
	/// Remove all functions from the list.
	/// </summary>
	public void RemoveAllFunctions()
	{
		vtkImplicitSum_RemoveAllFunctions_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitSum_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImplicitSum SafeDownCast(vtkObjectBase o)
	{
		vtkImplicitSum vtkImplicitSum2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitSum_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitSum2 = (vtkImplicitSum)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitSum2.Register(null);
			}
		}
		return vtkImplicitSum2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitSum_SetFunctionWeight_17(HandleRef pThis, HandleRef f, double weight);

	/// <summary>
	/// Set the weight (coefficient) of the given function to be weight.
	/// </summary>
	public void SetFunctionWeight(vtkImplicitFunction f, double weight)
	{
		vtkImplicitSum_SetFunctionWeight_17(GetCppThis(), f?.GetCppThis() ?? default(HandleRef), weight);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitSum_SetNormalizeByWeight_18(HandleRef pThis, int _arg);

	/// <summary>
	/// When calculating the function and gradient values of the
	/// composite function, setting NormalizeByWeight on will divide the
	/// final result by the total weight of the component functions.
	/// This process does not otherwise normalize the gradient vector.
	/// By default, NormalizeByWeight is off.
	/// </summary>
	public virtual void SetNormalizeByWeight(int _arg)
	{
		vtkImplicitSum_SetNormalizeByWeight_18(GetCppThis(), _arg);
	}
}
