using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkConvexPointSet
/// </summary>
/// <remarks>
///    a 3D cell defined by a set of convex points
///
/// vtkConvexPointSet is a concrete implementation that represents a 3D cell
/// defined by a convex set of points. An example of such a cell is an octant
/// (from an octree). vtkConvexPointSet uses the ordered triangulations
/// approach (vtkOrderedTriangulator) to create triangulations guaranteed to
/// be compatible across shared faces. This allows a general approach to
/// processing complex, convex cell types.
///
/// </remarks>
/// <seealso>
///
/// vtkHexahedron vtkPyramid vtkTetra vtkVoxel vtkWedge
/// </seealso>
public class vtkConvexPointSet : vtkCell3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkConvexPointSet";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkConvexPointSet()
	{
		MRClassNameKey = "class vtkConvexPointSet";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkConvexPointSet"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkConvexPointSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvexPointSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkConvexPointSet New()
	{
		vtkConvexPointSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvexPointSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConvexPointSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkConvexPointSet()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkConvexPointSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkConvexPointSet_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

	/// <summary>
	/// Returns the set of points forming a face of the triangulation of these
	/// points that are on the boundary of the cell that are closest
	/// parametrically to the point specified.
	/// </summary>
	public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
	{
		return vtkConvexPointSet_CellBoundary_01(GetCppThis(), subId, pcoords, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvexPointSet_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef connectivity, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

	/// <summary>
	/// Satisfy the vtkCell API. This method contours by triangulating the
	/// cell and then adding clip-edge intersection points into the
	/// triangulation; extracting the clipped region.
	/// </summary>
	public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray connectivity, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
	{
		vtkConvexPointSet_Clip_02(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), connectivity?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef), insideOut);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvexPointSet_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

	/// <summary>
	/// Satisfy the vtkCell API. This method contours by triangulating the
	/// cell and then contouring the resulting tetrahedra.
	/// </summary>
	public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
	{
		vtkConvexPointSet_Contour_03(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), verts?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvexPointSet_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

	/// <summary>
	/// Computes derivatives by triangulating and from subId and pcoords,
	/// evaluating derivatives on the resulting tetrahedron.
	/// </summary>
	public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
	{
		vtkConvexPointSet_Derivatives_04(GetCppThis(), subId, pcoords, values, dim, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvexPointSet_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

	/// <summary>
	/// The inverse of EvaluatePosition.
	/// </summary>
	public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
	{
		vtkConvexPointSet_EvaluateLocation_05(GetCppThis(), ref subId, pcoords, x, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvexPointSet_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

	/// <summary>
	/// Satisfy the vtkCell API. This method determines the subId, pcoords,
	/// and weights by triangulating the convex point set, and then
	/// determining which tetrahedron the point lies in.
	/// </summary>
	public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
	{
		return vtkConvexPointSet_EvaluatePosition_06(GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvexPointSet_GetCellType_07(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetCellType()
	{
		return vtkConvexPointSet_GetCellType_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkConvexPointSet_GetCentroid_08(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// See vtkCell3D API for description of these methods.
	/// @warning These method are unimplemented in vtkConvexPointSet
	/// </summary>
	public override bool GetCentroid(IntPtr arg0)
	{
		return (vtkConvexPointSet_GetCentroid_08(GetCppThis(), arg0) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvexPointSet_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// A convex point set has no explicit cell edge or faces; however
	/// implicitly (after triangulation) it does. Currently the method
	/// GetNumberOfEdges() always returns 0 while the GetNumberOfFaces() returns
	/// the number of boundary triangles of the triangulation of the convex
	/// point set. The method GetNumberOfFaces() triggers a triangulation of the
	/// convex point set; repeated calls to GetFace() then return the boundary
	/// faces. (Note: GetNumberOfEdges() currently returns 0 because it is a
	/// rarely used method and hard to implement. It can be changed in the future.
	/// </summary>
	public override vtkCell GetEdge(int arg0)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvexPointSet_GetEdge_09(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkConvexPointSet_GetFace_10(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// A convex point set has no explicit cell edge or faces; however
	/// implicitly (after triangulation) it does. Currently the method
	/// GetNumberOfEdges() always returns 0 while the GetNumberOfFaces() returns
	/// the number of boundary triangles of the triangulation of the convex
	/// point set. The method GetNumberOfFaces() triggers a triangulation of the
	/// convex point set; repeated calls to GetFace() then return the boundary
	/// faces. (Note: GetNumberOfEdges() currently returns 0 because it is a
	/// rarely used method and hard to implement. It can be changed in the future.
	/// </summary>
	public override vtkCell GetFace(int faceId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvexPointSet_GetFace_10(GetCppThis(), faceId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkConvexPointSet_GetNumberOfEdges_11(HandleRef pThis);

	/// <summary>
	/// A convex point set has no explicit cell edge or faces; however
	/// implicitly (after triangulation) it does. Currently the method
	/// GetNumberOfEdges() always returns 0 while the GetNumberOfFaces() returns
	/// the number of boundary triangles of the triangulation of the convex
	/// point set. The method GetNumberOfFaces() triggers a triangulation of the
	/// convex point set; repeated calls to GetFace() then return the boundary
	/// faces. (Note: GetNumberOfEdges() currently returns 0 because it is a
	/// rarely used method and hard to implement. It can be changed in the future.
	/// </summary>
	public override int GetNumberOfEdges()
	{
		return vtkConvexPointSet_GetNumberOfEdges_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvexPointSet_GetNumberOfFaces_12(HandleRef pThis);

	/// <summary>
	/// A convex point set has no explicit cell edge or faces; however
	/// implicitly (after triangulation) it does. Currently the method
	/// GetNumberOfEdges() always returns 0 while the GetNumberOfFaces() returns
	/// the number of boundary triangles of the triangulation of the convex
	/// point set. The method GetNumberOfFaces() triggers a triangulation of the
	/// convex point set; repeated calls to GetFace() then return the boundary
	/// faces. (Note: GetNumberOfEdges() currently returns 0 because it is a
	/// rarely used method and hard to implement. It can be changed in the future.
	/// </summary>
	public override int GetNumberOfFaces()
	{
		return vtkConvexPointSet_GetNumberOfFaces_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkConvexPointSet_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkConvexPointSet_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkConvexPointSet_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkConvexPointSet_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvexPointSet_GetParametricCenter_15(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	/// Return the center of the cell in parametric coordinates.
	/// </summary>
	public override int GetParametricCenter(IntPtr pcoords)
	{
		return vtkConvexPointSet_GetParametricCenter_15(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvexPointSet_GetParametricCoords_16(HandleRef pThis);

	/// <summary>
	/// See vtkCell3D API for description of this method.
	/// </summary>
	public override IntPtr GetParametricCoords()
	{
		return vtkConvexPointSet_GetParametricCoords_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvexPointSet_HasFixedTopology_17(HandleRef pThis);

	/// <summary>
	/// See vtkCell3D API for description of this method.
	/// </summary>
	public virtual int HasFixedTopology()
	{
		return vtkConvexPointSet_HasFixedTopology_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvexPointSet_Initialize_18(HandleRef pThis);

	/// <summary>
	/// This cell requires that it be initialized prior to access.
	/// </summary>
	public override void Initialize()
	{
		vtkConvexPointSet_Initialize_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvexPointSet_InterpolateDerivs_19(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// </summary>
	public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkConvexPointSet_InterpolateDerivs_19(GetCppThis(), pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConvexPointSet_InterpolateFunctions_20(HandleRef pThis, IntPtr pcoords, IntPtr sf);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// </summary>
	public override void InterpolateFunctions(IntPtr pcoords, IntPtr sf)
	{
		vtkConvexPointSet_InterpolateFunctions_20(GetCppThis(), pcoords, sf);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvexPointSet_IntersectWithLine_21(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

	/// <summary>
	/// Triangulates the cells and then intersects them to determine the
	/// intersection point.
	/// </summary>
	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
	{
		return vtkConvexPointSet_IntersectWithLine_21(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvexPointSet_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkConvexPointSet_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvexPointSet_IsPrimaryCell_23(HandleRef pThis);

	/// <summary>
	/// A convex point set is triangulated prior to any operations on it so
	/// it is not a primary cell, it is a composite cell.
	/// </summary>
	public override int IsPrimaryCell()
	{
		return vtkConvexPointSet_IsPrimaryCell_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvexPointSet_IsTypeOf_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkConvexPointSet_IsTypeOf_24(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvexPointSet_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkConvexPointSet NewInstance()
	{
		vtkConvexPointSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvexPointSet_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConvexPointSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvexPointSet_RequiresInitialization_27(HandleRef pThis);

	/// <summary>
	/// This cell requires that it be initialized prior to access.
	/// </summary>
	public override int RequiresInitialization()
	{
		return vtkConvexPointSet_RequiresInitialization_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConvexPointSet_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkConvexPointSet SafeDownCast(vtkObjectBase o)
	{
		vtkConvexPointSet vtkConvexPointSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConvexPointSet_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkConvexPointSet2 = (vtkConvexPointSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkConvexPointSet2.Register(null);
			}
		}
		return vtkConvexPointSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConvexPointSet_Triangulate_29(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

	/// <summary>
	/// Triangulate using methods of vtkOrderedTriangulator.
	/// </summary>
	public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
	{
		return vtkConvexPointSet_Triangulate_29(GetCppThis(), index, ptIds?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef));
	}
}
