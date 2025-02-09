using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAMRResampleFilter
///
///
///  This filter is a concrete instance of vtkMultiBlockDataSetAlgorithm and
///  provides functionality for extracting portion of the AMR dataset, specified
///  by a bounding box, in a uniform grid of the desired level of resolution.
///  The resulting uniform grid is stored in a vtkMultiBlockDataSet where the
///  number of blocks correspond to the number of processors utilized for the
///  operation.
///
/// @warning
///  Data of the input AMR dataset is assumed to be cell-centered.
///
/// </summary>
/// <seealso>
///
///  vtkOverlappingAMR, vtkUniformGrid
/// </seealso>
public class vtkAMRResampleFilter : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAMRResampleFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAMRResampleFilter()
	{
		MRClassNameKey = "class vtkAMRResampleFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRResampleFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAMRResampleFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRResampleFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAMRResampleFilter New()
	{
		vtkAMRResampleFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRResampleFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAMRResampleFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAMRResampleFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAMRResampleFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRResampleFilter_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Gets the metadata from upstream module and determines which blocks
	/// should be loaded by this instance.
	/// </summary>
	public virtual int FillInputPortInformation(int port, vtkInformation info)
	{
		return vtkAMRResampleFilter_FillInputPortInformation_01(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRResampleFilter_FillOutputPortInformation_02(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Gets the metadata from upstream module and determines which blocks
	/// should be loaded by this instance.
	/// </summary>
	public virtual int FillOutputPortInformation(int port, vtkInformation info)
	{
		return vtkAMRResampleFilter_FillOutputPortInformation_02(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRResampleFilter_GetBiasVector_03(HandleRef pThis);

	/// <summary>
	/// Set and Get the bias vector.  If UseBiasVector is true
	/// then the largest component of this vector can not have
	/// the max number of samples
	/// </summary>
	public virtual double[] GetBiasVector()
	{
		IntPtr intPtr = vtkAMRResampleFilter_GetBiasVector_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_GetBiasVector_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set and Get the bias vector.  If UseBiasVector is true
	/// then the largest component of this vector can not have
	/// the max number of samples
	/// </summary>
	public virtual void GetBiasVector(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkAMRResampleFilter_GetBiasVector_04(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_GetBiasVector_05(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set and Get the bias vector.  If UseBiasVector is true
	/// then the largest component of this vector can not have
	/// the max number of samples
	/// </summary>
	public virtual void GetBiasVector(IntPtr _arg)
	{
		vtkAMRResampleFilter_GetBiasVector_05(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRResampleFilter_GetController_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set &amp; Get macro for the multi-process controller
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRResampleFilter_GetController_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiProcessController2 = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiProcessController2.Register(null);
			}
		}
		return vtkMultiProcessController2;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRResampleFilter_GetDemandDrivenMode_07(HandleRef pThis);

	/// <summary>
	/// Set &amp; Get macro to allow the filter to operate in both demand-driven
	/// and standard modes
	/// </summary>
	public virtual int GetDemandDrivenMode()
	{
		return vtkAMRResampleFilter_GetDemandDrivenMode_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRResampleFilter_GetMax_08(HandleRef pThis);

	/// <summary>
	/// Set and Get the max corner
	/// </summary>
	public virtual double[] GetMax()
	{
		IntPtr intPtr = vtkAMRResampleFilter_GetMax_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_GetMax_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set and Get the max corner
	/// </summary>
	public virtual void GetMax(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkAMRResampleFilter_GetMax_09(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_GetMax_10(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set and Get the max corner
	/// </summary>
	public virtual void GetMax(IntPtr _arg)
	{
		vtkAMRResampleFilter_GetMax_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRResampleFilter_GetMin_11(HandleRef pThis);

	/// <summary>
	/// Set and Get the min corner
	/// </summary>
	public virtual double[] GetMin()
	{
		IntPtr intPtr = vtkAMRResampleFilter_GetMin_11(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_GetMin_12(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set and Get the min corner
	/// </summary>
	public virtual void GetMin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkAMRResampleFilter_GetMin_12(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_GetMin_13(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set and Get the min corner
	/// </summary>
	public virtual void GetMin(IntPtr _arg)
	{
		vtkAMRResampleFilter_GetMin_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMRResampleFilter_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAMRResampleFilter_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMRResampleFilter_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAMRResampleFilter_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRResampleFilter_GetNumberOfPartitions_16(HandleRef pThis);

	/// <summary>
	/// Set &amp; Get macro for the number of subdivisions
	/// </summary>
	public virtual int GetNumberOfPartitions()
	{
		return vtkAMRResampleFilter_GetNumberOfPartitions_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRResampleFilter_GetNumberOfSamples_17(HandleRef pThis);

	/// <summary>
	/// Set &amp; Get macro for the number of samples (cells) in each dimension.
	/// Nominal value for the number of samples is 10x10x10.
	/// </summary>
	public virtual int[] GetNumberOfSamples()
	{
		IntPtr intPtr = vtkAMRResampleFilter_GetNumberOfSamples_17(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_GetNumberOfSamples_18(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Set &amp; Get macro for the number of samples (cells) in each dimension.
	/// Nominal value for the number of samples is 10x10x10.
	/// </summary>
	public virtual void GetNumberOfSamples(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkAMRResampleFilter_GetNumberOfSamples_18(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_GetNumberOfSamples_19(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set &amp; Get macro for the number of samples (cells) in each dimension.
	/// Nominal value for the number of samples is 10x10x10.
	/// </summary>
	public virtual void GetNumberOfSamples(IntPtr _arg)
	{
		vtkAMRResampleFilter_GetNumberOfSamples_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRResampleFilter_GetTransferToNodes_20(HandleRef pThis);

	/// <summary>
	/// Set &amp; Get macro for the TransferToNodes flag
	/// </summary>
	public virtual int GetTransferToNodes()
	{
		return vtkAMRResampleFilter_GetTransferToNodes_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAMRResampleFilter_GetUseBiasVector_21(HandleRef pThis);

	/// <summary>
	/// Set &amp; Get macro for the number of subdivisions
	/// </summary>
	public virtual bool GetUseBiasVector()
	{
		return (vtkAMRResampleFilter_GetUseBiasVector_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRResampleFilter_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAMRResampleFilter_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRResampleFilter_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAMRResampleFilter_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRResampleFilter_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAMRResampleFilter NewInstance()
	{
		vtkAMRResampleFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRResampleFilter_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAMRResampleFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRResampleFilter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAMRResampleFilter SafeDownCast(vtkObjectBase o)
	{
		vtkAMRResampleFilter vtkAMRResampleFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRResampleFilter_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAMRResampleFilter2 = (vtkAMRResampleFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAMRResampleFilter2.Register(null);
			}
		}
		return vtkAMRResampleFilter2;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_SetBiasVector_27(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set and Get the bias vector.  If UseBiasVector is true
	/// then the largest component of this vector can not have
	/// the max number of samples
	/// </summary>
	public virtual void SetBiasVector(double _arg1, double _arg2, double _arg3)
	{
		vtkAMRResampleFilter_SetBiasVector_27(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_SetBiasVector_28(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set and Get the bias vector.  If UseBiasVector is true
	/// then the largest component of this vector can not have
	/// the max number of samples
	/// </summary>
	public virtual void SetBiasVector(IntPtr _arg)
	{
		vtkAMRResampleFilter_SetBiasVector_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_SetController_29(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set &amp; Get macro for the multi-process controller
	/// </summary>
	public virtual void SetController(vtkMultiProcessController arg0)
	{
		vtkAMRResampleFilter_SetController_29(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_SetDemandDrivenMode_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set &amp; Get macro to allow the filter to operate in both demand-driven
	/// and standard modes
	/// </summary>
	public virtual void SetDemandDrivenMode(int _arg)
	{
		vtkAMRResampleFilter_SetDemandDrivenMode_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_SetMax_31(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set and Get the max corner
	/// </summary>
	public virtual void SetMax(double _arg1, double _arg2, double _arg3)
	{
		vtkAMRResampleFilter_SetMax_31(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_SetMax_32(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set and Get the max corner
	/// </summary>
	public virtual void SetMax(IntPtr _arg)
	{
		vtkAMRResampleFilter_SetMax_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_SetMin_33(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set and Get the min corner
	/// </summary>
	public virtual void SetMin(double _arg1, double _arg2, double _arg3)
	{
		vtkAMRResampleFilter_SetMin_33(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_SetMin_34(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set and Get the min corner
	/// </summary>
	public virtual void SetMin(IntPtr _arg)
	{
		vtkAMRResampleFilter_SetMin_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_SetNumberOfPartitions_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Set &amp; Get macro for the number of subdivisions
	/// </summary>
	public virtual void SetNumberOfPartitions(int _arg)
	{
		vtkAMRResampleFilter_SetNumberOfPartitions_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_SetNumberOfSamples_36(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Set &amp; Get macro for the number of samples (cells) in each dimension.
	/// Nominal value for the number of samples is 10x10x10.
	/// </summary>
	public virtual void SetNumberOfSamples(int _arg1, int _arg2, int _arg3)
	{
		vtkAMRResampleFilter_SetNumberOfSamples_36(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_SetNumberOfSamples_37(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set &amp; Get macro for the number of samples (cells) in each dimension.
	/// Nominal value for the number of samples is 10x10x10.
	/// </summary>
	public virtual void SetNumberOfSamples(IntPtr _arg)
	{
		vtkAMRResampleFilter_SetNumberOfSamples_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_SetTransferToNodes_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Set &amp; Get macro for the TransferToNodes flag
	/// </summary>
	public virtual void SetTransferToNodes(int _arg)
	{
		vtkAMRResampleFilter_SetTransferToNodes_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRResampleFilter_SetUseBiasVector_39(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set &amp; Get macro for the number of subdivisions
	/// </summary>
	public virtual void SetUseBiasVector(bool _arg)
	{
		vtkAMRResampleFilter_SetUseBiasVector_39(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
