using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImplicitWindowFunction
/// </summary>
/// <remarks>
///    implicit function maps another implicit function to lie within a specified range
///
/// vtkImplicitWindowFunction is used to modify the output of another
/// implicit function to lie within a specified "window", or function
/// range. This can be used to add "thickness" to cutting or clipping
/// functions.
///
/// This class works as follows. First, it evaluates the function value of the
/// user-specified implicit function. Then, based on the window range specified,
/// it maps the function value into the window values specified.
///
///
/// </remarks>
/// <seealso>
///
/// vtkImplicitFunction
/// </seealso>
public class vtkImplicitWindowFunction : vtkImplicitFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitWindowFunction";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImplicitWindowFunction()
	{
		MRClassNameKey = "class vtkImplicitWindowFunction";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitWindowFunction"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImplicitWindowFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitWindowFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with window range (0,1) and window values (0,1).
	/// </summary>
	public new static vtkImplicitWindowFunction New()
	{
		vtkImplicitWindowFunction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitWindowFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitWindowFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with window range (0,1) and window values (0,1).
	/// </summary>
	public vtkImplicitWindowFunction()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImplicitWindowFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkImplicitWindowFunction_EvaluateFunction_01(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Evaluate window function.
	/// </summary>
	public override double EvaluateFunction(IntPtr x)
	{
		return vtkImplicitWindowFunction_EvaluateFunction_01(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitWindowFunction_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr n);

	/// <summary>
	/// Evaluate window function gradient. Just return implicit function gradient.
	/// </summary>
	public override void EvaluateGradient(IntPtr x, IntPtr n)
	{
		vtkImplicitWindowFunction_EvaluateGradient_02(GetCppThis(), x, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitWindowFunction_GetImplicitFunction_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify an implicit function to operate on.
	/// </summary>
	public virtual vtkImplicitFunction GetImplicitFunction()
	{
		vtkImplicitFunction vtkImplicitFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitWindowFunction_GetImplicitFunction_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitFunction2 = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitFunction2.Register(null);
			}
		}
		return vtkImplicitFunction2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImplicitWindowFunction_GetMTime_04(HandleRef pThis);

	/// <summary>
	/// Override modified time retrieval because of object dependencies.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImplicitWindowFunction_GetMTime_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitWindowFunction_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImplicitWindowFunction_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitWindowFunction_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImplicitWindowFunction_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitWindowFunction_GetWindowRange_07(HandleRef pThis);

	/// <summary>
	/// Specify the range of function values which are considered to lie within
	/// the window. WindowRange[0] is assumed to be less than WindowRange[1].
	/// </summary>
	public virtual double[] GetWindowRange()
	{
		IntPtr intPtr = vtkImplicitWindowFunction_GetWindowRange_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitWindowFunction_GetWindowRange_08(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the range of function values which are considered to lie within
	/// the window. WindowRange[0] is assumed to be less than WindowRange[1].
	/// </summary>
	public virtual void GetWindowRange(IntPtr data)
	{
		vtkImplicitWindowFunction_GetWindowRange_08(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitWindowFunction_GetWindowValues_09(HandleRef pThis);

	/// <summary>
	/// Specify the range of output values that the window range is mapped
	/// into. This is effectively a scaling and shifting of the original
	/// function values.
	/// </summary>
	public virtual double[] GetWindowValues()
	{
		IntPtr intPtr = vtkImplicitWindowFunction_GetWindowValues_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitWindowFunction_GetWindowValues_10(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the range of output values that the window range is mapped
	/// into. This is effectively a scaling and shifting of the original
	/// function values.
	/// </summary>
	public virtual void GetWindowValues(IntPtr data)
	{
		vtkImplicitWindowFunction_GetWindowValues_10(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitWindowFunction_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImplicitWindowFunction_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitWindowFunction_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImplicitWindowFunction_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitWindowFunction_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImplicitWindowFunction NewInstance()
	{
		vtkImplicitWindowFunction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitWindowFunction_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitWindowFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitWindowFunction_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImplicitWindowFunction SafeDownCast(vtkObjectBase o)
	{
		vtkImplicitWindowFunction vtkImplicitWindowFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitWindowFunction_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitWindowFunction2 = (vtkImplicitWindowFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitWindowFunction2.Register(null);
			}
		}
		return vtkImplicitWindowFunction2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitWindowFunction_SetImplicitFunction_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify an implicit function to operate on.
	/// </summary>
	public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
	{
		vtkImplicitWindowFunction_SetImplicitFunction_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitWindowFunction_SetWindowRange_17(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Specify the range of function values which are considered to lie within
	/// the window. WindowRange[0] is assumed to be less than WindowRange[1].
	/// </summary>
	public virtual void SetWindowRange(double _arg1, double _arg2)
	{
		vtkImplicitWindowFunction_SetWindowRange_17(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitWindowFunction_SetWindowRange_18(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the range of function values which are considered to lie within
	/// the window. WindowRange[0] is assumed to be less than WindowRange[1].
	/// </summary>
	public void SetWindowRange(IntPtr _arg)
	{
		vtkImplicitWindowFunction_SetWindowRange_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitWindowFunction_SetWindowValues_19(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Specify the range of output values that the window range is mapped
	/// into. This is effectively a scaling and shifting of the original
	/// function values.
	/// </summary>
	public virtual void SetWindowValues(double _arg1, double _arg2)
	{
		vtkImplicitWindowFunction_SetWindowValues_19(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitWindowFunction_SetWindowValues_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the range of output values that the window range is mapped
	/// into. This is effectively a scaling and shifting of the original
	/// function values.
	/// </summary>
	public void SetWindowValues(IntPtr _arg)
	{
		vtkImplicitWindowFunction_SetWindowValues_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImplicitWindowFunction_UsesGarbageCollector_21(HandleRef pThis);

	/// <summary>
	/// Participate in garbage collection.
	/// </summary>
	public override bool UsesGarbageCollector()
	{
		return (vtkImplicitWindowFunction_UsesGarbageCollector_21(GetCppThis()) != 0) ? true : false;
	}
}
