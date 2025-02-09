using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractHistogram
/// </summary>
/// <remarks>
///    Extract histogram data (binned values) from any
/// dataset
///
/// vtkExtractHistogram accepts any vtkDataSet as input and produces a
/// vtkTable containing histogram data as output.  The output vtkTable
/// will contains a vtkDoubleArray named "bin_extents" which contains
/// the boundaries between each histogram bin, and a vtkUnsignedLongArray
/// named "bin_values" which will contain the value for each bin.
/// </remarks>
public class vtkExtractHistogram : vtkTableAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractHistogram";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractHistogram()
	{
		MRClassNameKey = "class vtkExtractHistogram";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractHistogram"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractHistogram(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractHistogram_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractHistogram New()
	{
		vtkExtractHistogram result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractHistogram_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractHistogram)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExtractHistogram()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractHistogram_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_AccumulationOff_01(HandleRef pThis);

	/// <summary>
	/// If this option is set to true then the output table will contain an additional column with
	/// accumulated bin values.
	/// Default is false.
	/// </summary>
	public virtual void AccumulationOff()
	{
		vtkExtractHistogram_AccumulationOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_AccumulationOn_02(HandleRef pThis);

	/// <summary>
	/// If this option is set to true then the output table will contain an additional column with
	/// accumulated bin values.
	/// Default is false.
	/// </summary>
	public virtual void AccumulationOn()
	{
		vtkExtractHistogram_AccumulationOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_CalculateAveragesOff_03(HandleRef pThis);

	/// <summary>
	/// This option controls whether the algorithm calculates averages
	/// of variables other than the primary variable that fall into each
	/// bin.
	/// Default is false.
	/// </summary>
	public virtual void CalculateAveragesOff()
	{
		vtkExtractHistogram_CalculateAveragesOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_CalculateAveragesOn_04(HandleRef pThis);

	/// <summary>
	/// This option controls whether the algorithm calculates averages
	/// of variables other than the primary variable that fall into each
	/// bin.
	/// Default is false.
	/// </summary>
	public virtual void CalculateAveragesOn()
	{
		vtkExtractHistogram_CalculateAveragesOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_CenterBinsAroundMinAndMaxOff_05(HandleRef pThis);

	/// <summary>
	/// Get/Set if first and last bins must be centered around the min and max
	/// data. This is only used when UseCustomBinRanges is set to false.
	/// Default is false.
	/// </summary>
	public virtual void CenterBinsAroundMinAndMaxOff()
	{
		vtkExtractHistogram_CenterBinsAroundMinAndMaxOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_CenterBinsAroundMinAndMaxOn_06(HandleRef pThis);

	/// <summary>
	/// Get/Set if first and last bins must be centered around the min and max
	/// data. This is only used when UseCustomBinRanges is set to false.
	/// Default is false.
	/// </summary>
	public virtual void CenterBinsAroundMinAndMaxOn()
	{
		vtkExtractHistogram_CenterBinsAroundMinAndMaxOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractHistogram_GetAccumulation_07(HandleRef pThis);

	/// <summary>
	/// If this option is set to true then the output table will contain an additional column with
	/// accumulated bin values.
	/// Default is false.
	/// </summary>
	public virtual bool GetAccumulation()
	{
		return (vtkExtractHistogram_GetAccumulation_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractHistogram_GetBinAccumulationArrayName_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the optional bin accumulation array.
	/// Default is "bin_accumulation".
	/// </summary>
	public virtual string GetBinAccumulationArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkExtractHistogram_GetBinAccumulationArrayName_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractHistogram_GetBinCount_09(HandleRef pThis);

	/// <summary>
	/// Controls the number of bins N in the output histogram data.
	/// Default is 10.
	/// </summary>
	public virtual int GetBinCount()
	{
		return vtkExtractHistogram_GetBinCount_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractHistogram_GetBinCountMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Controls the number of bins N in the output histogram data.
	/// Default is 10.
	/// </summary>
	public virtual int GetBinCountMaxValue()
	{
		return vtkExtractHistogram_GetBinCountMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractHistogram_GetBinCountMinValue_11(HandleRef pThis);

	/// <summary>
	/// Controls the number of bins N in the output histogram data.
	/// Default is 10.
	/// </summary>
	public virtual int GetBinCountMinValue()
	{
		return vtkExtractHistogram_GetBinCountMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractHistogram_GetBinExtentsArrayName_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the bin extents array.
	/// Default is "bin_extents".
	/// </summary>
	public virtual string GetBinExtentsArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkExtractHistogram_GetBinExtentsArrayName_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractHistogram_GetBinRange_13(HandleRef pThis);

	/// <summary>
	/// Get the bin range which was used to create the bin extents.
	/// </summary>
	public virtual double[] GetBinRange()
	{
		IntPtr intPtr = vtkExtractHistogram_GetBinRange_13(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_GetBinRange_14(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Get the bin range which was used to create the bin extents.
	/// </summary>
	public virtual void GetBinRange(ref double _arg1, ref double _arg2)
	{
		vtkExtractHistogram_GetBinRange_14(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_GetBinRange_15(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the bin range which was used to create the bin extents.
	/// </summary>
	public virtual void GetBinRange(IntPtr _arg)
	{
		vtkExtractHistogram_GetBinRange_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractHistogram_GetBinValuesArrayName_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the bin values array.
	/// Default is "bin_values".
	/// </summary>
	public virtual string GetBinValuesArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkExtractHistogram_GetBinValuesArrayName_16(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractHistogram_GetCalculateAverages_17(HandleRef pThis);

	/// <summary>
	/// This option controls whether the algorithm calculates averages
	/// of variables other than the primary variable that fall into each
	/// bin.
	/// Default is false.
	/// </summary>
	public virtual bool GetCalculateAverages()
	{
		return (vtkExtractHistogram_GetCalculateAverages_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractHistogram_GetCenterBinsAroundMinAndMax_18(HandleRef pThis);

	/// <summary>
	/// Get/Set if first and last bins must be centered around the min and max
	/// data. This is only used when UseCustomBinRanges is set to false.
	/// Default is false.
	/// </summary>
	public virtual bool GetCenterBinsAroundMinAndMax()
	{
		return (vtkExtractHistogram_GetCenterBinsAroundMinAndMax_18(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractHistogram_GetComponent_19(HandleRef pThis);

	/// <summary>
	/// Controls which input data component should be binned, for input arrays
	/// with more-than-one component.  Setting this to the number of components
	/// will compute the histogram of the magnitude (L2 norm) of the tuple.
	/// Default is 0.
	/// </summary>
	public virtual int GetComponent()
	{
		return vtkExtractHistogram_GetComponent_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractHistogram_GetComponentMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Controls which input data component should be binned, for input arrays
	/// with more-than-one component.  Setting this to the number of components
	/// will compute the histogram of the magnitude (L2 norm) of the tuple.
	/// Default is 0.
	/// </summary>
	public virtual int GetComponentMaxValue()
	{
		return vtkExtractHistogram_GetComponentMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractHistogram_GetComponentMinValue_21(HandleRef pThis);

	/// <summary>
	/// Controls which input data component should be binned, for input arrays
	/// with more-than-one component.  Setting this to the number of components
	/// will compute the histogram of the magnitude (L2 norm) of the tuple.
	/// Default is 0.
	/// </summary>
	public virtual int GetComponentMinValue()
	{
		return vtkExtractHistogram_GetComponentMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractHistogram_GetCustomBinRanges_22(HandleRef pThis);

	/// <summary>
	/// Get/Set custom bin range to use. These are used only when
	/// UseCustomBinRanges is set to true.
	/// Default is [0, 100].
	/// </summary>
	public virtual double[] GetCustomBinRanges()
	{
		IntPtr intPtr = vtkExtractHistogram_GetCustomBinRanges_22(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_GetCustomBinRanges_23(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Get/Set custom bin range to use. These are used only when
	/// UseCustomBinRanges is set to true.
	/// Default is [0, 100].
	/// </summary>
	public virtual void GetCustomBinRanges(ref double _arg1, ref double _arg2)
	{
		vtkExtractHistogram_GetCustomBinRanges_23(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_GetCustomBinRanges_24(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set custom bin range to use. These are used only when
	/// UseCustomBinRanges is set to true.
	/// Default is [0, 100].
	/// </summary>
	public virtual void GetCustomBinRanges(IntPtr _arg)
	{
		vtkExtractHistogram_GetCustomBinRanges_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractHistogram_GetNormalize_25(HandleRef pThis);

	/// <summary>
	/// If this option is set then the bin values will be normalized so that the sum of the bin values
	/// adds up to 1.0.
	/// Default is false.
	/// </summary>
	public virtual bool GetNormalize()
	{
		return (vtkExtractHistogram_GetNormalize_25(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractHistogram_GetNumberOfGenerationsFromBase_26(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractHistogram_GetNumberOfGenerationsFromBase_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractHistogram_GetNumberOfGenerationsFromBaseType_27(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractHistogram_GetNumberOfGenerationsFromBaseType_27(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractHistogram_GetUseCustomBinRanges_28(HandleRef pThis);

	/// <summary>
	/// When set to true, CustomBinRanges will  be used instead of using the full
	/// range for the selected array.
	/// Default is false.
	/// </summary>
	public virtual bool GetUseCustomBinRanges()
	{
		return (vtkExtractHistogram_GetUseCustomBinRanges_28(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractHistogram_IsA_29(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractHistogram_IsA_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractHistogram_IsTypeOf_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractHistogram_IsTypeOf_30(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractHistogram_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractHistogram NewInstance()
	{
		vtkExtractHistogram result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractHistogram_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractHistogram)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_NormalizeOff_33(HandleRef pThis);

	/// <summary>
	/// If this option is set then the bin values will be normalized so that the sum of the bin values
	/// adds up to 1.0.
	/// Default is false.
	/// </summary>
	public virtual void NormalizeOff()
	{
		vtkExtractHistogram_NormalizeOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_NormalizeOn_34(HandleRef pThis);

	/// <summary>
	/// If this option is set then the bin values will be normalized so that the sum of the bin values
	/// adds up to 1.0.
	/// Default is false.
	/// </summary>
	public virtual void NormalizeOn()
	{
		vtkExtractHistogram_NormalizeOn_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractHistogram_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractHistogram SafeDownCast(vtkObjectBase o)
	{
		vtkExtractHistogram vtkExtractHistogram2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractHistogram_SafeDownCast_35(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractHistogram2 = (vtkExtractHistogram)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractHistogram2.Register(null);
			}
		}
		return vtkExtractHistogram2;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_SetAccumulation_36(HandleRef pThis, byte _arg);

	/// <summary>
	/// If this option is set to true then the output table will contain an additional column with
	/// accumulated bin values.
	/// Default is false.
	/// </summary>
	public virtual void SetAccumulation(bool _arg)
	{
		vtkExtractHistogram_SetAccumulation_36(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_SetBinAccumulationArrayName_37(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of the optional bin accumulation array.
	/// Default is "bin_accumulation".
	/// </summary>
	public virtual void SetBinAccumulationArrayName(string _arg)
	{
		vtkExtractHistogram_SetBinAccumulationArrayName_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_SetBinCount_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Controls the number of bins N in the output histogram data.
	/// Default is 10.
	/// </summary>
	public virtual void SetBinCount(int _arg)
	{
		vtkExtractHistogram_SetBinCount_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_SetBinExtentsArrayName_39(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of the bin extents array.
	/// Default is "bin_extents".
	/// </summary>
	public virtual void SetBinExtentsArrayName(string _arg)
	{
		vtkExtractHistogram_SetBinExtentsArrayName_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_SetBinValuesArrayName_40(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of the bin values array.
	/// Default is "bin_values".
	/// </summary>
	public virtual void SetBinValuesArrayName(string _arg)
	{
		vtkExtractHistogram_SetBinValuesArrayName_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_SetCalculateAverages_41(HandleRef pThis, byte _arg);

	/// <summary>
	/// This option controls whether the algorithm calculates averages
	/// of variables other than the primary variable that fall into each
	/// bin.
	/// Default is false.
	/// </summary>
	public virtual void SetCalculateAverages(bool _arg)
	{
		vtkExtractHistogram_SetCalculateAverages_41(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_SetCenterBinsAroundMinAndMax_42(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set if first and last bins must be centered around the min and max
	/// data. This is only used when UseCustomBinRanges is set to false.
	/// Default is false.
	/// </summary>
	public virtual void SetCenterBinsAroundMinAndMax(bool _arg)
	{
		vtkExtractHistogram_SetCenterBinsAroundMinAndMax_42(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_SetComponent_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Controls which input data component should be binned, for input arrays
	/// with more-than-one component.  Setting this to the number of components
	/// will compute the histogram of the magnitude (L2 norm) of the tuple.
	/// Default is 0.
	/// </summary>
	public virtual void SetComponent(int _arg)
	{
		vtkExtractHistogram_SetComponent_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_SetCustomBinRanges_44(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Get/Set custom bin range to use. These are used only when
	/// UseCustomBinRanges is set to true.
	/// Default is [0, 100].
	/// </summary>
	public virtual void SetCustomBinRanges(double _arg1, double _arg2)
	{
		vtkExtractHistogram_SetCustomBinRanges_44(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_SetCustomBinRanges_45(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set custom bin range to use. These are used only when
	/// UseCustomBinRanges is set to true.
	/// Default is [0, 100].
	/// </summary>
	public void SetCustomBinRanges(IntPtr _arg)
	{
		vtkExtractHistogram_SetCustomBinRanges_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_SetNormalize_46(HandleRef pThis, byte _arg);

	/// <summary>
	/// If this option is set then the bin values will be normalized so that the sum of the bin values
	/// adds up to 1.0.
	/// Default is false.
	/// </summary>
	public virtual void SetNormalize(bool _arg)
	{
		vtkExtractHistogram_SetNormalize_46(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_SetUseCustomBinRanges_47(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set to true, CustomBinRanges will  be used instead of using the full
	/// range for the selected array.
	/// Default is false.
	/// </summary>
	public virtual void SetUseCustomBinRanges(bool _arg)
	{
		vtkExtractHistogram_SetUseCustomBinRanges_47(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_UseCustomBinRangesOff_48(HandleRef pThis);

	/// <summary>
	/// When set to true, CustomBinRanges will  be used instead of using the full
	/// range for the selected array.
	/// Default is false.
	/// </summary>
	public virtual void UseCustomBinRangesOff()
	{
		vtkExtractHistogram_UseCustomBinRangesOff_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram_UseCustomBinRangesOn_49(HandleRef pThis);

	/// <summary>
	/// When set to true, CustomBinRanges will  be used instead of using the full
	/// range for the selected array.
	/// Default is false.
	/// </summary>
	public virtual void UseCustomBinRangesOn()
	{
		vtkExtractHistogram_UseCustomBinRangesOn_49(GetCppThis());
	}
}
