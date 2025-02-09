using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolyhedron
/// </summary>
/// <remarks>
///    a 3D cell defined by a set of polygonal faces
///
/// vtkPolyhedron is a concrete implementation that represents a 3D cell
/// defined by a set of polygonal faces. The polyhedron should be watertight,
/// non-self-intersecting and manifold (each edge is used twice).
///
/// Interpolation functions and weights are defined / computed using the
/// method of Mean Value Coordinates (MVC). See the VTK class
/// vtkMeanValueCoordinatesInterpolator for more information.
///
/// The class does not require the polyhedron to be convex. However, the
/// polygonal faces must be planar. Non-planar polygonal faces will
/// definitely cause problems, especially in severely warped situations.
///
/// </remarks>
/// <seealso>
///
/// vtkCell3D vtkConvexPointSet vtkMeanValueCoordinatesInterpolator
/// </seealso>
public class vtkPolyhedron : vtkCell3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolyhedron";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolyhedron()
	{
		MRClassNameKey = "class vtkPolyhedron";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyhedron"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolyhedron(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyhedron_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard new methods.
	/// </summary>
	public new static vtkPolyhedron New()
	{
		vtkPolyhedron result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyhedron_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyhedron)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard new methods.
	/// </summary>
	public vtkPolyhedron()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPolyhedron_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPolyhedron_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

	/// <summary>
	/// Find the boundary face closest to the point defined by the pcoords[3]
	/// and subId of the cell (subId can be ignored).
	/// </summary>
	public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
	{
		return vtkPolyhedron_CellBoundary_01(GetCppThis(), subId, pcoords, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyhedron_Clip_02(HandleRef pThis, double value, HandleRef scalars, HandleRef locator, HandleRef connectivity, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

	/// <summary>
	/// Satisfy the vtkCell API. This method clips the input polyhedron and outputs
	/// a new polyhedron. The face information of the output polyhedron is encoded
	/// in the output vtkCellArray using a special format:
	/// CellLength [nCellFaces, nFace0Pts, i, j, k, nFace1Pts, i, j, k, ...].
	/// Use the static method vtkUnstructuredGrid::DecomposePolyhedronCellArray
	/// to convert it into a standard format. Note: the algorithm assumes water-tight
	/// polyhedron cells.
	/// </summary>
	public override void Clip(double value, vtkDataArray scalars, vtkIncrementalPointLocator locator, vtkCellArray connectivity, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
	{
		vtkPolyhedron_Clip_02(GetCppThis(), value, scalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), connectivity?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef), insideOut);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyhedron_Contour_03(HandleRef pThis, double value, HandleRef scalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

	/// <summary>
	/// Satisfy the vtkCell API. This method contours the input polyhedron and outputs
	/// a polygon. When the result polygon is not planar, it will be triangulated.
	/// The current implementation assumes water-tight polyhedron cells.
	/// </summary>
	public override void Contour(double value, vtkDataArray scalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
	{
		vtkPolyhedron_Contour_03(GetCppThis(), value, scalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), verts?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyhedron_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

	/// <summary>
	/// Computes derivatives at the point specified by the parameter coordinate.
	/// Current implementation uses all vertices and subId is not used.
	/// To accelerate the speed, the future implementation can triangulate and
	/// extract the local tetrahedron from subId and pcoords, then evaluate
	/// derivatives on the local tetrahedron.
	/// </summary>
	public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
	{
		vtkPolyhedron_Derivatives_04(GetCppThis(), subId, pcoords, values, dim, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyhedron_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

	/// <summary>
	/// The inverse of EvaluatePosition. Note the weights should be the MVC
	/// weights.
	/// </summary>
	public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
	{
		vtkPolyhedron_EvaluateLocation_05(GetCppThis(), ref subId, pcoords, x, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyhedron_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

	/// <summary>
	/// Satisfy the vtkCell API. The subId is ignored and zero is always
	/// returned. The parametric coordinates pcoords are normalized values in
	/// the bounding box of the polyhedron. The weights are determined by
	/// evaluating the MVC coordinates. The dist is always zero if the point x[3]
	/// is inside the polyhedron; otherwise it's the distance to the surface.
	/// </summary>
	public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
	{
		return vtkPolyhedron_EvaluatePosition_06(GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyhedron_GetCellType_07(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetCellType()
	{
		return vtkPolyhedron_GetCellType_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyhedron_GetCentroid_08(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// See vtkCell3D API for description of these methods.
	/// @warning These method are unimplemented in vtkPolyhedron
	/// </summary>
	public override bool GetCentroid(IntPtr arg0)
	{
		return (vtkPolyhedron_GetCentroid_08(GetCppThis(), arg0) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyhedron_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// A polyhedron is represented internally by a set of polygonal faces.
	/// These faces can be processed to explicitly determine edges.
	/// </summary>
	public override vtkCell GetEdge(int arg0)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyhedron_GetEdge_09(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPolyhedron_GetFace_10(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// A polyhedron is represented internally by a set of polygonal faces.
	/// These faces can be processed to explicitly determine edges.
	/// </summary>
	public override vtkCell GetFace(int faceId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyhedron_GetFace_10(GetCppThis(), faceId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPolyhedron_GetFaces_11(HandleRef pThis);

	/// <summary>
	/// Methods supporting the definition of faces. Note that the GetFaces()
	/// returns a list of faces in vtkCellArray form; use the method
	/// GetNumberOfFaces() to determine the number of faces in the list.
	/// The SetFaces() method is also in vtkCellArray form, except that it
	/// begins with a leading count indicating the total number of faces in
	/// the list.
	/// </summary>
	public override IntPtr GetFaces()
	{
		return vtkPolyhedron_GetFaces_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyhedron_GetNumberOfEdges_12(HandleRef pThis);

	/// <summary>
	/// A polyhedron is represented internally by a set of polygonal faces.
	/// These faces can be processed to explicitly determine edges.
	/// </summary>
	public override int GetNumberOfEdges()
	{
		return vtkPolyhedron_GetNumberOfEdges_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyhedron_GetNumberOfFaces_13(HandleRef pThis);

	/// <summary>
	/// A polyhedron is represented internally by a set of polygonal faces.
	/// These faces can be processed to explicitly determine edges.
	/// </summary>
	public override int GetNumberOfFaces()
	{
		return vtkPolyhedron_GetNumberOfFaces_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyhedron_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard new methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolyhedron_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyhedron_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	/// Standard new methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolyhedron_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyhedron_GetParametricCenter_16(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	/// Return the center of the cell in parametric coordinates. In this cell,
	/// the center of the bounding box is returned.
	/// </summary>
	public override int GetParametricCenter(IntPtr pcoords)
	{
		return vtkPolyhedron_GetParametricCenter_16(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyhedron_GetParametricCoords_17(HandleRef pThis);

	/// <summary>
	/// See vtkCell3D API for description of this method.
	/// </summary>
	public override IntPtr GetParametricCoords()
	{
		return vtkPolyhedron_GetParametricCoords_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyhedron_GetPolyData_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct polydata if no one exist, then return this-&gt;PolyData
	/// </summary>
	public vtkPolyData GetPolyData()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyhedron_GetPolyData_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyhedron_Initialize_19(HandleRef pThis);

	/// <summary>
	/// This cell requires that it be initialized prior to access.
	/// </summary>
	public override void Initialize()
	{
		vtkPolyhedron_Initialize_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyhedron_InterpolateDerivs_20(HandleRef pThis, IntPtr x, IntPtr derivs);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives). Here we use the MVC calculation
	/// process to compute the interpolation functions.
	/// </summary>
	public override void InterpolateDerivs(IntPtr x, IntPtr derivs)
	{
		vtkPolyhedron_InterpolateDerivs_20(GetCppThis(), x, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyhedron_InterpolateFunctions_21(HandleRef pThis, IntPtr x, IntPtr sf);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives). Here we use the MVC calculation
	/// process to compute the interpolation functions.
	/// </summary>
	public override void InterpolateFunctions(IntPtr x, IntPtr sf)
	{
		vtkPolyhedron_InterpolateFunctions_21(GetCppThis(), x, sf);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyhedron_IntersectWithLine_22(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

	/// <summary>
	/// Intersect the line (p1,p2) with a given tolerance tol to determine a
	/// point of intersection x[3] with parametric coordinate t along the
	/// line. The parametric coordinates are returned as well (subId can be
	/// ignored). Returns true if the line intersects a face.
	/// </summary>
	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
	{
		return vtkPolyhedron_IntersectWithLine_22(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyhedron_IsA_23(HandleRef pThis, string type);

	/// <summary>
	/// Standard new methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolyhedron_IsA_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPolyhedron_IsConvex_24(HandleRef pThis);

	/// <summary>
	/// Determine whether or not a polyhedron is convex. This method is adapted
	/// from Devillers et al., "Checking the Convexity of Polytopes and the
	/// Planarity of Subdivisions", Computational Geometry, Volume 11, Issues
	/// 3 - 4, December 1998, Pages 187 - 208.
	/// </summary>
	public bool IsConvex()
	{
		return (vtkPolyhedron_IsConvex_24(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyhedron_IsInside_25(HandleRef pThis, IntPtr x, double tolerance);

	/// <summary>
	/// A method particular to vtkPolyhedron. It determines whether a point x[3]
	/// is inside the polyhedron or not (returns 1 is the point is inside, 0
	/// otherwise). The tolerance is expressed in normalized space; i.e., a
	/// fraction of the size of the bounding box.
	/// </summary>
	public int IsInside(IntPtr x, double tolerance)
	{
		return vtkPolyhedron_IsInside_25(GetCppThis(), x, tolerance);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyhedron_IsPrimaryCell_26(HandleRef pThis);

	/// <summary>
	/// A polyhedron is a full-fledged primary cell.
	/// </summary>
	public override int IsPrimaryCell()
	{
		return vtkPolyhedron_IsPrimaryCell_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyhedron_IsTypeOf_27(string type);

	/// <summary>
	/// Standard new methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolyhedron_IsTypeOf_27(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyhedron_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard new methods.
	/// </summary>
	public new vtkPolyhedron NewInstance()
	{
		vtkPolyhedron result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyhedron_NewInstance_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyhedron)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyhedron_RequiresExplicitFaceRepresentation_30(HandleRef pThis);

	/// <summary>
	/// Methods supporting the definition of faces. Note that the GetFaces()
	/// returns a list of faces in vtkCellArray form; use the method
	/// GetNumberOfFaces() to determine the number of faces in the list.
	/// The SetFaces() method is also in vtkCellArray form, except that it
	/// begins with a leading count indicating the total number of faces in
	/// the list.
	/// </summary>
	public override int RequiresExplicitFaceRepresentation()
	{
		return vtkPolyhedron_RequiresExplicitFaceRepresentation_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyhedron_RequiresInitialization_31(HandleRef pThis);

	/// <summary>
	/// This cell requires that it be initialized prior to access.
	/// </summary>
	public override int RequiresInitialization()
	{
		return vtkPolyhedron_RequiresInitialization_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyhedron_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard new methods.
	/// </summary>
	public new static vtkPolyhedron SafeDownCast(vtkObjectBase o)
	{
		vtkPolyhedron vtkPolyhedron2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyhedron_SafeDownCast_32(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyhedron2 = (vtkPolyhedron)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyhedron2.Register(null);
			}
		}
		return vtkPolyhedron2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyhedron_SetFaces_33(HandleRef pThis, IntPtr faces);

	/// <summary>
	/// Methods supporting the definition of faces. Note that the GetFaces()
	/// returns a list of faces in vtkCellArray form; use the method
	/// GetNumberOfFaces() to determine the number of faces in the list.
	/// The SetFaces() method is also in vtkCellArray form, except that it
	/// begins with a leading count indicating the total number of faces in
	/// the list.
	/// </summary>
	public override void SetFaces(IntPtr faces)
	{
		vtkPolyhedron_SetFaces_33(GetCppThis(), faces);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyhedron_Triangulate_34(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

	/// <summary>
	/// Use vtkOrderedTriangulator to tetrahedralize the polyhedron mesh. This
	/// method works well for a convex polyhedron but may return wrong result
	/// in a concave case.
	/// Once triangulation has been performed, the results are saved in ptIds and
	/// pts. The ptIds is a vtkIdList with 4xn number of ids (n is the number of
	/// result tetrahedrons). The first 4 represent the point ids of the first
	/// tetrahedron, the second 4 represents the point ids of the second tetrahedron
	/// and so on. The point ids represent global dataset ids.
	/// The points of result tetrahedons are stored in pts. Note that there are
	/// 4xm output points (m is the number of points in the original polyhedron).
	/// A point may be stored multiple times when it is shared by more than one
	/// tetrahedrons. The points stored in pts are ordered the same as they are
	/// listed in ptIds.
	/// </summary>
	public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
	{
		return vtkPolyhedron_Triangulate_34(GetCppThis(), index, ptIds?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef));
	}
}
