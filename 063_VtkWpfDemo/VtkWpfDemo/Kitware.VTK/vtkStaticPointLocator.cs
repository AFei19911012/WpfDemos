using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStaticPointLocator
/// </summary>
/// <remarks>
///    quickly locate points in 3-space
///
/// vtkStaticPointLocator is a spatial search object to quickly locate points
/// in 3D.  vtkStaticPointLocator works by dividing a specified region of
/// space into a regular array of cuboid buckets, and then keeping a
/// list of points that lie in each bucket. Typical operation involves giving
/// a position in 3D and finding the closest point; or finding the N closest
/// points.
///
/// vtkStaticPointLocator is an accelerated version of vtkPointLocator. It is
/// threaded (via vtkSMPTools), and supports one-time static construction
/// (i.e., incremental point insertion is not supported). If you need to
/// incrementally insert points, use the vtkPointLocator or its kin to do so.
///
/// @warning
/// This class is templated. It may run slower than serial execution if the code
/// is not optimized during compilation. Build in Release or ReleaseWithDebugInfo.
///
/// @warning
/// Make sure that you review the documentation for the superclasses
/// vtkAbstactPointLocator and vtkLocator. In particular the Automatic
/// data member can be used to automatically determine divisions based
/// on the average number of points per bucket.
///
/// @warning
/// Other types of spatial locators have been developed such as octrees and
/// kd-trees. These are often more efficient for the operations described
/// here.
///
/// @warning
/// Frequently vtkStaticPointLocator is used in lieu of vtkPointLocator.
/// They are very similar in terms of algorithmic approach, however
/// vtkStaticCellLocator is threaded and is typically much faster for
/// a large number of points (on the order of 3-5x faster). For small numbers
/// of points, vtkPointLocator is just as fast as vtkStaticPointLocator.
///
/// </remarks>
/// <seealso>
///
/// vtkPointLocator vtkCellLocator vtkLocator vtkAbstractPointLocator
/// </seealso>
public class vtkStaticPointLocator : vtkAbstractPointLocator
{
	/// <summary>
	/// Point merging is inherently an order-dependent process. Because naive
	/// threaded execution can non-deterministically change the ordering of
	/// merged points, threaded point merging for tolerances != 0.0 requires
	/// some level of serialization of the merging process to produce
	/// deterministic results. POINT_ORDER is completely serialized: two
	/// points with ids p0,p1 are merged if they are within tolerance of one
	/// another, with p1-&gt;p0 (p1 merged to p0) if p0&lt;p1. IN BIN_ORDER, a
	/// threaded checkerboarding approach is used so that p1-&gt;p0 when p0&lt;p1 in
	/// the local bin neighborhood and p1 not yet merged.
	/// </summary>
	public enum TraversalOrderType
	{
		/// <summary>enum member</summary>
		BIN_ORDER = 1,
		/// <summary>enum member</summary>
		POINT_ORDER = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStaticPointLocator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStaticPointLocator()
	{
		MRClassNameKey = "class vtkStaticPointLocator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStaticPointLocator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStaticPointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticPointLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with automatic computation of divisions, averaging
	/// 5 points per bucket.
	/// </summary>
	public new static vtkStaticPointLocator New()
	{
		vtkStaticPointLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStaticPointLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStaticPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with automatic computation of divisions, averaging
	/// 5 points per bucket.
	/// </summary>
	public vtkStaticPointLocator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStaticPointLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkStaticPointLocator_BuildLocator_01(HandleRef pThis);

	/// <summary>
	/// See vtkLocator and vtkAbstractPointLocator interface documentation.
	/// These methods are not thread safe.
	/// </summary>
	public override void BuildLocator()
	{
		vtkStaticPointLocator_BuildLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator_BuildLocator_02(HandleRef pThis, IntPtr inBounds);

	/// <summary>
	/// See vtkLocator and vtkAbstractPointLocator interface documentation.
	/// These methods are not thread safe.
	/// </summary>
	public void BuildLocator(IntPtr inBounds)
	{
		vtkStaticPointLocator_BuildLocator_02(GetCppThis(), inBounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator_FindClosestNPoints_03(HandleRef pThis, int N, IntPtr x, HandleRef result);

	/// <summary>
	/// Find the closest N points to a position. This returns the closest N
	/// points to a position. A faster method could be created that returned N
	/// close points to a position, but necessarily the exact N closest.  The
	/// returned points are sorted from closest to farthest.  These methods are
	/// thread safe if BuildLocator() is directly or indirectly called from a
	/// single thread first.
	/// </summary>
	public override void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
	{
		vtkStaticPointLocator_FindClosestNPoints_03(GetCppThis(), N, x, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticPointLocator_FindClosestPoint_04(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Given a position x, return the id of the point closest to it, or (-1) if
	/// no point found. An alternative method (defined in the superclass)
	/// requires separate x-y-z values. These methods are thread safe if
	/// BuildLocator() is directly or indirectly called from a single thread
	/// first.
	/// </summary>
	public override long FindClosestPoint(IntPtr x)
	{
		return vtkStaticPointLocator_FindClosestPoint_04(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticPointLocator_FindClosestPointWithinRadius_05(HandleRef pThis, double radius, IntPtr x, ref double dist2);

	/// <summary>
	/// Given a position x and a radius r, return the id of the point closest to
	/// the point in that radius, or (-1) if nothing found.  These methods are
	/// thread safe if BuildLocator() is directly or indirectly called from a
	/// single thread first. dist2 returns the squared distance to the
	/// point. Note that if multiple points are located the same distance away,
	/// the actual point returned is a function in which order the points are
	/// processed (i.e., indeterminate).
	/// </summary>
	public override long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
	{
		return vtkStaticPointLocator_FindClosestPointWithinRadius_05(GetCppThis(), radius, x, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticPointLocator_FindClosestPointWithinRadius_06(HandleRef pThis, double radius, IntPtr x, double inputDataLength, ref double dist2);

	/// <summary>
	/// Given a position x and a radius r, return the id of the point closest to
	/// the point in that radius, or (-1) if nothing found.  These methods are
	/// thread safe if BuildLocator() is directly or indirectly called from a
	/// single thread first. dist2 returns the squared distance to the
	/// point. Note that if multiple points are located the same distance away,
	/// the actual point returned is a function in which order the points are
	/// processed (i.e., indeterminate).
	/// </summary>
	public virtual long FindClosestPointWithinRadius(double radius, IntPtr x, double inputDataLength, ref double dist2)
	{
		return vtkStaticPointLocator_FindClosestPointWithinRadius_06(GetCppThis(), radius, x, inputDataLength, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator_FindPointsWithinRadius_07(HandleRef pThis, double R, IntPtr x, HandleRef result);

	/// <summary>
	/// Find all points within a specified radius R of position x.
	/// The result is not sorted in any specific manner.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first.
	/// </summary>
	public override void FindPointsWithinRadius(double R, IntPtr x, vtkIdList result)
	{
		vtkStaticPointLocator_FindPointsWithinRadius_07(GetCppThis(), R, x, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator_ForceBuildLocator_08(HandleRef pThis);

	/// <summary>
	/// See vtkLocator and vtkAbstractPointLocator interface documentation.
	/// These methods are not thread safe.
	/// </summary>
	public override void ForceBuildLocator()
	{
		vtkStaticPointLocator_ForceBuildLocator_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator_FreeSearchStructure_09(HandleRef pThis);

	/// <summary>
	/// See vtkLocator and vtkAbstractPointLocator interface documentation.
	/// These methods are not thread safe.
	/// </summary>
	public override void FreeSearchStructure()
	{
		vtkStaticPointLocator_FreeSearchStructure_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator_GenerateRepresentation_10(HandleRef pThis, int level, HandleRef pd);

	/// <summary>
	/// Populate a polydata with the faces of the bins that potentially contain cells.
	/// Note that the level parameter has no effect on this method as there is no
	/// hierarchy built (i.e., uniform binning). Typically this is used for debugging.
	/// </summary>
	public override void GenerateRepresentation(int level, vtkPolyData pd)
	{
		vtkStaticPointLocator_GenerateRepresentation_10(GetCppThis(), level, pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator_GetBucketIds_11(HandleRef pThis, long bNum, HandleRef bList);

	/// <summary>
	/// Given a bucket number bNum between 0 &lt;= bNum &lt; this-&gt;GetNumberOfBuckets(),
	/// return a list of point ids contained within the bucket. The user must
	/// provide an instance of vtkIdList to contain the result.
	/// </summary>
	public void GetBucketIds(long bNum, vtkIdList bList)
	{
		vtkStaticPointLocator_GetBucketIds_11(GetCppThis(), bNum, bList?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticPointLocator_GetDivisions_12(HandleRef pThis);

	/// <summary>
	/// Set the number of divisions in x-y-z directions. If the Automatic data
	/// member is enabled, the Divisions are set according to the
	/// NumberOfPointsPerBucket and MaxNumberOfBuckets data members. The number
	/// of divisions must be &gt;= 1 in each direction.
	/// </summary>
	public virtual int[] GetDivisions()
	{
		IntPtr intPtr = vtkStaticPointLocator_GetDivisions_12(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator_GetDivisions_13(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the number of divisions in x-y-z directions. If the Automatic data
	/// member is enabled, the Divisions are set according to the
	/// NumberOfPointsPerBucket and MaxNumberOfBuckets data members. The number
	/// of divisions must be &gt;= 1 in each direction.
	/// </summary>
	public virtual void GetDivisions(IntPtr data)
	{
		vtkStaticPointLocator_GetDivisions_13(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStaticPointLocator_GetLargeIds_14(HandleRef pThis);

	/// <summary>
	/// Inform the user as to whether large ids are being used. This flag only
	/// has meaning after the locator has been built. Large ids are used when the
	/// number of binned points, or the number of bins, is &gt;= the maximum number
	/// of buckets (specified by the user). Note that LargeIds are only available
	/// on 64-bit architectures.
	/// </summary>
	public bool GetLargeIds()
	{
		return (vtkStaticPointLocator_GetLargeIds_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticPointLocator_GetMaxNumberOfBuckets_15(HandleRef pThis);

	/// <summary>
	/// Set the maximum number of buckets in the locator. By default the value
	/// is set to VTK_INT_MAX. Note that there are significant performance
	/// implications at work here. If the number of buckets is set very large
	/// (meaning &gt; VTK_INT_MAX) then internal sorting may be performed using
	/// 64-bit integers (which is much slower than using a 32-bit int). Of
	/// course, memory requirements may dramatically increase as well.  It is
	/// recommended that the default value be used; but for extremely large data
	/// it may be desired to create a locator with an exceptionally large number
	/// of buckets. Note also that during initialization of the locator if the
	/// MaxNumberOfBuckets threshold is exceeded, the Divisions are scaled down
	/// in such a way as not to exceed the MaxNumberOfBuckets proportionally to
	/// the size of the bounding box in the x-y-z directions.
	/// </summary>
	public virtual long GetMaxNumberOfBuckets()
	{
		return vtkStaticPointLocator_GetMaxNumberOfBuckets_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticPointLocator_GetMaxNumberOfBucketsMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Set the maximum number of buckets in the locator. By default the value
	/// is set to VTK_INT_MAX. Note that there are significant performance
	/// implications at work here. If the number of buckets is set very large
	/// (meaning &gt; VTK_INT_MAX) then internal sorting may be performed using
	/// 64-bit integers (which is much slower than using a 32-bit int). Of
	/// course, memory requirements may dramatically increase as well.  It is
	/// recommended that the default value be used; but for extremely large data
	/// it may be desired to create a locator with an exceptionally large number
	/// of buckets. Note also that during initialization of the locator if the
	/// MaxNumberOfBuckets threshold is exceeded, the Divisions are scaled down
	/// in such a way as not to exceed the MaxNumberOfBuckets proportionally to
	/// the size of the bounding box in the x-y-z directions.
	/// </summary>
	public virtual long GetMaxNumberOfBucketsMaxValue()
	{
		return vtkStaticPointLocator_GetMaxNumberOfBucketsMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticPointLocator_GetMaxNumberOfBucketsMinValue_17(HandleRef pThis);

	/// <summary>
	/// Set the maximum number of buckets in the locator. By default the value
	/// is set to VTK_INT_MAX. Note that there are significant performance
	/// implications at work here. If the number of buckets is set very large
	/// (meaning &gt; VTK_INT_MAX) then internal sorting may be performed using
	/// 64-bit integers (which is much slower than using a 32-bit int). Of
	/// course, memory requirements may dramatically increase as well.  It is
	/// recommended that the default value be used; but for extremely large data
	/// it may be desired to create a locator with an exceptionally large number
	/// of buckets. Note also that during initialization of the locator if the
	/// MaxNumberOfBuckets threshold is exceeded, the Divisions are scaled down
	/// in such a way as not to exceed the MaxNumberOfBuckets proportionally to
	/// the size of the bounding box in the x-y-z directions.
	/// </summary>
	public virtual long GetMaxNumberOfBucketsMinValue()
	{
		return vtkStaticPointLocator_GetMaxNumberOfBucketsMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticPointLocator_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStaticPointLocator_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticPointLocator_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStaticPointLocator_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticPointLocator_GetNumberOfPointsInBucket_20(HandleRef pThis, long bNum);

	/// <summary>
	/// Given a bucket number bNum between 0 &lt;= bNum &lt; this-&gt;GetNumberOfBuckets(),
	/// return the number of points found in the bucket.
	/// </summary>
	public long GetNumberOfPointsInBucket(long bNum)
	{
		return vtkStaticPointLocator_GetNumberOfPointsInBucket_20(GetCppThis(), bNum);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticPointLocator_GetNumberOfPointsPerBucket_21(HandleRef pThis);

	/// <summary>
	/// Specify the average number of points in each bucket. This data member is
	/// used in conjunction with the Automatic data member (if enabled) to
	/// determine the number of locator x-y-z divisions.
	/// </summary>
	public virtual int GetNumberOfPointsPerBucket()
	{
		return vtkStaticPointLocator_GetNumberOfPointsPerBucket_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticPointLocator_GetNumberOfPointsPerBucketMaxValue_22(HandleRef pThis);

	/// <summary>
	/// Specify the average number of points in each bucket. This data member is
	/// used in conjunction with the Automatic data member (if enabled) to
	/// determine the number of locator x-y-z divisions.
	/// </summary>
	public virtual int GetNumberOfPointsPerBucketMaxValue()
	{
		return vtkStaticPointLocator_GetNumberOfPointsPerBucketMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticPointLocator_GetNumberOfPointsPerBucketMinValue_23(HandleRef pThis);

	/// <summary>
	/// Specify the average number of points in each bucket. This data member is
	/// used in conjunction with the Automatic data member (if enabled) to
	/// determine the number of locator x-y-z divisions.
	/// </summary>
	public virtual int GetNumberOfPointsPerBucketMinValue()
	{
		return vtkStaticPointLocator_GetNumberOfPointsPerBucketMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticPointLocator_GetSpacing_24(HandleRef pThis);

	/// <summary>
	/// Provide an accessor to the bucket spacing. Valid after the locator is
	/// built.
	/// </summary>
	public virtual IntPtr GetSpacing()
	{
		return vtkStaticPointLocator_GetSpacing_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator_GetSpacing_25(HandleRef pThis, IntPtr spacing);

	/// <summary>
	/// Provide an accessor to the bucket spacing. Valid after the locator is
	/// built.
	/// </summary>
	public virtual void GetSpacing(IntPtr spacing)
	{
		vtkStaticPointLocator_GetSpacing_25(GetCppThis(), spacing);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticPointLocator_GetTraversalOrder_26(HandleRef pThis);

	/// <summary>
	/// Specify the manner in which points are processed when a non-zero merge
	/// tolerance is specified. By default, BIN_ORDER is used (i.e., threaded
	/// using bin checkerboard traversal) versus POINT_ORDER, which is a serial traversal.
	/// </summary>
	public virtual int GetTraversalOrder()
	{
		return vtkStaticPointLocator_GetTraversalOrder_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticPointLocator_GetTraversalOrderMaxValue_27(HandleRef pThis);

	/// <summary>
	/// Specify the manner in which points are processed when a non-zero merge
	/// tolerance is specified. By default, BIN_ORDER is used (i.e., threaded
	/// using bin checkerboard traversal) versus POINT_ORDER, which is a serial traversal.
	/// </summary>
	public virtual int GetTraversalOrderMaxValue()
	{
		return vtkStaticPointLocator_GetTraversalOrderMaxValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticPointLocator_GetTraversalOrderMinValue_28(HandleRef pThis);

	/// <summary>
	/// Specify the manner in which points are processed when a non-zero merge
	/// tolerance is specified. By default, BIN_ORDER is used (i.e., threaded
	/// using bin checkerboard traversal) versus POINT_ORDER, which is a serial traversal.
	/// </summary>
	public virtual int GetTraversalOrderMinValue()
	{
		return vtkStaticPointLocator_GetTraversalOrderMinValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator_Initialize_29(HandleRef pThis);

	/// <summary>
	/// See vtkLocator and vtkAbstractPointLocator interface documentation.
	/// These methods are not thread safe.
	/// </summary>
	public override void Initialize()
	{
		vtkStaticPointLocator_Initialize_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticPointLocator_IntersectWithLine_30(HandleRef pThis, IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr lineX, IntPtr ptX, ref long ptId);

	/// <summary>
	/// Intersect the points contained in the locator with the line defined by
	/// (a0,a1). Return the point within the tolerance tol that is closest to a0
	/// (tol measured in the world coordinate system). If an intersection occurs
	/// (i.e., the method returns nonzero), then the parametric location along
	/// the line t, the closest position along the line lineX, and the coordinates
	/// of the picked ptId is returned in ptX. (This method is thread safe after
	/// the locator is built.)
	/// </summary>
	public int IntersectWithLine(IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr lineX, IntPtr ptX, ref long ptId)
	{
		return vtkStaticPointLocator_IntersectWithLine_30(GetCppThis(), a0, a1, tol, ref t, lineX, ptX, ref ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticPointLocator_IsA_31(HandleRef pThis, string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStaticPointLocator_IsA_31(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticPointLocator_IsTypeOf_32(string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStaticPointLocator_IsTypeOf_32(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator_MergePoints_33(HandleRef pThis, double tol, IntPtr mergeMap);

	/// <summary>
	/// Merge points in the locator given a tolerance. Return a merge map which
	/// maps all points to the points to which they were merged. Note the number
	/// of points in the merge map is the number of points the locator was built
	/// with. The user is expected to pass in an allocated mergeMap. Note that
	/// when tol!=0, the traversal order of threading can be specified using the
	/// SetTraversalOrder() method. The traversal order is needed to generate
	/// deterministic output (i.e., output independent of thread execution
	/// order).
	/// </summary>
	public void MergePoints(double tol, IntPtr mergeMap)
	{
		vtkStaticPointLocator_MergePoints_33(GetCppThis(), tol, mergeMap);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator_MergePointsWithData_34(HandleRef pThis, HandleRef data, IntPtr mergeMap);

	/// <summary>
	/// Merge points and associated data in the locator. Return a merge map
	/// which maps all points to the points to which they were merged. Note the
	/// number of points in the merge map is the number of points the locator
	/// was built with. Merging occurs when both the points and the associated
	/// point data (represented by the data array) are equal. The user is
	/// expected to pass in an allocated mergeMap, and the size of the data
	/// array should be number of points in the locator. The data array may
	/// have an arbitrary number of components.
	/// </summary>
	public void MergePointsWithData(vtkDataArray data, IntPtr mergeMap)
	{
		vtkStaticPointLocator_MergePointsWithData_34(GetCppThis(), data?.GetCppThis() ?? default(HandleRef), mergeMap);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticPointLocator_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new vtkStaticPointLocator NewInstance()
	{
		vtkStaticPointLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStaticPointLocator_NewInstance_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStaticPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticPointLocator_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new static vtkStaticPointLocator SafeDownCast(vtkObjectBase o)
	{
		vtkStaticPointLocator vtkStaticPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStaticPointLocator_SafeDownCast_37(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStaticPointLocator2 = (vtkStaticPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStaticPointLocator2.Register(null);
			}
		}
		return vtkStaticPointLocator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator_SetDivisions_38(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Set the number of divisions in x-y-z directions. If the Automatic data
	/// member is enabled, the Divisions are set according to the
	/// NumberOfPointsPerBucket and MaxNumberOfBuckets data members. The number
	/// of divisions must be &gt;= 1 in each direction.
	/// </summary>
	public virtual void SetDivisions(int _arg1, int _arg2, int _arg3)
	{
		vtkStaticPointLocator_SetDivisions_38(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator_SetDivisions_39(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the number of divisions in x-y-z directions. If the Automatic data
	/// member is enabled, the Divisions are set according to the
	/// NumberOfPointsPerBucket and MaxNumberOfBuckets data members. The number
	/// of divisions must be &gt;= 1 in each direction.
	/// </summary>
	public virtual void SetDivisions(IntPtr _arg)
	{
		vtkStaticPointLocator_SetDivisions_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator_SetMaxNumberOfBuckets_40(HandleRef pThis, long _arg);

	/// <summary>
	/// Set the maximum number of buckets in the locator. By default the value
	/// is set to VTK_INT_MAX. Note that there are significant performance
	/// implications at work here. If the number of buckets is set very large
	/// (meaning &gt; VTK_INT_MAX) then internal sorting may be performed using
	/// 64-bit integers (which is much slower than using a 32-bit int). Of
	/// course, memory requirements may dramatically increase as well.  It is
	/// recommended that the default value be used; but for extremely large data
	/// it may be desired to create a locator with an exceptionally large number
	/// of buckets. Note also that during initialization of the locator if the
	/// MaxNumberOfBuckets threshold is exceeded, the Divisions are scaled down
	/// in such a way as not to exceed the MaxNumberOfBuckets proportionally to
	/// the size of the bounding box in the x-y-z directions.
	/// </summary>
	public virtual void SetMaxNumberOfBuckets(long _arg)
	{
		vtkStaticPointLocator_SetMaxNumberOfBuckets_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator_SetNumberOfPointsPerBucket_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the average number of points in each bucket. This data member is
	/// used in conjunction with the Automatic data member (if enabled) to
	/// determine the number of locator x-y-z divisions.
	/// </summary>
	public virtual void SetNumberOfPointsPerBucket(int _arg)
	{
		vtkStaticPointLocator_SetNumberOfPointsPerBucket_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator_SetTraversalOrder_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the manner in which points are processed when a non-zero merge
	/// tolerance is specified. By default, BIN_ORDER is used (i.e., threaded
	/// using bin checkerboard traversal) versus POINT_ORDER, which is a serial traversal.
	/// </summary>
	public virtual void SetTraversalOrder(int _arg)
	{
		vtkStaticPointLocator_SetTraversalOrder_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator_SetTraversalOrderToBinOrder_43(HandleRef pThis);

	/// <summary>
	/// Specify the manner in which points are processed when a non-zero merge
	/// tolerance is specified. By default, BIN_ORDER is used (i.e., threaded
	/// using bin checkerboard traversal) versus POINT_ORDER, which is a serial traversal.
	/// </summary>
	public void SetTraversalOrderToBinOrder()
	{
		vtkStaticPointLocator_SetTraversalOrderToBinOrder_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator_SetTraversalOrderToPointOrder_44(HandleRef pThis);

	/// <summary>
	/// Specify the manner in which points are processed when a non-zero merge
	/// tolerance is specified. By default, BIN_ORDER is used (i.e., threaded
	/// using bin checkerboard traversal) versus POINT_ORDER, which is a serial traversal.
	/// </summary>
	public void SetTraversalOrderToPointOrder()
	{
		vtkStaticPointLocator_SetTraversalOrderToPointOrder_44(GetCppThis());
	}
}
