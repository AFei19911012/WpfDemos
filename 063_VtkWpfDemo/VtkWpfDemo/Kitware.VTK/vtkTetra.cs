using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTetra
/// </summary>
/// <remarks>
///    a 3D cell that represents a tetrahedron
///
/// vtkTetra is a concrete implementation of vtkCell to represent a 3D
/// tetrahedron. vtkTetra uses the standard isoparametric shape functions
/// for a linear tetrahedron. The tetrahedron is defined by the four points
/// (0-3); where (0,1,2) is the base of the tetrahedron which, using the
/// right hand rule, forms a triangle whose normal points in the direction
/// of the fourth point.
///
/// </remarks>
/// <seealso>
///
/// vtkConvexPointSet vtkHexahedron vtkPyramid vtkVoxel vtkWedge
/// </seealso>
public class vtkTetra : vtkCell3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTetra";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTetra()
	{
		MRClassNameKey = "class vtkTetra";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTetra"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTetra(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTetra_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTetra New()
	{
		vtkTetra result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTetra_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTetra)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTetra()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTetra_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkTetra_BarycentricCoords_01(IntPtr x, IntPtr x1, IntPtr x2, IntPtr x3, IntPtr x4, IntPtr bcoords);

	/// <summary>
	/// Given a 3D point x[3], determine the barycentric coordinates of the point.
	/// Barycentric coordinates are a natural coordinate system for simplices that
	/// express a position as a linear combination of the vertices. For a
	/// tetrahedron, there are four barycentric coordinates (because there are
	/// four vertices), and the sum of the coordinates must equal 1. If a
	/// point x is inside a simplex, then all four coordinates will be strictly
	/// positive.  If three coordinates are zero (so the fourth =1), then the
	/// point x is on a vertex. If two coordinates are zero, the point x is on an
	/// edge (and so on). In this method, you must specify the vertex coordinates
	/// x1-&gt;x4. Returns 0 if tetrahedron is degenerate.
	/// </summary>
	public static int BarycentricCoords(IntPtr x, IntPtr x1, IntPtr x2, IntPtr x3, IntPtr x4, IntPtr bcoords)
	{
		return vtkTetra_BarycentricCoords_01(x, x1, x2, x3, x4, bcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTetra_CellBoundary_02(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

	/// <summary>
	/// Returns the set of points that are on the boundary of the tetrahedron that
	/// are closest parametrically to the point specified. This may include faces,
	/// edges, or vertices.
	/// </summary>
	public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
	{
		return vtkTetra_CellBoundary_02(GetCppThis(), subId, pcoords, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTetra_Circumsphere_03(IntPtr x1, IntPtr x2, IntPtr x3, IntPtr x4, IntPtr center);

	/// <summary>
	/// Compute the circumcenter (center[3]) and radius squared (method
	/// return value) of a tetrahedron defined by the four points x1, x2,
	/// x3, and x4.
	/// </summary>
	public static double Circumsphere(IntPtr x1, IntPtr x2, IntPtr x3, IntPtr x4, IntPtr center)
	{
		return vtkTetra_Circumsphere_03(x1, x2, x3, x4, center);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTetra_Clip_04(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef connectivity, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray connectivity, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
	{
		vtkTetra_Clip_04(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), connectivity?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef), insideOut);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTetra_ComputeCentroid_05(HandleRef points, IntPtr pointIds, IntPtr centroid);

	/// <summary>
	/// Static method version of GetCentroid.
	/// </summary>
	public static bool ComputeCentroid(vtkPoints points, IntPtr pointIds, IntPtr centroid)
	{
		return (vtkTetra_ComputeCentroid_05(points?.GetCppThis() ?? default(HandleRef), pointIds, centroid) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTetra_ComputeVolume_06(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);

	/// <summary>
	/// Compute the volume of a tetrahedron defined by the four points
	/// p1, p2, p3, and p4.
	/// </summary>
	public static double ComputeVolume(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4)
	{
		return vtkTetra_ComputeVolume_06(p1, p2, p3, p4);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTetra_Contour_07(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
	{
		vtkTetra_Contour_07(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), verts?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTetra_Derivatives_08(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
	{
		vtkTetra_Derivatives_08(GetCppThis(), subId, pcoords, values, dim, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTetra_EvaluateLocation_09(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
	{
		vtkTetra_EvaluateLocation_09(GetCppThis(), ref subId, pcoords, x, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTetra_EvaluatePosition_10(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
	{
		return vtkTetra_EvaluatePosition_10(GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTetra_GetCellType_11(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetCellType()
	{
		return vtkTetra_GetCellType_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTetra_GetCentroid_12(HandleRef pThis, IntPtr centroid);

	/// <summary>
	/// See vtkCell3D API for description of these methods.
	/// </summary>
	public override bool GetCentroid(IntPtr centroid)
	{
		return (vtkTetra_GetCentroid_12(GetCppThis(), centroid) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTetra_GetEdge_13(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override vtkCell GetEdge(int edgeId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTetra_GetEdge_13(GetCppThis(), edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkTetra_GetEdgeArray_14(long edgeId);

	/// <summary>
	/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
	/// Ids are related to the cell, not to the dataset.
	///
	/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
	/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
	/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
	/// </summary>
	public static IntPtr GetEdgeArray(long edgeId)
	{
		return vtkTetra_GetEdgeArray_14(edgeId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTetra_GetEdgeToAdjacentFacesArray_15(long edgeId);

	/// <summary>
	/// Static method version of GetEdgeToAdjacentFaces.
	/// </summary>
	public static IntPtr GetEdgeToAdjacentFacesArray(long edgeId)
	{
		return vtkTetra_GetEdgeToAdjacentFacesArray_15(edgeId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTetra_GetFace_16(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override vtkCell GetFace(int faceId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTetra_GetFace_16(GetCppThis(), faceId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkTetra_GetFaceArray_17(long faceId);

	/// <summary>
	/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
	/// Ids are related to the cell, not to the dataset.
	///
	/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
	/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
	/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
	/// </summary>
	public static IntPtr GetFaceArray(long faceId)
	{
		return vtkTetra_GetFaceArray_17(faceId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTetra_GetFaceToAdjacentFacesArray_18(long faceId);

	/// <summary>
	/// Static method version of GetFaceToAdjacentFaces.
	/// </summary>
	public static IntPtr GetFaceToAdjacentFacesArray(long faceId)
	{
		return vtkTetra_GetFaceToAdjacentFacesArray_18(faceId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTetra_GetNumberOfEdges_19(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetNumberOfEdges()
	{
		return vtkTetra_GetNumberOfEdges_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTetra_GetNumberOfFaces_20(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetNumberOfFaces()
	{
		return vtkTetra_GetNumberOfFaces_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTetra_GetNumberOfGenerationsFromBase_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTetra_GetNumberOfGenerationsFromBase_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTetra_GetNumberOfGenerationsFromBaseType_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTetra_GetNumberOfGenerationsFromBaseType_22(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTetra_GetParametricCenter_23(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	/// Return the center of the tetrahedron in parametric coordinates.
	/// </summary>
	public override int GetParametricCenter(IntPtr pcoords)
	{
		return vtkTetra_GetParametricCenter_23(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTetra_GetParametricCoords_24(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override IntPtr GetParametricCoords()
	{
		return vtkTetra_GetParametricCoords_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTetra_GetParametricDistance_25(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	/// Return the distance of the parametric coordinate provided to the
	/// cell. If inside the cell, a distance of zero is returned.
	/// </summary>
	public override double GetParametricDistance(IntPtr pcoords)
	{
		return vtkTetra_GetParametricDistance_25(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTetra_GetPointToIncidentEdgesArray_26(long pointId);

	/// <summary>
	/// Static method version of GetPointToIncidentEdgesArray.
	/// </summary>
	public static IntPtr GetPointToIncidentEdgesArray(long pointId)
	{
		return vtkTetra_GetPointToIncidentEdgesArray_26(pointId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTetra_GetPointToIncidentFacesArray_27(long pointId);

	/// <summary>
	/// Static method version of GetPointToIncidentFacesArray.
	/// </summary>
	public static IntPtr GetPointToIncidentFacesArray(long pointId)
	{
		return vtkTetra_GetPointToIncidentFacesArray_27(pointId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTetra_GetPointToOneRingPointsArray_28(long pointId);

	/// <summary>
	/// Static method version of GetPointToOneRingPoints.
	/// </summary>
	public static IntPtr GetPointToOneRingPointsArray(long pointId)
	{
		return vtkTetra_GetPointToOneRingPointsArray_28(pointId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTetra_GetTriangleCases_29(int caseId);

	/// <summary>
	/// Return the case table for table-based isocontouring (aka marching cubes
	/// style implementations). A linear 3D cell with N vertices will have 2**N
	/// cases. The returned case array lists three edges in order to produce one
	/// output triangle which may be repeated to generate multiple triangles. The
	/// list of cases terminates with a -1 entry.
	/// </summary>
	public static IntPtr GetTriangleCases(int caseId)
	{
		return vtkTetra_GetTriangleCases_29(caseId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTetra_Insphere_30(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr center);

	/// <summary>
	/// Compute the center (center[3]) and radius (method return value) of
	/// a sphere that just fits inside the faces of a tetrahedron defined
	/// by the four points x1, x2, x3, and x4.
	/// </summary>
	public static double Insphere(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr center)
	{
		return vtkTetra_Insphere_30(p1, p2, p3, p4, center);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTetra_InterpolateDerivs_31(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// </summary>
	public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkTetra_InterpolateDerivs_31(GetCppThis(), pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTetra_InterpolateFunctions_32(HandleRef pThis, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// </summary>
	public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
	{
		vtkTetra_InterpolateFunctions_32(GetCppThis(), pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTetra_InterpolationDerivs_33(IntPtr pcoords, IntPtr derivs);

	/// <summary>
	/// Given parametric coordinates compute inverse Jacobian transformation
	/// matrix. Returns 9 elements of 3x3 inverse Jacobian plus interpolation
	/// function derivatives. Returns 0 if no inverse exists.
	/// </summary>
	public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkTetra_InterpolationDerivs_33(pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTetra_InterpolationFunctions_34(IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Given parametric coordinates compute inverse Jacobian transformation
	/// matrix. Returns 9 elements of 3x3 inverse Jacobian plus interpolation
	/// function derivatives. Returns 0 if no inverse exists.
	/// </summary>
	public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
	{
		vtkTetra_InterpolationFunctions_34(pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTetra_IntersectWithLine_35(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
	{
		return vtkTetra_IntersectWithLine_35(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTetra_IsA_36(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTetra_IsA_36(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTetra_IsInsideOut_37(HandleRef pThis);

	/// <summary>
	/// See vtkCell3D API for description of these methods.
	/// </summary>
	public override bool IsInsideOut()
	{
		return (vtkTetra_IsInsideOut_37(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTetra_IsTypeOf_38(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTetra_IsTypeOf_38(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTetra_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTetra NewInstance()
	{
		vtkTetra result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTetra_NewInstance_40(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTetra)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTetra_SafeDownCast_41(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTetra SafeDownCast(vtkObjectBase o)
	{
		vtkTetra vtkTetra2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTetra_SafeDownCast_41(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTetra2 = (vtkTetra)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTetra2.Register(null);
			}
		}
		return vtkTetra2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTetra_TetraCenter_42(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr center);

	/// <summary>
	/// Compute the center of the tetrahedron,
	/// </summary>
	public static void TetraCenter(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr center)
	{
		vtkTetra_TetraCenter_42(p1, p2, p3, p4, center);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTetra_Triangulate_43(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
	{
		return vtkTetra_Triangulate_43(GetCppThis(), index, ptIds?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef));
	}
}
