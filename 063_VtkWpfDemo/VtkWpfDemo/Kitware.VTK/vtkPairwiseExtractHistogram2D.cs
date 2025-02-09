using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPairwiseExtractHistogram2D
/// </summary>
/// <remarks>
///    compute a 2D histogram between
///  all adjacent columns of an input vtkTable.
///
///
///  This class computes a 2D histogram between all adjacent pairs of columns
///  of an input vtkTable. Internally it creates multiple vtkExtractHistogram2D
///  instances (one for each pair of adjacent table columns).  It also
///  manages updating histogram computations intelligently, only recomputing
///  those histograms for whom a relevant property has been altered.
///
///  Note that there are two different outputs from this filter.  One is a
///  table for which each column contains a flattened 2D histogram array.
///  The other is a vtkMultiBlockDataSet for which each block is a
///  vtkImageData representation of the 2D histogram.
///
/// </remarks>
/// <seealso>
///
///  vtkExtractHistogram2D vtkPPairwiseExtractHistogram2D
///
/// @par Thanks:
///  Developed by David Feng and Philippe Pebay at Sandia National Laboratories
///             ------------------------------------------------------------------------------
/// </seealso>
public class vtkPairwiseExtractHistogram2D : vtkStatisticsAlgorithm
{
	/// <summary>
	/// Get a pointer to the idx'th histogram filter.
	/// </summary>
	public new enum OutputIndices
	{
		/// <summary>enum member</summary>
		HISTOGRAM_IMAGE = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPairwiseExtractHistogram2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPairwiseExtractHistogram2D()
	{
		MRClassNameKey = "class vtkPairwiseExtractHistogram2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPairwiseExtractHistogram2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPairwiseExtractHistogram2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPairwiseExtractHistogram2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPairwiseExtractHistogram2D New()
	{
		vtkPairwiseExtractHistogram2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPairwiseExtractHistogram2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPairwiseExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPairwiseExtractHistogram2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPairwiseExtractHistogram2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPairwiseExtractHistogram2D_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Given a collection of models, calculate aggregate model.  Not used
	/// </summary>
	public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
	{
		vtkPairwiseExtractHistogram2D_Aggregate_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPairwiseExtractHistogram2D_GetBinRange_02(HandleRef pThis, int idx, long binX, long binY, IntPtr range);

	/// <summary>
	/// Compute the range of the bin located at position (binX,binY) in
	/// the 2D histogram at idx.
	/// </summary>
	public int GetBinRange(int idx, long binX, long binY, IntPtr range)
	{
		return vtkPairwiseExtractHistogram2D_GetBinRange_02(GetCppThis(), idx, binX, binY, range);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPairwiseExtractHistogram2D_GetBinRange_03(HandleRef pThis, int idx, long bin, IntPtr range);

	/// <summary>
	/// Get the range of the of the bin located at 1D position index bin
	/// in the 2D histogram array at idx.
	/// </summary>
	public int GetBinRange(int idx, long bin, IntPtr range)
	{
		return vtkPairwiseExtractHistogram2D_GetBinRange_03(GetCppThis(), idx, bin, range);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPairwiseExtractHistogram2D_GetBinWidth_04(HandleRef pThis, int idx, IntPtr bw);

	/// <summary>
	/// Get the width of all of the bins. Also stored in the spacing
	/// ivar of the histogram image output at idx.
	/// </summary>
	public void GetBinWidth(int idx, IntPtr bw)
	{
		vtkPairwiseExtractHistogram2D_GetBinWidth_04(GetCppThis(), idx, bw);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPairwiseExtractHistogram2D_GetHistogramExtents_05(HandleRef pThis, int idx);

	/// <summary>
	/// Get the histogram extents currently in use, either computed
	/// or set by the user for the idx'th histogram.
	/// </summary>
	public IntPtr GetHistogramExtents(int idx)
	{
		return vtkPairwiseExtractHistogram2D_GetHistogramExtents_05(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPairwiseExtractHistogram2D_GetHistogramFilter_06(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a pointer to the idx'th histogram filter.
	/// </summary>
	public vtkExtractHistogram2D GetHistogramFilter(int idx)
	{
		vtkExtractHistogram2D vtkExtractHistogram2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPairwiseExtractHistogram2D_GetHistogramFilter_06(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractHistogram2D2 = (vtkExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractHistogram2D2.Register(null);
			}
		}
		return vtkExtractHistogram2D2;
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPairwiseExtractHistogram2D_GetMaximumBinCount_07(HandleRef pThis, int idx);

	/// <summary>
	/// Get the maximum bin count for a single histogram
	/// </summary>
	public double GetMaximumBinCount(int idx)
	{
		return vtkPairwiseExtractHistogram2D_GetMaximumBinCount_07(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPairwiseExtractHistogram2D_GetMaximumBinCount_08(HandleRef pThis);

	/// <summary>
	/// Get the maximum bin count over all histograms
	/// </summary>
	public double GetMaximumBinCount()
	{
		return vtkPairwiseExtractHistogram2D_GetMaximumBinCount_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPairwiseExtractHistogram2D_GetNumberOfBins_09(HandleRef pThis);

	/// <summary>
	/// Set/get the bin dimensions of the histograms to compute
	/// </summary>
	public virtual int[] GetNumberOfBins()
	{
		IntPtr intPtr = vtkPairwiseExtractHistogram2D_GetNumberOfBins_09(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPairwiseExtractHistogram2D_GetNumberOfBins_10(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Set/get the bin dimensions of the histograms to compute
	/// </summary>
	public virtual void GetNumberOfBins(ref int _arg1, ref int _arg2)
	{
		vtkPairwiseExtractHistogram2D_GetNumberOfBins_10(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPairwiseExtractHistogram2D_GetNumberOfBins_11(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the bin dimensions of the histograms to compute
	/// </summary>
	public virtual void GetNumberOfBins(IntPtr _arg)
	{
		vtkPairwiseExtractHistogram2D_GetNumberOfBins_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPairwiseExtractHistogram2D_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPairwiseExtractHistogram2D_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPairwiseExtractHistogram2D_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPairwiseExtractHistogram2D_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPairwiseExtractHistogram2D_GetOutputHistogramImage_14(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vtkImageData output of the idx'th histogram filter
	/// </summary>
	public vtkImageData GetOutputHistogramImage(int idx)
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPairwiseExtractHistogram2D_GetOutputHistogramImage_14(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPairwiseExtractHistogram2D_GetScalarType_15(HandleRef pThis);

	/// <summary>
	/// Set the scalar type for each of the computed histograms.
	/// </summary>
	public virtual int GetScalarType()
	{
		return vtkPairwiseExtractHistogram2D_GetScalarType_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPairwiseExtractHistogram2D_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPairwiseExtractHistogram2D_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPairwiseExtractHistogram2D_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPairwiseExtractHistogram2D_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPairwiseExtractHistogram2D_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPairwiseExtractHistogram2D NewInstance()
	{
		vtkPairwiseExtractHistogram2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPairwiseExtractHistogram2D_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPairwiseExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPairwiseExtractHistogram2D_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPairwiseExtractHistogram2D SafeDownCast(vtkObjectBase o)
	{
		vtkPairwiseExtractHistogram2D vtkPairwiseExtractHistogram2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPairwiseExtractHistogram2D_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPairwiseExtractHistogram2D2 = (vtkPairwiseExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPairwiseExtractHistogram2D2.Register(null);
			}
		}
		return vtkPairwiseExtractHistogram2D2;
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPairwiseExtractHistogram2D_SetCustomColumnRange_21(HandleRef pThis, int col, IntPtr range);

	/// <summary>
	/// More standard way to set the custom range for a particular column.
	/// This makes sure that only the affected histograms know that they
	/// need to be updated.
	/// </summary>
	public void SetCustomColumnRange(int col, IntPtr range)
	{
		vtkPairwiseExtractHistogram2D_SetCustomColumnRange_21(GetCppThis(), col, range);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPairwiseExtractHistogram2D_SetCustomColumnRange_22(HandleRef pThis, int col, double rmin, double rmax);

	/// <summary>
	/// More standard way to set the custom range for a particular column.
	/// This makes sure that only the affected histograms know that they
	/// need to be updated.
	/// </summary>
	public void SetCustomColumnRange(int col, double rmin, double rmax)
	{
		vtkPairwiseExtractHistogram2D_SetCustomColumnRange_22(GetCppThis(), col, rmin, rmax);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPairwiseExtractHistogram2D_SetCustomColumnRangeByIndex_23(HandleRef pThis, double arg0, double arg1);

	/// <summary>
	/// Strange method for setting an index to be used for setting custom
	/// column range. This was (probably) necessary to get this class
	/// to interact with the ParaView client/server message passing interface.
	/// </summary>
	public void SetCustomColumnRangeByIndex(double arg0, double arg1)
	{
		vtkPairwiseExtractHistogram2D_SetCustomColumnRangeByIndex_23(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPairwiseExtractHistogram2D_SetCustomColumnRangeIndex_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Strange method for setting an index to be used for setting custom
	/// column range. This was (probably) necessary to get this class
	/// to interact with the ParaView client/server message passing interface.
	/// </summary>
	public virtual void SetCustomColumnRangeIndex(int _arg)
	{
		vtkPairwiseExtractHistogram2D_SetCustomColumnRangeIndex_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPairwiseExtractHistogram2D_SetNumberOfBins_25(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set/get the bin dimensions of the histograms to compute
	/// </summary>
	public virtual void SetNumberOfBins(int _arg1, int _arg2)
	{
		vtkPairwiseExtractHistogram2D_SetNumberOfBins_25(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPairwiseExtractHistogram2D_SetNumberOfBins_26(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the bin dimensions of the histograms to compute
	/// </summary>
	public void SetNumberOfBins(IntPtr _arg)
	{
		vtkPairwiseExtractHistogram2D_SetNumberOfBins_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPairwiseExtractHistogram2D_SetScalarType_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the scalar type for each of the computed histograms.
	/// </summary>
	public virtual void SetScalarType(int _arg)
	{
		vtkPairwiseExtractHistogram2D_SetScalarType_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedChar_28(HandleRef pThis);

	/// <summary>
	/// Set the scalar type for each of the computed histograms.
	/// </summary>
	public void SetScalarTypeToUnsignedChar()
	{
		vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedChar_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedInt_29(HandleRef pThis);

	/// <summary>
	/// Set the scalar type for each of the computed histograms.
	/// </summary>
	public void SetScalarTypeToUnsignedInt()
	{
		vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedInt_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedLong_30(HandleRef pThis);

	/// <summary>
	/// Set the scalar type for each of the computed histograms.
	/// </summary>
	public void SetScalarTypeToUnsignedLong()
	{
		vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedLong_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedShort_31(HandleRef pThis);

	/// <summary>
	/// Set the scalar type for each of the computed histograms.
	/// </summary>
	public void SetScalarTypeToUnsignedShort()
	{
		vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedShort_31(GetCppThis());
	}
}
