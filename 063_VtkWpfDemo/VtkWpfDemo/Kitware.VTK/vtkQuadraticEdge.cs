using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkQuadraticEdge
/// </summary>
/// <remarks>
///    cell represents a parabolic, isoparametric edge
///
/// vtkQuadraticEdge is a concrete implementation of vtkNonLinearCell to
/// represent a one-dimensional, 3-nodes, isoparametric parabolic line. The
/// interpolation is the standard finite element, quadratic isoparametric
/// shape function. The cell includes a mid-edge node. The ordering of the
/// three points defining the cell is point ids (0,1,2) where id #2 is the
/// midedge node.
///
/// </remarks>
/// <seealso>
///
/// vtkQuadraticTriangle vtkQuadraticTetra vtkQuadraticWedge
/// vtkQuadraticQuad vtkQuadraticHexahedron vtkQuadraticPyramid
/// </seealso>
public class vtkQuadraticEdge : vtkNonLinearCell
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkQuadraticEdge";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkQuadraticEdge()
	{
		MRClassNameKey = "class vtkQuadraticEdge";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadraticEdge"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkQuadraticEdge(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadraticEdge_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkQuadraticEdge New()
	{
		vtkQuadraticEdge result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadraticEdge_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkQuadraticEdge)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkQuadraticEdge()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkQuadraticEdge_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkQuadraticEdge_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
	{
		return vtkQuadraticEdge_CellBoundary_01(GetCppThis(), subId, pcoords, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticEdge_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef lines, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

	/// <summary>
	/// Clip this edge using scalar value provided. Like contouring, except
	/// that it cuts the edge to produce linear line segments.
	/// </summary>
	public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray lines, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
	{
		vtkQuadraticEdge_Clip_02(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef), insideOut);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticEdge_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
	{
		vtkQuadraticEdge_Contour_03(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), verts?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticEdge_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
	{
		vtkQuadraticEdge_Derivatives_04(GetCppThis(), subId, pcoords, values, dim, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticEdge_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
	{
		vtkQuadraticEdge_EvaluateLocation_05(GetCppThis(), ref subId, pcoords, x, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticEdge_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
	{
		return vtkQuadraticEdge_EvaluatePosition_06(GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticEdge_GetCellDimension_07(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int GetCellDimension()
	{
		return vtkQuadraticEdge_GetCellDimension_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticEdge_GetCellType_08(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int GetCellType()
	{
		return vtkQuadraticEdge_GetCellType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadraticEdge_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override vtkCell GetEdge(int arg0)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadraticEdge_GetEdge_09(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkQuadraticEdge_GetFace_10(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override vtkCell GetFace(int arg0)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadraticEdge_GetFace_10(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkQuadraticEdge_GetNumberOfEdges_11(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int GetNumberOfEdges()
	{
		return vtkQuadraticEdge_GetNumberOfEdges_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticEdge_GetNumberOfFaces_12(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int GetNumberOfFaces()
	{
		return vtkQuadraticEdge_GetNumberOfFaces_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkQuadraticEdge_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkQuadraticEdge_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkQuadraticEdge_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkQuadraticEdge_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticEdge_GetParametricCenter_15(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	/// Return the center of the quadratic tetra in parametric coordinates.
	/// </summary>
	public override int GetParametricCenter(IntPtr pcoords)
	{
		return vtkQuadraticEdge_GetParametricCenter_15(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadraticEdge_GetParametricCoords_16(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override IntPtr GetParametricCoords()
	{
		return vtkQuadraticEdge_GetParametricCoords_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticEdge_InterpolateDerivs_17(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// </summary>
	public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkQuadraticEdge_InterpolateDerivs_17(GetCppThis(), pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticEdge_InterpolateFunctions_18(HandleRef pThis, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// </summary>
	public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
	{
		vtkQuadraticEdge_InterpolateFunctions_18(GetCppThis(), pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticEdge_InterpolationDerivs_19(IntPtr pcoords, IntPtr derivs);

	/// <summary>
	/// Return the center of the quadratic tetra in parametric coordinates.
	/// </summary>
	public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkQuadraticEdge_InterpolationDerivs_19(pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticEdge_InterpolationFunctions_20(IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Return the center of the quadratic tetra in parametric coordinates.
	/// </summary>
	public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
	{
		vtkQuadraticEdge_InterpolationFunctions_20(pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticEdge_IntersectWithLine_21(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

	/// <summary>
	/// Line-edge intersection. Intersection has to occur within [0,1] parametric
	/// coordinates and with specified tolerance.
	/// </summary>
	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
	{
		return vtkQuadraticEdge_IntersectWithLine_21(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticEdge_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkQuadraticEdge_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticEdge_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkQuadraticEdge_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadraticEdge_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkQuadraticEdge NewInstance()
	{
		vtkQuadraticEdge result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadraticEdge_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkQuadraticEdge)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadraticEdge_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkQuadraticEdge SafeDownCast(vtkObjectBase o)
	{
		vtkQuadraticEdge vtkQuadraticEdge2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadraticEdge_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkQuadraticEdge2 = (vtkQuadraticEdge)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkQuadraticEdge2.Register(null);
			}
		}
		return vtkQuadraticEdge2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticEdge_Triangulate_27(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
	{
		return vtkQuadraticEdge_Triangulate_27(GetCppThis(), index, ptIds?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef));
	}
}
