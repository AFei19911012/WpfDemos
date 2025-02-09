using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImplicitDataSet
/// </summary>
/// <remarks>
///    treat a dataset as if it were an implicit function
///
/// vtkImplicitDataSet treats any type of dataset as if it were an
/// implicit function. This means it computes a function value and
/// gradient. vtkImplicitDataSet is a concrete implementation of
/// vtkImplicitFunction.
///
/// vtkImplicitDataSet computes the function (at the point x) by performing
/// cell interpolation. That is, it finds the cell containing x, and then
/// uses the cell's interpolation functions to compute an interpolated
/// scalar value at x. (A similar approach is used to find the
/// gradient, if requested.) Points outside of the dataset are assigned
/// the value of the ivar OutValue, and the gradient value OutGradient.
///
/// @warning
/// Any type of dataset can be used as an implicit function as long as it
/// has scalar data associated with it.
///
/// </remarks>
/// <seealso>
///
/// vtkImplicitFunction vtkImplicitVolume vtkClipPolyData vtkCutter
/// vtkImplicitWindowFunction
/// </seealso>
public class vtkImplicitDataSet : vtkImplicitFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitDataSet";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImplicitDataSet()
	{
		MRClassNameKey = "class vtkImplicitDataSet";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitDataSet"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImplicitDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an vtkImplicitDataSet with no initial dataset; the OutValue
	/// set to a large negative number; and the OutGradient set to (0,0,1).
	/// </summary>
	public new static vtkImplicitDataSet New()
	{
		vtkImplicitDataSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct an vtkImplicitDataSet with no initial dataset; the OutValue
	/// set to a large negative number; and the OutGradient set to (0,0,1).
	/// </summary>
	public vtkImplicitDataSet()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImplicitDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkImplicitDataSet_EvaluateFunction_01(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Evaluate the implicit function. This returns the interpolated scalar value
	/// at x[3].
	/// </summary>
	public override double EvaluateFunction(IntPtr x)
	{
		return vtkImplicitDataSet_EvaluateFunction_01(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitDataSet_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr n);

	/// <summary>
	/// Evaluate implicit function gradient.
	/// </summary>
	public override void EvaluateGradient(IntPtr x, IntPtr n)
	{
		vtkImplicitDataSet_EvaluateGradient_02(GetCppThis(), x, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitDataSet_GetDataSet_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / get the dataset used for the implicit function evaluation.
	/// </summary>
	public virtual vtkDataSet GetDataSet()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitDataSet_GetDataSet_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImplicitDataSet_GetMTime_04(HandleRef pThis);

	/// <summary>
	/// Return the MTime also considering the DataSet dependency.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImplicitDataSet_GetMTime_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitDataSet_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImplicitDataSet_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitDataSet_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImplicitDataSet_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitDataSet_GetOutGradient_07(HandleRef pThis);

	/// <summary>
	/// Set / get the function gradient to use for points outside of the dataset.
	/// </summary>
	public virtual double[] GetOutGradient()
	{
		IntPtr intPtr = vtkImplicitDataSet_GetOutGradient_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitDataSet_GetOutGradient_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set / get the function gradient to use for points outside of the dataset.
	/// </summary>
	public virtual void GetOutGradient(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImplicitDataSet_GetOutGradient_08(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitDataSet_GetOutGradient_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / get the function gradient to use for points outside of the dataset.
	/// </summary>
	public virtual void GetOutGradient(IntPtr _arg)
	{
		vtkImplicitDataSet_GetOutGradient_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitDataSet_GetOutValue_10(HandleRef pThis);

	/// <summary>
	/// Set / get the function value to use for points outside of the dataset.
	/// </summary>
	public virtual double GetOutValue()
	{
		return vtkImplicitDataSet_GetOutValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitDataSet_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImplicitDataSet_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitDataSet_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImplicitDataSet_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitDataSet_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImplicitDataSet NewInstance()
	{
		vtkImplicitDataSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitDataSet_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitDataSet_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImplicitDataSet SafeDownCast(vtkObjectBase o)
	{
		vtkImplicitDataSet vtkImplicitDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitDataSet_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitDataSet2 = (vtkImplicitDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitDataSet2.Register(null);
			}
		}
		return vtkImplicitDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitDataSet_SetDataSet_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set / get the dataset used for the implicit function evaluation.
	/// </summary>
	public virtual void SetDataSet(vtkDataSet arg0)
	{
		vtkImplicitDataSet_SetDataSet_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitDataSet_SetOutGradient_17(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set / get the function gradient to use for points outside of the dataset.
	/// </summary>
	public virtual void SetOutGradient(double _arg1, double _arg2, double _arg3)
	{
		vtkImplicitDataSet_SetOutGradient_17(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitDataSet_SetOutGradient_18(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / get the function gradient to use for points outside of the dataset.
	/// </summary>
	public virtual void SetOutGradient(IntPtr _arg)
	{
		vtkImplicitDataSet_SetOutGradient_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitDataSet_SetOutValue_19(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / get the function value to use for points outside of the dataset.
	/// </summary>
	public virtual void SetOutValue(double _arg)
	{
		vtkImplicitDataSet_SetOutValue_19(GetCppThis(), _arg);
	}
}
