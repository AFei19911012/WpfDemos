using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTableFFT
/// </summary>
/// <remarks>
///    FFT for table columns
///
/// vtkTableFFT performs the Fast Fourier Transform on the columns of a table.
/// It can perform the FFT per block : this performs something close to the
/// Welch method but it uses raw FFTs instead of periodograms. This allows to
/// reduce the impact of noise as well as speeding up the filter when the input
/// signal is too big.
///
/// It is also possible to apply a window on the input signal. If performing
/// the FFT per block then the window will be applied to each block instead.
///
/// The filter will look for a "Time" array (case insensitive) to determine the
/// sampling frequency. "Time" array is considered to have the same frequency
/// all along. If no "Time" array is found then the filter use the default frequency
/// value.
///
/// This filter will not apply the FFT on any arrays which names begin with 'vtk'.
///
/// This filter will consider arrays with 2 components as arrays of complex numbers,
/// the first column representing the real part and the second the imaginary part.
/// </remarks>
public class vtkTableFFT : vtkTableAlgorithm
{
	/// <summary>
	/// Enum allowing to choose the windowing function to apply on the input signal.
	/// </summary>
	public enum BARTLETT_WrapperEnum
	{
		/// <summary>enum member</summary>
		BARTLETT = 1,
		/// <summary>enum member</summary>
		BLACKMAN = 3,
		/// <summary>enum member</summary>
		HANNING = 0,
		/// <summary>enum member</summary>
		MAX_WINDOWING_FUNCTION = 5,
		/// <summary>enum member</summary>
		RECTANGULAR = 4,
		/// <summary>enum member</summary>
		SINE = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTableFFT";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTableFFT()
	{
		MRClassNameKey = "class vtkTableFFT";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableFFT"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTableFFT(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableFFT_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTableFFT New()
	{
		vtkTableFFT result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTableFFT_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTableFFT)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTableFFT()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTableFFT_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableFFT_AverageFftOff_01(HandleRef pThis);

	/// <summary>
	/// Specify if filter should use the Welch / periodogram method. If true the
	/// input should be split in multiple segment to compute an average fft across
	/// all segments / blocks.
	///
	/// @see vtkTableFFT::SetBlockSize(int)
	/// @see vtkTableFFT::SetBlockOverlap(int)
	///
	/// Default is false
	/// </summary>
	public virtual void AverageFftOff()
	{
		vtkTableFFT_AverageFftOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableFFT_AverageFftOn_02(HandleRef pThis);

	/// <summary>
	/// Specify if filter should use the Welch / periodogram method. If true the
	/// input should be split in multiple segment to compute an average fft across
	/// all segments / blocks.
	///
	/// @see vtkTableFFT::SetBlockSize(int)
	/// @see vtkTableFFT::SetBlockOverlap(int)
	///
	/// Default is false
	/// </summary>
	public virtual void AverageFftOn()
	{
		vtkTableFFT_AverageFftOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableFFT_CreateFrequencyColumnOff_03(HandleRef pThis);

	/// <summary>
	/// Specify if the filter should create a frequency column based on a column
	/// named "time" (not case sensitive). An evenly-spaced time array is expected.
	///
	/// @see vtkTableFFT::SetDefaultSampleRate(double)
	///
	/// Default is false
	/// </summary>
	public virtual void CreateFrequencyColumnOff()
	{
		vtkTableFFT_CreateFrequencyColumnOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableFFT_CreateFrequencyColumnOn_04(HandleRef pThis);

	/// <summary>
	/// Specify if the filter should create a frequency column based on a column
	/// named "time" (not case sensitive). An evenly-spaced time array is expected.
	///
	/// @see vtkTableFFT::SetDefaultSampleRate(double)
	///
	/// Default is false
	/// </summary>
	public virtual void CreateFrequencyColumnOn()
	{
		vtkTableFFT_CreateFrequencyColumnOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableFFT_DetrendOff_05(HandleRef pThis);

	/// <summary>
	/// Remove trend on each segment before applying the FFT. This is a constant
	/// detrend where the mean of the signal is substracted to the signal.
	/// Only used if AverageFft is true.
	///
	/// @see vtkTableFFT::SetAverageFft(bool)
	///
	/// Default is false.
	/// </summary>
	public virtual void DetrendOff()
	{
		vtkTableFFT_DetrendOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableFFT_DetrendOn_06(HandleRef pThis);

	/// <summary>
	/// Remove trend on each segment before applying the FFT. This is a constant
	/// detrend where the mean of the signal is substracted to the signal.
	/// Only used if AverageFft is true.
	///
	/// @see vtkTableFFT::SetAverageFft(bool)
	///
	/// Default is false.
	/// </summary>
	public virtual void DetrendOn()
	{
		vtkTableFFT_DetrendOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTableFFT_GetAverageFft_07(HandleRef pThis);

	/// <summary>
	/// Specify if filter should use the Welch / periodogram method. If true the
	/// input should be split in multiple segment to compute an average fft across
	/// all segments / blocks.
	///
	/// @see vtkTableFFT::SetBlockSize(int)
	/// @see vtkTableFFT::SetBlockOverlap(int)
	///
	/// Default is false
	/// </summary>
	public virtual bool GetAverageFft()
	{
		return (vtkTableFFT_GetAverageFft_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableFFT_GetBlockOverlap_08(HandleRef pThis);

	/// <summary>
	/// Specify the number of samples which will overlap between each block / segment.
	/// If value is not in a valid range (ie &lt; 0 or &gt;= BlockSize) then the
	/// value BlockSize / 2 will be used. Only used if AverageFft is true.
	///
	/// @see vtkTableFFT::SetAverageFft(bool)
	/// @see vtkTableFFT::SetBlockSize(int)
	///
	/// Default is -1
	/// </summary>
	public virtual int GetBlockOverlap()
	{
		return vtkTableFFT_GetBlockOverlap_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableFFT_GetBlockSize_09(HandleRef pThis);

	/// <summary>
	/// Specify the number of samples to use for each block / segment in the Welch
	/// method. Only used if AverageFft is true
	///
	/// @see vtkTableFFT::SetAverageFft(bool)
	///
	/// Default is 1024
	/// </summary>
	public virtual int GetBlockSize()
	{
		return vtkTableFFT_GetBlockSize_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTableFFT_GetCreateFrequencyColumn_10(HandleRef pThis);

	/// <summary>
	/// Specify if the filter should create a frequency column based on a column
	/// named "time" (not case sensitive). An evenly-spaced time array is expected.
	///
	/// @see vtkTableFFT::SetDefaultSampleRate(double)
	///
	/// Default is false
	/// </summary>
	public virtual bool GetCreateFrequencyColumn()
	{
		return (vtkTableFFT_GetCreateFrequencyColumn_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTableFFT_GetDefaultSampleRate_11(HandleRef pThis);

	/// <summary>
	/// If the "Time" column is not found then this value will be used.
	/// Expressed in Hz.
	///
	/// Default is 10'000 (Hz)
	/// </summary>
	public virtual double GetDefaultSampleRate()
	{
		return vtkTableFFT_GetDefaultSampleRate_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTableFFT_GetDetrend_12(HandleRef pThis);

	/// <summary>
	/// Remove trend on each segment before applying the FFT. This is a constant
	/// detrend where the mean of the signal is substracted to the signal.
	/// Only used if AverageFft is true.
	///
	/// @see vtkTableFFT::SetAverageFft(bool)
	///
	/// Default is false.
	/// </summary>
	public virtual bool GetDetrend()
	{
		return (vtkTableFFT_GetDetrend_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTableFFT_GetNormalize_13(HandleRef pThis);

	/// <summary>
	/// Specify if the output should be normalized so that Parseval's theorem is
	/// respected. If enabled output will be scaled according to the number of samples
	/// and the window energy. Else the raw FFT will be returned as is. Only used if
	/// AverageFft is false.
	///
	/// @see vtkTableFFT::SetAverageFft(bool)
	///
	/// Default is false
	/// </summary>
	public virtual bool GetNormalize()
	{
		return (vtkTableFFT_GetNormalize_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTableFFT_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTableFFT_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTableFFT_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTableFFT_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTableFFT_GetReturnOnesided_16(HandleRef pThis);

	/// <summary>
	/// Specify if the filter should use the optimized discrete fourier transform for
	/// real values and return a onesided spectrum : this will cause output columns to
	/// have from n to ((n / 2) + 1) values.
	/// If ReturnOnesided is true but the input contains columns with 2 components
	/// (aka complex data), these columns will be ignored.
	///
	/// Default is false
	/// </summary>
	public virtual bool GetReturnOnesided()
	{
		return (vtkTableFFT_GetReturnOnesided_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableFFT_GetScalingMethod_17(HandleRef pThis);

	/// <summary>
	/// Set what scaling should be used when applying the Welch method. It uses vtkFFT::Scaling
	/// enum as values.
	///
	/// @see vtkFFT::Scaling
	///
	/// Default is vtkFFT::Scaling::Density (aka 0)
	/// </summary>
	public virtual int GetScalingMethod()
	{
		return vtkTableFFT_GetScalingMethod_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableFFT_GetScalingMethodMaxValue_18(HandleRef pThis);

	/// <summary>
	/// Set what scaling should be used when applying the Welch method. It uses vtkFFT::Scaling
	/// enum as values.
	///
	/// @see vtkFFT::Scaling
	///
	/// Default is vtkFFT::Scaling::Density (aka 0)
	/// </summary>
	public virtual int GetScalingMethodMaxValue()
	{
		return vtkTableFFT_GetScalingMethodMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableFFT_GetScalingMethodMinValue_19(HandleRef pThis);

	/// <summary>
	/// Set what scaling should be used when applying the Welch method. It uses vtkFFT::Scaling
	/// enum as values.
	///
	/// @see vtkFFT::Scaling
	///
	/// Default is vtkFFT::Scaling::Density (aka 0)
	/// </summary>
	public virtual int GetScalingMethodMinValue()
	{
		return vtkTableFFT_GetScalingMethodMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableFFT_GetWindowingFunction_20(HandleRef pThis);

	/// <summary>
	/// Specify the windowing function to apply on the input.
	/// If @c AverageFft is true the windowing function will be
	/// applied per block and not on the whole input.
	///
	/// Default is RECTANGULAR (does nothing)
	/// </summary>
	public virtual int GetWindowingFunction()
	{
		return vtkTableFFT_GetWindowingFunction_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableFFT_IsA_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTableFFT_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableFFT_IsTypeOf_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTableFFT_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableFFT_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTableFFT NewInstance()
	{
		vtkTableFFT result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTableFFT_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTableFFT)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableFFT_NormalizeOff_25(HandleRef pThis);

	/// <summary>
	/// Specify if the output should be normalized so that Parseval's theorem is
	/// respected. If enabled output will be scaled according to the number of samples
	/// and the window energy. Else the raw FFT will be returned as is. Only used if
	/// AverageFft is false.
	///
	/// @see vtkTableFFT::SetAverageFft(bool)
	///
	/// Default is false
	/// </summary>
	public virtual void NormalizeOff()
	{
		vtkTableFFT_NormalizeOff_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableFFT_NormalizeOn_26(HandleRef pThis);

	/// <summary>
	/// Specify if the output should be normalized so that Parseval's theorem is
	/// respected. If enabled output will be scaled according to the number of samples
	/// and the window energy. Else the raw FFT will be returned as is. Only used if
	/// AverageFft is false.
	///
	/// @see vtkTableFFT::SetAverageFft(bool)
	///
	/// Default is false
	/// </summary>
	public virtual void NormalizeOn()
	{
		vtkTableFFT_NormalizeOn_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableFFT_ReturnOnesidedOff_27(HandleRef pThis);

	/// <summary>
	/// Specify if the filter should use the optimized discrete fourier transform for
	/// real values and return a onesided spectrum : this will cause output columns to
	/// have from n to ((n / 2) + 1) values.
	/// If ReturnOnesided is true but the input contains columns with 2 components
	/// (aka complex data), these columns will be ignored.
	///
	/// Default is false
	/// </summary>
	public virtual void ReturnOnesidedOff()
	{
		vtkTableFFT_ReturnOnesidedOff_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableFFT_ReturnOnesidedOn_28(HandleRef pThis);

	/// <summary>
	/// Specify if the filter should use the optimized discrete fourier transform for
	/// real values and return a onesided spectrum : this will cause output columns to
	/// have from n to ((n / 2) + 1) values.
	/// If ReturnOnesided is true but the input contains columns with 2 components
	/// (aka complex data), these columns will be ignored.
	///
	/// Default is false
	/// </summary>
	public virtual void ReturnOnesidedOn()
	{
		vtkTableFFT_ReturnOnesidedOn_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableFFT_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTableFFT SafeDownCast(vtkObjectBase o)
	{
		vtkTableFFT vtkTableFFT2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTableFFT_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTableFFT2 = (vtkTableFFT)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTableFFT2.Register(null);
			}
		}
		return vtkTableFFT2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableFFT_SetAverageFft_30(HandleRef pThis, byte arg0);

	/// <summary>
	/// Specify if filter should use the Welch / periodogram method. If true the
	/// input should be split in multiple segment to compute an average fft across
	/// all segments / blocks.
	///
	/// @see vtkTableFFT::SetBlockSize(int)
	/// @see vtkTableFFT::SetBlockOverlap(int)
	///
	/// Default is false
	/// </summary>
	public virtual void SetAverageFft(bool arg0)
	{
		vtkTableFFT_SetAverageFft_30(GetCppThis(), (byte)(arg0 ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableFFT_SetBlockOverlap_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the number of samples which will overlap between each block / segment.
	/// If value is not in a valid range (ie &lt; 0 or &gt;= BlockSize) then the
	/// value BlockSize / 2 will be used. Only used if AverageFft is true.
	///
	/// @see vtkTableFFT::SetAverageFft(bool)
	/// @see vtkTableFFT::SetBlockSize(int)
	///
	/// Default is -1
	/// </summary>
	public virtual void SetBlockOverlap(int _arg)
	{
		vtkTableFFT_SetBlockOverlap_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableFFT_SetBlockSize_32(HandleRef pThis, int arg0);

	/// <summary>
	/// Specify the number of samples to use for each block / segment in the Welch
	/// method. Only used if AverageFft is true
	///
	/// @see vtkTableFFT::SetAverageFft(bool)
	///
	/// Default is 1024
	/// </summary>
	public virtual void SetBlockSize(int arg0)
	{
		vtkTableFFT_SetBlockSize_32(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableFFT_SetCreateFrequencyColumn_33(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify if the filter should create a frequency column based on a column
	/// named "time" (not case sensitive). An evenly-spaced time array is expected.
	///
	/// @see vtkTableFFT::SetDefaultSampleRate(double)
	///
	/// Default is false
	/// </summary>
	public virtual void SetCreateFrequencyColumn(bool _arg)
	{
		vtkTableFFT_SetCreateFrequencyColumn_33(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableFFT_SetDefaultSampleRate_34(HandleRef pThis, double _arg);

	/// <summary>
	/// If the "Time" column is not found then this value will be used.
	/// Expressed in Hz.
	///
	/// Default is 10'000 (Hz)
	/// </summary>
	public virtual void SetDefaultSampleRate(double _arg)
	{
		vtkTableFFT_SetDefaultSampleRate_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableFFT_SetDetrend_35(HandleRef pThis, byte _arg);

	/// <summary>
	/// Remove trend on each segment before applying the FFT. This is a constant
	/// detrend where the mean of the signal is substracted to the signal.
	/// Only used if AverageFft is true.
	///
	/// @see vtkTableFFT::SetAverageFft(bool)
	///
	/// Default is false.
	/// </summary>
	public virtual void SetDetrend(bool _arg)
	{
		vtkTableFFT_SetDetrend_35(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableFFT_SetNormalize_36(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify if the output should be normalized so that Parseval's theorem is
	/// respected. If enabled output will be scaled according to the number of samples
	/// and the window energy. Else the raw FFT will be returned as is. Only used if
	/// AverageFft is false.
	///
	/// @see vtkTableFFT::SetAverageFft(bool)
	///
	/// Default is false
	/// </summary>
	public virtual void SetNormalize(bool _arg)
	{
		vtkTableFFT_SetNormalize_36(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableFFT_SetReturnOnesided_37(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify if the filter should use the optimized discrete fourier transform for
	/// real values and return a onesided spectrum : this will cause output columns to
	/// have from n to ((n / 2) + 1) values.
	/// If ReturnOnesided is true but the input contains columns with 2 components
	/// (aka complex data), these columns will be ignored.
	///
	/// Default is false
	/// </summary>
	public virtual void SetReturnOnesided(bool _arg)
	{
		vtkTableFFT_SetReturnOnesided_37(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableFFT_SetScalingMethod_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Set what scaling should be used when applying the Welch method. It uses vtkFFT::Scaling
	/// enum as values.
	///
	/// @see vtkFFT::Scaling
	///
	/// Default is vtkFFT::Scaling::Density (aka 0)
	/// </summary>
	public virtual void SetScalingMethod(int _arg)
	{
		vtkTableFFT_SetScalingMethod_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableFFT_SetWindowingFunction_39(HandleRef pThis, int arg0);

	/// <summary>
	/// Specify the windowing function to apply on the input.
	/// If @c AverageFft is true the windowing function will be
	/// applied per block and not on the whole input.
	///
	/// Default is RECTANGULAR (does nothing)
	/// </summary>
	public virtual void SetWindowingFunction(int arg0)
	{
		vtkTableFFT_SetWindowingFunction_39(GetCppThis(), arg0);
	}
}
