using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStructuredData
/// </summary>
/// <remarks>
///    Singleton class for topologically regular data
///
///
/// vtkStructuredData is a singleton class that provides an interface for
/// topologically regular data. Regular data is data that can be accessed
/// in rectangular fashion using an i-j-k index. A finite difference grid,
/// a volume, or a pixmap are all considered regular.
///
/// </remarks>
/// <seealso>
///
/// vtkStructuredGrid vtkUniformGrid vtkRectilinearGrid vtkRectilinearGrid
/// </seealso>
public class vtkStructuredData : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStructuredData()
	{
		MRClassNameKey = "class vtkStructuredData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStructuredData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern long vtkStructuredData_ComputeCellId_01(IntPtr dim, IntPtr ijk, int dataDescription);

	/// <summary>
	/// Given a location in structured coordinates (i-j-k), and the dimensions
	/// of the structured dataset, return the cell id.  This method does not
	/// adjust for the beginning of the extent.
	/// The dataDescription argument is not used.
	/// </summary>
	public static long ComputeCellId(IntPtr dim, IntPtr ijk, int dataDescription)
	{
		return vtkStructuredData_ComputeCellId_01(dim, ijk, dataDescription);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredData_ComputeCellIdForExtent_02(IntPtr extent, IntPtr ijk, int dataDescription);

	/// <summary>
	/// Given a location in structured coordinates (i-j-k), and the extent
	/// of the structured dataset, return the point id.
	/// The dataDescription argument is not used.
	/// </summary>
	public static long ComputeCellIdForExtent(IntPtr extent, IntPtr ijk, int dataDescription)
	{
		return vtkStructuredData_ComputeCellIdForExtent_02(extent, ijk, dataDescription);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredData_ComputeCellStructuredCoords_03(long cellId, IntPtr dim, IntPtr ijk, int dataDescription);

	/// <summary>
	/// Given a cellId and grid dimensions 'dim', get the structured coordinates
	/// (i-j-k). This method does not adjust for the beginning of the extent.
	/// The dataDescription argument is not used.
	/// </summary>
	public static void ComputeCellStructuredCoords(long cellId, IntPtr dim, IntPtr ijk, int dataDescription)
	{
		vtkStructuredData_ComputeCellStructuredCoords_03(cellId, dim, ijk, dataDescription);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredData_ComputeCellStructuredCoordsForExtent_04(long cellIdx, IntPtr ext, IntPtr ijk, int dataDescription);

	/// <summary>
	/// Given the global grid extent and the linear index of a cell within the
	/// grid extent, this method computes the corresponding structured coordinates
	/// of the given cell. This method adjusts for the beginning of the extent.
	/// The dataDescription argument is not used.
	/// </summary>
	public static void ComputeCellStructuredCoordsForExtent(long cellIdx, IntPtr ext, IntPtr ijk, int dataDescription)
	{
		vtkStructuredData_ComputeCellStructuredCoordsForExtent_04(cellIdx, ext, ijk, dataDescription);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredData_ComputePointId_05(IntPtr dim, IntPtr ijk, int dataDescription);

	/// <summary>
	/// Given a location in structured coordinates (i-j-k), and the dimensions
	/// of the structured dataset, return the point id.  This method does not
	/// adjust for the beginning of the extent.
	/// The dataDescription argument is not used.
	/// </summary>
	public static long ComputePointId(IntPtr dim, IntPtr ijk, int dataDescription)
	{
		return vtkStructuredData_ComputePointId_05(dim, ijk, dataDescription);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredData_ComputePointIdForExtent_06(IntPtr extent, IntPtr ijk, int dataDescription);

	/// <summary>
	/// Given a location in structured coordinates (i-j-k), and the extent
	/// of the structured dataset, return the point id.
	/// The dataDescription argument is not used.
	/// </summary>
	public static long ComputePointIdForExtent(IntPtr extent, IntPtr ijk, int dataDescription)
	{
		return vtkStructuredData_ComputePointIdForExtent_06(extent, ijk, dataDescription);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredData_ComputePointStructuredCoords_07(long ptId, IntPtr dim, IntPtr ijk, int dataDescription);

	/// <summary>
	/// Given a pointId and grid dimensions 'dim', get the structured coordinates
	/// (i-j-k). This method does not adjust for the beginning of the extent.
	/// The dataDescription argument is not used.
	/// </summary>
	public static void ComputePointStructuredCoords(long ptId, IntPtr dim, IntPtr ijk, int dataDescription)
	{
		vtkStructuredData_ComputePointStructuredCoords_07(ptId, dim, ijk, dataDescription);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredData_ComputePointStructuredCoordsForExtent_08(long ptId, IntPtr ext, IntPtr ijk, int dataDescription);

	/// <summary>
	/// Given a pointId and the grid extent ext, get the structured coordinates
	/// (i-j-k). This method adjusts for the beginning of the extent.
	/// The dataDescription argument is not used.
	/// </summary>
	public static void ComputePointStructuredCoordsForExtent(long ptId, IntPtr ext, IntPtr ijk, int dataDescription)
	{
		vtkStructuredData_ComputePointStructuredCoordsForExtent_08(ptId, ext, ijk, dataDescription);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredData_GetCellDimensionsFromExtent_09(IntPtr ext, IntPtr celldims, int dataDescription);

	/// <summary>
	/// Returns the cell dimensions, i.e., the number of cells along the i,j,k
	/// for the grid with the given grid extent. Note, the grid extent is the
	/// number of points.
	/// The dataDescription field is not used.
	/// </summary>
	public static void GetCellDimensionsFromExtent(IntPtr ext, IntPtr celldims, int dataDescription)
	{
		vtkStructuredData_GetCellDimensionsFromExtent_09(ext, celldims, dataDescription);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredData_GetCellDimensionsFromPointDimensions_10(IntPtr pntdims, IntPtr cellDims);

	/// <summary>
	/// Given the dimensions of the grid, in pntdims, this method returns
	/// the corresponding cell dimensions for the given grid.
	/// The dataDescription field is not used.
	/// </summary>
	public static void GetCellDimensionsFromPointDimensions(IntPtr pntdims, IntPtr cellDims)
	{
		vtkStructuredData_GetCellDimensionsFromPointDimensions_10(pntdims, cellDims);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredData_GetCellExtentFromPointExtent_11(IntPtr pntExtent, IntPtr cellExtent, int dataDescription);

	/// <summary>
	/// Given the point extent of a grid, this method computes the corresponding
	/// cell extent for the grid.
	/// The dataDescription field is not used.
	/// </summary>
	public static void GetCellExtentFromPointExtent(IntPtr pntExtent, IntPtr cellExtent, int dataDescription)
	{
		vtkStructuredData_GetCellExtentFromPointExtent_11(pntExtent, cellExtent, dataDescription);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredData_GetCellNeighbors_12(long cellId, HandleRef ptIds, HandleRef cellIds, IntPtr dim);

	/// <summary>
	/// Get the cells using the points ptIds, exclusive of the cell cellId.
	/// (See vtkDataSet for more info.)
	/// </summary>
	public static void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds, IntPtr dim)
	{
		vtkStructuredData_GetCellNeighbors_12(cellId, ptIds?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef), dim);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredData_GetCellNeighbors_13(long cellId, HandleRef ptIds, HandleRef cellIds, IntPtr dim, IntPtr seedLoc);

	/// <summary>
	/// Get the cells using the points ptIds, exclusive of the cell cellId.
	/// (See vtkDataSet for more info.)
	/// </summary>
	public static void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds, IntPtr dim, IntPtr seedLoc)
	{
		vtkStructuredData_GetCellNeighbors_13(cellId, ptIds?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef), dim, seedLoc);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredData_GetCellPoints_14(long cellId, HandleRef ptIds, int dataDescription, IntPtr dim);

	/// <summary>
	/// Get the points defining a cell. (See vtkDataSet for more info.)
	/// </summary>
	public static void GetCellPoints(long cellId, vtkIdList ptIds, int dataDescription, IntPtr dim)
	{
		vtkStructuredData_GetCellPoints_14(cellId, ptIds?.GetCppThis() ?? default(HandleRef), dataDescription, dim);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredData_GetDataDescription_15(IntPtr dims);

	/// <summary>
	/// Returns the data description given the dimensions (eg. VTK_SINGLE_POINT,
	/// VTK_X_LINE, VTK_XY_PLANE etc.)
	/// </summary>
	public static int GetDataDescription(IntPtr dims)
	{
		return vtkStructuredData_GetDataDescription_15(dims);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredData_GetDataDescriptionFromExtent_16(IntPtr ext);

	/// <summary>
	/// Returns the data description given the dimensions (eg. VTK_SINGLE_POINT,
	/// VTK_X_LINE, VTK_XY_PLANE etc.)
	/// </summary>
	public static int GetDataDescriptionFromExtent(IntPtr ext)
	{
		return vtkStructuredData_GetDataDescriptionFromExtent_16(ext);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredData_GetDataDimension_17(int dataDescription);

	/// <summary>
	/// Return the topological dimension of the data (e.g., 0, 1, 2, or 3D).
	/// </summary>
	public static int GetDataDimension(int dataDescription)
	{
		return vtkStructuredData_GetDataDimension_17(dataDescription);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredData_GetDataDimension_18(IntPtr ext);

	/// <summary>
	/// Return the topological dimension of the data (e.g., 0, 1, 2, or 3D).
	/// </summary>
	public static int GetDataDimension(IntPtr ext)
	{
		return vtkStructuredData_GetDataDimension_18(ext);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredData_GetDimensionsFromExtent_19(IntPtr ext, IntPtr dims, int dataDescription);

	/// <summary>
	/// Computes the structured grid dimensions based on the given extent.
	/// The dataDescription field is not used.
	/// </summary>
	public static void GetDimensionsFromExtent(IntPtr ext, IntPtr dims, int dataDescription)
	{
		vtkStructuredData_GetDimensionsFromExtent_19(ext, dims, dataDescription);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredData_GetGlobalStructuredCoordinates_20(IntPtr lijk, IntPtr ext, IntPtr ijk, int dataDescription);

	/// <summary>
	/// Given local structured coordinates, and the corresponding global sub-grid
	/// extent, this method computes the global ijk coordinates.
	/// The dataDescription parameter is not used.
	/// </summary>
	public static void GetGlobalStructuredCoordinates(IntPtr lijk, IntPtr ext, IntPtr ijk, int dataDescription)
	{
		vtkStructuredData_GetGlobalStructuredCoordinates_20(lijk, ext, ijk, dataDescription);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredData_GetLocalStructuredCoordinates_21(IntPtr ijk, IntPtr ext, IntPtr lijk, int dataDescription);

	/// <summary>
	/// Given the global structured coordinates for a point or cell, ijk, w.r.t.
	/// as well as, the global sub-grid cell or point extent, this method computes
	/// the corresponding local structured coordinates, lijk, starting from 0.
	/// The dataDescription argument is not used.
	/// </summary>
	public static void GetLocalStructuredCoordinates(IntPtr ijk, IntPtr ext, IntPtr lijk, int dataDescription)
	{
		vtkStructuredData_GetLocalStructuredCoordinates_21(ijk, ext, lijk, dataDescription);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredData_GetNumberOfCells_22(IntPtr ext, int dataDescription);

	/// <summary>
	/// Given the grid extent, this method returns the total number of cells
	/// within the extent.
	/// The dataDescription field is not used.
	/// </summary>
	public static long GetNumberOfCells(IntPtr ext, int dataDescription)
	{
		return vtkStructuredData_GetNumberOfCells_22(ext, dataDescription);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredData_GetNumberOfGenerationsFromBase_23(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStructuredData_GetNumberOfGenerationsFromBase_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredData_GetNumberOfGenerationsFromBaseType_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStructuredData_GetNumberOfGenerationsFromBaseType_24(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredData_GetNumberOfPoints_25(IntPtr ext, int dataDescription);

	/// <summary>
	/// Given the grid extent, this method returns the total number of points
	/// within the extent.
	/// The dataDescription field is not used.
	/// </summary>
	public static long GetNumberOfPoints(IntPtr ext, int dataDescription)
	{
		return vtkStructuredData_GetNumberOfPoints_25(ext, dataDescription);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredData_GetPointCells_26(long ptId, HandleRef cellIds, IntPtr dim);

	/// <summary>
	/// Get the cells using a point. (See vtkDataSet for more info.)
	/// </summary>
	public static void GetPointCells(long ptId, vtkIdList cellIds, IntPtr dim)
	{
		vtkStructuredData_GetPointCells_26(ptId, cellIds?.GetCppThis() ?? default(HandleRef), dim);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredData_IsA_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStructuredData_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStructuredData_IsCellVisible_28(long cellId, IntPtr dimensions, int dataDescription, HandleRef cellGhostArray, HandleRef pointGhostArray);

	/// <summary>
	/// Return non-zero value if specified cell is visible.
	/// </summary>
	public static bool IsCellVisible(long cellId, IntPtr dimensions, int dataDescription, vtkUnsignedCharArray cellGhostArray, vtkUnsignedCharArray pointGhostArray)
	{
		return (vtkStructuredData_IsCellVisible_28(cellId, dimensions, dataDescription, cellGhostArray?.GetCppThis() ?? default(HandleRef), pointGhostArray?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStructuredData_IsPointVisible_29(long cellId, HandleRef ghosts);

	/// <summary>
	/// Return non-zero value if specified point is visible.
	/// </summary>
	public static bool IsPointVisible(long cellId, vtkUnsignedCharArray ghosts)
	{
		return (vtkStructuredData_IsPointVisible_29(cellId, ghosts?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredData_IsTypeOf_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStructuredData_IsTypeOf_30(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredData_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkStructuredData NewInstance()
	{
		vtkStructuredData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredData_NewInstance_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStructuredData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredData_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStructuredData SafeDownCast(vtkObjectBase o)
	{
		vtkStructuredData vtkStructuredData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredData_SafeDownCast_32(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStructuredData2 = (vtkStructuredData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStructuredData2.Register(null);
			}
		}
		return vtkStructuredData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredData_SetDimensions_33(IntPtr inDim, IntPtr dim);

	/// <summary>
	/// Specify the dimensions of a regular, rectangular dataset. The input is
	/// the new dimensions (inDim) and the current dimensions (dim). The function
	/// returns the dimension of the dataset (0-3D). If the dimensions are
	/// improperly specified a -1 is returned. If the dimensions are unchanged, a
	/// value of 100 is returned.
	/// </summary>
	public static int SetDimensions(IntPtr inDim, IntPtr dim)
	{
		return vtkStructuredData_SetDimensions_33(inDim, dim);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredData_SetExtent_34(IntPtr inExt, IntPtr ext);

	/// <summary>
	/// Specify the dimensions of a regular, rectangular dataset. The input is
	/// the new dimensions (inDim) and the current dimensions (dim). The function
	/// returns the dimension of the dataset (0-3D). If the dimensions are
	/// improperly specified a -1 is returned. If the dimensions are unchanged, a
	/// value of 100 is returned.
	/// </summary>
	public static int SetExtent(IntPtr inExt, IntPtr ext)
	{
		return vtkStructuredData_SetExtent_34(inExt, ext);
	}
}
