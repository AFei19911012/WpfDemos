using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAbstractPointLocator
/// </summary>
/// <remarks>
///    abstract class to quickly locate points in 3-space
///
/// vtkAbstractPointLocator is an abstract spatial search object to quickly locate points
/// in 3D. vtkAbstractPointLocator works by dividing a specified region of space into
/// "rectangular" buckets, and then keeping a list of points that
/// lie in each bucket. Typical operation involves giving a position in 3D
/// and finding the closest point.  The points are provided from the specified
/// dataset input.
///
/// </remarks>
/// <seealso>
///
/// vtkPointLocator vtkStaticPointLocator vtkMergePoints
/// </seealso>
public abstract class vtkAbstractPointLocator : vtkLocator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractPointLocator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAbstractPointLocator()
	{
		MRClassNameKey = "class vtkAbstractPointLocator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractPointLocator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAbstractPointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkAbstractPointLocator_FindClosestNPoints_01(HandleRef pThis, int N, IntPtr x, HandleRef result);

	/// <summary>
	/// Find the closest N points to a position. This returns the closest
	/// N points to a position. A faster method could be created that returned
	/// N close points to a position, but necessarily the exact N closest.
	/// The returned points are sorted from closest to farthest.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first.
	/// </summary>
	public virtual void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
	{
		vtkAbstractPointLocator_FindClosestNPoints_01(GetCppThis(), N, x, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPointLocator_FindClosestNPoints_02(HandleRef pThis, int N, double x, double y, double z, HandleRef result);

	/// <summary>
	/// Find the closest N points to a position. This returns the closest
	/// N points to a position. A faster method could be created that returned
	/// N close points to a position, but necessarily the exact N closest.
	/// The returned points are sorted from closest to farthest.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first.
	/// </summary>
	public void FindClosestNPoints(int N, double x, double y, double z, vtkIdList result)
	{
		vtkAbstractPointLocator_FindClosestNPoints_02(GetCppThis(), N, x, y, z, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractPointLocator_FindClosestPoint_03(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Given a position x, return the id of the point closest to it. Alternative
	/// method requires separate x-y-z values.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first.
	/// </summary>
	public virtual long FindClosestPoint(IntPtr x)
	{
		return vtkAbstractPointLocator_FindClosestPoint_03(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractPointLocator_FindClosestPoint_04(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Given a position x, return the id of the point closest to it. Alternative
	/// method requires separate x-y-z values.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first.
	/// </summary>
	public long FindClosestPoint(double x, double y, double z)
	{
		return vtkAbstractPointLocator_FindClosestPoint_04(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractPointLocator_FindClosestPointWithinRadius_05(HandleRef pThis, double radius, IntPtr x, ref double dist2);

	/// <summary>
	/// Given a position x and a radius r, return the id of the point
	/// closest to the point in that radius.
	/// dist2 returns the squared distance to the point.
	/// </summary>
	public virtual long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
	{
		return vtkAbstractPointLocator_FindClosestPointWithinRadius_05(GetCppThis(), radius, x, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPointLocator_FindPointsWithinRadius_06(HandleRef pThis, double R, IntPtr x, HandleRef result);

	/// <summary>
	/// Find all points within a specified radius R of position x.
	/// The result is not sorted in any specific manner.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first.
	/// </summary>
	public virtual void FindPointsWithinRadius(double R, IntPtr x, vtkIdList result)
	{
		vtkAbstractPointLocator_FindPointsWithinRadius_06(GetCppThis(), R, x, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPointLocator_FindPointsWithinRadius_07(HandleRef pThis, double R, double x, double y, double z, HandleRef result);

	/// <summary>
	/// Find all points within a specified radius R of position x.
	/// The result is not sorted in any specific manner.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first.
	/// </summary>
	public void FindPointsWithinRadius(double R, double x, double y, double z, vtkIdList result)
	{
		vtkAbstractPointLocator_FindPointsWithinRadius_07(GetCppThis(), R, x, y, z, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPointLocator_GetBounds_08(HandleRef pThis);

	/// <summary>
	/// Provide an accessor to the bounds. Valid after the locator is built.
	/// </summary>
	public virtual IntPtr GetBounds()
	{
		return vtkAbstractPointLocator_GetBounds_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPointLocator_GetBounds_09(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Provide an accessor to the bounds. Valid after the locator is built.
	/// </summary>
	public virtual void GetBounds(IntPtr arg0)
	{
		vtkAbstractPointLocator_GetBounds_09(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractPointLocator_GetNumberOfBuckets_10(HandleRef pThis);

	/// <summary>
	/// Return the total number of buckets in the locator. This has meaning only
	/// after the locator is constructed.
	/// </summary>
	public virtual long GetNumberOfBuckets()
	{
		return vtkAbstractPointLocator_GetNumberOfBuckets_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractPointLocator_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAbstractPointLocator_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractPointLocator_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAbstractPointLocator_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractPointLocator_IsA_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAbstractPointLocator_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractPointLocator_IsTypeOf_14(string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAbstractPointLocator_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPointLocator_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new vtkAbstractPointLocator NewInstance()
	{
		vtkAbstractPointLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPointLocator_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPointLocator_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new static vtkAbstractPointLocator SafeDownCast(vtkObjectBase o)
	{
		vtkAbstractPointLocator vtkAbstractPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPointLocator_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
}
