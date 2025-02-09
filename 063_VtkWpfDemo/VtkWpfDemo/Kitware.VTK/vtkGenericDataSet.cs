using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericDataSet
/// </summary>
/// <remarks>
///    defines dataset interface
///
/// In VTK, spatial-temporal data is defined in terms of a dataset. The
/// dataset consists of geometry (e.g., points), topology (e.g., cells), and
/// attributes (e.g., scalars, vectors, etc.) vtkGenericDataSet is an abstract
/// class defining this abstraction.
///
/// Since vtkGenericDataSet provides a general interface to manipulate data,
/// algorithms that process it tend to be slower than those specialized for a
/// particular data type. For this reason, there are concrete, non-abstract
/// subclasses that represent and provide access to data more efficiently.
/// Note that filters to process this dataset type are currently found in the
/// VTK/GenericFiltering/ subdirectory.
///
/// Unlike the vtkDataSet class, vtkGenericDataSet provides a more flexible
/// interface including support for iterators. vtkGenericDataSet is also
/// designed to interface VTK to external simulation packages without the
/// penalty of copying memory (see VTK/GenericFiltering/README.html) for
/// more information. Thus vtkGenericDataSet plays a central role in the
/// adaptor framework.
///
/// Please note that this class introduces the concepts of "boundary cells".
/// This refers to the boundaries of a cell (e.g., face of a tetrahedron)
/// which may in turn be represented as a cell. Boundary cells are derivative
/// topological features of cells, and are therefore never explicitly
/// represented in the dataset. Often in visualization algorithms, looping
/// over boundaries (edges or faces) is employed, while the actual dataset
/// cells may not traversed. Thus there are methods to loop over these
/// boundary cells.
///
/// Finally, as a point of clarification, points are not the same as vertices.
/// Vertices refer to points, and points specify a position is space. Vertices
/// are a type of 0-D cell. Also, the concept of a DOFNode, which is where
/// coefficients for higher-order cells are kept, is a new concept introduced
/// by the adaptor framework (see vtkGenericAdaptorCell for more information).
///
/// </remarks>
/// <seealso>
///
/// vtkGenericAdaptorCell vtkDataSet
/// </seealso>
public abstract class vtkGenericDataSet : vtkDataObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericDataSet";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericDataSet()
	{
		MRClassNameKey = "class vtkGenericDataSet";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericDataSet"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkGenericDataSet_ComputeBounds_01(HandleRef pThis);

	/// <summary>
	/// Compute the geometry bounding box.
	/// </summary>
	public virtual void ComputeBounds()
	{
		vtkGenericDataSet_ComputeBounds_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericDataSet_FindCell_02(HandleRef pThis, IntPtr x, HandleRef cell, double tol2, ref int subId, IntPtr pcoords);

	/// <summary>
	/// Locate the closest cell to position `x' (global coordinates) with
	/// respect to a tolerance squared `tol2' and an initial guess `cell' (if
	/// valid). The result consists in the `cell', the `subId' of the sub-cell
	/// (0 if primary cell), the parametric coordinates `pcoord' of the
	/// position. It returns whether the position is inside the cell or
	/// not (boolean). Tolerance is used to control how close the point is to be
	/// considered "in" the cell.
	/// THIS METHOD IS NOT THREAD SAFE.
	/// \pre not_empty: GetNumberOfCells()&gt;0
	/// \pre cell_exists: cell!=0
	/// \pre positive_tolerance: tol2&gt;0
	/// </summary>
	public virtual int FindCell(IntPtr x, vtkGenericCellIterator cell, double tol2, ref int subId, IntPtr pcoords)
	{
		return vtkGenericDataSet_FindCell_02(GetCppThis(), x, cell?.GetCppThis() ?? default(HandleRef), tol2, ref subId, pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericDataSet_FindPoint_03(HandleRef pThis, IntPtr x, HandleRef p);

	/// <summary>
	/// Locate the closest point `p' to position `x' (global coordinates).
	/// \pre not_empty: GetNumberOfPoints()&gt;0
	/// \pre p_exists: p!=0
	/// </summary>
	public virtual void FindPoint(IntPtr x, vtkGenericPointIterator p)
	{
		vtkGenericDataSet_FindPoint_03(GetCppThis(), x, p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkGenericDataSet_GetActualMemorySize_04(HandleRef pThis);

	/// <summary>
	/// Actual size of the data in kibibytes (1024 bytes); only valid after the pipeline has
	/// updated. It is guaranteed to be greater than or equal to the memory
	/// required to represent the data.
	/// </summary>
	public override uint GetActualMemorySize()
	{
		return vtkGenericDataSet_GetActualMemorySize_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericDataSet_GetAttributes_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the collection of attributes associated with this dataset.
	/// </summary>
	public virtual vtkGenericAttributeCollection GetAttributes()
	{
		vtkGenericAttributeCollection vtkGenericAttributeCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericDataSet_GetAttributes_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericAttributeCollection2 = (vtkGenericAttributeCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericAttributeCollection2.Register(null);
			}
		}
		return vtkGenericAttributeCollection2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericDataSet_GetAttributes_06(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the attributes of the data object of the specified
	/// attribute type. The type may be:
	/// &lt;ul&gt;
	/// &lt;li&gt;POINT  - Defined in vtkDataSet subclasses.
	/// &lt;li&gt;CELL   - Defined in vtkDataSet subclasses.
	/// &lt;li&gt;VERTEX - Defined in vtkGraph subclasses.
	/// &lt;li&gt;EDGE   - Defined in vtkGraph subclasses.
	/// &lt;li&gt;ROW    - Defined in vtkTable.
	/// &lt;/ul&gt;
	/// The other attribute type, FIELD, will return nullptr since
	/// field data is stored as a vtkFieldData instance, not a
	/// vtkDataSetAttributes instance. To retrieve field data, use
	/// GetAttributesAsFieldData.
	/// </summary>
	public override vtkDataSetAttributes GetAttributes(int type)
	{
		vtkDataSetAttributes vtkDataSetAttributes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericDataSet_GetAttributes_06(GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSetAttributes2 = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSetAttributes2.Register(null);
			}
		}
		return vtkDataSetAttributes2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericDataSet_GetBounds_07(HandleRef pThis);

	/// <summary>
	/// Return a pointer to the geometry bounding box in the form
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// The return value is VOLATILE.
	/// \post result_exists: result!=0
	/// </summary>
	public virtual IntPtr GetBounds()
	{
		return vtkGenericDataSet_GetBounds_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericDataSet_GetBounds_08(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Return the geometry bounding box in global coordinates in
	/// the form (xmin,xmax, ymin,ymax, zmin,zmax) in the `bounds' array.
	/// </summary>
	public virtual void GetBounds(IntPtr bounds)
	{
		vtkGenericDataSet_GetBounds_08(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericDataSet_GetCellDimension_09(HandleRef pThis);

	/// <summary>
	/// Return -1 if the dataset is explicitly defined by cells of varying
	/// dimensions or if there are no cells. If the dataset is explicitly
	/// defined by cells of a unique dimension, return this dimension.
	/// \post valid_range: (result&gt;=-1) &amp;&amp; (result&lt;=3)
	/// </summary>
	public virtual int GetCellDimension()
	{
		return vtkGenericDataSet_GetCellDimension_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericDataSet_GetCellTypes_10(HandleRef pThis, HandleRef types);

	/// <summary>
	/// Get a list of types of cells in a dataset. The list consists of an array
	/// of types (not necessarily in any order), with a single entry per type.
	/// For example a dataset 5 triangles, 3 lines, and 100 hexahedra would
	/// result a list of three entries, corresponding to the types VTK_TRIANGLE,
	/// VTK_LINE, and VTK_HEXAHEDRON.
	/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
	/// THE DATASET IS NOT MODIFIED
	/// \pre types_exist: types!=0
	/// </summary>
	public virtual void GetCellTypes(vtkCellTypes types)
	{
		vtkGenericDataSet_GetCellTypes_10(GetCppThis(), types?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericDataSet_GetCenter_11(HandleRef pThis);

	/// <summary>
	/// Get the center of the bounding box in global coordinates.
	/// The return value is VOLATILE.
	/// \post result_exists: result!=0
	/// </summary>
	public virtual IntPtr GetCenter()
	{
		return vtkGenericDataSet_GetCenter_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericDataSet_GetCenter_12(HandleRef pThis, IntPtr center);

	/// <summary>
	/// Get the center of the bounding box in global coordinates.
	/// </summary>
	public virtual void GetCenter(IntPtr center)
	{
		vtkGenericDataSet_GetCenter_12(GetCppThis(), center);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericDataSet_GetData_13(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkGenericDataSet GetData(vtkInformation info)
	{
		vtkGenericDataSet vtkGenericDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericDataSet_GetData_13(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericDataSet2 = (vtkGenericDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericDataSet2.Register(null);
			}
		}
		return vtkGenericDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericDataSet_GetData_14(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkGenericDataSet GetData(vtkInformationVector v, int i)
	{
		vtkGenericDataSet vtkGenericDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericDataSet_GetData_14(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericDataSet2 = (vtkGenericDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericDataSet2.Register(null);
			}
		}
		return vtkGenericDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericDataSet_GetDataObjectType_15(HandleRef pThis);

	/// <summary>
	/// Return the type of data object.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkGenericDataSet_GetDataObjectType_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericDataSet_GetEstimatedSize_16(HandleRef pThis);

	/// <summary>
	/// Estimated size needed after tessellation (or special operation)
	/// </summary>
	public virtual long GetEstimatedSize()
	{
		return vtkGenericDataSet_GetEstimatedSize_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGenericDataSet_GetLength_17(HandleRef pThis);

	/// <summary>
	/// Return the length of the diagonal of the bounding box.
	/// \post positive_result: result&gt;=0
	/// </summary>
	public virtual double GetLength()
	{
		return vtkGenericDataSet_GetLength_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkGenericDataSet_GetMTime_18(HandleRef pThis);

	/// <summary>
	/// Datasets are composite objects and need to check each part for their
	/// modified time.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkGenericDataSet_GetMTime_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericDataSet_GetNumberOfCells_19(HandleRef pThis, int dim);

	/// <summary>
	/// Return the number of cells that explicitly define the dataset. See
	/// NewCellIterator() for more details.
	/// \pre valid_dim_range: (dim&gt;=-1) &amp;&amp; (dim&lt;=3)
	/// \post positive_result: result&gt;=0
	/// </summary>
	public virtual long GetNumberOfCells(int dim)
	{
		return vtkGenericDataSet_GetNumberOfCells_19(GetCppThis(), dim);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericDataSet_GetNumberOfElements_20(HandleRef pThis, int type);

	/// <summary>
	/// Get the number of elements for a specific attribute type (POINT, CELL, etc.).
	/// </summary>
	public override long GetNumberOfElements(int type)
	{
		return vtkGenericDataSet_GetNumberOfElements_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericDataSet_GetNumberOfGenerationsFromBase_21(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK type and print macros.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericDataSet_GetNumberOfGenerationsFromBase_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericDataSet_GetNumberOfGenerationsFromBaseType_22(string type);

	/// <summary>
	/// Standard VTK type and print macros.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericDataSet_GetNumberOfGenerationsFromBaseType_22(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericDataSet_GetNumberOfPoints_23(HandleRef pThis);

	/// <summary>
	/// Return the number of points composing the dataset. See NewPointIterator()
	/// for more details.
	/// \post positive_result: result&gt;=0
	/// </summary>
	public virtual long GetNumberOfPoints()
	{
		return vtkGenericDataSet_GetNumberOfPoints_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericDataSet_GetTessellator_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get a cell tessellator if cells must be tessellated during
	/// processing.
	/// \pre tessellator_exists: tessellator!=0
	/// </summary>
	public virtual vtkGenericCellTessellator GetTessellator()
	{
		vtkGenericCellTessellator vtkGenericCellTessellator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericDataSet_GetTessellator_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericCellTessellator2 = (vtkGenericCellTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericCellTessellator2.Register(null);
			}
		}
		return vtkGenericCellTessellator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericDataSet_IsA_25(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK type and print macros.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericDataSet_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericDataSet_IsTypeOf_26(string type);

	/// <summary>
	/// Standard VTK type and print macros.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericDataSet_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericDataSet_NewBoundaryIterator_27(HandleRef pThis, int dim, int exteriorOnly, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return an iterator to traverse cell boundaries of dimension `dim' (or
	/// all dimensions if -1) of the dataset.  If `exteriorOnly' is true, only
	/// the exterior cell boundaries of the dataset will be returned, otherwise
	/// it will return exterior and interior cell boundaries. The user is
	/// responsible for deleting the iterator.
	/// \pre valid_dim_range: (dim&gt;=-1) &amp;&amp; (dim&lt;=2)
	/// \post result_exists: result!=0
	/// </summary>
	public virtual vtkGenericCellIterator NewBoundaryIterator(int dim, int exteriorOnly)
	{
		vtkGenericCellIterator vtkGenericCellIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericDataSet_NewBoundaryIterator_27(GetCppThis(), dim, exteriorOnly, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericCellIterator2 = (vtkGenericCellIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericCellIterator2.Register(null);
			}
		}
		return vtkGenericCellIterator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericDataSet_NewCellIterator_28(HandleRef pThis, int dim, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return an iterator to traverse cells of dimension `dim' (or all
	/// dimensions if -1) that explicitly define the dataset. For instance, it
	/// will return only tetrahedra if the mesh is defined by tetrahedra. If the
	/// mesh is composed of two parts, one with tetrahedra and another part with
	/// triangles, it will return both, but will not return the boundary edges
	/// and vertices of these cells. The user is responsible for deleting the
	/// iterator.
	/// \pre valid_dim_range: (dim&gt;=-1) &amp;&amp; (dim&lt;=3)
	/// \post result_exists: result!=0
	/// </summary>
	public virtual vtkGenericCellIterator NewCellIterator(int dim)
	{
		vtkGenericCellIterator vtkGenericCellIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericDataSet_NewCellIterator_28(GetCppThis(), dim, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericCellIterator2 = (vtkGenericCellIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericCellIterator2.Register(null);
			}
		}
		return vtkGenericCellIterator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericDataSet_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK type and print macros.
	/// </summary>
	public new vtkGenericDataSet NewInstance()
	{
		vtkGenericDataSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericDataSet_NewInstance_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericDataSet_NewPointIterator_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return an iterator to traverse the points composing the dataset; they
	/// can be points that define a cell (corner points) or isolated points.
	/// The user is responsible for deleting the iterator.
	/// \post result_exists: result!=0
	/// </summary>
	public virtual vtkGenericPointIterator NewPointIterator()
	{
		vtkGenericPointIterator vtkGenericPointIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericDataSet_NewPointIterator_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericPointIterator2 = (vtkGenericPointIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericPointIterator2.Register(null);
			}
		}
		return vtkGenericPointIterator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericDataSet_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK type and print macros.
	/// </summary>
	public new static vtkGenericDataSet SafeDownCast(vtkObjectBase o)
	{
		vtkGenericDataSet vtkGenericDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericDataSet_SafeDownCast_31(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericDataSet2 = (vtkGenericDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericDataSet2.Register(null);
			}
		}
		return vtkGenericDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericDataSet_SetTessellator_32(HandleRef pThis, HandleRef tessellator);

	/// <summary>
	/// Set/Get a cell tessellator if cells must be tessellated during
	/// processing.
	/// \pre tessellator_exists: tessellator!=0
	/// </summary>
	public virtual void SetTessellator(vtkGenericCellTessellator tessellator)
	{
		vtkGenericDataSet_SetTessellator_32(GetCppThis(), tessellator?.GetCppThis() ?? default(HandleRef));
	}
}
