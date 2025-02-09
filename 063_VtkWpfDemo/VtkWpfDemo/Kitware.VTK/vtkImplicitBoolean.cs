using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImplicitBoolean
/// </summary>
/// <remarks>
///    implicit function consisting of boolean combinations of implicit functions
///
/// vtkImplicitBoolean is an implicit function consisting of boolean
/// combinations of implicit functions. The class has a list of functions
/// (FunctionList) that are combined according to a specified operator
/// (VTK_UNION or VTK_INTERSECTION or VTK_DIFFERENCE). You can use nested
/// combinations of vtkImplicitFunction's (and/or vtkImplicitBoolean) to create
/// elaborate implicit functions.  vtkImplicitBoolean is a concrete
/// implementation of vtkImplicitFunction.
///
/// The operators work as follows. The VTK_UNION operator takes the minimum
/// value of all implicit functions. The VTK_INTERSECTION operator takes the
/// maximum value of all implicit functions. The VTK_DIFFERENCE operator
/// subtracts the 2nd through last implicit functions from the first. The
/// VTK_UNION_OF_MAGNITUDES takes the minimum absolute value of the
/// implicit functions.
/// </remarks>
public class vtkImplicitBoolean : vtkImplicitFunction
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum OperationType
	{
		/// <summary>enum member</summary>
		VTK_DIFFERENCE = 2,
		/// <summary>enum member</summary>
		VTK_INTERSECTION = 1,
		/// <summary>enum member</summary>
		VTK_UNION = 0,
		/// <summary>enum member</summary>
		VTK_UNION_OF_MAGNITUDES = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitBoolean";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImplicitBoolean()
	{
		MRClassNameKey = "class vtkImplicitBoolean";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitBoolean"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImplicitBoolean(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitBoolean_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Default boolean method is union.
	/// </summary>
	public new static vtkImplicitBoolean New()
	{
		vtkImplicitBoolean result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitBoolean_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitBoolean)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Default boolean method is union.
	/// </summary>
	public vtkImplicitBoolean()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImplicitBoolean_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImplicitBoolean_AddFunction_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add another implicit function to the list of functions.
	/// </summary>
	public void AddFunction(vtkImplicitFunction arg0)
	{
		vtkImplicitBoolean_AddFunction_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitBoolean_EvaluateFunction_02(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Evaluate boolean combinations of implicit function using current operator.
	/// </summary>
	public override double EvaluateFunction(IntPtr x)
	{
		return vtkImplicitBoolean_EvaluateFunction_02(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitBoolean_EvaluateGradient_03(HandleRef pThis, IntPtr x, IntPtr g);

	/// <summary>
	/// Evaluate gradient of boolean combination.
	/// </summary>
	public override void EvaluateGradient(IntPtr x, IntPtr g)
	{
		vtkImplicitBoolean_EvaluateGradient_03(GetCppThis(), x, g);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitBoolean_GetFunction_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the collection of implicit functions.
	/// </summary>
	public vtkImplicitFunctionCollection GetFunction()
	{
		vtkImplicitFunctionCollection vtkImplicitFunctionCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitBoolean_GetFunction_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitFunctionCollection2 = (vtkImplicitFunctionCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitFunctionCollection2.Register(null);
			}
		}
		return vtkImplicitFunctionCollection2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImplicitBoolean_GetMTime_05(HandleRef pThis);

	/// <summary>
	/// Override modified time retrieval because of object dependencies.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImplicitBoolean_GetMTime_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitBoolean_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImplicitBoolean_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitBoolean_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImplicitBoolean_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitBoolean_GetOperationType_08(HandleRef pThis);

	/// <summary>
	/// Specify the type of boolean operation.
	/// </summary>
	public virtual int GetOperationType()
	{
		return vtkImplicitBoolean_GetOperationType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitBoolean_GetOperationTypeAsString_09(HandleRef pThis);

	/// <summary>
	/// Specify the type of boolean operation.
	/// </summary>
	public string GetOperationTypeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImplicitBoolean_GetOperationTypeAsString_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitBoolean_GetOperationTypeMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Specify the type of boolean operation.
	/// </summary>
	public virtual int GetOperationTypeMaxValue()
	{
		return vtkImplicitBoolean_GetOperationTypeMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitBoolean_GetOperationTypeMinValue_11(HandleRef pThis);

	/// <summary>
	/// Specify the type of boolean operation.
	/// </summary>
	public virtual int GetOperationTypeMinValue()
	{
		return vtkImplicitBoolean_GetOperationTypeMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitBoolean_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImplicitBoolean_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitBoolean_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImplicitBoolean_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitBoolean_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImplicitBoolean NewInstance()
	{
		vtkImplicitBoolean result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitBoolean_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitBoolean)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitBoolean_RemoveFunction_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Remove a function from the list of implicit functions to boolean.
	/// </summary>
	public void RemoveFunction(vtkImplicitFunction arg0)
	{
		vtkImplicitBoolean_RemoveFunction_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitBoolean_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImplicitBoolean SafeDownCast(vtkObjectBase o)
	{
		vtkImplicitBoolean vtkImplicitBoolean2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitBoolean_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitBoolean2 = (vtkImplicitBoolean)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitBoolean2.Register(null);
			}
		}
		return vtkImplicitBoolean2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitBoolean_SetOperationType_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the type of boolean operation.
	/// </summary>
	public virtual void SetOperationType(int _arg)
	{
		vtkImplicitBoolean_SetOperationType_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitBoolean_SetOperationTypeToDifference_19(HandleRef pThis);

	/// <summary>
	/// Specify the type of boolean operation.
	/// </summary>
	public void SetOperationTypeToDifference()
	{
		vtkImplicitBoolean_SetOperationTypeToDifference_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitBoolean_SetOperationTypeToIntersection_20(HandleRef pThis);

	/// <summary>
	/// Specify the type of boolean operation.
	/// </summary>
	public void SetOperationTypeToIntersection()
	{
		vtkImplicitBoolean_SetOperationTypeToIntersection_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitBoolean_SetOperationTypeToUnion_21(HandleRef pThis);

	/// <summary>
	/// Specify the type of boolean operation.
	/// </summary>
	public void SetOperationTypeToUnion()
	{
		vtkImplicitBoolean_SetOperationTypeToUnion_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitBoolean_SetOperationTypeToUnionOfMagnitudes_22(HandleRef pThis);

	/// <summary>
	/// Specify the type of boolean operation.
	/// </summary>
	public void SetOperationTypeToUnionOfMagnitudes()
	{
		vtkImplicitBoolean_SetOperationTypeToUnionOfMagnitudes_22(GetCppThis());
	}
}
