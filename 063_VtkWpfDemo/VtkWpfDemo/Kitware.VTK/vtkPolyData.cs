using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolyData
/// </summary>
/// <remarks>
///    concrete dataset represents vertices, lines, polygons, and triangle strips
///
/// vtkPolyData is a data object that is a concrete implementation of
/// vtkDataSet. vtkPolyData represents a geometric structure consisting of
/// vertices, lines, polygons, and/or triangle strips. Point and cell
/// attribute values (e.g., scalars, vectors, etc.) also are represented.
///
/// The actual cell types (vtkCellType.h) supported by vtkPolyData are:
/// vtkVertex, vtkPolyVertex, vtkLine, vtkPolyLine, vtkTriangle, vtkQuad,
/// vtkPolygon, and vtkTriangleStrip.
///
/// One important feature of vtkPolyData objects is that special traversal and
/// data manipulation methods are available to process data. These methods are
/// generally more efficient than vtkDataSet methods and should be used
/// whenever possible. For example, traversing the cells in a dataset we would
/// use GetCell(). To traverse cells with vtkPolyData we would retrieve the
/// cell array object representing polygons (for example using GetPolys()) and
/// then use vtkCellArray's InitTraversal() and GetNextCell() methods.
///
/// @warning
/// Because vtkPolyData is implemented with four separate instances of
/// vtkCellArray to represent 0D vertices, 1D lines, 2D polygons, and 2D
/// triangle strips, it is possible to create vtkPolyData instances that
/// consist of a mixture of cell types. Because of the design of the class,
/// there are certain limitations on how mixed cell types are inserted into
/// the vtkPolyData, and in turn the order in which they are processed and
/// rendered. To preserve the consistency of cell ids, and to ensure that
/// cells with cell data are rendered properly, users must insert mixed cells
/// in the order of vertices (vtkVertex and vtkPolyVertex), lines (vtkLine and
/// vtkPolyLine), polygons (vtkTriangle, vtkQuad, vtkPolygon), and triangle
/// strips (vtkTriangleStrip).
///
/// @warning
/// Some filters when processing vtkPolyData with mixed cell types may process
/// the cells in differing ways. Some will convert one type into another
/// (e.g., vtkTriangleStrip into vtkTriangles) or expect a certain type
/// (vtkDecimatePro expects triangles or triangle strips; vtkTubeFilter
/// expects lines). Read the documentation for each filter carefully to
/// understand how each part of vtkPolyData is processed.
///
/// @warning
/// Some of the methods specified here function properly only when the dataset
/// has been specified as "Editable". They are documented as such.
/// </remarks>
public class vtkPolyData : vtkPointSet
{
	/// <summary>
	/// Scalar field critical point classification (for manifold 2D meshes).
	/// Reference: J. Milnor "Morse Theory", Princeton University Press, 1963.
	///
	/// Given a pointId and an attribute representing a scalar field, this member
	/// returns the index of the critical point:
	/// vtkPolyData::MINIMUM (index 0): local minimum;
	/// vtkPolyData::SADDLE  (index 1): local saddle;
	/// vtkPolyData::MAXIMUM (index 2): local maximum.
	///
	/// Other returned values are:
	/// vtkPolyData::REGULAR_POINT: regular point (the gradient does not vanish);
	/// vtkPolyData::ERR_NON_MANIFOLD_STAR: the star of the considered vertex is
	/// not manifold (could not evaluate the index)
	/// vtkPolyData::ERR_INCORRECT_FIELD: the number of entries in the scalar field
	/// array is different form the number of vertices in the mesh.
	/// vtkPolyData::ERR_NO_SUCH_FIELD: the specified scalar field does not exist.
	/// </summary>
	public enum ERR_INCORRECT_FIELD_WrapperEnum
	{
		/// <summary>enum member</summary>
		ERR_INCORRECT_FIELD = -3,
		/// <summary>enum member</summary>
		ERR_NON_MANIFOLD_STAR = -2,
		/// <summary>enum member</summary>
		ERR_NO_SUCH_FIELD = -4,
		/// <summary>enum member</summary>
		MAXIMUM = 2,
		/// <summary>enum member</summary>
		MINIMUM = 0,
		/// <summary>enum member</summary>
		REGULAR_POINT = -1,
		/// <summary>enum member</summary>
		SADDLE = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolyData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolyData()
	{
		MRClassNameKey = "class vtkPolyData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPolyData New()
	{
		vtkPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPolyData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPolyData_AddCellReference_01(HandleRef pThis, long cellId);

	/// <summary>
	/// Add references to cell in cell structure. This means the links from
	/// the cell's points to the cell are modified. Memory is not extended. Use the
	/// method ResizeCellList() to resize the link list from a point to its using
	/// cells. (This operator assumes BuildLinks() has been called.) Use this
	/// method only when the dataset is set as Editable.
	/// </summary>
	public void AddCellReference(long cellId)
	{
		vtkPolyData_AddCellReference_01(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_AddReferenceToCell_02(HandleRef pThis, long ptId, long cellId);

	/// <summary>
	/// Add a reference to a cell in a particular point's link list. (You may also
	/// consider using AddCellReference() to add the references from all the
	/// cell's points to the cell.) This operator does not realloc memory; use the
	/// operator ResizeCellList() to do this if necessary. Use this
	/// method only when the dataset is set as Editable.
	/// </summary>
	public void AddReferenceToCell(long ptId, long cellId)
	{
		vtkPolyData_AddReferenceToCell_02(GetCppThis(), ptId, cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_Allocate_03(HandleRef pThis, long numCells, int arg1);

	/// <summary>
	/// Method allocates initial storage for vertex, line, polygon, and
	/// triangle strip arrays. Use this method before the method
	/// PolyData::InsertNextCell(). (Or, provide vertex, line, polygon, and
	/// triangle strip cell arrays). @a extSize is no longer used.
	/// </summary>
	public void Allocate(long numCells, int arg1)
	{
		vtkPolyData_Allocate_03(GetCppThis(), numCells, arg1);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_Allocate_04(HandleRef pThis, HandleRef inPolyData, long numCells, int arg2);

	/// <summary>
	/// Similar to the method above, this method allocates initial storage for
	/// vertex, line, polygon, and triangle strip arrays. It does this more
	/// intelligently, examining the supplied inPolyData to determine whether to
	/// allocate the verts, lines, polys, and strips arrays.  (These arrays are
	/// allocated only if there is data in the corresponding arrays in the
	/// inPolyData.)  Caution: if the inPolyData has no verts, and after
	/// allocating with this method an PolyData::InsertNextCell() is invoked
	/// where a vertex is inserted, bad things will happen.
	/// </summary>
	public void Allocate(vtkPolyData inPolyData, long numCells, int arg2)
	{
		vtkPolyData_Allocate_04(GetCppThis(), inPolyData?.GetCppThis() ?? default(HandleRef), numCells, arg2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyData_AllocateCopy_05(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Preallocate memory for the internal cell arrays such that they are the
	/// same size as those in @a pd.
	///
	/// Existing data is not preserved and the number of cells is set to zero.
	///
	/// @return True if allocation succeeds.
	/// </summary>
	public bool AllocateCopy(vtkPolyData pd)
	{
		return (vtkPolyData_AllocateCopy_05(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyData_AllocateEstimate_06(HandleRef pThis, long numCells, long maxCellSize);

	/// <summary>
	/// Preallocate memory for the internal cell arrays. Each of the internal
	/// cell arrays (verts, lines, polys, and strips) will be resized to hold
	/// @a numCells cells of size @a maxCellSize.
	///
	/// Existing data is not preserved and the number of cells is set to zero.
	///
	/// @return True if allocation succeeds.
	/// </summary>
	public bool AllocateEstimate(long numCells, long maxCellSize)
	{
		return (vtkPolyData_AllocateEstimate_06(GetCppThis(), numCells, maxCellSize) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyData_AllocateEstimate_07(HandleRef pThis, long numVerts, long maxVertSize, long numLines, long maxLineSize, long numPolys, long maxPolySize, long numStrips, long maxStripSize);

	/// <summary>
	/// Preallocate memory for the internal cell arrays. Each of the internal
	/// cell arrays (verts, lines, polys, and strips) will be resized to hold
	/// the indicated number of cells of the specified cell size.
	///
	/// Existing data is not preserved and the number of cells is set to zero.
	///
	/// @return True if allocation succeeds.
	/// </summary>
	public bool AllocateEstimate(long numVerts, long maxVertSize, long numLines, long maxLineSize, long numPolys, long maxPolySize, long numStrips, long maxStripSize)
	{
		return (vtkPolyData_AllocateEstimate_07(GetCppThis(), numVerts, maxVertSize, numLines, maxLineSize, numPolys, maxPolySize, numStrips, maxStripSize) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyData_AllocateExact_08(HandleRef pThis, long numCells, long connectivitySize);

	/// <summary>
	/// Preallocate memory for the internal cell arrays. Each of the internal
	/// cell arrays (verts, lines, polys, and strips) will be resized to hold
	/// @a numCells cells and @a connectivitySize pointIds.
	///
	/// Existing data is not preserved and the number of cells is set to zero.
	///
	/// @return True if allocation succeeds.
	/// </summary>
	public bool AllocateExact(long numCells, long connectivitySize)
	{
		return (vtkPolyData_AllocateExact_08(GetCppThis(), numCells, connectivitySize) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyData_AllocateExact_09(HandleRef pThis, long numVerts, long vertConnSize, long numLines, long lineConnSize, long numPolys, long polyConnSize, long numStrips, long stripConnSize);

	/// <summary>
	/// Preallocate memory for the internal cell arrays. Each of the internal
	/// cell arrays (verts, lines, polys, and strips) will be resized to hold
	/// the indicated number of cells and the specified number of point ids
	/// (ConnSize).
	///
	/// Existing data is not preserved and the number of cells is set to zero.
	///
	/// @return True if allocation succeeds.
	/// </summary>
	public bool AllocateExact(long numVerts, long vertConnSize, long numLines, long lineConnSize, long numPolys, long polyConnSize, long numStrips, long stripConnSize)
	{
		return (vtkPolyData_AllocateExact_09(GetCppThis(), numVerts, vertConnSize, numLines, lineConnSize, numPolys, polyConnSize, numStrips, stripConnSize) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyData_AllocateProportional_10(HandleRef pThis, HandleRef pd, double ratio);

	/// <summary>
	/// Preallocate memory for the internal cell arrays such that they are
	/// proportional to those in @a pd by a factor of @a ratio (for instance,
	/// @a ratio = 2 allocates twice as many cells).
	///
	/// Existing data is not preserved and the number of cells is set to zero.
	///
	/// @return True if allocation succeeds.
	/// </summary>
	public bool AllocateProportional(vtkPolyData pd, double ratio)
	{
		return (vtkPolyData_AllocateProportional_10(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef), ratio) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_BuildCells_11(HandleRef pThis);

	/// <summary>
	/// Create data structure that allows random access of cells. BuildCells is
	/// expensive but necessary to make use of the faster non-virtual implementations
	/// of GetCell/GetCellPoints. One may check if cells need to be built via
	/// NeedToBuilds before invoking. Cells always need to be built/re-built after
	/// low level direct modifications to verts, lines, polys or strips cell arrays.
	/// </summary>
	public void BuildCells()
	{
		vtkPolyData_BuildCells_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_BuildLinks_12(HandleRef pThis, int initialSize);

	/// <summary>
	/// Create upward links from points to cells that use each point. Enables
	/// topologically complex queries. Normally the links array is allocated
	/// based on the number of points in the vtkPolyData. The optional
	/// initialSize parameter can be used to allocate a larger size initially.
	/// </summary>
	public void BuildLinks(int initialSize)
	{
		vtkPolyData_BuildLinks_12(GetCppThis(), initialSize);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_ComputeCellsBounds_13(HandleRef pThis);

	/// <summary>
	/// Compute the (X, Y, Z)  bounds of the data. Note that the method only considers
	/// points that are used by cells.
	/// This is done for usability and historical reasons.
	///
	/// IMPORTANT
	///
	/// Until vtk 9.0.1, vtkPolyData::ComputeBounds() used to ignore points that do not belong
	/// to any cell.
	/// That was not consistent with other vtkPointSet subclasses and thus was error prone.
	/// See this ParaView issue https://gitlab.kitware.com/paraview/paraview/-/issues/20354
	/// Now it defers to vtkPointSet::ComputeBounds() so vtkPolyData::GetBounds() may
	/// not return the same bounds as before. This behavior is probably the one you want
	/// when using bounds.
	///
	/// The previous behavior is still available through vtkPolyData::ComputeCellsBounds()
	/// and vtkPolyData::GetCellsBounds(). This is mainly used for rendering purpose.
	/// </summary>
	public void ComputeCellsBounds()
	{
		vtkPolyData_ComputeCellsBounds_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_CopyCells_14(HandleRef pThis, HandleRef pd, HandleRef idList, HandleRef locator);

	/// <summary>
	/// Copy cells listed in idList from pd, including points, point data,
	/// and cell data.  This method assumes that point and cell data have
	/// been allocated.  If you pass in a point locator, then the points
	/// won't be duplicated in the output. This requires the use of an
	/// incremental point locator.
	/// </summary>
	public void CopyCells(vtkPolyData pd, vtkIdList idList, vtkIncrementalPointLocator locator)
	{
		vtkPolyData_CopyCells_14(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef), idList?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_CopyStructure_15(HandleRef pThis, HandleRef ds);

	/// <summary>
	/// Copy the geometric and topological structure of an input poly data object.
	/// </summary>
	public override void CopyStructure(vtkDataSet ds)
	{
		vtkPolyData_CopyStructure_15(GetCppThis(), ds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_DeepCopy_16(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void DeepCopy(vtkDataObject src)
	{
		vtkPolyData_DeepCopy_16(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_DeleteCell_17(HandleRef pThis, long cellId);

	/// <summary>
	/// Mark a point/cell as deleted from this vtkPolyData. Use this
	/// method only when the dataset is set as Editable.
	/// </summary>
	public void DeleteCell(long cellId)
	{
		vtkPolyData_DeleteCell_17(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_DeleteCells_18(HandleRef pThis);

	/// <summary>
	/// Release data structure that allows random access of the cells. This must
	/// be done before a 2nd call to BuildLinks(). DeleteCells implicitly deletes
	/// the links as well since they are no longer valid.
	/// </summary>
	public void DeleteCells()
	{
		vtkPolyData_DeleteCells_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_DeleteLinks_19(HandleRef pThis);

	/// <summary>
	/// Release the upward links from point to cells that use each point.
	/// </summary>
	public void DeleteLinks()
	{
		vtkPolyData_DeleteLinks_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_DeletePoint_20(HandleRef pThis, long ptId);

	/// <summary>
	/// Mark a point/cell as deleted from this vtkPolyData. Use this
	/// method only when the dataset is set as Editable.
	/// </summary>
	public void DeletePoint(long ptId)
	{
		vtkPolyData_DeletePoint_20(GetCppThis(), ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyData_ExtendedNew_21(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPolyData ExtendedNew()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyData_ExtendedNew_21(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPolyData_GetActualMemorySize_22(HandleRef pThis);

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
		return vtkPolyData_GetActualMemorySize_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyData_GetCell_23(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkDataSet interface.
	/// </summary>
	public override vtkCell GetCell(long cellId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyData_GetCell_23(GetCppThis(), cellId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPolyData_GetCell_24(HandleRef pThis, long cellId, HandleRef cell);

	/// <summary>
	/// Standard vtkDataSet interface.
	/// </summary>
	public override void GetCell(long cellId, vtkGenericCell cell)
	{
		vtkPolyData_GetCell_24(GetCppThis(), cellId, cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_GetCellBounds_25(HandleRef pThis, long cellId, IntPtr bounds);

	/// <summary>
	/// Standard vtkDataSet interface.
	/// </summary>
	public override void GetCellBounds(long cellId, IntPtr bounds)
	{
		vtkPolyData_GetCellBounds_25(GetCppThis(), cellId, bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_GetCellEdgeNeighbors_26(HandleRef pThis, long cellId, long p1, long p2, HandleRef cellIds);

	/// <summary>
	/// Get the neighbors at an edge. More efficient than the general
	/// GetCellNeighbors(). Assumes links have been built (with BuildLinks()),
	/// and looks specifically for edge neighbors.
	/// </summary>
	public void GetCellEdgeNeighbors(long cellId, long p1, long p2, vtkIdList cellIds)
	{
		vtkPolyData_GetCellEdgeNeighbors_26(GetCppThis(), cellId, p1, p2, cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyData_GetCellIdRelativeToCellArray_27(HandleRef pThis, long cellId);

	/// <summary>
	/// Maps the cell at position `cellId` inside the `vtkPolyData` to its location in the
	/// corresponding cell array. For instance, if cell `cellId` is a line, then this method returns
	/// the position of this cell in the `Lines` cell array.
	/// </summary>
	public long GetCellIdRelativeToCellArray(long cellId)
	{
		return vtkPolyData_GetCellIdRelativeToCellArray_27(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_GetCellNeighbors_28(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds);

	/// <summary>
	/// Standard vtkDataSet interface.
	/// </summary>
	public override void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds)
	{
		vtkPolyData_GetCellNeighbors_28(GetCppThis(), cellId, ptIds?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_GetCellPoints_29(HandleRef pThis, long cellId, HandleRef ptIds);

	/// <summary>
	/// Copy a cells point ids into list provided. (Less efficient.)
	/// </summary>
	public override void GetCellPoints(long cellId, vtkIdList ptIds)
	{
		vtkPolyData_GetCellPoints_29(GetCppThis(), cellId, ptIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyData_GetCellSize_30(HandleRef pThis, long cellId);

	/// <summary>
	/// Standard vtkDataSet interface.
	/// </summary>
	public override long GetCellSize(long cellId)
	{
		return vtkPolyData_GetCellSize_30(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyData_GetCellType_31(HandleRef pThis, long cellId);

	/// <summary>
	/// Standard vtkDataSet interface.
	/// </summary>
	public override int GetCellType(long cellId)
	{
		return vtkPolyData_GetCellType_31(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_GetCellsBounds_32(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the cells bounds.
	/// Internally calls ComputeCellsBounds().
	/// @sa ComputeCellsBounds()
	/// </summary>
	public void GetCellsBounds(IntPtr bounds)
	{
		vtkPolyData_GetCellsBounds_32(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyData_GetData_33(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkPolyData GetData(vtkInformation info)
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyData_GetData_33(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyData_GetData_34(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkPolyData GetData(vtkInformationVector v, int i)
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyData_GetData_34(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyData_GetDataObjectType_35(HandleRef pThis);

	/// <summary>
	/// Return what type of dataset this is.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkPolyData_GetDataObjectType_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyData_GetGhostLevel_36(HandleRef pThis);

	/// <summary>
	/// Get the ghost level.
	/// </summary>
	public virtual int GetGhostLevel()
	{
		return vtkPolyData_GetGhostLevel_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyData_GetLines_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the cell array defining lines. If there are no lines, an
	/// empty array will be returned (convenience to simplify traversal).
	/// </summary>
	public vtkCellArray GetLines()
	{
		vtkCellArray vtkCellArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyData_GetLines_37(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPolyData_GetLinks_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the links that you created possibly without using BuildLinks.
	///
	/// Note: Only vtkCellLinks are currently supported.
	/// </summary>
	public virtual vtkAbstractCellLinks GetLinks()
	{
		vtkAbstractCellLinks vtkAbstractCellLinks2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyData_GetLinks_38(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkPolyData_GetMTime_39(HandleRef pThis);

	/// <summary>
	/// Get MTime which also considers its cell array MTime.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkPolyData_GetMTime_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyData_GetMaxCellSize_40(HandleRef pThis);

	/// <summary>
	/// Return the maximum cell size in this poly data.
	/// </summary>
	public override int GetMaxCellSize()
	{
		return vtkPolyData_GetMaxCellSize_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkPolyData_GetMeshMTime_41(HandleRef pThis);

	/// <summary>
	/// Return the mesh (geometry/topology) modification time.
	/// This time is different from the usual MTime which also takes into
	/// account the modification of data arrays. This function can be used to
	/// track the changes on the mesh separately from the data arrays
	/// (eg. static mesh over time with transient data).
	/// </summary>
	public virtual ulong GetMeshMTime()
	{
		return vtkPolyData_GetMeshMTime_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyData_GetNumberOfCells_42(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet interface.
	/// </summary>
	public override long GetNumberOfCells()
	{
		return vtkPolyData_GetNumberOfCells_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyData_GetNumberOfGenerationsFromBase_43(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolyData_GetNumberOfGenerationsFromBase_43(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyData_GetNumberOfGenerationsFromBaseType_44(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolyData_GetNumberOfGenerationsFromBaseType_44(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyData_GetNumberOfLines_45(HandleRef pThis);

	/// <summary>
	/// Return the number of primitives of a particular type held.
	/// </summary>
	public long GetNumberOfLines()
	{
		return vtkPolyData_GetNumberOfLines_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyData_GetNumberOfPieces_46(HandleRef pThis);

	/// <summary>
	/// Get the piece and the number of pieces. Similar to extent in 3D.
	/// </summary>
	public virtual int GetNumberOfPieces()
	{
		return vtkPolyData_GetNumberOfPieces_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyData_GetNumberOfPolys_47(HandleRef pThis);

	/// <summary>
	/// Return the number of primitives of a particular type held.
	/// </summary>
	public long GetNumberOfPolys()
	{
		return vtkPolyData_GetNumberOfPolys_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyData_GetNumberOfStrips_48(HandleRef pThis);

	/// <summary>
	/// Return the number of primitives of a particular type held.
	/// </summary>
	public long GetNumberOfStrips()
	{
		return vtkPolyData_GetNumberOfStrips_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyData_GetNumberOfVerts_49(HandleRef pThis);

	/// <summary>
	/// Return the number of primitives of a particular type held.
	/// </summary>
	public long GetNumberOfVerts()
	{
		return vtkPolyData_GetNumberOfVerts_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyData_GetPiece_50(HandleRef pThis);

	/// <summary>
	/// Get the piece and the number of pieces. Similar to extent in 3D.
	/// </summary>
	public virtual int GetPiece()
	{
		return vtkPolyData_GetPiece_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_GetPointCells_51(HandleRef pThis, long ptId, HandleRef cellIds);

	/// <summary>
	/// Efficient method to obtain cells using a particular point. Make sure that
	/// routine BuildLinks() has been called.
	/// </summary>
	public override void GetPointCells(long ptId, vtkIdList cellIds)
	{
		vtkPolyData_GetPointCells_51(GetCppThis(), ptId, cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyData_GetPolys_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the cell array defining polygons. If there are no polygons, an
	/// empty array will be returned (convenience to simplify traversal).
	/// </summary>
	public vtkCellArray GetPolys()
	{
		vtkCellArray vtkCellArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyData_GetPolys_52(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPolyData_GetScalarFieldCriticalIndex_53(HandleRef pThis, long pointId, HandleRef scalarField);

	/// <summary>
	/// Scalar field critical point classification (for manifold 2D meshes).
	/// Reference: J. Milnor "Morse Theory", Princeton University Press, 1963.
	///
	/// Given a pointId and an attribute representing a scalar field, this member
	/// returns the index of the critical point:
	/// vtkPolyData::MINIMUM (index 0): local minimum;
	/// vtkPolyData::SADDLE  (index 1): local saddle;
	/// vtkPolyData::MAXIMUM (index 2): local maximum.
	///
	/// Other returned values are:
	/// vtkPolyData::REGULAR_POINT: regular point (the gradient does not vanish);
	/// vtkPolyData::ERR_NON_MANIFOLD_STAR: the star of the considered vertex is
	/// not manifold (could not evaluate the index)
	/// vtkPolyData::ERR_INCORRECT_FIELD: the number of entries in the scalar field
	/// array is different form the number of vertices in the mesh.
	/// vtkPolyData::ERR_NO_SUCH_FIELD: the specified scalar field does not exist.
	/// </summary>
	public int GetScalarFieldCriticalIndex(long pointId, vtkDataArray scalarField)
	{
		return vtkPolyData_GetScalarFieldCriticalIndex_53(GetCppThis(), pointId, scalarField?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyData_GetScalarFieldCriticalIndex_54(HandleRef pThis, long pointId, int fieldId);

	/// <summary>
	/// Scalar field critical point classification (for manifold 2D meshes).
	/// Reference: J. Milnor "Morse Theory", Princeton University Press, 1963.
	///
	/// Given a pointId and an attribute representing a scalar field, this member
	/// returns the index of the critical point:
	/// vtkPolyData::MINIMUM (index 0): local minimum;
	/// vtkPolyData::SADDLE  (index 1): local saddle;
	/// vtkPolyData::MAXIMUM (index 2): local maximum.
	///
	/// Other returned values are:
	/// vtkPolyData::REGULAR_POINT: regular point (the gradient does not vanish);
	/// vtkPolyData::ERR_NON_MANIFOLD_STAR: the star of the considered vertex is
	/// not manifold (could not evaluate the index)
	/// vtkPolyData::ERR_INCORRECT_FIELD: the number of entries in the scalar field
	/// array is different form the number of vertices in the mesh.
	/// vtkPolyData::ERR_NO_SUCH_FIELD: the specified scalar field does not exist.
	/// </summary>
	public int GetScalarFieldCriticalIndex(long pointId, int fieldId)
	{
		return vtkPolyData_GetScalarFieldCriticalIndex_54(GetCppThis(), pointId, fieldId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyData_GetScalarFieldCriticalIndex_55(HandleRef pThis, long pointId, string fieldName);

	/// <summary>
	/// Scalar field critical point classification (for manifold 2D meshes).
	/// Reference: J. Milnor "Morse Theory", Princeton University Press, 1963.
	///
	/// Given a pointId and an attribute representing a scalar field, this member
	/// returns the index of the critical point:
	/// vtkPolyData::MINIMUM (index 0): local minimum;
	/// vtkPolyData::SADDLE  (index 1): local saddle;
	/// vtkPolyData::MAXIMUM (index 2): local maximum.
	///
	/// Other returned values are:
	/// vtkPolyData::REGULAR_POINT: regular point (the gradient does not vanish);
	/// vtkPolyData::ERR_NON_MANIFOLD_STAR: the star of the considered vertex is
	/// not manifold (could not evaluate the index)
	/// vtkPolyData::ERR_INCORRECT_FIELD: the number of entries in the scalar field
	/// array is different form the number of vertices in the mesh.
	/// vtkPolyData::ERR_NO_SUCH_FIELD: the specified scalar field does not exist.
	/// </summary>
	public int GetScalarFieldCriticalIndex(long pointId, string fieldName)
	{
		return vtkPolyData_GetScalarFieldCriticalIndex_55(GetCppThis(), pointId, fieldName);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyData_GetStrips_56(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the cell array defining triangle strips. If there are no
	/// triangle strips, an empty array will be returned (convenience to
	/// simplify traversal).
	/// </summary>
	public vtkCellArray GetStrips()
	{
		vtkCellArray vtkCellArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyData_GetStrips_56(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPolyData_GetVerts_57(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the cell array defining vertices. If there are no vertices, an
	/// empty array will be returned (convenience to simplify traversal).
	/// </summary>
	public vtkCellArray GetVerts()
	{
		vtkCellArray vtkCellArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyData_GetVerts_57(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPolyData_Initialize_58(HandleRef pThis);

	/// <summary>
	/// Restore object to initial state. Release memory back to system.
	/// </summary>
	public override void Initialize()
	{
		vtkPolyData_Initialize_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyData_InsertNextCell_59(HandleRef pThis, int type, int npts, IntPtr pts);

	/// <summary>
	/// Insert a cell of type VTK_VERTEX, VTK_POLY_VERTEX, VTK_LINE, VTK_POLY_LINE,
	/// VTK_TRIANGLE, VTK_QUAD, VTK_POLYGON, or VTK_TRIANGLE_STRIP.  Make sure that
	/// the PolyData::Allocate() function has been called first or that vertex,
	/// line, polygon, and triangle strip arrays have been supplied.
	/// Note: will also insert VTK_PIXEL, but converts it to VTK_QUAD.
	/// </summary>
	public long InsertNextCell(int type, int npts, IntPtr pts)
	{
		return vtkPolyData_InsertNextCell_59(GetCppThis(), type, npts, pts);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyData_InsertNextCell_60(HandleRef pThis, int type, HandleRef pts);

	/// <summary>
	/// Insert a cell of type VTK_VERTEX, VTK_POLY_VERTEX, VTK_LINE, VTK_POLY_LINE,
	/// VTK_TRIANGLE, VTK_QUAD, VTK_POLYGON, or VTK_TRIANGLE_STRIP.  Make sure that
	/// the PolyData::Allocate() function has been called first or that vertex,
	/// line, polygon, and triangle strip arrays have been supplied.
	/// Note: will also insert VTK_PIXEL, but converts it to VTK_QUAD.
	/// </summary>
	public long InsertNextCell(int type, vtkIdList pts)
	{
		return vtkPolyData_InsertNextCell_60(GetCppThis(), type, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyData_InsertNextLinkedCell_61(HandleRef pThis, int type, int npts, IntPtr pts);

	/// <summary>
	/// Add a new cell to the cell data structure (after cell pointers have been
	/// built). This method adds the cell and then updates the links from the
	/// points to the cells. (Memory is allocated as necessary.) Use this method
	/// only when the dataset is set as Editable.
	/// </summary>
	public long InsertNextLinkedCell(int type, int npts, IntPtr pts)
	{
		return vtkPolyData_InsertNextLinkedCell_61(GetCppThis(), type, npts, pts);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyData_InsertNextLinkedPoint_62(HandleRef pThis, int numLinks);

	/// <summary>
	/// Add a point to the cell data structure (after cell pointers have been
	/// built). This method adds the point and then allocates memory for the
	/// links to the cells.  (To use this method, make sure points are available
	/// and BuildLinks() has been invoked.) Of the two methods below, one inserts
	/// a point coordinate and the other just makes room for cell links. Use this
	/// method only when the dataset is set as Editable.
	/// </summary>
	public long InsertNextLinkedPoint(int numLinks)
	{
		return vtkPolyData_InsertNextLinkedPoint_62(GetCppThis(), numLinks);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyData_InsertNextLinkedPoint_63(HandleRef pThis, IntPtr x, int numLinks);

	/// <summary>
	/// Add a point to the cell data structure (after cell pointers have been
	/// built). This method adds the point and then allocates memory for the
	/// links to the cells.  (To use this method, make sure points are available
	/// and BuildLinks() has been invoked.) Of the two methods below, one inserts
	/// a point coordinate and the other just makes room for cell links. Use this
	/// method only when the dataset is set as Editable.
	/// </summary>
	public long InsertNextLinkedPoint(IntPtr x, int numLinks)
	{
		return vtkPolyData_InsertNextLinkedPoint_63(GetCppThis(), x, numLinks);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyData_IsA_64(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolyData_IsA_64(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyData_IsEdge_65(HandleRef pThis, long p1, long p2);

	/// <summary>
	/// Determine whether two points form an edge. If they do, return non-zero.
	/// By definition PolyVertex and PolyLine have no edges since 1-dimensional
	/// edges are only found on cells 2D and higher.
	/// Edges are defined as 1-D boundary entities to cells.
	/// Make sure BuildLinks() has been called first.
	/// </summary>
	public int IsEdge(long p1, long p2)
	{
		return vtkPolyData_IsEdge_65(GetCppThis(), p1, p2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyData_IsPointUsedByCell_66(HandleRef pThis, long ptId, long cellId);

	/// <summary>
	/// Determine whether a point is used by a particular cell. If it is, return
	/// non-zero. Make sure BuildCells() has been called first.
	/// </summary>
	public int IsPointUsedByCell(long ptId, long cellId)
	{
		return vtkPolyData_IsPointUsedByCell_66(GetCppThis(), ptId, cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyData_IsTriangle_67(HandleRef pThis, int v1, int v2, int v3);

	/// <summary>
	/// Given three vertices, determine whether it's a triangle. Make sure
	/// BuildLinks() has been called first.
	/// </summary>
	public int IsTriangle(int v1, int v2, int v3)
	{
		return vtkPolyData_IsTriangle_67(GetCppThis(), v1, v2, v3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyData_IsTypeOf_68(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolyData_IsTypeOf_68(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyData_NeedToBuildCells_69(HandleRef pThis);

	/// <summary>
	/// Check if BuildCells is needed.
	/// </summary>
	public bool NeedToBuildCells()
	{
		return (vtkPolyData_NeedToBuildCells_69(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyData_NewInstance_71(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPolyData NewInstance()
	{
		vtkPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyData_NewInstance_71(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_RemoveCellReference_72(HandleRef pThis, long cellId);

	/// <summary>
	/// Remove all references to cell in cell structure. This means the links
	/// from the cell's points to the cell are deleted. Memory is not
	/// reclaimed. Use the method ResizeCellList() to resize the link list from
	/// a point to its using cells. (This operator assumes BuildLinks() has been
	/// called.) Use this method only when the dataset is set as Editable.
	/// </summary>
	public void RemoveCellReference(long cellId)
	{
		vtkPolyData_RemoveCellReference_72(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_RemoveDeletedCells_73(HandleRef pThis);

	/// <summary>
	/// The cells marked by calls to DeleteCell are stored in the Cell Array
	/// VTK_EMPTY_CELL, but they still exist in the cell arrays.  Calling
	/// RemoveDeletedCells will traverse the cell arrays and remove/compact the
	/// cell arrays as well as any cell data thus truly removing the cells from
	/// the polydata object. Use this method only when the dataset is set as
	/// Editable.
	/// </summary>
	public void RemoveDeletedCells()
	{
		vtkPolyData_RemoveDeletedCells_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_RemoveGhostCells_74(HandleRef pThis);

	/// <summary>
	/// This method will remove any cell that is marked as ghost
	/// (has the vtkDataSetAttributes::DUPLICATECELL or
	/// the vtkDataSetAttributes::HIDDENCELL bit set).
	/// It does not remove unused points.
	/// </summary>
	public void RemoveGhostCells()
	{
		vtkPolyData_RemoveGhostCells_74(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_RemoveReferenceToCell_75(HandleRef pThis, long ptId, long cellId);

	/// <summary>
	/// Remove a reference to a cell in a particular point's link list. You may
	/// also consider using RemoveCellReference() to remove the references from
	/// all the cell's points to the cell. This operator does not reallocate
	/// memory; use the operator ResizeCellList() to do this if necessary. Use
	/// this method only when the dataset is set as Editable.
	/// </summary>
	public void RemoveReferenceToCell(long ptId, long cellId)
	{
		vtkPolyData_RemoveReferenceToCell_75(GetCppThis(), ptId, cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_ReplaceCell_76(HandleRef pThis, long cellId, HandleRef ids);

	/// <summary>
	/// Replace the points defining cell "cellId" with a new set of points. This
	/// operator is (typically) used when links from points to cells have not been
	/// built (i.e., BuildLinks() has not been executed). Use the operator
	/// ReplaceLinkedCell() to replace a cell when cell structure has been built. Use this
	/// method only when the dataset is set as Editable.
	/// @{
	/// </summary>
	public void ReplaceCell(long cellId, vtkIdList ids)
	{
		vtkPolyData_ReplaceCell_76(GetCppThis(), cellId, ids?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_ReplaceCell_77(HandleRef pThis, long cellId, int npts, IntPtr pts);

	/// <summary>
	/// Replace the points defining cell "cellId" with a new set of points. This
	/// operator is (typically) used when links from points to cells have not been
	/// built (i.e., BuildLinks() has not been executed). Use the operator
	/// ReplaceLinkedCell() to replace a cell when cell structure has been built. Use this
	/// method only when the dataset is set as Editable.
	/// @{
	/// </summary>
	public void ReplaceCell(long cellId, int npts, IntPtr pts)
	{
		vtkPolyData_ReplaceCell_77(GetCppThis(), cellId, npts, pts);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_ReplaceCellPoint_78(HandleRef pThis, long cellId, long oldPtId, long newPtId);

	/// <summary>
	/// Replace a point in the cell connectivity list with a different point. Use this
	/// method only when the dataset is set as Editable.
	///
	/// The version with cellPointIds avoids allocating/deallocating a vtkIdList at each call
	/// internally.
	///
	/// THIS METHOD IS THREAD SAFE IF BuildCells() IS FIRST CALLED FROM A SINGLE THREAD.
	/// </summary>
	public void ReplaceCellPoint(long cellId, long oldPtId, long newPtId)
	{
		vtkPolyData_ReplaceCellPoint_78(GetCppThis(), cellId, oldPtId, newPtId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_ReplaceCellPoint_79(HandleRef pThis, long cellId, long oldPtId, long newPtId, HandleRef cellPointIds);

	/// <summary>
	/// Replace a point in the cell connectivity list with a different point. Use this
	/// method only when the dataset is set as Editable.
	///
	/// The version with cellPointIds avoids allocating/deallocating a vtkIdList at each call
	/// internally.
	///
	/// THIS METHOD IS THREAD SAFE IF BuildCells() IS FIRST CALLED FROM A SINGLE THREAD.
	/// </summary>
	public void ReplaceCellPoint(long cellId, long oldPtId, long newPtId, vtkIdList cellPointIds)
	{
		vtkPolyData_ReplaceCellPoint_79(GetCppThis(), cellId, oldPtId, newPtId, cellPointIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_ReplaceLinkedCell_80(HandleRef pThis, long cellId, int npts, IntPtr pts);

	/// <summary>
	/// Replace one cell with another in cell structure. This operator updates
	/// the connectivity list and the point's link list. It does not delete
	/// references to the old cell in the point's link list. Use the operator
	/// RemoveCellReference() to delete all references from points to (old)
	/// cell.  You may also want to consider using the operator ResizeCellList()
	/// if the link list is changing size. Use this method only when the dataset
	/// is set as Editable.
	/// </summary>
	public void ReplaceLinkedCell(long cellId, int npts, IntPtr pts)
	{
		vtkPolyData_ReplaceLinkedCell_80(GetCppThis(), cellId, npts, pts);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_Reset_81(HandleRef pThis);

	/// <summary>
	/// Begin inserting data all over again. Memory is not freed but otherwise
	/// objects are returned to their initial state.
	/// </summary>
	public void Reset()
	{
		vtkPolyData_Reset_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_ResizeCellList_82(HandleRef pThis, long ptId, int size);

	/// <summary>
	/// Resize the list of cells using a particular point. (This operator
	/// assumes that BuildLinks() has been called.) Use this method only when
	/// the dataset is set as Editable.
	/// </summary>
	public void ResizeCellList(long ptId, int size)
	{
		vtkPolyData_ResizeCellList_82(GetCppThis(), ptId, size);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_ReverseCell_83(HandleRef pThis, long cellId);

	/// <summary>
	/// Reverse the order of point ids defining the cell. Use this
	/// method only when the dataset is set as Editable.
	/// </summary>
	public void ReverseCell(long cellId)
	{
		vtkPolyData_ReverseCell_83(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyData_SafeDownCast_84(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPolyData SafeDownCast(vtkObjectBase o)
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyData_SafeDownCast_84(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_SetLines_85(HandleRef pThis, HandleRef l);

	/// <summary>
	/// Set the cell array defining lines.
	/// </summary>
	public void SetLines(vtkCellArray l)
	{
		vtkPolyData_SetLines_85(GetCppThis(), l?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_SetLinks_86(HandleRef pThis, HandleRef links);

	/// <summary>
	/// Set/Get the links that you created possibly without using BuildLinks.
	///
	/// Note: Only vtkCellLinks are currently supported.
	/// </summary>
	public virtual void SetLinks(vtkAbstractCellLinks links)
	{
		vtkPolyData_SetLinks_86(GetCppThis(), links?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_SetPolys_87(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set the cell array defining polygons.
	/// </summary>
	public void SetPolys(vtkCellArray p)
	{
		vtkPolyData_SetPolys_87(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_SetStrips_88(HandleRef pThis, HandleRef s);

	/// <summary>
	/// Set the cell array defining triangle strips.
	/// </summary>
	public void SetStrips(vtkCellArray s)
	{
		vtkPolyData_SetStrips_88(GetCppThis(), s?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_SetVerts_89(HandleRef pThis, HandleRef v);

	/// <summary>
	/// Set the cell array defining vertices.
	/// </summary>
	public void SetVerts(vtkCellArray v)
	{
		vtkPolyData_SetVerts_89(GetCppThis(), v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_ShallowCopy_90(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void ShallowCopy(vtkDataObject src)
	{
		vtkPolyData_ShallowCopy_90(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyData_Squeeze_91(HandleRef pThis);

	/// <summary>
	/// Recover extra allocated memory when creating data whose initial size
	/// is unknown. Examples include using the InsertNextCell() method, or
	/// when using the CellArray::EstimateSize() method to create vertices,
	/// lines, polygons, or triangle strips.
	/// </summary>
	public override void Squeeze()
	{
		vtkPolyData_Squeeze_91(GetCppThis());
	}
}
