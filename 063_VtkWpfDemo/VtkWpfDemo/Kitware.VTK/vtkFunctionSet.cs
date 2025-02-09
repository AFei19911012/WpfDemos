using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFunctionSet
/// </summary>
/// <remarks>
///    Abstract interface for sets of functions
///
/// vtkFunctionSet specifies an abstract interface for set of functions
/// of the form F_i = F_i(x_j) where F (with i=1..m) are the functions
/// and x (with j=1..n) are the independent variables.
/// The only supported operation is the function evaluation at x_j.
///
/// </remarks>
/// <seealso>
///
/// vtkImplicitDataSet vtkCompositeInterpolatedVelocityField vtkAMRInterpolatedVelocityField
/// vtkInitialValueProblemSolver
/// </seealso>
public class vtkFunctionSet : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFunctionSet";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFunctionSet()
	{
		MRClassNameKey = "class vtkFunctionSet";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFunctionSet"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFunctionSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern int vtkFunctionSet_FunctionValues_01(HandleRef pThis, IntPtr x, IntPtr f);

	/// <summary>
	/// Evaluate functions at x_j.
	/// x and f have to point to valid double arrays of appropriate
	/// sizes obtained with GetNumberOfFunctions() and
	/// GetNumberOfIndependentVariables.
	/// If you inherit this class, make sure to reimplement at least one of the two
	/// FunctionValues signatures.
	/// </summary>
	public virtual int FunctionValues(IntPtr x, IntPtr f)
	{
		return vtkFunctionSet_FunctionValues_01(GetCppThis(), x, f);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFunctionSet_FunctionValues_02(HandleRef pThis, IntPtr x, IntPtr f, IntPtr arg2);

	/// <summary>
	/// Evaluate functions at x_j.
	/// x and f have to point to valid double arrays of appropriate
	/// sizes obtained with GetNumberOfFunctions() and
	/// GetNumberOfIndependentVariables.
	/// If you inherit this class, make sure to reimplement at least one of the two
	/// FunctionValues signatures.
	/// </summary>
	public virtual int FunctionValues(IntPtr x, IntPtr f, IntPtr arg2)
	{
		return vtkFunctionSet_FunctionValues_02(GetCppThis(), x, f, arg2);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFunctionSet_GetNumberOfFunctions_03(HandleRef pThis);

	/// <summary>
	/// Return the number of functions. Note that this is constant for
	/// a given type of set of functions and can not be changed at
	/// run time.
	/// </summary>
	public virtual int GetNumberOfFunctions()
	{
		return vtkFunctionSet_GetNumberOfFunctions_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFunctionSet_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFunctionSet_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFunctionSet_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFunctionSet_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFunctionSet_GetNumberOfIndependentVariables_06(HandleRef pThis);

	/// <summary>
	/// Return the number of independent variables. Note that this is
	/// constant for a given type of set of functions and can not be changed
	/// at run time.
	/// </summary>
	public virtual int GetNumberOfIndependentVariables()
	{
		return vtkFunctionSet_GetNumberOfIndependentVariables_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFunctionSet_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFunctionSet_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFunctionSet_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFunctionSet_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFunctionSet_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFunctionSet NewInstance()
	{
		vtkFunctionSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFunctionSet_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFunctionSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFunctionSet_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFunctionSet SafeDownCast(vtkObjectBase o)
	{
		vtkFunctionSet vtkFunctionSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFunctionSet_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
}
