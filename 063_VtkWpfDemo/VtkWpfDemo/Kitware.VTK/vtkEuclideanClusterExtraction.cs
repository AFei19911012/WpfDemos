using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkEuclideanClusterExtraction
/// </summary>
/// <remarks>
///    perform segmentation based on geometric
/// proximity and optional scalar threshold
///
/// vtkEuclideanClusterExtraction is a filter that extracts points that are in
/// close geometric proximity, and optionally satisfies a scalar threshold
/// criterion. (Points extracted in this way are referred to as clusters.)
/// The filter works in one of five ways: 1) extract the largest cluster in the
/// dataset; 2) extract specified cluster number(s); 3) extract all clusters
/// containing specified point ids; 4) extract the cluster closest to a specified
/// point; or 5) extract all clusters (which can be used for coloring the clusters).
///
/// Note that geometric proximity is defined by setting the Radius instance
/// variable. This variable defines a local sphere around each point; other
/// points contained in this sphere are considered "connected" to the
/// point. Setting this number too large will connect clusters that should not
/// be; setting it too small will fragment the point cloud into myriad
/// clusters. To accelerate the geometric proximity operations, a point
/// locator may be specified. By default, a vtkStaticPointLocator is used, but
/// any vtkAbstractPointLocator may be specified.
///
/// The behavior of vtkEuclideanClusterExtraction can be modified by turning
/// on the boolean ivar ScalarConnectivity. If this flag is on, the clustering
/// algorithm is modified so that points are considered part of a cluster if
/// they satisfy both the geometric proximity measure, and the points scalar
/// values falls into the scalar range specified. This use of
/// ScalarConnectivity is particularly useful for data with intensity or color
/// information, serving as a simple "connected segmentation" algorithm. For
/// example, by using a seed point in a known cluster, clustering will pull
/// out all points "representing" the local structure.
///
/// </remarks>
/// <seealso>
///
/// vtkConnectivityFilter vtkPolyDataConnectivityFilter
/// </seealso>
public class vtkEuclideanClusterExtraction : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEuclideanClusterExtraction";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEuclideanClusterExtraction()
	{
		MRClassNameKey = "class vtkEuclideanClusterExtraction";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEuclideanClusterExtraction"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEuclideanClusterExtraction(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEuclideanClusterExtraction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with default extraction mode to extract largest clusters.
	/// </summary>
	public new static vtkEuclideanClusterExtraction New()
	{
		vtkEuclideanClusterExtraction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEuclideanClusterExtraction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEuclideanClusterExtraction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with default extraction mode to extract largest clusters.
	/// </summary>
	public vtkEuclideanClusterExtraction()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkEuclideanClusterExtraction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkEuclideanClusterExtraction_AddSeed_01(HandleRef pThis, long id);

	/// <summary>
	/// Add a seed id (point id). Note: ids are 0-offset.
	/// </summary>
	public void AddSeed(long id)
	{
		vtkEuclideanClusterExtraction_AddSeed_01(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_AddSpecifiedCluster_02(HandleRef pThis, int id);

	/// <summary>
	/// Add a cluster id to extract. Note: ids are 0-offset.
	/// </summary>
	public void AddSpecifiedCluster(int id)
	{
		vtkEuclideanClusterExtraction_AddSpecifiedCluster_02(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_ColorClustersOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off the coloring of connected clusters.
	/// </summary>
	public virtual void ColorClustersOff()
	{
		vtkEuclideanClusterExtraction_ColorClustersOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_ColorClustersOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off the coloring of connected clusters.
	/// </summary>
	public virtual void ColorClustersOn()
	{
		vtkEuclideanClusterExtraction_ColorClustersOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_DeleteSeed_05(HandleRef pThis, long id);

	/// <summary>
	/// Delete a seed id.a
	/// </summary>
	public void DeleteSeed(long id)
	{
		vtkEuclideanClusterExtraction_DeleteSeed_05(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_DeleteSpecifiedCluster_06(HandleRef pThis, int id);

	/// <summary>
	/// Delete a cluster id to extract.
	/// </summary>
	public void DeleteSpecifiedCluster(int id)
	{
		vtkEuclideanClusterExtraction_DeleteSpecifiedCluster_06(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEuclideanClusterExtraction_GetClosestPoint_07(HandleRef pThis);

	/// <summary>
	/// Used to specify the x-y-z point coordinates when extracting the cluster
	/// closest to a specified point.
	/// </summary>
	public virtual double[] GetClosestPoint()
	{
		IntPtr intPtr = vtkEuclideanClusterExtraction_GetClosestPoint_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_GetClosestPoint_08(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Used to specify the x-y-z point coordinates when extracting the cluster
	/// closest to a specified point.
	/// </summary>
	public virtual void GetClosestPoint(IntPtr data)
	{
		vtkEuclideanClusterExtraction_GetClosestPoint_08(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkEuclideanClusterExtraction_GetColorClusters_09(HandleRef pThis);

	/// <summary>
	/// Turn on/off the coloring of connected clusters.
	/// </summary>
	public virtual bool GetColorClusters()
	{
		return (vtkEuclideanClusterExtraction_GetColorClusters_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEuclideanClusterExtraction_GetExtractionMode_10(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public virtual int GetExtractionMode()
	{
		return vtkEuclideanClusterExtraction_GetExtractionMode_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEuclideanClusterExtraction_GetExtractionModeAsString_11(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public string GetExtractionModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkEuclideanClusterExtraction_GetExtractionModeAsString_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEuclideanClusterExtraction_GetExtractionModeMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public virtual int GetExtractionModeMaxValue()
	{
		return vtkEuclideanClusterExtraction_GetExtractionModeMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEuclideanClusterExtraction_GetExtractionModeMinValue_13(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public virtual int GetExtractionModeMinValue()
	{
		return vtkEuclideanClusterExtraction_GetExtractionModeMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEuclideanClusterExtraction_GetLocator_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient proximity searches near a
	/// specified interpolation position.
	/// </summary>
	public virtual vtkAbstractPointLocator GetLocator()
	{
		vtkAbstractPointLocator vtkAbstractPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEuclideanClusterExtraction_GetLocator_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkEuclideanClusterExtraction_GetNumberOfExtractedClusters_15(HandleRef pThis);

	/// <summary>
	/// Obtain the number of connected clusters. This value is valid only after filter execution.
	/// </summary>
	public int GetNumberOfExtractedClusters()
	{
		return vtkEuclideanClusterExtraction_GetNumberOfExtractedClusters_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEuclideanClusterExtraction_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEuclideanClusterExtraction_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEuclideanClusterExtraction_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEuclideanClusterExtraction_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEuclideanClusterExtraction_GetRadius_18(HandleRef pThis);

	/// <summary>
	/// Specify the local search radius.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkEuclideanClusterExtraction_GetRadius_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEuclideanClusterExtraction_GetRadiusMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Specify the local search radius.
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkEuclideanClusterExtraction_GetRadiusMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEuclideanClusterExtraction_GetRadiusMinValue_20(HandleRef pThis);

	/// <summary>
	/// Specify the local search radius.
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkEuclideanClusterExtraction_GetRadiusMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkEuclideanClusterExtraction_GetScalarConnectivity_21(HandleRef pThis);

	/// <summary>
	/// Turn on/off connectivity based on scalar value. If on, points are
	/// connected only if the are proximal AND the scalar value of a candidate
	/// point falls in the scalar range specified. Of course input point scalar
	/// data must be provided.
	/// </summary>
	public virtual bool GetScalarConnectivity()
	{
		return (vtkEuclideanClusterExtraction_GetScalarConnectivity_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEuclideanClusterExtraction_GetScalarRange_22(HandleRef pThis);

	/// <summary>
	/// Set the scalar range used to extract points based on scalar connectivity.
	/// </summary>
	public virtual double[] GetScalarRange()
	{
		IntPtr intPtr = vtkEuclideanClusterExtraction_GetScalarRange_22(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_GetScalarRange_23(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set the scalar range used to extract points based on scalar connectivity.
	/// </summary>
	public virtual void GetScalarRange(ref double _arg1, ref double _arg2)
	{
		vtkEuclideanClusterExtraction_GetScalarRange_23(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_GetScalarRange_24(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the scalar range used to extract points based on scalar connectivity.
	/// </summary>
	public virtual void GetScalarRange(IntPtr _arg)
	{
		vtkEuclideanClusterExtraction_GetScalarRange_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_InitializeSeedList_25(HandleRef pThis);

	/// <summary>
	/// Initialize the list of point ids used to seed clusters.
	/// </summary>
	public void InitializeSeedList()
	{
		vtkEuclideanClusterExtraction_InitializeSeedList_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_InitializeSpecifiedClusterList_26(HandleRef pThis);

	/// <summary>
	/// Initialize the list of cluster ids to extract.
	/// </summary>
	public void InitializeSpecifiedClusterList()
	{
		vtkEuclideanClusterExtraction_InitializeSpecifiedClusterList_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEuclideanClusterExtraction_IsA_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEuclideanClusterExtraction_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEuclideanClusterExtraction_IsTypeOf_28(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEuclideanClusterExtraction_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEuclideanClusterExtraction_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkEuclideanClusterExtraction NewInstance()
	{
		vtkEuclideanClusterExtraction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEuclideanClusterExtraction_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEuclideanClusterExtraction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEuclideanClusterExtraction_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEuclideanClusterExtraction SafeDownCast(vtkObjectBase o)
	{
		vtkEuclideanClusterExtraction vtkEuclideanClusterExtraction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEuclideanClusterExtraction_SafeDownCast_31(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEuclideanClusterExtraction2 = (vtkEuclideanClusterExtraction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEuclideanClusterExtraction2.Register(null);
			}
		}
		return vtkEuclideanClusterExtraction2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_ScalarConnectivityOff_32(HandleRef pThis);

	/// <summary>
	/// Turn on/off connectivity based on scalar value. If on, points are
	/// connected only if the are proximal AND the scalar value of a candidate
	/// point falls in the scalar range specified. Of course input point scalar
	/// data must be provided.
	/// </summary>
	public virtual void ScalarConnectivityOff()
	{
		vtkEuclideanClusterExtraction_ScalarConnectivityOff_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_ScalarConnectivityOn_33(HandleRef pThis);

	/// <summary>
	/// Turn on/off connectivity based on scalar value. If on, points are
	/// connected only if the are proximal AND the scalar value of a candidate
	/// point falls in the scalar range specified. Of course input point scalar
	/// data must be provided.
	/// </summary>
	public virtual void ScalarConnectivityOn()
	{
		vtkEuclideanClusterExtraction_ScalarConnectivityOn_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_SetClosestPoint_34(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Used to specify the x-y-z point coordinates when extracting the cluster
	/// closest to a specified point.
	/// </summary>
	public virtual void SetClosestPoint(double _arg1, double _arg2, double _arg3)
	{
		vtkEuclideanClusterExtraction_SetClosestPoint_34(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_SetClosestPoint_35(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Used to specify the x-y-z point coordinates when extracting the cluster
	/// closest to a specified point.
	/// </summary>
	public virtual void SetClosestPoint(IntPtr _arg)
	{
		vtkEuclideanClusterExtraction_SetClosestPoint_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_SetColorClusters_36(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off the coloring of connected clusters.
	/// </summary>
	public virtual void SetColorClusters(bool _arg)
	{
		vtkEuclideanClusterExtraction_SetColorClusters_36(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_SetExtractionMode_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public virtual void SetExtractionMode(int _arg)
	{
		vtkEuclideanClusterExtraction_SetExtractionMode_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_SetExtractionModeToAllClusters_38(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToAllClusters()
	{
		vtkEuclideanClusterExtraction_SetExtractionModeToAllClusters_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_SetExtractionModeToClosestPointCluster_39(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToClosestPointCluster()
	{
		vtkEuclideanClusterExtraction_SetExtractionModeToClosestPointCluster_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_SetExtractionModeToLargestCluster_40(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToLargestCluster()
	{
		vtkEuclideanClusterExtraction_SetExtractionModeToLargestCluster_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_SetExtractionModeToPointSeededClusters_41(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToPointSeededClusters()
	{
		vtkEuclideanClusterExtraction_SetExtractionModeToPointSeededClusters_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_SetExtractionModeToSpecifiedClusters_42(HandleRef pThis);

	/// <summary>
	/// Control the extraction of connected surfaces.
	/// </summary>
	public void SetExtractionModeToSpecifiedClusters()
	{
		vtkEuclideanClusterExtraction_SetExtractionModeToSpecifiedClusters_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_SetLocator_43(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient proximity searches near a
	/// specified interpolation position.
	/// </summary>
	public void SetLocator(vtkAbstractPointLocator locator)
	{
		vtkEuclideanClusterExtraction_SetLocator_43(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_SetRadius_44(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the local search radius.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkEuclideanClusterExtraction_SetRadius_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_SetScalarConnectivity_45(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off connectivity based on scalar value. If on, points are
	/// connected only if the are proximal AND the scalar value of a candidate
	/// point falls in the scalar range specified. Of course input point scalar
	/// data must be provided.
	/// </summary>
	public virtual void SetScalarConnectivity(bool _arg)
	{
		vtkEuclideanClusterExtraction_SetScalarConnectivity_45(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_SetScalarRange_46(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set the scalar range used to extract points based on scalar connectivity.
	/// </summary>
	public virtual void SetScalarRange(double _arg1, double _arg2)
	{
		vtkEuclideanClusterExtraction_SetScalarRange_46(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEuclideanClusterExtraction_SetScalarRange_47(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the scalar range used to extract points based on scalar connectivity.
	/// </summary>
	public void SetScalarRange(IntPtr _arg)
	{
		vtkEuclideanClusterExtraction_SetScalarRange_47(GetCppThis(), _arg);
	}
}
