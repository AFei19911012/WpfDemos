using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageShrink3D
/// </summary>
/// <remarks>
///    Subsamples an image.
///
/// vtkImageShrink3D shrinks an image by sub sampling on a
/// uniform grid (integer multiples).
/// </remarks>
public class vtkImageShrink3D : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageShrink3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageShrink3D()
	{
		MRClassNameKey = "class vtkImageShrink3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageShrink3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageShrink3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageShrink3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageShrink3D New()
	{
		vtkImageShrink3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageShrink3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageShrink3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageShrink3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageShrink3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_AveragingOff_01(HandleRef pThis);

	/// <summary>
	/// Choose Mean, Minimum, Maximum, Median or sub sampling.
	/// The neighborhood operations are not centered on the sampled pixel.
	/// This may cause a half pixel shift in your output image.
	/// You can changed "Shift" to get around this.
	/// vtkImageGaussianSmooth or vtkImageMean with strides.
	/// </summary>
	public virtual void AveragingOff()
	{
		vtkImageShrink3D_AveragingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_AveragingOn_02(HandleRef pThis);

	/// <summary>
	/// Choose Mean, Minimum, Maximum, Median or sub sampling.
	/// The neighborhood operations are not centered on the sampled pixel.
	/// This may cause a half pixel shift in your output image.
	/// You can changed "Shift" to get around this.
	/// vtkImageGaussianSmooth or vtkImageMean with strides.
	/// </summary>
	public virtual void AveragingOn()
	{
		vtkImageShrink3D_AveragingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageShrink3D_GetAveraging_03(HandleRef pThis);

	/// <summary>
	/// Choose Mean, Minimum, Maximum, Median or sub sampling.
	/// The neighborhood operations are not centered on the sampled pixel.
	/// This may cause a half pixel shift in your output image.
	/// You can changed "Shift" to get around this.
	/// vtkImageGaussianSmooth or vtkImageMean with strides.
	/// </summary>
	public int GetAveraging()
	{
		return vtkImageShrink3D_GetAveraging_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageShrink3D_GetMaximum_04(HandleRef pThis);

	/// <summary>
	/// Choose Mean, Minimum, Maximum, Median or sub sampling.
	/// The neighborhood operations are not centered on the sampled pixel.
	/// This may cause a half pixel shift in your output image.
	/// You can changed "Shift" to get around this.
	/// vtkImageGaussianSmooth or vtkImageMean with strides.
	/// </summary>
	public virtual int GetMaximum()
	{
		return vtkImageShrink3D_GetMaximum_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageShrink3D_GetMean_05(HandleRef pThis);

	/// <summary>
	/// Choose Mean, Minimum, Maximum, Median or sub sampling.
	/// The neighborhood operations are not centered on the sampled pixel.
	/// This may cause a half pixel shift in your output image.
	/// You can changed "Shift" to get around this.
	/// vtkImageGaussianSmooth or vtkImageMean with strides.
	/// </summary>
	public virtual int GetMean()
	{
		return vtkImageShrink3D_GetMean_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageShrink3D_GetMedian_06(HandleRef pThis);

	/// <summary>
	/// Choose Mean, Minimum, Maximum, Median or sub sampling.
	/// The neighborhood operations are not centered on the sampled pixel.
	/// This may cause a half pixel shift in your output image.
	/// You can changed "Shift" to get around this.
	/// vtkImageGaussianSmooth or vtkImageMean with strides.
	/// </summary>
	public virtual int GetMedian()
	{
		return vtkImageShrink3D_GetMedian_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageShrink3D_GetMinimum_07(HandleRef pThis);

	/// <summary>
	/// Choose Mean, Minimum, Maximum, Median or sub sampling.
	/// The neighborhood operations are not centered on the sampled pixel.
	/// This may cause a half pixel shift in your output image.
	/// You can changed "Shift" to get around this.
	/// vtkImageGaussianSmooth or vtkImageMean with strides.
	/// </summary>
	public virtual int GetMinimum()
	{
		return vtkImageShrink3D_GetMinimum_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageShrink3D_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageShrink3D_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageShrink3D_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageShrink3D_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageShrink3D_GetShift_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the pixel to use as origin.
	/// </summary>
	public virtual int[] GetShift()
	{
		IntPtr intPtr = vtkImageShrink3D_GetShift_10(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_GetShift_11(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Set/Get the pixel to use as origin.
	/// </summary>
	public virtual void GetShift(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkImageShrink3D_GetShift_11(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_GetShift_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the pixel to use as origin.
	/// </summary>
	public virtual void GetShift(IntPtr _arg)
	{
		vtkImageShrink3D_GetShift_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageShrink3D_GetShrinkFactors_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the shrink factors
	/// </summary>
	public virtual int[] GetShrinkFactors()
	{
		IntPtr intPtr = vtkImageShrink3D_GetShrinkFactors_13(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_GetShrinkFactors_14(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Set/Get the shrink factors
	/// </summary>
	public virtual void GetShrinkFactors(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkImageShrink3D_GetShrinkFactors_14(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_GetShrinkFactors_15(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the shrink factors
	/// </summary>
	public virtual void GetShrinkFactors(IntPtr _arg)
	{
		vtkImageShrink3D_GetShrinkFactors_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageShrink3D_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageShrink3D_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageShrink3D_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageShrink3D_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_MaximumOff_18(HandleRef pThis);

	/// <summary>
	/// Choose Mean, Minimum, Maximum, Median or sub sampling.
	/// The neighborhood operations are not centered on the sampled pixel.
	/// This may cause a half pixel shift in your output image.
	/// You can changed "Shift" to get around this.
	/// vtkImageGaussianSmooth or vtkImageMean with strides.
	/// </summary>
	public virtual void MaximumOff()
	{
		vtkImageShrink3D_MaximumOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_MaximumOn_19(HandleRef pThis);

	/// <summary>
	/// Choose Mean, Minimum, Maximum, Median or sub sampling.
	/// The neighborhood operations are not centered on the sampled pixel.
	/// This may cause a half pixel shift in your output image.
	/// You can changed "Shift" to get around this.
	/// vtkImageGaussianSmooth or vtkImageMean with strides.
	/// </summary>
	public virtual void MaximumOn()
	{
		vtkImageShrink3D_MaximumOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_MeanOff_20(HandleRef pThis);

	/// <summary>
	/// Choose Mean, Minimum, Maximum, Median or sub sampling.
	/// The neighborhood operations are not centered on the sampled pixel.
	/// This may cause a half pixel shift in your output image.
	/// You can changed "Shift" to get around this.
	/// vtkImageGaussianSmooth or vtkImageMean with strides.
	/// </summary>
	public virtual void MeanOff()
	{
		vtkImageShrink3D_MeanOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_MeanOn_21(HandleRef pThis);

	/// <summary>
	/// Choose Mean, Minimum, Maximum, Median or sub sampling.
	/// The neighborhood operations are not centered on the sampled pixel.
	/// This may cause a half pixel shift in your output image.
	/// You can changed "Shift" to get around this.
	/// vtkImageGaussianSmooth or vtkImageMean with strides.
	/// </summary>
	public virtual void MeanOn()
	{
		vtkImageShrink3D_MeanOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_MedianOff_22(HandleRef pThis);

	/// <summary>
	/// Choose Mean, Minimum, Maximum, Median or sub sampling.
	/// The neighborhood operations are not centered on the sampled pixel.
	/// This may cause a half pixel shift in your output image.
	/// You can changed "Shift" to get around this.
	/// vtkImageGaussianSmooth or vtkImageMean with strides.
	/// </summary>
	public virtual void MedianOff()
	{
		vtkImageShrink3D_MedianOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_MedianOn_23(HandleRef pThis);

	/// <summary>
	/// Choose Mean, Minimum, Maximum, Median or sub sampling.
	/// The neighborhood operations are not centered on the sampled pixel.
	/// This may cause a half pixel shift in your output image.
	/// You can changed "Shift" to get around this.
	/// vtkImageGaussianSmooth or vtkImageMean with strides.
	/// </summary>
	public virtual void MedianOn()
	{
		vtkImageShrink3D_MedianOn_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_MinimumOff_24(HandleRef pThis);

	/// <summary>
	/// Choose Mean, Minimum, Maximum, Median or sub sampling.
	/// The neighborhood operations are not centered on the sampled pixel.
	/// This may cause a half pixel shift in your output image.
	/// You can changed "Shift" to get around this.
	/// vtkImageGaussianSmooth or vtkImageMean with strides.
	/// </summary>
	public virtual void MinimumOff()
	{
		vtkImageShrink3D_MinimumOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_MinimumOn_25(HandleRef pThis);

	/// <summary>
	/// Choose Mean, Minimum, Maximum, Median or sub sampling.
	/// The neighborhood operations are not centered on the sampled pixel.
	/// This may cause a half pixel shift in your output image.
	/// You can changed "Shift" to get around this.
	/// vtkImageGaussianSmooth or vtkImageMean with strides.
	/// </summary>
	public virtual void MinimumOn()
	{
		vtkImageShrink3D_MinimumOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageShrink3D_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageShrink3D NewInstance()
	{
		vtkImageShrink3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageShrink3D_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageShrink3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageShrink3D_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageShrink3D SafeDownCast(vtkObjectBase o)
	{
		vtkImageShrink3D vtkImageShrink3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageShrink3D_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageShrink3D2 = (vtkImageShrink3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageShrink3D2.Register(null);
			}
		}
		return vtkImageShrink3D2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_SetAveraging_29(HandleRef pThis, int arg0);

	/// <summary>
	/// Choose Mean, Minimum, Maximum, Median or sub sampling.
	/// The neighborhood operations are not centered on the sampled pixel.
	/// This may cause a half pixel shift in your output image.
	/// You can changed "Shift" to get around this.
	/// vtkImageGaussianSmooth or vtkImageMean with strides.
	/// </summary>
	public void SetAveraging(int arg0)
	{
		vtkImageShrink3D_SetAveraging_29(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_SetMaximum_30(HandleRef pThis, int arg0);

	/// <summary>
	/// Choose Mean, Minimum, Maximum, Median or sub sampling.
	/// The neighborhood operations are not centered on the sampled pixel.
	/// This may cause a half pixel shift in your output image.
	/// You can changed "Shift" to get around this.
	/// vtkImageGaussianSmooth or vtkImageMean with strides.
	/// </summary>
	public void SetMaximum(int arg0)
	{
		vtkImageShrink3D_SetMaximum_30(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_SetMean_31(HandleRef pThis, int arg0);

	/// <summary>
	/// Choose Mean, Minimum, Maximum, Median or sub sampling.
	/// The neighborhood operations are not centered on the sampled pixel.
	/// This may cause a half pixel shift in your output image.
	/// You can changed "Shift" to get around this.
	/// vtkImageGaussianSmooth or vtkImageMean with strides.
	/// </summary>
	public void SetMean(int arg0)
	{
		vtkImageShrink3D_SetMean_31(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_SetMedian_32(HandleRef pThis, int arg0);

	/// <summary>
	/// Choose Mean, Minimum, Maximum, Median or sub sampling.
	/// The neighborhood operations are not centered on the sampled pixel.
	/// This may cause a half pixel shift in your output image.
	/// You can changed "Shift" to get around this.
	/// vtkImageGaussianSmooth or vtkImageMean with strides.
	/// </summary>
	public void SetMedian(int arg0)
	{
		vtkImageShrink3D_SetMedian_32(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_SetMinimum_33(HandleRef pThis, int arg0);

	/// <summary>
	/// Choose Mean, Minimum, Maximum, Median or sub sampling.
	/// The neighborhood operations are not centered on the sampled pixel.
	/// This may cause a half pixel shift in your output image.
	/// You can changed "Shift" to get around this.
	/// vtkImageGaussianSmooth or vtkImageMean with strides.
	/// </summary>
	public void SetMinimum(int arg0)
	{
		vtkImageShrink3D_SetMinimum_33(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_SetShift_34(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Set/Get the pixel to use as origin.
	/// </summary>
	public virtual void SetShift(int _arg1, int _arg2, int _arg3)
	{
		vtkImageShrink3D_SetShift_34(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_SetShift_35(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the pixel to use as origin.
	/// </summary>
	public virtual void SetShift(IntPtr _arg)
	{
		vtkImageShrink3D_SetShift_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_SetShrinkFactors_36(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Set/Get the shrink factors
	/// </summary>
	public virtual void SetShrinkFactors(int _arg1, int _arg2, int _arg3)
	{
		vtkImageShrink3D_SetShrinkFactors_36(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShrink3D_SetShrinkFactors_37(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the shrink factors
	/// </summary>
	public virtual void SetShrinkFactors(IntPtr _arg)
	{
		vtkImageShrink3D_SetShrinkFactors_37(GetCppThis(), _arg);
	}
}
