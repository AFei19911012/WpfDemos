using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointsProjectedHull
/// </summary>
/// <remarks>
///    the convex hull of the orthogonal
///    projection of the vtkPoints in the 3 coordinate directions
///
///    a subclass of vtkPoints, it maintains the counter clockwise
///    convex hull of the points (projected orthogonally in the
///    three coordinate directions) and has a method to
///    test for intersection of that hull with an axis aligned
///    rectangle.  This is used for intersection tests of 3D volumes.
/// </remarks>
public class vtkPointsProjectedHull : vtkPoints
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointsProjectedHull";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointsProjectedHull()
	{
		MRClassNameKey = "class vtkPointsProjectedHull";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointsProjectedHull"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointsProjectedHull(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointsProjectedHull_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPointsProjectedHull New()
	{
		vtkPointsProjectedHull result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointsProjectedHull_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointsProjectedHull)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPointsProjectedHull()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointsProjectedHull_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPointsProjectedHull_GetCCWHullX_01(HandleRef pThis, IntPtr pts, int len);

	/// <summary>
	/// Returns the coordinates (y,z) of the points in the convex hull
	/// of the projection of the points down the positive x-axis.  pts has
	/// storage for len*2 values.
	/// </summary>
	public int GetCCWHullX(IntPtr pts, int len)
	{
		return vtkPointsProjectedHull_GetCCWHullX_01(GetCppThis(), pts, len);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointsProjectedHull_GetCCWHullY_02(HandleRef pThis, IntPtr pts, int len);

	/// <summary>
	/// Returns the coordinates (z, x) of the points in the convex hull
	/// of the projection of the points down the positive y-axis.  pts has
	/// storage for len*2 values.
	/// </summary>
	public int GetCCWHullY(IntPtr pts, int len)
	{
		return vtkPointsProjectedHull_GetCCWHullY_02(GetCppThis(), pts, len);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointsProjectedHull_GetCCWHullZ_03(HandleRef pThis, IntPtr pts, int len);

	/// <summary>
	/// Returns the coordinates (x, y) of the points in the convex hull
	/// of the projection of the points down the positive z-axis.  pts has
	/// storage for len*2 values.
	/// </summary>
	public int GetCCWHullZ(IntPtr pts, int len)
	{
		return vtkPointsProjectedHull_GetCCWHullZ_03(GetCppThis(), pts, len);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointsProjectedHull_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointsProjectedHull_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointsProjectedHull_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointsProjectedHull_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointsProjectedHull_GetSizeCCWHullX_06(HandleRef pThis);

	/// <summary>
	/// Returns the number of points in the convex hull of the projection
	/// of the points down the positive x-axis
	/// </summary>
	public int GetSizeCCWHullX()
	{
		return vtkPointsProjectedHull_GetSizeCCWHullX_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointsProjectedHull_GetSizeCCWHullY_07(HandleRef pThis);

	/// <summary>
	/// Returns the number of points in the convex hull of the projection
	/// of the points down the positive y-axis
	/// </summary>
	public int GetSizeCCWHullY()
	{
		return vtkPointsProjectedHull_GetSizeCCWHullY_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointsProjectedHull_GetSizeCCWHullZ_08(HandleRef pThis);

	/// <summary>
	/// Returns the number of points in the convex hull of the projection
	/// of the points down the positive z-axis
	/// </summary>
	public int GetSizeCCWHullZ()
	{
		return vtkPointsProjectedHull_GetSizeCCWHullZ_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointsProjectedHull_Initialize_09(HandleRef pThis);

	/// <summary>
	/// Returns the number of points in the convex hull of the projection
	/// of the points down the positive z-axis
	/// </summary>
	public override void Initialize()
	{
		vtkPointsProjectedHull_Initialize_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointsProjectedHull_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointsProjectedHull_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointsProjectedHull_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointsProjectedHull_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointsProjectedHull_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPointsProjectedHull NewInstance()
	{
		vtkPointsProjectedHull result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointsProjectedHull_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointsProjectedHull)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointsProjectedHull_RectangleIntersectionX_14(HandleRef pThis, HandleRef R);

	/// <summary>
	/// determine whether the resulting rectangle intersects the
	/// convex hull of the projection of the points along that axis.
	/// </summary>
	public int RectangleIntersectionX(vtkPoints R)
	{
		return vtkPointsProjectedHull_RectangleIntersectionX_14(GetCppThis(), R?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointsProjectedHull_RectangleIntersectionX_15(HandleRef pThis, float ymin, float ymax, float zmin, float zmax);

	/// <summary>
	/// the convex hull of the projection of the points along the
	/// positive X-axis.
	/// </summary>
	public int RectangleIntersectionX(float ymin, float ymax, float zmin, float zmax)
	{
		return vtkPointsProjectedHull_RectangleIntersectionX_15(GetCppThis(), ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointsProjectedHull_RectangleIntersectionX_16(HandleRef pThis, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// the convex hull of the projection of the points along the
	/// positive X-axis.
	/// </summary>
	public int RectangleIntersectionX(double ymin, double ymax, double zmin, double zmax)
	{
		return vtkPointsProjectedHull_RectangleIntersectionX_16(GetCppThis(), ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointsProjectedHull_RectangleIntersectionY_17(HandleRef pThis, HandleRef R);

	/// <summary>
	/// of the parallel projection along the Y axis of the points
	/// </summary>
	public int RectangleIntersectionY(vtkPoints R)
	{
		return vtkPointsProjectedHull_RectangleIntersectionY_17(GetCppThis(), R?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointsProjectedHull_RectangleIntersectionY_18(HandleRef pThis, float zmin, float zmax, float xmin, float xmax);

	/// <summary>
	/// the convex hull of the projection of the points along the
	/// positive Y-axis.
	/// </summary>
	public int RectangleIntersectionY(float zmin, float zmax, float xmin, float xmax)
	{
		return vtkPointsProjectedHull_RectangleIntersectionY_18(GetCppThis(), zmin, zmax, xmin, xmax);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointsProjectedHull_RectangleIntersectionY_19(HandleRef pThis, double zmin, double zmax, double xmin, double xmax);

	/// <summary>
	/// the convex hull of the projection of the points along the
	/// positive Y-axis.
	/// </summary>
	public int RectangleIntersectionY(double zmin, double zmax, double xmin, double xmax)
	{
		return vtkPointsProjectedHull_RectangleIntersectionY_19(GetCppThis(), zmin, zmax, xmin, xmax);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointsProjectedHull_RectangleIntersectionZ_20(HandleRef pThis, HandleRef R);

	/// <summary>
	/// of the parallel projection along the Z axis of the points
	/// </summary>
	public int RectangleIntersectionZ(vtkPoints R)
	{
		return vtkPointsProjectedHull_RectangleIntersectionZ_20(GetCppThis(), R?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointsProjectedHull_RectangleIntersectionZ_21(HandleRef pThis, float xmin, float xmax, float ymin, float ymax);

	/// <summary>
	/// the convex hull of the projection of the points along the
	/// positive Z-axis.
	/// </summary>
	public int RectangleIntersectionZ(float xmin, float xmax, float ymin, float ymax)
	{
		return vtkPointsProjectedHull_RectangleIntersectionZ_21(GetCppThis(), xmin, xmax, ymin, ymax);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointsProjectedHull_RectangleIntersectionZ_22(HandleRef pThis, double xmin, double xmax, double ymin, double ymax);

	/// <summary>
	/// the convex hull of the projection of the points along the
	/// positive Z-axis.
	/// </summary>
	public int RectangleIntersectionZ(double xmin, double xmax, double ymin, double ymax)
	{
		return vtkPointsProjectedHull_RectangleIntersectionZ_22(GetCppThis(), xmin, xmax, ymin, ymax);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointsProjectedHull_Reset_23(HandleRef pThis);

	/// <summary>
	/// Returns the number of points in the convex hull of the projection
	/// of the points down the positive z-axis
	/// </summary>
	public override void Reset()
	{
		vtkPointsProjectedHull_Reset_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointsProjectedHull_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPointsProjectedHull SafeDownCast(vtkObjectBase o)
	{
		vtkPointsProjectedHull vtkPointsProjectedHull2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointsProjectedHull_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointsProjectedHull2 = (vtkPointsProjectedHull)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointsProjectedHull2.Register(null);
			}
		}
		return vtkPointsProjectedHull2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointsProjectedHull_Update_25(HandleRef pThis);

	/// <summary>
	/// Forces recalculation of convex hulls, use this if
	/// you delete/add points
	/// </summary>
	public void Update()
	{
		vtkPointsProjectedHull_Update_25(GetCppThis());
	}
}
