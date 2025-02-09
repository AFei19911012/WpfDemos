using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageQuantizeRGBToIndex
/// </summary>
/// <remarks>
///    generalized histograms up to 4 dimensions
///
/// vtkImageQuantizeRGBToIndex takes a 3 component RGB image as
/// input and produces a one component index image as output, along with
/// a lookup table that contains the color definitions for the index values.
/// This filter works on the entire input extent - it does not perform
/// streaming, and it does not supported threaded execution (because it has
/// to process the entire image).
///
/// To use this filter, you typically set the number of colors
/// (between 2 and 65536), execute it, and then retrieve the lookup table.
/// The colors can then be using the lookup table and the image index.
///
/// This filter can run faster, by initially sampling the colors at a
/// coarser level. This can be specified by the SamplingRate parameter.
///
/// The "index-image" viewed as a greyscale image, is usually quite
/// arbitrary, accentuating contrast where none can be perceived in
/// the original color image.
/// To make the index image more meaningful (e.g. for image segmentation
/// operating on scalar images), we sort the mean colors by luminance
/// and re-map the indices accordingly. This option does not introduce any
/// computational complexity and has no impact on actual colors in the
/// lookup table (only their order).
/// </remarks>
public class vtkImageQuantizeRGBToIndex : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageQuantizeRGBToIndex";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageQuantizeRGBToIndex()
	{
		MRClassNameKey = "class vtkImageQuantizeRGBToIndex";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageQuantizeRGBToIndex"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageQuantizeRGBToIndex(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageQuantizeRGBToIndex_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageQuantizeRGBToIndex New()
	{
		vtkImageQuantizeRGBToIndex result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageQuantizeRGBToIndex_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageQuantizeRGBToIndex)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageQuantizeRGBToIndex()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageQuantizeRGBToIndex_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageQuantizeRGBToIndex_GetBuildTreeExecuteTime_01(HandleRef pThis);

	/// <summary>
	/// Get the resulting lookup table that contains the color definitions
	/// corresponding to the index values in the output image.
	/// </summary>
	public virtual double GetBuildTreeExecuteTime()
	{
		return vtkImageQuantizeRGBToIndex_GetBuildTreeExecuteTime_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageQuantizeRGBToIndex_GetInitializeExecuteTime_02(HandleRef pThis);

	/// <summary>
	/// Get the resulting lookup table that contains the color definitions
	/// corresponding to the index values in the output image.
	/// </summary>
	public virtual double GetInitializeExecuteTime()
	{
		return vtkImageQuantizeRGBToIndex_GetInitializeExecuteTime_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageQuantizeRGBToIndex_GetInputType_03(HandleRef pThis);

	/// <summary>
	/// For internal use only - get the type of the image
	/// </summary>
	public virtual int GetInputType()
	{
		return vtkImageQuantizeRGBToIndex_GetInputType_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageQuantizeRGBToIndex_GetLookupIndexExecuteTime_04(HandleRef pThis);

	/// <summary>
	/// Get the resulting lookup table that contains the color definitions
	/// corresponding to the index values in the output image.
	/// </summary>
	public virtual double GetLookupIndexExecuteTime()
	{
		return vtkImageQuantizeRGBToIndex_GetLookupIndexExecuteTime_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageQuantizeRGBToIndex_GetLookupTable_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the resulting lookup table that contains the color definitions
	/// corresponding to the index values in the output image.
	/// </summary>
	public virtual vtkLookupTable GetLookupTable()
	{
		vtkLookupTable vtkLookupTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageQuantizeRGBToIndex_GetLookupTable_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLookupTable2 = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLookupTable2.Register(null);
			}
		}
		return vtkLookupTable2;
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageQuantizeRGBToIndex_GetNumberOfColors_06(HandleRef pThis);

	/// <summary>
	/// Set / Get the number of color index values to produce - must be
	/// a number between 2 and 65536.
	/// </summary>
	public virtual int GetNumberOfColors()
	{
		return vtkImageQuantizeRGBToIndex_GetNumberOfColors_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageQuantizeRGBToIndex_GetNumberOfColorsMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Set / Get the number of color index values to produce - must be
	/// a number between 2 and 65536.
	/// </summary>
	public virtual int GetNumberOfColorsMaxValue()
	{
		return vtkImageQuantizeRGBToIndex_GetNumberOfColorsMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageQuantizeRGBToIndex_GetNumberOfColorsMinValue_08(HandleRef pThis);

	/// <summary>
	/// Set / Get the number of color index values to produce - must be
	/// a number between 2 and 65536.
	/// </summary>
	public virtual int GetNumberOfColorsMinValue()
	{
		return vtkImageQuantizeRGBToIndex_GetNumberOfColorsMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageQuantizeRGBToIndex_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageQuantizeRGBToIndex_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageQuantizeRGBToIndex_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageQuantizeRGBToIndex_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageQuantizeRGBToIndex_GetSamplingRate_11(HandleRef pThis);

	/// <summary>
	/// Set / Get the number of color index values to produce - must be
	/// a number between 2 and 65536.
	/// </summary>
	public virtual int[] GetSamplingRate()
	{
		IntPtr intPtr = vtkImageQuantizeRGBToIndex_GetSamplingRate_11(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageQuantizeRGBToIndex_GetSamplingRate_12(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Set / Get the number of color index values to produce - must be
	/// a number between 2 and 65536.
	/// </summary>
	public virtual void GetSamplingRate(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkImageQuantizeRGBToIndex_GetSamplingRate_12(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageQuantizeRGBToIndex_GetSamplingRate_13(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / Get the number of color index values to produce - must be
	/// a number between 2 and 65536.
	/// </summary>
	public virtual void GetSamplingRate(IntPtr _arg)
	{
		vtkImageQuantizeRGBToIndex_GetSamplingRate_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImageQuantizeRGBToIndex_GetSortIndexByLuminance_14(HandleRef pThis);

	/// <summary>
	/// Set / Get the number of color index values to produce - must be
	/// a number between 2 and 65536.
	/// </summary>
	public virtual bool GetSortIndexByLuminance()
	{
		return (vtkImageQuantizeRGBToIndex_GetSortIndexByLuminance_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageQuantizeRGBToIndex_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageQuantizeRGBToIndex_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageQuantizeRGBToIndex_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageQuantizeRGBToIndex_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageQuantizeRGBToIndex_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageQuantizeRGBToIndex NewInstance()
	{
		vtkImageQuantizeRGBToIndex result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageQuantizeRGBToIndex_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageQuantizeRGBToIndex)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageQuantizeRGBToIndex_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageQuantizeRGBToIndex SafeDownCast(vtkObjectBase o)
	{
		vtkImageQuantizeRGBToIndex vtkImageQuantizeRGBToIndex2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageQuantizeRGBToIndex_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageQuantizeRGBToIndex2 = (vtkImageQuantizeRGBToIndex)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageQuantizeRGBToIndex2.Register(null);
			}
		}
		return vtkImageQuantizeRGBToIndex2;
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageQuantizeRGBToIndex_SetBuildTreeExecuteTime_20(HandleRef pThis, double _arg);

	/// <summary>
	/// For internal use only - set the times for execution
	/// </summary>
	public virtual void SetBuildTreeExecuteTime(double _arg)
	{
		vtkImageQuantizeRGBToIndex_SetBuildTreeExecuteTime_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageQuantizeRGBToIndex_SetInitializeExecuteTime_21(HandleRef pThis, double _arg);

	/// <summary>
	/// For internal use only - set the times for execution
	/// </summary>
	public virtual void SetInitializeExecuteTime(double _arg)
	{
		vtkImageQuantizeRGBToIndex_SetInitializeExecuteTime_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageQuantizeRGBToIndex_SetLookupIndexExecuteTime_22(HandleRef pThis, double _arg);

	/// <summary>
	/// For internal use only - set the times for execution
	/// </summary>
	public virtual void SetLookupIndexExecuteTime(double _arg)
	{
		vtkImageQuantizeRGBToIndex_SetLookupIndexExecuteTime_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageQuantizeRGBToIndex_SetNumberOfColors_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Set / Get the number of color index values to produce - must be
	/// a number between 2 and 65536.
	/// </summary>
	public virtual void SetNumberOfColors(int _arg)
	{
		vtkImageQuantizeRGBToIndex_SetNumberOfColors_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageQuantizeRGBToIndex_SetSamplingRate_24(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Set / Get the number of color index values to produce - must be
	/// a number between 2 and 65536.
	/// </summary>
	public virtual void SetSamplingRate(int _arg1, int _arg2, int _arg3)
	{
		vtkImageQuantizeRGBToIndex_SetSamplingRate_24(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageQuantizeRGBToIndex_SetSamplingRate_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / Get the number of color index values to produce - must be
	/// a number between 2 and 65536.
	/// </summary>
	public virtual void SetSamplingRate(IntPtr _arg)
	{
		vtkImageQuantizeRGBToIndex_SetSamplingRate_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageQuantizeRGBToIndex_SetSortIndexByLuminance_26(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set / Get the number of color index values to produce - must be
	/// a number between 2 and 65536.
	/// </summary>
	public virtual void SetSortIndexByLuminance(bool _arg)
	{
		vtkImageQuantizeRGBToIndex_SetSortIndexByLuminance_26(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageQuantizeRGBToIndex_SortIndexByLuminanceOff_27(HandleRef pThis);

	/// <summary>
	/// Set / Get the number of color index values to produce - must be
	/// a number between 2 and 65536.
	/// </summary>
	public virtual void SortIndexByLuminanceOff()
	{
		vtkImageQuantizeRGBToIndex_SortIndexByLuminanceOff_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageQuantizeRGBToIndex_SortIndexByLuminanceOn_28(HandleRef pThis);

	/// <summary>
	/// Set / Get the number of color index values to produce - must be
	/// a number between 2 and 65536.
	/// </summary>
	public virtual void SortIndexByLuminanceOn()
	{
		vtkImageQuantizeRGBToIndex_SortIndexByLuminanceOn_28(GetCppThis());
	}
}
