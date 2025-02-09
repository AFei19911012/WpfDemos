using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStructuredGrid
/// </summary>
/// <remarks>
///    topologically regular array of data
///
/// vtkStructuredGrid is a data object that is a concrete implementation of
/// vtkDataSet. vtkStructuredGrid represents a geometric structure that is a
/// topologically regular array of points. The topology is that of a cube that
/// has been subdivided into a regular array of smaller cubes. Each point/cell
/// can be addressed with i-j-k indices. Examples include finite difference
/// grids.
///
/// The order and number of points must match that specified by the dimensions
/// of the grid. The point order increases in i fastest (from 0&lt;=i&lt;dims[0]),
/// then j (0&lt;=j&lt;dims[1]), then k (0&lt;=k&lt;dims[2]) where dims[] are the
/// dimensions of the grid in the i-j-k topological directions. The number of
/// points is dims[0]*dims[1]*dims[2]. The same is true for the cells of the
/// grid. The order and number of cells must match that specified by the
/// dimensions of the grid. The cell order increases in i fastest (from
/// 0&lt;=i&lt;(dims[0]-1)), then j (0&lt;=j&lt;(dims[1]-1)), then k (0&lt;=k&lt;(dims[2]-1))
/// The number of cells is (dims[0]-1)*(dims[1]-1)*(dims[2]-1).
///
/// vtkStructuredGrid has the ability to blank,
/// or "turn-off" points and cells in the dataset. This is done by setting
/// vtkDataSetAttributes::HIDDENPOINT or vtkDataSetAttributes::HIDDENCELL
/// in the ghost array for each point / cell that needs to be blanked.
/// </remarks>
public class vtkStructuredGrid : vtkPointSet
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGrid";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStructuredGrid()
	{
		MRClassNameKey = "class vtkStructuredGrid";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGrid"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStructuredGrid New()
	{
		vtkStructuredGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkStructuredGrid()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkStructuredGrid_BlankCell_01(HandleRef pThis, long ptId);

	/// <summary>
	/// Methods for supporting blanking of cells. Blanking turns on or off
	/// cells in the structured grid, and hence the points connected to them.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public void BlankCell(long ptId)
	{
		vtkStructuredGrid_BlankCell_01(GetCppThis(), ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_BlankPoint_02(HandleRef pThis, long ptId);

	/// <summary>
	/// Methods for supporting blanking of cells. Blanking turns on or off
	/// points in the structured grid, and hence the cells connected to them.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public void BlankPoint(long ptId)
	{
		vtkStructuredGrid_BlankPoint_02(GetCppThis(), ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_CopyStructure_03(HandleRef pThis, HandleRef ds);

	/// <summary>
	/// Copy the geometric and topological structure of an input poly data object.
	/// </summary>
	public override void CopyStructure(vtkDataSet ds)
	{
		vtkStructuredGrid_CopyStructure_03(GetCppThis(), ds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_Crop_04(HandleRef pThis, IntPtr updateExtent);

	/// <summary>
	/// Reallocates and copies to set the Extent to the UpdateExtent.
	/// This is used internally when the exact extent is requested,
	/// and the source generated more than the update extent.
	/// </summary>
	public override void Crop(IntPtr updateExtent)
	{
		vtkStructuredGrid_Crop_04(GetCppThis(), updateExtent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_DeepCopy_05(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void DeepCopy(vtkDataObject src)
	{
		vtkStructuredGrid_DeepCopy_05(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGrid_ExtendedNew_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStructuredGrid ExtendedNew()
	{
		vtkStructuredGrid vtkStructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredGrid_ExtendedNew_06(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStructuredGrid2 = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStructuredGrid2.Register(null);
			}
		}
		return vtkStructuredGrid2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkStructuredGrid_GetActualMemorySize_07(HandleRef pThis);

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
		return vtkStructuredGrid_GetActualMemorySize_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGrid_GetCell_08(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override vtkCell GetCell(long cellId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredGrid_GetCell_08(GetCppThis(), cellId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkStructuredGrid_GetCell_09(HandleRef pThis, int i, int j, int k, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override vtkCell GetCell(int i, int j, int k)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredGrid_GetCell_09(GetCppThis(), i, j, k, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkStructuredGrid_GetCell_10(HandleRef pThis, long cellId, HandleRef cell);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void GetCell(long cellId, vtkGenericCell cell)
	{
		vtkStructuredGrid_GetCell_10(GetCppThis(), cellId, cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_GetCellBounds_11(HandleRef pThis, long cellId, IntPtr bounds);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void GetCellBounds(long cellId, IntPtr bounds)
	{
		vtkStructuredGrid_GetCellBounds_11(GetCppThis(), cellId, bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_GetCellDims_12(HandleRef pThis, IntPtr cellDims);

	/// <summary>
	/// Given the node dimensions of this grid instance, this method computes the
	/// node dimensions. The value in each dimension can will have a lowest value
	/// of "1" such that computing the total number of cells can be achieved by
	/// simply by cellDims[0]*cellDims[1]*cellDims[2].
	/// </summary>
	public void GetCellDims(IntPtr cellDims)
	{
		vtkStructuredGrid_GetCellDims_12(GetCppThis(), cellDims);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_GetCellNeighbors_13(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds)
	{
		vtkStructuredGrid_GetCellNeighbors_13(GetCppThis(), cellId, ptIds?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_GetCellNeighbors_14(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds, IntPtr seedLoc);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds, IntPtr seedLoc)
	{
		vtkStructuredGrid_GetCellNeighbors_14(GetCppThis(), cellId, ptIds?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef), seedLoc);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_GetCellPoints_15(HandleRef pThis, long cellId, HandleRef ptIds);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void GetCellPoints(long cellId, vtkIdList ptIds)
	{
		vtkStructuredGrid_GetCellPoints_15(GetCppThis(), cellId, ptIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredGrid_GetCellSize_16(HandleRef pThis, long cellId);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override long GetCellSize(long cellId)
	{
		return vtkStructuredGrid_GetCellSize_16(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredGrid_GetCellType_17(HandleRef pThis, long cellId);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override int GetCellType(long cellId)
	{
		return vtkStructuredGrid_GetCellType_17(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGrid_GetData_18(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkStructuredGrid GetData(vtkInformation info)
	{
		vtkStructuredGrid vtkStructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredGrid_GetData_18(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStructuredGrid2 = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStructuredGrid2.Register(null);
			}
		}
		return vtkStructuredGrid2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGrid_GetData_19(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkStructuredGrid GetData(vtkInformationVector v, int i)
	{
		vtkStructuredGrid vtkStructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredGrid_GetData_19(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStructuredGrid2 = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStructuredGrid2.Register(null);
			}
		}
		return vtkStructuredGrid2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredGrid_GetDataDimension_20(HandleRef pThis);

	/// <summary>
	/// Return the dimensionality of the data.
	/// </summary>
	public int GetDataDimension()
	{
		return vtkStructuredGrid_GetDataDimension_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredGrid_GetDataObjectType_21(HandleRef pThis);

	/// <summary>
	/// Return what type of dataset this is.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkStructuredGrid_GetDataObjectType_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_GetDimensions_22(HandleRef pThis, IntPtr dims);

	/// <summary>
	/// Get dimensions of this structured grid based on its extent.
	/// </summary>
	public virtual void GetDimensions(IntPtr dims)
	{
		vtkStructuredGrid_GetDimensions_22(GetCppThis(), dims);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGrid_GetExtent_23(HandleRef pThis);

	/// <summary>
	/// Different ways to set the extent of the data array.  The extent
	/// should be set before the "Scalars" are set or allocated.
	/// The Extent is stored in the order (X, Y, Z).
	/// </summary>
	public virtual int[] GetExtent()
	{
		IntPtr intPtr = vtkStructuredGrid_GetExtent_23(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_GetExtent_24(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Different ways to set the extent of the data array.  The extent
	/// should be set before the "Scalars" are set or allocated.
	/// The Extent is stored in the order (X, Y, Z).
	/// </summary>
	public virtual void GetExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkStructuredGrid_GetExtent_24(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_GetExtent_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Different ways to set the extent of the data array.  The extent
	/// should be set before the "Scalars" are set or allocated.
	/// The Extent is stored in the order (X, Y, Z).
	/// </summary>
	public virtual void GetExtent(IntPtr _arg)
	{
		vtkStructuredGrid_GetExtent_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredGrid_GetExtentType_26(HandleRef pThis);

	/// <summary>
	/// The extent type is a 3D extent
	/// </summary>
	public override int GetExtentType()
	{
		return vtkStructuredGrid_GetExtentType_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredGrid_GetMaxCellSize_27(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override int GetMaxCellSize()
	{
		return vtkStructuredGrid_GetMaxCellSize_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredGrid_GetNumberOfCells_28(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override long GetNumberOfCells()
	{
		return vtkStructuredGrid_GetNumberOfCells_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredGrid_GetNumberOfGenerationsFromBase_29(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStructuredGrid_GetNumberOfGenerationsFromBase_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredGrid_GetNumberOfGenerationsFromBaseType_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStructuredGrid_GetNumberOfGenerationsFromBaseType_30(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredGrid_GetNumberOfPoints_31(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override long GetNumberOfPoints()
	{
		return vtkStructuredGrid_GetNumberOfPoints_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGrid_GetPoint_32(HandleRef pThis, long ptId);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override double[] GetPoint(long ptId)
	{
		IntPtr intPtr = vtkStructuredGrid_GetPoint_32(GetCppThis(), ptId);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_GetPoint_33(HandleRef pThis, long ptId, IntPtr p);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void GetPoint(long ptId, IntPtr p)
	{
		vtkStructuredGrid_GetPoint_33(GetCppThis(), ptId, p);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_GetPoint_34(HandleRef pThis, int i, int j, int k, IntPtr p, byte adjustForExtent);

	/// <summary>
	/// Get a point in the grid. If adjustForExtent is true, (i,j,k) is
	/// interpreted as a position relative to the beginning of the extent.
	/// If adjustForExtent is false, (i,j,k) is interpreted literally
	/// and the (i,j,k) point of the grid is returned regardless of the
	/// extent beginning.
	/// The point coordinate is returned in 'p'.
	/// The default adjustForExtent is true.
	/// </summary>
	public void GetPoint(int i, int j, int k, IntPtr p, bool adjustForExtent)
	{
		vtkStructuredGrid_GetPoint_34(GetCppThis(), i, j, k, p, (byte)(adjustForExtent ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_GetPointCells_35(HandleRef pThis, long ptId, HandleRef cellIds);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void GetPointCells(long ptId, vtkIdList cellIds)
	{
		vtkStructuredGrid_GetPointCells_35(GetCppThis(), ptId, cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStructuredGrid_HasAnyBlankCells_36(HandleRef pThis);

	/// <summary>
	/// Returns 1 if there is any visibility constraint on the cells,
	/// 0 otherwise.
	/// </summary>
	public override bool HasAnyBlankCells()
	{
		return (vtkStructuredGrid_HasAnyBlankCells_36(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStructuredGrid_HasAnyBlankPoints_37(HandleRef pThis);

	/// <summary>
	/// Returns 1 if there is any visibility constraint on the points,
	/// 0 otherwise.
	/// </summary>
	public override bool HasAnyBlankPoints()
	{
		return (vtkStructuredGrid_HasAnyBlankPoints_37(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_Initialize_38(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void Initialize()
	{
		vtkStructuredGrid_Initialize_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredGrid_IsA_39(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStructuredGrid_IsA_39(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStructuredGrid_IsCellVisible_40(HandleRef pThis, long cellId);

	/// <summary>
	/// Return non-zero value if specified point is visible.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public byte IsCellVisible(long cellId)
	{
		return vtkStructuredGrid_IsCellVisible_40(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStructuredGrid_IsPointVisible_41(HandleRef pThis, long ptId);

	/// <summary>
	/// Return non-zero value if specified point is visible.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public byte IsPointVisible(long ptId)
	{
		return vtkStructuredGrid_IsPointVisible_41(GetCppThis(), ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredGrid_IsTypeOf_42(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStructuredGrid_IsTypeOf_42(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGrid_NewInstance_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkStructuredGrid NewInstance()
	{
		vtkStructuredGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredGrid_NewInstance_44(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGrid_SafeDownCast_45(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStructuredGrid SafeDownCast(vtkObjectBase o)
	{
		vtkStructuredGrid vtkStructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredGrid_SafeDownCast_45(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStructuredGrid2 = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStructuredGrid2.Register(null);
			}
		}
		return vtkStructuredGrid2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_SetDimensions_46(HandleRef pThis, int i, int j, int k);

	/// <summary>
	/// Sets the extent to be 0 to i-1, 0 to j-1, and 0 to k-1.
	/// </summary>
	public void SetDimensions(int i, int j, int k)
	{
		vtkStructuredGrid_SetDimensions_46(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_SetDimensions_47(HandleRef pThis, IntPtr dims);

	/// <summary>
	/// Sets the extent to be 0 to dim[i]-1 in all 3 dimensions.
	/// </summary>
	public void SetDimensions(IntPtr dims)
	{
		vtkStructuredGrid_SetDimensions_47(GetCppThis(), dims);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_SetExtent_48(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Different ways to set the extent of the data array.  The extent
	/// should be set before the "Scalars" are set or allocated.
	/// The Extent is stored in the order (X, Y, Z).
	/// </summary>
	public void SetExtent(IntPtr extent)
	{
		vtkStructuredGrid_SetExtent_48(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_SetExtent_49(HandleRef pThis, int xMin, int xMax, int yMin, int yMax, int zMin, int zMax);

	/// <summary>
	/// Different ways to set the extent of the data array.  The extent
	/// should be set before the "Scalars" are set or allocated.
	/// The Extent is stored in the order (X, Y, Z).
	/// </summary>
	public void SetExtent(int xMin, int xMax, int yMin, int yMax, int zMin, int zMax)
	{
		vtkStructuredGrid_SetExtent_49(GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_ShallowCopy_50(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void ShallowCopy(vtkDataObject src)
	{
		vtkStructuredGrid_ShallowCopy_50(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_UnBlankCell_51(HandleRef pThis, long ptId);

	/// <summary>
	/// Methods for supporting blanking of cells. Blanking turns on or off
	/// cells in the structured grid, and hence the points connected to them.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public void UnBlankCell(long ptId)
	{
		vtkStructuredGrid_UnBlankCell_51(GetCppThis(), ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGrid_UnBlankPoint_52(HandleRef pThis, long ptId);

	/// <summary>
	/// Methods for supporting blanking of cells. Blanking turns on or off
	/// points in the structured grid, and hence the cells connected to them.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public void UnBlankPoint(long ptId)
	{
		vtkStructuredGrid_UnBlankPoint_52(GetCppThis(), ptId);
	}
}
