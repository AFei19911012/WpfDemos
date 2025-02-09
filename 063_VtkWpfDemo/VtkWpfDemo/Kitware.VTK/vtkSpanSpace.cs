using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSpanSpace
/// </summary>
/// <remarks>
///    organize data according to scalar span space
///
/// This is a helper class used to accelerate contouring operations. Given an
/// dataset, it organizes the dataset cells into a 2D binned space, with
/// coordinate axes (scalar_min,scalar_max). This so-called span space can
/// then be traversed quickly to find the cells that intersect a specified
/// contour value.
///
/// This class has an API that supports both serial and parallel
/// operation.  The parallel API enables the using class to grab arrays
/// (or batches) of cells that lie along a particular row in the span
/// space. These arrays can then be processed separately or in parallel.
///
/// Learn more about span space in these two publications: 1) "A Near
/// Optimal Isosorface Extraction Algorithm Using the Span Space."
/// Yarden Livnat et al. and 2) Isosurfacing in Span Space with Utmost
/// Efficiency." Han-Wei Shen et al.
///
/// </remarks>
/// <seealso>
///
/// vtkScalarTree vtkSimpleScalarTree
/// </seealso>
public class vtkSpanSpace : vtkScalarTree
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSpanSpace";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSpanSpace()
	{
		MRClassNameKey = "class vtkSpanSpace";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpanSpace"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSpanSpace(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpanSpace_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate a scalar tree with default resolution of 100 and automatic
	/// scalar range computation.
	/// </summary>
	public new static vtkSpanSpace New()
	{
		vtkSpanSpace result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpanSpace_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSpanSpace)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate a scalar tree with default resolution of 100 and automatic
	/// scalar range computation.
	/// </summary>
	public vtkSpanSpace()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSpanSpace_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpanSpace_BuildTree_01(HandleRef pThis);

	/// <summary>
	/// Construct the scalar tree from the dataset provided. Checks build times
	/// and modified time from input and reconstructs the tree if necessary.
	/// </summary>
	public override void BuildTree()
	{
		vtkSpanSpace_BuildTree_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpanSpace_ComputeResolutionOff_02(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether the resolution of span space is computed
	/// automatically from the average number of cells falling in each bucket.
	/// </summary>
	public virtual void ComputeResolutionOff()
	{
		vtkSpanSpace_ComputeResolutionOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpanSpace_ComputeResolutionOn_03(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether the resolution of span space is computed
	/// automatically from the average number of cells falling in each bucket.
	/// </summary>
	public virtual void ComputeResolutionOn()
	{
		vtkSpanSpace_ComputeResolutionOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpanSpace_ComputeScalarRangeOff_04(HandleRef pThis);

	/// <summary>
	/// This boolean controls whether the determination of the scalar range is
	/// computed from the input scalar data. By default this is enabled.
	/// </summary>
	public virtual void ComputeScalarRangeOff()
	{
		vtkSpanSpace_ComputeScalarRangeOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpanSpace_ComputeScalarRangeOn_05(HandleRef pThis);

	/// <summary>
	/// This boolean controls whether the determination of the scalar range is
	/// computed from the input scalar data. By default this is enabled.
	/// </summary>
	public virtual void ComputeScalarRangeOn()
	{
		vtkSpanSpace_ComputeScalarRangeOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpanSpace_GetBatchSize_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the size of the cell batches when processing in
	/// parallel. By default the batch size = 100 cells in each batch.
	/// </summary>
	public virtual long GetBatchSize()
	{
		return vtkSpanSpace_GetBatchSize_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpanSpace_GetBatchSizeMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the size of the cell batches when processing in
	/// parallel. By default the batch size = 100 cells in each batch.
	/// </summary>
	public virtual long GetBatchSizeMaxValue()
	{
		return vtkSpanSpace_GetBatchSizeMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpanSpace_GetBatchSizeMinValue_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the size of the cell batches when processing in
	/// parallel. By default the batch size = 100 cells in each batch.
	/// </summary>
	public virtual long GetBatchSizeMinValue()
	{
		return vtkSpanSpace_GetBatchSizeMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpanSpace_GetCellBatch_09(HandleRef pThis, long batchNum, ref long numCells);

	/// <summary>
	/// Return the array of cell ids in the specified batch. The method
	/// also returns the number of cell ids in the array. Make sure to
	/// call GetNumberOfCellBatches() beforehand.
	/// </summary>
	public override IntPtr GetCellBatch(long batchNum, ref long numCells)
	{
		return vtkSpanSpace_GetCellBatch_09(GetCppThis(), batchNum, ref numCells);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpanSpace_GetComputeResolution_10(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether the resolution of span space is computed
	/// automatically from the average number of cells falling in each bucket.
	/// </summary>
	public virtual int GetComputeResolution()
	{
		return vtkSpanSpace_GetComputeResolution_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpanSpace_GetComputeScalarRange_11(HandleRef pThis);

	/// <summary>
	/// This boolean controls whether the determination of the scalar range is
	/// computed from the input scalar data. By default this is enabled.
	/// </summary>
	public virtual int GetComputeScalarRange()
	{
		return vtkSpanSpace_GetComputeScalarRange_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpanSpace_GetNextCell_12(HandleRef pThis, ref long cellId, HandleRef ptIds, HandleRef cellScalars, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the next cell that may contain scalar value specified to
	/// InitTraversal(). The value nullptr is returned if the list is
	/// exhausted. Make sure that InitTraversal() has been invoked first or
	/// you'll get undefined behavior. This is inherently a serial operation.
	/// </summary>
	public override vtkCell GetNextCell(ref long cellId, vtkIdList ptIds, vtkDataArray cellScalars)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpanSpace_GetNextCell_12(GetCppThis(), ref cellId, ptIds?.GetCppThis() ?? default(HandleRef), cellScalars?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCell2 = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCell2.Register(null);
			}
		}
		return vtkCell2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpanSpace_GetNumberOfCellBatches_13(HandleRef pThis, double scalarValue);

	/// <summary>
	/// Get the number of cell batches available for processing as a function of
	/// the specified scalar value. Each batch contains a list of candidate
	/// cells that may contain the specified isocontour value.
	/// </summary>
	public override long GetNumberOfCellBatches(double scalarValue)
	{
		return vtkSpanSpace_GetNumberOfCellBatches_13(GetCppThis(), scalarValue);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpanSpace_GetNumberOfCellsPerBucket_14(HandleRef pThis);

	/// <summary>
	/// Specify the average number of cells in each bucket. This is used to
	/// indirectly control the resolution if ComputeResolution is enabled.
	/// </summary>
	public virtual int GetNumberOfCellsPerBucket()
	{
		return vtkSpanSpace_GetNumberOfCellsPerBucket_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpanSpace_GetNumberOfCellsPerBucketMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Specify the average number of cells in each bucket. This is used to
	/// indirectly control the resolution if ComputeResolution is enabled.
	/// </summary>
	public virtual int GetNumberOfCellsPerBucketMaxValue()
	{
		return vtkSpanSpace_GetNumberOfCellsPerBucketMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpanSpace_GetNumberOfCellsPerBucketMinValue_16(HandleRef pThis);

	/// <summary>
	/// Specify the average number of cells in each bucket. This is used to
	/// indirectly control the resolution if ComputeResolution is enabled.
	/// </summary>
	public virtual int GetNumberOfCellsPerBucketMinValue()
	{
		return vtkSpanSpace_GetNumberOfCellsPerBucketMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpanSpace_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSpanSpace_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpanSpace_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSpanSpace_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpanSpace_GetResolution_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the resolution N of the span space. The span space can be
	/// envisioned as a rectangular lattice of NXN buckets/bins (i.e., N rows
	/// and N columns), where each bucket stores a list of cell ids. The i-j
	/// coordinate of each cell (hence its location in the lattice) is
	/// determined from the cell's 2-tuple (smin,smax) scalar range.  By default
	/// Resolution = 100, with a clamp of 10,000.
	/// </summary>
	public virtual long GetResolution()
	{
		return vtkSpanSpace_GetResolution_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpanSpace_GetResolutionMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the resolution N of the span space. The span space can be
	/// envisioned as a rectangular lattice of NXN buckets/bins (i.e., N rows
	/// and N columns), where each bucket stores a list of cell ids. The i-j
	/// coordinate of each cell (hence its location in the lattice) is
	/// determined from the cell's 2-tuple (smin,smax) scalar range.  By default
	/// Resolution = 100, with a clamp of 10,000.
	/// </summary>
	public virtual long GetResolutionMaxValue()
	{
		return vtkSpanSpace_GetResolutionMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpanSpace_GetResolutionMinValue_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the resolution N of the span space. The span space can be
	/// envisioned as a rectangular lattice of NXN buckets/bins (i.e., N rows
	/// and N columns), where each bucket stores a list of cell ids. The i-j
	/// coordinate of each cell (hence its location in the lattice) is
	/// determined from the cell's 2-tuple (smin,smax) scalar range.  By default
	/// Resolution = 100, with a clamp of 10,000.
	/// </summary>
	public virtual long GetResolutionMinValue()
	{
		return vtkSpanSpace_GetResolutionMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpanSpace_GetScalarRange_22(HandleRef pThis);

	/// <summary>
	/// Specify the scalar range in terms of minimum and maximum values
	/// (smin,smax). These values are used to build the span space. Note that
	/// setting the range can have significant impact on the performance of the
	/// span space as it controls the effective resolution near important
	/// isocontour values. By default the range is computed automatically; turn
	/// off ComputeScalarRange is you wish to manually specify it.
	/// </summary>
	public virtual double[] GetScalarRange()
	{
		IntPtr intPtr = vtkSpanSpace_GetScalarRange_22(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpanSpace_GetScalarRange_23(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the scalar range in terms of minimum and maximum values
	/// (smin,smax). These values are used to build the span space. Note that
	/// setting the range can have significant impact on the performance of the
	/// span space as it controls the effective resolution near important
	/// isocontour values. By default the range is computed automatically; turn
	/// off ComputeScalarRange is you wish to manually specify it.
	/// </summary>
	public virtual void GetScalarRange(IntPtr data)
	{
		vtkSpanSpace_GetScalarRange_23(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpanSpace_InitTraversal_24(HandleRef pThis, double scalarValue);

	/// <summary>
	/// Begin to traverse the cells based on a scalar value. Returned cells will
	/// have scalar values that span the scalar value specified (within the
	/// resolution of the span space). Note this method must be called prior to
	/// parallel or serial traversal since it specifies the scalar value to be
	/// extracted.
	/// </summary>
	public override void InitTraversal(double scalarValue)
	{
		vtkSpanSpace_InitTraversal_24(GetCppThis(), scalarValue);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpanSpace_Initialize_25(HandleRef pThis);

	/// <summary>
	/// Initialize the span space. Frees memory and resets object as
	/// appropriate.
	/// </summary>
	public override void Initialize()
	{
		vtkSpanSpace_Initialize_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpanSpace_IsA_26(HandleRef pThis, string type);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSpanSpace_IsA_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpanSpace_IsTypeOf_27(string type);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSpanSpace_IsTypeOf_27(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpanSpace_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public new vtkSpanSpace NewInstance()
	{
		vtkSpanSpace result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpanSpace_NewInstance_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSpanSpace)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpanSpace_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public new static vtkSpanSpace SafeDownCast(vtkObjectBase o)
	{
		vtkSpanSpace vtkSpanSpace2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpanSpace_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSpanSpace2 = (vtkSpanSpace)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSpanSpace2.Register(null);
			}
		}
		return vtkSpanSpace2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpanSpace_SetBatchSize_31(HandleRef pThis, long _arg);

	/// <summary>
	/// Set/Get the size of the cell batches when processing in
	/// parallel. By default the batch size = 100 cells in each batch.
	/// </summary>
	public virtual void SetBatchSize(long _arg)
	{
		vtkSpanSpace_SetBatchSize_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpanSpace_SetComputeResolution_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether the resolution of span space is computed
	/// automatically from the average number of cells falling in each bucket.
	/// </summary>
	public virtual void SetComputeResolution(int _arg)
	{
		vtkSpanSpace_SetComputeResolution_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpanSpace_SetComputeScalarRange_33(HandleRef pThis, int _arg);

	/// <summary>
	/// This boolean controls whether the determination of the scalar range is
	/// computed from the input scalar data. By default this is enabled.
	/// </summary>
	public virtual void SetComputeScalarRange(int _arg)
	{
		vtkSpanSpace_SetComputeScalarRange_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpanSpace_SetNumberOfCellsPerBucket_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the average number of cells in each bucket. This is used to
	/// indirectly control the resolution if ComputeResolution is enabled.
	/// </summary>
	public virtual void SetNumberOfCellsPerBucket(int _arg)
	{
		vtkSpanSpace_SetNumberOfCellsPerBucket_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpanSpace_SetResolution_35(HandleRef pThis, long _arg);

	/// <summary>
	/// Set/Get the resolution N of the span space. The span space can be
	/// envisioned as a rectangular lattice of NXN buckets/bins (i.e., N rows
	/// and N columns), where each bucket stores a list of cell ids. The i-j
	/// coordinate of each cell (hence its location in the lattice) is
	/// determined from the cell's 2-tuple (smin,smax) scalar range.  By default
	/// Resolution = 100, with a clamp of 10,000.
	/// </summary>
	public virtual void SetResolution(long _arg)
	{
		vtkSpanSpace_SetResolution_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpanSpace_SetScalarRange_36(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Specify the scalar range in terms of minimum and maximum values
	/// (smin,smax). These values are used to build the span space. Note that
	/// setting the range can have significant impact on the performance of the
	/// span space as it controls the effective resolution near important
	/// isocontour values. By default the range is computed automatically; turn
	/// off ComputeScalarRange is you wish to manually specify it.
	/// </summary>
	public virtual void SetScalarRange(double _arg1, double _arg2)
	{
		vtkSpanSpace_SetScalarRange_36(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpanSpace_SetScalarRange_37(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the scalar range in terms of minimum and maximum values
	/// (smin,smax). These values are used to build the span space. Note that
	/// setting the range can have significant impact on the performance of the
	/// span space as it controls the effective resolution near important
	/// isocontour values. By default the range is computed automatically; turn
	/// off ComputeScalarRange is you wish to manually specify it.
	/// </summary>
	public void SetScalarRange(IntPtr _arg)
	{
		vtkSpanSpace_SetScalarRange_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpanSpace_ShallowCopy_38(HandleRef pThis, HandleRef stree);

	/// <summary>
	/// This method is used to copy data members when cloning an instance of the
	/// class. It does not copy heavy data.
	/// </summary>
	public override void ShallowCopy(vtkScalarTree stree)
	{
		vtkSpanSpace_ShallowCopy_38(GetCppThis(), stree?.GetCppThis() ?? default(HandleRef));
	}
}
