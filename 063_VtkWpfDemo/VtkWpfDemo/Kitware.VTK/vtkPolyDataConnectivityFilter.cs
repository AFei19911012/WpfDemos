using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolyDataConnectivityFilter
/// </summary>
/// <remarks>
///    extract polygonal data based on geometric connectivity
///
/// vtkPolyDataConnectivityFilter is a filter that extracts cells that
/// share common points and/or satisfy a scalar threshold
/// criterion. (Such a group of cells is called a region.) The filter
/// works in one of six ways: 1) extract the largest (most points) connected region
/// in the dataset; 2) extract specified region numbers; 3) extract all
/// regions sharing specified point ids; 4) extract all regions sharing
/// specified cell ids; 5) extract the region closest to the specified
/// point; or 6) extract all regions (used to color regions).
///
/// This filter is specialized for polygonal data. This means it runs a bit
/// faster and is easier to construct visualization networks that process
/// polygonal data.
///
/// The behavior of vtkPolyDataConnectivityFilter can be modified by turning
/// on the boolean ivar ScalarConnectivity. If this flag is on, the
/// connectivity algorithm is modified so that cells are considered connected
/// only if 1) they are geometrically connected (share a point) and 2) the
/// scalar values of the cell's points falls in the scalar range specified.
/// If ScalarConnectivity and FullScalarConnectivity is ON, all the cell's
/// points must lie in the scalar range specified for the cell to qualify as
/// being connected. If FullScalarConnectivity is OFF, any one of the cell's
/// points may lie in the user specified scalar range for the cell to qualify
/// as being connected.
///
/// This use of ScalarConnectivity is particularly useful for selecting cells
/// for later processing.
///
/// </remarks>
/// <seealso>
///
/// vtkConnectivityFilter
/// </seealso>
public class vtkPolyDataConnectivityFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataConnectivityFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolyDataConnectivityFilter()
	{
		MRClassNameKey = "class vtkPolyDataConnectivityFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataConnectivityFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolyDataConnectivityFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataConnectivityFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with default extraction mode to extract largest regions.
	/// </summary>
	public new static vtkPolyDataConnectivityFilter New()
	{
		vtkPolyDataConnectivityFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataConnectivityFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataConnectivityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with default extraction mode to extract largest regions.
	/// </summary>
	public vtkPolyDataConnectivityFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPolyDataConnectivityFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPolyDataConnectivityFilter_AddSeed_01(HandleRef pThis, int id);

	/// <summary>
	/// Add a seed id (point or cell id). Note: ids are 0-offset.
	/// </summary>
	public void AddSeed(int id)
	{
		vtkPolyDataConnectivityFilter_AddSeed_01(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_AddSpecifiedRegion_02(HandleRef pThis, int id);

	/// <summary>
	/// Add a region id to extract. Note: ids are 0-offset.
	/// </summary>
	public void AddSpecifiedRegion(int id)
	{
		vtkPolyDataConnectivityFilter_AddSpecifiedRegion_02(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_ColorRegionsOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off the coloring of connected regions.
	/// </summary>
	public virtual void ColorRegionsOff()
	{
		vtkPolyDataConnectivityFilter_ColorRegionsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_ColorRegionsOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off the coloring of connected regions.
	/// </summary>
	public virtual void ColorRegionsOn()
	{
		vtkPolyDataConnectivityFilter_ColorRegionsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_DeleteSeed_05(HandleRef pThis, int id);

	/// <summary>
	/// Delete a seed id (point or cell id). Note: ids are 0-offset.
	/// </summary>
	public void DeleteSeed(int id)
	{
		vtkPolyDataConnectivityFilter_DeleteSeed_05(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_DeleteSpecifiedRegion_06(HandleRef pThis, int id);

	/// <summary>
	/// Delete a region id to extract. Note: ids are 0-offset.
	/// </summary>
	public void DeleteSpecifiedRegion(int id)
	{
		vtkPolyDataConnectivityFilter_DeleteSpecifiedRegion_06(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_FullScalarConnectivityOff_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off the use of Fully connected scalar connectivity. This is off
	/// by default. The flag is used only if ScalarConnectivity is on. If
	/// FullScalarConnectivity is ON, all the cell's points must lie in the
	/// scalar range specified for the cell to qualify as being connected. If
	/// FullScalarConnectivity is OFF, any one of the cell's points may lie in
	/// the user specified scalar range for the cell to qualify as being
	/// connected.
	/// </summary>
	public virtual void FullScalarConnectivityOff()
	{
		vtkPolyDataConnectivityFilter_FullScalarConnectivityOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_FullScalarConnectivityOn_08(HandleRef pThis);

	/// <summary>
	/// Turn on/off the use of Fully connected scalar connectivity. This is off
	/// by default. The flag is used only if ScalarConnectivity is on. If
	/// FullScalarConnectivity is ON, all the cell's points must lie in the
	/// scalar range specified for the cell to qualify as being connected. If
	/// FullScalarConnectivity is OFF, any one of the cell's points may lie in
	/// the user specified scalar range for the cell to qualify as being
	/// connected.
	/// </summary>
	public virtual void FullScalarConnectivityOn()
	{
		vtkPolyDataConnectivityFilter_FullScalarConnectivityOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataConnectivityFilter_GetClosestPoint_09(HandleRef pThis);

	/// <summary>
	/// Use to specify x-y-z point coordinates when extracting the region
	/// closest to a specified point.
	/// </summary>
	public virtual double[] GetClosestPoint()
	{
		IntPtr intPtr = vtkPolyDataConnectivityFilter_GetClosestPoint_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_GetClosestPoint_10(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Use to specify x-y-z point coordinates when extracting the region
	/// closest to a specified point.
	/// </summary>
	public virtual void GetClosestPoint(IntPtr data)
	{
		vtkPolyDataConnectivityFilter_GetClosestPoint_10(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataConnectivityFilter_GetColorRegions_11(HandleRef pThis);

	/// <summary>
	/// Turn on/off the coloring of connected regions.
	/// </summary>
	public virtual int GetColorRegions()
	{
		return vtkPolyDataConnectivityFilter_GetColorRegions_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataConnectivityFilter_GetExtractionMode_12(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public virtual int GetExtractionMode()
	{
		return vtkPolyDataConnectivityFilter_GetExtractionMode_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataConnectivityFilter_GetExtractionModeAsString_13(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public string GetExtractionModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkPolyDataConnectivityFilter_GetExtractionModeAsString_13(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataConnectivityFilter_GetExtractionModeMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public virtual int GetExtractionModeMaxValue()
	{
		return vtkPolyDataConnectivityFilter_GetExtractionModeMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataConnectivityFilter_GetExtractionModeMinValue_15(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public virtual int GetExtractionModeMinValue()
	{
		return vtkPolyDataConnectivityFilter_GetExtractionModeMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataConnectivityFilter_GetFullScalarConnectivity_16(HandleRef pThis);

	/// <summary>
	/// Turn on/off the use of Fully connected scalar connectivity. This is off
	/// by default. The flag is used only if ScalarConnectivity is on. If
	/// FullScalarConnectivity is ON, all the cell's points must lie in the
	/// scalar range specified for the cell to qualify as being connected. If
	/// FullScalarConnectivity is OFF, any one of the cell's points may lie in
	/// the user specified scalar range for the cell to qualify as being
	/// connected.
	/// </summary>
	public virtual int GetFullScalarConnectivity()
	{
		return vtkPolyDataConnectivityFilter_GetFullScalarConnectivity_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataConnectivityFilter_GetMarkVisitedPointIds_17(HandleRef pThis);

	/// <summary>
	/// Specify whether to record input point ids that appear in the output connected
	/// components. It may be useful to extract the visited point ids for use by a
	/// downstream filter. Default is OFF.
	/// </summary>
	public virtual int GetMarkVisitedPointIds()
	{
		return vtkPolyDataConnectivityFilter_GetMarkVisitedPointIds_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataConnectivityFilter_GetNumberOfExtractedRegions_18(HandleRef pThis);

	/// <summary>
	/// Obtain the number of connected regions.
	/// </summary>
	public int GetNumberOfExtractedRegions()
	{
		return vtkPolyDataConnectivityFilter_GetNumberOfExtractedRegions_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataConnectivityFilter_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolyDataConnectivityFilter_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataConnectivityFilter_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolyDataConnectivityFilter_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataConnectivityFilter_GetOutputPointsPrecision_21(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkPolyDataConnectivityFilter_GetOutputPointsPrecision_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataConnectivityFilter_GetRegionSizes_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Obtain the array containing the region sizes of the extracted
	/// regions
	/// </summary>
	public virtual vtkIdTypeArray GetRegionSizes()
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataConnectivityFilter_GetRegionSizes_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPolyDataConnectivityFilter_GetScalarConnectivity_23(HandleRef pThis);

	/// <summary>
	/// Turn on/off connectivity based on scalar value. If on, cells are connected
	/// only if they share points AND one of the cells scalar values falls in the
	/// scalar range specified.
	/// </summary>
	public virtual int GetScalarConnectivity()
	{
		return vtkPolyDataConnectivityFilter_GetScalarConnectivity_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataConnectivityFilter_GetScalarRange_24(HandleRef pThis);

	/// <summary>
	/// Set the scalar range to use to extract cells based on scalar connectivity.
	/// </summary>
	public virtual double[] GetScalarRange()
	{
		IntPtr intPtr = vtkPolyDataConnectivityFilter_GetScalarRange_24(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_GetScalarRange_25(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set the scalar range to use to extract cells based on scalar connectivity.
	/// </summary>
	public virtual void GetScalarRange(ref double _arg1, ref double _arg2)
	{
		vtkPolyDataConnectivityFilter_GetScalarRange_25(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_GetScalarRange_26(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the scalar range to use to extract cells based on scalar connectivity.
	/// </summary>
	public virtual void GetScalarRange(IntPtr _arg)
	{
		vtkPolyDataConnectivityFilter_GetScalarRange_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataConnectivityFilter_GetVisitedPointIds_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input point ids that appear in the output connected components. This is
	/// non-empty only if MarkVisitedPointIds has been set.
	/// </summary>
	public virtual vtkIdList GetVisitedPointIds()
	{
		vtkIdList vtkIdList2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataConnectivityFilter_GetVisitedPointIds_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdList2 = (vtkIdList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdList2.Register(null);
			}
		}
		return vtkIdList2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_InitializeSeedList_28(HandleRef pThis);

	/// <summary>
	/// Initialize list of point ids/cell ids used to seed regions.
	/// </summary>
	public void InitializeSeedList()
	{
		vtkPolyDataConnectivityFilter_InitializeSeedList_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_InitializeSpecifiedRegionList_29(HandleRef pThis);

	/// <summary>
	/// Initialize list of region ids to extract.
	/// </summary>
	public void InitializeSpecifiedRegionList()
	{
		vtkPolyDataConnectivityFilter_InitializeSpecifiedRegionList_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataConnectivityFilter_IsA_30(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolyDataConnectivityFilter_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataConnectivityFilter_IsTypeOf_31(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolyDataConnectivityFilter_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_MarkVisitedPointIdsOff_32(HandleRef pThis);

	/// <summary>
	/// Specify whether to record input point ids that appear in the output connected
	/// components. It may be useful to extract the visited point ids for use by a
	/// downstream filter. Default is OFF.
	/// </summary>
	public virtual void MarkVisitedPointIdsOff()
	{
		vtkPolyDataConnectivityFilter_MarkVisitedPointIdsOff_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_MarkVisitedPointIdsOn_33(HandleRef pThis);

	/// <summary>
	/// Specify whether to record input point ids that appear in the output connected
	/// components. It may be useful to extract the visited point ids for use by a
	/// downstream filter. Default is OFF.
	/// </summary>
	public virtual void MarkVisitedPointIdsOn()
	{
		vtkPolyDataConnectivityFilter_MarkVisitedPointIdsOn_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataConnectivityFilter_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPolyDataConnectivityFilter NewInstance()
	{
		vtkPolyDataConnectivityFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataConnectivityFilter_NewInstance_35(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataConnectivityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataConnectivityFilter_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPolyDataConnectivityFilter SafeDownCast(vtkObjectBase o)
	{
		vtkPolyDataConnectivityFilter vtkPolyDataConnectivityFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataConnectivityFilter_SafeDownCast_36(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataConnectivityFilter2 = (vtkPolyDataConnectivityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataConnectivityFilter2.Register(null);
			}
		}
		return vtkPolyDataConnectivityFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_ScalarConnectivityOff_37(HandleRef pThis);

	/// <summary>
	/// Turn on/off connectivity based on scalar value. If on, cells are connected
	/// only if they share points AND one of the cells scalar values falls in the
	/// scalar range specified.
	/// </summary>
	public virtual void ScalarConnectivityOff()
	{
		vtkPolyDataConnectivityFilter_ScalarConnectivityOff_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_ScalarConnectivityOn_38(HandleRef pThis);

	/// <summary>
	/// Turn on/off connectivity based on scalar value. If on, cells are connected
	/// only if they share points AND one of the cells scalar values falls in the
	/// scalar range specified.
	/// </summary>
	public virtual void ScalarConnectivityOn()
	{
		vtkPolyDataConnectivityFilter_ScalarConnectivityOn_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_SetClosestPoint_39(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Use to specify x-y-z point coordinates when extracting the region
	/// closest to a specified point.
	/// </summary>
	public virtual void SetClosestPoint(double _arg1, double _arg2, double _arg3)
	{
		vtkPolyDataConnectivityFilter_SetClosestPoint_39(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_SetClosestPoint_40(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Use to specify x-y-z point coordinates when extracting the region
	/// closest to a specified point.
	/// </summary>
	public virtual void SetClosestPoint(IntPtr _arg)
	{
		vtkPolyDataConnectivityFilter_SetClosestPoint_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_SetColorRegions_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the coloring of connected regions.
	/// </summary>
	public virtual void SetColorRegions(int _arg)
	{
		vtkPolyDataConnectivityFilter_SetColorRegions_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_SetExtractionMode_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public virtual void SetExtractionMode(int _arg)
	{
		vtkPolyDataConnectivityFilter_SetExtractionMode_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_SetExtractionModeToAllRegions_43(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToAllRegions()
	{
		vtkPolyDataConnectivityFilter_SetExtractionModeToAllRegions_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_SetExtractionModeToCellSeededRegions_44(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToCellSeededRegions()
	{
		vtkPolyDataConnectivityFilter_SetExtractionModeToCellSeededRegions_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_SetExtractionModeToClosestPointRegion_45(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToClosestPointRegion()
	{
		vtkPolyDataConnectivityFilter_SetExtractionModeToClosestPointRegion_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_SetExtractionModeToLargestRegion_46(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToLargestRegion()
	{
		vtkPolyDataConnectivityFilter_SetExtractionModeToLargestRegion_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_SetExtractionModeToPointSeededRegions_47(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToPointSeededRegions()
	{
		vtkPolyDataConnectivityFilter_SetExtractionModeToPointSeededRegions_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_SetExtractionModeToSpecifiedRegions_48(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToSpecifiedRegions()
	{
		vtkPolyDataConnectivityFilter_SetExtractionModeToSpecifiedRegions_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_SetFullScalarConnectivity_49(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the use of Fully connected scalar connectivity. This is off
	/// by default. The flag is used only if ScalarConnectivity is on. If
	/// FullScalarConnectivity is ON, all the cell's points must lie in the
	/// scalar range specified for the cell to qualify as being connected. If
	/// FullScalarConnectivity is OFF, any one of the cell's points may lie in
	/// the user specified scalar range for the cell to qualify as being
	/// connected.
	/// </summary>
	public virtual void SetFullScalarConnectivity(int _arg)
	{
		vtkPolyDataConnectivityFilter_SetFullScalarConnectivity_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_SetMarkVisitedPointIds_50(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to record input point ids that appear in the output connected
	/// components. It may be useful to extract the visited point ids for use by a
	/// downstream filter. Default is OFF.
	/// </summary>
	public virtual void SetMarkVisitedPointIds(int _arg)
	{
		vtkPolyDataConnectivityFilter_SetMarkVisitedPointIds_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_SetOutputPointsPrecision_51(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkPolyDataConnectivityFilter_SetOutputPointsPrecision_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_SetScalarConnectivity_52(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off connectivity based on scalar value. If on, cells are connected
	/// only if they share points AND one of the cells scalar values falls in the
	/// scalar range specified.
	/// </summary>
	public virtual void SetScalarConnectivity(int _arg)
	{
		vtkPolyDataConnectivityFilter_SetScalarConnectivity_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_SetScalarRange_53(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set the scalar range to use to extract cells based on scalar connectivity.
	/// </summary>
	public virtual void SetScalarRange(double _arg1, double _arg2)
	{
		vtkPolyDataConnectivityFilter_SetScalarRange_53(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataConnectivityFilter_SetScalarRange_54(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the scalar range to use to extract cells based on scalar connectivity.
	/// </summary>
	public void SetScalarRange(IntPtr _arg)
	{
		vtkPolyDataConnectivityFilter_SetScalarRange_54(GetCppThis(), _arg);
	}
}
