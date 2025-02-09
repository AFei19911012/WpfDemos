using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageDifference
/// </summary>
/// <remarks>
///    Compares images for regression tests.
///
/// vtkImageDifference takes two rgb unsigned char images and compares them.
/// It allows the images to be slightly different.  If AllowShift is on,
/// then each pixel can be shifted by two pixels. Threshold is the allowable
/// error for each pixel.
///
/// This is a symmetric filter and the difference computed is symmetric.
/// The resulting value is the maximum error of the two directions
/// A-&gt;B and B-&gt;A
/// </remarks>
public class vtkImageDifference : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageDifference";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageDifference()
	{
		MRClassNameKey = "class vtkImageDifference";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDifference"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageDifference(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDifference_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageDifference New()
	{
		vtkImageDifference result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDifference_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageDifference)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageDifference()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageDifference_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImageDifference_AllowShiftOff_01(HandleRef pThis);

	/// <summary>
	/// Specify whether the comparison will allow a shift of two
	/// pixels between the images.  If set, then the minimum difference
	/// between input images will be used to determine the difference.
	/// Otherwise, the difference is computed directly between pixels
	/// of identical row/column values.
	/// </summary>
	public virtual void AllowShiftOff()
	{
		vtkImageDifference_AllowShiftOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDifference_AllowShiftOn_02(HandleRef pThis);

	/// <summary>
	/// Specify whether the comparison will allow a shift of two
	/// pixels between the images.  If set, then the minimum difference
	/// between input images will be used to determine the difference.
	/// Otherwise, the difference is computed directly between pixels
	/// of identical row/column values.
	/// </summary>
	public virtual void AllowShiftOn()
	{
		vtkImageDifference_AllowShiftOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDifference_AveragingOff_03(HandleRef pThis);

	/// <summary>
	/// Specify whether the comparison will include comparison of
	/// averaged 3x3 data between the images. For graphics renderings
	/// you normally would leave this on. For imaging operations it
	/// should be off.
	/// </summary>
	public virtual void AveragingOff()
	{
		vtkImageDifference_AveragingOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDifference_AveragingOn_04(HandleRef pThis);

	/// <summary>
	/// Specify whether the comparison will include comparison of
	/// averaged 3x3 data between the images. For graphics renderings
	/// you normally would leave this on. For imaging operations it
	/// should be off.
	/// </summary>
	public virtual void AveragingOn()
	{
		vtkImageDifference_AveragingOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImageDifference_GetAllowShift_05(HandleRef pThis);

	/// <summary>
	/// Specify whether the comparison will allow a shift of two
	/// pixels between the images.  If set, then the minimum difference
	/// between input images will be used to determine the difference.
	/// Otherwise, the difference is computed directly between pixels
	/// of identical row/column values.
	/// </summary>
	public virtual bool GetAllowShift()
	{
		return (vtkImageDifference_GetAllowShift_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageDifference_GetAverageThresholdFactor_06(HandleRef pThis);

	/// <summary>
	/// When doing Averaging, adjust the threshold for the average
	/// by this factor. Defaults to 0.5 requiring a better match
	/// </summary>
	public virtual double GetAverageThresholdFactor()
	{
		return vtkImageDifference_GetAverageThresholdFactor_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImageDifference_GetAveraging_07(HandleRef pThis);

	/// <summary>
	/// Specify whether the comparison will include comparison of
	/// averaged 3x3 data between the images. For graphics renderings
	/// you normally would leave this on. For imaging operations it
	/// should be off.
	/// </summary>
	public virtual bool GetAveraging()
	{
		return (vtkImageDifference_GetAveraging_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageDifference_GetError_08(HandleRef pThis);

	/// <summary>
	/// Return the total error in comparing the two images.
	/// </summary>
	public double GetError()
	{
		return vtkImageDifference_GetError_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDifference_GetError_09(HandleRef pThis, IntPtr e);

	/// <summary>
	/// Return the total error in comparing the two images.
	/// </summary>
	public void GetError(IntPtr e)
	{
		vtkImageDifference_GetError_09(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDifference_GetImage_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the Image to compare the input to.
	/// </summary>
	public vtkImageData GetImage()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDifference_GetImage_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageDifference_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageDifference_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageDifference_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageDifference_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDifference_GetThreshold_13(HandleRef pThis);

	/// <summary>
	/// Specify a threshold tolerance for pixel differences.
	/// </summary>
	public virtual int GetThreshold()
	{
		return vtkImageDifference_GetThreshold_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageDifference_GetThresholdedError_14(HandleRef pThis);

	/// <summary>
	/// Return the total thresholded error in comparing the two images.
	/// The thresholded error is the error for a given pixel minus the
	/// threshold and clamped at a minimum of zero.
	/// </summary>
	public double GetThresholdedError()
	{
		return vtkImageDifference_GetThresholdedError_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDifference_GetThresholdedError_15(HandleRef pThis, IntPtr e);

	/// <summary>
	/// Return the total thresholded error in comparing the two images.
	/// The thresholded error is the error for a given pixel minus the
	/// threshold and clamped at a minimum of zero.
	/// </summary>
	public void GetThresholdedError(IntPtr e)
	{
		vtkImageDifference_GetThresholdedError_15(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDifference_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageDifference_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDifference_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageDifference_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDifference_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageDifference NewInstance()
	{
		vtkImageDifference result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDifference_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageDifference)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDifference_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageDifference SafeDownCast(vtkObjectBase o)
	{
		vtkImageDifference vtkImageDifference2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDifference_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageDifference2 = (vtkImageDifference)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageDifference2.Register(null);
			}
		}
		return vtkImageDifference2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDifference_SetAllowShift_21(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether the comparison will allow a shift of two
	/// pixels between the images.  If set, then the minimum difference
	/// between input images will be used to determine the difference.
	/// Otherwise, the difference is computed directly between pixels
	/// of identical row/column values.
	/// </summary>
	public virtual void SetAllowShift(bool _arg)
	{
		vtkImageDifference_SetAllowShift_21(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDifference_SetAverageThresholdFactor_22(HandleRef pThis, double _arg);

	/// <summary>
	/// When doing Averaging, adjust the threshold for the average
	/// by this factor. Defaults to 0.5 requiring a better match
	/// </summary>
	public virtual void SetAverageThresholdFactor(double _arg)
	{
		vtkImageDifference_SetAverageThresholdFactor_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDifference_SetAveraging_23(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether the comparison will include comparison of
	/// averaged 3x3 data between the images. For graphics renderings
	/// you normally would leave this on. For imaging operations it
	/// should be off.
	/// </summary>
	public virtual void SetAveraging(bool _arg)
	{
		vtkImageDifference_SetAveraging_23(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDifference_SetImageConnection_24(HandleRef pThis, HandleRef output);

	/// <summary>
	/// Specify the Image to compare the input to.
	/// </summary>
	public void SetImageConnection(vtkAlgorithmOutput output)
	{
		vtkImageDifference_SetImageConnection_24(GetCppThis(), output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDifference_SetImageData_25(HandleRef pThis, HandleRef image);

	/// <summary>
	/// Specify the Image to compare the input to.
	/// </summary>
	public void SetImageData(vtkDataObject image)
	{
		vtkImageDifference_SetImageData_25(GetCppThis(), image?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDifference_SetThreshold_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify a threshold tolerance for pixel differences.
	/// </summary>
	public virtual void SetThreshold(int _arg)
	{
		vtkImageDifference_SetThreshold_26(GetCppThis(), _arg);
	}
}
