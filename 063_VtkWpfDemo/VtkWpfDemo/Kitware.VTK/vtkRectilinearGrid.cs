using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRectilinearGrid
/// </summary>
/// <remarks>
///    a dataset that is topologically regular with variable spacing in the three coordinate
/// directions
///
/// vtkRectilinearGrid is a data object that is a concrete implementation of
/// vtkDataSet. vtkRectilinearGrid represents a geometric structure that is
/// topologically regular with variable spacing in the three coordinate
/// directions x-y-z.
///
/// To define a vtkRectilinearGrid, you must specify the dimensions of the
/// data and provide three arrays of values specifying the coordinates
/// along the x-y-z axes. The coordinate arrays are specified using three
/// vtkDataArray objects (one for x, one for y, one for z).
///
/// @warning
/// Make sure that the dimensions of the grid match the number of coordinates
/// in the x-y-z directions. If not, unpredictable results (including
/// program failure) may result. Also, you must supply coordinates in all
/// three directions, even if the dataset topology is 2D, 1D, or 0D.
/// </remarks>
public class vtkRectilinearGrid : vtkDataSet
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGrid";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRectilinearGrid()
	{
		MRClassNameKey = "class vtkRectilinearGrid";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGrid"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRectilinearGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRectilinearGrid New()
	{
		vtkRectilinearGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRectilinearGrid()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRectilinearGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkRectilinearGrid_ComputeBounds_01(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void ComputeBounds()
	{
		vtkRectilinearGrid_ComputeBounds_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearGrid_ComputeCellId_02(HandleRef pThis, IntPtr ijk);

	/// <summary>
	/// Given a location in structured coordinates (i-j-k), return the cell id.
	/// </summary>
	public long ComputeCellId(IntPtr ijk)
	{
		return vtkRectilinearGrid_ComputeCellId_02(GetCppThis(), ijk);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearGrid_ComputePointId_03(HandleRef pThis, IntPtr ijk);

	/// <summary>
	/// Given a location in structured coordinates (i-j-k), return the point id.
	/// </summary>
	public long ComputePointId(IntPtr ijk)
	{
		return vtkRectilinearGrid_ComputePointId_03(GetCppThis(), ijk);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGrid_ComputeStructuredCoordinates_04(HandleRef pThis, IntPtr x, IntPtr ijk, IntPtr pcoords);

	/// <summary>
	/// Convenience function computes the structured coordinates for a point x[3].
	/// The cell is specified by the array ijk[3], and the parametric coordinates
	/// in the cell are specified with pcoords[3]. The function returns a 0 if the
	/// point x is outside of the grid, and a 1 if inside the grid.
	/// </summary>
	public int ComputeStructuredCoordinates(IntPtr x, IntPtr ijk, IntPtr pcoords)
	{
		return vtkRectilinearGrid_ComputeStructuredCoordinates_04(GetCppThis(), x, ijk, pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_CopyStructure_05(HandleRef pThis, HandleRef ds);

	/// <summary>
	/// Copy the geometric and topological structure of an input rectilinear grid
	/// object.
	/// </summary>
	public override void CopyStructure(vtkDataSet ds)
	{
		vtkRectilinearGrid_CopyStructure_05(GetCppThis(), ds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_Crop_06(HandleRef pThis, IntPtr updateExtent);

	/// <summary>
	/// Reallocates and copies to set the Extent to the UpdateExtent.
	/// This is used internally when the exact extent is requested,
	/// and the source generated more than the update extent.
	/// </summary>
	public override void Crop(IntPtr updateExtent)
	{
		vtkRectilinearGrid_Crop_06(GetCppThis(), updateExtent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_DeepCopy_07(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void DeepCopy(vtkDataObject src)
	{
		vtkRectilinearGrid_DeepCopy_07(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGrid_ExtendedNew_08(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static vtkRectilinearGrid ExtendedNew()
	{
		vtkRectilinearGrid vtkRectilinearGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGrid_ExtendedNew_08(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRectilinearGrid2 = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRectilinearGrid2.Register(null);
			}
		}
		return vtkRectilinearGrid2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGrid_FindAndGetCell_09(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override vtkCell FindAndGetCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGrid_FindAndGetCell_09(GetCppThis(), x, cell?.GetCppThis() ?? default(HandleRef), cellId, tol2, ref subId, pcoords, weights, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkRectilinearGrid_FindCell_10(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override long FindCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		return vtkRectilinearGrid_FindCell_10(GetCppThis(), x, cell?.GetCppThis() ?? default(HandleRef), cellId, tol2, ref subId, pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearGrid_FindCell_11(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		return vtkRectilinearGrid_FindCell_11(GetCppThis(), x, cell?.GetCppThis() ?? default(HandleRef), gencell?.GetCppThis() ?? default(HandleRef), cellId, tol2, ref subId, pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearGrid_FindPoint_12(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public new long FindPoint(double x, double y, double z)
	{
		return vtkRectilinearGrid_FindPoint_12(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearGrid_FindPoint_13(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override long FindPoint(IntPtr x)
	{
		return vtkRectilinearGrid_FindPoint_13(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkRectilinearGrid_GetActualMemorySize_14(HandleRef pThis);

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
		return vtkRectilinearGrid_GetActualMemorySize_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGrid_GetCell_15(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override vtkCell GetCell(long cellId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGrid_GetCell_15(GetCppThis(), cellId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkRectilinearGrid_GetCell_16(HandleRef pThis, int i, int j, int k, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override vtkCell GetCell(int i, int j, int k)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGrid_GetCell_16(GetCppThis(), i, j, k, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkRectilinearGrid_GetCell_17(HandleRef pThis, long cellId, HandleRef cell);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void GetCell(long cellId, vtkGenericCell cell)
	{
		vtkRectilinearGrid_GetCell_17(GetCppThis(), cellId, cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_GetCellBounds_18(HandleRef pThis, long cellId, IntPtr bounds);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void GetCellBounds(long cellId, IntPtr bounds)
	{
		vtkRectilinearGrid_GetCellBounds_18(GetCppThis(), cellId, bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_GetCellDims_19(HandleRef pThis, IntPtr cellDims);

	/// <summary>
	/// Given the node dimensions of this grid instance, this method computes the
	/// node dimensions. The value in each dimension can will have a lowest value
	/// of "1" such that computing the total number of cells can be achieved by
	/// simply by cellDims[0]*cellDims[1]*cellDims[2].
	/// </summary>
	public void GetCellDims(IntPtr cellDims)
	{
		vtkRectilinearGrid_GetCellDims_19(GetCppThis(), cellDims);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_GetCellNeighbors_20(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds)
	{
		vtkRectilinearGrid_GetCellNeighbors_20(GetCppThis(), cellId, ptIds?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_GetCellNeighbors_21(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds, IntPtr seedLoc);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds, IntPtr seedLoc)
	{
		vtkRectilinearGrid_GetCellNeighbors_21(GetCppThis(), cellId, ptIds?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef), seedLoc);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_GetCellPoints_22(HandleRef pThis, long cellId, HandleRef ptIds);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void GetCellPoints(long cellId, vtkIdList ptIds)
	{
		vtkRectilinearGrid_GetCellPoints_22(GetCppThis(), cellId, ptIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearGrid_GetCellSize_23(HandleRef pThis, long cellId);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override long GetCellSize(long cellId)
	{
		return vtkRectilinearGrid_GetCellSize_23(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGrid_GetCellType_24(HandleRef pThis, long cellId);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override int GetCellType(long cellId)
	{
		return vtkRectilinearGrid_GetCellType_24(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGrid_GetData_25(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkRectilinearGrid GetData(vtkInformation info)
	{
		vtkRectilinearGrid vtkRectilinearGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGrid_GetData_25(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRectilinearGrid2 = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRectilinearGrid2.Register(null);
			}
		}
		return vtkRectilinearGrid2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGrid_GetData_26(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkRectilinearGrid GetData(vtkInformationVector v, int i)
	{
		vtkRectilinearGrid vtkRectilinearGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGrid_GetData_26(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRectilinearGrid2 = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRectilinearGrid2.Register(null);
			}
		}
		return vtkRectilinearGrid2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGrid_GetDataDimension_27(HandleRef pThis);

	/// <summary>
	/// Return the dimensionality of the data.
	/// </summary>
	public int GetDataDimension()
	{
		return vtkRectilinearGrid_GetDataDimension_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGrid_GetDataObjectType_28(HandleRef pThis);

	/// <summary>
	/// Return what type of dataset this is.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkRectilinearGrid_GetDataObjectType_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGrid_GetDimensions_29(HandleRef pThis);

	/// <summary>
	/// Get dimensions of this rectilinear grid dataset.
	/// </summary>
	public virtual int[] GetDimensions()
	{
		IntPtr intPtr = vtkRectilinearGrid_GetDimensions_29(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_GetDimensions_30(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Get dimensions of this rectilinear grid dataset.
	/// </summary>
	public virtual void GetDimensions(IntPtr data)
	{
		vtkRectilinearGrid_GetDimensions_30(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGrid_GetExtent_31(HandleRef pThis);

	/// <summary>
	/// Different ways to set the extent of the data array.  The extent
	/// should be set before the "Scalars" are set or allocated.
	/// The Extent is stored in the order (X, Y, Z).
	/// </summary>
	public virtual int[] GetExtent()
	{
		IntPtr intPtr = vtkRectilinearGrid_GetExtent_31(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_GetExtent_32(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Different ways to set the extent of the data array.  The extent
	/// should be set before the "Scalars" are set or allocated.
	/// The Extent is stored in the order (X, Y, Z).
	/// </summary>
	public virtual void GetExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkRectilinearGrid_GetExtent_32(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_GetExtent_33(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Different ways to set the extent of the data array.  The extent
	/// should be set before the "Scalars" are set or allocated.
	/// The Extent is stored in the order (X, Y, Z).
	/// </summary>
	public virtual void GetExtent(IntPtr _arg)
	{
		vtkRectilinearGrid_GetExtent_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGrid_GetExtentType_34(HandleRef pThis);

	/// <summary>
	/// Structured extent. The extent type is a 3D extent
	/// </summary>
	public override int GetExtentType()
	{
		return vtkRectilinearGrid_GetExtentType_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGrid_GetMaxCellSize_35(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override int GetMaxCellSize()
	{
		return vtkRectilinearGrid_GetMaxCellSize_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearGrid_GetNumberOfCells_36(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override long GetNumberOfCells()
	{
		return vtkRectilinearGrid_GetNumberOfCells_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearGrid_GetNumberOfGenerationsFromBase_37(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRectilinearGrid_GetNumberOfGenerationsFromBase_37(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearGrid_GetNumberOfGenerationsFromBaseType_38(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRectilinearGrid_GetNumberOfGenerationsFromBaseType_38(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearGrid_GetNumberOfPoints_39(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override long GetNumberOfPoints()
	{
		return vtkRectilinearGrid_GetNumberOfPoints_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGrid_GetNumberOfScalarComponents_40(HandleRef meta_data);

	/// <summary>
	/// Set/Get the number of scalar components for points. As with the
	/// SetScalarType method this is setting pipeline info.
	/// </summary>
	public static int GetNumberOfScalarComponents(vtkInformation meta_data)
	{
		return vtkRectilinearGrid_GetNumberOfScalarComponents_40(meta_data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGrid_GetNumberOfScalarComponents_41(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of scalar components for points. As with the
	/// SetScalarType method this is setting pipeline info.
	/// </summary>
	public int GetNumberOfScalarComponents()
	{
		return vtkRectilinearGrid_GetNumberOfScalarComponents_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGrid_GetPoint_42(HandleRef pThis, long ptId);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override double[] GetPoint(long ptId)
	{
		IntPtr intPtr = vtkRectilinearGrid_GetPoint_42(GetCppThis(), ptId);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_GetPoint_43(HandleRef pThis, long id, IntPtr x);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void GetPoint(long id, IntPtr x)
	{
		vtkRectilinearGrid_GetPoint_43(GetCppThis(), id, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_GetPoint_44(HandleRef pThis, int i, int j, int k, IntPtr p);

	/// <summary>
	/// Given the IJK-coordinates of the point, it returns the corresponding
	/// xyz-coordinates. The xyz coordinates are stored in the user-supplied
	/// array p.
	/// </summary>
	public void GetPoint(int i, int j, int k, IntPtr p)
	{
		vtkRectilinearGrid_GetPoint_44(GetCppThis(), i, j, k, p);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_GetPointCells_45(HandleRef pThis, long ptId, HandleRef cellIds);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void GetPointCells(long ptId, vtkIdList cellIds)
	{
		vtkRectilinearGrid_GetPointCells_45(GetCppThis(), ptId, cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_GetPoints_46(HandleRef pThis, HandleRef pnts);

	/// <summary>
	/// Given a user-supplied vtkPoints container object, this method fills in all
	/// the points of the RectilinearGrid.
	/// </summary>
	public void GetPoints(vtkPoints pnts)
	{
		vtkRectilinearGrid_GetPoints_46(GetCppThis(), pnts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGrid_GetScalarType_47(HandleRef meta_data);

	/// <summary>
	/// Set/Get the scalar data type for the points. This is setting pipeline info.
	/// </summary>
	public static int GetScalarType(vtkInformation meta_data)
	{
		return vtkRectilinearGrid_GetScalarType_47(meta_data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGrid_GetScalarType_48(HandleRef pThis);

	/// <summary>
	/// Set/Get the scalar data type for the points. This is setting pipeline info.
	/// </summary>
	public int GetScalarType()
	{
		return vtkRectilinearGrid_GetScalarType_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGrid_GetScalarTypeAsString_49(HandleRef pThis);

	/// <summary>
	/// Set/Get the scalar data type for the points. This is setting pipeline info.
	/// </summary>
	public string GetScalarTypeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkRectilinearGrid_GetScalarTypeAsString_49(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGrid_GetXCoordinates_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the grid coordinates in the x-direction.
	/// </summary>
	public virtual vtkDataArray GetXCoordinates()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGrid_GetXCoordinates_50(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkRectilinearGrid_GetYCoordinates_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the grid coordinates in the y-direction.
	/// </summary>
	public virtual vtkDataArray GetYCoordinates()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGrid_GetYCoordinates_51(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkRectilinearGrid_GetZCoordinates_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the grid coordinates in the z-direction.
	/// </summary>
	public virtual vtkDataArray GetZCoordinates()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGrid_GetZCoordinates_52(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkRectilinearGrid_HasAnyBlankCells_53(HandleRef pThis);

	/// <summary>
	/// Returns 1 if there is any visibility constraint on the cells,
	/// 0 otherwise.
	/// </summary>
	public override bool HasAnyBlankCells()
	{
		return (vtkRectilinearGrid_HasAnyBlankCells_53(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRectilinearGrid_HasAnyBlankPoints_54(HandleRef pThis);

	/// <summary>
	/// Returns 1 if there is any visibility constraint on the points,
	/// 0 otherwise.
	/// </summary>
	public override bool HasAnyBlankPoints()
	{
		return (vtkRectilinearGrid_HasAnyBlankPoints_54(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRectilinearGrid_HasNumberOfScalarComponents_55(HandleRef meta_data);

	/// <summary>
	/// Set/Get the number of scalar components for points. As with the
	/// SetScalarType method this is setting pipeline info.
	/// </summary>
	public static bool HasNumberOfScalarComponents(vtkInformation meta_data)
	{
		return (vtkRectilinearGrid_HasNumberOfScalarComponents_55(meta_data?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRectilinearGrid_HasScalarType_56(HandleRef meta_data);

	/// <summary>
	/// Set/Get the scalar data type for the points. This is setting pipeline info.
	/// </summary>
	public static bool HasScalarType(vtkInformation meta_data)
	{
		return (vtkRectilinearGrid_HasScalarType_56(meta_data?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_Initialize_57(HandleRef pThis);

	/// <summary>
	/// Restore object to initial state. Release memory back to system.
	/// </summary>
	public override void Initialize()
	{
		vtkRectilinearGrid_Initialize_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGrid_IsA_58(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRectilinearGrid_IsA_58(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRectilinearGrid_IsCellVisible_59(HandleRef pThis, long cellId);

	/// <summary>
	/// Return non-zero value if specified point is visible.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public byte IsCellVisible(long cellId)
	{
		return vtkRectilinearGrid_IsCellVisible_59(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRectilinearGrid_IsPointVisible_60(HandleRef pThis, long ptId);

	/// <summary>
	/// Return non-zero value if specified point is visible.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public byte IsPointVisible(long ptId)
	{
		return vtkRectilinearGrid_IsPointVisible_60(GetCppThis(), ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGrid_IsTypeOf_61(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRectilinearGrid_IsTypeOf_61(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGrid_NewInstance_63(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRectilinearGrid NewInstance()
	{
		vtkRectilinearGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGrid_NewInstance_63(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGrid_SafeDownCast_64(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRectilinearGrid SafeDownCast(vtkObjectBase o)
	{
		vtkRectilinearGrid vtkRectilinearGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGrid_SafeDownCast_64(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRectilinearGrid2 = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRectilinearGrid2.Register(null);
			}
		}
		return vtkRectilinearGrid2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_SetDimensions_65(HandleRef pThis, int i, int j, int k);

	/// <summary>
	/// Set dimensions of rectilinear grid dataset.
	/// This also sets the extent.
	/// </summary>
	public void SetDimensions(int i, int j, int k)
	{
		vtkRectilinearGrid_SetDimensions_65(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_SetDimensions_66(HandleRef pThis, IntPtr dim);

	/// <summary>
	/// Set dimensions of rectilinear grid dataset.
	/// This also sets the extent.
	/// </summary>
	public void SetDimensions(IntPtr dim)
	{
		vtkRectilinearGrid_SetDimensions_66(GetCppThis(), dim);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_SetExtent_67(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Different ways to set the extent of the data array.  The extent
	/// should be set before the "Scalars" are set or allocated.
	/// The Extent is stored in the order (X, Y, Z).
	/// </summary>
	public void SetExtent(IntPtr extent)
	{
		vtkRectilinearGrid_SetExtent_67(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_SetExtent_68(HandleRef pThis, int xMin, int xMax, int yMin, int yMax, int zMin, int zMax);

	/// <summary>
	/// Different ways to set the extent of the data array.  The extent
	/// should be set before the "Scalars" are set or allocated.
	/// The Extent is stored in the order (X, Y, Z).
	/// </summary>
	public void SetExtent(int xMin, int xMax, int yMin, int yMax, int zMin, int zMax)
	{
		vtkRectilinearGrid_SetExtent_68(GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_SetNumberOfScalarComponents_69(int n, HandleRef meta_data);

	/// <summary>
	/// Set/Get the number of scalar components for points. As with the
	/// SetScalarType method this is setting pipeline info.
	/// </summary>
	public static void SetNumberOfScalarComponents(int n, vtkInformation meta_data)
	{
		vtkRectilinearGrid_SetNumberOfScalarComponents_69(n, meta_data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_SetScalarType_70(int arg0, HandleRef meta_data);

	/// <summary>
	/// Set/Get the scalar data type for the points. This is setting pipeline info.
	/// </summary>
	public static void SetScalarType(int arg0, vtkInformation meta_data)
	{
		vtkRectilinearGrid_SetScalarType_70(arg0, meta_data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_SetXCoordinates_71(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the grid coordinates in the x-direction.
	/// </summary>
	public virtual void SetXCoordinates(vtkDataArray arg0)
	{
		vtkRectilinearGrid_SetXCoordinates_71(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_SetYCoordinates_72(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the grid coordinates in the y-direction.
	/// </summary>
	public virtual void SetYCoordinates(vtkDataArray arg0)
	{
		vtkRectilinearGrid_SetYCoordinates_72(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_SetZCoordinates_73(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the grid coordinates in the z-direction.
	/// </summary>
	public virtual void SetZCoordinates(vtkDataArray arg0)
	{
		vtkRectilinearGrid_SetZCoordinates_73(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGrid_ShallowCopy_74(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void ShallowCopy(vtkDataObject src)
	{
		vtkRectilinearGrid_ShallowCopy_74(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}
}
