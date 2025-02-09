using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageConvolve
/// </summary>
/// <remarks>
///    Convolution of an image with a kernel.
///
/// vtkImageConvolve convolves the image with a 3D NxNxN kernel or a
/// 2D NxN kernel.  The output image is cropped to the same size as
/// the input.
/// </remarks>
public class vtkImageConvolve : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageConvolve";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageConvolve()
	{
		MRClassNameKey = "class vtkImageConvolve";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageConvolve"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageConvolve(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConvolve_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an instance of vtkImageConvolve filter.
	/// </summary>
	public new static vtkImageConvolve New()
	{
		vtkImageConvolve result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageConvolve_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageConvolve)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct an instance of vtkImageConvolve filter.
	/// </summary>
	public vtkImageConvolve()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageConvolve_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConvolve_GetKernel3x3_01(HandleRef pThis);

	/// <summary>
	/// Return an array that contains the kernel.
	/// </summary>
	public IntPtr GetKernel3x3()
	{
		return vtkImageConvolve_GetKernel3x3_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConvolve_GetKernel3x3_02(HandleRef pThis, IntPtr kernel);

	/// <summary>
	/// Return an array that contains the kernel.
	/// </summary>
	public void GetKernel3x3(IntPtr kernel)
	{
		vtkImageConvolve_GetKernel3x3_02(GetCppThis(), kernel);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConvolve_GetKernel3x3x3_03(HandleRef pThis);

	/// <summary>
	/// Return an array that contains the kernel
	/// </summary>
	public IntPtr GetKernel3x3x3()
	{
		return vtkImageConvolve_GetKernel3x3x3_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConvolve_GetKernel3x3x3_04(HandleRef pThis, IntPtr kernel);

	/// <summary>
	/// Return an array that contains the kernel
	/// </summary>
	public void GetKernel3x3x3(IntPtr kernel)
	{
		vtkImageConvolve_GetKernel3x3x3_04(GetCppThis(), kernel);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConvolve_GetKernel5x5_05(HandleRef pThis);

	/// <summary>
	/// Return an array that contains the kernel.
	/// </summary>
	public IntPtr GetKernel5x5()
	{
		return vtkImageConvolve_GetKernel5x5_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConvolve_GetKernel5x5_06(HandleRef pThis, IntPtr kernel);

	/// <summary>
	/// Return an array that contains the kernel.
	/// </summary>
	public void GetKernel5x5(IntPtr kernel)
	{
		vtkImageConvolve_GetKernel5x5_06(GetCppThis(), kernel);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConvolve_GetKernel5x5x5_07(HandleRef pThis);

	/// <summary>
	/// Return an array that contains the kernel
	/// </summary>
	public IntPtr GetKernel5x5x5()
	{
		return vtkImageConvolve_GetKernel5x5x5_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConvolve_GetKernel5x5x5_08(HandleRef pThis, IntPtr kernel);

	/// <summary>
	/// Return an array that contains the kernel
	/// </summary>
	public void GetKernel5x5x5(IntPtr kernel)
	{
		vtkImageConvolve_GetKernel5x5x5_08(GetCppThis(), kernel);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConvolve_GetKernel7x7_09(HandleRef pThis);

	/// <summary>
	/// Return an array that contains the kernel.
	/// </summary>
	public IntPtr GetKernel7x7()
	{
		return vtkImageConvolve_GetKernel7x7_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConvolve_GetKernel7x7_10(HandleRef pThis, IntPtr kernel);

	/// <summary>
	/// Return an array that contains the kernel.
	/// </summary>
	public void GetKernel7x7(IntPtr kernel)
	{
		vtkImageConvolve_GetKernel7x7_10(GetCppThis(), kernel);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConvolve_GetKernel7x7x7_11(HandleRef pThis);

	/// <summary>
	/// Return an array that contains the kernel
	/// </summary>
	public IntPtr GetKernel7x7x7()
	{
		return vtkImageConvolve_GetKernel7x7x7_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConvolve_GetKernel7x7x7_12(HandleRef pThis, IntPtr kernel);

	/// <summary>
	/// Return an array that contains the kernel
	/// </summary>
	public void GetKernel7x7x7(IntPtr kernel)
	{
		vtkImageConvolve_GetKernel7x7x7_12(GetCppThis(), kernel);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConvolve_GetKernelSize_13(HandleRef pThis);

	/// <summary>
	/// Get the kernel size
	/// </summary>
	public virtual int[] GetKernelSize()
	{
		IntPtr intPtr = vtkImageConvolve_GetKernelSize_13(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConvolve_GetKernelSize_14(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Get the kernel size
	/// </summary>
	public virtual void GetKernelSize(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkImageConvolve_GetKernelSize_14(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConvolve_GetKernelSize_15(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the kernel size
	/// </summary>
	public virtual void GetKernelSize(IntPtr _arg)
	{
		vtkImageConvolve_GetKernelSize_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageConvolve_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	/// Construct an instance of vtkImageConvolve filter.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageConvolve_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageConvolve_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	/// Construct an instance of vtkImageConvolve filter.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageConvolve_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageConvolve_IsA_18(HandleRef pThis, string type);

	/// <summary>
	/// Construct an instance of vtkImageConvolve filter.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageConvolve_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageConvolve_IsTypeOf_19(string type);

	/// <summary>
	/// Construct an instance of vtkImageConvolve filter.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageConvolve_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConvolve_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an instance of vtkImageConvolve filter.
	/// </summary>
	public new vtkImageConvolve NewInstance()
	{
		vtkImageConvolve result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageConvolve_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageConvolve)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConvolve_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an instance of vtkImageConvolve filter.
	/// </summary>
	public new static vtkImageConvolve SafeDownCast(vtkObjectBase o)
	{
		vtkImageConvolve vtkImageConvolve2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageConvolve_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageConvolve2 = (vtkImageConvolve)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageConvolve2.Register(null);
			}
		}
		return vtkImageConvolve2;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConvolve_SetKernel3x3_23(HandleRef pThis, IntPtr kernel);

	/// <summary>
	/// Set the kernel to be a given 3x3 or 5x5 or 7x7 kernel.
	/// </summary>
	public void SetKernel3x3(IntPtr kernel)
	{
		vtkImageConvolve_SetKernel3x3_23(GetCppThis(), kernel);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConvolve_SetKernel3x3x3_24(HandleRef pThis, IntPtr kernel);

	/// <summary>
	/// Set the kernel to be a 3x3x3 or 5x5x5 or 7x7x7 kernel.
	/// </summary>
	public void SetKernel3x3x3(IntPtr kernel)
	{
		vtkImageConvolve_SetKernel3x3x3_24(GetCppThis(), kernel);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConvolve_SetKernel5x5_25(HandleRef pThis, IntPtr kernel);

	/// <summary>
	/// Set the kernel to be a given 3x3 or 5x5 or 7x7 kernel.
	/// </summary>
	public void SetKernel5x5(IntPtr kernel)
	{
		vtkImageConvolve_SetKernel5x5_25(GetCppThis(), kernel);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConvolve_SetKernel5x5x5_26(HandleRef pThis, IntPtr kernel);

	/// <summary>
	/// Set the kernel to be a 3x3x3 or 5x5x5 or 7x7x7 kernel.
	/// </summary>
	public void SetKernel5x5x5(IntPtr kernel)
	{
		vtkImageConvolve_SetKernel5x5x5_26(GetCppThis(), kernel);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConvolve_SetKernel7x7_27(HandleRef pThis, IntPtr kernel);

	/// <summary>
	/// Set the kernel to be a given 3x3 or 5x5 or 7x7 kernel.
	/// </summary>
	public void SetKernel7x7(IntPtr kernel)
	{
		vtkImageConvolve_SetKernel7x7_27(GetCppThis(), kernel);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConvolve_SetKernel7x7x7_28(HandleRef pThis, IntPtr kernel);

	/// <summary>
	/// Set the kernel to be a 3x3x3 or 5x5x5 or 7x7x7 kernel.
	/// </summary>
	public void SetKernel7x7x7(IntPtr kernel)
	{
		vtkImageConvolve_SetKernel7x7x7_28(GetCppThis(), kernel);
	}
}
