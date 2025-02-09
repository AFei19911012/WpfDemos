using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractHistogram2D
/// </summary>
/// <remarks>
///    compute a 2D histogram between two columns
///  of an input vtkTable.
///
///
///  This class computes a 2D histogram between two columns of an input
///  vtkTable. Just as with a 1D histogram, a 2D histogram breaks
///  up the input domain into bins, and each pair of values (row in
///  the table) fits into a single bin and increments a row counter
///  for that bin.
///
///  To use this class, set the input with a table and call AddColumnPair(nameX,nameY),
///  where nameX and nameY are the names of the two columns to be used.
///
///  In addition to the number of bins (in X and Y), the domain of
///  the histogram can be customized by toggling the UseCustomHistogramExtents
///  flag and setting the CustomHistogramExtents variable to the
///  desired value.
///
/// </remarks>
/// <seealso>
///
///  vtkPExtractHistogram2D
///
/// @par Thanks:
///  Developed by David Feng and Philippe Pebay at Sandia National Laboratories
///             ------------------------------------------------------------------------------
/// </seealso>
public class vtkExtractHistogram2D : vtkStatisticsAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new enum OutputIndices
	{
		/// <summary>enum member</summary>
		HISTOGRAM_IMAGE = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractHistogram2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractHistogram2D()
	{
		MRClassNameKey = "class vtkExtractHistogram2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractHistogram2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractHistogram2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractHistogram2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractHistogram2D New()
	{
		vtkExtractHistogram2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractHistogram2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExtractHistogram2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractHistogram2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkExtractHistogram2D_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Given a collection of models, calculate aggregate model. Not used.
	/// </summary>
	public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
	{
		vtkExtractHistogram2D_Aggregate_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractHistogram2D_GetBinRange_02(HandleRef pThis, long binX, long binY, IntPtr range);

	/// <summary>
	/// Compute the range of the bin located at position (binX,binY) in
	/// the 2D histogram.
	/// </summary>
	public int GetBinRange(long binX, long binY, IntPtr range)
	{
		return vtkExtractHistogram2D_GetBinRange_02(GetCppThis(), binX, binY, range);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractHistogram2D_GetBinRange_03(HandleRef pThis, long bin, IntPtr range);

	/// <summary>
	/// Get the range of the of the bin located at 1D position index bin
	/// in the 2D histogram array.
	/// </summary>
	public int GetBinRange(long bin, IntPtr range)
	{
		return vtkExtractHistogram2D_GetBinRange_03(GetCppThis(), bin, range);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_GetBinWidth_04(HandleRef pThis, IntPtr bw);

	/// <summary>
	/// Get the width of all of the bins. Also stored in the spacing
	/// ivar of the histogram image output.
	/// </summary>
	public void GetBinWidth(IntPtr bw)
	{
		vtkExtractHistogram2D_GetBinWidth_04(GetCppThis(), bw);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractHistogram2D_GetComponentsToProcess_05(HandleRef pThis);

	/// <summary>
	/// Set/get the components of the arrays in the two input columns
	/// to be used during histogram computation.  Defaults to component 0.
	/// </summary>
	public virtual int[] GetComponentsToProcess()
	{
		IntPtr intPtr = vtkExtractHistogram2D_GetComponentsToProcess_05(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_GetComponentsToProcess_06(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Set/get the components of the arrays in the two input columns
	/// to be used during histogram computation.  Defaults to component 0.
	/// </summary>
	public virtual void GetComponentsToProcess(ref int _arg1, ref int _arg2)
	{
		vtkExtractHistogram2D_GetComponentsToProcess_06(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_GetComponentsToProcess_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the components of the arrays in the two input columns
	/// to be used during histogram computation.  Defaults to component 0.
	/// </summary>
	public virtual void GetComponentsToProcess(IntPtr _arg)
	{
		vtkExtractHistogram2D_GetComponentsToProcess_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractHistogram2D_GetCustomHistogramExtents_08(HandleRef pThis);

	/// <summary>
	/// Set/get a custom domain for histogram computation.  UseCustomHistogramExtents
	/// must be called for these to actually be used.
	/// </summary>
	public virtual double[] GetCustomHistogramExtents()
	{
		IntPtr intPtr = vtkExtractHistogram2D_GetCustomHistogramExtents_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_GetCustomHistogramExtents_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// Set/get a custom domain for histogram computation.  UseCustomHistogramExtents
	/// must be called for these to actually be used.
	/// </summary>
	public virtual void GetCustomHistogramExtents(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkExtractHistogram2D_GetCustomHistogramExtents_09(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_GetCustomHistogramExtents_10(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get a custom domain for histogram computation.  UseCustomHistogramExtents
	/// must be called for these to actually be used.
	/// </summary>
	public virtual void GetCustomHistogramExtents(IntPtr _arg)
	{
		vtkExtractHistogram2D_GetCustomHistogramExtents_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractHistogram2D_GetHistogramExtents_11(HandleRef pThis);

	/// <summary>
	/// Get the histogram extents currently in use, either computed
	/// or set by the user.
	/// </summary>
	public IntPtr GetHistogramExtents()
	{
		return vtkExtractHistogram2D_GetHistogramExtents_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkExtractHistogram2D_GetMaximumBinCount_12(HandleRef pThis);

	/// <summary>
	/// Access the count of the histogram bin containing the largest number
	/// of input rows.
	/// </summary>
	public virtual double GetMaximumBinCount()
	{
		return vtkExtractHistogram2D_GetMaximumBinCount_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractHistogram2D_GetNumberOfBins_13(HandleRef pThis);

	/// <summary>
	/// Set/get the number of bins to be used per dimension (x,y)
	/// </summary>
	public virtual int[] GetNumberOfBins()
	{
		IntPtr intPtr = vtkExtractHistogram2D_GetNumberOfBins_13(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_GetNumberOfBins_14(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Set/get the number of bins to be used per dimension (x,y)
	/// </summary>
	public virtual void GetNumberOfBins(ref int _arg1, ref int _arg2)
	{
		vtkExtractHistogram2D_GetNumberOfBins_14(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_GetNumberOfBins_15(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the number of bins to be used per dimension (x,y)
	/// </summary>
	public virtual void GetNumberOfBins(IntPtr _arg)
	{
		vtkExtractHistogram2D_GetNumberOfBins_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractHistogram2D_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractHistogram2D_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractHistogram2D_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractHistogram2D_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractHistogram2D_GetOutputHistogramImage_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Gets the data object at the histogram image output port and
	/// casts it to a vtkImageData.
	/// </summary>
	public vtkImageData GetOutputHistogramImage()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractHistogram2D_GetOutputHistogramImage_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkExtractHistogram2D_GetRowMask_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set an optional mask that can ignore rows of the table
	/// </summary>
	public virtual vtkDataArray GetRowMask()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractHistogram2D_GetRowMask_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractHistogram2D_GetScalarType_20(HandleRef pThis);

	/// <summary>
	/// Control the scalar type of the output histogram.  If the input
	/// is relatively small, you can save space by using a smaller
	/// data type.  Defaults to unsigned integer.
	/// </summary>
	public virtual int GetScalarType()
	{
		return vtkExtractHistogram2D_GetScalarType_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractHistogram2D_GetSwapColumns_21(HandleRef pThis);

	/// <summary>
	/// Get the histogram extents currently in use, either computed
	/// or set by the user.
	/// </summary>
	public virtual int GetSwapColumns()
	{
		return vtkExtractHistogram2D_GetSwapColumns_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractHistogram2D_GetUseCustomHistogramExtents_22(HandleRef pThis);

	/// <summary>
	/// Use the extents in CustomHistogramExtents when computing the
	/// histogram, rather than the simple range of the input columns.
	/// </summary>
	public virtual int GetUseCustomHistogramExtents()
	{
		return vtkExtractHistogram2D_GetUseCustomHistogramExtents_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractHistogram2D_IsA_23(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractHistogram2D_IsA_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractHistogram2D_IsTypeOf_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractHistogram2D_IsTypeOf_24(type);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractHistogram2D_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractHistogram2D NewInstance()
	{
		vtkExtractHistogram2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractHistogram2D_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractHistogram2D_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractHistogram2D SafeDownCast(vtkObjectBase o)
	{
		vtkExtractHistogram2D vtkExtractHistogram2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractHistogram2D_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkExtractHistogram2D_SetComponentsToProcess_28(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set/get the components of the arrays in the two input columns
	/// to be used during histogram computation.  Defaults to component 0.
	/// </summary>
	public virtual void SetComponentsToProcess(int _arg1, int _arg2)
	{
		vtkExtractHistogram2D_SetComponentsToProcess_28(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_SetComponentsToProcess_29(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the components of the arrays in the two input columns
	/// to be used during histogram computation.  Defaults to component 0.
	/// </summary>
	public void SetComponentsToProcess(IntPtr _arg)
	{
		vtkExtractHistogram2D_SetComponentsToProcess_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_SetCustomHistogramExtents_30(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Set/get a custom domain for histogram computation.  UseCustomHistogramExtents
	/// must be called for these to actually be used.
	/// </summary>
	public virtual void SetCustomHistogramExtents(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkExtractHistogram2D_SetCustomHistogramExtents_30(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_SetCustomHistogramExtents_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get a custom domain for histogram computation.  UseCustomHistogramExtents
	/// must be called for these to actually be used.
	/// </summary>
	public virtual void SetCustomHistogramExtents(IntPtr _arg)
	{
		vtkExtractHistogram2D_SetCustomHistogramExtents_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_SetNumberOfBins_32(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set/get the number of bins to be used per dimension (x,y)
	/// </summary>
	public virtual void SetNumberOfBins(int _arg1, int _arg2)
	{
		vtkExtractHistogram2D_SetNumberOfBins_32(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_SetNumberOfBins_33(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the number of bins to be used per dimension (x,y)
	/// </summary>
	public void SetNumberOfBins(IntPtr _arg)
	{
		vtkExtractHistogram2D_SetNumberOfBins_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_SetRowMask_34(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set an optional mask that can ignore rows of the table
	/// </summary>
	public virtual void SetRowMask(vtkDataArray arg0)
	{
		vtkExtractHistogram2D_SetRowMask_34(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_SetScalarType_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the scalar type of the output histogram.  If the input
	/// is relatively small, you can save space by using a smaller
	/// data type.  Defaults to unsigned integer.
	/// </summary>
	public virtual void SetScalarType(int _arg)
	{
		vtkExtractHistogram2D_SetScalarType_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_SetScalarTypeToDouble_36(HandleRef pThis);

	/// <summary>
	/// Control the scalar type of the output histogram.  If the input
	/// is relatively small, you can save space by using a smaller
	/// data type.  Defaults to unsigned integer.
	/// </summary>
	public void SetScalarTypeToDouble()
	{
		vtkExtractHistogram2D_SetScalarTypeToDouble_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_SetScalarTypeToFloat_37(HandleRef pThis);

	/// <summary>
	/// Control the scalar type of the output histogram.  If the input
	/// is relatively small, you can save space by using a smaller
	/// data type.  Defaults to unsigned integer.
	/// </summary>
	public void SetScalarTypeToFloat()
	{
		vtkExtractHistogram2D_SetScalarTypeToFloat_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_SetScalarTypeToUnsignedChar_38(HandleRef pThis);

	/// <summary>
	/// Control the scalar type of the output histogram.  If the input
	/// is relatively small, you can save space by using a smaller
	/// data type.  Defaults to unsigned integer.
	/// </summary>
	public void SetScalarTypeToUnsignedChar()
	{
		vtkExtractHistogram2D_SetScalarTypeToUnsignedChar_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_SetScalarTypeToUnsignedInt_39(HandleRef pThis);

	/// <summary>
	/// Control the scalar type of the output histogram.  If the input
	/// is relatively small, you can save space by using a smaller
	/// data type.  Defaults to unsigned integer.
	/// </summary>
	public void SetScalarTypeToUnsignedInt()
	{
		vtkExtractHistogram2D_SetScalarTypeToUnsignedInt_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_SetScalarTypeToUnsignedLong_40(HandleRef pThis);

	/// <summary>
	/// Control the scalar type of the output histogram.  If the input
	/// is relatively small, you can save space by using a smaller
	/// data type.  Defaults to unsigned integer.
	/// </summary>
	public void SetScalarTypeToUnsignedLong()
	{
		vtkExtractHistogram2D_SetScalarTypeToUnsignedLong_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_SetScalarTypeToUnsignedShort_41(HandleRef pThis);

	/// <summary>
	/// Control the scalar type of the output histogram.  If the input
	/// is relatively small, you can save space by using a smaller
	/// data type.  Defaults to unsigned integer.
	/// </summary>
	public void SetScalarTypeToUnsignedShort()
	{
		vtkExtractHistogram2D_SetScalarTypeToUnsignedShort_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_SetSwapColumns_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Get the histogram extents currently in use, either computed
	/// or set by the user.
	/// </summary>
	public virtual void SetSwapColumns(int _arg)
	{
		vtkExtractHistogram2D_SetSwapColumns_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_SetUseCustomHistogramExtents_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Use the extents in CustomHistogramExtents when computing the
	/// histogram, rather than the simple range of the input columns.
	/// </summary>
	public virtual void SetUseCustomHistogramExtents(int _arg)
	{
		vtkExtractHistogram2D_SetUseCustomHistogramExtents_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_SwapColumnsOff_44(HandleRef pThis);

	/// <summary>
	/// Get the histogram extents currently in use, either computed
	/// or set by the user.
	/// </summary>
	public virtual void SwapColumnsOff()
	{
		vtkExtractHistogram2D_SwapColumnsOff_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_SwapColumnsOn_45(HandleRef pThis);

	/// <summary>
	/// Get the histogram extents currently in use, either computed
	/// or set by the user.
	/// </summary>
	public virtual void SwapColumnsOn()
	{
		vtkExtractHistogram2D_SwapColumnsOn_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_UseCustomHistogramExtentsOff_46(HandleRef pThis);

	/// <summary>
	/// Use the extents in CustomHistogramExtents when computing the
	/// histogram, rather than the simple range of the input columns.
	/// </summary>
	public virtual void UseCustomHistogramExtentsOff()
	{
		vtkExtractHistogram2D_UseCustomHistogramExtentsOff_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractHistogram2D_UseCustomHistogramExtentsOn_47(HandleRef pThis);

	/// <summary>
	/// Use the extents in CustomHistogramExtents when computing the
	/// histogram, rather than the simple range of the input columns.
	/// </summary>
	public virtual void UseCustomHistogramExtentsOn()
	{
		vtkExtractHistogram2D_UseCustomHistogramExtentsOn_47(GetCppThis());
	}
}
