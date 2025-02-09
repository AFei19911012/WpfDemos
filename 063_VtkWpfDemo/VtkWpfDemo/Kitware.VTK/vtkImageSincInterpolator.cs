using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageSincInterpolator
/// </summary>
/// <remarks>
///    perform sinc interpolation on images
///
/// vtkImageSincInterpolator provides various windowed sinc interpolation
/// methods for image data.  The default is a five-lobed Lanczos interpolant,
/// with a kernel size of 6.  The interpolator can also bandlimit the image,
/// which can be used for antialiasing.  The interpolation kernels are
/// evaluated via a lookup table for efficiency.
/// @par Thanks:
/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
/// </remarks>
/// <seealso>
///
/// vtkImageReslice
/// </seealso>
public class vtkImageSincInterpolator : vtkAbstractImageInterpolator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageSincInterpolator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageSincInterpolator()
	{
		MRClassNameKey = "class vtkImageSincInterpolator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSincInterpolator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageSincInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSincInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageSincInterpolator New()
	{
		vtkImageSincInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSincInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageSincInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageSincInterpolator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageSincInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImageSincInterpolator_AntialiasingOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on antialiasing.  If antialiasing is on, then the BlurFactors
	/// will be computed automatically from the output sampling rate such that
	/// that the image will be bandlimited to the Nyquist frequency.  This
	/// is only applicable when the interpolator is being used by a resampling
	/// filter like vtkImageReslice.  Such a filter will indicate the output
	/// sampling by calling the interpolator's ComputeSupportSize() method,
	/// which will compute the blur factors at the same time that it computes
	/// the support size.
	/// </summary>
	public void AntialiasingOff()
	{
		vtkImageSincInterpolator_AntialiasingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_AntialiasingOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on antialiasing.  If antialiasing is on, then the BlurFactors
	/// will be computed automatically from the output sampling rate such that
	/// that the image will be bandlimited to the Nyquist frequency.  This
	/// is only applicable when the interpolator is being used by a resampling
	/// filter like vtkImageReslice.  Such a filter will indicate the output
	/// sampling by calling the interpolator's ComputeSupportSize() method,
	/// which will compute the blur factors at the same time that it computes
	/// the support size.
	/// </summary>
	public void AntialiasingOn()
	{
		vtkImageSincInterpolator_AntialiasingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_ComputeSupportSize_03(HandleRef pThis, IntPtr matrix, IntPtr support);

	/// <summary>
	/// Get the support size for use in computing update extents.  If the data
	/// will be sampled on a regular grid, then pass a matrix describing the
	/// structured coordinate transformation between the output and the input.
	/// Otherwise, pass nullptr as the matrix to retrieve the full kernel size.
	/// </summary>
	public override void ComputeSupportSize(IntPtr matrix, IntPtr support)
	{
		vtkImageSincInterpolator_ComputeSupportSize_03(GetCppThis(), matrix, support);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSincInterpolator_GetAntialiasing_04(HandleRef pThis);

	/// <summary>
	/// Turn on antialiasing.  If antialiasing is on, then the BlurFactors
	/// will be computed automatically from the output sampling rate such that
	/// that the image will be bandlimited to the Nyquist frequency.  This
	/// is only applicable when the interpolator is being used by a resampling
	/// filter like vtkImageReslice.  Such a filter will indicate the output
	/// sampling by calling the interpolator's ComputeSupportSize() method,
	/// which will compute the blur factors at the same time that it computes
	/// the support size.
	/// </summary>
	public int GetAntialiasing()
	{
		return vtkImageSincInterpolator_GetAntialiasing_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_GetBlurFactors_05(HandleRef pThis, IntPtr f);

	/// <summary>
	/// Blur the image by widening the windowed sinc kernel by the specified
	/// factors for the x, y, and z directions.  This reduces the bandwidth
	/// by these same factors.  If you turn Antialiasing on, then the blur
	/// factors will be computed automatically from the output sampling rate.
	/// Blurring increases the computation time because the kernel size
	/// increases by the blur factor.
	/// </summary>
	public void GetBlurFactors(IntPtr f)
	{
		vtkImageSincInterpolator_GetBlurFactors_05(GetCppThis(), f);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSincInterpolator_GetBlurFactors_06(HandleRef pThis);

	/// <summary>
	/// Blur the image by widening the windowed sinc kernel by the specified
	/// factors for the x, y, and z directions.  This reduces the bandwidth
	/// by these same factors.  If you turn Antialiasing on, then the blur
	/// factors will be computed automatically from the output sampling rate.
	/// Blurring increases the computation time because the kernel size
	/// increases by the blur factor.
	/// </summary>
	public double[] GetBlurFactors()
	{
		IntPtr intPtr = vtkImageSincInterpolator_GetBlurFactors_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageSincInterpolator_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageSincInterpolator_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageSincInterpolator_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageSincInterpolator_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSincInterpolator_GetRenormalization_09(HandleRef pThis);

	/// <summary>
	/// Turn off renormalization.  Most of the sinc windows provide kernels
	/// for which the weights do not sum to one, and for which the sum depends
	/// on the offset.  This results in small ripple artifacts in the output.
	/// By default, the vtkImageSincInterpolator will renormalize these kernels.
	/// This method allows the renormalization to be turned off.
	/// </summary>
	public int GetRenormalization()
	{
		return vtkImageSincInterpolator_GetRenormalization_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSincInterpolator_GetUseWindowParameter_10(HandleRef pThis);

	/// <summary>
	/// Turn this on in order to use SetWindowParameter.  If it is off,
	/// then the default parameter will be used for the window.
	/// </summary>
	public int GetUseWindowParameter()
	{
		return vtkImageSincInterpolator_GetUseWindowParameter_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSincInterpolator_GetWindowFunction_11(HandleRef pThis);

	/// <summary>
	/// The window function to use.  The default is Lanczos, which is very
	/// popular and performs well with a kernel width of 6.  The Cosine
	/// window is included for historical reasons.  All other windows are
	/// described in AH Nuttall, "Some windows with very good sidelobe
	/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
	/// Processing 29:84-91, 1981.
	/// </summary>
	public int GetWindowFunction()
	{
		return vtkImageSincInterpolator_GetWindowFunction_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSincInterpolator_GetWindowFunctionAsString_12(HandleRef pThis);

	/// <summary>
	/// The window function to use.  The default is Lanczos, which is very
	/// popular and performs well with a kernel width of 6.  The Cosine
	/// window is included for historical reasons.  All other windows are
	/// described in AH Nuttall, "Some windows with very good sidelobe
	/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
	/// Processing 29:84-91, 1981.
	/// </summary>
	public virtual string GetWindowFunctionAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImageSincInterpolator_GetWindowFunctionAsString_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSincInterpolator_GetWindowHalfWidth_13(HandleRef pThis);

	/// <summary>
	/// Set the window half-width, this must be an integer between 1 and 16,
	/// with a default value of 3.  The kernel size will be twice this value
	/// if no blur factors are applied. The total number of sinc lobes will
	/// be one less than twice the half-width, so if the half-width is 3 then
	/// the kernel size will be 6 and there will be 5 sinc lobes.
	/// </summary>
	public int GetWindowHalfWidth()
	{
		return vtkImageSincInterpolator_GetWindowHalfWidth_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageSincInterpolator_GetWindowParameter_14(HandleRef pThis);

	/// <summary>
	/// Set the alpha parameter for the Kaiser window function.
	/// This parameter will be ignored unless UseWindowParameter is On.
	/// If UseWindowParameter is Off, then alpha is set to be the same as n
	/// where n is the window half-width.  Using an alpha less than n
	/// increases the sharpness and ringing, while using an alpha greater
	/// than n increases the blurring.
	/// </summary>
	public double GetWindowParameter()
	{
		return vtkImageSincInterpolator_GetWindowParameter_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSincInterpolator_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageSincInterpolator_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImageSincInterpolator_IsSeparable_16(HandleRef pThis);

	/// <summary>
	/// Returns true if the interpolator supports weight precomputation.
	/// This will always return true for this interpolator.
	/// </summary>
	public override bool IsSeparable()
	{
		return (vtkImageSincInterpolator_IsSeparable_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSincInterpolator_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageSincInterpolator_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSincInterpolator_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageSincInterpolator NewInstance()
	{
		vtkImageSincInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSincInterpolator_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageSincInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_RenormalizationOff_20(HandleRef pThis);

	/// <summary>
	/// Turn off renormalization.  Most of the sinc windows provide kernels
	/// for which the weights do not sum to one, and for which the sum depends
	/// on the offset.  This results in small ripple artifacts in the output.
	/// By default, the vtkImageSincInterpolator will renormalize these kernels.
	/// This method allows the renormalization to be turned off.
	/// </summary>
	public void RenormalizationOff()
	{
		vtkImageSincInterpolator_RenormalizationOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_RenormalizationOn_21(HandleRef pThis);

	/// <summary>
	/// Turn off renormalization.  Most of the sinc windows provide kernels
	/// for which the weights do not sum to one, and for which the sum depends
	/// on the offset.  This results in small ripple artifacts in the output.
	/// By default, the vtkImageSincInterpolator will renormalize these kernels.
	/// This method allows the renormalization to be turned off.
	/// </summary>
	public void RenormalizationOn()
	{
		vtkImageSincInterpolator_RenormalizationOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSincInterpolator_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageSincInterpolator SafeDownCast(vtkObjectBase o)
	{
		vtkImageSincInterpolator vtkImageSincInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSincInterpolator_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageSincInterpolator2 = (vtkImageSincInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageSincInterpolator2.Register(null);
			}
		}
		return vtkImageSincInterpolator2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_SetAntialiasing_23(HandleRef pThis, int antialiasing);

	/// <summary>
	/// Turn on antialiasing.  If antialiasing is on, then the BlurFactors
	/// will be computed automatically from the output sampling rate such that
	/// that the image will be bandlimited to the Nyquist frequency.  This
	/// is only applicable when the interpolator is being used by a resampling
	/// filter like vtkImageReslice.  Such a filter will indicate the output
	/// sampling by calling the interpolator's ComputeSupportSize() method,
	/// which will compute the blur factors at the same time that it computes
	/// the support size.
	/// </summary>
	public void SetAntialiasing(int antialiasing)
	{
		vtkImageSincInterpolator_SetAntialiasing_23(GetCppThis(), antialiasing);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_SetBlurFactors_24(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Blur the image by widening the windowed sinc kernel by the specified
	/// factors for the x, y, and z directions.  This reduces the bandwidth
	/// by these same factors.  If you turn Antialiasing on, then the blur
	/// factors will be computed automatically from the output sampling rate.
	/// Blurring increases the computation time because the kernel size
	/// increases by the blur factor.
	/// </summary>
	public void SetBlurFactors(double x, double y, double z)
	{
		vtkImageSincInterpolator_SetBlurFactors_24(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_SetBlurFactors_25(HandleRef pThis, IntPtr f);

	/// <summary>
	/// Blur the image by widening the windowed sinc kernel by the specified
	/// factors for the x, y, and z directions.  This reduces the bandwidth
	/// by these same factors.  If you turn Antialiasing on, then the blur
	/// factors will be computed automatically from the output sampling rate.
	/// Blurring increases the computation time because the kernel size
	/// increases by the blur factor.
	/// </summary>
	public void SetBlurFactors(IntPtr f)
	{
		vtkImageSincInterpolator_SetBlurFactors_25(GetCppThis(), f);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_SetRenormalization_26(HandleRef pThis, int renormalization);

	/// <summary>
	/// Turn off renormalization.  Most of the sinc windows provide kernels
	/// for which the weights do not sum to one, and for which the sum depends
	/// on the offset.  This results in small ripple artifacts in the output.
	/// By default, the vtkImageSincInterpolator will renormalize these kernels.
	/// This method allows the renormalization to be turned off.
	/// </summary>
	public void SetRenormalization(int renormalization)
	{
		vtkImageSincInterpolator_SetRenormalization_26(GetCppThis(), renormalization);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_SetUseWindowParameter_27(HandleRef pThis, int val);

	/// <summary>
	/// Turn this on in order to use SetWindowParameter.  If it is off,
	/// then the default parameter will be used for the window.
	/// </summary>
	public void SetUseWindowParameter(int val)
	{
		vtkImageSincInterpolator_SetUseWindowParameter_27(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_SetWindowFunction_28(HandleRef pThis, int mode);

	/// <summary>
	/// The window function to use.  The default is Lanczos, which is very
	/// popular and performs well with a kernel width of 6.  The Cosine
	/// window is included for historical reasons.  All other windows are
	/// described in AH Nuttall, "Some windows with very good sidelobe
	/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
	/// Processing 29:84-91, 1981.
	/// </summary>
	public virtual void SetWindowFunction(int mode)
	{
		vtkImageSincInterpolator_SetWindowFunction_28(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_SetWindowFunctionToBlackman_29(HandleRef pThis);

	/// <summary>
	/// The window function to use.  The default is Lanczos, which is very
	/// popular and performs well with a kernel width of 6.  The Cosine
	/// window is included for historical reasons.  All other windows are
	/// described in AH Nuttall, "Some windows with very good sidelobe
	/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
	/// Processing 29:84-91, 1981.
	/// </summary>
	public void SetWindowFunctionToBlackman()
	{
		vtkImageSincInterpolator_SetWindowFunctionToBlackman_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_SetWindowFunctionToBlackmanHarris3_30(HandleRef pThis);

	/// <summary>
	/// The window function to use.  The default is Lanczos, which is very
	/// popular and performs well with a kernel width of 6.  The Cosine
	/// window is included for historical reasons.  All other windows are
	/// described in AH Nuttall, "Some windows with very good sidelobe
	/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
	/// Processing 29:84-91, 1981.
	/// </summary>
	public void SetWindowFunctionToBlackmanHarris3()
	{
		vtkImageSincInterpolator_SetWindowFunctionToBlackmanHarris3_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_SetWindowFunctionToBlackmanHarris4_31(HandleRef pThis);

	/// <summary>
	/// The window function to use.  The default is Lanczos, which is very
	/// popular and performs well with a kernel width of 6.  The Cosine
	/// window is included for historical reasons.  All other windows are
	/// described in AH Nuttall, "Some windows with very good sidelobe
	/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
	/// Processing 29:84-91, 1981.
	/// </summary>
	public void SetWindowFunctionToBlackmanHarris4()
	{
		vtkImageSincInterpolator_SetWindowFunctionToBlackmanHarris4_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_SetWindowFunctionToBlackmanNuttall3_32(HandleRef pThis);

	/// <summary>
	/// The window function to use.  The default is Lanczos, which is very
	/// popular and performs well with a kernel width of 6.  The Cosine
	/// window is included for historical reasons.  All other windows are
	/// described in AH Nuttall, "Some windows with very good sidelobe
	/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
	/// Processing 29:84-91, 1981.
	/// </summary>
	public void SetWindowFunctionToBlackmanNuttall3()
	{
		vtkImageSincInterpolator_SetWindowFunctionToBlackmanNuttall3_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_SetWindowFunctionToBlackmanNuttall4_33(HandleRef pThis);

	/// <summary>
	/// The window function to use.  The default is Lanczos, which is very
	/// popular and performs well with a kernel width of 6.  The Cosine
	/// window is included for historical reasons.  All other windows are
	/// described in AH Nuttall, "Some windows with very good sidelobe
	/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
	/// Processing 29:84-91, 1981.
	/// </summary>
	public void SetWindowFunctionToBlackmanNuttall4()
	{
		vtkImageSincInterpolator_SetWindowFunctionToBlackmanNuttall4_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_SetWindowFunctionToCosine_34(HandleRef pThis);

	/// <summary>
	/// The window function to use.  The default is Lanczos, which is very
	/// popular and performs well with a kernel width of 6.  The Cosine
	/// window is included for historical reasons.  All other windows are
	/// described in AH Nuttall, "Some windows with very good sidelobe
	/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
	/// Processing 29:84-91, 1981.
	/// </summary>
	public void SetWindowFunctionToCosine()
	{
		vtkImageSincInterpolator_SetWindowFunctionToCosine_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_SetWindowFunctionToHamming_35(HandleRef pThis);

	/// <summary>
	/// The window function to use.  The default is Lanczos, which is very
	/// popular and performs well with a kernel width of 6.  The Cosine
	/// window is included for historical reasons.  All other windows are
	/// described in AH Nuttall, "Some windows with very good sidelobe
	/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
	/// Processing 29:84-91, 1981.
	/// </summary>
	public void SetWindowFunctionToHamming()
	{
		vtkImageSincInterpolator_SetWindowFunctionToHamming_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_SetWindowFunctionToHann_36(HandleRef pThis);

	/// <summary>
	/// The window function to use.  The default is Lanczos, which is very
	/// popular and performs well with a kernel width of 6.  The Cosine
	/// window is included for historical reasons.  All other windows are
	/// described in AH Nuttall, "Some windows with very good sidelobe
	/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
	/// Processing 29:84-91, 1981.
	/// </summary>
	public void SetWindowFunctionToHann()
	{
		vtkImageSincInterpolator_SetWindowFunctionToHann_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_SetWindowFunctionToKaiser_37(HandleRef pThis);

	/// <summary>
	/// The window function to use.  The default is Lanczos, which is very
	/// popular and performs well with a kernel width of 6.  The Cosine
	/// window is included for historical reasons.  All other windows are
	/// described in AH Nuttall, "Some windows with very good sidelobe
	/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
	/// Processing 29:84-91, 1981.
	/// </summary>
	public void SetWindowFunctionToKaiser()
	{
		vtkImageSincInterpolator_SetWindowFunctionToKaiser_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_SetWindowFunctionToLanczos_38(HandleRef pThis);

	/// <summary>
	/// The window function to use.  The default is Lanczos, which is very
	/// popular and performs well with a kernel width of 6.  The Cosine
	/// window is included for historical reasons.  All other windows are
	/// described in AH Nuttall, "Some windows with very good sidelobe
	/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
	/// Processing 29:84-91, 1981.
	/// </summary>
	public void SetWindowFunctionToLanczos()
	{
		vtkImageSincInterpolator_SetWindowFunctionToLanczos_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_SetWindowFunctionToNuttall_39(HandleRef pThis);

	/// <summary>
	/// The window function to use.  The default is Lanczos, which is very
	/// popular and performs well with a kernel width of 6.  The Cosine
	/// window is included for historical reasons.  All other windows are
	/// described in AH Nuttall, "Some windows with very good sidelobe
	/// behavior," IEEE Transactions on Acoustics, Speech, and Signal
	/// Processing 29:84-91, 1981.
	/// </summary>
	public void SetWindowFunctionToNuttall()
	{
		vtkImageSincInterpolator_SetWindowFunctionToNuttall_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_SetWindowHalfWidth_40(HandleRef pThis, int n);

	/// <summary>
	/// Set the window half-width, this must be an integer between 1 and 16,
	/// with a default value of 3.  The kernel size will be twice this value
	/// if no blur factors are applied. The total number of sinc lobes will
	/// be one less than twice the half-width, so if the half-width is 3 then
	/// the kernel size will be 6 and there will be 5 sinc lobes.
	/// </summary>
	public void SetWindowHalfWidth(int n)
	{
		vtkImageSincInterpolator_SetWindowHalfWidth_40(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_SetWindowParameter_41(HandleRef pThis, double parm);

	/// <summary>
	/// Set the alpha parameter for the Kaiser window function.
	/// This parameter will be ignored unless UseWindowParameter is On.
	/// If UseWindowParameter is Off, then alpha is set to be the same as n
	/// where n is the window half-width.  Using an alpha less than n
	/// increases the sharpness and ringing, while using an alpha greater
	/// than n increases the blurring.
	/// </summary>
	public void SetWindowParameter(double parm)
	{
		vtkImageSincInterpolator_SetWindowParameter_41(GetCppThis(), parm);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_UseWindowParameterOff_42(HandleRef pThis);

	/// <summary>
	/// Turn this on in order to use SetWindowParameter.  If it is off,
	/// then the default parameter will be used for the window.
	/// </summary>
	public void UseWindowParameterOff()
	{
		vtkImageSincInterpolator_UseWindowParameterOff_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSincInterpolator_UseWindowParameterOn_43(HandleRef pThis);

	/// <summary>
	/// Turn this on in order to use SetWindowParameter.  If it is off,
	/// then the default parameter will be used for the window.
	/// </summary>
	public void UseWindowParameterOn()
	{
		vtkImageSincInterpolator_UseWindowParameterOn_43(GetCppThis());
	}
}
