using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolyDataEdgeConnectivityFilter
/// </summary>
/// <remarks>
///    segment polygonal mesh based on shared edge connectivity
///
/// vtkPolyDataEdgeConnectivityFilter is a filter to segment cells that
/// share common edges (i.e., are edge connected), given certain conditions on
/// edge connectivity. These conditions are 1) the shared edge is not a
/// barrier edge, and 2) the edge neighbor satisfies conditions on scalar
/// values.  Specification of both #1 and #2 are optional; in which case all
/// polygons in a region that share edges are connected. Barrier edges are
/// either defined by providing an optional second polydata input (which
/// contains a list of lines defining the barrier edges), or a condition on
/// edge length. The conditions on edge length specify whether edges within a
/// range of edge lengths are considered barrier edges.  All connected
/// polygonal cells satisfying these conditions form a region. Typically the
/// filter segments multiple regions; however the user can specify which
/// region(s) are to be extracted and output.
///
/// The filter works in one of seven ways: 1) extract the largest (in terms of
/// total surface area) edge-connected region in the dataset; 2) extract
/// specified regions; 3) extract all regions containing user-specified
/// point ids; 4) extract all regions containing user-specified cell ids; 5)
/// extract the region closest to a user-specified point; 6) extract all
/// edge-connected regions (used to color regions, i.e., create segmentation
/// labeling); or 7) extract "large" regions, that is all regions considered
/// large in terms of their surface area relative to the total input polydata
/// surface area.
///
/// Barrier edges add a unique twist to the filter. By using them, it is
/// possible to segment out portions of a mesh with very small, very large, or
/// in between polygon-sized features.
///
/// Due to the nature of edge connectivity, the filter only operates on
/// polygons. Vertices, lines, and triangle strips are ignored (and not passed
/// through to the output). Point and cell attribute data are copied to the
/// output; however, an additional, optional array named "RegionId" may be
/// added to the output cell attribute data by enabling ColorRegions.
///
/// @warning
/// If more than one output region is produced, regions are sorted based on
/// their surface area. Thus region# 0 is the largest, followed by the next
/// largest and so on.
///
/// @warning
/// To be clear: if scalar connectivity is enabled, this filter segments data
/// based on *cell* attribute data based on edge-connected meshes. The similar
/// vtkPolyDataConnectivityFilter segments based on point attribute data and
/// point-connected meshes.
///
/// @warning
/// A second, optional vtkPolyData (the Source) may be specified which
/// contains edges (i.e., vtkPolyData::Lines) that specify barries to edge
/// connectivity. That is, two polygons who share an edge are not connected if
/// the shared edge exists in the Source vtkPolyData. This feature can be used
/// with other filters such as vtkDelaunay2D (and its constraint edges) to
/// create segmented regions.
///
/// @warning
/// Note that mesh regions attached at just a point are not considered
/// connected. Thus such point-connected meshes will be segmented into
/// different regions. This differs from vtkPolyDataConnectivityFilter which
/// segments produces point-connected regions.
///
/// </remarks>
/// <seealso>
///
/// vtkPolyDataConnectivityFilter vtkConnectivityFilter vtkDelaunay2D
/// </seealso>
public class vtkPolyDataEdgeConnectivityFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Use to specify x-y-z point coordinates when extracting the region
	/// closest to a specified point.
	/// </summary>
	public enum RegionGrowingType
	{
		/// <summary>enum member</summary>
		LargeRegions = 1,
		/// <summary>enum member</summary>
		RegionGrowingOff = 0,
		/// <summary>enum member</summary>
		SmallRegions = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataEdgeConnectivityFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolyDataEdgeConnectivityFilter()
	{
		MRClassNameKey = "class vtkPolyDataEdgeConnectivityFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataEdgeConnectivityFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolyDataEdgeConnectivityFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataEdgeConnectivityFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, get type information, and print the object.
	/// </summary>
	public new static vtkPolyDataEdgeConnectivityFilter New()
	{
		vtkPolyDataEdgeConnectivityFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataEdgeConnectivityFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataEdgeConnectivityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods to instantiate, get type information, and print the object.
	/// </summary>
	public vtkPolyDataEdgeConnectivityFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPolyDataEdgeConnectivityFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_AddSeed_01(HandleRef pThis, int id);

	/// <summary>
	/// Add a seed id (point or cell id). Note: ids are 0-offset.
	/// </summary>
	public void AddSeed(int id)
	{
		vtkPolyDataEdgeConnectivityFilter_AddSeed_01(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_AddSpecifiedRegion_02(HandleRef pThis, int id);

	/// <summary>
	/// Add a region id to extract. Note: ids are 0-offset.
	/// </summary>
	public void AddSpecifiedRegion(int id)
	{
		vtkPolyDataEdgeConnectivityFilter_AddSpecifiedRegion_02(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_BarrierEdgesOff_03(HandleRef pThis);

	/// <summary>
	/// Control connectivity traversal based on barrier edges. If enabled, then
	/// either the length of edges, or a explicit specification of barrier
	/// edges, is used to control what are considered connected edge neighbors.
	/// </summary>
	public virtual void BarrierEdgesOff()
	{
		vtkPolyDataEdgeConnectivityFilter_BarrierEdgesOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_BarrierEdgesOn_04(HandleRef pThis);

	/// <summary>
	/// Control connectivity traversal based on barrier edges. If enabled, then
	/// either the length of edges, or a explicit specification of barrier
	/// edges, is used to control what are considered connected edge neighbors.
	/// </summary>
	public virtual void BarrierEdgesOn()
	{
		vtkPolyDataEdgeConnectivityFilter_BarrierEdgesOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_CellRegionAreasOff_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off the creation of a cell array that, for each cell, contains
	/// the area of the region to which the cell is associated. If enabled, then
	/// an array named "CellRegionArea" is added to the output cell data.
	/// </summary>
	public virtual void CellRegionAreasOff()
	{
		vtkPolyDataEdgeConnectivityFilter_CellRegionAreasOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_CellRegionAreasOn_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off the creation of a cell array that, for each cell, contains
	/// the area of the region to which the cell is associated. If enabled, then
	/// an array named "CellRegionArea" is added to the output cell data.
	/// </summary>
	public virtual void CellRegionAreasOn()
	{
		vtkPolyDataEdgeConnectivityFilter_CellRegionAreasOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_ColorRegionsOff_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off the coloring of edge-connected regions. If enabled, then
	/// a array named "RegionId" is added to the output cell data. The array
	/// contains, for each cell, the id with which the cell is associated.
	/// </summary>
	public virtual void ColorRegionsOff()
	{
		vtkPolyDataEdgeConnectivityFilter_ColorRegionsOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_ColorRegionsOn_08(HandleRef pThis);

	/// <summary>
	/// Turn on/off the coloring of edge-connected regions. If enabled, then
	/// a array named "RegionId" is added to the output cell data. The array
	/// contains, for each cell, the id with which the cell is associated.
	/// </summary>
	public virtual void ColorRegionsOn()
	{
		vtkPolyDataEdgeConnectivityFilter_ColorRegionsOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_DeleteSeed_09(HandleRef pThis, int id);

	/// <summary>
	/// Delete a seed id (point or cell id). Note: ids are 0-offset.
	/// </summary>
	public void DeleteSeed(int id)
	{
		vtkPolyDataEdgeConnectivityFilter_DeleteSeed_09(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_DeleteSpecifiedRegion_10(HandleRef pThis, int id);

	/// <summary>
	/// Delete a region id to extract. Note: ids are 0-offset.
	/// </summary>
	public void DeleteSpecifiedRegion(int id)
	{
		vtkPolyDataEdgeConnectivityFilter_DeleteSpecifiedRegion_10(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataEdgeConnectivityFilter_GetBarrierEdgeLength_11(HandleRef pThis);

	/// <summary>
	/// Edges E of length edgeLen (BarrierEdgeLength[0]&lt;=edgeLen&lt;=BarrierEdgeLength[1])
	/// define barrier edges. If edgeLen falls within this range, then polygon
	/// cells on either side of the edge E are not neighbors, since the edge is
	/// a barrier edge. Note that a range of [VTK_DOUBLE_MAX,VTK_DOUBLE_MAX]
	/// (which is the default range) implies that all edges are not barrier
	/// edges (based on edge length).
	/// </summary>
	public virtual double[] GetBarrierEdgeLength()
	{
		IntPtr intPtr = vtkPolyDataEdgeConnectivityFilter_GetBarrierEdgeLength_11(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_GetBarrierEdgeLength_12(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Edges E of length edgeLen (BarrierEdgeLength[0]&lt;=edgeLen&lt;=BarrierEdgeLength[1])
	/// define barrier edges. If edgeLen falls within this range, then polygon
	/// cells on either side of the edge E are not neighbors, since the edge is
	/// a barrier edge. Note that a range of [VTK_DOUBLE_MAX,VTK_DOUBLE_MAX]
	/// (which is the default range) implies that all edges are not barrier
	/// edges (based on edge length).
	/// </summary>
	public virtual void GetBarrierEdgeLength(ref double _arg1, ref double _arg2)
	{
		vtkPolyDataEdgeConnectivityFilter_GetBarrierEdgeLength_12(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_GetBarrierEdgeLength_13(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Edges E of length edgeLen (BarrierEdgeLength[0]&lt;=edgeLen&lt;=BarrierEdgeLength[1])
	/// define barrier edges. If edgeLen falls within this range, then polygon
	/// cells on either side of the edge E are not neighbors, since the edge is
	/// a barrier edge. Note that a range of [VTK_DOUBLE_MAX,VTK_DOUBLE_MAX]
	/// (which is the default range) implies that all edges are not barrier
	/// edges (based on edge length).
	/// </summary>
	public virtual void GetBarrierEdgeLength(IntPtr _arg)
	{
		vtkPolyDataEdgeConnectivityFilter_GetBarrierEdgeLength_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataEdgeConnectivityFilter_GetBarrierEdges_14(HandleRef pThis);

	/// <summary>
	/// Control connectivity traversal based on barrier edges. If enabled, then
	/// either the length of edges, or a explicit specification of barrier
	/// edges, is used to control what are considered connected edge neighbors.
	/// </summary>
	public virtual int GetBarrierEdges()
	{
		return vtkPolyDataEdgeConnectivityFilter_GetBarrierEdges_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataEdgeConnectivityFilter_GetCellRegionAreas_15(HandleRef pThis);

	/// <summary>
	/// Turn on/off the creation of a cell array that, for each cell, contains
	/// the area of the region to which the cell is associated. If enabled, then
	/// an array named "CellRegionArea" is added to the output cell data.
	/// </summary>
	public virtual int GetCellRegionAreas()
	{
		return vtkPolyDataEdgeConnectivityFilter_GetCellRegionAreas_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataEdgeConnectivityFilter_GetClosestPoint_16(HandleRef pThis);

	/// <summary>
	/// Use to specify x-y-z point coordinates when extracting the region
	/// closest to a specified point.
	/// </summary>
	public virtual double[] GetClosestPoint()
	{
		IntPtr intPtr = vtkPolyDataEdgeConnectivityFilter_GetClosestPoint_16(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_GetClosestPoint_17(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Use to specify x-y-z point coordinates when extracting the region
	/// closest to a specified point.
	/// </summary>
	public virtual void GetClosestPoint(IntPtr data)
	{
		vtkPolyDataEdgeConnectivityFilter_GetClosestPoint_17(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataEdgeConnectivityFilter_GetColorRegions_18(HandleRef pThis);

	/// <summary>
	/// Turn on/off the coloring of edge-connected regions. If enabled, then
	/// a array named "RegionId" is added to the output cell data. The array
	/// contains, for each cell, the id with which the cell is associated.
	/// </summary>
	public virtual int GetColorRegions()
	{
		return vtkPolyDataEdgeConnectivityFilter_GetColorRegions_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataEdgeConnectivityFilter_GetExtractionMode_19(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public virtual int GetExtractionMode()
	{
		return vtkPolyDataEdgeConnectivityFilter_GetExtractionMode_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataEdgeConnectivityFilter_GetExtractionModeAsString_20(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public string GetExtractionModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkPolyDataEdgeConnectivityFilter_GetExtractionModeAsString_20(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataEdgeConnectivityFilter_GetExtractionModeMaxValue_21(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public virtual int GetExtractionModeMaxValue()
	{
		return vtkPolyDataEdgeConnectivityFilter_GetExtractionModeMaxValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataEdgeConnectivityFilter_GetExtractionModeMinValue_22(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public virtual int GetExtractionModeMinValue()
	{
		return vtkPolyDataEdgeConnectivityFilter_GetExtractionModeMinValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolyDataEdgeConnectivityFilter_GetLargeRegionThreshold_23(HandleRef pThis);

	/// <summary>
	/// Define what a large region is by specifying the fraction of total input
	/// mesh area a region must be in order to be considered large. So for
	/// example, if the LargeRegionThreshold is 0.10, then if the summed surface
	/// area of all the cells composing a region is greater than or equal to
	/// 10%, the region is considered large. By default, the LargeRegionThreshold
	/// is 0.05.
	/// </summary>
	public virtual double GetLargeRegionThreshold()
	{
		return vtkPolyDataEdgeConnectivityFilter_GetLargeRegionThreshold_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolyDataEdgeConnectivityFilter_GetLargeRegionThresholdMaxValue_24(HandleRef pThis);

	/// <summary>
	/// Define what a large region is by specifying the fraction of total input
	/// mesh area a region must be in order to be considered large. So for
	/// example, if the LargeRegionThreshold is 0.10, then if the summed surface
	/// area of all the cells composing a region is greater than or equal to
	/// 10%, the region is considered large. By default, the LargeRegionThreshold
	/// is 0.05.
	/// </summary>
	public virtual double GetLargeRegionThresholdMaxValue()
	{
		return vtkPolyDataEdgeConnectivityFilter_GetLargeRegionThresholdMaxValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolyDataEdgeConnectivityFilter_GetLargeRegionThresholdMinValue_25(HandleRef pThis);

	/// <summary>
	/// Define what a large region is by specifying the fraction of total input
	/// mesh area a region must be in order to be considered large. So for
	/// example, if the LargeRegionThreshold is 0.10, then if the summed surface
	/// area of all the cells composing a region is greater than or equal to
	/// 10%, the region is considered large. By default, the LargeRegionThreshold
	/// is 0.05.
	/// </summary>
	public virtual double GetLargeRegionThresholdMinValue()
	{
		return vtkPolyDataEdgeConnectivityFilter_GetLargeRegionThresholdMinValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataEdgeConnectivityFilter_GetNumberOfExtractedRegions_26(HandleRef pThis);

	/// <summary>
	/// Obtain the number of connected regions found. This returns valid
	/// information only after the filter has successfully executed.
	/// </summary>
	public int GetNumberOfExtractedRegions()
	{
		return vtkPolyDataEdgeConnectivityFilter_GetNumberOfExtractedRegions_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataEdgeConnectivityFilter_GetNumberOfGenerationsFromBase_27(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to instantiate, get type information, and print the object.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolyDataEdgeConnectivityFilter_GetNumberOfGenerationsFromBase_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataEdgeConnectivityFilter_GetNumberOfGenerationsFromBaseType_28(string type);

	/// <summary>
	/// Standard methods to instantiate, get type information, and print the object.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolyDataEdgeConnectivityFilter_GetNumberOfGenerationsFromBaseType_28(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataEdgeConnectivityFilter_GetNumberOfSpecifiedRegions_29(HandleRef pThis);

	/// <summary>
	/// Get number of specified regions.
	/// </summary>
	public int GetNumberOfSpecifiedRegions()
	{
		return vtkPolyDataEdgeConnectivityFilter_GetNumberOfSpecifiedRegions_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataEdgeConnectivityFilter_GetOutputPointsPrecision_30(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkPolyDataEdgeConnectivityFilter_GetOutputPointsPrecision_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataEdgeConnectivityFilter_GetRegionGrowing_31(HandleRef pThis);

	/// <summary>
	/// Specify a strategy for region growing. Regions growing is a
	/// postprocessing step which assimilates small regions into larger regions;
	/// i.e., region growing is an additional step as part of a segmentation
	/// workflow. By default, region growing is off. If growing large regions
	/// is enabled, then smaller regions are assimilated into larger regions. If
	/// growing small regions is enabled, then small regions are combined to
	/// form larger regions. Note that the definition of a large region is a
	/// region that exceeds the large region threshold.
	/// </summary>
	public virtual int GetRegionGrowing()
	{
		return vtkPolyDataEdgeConnectivityFilter_GetRegionGrowing_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataEdgeConnectivityFilter_GetRegionGrowingMaxValue_32(HandleRef pThis);

	/// <summary>
	/// Specify a strategy for region growing. Regions growing is a
	/// postprocessing step which assimilates small regions into larger regions;
	/// i.e., region growing is an additional step as part of a segmentation
	/// workflow. By default, region growing is off. If growing large regions
	/// is enabled, then smaller regions are assimilated into larger regions. If
	/// growing small regions is enabled, then small regions are combined to
	/// form larger regions. Note that the definition of a large region is a
	/// region that exceeds the large region threshold.
	/// </summary>
	public virtual int GetRegionGrowingMaxValue()
	{
		return vtkPolyDataEdgeConnectivityFilter_GetRegionGrowingMaxValue_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataEdgeConnectivityFilter_GetRegionGrowingMinValue_33(HandleRef pThis);

	/// <summary>
	/// Specify a strategy for region growing. Regions growing is a
	/// postprocessing step which assimilates small regions into larger regions;
	/// i.e., region growing is an additional step as part of a segmentation
	/// workflow. By default, region growing is off. If growing large regions
	/// is enabled, then smaller regions are assimilated into larger regions. If
	/// growing small regions is enabled, then small regions are combined to
	/// form larger regions. Note that the definition of a large region is a
	/// region that exceeds the large region threshold.
	/// </summary>
	public virtual int GetRegionGrowingMinValue()
	{
		return vtkPolyDataEdgeConnectivityFilter_GetRegionGrowingMinValue_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataEdgeConnectivityFilter_GetRegionSizes_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Obtain the array containing the region sizes of the extracted
	/// regions.
	/// </summary>
	public virtual vtkIdTypeArray GetRegionSizes()
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataEdgeConnectivityFilter_GetRegionSizes_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataEdgeConnectivityFilter_GetScalarConnectivity_35(HandleRef pThis);

	/// <summary>
	/// Turn on/off connectivity based on scalar value. If on, cells are
	/// connected only if they share a non-barrier edge AND and cell's scalar
	/// value falls within the scalar range specified.
	/// </summary>
	public virtual int GetScalarConnectivity()
	{
		return vtkPolyDataEdgeConnectivityFilter_GetScalarConnectivity_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataEdgeConnectivityFilter_GetScalarRange_36(HandleRef pThis);

	/// <summary>
	/// Set the scalar range to extract cells based on scalar connectivity.
	/// </summary>
	public virtual double[] GetScalarRange()
	{
		IntPtr intPtr = vtkPolyDataEdgeConnectivityFilter_GetScalarRange_36(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_GetScalarRange_37(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set the scalar range to extract cells based on scalar connectivity.
	/// </summary>
	public virtual void GetScalarRange(ref double _arg1, ref double _arg2)
	{
		vtkPolyDataEdgeConnectivityFilter_GetScalarRange_37(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_GetScalarRange_38(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the scalar range to extract cells based on scalar connectivity.
	/// </summary>
	public virtual void GetScalarRange(IntPtr _arg)
	{
		vtkPolyDataEdgeConnectivityFilter_GetScalarRange_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataEdgeConnectivityFilter_GetSource_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the source vtkPolyData object used to specify barrier edges
	/// (this is an optional connection.) If specified, the connected traversal
	/// cannot traverse across the edges indicated as they are defined as
	/// barrier edges. Also note that the data member BarrierEdges must be
	/// enabled.
	/// </summary>
	public vtkPolyData GetSource()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataEdgeConnectivityFilter_GetSource_39(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolyDataEdgeConnectivityFilter_GetTotalArea_40(HandleRef pThis);

	/// <summary>
	/// Obtain the total area of all regions combined.
	/// </summary>
	public double GetTotalArea()
	{
		return vtkPolyDataEdgeConnectivityFilter_GetTotalArea_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_GrowLargeRegionsOff_41(HandleRef pThis);

	/// <summary>
	/// Specify a strategy for region growing. Regions growing is a
	/// postprocessing step which assimilates small regions into larger regions;
	/// i.e., region growing is an additional step as part of a segmentation
	/// workflow. By default, region growing is off. If growing large regions
	/// is enabled, then smaller regions are assimilated into larger regions. If
	/// growing small regions is enabled, then small regions are combined to
	/// form larger regions. Note that the definition of a large region is a
	/// region that exceeds the large region threshold.
	/// </summary>
	public void GrowLargeRegionsOff()
	{
		vtkPolyDataEdgeConnectivityFilter_GrowLargeRegionsOff_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_GrowLargeRegionsOn_42(HandleRef pThis);

	/// <summary>
	/// Specify a strategy for region growing. Regions growing is a
	/// postprocessing step which assimilates small regions into larger regions;
	/// i.e., region growing is an additional step as part of a segmentation
	/// workflow. By default, region growing is off. If growing large regions
	/// is enabled, then smaller regions are assimilated into larger regions. If
	/// growing small regions is enabled, then small regions are combined to
	/// form larger regions. Note that the definition of a large region is a
	/// region that exceeds the large region threshold.
	/// </summary>
	public void GrowLargeRegionsOn()
	{
		vtkPolyDataEdgeConnectivityFilter_GrowLargeRegionsOn_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_GrowSmallRegionsOff_43(HandleRef pThis);

	/// <summary>
	/// Specify a strategy for region growing. Regions growing is a
	/// postprocessing step which assimilates small regions into larger regions;
	/// i.e., region growing is an additional step as part of a segmentation
	/// workflow. By default, region growing is off. If growing large regions
	/// is enabled, then smaller regions are assimilated into larger regions. If
	/// growing small regions is enabled, then small regions are combined to
	/// form larger regions. Note that the definition of a large region is a
	/// region that exceeds the large region threshold.
	/// </summary>
	public void GrowSmallRegionsOff()
	{
		vtkPolyDataEdgeConnectivityFilter_GrowSmallRegionsOff_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_GrowSmallRegionsOn_44(HandleRef pThis);

	/// <summary>
	/// Specify a strategy for region growing. Regions growing is a
	/// postprocessing step which assimilates small regions into larger regions;
	/// i.e., region growing is an additional step as part of a segmentation
	/// workflow. By default, region growing is off. If growing large regions
	/// is enabled, then smaller regions are assimilated into larger regions. If
	/// growing small regions is enabled, then small regions are combined to
	/// form larger regions. Note that the definition of a large region is a
	/// region that exceeds the large region threshold.
	/// </summary>
	public void GrowSmallRegionsOn()
	{
		vtkPolyDataEdgeConnectivityFilter_GrowSmallRegionsOn_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_InitializeSeedList_45(HandleRef pThis);

	/// <summary>
	/// Initialize list of point ids/cell ids used to seed regions.
	/// </summary>
	public void InitializeSeedList()
	{
		vtkPolyDataEdgeConnectivityFilter_InitializeSeedList_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_InitializeSpecifiedRegionList_46(HandleRef pThis);

	/// <summary>
	/// Initialize list of region ids to extract.
	/// </summary>
	public void InitializeSpecifiedRegionList()
	{
		vtkPolyDataEdgeConnectivityFilter_InitializeSpecifiedRegionList_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataEdgeConnectivityFilter_IsA_47(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to instantiate, get type information, and print the object.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolyDataEdgeConnectivityFilter_IsA_47(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataEdgeConnectivityFilter_IsTypeOf_48(string type);

	/// <summary>
	/// Standard methods to instantiate, get type information, and print the object.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolyDataEdgeConnectivityFilter_IsTypeOf_48(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataEdgeConnectivityFilter_NewInstance_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, get type information, and print the object.
	/// </summary>
	public new vtkPolyDataEdgeConnectivityFilter NewInstance()
	{
		vtkPolyDataEdgeConnectivityFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataEdgeConnectivityFilter_NewInstance_50(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataEdgeConnectivityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataEdgeConnectivityFilter_SafeDownCast_51(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, get type information, and print the object.
	/// </summary>
	public new static vtkPolyDataEdgeConnectivityFilter SafeDownCast(vtkObjectBase o)
	{
		vtkPolyDataEdgeConnectivityFilter vtkPolyDataEdgeConnectivityFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataEdgeConnectivityFilter_SafeDownCast_51(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataEdgeConnectivityFilter2 = (vtkPolyDataEdgeConnectivityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataEdgeConnectivityFilter2.Register(null);
			}
		}
		return vtkPolyDataEdgeConnectivityFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_ScalarConnectivityOff_52(HandleRef pThis);

	/// <summary>
	/// Turn on/off connectivity based on scalar value. If on, cells are
	/// connected only if they share a non-barrier edge AND and cell's scalar
	/// value falls within the scalar range specified.
	/// </summary>
	public virtual void ScalarConnectivityOff()
	{
		vtkPolyDataEdgeConnectivityFilter_ScalarConnectivityOff_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_ScalarConnectivityOn_53(HandleRef pThis);

	/// <summary>
	/// Turn on/off connectivity based on scalar value. If on, cells are
	/// connected only if they share a non-barrier edge AND and cell's scalar
	/// value falls within the scalar range specified.
	/// </summary>
	public virtual void ScalarConnectivityOn()
	{
		vtkPolyDataEdgeConnectivityFilter_ScalarConnectivityOn_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetBarrierEdgeLength_54(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Edges E of length edgeLen (BarrierEdgeLength[0]&lt;=edgeLen&lt;=BarrierEdgeLength[1])
	/// define barrier edges. If edgeLen falls within this range, then polygon
	/// cells on either side of the edge E are not neighbors, since the edge is
	/// a barrier edge. Note that a range of [VTK_DOUBLE_MAX,VTK_DOUBLE_MAX]
	/// (which is the default range) implies that all edges are not barrier
	/// edges (based on edge length).
	/// </summary>
	public virtual void SetBarrierEdgeLength(double _arg1, double _arg2)
	{
		vtkPolyDataEdgeConnectivityFilter_SetBarrierEdgeLength_54(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetBarrierEdgeLength_55(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Edges E of length edgeLen (BarrierEdgeLength[0]&lt;=edgeLen&lt;=BarrierEdgeLength[1])
	/// define barrier edges. If edgeLen falls within this range, then polygon
	/// cells on either side of the edge E are not neighbors, since the edge is
	/// a barrier edge. Note that a range of [VTK_DOUBLE_MAX,VTK_DOUBLE_MAX]
	/// (which is the default range) implies that all edges are not barrier
	/// edges (based on edge length).
	/// </summary>
	public void SetBarrierEdgeLength(IntPtr _arg)
	{
		vtkPolyDataEdgeConnectivityFilter_SetBarrierEdgeLength_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetBarrierEdges_56(HandleRef pThis, int _arg);

	/// <summary>
	/// Control connectivity traversal based on barrier edges. If enabled, then
	/// either the length of edges, or a explicit specification of barrier
	/// edges, is used to control what are considered connected edge neighbors.
	/// </summary>
	public virtual void SetBarrierEdges(int _arg)
	{
		vtkPolyDataEdgeConnectivityFilter_SetBarrierEdges_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetCellRegionAreas_57(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the creation of a cell array that, for each cell, contains
	/// the area of the region to which the cell is associated. If enabled, then
	/// an array named "CellRegionArea" is added to the output cell data.
	/// </summary>
	public virtual void SetCellRegionAreas(int _arg)
	{
		vtkPolyDataEdgeConnectivityFilter_SetCellRegionAreas_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetClosestPoint_58(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Use to specify x-y-z point coordinates when extracting the region
	/// closest to a specified point.
	/// </summary>
	public virtual void SetClosestPoint(double _arg1, double _arg2, double _arg3)
	{
		vtkPolyDataEdgeConnectivityFilter_SetClosestPoint_58(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetClosestPoint_59(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Use to specify x-y-z point coordinates when extracting the region
	/// closest to a specified point.
	/// </summary>
	public virtual void SetClosestPoint(IntPtr _arg)
	{
		vtkPolyDataEdgeConnectivityFilter_SetClosestPoint_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetColorRegions_60(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the coloring of edge-connected regions. If enabled, then
	/// a array named "RegionId" is added to the output cell data. The array
	/// contains, for each cell, the id with which the cell is associated.
	/// </summary>
	public virtual void SetColorRegions(int _arg)
	{
		vtkPolyDataEdgeConnectivityFilter_SetColorRegions_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetExtractionMode_61(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public virtual void SetExtractionMode(int _arg)
	{
		vtkPolyDataEdgeConnectivityFilter_SetExtractionMode_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToAllRegions_62(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToAllRegions()
	{
		vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToAllRegions_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToCellSeededRegions_63(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToCellSeededRegions()
	{
		vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToCellSeededRegions_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToClosestPointRegion_64(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToClosestPointRegion()
	{
		vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToClosestPointRegion_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToLargeRegions_65(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToLargeRegions()
	{
		vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToLargeRegions_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToLargestRegion_66(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToLargestRegion()
	{
		vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToLargestRegion_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToPointSeededRegions_67(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToPointSeededRegions()
	{
		vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToPointSeededRegions_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToSpecifiedRegions_68(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToSpecifiedRegions()
	{
		vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToSpecifiedRegions_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetLargeRegionThreshold_69(HandleRef pThis, double _arg);

	/// <summary>
	/// Define what a large region is by specifying the fraction of total input
	/// mesh area a region must be in order to be considered large. So for
	/// example, if the LargeRegionThreshold is 0.10, then if the summed surface
	/// area of all the cells composing a region is greater than or equal to
	/// 10%, the region is considered large. By default, the LargeRegionThreshold
	/// is 0.05.
	/// </summary>
	public virtual void SetLargeRegionThreshold(double _arg)
	{
		vtkPolyDataEdgeConnectivityFilter_SetLargeRegionThreshold_69(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetOutputPointsPrecision_70(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkPolyDataEdgeConnectivityFilter_SetOutputPointsPrecision_70(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetRegionGrowing_71(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify a strategy for region growing. Regions growing is a
	/// postprocessing step which assimilates small regions into larger regions;
	/// i.e., region growing is an additional step as part of a segmentation
	/// workflow. By default, region growing is off. If growing large regions
	/// is enabled, then smaller regions are assimilated into larger regions. If
	/// growing small regions is enabled, then small regions are combined to
	/// form larger regions. Note that the definition of a large region is a
	/// region that exceeds the large region threshold.
	/// </summary>
	public virtual void SetRegionGrowing(int _arg)
	{
		vtkPolyDataEdgeConnectivityFilter_SetRegionGrowing_71(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetRegionGrowingOff_72(HandleRef pThis);

	/// <summary>
	/// Specify a strategy for region growing. Regions growing is a
	/// postprocessing step which assimilates small regions into larger regions;
	/// i.e., region growing is an additional step as part of a segmentation
	/// workflow. By default, region growing is off. If growing large regions
	/// is enabled, then smaller regions are assimilated into larger regions. If
	/// growing small regions is enabled, then small regions are combined to
	/// form larger regions. Note that the definition of a large region is a
	/// region that exceeds the large region threshold.
	/// </summary>
	public void SetRegionGrowingOff()
	{
		vtkPolyDataEdgeConnectivityFilter_SetRegionGrowingOff_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetRegionGrowingToLargeRegions_73(HandleRef pThis);

	/// <summary>
	/// Specify a strategy for region growing. Regions growing is a
	/// postprocessing step which assimilates small regions into larger regions;
	/// i.e., region growing is an additional step as part of a segmentation
	/// workflow. By default, region growing is off. If growing large regions
	/// is enabled, then smaller regions are assimilated into larger regions. If
	/// growing small regions is enabled, then small regions are combined to
	/// form larger regions. Note that the definition of a large region is a
	/// region that exceeds the large region threshold.
	/// </summary>
	public void SetRegionGrowingToLargeRegions()
	{
		vtkPolyDataEdgeConnectivityFilter_SetRegionGrowingToLargeRegions_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetRegionGrowingToSmallRegions_74(HandleRef pThis);

	/// <summary>
	/// Specify a strategy for region growing. Regions growing is a
	/// postprocessing step which assimilates small regions into larger regions;
	/// i.e., region growing is an additional step as part of a segmentation
	/// workflow. By default, region growing is off. If growing large regions
	/// is enabled, then smaller regions are assimilated into larger regions. If
	/// growing small regions is enabled, then small regions are combined to
	/// form larger regions. Note that the definition of a large region is a
	/// region that exceeds the large region threshold.
	/// </summary>
	public void SetRegionGrowingToSmallRegions()
	{
		vtkPolyDataEdgeConnectivityFilter_SetRegionGrowingToSmallRegions_74(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetScalarConnectivity_75(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off connectivity based on scalar value. If on, cells are
	/// connected only if they share a non-barrier edge AND and cell's scalar
	/// value falls within the scalar range specified.
	/// </summary>
	public virtual void SetScalarConnectivity(int _arg)
	{
		vtkPolyDataEdgeConnectivityFilter_SetScalarConnectivity_75(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetScalarRange_76(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set the scalar range to extract cells based on scalar connectivity.
	/// </summary>
	public virtual void SetScalarRange(double _arg1, double _arg2)
	{
		vtkPolyDataEdgeConnectivityFilter_SetScalarRange_76(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetScalarRange_77(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the scalar range to extract cells based on scalar connectivity.
	/// </summary>
	public void SetScalarRange(IntPtr _arg)
	{
		vtkPolyDataEdgeConnectivityFilter_SetScalarRange_77(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetSourceConnection_78(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify the source vtkPolyData object used to specify barrier edges
	/// (this is an optional connection.) If specified, the connected traversal
	/// cannot traverse across the edges indicated as they are defined as
	/// barrier edges. Also note that the data member BarrierEdges must be
	/// enabled.
	/// </summary>
	public void SetSourceConnection(vtkAlgorithmOutput algOutput)
	{
		vtkPolyDataEdgeConnectivityFilter_SetSourceConnection_78(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataEdgeConnectivityFilter_SetSourceData_79(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the source vtkPolyData object used to specify barrier edges
	/// (this is an optional connection.) If specified, the connected traversal
	/// cannot traverse across the edges indicated as they are defined as
	/// barrier edges. Also note that the data member BarrierEdges must be
	/// enabled.
	/// </summary>
	public void SetSourceData(vtkPolyData arg0)
	{
		vtkPolyDataEdgeConnectivityFilter_SetSourceData_79(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
