using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkQuadraticLinearQuad
/// </summary>
/// <remarks>
///    cell represents a quadratic-linear, 6-node isoparametric quad
///
/// vtkQuadraticQuad is a concrete implementation of vtkNonLinearCell to
/// represent a two-dimensional, 6-node isoparametric quadratic-linear quadrilateral
/// element. The interpolation is the standard finite element, quadratic-linear
/// isoparametric shape function. The cell includes a mid-edge node for two
/// of the four edges. The ordering of the six points defining
/// the cell are point ids (0-3,4-5) where ids 0-3 define the four corner
/// vertices of the quad; ids 4-7 define the midedge nodes (0,1) and (2,3) .
///
/// </remarks>
/// <seealso>
///
/// vtkQuadraticEdge vtkQuadraticTriangle vtkQuadraticTetra vtkQuadraticQuad
/// vtkQuadraticHexahedron vtkQuadraticWedge vtkQuadraticPyramid
///
/// @par Thanks:
/// Thanks to Soeren Gebbert  who developed this class and
/// integrated it into VTK 5.0.
/// </seealso>
public class vtkQuadraticLinearQuad : vtkNonLinearCell
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkQuadraticLinearQuad";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkQuadraticLinearQuad()
	{
		MRClassNameKey = "class vtkQuadraticLinearQuad";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadraticLinearQuad"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkQuadraticLinearQuad(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadraticLinearQuad_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkQuadraticLinearQuad New()
	{
		vtkQuadraticLinearQuad result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadraticLinearQuad_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkQuadraticLinearQuad)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkQuadraticLinearQuad()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkQuadraticLinearQuad_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkQuadraticLinearQuad_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
	{
		return vtkQuadraticLinearQuad_CellBoundary_01(GetCppThis(), subId, pcoords, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticLinearQuad_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

	/// <summary>
	/// Clip this quadratic linear quad using scalar value provided. Like
	/// contouring, except that it cuts the quad to produce linear triangles.
	/// </summary>
	public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
	{
		vtkQuadraticLinearQuad_Clip_02(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef), insideOut);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticLinearQuad_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
	{
		vtkQuadraticLinearQuad_Contour_03(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), verts?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticLinearQuad_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
	{
		vtkQuadraticLinearQuad_Derivatives_04(GetCppThis(), subId, pcoords, values, dim, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticLinearQuad_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
	{
		vtkQuadraticLinearQuad_EvaluateLocation_05(GetCppThis(), ref subId, pcoords, x, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticLinearQuad_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
	{
		return vtkQuadraticLinearQuad_EvaluatePosition_06(GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticLinearQuad_GetCellDimension_07(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int GetCellDimension()
	{
		return vtkQuadraticLinearQuad_GetCellDimension_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticLinearQuad_GetCellType_08(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int GetCellType()
	{
		return vtkQuadraticLinearQuad_GetCellType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadraticLinearQuad_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkQuadraticLinearQuad_GetEdge_09(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkQuadraticLinearQuad_GetEdgeArray_10(long edgeId);

	/// <summary>
	/// Return the ids of the vertices defining edge (`edgeId`).
	/// Ids are related to the cell, not to the dataset.
	///
	/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
	/// This is so ids are unified between vtkCell and vtkPoints.
	///
	/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
	/// This is so ids are unified between vtkCell and vtkPoints.
	/// </summary>
	public static IntPtr GetEdgeArray(long edgeId)
	{
		return vtkQuadraticLinearQuad_GetEdgeArray_10(edgeId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadraticLinearQuad_GetFace_11(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkQuadraticLinearQuad_GetFace_11(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkQuadraticLinearQuad_GetNumberOfEdges_12(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int GetNumberOfEdges()
	{
		return vtkQuadraticLinearQuad_GetNumberOfEdges_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticLinearQuad_GetNumberOfFaces_13(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int GetNumberOfFaces()
	{
		return vtkQuadraticLinearQuad_GetNumberOfFaces_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkQuadraticLinearQuad_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkQuadraticLinearQuad_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkQuadraticLinearQuad_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkQuadraticLinearQuad_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticLinearQuad_GetParametricCenter_16(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	/// Return the center of the pyramid in parametric coordinates.
	/// </summary>
	public override int GetParametricCenter(IntPtr pcoords)
	{
		return vtkQuadraticLinearQuad_GetParametricCenter_16(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadraticLinearQuad_GetParametricCoords_17(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override IntPtr GetParametricCoords()
	{
		return vtkQuadraticLinearQuad_GetParametricCoords_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticLinearQuad_InterpolateDerivs_18(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// </summary>
	public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkQuadraticLinearQuad_InterpolateDerivs_18(GetCppThis(), pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticLinearQuad_InterpolateFunctions_19(HandleRef pThis, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// </summary>
	public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
	{
		vtkQuadraticLinearQuad_InterpolateFunctions_19(GetCppThis(), pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticLinearQuad_InterpolationDerivs_20(IntPtr pcoords, IntPtr derivs);

	/// <summary>
	/// Return the center of the pyramid in parametric coordinates.
	/// </summary>
	public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkQuadraticLinearQuad_InterpolationDerivs_20(pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticLinearQuad_InterpolationFunctions_21(IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Return the center of the pyramid in parametric coordinates.
	/// </summary>
	public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
	{
		vtkQuadraticLinearQuad_InterpolationFunctions_21(pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticLinearQuad_IntersectWithLine_22(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

	/// <summary>
	/// Line-edge intersection. Intersection has to occur within [0,1] parametric
	/// coordinates and with specified tolerance.
	/// </summary>
	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
	{
		return vtkQuadraticLinearQuad_IntersectWithLine_22(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticLinearQuad_IsA_23(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkQuadraticLinearQuad_IsA_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticLinearQuad_IsTypeOf_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkQuadraticLinearQuad_IsTypeOf_24(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadraticLinearQuad_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkQuadraticLinearQuad NewInstance()
	{
		vtkQuadraticLinearQuad result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadraticLinearQuad_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkQuadraticLinearQuad)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadraticLinearQuad_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkQuadraticLinearQuad SafeDownCast(vtkObjectBase o)
	{
		vtkQuadraticLinearQuad vtkQuadraticLinearQuad2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadraticLinearQuad_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkQuadraticLinearQuad2 = (vtkQuadraticLinearQuad)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkQuadraticLinearQuad2.Register(null);
			}
		}
		return vtkQuadraticLinearQuad2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticLinearQuad_Triangulate_28(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
	{
		return vtkQuadraticLinearQuad_Triangulate_28(GetCppThis(), index, ptIds?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef));
	}
}
