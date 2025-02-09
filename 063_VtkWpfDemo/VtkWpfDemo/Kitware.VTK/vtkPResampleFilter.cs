using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPResampleFilter
/// </summary>
/// <remarks>
///    probe dataset in parallel using a vtkImageData
///
/// </remarks>
public class vtkPResampleFilter : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPResampleFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPResampleFilter()
	{
		MRClassNameKey = "class vtkPResampleFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPResampleFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPResampleFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPResampleFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPResampleFilter New()
	{
		vtkPResampleFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPResampleFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPResampleFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPResampleFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPResampleFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPResampleFilter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set and get the controller.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPResampleFilter_GetController_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPResampleFilter_GetCustomSamplingBounds_02(HandleRef pThis);

	/// <summary>
	/// Set/Get sampling bounds. If (UseInputBounds == 1) then the sampling
	/// bounds won't be used.
	/// </summary>
	public virtual double[] GetCustomSamplingBounds()
	{
		IntPtr intPtr = vtkPResampleFilter_GetCustomSamplingBounds_02(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPResampleFilter_GetCustomSamplingBounds_03(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

	/// <summary>
	/// Set/Get sampling bounds. If (UseInputBounds == 1) then the sampling
	/// bounds won't be used.
	/// </summary>
	public virtual void GetCustomSamplingBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
	{
		vtkPResampleFilter_GetCustomSamplingBounds_03(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPResampleFilter_GetCustomSamplingBounds_04(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get sampling bounds. If (UseInputBounds == 1) then the sampling
	/// bounds won't be used.
	/// </summary>
	public virtual void GetCustomSamplingBounds(IntPtr _arg)
	{
		vtkPResampleFilter_GetCustomSamplingBounds_04(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPResampleFilter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPResampleFilter_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPResampleFilter_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPResampleFilter_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPResampleFilter_GetSamplingDimension_07(HandleRef pThis);

	/// <summary>
	/// Set/Get sampling dimension along each axis. Default will be [10,10,10]
	/// </summary>
	public virtual int[] GetSamplingDimension()
	{
		IntPtr intPtr = vtkPResampleFilter_GetSamplingDimension_07(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPResampleFilter_GetSamplingDimension_08(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Set/Get sampling dimension along each axis. Default will be [10,10,10]
	/// </summary>
	public virtual void GetSamplingDimension(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkPResampleFilter_GetSamplingDimension_08(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPResampleFilter_GetSamplingDimension_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get sampling dimension along each axis. Default will be [10,10,10]
	/// </summary>
	public virtual void GetSamplingDimension(IntPtr _arg)
	{
		vtkPResampleFilter_GetSamplingDimension_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPResampleFilter_GetUseInputBounds_10(HandleRef pThis);

	/// <summary>
	/// Set/Get if the filter should use Input bounds to sub-sample the data.
	/// By default it is set to 1.
	/// </summary>
	public virtual int GetUseInputBounds()
	{
		return vtkPResampleFilter_GetUseInputBounds_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPResampleFilter_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPResampleFilter_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPResampleFilter_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPResampleFilter_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPResampleFilter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPResampleFilter NewInstance()
	{
		vtkPResampleFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPResampleFilter_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPResampleFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPResampleFilter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPResampleFilter SafeDownCast(vtkObjectBase o)
	{
		vtkPResampleFilter vtkPResampleFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPResampleFilter_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPResampleFilter2 = (vtkPResampleFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPResampleFilter2.Register(null);
			}
		}
		return vtkPResampleFilter2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPResampleFilter_SetController_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set and get the controller.
	/// </summary>
	public virtual void SetController(vtkMultiProcessController arg0)
	{
		vtkPResampleFilter_SetController_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPResampleFilter_SetCustomSamplingBounds_17(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set/Get sampling bounds. If (UseInputBounds == 1) then the sampling
	/// bounds won't be used.
	/// </summary>
	public virtual void SetCustomSamplingBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkPResampleFilter_SetCustomSamplingBounds_17(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPResampleFilter_SetCustomSamplingBounds_18(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get sampling bounds. If (UseInputBounds == 1) then the sampling
	/// bounds won't be used.
	/// </summary>
	public virtual void SetCustomSamplingBounds(IntPtr _arg)
	{
		vtkPResampleFilter_SetCustomSamplingBounds_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPResampleFilter_SetSamplingDimension_19(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Set/Get sampling dimension along each axis. Default will be [10,10,10]
	/// </summary>
	public virtual void SetSamplingDimension(int _arg1, int _arg2, int _arg3)
	{
		vtkPResampleFilter_SetSamplingDimension_19(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPResampleFilter_SetSamplingDimension_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get sampling dimension along each axis. Default will be [10,10,10]
	/// </summary>
	public virtual void SetSamplingDimension(IntPtr _arg)
	{
		vtkPResampleFilter_SetSamplingDimension_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPResampleFilter_SetUseInputBounds_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get if the filter should use Input bounds to sub-sample the data.
	/// By default it is set to 1.
	/// </summary>
	public virtual void SetUseInputBounds(int _arg)
	{
		vtkPResampleFilter_SetUseInputBounds_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPResampleFilter_UseInputBoundsOff_22(HandleRef pThis);

	/// <summary>
	/// Set/Get if the filter should use Input bounds to sub-sample the data.
	/// By default it is set to 1.
	/// </summary>
	public virtual void UseInputBoundsOff()
	{
		vtkPResampleFilter_UseInputBoundsOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPResampleFilter_UseInputBoundsOn_23(HandleRef pThis);

	/// <summary>
	/// Set/Get if the filter should use Input bounds to sub-sample the data.
	/// By default it is set to 1.
	/// </summary>
	public virtual void UseInputBoundsOn()
	{
		vtkPResampleFilter_UseInputBoundsOn_23(GetCppThis());
	}
}
