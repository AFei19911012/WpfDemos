using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkConnectivityFilter
/// </summary>
/// <remarks>
///    extract data based on geometric connectivity
///
/// vtkConnectivityFilter is a filter that extracts cells that share common
/// points and/or meet other connectivity criterion. (Cells that share
/// vertices and meet other connectivity criterion such as scalar range are
/// known as a region.)  The filter works in one of six ways: 1) extract the
/// largest connected region in the dataset; 2) extract specified region
/// numbers; 3) extract all regions sharing specified point ids; 4) extract
/// all regions sharing specified cell ids; 5) extract the region closest to
/// the specified point; or 6) extract all regions (used to color the data by
/// region).
///
/// vtkConnectivityFilter is generalized to handle any type of input dataset.
/// If the input to this filter is a vtkPolyData, the output will be a vtkPolyData.
/// For all other input types, it generates output data of type vtkUnstructuredGrid.
/// Note that the only Get*Output() methods that will return a non-null pointer
/// are GetUnstructuredGridOutput() and GetPolyDataOutput() when the output of the
/// filter is a vtkUnstructuredGrid or vtkPolyData, respectively.
///
/// The behavior of vtkConnectivityFilter can be modified by turning on the
/// boolean ivar ScalarConnectivity. If this flag is on, the connectivity
/// algorithm is modified so that cells are considered connected only if 1)
/// they are geometrically connected (share a point) and 2) the scalar values
/// of one of the cell's points falls in the scalar range specified. This use
/// of ScalarConnectivity is particularly useful for volume datasets: it can
/// be used as a simple "connected segmentation" algorithm. For example, by
/// using a seed voxel (i.e., cell) on a known anatomical structure,
/// connectivity will pull out all voxels "containing" the anatomical
/// structure. These voxels can then be contoured or processed by other
/// visualization filters.
///
/// If the extraction mode is set to all regions and ColorRegions is enabled,
/// The RegionIds are assigned to each region by the order in which the region
/// was processed and has no other significance with respect to the size of
/// or number of cells.
///
/// </remarks>
/// <seealso>
///
/// vtkPolyDataConnectivityFilter
/// </seealso>
public class vtkConnectivityFilter : vtkPointSetAlgorithm
{
	/// <summary>
	/// Enumeration of the various ways to assign RegionIds when
	/// the ColorRegions option is on.
	/// </summary>
	public enum RegionIdAssignment
	{
		/// <summary>enum member</summary>
		CELL_COUNT_ASCENDING = 2,
		/// <summary>enum member</summary>
		CELL_COUNT_DESCENDING = 1,
		/// <summary>enum member</summary>
		UNSPECIFIED = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkConnectivityFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkConnectivityFilter()
	{
		MRClassNameKey = "class vtkConnectivityFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkConnectivityFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkConnectivityFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConnectivityFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with default extraction mode to extract largest regions.
	/// </summary>
	public new static vtkConnectivityFilter New()
	{
		vtkConnectivityFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConnectivityFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConnectivityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with default extraction mode to extract largest regions.
	/// </summary>
	public vtkConnectivityFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkConnectivityFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkConnectivityFilter_AddSeed_01(HandleRef pThis, long id);

	/// <summary>
	/// Add a seed id (point or cell id). Note: ids are 0-offset.
	/// </summary>
	public void AddSeed(long id)
	{
		vtkConnectivityFilter_AddSeed_01(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_AddSpecifiedRegion_02(HandleRef pThis, int id);

	/// <summary>
	/// Add a region id to extract. Note: ids are 0-offset.
	/// </summary>
	public void AddSpecifiedRegion(int id)
	{
		vtkConnectivityFilter_AddSpecifiedRegion_02(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_ColorRegionsOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off the coloring of connected regions.
	/// </summary>
	public virtual void ColorRegionsOff()
	{
		vtkConnectivityFilter_ColorRegionsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_ColorRegionsOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off the coloring of connected regions.
	/// </summary>
	public virtual void ColorRegionsOn()
	{
		vtkConnectivityFilter_ColorRegionsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_DeleteSeed_05(HandleRef pThis, long id);

	/// <summary>
	/// Delete a seed id (point or cell id). Note: ids are 0-offset.
	/// </summary>
	public void DeleteSeed(long id)
	{
		vtkConnectivityFilter_DeleteSeed_05(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_DeleteSpecifiedRegion_06(HandleRef pThis, int id);

	/// <summary>
	/// Delete a region id to extract. Note: ids are 0-offset.
	/// </summary>
	public void DeleteSpecifiedRegion(int id)
	{
		vtkConnectivityFilter_DeleteSpecifiedRegion_06(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConnectivityFilter_GetClosestPoint_07(HandleRef pThis);

	/// <summary>
	/// Use to specify x-y-z point coordinates when extracting the region
	/// closest to a specified point.
	/// </summary>
	public virtual double[] GetClosestPoint()
	{
		IntPtr intPtr = vtkConnectivityFilter_GetClosestPoint_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_GetClosestPoint_08(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Use to specify x-y-z point coordinates when extracting the region
	/// closest to a specified point.
	/// </summary>
	public virtual void GetClosestPoint(IntPtr data)
	{
		vtkConnectivityFilter_GetClosestPoint_08(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConnectivityFilter_GetColorRegions_09(HandleRef pThis);

	/// <summary>
	/// Turn on/off the coloring of connected regions.
	/// </summary>
	public virtual int GetColorRegions()
	{
		return vtkConnectivityFilter_GetColorRegions_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConnectivityFilter_GetExtractionMode_10(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public virtual int GetExtractionMode()
	{
		return vtkConnectivityFilter_GetExtractionMode_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConnectivityFilter_GetExtractionModeAsString_11(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public string GetExtractionModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkConnectivityFilter_GetExtractionModeAsString_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConnectivityFilter_GetExtractionModeMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public virtual int GetExtractionModeMaxValue()
	{
		return vtkConnectivityFilter_GetExtractionModeMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConnectivityFilter_GetExtractionModeMinValue_13(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public virtual int GetExtractionModeMinValue()
	{
		return vtkConnectivityFilter_GetExtractionModeMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConnectivityFilter_GetNumberOfExtractedRegions_14(HandleRef pThis);

	/// <summary>
	/// Obtain the number of connected regions.
	/// </summary>
	public int GetNumberOfExtractedRegions()
	{
		return vtkConnectivityFilter_GetNumberOfExtractedRegions_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkConnectivityFilter_GetNumberOfGenerationsFromBase_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkConnectivityFilter_GetNumberOfGenerationsFromBase_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkConnectivityFilter_GetNumberOfGenerationsFromBaseType_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkConnectivityFilter_GetNumberOfGenerationsFromBaseType_16(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConnectivityFilter_GetOutputPointsPrecision_17(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkConnectivityFilter_GetOutputPointsPrecision_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConnectivityFilter_GetRegionIdAssignmentMode_18(HandleRef pThis);

	/// <summary>
	/// Set/get mode controlling how RegionIds are assigned.
	/// </summary>
	public virtual int GetRegionIdAssignmentMode()
	{
		return vtkConnectivityFilter_GetRegionIdAssignmentMode_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConnectivityFilter_GetScalarConnectivity_19(HandleRef pThis);

	/// <summary>
	/// Turn on/off connectivity based on scalar value. If on, cells are connected
	/// only if they share points AND one of the cells scalar values falls in the
	/// scalar range specified.
	/// </summary>
	public virtual int GetScalarConnectivity()
	{
		return vtkConnectivityFilter_GetScalarConnectivity_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConnectivityFilter_GetScalarRange_20(HandleRef pThis);

	/// <summary>
	/// Set the scalar range to use to extract cells based on scalar connectivity.
	/// </summary>
	public virtual double[] GetScalarRange()
	{
		IntPtr intPtr = vtkConnectivityFilter_GetScalarRange_20(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_GetScalarRange_21(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set the scalar range to use to extract cells based on scalar connectivity.
	/// </summary>
	public virtual void GetScalarRange(ref double _arg1, ref double _arg2)
	{
		vtkConnectivityFilter_GetScalarRange_21(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_GetScalarRange_22(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the scalar range to use to extract cells based on scalar connectivity.
	/// </summary>
	public virtual void GetScalarRange(IntPtr _arg)
	{
		vtkConnectivityFilter_GetScalarRange_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_InitializeSeedList_23(HandleRef pThis);

	/// <summary>
	/// Initialize list of point ids/cell ids used to seed regions.
	/// </summary>
	public void InitializeSeedList()
	{
		vtkConnectivityFilter_InitializeSeedList_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_InitializeSpecifiedRegionList_24(HandleRef pThis);

	/// <summary>
	/// Initialize list of region ids to extract.
	/// </summary>
	public void InitializeSpecifiedRegionList()
	{
		vtkConnectivityFilter_InitializeSpecifiedRegionList_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConnectivityFilter_IsA_25(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkConnectivityFilter_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConnectivityFilter_IsTypeOf_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkConnectivityFilter_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConnectivityFilter_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkConnectivityFilter NewInstance()
	{
		vtkConnectivityFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConnectivityFilter_NewInstance_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConnectivityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConnectivityFilter_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkConnectivityFilter SafeDownCast(vtkObjectBase o)
	{
		vtkConnectivityFilter vtkConnectivityFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConnectivityFilter_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkConnectivityFilter2 = (vtkConnectivityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkConnectivityFilter2.Register(null);
			}
		}
		return vtkConnectivityFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_ScalarConnectivityOff_30(HandleRef pThis);

	/// <summary>
	/// Turn on/off connectivity based on scalar value. If on, cells are connected
	/// only if they share points AND one of the cells scalar values falls in the
	/// scalar range specified.
	/// </summary>
	public virtual void ScalarConnectivityOff()
	{
		vtkConnectivityFilter_ScalarConnectivityOff_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_ScalarConnectivityOn_31(HandleRef pThis);

	/// <summary>
	/// Turn on/off connectivity based on scalar value. If on, cells are connected
	/// only if they share points AND one of the cells scalar values falls in the
	/// scalar range specified.
	/// </summary>
	public virtual void ScalarConnectivityOn()
	{
		vtkConnectivityFilter_ScalarConnectivityOn_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_SetClosestPoint_32(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Use to specify x-y-z point coordinates when extracting the region
	/// closest to a specified point.
	/// </summary>
	public virtual void SetClosestPoint(double _arg1, double _arg2, double _arg3)
	{
		vtkConnectivityFilter_SetClosestPoint_32(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_SetClosestPoint_33(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Use to specify x-y-z point coordinates when extracting the region
	/// closest to a specified point.
	/// </summary>
	public virtual void SetClosestPoint(IntPtr _arg)
	{
		vtkConnectivityFilter_SetClosestPoint_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_SetColorRegions_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the coloring of connected regions.
	/// </summary>
	public virtual void SetColorRegions(int _arg)
	{
		vtkConnectivityFilter_SetColorRegions_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_SetExtractionMode_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public virtual void SetExtractionMode(int _arg)
	{
		vtkConnectivityFilter_SetExtractionMode_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_SetExtractionModeToAllRegions_36(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToAllRegions()
	{
		vtkConnectivityFilter_SetExtractionModeToAllRegions_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_SetExtractionModeToCellSeededRegions_37(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToCellSeededRegions()
	{
		vtkConnectivityFilter_SetExtractionModeToCellSeededRegions_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_SetExtractionModeToClosestPointRegion_38(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToClosestPointRegion()
	{
		vtkConnectivityFilter_SetExtractionModeToClosestPointRegion_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_SetExtractionModeToLargestRegion_39(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToLargestRegion()
	{
		vtkConnectivityFilter_SetExtractionModeToLargestRegion_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_SetExtractionModeToPointSeededRegions_40(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToPointSeededRegions()
	{
		vtkConnectivityFilter_SetExtractionModeToPointSeededRegions_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_SetExtractionModeToSpecifiedRegions_41(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToSpecifiedRegions()
	{
		vtkConnectivityFilter_SetExtractionModeToSpecifiedRegions_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_SetOutputPointsPrecision_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkConnectivityFilter_SetOutputPointsPrecision_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_SetRegionIdAssignmentMode_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get mode controlling how RegionIds are assigned.
	/// </summary>
	public virtual void SetRegionIdAssignmentMode(int _arg)
	{
		vtkConnectivityFilter_SetRegionIdAssignmentMode_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_SetScalarConnectivity_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off connectivity based on scalar value. If on, cells are connected
	/// only if they share points AND one of the cells scalar values falls in the
	/// scalar range specified.
	/// </summary>
	public virtual void SetScalarConnectivity(int _arg)
	{
		vtkConnectivityFilter_SetScalarConnectivity_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_SetScalarRange_45(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set the scalar range to use to extract cells based on scalar connectivity.
	/// </summary>
	public virtual void SetScalarRange(double _arg1, double _arg2)
	{
		vtkConnectivityFilter_SetScalarRange_45(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectivityFilter_SetScalarRange_46(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the scalar range to use to extract cells based on scalar connectivity.
	/// </summary>
	public void SetScalarRange(IntPtr _arg)
	{
		vtkConnectivityFilter_SetScalarRange_46(GetCppThis(), _arg);
	}
}
