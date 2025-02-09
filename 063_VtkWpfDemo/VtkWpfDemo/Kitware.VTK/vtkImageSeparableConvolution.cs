using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageSeparableConvolution
/// </summary>
/// <remarks>
///     3 1D convolutions on an image
///
/// vtkImageSeparableConvolution performs a convolution along the X, Y,
/// and Z axes of an image, based on the three different 1D convolution
/// kernels.  The kernels must be of odd size, and are considered to be
/// centered at (int)((kernelsize - 1) / 2.0 ).  If a kernel is nullptr,
/// that dimension is skipped.  This filter is designed to efficiently
/// convolve separable filters that can be decomposed into 1 or more 1D
/// convolutions.  It also handles arbitrarily large kernel sizes, and
/// uses edge replication to handle boundaries.
/// </remarks>
public class vtkImageSeparableConvolution : vtkImageDecomposeFilter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageSeparableConvolution";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageSeparableConvolution()
	{
		MRClassNameKey = "class vtkImageSeparableConvolution";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSeparableConvolution"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageSeparableConvolution(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSeparableConvolution_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageSeparableConvolution New()
	{
		vtkImageSeparableConvolution result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSeparableConvolution_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageSeparableConvolution)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageSeparableConvolution()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageSeparableConvolution_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkImageSeparableConvolution_GetMTime_01(HandleRef pThis);

	/// <summary>
	/// Overload standard modified time function. If kernel arrays are modified,
	/// then this object is modified as well.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImageSeparableConvolution_GetMTime_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageSeparableConvolution_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageSeparableConvolution_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageSeparableConvolution_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageSeparableConvolution_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSeparableConvolution_GetXKernel_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual vtkFloatArray GetXKernel()
	{
		vtkFloatArray vtkFloatArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSeparableConvolution_GetXKernel_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFloatArray2 = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFloatArray2.Register(null);
			}
		}
		return vtkFloatArray2;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSeparableConvolution_GetYKernel_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual vtkFloatArray GetYKernel()
	{
		vtkFloatArray vtkFloatArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSeparableConvolution_GetYKernel_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFloatArray2 = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFloatArray2.Register(null);
			}
		}
		return vtkFloatArray2;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSeparableConvolution_GetZKernel_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual vtkFloatArray GetZKernel()
	{
		vtkFloatArray vtkFloatArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSeparableConvolution_GetZKernel_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFloatArray2 = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFloatArray2.Register(null);
			}
		}
		return vtkFloatArray2;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSeparableConvolution_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageSeparableConvolution_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSeparableConvolution_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageSeparableConvolution_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSeparableConvolution_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageSeparableConvolution NewInstance()
	{
		vtkImageSeparableConvolution result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSeparableConvolution_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageSeparableConvolution)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSeparableConvolution_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageSeparableConvolution SafeDownCast(vtkObjectBase o)
	{
		vtkImageSeparableConvolution vtkImageSeparableConvolution2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSeparableConvolution_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageSeparableConvolution2 = (vtkImageSeparableConvolution)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageSeparableConvolution2.Register(null);
			}
		}
		return vtkImageSeparableConvolution2;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSeparableConvolution_SetXKernel_12(HandleRef pThis, HandleRef arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetXKernel(vtkFloatArray arg0)
	{
		vtkImageSeparableConvolution_SetXKernel_12(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSeparableConvolution_SetYKernel_13(HandleRef pThis, HandleRef arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetYKernel(vtkFloatArray arg0)
	{
		vtkImageSeparableConvolution_SetYKernel_13(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSeparableConvolution_SetZKernel_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetZKernel(vtkFloatArray arg0)
	{
		vtkImageSeparableConvolution_SetZKernel_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
