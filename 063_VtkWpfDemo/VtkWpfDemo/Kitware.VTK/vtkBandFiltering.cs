using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBandFiltering
/// </summary>
/// <remarks>
///    Band filtering for table columns
///
/// vtkBandFiltering performs a band filtering in frequency space. It takes as input a table with
/// at least a column for a specific quantity and an optional time array like the vtkTableFFT. The
/// output will be an table with the mean of this quantity (in the original unit or in decibels) for
/// each frequencies defined in the frequency column (in Hz).
/// </remarks>
public class vtkBandFiltering : vtkTableAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum CUSTOM_WrapperEnum
	{
		/// <summary>enum member</summary>
		CUSTOM = 2,
		/// <summary>enum member</summary>
		OCTAVE = 0,
		/// <summary>enum member</summary>
		THIRD_OCTAVE = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBandFiltering";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBandFiltering()
	{
		MRClassNameKey = "class vtkBandFiltering";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBandFiltering"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBandFiltering(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBandFiltering_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBandFiltering New()
	{
		vtkBandFiltering result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBandFiltering_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBandFiltering)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkBandFiltering()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBandFiltering_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkBandFiltering_GetApplyFFT_01(HandleRef pThis);

	/// <summary>
	/// Specify if one want to apply an FFT on the input before computing the band filtering.
	/// It should be set to true if the input is a sound signal and false if it has already been
	/// processed by an FFT. When taking an FFT as its input, the filter expects it to be a
	/// signal of real values where its mirrored part has already been removed.
	///
	/// If false then one should specify which array is the Frequency array.
	///
	/// Default is true.
	///
	/// @see vtkTableFFT::SetReturnOnesided(bool)
	/// </summary>
	public virtual bool GetApplyFFT()
	{
		return (vtkBandFiltering_GetApplyFFT_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBandFiltering_GetBandFilteringMode_02(HandleRef pThis);

	/// <summary>
	/// Specify if the filter should use octave, third or custom octave band.
	///
	/// Default is OCTAVE
	///
	/// @see SetOctaveSubdivision
	/// </summary>
	public virtual int GetBandFilteringMode()
	{
		return vtkBandFiltering_GetBandFilteringMode_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBandFiltering_GetBandFilteringModeMaxValue_03(HandleRef pThis);

	/// <summary>
	/// Specify if the filter should use octave, third or custom octave band.
	///
	/// Default is OCTAVE
	///
	/// @see SetOctaveSubdivision
	/// </summary>
	public virtual int GetBandFilteringModeMaxValue()
	{
		return vtkBandFiltering_GetBandFilteringModeMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBandFiltering_GetBandFilteringModeMinValue_04(HandleRef pThis);

	/// <summary>
	/// Specify if the filter should use octave, third or custom octave band.
	///
	/// Default is OCTAVE
	///
	/// @see SetOctaveSubdivision
	/// </summary>
	public virtual int GetBandFilteringModeMinValue()
	{
		return vtkBandFiltering_GetBandFilteringModeMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBandFiltering_GetDefaultSamplingRate_05(HandleRef pThis);

	/// <summary>
	/// Specify the frequency sample rate in Hz.
	/// If ApplyFFT is true: this will be used if the filter cannot find a time column
	/// If ApplyFFT is false: this will be used if the filter cannot find a frequency column.
	///
	/// @see vtkBandFiltering::SetFrequencyArrayName(std::string)
	///
	/// Default is 10000.
	/// </summary>
	public virtual double GetDefaultSamplingRate()
	{
		return vtkBandFiltering_GetDefaultSamplingRate_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkBandFiltering_GetFrequencyArrayName_06(HandleRef pThis);

	/// <summary>
	/// When ApplyFFT is false, specify the frequency array to use when filtering the signals.
	/// If no array with this name is found then use the specified default sample rate to create
	/// a new one.
	///
	/// Default is "Frequency".
	///
	/// @see vtkTableFFT::SetDefaultSamplingRate(double)
	/// @see vtkTableFFT::SetApplyFFT(bool)
	/// </summary>
	public virtual string GetFrequencyArrayName()
	{
		return vtkBandFiltering_GetFrequencyArrayName_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBandFiltering_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBandFiltering_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBandFiltering_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBandFiltering_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBandFiltering_GetOctaveSubdivision_09(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of octave subdivision when using
	/// BandFilteringMode == CUSTOM . Only odd numbers are valid.
	/// When using even numbers, the number just below will be used.
	/// 1 is equivalent to using the OCTAVE mode, and 3 the THIRD_OCTAVE
	/// mode.
	///
	/// Default is 1
	///
	/// @see vtkBandFiltering::SetBandFilteringMode(int)
	/// </summary>
	public virtual int GetOctaveSubdivision()
	{
		return vtkBandFiltering_GetOctaveSubdivision_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBandFiltering_GetOctaveSubdivisionMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of octave subdivision when using
	/// BandFilteringMode == CUSTOM . Only odd numbers are valid.
	/// When using even numbers, the number just below will be used.
	/// 1 is equivalent to using the OCTAVE mode, and 3 the THIRD_OCTAVE
	/// mode.
	///
	/// Default is 1
	///
	/// @see vtkBandFiltering::SetBandFilteringMode(int)
	/// </summary>
	public virtual int GetOctaveSubdivisionMaxValue()
	{
		return vtkBandFiltering_GetOctaveSubdivisionMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBandFiltering_GetOctaveSubdivisionMinValue_11(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of octave subdivision when using
	/// BandFilteringMode == CUSTOM . Only odd numbers are valid.
	/// When using even numbers, the number just below will be used.
	/// 1 is equivalent to using the OCTAVE mode, and 3 the THIRD_OCTAVE
	/// mode.
	///
	/// Default is 1
	///
	/// @see vtkBandFiltering::SetBandFilteringMode(int)
	/// </summary>
	public virtual int GetOctaveSubdivisionMinValue()
	{
		return vtkBandFiltering_GetOctaveSubdivisionMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkBandFiltering_GetOutputInDecibel_12(HandleRef pThis);

	/// <summary>
	/// Specify if we want to output band filtering in dB. Reference value used is the one
	/// for sound pressure, i.e. 2e-5 (Pa).
	///
	/// Default is false.
	/// </summary>
	public virtual bool GetOutputInDecibel()
	{
		return (vtkBandFiltering_GetOutputInDecibel_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBandFiltering_GetReferenceValue_13(HandleRef pThis);

	/// <summary>
	/// Specify the reference value used to convert the input quantity to decibel.
	///
	/// Default is 2e-5
	/// </summary>
	public virtual double GetReferenceValue()
	{
		return vtkBandFiltering_GetReferenceValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBandFiltering_GetWindowType_14(HandleRef pThis);

	/// <summary>
	/// Get/set the windowing function for the FFT. Only used if ApplyFFT is true.
	/// Windowing function enum is defined in vtkTableFFT.
	///
	/// Default is vtkTableFFT::HANNING.
	/// </summary>
	public virtual int GetWindowType()
	{
		return vtkBandFiltering_GetWindowType_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBandFiltering_GetWindowTypeMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Get/set the windowing function for the FFT. Only used if ApplyFFT is true.
	/// Windowing function enum is defined in vtkTableFFT.
	///
	/// Default is vtkTableFFT::HANNING.
	/// </summary>
	public virtual int GetWindowTypeMaxValue()
	{
		return vtkBandFiltering_GetWindowTypeMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBandFiltering_GetWindowTypeMinValue_16(HandleRef pThis);

	/// <summary>
	/// Get/set the windowing function for the FFT. Only used if ApplyFFT is true.
	/// Windowing function enum is defined in vtkTableFFT.
	///
	/// Default is vtkTableFFT::HANNING.
	/// </summary>
	public virtual int GetWindowTypeMinValue()
	{
		return vtkBandFiltering_GetWindowTypeMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBandFiltering_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBandFiltering_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBandFiltering_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBandFiltering_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBandFiltering_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBandFiltering NewInstance()
	{
		vtkBandFiltering result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBandFiltering_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBandFiltering)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBandFiltering_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBandFiltering SafeDownCast(vtkObjectBase o)
	{
		vtkBandFiltering vtkBandFiltering2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBandFiltering_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBandFiltering2 = (vtkBandFiltering)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBandFiltering2.Register(null);
			}
		}
		return vtkBandFiltering2;
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandFiltering_SetApplyFFT_22(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify if one want to apply an FFT on the input before computing the band filtering.
	/// It should be set to true if the input is a sound signal and false if it has already been
	/// processed by an FFT. When taking an FFT as its input, the filter expects it to be a
	/// signal of real values where its mirrored part has already been removed.
	///
	/// If false then one should specify which array is the Frequency array.
	///
	/// Default is true.
	///
	/// @see vtkTableFFT::SetReturnOnesided(bool)
	/// </summary>
	public virtual void SetApplyFFT(bool _arg)
	{
		vtkBandFiltering_SetApplyFFT_22(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandFiltering_SetBandFilteringMode_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify if the filter should use octave, third or custom octave band.
	///
	/// Default is OCTAVE
	///
	/// @see SetOctaveSubdivision
	/// </summary>
	public virtual void SetBandFilteringMode(int _arg)
	{
		vtkBandFiltering_SetBandFilteringMode_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandFiltering_SetDefaultSamplingRate_24(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the frequency sample rate in Hz.
	/// If ApplyFFT is true: this will be used if the filter cannot find a time column
	/// If ApplyFFT is false: this will be used if the filter cannot find a frequency column.
	///
	/// @see vtkBandFiltering::SetFrequencyArrayName(std::string)
	///
	/// Default is 10000.
	/// </summary>
	public virtual void SetDefaultSamplingRate(double _arg)
	{
		vtkBandFiltering_SetDefaultSamplingRate_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandFiltering_SetFrequencyArrayName_25(HandleRef pThis, string _arg);

	/// <summary>
	/// When ApplyFFT is false, specify the frequency array to use when filtering the signals.
	/// If no array with this name is found then use the specified default sample rate to create
	/// a new one.
	///
	/// Default is "Frequency".
	///
	/// @see vtkTableFFT::SetDefaultSamplingRate(double)
	/// @see vtkTableFFT::SetApplyFFT(bool)
	/// </summary>
	public virtual void SetFrequencyArrayName(string _arg)
	{
		vtkBandFiltering_SetFrequencyArrayName_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandFiltering_SetOctaveSubdivision_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the number of octave subdivision when using
	/// BandFilteringMode == CUSTOM . Only odd numbers are valid.
	/// When using even numbers, the number just below will be used.
	/// 1 is equivalent to using the OCTAVE mode, and 3 the THIRD_OCTAVE
	/// mode.
	///
	/// Default is 1
	///
	/// @see vtkBandFiltering::SetBandFilteringMode(int)
	/// </summary>
	public virtual void SetOctaveSubdivision(int _arg)
	{
		vtkBandFiltering_SetOctaveSubdivision_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandFiltering_SetOutputInDecibel_27(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify if we want to output band filtering in dB. Reference value used is the one
	/// for sound pressure, i.e. 2e-5 (Pa).
	///
	/// Default is false.
	/// </summary>
	public virtual void SetOutputInDecibel(bool _arg)
	{
		vtkBandFiltering_SetOutputInDecibel_27(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandFiltering_SetReferenceValue_28(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the reference value used to convert the input quantity to decibel.
	///
	/// Default is 2e-5
	/// </summary>
	public virtual void SetReferenceValue(double _arg)
	{
		vtkBandFiltering_SetReferenceValue_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersDSP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBandFiltering_SetWindowType_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/set the windowing function for the FFT. Only used if ApplyFFT is true.
	/// Windowing function enum is defined in vtkTableFFT.
	///
	/// Default is vtkTableFFT::HANNING.
	/// </summary>
	public virtual void SetWindowType(int _arg)
	{
		vtkBandFiltering_SetWindowType_29(GetCppThis(), _arg);
	}
}
