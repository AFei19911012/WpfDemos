using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBiQuadraticQuadraticWedge
/// </summary>
/// <remarks>
///    cell represents a parabolic, 18-node isoparametric wedge
///
/// vtkBiQuadraticQuadraticWedge is a concrete implementation of vtkNonLinearCell to
/// represent a three-dimensional, 18-node isoparametric biquadratic
/// wedge. The interpolation is the standard finite element,
/// biquadratic-quadratic isoparametric shape function plus the linear functions.
/// The cell includes a mid-edge node. The
/// ordering of the 18 points defining the cell is point ids (0-5,6-15, 16-18)
/// where point ids 0-5 are the six corner vertices of the wedge; followed by
/// nine midedge nodes (6-15) and 3 center-face nodes. Note that these midedge
/// nodes correspond lie
/// on the edges defined by (0,1), (1,2), (2,0), (3,4), (4,5), (5,3), (0,3),
/// (1,4), (2,5), and the center-face nodes are laying in quads 16-(0,1,4,3),
/// 17-(1,2,5,4) and (2,0,3,5).
///
/// </remarks>
/// <seealso>
///
/// vtkQuadraticEdge vtkQuadraticTriangle vtkQuadraticTetra
/// vtkQuadraticHexahedron vtkQuadraticQuad vtkQuadraticPyramid
///
/// @par Thanks:
/// Thanks to Soeren Gebbert who developed this class and
/// integrated it into VTK 5.0.
/// </seealso>
public class vtkBiQuadraticQuadraticWedge : vtkNonLinearCell
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBiQuadraticQuadraticWedge";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBiQuadraticQuadraticWedge()
	{
		MRClassNameKey = "class vtkBiQuadraticQuadraticWedge";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBiQuadraticQuadraticWedge"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBiQuadraticQuadraticWedge(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiQuadraticQuadraticWedge_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBiQuadraticQuadraticWedge New()
	{
		vtkBiQuadraticQuadraticWedge result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiQuadraticQuadraticWedge_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBiQuadraticQuadraticWedge)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkBiQuadraticQuadraticWedge()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBiQuadraticQuadraticWedge_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkBiQuadraticQuadraticWedge_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
	{
		return vtkBiQuadraticQuadraticWedge_CellBoundary_01(GetCppThis(), subId, pcoords, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiQuadraticQuadraticWedge_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef tetras, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

	/// <summary>
	/// Clip this quadratic Wedge using scalar value provided. Like
	/// contouring, except that it cuts the hex to produce linear
	/// tetrahedron.
	/// </summary>
	public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray tetras, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
	{
		vtkBiQuadraticQuadraticWedge_Clip_02(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), tetras?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef), insideOut);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiQuadraticQuadraticWedge_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
	{
		vtkBiQuadraticQuadraticWedge_Contour_03(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), verts?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiQuadraticQuadraticWedge_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
	{
		vtkBiQuadraticQuadraticWedge_Derivatives_04(GetCppThis(), subId, pcoords, values, dim, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiQuadraticQuadraticWedge_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
	{
		vtkBiQuadraticQuadraticWedge_EvaluateLocation_05(GetCppThis(), ref subId, pcoords, x, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiQuadraticQuadraticWedge_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
	{
		return vtkBiQuadraticQuadraticWedge_EvaluatePosition_06(GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiQuadraticQuadraticWedge_GetCellDimension_07(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int GetCellDimension()
	{
		return vtkBiQuadraticQuadraticWedge_GetCellDimension_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiQuadraticQuadraticWedge_GetCellType_08(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int GetCellType()
	{
		return vtkBiQuadraticQuadraticWedge_GetCellType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiQuadraticQuadraticWedge_GetEdge_09(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override vtkCell GetEdge(int edgeId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiQuadraticQuadraticWedge_GetEdge_09(GetCppThis(), edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkBiQuadraticQuadraticWedge_GetEdgeArray_10(long edgeId);

	/// <summary>
	/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
	/// Ids are related to the cell, not to the dataset.
	///
	/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
	/// This is so ids are unified between vtkCell and vtkPoints.
	/// </summary>
	public static IntPtr GetEdgeArray(long edgeId)
	{
		return vtkBiQuadraticQuadraticWedge_GetEdgeArray_10(edgeId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiQuadraticQuadraticWedge_GetFace_11(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override vtkCell GetFace(int faceId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiQuadraticQuadraticWedge_GetFace_11(GetCppThis(), faceId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkBiQuadraticQuadraticWedge_GetFaceArray_12(long faceId);

	/// <summary>
	/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
	/// Ids are related to the cell, not to the dataset.
	///
	/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
	/// This is so ids are unified between vtkCell and vtkPoints.
	/// </summary>
	public static IntPtr GetFaceArray(long faceId)
	{
		return vtkBiQuadraticQuadraticWedge_GetFaceArray_12(faceId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiQuadraticQuadraticWedge_GetNumberOfEdges_13(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int GetNumberOfEdges()
	{
		return vtkBiQuadraticQuadraticWedge_GetNumberOfEdges_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiQuadraticQuadraticWedge_GetNumberOfFaces_14(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int GetNumberOfFaces()
	{
		return vtkBiQuadraticQuadraticWedge_GetNumberOfFaces_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBiQuadraticQuadraticWedge_GetNumberOfGenerationsFromBase_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBiQuadraticQuadraticWedge_GetNumberOfGenerationsFromBase_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBiQuadraticQuadraticWedge_GetNumberOfGenerationsFromBaseType_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBiQuadraticQuadraticWedge_GetNumberOfGenerationsFromBaseType_16(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiQuadraticQuadraticWedge_GetParametricCenter_17(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	/// Return the center of the quadratic wedge in parametric coordinates.
	/// </summary>
	public override int GetParametricCenter(IntPtr pcoords)
	{
		return vtkBiQuadraticQuadraticWedge_GetParametricCenter_17(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiQuadraticQuadraticWedge_GetParametricCoords_18(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override IntPtr GetParametricCoords()
	{
		return vtkBiQuadraticQuadraticWedge_GetParametricCoords_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiQuadraticQuadraticWedge_InterpolateDerivs_19(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// </summary>
	public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkBiQuadraticQuadraticWedge_InterpolateDerivs_19(GetCppThis(), pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiQuadraticQuadraticWedge_InterpolateFunctions_20(HandleRef pThis, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// </summary>
	public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
	{
		vtkBiQuadraticQuadraticWedge_InterpolateFunctions_20(GetCppThis(), pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiQuadraticQuadraticWedge_InterpolationDerivs_21(IntPtr pcoords, IntPtr derivs);

	/// <summary>
	/// Return the center of the quadratic wedge in parametric coordinates.
	/// </summary>
	public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkBiQuadraticQuadraticWedge_InterpolationDerivs_21(pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiQuadraticQuadraticWedge_InterpolationFunctions_22(IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Return the center of the quadratic wedge in parametric coordinates.
	/// </summary>
	public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
	{
		vtkBiQuadraticQuadraticWedge_InterpolationFunctions_22(pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiQuadraticQuadraticWedge_IntersectWithLine_23(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

	/// <summary>
	/// Line-edge intersection. Intersection has to occur within [0,1] parametric
	/// coordinates and with specified tolerance.
	/// </summary>
	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
	{
		return vtkBiQuadraticQuadraticWedge_IntersectWithLine_23(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiQuadraticQuadraticWedge_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBiQuadraticQuadraticWedge_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiQuadraticQuadraticWedge_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBiQuadraticQuadraticWedge_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiQuadraticQuadraticWedge_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBiQuadraticQuadraticWedge NewInstance()
	{
		vtkBiQuadraticQuadraticWedge result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiQuadraticQuadraticWedge_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBiQuadraticQuadraticWedge)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiQuadraticQuadraticWedge_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBiQuadraticQuadraticWedge SafeDownCast(vtkObjectBase o)
	{
		vtkBiQuadraticQuadraticWedge vtkBiQuadraticQuadraticWedge2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiQuadraticQuadraticWedge_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBiQuadraticQuadraticWedge2 = (vtkBiQuadraticQuadraticWedge)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBiQuadraticQuadraticWedge2.Register(null);
			}
		}
		return vtkBiQuadraticQuadraticWedge2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiQuadraticQuadraticWedge_Triangulate_29(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
	{
		return vtkBiQuadraticQuadraticWedge_Triangulate_29(GetCppThis(), index, ptIds?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef));
	}
}
