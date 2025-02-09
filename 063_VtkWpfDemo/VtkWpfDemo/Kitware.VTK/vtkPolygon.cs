using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolygon
/// </summary>
/// <remarks>
///    a cell that represents an n-sided polygon
///
/// vtkPolygon is a concrete implementation of vtkCell to represent a 2D
/// n-sided polygon. The polygons cannot have any internal holes, and cannot
/// self-intersect. Define the polygon with n-points ordered in the counter-
/// clockwise direction; do not repeat the last point.
/// </remarks>
public class vtkPolygon : vtkCell
{
	/// <summary>
	/// Specify an internal tolerance for operations requiring polygon
	/// triangulation.  (For example, clipping and contouring operations proceed
	/// by first triangulating the polygon, and then clipping/contouring the
	/// resulting triangles.)  This is a normalized tolerance value multiplied
	/// by the diagonal length of the polygon bounding box. Is it used to
	/// determine whether potential triangulation edges intersect one another.
	/// </summary>
	public enum EarCutMeasureTypes
	{
		/// <summary>enum member</summary>
		BEST_QUALITY = 2,
		/// <summary>enum member</summary>
		DOT_PRODUCT = 1,
		/// <summary>enum member</summary>
		PERIMETER2_TO_AREA_RATIO = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolygon";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolygon()
	{
		MRClassNameKey = "class vtkPolygon";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolygon"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolygon(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolygon_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPolygon New()
	{
		vtkPolygon result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolygon_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolygon)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPolygon()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPolygon_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPolygon_BoundedTriangulate_01(HandleRef pThis, HandleRef outTris, double tol);

	/// <summary>
	/// Triangulate polygon and enforce that the ratio of the smallest triangle
	/// area to the polygon area is greater than a user-defined tolerance. The user
	/// must provide the vtkIdList outTris. On output, the outTris list contains
	/// the ids of the points defining the triangulation. The ids are ordered into
	/// groups of three: each three-group defines one triangle.
	/// </summary>
	public int BoundedTriangulate(vtkIdList outTris, double tol)
	{
		return vtkPolygon_BoundedTriangulate_01(GetCppThis(), outTris?.GetCppThis() ?? default(HandleRef), tol);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygon_CellBoundary_02(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
	{
		return vtkPolygon_CellBoundary_02(GetCppThis(), subId, pcoords, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygon_Clip_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef tris, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray tris, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
	{
		vtkPolygon_Clip_03(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), tris?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef), insideOut);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolygon_ComputeArea_04(HandleRef pThis);

	/// <summary>
	/// Compute the area of a polygon. This is a convenience function
	/// which simply calls static double ComputeArea(vtkPoints *p,
	/// vtkIdType numPts, vtkIdType *pts, double normal[3]);
	/// with the appropriate parameters from the instantiated vtkPolygon.
	/// </summary>
	public double ComputeArea()
	{
		return vtkPolygon_ComputeArea_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolygon_ComputeArea_05(HandleRef p, long numPts, IntPtr pts, IntPtr normal);

	/// <summary>
	/// Compute the area of a polygon in 3D. The area is returned, as well as
	/// the normal (a side effect of using this method). If you desire to
	/// compute the area of a triangle, use vtkTriangleArea which is faster.
	/// If pts==nullptr, point indexing is supposed to be {0, 1, ..., numPts-1}.
	/// If you already have a vtkPolygon instantiated, a convenience function,
	/// ComputeArea() is provided.
	/// </summary>
	public static double ComputeArea(vtkPoints p, long numPts, IntPtr pts, IntPtr normal)
	{
		return vtkPolygon_ComputeArea_05(p?.GetCppThis() ?? default(HandleRef), numPts, pts, normal);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolygon_ComputeCentroid_06(HandleRef p, int numPts, IntPtr pts, IntPtr centroid);

	/// <summary>
	/// Compute the centroid of a set of points. Returns false if the computation
	/// is invalid (this occurs when numPts=0 or when ids is empty).
	/// </summary>
	public static bool ComputeCentroid(vtkPoints p, int numPts, IntPtr pts, IntPtr centroid)
	{
		return (vtkPolygon_ComputeCentroid_06(p?.GetCppThis() ?? default(HandleRef), numPts, pts, centroid) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolygon_ComputeCentroid_07(HandleRef ids, HandleRef pts, IntPtr centroid);

	/// <summary>
	/// Compute the centroid of a set of points. Returns false if the computation
	/// is invalid (this occurs when numPts=0 or when ids is empty).
	/// </summary>
	public static bool ComputeCentroid(vtkIdTypeArray ids, vtkPoints pts, IntPtr centroid)
	{
		return (vtkPolygon_ComputeCentroid_07(ids?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef), centroid) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygon_ComputeNormal_08(HandleRef p, int numPts, IntPtr pts, IntPtr n);

	/// <summary>
	/// Computes the unit normal to the polygon. If pts=nullptr, point indexing is
	/// assumed to be {0, 1, ..., numPts-1}.
	/// </summary>
	public static void ComputeNormal(vtkPoints p, int numPts, IntPtr pts, IntPtr n)
	{
		vtkPolygon_ComputeNormal_08(p?.GetCppThis() ?? default(HandleRef), numPts, pts, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygon_ComputeNormal_09(HandleRef p, IntPtr n);

	/// <summary>
	/// Computes the unit normal to the polygon. If pts=nullptr, point indexing is
	/// assumed to be {0, 1, ..., numPts-1}.
	/// </summary>
	public static void ComputeNormal(vtkPoints p, IntPtr n)
	{
		vtkPolygon_ComputeNormal_09(p?.GetCppThis() ?? default(HandleRef), n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygon_ComputeNormal_10(HandleRef ids, HandleRef pts, IntPtr n);

	/// <summary>
	/// Computes the unit normal to the polygon. If pts=nullptr, point indexing is
	/// assumed to be {0, 1, ..., numPts-1}.
	/// </summary>
	public static void ComputeNormal(vtkIdTypeArray ids, vtkPoints pts, IntPtr n)
	{
		vtkPolygon_ComputeNormal_10(ids?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef), n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygon_ComputeNormal_11(int numPts, IntPtr pts, IntPtr n);

	/// <summary>
	/// Compute the polygon normal from an array of points. This version assumes
	/// that the polygon is convex, and looks for the first valid normal.
	/// </summary>
	public static void ComputeNormal(int numPts, IntPtr pts, IntPtr n)
	{
		vtkPolygon_ComputeNormal_11(numPts, pts, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygon_Contour_12(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
	{
		vtkPolygon_Contour_12(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), verts?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygon_Derivatives_13(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
	{
		vtkPolygon_Derivatives_13(GetCppThis(), subId, pcoords, values, dim, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolygon_DistanceToPolygon_14(IntPtr x, int numPts, IntPtr pts, IntPtr bounds, IntPtr closest);

	/// <summary>
	/// Compute the distance of a point to a polygon. The closest point on
	/// the polygon is also returned. The bounds should be provided to
	/// accelerate the computation.
	/// </summary>
	public static double DistanceToPolygon(IntPtr x, int numPts, IntPtr pts, IntPtr bounds, IntPtr closest)
	{
		return vtkPolygon_DistanceToPolygon_14(x, numPts, pts, bounds, closest);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygon_EarCutTriangulation_15(HandleRef pThis, int measure);

	/// <summary>
	/// A fast triangulation method. Uses recursive divide and
	/// conquer based on plane splitting to reduce loop into triangles.
	/// The cell (e.g., triangle) is presumed properly initialized (i.e.,
	/// Points and PointIds). Ears can be removed using different measures
	/// (the measures indicate convexity plus characterize the local
	/// geometry around each vertex).
	/// </summary>
	public int EarCutTriangulation(int measure)
	{
		return vtkPolygon_EarCutTriangulation_15(GetCppThis(), measure);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygon_EarCutTriangulation_16(HandleRef pThis, HandleRef outTris, int measure);

	/// <summary>
	/// A fast triangulation method. Uses recursive divide and
	/// conquer based on plane splitting to reduce loop into triangles.
	/// The cell (e.g., triangle) is presumed properly initialized (i.e.,
	/// Points and PointIds). Ears can be removed using different measures
	/// (the measures indicate convexity plus characterize the local
	/// geometry around each vertex).
	/// </summary>
	public int EarCutTriangulation(vtkIdList outTris, int measure)
	{
		return vtkPolygon_EarCutTriangulation_16(GetCppThis(), outTris?.GetCppThis() ?? default(HandleRef), measure);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygon_EvaluateLocation_17(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
	{
		vtkPolygon_EvaluateLocation_17(GetCppThis(), ref subId, pcoords, x, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygon_EvaluatePosition_18(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
	{
		return vtkPolygon_EvaluatePosition_18(GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygon_GetCellDimension_19(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetCellDimension()
	{
		return vtkPolygon_GetCellDimension_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygon_GetCellType_20(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetCellType()
	{
		return vtkPolygon_GetCellType_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolygon_GetEdge_21(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override vtkCell GetEdge(int edgeId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolygon_GetEdge_21(GetCppThis(), edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPolygon_GetFace_22(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override vtkCell GetFace(int arg0)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolygon_GetFace_22(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPolygon_GetNumberOfEdges_23(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetNumberOfEdges()
	{
		return vtkPolygon_GetNumberOfEdges_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygon_GetNumberOfFaces_24(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetNumberOfFaces()
	{
		return vtkPolygon_GetNumberOfFaces_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolygon_GetNumberOfGenerationsFromBase_25(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolygon_GetNumberOfGenerationsFromBase_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolygon_GetNumberOfGenerationsFromBaseType_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolygon_GetNumberOfGenerationsFromBaseType_26(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolygon_GetTolerance_27(HandleRef pThis);

	/// <summary>
	/// Specify an internal tolerance for operations requiring polygon
	/// triangulation.  (For example, clipping and contouring operations proceed
	/// by first triangulating the polygon, and then clipping/contouring the
	/// resulting triangles.)  This is a normalized tolerance value multiplied
	/// by the diagonal length of the polygon bounding box. Is it used to
	/// determine whether potential triangulation edges intersect one another.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkPolygon_GetTolerance_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolygon_GetToleranceMaxValue_28(HandleRef pThis);

	/// <summary>
	/// Specify an internal tolerance for operations requiring polygon
	/// triangulation.  (For example, clipping and contouring operations proceed
	/// by first triangulating the polygon, and then clipping/contouring the
	/// resulting triangles.)  This is a normalized tolerance value multiplied
	/// by the diagonal length of the polygon bounding box. Is it used to
	/// determine whether potential triangulation edges intersect one another.
	/// </summary>
	public virtual double GetToleranceMaxValue()
	{
		return vtkPolygon_GetToleranceMaxValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolygon_GetToleranceMinValue_29(HandleRef pThis);

	/// <summary>
	/// Specify an internal tolerance for operations requiring polygon
	/// triangulation.  (For example, clipping and contouring operations proceed
	/// by first triangulating the polygon, and then clipping/contouring the
	/// resulting triangles.)  This is a normalized tolerance value multiplied
	/// by the diagonal length of the polygon bounding box. Is it used to
	/// determine whether potential triangulation edges intersect one another.
	/// </summary>
	public virtual double GetToleranceMinValue()
	{
		return vtkPolygon_GetToleranceMinValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolygon_GetUseMVCInterpolation_30(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag indicating whether to use Mean Value Coordinate for the
	/// interpolation. If true, InterpolateFunctions() uses the Mean Value
	/// Coordinate to compute weights. Otherwise, the conventional 1/r^2 method
	/// is used. The UseMVCInterpolation parameter is set to false by default.
	/// </summary>
	public virtual bool GetUseMVCInterpolation()
	{
		return (vtkPolygon_GetUseMVCInterpolation_30(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygon_InterpolateFunctions_31(HandleRef pThis, IntPtr x, IntPtr sf);

	/// <summary>
	/// Compute the interpolation functions/derivatives.
	/// (aka shape functions/derivatives)
	/// Two interpolation algorithms are available: 1/r^2 and Mean Value
	/// Coordinate. The former is used by default. To use the second algorithm,
	/// set UseMVCInterpolation to be true.
	/// The function assumes the input point lies on the polygon plane without
	/// checking that.
	/// </summary>
	public override void InterpolateFunctions(IntPtr x, IntPtr sf)
	{
		vtkPolygon_InterpolateFunctions_31(GetCppThis(), x, sf);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygon_IntersectConvex2DCells_32(HandleRef cell1, HandleRef cell2, double tol, IntPtr p0, IntPtr p1);

	/// <summary>
	/// Intersect two convex 2D polygons to produce a line segment as output.
	/// The return status of the methods indicated no intersection (returns 0);
	/// a single point of intersection (returns 1); or a line segment (i.e., two
	/// points of intersection, returns 2). The points of intersection are
	/// returned in the arrays p0 and p1.  If less than two points of
	/// intersection are generated then p1 and/or p0 may be
	/// indeterminiate. Finally, if the two convex polygons are parallel, then
	/// "0" is returned (i.e., no intersection) even if the triangles lie on one
	/// another.
	/// </summary>
	public static int IntersectConvex2DCells(vtkCell cell1, vtkCell cell2, double tol, IntPtr p0, IntPtr p1)
	{
		return vtkPolygon_IntersectConvex2DCells_32(cell1?.GetCppThis() ?? default(HandleRef), cell2?.GetCppThis() ?? default(HandleRef), tol, p0, p1);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygon_IntersectPolygonWithPolygon_33(int npts, IntPtr pts, IntPtr bounds, int npts2, IntPtr pts2, IntPtr bounds2, double tol, IntPtr x);

	/// <summary>
	/// Method intersects two polygons. You must supply the number of points and
	/// point coordinates (npts, *pts) and the bounding box (bounds) of the two
	/// polygons. Also supply a tolerance squared for controlling
	/// error. The method returns 1 if there is an intersection, and 0 if
	/// not. A single point of intersection x[3] is also returned if there
	/// is an intersection.
	/// </summary>
	public static int IntersectPolygonWithPolygon(int npts, IntPtr pts, IntPtr bounds, int npts2, IntPtr pts2, IntPtr bounds2, double tol, IntPtr x)
	{
		return vtkPolygon_IntersectPolygonWithPolygon_33(npts, pts, bounds, npts2, pts2, bounds2, tol, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygon_IntersectWithLine_34(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
	{
		return vtkPolygon_IntersectWithLine_34(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygon_IsA_35(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolygon_IsA_35(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolygon_IsConvex_36(HandleRef pThis);

	/// <summary>
	/// Determine whether or not a polygon is convex. This is a convenience
	/// function that simply calls static bool IsConvex(int numPts,
	/// vtkIdType *pts, vtkPoints *p) with the appropriate parameters from the
	/// instantiated vtkPolygon.
	/// </summary>
	public bool IsConvex()
	{
		return (vtkPolygon_IsConvex_36(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolygon_IsConvex_37(HandleRef p, int numPts, IntPtr pts);

	/// <summary>
	/// Determine whether or not a polygon is convex. If pts=nullptr, point indexing
	/// is assumed to be {0, 1, ..., numPts-1}.
	/// </summary>
	public static bool IsConvex(vtkPoints p, int numPts, IntPtr pts)
	{
		return (vtkPolygon_IsConvex_37(p?.GetCppThis() ?? default(HandleRef), numPts, pts) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolygon_IsConvex_38(HandleRef ids, HandleRef p);

	/// <summary>
	/// Determine whether or not a polygon is convex. If pts=nullptr, point indexing
	/// is assumed to be {0, 1, ..., numPts-1}.
	/// </summary>
	public static bool IsConvex(vtkIdTypeArray ids, vtkPoints p)
	{
		return (vtkPolygon_IsConvex_38(ids?.GetCppThis() ?? default(HandleRef), p?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolygon_IsConvex_39(HandleRef p);

	/// <summary>
	/// Determine whether or not a polygon is convex. If pts=nullptr, point indexing
	/// is assumed to be {0, 1, ..., numPts-1}.
	/// </summary>
	public static bool IsConvex(vtkPoints p)
	{
		return (vtkPolygon_IsConvex_39(p?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygon_IsPrimaryCell_40(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int IsPrimaryCell()
	{
		return vtkPolygon_IsPrimaryCell_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygon_IsTypeOf_41(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolygon_IsTypeOf_41(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolygon_NewInstance_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPolygon NewInstance()
	{
		vtkPolygon result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolygon_NewInstance_43(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolygon)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygon_NonDegenerateTriangulate_44(HandleRef pThis, HandleRef outTris);

	/// <summary>
	/// Same as Triangulate(vtkIdList *outTris)
	/// but with a first pass to split the polygon into non-degenerate polygons.
	/// </summary>
	public int NonDegenerateTriangulate(vtkIdList outTris)
	{
		return vtkPolygon_NonDegenerateTriangulate_44(GetCppThis(), outTris?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygon_ParameterizePolygon_45(HandleRef pThis, IntPtr p0, IntPtr p10, ref double l10, IntPtr p20, ref double l20, IntPtr n);

	/// <summary>
	/// Create a local s-t coordinate system for a polygon. The point p0 is
	/// the origin of the local system, p10 is s-axis vector, and p20 is the
	/// t-axis vector. (These are expressed in the modeling coordinate system and
	/// are vectors of dimension [3].) The values l20 and l20 are the lengths of
	/// the vectors p10 and p20, and n is the polygon normal.
	/// </summary>
	public int ParameterizePolygon(IntPtr p0, IntPtr p10, ref double l10, IntPtr p20, ref double l20, IntPtr n)
	{
		return vtkPolygon_ParameterizePolygon_45(GetCppThis(), p0, p10, ref l10, p20, ref l20, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygon_PointInPolygon_46(IntPtr x, int numPts, IntPtr pts, IntPtr bounds, IntPtr n);

	/// <summary>
	/// Determine whether a point is inside the specified polygon. The function
	/// computes the winding number to assess inclusion. It works for arbitrary
	/// polygon shapes (e.g., non-convex) oriented arbitrarily in 3D
	/// space. Returns 0 if the point is not in the polygon; 1 if it is.  Can
	/// also return -1 to indicate a degenerate polygon. Parameters passed into
	/// the method include the point in question x[3]; the polygon defined by
	/// (npts,pts); the bounds of the polygon bounds[6]; and the normal n[3] to
	/// the polygon. (The implementation was inspired by Dan Sunday's book
	/// Practical Geometry Algorithms.) This method is thread safe.
	/// </summary>
	public static int PointInPolygon(IntPtr x, int numPts, IntPtr pts, IntPtr bounds, IntPtr n)
	{
		return vtkPolygon_PointInPolygon_46(x, numPts, pts, bounds, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolygon_SafeDownCast_47(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPolygon SafeDownCast(vtkObjectBase o)
	{
		vtkPolygon vtkPolygon2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolygon_SafeDownCast_47(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolygon2 = (vtkPolygon)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolygon2.Register(null);
			}
		}
		return vtkPolygon2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygon_SetTolerance_48(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify an internal tolerance for operations requiring polygon
	/// triangulation.  (For example, clipping and contouring operations proceed
	/// by first triangulating the polygon, and then clipping/contouring the
	/// resulting triangles.)  This is a normalized tolerance value multiplied
	/// by the diagonal length of the polygon bounding box. Is it used to
	/// determine whether potential triangulation edges intersect one another.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkPolygon_SetTolerance_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygon_SetUseMVCInterpolation_49(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the flag indicating whether to use Mean Value Coordinate for the
	/// interpolation. If true, InterpolateFunctions() uses the Mean Value
	/// Coordinate to compute weights. Otherwise, the conventional 1/r^2 method
	/// is used. The UseMVCInterpolation parameter is set to false by default.
	/// </summary>
	public virtual void SetUseMVCInterpolation(bool _arg)
	{
		vtkPolygon_SetUseMVCInterpolation_49(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygon_Triangulate_50(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
	{
		return vtkPolygon_Triangulate_50(GetCppThis(), index, ptIds?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygon_Triangulate_51(HandleRef pThis, HandleRef outTris);

	/// <summary>
	/// Triangulate this polygon. The user must provide the vtkIdList outTris.
	/// On output, the outTris list contains the ids of the points defining the
	/// triangulation (i.e., not the associated polygon-&gt;PointIds, rather the
	/// index into the polygon-&gt;Points array). The ids are ordered into groups
	/// of three: each three-group defines one triangle. The method returns
	/// non-zero if the triangulation is successful.
	/// </summary>
	public int Triangulate(vtkIdList outTris)
	{
		return vtkPolygon_Triangulate_51(GetCppThis(), outTris?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygon_UnbiasedEarCutTriangulation_52(HandleRef pThis, int seed, int measure);

	/// <summary>
	/// A fast triangulation method. Uses recursive divide and
	/// conquer based on plane splitting to reduce loop into triangles.
	/// The cell (e.g., triangle) is presumed properly initialized (i.e.,
	/// Points and PointIds). Unlike EarCutTriangulation(), vertices are visited
	/// sequentially without preference to angle.
	/// </summary>
	public int UnbiasedEarCutTriangulation(int seed, int measure)
	{
		return vtkPolygon_UnbiasedEarCutTriangulation_52(GetCppThis(), seed, measure);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygon_UnbiasedEarCutTriangulation_53(HandleRef pThis, int seed, HandleRef outTris, int measure);

	/// <summary>
	/// A fast triangulation method. Uses recursive divide and
	/// conquer based on plane splitting to reduce loop into triangles.
	/// The cell (e.g., triangle) is presumed properly initialized (i.e.,
	/// Points and PointIds). Unlike EarCutTriangulation(), vertices are visited
	/// sequentially without preference to angle.
	/// </summary>
	public int UnbiasedEarCutTriangulation(int seed, vtkIdList outTris, int measure)
	{
		return vtkPolygon_UnbiasedEarCutTriangulation_53(GetCppThis(), seed, outTris?.GetCppThis() ?? default(HandleRef), measure);
	}
}
