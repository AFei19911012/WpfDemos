using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStaticPointLocator2D
/// </summary>
/// <remarks>
///    quickly locate points in 2-space
///
/// vtkStaticPointLocator2D is a spatial search object to quickly locate points
/// in 2D.  vtkStaticPointLocator2D works by dividing a specified region of
/// space into a regular array of rectilinear buckets, and then keeping a
/// list of points that lie in each bucket. Typical operation involves giving
/// a position in 2D and finding the closest point; or finding the N closest
/// points. (Note that the more general vtkStaticPointLocator is available
/// for 3D operations.) Other specialized methods for 2D have also been provided.
///
/// vtkStaticPointLocator2D is an accelerated version of vtkPointLocator. It is
/// threaded (via vtkSMPTools), and supports one-time static construction
/// (i.e., incremental point insertion is not supported). If you need to
/// incrementally insert points, use the vtkPointLocator or its kin to do so.
///
/// Note that to satisfy the superclass's API, methods often assume a 3D point
/// is provided. However, only the x,y values are used for processing. The
/// z-value is only used to define location of the 2D plane.
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
/// </remarks>
/// <seealso>
///
/// vtkStaticPointLocator vtkPointLocator vtkCellLocator vtkLocator
/// vtkAbstractPointLocator
/// </seealso>
public class vtkStaticPointLocator2D : vtkAbstractPointLocator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStaticPointLocator2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStaticPointLocator2D()
	{
		MRClassNameKey = "class vtkStaticPointLocator2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStaticPointLocator2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStaticPointLocator2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticPointLocator2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with automatic computation of divisions, averaging
	/// 5 points per bucket.
	/// </summary>
	public new static vtkStaticPointLocator2D New()
	{
		vtkStaticPointLocator2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStaticPointLocator2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStaticPointLocator2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with automatic computation of divisions, averaging
	/// 5 points per bucket.
	/// </summary>
	public vtkStaticPointLocator2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStaticPointLocator2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkStaticPointLocator2D_BuildLocator_01(HandleRef pThis);

	/// <summary>
	/// See vtkLocator and vtkAbstractPointLocator interface documentation.
	/// These methods are not thread safe.
	/// </summary>
	public override void BuildLocator()
	{
		vtkStaticPointLocator2D_BuildLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStaticPointLocator2D_FindCloseNBoundedPoints_02(HandleRef pThis, int N, IntPtr x, HandleRef result);

	/// <summary>
	/// Special method for 2D operations (e.g., vtkVoronoi2D). The method
	/// returns the approximate number of points requested, returning the radius
	/// R of the furthest point, with the guarantee that all points are included
	/// that are closer than &lt;=R.
	/// </summary>
	public double FindCloseNBoundedPoints(int N, IntPtr x, vtkIdList result)
	{
		return vtkStaticPointLocator2D_FindCloseNBoundedPoints_02(GetCppThis(), N, x, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator2D_FindClosestNPoints_03(HandleRef pThis, int N, IntPtr x, HandleRef result);

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
		vtkStaticPointLocator2D_FindClosestNPoints_03(GetCppThis(), N, x, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticPointLocator2D_FindClosestPoint_04(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Given a position x, return the id of the point closest to it. An
	/// alternative method (defined in the superclass) requires separate x-y-z
	/// values. These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first. (Note in the 2D locator
	/// the z-value is ignored.)
	/// </summary>
	public override long FindClosestPoint(IntPtr x)
	{
		return vtkStaticPointLocator2D_FindClosestPoint_04(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticPointLocator2D_FindClosestPointWithinRadius_05(HandleRef pThis, double radius, IntPtr x, ref double dist2);

	/// <summary>
	/// Given a position x and a radius r, return the id of the point closest to
	/// the point within that radius.  These methods are thread safe if
	/// BuildLocator() is directly or indirectly called from a single thread
	/// first. dist2 returns the squared distance to the point. Note that if multiple
	/// points are located the same distance away, the actual point returned is a
	/// function in which order the points are processed (i.e., indeterminate).
	/// </summary>
	public override long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
	{
		return vtkStaticPointLocator2D_FindClosestPointWithinRadius_05(GetCppThis(), radius, x, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticPointLocator2D_FindClosestPointWithinRadius_06(HandleRef pThis, double radius, IntPtr x, double inputDataLength, ref double dist2);

	/// <summary>
	/// Given a position x and a radius r, return the id of the point closest to
	/// the point within that radius.  These methods are thread safe if
	/// BuildLocator() is directly or indirectly called from a single thread
	/// first. dist2 returns the squared distance to the point. Note that if multiple
	/// points are located the same distance away, the actual point returned is a
	/// function in which order the points are processed (i.e., indeterminate).
	/// </summary>
	public virtual long FindClosestPointWithinRadius(double radius, IntPtr x, double inputDataLength, ref double dist2)
	{
		return vtkStaticPointLocator2D_FindClosestPointWithinRadius_06(GetCppThis(), radius, x, inputDataLength, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator2D_FindPointsWithinRadius_07(HandleRef pThis, double R, IntPtr x, HandleRef result);

	/// <summary>
	/// Find all points within a specified radius R of position x.
	/// The result is not sorted in any specific manner.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first.
	/// </summary>
	public override void FindPointsWithinRadius(double R, IntPtr x, vtkIdList result)
	{
		vtkStaticPointLocator2D_FindPointsWithinRadius_07(GetCppThis(), R, x, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator2D_ForceBuildLocator_08(HandleRef pThis);

	/// <summary>
	/// See vtkLocator and vtkAbstractPointLocator interface documentation.
	/// These methods are not thread safe.
	/// </summary>
	public override void ForceBuildLocator()
	{
		vtkStaticPointLocator2D_ForceBuildLocator_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator2D_FreeSearchStructure_09(HandleRef pThis);

	/// <summary>
	/// See vtkLocator and vtkAbstractPointLocator interface documentation.
	/// These methods are not thread safe.
	/// </summary>
	public override void FreeSearchStructure()
	{
		vtkStaticPointLocator2D_FreeSearchStructure_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator2D_GenerateRepresentation_10(HandleRef pThis, int level, HandleRef pd);

	/// <summary>
	/// Populate a polydata with the faces of the bins that potentially contain cells.
	/// Note that the level parameter has no effect on this method as there is no
	/// hierarchy built (i.e., uniform binning). Typically this is used for debugging.
	/// </summary>
	public override void GenerateRepresentation(int level, vtkPolyData pd)
	{
		vtkStaticPointLocator2D_GenerateRepresentation_10(GetCppThis(), level, pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator2D_GetBounds_11(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Provide an accessor to the bounds. Valid after the locator is built.
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkStaticPointLocator2D_GetBounds_11(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator2D_GetBucketIds_12(HandleRef pThis, long bNum, HandleRef bList);

	/// <summary>
	/// Given a bucket number bNum between 0 &lt;= bNum &lt; this-&gt;GetNumberOfBuckets(),
	/// return a list of point ids contained within the bucket. The user must
	/// provide an instance of vtkIdList to contain the result.
	/// </summary>
	public void GetBucketIds(long bNum, vtkIdList bList)
	{
		vtkStaticPointLocator2D_GetBucketIds_12(GetCppThis(), bNum, bList?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticPointLocator2D_GetBucketIndex_13(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Given a point x[3], return the locator index (i,j) which contains the
	/// point. This method is meant to be fast, so error checking is not
	/// performed. This method should only be called after the locator is built.
	/// </summary>
	public long GetBucketIndex(IntPtr x)
	{
		return vtkStaticPointLocator2D_GetBucketIndex_13(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator2D_GetBucketIndices_14(HandleRef pThis, IntPtr x, IntPtr ij);

	/// <summary>
	/// Given a point x[3], return the locator index (i,j) which contains the
	/// point. This method is meant to be fast, so error checking is not
	/// performed. This method should only be called after the locator is built.
	/// </summary>
	public void GetBucketIndices(IntPtr x, IntPtr ij)
	{
		vtkStaticPointLocator2D_GetBucketIndices_14(GetCppThis(), x, ij);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticPointLocator2D_GetDivisions_15(HandleRef pThis);

	/// <summary>
	/// Set the number of divisions in x-y directions. If the Automatic data
	/// member is enabled, the Divisions are set according to the
	/// NumberOfPointsPerBucket and MaxNumberOfBuckets data members. The number
	/// of divisions must be &gt;= 1 in each direction.
	/// </summary>
	public virtual int[] GetDivisions()
	{
		IntPtr intPtr = vtkStaticPointLocator2D_GetDivisions_15(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator2D_GetDivisions_16(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the number of divisions in x-y directions. If the Automatic data
	/// member is enabled, the Divisions are set according to the
	/// NumberOfPointsPerBucket and MaxNumberOfBuckets data members. The number
	/// of divisions must be &gt;= 1 in each direction.
	/// </summary>
	public virtual void GetDivisions(IntPtr data)
	{
		vtkStaticPointLocator2D_GetDivisions_16(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStaticPointLocator2D_GetLargeIds_17(HandleRef pThis);

	/// <summary>
	/// Inform the user as to whether large ids are being used. This flag only
	/// has meaning after the locator has been built. Large ids are used when the
	/// number of binned points, or the number of bins, is &gt;= the maximum number
	/// of buckets (specified by the user). Note that LargeIds are only available
	/// on 64-bit architectures.
	/// </summary>
	public bool GetLargeIds()
	{
		return (vtkStaticPointLocator2D_GetLargeIds_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticPointLocator2D_GetMaxNumberOfBuckets_18(HandleRef pThis);

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
		return vtkStaticPointLocator2D_GetMaxNumberOfBuckets_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticPointLocator2D_GetMaxNumberOfBucketsMaxValue_19(HandleRef pThis);

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
		return vtkStaticPointLocator2D_GetMaxNumberOfBucketsMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticPointLocator2D_GetMaxNumberOfBucketsMinValue_20(HandleRef pThis);

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
		return vtkStaticPointLocator2D_GetMaxNumberOfBucketsMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticPointLocator2D_GetNumberOfGenerationsFromBase_21(HandleRef pThis, string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStaticPointLocator2D_GetNumberOfGenerationsFromBase_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticPointLocator2D_GetNumberOfGenerationsFromBaseType_22(string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStaticPointLocator2D_GetNumberOfGenerationsFromBaseType_22(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticPointLocator2D_GetNumberOfPointsInBucket_23(HandleRef pThis, long bNum);

	/// <summary>
	/// Given a bucket number bNum between 0 &lt;= bNum &lt; this-&gt;GetNumberOfBuckets(),
	/// return the number of points found in the bucket. Note that a bucket can
	/// also be specified with locator indices (i,j) which converts to a the
	/// bucket number bNum=i+this-&gt;Divisions[0]*j.
	/// </summary>
	public long GetNumberOfPointsInBucket(long bNum)
	{
		return vtkStaticPointLocator2D_GetNumberOfPointsInBucket_23(GetCppThis(), bNum);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticPointLocator2D_GetNumberOfPointsPerBucket_24(HandleRef pThis);

	/// <summary>
	/// Specify the average number of points in each bucket. This data member is
	/// used in conjunction with the Automatic data member (if enabled) to
	/// determine the number of locator x-y divisions.
	/// </summary>
	public virtual int GetNumberOfPointsPerBucket()
	{
		return vtkStaticPointLocator2D_GetNumberOfPointsPerBucket_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticPointLocator2D_GetNumberOfPointsPerBucketMaxValue_25(HandleRef pThis);

	/// <summary>
	/// Specify the average number of points in each bucket. This data member is
	/// used in conjunction with the Automatic data member (if enabled) to
	/// determine the number of locator x-y divisions.
	/// </summary>
	public virtual int GetNumberOfPointsPerBucketMaxValue()
	{
		return vtkStaticPointLocator2D_GetNumberOfPointsPerBucketMaxValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticPointLocator2D_GetNumberOfPointsPerBucketMinValue_26(HandleRef pThis);

	/// <summary>
	/// Specify the average number of points in each bucket. This data member is
	/// used in conjunction with the Automatic data member (if enabled) to
	/// determine the number of locator x-y divisions.
	/// </summary>
	public virtual int GetNumberOfPointsPerBucketMinValue()
	{
		return vtkStaticPointLocator2D_GetNumberOfPointsPerBucketMinValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticPointLocator2D_GetSpacing_27(HandleRef pThis);

	/// <summary>
	/// Provide an accessor to the bucket spacing. Valid after the locator is
	/// built.
	/// </summary>
	public virtual IntPtr GetSpacing()
	{
		return vtkStaticPointLocator2D_GetSpacing_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator2D_GetSpacing_28(HandleRef pThis, IntPtr spacing);

	/// <summary>
	/// Provide an accessor to the bucket spacing. Valid after the locator is
	/// built.
	/// </summary>
	public virtual void GetSpacing(IntPtr spacing)
	{
		vtkStaticPointLocator2D_GetSpacing_28(GetCppThis(), spacing);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator2D_Initialize_29(HandleRef pThis);

	/// <summary>
	/// See vtkLocator and vtkAbstractPointLocator interface documentation.
	/// These methods are not thread safe.
	/// </summary>
	public override void Initialize()
	{
		vtkStaticPointLocator2D_Initialize_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticPointLocator2D_IntersectWithLine_30(HandleRef pThis, IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr lineX, IntPtr ptX, ref long ptId);

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
		return vtkStaticPointLocator2D_IntersectWithLine_30(GetCppThis(), a0, a1, tol, ref t, lineX, ptX, ref ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticPointLocator2D_IsA_31(HandleRef pThis, string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStaticPointLocator2D_IsA_31(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticPointLocator2D_IsTypeOf_32(string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStaticPointLocator2D_IsTypeOf_32(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator2D_MergePoints_33(HandleRef pThis, double tol, IntPtr mergeMap);

	/// <summary>
	/// Merge points in the locator given a tolerance. Return a merge map which
	/// represents the mapping of "concident" point ids to a single point. Note
	/// the number of points in the merge map is the number of points the
	/// locator was built with. The user is expected to pass in an allocated
	/// mergeMap.
	/// </summary>
	public void MergePoints(double tol, IntPtr mergeMap)
	{
		vtkStaticPointLocator2D_MergePoints_33(GetCppThis(), tol, mergeMap);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticPointLocator2D_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new vtkStaticPointLocator2D NewInstance()
	{
		vtkStaticPointLocator2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStaticPointLocator2D_NewInstance_35(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStaticPointLocator2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticPointLocator2D_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new static vtkStaticPointLocator2D SafeDownCast(vtkObjectBase o)
	{
		vtkStaticPointLocator2D vtkStaticPointLocator2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStaticPointLocator2D_SafeDownCast_36(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStaticPointLocator2D2 = (vtkStaticPointLocator2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStaticPointLocator2D2.Register(null);
			}
		}
		return vtkStaticPointLocator2D2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator2D_SetDivisions_37(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set the number of divisions in x-y directions. If the Automatic data
	/// member is enabled, the Divisions are set according to the
	/// NumberOfPointsPerBucket and MaxNumberOfBuckets data members. The number
	/// of divisions must be &gt;= 1 in each direction.
	/// </summary>
	public virtual void SetDivisions(int _arg1, int _arg2)
	{
		vtkStaticPointLocator2D_SetDivisions_37(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator2D_SetDivisions_38(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the number of divisions in x-y directions. If the Automatic data
	/// member is enabled, the Divisions are set according to the
	/// NumberOfPointsPerBucket and MaxNumberOfBuckets data members. The number
	/// of divisions must be &gt;= 1 in each direction.
	/// </summary>
	public void SetDivisions(IntPtr _arg)
	{
		vtkStaticPointLocator2D_SetDivisions_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator2D_SetMaxNumberOfBuckets_39(HandleRef pThis, long _arg);

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
		vtkStaticPointLocator2D_SetMaxNumberOfBuckets_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticPointLocator2D_SetNumberOfPointsPerBucket_40(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the average number of points in each bucket. This data member is
	/// used in conjunction with the Automatic data member (if enabled) to
	/// determine the number of locator x-y divisions.
	/// </summary>
	public virtual void SetNumberOfPointsPerBucket(int _arg)
	{
		vtkStaticPointLocator2D_SetNumberOfPointsPerBucket_40(GetCppThis(), _arg);
	}
}
