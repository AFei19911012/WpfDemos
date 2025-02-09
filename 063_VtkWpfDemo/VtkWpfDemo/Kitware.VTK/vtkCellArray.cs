using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCellArray
/// </summary>
/// <remarks>
///    object to represent cell connectivity
///
/// vtkCellArray stores dataset topologies as an explicit connectivity table
/// listing the point ids that make up each cell.
///
/// Internally, the connectivity table is represented as two arrays: Offsets and
/// Connectivity.
///
/// Offsets is an array of [numCells+1] values indicating the index in the
/// Connectivity array where each cell's points start. The last value is always
/// the length of the Connectivity array.
///
/// The Connectivity array stores the lists of point ids for each cell.
///
/// Thus, for a dataset consisting of 2 triangles, a quad, and a line, the
/// internal arrays will appear as follows:
///
/// ```
/// Topology:
/// ---------
/// Cell 0: Triangle | point ids: {0, 1, 2}
/// Cell 1: Triangle | point ids: {5, 7, 2}
/// Cell 2: Quad     | point ids: {3, 4, 6, 7}
/// Cell 4: Line     | point ids: {5, 8}
///
/// vtkCellArray (current):
/// -----------------------
/// Offsets:      {0, 3, 6, 10, 12}
/// Connectivity: {0, 1, 2, 5, 7, 2, 3, 4, 6, 7, 5, 8}
/// ```
///
/// While this class provides traversal methods (the legacy InitTraversal(),
/// GetNextCell() methods, and the newer method GetCellAtId()) these are in
/// general not thread-safe. Whenever possible it is preferable to use a
/// local thread-safe, vtkCellArrayIterator object, which can be obtained via:
///
/// ```
/// auto iter = vtk::TakeSmartPointer(cellArray-&gt;NewIterator());
/// for (iter-&gt;GoToFirstCell(); !iter-&gt;IsDoneWithTraversal(); iter-&gt;GoToNextCell())
/// {
///   // do work with iter
/// }
/// ```
/// (Note however that depending on the type and structure of internal
/// storage, a cell array iterator may be significantly slower than direct
/// traversal over the cell array due to extra data copying. Factors of 3-4X
/// are not uncommon. See vtkCellArrayIterator for more information. Also note
/// that an iterator may become invalid if the internal vtkCellArray storage
/// is modified.)
///
/// Other methods are also available for allocation and memory-related
/// management; insertion of new cells into the vtkCellArray; and limited
/// editing operations such as replacing one cell with a new cell of the
/// same size.
///
/// The internal arrays may store either 32- or 64-bit values, though most of
/// the API will prefer to use vtkIdType to refer to items in these
/// arrays. This enables significant memory savings when vtkIdType is 64-bit,
/// but 32 bits are sufficient to store all of the values in the connectivity
/// table. Using 64-bit storage with a 32-bit vtkIdType is permitted, but
/// values too large to fit in a 32-bit signed integer will be truncated when
/// accessed through the API. (The particular internal storage type has
/// implications on performance depending on vtkIdType. If the internal
/// storage is equivalent to vtkIdType, then methods that return pointers to
/// arrays of point ids can share the internal storage; otherwise a copy of
/// internal memory must be performed.)
///
/// Methods for managing the storage type are:
///
/// - `bool IsStorage64Bit()`
/// - `bool IsStorageShareable() // Can pointers to internal storage be shared`
/// - `void Use32BitStorage()`
/// - `void Use64BitStorage()`
/// - `void UseDefaultStorage() // Depends on vtkIdType`
/// - `bool CanConvertTo32BitStorage()`
/// - `bool CanConvertTo64BitStorage()`
/// - `bool CanConvertToDefaultStorage() // Depends on vtkIdType`
/// - `bool ConvertTo32BitStorage()`
/// - `bool ConvertTo64BitStorage()`
/// - `bool ConvertToDefaultStorage() // Depends on vtkIdType`
/// - `bool ConvertToSmallestStorage() // Depends on current values in arrays`
///
/// Note that some legacy methods are still available that reflect the
/// previous storage format of this data, which embedded the cell sizes into
/// the Connectivity array:
///
/// ```
/// vtkCellArray (legacy):
/// ----------------------
/// Connectivity: {3, 0, 1, 2, 3, 5, 7, 2, 4, 3, 4, 6, 7, 2, 5, 8}
///                |--Cell 0--||--Cell 1--||----Cell 2---||--C3-|
/// ```
///
/// The methods require an external lookup table to allow random access, which
/// was historically stored in the vtkCellTypes object. The following methods in
/// vtkCellArray still support this style of indexing for compatibility
/// purposes, but these are slow as they must perform some complex computations
/// to convert the old "location" into the new "offset" and should be avoided.
/// These methods (and their modern equivalents) are:
///
/// - GetCell (Prefer GetCellAtId)
/// - GetInsertLocation (Prefer GetNumberOfCells)
/// - GetTraversalLocation (Prefer GetTraversalCellId, or better, NewIterator)
/// - SetTraversalLocation (Prefer SetTraversalLocation, or better, NewIterator)
/// - ReverseCell (Prefer ReverseCellAtId)
/// - ReplaceCell (Prefer ReplaceCellAtId)
/// - SetCells (Use ImportLegacyFormat, or SetData)
/// - GetData (Use ExportLegacyFormat, or Get[Offsets|Connectivity]Array[|32|64])
///
/// Some other legacy methods were completely removed, such as GetPointer() /
/// WritePointer(), since they are cannot be effectively emulated under the
/// current design. If external code needs to support both the old and new
/// version of the vtkCellArray API, the VTK_CELL_ARRAY_V2 preprocessor
/// definition may be used to detect which API is being compiled against.
///
/// </remarks>
/// <seealso>
///  vtkCellTypes vtkCellLinks
/// </seealso>
public class vtkCellArray : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCellArray";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCellArray()
	{
		MRClassNameKey = "class vtkCellArray";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellArray"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCellArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and
	/// printing.
	/// </summary>
	public new static vtkCellArray New()
	{
		vtkCellArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and
	/// printing.
	/// </summary>
	public vtkCellArray()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCellArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCellArray_Allocate_01(HandleRef pThis, long sz, long arg1);

	/// <summary>
	/// Allocate memory.
	///
	/// This currently allocates both the offsets and connectivity arrays to @a sz.
	///
	/// @note It is preferable to use AllocateEstimate(numCells, maxCellSize)
	/// or AllocateExact(numCells, connectivitySize) instead.
	/// </summary>
	public int Allocate(long sz, long arg1)
	{
		return vtkCellArray_Allocate_01(GetCppThis(), sz, arg1);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellArray_AllocateCopy_02(HandleRef pThis, HandleRef other);

	/// <summary>
	/// @brief Pre-allocate memory in internal data structures to match the used
	/// size of the input vtkCellArray. Does not change
	/// the number of cells, only the array capacities. Existing data is NOT
	/// preserved.
	/// @param other The vtkCellArray to use as a reference.
	/// @return True if allocation succeeds.
	/// @sa Squeeze AllocateEstimate AllocateExact
	/// </summary>
	public bool AllocateCopy(vtkCellArray other)
	{
		return (vtkCellArray_AllocateCopy_02(GetCppThis(), other?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellArray_AllocateEstimate_03(HandleRef pThis, long numCells, long maxCellSize);

	/// <summary>
	/// @brief Pre-allocate memory in internal data structures. Does not change
	/// the number of cells, only the array capacities. Existing data is NOT
	/// preserved.
	/// @param numCells The number of expected cells in the dataset.
	/// @param maxCellSize The number of points per cell to allocate memory for.
	/// @return True if allocation succeeds.
	/// @sa Squeeze AllocateExact AllocateCopy
	/// </summary>
	public bool AllocateEstimate(long numCells, long maxCellSize)
	{
		return (vtkCellArray_AllocateEstimate_03(GetCppThis(), numCells, maxCellSize) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellArray_AllocateExact_04(HandleRef pThis, long numCells, long connectivitySize);

	/// <summary>
	/// @brief Pre-allocate memory in internal data structures. Does not change
	/// the number of cells, only the array capacities. Existing data is NOT
	/// preserved.
	/// @param numCells The number of expected cells in the dataset.
	/// @param connectivitySize The total number of pointIds stored for all cells.
	/// @return True if allocation succeeds.
	/// @sa Squeeze AllocateEstimate AllocateCopy
	/// </summary>
	public bool AllocateExact(long numCells, long connectivitySize)
	{
		return (vtkCellArray_AllocateExact_04(GetCppThis(), numCells, connectivitySize) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_Append_05(HandleRef pThis, HandleRef src, long pointOffset);

	/// <summary>
	/// Append cells from src into this. Point ids are offset by @a pointOffset.
	/// </summary>
	public void Append(vtkCellArray src, long pointOffset)
	{
		vtkCellArray_Append_05(GetCppThis(), src?.GetCppThis() ?? default(HandleRef), pointOffset);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_AppendLegacyFormat_06(HandleRef pThis, HandleRef data, long ptOffset);

	/// <summary>
	/// Append an array of data with the legacy vtkCellArray layout, e.g.:
	///
	/// ```
	/// { n0, p0_0, p0_1, ..., p0_n, n1, p1_0, p1_1, ..., p1_n, ... }
	/// ```
	///
	/// where `n0` is the number of points in cell 0, and `pX_Y` is the Y'th point
	/// in cell X.
	/// @{
	/// </summary>
	public void AppendLegacyFormat(vtkIdTypeArray data, long ptOffset)
	{
		vtkCellArray_AppendLegacyFormat_06(GetCppThis(), data?.GetCppThis() ?? default(HandleRef), ptOffset);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_AppendLegacyFormat_07(HandleRef pThis, IntPtr data, long len, long ptOffset);

	/// <summary>
	/// Append an array of data with the legacy vtkCellArray layout, e.g.:
	///
	/// ```
	/// { n0, p0_0, p0_1, ..., p0_n, n1, p1_0, p1_1, ..., p1_n, ... }
	/// ```
	///
	/// where `n0` is the number of points in cell 0, and `pX_Y` is the Y'th point
	/// in cell X.
	/// @{
	/// </summary>
	public void AppendLegacyFormat(IntPtr data, long len, long ptOffset)
	{
		vtkCellArray_AppendLegacyFormat_07(GetCppThis(), data, len, ptOffset);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellArray_CanConvertTo32BitStorage_08(HandleRef pThis);

	/// <summary>
	/// Check if the existing data can safely be converted to use 32- or 64- bit
	/// storage. Ensures that all values can be converted to the target storage
	/// without truncating.
	/// If selecting default storage, the storage depends on the VTK_USE_64BIT_IDS
	/// setting.
	/// @{
	/// </summary>
	public bool CanConvertTo32BitStorage()
	{
		return (vtkCellArray_CanConvertTo32BitStorage_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellArray_CanConvertTo64BitStorage_09(HandleRef pThis);

	/// <summary>
	/// Check if the existing data can safely be converted to use 32- or 64- bit
	/// storage. Ensures that all values can be converted to the target storage
	/// without truncating.
	/// If selecting default storage, the storage depends on the VTK_USE_64BIT_IDS
	/// setting.
	/// @{
	/// </summary>
	public bool CanConvertTo64BitStorage()
	{
		return (vtkCellArray_CanConvertTo64BitStorage_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellArray_CanConvertToDefaultStorage_10(HandleRef pThis);

	/// <summary>
	/// Check if the existing data can safely be converted to use 32- or 64- bit
	/// storage. Ensures that all values can be converted to the target storage
	/// without truncating.
	/// If selecting default storage, the storage depends on the VTK_USE_64BIT_IDS
	/// setting.
	/// @{
	/// </summary>
	public bool CanConvertToDefaultStorage()
	{
		return (vtkCellArray_CanConvertToDefaultStorage_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellArray_ConvertTo32BitStorage_11(HandleRef pThis);

	/// <summary>
	/// Convert internal data structures to use 32- or 64-bit storage.
	///
	/// If selecting default storage, the storage depends on the VTK_USE_64BIT_IDS
	/// setting.
	///
	/// If selecting smallest storage, the data is checked to see what the smallest
	/// safe storage for the existing data is, and then converts to it.
	///
	/// Existing data is preserved.
	///
	/// @return True on success, false on failure. If this algorithm fails, the
	/// cell array will be in an unspecified state.
	///
	/// @{
	/// </summary>
	public bool ConvertTo32BitStorage()
	{
		return (vtkCellArray_ConvertTo32BitStorage_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellArray_ConvertTo64BitStorage_12(HandleRef pThis);

	/// <summary>
	/// Convert internal data structures to use 32- or 64-bit storage.
	///
	/// If selecting default storage, the storage depends on the VTK_USE_64BIT_IDS
	/// setting.
	///
	/// If selecting smallest storage, the data is checked to see what the smallest
	/// safe storage for the existing data is, and then converts to it.
	///
	/// Existing data is preserved.
	///
	/// @return True on success, false on failure. If this algorithm fails, the
	/// cell array will be in an unspecified state.
	///
	/// @{
	/// </summary>
	public bool ConvertTo64BitStorage()
	{
		return (vtkCellArray_ConvertTo64BitStorage_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellArray_ConvertToDefaultStorage_13(HandleRef pThis);

	/// <summary>
	/// Convert internal data structures to use 32- or 64-bit storage.
	///
	/// If selecting default storage, the storage depends on the VTK_USE_64BIT_IDS
	/// setting.
	///
	/// If selecting smallest storage, the data is checked to see what the smallest
	/// safe storage for the existing data is, and then converts to it.
	///
	/// Existing data is preserved.
	///
	/// @return True on success, false on failure. If this algorithm fails, the
	/// cell array will be in an unspecified state.
	///
	/// @{
	/// </summary>
	public bool ConvertToDefaultStorage()
	{
		return (vtkCellArray_ConvertToDefaultStorage_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellArray_ConvertToSmallestStorage_14(HandleRef pThis);

	/// <summary>
	/// Convert internal data structures to use 32- or 64-bit storage.
	///
	/// If selecting default storage, the storage depends on the VTK_USE_64BIT_IDS
	/// setting.
	///
	/// If selecting smallest storage, the data is checked to see what the smallest
	/// safe storage for the existing data is, and then converts to it.
	///
	/// Existing data is preserved.
	///
	/// @return True on success, false on failure. If this algorithm fails, the
	/// cell array will be in an unspecified state.
	///
	/// @{
	/// </summary>
	public bool ConvertToSmallestStorage()
	{
		return (vtkCellArray_ConvertToSmallestStorage_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_DeepCopy_15(HandleRef pThis, HandleRef ca);

	/// <summary>
	/// Perform a deep copy (no reference counting) of the given cell array.
	/// </summary>
	public void DeepCopy(vtkCellArray ca)
	{
		vtkCellArray_DeepCopy_15(GetCppThis(), ca?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArray_EstimateSize_16(HandleRef pThis, long numCells, int maxPtsPerCell);

	/// <summary>
	/// Utility routines help manage memory of cell array. EstimateSize()
	/// returns a value used to initialize and allocate memory for array based
	/// on number of cells and maximum number of points making up cell.  If
	/// every cell is the same size (in terms of number of points), then the
	/// memory estimate is guaranteed exact. (If not exact, use Squeeze() to
	/// reclaim any extra memory.)
	///
	/// @note This method was often misused (e.g. called alone and then
	/// discarding the result). Use AllocateEstimate directly instead.
	/// </summary>
	public long EstimateSize(long numCells, int maxPtsPerCell)
	{
		return vtkCellArray_EstimateSize_16(GetCppThis(), numCells, maxPtsPerCell);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_ExportLegacyFormat_17(HandleRef pThis, HandleRef data);

	/// <summary>
	/// Fill @a data with the old-style vtkCellArray data layout, e.g.
	///
	/// ```
	/// { n0, p0_0, p0_1, ..., p0_n, n1, p1_0, p1_1, ..., p1_n, ... }
	/// ```
	///
	/// where `n0` is the number of points in cell 0, and `pX_Y` is the Y'th point
	/// in cell X.
	/// </summary>
	public void ExportLegacyFormat(vtkIdTypeArray data)
	{
		vtkCellArray_ExportLegacyFormat_17(GetCppThis(), data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkCellArray_GetActualMemorySize_18(HandleRef pThis);

	/// <summary>
	/// Return the memory in kibibytes (1024 bytes) consumed by this cell array. Used to
	/// support streaming and reading/writing data. The value returned is
	/// guaranteed to be greater than or equal to the memory required to
	/// actually represent the data represented by this object. The
	/// information returned is valid only after the pipeline has
	/// been updated.
	/// </summary>
	public uint GetActualMemorySize()
	{
		return vtkCellArray_GetActualMemorySize_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_GetCell_19(HandleRef pThis, long loc, HandleRef pts);

	/// <summary>
	/// Internal method used to retrieve a cell given a legacy offset location.
	///
	/// @note The location-based API is now a super-slow compatibility layer.
	/// Prefer GetCellAtId.
	/// </summary>
	public void GetCell(long loc, vtkIdList pts)
	{
		vtkCellArray_GetCell_19(GetCppThis(), loc, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_GetCellAtId_20(HandleRef pThis, long cellId, HandleRef pts);

	/// <summary>
	/// Return the point ids for the cell at @a cellId. This always copies
	/// the cell ids (i.e., the list of points @a pts into the supplied
	/// vtkIdList). This method is thread safe.
	/// </summary>
	public void GetCellAtId(long cellId, vtkIdList pts)
	{
		vtkCellArray_GetCellAtId_20(GetCppThis(), cellId, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArray_GetCellSize_21(HandleRef pThis, long cellId);

	/// <summary>
	/// Return the size of the cell at @a cellId.
	/// </summary>
	public long GetCellSize(long cellId)
	{
		return vtkCellArray_GetCellSize_21(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellArray_GetConnectivityArray_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the array used to store the point ids that define the cells'
	/// connectivity. The 32/64 variants are only valid when IsStorage64Bit()
	/// returns the appropriate value.
	/// @{
	/// </summary>
	public vtkDataArray GetConnectivityArray()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellArray_GetConnectivityArray_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellArray_GetConnectivityArray32_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the array used to store the point ids that define the cells'
	/// connectivity. The 32/64 variants are only valid when IsStorage64Bit()
	/// returns the appropriate value.
	/// @{
	/// </summary>
	public vtkTypeInt32Array GetConnectivityArray32()
	{
		vtkTypeInt32Array vtkTypeInt32Array2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellArray_GetConnectivityArray32_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTypeInt32Array2 = (vtkTypeInt32Array)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTypeInt32Array2.Register(null);
			}
		}
		return vtkTypeInt32Array2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellArray_GetConnectivityArray64_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the array used to store the point ids that define the cells'
	/// connectivity. The 32/64 variants are only valid when IsStorage64Bit()
	/// returns the appropriate value.
	/// @{
	/// </summary>
	public vtkTypeInt64Array GetConnectivityArray64()
	{
		vtkTypeInt64Array vtkTypeInt64Array2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellArray_GetConnectivityArray64_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTypeInt64Array2 = (vtkTypeInt64Array)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTypeInt64Array2.Register(null);
			}
		}
		return vtkTypeInt64Array2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellArray_GetData_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the underlying data as a data array.
	///
	/// @warning The returned array is not the actual internal representation used
	/// by vtkCellArray. Modifications to the returned array will not change the
	/// vtkCellArray's topology.
	///
	/// @note Use ExportLegacyFormat, or GetOffsetsArray/GetConnectivityArray
	/// instead.
	/// </summary>
	public vtkIdTypeArray GetData()
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellArray_GetData_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdTypeArray2 = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdTypeArray2.Register(null);
			}
		}
		return vtkIdTypeArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArray_GetInsertLocation_26(HandleRef pThis, int npts);

	/// <summary>
	/// Computes the current legacy insertion location within the internal array.
	/// Used in conjunction with GetCell(int loc,...).
	///
	/// @note The location-based API is now a super-slow compatibility layer.
	/// </summary>
	public long GetInsertLocation(int npts)
	{
		return vtkCellArray_GetInsertLocation_26(GetCppThis(), npts);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellArray_GetMaxCellSize_27(HandleRef pThis);

	/// <summary>
	/// Returns the size of the largest cell. The size is the number of points
	/// defining the cell.
	/// </summary>
	public int GetMaxCellSize()
	{
		return vtkCellArray_GetMaxCellSize_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellArray_GetNextCell_28(HandleRef pThis, HandleRef pts);

	/// <summary>
	/// @warning This method is not thread-safe. Consider using the NewIterator()
	/// iterator instead.
	///
	/// GetNextCell() gets the next cell in the list. If end of list is
	/// encountered, 0 is returned.
	///
	/// @note This method is not thread-safe and has tricky syntax to use
	/// correctly. Prefer the use of vtkCellArrayIterator (see NewIterator()).
	/// </summary>
	public int GetNextCell(vtkIdList pts)
	{
		return vtkCellArray_GetNextCell_28(GetCppThis(), pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArray_GetNumberOfCells_29(HandleRef pThis);

	/// <summary>
	/// Get the number of cells in the array.
	/// </summary>
	public long GetNumberOfCells()
	{
		return vtkCellArray_GetNumberOfCells_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArray_GetNumberOfConnectivityEntries_30(HandleRef pThis);

	/// <summary>
	/// Return the size of the array that would be returned from
	/// ExportLegacyFormat().
	///
	/// @note Method incompatible with current internal storage.
	/// </summary>
	public long GetNumberOfConnectivityEntries()
	{
		return vtkCellArray_GetNumberOfConnectivityEntries_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArray_GetNumberOfConnectivityIds_31(HandleRef pThis);

	/// <summary>
	/// Get the size of the connectivity array that stores the point ids.
	/// @note Do not confuse this with the deprecated
	/// GetNumberOfConnectivityEntries(), which refers to the legacy memory
	/// layout.
	/// </summary>
	public long GetNumberOfConnectivityIds()
	{
		return vtkCellArray_GetNumberOfConnectivityIds_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArray_GetNumberOfGenerationsFromBase_32(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and
	/// printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCellArray_GetNumberOfGenerationsFromBase_32(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArray_GetNumberOfGenerationsFromBaseType_33(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and
	/// printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCellArray_GetNumberOfGenerationsFromBaseType_33(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArray_GetNumberOfOffsets_34(HandleRef pThis);

	/// <summary>
	/// Get the number of elements in the offsets array. This will be the number of
	/// cells + 1.
	/// </summary>
	public long GetNumberOfOffsets()
	{
		return vtkCellArray_GetNumberOfOffsets_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArray_GetOffset_35(HandleRef pThis, long cellId);

	/// <summary>
	/// Get the offset (into the connectivity) for a specified cell id.
	/// </summary>
	public long GetOffset(long cellId)
	{
		return vtkCellArray_GetOffset_35(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellArray_GetOffsetsArray_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the array used to store cell offsets. The 32/64 variants are only
	/// valid when IsStorage64Bit() returns the appropriate value.
	/// @{
	/// </summary>
	public vtkDataArray GetOffsetsArray()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellArray_GetOffsetsArray_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellArray_GetOffsetsArray32_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the array used to store cell offsets. The 32/64 variants are only
	/// valid when IsStorage64Bit() returns the appropriate value.
	/// @{
	/// </summary>
	public vtkTypeInt32Array GetOffsetsArray32()
	{
		vtkTypeInt32Array vtkTypeInt32Array2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellArray_GetOffsetsArray32_37(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTypeInt32Array2 = (vtkTypeInt32Array)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTypeInt32Array2.Register(null);
			}
		}
		return vtkTypeInt32Array2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellArray_GetOffsetsArray64_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the array used to store cell offsets. The 32/64 variants are only
	/// valid when IsStorage64Bit() returns the appropriate value.
	/// @{
	/// </summary>
	public vtkTypeInt64Array GetOffsetsArray64()
	{
		vtkTypeInt64Array vtkTypeInt64Array2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellArray_GetOffsetsArray64_38(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTypeInt64Array2 = (vtkTypeInt64Array)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTypeInt64Array2.Register(null);
			}
		}
		return vtkTypeInt64Array2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArray_GetSize_39(HandleRef pThis);

	/// <summary>
	/// Get the size of the allocated connectivity array.
	///
	/// @warning This returns the allocated capacity of the internal arrays as a
	/// number of elements, NOT the number of elements in use.
	///
	/// @note Method incompatible with current internal storage.
	/// </summary>
	public long GetSize()
	{
		return vtkCellArray_GetSize_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArray_GetTraversalCellId_40(HandleRef pThis);

	/// <summary>
	/// Get/Set the current cellId for traversal.
	///
	/// @note This method is not thread-safe and has tricky syntax to use
	/// correctly. Prefer the use of vtkCellArrayIterator (see NewIterator()).
	/// @{
	/// </summary>
	public long GetTraversalCellId()
	{
		return vtkCellArray_GetTraversalCellId_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArray_GetTraversalLocation_41(HandleRef pThis);

	/// <summary>
	/// Get/Set the current traversal legacy location.
	///
	/// @note The location-based API is now a super-slow compatibility layer.
	/// Prefer Get/SetTraversalCellId.
	/// @{
	/// </summary>
	public long GetTraversalLocation()
	{
		return vtkCellArray_GetTraversalLocation_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArray_GetTraversalLocation_42(HandleRef pThis, long npts);

	/// <summary>
	/// Get/Set the current traversal legacy location.
	///
	/// @note The location-based API is now a super-slow compatibility layer.
	/// Prefer Get/SetTraversalCellId.
	/// @{
	/// </summary>
	public long GetTraversalLocation(long npts)
	{
		return vtkCellArray_GetTraversalLocation_42(GetCppThis(), npts);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_ImportLegacyFormat_43(HandleRef pThis, HandleRef data);

	/// <summary>
	/// Import an array of data with the legacy vtkCellArray layout, e.g.:
	///
	/// ```
	/// { n0, p0_0, p0_1, ..., p0_n, n1, p1_0, p1_1, ..., p1_n, ... }
	/// ```
	///
	/// where `n0` is the number of points in cell 0, and `pX_Y` is the Y'th point
	/// in cell X.
	/// @{
	/// </summary>
	public void ImportLegacyFormat(vtkIdTypeArray data)
	{
		vtkCellArray_ImportLegacyFormat_43(GetCppThis(), data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_ImportLegacyFormat_44(HandleRef pThis, IntPtr data, long len);

	/// <summary>
	/// Import an array of data with the legacy vtkCellArray layout, e.g.:
	///
	/// ```
	/// { n0, p0_0, p0_1, ..., p0_n, n1, p1_0, p1_1, ..., p1_n, ... }
	/// ```
	///
	/// where `n0` is the number of points in cell 0, and `pX_Y` is the Y'th point
	/// in cell X.
	/// @{
	/// </summary>
	public void ImportLegacyFormat(IntPtr data, long len)
	{
		vtkCellArray_ImportLegacyFormat_44(GetCppThis(), data, len);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_InitTraversal_45(HandleRef pThis);

	/// <summary>
	/// @warning This method is not thread-safe. Consider using the NewIterator()
	/// iterator instead.
	///
	/// InitTraversal() initializes the traversal of the list of cells.
	///
	/// @note This method is not thread-safe and has tricky syntax to use
	/// correctly. Prefer the use of vtkCellArrayIterator (see NewIterator()).
	/// </summary>
	public void InitTraversal()
	{
		vtkCellArray_InitTraversal_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_Initialize_46(HandleRef pThis);

	/// <summary>
	/// Free any memory and reset to an empty state.
	/// </summary>
	public void Initialize()
	{
		vtkCellArray_Initialize_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_InsertCellPoint_47(HandleRef pThis, long id);

	/// <summary>
	/// Used in conjunction with InsertNextCell(npts) to add another point
	/// to the list of cells.
	/// </summary>
	public void InsertCellPoint(long id)
	{
		vtkCellArray_InsertCellPoint_47(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArray_InsertNextCell_48(HandleRef pThis, HandleRef cell);

	/// <summary>
	/// Insert a cell object. Return the cell id of the cell.
	/// </summary>
	public long InsertNextCell(vtkCell cell)
	{
		return vtkCellArray_InsertNextCell_48(GetCppThis(), cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArray_InsertNextCell_49(HandleRef pThis, long npts, IntPtr pts);

	/// <summary>
	/// Create a cell by specifying the number of points and an array of point
	/// id's.  Return the cell id of the cell.
	/// </summary>
	public long InsertNextCell(long npts, IntPtr pts)
	{
		return vtkCellArray_InsertNextCell_49(GetCppThis(), npts, pts);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArray_InsertNextCell_50(HandleRef pThis, HandleRef pts);

	/// <summary>
	/// Create a cell by specifying a list of point ids. Return the cell id of
	/// the cell.
	/// </summary>
	public long InsertNextCell(vtkIdList pts)
	{
		return vtkCellArray_InsertNextCell_50(GetCppThis(), pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArray_InsertNextCell_51(HandleRef pThis, int npts);

	/// <summary>
	/// Create cells by specifying a count of total points to be inserted, and
	/// then adding points one at a time using method InsertCellPoint(). If you
	/// don't know the count initially, use the method UpdateCellCount() to
	/// complete the cell. Return the cell id of the cell.
	/// </summary>
	public long InsertNextCell(int npts)
	{
		return vtkCellArray_InsertNextCell_51(GetCppThis(), npts);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellArray_IsA_52(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and
	/// printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCellArray_IsA_52(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArray_IsHomogeneous_53(HandleRef pThis);

	/// <summary>
	/// Check if all cells have the same number of vertices.
	///
	/// The return value is coded as:
	/// * -1 = heterogeneous
	/// * 0 = Cell array empty
	/// * n (positive integer) = homogeneous array of cell size n
	/// </summary>
	public long IsHomogeneous()
	{
		return vtkCellArray_IsHomogeneous_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellArray_IsStorage64Bit_54(HandleRef pThis);

	/// <summary>
	/// @return True if the internal storage is using 64 bit arrays. If false,
	/// the storage is using 32 bit arrays.
	/// </summary>
	public bool IsStorage64Bit()
	{
		return (vtkCellArray_IsStorage64Bit_54(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellArray_IsStorageShareable_55(HandleRef pThis);

	/// <summary>
	/// @return True if the internal storage can be shared as a
	/// pointer to vtkIdType, i.e., the type and organization of internal
	/// storage is such that copying of data can be avoided, and instead
	/// a pointer to vtkIdType can be used.
	/// </summary>
	public bool IsStorageShareable()
	{
		return (vtkCellArray_IsStorageShareable_55(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellArray_IsTypeOf_56(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and
	/// printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCellArray_IsTypeOf_56(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellArray_IsValid_57(HandleRef pThis);

	/// <summary>
	/// Check that internal storage is consistent and in a valid state.
	///
	/// Specifically, this function returns true if and only if:
	/// - The offset and connectivity arrays have exactly one component.
	/// - The offset array has at least one value and starts at 0.
	/// - The offset array values never decrease.
	/// - The connectivity array has as many entries as the last value in the
	///   offset array.
	/// </summary>
	public bool IsValid()
	{
		return (vtkCellArray_IsValid_57(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellArray_NewInstance_59(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and
	/// printing.
	/// </summary>
	public new vtkCellArray NewInstance()
	{
		vtkCellArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellArray_NewInstance_59(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellArray_NewIterator_60(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// @brief NewIterator returns a new instance of vtkCellArrayIterator that
	/// is initialized to point at the first cell's data. The caller is responsible
	/// for Delete()'ing the object.
	/// </summary>
	public vtkCellArrayIterator NewIterator()
	{
		vtkCellArrayIterator vtkCellArrayIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellArray_NewIterator_60(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellArrayIterator2 = (vtkCellArrayIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellArrayIterator2.Register(null);
			}
		}
		return vtkCellArrayIterator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_ReplaceCell_61(HandleRef pThis, long loc, int npts, IntPtr pts);

	/// <summary>
	/// Replace the point ids of the cell at the legacy location with a different
	/// list of point ids. Calling this method does not mark the vtkCellArray as
	/// modified. This is the responsibility of the caller and may be done after
	/// multiple calls to ReplaceCell. This call does not support changing the
	/// number of points in the cell -- the caller must ensure that the target
	/// cell has npts points.
	///
	/// @note The location-based API is now a super-slow compatibility layer.
	/// Prefer ReplaceCellAtId.
	/// </summary>
	public void ReplaceCell(long loc, int npts, IntPtr pts)
	{
		vtkCellArray_ReplaceCell_61(GetCppThis(), loc, npts, pts);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_ReplaceCellAtId_62(HandleRef pThis, long cellId, HandleRef list);

	/// <summary>
	/// Replaces the point ids for the specified cell with the supplied list.
	///
	/// @warning This can ONLY replace the cell if the size does not change.
	/// Attempting to change cell size through this method will have undefined
	/// results.
	/// @{
	/// </summary>
	public void ReplaceCellAtId(long cellId, vtkIdList list)
	{
		vtkCellArray_ReplaceCellAtId_62(GetCppThis(), cellId, list?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_ReplaceCellAtId_63(HandleRef pThis, long cellId, long cellSize, IntPtr cellPoints);

	/// <summary>
	/// Replaces the point ids for the specified cell with the supplied list.
	///
	/// @warning This can ONLY replace the cell if the size does not change.
	/// Attempting to change cell size through this method will have undefined
	/// results.
	/// @{
	/// </summary>
	public void ReplaceCellAtId(long cellId, long cellSize, IntPtr cellPoints)
	{
		vtkCellArray_ReplaceCellAtId_63(GetCppThis(), cellId, cellSize, cellPoints);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_ReplaceCellPointAtId_64(HandleRef pThis, long cellId, long cellPointIndex, long newPointId);

	/// <summary>
	/// Replaces the pointId at cellPointIndex of a cell with newPointId.
	///
	/// @warning This can ONLY replace the cell if the size does not change.
	/// Attempting to change cell size through this method will have undefined
	/// results.
	/// </summary>
	public void ReplaceCellPointAtId(long cellId, long cellPointIndex, long newPointId)
	{
		vtkCellArray_ReplaceCellPointAtId_64(GetCppThis(), cellId, cellPointIndex, newPointId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_Reset_65(HandleRef pThis);

	/// <summary>
	/// Reuse list. Reset to initial state without freeing memory.
	/// </summary>
	public void Reset()
	{
		vtkCellArray_Reset_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellArray_ResizeExact_66(HandleRef pThis, long numCells, long connectivitySize);

	/// <summary>
	/// @brief ResizeExact() resizes the internal structures to hold @a numCells
	/// total cell offsets and @a connectivitySize total pointIds. Old data is
	/// preserved, and newly-available memory is not initialized.
	///
	/// @warning For advanced use only. You probably want an Allocate method.
	///
	/// @return True if allocation succeeds.
	/// </summary>
	public bool ResizeExact(long numCells, long connectivitySize)
	{
		return (vtkCellArray_ResizeExact_66(GetCppThis(), numCells, connectivitySize) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_ReverseCell_67(HandleRef pThis, long loc);

	/// <summary>
	/// Special method inverts ordering of cell at the specified legacy location.
	/// Must be called carefully or the cell topology may be corrupted.
	///
	/// @note The location-based API is now a super-slow compatibility layer.
	/// Prefer ReverseCellAtId;
	/// </summary>
	public void ReverseCell(long loc)
	{
		vtkCellArray_ReverseCell_67(GetCppThis(), loc);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_ReverseCellAtId_68(HandleRef pThis, long cellId);

	/// <summary>
	/// Reverses the order of the point ids for the specified cell.
	/// </summary>
	public void ReverseCellAtId(long cellId)
	{
		vtkCellArray_ReverseCellAtId_68(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellArray_SafeDownCast_69(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and
	/// printing.
	/// </summary>
	public new static vtkCellArray SafeDownCast(vtkObjectBase o)
	{
		vtkCellArray vtkCellArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellArray_SafeDownCast_69(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellArray2 = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellArray2.Register(null);
			}
		}
		return vtkCellArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_SetCells_70(HandleRef pThis, long ncells, HandleRef cells);

	/// <summary>
	/// Define multiple cells by providing a connectivity list. The list is in
	/// the form (npts,p0,p1,...p(npts-1), repeated for each cell). Be careful
	/// using this method because it discards the old cells, and anything
	/// referring these cells becomes invalid (for example, if BuildCells() has
	/// been called see vtkPolyData).  The traversal location is reset to the
	/// beginning of the list; the insertion location is set to the end of the
	/// list.
	///
	/// @warning The vtkCellArray will not hold a reference to `cells`. This
	/// function merely calls ImportLegacyFormat.
	///
	/// @note Use ImportLegacyFormat or SetData instead.
	/// </summary>
	public void SetCells(long ncells, vtkIdTypeArray cells)
	{
		vtkCellArray_SetCells_70(GetCppThis(), ncells, cells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_SetData_71(HandleRef pThis, HandleRef offsets, HandleRef connectivity);

	/// <summary>
	/// Set the internal data arrays to the supplied offsets and connectivity
	/// arrays.
	///
	/// Note that the input arrays may be copied and not used directly. To avoid
	/// copying, use vtkIdTypeArray, vtkCellArray::ArrayType32, or
	/// vtkCellArray::ArrayType64.
	///
	/// @{
	/// </summary>
	public void SetData(vtkTypeInt32Array offsets, vtkTypeInt32Array connectivity)
	{
		vtkCellArray_SetData_71(GetCppThis(), offsets?.GetCppThis() ?? default(HandleRef), connectivity?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_SetData_72(HandleRef pThis, HandleRef offsets, HandleRef connectivity);

	/// <summary>
	/// Set the internal data arrays to the supplied offsets and connectivity
	/// arrays.
	///
	/// Note that the input arrays may be copied and not used directly. To avoid
	/// copying, use vtkIdTypeArray, vtkCellArray::ArrayType32, or
	/// vtkCellArray::ArrayType64.
	///
	/// @{
	/// </summary>
	public void SetData(vtkTypeInt64Array offsets, vtkTypeInt64Array connectivity)
	{
		vtkCellArray_SetData_72(GetCppThis(), offsets?.GetCppThis() ?? default(HandleRef), connectivity?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_SetData_73(HandleRef pThis, HandleRef offsets, HandleRef connectivity);

	/// <summary>
	/// Set the internal data arrays to the supplied offsets and connectivity
	/// arrays.
	///
	/// Note that the input arrays may be copied and not used directly. To avoid
	/// copying, use vtkIdTypeArray, vtkCellArray::ArrayType32, or
	/// vtkCellArray::ArrayType64.
	///
	/// @{
	/// </summary>
	public void SetData(vtkIdTypeArray offsets, vtkIdTypeArray connectivity)
	{
		vtkCellArray_SetData_73(GetCppThis(), offsets?.GetCppThis() ?? default(HandleRef), connectivity?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellArray_SetData_74(HandleRef pThis, HandleRef offsets, HandleRef connectivity);

	/// <summary>
	/// Sets the internal arrays to the supplied offsets and connectivity arrays.
	///
	/// This is a convenience method, and may fail if the following conditions
	/// are not met:
	///
	/// - Both arrays must be of the same type.
	/// - The array type must be one of the types in InputArrayList.
	///
	/// If invalid arrays are passed in, an error is logged and the function
	/// will return false.
	/// </summary>
	public bool SetData(vtkDataArray offsets, vtkDataArray connectivity)
	{
		return (vtkCellArray_SetData_74(GetCppThis(), offsets?.GetCppThis() ?? default(HandleRef), connectivity?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellArray_SetData_75(HandleRef pThis, long cellSize, HandleRef connectivity);

	/// <summary>
	/// Sets the internal arrays to the supported connectivity array with an
	/// offsets array automatically generated given the fixed cells size.
	///
	/// This is a convenience method, and may fail if the following conditions
	/// are not met:
	///
	/// - The `connectivity` array must be one of the types in InputArrayList.
	/// - The `connectivity` array size must be a multiple of `cellSize`.
	///
	/// If invalid arrays are passed in, an error is logged and the function
	/// will return false.
	/// </summary>
	public bool SetData(long cellSize, vtkDataArray connectivity)
	{
		return (vtkCellArray_SetData_75(GetCppThis(), cellSize, connectivity?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_SetNumberOfCells_76(HandleRef pThis, long arg0);

	/// <summary>
	/// Set the number of cells in the array.
	/// DO NOT do any kind of allocation, advanced use only.
	///
	/// @note This call has no effect.
	/// </summary>
	public virtual void SetNumberOfCells(long arg0)
	{
		vtkCellArray_SetNumberOfCells_76(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_SetTraversalCellId_77(HandleRef pThis, long cellId);

	/// <summary>
	/// Get/Set the current cellId for traversal.
	///
	/// @note This method is not thread-safe and has tricky syntax to use
	/// correctly. Prefer the use of vtkCellArrayIterator (see NewIterator()).
	/// @{
	/// </summary>
	public void SetTraversalCellId(long cellId)
	{
		vtkCellArray_SetTraversalCellId_77(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_SetTraversalLocation_78(HandleRef pThis, long loc);

	/// <summary>
	/// Get/Set the current traversal legacy location.
	///
	/// @note The location-based API is now a super-slow compatibility layer.
	/// Prefer Get/SetTraversalCellId.
	/// @{
	/// </summary>
	public void SetTraversalLocation(long loc)
	{
		vtkCellArray_SetTraversalLocation_78(GetCppThis(), loc);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_ShallowCopy_79(HandleRef pThis, HandleRef ca);

	/// <summary>
	/// Shallow copy @a ca into this cell array.
	/// </summary>
	public void ShallowCopy(vtkCellArray ca)
	{
		vtkCellArray_ShallowCopy_79(GetCppThis(), ca?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_Squeeze_80(HandleRef pThis);

	/// <summary>
	/// Reclaim any extra memory while preserving data.
	///
	/// @sa ConvertToSmallestStorage
	/// </summary>
	public void Squeeze()
	{
		vtkCellArray_Squeeze_80(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_UpdateCellCount_81(HandleRef pThis, int npts);

	/// <summary>
	/// Used in conjunction with InsertNextCell(int npts) and InsertCellPoint() to
	/// update the number of points defining the cell.
	/// </summary>
	public void UpdateCellCount(int npts)
	{
		vtkCellArray_UpdateCellCount_81(GetCppThis(), npts);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_Use32BitStorage_82(HandleRef pThis);

	/// <summary>
	/// Initialize internal data structures to use 32- or 64-bit storage.
	/// If selecting default storage, the storage depends on the VTK_USE_64BIT_IDS
	/// setting.
	///
	/// All existing data is erased.
	/// @{
	/// </summary>
	public void Use32BitStorage()
	{
		vtkCellArray_Use32BitStorage_82(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_Use64BitStorage_83(HandleRef pThis);

	/// <summary>
	/// Initialize internal data structures to use 32- or 64-bit storage.
	/// If selecting default storage, the storage depends on the VTK_USE_64BIT_IDS
	/// setting.
	///
	/// All existing data is erased.
	/// @{
	/// </summary>
	public void Use64BitStorage()
	{
		vtkCellArray_Use64BitStorage_83(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArray_UseDefaultStorage_84(HandleRef pThis);

	/// <summary>
	/// Initialize internal data structures to use 32- or 64-bit storage.
	/// If selecting default storage, the storage depends on the VTK_USE_64BIT_IDS
	/// setting.
	///
	/// All existing data is erased.
	/// @{
	/// </summary>
	public void UseDefaultStorage()
	{
		vtkCellArray_UseDefaultStorage_84(GetCppThis());
	}
}
