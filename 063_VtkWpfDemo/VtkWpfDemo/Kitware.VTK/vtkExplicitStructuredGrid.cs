using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExplicitStructuredGrid
/// </summary>
/// <remarks>
///    structured grid with explicit topology and geometry
///
/// vtkExplicitStructuredGrid is a data object that is a concrete implementation
/// of vtkDataSet. vtkExplicitStructuredGrid represents a geometric structure
/// that is a topologically regular array of hexahedron. The topology is that of
/// a cube that has been subdivided into a regular array of smaller cubes.
/// Each cell can be addressed with i-j-k indices, however neighbor hexahedrons
/// does not necessarily share a face and hexahedron can be blanked (turned-off).
///
/// Like unstructured grid, vtkExplicitStructuredGrid has explicit point coordinates
/// and cell to point indexing.
/// Unlike unstructured grid, vtkExplicitStructuredGrid does not keep a cell type
/// list as all visible cells are known to be hexahedra.
/// vtkExplicitStructuredGrid can take advantage of its layout to perform operations
/// based on the i, j, k parameters, similar to structured grid. This makes some
/// operations faster on this class, without losing the flexibility of the
/// cell -&gt; points mapping.
/// The most common use of this class would be in situations where you have all
/// hexahedra but the points used by the cells are not exactly defined by the
/// i, j, k parameters. One example of this is a structured grid with a half voxel
/// shift occurring in the middle of it such as with a geologic fault.
///
/// The order and number of points is arbitrary.
/// The order and number of cells must match that specified by the dimensions
/// of the grid minus 1, because in vtk structured datasets the dimensions
/// correspond to the points.
/// The cells order increases in i fastest (from 0 &lt;= i &lt;= dims[0] - 2),
/// then j (0 &lt;= j &lt;= dims[1] - 2), then k ( 0 &lt;= k &lt;= dims[2] - 2) where dims[]
/// are the dimensions of the grid in the i-j-k topological directions.
/// The number of cells is (dims[0] - 1) * (dims[1] - 1) * (dims[2] - 1).
///
/// In order for an ESG to be usable by most other ESG specific filters,
/// it is needed to call the ComputeFacesConnectivityFlagsArray method.
/// It is also recommended to call CheckAndReorderFaces method to fix any
/// faces issues in the dataset.
/// </remarks>
public class vtkExplicitStructuredGrid : vtkPointSet
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExplicitStructuredGrid";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExplicitStructuredGrid()
	{
		MRClassNameKey = "class vtkExplicitStructuredGrid";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExplicitStructuredGrid"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExplicitStructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExplicitStructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkExplicitStructuredGrid New()
	{
		vtkExplicitStructuredGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExplicitStructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public vtkExplicitStructuredGrid()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExplicitStructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkExplicitStructuredGrid_BlankCell_01(HandleRef pThis, long cellId);

	/// <summary>
	/// Methods for supporting blanking of cells. Blanking turns on or off
	/// cells in the structured grid.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public void BlankCell(long cellId)
	{
		vtkExplicitStructuredGrid_BlankCell_01(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_BuildLinks_02(HandleRef pThis);

	/// <summary>
	/// Create/Get upward links from points to cells that use each point.
	/// Enables topologically complex queries.
	/// </summary>
	public void BuildLinks()
	{
		vtkExplicitStructuredGrid_BuildLinks_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_CheckAndReorderFaces_03(HandleRef pThis);

	/// <summary>
	/// Check faces are numbered correctly regarding ijk numbering
	/// If not this will reorganize cell points order
	/// so face order is valid.
	/// This is made in two pass, first it check that faces are on
	/// the correct axis and corrects it
	/// Then it check if faces are mirrored and corrects it.
	/// Make sure cells and extent have been set before calling this method
	/// and recompute face connectivity afterwards.
	/// </summary>
	public void CheckAndReorderFaces()
	{
		vtkExplicitStructuredGrid_CheckAndReorderFaces_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExplicitStructuredGrid_ComputeCellId_04(HandleRef pThis, int i, int j, int k, byte adjustForExtent);

	/// <summary>
	/// Given a location in structured coordinates (i-j-k), return the cell id.
	/// If adjustForExtent is true, (i,j,k) is interpreted as a position relative
	/// to the beginning of the extent.
	/// If adjustForExtent is false, (i,j,k) is interpreted literally
	/// and the cell id is returned regardless of the extent beginning.
	/// The default adjustForExtent is true.
	/// </summary>
	public long ComputeCellId(int i, int j, int k, bool adjustForExtent)
	{
		return vtkExplicitStructuredGrid_ComputeCellId_04(GetCppThis(), i, j, k, (byte)(adjustForExtent ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_ComputeCellStructuredCoords_05(HandleRef pThis, long cellId, ref int i, ref int j, ref int k, byte adjustForExtent);

	/// <summary>
	/// Given a cellId, get the structured coordinates (i-j-k).
	/// If adjustForExtent is true, (i,j,k) is computed as a position relative
	/// to the beginning of the extent.
	/// If adjustForExtent is false, (i,j,k) is computed regardless of the
	/// extent beginning.
	/// The default adjustForExtent is true.
	/// </summary>
	public void ComputeCellStructuredCoords(long cellId, ref int i, ref int j, ref int k, bool adjustForExtent)
	{
		vtkExplicitStructuredGrid_ComputeCellStructuredCoords_05(GetCppThis(), cellId, ref i, ref j, ref k, (byte)(adjustForExtent ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_ComputeFacesConnectivityFlagsArray_06(HandleRef pThis);

	/// <summary>
	/// Compute the faces connectivity flags array. This method should
	/// be called after the construction if the ESG is to be used by
	/// other filters.
	/// </summary>
	public void ComputeFacesConnectivityFlagsArray()
	{
		vtkExplicitStructuredGrid_ComputeFacesConnectivityFlagsArray_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_CopyStructure_07(HandleRef pThis, HandleRef ds);

	/// <summary>
	/// Copy the geometric and topological structure of an input poly data object.
	/// </summary>
	public override void CopyStructure(vtkDataSet ds)
	{
		vtkExplicitStructuredGrid_CopyStructure_07(GetCppThis(), ds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_Crop_08(HandleRef pThis, IntPtr updateExtent);

	/// <summary>
	/// Reallocates and copies to set the Extent to the UpdateExtent.
	/// This is used internally when the exact extent is requested,
	/// and the source generated more than the update extent.
	/// </summary>
	public override void Crop(IntPtr updateExtent)
	{
		vtkExplicitStructuredGrid_Crop_08(GetCppThis(), updateExtent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_Crop_09(HandleRef pThis, HandleRef input, IntPtr updateExtent, byte generateOriginalCellIds);

	/// <summary>
	/// Reallocates and copies to set the Extent to the UpdateExtent.
	/// This is used internally when the exact extent is requested,
	/// and the source generated more than the update extent.
	/// </summary>
	public virtual void Crop(vtkExplicitStructuredGrid input, IntPtr updateExtent, bool generateOriginalCellIds)
	{
		vtkExplicitStructuredGrid_Crop_09(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), updateExtent, (byte)(generateOriginalCellIds ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_DeepCopy_10(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void DeepCopy(vtkDataObject src)
	{
		vtkExplicitStructuredGrid_DeepCopy_10(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_GenerateGhostArray_11(HandleRef pThis, IntPtr zeroExt, byte cellOnly);

	/// <summary>
	/// Normally called by pipeline executives or algorithms only. This method
	/// computes the ghost arrays for a given dataset. The zeroExt argument
	/// specifies the extent of the region which ghost type = 0.
	/// </summary>
	public override void GenerateGhostArray(IntPtr zeroExt, bool cellOnly)
	{
		vtkExplicitStructuredGrid_GenerateGhostArray_11(GetCppThis(), zeroExt, (byte)(cellOnly ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkExplicitStructuredGrid_GetActualMemorySize_12(HandleRef pThis);

	/// <summary>
	/// Return the actual size of the data in kilobytes. This number
	/// is valid only after the pipeline has updated. The memory size
	/// returned is guaranteed to be greater than or equal to the
	/// memory required to represent the data (e.g., extra space in
	/// arrays, etc. are not included in the return value). THIS METHOD
	/// IS THREAD SAFE.
	/// </summary>
	public override uint GetActualMemorySize()
	{
		return vtkExplicitStructuredGrid_GetActualMemorySize_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExplicitStructuredGrid_GetCell_13(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override vtkCell GetCell(long cellId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExplicitStructuredGrid_GetCell_13(GetCppThis(), cellId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkExplicitStructuredGrid_GetCell_14(HandleRef pThis, long cellId, HandleRef cell);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void GetCell(long cellId, vtkGenericCell cell)
	{
		vtkExplicitStructuredGrid_GetCell_14(GetCppThis(), cellId, cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_GetCellBounds_15(HandleRef pThis, long cellId, IntPtr bounds);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void GetCellBounds(long cellId, IntPtr bounds)
	{
		vtkExplicitStructuredGrid_GetCellBounds_15(GetCppThis(), cellId, bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_GetCellDims_16(HandleRef pThis, IntPtr cellDims);

	/// <summary>
	/// Computes the cell dimensions according to internal point dimensions.
	/// The total number of cells can be achieved simply by
	/// cellDims[0] * cellDims[1] * cellDims[2].
	/// </summary>
	public void GetCellDims(IntPtr cellDims)
	{
		vtkExplicitStructuredGrid_GetCellDims_16(GetCppThis(), cellDims);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_GetCellNeighbors_17(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds)
	{
		vtkExplicitStructuredGrid_GetCellNeighbors_17(GetCppThis(), cellId, ptIds?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_GetCellNeighbors_18(HandleRef pThis, long cellId, IntPtr neighbors, IntPtr wholeExtent);

	/// <summary>
	/// Get cell neighbors of the cell for every faces.
	/// </summary>
	public void GetCellNeighbors(long cellId, IntPtr neighbors, IntPtr wholeExtent)
	{
		vtkExplicitStructuredGrid_GetCellNeighbors_18(GetCppThis(), cellId, neighbors, wholeExtent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_GetCellPoints_19(HandleRef pThis, long cellId, HandleRef ptIds);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void GetCellPoints(long cellId, vtkIdList ptIds)
	{
		vtkExplicitStructuredGrid_GetCellPoints_19(GetCppThis(), cellId, ptIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExplicitStructuredGrid_GetCellPoints_20(HandleRef pThis, long cellId);

	/// <summary>
	/// Get direct raw pointer to the 8 points indices of an hexahedra.
	///
	/// Note: This method MAY NOT be thread-safe. (See GetCellAtId at vtkCellArray)
	/// </summary>
	public IntPtr GetCellPoints(long cellId)
	{
		return vtkExplicitStructuredGrid_GetCellPoints_20(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExplicitStructuredGrid_GetCellSize_21(HandleRef pThis, long cellId);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override long GetCellSize(long cellId)
	{
		return vtkExplicitStructuredGrid_GetCellSize_21(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExplicitStructuredGrid_GetCellType_22(HandleRef pThis, long cellId);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override int GetCellType(long cellId)
	{
		return vtkExplicitStructuredGrid_GetCellType_22(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExplicitStructuredGrid_GetCells_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the cell array defining hexahedron.
	/// </summary>
	public virtual vtkCellArray GetCells()
	{
		vtkCellArray vtkCellArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExplicitStructuredGrid_GetCells_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkExplicitStructuredGrid_GetData_24(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkExplicitStructuredGrid GetData(vtkInformation info)
	{
		vtkExplicitStructuredGrid vtkExplicitStructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExplicitStructuredGrid_GetData_24(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExplicitStructuredGrid2 = (vtkExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExplicitStructuredGrid2.Register(null);
			}
		}
		return vtkExplicitStructuredGrid2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExplicitStructuredGrid_GetData_25(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkExplicitStructuredGrid GetData(vtkInformationVector v, int i)
	{
		vtkExplicitStructuredGrid vtkExplicitStructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExplicitStructuredGrid_GetData_25(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExplicitStructuredGrid2 = (vtkExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExplicitStructuredGrid2.Register(null);
			}
		}
		return vtkExplicitStructuredGrid2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExplicitStructuredGrid_GetDataDimension_26(HandleRef pThis);

	/// <summary>
	/// Return the dimensionality of the data.
	/// </summary>
	public int GetDataDimension()
	{
		return vtkExplicitStructuredGrid_GetDataDimension_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExplicitStructuredGrid_GetDataObjectType_27(HandleRef pThis);

	/// <summary>
	/// Return what type of dataset this is.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkExplicitStructuredGrid_GetDataObjectType_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_GetDimensions_28(HandleRef pThis, IntPtr dim);

	/// <summary>
	/// Set/Get the dimensions of this structured dataset in term of number
	/// of points along each direction.
	/// This is just a convenience method which calls Set/GetExtent internally.
	/// </summary>
	public void GetDimensions(IntPtr dim)
	{
		vtkExplicitStructuredGrid_GetDimensions_28(GetCppThis(), dim);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExplicitStructuredGrid_GetExtent_29(HandleRef pThis);

	/// <summary>
	/// Set/Get the extent of this structured dataset in term of number
	/// of points along each direction.
	/// Setting the extent will reset the internal CellArray and Links
	/// and a correctly sized cell array will be created.
	/// The Extent is stored  in the order (X, Y, Z).
	/// </summary>
	public virtual int[] GetExtent()
	{
		IntPtr intPtr = vtkExplicitStructuredGrid_GetExtent_29(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_GetExtent_30(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Set/Get the extent of this structured dataset in term of number
	/// of points along each direction.
	/// Setting the extent will reset the internal CellArray and Links
	/// and a correctly sized cell array will be created.
	/// The Extent is stored  in the order (X, Y, Z).
	/// </summary>
	public virtual void GetExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkExplicitStructuredGrid_GetExtent_30(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_GetExtent_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the extent of this structured dataset in term of number
	/// of points along each direction.
	/// Setting the extent will reset the internal CellArray and Links
	/// and a correctly sized cell array will be created.
	/// The Extent is stored  in the order (X, Y, Z).
	/// </summary>
	public virtual void GetExtent(IntPtr _arg)
	{
		vtkExplicitStructuredGrid_GetExtent_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExplicitStructuredGrid_GetExtentType_32(HandleRef pThis);

	/// <summary>
	/// The extent type is a 3D extent
	/// </summary>
	public override int GetExtentType()
	{
		return vtkExplicitStructuredGrid_GetExtentType_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExplicitStructuredGrid_GetFacesConnectivityFlagsArrayName_33(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the faces connectivity flags array.
	/// </summary>
	public virtual string GetFacesConnectivityFlagsArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkExplicitStructuredGrid_GetFacesConnectivityFlagsArrayName_33(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExplicitStructuredGrid_GetLinks_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create/Get upward links from points to cells that use each point.
	/// Enables topologically complex queries.
	/// </summary>
	public virtual vtkAbstractCellLinks GetLinks()
	{
		vtkAbstractCellLinks vtkAbstractCellLinks2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExplicitStructuredGrid_GetLinks_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkExplicitStructuredGrid_GetMaxCellSize_35(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override int GetMaxCellSize()
	{
		return vtkExplicitStructuredGrid_GetMaxCellSize_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExplicitStructuredGrid_GetNumberOfCells_36(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override long GetNumberOfCells()
	{
		return vtkExplicitStructuredGrid_GetNumberOfCells_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExplicitStructuredGrid_GetNumberOfGenerationsFromBase_37(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExplicitStructuredGrid_GetNumberOfGenerationsFromBase_37(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExplicitStructuredGrid_GetNumberOfGenerationsFromBaseType_38(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExplicitStructuredGrid_GetNumberOfGenerationsFromBaseType_38(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_GetPointCells_39(HandleRef pThis, long ptId, HandleRef cellIds);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void GetPointCells(long ptId, vtkIdList cellIds)
	{
		vtkExplicitStructuredGrid_GetPointCells_39(GetCppThis(), ptId, cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExplicitStructuredGrid_HasAnyBlankCells_40(HandleRef pThis);

	/// <summary>
	/// Returns true if one or more cells are blanked, false otherwise.
	/// </summary>
	public override bool HasAnyBlankCells()
	{
		return (vtkExplicitStructuredGrid_HasAnyBlankCells_40(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExplicitStructuredGrid_HasAnyGhostCells_41(HandleRef pThis);

	/// <summary>
	/// Returns true if one or more cells are ghost, false otherwise.
	/// </summary>
	public new bool HasAnyGhostCells()
	{
		return (vtkExplicitStructuredGrid_HasAnyGhostCells_41(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_Initialize_42(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void Initialize()
	{
		vtkExplicitStructuredGrid_Initialize_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExplicitStructuredGrid_IsA_43(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExplicitStructuredGrid_IsA_43(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExplicitStructuredGrid_IsCellGhost_44(HandleRef pThis, long cellId);

	/// <summary>
	/// Return non-zero value if specified cell is a ghost cell.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public byte IsCellGhost(long cellId)
	{
		return vtkExplicitStructuredGrid_IsCellGhost_44(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExplicitStructuredGrid_IsCellVisible_45(HandleRef pThis, long cellId);

	/// <summary>
	/// Return non-zero value if specified cell is visible.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public byte IsCellVisible(long cellId)
	{
		return vtkExplicitStructuredGrid_IsCellVisible_45(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExplicitStructuredGrid_IsTypeOf_46(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExplicitStructuredGrid_IsTypeOf_46(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExplicitStructuredGrid_NewInstance_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new vtkExplicitStructuredGrid NewInstance()
	{
		vtkExplicitStructuredGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExplicitStructuredGrid_NewInstance_48(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExplicitStructuredGrid_SafeDownCast_49(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkExplicitStructuredGrid SafeDownCast(vtkObjectBase o)
	{
		vtkExplicitStructuredGrid vtkExplicitStructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExplicitStructuredGrid_SafeDownCast_49(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExplicitStructuredGrid2 = (vtkExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExplicitStructuredGrid2.Register(null);
			}
		}
		return vtkExplicitStructuredGrid2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_SetCells_50(HandleRef pThis, HandleRef cells);

	/// <summary>
	/// Set/Get the cell array defining hexahedron.
	/// </summary>
	public void SetCells(vtkCellArray cells)
	{
		vtkExplicitStructuredGrid_SetCells_50(GetCppThis(), cells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_SetDimensions_51(HandleRef pThis, int i, int j, int k);

	/// <summary>
	/// Set/Get the dimensions of this structured dataset in term of number
	/// of points along each direction.
	/// This is just a convenience method which calls Set/GetExtent internally.
	/// </summary>
	public void SetDimensions(int i, int j, int k)
	{
		vtkExplicitStructuredGrid_SetDimensions_51(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_SetDimensions_52(HandleRef pThis, IntPtr dim);

	/// <summary>
	/// Set/Get the dimensions of this structured dataset in term of number
	/// of points along each direction.
	/// This is just a convenience method which calls Set/GetExtent internally.
	/// </summary>
	public void SetDimensions(IntPtr dim)
	{
		vtkExplicitStructuredGrid_SetDimensions_52(GetCppThis(), dim);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_SetExtent_53(HandleRef pThis, int x0, int x1, int y0, int y1, int z0, int z1);

	/// <summary>
	/// Set/Get the extent of this structured dataset in term of number
	/// of points along each direction.
	/// Setting the extent will reset the internal CellArray and Links
	/// and a correctly sized cell array will be created.
	/// The Extent is stored  in the order (X, Y, Z).
	/// </summary>
	public void SetExtent(int x0, int x1, int y0, int y1, int z0, int z1)
	{
		vtkExplicitStructuredGrid_SetExtent_53(GetCppThis(), x0, x1, y0, y1, z0, z1);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_SetExtent_54(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Set/Get the extent of this structured dataset in term of number
	/// of points along each direction.
	/// Setting the extent will reset the internal CellArray and Links
	/// and a correctly sized cell array will be created.
	/// The Extent is stored  in the order (X, Y, Z).
	/// </summary>
	public void SetExtent(IntPtr extent)
	{
		vtkExplicitStructuredGrid_SetExtent_54(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_SetFacesConnectivityFlagsArrayName_55(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of the faces connectivity flags array.
	/// </summary>
	public virtual void SetFacesConnectivityFlagsArrayName(string _arg)
	{
		vtkExplicitStructuredGrid_SetFacesConnectivityFlagsArrayName_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_ShallowCopy_56(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void ShallowCopy(vtkDataObject src)
	{
		vtkExplicitStructuredGrid_ShallowCopy_56(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExplicitStructuredGrid_UnBlankCell_57(HandleRef pThis, long cellId);

	/// <summary>
	/// Methods for supporting blanking of cells. Blanking turns on or off
	/// cells in the structured grid.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public void UnBlankCell(long cellId)
	{
		vtkExplicitStructuredGrid_UnBlankCell_57(GetCppThis(), cellId);
	}
}
