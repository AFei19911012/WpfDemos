using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHigherOrderWedge
/// </summary>
/// <remarks>
///    A 3D cell that represents an arbitrary order HigherOrder wedge
///
/// vtkHigherOrderWedge is a concrete implementation of vtkCell to represent a
/// 3D wedge using HigherOrder shape functions of user specified order.
/// A wedge consists of two triangular and three quadrilateral faces.
/// The first six points of the wedge (0-5) are the "corner" points
/// where the first three points are the base of the wedge. This wedge
/// point ordering is opposite the vtkWedge ordering though in that
/// the base of the wedge defined by the first three points (0,1,2) form
/// a triangle whose normal points inward (toward the triangular face (3,4,5)).
/// While this is opposite the vtkWedge convention it is consistent with
/// every other cell type in VTK. The first 2 parametric coordinates of the
/// HigherOrder wedge or for the triangular base and vary between 0 and 1. The
/// third parametric coordinate is between the two triangular faces and goes
/// from 0 to 1 as well.
/// </remarks>
public abstract class vtkHigherOrderWedge : vtkNonLinearCell
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHigherOrderWedge";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHigherOrderWedge()
	{
		MRClassNameKey = "class vtkHigherOrderWedge";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHigherOrderWedge"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHigherOrderWedge(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern int vtkHigherOrderWedge_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
	{
		return vtkHigherOrderWedge_CellBoundary_01(GetCppThis(), subId, pcoords, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderWedge_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
	{
		vtkHigherOrderWedge_Clip_02(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef), insideOut);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderWedge_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
	{
		vtkHigherOrderWedge_Contour_03(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), verts?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderWedge_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
	{
		vtkHigherOrderWedge_Derivatives_04(GetCppThis(), subId, pcoords, values, dim, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderWedge_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
	{
		vtkHigherOrderWedge_EvaluateLocation_05(GetCppThis(), ref subId, pcoords, x, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderWedge_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
	{
		return vtkHigherOrderWedge_EvaluatePosition_06(GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderWedge_GetBoundaryQuad_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual vtkHigherOrderQuadrilateral GetBoundaryQuad()
	{
		vtkHigherOrderQuadrilateral vtkHigherOrderQuadrilateral2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderWedge_GetBoundaryQuad_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHigherOrderQuadrilateral2 = (vtkHigherOrderQuadrilateral)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHigherOrderQuadrilateral2.Register(null);
			}
		}
		return vtkHigherOrderQuadrilateral2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderWedge_GetBoundaryTri_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual vtkHigherOrderTriangle GetBoundaryTri()
	{
		vtkHigherOrderTriangle vtkHigherOrderTriangle2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderWedge_GetBoundaryTri_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHigherOrderTriangle2 = (vtkHigherOrderTriangle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHigherOrderTriangle2.Register(null);
			}
		}
		return vtkHigherOrderTriangle2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderWedge_GetCellDimension_09(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int GetCellDimension()
	{
		return vtkHigherOrderWedge_GetCellDimension_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderWedge_GetCellType_10(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int GetCellType()
	{
		return vtkHigherOrderWedge_GetCellType_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderWedge_GetEdge_11(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override vtkCell GetEdge(int edgeId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderWedge_GetEdge_11(GetCppThis(), edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkHigherOrderWedge_GetEdgeCell_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual vtkHigherOrderCurve GetEdgeCell()
	{
		vtkHigherOrderCurve vtkHigherOrderCurve2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderWedge_GetEdgeCell_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHigherOrderCurve2 = (vtkHigherOrderCurve)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHigherOrderCurve2.Register(null);
			}
		}
		return vtkHigherOrderCurve2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderWedge_GetFace_13(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override vtkCell GetFace(int faceId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderWedge_GetFace_13(GetCppThis(), faceId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkHigherOrderWedge_GetInterpolation_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual vtkHigherOrderInterpolation GetInterpolation()
	{
		vtkHigherOrderInterpolation vtkHigherOrderInterpolation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderWedge_GetInterpolation_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHigherOrderInterpolation2 = (vtkHigherOrderInterpolation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHigherOrderInterpolation2.Register(null);
			}
		}
		return vtkHigherOrderInterpolation2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderWedge_GetNumberOfApproximatingWedges_15(IntPtr order);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static int GetNumberOfApproximatingWedges(IntPtr order)
	{
		return vtkHigherOrderWedge_GetNumberOfApproximatingWedges_15(order);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderWedge_GetNumberOfApproximatingWedges_16(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetNumberOfApproximatingWedges()
	{
		return vtkHigherOrderWedge_GetNumberOfApproximatingWedges_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderWedge_GetNumberOfEdges_17(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int GetNumberOfEdges()
	{
		return vtkHigherOrderWedge_GetNumberOfEdges_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderWedge_GetNumberOfFaces_18(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int GetNumberOfFaces()
	{
		return vtkHigherOrderWedge_GetNumberOfFaces_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHigherOrderWedge_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHigherOrderWedge_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHigherOrderWedge_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHigherOrderWedge_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderWedge_GetOrder_21(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual IntPtr GetOrder()
	{
		return vtkHigherOrderWedge_GetOrder_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderWedge_GetOrder_22(HandleRef pThis, int i);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetOrder(int i)
	{
		return vtkHigherOrderWedge_GetOrder_22(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderWedge_GetParametricCenter_23(HandleRef pThis, IntPtr center);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int GetParametricCenter(IntPtr center)
	{
		return vtkHigherOrderWedge_GetParametricCenter_23(GetCppThis(), center);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderWedge_GetParametricCoords_24(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override IntPtr GetParametricCoords()
	{
		return vtkHigherOrderWedge_GetParametricCoords_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHigherOrderWedge_GetParametricDistance_25(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override double GetParametricDistance(IntPtr pcoords)
	{
		return vtkHigherOrderWedge_GetParametricDistance_25(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderWedge_Initialize_26(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Initialize()
	{
		vtkHigherOrderWedge_Initialize_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderWedge_InterpolateDerivs_27(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkHigherOrderWedge_InterpolateDerivs_27(GetCppThis(), pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderWedge_InterpolateFunctions_28(HandleRef pThis, IntPtr pcoords, IntPtr weights);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
	{
		vtkHigherOrderWedge_InterpolateFunctions_28(GetCppThis(), pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderWedge_IntersectWithLine_29(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
	{
		return vtkHigherOrderWedge_IntersectWithLine_29(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderWedge_IsA_30(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHigherOrderWedge_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderWedge_IsTypeOf_31(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHigherOrderWedge_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderWedge_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHigherOrderWedge NewInstance()
	{
		vtkHigherOrderWedge result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderWedge_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHigherOrderWedge)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderWedge_PointIndexFromIJK_33(int i, int j, int k, IntPtr order);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static int PointIndexFromIJK(int i, int j, int k, IntPtr order)
	{
		return vtkHigherOrderWedge_PointIndexFromIJK_33(i, j, k, order);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderWedge_PointIndexFromIJK_34(HandleRef pThis, int i, int j, int k);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int PointIndexFromIJK(int i, int j, int k)
	{
		return vtkHigherOrderWedge_PointIndexFromIJK_34(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderWedge_RequiresInitialization_35(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int RequiresInitialization()
	{
		return vtkHigherOrderWedge_RequiresInitialization_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderWedge_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHigherOrderWedge SafeDownCast(vtkObjectBase o)
	{
		vtkHigherOrderWedge vtkHigherOrderWedge2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderWedge_SafeDownCast_36(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHigherOrderWedge2 = (vtkHigherOrderWedge)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHigherOrderWedge2.Register(null);
			}
		}
		return vtkHigherOrderWedge2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderWedge_SetOrder_37(HandleRef pThis, int s, int t, int u, long numPts);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetOrder(int s, int t, int u, long numPts)
	{
		vtkHigherOrderWedge_SetOrder_37(GetCppThis(), s, t, u, numPts);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderWedge_SetOrderFromCellData_38(HandleRef pThis, HandleRef cell_data, long numPts, long cell_id);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetOrderFromCellData(vtkCellData cell_data, long numPts, long cell_id)
	{
		vtkHigherOrderWedge_SetOrderFromCellData_38(GetCppThis(), cell_data?.GetCppThis() ?? default(HandleRef), numPts, cell_id);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderWedge_SetParametricCoords_39(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetParametricCoords()
	{
		vtkHigherOrderWedge_SetParametricCoords_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderWedge_SetUniformOrderFromNumPoints_40(HandleRef pThis, long numPts);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetUniformOrderFromNumPoints(long numPts)
	{
		vtkHigherOrderWedge_SetUniformOrderFromNumPoints_40(GetCppThis(), numPts);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHigherOrderWedge_SubCellCoordinatesFromId_41(HandleRef pThis, vtkVector3i ijk, int subId);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public bool SubCellCoordinatesFromId(vtkVector3i ijk, int subId)
	{
		return (vtkHigherOrderWedge_SubCellCoordinatesFromId_41(GetCppThis(), ijk, subId) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHigherOrderWedge_SubCellCoordinatesFromId_42(HandleRef pThis, ref int i, ref int j, ref int k, int subId);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public bool SubCellCoordinatesFromId(ref int i, ref int j, ref int k, int subId)
	{
		return (vtkHigherOrderWedge_SubCellCoordinatesFromId_42(GetCppThis(), ref i, ref j, ref k, subId) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHigherOrderWedge_TransformApproxToCellParams_43(HandleRef pThis, int subCell, IntPtr pcoords);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public bool TransformApproxToCellParams(int subCell, IntPtr pcoords)
	{
		return (vtkHigherOrderWedge_TransformApproxToCellParams_43(GetCppThis(), subCell, pcoords) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHigherOrderWedge_TransformFaceToCellParams_44(HandleRef pThis, int bdyFace, IntPtr pcoords);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public bool TransformFaceToCellParams(int bdyFace, IntPtr pcoords)
	{
		return (vtkHigherOrderWedge_TransformFaceToCellParams_44(GetCppThis(), bdyFace, pcoords) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderWedge_Triangulate_45(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
	{
		return vtkHigherOrderWedge_Triangulate_45(GetCppThis(), index, ptIds?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef));
	}
}
