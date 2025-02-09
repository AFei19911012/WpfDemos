using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointLocator
/// </summary>
/// <remarks>
///    quickly locate points in 3-space
///
/// vtkPointLocator is a spatial search object to quickly locate points in 3D.
/// vtkPointLocator works by dividing a specified region of space into a regular
/// array of "rectangular" buckets, and then keeping a list of points that
/// lie in each bucket. Typical operation involves giving a position in 3D
/// and finding the closest point.
///
/// vtkPointLocator has two distinct methods of interaction. In the first
/// method, you supply it with a dataset, and it operates on the points in
/// the dataset. In the second method, you supply it with an array of points,
/// and the object operates on the array.
///
/// @warning
/// Many other types of spatial locators have been developed such as
/// octrees and kd-trees. These are often more efficient for the
/// operations described here.
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
/// vtkCellPicker vtkPointPicker vtkStaticPointLocator
/// </seealso>
public class vtkPointLocator : vtkIncrementalPointLocator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointLocator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointLocator()
	{
		MRClassNameKey = "class vtkPointLocator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointLocator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with automatic computation of divisions, averaging
	/// 25 points per bucket.
	/// </summary>
	public new static vtkPointLocator New()
	{
		vtkPointLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with automatic computation of divisions, averaging
	/// 25 points per bucket.
	/// </summary>
	public vtkPointLocator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPointLocator_BuildLocator_01(HandleRef pThis);

	/// <summary>
	/// See vtkLocator interface documentation.
	/// These methods are not thread safe.
	/// </summary>
	public override void BuildLocator()
	{
		vtkPointLocator_BuildLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointLocator_FindClosestInsertedPoint_02(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Given a position x, return the id of the point closest to it. This method
	/// is used when performing incremental point insertion. Note that -1
	/// indicates that no point was found.
	/// This method is thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first.
	/// </summary>
	public override long FindClosestInsertedPoint(IntPtr x)
	{
		return vtkPointLocator_FindClosestInsertedPoint_02(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLocator_FindClosestNPoints_03(HandleRef pThis, int N, IntPtr x, HandleRef result);

	/// <summary>
	/// Find the closest N points to a position. This returns the closest
	/// N points to a position. A faster method could be created that returned
	/// N close points to a position, but necessarily the exact N closest.
	/// The returned points are sorted from closest to farthest.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first.
	/// </summary>
	public override void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
	{
		vtkPointLocator_FindClosestNPoints_03(GetCppThis(), N, x, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointLocator_FindClosestPoint_04(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Given a position x, return the id of the point closest to it. Alternative
	/// method requires separate x-y-z values.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first.
	/// </summary>
	public override long FindClosestPoint(IntPtr x)
	{
		return vtkPointLocator_FindClosestPoint_04(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointLocator_FindClosestPointWithinRadius_05(HandleRef pThis, double radius, IntPtr x, ref double dist2);

	/// <summary>
	/// Given a position x and a radius r, return the id of the point
	/// closest to the point in that radius.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first. dist2 returns the squared
	/// distance to the point.
	/// </summary>
	public override long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
	{
		return vtkPointLocator_FindClosestPointWithinRadius_05(GetCppThis(), radius, x, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointLocator_FindClosestPointWithinRadius_06(HandleRef pThis, double radius, IntPtr x, double inputDataLength, ref double dist2);

	/// <summary>
	/// Given a position x and a radius r, return the id of the point
	/// closest to the point in that radius.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first. dist2 returns the squared
	/// distance to the point.
	/// </summary>
	public virtual long FindClosestPointWithinRadius(double radius, IntPtr x, double inputDataLength, ref double dist2)
	{
		return vtkPointLocator_FindClosestPointWithinRadius_06(GetCppThis(), radius, x, inputDataLength, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLocator_FindDistributedPoints_07(HandleRef pThis, int N, IntPtr x, HandleRef result, int M);

	/// <summary>
	/// Find the closest points to a position such that each octant of
	/// space around the position contains at least N points. Loosely
	/// limit the search to a maximum number of points evaluated, M.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first.
	/// </summary>
	public virtual void FindDistributedPoints(int N, IntPtr x, vtkIdList result, int M)
	{
		vtkPointLocator_FindDistributedPoints_07(GetCppThis(), N, x, result?.GetCppThis() ?? default(HandleRef), M);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLocator_FindDistributedPoints_08(HandleRef pThis, int N, double x, double y, double z, HandleRef result, int M);

	/// <summary>
	/// Find the closest points to a position such that each octant of
	/// space around the position contains at least N points. Loosely
	/// limit the search to a maximum number of points evaluated, M.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first.
	/// </summary>
	public virtual void FindDistributedPoints(int N, double x, double y, double z, vtkIdList result, int M)
	{
		vtkPointLocator_FindDistributedPoints_08(GetCppThis(), N, x, y, z, result?.GetCppThis() ?? default(HandleRef), M);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLocator_FindPointsWithinRadius_09(HandleRef pThis, double R, IntPtr x, HandleRef result);

	/// <summary>
	/// Find all points within a specified radius R of position x.
	/// The result is not sorted in any specific manner.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first.
	/// </summary>
	public override void FindPointsWithinRadius(double R, IntPtr x, vtkIdList result)
	{
		vtkPointLocator_FindPointsWithinRadius_09(GetCppThis(), R, x, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLocator_ForceBuildLocator_10(HandleRef pThis);

	/// <summary>
	/// See vtkLocator interface documentation.
	/// These methods are not thread safe.
	/// </summary>
	public override void ForceBuildLocator()
	{
		vtkPointLocator_ForceBuildLocator_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLocator_FreeSearchStructure_11(HandleRef pThis);

	/// <summary>
	/// See vtkLocator interface documentation.
	/// These methods are not thread safe.
	/// </summary>
	public override void FreeSearchStructure()
	{
		vtkPointLocator_FreeSearchStructure_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLocator_GenerateRepresentation_12(HandleRef pThis, int level, HandleRef pd);

	/// <summary>
	/// See vtkLocator interface documentation.
	/// These methods are not thread safe.
	/// </summary>
	public override void GenerateRepresentation(int level, vtkPolyData pd)
	{
		vtkPointLocator_GenerateRepresentation_12(GetCppThis(), level, pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointLocator_GetDivisions_13(HandleRef pThis);

	/// <summary>
	/// Set the number of divisions in x-y-z directions.
	/// </summary>
	public virtual int[] GetDivisions()
	{
		IntPtr intPtr = vtkPointLocator_GetDivisions_13(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLocator_GetDivisions_14(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the number of divisions in x-y-z directions.
	/// </summary>
	public virtual void GetDivisions(IntPtr data)
	{
		vtkPointLocator_GetDivisions_14(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointLocator_GetNumberOfGenerationsFromBase_15(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type management and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointLocator_GetNumberOfGenerationsFromBase_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointLocator_GetNumberOfGenerationsFromBaseType_16(string type);

	/// <summary>
	/// Standard methods for type management and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointLocator_GetNumberOfGenerationsFromBaseType_16(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointLocator_GetNumberOfPointsPerBucket_17(HandleRef pThis);

	/// <summary>
	/// Specify the average number of points in each bucket.
	/// </summary>
	public virtual int GetNumberOfPointsPerBucket()
	{
		return vtkPointLocator_GetNumberOfPointsPerBucket_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointLocator_GetNumberOfPointsPerBucketMaxValue_18(HandleRef pThis);

	/// <summary>
	/// Specify the average number of points in each bucket.
	/// </summary>
	public virtual int GetNumberOfPointsPerBucketMaxValue()
	{
		return vtkPointLocator_GetNumberOfPointsPerBucketMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointLocator_GetNumberOfPointsPerBucketMinValue_19(HandleRef pThis);

	/// <summary>
	/// Specify the average number of points in each bucket.
	/// </summary>
	public virtual int GetNumberOfPointsPerBucketMinValue()
	{
		return vtkPointLocator_GetNumberOfPointsPerBucketMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointLocator_GetPoints_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Provide an accessor to the points.
	/// </summary>
	public virtual vtkPoints GetPoints()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointLocator_GetPoints_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointLocator_GetPointsInBucket_21(HandleRef pThis, IntPtr x, IntPtr ijk, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a position x, return the list of points in the bucket that
	/// contains the point. It is possible that nullptr is returned. The user
	/// provides an ijk array that is the indices into the locator.
	/// This method is thread safe.
	/// </summary>
	public virtual vtkIdList GetPointsInBucket(IntPtr x, IntPtr ijk)
	{
		vtkIdList vtkIdList2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointLocator_GetPointsInBucket_21(GetCppThis(), x, ijk, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointLocator_InitPointInsertion_22(HandleRef pThis, HandleRef newPts, IntPtr bounds);

	/// <summary>
	/// Initialize the point insertion process. The newPts is an object
	/// representing point coordinates into which incremental insertion methods
	/// place their data. Bounds are the box that the points lie in.
	/// Not thread safe.
	/// </summary>
	public override int InitPointInsertion(vtkPoints newPts, IntPtr bounds)
	{
		return vtkPointLocator_InitPointInsertion_22(GetCppThis(), newPts?.GetCppThis() ?? default(HandleRef), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointLocator_InitPointInsertion_23(HandleRef pThis, HandleRef newPts, IntPtr bounds, long estNumPts);

	/// <summary>
	/// Initialize the point insertion process. The newPts is an object
	/// representing point coordinates into which incremental insertion methods
	/// place their data. Bounds are the box that the points lie in.
	/// Not thread safe.
	/// </summary>
	public override int InitPointInsertion(vtkPoints newPts, IntPtr bounds, long estNumPts)
	{
		return vtkPointLocator_InitPointInsertion_23(GetCppThis(), newPts?.GetCppThis() ?? default(HandleRef), bounds, estNumPts);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLocator_Initialize_24(HandleRef pThis);

	/// <summary>
	/// See vtkLocator interface documentation.
	/// These methods are not thread safe.
	/// </summary>
	public override void Initialize()
	{
		vtkPointLocator_Initialize_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointLocator_InsertNextPoint_25(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Incrementally insert a point into search structure. The method returns
	/// the insertion location (i.e., point id). You should use the method
	/// IsInsertedPoint() to see whether this point has already been
	/// inserted (that is, if you desire to prevent duplicate points).
	/// Before using this method you must make sure that newPts have been
	/// supplied, the bounds has been set properly, and that divs are
	/// properly set. (See InitPointInsertion().)
	/// Not thread safe.
	/// </summary>
	public override long InsertNextPoint(IntPtr x)
	{
		return vtkPointLocator_InsertNextPoint_25(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLocator_InsertPoint_26(HandleRef pThis, long ptId, IntPtr x);

	/// <summary>
	/// Incrementally insert a point into search structure with a particular
	/// index value. You should use the method IsInsertedPoint() to see whether
	/// this point has already been inserted (that is, if you desire to prevent
	/// duplicate points). Before using this method you must make sure that
	/// newPts have been supplied, the bounds has been set properly, and that
	/// divs are properly set. (See InitPointInsertion().)
	/// Not thread safe.
	/// </summary>
	public override void InsertPoint(long ptId, IntPtr x)
	{
		vtkPointLocator_InsertPoint_26(GetCppThis(), ptId, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointLocator_InsertUniquePoint_27(HandleRef pThis, IntPtr x, ref long ptId);

	/// <summary>
	/// Determine whether point given by x[3] has been inserted into points list.
	/// Return 0 if point was already in the list, otherwise return 1. If the
	/// point was not in the list, it will be ADDED.  In either case, the id of
	/// the point (newly inserted or not) is returned in the ptId argument.
	/// Note this combines the functionality of IsInsertedPoint() followed
	/// by a call to InsertNextPoint().
	/// This method is not thread safe.
	/// </summary>
	public override int InsertUniquePoint(IntPtr x, ref long ptId)
	{
		return vtkPointLocator_InsertUniquePoint_27(GetCppThis(), x, ref ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointLocator_IsA_28(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type management and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointLocator_IsA_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointLocator_IsInsertedPoint_29(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Determine whether point given by x[3] has been inserted into points list.
	/// Return id of previously inserted point if this is true, otherwise return
	/// -1. This method is thread safe.
	/// </summary>
	public override long IsInsertedPoint(double x, double y, double z)
	{
		return vtkPointLocator_IsInsertedPoint_29(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointLocator_IsInsertedPoint_30(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Determine whether point given by x[3] has been inserted into points list.
	/// Return id of previously inserted point if this is true, otherwise return
	/// -1. This method is thread safe.
	/// </summary>
	public override long IsInsertedPoint(IntPtr x)
	{
		return vtkPointLocator_IsInsertedPoint_30(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointLocator_IsTypeOf_31(string type);

	/// <summary>
	/// Standard methods for type management and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointLocator_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointLocator_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type management and printing.
	/// </summary>
	public new vtkPointLocator NewInstance()
	{
		vtkPointLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointLocator_NewInstance_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointLocator_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type management and printing.
	/// </summary>
	public new static vtkPointLocator SafeDownCast(vtkObjectBase o)
	{
		vtkPointLocator vtkPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointLocator_SafeDownCast_34(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointLocator2 = (vtkPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointLocator2.Register(null);
			}
		}
		return vtkPointLocator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLocator_SetDivisions_35(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Set the number of divisions in x-y-z directions.
	/// </summary>
	public virtual void SetDivisions(int _arg1, int _arg2, int _arg3)
	{
		vtkPointLocator_SetDivisions_35(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLocator_SetDivisions_36(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the number of divisions in x-y-z directions.
	/// </summary>
	public virtual void SetDivisions(IntPtr _arg)
	{
		vtkPointLocator_SetDivisions_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLocator_SetNumberOfPointsPerBucket_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the average number of points in each bucket.
	/// </summary>
	public virtual void SetNumberOfPointsPerBucket(int _arg)
	{
		vtkPointLocator_SetNumberOfPointsPerBucket_37(GetCppThis(), _arg);
	}
}
