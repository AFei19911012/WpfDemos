using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkResampleToImage
/// </summary>
/// <remarks>
///    sample dataset on a uniform grid
///
/// vtkPResampleToImage is a filter that resamples the input dataset on
/// a uniform grid. It internally uses vtkProbeFilter to do the probing.
/// </remarks>
/// <seealso>
///
/// vtkProbeFilter
/// </seealso>
public class vtkResampleToImage : vtkAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkResampleToImage";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkResampleToImage()
	{
		MRClassNameKey = "class vtkResampleToImage";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkResampleToImage"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkResampleToImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResampleToImage_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkResampleToImage New()
	{
		vtkResampleToImage result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResampleToImage_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResampleToImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkResampleToImage()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkResampleToImage_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResampleToImage_GetMaskArrayName_01(HandleRef pThis);

	/// <summary>
	/// Get the name of the valid-points mask array.
	/// </summary>
	public string GetMaskArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkResampleToImage_GetMaskArrayName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResampleToImage_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkResampleToImage_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResampleToImage_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkResampleToImage_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResampleToImage_GetOutput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output data for this algorithm.
	/// </summary>
	public vtkImageData GetOutput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResampleToImage_GetOutput_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResampleToImage_GetSamplingBounds_05(HandleRef pThis);

	/// <summary>
	/// Set/Get sampling bounds. If (UseInputBounds == 1) then the sampling
	/// bounds won't be used.
	/// </summary>
	public virtual double[] GetSamplingBounds()
	{
		IntPtr intPtr = vtkResampleToImage_GetSamplingBounds_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleToImage_GetSamplingBounds_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

	/// <summary>
	/// Set/Get sampling bounds. If (UseInputBounds == 1) then the sampling
	/// bounds won't be used.
	/// </summary>
	public virtual void GetSamplingBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
	{
		vtkResampleToImage_GetSamplingBounds_06(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleToImage_GetSamplingBounds_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get sampling bounds. If (UseInputBounds == 1) then the sampling
	/// bounds won't be used.
	/// </summary>
	public virtual void GetSamplingBounds(IntPtr _arg)
	{
		vtkResampleToImage_GetSamplingBounds_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResampleToImage_GetSamplingDimensions_08(HandleRef pThis);

	/// <summary>
	/// Set/Get sampling dimension along each axis. Default will be [10,10,10]
	/// </summary>
	public virtual int[] GetSamplingDimensions()
	{
		IntPtr intPtr = vtkResampleToImage_GetSamplingDimensions_08(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleToImage_GetSamplingDimensions_09(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Set/Get sampling dimension along each axis. Default will be [10,10,10]
	/// </summary>
	public virtual void GetSamplingDimensions(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkResampleToImage_GetSamplingDimensions_09(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleToImage_GetSamplingDimensions_10(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get sampling dimension along each axis. Default will be [10,10,10]
	/// </summary>
	public virtual void GetSamplingDimensions(IntPtr _arg)
	{
		vtkResampleToImage_GetSamplingDimensions_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkResampleToImage_GetUseInputBounds_11(HandleRef pThis);

	/// <summary>
	/// Set/Get if the filter should use Input bounds to sub-sample the data.
	/// By default it is set to 1.
	/// </summary>
	public virtual bool GetUseInputBounds()
	{
		return (vtkResampleToImage_GetUseInputBounds_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResampleToImage_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkResampleToImage_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResampleToImage_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkResampleToImage_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResampleToImage_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkResampleToImage NewInstance()
	{
		vtkResampleToImage result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResampleToImage_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResampleToImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResampleToImage_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkResampleToImage SafeDownCast(vtkObjectBase o)
	{
		vtkResampleToImage vtkResampleToImage2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResampleToImage_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResampleToImage2 = (vtkResampleToImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResampleToImage2.Register(null);
			}
		}
		return vtkResampleToImage2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleToImage_SetSamplingBounds_17(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set/Get sampling bounds. If (UseInputBounds == 1) then the sampling
	/// bounds won't be used.
	/// </summary>
	public virtual void SetSamplingBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkResampleToImage_SetSamplingBounds_17(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleToImage_SetSamplingBounds_18(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get sampling bounds. If (UseInputBounds == 1) then the sampling
	/// bounds won't be used.
	/// </summary>
	public virtual void SetSamplingBounds(IntPtr _arg)
	{
		vtkResampleToImage_SetSamplingBounds_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleToImage_SetSamplingDimensions_19(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Set/Get sampling dimension along each axis. Default will be [10,10,10]
	/// </summary>
	public virtual void SetSamplingDimensions(int _arg1, int _arg2, int _arg3)
	{
		vtkResampleToImage_SetSamplingDimensions_19(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleToImage_SetSamplingDimensions_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get sampling dimension along each axis. Default will be [10,10,10]
	/// </summary>
	public virtual void SetSamplingDimensions(IntPtr _arg)
	{
		vtkResampleToImage_SetSamplingDimensions_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleToImage_SetUseInputBounds_21(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get if the filter should use Input bounds to sub-sample the data.
	/// By default it is set to 1.
	/// </summary>
	public virtual void SetUseInputBounds(bool _arg)
	{
		vtkResampleToImage_SetUseInputBounds_21(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleToImage_UseInputBoundsOff_22(HandleRef pThis);

	/// <summary>
	/// Set/Get if the filter should use Input bounds to sub-sample the data.
	/// By default it is set to 1.
	/// </summary>
	public virtual void UseInputBoundsOff()
	{
		vtkResampleToImage_UseInputBoundsOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleToImage_UseInputBoundsOn_23(HandleRef pThis);

	/// <summary>
	/// Set/Get if the filter should use Input bounds to sub-sample the data.
	/// By default it is set to 1.
	/// </summary>
	public virtual void UseInputBoundsOn()
	{
		vtkResampleToImage_UseInputBoundsOn_23(GetCppThis());
	}
}
