using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDataSet
/// </summary>
/// <remarks>
///    abstract class to specify dataset behavior
///
/// vtkDataSet is an abstract class that specifies an interface for dataset
/// objects. vtkDataSet also provides methods to provide information about
/// the data, such as center, bounding box, and representative length.
///
/// In vtk a dataset consists of a structure (geometry and topology) and
/// attribute data. The structure is defined implicitly or explicitly as
/// a collection of cells. The geometry of the structure is contained in
/// point coordinates plus the cell interpolation functions. The topology
/// of the dataset structure is defined by cell types and how the cells
/// share their defining points.
///
/// Attribute data in vtk is either point data (data at points) or cell data
/// (data at cells). Typically filters operate on point data, but some may
/// operate on cell data, both cell and point data, either one, or none.
///
/// </remarks>
/// <seealso>
///
/// vtkPointSet vtkStructuredPoints vtkStructuredGrid vtkUnstructuredGrid
/// vtkRectilinearGrid vtkPolyData vtkPointData vtkCellData
/// vtkDataObject vtkFieldData
/// </seealso>
public abstract class vtkDataSet : vtkDataObject
{
	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public enum FieldDataType
	{
		/// <summary>enum member</summary>
		CELL_DATA_FIELD = 2,
		/// <summary>enum member</summary>
		DATA_OBJECT_FIELD = 0,
		/// <summary>enum member</summary>
		POINT_DATA_FIELD = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataSet";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataSet()
	{
		MRClassNameKey = "class vtkDataSet";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSet"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern IntPtr vtkDataSet_AllocateCellGhostArray_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Allocate ghost array for cells.
	/// </summary>
	public vtkUnsignedCharArray AllocateCellGhostArray()
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSet_AllocateCellGhostArray_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataSet_AllocatePointGhostArray_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Allocate ghost array for points.
	/// </summary>
	public vtkUnsignedCharArray AllocatePointGhostArray()
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSet_AllocatePointGhostArray_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDataSet_CheckAttributes_03(HandleRef pThis);

	/// <summary>
	/// This method checks to see if the cell and point attributes
	/// match the geometry.  Many filters will crash if the number of
	/// tuples in an array is less than the number of points/cells.
	/// This method returns 1 if there is a mismatch,
	/// and 0 if everything is ok.  It prints an error if an
	/// array is too short, and a warning if an array is too long.
	/// </summary>
	public int CheckAttributes()
	{
		return vtkDataSet_CheckAttributes_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSet_ComputeBounds_04(HandleRef pThis);

	/// <summary>
	/// Compute the data bounding box from data points.
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public virtual void ComputeBounds()
	{
		vtkDataSet_ComputeBounds_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSet_CopyAttributes_05(HandleRef pThis, HandleRef ds);

	/// <summary>
	/// Copy the attributes associated with the specified dataset to this
	/// instance of vtkDataSet.
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public virtual void CopyAttributes(vtkDataSet ds)
	{
		vtkDataSet_CopyAttributes_05(GetCppThis(), ds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSet_CopyStructure_06(HandleRef pThis, HandleRef ds);

	/// <summary>
	/// Copy the geometric and topological structure of an object. Note that
	/// the invoking object and the object pointed to by the parameter ds must
	/// be of the same type.
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public virtual void CopyStructure(vtkDataSet ds)
	{
		vtkDataSet_CopyStructure_06(GetCppThis(), ds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSet_DeepCopy_07(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void DeepCopy(vtkDataObject src)
	{
		vtkDataSet_DeepCopy_07(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSet_FindAndGetCell_08(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Locate the cell that contains a point and return the cell. Also returns
	/// the subcell id, parametric coordinates and weights for subsequent
	/// interpolation. This method combines the derived class methods
	/// int FindCell and vtkCell *GetCell. Derived classes may provide a more
	/// efficient implementation. See for example vtkStructuredPoints.
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public virtual vtkCell FindAndGetCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSet_FindAndGetCell_08(GetCppThis(), x, cell?.GetCppThis() ?? default(HandleRef), cellId, tol2, ref subId, pcoords, weights, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkDataSet_FindCell_09(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Locate cell based on global coordinate x and tolerance
	/// squared. If cell and cellId is non-nullptr, then search starts from
	/// this cell and looks at immediate neighbors.  Returns cellId &gt;= 0
	/// if inside, &lt; 0 otherwise.  The parametric coordinates are
	/// provided in pcoords[3]. The interpolation weights are returned in
	/// weights[]. (The number of weights is equal to the number of
	/// points in the found cell). Tolerance is used to control how close
	/// the point is to be considered "in" the cell.
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public virtual long FindCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		return vtkDataSet_FindCell_09(GetCppThis(), x, cell?.GetCppThis() ?? default(HandleRef), cellId, tol2, ref subId, pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataSet_FindCell_10(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// This is a version of the above method that can be used with
	/// multithreaded applications. A vtkGenericCell must be passed in
	/// to be used in internal calls that might be made to GetCell()
	/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
	/// THE DATASET IS NOT MODIFIED
	/// </summary>
	public virtual long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		return vtkDataSet_FindCell_10(GetCppThis(), x, cell?.GetCppThis() ?? default(HandleRef), gencell?.GetCppThis() ?? default(HandleRef), cellId, tol2, ref subId, pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataSet_FindPoint_11(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Locate the closest point to the global coordinate x. Return the
	/// point id. If point id &lt; 0; then no point found. (This may arise
	/// when point is outside of dataset.)
	/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
	/// THE DATASET IS NOT MODIFIED
	/// </summary>
	public long FindPoint(double x, double y, double z)
	{
		return vtkDataSet_FindPoint_11(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataSet_FindPoint_12(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Locate the closest point to the global coordinate x. Return the
	/// point id. If point id &lt; 0; then no point found. (This may arise
	/// when point is outside of dataset.)
	/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
	/// THE DATASET IS NOT MODIFIED
	/// </summary>
	public virtual long FindPoint(IntPtr x)
	{
		return vtkDataSet_FindPoint_12(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSet_GenerateGhostArray_13(HandleRef pThis, IntPtr zeroExt);

	/// <summary>
	/// Normally called by pipeline executives or algorithms only. This method
	/// computes the ghost arrays for a given dataset. The zeroExt argument
	/// specifies the extent of the region which ghost type = 0.
	/// </summary>
	public virtual void GenerateGhostArray(IntPtr zeroExt)
	{
		vtkDataSet_GenerateGhostArray_13(GetCppThis(), zeroExt);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSet_GenerateGhostArray_14(HandleRef pThis, IntPtr zeroExt, byte cellOnly);

	/// <summary>
	/// Normally called by pipeline executives or algorithms only. This method
	/// computes the ghost arrays for a given dataset. The zeroExt argument
	/// specifies the extent of the region which ghost type = 0.
	/// </summary>
	public virtual void GenerateGhostArray(IntPtr zeroExt, bool cellOnly)
	{
		vtkDataSet_GenerateGhostArray_14(GetCppThis(), zeroExt, (byte)(cellOnly ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDataSet_GetActualMemorySize_15(HandleRef pThis);

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
		return vtkDataSet_GetActualMemorySize_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSet_GetAttributesAsFieldData_16(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the attributes of the data object as a vtkFieldData.
	/// This returns non-null values in all the same cases as GetAttributes,
	/// in addition to the case of FIELD, which will return the field data
	/// for any vtkDataObject subclass.
	/// </summary>
	public override vtkFieldData GetAttributesAsFieldData(int type)
	{
		vtkFieldData vtkFieldData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSet_GetAttributesAsFieldData_16(GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFieldData2 = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFieldData2.Register(null);
			}
		}
		return vtkFieldData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSet_GetBounds_17(HandleRef pThis);

	/// <summary>
	/// Return a pointer to the geometry bounding box in the form
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public double[] GetBounds()
	{
		IntPtr intPtr = vtkDataSet_GetBounds_17(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSet_GetBounds_18(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Return a pointer to the geometry bounding box in the form
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
	/// THE DATASET IS NOT MODIFIED
	/// </summary>
	public void GetBounds(IntPtr bounds)
	{
		vtkDataSet_GetBounds_18(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSet_GetCell_19(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get cell with cellId such that: 0 &lt;= cellId &lt; NumberOfCells. The returned
	/// vtkCell is an object owned by this instance, hence the return value must not
	/// be deleted by the caller.
	///
	/// @warning Repeat calls to this function for different face ids will change
	/// the data stored in the internal member object whose pointer is returned by
	/// this function.
	///
	/// @warning THIS METHOD IS NOT THREAD SAFE. For a thread-safe version, please use
	/// void GetCell(vtkIdType cellId, vtkGenericCell* cell).
	/// </summary>
	public virtual vtkCell GetCell(long cellId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSet_GetCell_19(GetCppThis(), cellId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataSet_GetCell_20(HandleRef pThis, int arg0, int arg1, int arg2, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get cell with cellId such that: 0 &lt;= cellId &lt; NumberOfCells. The returned
	/// vtkCell is an object owned by this instance, hence the return value must not
	/// be deleted by the caller.
	///
	/// @warning Repeat calls to this function for different face ids will change
	/// the data stored in the internal member object whose pointer is returned by
	/// this function.
	///
	/// @warning THIS METHOD IS NOT THREAD SAFE. For a thread-safe version, please use
	/// void GetCell(vtkIdType cellId, vtkGenericCell* cell).
	/// </summary>
	public virtual vtkCell GetCell(int arg0, int arg1, int arg2)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSet_GetCell_20(GetCppThis(), arg0, arg1, arg2, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDataSet_GetCell_21(HandleRef pThis, long cellId, HandleRef cell);

	/// <summary>
	/// Get cell with cellId such that: 0 &lt;= cellId &lt; NumberOfCells.
	/// This is a thread-safe alternative to the previous GetCell()
	/// method.
	/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
	/// THE DATASET IS NOT MODIFIED
	/// </summary>
	public virtual void GetCell(long cellId, vtkGenericCell cell)
	{
		vtkDataSet_GetCell_21(GetCppThis(), cellId, cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSet_GetCellBounds_22(HandleRef pThis, long cellId, IntPtr bounds);

	/// <summary>
	/// Get the bounds of the cell with cellId such that:
	/// 0 &lt;= cellId &lt; NumberOfCells.
	/// A subclass may be able to determine the bounds of cell without using
	/// an expensive GetCell() method. A default implementation is provided
	/// that actually uses a GetCell() call.  This is to ensure the method
	/// is available to all datasets.  Subclasses should override this method
	/// to provide an efficient implementation.
	/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
	/// THE DATASET IS NOT MODIFIED
	/// </summary>
	public virtual void GetCellBounds(long cellId, IntPtr bounds)
	{
		vtkDataSet_GetCellBounds_22(GetCppThis(), cellId, bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSet_GetCellData_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a pointer to this dataset's cell data.
	/// THIS METHOD IS THREAD SAFE
	/// </summary>
	public vtkCellData GetCellData()
	{
		vtkCellData vtkCellData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSet_GetCellData_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellData2 = (vtkCellData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellData2.Register(null);
			}
		}
		return vtkCellData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSet_GetCellGhostArray_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the array that defines the ghost type of each cell.
	/// We cache the pointer to the array to save a lookup involving string comparisons
	/// </summary>
	public vtkUnsignedCharArray GetCellGhostArray()
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSet_GetCellGhostArray_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDataSet_GetCellNeighbors_25(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds);

	/// <summary>
	/// Topological inquiry to get all cells using list of points exclusive of
	/// cell specified (e.g., cellId). Note that the list consists of only
	/// cells that use ALL the points provided.
	/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
	/// THE DATASET IS NOT MODIFIED
	/// </summary>
	public virtual void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds)
	{
		vtkDataSet_GetCellNeighbors_25(GetCppThis(), cellId, ptIds?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSet_GetCellPoints_26(HandleRef pThis, long cellId, HandleRef ptIds);

	/// <summary>
	/// Topological inquiry to get points defining cell.
	/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
	/// THE DATASET IS NOT MODIFIED
	/// </summary>
	public virtual void GetCellPoints(long cellId, vtkIdList ptIds)
	{
		vtkDataSet_GetCellPoints_26(GetCppThis(), cellId, ptIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataSet_GetCellSize_27(HandleRef pThis, long cellId);

	/// <summary>
	/// Get the size of cell with cellId such that: 0 &lt;= cellId &lt; NumberOfCells.
	/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
	/// THE DATASET IS NOT MODIFIED
	///
	/// @warning This method MUST be overridden for performance reasons.
	/// Default implementation is very unefficient.
	/// </summary>
	public virtual long GetCellSize(long cellId)
	{
		return vtkDataSet_GetCellSize_27(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSet_GetCellType_28(HandleRef pThis, long cellId);

	/// <summary>
	/// Get type of cell with cellId such that: 0 &lt;= cellId &lt; NumberOfCells.
	/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
	/// THE DATASET IS NOT MODIFIED
	/// </summary>
	public virtual int GetCellType(long cellId)
	{
		return vtkDataSet_GetCellType_28(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSet_GetCellTypes_29(HandleRef pThis, HandleRef types);

	/// <summary>
	/// Get a list of types of cells in a dataset. The list consists of an array
	/// of types (not necessarily in any order), with a single entry per type.
	/// For example a dataset 5 triangles, 3 lines, and 100 hexahedra would
	/// result a list of three entries, corresponding to the types VTK_TRIANGLE,
	/// VTK_LINE, and VTK_HEXAHEDRON.
	/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
	/// THE DATASET IS NOT MODIFIED
	/// </summary>
	public virtual void GetCellTypes(vtkCellTypes types)
	{
		vtkDataSet_GetCellTypes_29(GetCppThis(), types?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSet_GetCenter_30(HandleRef pThis);

	/// <summary>
	/// Get the center of the bounding box.
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public double[] GetCenter()
	{
		IntPtr intPtr = vtkDataSet_GetCenter_30(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSet_GetCenter_31(HandleRef pThis, IntPtr center);

	/// <summary>
	/// Get the center of the bounding box.
	/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
	/// THE DATASET IS NOT MODIFIED
	/// </summary>
	public void GetCenter(IntPtr center)
	{
		vtkDataSet_GetCenter_31(GetCppThis(), center);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSet_GetData_32(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkDataSet GetData(vtkInformation info)
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSet_GetData_32(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSet_GetData_33(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkDataSet GetData(vtkInformationVector v, int i)
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSet_GetData_33(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSet_GetDataObjectType_34(HandleRef pThis);

	/// <summary>
	/// Return the type of data object.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkDataSet_GetDataObjectType_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSet_GetGhostArray_35(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the ghost array for the given type (point or cell).
	/// Takes advantage of the cache with the pointer to the array to save a string
	/// comparison.
	/// </summary>
	public override vtkUnsignedCharArray GetGhostArray(int type)
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSet_GetGhostArray_35(GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkDataSet_GetLength_36(HandleRef pThis);

	/// <summary>
	/// Return the length of the diagonal of the bounding box.
	/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
	/// THE DATASET IS NOT MODIFIED
	/// </summary>
	public double GetLength()
	{
		return vtkDataSet_GetLength_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDataSet_GetLength2_37(HandleRef pThis);

	/// <summary>
	/// Return the squared length of the diagonal of the bounding box.
	/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
	/// THE DATASET IS NOT MODIFIED
	/// </summary>
	public double GetLength2()
	{
		return vtkDataSet_GetLength2_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDataSet_GetMTime_38(HandleRef pThis);

	/// <summary>
	/// Datasets are composite objects and need to check each part for MTime
	/// THIS METHOD IS THREAD SAFE
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkDataSet_GetMTime_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSet_GetMaxCellSize_39(HandleRef pThis);

	/// <summary>
	/// Convenience method returns largest cell size in dataset. This is generally
	/// used to allocate memory for supporting data structures.
	/// THIS METHOD IS THREAD SAFE
	/// </summary>
	public virtual int GetMaxCellSize()
	{
		return vtkDataSet_GetMaxCellSize_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataSet_GetNumberOfCells_40(HandleRef pThis);

	/// <summary>
	/// Determine the number of cells composing the dataset.
	/// THIS METHOD IS THREAD SAFE
	/// </summary>
	public virtual long GetNumberOfCells()
	{
		return vtkDataSet_GetNumberOfCells_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataSet_GetNumberOfElements_41(HandleRef pThis, int type);

	/// <summary>
	/// Get the number of elements for a specific attribute type (POINT, CELL, etc.).
	/// </summary>
	public override long GetNumberOfElements(int type)
	{
		return vtkDataSet_GetNumberOfElements_41(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataSet_GetNumberOfGenerationsFromBase_42(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataSet_GetNumberOfGenerationsFromBase_42(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataSet_GetNumberOfGenerationsFromBaseType_43(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataSet_GetNumberOfGenerationsFromBaseType_43(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataSet_GetNumberOfPoints_44(HandleRef pThis);

	/// <summary>
	/// Determine the number of points composing the dataset.
	/// THIS METHOD IS THREAD SAFE
	/// </summary>
	public virtual long GetNumberOfPoints()
	{
		return vtkDataSet_GetNumberOfPoints_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSet_GetPoint_45(HandleRef pThis, long ptId);

	/// <summary>
	/// Get point coordinates with ptId such that: 0 &lt;= ptId &lt; NumberOfPoints.
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public virtual double[] GetPoint(long ptId)
	{
		IntPtr intPtr = vtkDataSet_GetPoint_45(GetCppThis(), ptId);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSet_GetPoint_46(HandleRef pThis, long id, IntPtr x);

	/// <summary>
	/// Copy point coordinates into user provided array x[3] for specified
	/// point id.
	/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
	/// THE DATASET IS NOT MODIFIED
	/// </summary>
	public virtual void GetPoint(long id, IntPtr x)
	{
		vtkDataSet_GetPoint_46(GetCppThis(), id, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSet_GetPointCells_47(HandleRef pThis, long ptId, HandleRef cellIds);

	/// <summary>
	/// Topological inquiry to get cells using point.
	/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
	/// THE DATASET IS NOT MODIFIED
	/// </summary>
	public virtual void GetPointCells(long ptId, vtkIdList cellIds)
	{
		vtkDataSet_GetPointCells_47(GetCppThis(), ptId, cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSet_GetPointData_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a pointer to this dataset's point data.
	/// THIS METHOD IS THREAD SAFE
	/// </summary>
	public vtkPointData GetPointData()
	{
		vtkPointData vtkPointData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSet_GetPointData_48(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointData2 = (vtkPointData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointData2.Register(null);
			}
		}
		return vtkPointData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSet_GetPointGhostArray_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Gets the array that defines the ghost type of each point.
	/// We cache the pointer to the array to save a lookup involving string comparisons
	/// </summary>
	public vtkUnsignedCharArray GetPointGhostArray()
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSet_GetPointGhostArray_49(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDataSet_GetScalarRange_50(HandleRef pThis, IntPtr range);

	/// <summary>
	/// Convenience method to get the range of the first component (and only
	/// the first component) of any scalars in the data set.  If the data has
	/// both point data and cell data, it returns the (min/max) range of
	/// combined point and cell data.  If there are no point or cell scalars
	/// the method will return (0,1).  Note: It might be necessary to call
	/// Update to create or refresh the scalars before calling this method.
	/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
	/// THE DATASET IS NOT MODIFIED
	/// </summary>
	public virtual void GetScalarRange(IntPtr range)
	{
		vtkDataSet_GetScalarRange_50(GetCppThis(), range);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSet_GetScalarRange_51(HandleRef pThis);

	/// <summary>
	/// Convenience method to get the range of the first component (and only
	/// the first component) of any scalars in the data set.  If the data has
	/// both point data and cell data, it returns the (min/max) range of
	/// combined point and cell data.  If there are no point or cell scalars
	/// the method will return (0,1).  Note: It might be necessary to call
	/// Update to create or refresh the scalars before calling this method.
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public double[] GetScalarRange()
	{
		IntPtr intPtr = vtkDataSet_GetScalarRange_51(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataSet_HasAnyBlankCells_52(HandleRef pThis);

	/// <summary>
	/// Returns 1 if there are any blanking cells
	/// 0 otherwise. Blanking is supported only for vtkStructuredGrid
	/// and vtkUniformGrid
	/// </summary>
	public virtual bool HasAnyBlankCells()
	{
		return (vtkDataSet_HasAnyBlankCells_52(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataSet_HasAnyBlankPoints_53(HandleRef pThis);

	/// <summary>
	/// Returns 1 if there are any blanking points
	/// 0 otherwise. Blanking is supported only for vtkStructuredGrid
	/// and vtkUniformGrid
	/// </summary>
	public virtual bool HasAnyBlankPoints()
	{
		return (vtkDataSet_HasAnyBlankPoints_53(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataSet_HasAnyGhostCells_54(HandleRef pThis);

	/// <summary>
	/// Returns 1 if there are any ghost cells
	/// 0 otherwise.
	/// </summary>
	public bool HasAnyGhostCells()
	{
		return (vtkDataSet_HasAnyGhostCells_54(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataSet_HasAnyGhostPoints_55(HandleRef pThis);

	/// <summary>
	/// Returns 1 if there are any ghost points
	/// 0 otherwise.
	/// </summary>
	public bool HasAnyGhostPoints()
	{
		return (vtkDataSet_HasAnyGhostPoints_55(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSet_Initialize_56(HandleRef pThis);

	/// <summary>
	/// Restore data object to initial state.
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public override void Initialize()
	{
		vtkDataSet_Initialize_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSet_IsA_57(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataSet_IsA_57(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSet_IsTypeOf_58(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataSet_IsTypeOf_58(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSet_NewCellIterator_59(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return an iterator that traverses the cells in this data set.
	/// </summary>
	public virtual vtkCellIterator NewCellIterator()
	{
		vtkCellIterator vtkCellIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSet_NewCellIterator_59(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataSet_NewInstance_60(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDataSet NewInstance()
	{
		vtkDataSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSet_NewInstance_60(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSet_SafeDownCast_61(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataSet SafeDownCast(vtkObjectBase o)
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSet_SafeDownCast_61(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSet_SetCellOrderAndRationalWeights_62(HandleRef pThis, long cellId, HandleRef cell);

	/// <summary>
	/// Get cell with cellId such that: 0 &lt;= cellId &lt; NumberOfCells. The returned
	/// vtkCell is an object owned by this instance, hence the return value must not
	/// be deleted by the caller.
	///
	/// @warning Repeat calls to this function for different face ids will change
	/// the data stored in the internal member object whose pointer is returned by
	/// this function.
	///
	/// @warning THIS METHOD IS NOT THREAD SAFE. For a thread-safe version, please use
	/// void GetCell(vtkIdType cellId, vtkGenericCell* cell).
	/// </summary>
	public void SetCellOrderAndRationalWeights(long cellId, vtkGenericCell cell)
	{
		vtkDataSet_SetCellOrderAndRationalWeights_62(GetCppThis(), cellId, cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSet_ShallowCopy_63(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void ShallowCopy(vtkDataObject src)
	{
		vtkDataSet_ShallowCopy_63(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSet_Squeeze_64(HandleRef pThis);

	/// <summary>
	/// Reclaim any extra memory used to store data.
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public virtual void Squeeze()
	{
		vtkDataSet_Squeeze_64(GetCppThis());
	}
}
