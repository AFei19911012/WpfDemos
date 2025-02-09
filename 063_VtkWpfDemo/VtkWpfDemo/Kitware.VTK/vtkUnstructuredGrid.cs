using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUnstructuredGrid
/// </summary>
/// <remarks>
///    dataset represents arbitrary combinations of
/// all possible cell types
///
/// vtkUnstructuredGrid is a data object that is a concrete implementation of
/// vtkDataSet. vtkUnstructuredGrid represents any combinations of any cell
/// types. This includes 0D (e.g., points), 1D (e.g., lines, polylines), 2D
/// (e.g., triangles, polygons), and 3D (e.g., hexahedron, tetrahedron,
/// polyhedron, etc.). vtkUnstructuredGrid provides random access to cells, as
/// well as topological information (such as lists of cells using each point).
/// </remarks>
public class vtkUnstructuredGrid : vtkUnstructuredGridBase
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGrid";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUnstructuredGrid()
	{
		MRClassNameKey = "class vtkUnstructuredGrid";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGrid"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUnstructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard instantiation method.
	/// </summary>
	public new static vtkUnstructuredGrid New()
	{
		vtkUnstructuredGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard instantiation method.
	/// </summary>
	public vtkUnstructuredGrid()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkUnstructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkUnstructuredGrid_AddReferenceToCell_01(HandleRef pThis, long ptId, long cellId);

	/// <summary>
	/// Use these methods only if the dataset has been specified as
	/// Editable. See vtkPointSet for more information.
	/// </summary>
	public void AddReferenceToCell(long ptId, long cellId)
	{
		vtkUnstructuredGrid_AddReferenceToCell_01(GetCppThis(), ptId, cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_Allocate_02(HandleRef pThis, long numCells, int arg1);

	/// <summary>
	/// Method allocates initial storage for the cell connectivity. Use this
	/// method before the method InsertNextCell(). The array capacity is
	/// doubled when the inserting a cell exceeds the current capacity.
	/// extSize is no longer used.
	///
	/// @note Prefer AllocateExact or AllocateEstimate, which give more control
	/// over how allocations are distributed.
	/// </summary>
	public override void Allocate(long numCells, int arg1)
	{
		vtkUnstructuredGrid_Allocate_02(GetCppThis(), numCells, arg1);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUnstructuredGrid_AllocateEstimate_03(HandleRef pThis, long numCells, long maxCellSize);

	/// <summary>
	/// @brief Pre-allocate memory in internal data structures. Does not change
	/// the number of cells, only the array capacities. Existing data is NOT
	/// preserved.
	/// @param numCells The number of expected cells in the dataset.
	/// @param maxCellSize The number of points per cell to allocate memory for.
	/// @return True if allocation succeeds.
	/// @sa Squeeze();
	/// </summary>
	public bool AllocateEstimate(long numCells, long maxCellSize)
	{
		return (vtkUnstructuredGrid_AllocateEstimate_03(GetCppThis(), numCells, maxCellSize) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUnstructuredGrid_AllocateExact_04(HandleRef pThis, long numCells, long connectivitySize);

	/// <summary>
	/// @brief Pre-allocate memory in internal data structures. Does not change
	/// the number of cells, only the array capacities. Existing data is NOT
	/// preserved.
	/// @param numCells The number of expected cells in the dataset.
	/// @param connectivitySize The total number of pointIds stored for all cells.
	/// @return True if allocation succeeds.
	/// @sa Squeeze();
	/// </summary>
	public bool AllocateExact(long numCells, long connectivitySize)
	{
		return (vtkUnstructuredGrid_AllocateExact_04(GetCppThis(), numCells, connectivitySize) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_BuildLinks_05(HandleRef pThis);

	/// <summary>
	/// Build topological links from points to lists of cells that use each point.
	/// See vtkAbstractCellLinks for more information.
	/// </summary>
	public void BuildLinks()
	{
		vtkUnstructuredGrid_BuildLinks_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_ConvertFaceStreamPointIds_06(HandleRef faceStream, IntPtr idMap);

	/// <summary>
	/// Convert pid in a face stream into idMap[pid]. The face stream is of format
	/// [nCellFaces, nFace0Pts, i, j, k, nFace1Pts, i, j, k, ...]. The user is
	/// responsible to make sure all the Ids in faceStream do not exceed the
	/// range of idMap.
	/// </summary>
	public static void ConvertFaceStreamPointIds(vtkIdList faceStream, IntPtr idMap)
	{
		vtkUnstructuredGrid_ConvertFaceStreamPointIds_06(faceStream?.GetCppThis() ?? default(HandleRef), idMap);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_ConvertFaceStreamPointIds_07(long nfaces, IntPtr faceStream, IntPtr idMap);

	/// <summary>
	/// Convert pid in a face stream into idMap[pid]. The face stream is of format
	/// [nFace0Pts, i, j, k, nFace1Pts, i, j, k, ...]. The user is responsible to
	/// make sure all the Ids in faceStream do not exceed the range of idMap.
	/// </summary>
	public static void ConvertFaceStreamPointIds(long nfaces, IntPtr faceStream, IntPtr idMap)
	{
		vtkUnstructuredGrid_ConvertFaceStreamPointIds_07(nfaces, faceStream, idMap);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_CopyStructure_08(HandleRef pThis, HandleRef ds);

	/// <summary>
	/// Standard vtkDataSet methods; see vtkDataSet.h for documentation.
	/// </summary>
	public override void CopyStructure(vtkDataSet ds)
	{
		vtkUnstructuredGrid_CopyStructure_08(GetCppThis(), ds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_DecomposeAPolyhedronCell_09(HandleRef polyhedronCellArray, ref long nCellpts, ref long nCellfaces, HandleRef cellArray, HandleRef faces);

	/// <summary>
	/// A static method for converting a polyhedron vtkCellArray of format
	/// [nCellFaces, nFace0Pts, i, j, k, nFace1Pts, i, j, k, ...]
	/// into three components: (1) an integer indicating the number of faces
	/// (2) a standard vtkCellArray storing point ids [nCell0Pts, i, j, k]
	/// and (3) an vtkIdTypeArray storing face connectivity in format
	/// [nFace0Pts, i, j, k, nFace1Pts, i, j, k, ...]
	/// Note: input is assumed to contain only one polyhedron cell.
	/// Outputs (2) and (3) will be stacked at the end of the input
	/// cellArray and faces. The original data in the input will not
	/// be touched.
	/// </summary>
	public static void DecomposeAPolyhedronCell(vtkCellArray polyhedronCellArray, ref long nCellpts, ref long nCellfaces, vtkCellArray cellArray, vtkIdTypeArray faces)
	{
		vtkUnstructuredGrid_DecomposeAPolyhedronCell_09(polyhedronCellArray?.GetCppThis() ?? default(HandleRef), ref nCellpts, ref nCellfaces, cellArray?.GetCppThis() ?? default(HandleRef), faces?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_DecomposeAPolyhedronCell_10(IntPtr polyhedronCellStream, ref long nCellpts, ref long nCellfaces, HandleRef cellArray, HandleRef faces);

	/// <summary>
	/// A static method for converting a polyhedron vtkCellArray of format
	/// [nCellFaces, nFace0Pts, i, j, k, nFace1Pts, i, j, k, ...]
	/// into three components: (1) an integer indicating the number of faces
	/// (2) a standard vtkCellArray storing point ids [nCell0Pts, i, j, k]
	/// and (3) an vtkIdTypeArray storing face connectivity in format
	/// [nFace0Pts, i, j, k, nFace1Pts, i, j, k, ...]
	/// Note: input is assumed to contain only one polyhedron cell.
	/// Outputs (2) and (3) will be stacked at the end of the input
	/// cellArray and faces. The original data in the input will not
	/// be touched.
	/// </summary>
	public static void DecomposeAPolyhedronCell(IntPtr polyhedronCellStream, ref long nCellpts, ref long nCellfaces, vtkCellArray cellArray, vtkIdTypeArray faces)
	{
		vtkUnstructuredGrid_DecomposeAPolyhedronCell_10(polyhedronCellStream, ref nCellpts, ref nCellfaces, cellArray?.GetCppThis() ?? default(HandleRef), faces?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_DecomposeAPolyhedronCell_11(long nCellFaces, IntPtr inFaceStream, ref long nCellpts, HandleRef cellArray, HandleRef faces);

	/// <summary>
	/// A static method for converting an input polyhedron cell stream of format
	/// [nFace0Pts, i, j, k, nFace1Pts, i, j, k, ...]
	/// into three components: (1) an integer indicating the number of faces
	/// (2) a standard vtkCellArray storing point ids [nCell0Pts, i, j, k]
	/// and (3) an vtkIdTypeArray storing face connectivity in format
	/// [nFace0Pts, i, j, k, nFace1Pts, i, j, k, ...]
	/// Note: input is assumed to contain only one polyhedron cell.
	/// Outputs (2) and (3) will be stacked at the end of the input
	/// cellArray and faces. The original data in the input will not
	/// be touched.
	/// </summary>
	public static void DecomposeAPolyhedronCell(long nCellFaces, IntPtr inFaceStream, ref long nCellpts, vtkCellArray cellArray, vtkIdTypeArray faces)
	{
		vtkUnstructuredGrid_DecomposeAPolyhedronCell_11(nCellFaces, inFaceStream, ref nCellpts, cellArray?.GetCppThis() ?? default(HandleRef), faces?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_DeepCopy_12(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void DeepCopy(vtkDataObject src)
	{
		vtkUnstructuredGrid_DeepCopy_12(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGrid_ExtendedNew_13(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard instantiation method.
	/// </summary>
	public new static vtkUnstructuredGrid ExtendedNew()
	{
		vtkUnstructuredGrid vtkUnstructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGrid_ExtendedNew_13(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGrid2 = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGrid2.Register(null);
			}
		}
		return vtkUnstructuredGrid2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkUnstructuredGrid_GetActualMemorySize_14(HandleRef pThis);

	/// <summary>
	/// Return the actual size of the data in kibibytes (1024 bytes). This number
	/// is valid only after the pipeline has updated. The memory size
	/// returned is guaranteed to be greater than or equal to the
	/// memory required to represent the data (e.g., extra space in
	/// arrays, etc. are not included in the return value). THIS METHOD
	/// IS THREAD SAFE.
	/// </summary>
	public override uint GetActualMemorySize()
	{
		return vtkUnstructuredGrid_GetActualMemorySize_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGrid_GetCell_15(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkDataSet methods; see vtkDataSet.h for documentation.
	/// </summary>
	public override vtkCell GetCell(long cellId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGrid_GetCell_15(GetCppThis(), cellId, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_GetCell_16(HandleRef pThis, long cellId, HandleRef cell);

	/// <summary>
	/// Standard vtkDataSet methods; see vtkDataSet.h for documentation.
	/// </summary>
	public override void GetCell(long cellId, vtkGenericCell cell)
	{
		vtkUnstructuredGrid_GetCell_16(GetCppThis(), cellId, cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_GetCellBounds_17(HandleRef pThis, long cellId, IntPtr bounds);

	/// <summary>
	/// Standard vtkDataSet methods; see vtkDataSet.h for documentation.
	/// </summary>
	public override void GetCellBounds(long cellId, IntPtr bounds)
	{
		vtkUnstructuredGrid_GetCellBounds_17(GetCppThis(), cellId, bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGrid_GetCellLinks_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the cell links. The cell links will be one of nullptr=0;
	/// vtkCellLinks=1; vtkStaticCellLinksTemplate&lt;VTK_UNSIGNED_SHORT&gt;=2;
	/// vtkStaticCellLinksTemplate&lt;VTK_UNSIGNED_INT&gt;=3;
	/// vtkStaticCellLinksTemplate&lt;VTK_ID_TYPE&gt;=4.  (See enum types defined in
	/// vtkAbstractCellLinks.)
	/// </summary>
	public vtkAbstractCellLinks GetCellLinks()
	{
		vtkAbstractCellLinks vtkAbstractCellLinks2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGrid_GetCellLinks_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractCellLinks2 = (vtkAbstractCellLinks)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractCellLinks2.Register(null);
			}
		}
		return vtkAbstractCellLinks2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGrid_GetCellLocationsArray_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the array of all the starting indices of cell definitions
	/// in the cell array.
	///
	/// @warning vtkCellArray supports random access now. This array is no
	/// longer used.
	/// </summary>
	public vtkIdTypeArray GetCellLocationsArray()
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGrid_GetCellLocationsArray_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkUnstructuredGrid_GetCellNeighbors_20(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds);

	/// <summary>
	/// A topological inquiry to retrieve all of the cells using list of points
	/// exclusive of the current cell specified (e.g., cellId).  THIS METHOD IS
	/// THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND THE DATASET IS NOT
	/// MODIFIED.
	/// </summary>
	public override void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds)
	{
		vtkUnstructuredGrid_GetCellNeighbors_20(GetCppThis(), cellId, ptIds?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_GetCellNeighbors_21(HandleRef pThis, long cellId, long npts, IntPtr ptIds, HandleRef cellIds);

	/// <summary>
	/// A topological inquiry to retrieve all of the cells using list of points
	/// exclusive of the current cell specified (e.g., cellId).  THIS METHOD IS
	/// THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND THE DATASET IS NOT
	/// MODIFIED.
	/// </summary>
	public void GetCellNeighbors(long cellId, long npts, IntPtr ptIds, vtkIdList cellIds)
	{
		vtkUnstructuredGrid_GetCellNeighbors_21(GetCppThis(), cellId, npts, ptIds, cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_GetCellPoints_22(HandleRef pThis, long cellId, HandleRef ptIds);

	/// <summary>
	/// Standard vtkDataSet methods; see vtkDataSet.h for documentation.
	/// </summary>
	public override void GetCellPoints(long cellId, vtkIdList ptIds)
	{
		vtkUnstructuredGrid_GetCellPoints_22(GetCppThis(), cellId, ptIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGrid_GetCellSize_23(HandleRef pThis, long cellId);

	/// <summary>
	/// Get the size of the cell with given cellId.
	/// </summary>
	public override long GetCellSize(long cellId)
	{
		return vtkUnstructuredGrid_GetCellSize_23(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGrid_GetCellType_24(HandleRef pThis, long cellId);

	/// <summary>
	/// Get the type of the cell with the given cellId.
	/// </summary>
	public override int GetCellType(long cellId)
	{
		return vtkUnstructuredGrid_GetCellType_24(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGrid_GetCellTypesArray_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the array of all cell types in the grid. Each single-component
	/// tuple in the array at an index that corresponds to the type of the cell
	/// with the same index. To get an array of only the distinct cell types in
	/// the dataset, use GetCellTypes().
	/// </summary>
	public vtkUnsignedCharArray GetCellTypesArray()
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGrid_GetCellTypesArray_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGrid_GetCells_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the unstructured grid connectivity array.
	/// </summary>
	public vtkCellArray GetCells()
	{
		vtkCellArray vtkCellArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGrid_GetCells_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkUnstructuredGrid_GetData_27(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkUnstructuredGrid GetData(vtkInformation info)
	{
		vtkUnstructuredGrid vtkUnstructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGrid_GetData_27(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGrid2 = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGrid2.Register(null);
			}
		}
		return vtkUnstructuredGrid2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGrid_GetData_28(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkUnstructuredGrid GetData(vtkInformationVector v, int i)
	{
		vtkUnstructuredGrid vtkUnstructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGrid_GetData_28(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGrid2 = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGrid2.Register(null);
			}
		}
		return vtkUnstructuredGrid2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGrid_GetDataObjectType_29(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkUnstructuredGrid_GetDataObjectType_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGrid_GetDistinctCellTypesArray_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a list of types of cells in a dataset. The list consists of an array
	/// of types (not necessarily in any order), with a single entry per type.
	/// For example a dataset with 5 triangles, 3 lines, and 100 hexahedra would
	/// result in a list of three entries, corresponding to the types VTK_TRIANGLE,
	/// VTK_LINE, and VTK_HEXAHEDRON. This override implements an optimization that
	/// recomputes cell types only when the types of cells may have changed.
	/// This method never returns `nullptr`.
	///
	/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
	/// THE DATASET IS NOT MODIFIED
	/// </summary>
	public vtkUnsignedCharArray GetDistinctCellTypesArray()
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGrid_GetDistinctCellTypesArray_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGrid_GetFaceLocations_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get pointer to faces and facelocations. Support for polyhedron cells.
	/// </summary>
	public vtkIdTypeArray GetFaceLocations()
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGrid_GetFaceLocations_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkUnstructuredGrid_GetFaceStream_32(HandleRef pThis, long cellId, HandleRef ptIds);

	/// <summary>
	/// Get the face stream of a polyhedron cell in the following format:
	/// (numCellFaces, numFace0Pts, id1, id2, id3, numFace1Pts,id1, id2, id3, ...).
	/// If the requested cell is not a polyhedron, then the standard GetCellPoints
	/// is called to return a list of unique point ids (id1, id2, id3, ...).
	/// </summary>
	public void GetFaceStream(long cellId, vtkIdList ptIds)
	{
		vtkUnstructuredGrid_GetFaceStream_32(GetCppThis(), cellId, ptIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGrid_GetFaces_33(HandleRef pThis, long cellId);

	/// <summary>
	/// Special support for polyhedron. Return nullptr for all other cell types.
	/// </summary>
	public IntPtr GetFaces(long cellId)
	{
		return vtkUnstructuredGrid_GetFaces_33(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGrid_GetFaces_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get pointer to faces and facelocations. Support for polyhedron cells.
	/// </summary>
	public vtkIdTypeArray GetFaces()
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGrid_GetFaces_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkUnstructuredGrid_GetGhostLevel_35(HandleRef pThis);

	/// <summary>
	/// Get the ghost level.
	/// </summary>
	public virtual int GetGhostLevel()
	{
		return vtkUnstructuredGrid_GetGhostLevel_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_GetIdsOfCellsOfType_36(HandleRef pThis, int type, HandleRef array);

	/// <summary>
	/// Fill vtkIdTypeArray container with list of cell Ids.  This
	/// method traverses all cells and, for a particular cell type,
	/// inserts the cell Id into the container.
	/// </summary>
	public override void GetIdsOfCellsOfType(int type, vtkIdTypeArray array)
	{
		vtkUnstructuredGrid_GetIdsOfCellsOfType_36(GetCppThis(), type, array?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGrid_GetLinks_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the links that you created possibly without using BuildLinks.
	/// </summary>
	public virtual vtkAbstractCellLinks GetLinks()
	{
		vtkAbstractCellLinks vtkAbstractCellLinks2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGrid_GetLinks_37(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractCellLinks2 = (vtkAbstractCellLinks)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractCellLinks2.Register(null);
			}
		}
		return vtkAbstractCellLinks2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGrid_GetMaxCellSize_38(HandleRef pThis);

	/// <summary>
	/// Get the size, in number of points, of the largest cell.
	/// </summary>
	public override int GetMaxCellSize()
	{
		return vtkUnstructuredGrid_GetMaxCellSize_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkUnstructuredGrid_GetMeshMTime_39(HandleRef pThis);

	/// <summary>
	/// Return the mesh (geometry/topology) modification time.
	/// This time is different from the usual MTime which also takes into
	/// account the modification of data arrays. This function can be used to
	/// track the changes on the mesh separately from the data arrays
	/// (eg. static mesh over time with transient data).
	/// </summary>
	public virtual ulong GetMeshMTime()
	{
		return vtkUnstructuredGrid_GetMeshMTime_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGrid_GetNumberOfCells_40(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet methods; see vtkDataSet.h for documentation.
	/// </summary>
	public override long GetNumberOfCells()
	{
		return vtkUnstructuredGrid_GetNumberOfCells_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGrid_GetNumberOfGenerationsFromBase_41(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUnstructuredGrid_GetNumberOfGenerationsFromBase_41(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGrid_GetNumberOfGenerationsFromBaseType_42(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUnstructuredGrid_GetNumberOfGenerationsFromBaseType_42(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGrid_GetNumberOfPieces_43(HandleRef pThis);

	/// <summary>
	/// Set / Get the piece and the number of pieces. Similar to extent in 3D.
	/// </summary>
	public virtual int GetNumberOfPieces()
	{
		return vtkUnstructuredGrid_GetNumberOfPieces_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGrid_GetPiece_44(HandleRef pThis);

	/// <summary>
	/// Set / Get the piece and the number of pieces. Similar to extent in 3D.
	/// </summary>
	public virtual int GetPiece()
	{
		return vtkUnstructuredGrid_GetPiece_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_GetPointCells_45(HandleRef pThis, long ptId, HandleRef cellIds);

	/// <summary>
	/// Standard vtkDataSet methods; see vtkDataSet.h for documentation.
	/// </summary>
	public override void GetPointCells(long ptId, vtkIdList cellIds)
	{
		vtkUnstructuredGrid_GetPointCells_45(GetCppThis(), ptId, cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_Initialize_46(HandleRef pThis);

	/// <summary>
	/// Reset the grid to an empty state and free any memory.
	/// </summary>
	public override void Initialize()
	{
		vtkUnstructuredGrid_Initialize_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGrid_InitializeFacesRepresentation_47(HandleRef pThis, long numPrevCells);

	/// <summary>
	/// Special function used by vtkUnstructuredGridReader.
	/// By default vtkUnstructuredGrid does not contain face information, which is
	/// only used by polyhedron cells. If so far no polyhedron cells have been
	/// added, Faces and FaceLocations pointers will be nullptr. In this case, need to
	/// initialize the arrays and assign values to the previous non-polyhedron cells.
	/// </summary>
	public int InitializeFacesRepresentation(long numPrevCells)
	{
		return vtkUnstructuredGrid_InitializeFacesRepresentation_47(GetCppThis(), numPrevCells);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGrid_InsertNextLinkedCell_48(HandleRef pThis, int type, int npts, IntPtr pts);

	/// <summary>
	/// Use these methods only if the dataset has been specified as
	/// Editable. See vtkPointSet for more information.
	/// </summary>
	public long InsertNextLinkedCell(int type, int npts, IntPtr pts)
	{
		return vtkUnstructuredGrid_InsertNextLinkedCell_48(GetCppThis(), type, npts, pts);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGrid_IsA_49(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUnstructuredGrid_IsA_49(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUnstructuredGrid_IsCellBoundary_50(HandleRef pThis, long cellId, long npts, IntPtr ptIds);

	/// <summary>
	/// A topological inquiry to determine whether a topological entity (e.g.,
	/// point, edge, or face) defined by the point ids (ptIds of length npts) is
	/// a boundary entity of a specified cell (indicated by cellId). A boundary
	/// entity is a topological feature used by exactly one cell. This method is
	/// related to GetCellNeighbors() except that it simply indicates whether a
	/// topological feature is boundary - hence the method is faster. CellIds in the
	/// second version are used as a temp buffer to avoid allocation internally, and
	/// it's faster. THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A
	/// SINGLE THREAD AND THE DATASET IS NOT MODIFIED.
	/// </summary>
	public bool IsCellBoundary(long cellId, long npts, IntPtr ptIds)
	{
		return (vtkUnstructuredGrid_IsCellBoundary_50(GetCppThis(), cellId, npts, ptIds) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUnstructuredGrid_IsCellBoundary_51(HandleRef pThis, long cellId, long npts, IntPtr ptIds, HandleRef cellIds);

	/// <summary>
	/// A topological inquiry to determine whether a topological entity (e.g.,
	/// point, edge, or face) defined by the point ids (ptIds of length npts) is
	/// a boundary entity of a specified cell (indicated by cellId). A boundary
	/// entity is a topological feature used by exactly one cell. This method is
	/// related to GetCellNeighbors() except that it simply indicates whether a
	/// topological feature is boundary - hence the method is faster. CellIds in the
	/// second version are used as a temp buffer to avoid allocation internally, and
	/// it's faster. THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A
	/// SINGLE THREAD AND THE DATASET IS NOT MODIFIED.
	/// </summary>
	public bool IsCellBoundary(long cellId, long npts, IntPtr ptIds, vtkIdList cellIds)
	{
		return (vtkUnstructuredGrid_IsCellBoundary_51(GetCppThis(), cellId, npts, ptIds, cellIds?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGrid_IsHomogeneous_52(HandleRef pThis);

	/// <summary>
	/// Returns whether cells are all of the same type.
	/// </summary>
	public override int IsHomogeneous()
	{
		return vtkUnstructuredGrid_IsHomogeneous_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGrid_IsTypeOf_53(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUnstructuredGrid_IsTypeOf_53(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGrid_NewCellIterator_55(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkDataSet methods; see vtkDataSet.h for documentation.
	/// </summary>
	public override vtkCellIterator NewCellIterator()
	{
		vtkCellIterator vtkCellIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGrid_NewCellIterator_55(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellIterator2 = (vtkCellIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellIterator2.Register(null);
			}
		}
		return vtkCellIterator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGrid_NewInstance_56(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new vtkUnstructuredGrid NewInstance()
	{
		vtkUnstructuredGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGrid_NewInstance_56(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_RemoveGhostCells_57(HandleRef pThis);

	/// <summary>
	/// This method will remove any cell that is marked as ghost
	/// (has the vtkDataSetAttributes::DUPLICATECELL or
	/// the vtkDataSetAttributes::HIDDENCELL bit set).
	/// </summary>
	public void RemoveGhostCells()
	{
		vtkUnstructuredGrid_RemoveGhostCells_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_RemoveReferenceToCell_58(HandleRef pThis, long ptId, long cellId);

	/// <summary>
	/// Use these methods only if the dataset has been specified as
	/// Editable. See vtkPointSet for more information.
	/// </summary>
	public void RemoveReferenceToCell(long ptId, long cellId)
	{
		vtkUnstructuredGrid_RemoveReferenceToCell_58(GetCppThis(), ptId, cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_Reset_59(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet methods; see vtkDataSet.h for documentation.
	/// </summary>
	public void Reset()
	{
		vtkUnstructuredGrid_Reset_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_ResizeCellList_60(HandleRef pThis, long ptId, int size);

	/// <summary>
	/// Use these methods only if the dataset has been specified as
	/// Editable. See vtkPointSet for more information.
	/// </summary>
	public void ResizeCellList(long ptId, int size)
	{
		vtkUnstructuredGrid_ResizeCellList_60(GetCppThis(), ptId, size);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGrid_SafeDownCast_61(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static vtkUnstructuredGrid SafeDownCast(vtkObjectBase o)
	{
		vtkUnstructuredGrid vtkUnstructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGrid_SafeDownCast_61(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGrid2 = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGrid2.Register(null);
			}
		}
		return vtkUnstructuredGrid2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_SetCells_62(HandleRef pThis, int type, HandleRef cells);

	/// <summary>
	/// Provide cell information to define the dataset.
	///
	/// Cells like vtkPolyhedron require points plus a list of faces. To handle
	/// vtkPolyhedron, SetCells() support a special input cellConnectivities format
	/// (numCellFaces, numFace0Pts, id1, id2, id3, numFace1Pts,id1, id2, id3, ...)
	/// The functions use vtkPolyhedron::DecomposeAPolyhedronCell() to convert
	/// polyhedron cells into standard format.
	/// </summary>
	public void SetCells(int type, vtkCellArray cells)
	{
		vtkUnstructuredGrid_SetCells_62(GetCppThis(), type, cells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_SetCells_63(HandleRef pThis, IntPtr types, HandleRef cells);

	/// <summary>
	/// Provide cell information to define the dataset.
	///
	/// Cells like vtkPolyhedron require points plus a list of faces. To handle
	/// vtkPolyhedron, SetCells() support a special input cellConnectivities format
	/// (numCellFaces, numFace0Pts, id1, id2, id3, numFace1Pts,id1, id2, id3, ...)
	/// The functions use vtkPolyhedron::DecomposeAPolyhedronCell() to convert
	/// polyhedron cells into standard format.
	/// </summary>
	public void SetCells(IntPtr types, vtkCellArray cells)
	{
		vtkUnstructuredGrid_SetCells_63(GetCppThis(), types, cells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_SetCells_64(HandleRef pThis, HandleRef cellTypes, HandleRef cells);

	/// <summary>
	/// Provide cell information to define the dataset.
	///
	/// Cells like vtkPolyhedron require points plus a list of faces. To handle
	/// vtkPolyhedron, SetCells() support a special input cellConnectivities format
	/// (numCellFaces, numFace0Pts, id1, id2, id3, numFace1Pts,id1, id2, id3, ...)
	/// The functions use vtkPolyhedron::DecomposeAPolyhedronCell() to convert
	/// polyhedron cells into standard format.
	/// </summary>
	public void SetCells(vtkUnsignedCharArray cellTypes, vtkCellArray cells)
	{
		vtkUnstructuredGrid_SetCells_64(GetCppThis(), cellTypes?.GetCppThis() ?? default(HandleRef), cells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_SetCells_65(HandleRef pThis, HandleRef cellTypes, HandleRef cells, HandleRef faceLocations, HandleRef faces);

	/// <summary>
	/// Provide cell information to define the dataset.
	///
	/// Cells like vtkPolyhedron require points plus a list of faces. To handle
	/// vtkPolyhedron, SetCells() support a special input cellConnectivities format
	/// (numCellFaces, numFace0Pts, id1, id2, id3, numFace1Pts,id1, id2, id3, ...)
	/// The functions use vtkPolyhedron::DecomposeAPolyhedronCell() to convert
	/// polyhedron cells into standard format.
	/// </summary>
	public void SetCells(vtkUnsignedCharArray cellTypes, vtkCellArray cells, vtkIdTypeArray faceLocations, vtkIdTypeArray faces)
	{
		vtkUnstructuredGrid_SetCells_65(GetCppThis(), cellTypes?.GetCppThis() ?? default(HandleRef), cells?.GetCppThis() ?? default(HandleRef), faceLocations?.GetCppThis() ?? default(HandleRef), faces?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_SetCells_66(HandleRef pThis, HandleRef cellTypes, HandleRef cellLocations, HandleRef cells);

	/// <summary>
	/// Special methods specific to vtkUnstructuredGrid for defining the cells
	/// composing the dataset. Most cells require just arrays of cellTypes,
	/// cellLocations and cellConnectivities which implicitly define the set of
	/// points in each cell and their ordering. In those cases the
	/// cellConnectivities are of the format
	/// (numFace0Pts, id1, id2, id3, numFace1Pts, id1, id2, id3...). However, some
	/// cells like vtkPolyhedron require points plus a list of faces. To handle
	/// vtkPolyhedron, SetCells() support a special input cellConnectivities format
	/// (numCellFaces, numFace0Pts, id1, id2, id3, numFace1Pts,id1, id2, id3, ...)
	/// The functions use vtkPolyhedron::DecomposeAPolyhedronCell() to convert
	/// polyhedron cells into standard format.
	///
	/// @warning The cellLocations array is no longer used; this information
	/// is stored in vtkCellArray. Use the other SetCells overloads.
	/// </summary>
	public void SetCells(vtkUnsignedCharArray cellTypes, vtkIdTypeArray cellLocations, vtkCellArray cells)
	{
		vtkUnstructuredGrid_SetCells_66(GetCppThis(), cellTypes?.GetCppThis() ?? default(HandleRef), cellLocations?.GetCppThis() ?? default(HandleRef), cells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_SetCells_67(HandleRef pThis, HandleRef cellTypes, HandleRef cellLocations, HandleRef cells, HandleRef faceLocations, HandleRef faces);

	/// <summary>
	/// Special methods specific to vtkUnstructuredGrid for defining the cells
	/// composing the dataset. Most cells require just arrays of cellTypes,
	/// cellLocations and cellConnectivities which implicitly define the set of
	/// points in each cell and their ordering. In those cases the
	/// cellConnectivities are of the format
	/// (numFace0Pts, id1, id2, id3, numFace1Pts, id1, id2, id3...). However, some
	/// cells like vtkPolyhedron require points plus a list of faces. To handle
	/// vtkPolyhedron, SetCells() support a special input cellConnectivities format
	/// (numCellFaces, numFace0Pts, id1, id2, id3, numFace1Pts,id1, id2, id3, ...)
	/// The functions use vtkPolyhedron::DecomposeAPolyhedronCell() to convert
	/// polyhedron cells into standard format.
	///
	/// @warning The cellLocations array is no longer used; this information
	/// is stored in vtkCellArray. Use the other SetCells overloads.
	/// </summary>
	public void SetCells(vtkUnsignedCharArray cellTypes, vtkIdTypeArray cellLocations, vtkCellArray cells, vtkIdTypeArray faceLocations, vtkIdTypeArray faces)
	{
		vtkUnstructuredGrid_SetCells_67(GetCppThis(), cellTypes?.GetCppThis() ?? default(HandleRef), cellLocations?.GetCppThis() ?? default(HandleRef), cells?.GetCppThis() ?? default(HandleRef), faceLocations?.GetCppThis() ?? default(HandleRef), faces?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_SetLinks_68(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// Set/Get the links that you created possibly without using BuildLinks.
	/// </summary>
	public virtual void SetLinks(vtkAbstractCellLinks _arg)
	{
		vtkUnstructuredGrid_SetLinks_68(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_ShallowCopy_69(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void ShallowCopy(vtkDataObject src)
	{
		vtkUnstructuredGrid_ShallowCopy_69(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGrid_Squeeze_70(HandleRef pThis);

	/// <summary>
	/// Squeeze all arrays in the grid to conserve memory.
	/// </summary>
	public override void Squeeze()
	{
		vtkUnstructuredGrid_Squeeze_70(GetCppThis());
	}
}
