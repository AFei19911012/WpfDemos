using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageAccumulate
/// </summary>
/// <remarks>
///    Generalized histograms up to 3 dimensions.
///
/// vtkImageAccumulate - This filter divides component space into
/// discrete bins.  It then counts the number of pixels associated
/// with each bin.
/// The dimensionality of the output depends on how many components the
/// input pixels have. An input images with N components per pixels will
/// result in an N-dimensional histogram, where N can be 1, 2, or 3.
/// The input can be any type, but the output is always int.
/// Some statistics are computed on the pixel values at the same time.
/// The SetStencil and ReverseStencil functions allow the statistics to be
/// computed on an arbitrary portion of the input data.
/// See the documentation for vtkImageStencilData for more information.
///
/// This filter also supports ignoring pixels with value equal to 0. Using this
/// option with vtkImageMask may result in results being slightly off since 0
/// could be a valid value from your input.
///
/// </remarks>
public class vtkImageAccumulate : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageAccumulate";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageAccumulate()
	{
		MRClassNameKey = "class vtkImageAccumulate";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageAccumulate"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageAccumulate(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAccumulate_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageAccumulate New()
	{
		vtkImageAccumulate result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageAccumulate_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageAccumulate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageAccumulate()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageAccumulate_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_GetComponentExtent_01(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Set/Get - The component extent sets the number/extent of the bins.
	/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
	/// this extent should be set to 0, 9, 0, 0, 0, 0.
	/// The extent specifies inclusive min/max values.
	/// This implies that the top extent should be set to the number of bins - 1.
	/// Initial value is (0,255,0,0,0,0)
	/// </summary>
	public void GetComponentExtent(IntPtr extent)
	{
		vtkImageAccumulate_GetComponentExtent_01(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAccumulate_GetComponentExtent_02(HandleRef pThis);

	/// <summary>
	/// Set/Get - The component extent sets the number/extent of the bins.
	/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
	/// this extent should be set to 0, 9, 0, 0, 0, 0.
	/// The extent specifies inclusive min/max values.
	/// This implies that the top extent should be set to the number of bins - 1.
	/// Initial value is (0,255,0,0,0,0)
	/// </summary>
	public int[] GetComponentExtent()
	{
		IntPtr intPtr = vtkImageAccumulate_GetComponentExtent_02(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAccumulate_GetComponentOrigin_03(HandleRef pThis);

	/// <summary>
	/// Set/Get - The component origin is the location of bin (0, 0, 0).
	/// Note that if the Component extent does not include the value (0,0,0),
	/// then this origin bin will not actually be in the output.
	/// The origin of the output ends up being the same as the component origin.
	/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
	/// this origin should be set to 1000, 0, 0.
	/// Initial value is (0.0,0.0,0.0).
	/// </summary>
	public virtual double[] GetComponentOrigin()
	{
		IntPtr intPtr = vtkImageAccumulate_GetComponentOrigin_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_GetComponentOrigin_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get - The component origin is the location of bin (0, 0, 0).
	/// Note that if the Component extent does not include the value (0,0,0),
	/// then this origin bin will not actually be in the output.
	/// The origin of the output ends up being the same as the component origin.
	/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
	/// this origin should be set to 1000, 0, 0.
	/// Initial value is (0.0,0.0,0.0).
	/// </summary>
	public virtual void GetComponentOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageAccumulate_GetComponentOrigin_04(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_GetComponentOrigin_05(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get - The component origin is the location of bin (0, 0, 0).
	/// Note that if the Component extent does not include the value (0,0,0),
	/// then this origin bin will not actually be in the output.
	/// The origin of the output ends up being the same as the component origin.
	/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
	/// this origin should be set to 1000, 0, 0.
	/// Initial value is (0.0,0.0,0.0).
	/// </summary>
	public virtual void GetComponentOrigin(IntPtr _arg)
	{
		vtkImageAccumulate_GetComponentOrigin_05(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAccumulate_GetComponentSpacing_06(HandleRef pThis);

	/// <summary>
	/// Set/Get - The component spacing is the dimension of each bin.
	/// This ends up being the spacing of the output "image".
	/// If the number of input scalar components are less than three,
	/// then some of these spacing values are ignored.
	/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
	/// this spacing should be set to 100, 0, 0.
	/// Initial value is (1.0,1.0,1.0).
	/// </summary>
	public virtual double[] GetComponentSpacing()
	{
		IntPtr intPtr = vtkImageAccumulate_GetComponentSpacing_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_GetComponentSpacing_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get - The component spacing is the dimension of each bin.
	/// This ends up being the spacing of the output "image".
	/// If the number of input scalar components are less than three,
	/// then some of these spacing values are ignored.
	/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
	/// this spacing should be set to 100, 0, 0.
	/// Initial value is (1.0,1.0,1.0).
	/// </summary>
	public virtual void GetComponentSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageAccumulate_GetComponentSpacing_07(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_GetComponentSpacing_08(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get - The component spacing is the dimension of each bin.
	/// This ends up being the spacing of the output "image".
	/// If the number of input scalar components are less than three,
	/// then some of these spacing values are ignored.
	/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
	/// this spacing should be set to 100, 0, 0.
	/// Initial value is (1.0,1.0,1.0).
	/// </summary>
	public virtual void GetComponentSpacing(IntPtr _arg)
	{
		vtkImageAccumulate_GetComponentSpacing_08(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAccumulate_GetIgnoreZero_09(HandleRef pThis);

	/// <summary>
	/// Should the data with value 0 be ignored? Initial value is false.
	/// </summary>
	public virtual int GetIgnoreZero()
	{
		return vtkImageAccumulate_GetIgnoreZero_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAccumulate_GetIgnoreZeroMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Should the data with value 0 be ignored? Initial value is false.
	/// </summary>
	public virtual int GetIgnoreZeroMaxValue()
	{
		return vtkImageAccumulate_GetIgnoreZeroMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAccumulate_GetIgnoreZeroMinValue_11(HandleRef pThis);

	/// <summary>
	/// Should the data with value 0 be ignored? Initial value is false.
	/// </summary>
	public virtual int GetIgnoreZeroMinValue()
	{
		return vtkImageAccumulate_GetIgnoreZeroMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAccumulate_GetMax_12(HandleRef pThis);

	/// <summary>
	/// Get the statistics information for the data.
	/// The values only make sense after the execution of the filter.
	/// Initial values are 0.
	/// </summary>
	public virtual double[] GetMax()
	{
		IntPtr intPtr = vtkImageAccumulate_GetMax_12(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_GetMax_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get the statistics information for the data.
	/// The values only make sense after the execution of the filter.
	/// Initial values are 0.
	/// </summary>
	public virtual void GetMax(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageAccumulate_GetMax_13(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_GetMax_14(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the statistics information for the data.
	/// The values only make sense after the execution of the filter.
	/// Initial values are 0.
	/// </summary>
	public virtual void GetMax(IntPtr _arg)
	{
		vtkImageAccumulate_GetMax_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAccumulate_GetMean_15(HandleRef pThis);

	/// <summary>
	/// Get the statistics information for the data.
	/// The values only make sense after the execution of the filter.
	/// Initial values are 0.
	/// </summary>
	public virtual double[] GetMean()
	{
		IntPtr intPtr = vtkImageAccumulate_GetMean_15(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_GetMean_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get the statistics information for the data.
	/// The values only make sense after the execution of the filter.
	/// Initial values are 0.
	/// </summary>
	public virtual void GetMean(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageAccumulate_GetMean_16(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_GetMean_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the statistics information for the data.
	/// The values only make sense after the execution of the filter.
	/// Initial values are 0.
	/// </summary>
	public virtual void GetMean(IntPtr _arg)
	{
		vtkImageAccumulate_GetMean_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAccumulate_GetMin_18(HandleRef pThis);

	/// <summary>
	/// Get the statistics information for the data.
	/// The values only make sense after the execution of the filter.
	/// Initial values are 0.
	/// </summary>
	public virtual double[] GetMin()
	{
		IntPtr intPtr = vtkImageAccumulate_GetMin_18(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_GetMin_19(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get the statistics information for the data.
	/// The values only make sense after the execution of the filter.
	/// Initial values are 0.
	/// </summary>
	public virtual void GetMin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageAccumulate_GetMin_19(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_GetMin_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the statistics information for the data.
	/// The values only make sense after the execution of the filter.
	/// Initial values are 0.
	/// </summary>
	public virtual void GetMin(IntPtr _arg)
	{
		vtkImageAccumulate_GetMin_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageAccumulate_GetNumberOfGenerationsFromBase_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageAccumulate_GetNumberOfGenerationsFromBase_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageAccumulate_GetNumberOfGenerationsFromBaseType_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageAccumulate_GetNumberOfGenerationsFromBaseType_22(type);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAccumulate_GetReverseStencil_23(HandleRef pThis);

	/// <summary>
	/// Reverse the stencil. Initial value is false.
	/// </summary>
	public virtual int GetReverseStencil()
	{
		return vtkImageAccumulate_GetReverseStencil_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAccumulate_GetReverseStencilMaxValue_24(HandleRef pThis);

	/// <summary>
	/// Reverse the stencil. Initial value is false.
	/// </summary>
	public virtual int GetReverseStencilMaxValue()
	{
		return vtkImageAccumulate_GetReverseStencilMaxValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAccumulate_GetReverseStencilMinValue_25(HandleRef pThis);

	/// <summary>
	/// Reverse the stencil. Initial value is false.
	/// </summary>
	public virtual int GetReverseStencilMinValue()
	{
		return vtkImageAccumulate_GetReverseStencilMinValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAccumulate_GetStandardDeviation_26(HandleRef pThis);

	/// <summary>
	/// Get the statistics information for the data.
	/// The values only make sense after the execution of the filter.
	/// Initial values are 0.
	/// </summary>
	public virtual double[] GetStandardDeviation()
	{
		IntPtr intPtr = vtkImageAccumulate_GetStandardDeviation_26(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_GetStandardDeviation_27(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get the statistics information for the data.
	/// The values only make sense after the execution of the filter.
	/// Initial values are 0.
	/// </summary>
	public virtual void GetStandardDeviation(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageAccumulate_GetStandardDeviation_27(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_GetStandardDeviation_28(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the statistics information for the data.
	/// The values only make sense after the execution of the filter.
	/// Initial values are 0.
	/// </summary>
	public virtual void GetStandardDeviation(IntPtr _arg)
	{
		vtkImageAccumulate_GetStandardDeviation_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAccumulate_GetStencil_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Use a stencil to specify which voxels to accumulate.
	/// Backcompatible methods.
	/// It set and get the stencil on input port 1.
	/// Initial value is nullptr.
	/// </summary>
	public vtkImageStencilData GetStencil()
	{
		vtkImageStencilData vtkImageStencilData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageAccumulate_GetStencil_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageStencilData2 = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageStencilData2.Register(null);
			}
		}
		return vtkImageStencilData2;
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageAccumulate_GetVoxelCount_30(HandleRef pThis);

	/// <summary>
	/// Get the statistics information for the data.
	/// The values only make sense after the execution of the filter.
	/// Initial values are 0.
	/// </summary>
	public virtual long GetVoxelCount()
	{
		return vtkImageAccumulate_GetVoxelCount_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_IgnoreZeroOff_31(HandleRef pThis);

	/// <summary>
	/// Should the data with value 0 be ignored? Initial value is false.
	/// </summary>
	public virtual void IgnoreZeroOff()
	{
		vtkImageAccumulate_IgnoreZeroOff_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_IgnoreZeroOn_32(HandleRef pThis);

	/// <summary>
	/// Should the data with value 0 be ignored? Initial value is false.
	/// </summary>
	public virtual void IgnoreZeroOn()
	{
		vtkImageAccumulate_IgnoreZeroOn_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAccumulate_IsA_33(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageAccumulate_IsA_33(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageAccumulate_IsTypeOf_34(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageAccumulate_IsTypeOf_34(type);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAccumulate_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageAccumulate NewInstance()
	{
		vtkImageAccumulate result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageAccumulate_NewInstance_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageAccumulate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_ReverseStencilOff_37(HandleRef pThis);

	/// <summary>
	/// Reverse the stencil. Initial value is false.
	/// </summary>
	public virtual void ReverseStencilOff()
	{
		vtkImageAccumulate_ReverseStencilOff_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_ReverseStencilOn_38(HandleRef pThis);

	/// <summary>
	/// Reverse the stencil. Initial value is false.
	/// </summary>
	public virtual void ReverseStencilOn()
	{
		vtkImageAccumulate_ReverseStencilOn_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageAccumulate_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageAccumulate SafeDownCast(vtkObjectBase o)
	{
		vtkImageAccumulate vtkImageAccumulate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageAccumulate_SafeDownCast_39(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageAccumulate2 = (vtkImageAccumulate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageAccumulate2.Register(null);
			}
		}
		return vtkImageAccumulate2;
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_SetComponentExtent_40(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Set/Get - The component extent sets the number/extent of the bins.
	/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
	/// this extent should be set to 0, 9, 0, 0, 0, 0.
	/// The extent specifies inclusive min/max values.
	/// This implies that the top extent should be set to the number of bins - 1.
	/// Initial value is (0,255,0,0,0,0)
	/// </summary>
	public void SetComponentExtent(IntPtr extent)
	{
		vtkImageAccumulate_SetComponentExtent_40(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_SetComponentExtent_41(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

	/// <summary>
	/// Set/Get - The component extent sets the number/extent of the bins.
	/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
	/// this extent should be set to 0, 9, 0, 0, 0, 0.
	/// The extent specifies inclusive min/max values.
	/// This implies that the top extent should be set to the number of bins - 1.
	/// Initial value is (0,255,0,0,0,0)
	/// </summary>
	public void SetComponentExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
	{
		vtkImageAccumulate_SetComponentExtent_41(GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_SetComponentOrigin_42(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get - The component origin is the location of bin (0, 0, 0).
	/// Note that if the Component extent does not include the value (0,0,0),
	/// then this origin bin will not actually be in the output.
	/// The origin of the output ends up being the same as the component origin.
	/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
	/// this origin should be set to 1000, 0, 0.
	/// Initial value is (0.0,0.0,0.0).
	/// </summary>
	public virtual void SetComponentOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkImageAccumulate_SetComponentOrigin_42(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_SetComponentOrigin_43(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get - The component origin is the location of bin (0, 0, 0).
	/// Note that if the Component extent does not include the value (0,0,0),
	/// then this origin bin will not actually be in the output.
	/// The origin of the output ends up being the same as the component origin.
	/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
	/// this origin should be set to 1000, 0, 0.
	/// Initial value is (0.0,0.0,0.0).
	/// </summary>
	public virtual void SetComponentOrigin(IntPtr _arg)
	{
		vtkImageAccumulate_SetComponentOrigin_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_SetComponentSpacing_44(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get - The component spacing is the dimension of each bin.
	/// This ends up being the spacing of the output "image".
	/// If the number of input scalar components are less than three,
	/// then some of these spacing values are ignored.
	/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
	/// this spacing should be set to 100, 0, 0.
	/// Initial value is (1.0,1.0,1.0).
	/// </summary>
	public virtual void SetComponentSpacing(double _arg1, double _arg2, double _arg3)
	{
		vtkImageAccumulate_SetComponentSpacing_44(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_SetComponentSpacing_45(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get - The component spacing is the dimension of each bin.
	/// This ends up being the spacing of the output "image".
	/// If the number of input scalar components are less than three,
	/// then some of these spacing values are ignored.
	/// For a 1D histogram with 10 bins spanning the values 1000 to 2000,
	/// this spacing should be set to 100, 0, 0.
	/// Initial value is (1.0,1.0,1.0).
	/// </summary>
	public virtual void SetComponentSpacing(IntPtr _arg)
	{
		vtkImageAccumulate_SetComponentSpacing_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_SetIgnoreZero_46(HandleRef pThis, int _arg);

	/// <summary>
	/// Should the data with value 0 be ignored? Initial value is false.
	/// </summary>
	public virtual void SetIgnoreZero(int _arg)
	{
		vtkImageAccumulate_SetIgnoreZero_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_SetReverseStencil_47(HandleRef pThis, int _arg);

	/// <summary>
	/// Reverse the stencil. Initial value is false.
	/// </summary>
	public virtual void SetReverseStencil(int _arg)
	{
		vtkImageAccumulate_SetReverseStencil_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageAccumulate_SetStencilData_48(HandleRef pThis, HandleRef stencil);

	/// <summary>
	/// Use a stencil to specify which voxels to accumulate.
	/// Backcompatible methods.
	/// It set and get the stencil on input port 1.
	/// Initial value is nullptr.
	/// </summary>
	public void SetStencilData(vtkImageStencilData stencil)
	{
		vtkImageAccumulate_SetStencilData_48(GetCppThis(), stencil?.GetCppThis() ?? default(HandleRef));
	}
}
