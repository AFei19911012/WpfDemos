using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkConnectedPointsFilter
/// </summary>
/// <remarks>
///    extract / segment points based on geometric connectivity
///
/// vtkConnectedPointsFilter is a filter that extracts and/or segments points
/// from a point cloud based on geometric distance measures (e.g., proximity,
/// normal alignments, etc.) and optional measures such as scalar range. The
/// default operation is to segment the points into "connected" regions where
/// the connection is determined by an appropriate distance measure. Each
/// region is given a region id. Optionally, the filter can output the largest
/// connected region of points; a particular region (via id specification);
/// those regions that are seeded using a list of input point ids; or the
/// region of points closest to a specified position.
///
/// The key parameter of this filter is the radius defining a sphere around
/// each point which defines a local neighborhood: any other points in the
/// local neighborhood are assumed connected to the point. Note that the
/// radius is defined in absolute terms.
///
/// Other parameters are used to further qualify what it means to be a
/// neighboring point. For example, scalar range and/or point normals can be
/// used to further constrain the neighborhood. Also the extraction mode
/// defines how the filter operates. By default, all regions are extracted but
/// it is possible to extract particular regions; the region closest to a seed
/// point; seeded regions; or the largest region found while processing. By
/// default, all regions are extracted.
///
/// On output, all points are labeled with a region number. However note that
/// the number of input and output points may not be the same: if not
/// extracting all regions then the output size may be less than the input
/// size.
///
/// </remarks>
/// <seealso>
///
/// vtkPolyDataConnectivityFilter vtkConnectivityFilter
/// </seealso>
public class vtkConnectedPointsFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkConnectedPointsFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkConnectedPointsFilter()
	{
		MRClassNameKey = "class vtkConnectedPointsFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkConnectedPointsFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkConnectedPointsFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConnectedPointsFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with default extraction mode to extract the largest region.
	/// </summary>
	public new static vtkConnectedPointsFilter New()
	{
		vtkConnectedPointsFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConnectedPointsFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConnectedPointsFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with default extraction mode to extract the largest region.
	/// </summary>
	public vtkConnectedPointsFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkConnectedPointsFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_AddSeed_01(HandleRef pThis, long id);

	/// <summary>
	/// Add a non-negative point seed id. Note: ids are 0-offset.
	/// </summary>
	public void AddSeed(long id)
	{
		vtkConnectedPointsFilter_AddSeed_01(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_AddSpecifiedRegion_02(HandleRef pThis, long id);

	/// <summary>
	/// Add a non-negative region id to extract. Note: ids are 0-offset.
	/// </summary>
	public void AddSpecifiedRegion(long id)
	{
		vtkConnectedPointsFilter_AddSpecifiedRegion_02(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_AlignedNormalsOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off connectivity based on point normal consistency. If on, and
	/// point normals are defined, points are connected only if they satisfy
	/// other criterion (e.g., geometric proximity, scalar connectivity, etc.)
	/// AND the angle between normals is no greater than NormalAngle;
	/// </summary>
	public virtual void AlignedNormalsOff()
	{
		vtkConnectedPointsFilter_AlignedNormalsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_AlignedNormalsOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off connectivity based on point normal consistency. If on, and
	/// point normals are defined, points are connected only if they satisfy
	/// other criterion (e.g., geometric proximity, scalar connectivity, etc.)
	/// AND the angle between normals is no greater than NormalAngle;
	/// </summary>
	public virtual void AlignedNormalsOn()
	{
		vtkConnectedPointsFilter_AlignedNormalsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_DeleteSeed_05(HandleRef pThis, long id);

	/// <summary>
	/// Delete a point seed id. Note: ids are 0-offset.
	/// </summary>
	public void DeleteSeed(long id)
	{
		vtkConnectedPointsFilter_DeleteSeed_05(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_DeleteSpecifiedRegion_06(HandleRef pThis, long id);

	/// <summary>
	/// Delete a region id to extract. Note: ids are 0-offset.
	/// </summary>
	public void DeleteSpecifiedRegion(long id)
	{
		vtkConnectedPointsFilter_DeleteSpecifiedRegion_06(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConnectedPointsFilter_GetAlignedNormals_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off connectivity based on point normal consistency. If on, and
	/// point normals are defined, points are connected only if they satisfy
	/// other criterion (e.g., geometric proximity, scalar connectivity, etc.)
	/// AND the angle between normals is no greater than NormalAngle;
	/// </summary>
	public virtual int GetAlignedNormals()
	{
		return vtkConnectedPointsFilter_GetAlignedNormals_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConnectedPointsFilter_GetClosestPoint_08(HandleRef pThis);

	/// <summary>
	/// Use to specify x-y-z point coordinates when extracting the region
	/// closest to a specified point.
	/// </summary>
	public virtual double[] GetClosestPoint()
	{
		IntPtr intPtr = vtkConnectedPointsFilter_GetClosestPoint_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_GetClosestPoint_09(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Use to specify x-y-z point coordinates when extracting the region
	/// closest to a specified point.
	/// </summary>
	public virtual void GetClosestPoint(IntPtr data)
	{
		vtkConnectedPointsFilter_GetClosestPoint_09(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConnectedPointsFilter_GetExtractionMode_10(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected regions.
	/// </summary>
	public virtual int GetExtractionMode()
	{
		return vtkConnectedPointsFilter_GetExtractionMode_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConnectedPointsFilter_GetExtractionModeAsString_11(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected regions.
	/// </summary>
	public string GetExtractionModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkConnectedPointsFilter_GetExtractionModeAsString_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConnectedPointsFilter_GetExtractionModeMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected regions.
	/// </summary>
	public virtual int GetExtractionModeMaxValue()
	{
		return vtkConnectedPointsFilter_GetExtractionModeMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConnectedPointsFilter_GetExtractionModeMinValue_13(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected regions.
	/// </summary>
	public virtual int GetExtractionModeMinValue()
	{
		return vtkConnectedPointsFilter_GetExtractionModeMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConnectedPointsFilter_GetLocator_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient searches to locate points
	/// around a sample point.
	/// </summary>
	public virtual vtkAbstractPointLocator GetLocator()
	{
		vtkAbstractPointLocator vtkAbstractPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConnectedPointsFilter_GetLocator_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractPointLocator2 = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractPointLocator2.Register(null);
			}
		}
		return vtkAbstractPointLocator2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConnectedPointsFilter_GetNormalAngle_15(HandleRef pThis);

	/// <summary>
	/// Specify a threshold for normal angles. If AlignedNormalsOn is set, then
	/// points are connected if the angle between their normals is within this
	/// angle threshold (expressed in degrees).
	/// </summary>
	public virtual double GetNormalAngle()
	{
		return vtkConnectedPointsFilter_GetNormalAngle_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConnectedPointsFilter_GetNormalAngleMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Specify a threshold for normal angles. If AlignedNormalsOn is set, then
	/// points are connected if the angle between their normals is within this
	/// angle threshold (expressed in degrees).
	/// </summary>
	public virtual double GetNormalAngleMaxValue()
	{
		return vtkConnectedPointsFilter_GetNormalAngleMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConnectedPointsFilter_GetNormalAngleMinValue_17(HandleRef pThis);

	/// <summary>
	/// Specify a threshold for normal angles. If AlignedNormalsOn is set, then
	/// points are connected if the angle between their normals is within this
	/// angle threshold (expressed in degrees).
	/// </summary>
	public virtual double GetNormalAngleMinValue()
	{
		return vtkConnectedPointsFilter_GetNormalAngleMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConnectedPointsFilter_GetNumberOfExtractedRegions_18(HandleRef pThis);

	/// <summary>
	/// Obtain the number of connected regions. The return value is valid only
	/// after the filter has executed.
	/// </summary>
	public int GetNumberOfExtractedRegions()
	{
		return vtkConnectedPointsFilter_GetNumberOfExtractedRegions_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkConnectedPointsFilter_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkConnectedPointsFilter_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkConnectedPointsFilter_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkConnectedPointsFilter_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConnectedPointsFilter_GetRadius_21(HandleRef pThis);

	/// <summary>
	/// Set / get the radius variable specifying a local sphere used to define
	/// local point neighborhood.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkConnectedPointsFilter_GetRadius_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConnectedPointsFilter_GetRadiusMaxValue_22(HandleRef pThis);

	/// <summary>
	/// Set / get the radius variable specifying a local sphere used to define
	/// local point neighborhood.
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkConnectedPointsFilter_GetRadiusMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConnectedPointsFilter_GetRadiusMinValue_23(HandleRef pThis);

	/// <summary>
	/// Set / get the radius variable specifying a local sphere used to define
	/// local point neighborhood.
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkConnectedPointsFilter_GetRadiusMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConnectedPointsFilter_GetScalarConnectivity_24(HandleRef pThis);

	/// <summary>
	/// Turn on/off connectivity based on scalar value. If on, points are
	/// connected only if they satisfy the various geometric criterion AND one
	/// of the points scalar values falls in the scalar range specified.
	/// </summary>
	public virtual int GetScalarConnectivity()
	{
		return vtkConnectedPointsFilter_GetScalarConnectivity_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConnectedPointsFilter_GetScalarRange_25(HandleRef pThis);

	/// <summary>
	/// Set the scalar range to use to extract points based on scalar connectivity.
	/// </summary>
	public virtual double[] GetScalarRange()
	{
		IntPtr intPtr = vtkConnectedPointsFilter_GetScalarRange_25(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_GetScalarRange_26(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set the scalar range to use to extract points based on scalar connectivity.
	/// </summary>
	public virtual void GetScalarRange(ref double _arg1, ref double _arg2)
	{
		vtkConnectedPointsFilter_GetScalarRange_26(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_GetScalarRange_27(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the scalar range to use to extract points based on scalar connectivity.
	/// </summary>
	public virtual void GetScalarRange(IntPtr _arg)
	{
		vtkConnectedPointsFilter_GetScalarRange_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_InitializeSeedList_28(HandleRef pThis);

	/// <summary>
	/// Initialize list of point ids ids used to seed regions.
	/// </summary>
	public void InitializeSeedList()
	{
		vtkConnectedPointsFilter_InitializeSeedList_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_InitializeSpecifiedRegionList_29(HandleRef pThis);

	/// <summary>
	/// Initialize list of region ids to extract.
	/// </summary>
	public void InitializeSpecifiedRegionList()
	{
		vtkConnectedPointsFilter_InitializeSpecifiedRegionList_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConnectedPointsFilter_IsA_30(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkConnectedPointsFilter_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConnectedPointsFilter_IsTypeOf_31(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkConnectedPointsFilter_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConnectedPointsFilter_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkConnectedPointsFilter NewInstance()
	{
		vtkConnectedPointsFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConnectedPointsFilter_NewInstance_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConnectedPointsFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConnectedPointsFilter_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkConnectedPointsFilter SafeDownCast(vtkObjectBase o)
	{
		vtkConnectedPointsFilter vtkConnectedPointsFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConnectedPointsFilter_SafeDownCast_34(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkConnectedPointsFilter2 = (vtkConnectedPointsFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkConnectedPointsFilter2.Register(null);
			}
		}
		return vtkConnectedPointsFilter2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_ScalarConnectivityOff_35(HandleRef pThis);

	/// <summary>
	/// Turn on/off connectivity based on scalar value. If on, points are
	/// connected only if they satisfy the various geometric criterion AND one
	/// of the points scalar values falls in the scalar range specified.
	/// </summary>
	public virtual void ScalarConnectivityOff()
	{
		vtkConnectedPointsFilter_ScalarConnectivityOff_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_ScalarConnectivityOn_36(HandleRef pThis);

	/// <summary>
	/// Turn on/off connectivity based on scalar value. If on, points are
	/// connected only if they satisfy the various geometric criterion AND one
	/// of the points scalar values falls in the scalar range specified.
	/// </summary>
	public virtual void ScalarConnectivityOn()
	{
		vtkConnectedPointsFilter_ScalarConnectivityOn_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_SetAlignedNormals_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off connectivity based on point normal consistency. If on, and
	/// point normals are defined, points are connected only if they satisfy
	/// other criterion (e.g., geometric proximity, scalar connectivity, etc.)
	/// AND the angle between normals is no greater than NormalAngle;
	/// </summary>
	public virtual void SetAlignedNormals(int _arg)
	{
		vtkConnectedPointsFilter_SetAlignedNormals_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_SetClosestPoint_38(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Use to specify x-y-z point coordinates when extracting the region
	/// closest to a specified point.
	/// </summary>
	public virtual void SetClosestPoint(double _arg1, double _arg2, double _arg3)
	{
		vtkConnectedPointsFilter_SetClosestPoint_38(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_SetClosestPoint_39(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Use to specify x-y-z point coordinates when extracting the region
	/// closest to a specified point.
	/// </summary>
	public virtual void SetClosestPoint(IntPtr _arg)
	{
		vtkConnectedPointsFilter_SetClosestPoint_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_SetExtractionMode_40(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the extraction of connected regions.
	/// </summary>
	public virtual void SetExtractionMode(int _arg)
	{
		vtkConnectedPointsFilter_SetExtractionMode_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_SetExtractionModeToAllRegions_41(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected regions.
	/// </summary>
	public void SetExtractionModeToAllRegions()
	{
		vtkConnectedPointsFilter_SetExtractionModeToAllRegions_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_SetExtractionModeToClosestPointRegion_42(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected regions.
	/// </summary>
	public void SetExtractionModeToClosestPointRegion()
	{
		vtkConnectedPointsFilter_SetExtractionModeToClosestPointRegion_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_SetExtractionModeToLargestRegion_43(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected regions.
	/// </summary>
	public void SetExtractionModeToLargestRegion()
	{
		vtkConnectedPointsFilter_SetExtractionModeToLargestRegion_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_SetExtractionModeToPointSeededRegions_44(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected regions.
	/// </summary>
	public void SetExtractionModeToPointSeededRegions()
	{
		vtkConnectedPointsFilter_SetExtractionModeToPointSeededRegions_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_SetExtractionModeToSpecifiedRegions_45(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected regions.
	/// </summary>
	public void SetExtractionModeToSpecifiedRegions()
	{
		vtkConnectedPointsFilter_SetExtractionModeToSpecifiedRegions_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_SetLocator_46(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient searches to locate points
	/// around a sample point.
	/// </summary>
	public void SetLocator(vtkAbstractPointLocator locator)
	{
		vtkConnectedPointsFilter_SetLocator_46(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_SetNormalAngle_47(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify a threshold for normal angles. If AlignedNormalsOn is set, then
	/// points are connected if the angle between their normals is within this
	/// angle threshold (expressed in degrees).
	/// </summary>
	public virtual void SetNormalAngle(double _arg)
	{
		vtkConnectedPointsFilter_SetNormalAngle_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_SetRadius_48(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / get the radius variable specifying a local sphere used to define
	/// local point neighborhood.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkConnectedPointsFilter_SetRadius_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_SetScalarConnectivity_49(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off connectivity based on scalar value. If on, points are
	/// connected only if they satisfy the various geometric criterion AND one
	/// of the points scalar values falls in the scalar range specified.
	/// </summary>
	public virtual void SetScalarConnectivity(int _arg)
	{
		vtkConnectedPointsFilter_SetScalarConnectivity_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_SetScalarRange_50(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set the scalar range to use to extract points based on scalar connectivity.
	/// </summary>
	public virtual void SetScalarRange(double _arg1, double _arg2)
	{
		vtkConnectedPointsFilter_SetScalarRange_50(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConnectedPointsFilter_SetScalarRange_51(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the scalar range to use to extract points based on scalar connectivity.
	/// </summary>
	public void SetScalarRange(IntPtr _arg)
	{
		vtkConnectedPointsFilter_SetScalarRange_51(GetCppThis(), _arg);
	}
}
