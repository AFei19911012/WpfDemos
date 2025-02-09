using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVoxel
/// </summary>
/// <remarks>
///    a cell that represents a 3D orthogonal parallelepiped
///
/// vtkVoxel is a concrete implementation of vtkCell to represent a 3D
/// orthogonal parallelepiped. Unlike vtkHexahedron, vtkVoxel has interior
/// angles of 90 degrees, and sides are parallel to coordinate axes. This
/// results in large increases in computational performance.
///
/// </remarks>
/// <seealso>
///
/// vtkConvexPointSet vtkHexahedron vtkPyramid vtkTetra vtkWedge
/// </seealso>
public class vtkVoxel : vtkCell3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVoxel";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVoxel()
	{
		MRClassNameKey = "class vtkVoxel";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVoxel"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVoxel(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVoxel New()
	{
		vtkVoxel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoxel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVoxel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkVoxel()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVoxel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkVoxel_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
	{
		return vtkVoxel_CellBoundary_01(GetCppThis(), subId, pcoords, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVoxel_ComputeBoundingSphere_02(HandleRef pThis, IntPtr center);

	/// <summary>
	/// Computes exact bounding sphere of this voxel.
	/// </summary>
	public override double ComputeBoundingSphere(IntPtr center)
	{
		return vtkVoxel_ComputeBoundingSphere_02(GetCppThis(), center);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVoxel_ComputeCentroid_03(HandleRef points, IntPtr pointIds, IntPtr centroid);

	/// <summary>
	/// Static method version of GetCentroid.
	/// </summary>
	public static bool ComputeCentroid(vtkPoints points, IntPtr pointIds, IntPtr centroid)
	{
		return (vtkVoxel_ComputeCentroid_03(points?.GetCppThis() ?? default(HandleRef), pointIds, centroid) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxel_Contour_04(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
	{
		vtkVoxel_Contour_04(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), verts?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxel_Derivatives_05(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
	{
		vtkVoxel_Derivatives_05(GetCppThis(), subId, pcoords, values, dim, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxel_EvaluateLocation_06(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
	{
		vtkVoxel_EvaluateLocation_06(GetCppThis(), ref subId, pcoords, x, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxel_EvaluatePosition_07(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
	{
		return vtkVoxel_EvaluatePosition_07(GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxel_GetCellDimension_08(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetCellDimension()
	{
		return vtkVoxel_GetCellDimension_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxel_GetCellType_09(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetCellType()
	{
		return vtkVoxel_GetCellType_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVoxel_GetCentroid_10(HandleRef pThis, IntPtr centroid);

	/// <summary>
	/// See vtkCell3D API for description of these methods.
	/// @warning Face points of vtkVoxel are not sorted properly.
	/// {pts[0], pts[1], pts[3], pts[2]} forms consecutive points of one face.
	/// </summary>
	public override bool GetCentroid(IntPtr centroid)
	{
		return (vtkVoxel_GetCentroid_10(GetCppThis(), centroid) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxel_GetEdge_11(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override vtkCell GetEdge(int edgeId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoxel_GetEdge_11(GetCppThis(), edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkVoxel_GetEdgeArray_12(long edgeId);

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
		return vtkVoxel_GetEdgeArray_12(edgeId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxel_GetEdgeToAdjacentFacesArray_13(long edgeId);

	/// <summary>
	/// Static method version of GetEdgeToAdjacentFaces.
	/// </summary>
	public static IntPtr GetEdgeToAdjacentFacesArray(long edgeId)
	{
		return vtkVoxel_GetEdgeToAdjacentFacesArray_13(edgeId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxel_GetFace_14(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override vtkCell GetFace(int faceId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoxel_GetFace_14(GetCppThis(), faceId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkVoxel_GetFaceArray_15(long faceId);

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
		return vtkVoxel_GetFaceArray_15(faceId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxel_GetFaceToAdjacentFacesArray_16(long faceId);

	/// <summary>
	/// Static method version of GetFaceToAdjacentFaces.
	/// </summary>
	public static IntPtr GetFaceToAdjacentFacesArray(long faceId)
	{
		return vtkVoxel_GetFaceToAdjacentFacesArray_16(faceId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxel_GetNumberOfEdges_17(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetNumberOfEdges()
	{
		return vtkVoxel_GetNumberOfEdges_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxel_GetNumberOfFaces_18(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetNumberOfFaces()
	{
		return vtkVoxel_GetNumberOfFaces_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVoxel_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVoxel_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVoxel_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVoxel_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxel_GetParametricCoords_21(HandleRef pThis);

	/// <summary>
	/// See vtkCell3D API for description of these methods.
	/// @warning Face points of vtkVoxel are not sorted properly.
	/// {pts[0], pts[1], pts[3], pts[2]} forms consecutive points of one face.
	/// </summary>
	public override IntPtr GetParametricCoords()
	{
		return vtkVoxel_GetParametricCoords_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxel_GetPointToIncidentEdgesArray_22(long pointId);

	/// <summary>
	/// Static method version of GetPointToIncidentEdgesArray.
	/// </summary>
	public static IntPtr GetPointToIncidentEdgesArray(long pointId)
	{
		return vtkVoxel_GetPointToIncidentEdgesArray_22(pointId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxel_GetPointToIncidentFacesArray_23(long pointId);

	/// <summary>
	/// Static method version of GetPointToIncidentFacesArray.
	/// </summary>
	public static IntPtr GetPointToIncidentFacesArray(long pointId)
	{
		return vtkVoxel_GetPointToIncidentFacesArray_23(pointId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxel_GetPointToOneRingPointsArray_24(long pointId);

	/// <summary>
	/// Static method version of GetPointToOneRingPoints.
	/// </summary>
	public static IntPtr GetPointToOneRingPointsArray(long pointId)
	{
		return vtkVoxel_GetPointToOneRingPointsArray_24(pointId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxel_GetTriangleCases_25(int caseId);

	/// <summary>
	/// Return the case table for table-based isocontouring (aka marching cubes
	/// style implementations). A linear 3D cell with N vertices will have 2**N
	/// cases. The returned case array lists three edges in order to produce one
	/// output triangle which may be repeated to generate multiple triangles. The
	/// list of cases terminates with a -1 entry.
	/// </summary>
	public static IntPtr GetTriangleCases(int caseId)
	{
		return vtkVoxel_GetTriangleCases_25(caseId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxel_Inflate_26(HandleRef pThis, double dist);

	/// <summary>
	/// Inflates voxel by moving every faces by dist. Since normals are not
	/// ambiguous for degenerate voxels, degenerate voxels are inflated correctly.
	/// For example, inflating a voxel collapsed to a single point will produce a
	/// voxel of width 2 * dist.
	///
	/// \return 1
	/// </summary>
	public override int Inflate(double dist)
	{
		return vtkVoxel_Inflate_26(GetCppThis(), dist);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxel_InterpolateDerivs_27(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// </summary>
	public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkVoxel_InterpolateDerivs_27(GetCppThis(), pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxel_InterpolateFunctions_28(HandleRef pThis, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// </summary>
	public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
	{
		vtkVoxel_InterpolateFunctions_28(GetCppThis(), pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxel_InterpolationDerivs_29(IntPtr pcoords, IntPtr derivs);

	/// <summary>
	/// Inflates voxel by moving every faces by dist. Since normals are not
	/// ambiguous for degenerate voxels, degenerate voxels are inflated correctly.
	/// For example, inflating a voxel collapsed to a single point will produce a
	/// voxel of width 2 * dist.
	///
	/// \return 1
	/// </summary>
	public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkVoxel_InterpolationDerivs_29(pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxel_InterpolationFunctions_30(IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Compute the interpolation functions.
	/// This static method is for convenience. Use the member function
	/// if you already have an instance of a voxel.
	/// </summary>
	public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
	{
		vtkVoxel_InterpolationFunctions_30(pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxel_IntersectWithLine_31(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
	{
		return vtkVoxel_IntersectWithLine_31(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxel_IsA_32(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVoxel_IsA_32(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVoxel_IsInsideOut_33(HandleRef pThis);

	/// <summary>
	/// See vtkCell3D API for description of these methods.
	/// @warning Face points of vtkVoxel are not sorted properly.
	/// {pts[0], pts[1], pts[3], pts[2]} forms consecutive points of one face.
	/// </summary>
	public override bool IsInsideOut()
	{
		return (vtkVoxel_IsInsideOut_33(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxel_IsTypeOf_34(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVoxel_IsTypeOf_34(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxel_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVoxel NewInstance()
	{
		vtkVoxel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoxel_NewInstance_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVoxel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxel_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVoxel SafeDownCast(vtkObjectBase o)
	{
		vtkVoxel vtkVoxel2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoxel_SafeDownCast_37(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVoxel2 = (vtkVoxel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVoxel2.Register(null);
			}
		}
		return vtkVoxel2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxel_Triangulate_38(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
	{
		return vtkVoxel_Triangulate_38(GetCppThis(), index, ptIds?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef));
	}
}
