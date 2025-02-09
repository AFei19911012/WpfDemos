using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFitToHeightMapFilter
/// </summary>
/// <remarks>
///    adjust polydata to fit image height map
///
/// vtkFitToHeightMapFilter "drapes" or "covers" a height map image by
/// determining new point coordinates of an input polydata by projecting (in
/// the z-direction) onto the height map. Different projection approaches can
/// be used including projecting points, or averaging / taking the minimum /
/// taking the maximum of the cell's points or sampled interior points.  The
/// filter passes the input to the output, however new new point coordinates
/// are generated, and point normals are not passed through. Note that the
/// draping supports verts, lines, polygons, and triangle strips.
///
/// @warning
/// Since new point coordinates are generated, planar polygons may become
/// non-planar. To guarantee planarity, use a triangle mesh as input. Also
/// note that strategies based on averaging across a cell, or the points of a
/// cell, set the z-value for all of the cell's points to the same
/// value. However, as currently written, depending on the order in which
/// cells are processed, the last z-value set is the final value (since points
/// may be shared by multiple cells). Thus the filter works best with triangle
/// meshes, or if cells are topologically disconnected (i.e., points are only
/// used by one cell - use vtkShrinkFilter to topologically disconnect
/// the cells in a mesh).
///
/// @warning
/// The point normals are not passed through to the output as the projection
/// process may distort the projected polydata surface.
///
/// @warning
/// The interior cell sampling is currently carried out by triangulating the
/// cells, and then taking the centroid of each resulting triangle. Thus the
/// number of samples for each cell is (number of cell points - 2). Future
/// implementations may use a different sampling strategy.
///
/// @warning
/// Points outside of the height map image are clamped to the boundary of the
/// height map. This may produce unexpected behavior in some cases.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkTrimmedExtrusionFilter vtkShrinkFilter vtkShrinkPolyData
/// </seealso>
public class vtkFitToHeightMapFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Get a pointer to the height map.
	/// </summary>
	public enum FittingStrategy
	{
		/// <summary>enum member</summary>
		CELL_AVERAGE_HEIGHT = 6,
		/// <summary>enum member</summary>
		CELL_MAXIMUM_HEIGHT = 5,
		/// <summary>enum member</summary>
		CELL_MINIMUM_HEIGHT = 4,
		/// <summary>enum member</summary>
		POINT_AVERAGE_HEIGHT = 3,
		/// <summary>enum member</summary>
		POINT_MAXIMUM_HEIGHT = 2,
		/// <summary>enum member</summary>
		POINT_MINIMUM_HEIGHT = 1,
		/// <summary>enum member</summary>
		POINT_PROJECTION = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFitToHeightMapFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFitToHeightMapFilter()
	{
		MRClassNameKey = "class vtkFitToHeightMapFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFitToHeightMapFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFitToHeightMapFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFitToHeightMapFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public new static vtkFitToHeightMapFilter New()
	{
		vtkFitToHeightMapFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFitToHeightMapFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFitToHeightMapFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public vtkFitToHeightMapFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFitToHeightMapFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFitToHeightMapFilter_GetFittingStrategy_01(HandleRef pThis);

	/// <summary>
	/// Specify a strategy for fitting, or projecting, the polydata to the
	/// height field.  By default the points of the polydata are projected onto
	/// the height field (POINT_PROJECTION).  However, to preserve planarity,
	/// or to fit the polydata cells at the average/minimum/maximum height to
	/// the height field, different strategies can be used (i.e., placing the
	/// cells). The point-based strategies (e.g, POINT_MINIMUM_HEIGHT) set the
	/// cell at the minimum height of the cell's points (and so on). The
	/// cell-based strategies (e.g., CELL_MINIMUM_HEIGHT) sample the interior of
	/// the cell and place the cell at the minimum height (and so on) of the
	/// cell's sampled interior points.
	/// </summary>
	public virtual int GetFittingStrategy()
	{
		return vtkFitToHeightMapFilter_GetFittingStrategy_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFitToHeightMapFilter_GetHeightMap_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a pointer to the height map.
	/// </summary>
	public vtkImageData GetHeightMap()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFitToHeightMapFilter_GetHeightMap_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFitToHeightMapFilter_GetHeightMap_03(HandleRef pThis, HandleRef sourceInfo, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a pointer to the height map.
	/// </summary>
	public vtkImageData GetHeightMap(vtkInformationVector sourceInfo)
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFitToHeightMapFilter_GetHeightMap_03(GetCppThis(), sourceInfo?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFitToHeightMapFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFitToHeightMapFilter_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFitToHeightMapFilter_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFitToHeightMapFilter_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFitToHeightMapFilter_GetUseHeightMapOffset_06(HandleRef pThis);

	/// <summary>
	/// Indicate whether the z-offset from the image height map should be added
	/// to the final result. Some height map images are offset in z-coordinate
	/// which is independent of the height map values. By default this value is
	/// true.
	/// </summary>
	public virtual int GetUseHeightMapOffset()
	{
		return vtkFitToHeightMapFilter_GetUseHeightMapOffset_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFitToHeightMapFilter_IsA_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFitToHeightMapFilter_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFitToHeightMapFilter_IsTypeOf_08(string type);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFitToHeightMapFilter_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFitToHeightMapFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public new vtkFitToHeightMapFilter NewInstance()
	{
		vtkFitToHeightMapFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFitToHeightMapFilter_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFitToHeightMapFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFitToHeightMapFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type and printing.
	/// </summary>
	public new static vtkFitToHeightMapFilter SafeDownCast(vtkObjectBase o)
	{
		vtkFitToHeightMapFilter vtkFitToHeightMapFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFitToHeightMapFilter_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFitToHeightMapFilter2 = (vtkFitToHeightMapFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFitToHeightMapFilter2.Register(null);
			}
		}
		return vtkFitToHeightMapFilter2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFitToHeightMapFilter_SetFittingStrategy_12(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify a strategy for fitting, or projecting, the polydata to the
	/// height field.  By default the points of the polydata are projected onto
	/// the height field (POINT_PROJECTION).  However, to preserve planarity,
	/// or to fit the polydata cells at the average/minimum/maximum height to
	/// the height field, different strategies can be used (i.e., placing the
	/// cells). The point-based strategies (e.g, POINT_MINIMUM_HEIGHT) set the
	/// cell at the minimum height of the cell's points (and so on). The
	/// cell-based strategies (e.g., CELL_MINIMUM_HEIGHT) sample the interior of
	/// the cell and place the cell at the minimum height (and so on) of the
	/// cell's sampled interior points.
	/// </summary>
	public virtual void SetFittingStrategy(int _arg)
	{
		vtkFitToHeightMapFilter_SetFittingStrategy_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFitToHeightMapFilter_SetFittingStrategyToAverageHeight_13(HandleRef pThis);

	/// <summary>
	/// Specify a strategy for fitting, or projecting, the polydata to the
	/// height field.  By default the points of the polydata are projected onto
	/// the height field (POINT_PROJECTION).  However, to preserve planarity,
	/// or to fit the polydata cells at the average/minimum/maximum height to
	/// the height field, different strategies can be used (i.e., placing the
	/// cells). The point-based strategies (e.g, POINT_MINIMUM_HEIGHT) set the
	/// cell at the minimum height of the cell's points (and so on). The
	/// cell-based strategies (e.g., CELL_MINIMUM_HEIGHT) sample the interior of
	/// the cell and place the cell at the minimum height (and so on) of the
	/// cell's sampled interior points.
	/// </summary>
	public void SetFittingStrategyToAverageHeight()
	{
		vtkFitToHeightMapFilter_SetFittingStrategyToAverageHeight_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFitToHeightMapFilter_SetFittingStrategyToCellAverageHeight_14(HandleRef pThis);

	/// <summary>
	/// Specify a strategy for fitting, or projecting, the polydata to the
	/// height field.  By default the points of the polydata are projected onto
	/// the height field (POINT_PROJECTION).  However, to preserve planarity,
	/// or to fit the polydata cells at the average/minimum/maximum height to
	/// the height field, different strategies can be used (i.e., placing the
	/// cells). The point-based strategies (e.g, POINT_MINIMUM_HEIGHT) set the
	/// cell at the minimum height of the cell's points (and so on). The
	/// cell-based strategies (e.g., CELL_MINIMUM_HEIGHT) sample the interior of
	/// the cell and place the cell at the minimum height (and so on) of the
	/// cell's sampled interior points.
	/// </summary>
	public void SetFittingStrategyToCellAverageHeight()
	{
		vtkFitToHeightMapFilter_SetFittingStrategyToCellAverageHeight_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFitToHeightMapFilter_SetFittingStrategyToCellMaximumHeight_15(HandleRef pThis);

	/// <summary>
	/// Specify a strategy for fitting, or projecting, the polydata to the
	/// height field.  By default the points of the polydata are projected onto
	/// the height field (POINT_PROJECTION).  However, to preserve planarity,
	/// or to fit the polydata cells at the average/minimum/maximum height to
	/// the height field, different strategies can be used (i.e., placing the
	/// cells). The point-based strategies (e.g, POINT_MINIMUM_HEIGHT) set the
	/// cell at the minimum height of the cell's points (and so on). The
	/// cell-based strategies (e.g., CELL_MINIMUM_HEIGHT) sample the interior of
	/// the cell and place the cell at the minimum height (and so on) of the
	/// cell's sampled interior points.
	/// </summary>
	public void SetFittingStrategyToCellMaximumHeight()
	{
		vtkFitToHeightMapFilter_SetFittingStrategyToCellMaximumHeight_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFitToHeightMapFilter_SetFittingStrategyToCellMinimumHeight_16(HandleRef pThis);

	/// <summary>
	/// Specify a strategy for fitting, or projecting, the polydata to the
	/// height field.  By default the points of the polydata are projected onto
	/// the height field (POINT_PROJECTION).  However, to preserve planarity,
	/// or to fit the polydata cells at the average/minimum/maximum height to
	/// the height field, different strategies can be used (i.e., placing the
	/// cells). The point-based strategies (e.g, POINT_MINIMUM_HEIGHT) set the
	/// cell at the minimum height of the cell's points (and so on). The
	/// cell-based strategies (e.g., CELL_MINIMUM_HEIGHT) sample the interior of
	/// the cell and place the cell at the minimum height (and so on) of the
	/// cell's sampled interior points.
	/// </summary>
	public void SetFittingStrategyToCellMinimumHeight()
	{
		vtkFitToHeightMapFilter_SetFittingStrategyToCellMinimumHeight_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFitToHeightMapFilter_SetFittingStrategyToPointMaximumHeight_17(HandleRef pThis);

	/// <summary>
	/// Specify a strategy for fitting, or projecting, the polydata to the
	/// height field.  By default the points of the polydata are projected onto
	/// the height field (POINT_PROJECTION).  However, to preserve planarity,
	/// or to fit the polydata cells at the average/minimum/maximum height to
	/// the height field, different strategies can be used (i.e., placing the
	/// cells). The point-based strategies (e.g, POINT_MINIMUM_HEIGHT) set the
	/// cell at the minimum height of the cell's points (and so on). The
	/// cell-based strategies (e.g., CELL_MINIMUM_HEIGHT) sample the interior of
	/// the cell and place the cell at the minimum height (and so on) of the
	/// cell's sampled interior points.
	/// </summary>
	public void SetFittingStrategyToPointMaximumHeight()
	{
		vtkFitToHeightMapFilter_SetFittingStrategyToPointMaximumHeight_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFitToHeightMapFilter_SetFittingStrategyToPointMinimumHeight_18(HandleRef pThis);

	/// <summary>
	/// Specify a strategy for fitting, or projecting, the polydata to the
	/// height field.  By default the points of the polydata are projected onto
	/// the height field (POINT_PROJECTION).  However, to preserve planarity,
	/// or to fit the polydata cells at the average/minimum/maximum height to
	/// the height field, different strategies can be used (i.e., placing the
	/// cells). The point-based strategies (e.g, POINT_MINIMUM_HEIGHT) set the
	/// cell at the minimum height of the cell's points (and so on). The
	/// cell-based strategies (e.g., CELL_MINIMUM_HEIGHT) sample the interior of
	/// the cell and place the cell at the minimum height (and so on) of the
	/// cell's sampled interior points.
	/// </summary>
	public void SetFittingStrategyToPointMinimumHeight()
	{
		vtkFitToHeightMapFilter_SetFittingStrategyToPointMinimumHeight_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFitToHeightMapFilter_SetFittingStrategyToPointProjection_19(HandleRef pThis);

	/// <summary>
	/// Specify a strategy for fitting, or projecting, the polydata to the
	/// height field.  By default the points of the polydata are projected onto
	/// the height field (POINT_PROJECTION).  However, to preserve planarity,
	/// or to fit the polydata cells at the average/minimum/maximum height to
	/// the height field, different strategies can be used (i.e., placing the
	/// cells). The point-based strategies (e.g, POINT_MINIMUM_HEIGHT) set the
	/// cell at the minimum height of the cell's points (and so on). The
	/// cell-based strategies (e.g., CELL_MINIMUM_HEIGHT) sample the interior of
	/// the cell and place the cell at the minimum height (and so on) of the
	/// cell's sampled interior points.
	/// </summary>
	public void SetFittingStrategyToPointProjection()
	{
		vtkFitToHeightMapFilter_SetFittingStrategyToPointProjection_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFitToHeightMapFilter_SetHeightMapConnection_20(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify the pipeline connection to the height map.
	/// </summary>
	public void SetHeightMapConnection(vtkAlgorithmOutput algOutput)
	{
		vtkFitToHeightMapFilter_SetHeightMapConnection_20(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFitToHeightMapFilter_SetHeightMapData_21(HandleRef pThis, HandleRef idata);

	/// <summary>
	/// Set the height map for the filter.  Note that this method does not
	/// connect the pipeline. The algorithm will work on the input data as it is
	/// without updating the producer of the data.  See SetHeightMapConnection()
	/// for connecting the pipeline.
	/// </summary>
	public void SetHeightMapData(vtkImageData idata)
	{
		vtkFitToHeightMapFilter_SetHeightMapData_21(GetCppThis(), idata?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFitToHeightMapFilter_SetUseHeightMapOffset_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether the z-offset from the image height map should be added
	/// to the final result. Some height map images are offset in z-coordinate
	/// which is independent of the height map values. By default this value is
	/// true.
	/// </summary>
	public virtual void SetUseHeightMapOffset(int _arg)
	{
		vtkFitToHeightMapFilter_SetUseHeightMapOffset_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFitToHeightMapFilter_UseHeightMapOffsetOff_23(HandleRef pThis);

	/// <summary>
	/// Indicate whether the z-offset from the image height map should be added
	/// to the final result. Some height map images are offset in z-coordinate
	/// which is independent of the height map values. By default this value is
	/// true.
	/// </summary>
	public virtual void UseHeightMapOffsetOff()
	{
		vtkFitToHeightMapFilter_UseHeightMapOffsetOff_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFitToHeightMapFilter_UseHeightMapOffsetOn_24(HandleRef pThis);

	/// <summary>
	/// Indicate whether the z-offset from the image height map should be added
	/// to the final result. Some height map images are offset in z-coordinate
	/// which is independent of the height map values. By default this value is
	/// true.
	/// </summary>
	public virtual void UseHeightMapOffsetOn()
	{
		vtkFitToHeightMapFilter_UseHeightMapOffsetOn_24(GetCppThis());
	}
}
