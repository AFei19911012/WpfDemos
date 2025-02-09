using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageWeightedSum
/// </summary>
/// <remarks>
///     adds any number of images, weighting
/// each according to the weight set using this-&gt;SetWeights(i,w).
///
///
/// All weights are normalized so they will sum to 1.
/// Images must have the same extents. Output is
///
/// @par Thanks:
/// The original author of this class is Lauren O'Donnell (MIT) for Slicer
/// </remarks>
public class vtkImageWeightedSum : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageWeightedSum";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageWeightedSum()
	{
		MRClassNameKey = "class vtkImageWeightedSum";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageWeightedSum"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageWeightedSum(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageWeightedSum_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageWeightedSum New()
	{
		vtkImageWeightedSum result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageWeightedSum_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageWeightedSum)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageWeightedSum()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageWeightedSum_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageWeightedSum_CalculateTotalWeight_01(HandleRef pThis);

	/// <summary>
	/// Compute the total value of all the weight
	/// </summary>
	public double CalculateTotalWeight()
	{
		return vtkImageWeightedSum_CalculateTotalWeight_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageWeightedSum_GetNormalizeByWeight_02(HandleRef pThis);

	/// <summary>
	/// Setting NormalizeByWeight on will divide the
	/// final result by the total weight of the component functions.
	/// This process does not otherwise normalize the weighted sum
	/// By default, NormalizeByWeight is on.
	/// </summary>
	public virtual int GetNormalizeByWeight()
	{
		return vtkImageWeightedSum_GetNormalizeByWeight_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageWeightedSum_GetNormalizeByWeightMaxValue_03(HandleRef pThis);

	/// <summary>
	/// Setting NormalizeByWeight on will divide the
	/// final result by the total weight of the component functions.
	/// This process does not otherwise normalize the weighted sum
	/// By default, NormalizeByWeight is on.
	/// </summary>
	public virtual int GetNormalizeByWeightMaxValue()
	{
		return vtkImageWeightedSum_GetNormalizeByWeightMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageWeightedSum_GetNormalizeByWeightMinValue_04(HandleRef pThis);

	/// <summary>
	/// Setting NormalizeByWeight on will divide the
	/// final result by the total weight of the component functions.
	/// This process does not otherwise normalize the weighted sum
	/// By default, NormalizeByWeight is on.
	/// </summary>
	public virtual int GetNormalizeByWeightMinValue()
	{
		return vtkImageWeightedSum_GetNormalizeByWeightMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageWeightedSum_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageWeightedSum_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageWeightedSum_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageWeightedSum_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageWeightedSum_GetWeights_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The weights control the contribution of each input to the sum.
	/// They will be normalized to sum to 1 before filter execution.
	/// </summary>
	public virtual vtkDoubleArray GetWeights()
	{
		vtkDoubleArray vtkDoubleArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageWeightedSum_GetWeights_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDoubleArray2 = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDoubleArray2.Register(null);
			}
		}
		return vtkDoubleArray2;
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageWeightedSum_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageWeightedSum_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageWeightedSum_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageWeightedSum_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageWeightedSum_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageWeightedSum NewInstance()
	{
		vtkImageWeightedSum result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageWeightedSum_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageWeightedSum)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageWeightedSum_NormalizeByWeightOff_12(HandleRef pThis);

	/// <summary>
	/// Setting NormalizeByWeight on will divide the
	/// final result by the total weight of the component functions.
	/// This process does not otherwise normalize the weighted sum
	/// By default, NormalizeByWeight is on.
	/// </summary>
	public virtual void NormalizeByWeightOff()
	{
		vtkImageWeightedSum_NormalizeByWeightOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageWeightedSum_NormalizeByWeightOn_13(HandleRef pThis);

	/// <summary>
	/// Setting NormalizeByWeight on will divide the
	/// final result by the total weight of the component functions.
	/// This process does not otherwise normalize the weighted sum
	/// By default, NormalizeByWeight is on.
	/// </summary>
	public virtual void NormalizeByWeightOn()
	{
		vtkImageWeightedSum_NormalizeByWeightOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageWeightedSum_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageWeightedSum SafeDownCast(vtkObjectBase o)
	{
		vtkImageWeightedSum vtkImageWeightedSum2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageWeightedSum_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageWeightedSum2 = (vtkImageWeightedSum)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageWeightedSum2.Register(null);
			}
		}
		return vtkImageWeightedSum2;
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageWeightedSum_SetNormalizeByWeight_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Setting NormalizeByWeight on will divide the
	/// final result by the total weight of the component functions.
	/// This process does not otherwise normalize the weighted sum
	/// By default, NormalizeByWeight is on.
	/// </summary>
	public virtual void SetNormalizeByWeight(int _arg)
	{
		vtkImageWeightedSum_SetNormalizeByWeight_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageWeightedSum_SetWeight_16(HandleRef pThis, long id, double weight);

	/// <summary>
	/// Change a specific weight. Reallocation is done
	/// </summary>
	public virtual void SetWeight(long id, double weight)
	{
		vtkImageWeightedSum_SetWeight_16(GetCppThis(), id, weight);
	}

	[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageWeightedSum_SetWeights_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// The weights control the contribution of each input to the sum.
	/// They will be normalized to sum to 1 before filter execution.
	/// </summary>
	public virtual void SetWeights(vtkDoubleArray arg0)
	{
		vtkImageWeightedSum_SetWeights_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
