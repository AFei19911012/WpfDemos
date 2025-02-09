using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractStructuredGridHelper
/// </summary>
/// <remarks>
///    helper for extracting/sub-sampling
///  structured datasets.
///
///
/// vtkExtractStructuredGridHelper provides some common functionality that is
/// used by filters that extract and sub-sample structured data. Specifically,
/// it provides functionality for calculating the mapping from the output extent
/// of each process to the input extent.
///
/// </remarks>
/// <seealso>
///
/// vtkExtractGrid vtkExtractVOI vtkExtractRectilinearGrid
/// </seealso>
public class vtkExtractStructuredGridHelper : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractStructuredGridHelper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractStructuredGridHelper()
	{
		MRClassNameKey = "class vtkExtractStructuredGridHelper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractStructuredGridHelper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractStructuredGridHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractStructuredGridHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractStructuredGridHelper New()
	{
		vtkExtractStructuredGridHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractStructuredGridHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractStructuredGridHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExtractStructuredGridHelper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractStructuredGridHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractStructuredGridHelper_ComputeBeginAndEnd_01(HandleRef pThis, IntPtr inExt, IntPtr voi, IntPtr begin, IntPtr end);

	/// <summary>
	/// \brief Returns the begin &amp; end extent that intersects with the VOI
	/// \param inExt the input extent
	/// \param voi the volume of interest
	/// \param begin the begin extent
	/// \param end the end extent
	/// </summary>
	public void ComputeBeginAndEnd(IntPtr inExt, IntPtr voi, IntPtr begin, IntPtr end)
	{
		vtkExtractStructuredGridHelper_ComputeBeginAndEnd_01(GetCppThis(), inExt, voi, begin, end);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractStructuredGridHelper_CopyCellData_02(HandleRef pThis, IntPtr inExt, IntPtr outExt, HandleRef cd, HandleRef outCD);

	/// <summary>
	/// \brief Copies the cell data to the output.
	/// \param inExt the input grid extent.
	/// \param outExt the output grid extent.
	/// \param cd the input cell data.
	/// \param outCD the output cell data.
	/// \pre cd != nullptr.
	/// \pre outCD != nullptr.
	/// </summary>
	public void CopyCellData(IntPtr inExt, IntPtr outExt, vtkCellData cd, vtkCellData outCD)
	{
		vtkExtractStructuredGridHelper_CopyCellData_02(GetCppThis(), inExt, outExt, cd?.GetCppThis() ?? default(HandleRef), outCD?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractStructuredGridHelper_CopyPointsAndPointData_03(HandleRef pThis, IntPtr inExt, IntPtr outExt, HandleRef pd, HandleRef inpnts, HandleRef outPD, HandleRef outpnts);

	/// <summary>
	/// \brief Copies the points &amp; point data to the output.
	/// \param inExt the input grid extent.
	/// \param outExt the output grid extent.
	/// \param pd pointer to the input point data.
	/// \param inpnts pointer to the input points, or nullptr if uniform grid.
	/// \param outPD point to the output point data.
	/// \param outpnts pointer to the output points, or nullptr if uniform grid.
	/// \pre pd != nullptr.
	/// \pre outPD != nullptr.
	/// </summary>
	public void CopyPointsAndPointData(IntPtr inExt, IntPtr outExt, vtkPointData pd, vtkPoints inpnts, vtkPointData outPD, vtkPoints outpnts)
	{
		vtkExtractStructuredGridHelper_CopyPointsAndPointData_03(GetCppThis(), inExt, outExt, pd?.GetCppThis() ?? default(HandleRef), inpnts?.GetCppThis() ?? default(HandleRef), outPD?.GetCppThis() ?? default(HandleRef), outpnts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractStructuredGridHelper_GetMappedExtentValue_04(HandleRef pThis, int dim, int outExtVal);

	/// <summary>
	/// \brief Given a dimension and output extent value, return the corresponding
	/// input extent value. This method should be used to convert extent values.
	/// \param dim the data dimension.
	/// \param outExtVal The output extent value along the given dimension.
	/// \pre dim &gt;= 0 &amp;&amp; dim &lt; 3
	/// \pre outExtVal &gt;= this-&gt;GetOutputWholeExtent()[2*dim] &amp;&amp;
	/// outExtVal &lt;= this-&gt;GetOutputWholeExtent()[2*dim+1]
	/// \return The input extent value along the given dimension.
	/// \sa GetMappedIndex
	/// \sa GetMappedExtentValueFromIndex
	/// </summary>
	public int GetMappedExtentValue(int dim, int outExtVal)
	{
		return vtkExtractStructuredGridHelper_GetMappedExtentValue_04(GetCppThis(), dim, outExtVal);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractStructuredGridHelper_GetMappedExtentValueFromIndex_05(HandleRef pThis, int dim, int outIdx);

	/// <summary>
	/// \brief Given a dimension and output extent index, return the corresponding
	/// input extent value. This method should be used to compute extent values
	/// from extent indices.
	/// \param dim the data dimension.
	/// \param outIdx The output index along the given dimension.
	/// \pre dim &gt;= 0 &amp;&amp; dim &lt; 3
	/// \pre outIdx &gt;= 0 &amp;&amp; outIdx &lt; this-&gt;GetSize( dim )
	/// \return The input extent value along the given dimension.
	/// \sa GetMappedIndex
	/// \sa GetMappedExtentValue
	/// </summary>
	public int GetMappedExtentValueFromIndex(int dim, int outIdx)
	{
		return vtkExtractStructuredGridHelper_GetMappedExtentValueFromIndex_05(GetCppThis(), dim, outIdx);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractStructuredGridHelper_GetMappedIndex_06(HandleRef pThis, int dim, int outIdx);

	/// <summary>
	/// \brief Given a dimension and output index, return the corresponding
	/// extent index. This method should be used to convert array indices,
	/// such as the coordinate arrays for rectilinear grids.
	/// \param dim the data dimension
	/// \param outIdx The output index along the given dimension.
	/// \pre dim &gt;= 0 &amp;&amp; dim &lt; 3
	/// \pre outIdx &gt;= 0 &amp;&amp; outIdx &lt; this-&gt;GetSize( dim )
	/// \return The input extent index along the given dimension.
	/// \sa GetMappedExtentValue
	/// \sa GetMappedExtentValueFromIndex
	/// </summary>
	public int GetMappedIndex(int dim, int outIdx)
	{
		return vtkExtractStructuredGridHelper_GetMappedIndex_06(GetCppThis(), dim, outIdx);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractStructuredGridHelper_GetMappedIndexFromExtentValue_07(HandleRef pThis, int dim, int outExtVal);

	/// <summary>
	/// \brief Given a dimension and output extent value, return the corresponding
	/// input extent index. This method should be used to compute extent
	/// indices from extent values.
	/// \param dim the data dimension
	/// \param outExtVal The output extent value along the given dimension.
	/// \pre dim &gt;= 0 &amp;&amp; dim &lt; 3
	/// \pre outExtVal &gt;= this-&gt;GetOutputWholeExtent()[2*dim] &amp;&amp;
	/// outExtVal &lt;= this-&gt;GetOutputWholeExtent()[2*dim+1]
	/// \return The input extent index along the given dimension.
	/// \sa GetMappedExtentValue
	/// \sa GetMappedExtentValueFromIndex
	/// </summary>
	public int GetMappedIndexFromExtentValue(int dim, int outExtVal)
	{
		return vtkExtractStructuredGridHelper_GetMappedIndexFromExtentValue_07(GetCppThis(), dim, outExtVal);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractStructuredGridHelper_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractStructuredGridHelper_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractStructuredGridHelper_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractStructuredGridHelper_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractStructuredGridHelper_GetOutputWholeExtent_10(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int[] GetOutputWholeExtent()
	{
		IntPtr intPtr = vtkExtractStructuredGridHelper_GetOutputWholeExtent_10(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractStructuredGridHelper_GetOutputWholeExtent_11(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void GetOutputWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkExtractStructuredGridHelper_GetOutputWholeExtent_11(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractStructuredGridHelper_GetOutputWholeExtent_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void GetOutputWholeExtent(IntPtr _arg)
	{
		vtkExtractStructuredGridHelper_GetOutputWholeExtent_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractStructuredGridHelper_GetPartitionedOutputExtent_13(IntPtr globalVOI, IntPtr partitionedVOI, IntPtr outputWholeExtent, IntPtr sampleRate, byte includeBoundary, IntPtr partitionedOutputExtent);

	/// <summary>
	/// Calculate the partitioned output extent for a partitioned structured
	/// dataset. This method sets \a partitionedOutputExtent to the correct extent
	/// of an extracted dataset, such that it properly fits with the other
	/// partitioned pieces while considering the \a globalVOI, the
	/// \a sampleRate, and the boundary conditions.
	/// \param globalVOI The full VOI for the entire distributed dataset.
	/// \param partitionedVOI The VOI used in the serial extraction.
	/// \param outputWholeExtent The output extent of the full dataset.
	/// \param sampleRate The sampling rate in each dimension.
	/// \param includeBoundary Whether or not to include the boundary of the VOI,
	/// even if it doesn't fit the spacing.
	/// \param partitionedOutputExtent The correct output extent of the extracted
	/// dataset.
	/// </summary>
	public static void GetPartitionedOutputExtent(IntPtr globalVOI, IntPtr partitionedVOI, IntPtr outputWholeExtent, IntPtr sampleRate, bool includeBoundary, IntPtr partitionedOutputExtent)
	{
		vtkExtractStructuredGridHelper_GetPartitionedOutputExtent_13(globalVOI, partitionedVOI, outputWholeExtent, sampleRate, (byte)(includeBoundary ? 1u : 0u), partitionedOutputExtent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractStructuredGridHelper_GetPartitionedVOI_14(IntPtr globalVOI, IntPtr partitionedExtent, IntPtr sampleRate, byte includeBoundary, IntPtr partitionedVOI);

	/// <summary>
	/// Calculate the VOI for a partitioned structured dataset. This method sets
	/// \a partitionedVOI to the VOI that extracts as much of the
	/// \a partitionedExtent as possible while considering the \a globalVOI, the
	/// \a sampleRate, and the boundary conditions.
	/// \param globalVOI The full VOI for the entire distributed dataset.
	/// \param partitionedExtent Extent of the process's partitioned input data.
	/// \param sampleRate The sampling rate in each dimension.
	/// \param includeBoundary Whether or not to include the boundary of the VOI,
	/// even if it doesn't fit the spacing.
	/// \param partitionedVOI The extent of the process's partitioned dataset that
	/// should be extracted by a serial extraction filter.
	/// </summary>
	public static void GetPartitionedVOI(IntPtr globalVOI, IntPtr partitionedExtent, IntPtr sampleRate, bool includeBoundary, IntPtr partitionedVOI)
	{
		vtkExtractStructuredGridHelper_GetPartitionedVOI_14(globalVOI, partitionedExtent, sampleRate, (byte)(includeBoundary ? 1u : 0u), partitionedVOI);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractStructuredGridHelper_GetSize_15(HandleRef pThis, int dim);

	/// <summary>
	/// \brief Returns the size along a given dimension
	/// \param dim the dimension in query
	/// \pre dim &gt;= 0 &amp;&amp; dim &lt; 3
	/// </summary>
	public int GetSize(int dim)
	{
		return vtkExtractStructuredGridHelper_GetSize_15(GetCppThis(), dim);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractStructuredGridHelper_Initialize_16(HandleRef pThis, IntPtr voi, IntPtr wholeExt, IntPtr sampleRate, byte includeBoundary);

	/// <summary>
	/// \brief Initializes the index map.
	/// \param voi the extent of the volume of interest
	/// \param wholeExt the whole extent of the domain
	/// \param sampleRate the sampling rate
	/// \param includeBoundary indicates whether to include the boundary or not.
	/// </summary>
	public void Initialize(IntPtr voi, IntPtr wholeExt, IntPtr sampleRate, bool includeBoundary)
	{
		vtkExtractStructuredGridHelper_Initialize_16(GetCppThis(), voi, wholeExt, sampleRate, (byte)(includeBoundary ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractStructuredGridHelper_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractStructuredGridHelper_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractStructuredGridHelper_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractStructuredGridHelper_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractStructuredGridHelper_IsValid_19(HandleRef pThis);

	/// <summary>
	/// Returns true if the helper is properly initialized.
	/// </summary>
	public bool IsValid()
	{
		return (vtkExtractStructuredGridHelper_IsValid_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractStructuredGridHelper_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractStructuredGridHelper NewInstance()
	{
		vtkExtractStructuredGridHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractStructuredGridHelper_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractStructuredGridHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractStructuredGridHelper_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractStructuredGridHelper SafeDownCast(vtkObjectBase o)
	{
		vtkExtractStructuredGridHelper vtkExtractStructuredGridHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractStructuredGridHelper_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractStructuredGridHelper2 = (vtkExtractStructuredGridHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractStructuredGridHelper2.Register(null);
			}
		}
		return vtkExtractStructuredGridHelper2;
	}
}
