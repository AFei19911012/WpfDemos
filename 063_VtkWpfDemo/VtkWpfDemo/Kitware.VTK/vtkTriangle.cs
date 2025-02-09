using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTriangle
/// </summary>
/// <remarks>
///    a cell that represents a triangle
///
/// vtkTriangle is a concrete implementation of vtkCell to represent a triangle
/// located in 3-space.
/// </remarks>
public class vtkTriangle : vtkCell
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTriangle";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTriangle()
	{
		MRClassNameKey = "class vtkTriangle";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTriangle"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTriangle(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTriangle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTriangle New()
	{
		vtkTriangle result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTriangle_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTriangle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTriangle()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTriangle_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkTriangle_BarycentricCoords_01(IntPtr x, IntPtr x1, IntPtr x2, IntPtr x3, IntPtr bcoords);

	/// <summary>
	/// Given a 2D point x[2], determine the barycentric coordinates of the point.
	/// Barycentric coordinates are a natural coordinate system for simplices that
	/// express a position as a linear combination of the vertices. For a
	/// triangle, there are three barycentric coordinates (because there are
	/// three vertices), and the sum of the coordinates must equal 1. If a
	/// point x is inside a simplex, then all three coordinates will be strictly
	/// positive.  If two coordinates are zero (so the third =1), then the
	/// point x is on a vertex. If one coordinates are zero, the point x is on an
	/// edge. In this method, you must specify the vertex coordinates x1-&gt;x3.
	/// Returns 0 if triangle is degenerate.
	/// </summary>
	public static int BarycentricCoords(IntPtr x, IntPtr x1, IntPtr x2, IntPtr x3, IntPtr bcoords)
	{
		return vtkTriangle_BarycentricCoords_01(x, x1, x2, x3, bcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangle_CellBoundary_02(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
	{
		return vtkTriangle_CellBoundary_02(GetCppThis(), subId, pcoords, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTriangle_Circumcircle_03(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr center);

	/// <summary>
	/// Compute the circumcenter (center[3]) and radius squared (method
	/// return value) of a triangle defined by the three points x1, x2,
	/// and x3. (Note that the coordinates are 2D. 3D points can be used
	/// but the z-component will be ignored.)
	/// </summary>
	public static double Circumcircle(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr center)
	{
		return vtkTriangle_Circumcircle_03(p1, p2, p3, center);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangle_Clip_04(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

	/// <summary>
	/// Clip this triangle using scalar value provided. Like contouring, except
	/// that it cuts the triangle to produce other triangles.
	/// </summary>
	public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
	{
		vtkTriangle_Clip_04(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef), insideOut);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTriangle_ComputeArea_05(HandleRef pThis);

	/// <summary>
	/// A convenience function to compute the area of a vtkTriangle.
	/// </summary>
	public double ComputeArea()
	{
		return vtkTriangle_ComputeArea_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTriangle_ComputeCentroid_06(HandleRef points, IntPtr pointIds, IntPtr centroid);

	/// <summary>
	/// Get the centroid of the triangle.
	/// pointIds can be nullptr if ids are {0, 1, 2}
	/// </summary>
	public static bool ComputeCentroid(vtkPoints points, IntPtr pointIds, IntPtr centroid)
	{
		return (vtkTriangle_ComputeCentroid_06(points?.GetCppThis() ?? default(HandleRef), pointIds, centroid) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangle_ComputeNormal_07(HandleRef p, int numPts, IntPtr pts, IntPtr n);

	/// <summary>
	/// Compute the triangle normal from a points list, and a list of point ids
	/// that index into the points list.
	/// </summary>
	public static void ComputeNormal(vtkPoints p, int numPts, IntPtr pts, IntPtr n)
	{
		vtkTriangle_ComputeNormal_07(p?.GetCppThis() ?? default(HandleRef), numPts, pts, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangle_ComputeNormal_08(IntPtr v1, IntPtr v2, IntPtr v3, IntPtr n);

	/// <summary>
	/// Compute the triangle normal from three points.
	/// </summary>
	public static void ComputeNormal(IntPtr v1, IntPtr v2, IntPtr v3, IntPtr n)
	{
		vtkTriangle_ComputeNormal_08(v1, v2, v3, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangle_ComputeNormalDirection_09(IntPtr v1, IntPtr v2, IntPtr v3, IntPtr n);

	/// <summary>
	/// Compute the (unnormalized) triangle normal direction from three points.
	/// </summary>
	public static void ComputeNormalDirection(IntPtr v1, IntPtr v2, IntPtr v3, IntPtr n)
	{
		vtkTriangle_ComputeNormalDirection_09(v1, v2, v3, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangle_ComputeQuadric_10(IntPtr x1, IntPtr x2, IntPtr x3, HandleRef quadric);

	/// <summary>
	/// Calculate the error quadric for this triangle.  Return the
	/// quadric as a 4x4 matrix or a vtkQuadric.  (from Peter
	/// Lindstrom's Siggraph 2000 paper, "Out-of-Core Simplification of
	/// Large Polygonal Models")
	/// </summary>
	public static void ComputeQuadric(IntPtr x1, IntPtr x2, IntPtr x3, vtkQuadric quadric)
	{
		vtkTriangle_ComputeQuadric_10(x1, x2, x3, quadric?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangle_Contour_11(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
	{
		vtkTriangle_Contour_11(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), verts?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangle_Derivatives_12(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
	{
		vtkTriangle_Derivatives_12(GetCppThis(), subId, pcoords, values, dim, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangle_EvaluateLocation_13(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
	{
		vtkTriangle_EvaluateLocation_13(GetCppThis(), ref subId, pcoords, x, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangle_EvaluatePosition_14(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
	{
		return vtkTriangle_EvaluatePosition_14(GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangle_GetCellDimension_15(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetCellDimension()
	{
		return vtkTriangle_GetCellDimension_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangle_GetCellType_16(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetCellType()
	{
		return vtkTriangle_GetCellType_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTriangle_GetEdge_17(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the edge specified by edgeId (range 0 to 2) and return that edge's
	/// coordinates.
	/// </summary>
	public override vtkCell GetEdge(int edgeId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTriangle_GetEdge_17(GetCppThis(), edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCell2 = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCell2.Register(null);
			}
		}
		return vtkCell2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTriangle_GetEdgeArray_18(HandleRef pThis, long edgeId);

	/// <summary>
	/// Return the ids of the vertices defining edge (`edgeId`).
	/// Ids are related to the cell, not to the dataset.
	///
	/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
	/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
	/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
	/// </summary>
	public IntPtr GetEdgeArray(long edgeId)
	{
		return vtkTriangle_GetEdgeArray_18(GetCppThis(), edgeId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTriangle_GetFace_19(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override vtkCell GetFace(int arg0)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTriangle_GetFace_19(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCell2 = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCell2.Register(null);
			}
		}
		return vtkCell2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangle_GetNumberOfEdges_20(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetNumberOfEdges()
	{
		return vtkTriangle_GetNumberOfEdges_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangle_GetNumberOfFaces_21(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetNumberOfFaces()
	{
		return vtkTriangle_GetNumberOfFaces_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTriangle_GetNumberOfGenerationsFromBase_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTriangle_GetNumberOfGenerationsFromBase_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTriangle_GetNumberOfGenerationsFromBaseType_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTriangle_GetNumberOfGenerationsFromBaseType_23(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangle_GetParametricCenter_24(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	/// Return the center of the triangle in parametric coordinates.
	/// </summary>
	public override int GetParametricCenter(IntPtr pcoords)
	{
		return vtkTriangle_GetParametricCenter_24(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTriangle_GetParametricCoords_25(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override IntPtr GetParametricCoords()
	{
		return vtkTriangle_GetParametricCoords_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTriangle_GetParametricDistance_26(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	/// Return the distance of the parametric coordinate provided to the
	/// cell. If inside the cell, a distance of zero is returned.
	/// </summary>
	public override double GetParametricDistance(IntPtr pcoords)
	{
		return vtkTriangle_GetParametricDistance_26(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangle_InterpolateDerivs_27(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// </summary>
	public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkTriangle_InterpolateDerivs_27(GetCppThis(), pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangle_InterpolateFunctions_28(HandleRef pThis, IntPtr pcoords, IntPtr sf);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// </summary>
	public override void InterpolateFunctions(IntPtr pcoords, IntPtr sf)
	{
		vtkTriangle_InterpolateFunctions_28(GetCppThis(), pcoords, sf);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangle_InterpolationDerivs_29(IntPtr pcoords, IntPtr derivs);

	/// <summary>
	/// Clip this triangle using scalar value provided. Like contouring, except
	/// that it cuts the triangle to produce other triangles.
	/// </summary>
	public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkTriangle_InterpolationDerivs_29(pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangle_InterpolationFunctions_30(IntPtr pcoords, IntPtr sf);

	/// <summary>
	/// Clip this triangle using scalar value provided. Like contouring, except
	/// that it cuts the triangle to produce other triangles.
	/// </summary>
	public static void InterpolationFunctions(IntPtr pcoords, IntPtr sf)
	{
		vtkTriangle_InterpolationFunctions_30(pcoords, sf);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangle_IntersectWithLine_31(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

	/// <summary>
	/// Given a line defined by two points p1 and p2, determine whether it intersects the triangle.
	/// The tolerance tol is used to verify whether the intersection is inside or outside of the
	/// triangle. If the line and triangle are coplanar and there is intersection, the intersecting
	/// point is chosen as the point closest to p1 that is inside the triangle.
	/// </summary>
	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
	{
		return vtkTriangle_IntersectWithLine_31(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangle_IsA_32(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTriangle_IsA_32(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangle_IsTypeOf_33(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTriangle_IsTypeOf_33(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTriangle_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTriangle NewInstance()
	{
		vtkTriangle result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTriangle_NewInstance_35(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTriangle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangle_PointInTriangle_36(IntPtr x, IntPtr x1, IntPtr x2, IntPtr x3, double tol2);

	/// <summary>
	/// Compute the (unnormalized) triangle normal direction from three points.
	/// </summary>
	public static int PointInTriangle(IntPtr x, IntPtr x1, IntPtr x2, IntPtr x3, double tol2)
	{
		return vtkTriangle_PointInTriangle_36(x, x1, x2, x3, tol2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangle_ProjectTo2D_37(IntPtr x1, IntPtr x2, IntPtr x3, IntPtr v1, IntPtr v2, IntPtr v3);

	/// <summary>
	/// Project triangle defined in 3D to 2D coordinates. Returns 0 if
	/// degenerate triangle; non-zero value otherwise. Input points are x1-&gt;x3;
	/// output 2D points are v1-&gt;v3.
	/// </summary>
	public static int ProjectTo2D(IntPtr x1, IntPtr x2, IntPtr x3, IntPtr v1, IntPtr v2, IntPtr v3)
	{
		return vtkTriangle_ProjectTo2D_37(x1, x2, x3, v1, v2, v3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTriangle_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTriangle SafeDownCast(vtkObjectBase o)
	{
		vtkTriangle vtkTriangle2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTriangle_SafeDownCast_38(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTriangle2 = (vtkTriangle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTriangle2.Register(null);
			}
		}
		return vtkTriangle2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTriangle_TriangleArea_39(IntPtr p1, IntPtr p2, IntPtr p3);

	/// <summary>
	/// Compute the area of a triangle in 3D.
	/// See also vtkTriangle::ComputeArea()
	/// </summary>
	public static double TriangleArea(IntPtr p1, IntPtr p2, IntPtr p3)
	{
		return vtkTriangle_TriangleArea_39(p1, p2, p3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTriangle_TriangleCenter_40(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr center);

	/// <summary>
	/// Compute the center of the triangle.
	/// </summary>
	public static void TriangleCenter(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr center)
	{
		vtkTriangle_TriangleCenter_40(p1, p2, p3, center);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangle_TrianglesIntersect_41(IntPtr p1, IntPtr q1, IntPtr r1, IntPtr p2, IntPtr q2, IntPtr r2);

	/// <summary>
	/// Compute the (unnormalized) triangle normal direction from three points.
	/// </summary>
	public static int TrianglesIntersect(IntPtr p1, IntPtr q1, IntPtr r1, IntPtr p2, IntPtr q2, IntPtr r2)
	{
		return vtkTriangle_TrianglesIntersect_41(p1, q1, r1, p2, q2, r2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangle_Triangulate_42(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
	{
		return vtkTriangle_Triangulate_42(GetCppThis(), index, ptIds?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef));
	}
}
