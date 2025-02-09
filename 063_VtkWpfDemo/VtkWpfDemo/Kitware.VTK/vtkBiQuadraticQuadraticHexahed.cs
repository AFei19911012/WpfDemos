using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBiQuadraticQuadraticHexahedron
/// </summary>
/// <remarks>
///    cell represents a biquadratic,
/// 24-node isoparametric hexahedron
///
/// vtkBiQuadraticQuadraticHexahedron is a concrete implementation of vtkNonLinearCell to
/// represent a three-dimensional, 24-node isoparametric biquadratic
/// hexahedron. The interpolation is the standard finite element,
/// biquadratic-quadratic
/// isoparametric shape function. The cell includes mid-edge and center-face nodes. The
/// ordering of the 24 points defining the cell is point ids (0-7,8-19, 20-23)
/// where point ids 0-7 are the eight corner vertices of the cube; followed by
/// twelve midedge nodes (8-19), nodes 20-23 are the center-face nodes. Note that
/// these midedge nodes correspond lie
/// on the edges defined by (0,1), (1,2), (2,3), (3,0), (4,5), (5,6), (6,7),
/// (7,4), (0,4), (1,5), (2,6), (3,7). The center face nodes laying in quad
/// 22-(0,1,5,4), 21-(1,2,6,5), 23-(2,3,7,6) and 22-(3,0,4,7)
///
/// \verbatim
///
/// top
///  7--14--6
///  |      |
/// 15      13
///  |      |
///  4--12--5
///
///  middle
/// 19--23--18
///  |      |
/// 20      21
///  |      |
/// 16--22--17
///
/// bottom
///  3--10--2
///  |      |
/// 11      9
///  |      |
///  0-- 8--1
///
/// \endverbatim
///
///
/// </remarks>
/// <seealso>
///
/// vtkQuadraticEdge vtkQuadraticTriangle vtkQuadraticTetra
/// vtkQuadraticQuad vtkQuadraticPyramid vtkQuadraticWedge
///
/// @par Thanks:
/// Thanks to Soeren Gebbert  who developed this class and
/// integrated it into VTK 5.0.
/// </seealso>
public class vtkBiQuadraticQuadraticHexahedron : vtkNonLinearCell
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBiQuadraticQuadraticHexahedron";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBiQuadraticQuadraticHexahedron()
	{
		MRClassNameKey = "class vtkBiQuadraticQuadraticHexahedron";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBiQuadraticQuadraticHexahedron"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBiQuadraticQuadraticHexahedron(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiQuadraticQuadraticHexahedron_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBiQuadraticQuadraticHexahedron New()
	{
		vtkBiQuadraticQuadraticHexahedron result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiQuadraticQuadraticHexahedron_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBiQuadraticQuadraticHexahedron)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkBiQuadraticQuadraticHexahedron()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBiQuadraticQuadraticHexahedron_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkBiQuadraticQuadraticHexahedron_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
	{
		return vtkBiQuadraticQuadraticHexahedron_CellBoundary_01(GetCppThis(), subId, pcoords, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiQuadraticQuadraticHexahedron_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef tetras, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

	/// <summary>
	/// Clip this biquadratic hexahedron using scalar value provided. Like
	/// contouring, except that it cuts the hex to produce linear
	/// tetrahedron.
	/// </summary>
	public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray tetras, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
	{
		vtkBiQuadraticQuadraticHexahedron_Clip_02(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), tetras?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef), insideOut);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiQuadraticQuadraticHexahedron_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
	{
		vtkBiQuadraticQuadraticHexahedron_Contour_03(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), verts?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiQuadraticQuadraticHexahedron_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
	{
		vtkBiQuadraticQuadraticHexahedron_Derivatives_04(GetCppThis(), subId, pcoords, values, dim, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiQuadraticQuadraticHexahedron_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
	{
		vtkBiQuadraticQuadraticHexahedron_EvaluateLocation_05(GetCppThis(), ref subId, pcoords, x, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiQuadraticQuadraticHexahedron_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
	{
		return vtkBiQuadraticQuadraticHexahedron_EvaluatePosition_06(GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiQuadraticQuadraticHexahedron_GetCellDimension_07(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int GetCellDimension()
	{
		return vtkBiQuadraticQuadraticHexahedron_GetCellDimension_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiQuadraticQuadraticHexahedron_GetCellType_08(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int GetCellType()
	{
		return vtkBiQuadraticQuadraticHexahedron_GetCellType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiQuadraticQuadraticHexahedron_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkBiQuadraticQuadraticHexahedron_GetEdge_09(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkBiQuadraticQuadraticHexahedron_GetEdgeArray_10(long edgeId);

	/// <summary>
	/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
	/// Ids are related to the cell, not to the dataset.
	///
	/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
	/// This is so ids are unified between vtkCell and vtkPoints.
	/// </summary>
	public static IntPtr GetEdgeArray(long edgeId)
	{
		return vtkBiQuadraticQuadraticHexahedron_GetEdgeArray_10(edgeId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiQuadraticQuadraticHexahedron_GetFace_11(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkBiQuadraticQuadraticHexahedron_GetFace_11(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkBiQuadraticQuadraticHexahedron_GetFaceArray_12(long faceId);

	/// <summary>
	/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
	/// Ids are related to the cell, not to the dataset.
	///
	/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
	/// This is so ids are unified between vtkCell and vtkPoints.
	/// </summary>
	public static IntPtr GetFaceArray(long faceId)
	{
		return vtkBiQuadraticQuadraticHexahedron_GetFaceArray_12(faceId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiQuadraticQuadraticHexahedron_GetNumberOfEdges_13(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int GetNumberOfEdges()
	{
		return vtkBiQuadraticQuadraticHexahedron_GetNumberOfEdges_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiQuadraticQuadraticHexahedron_GetNumberOfFaces_14(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int GetNumberOfFaces()
	{
		return vtkBiQuadraticQuadraticHexahedron_GetNumberOfFaces_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBiQuadraticQuadraticHexahedron_GetNumberOfGenerationsFromBase_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBiQuadraticQuadraticHexahedron_GetNumberOfGenerationsFromBase_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBiQuadraticQuadraticHexahedron_GetNumberOfGenerationsFromBaseType_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBiQuadraticQuadraticHexahedron_GetNumberOfGenerationsFromBaseType_16(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiQuadraticQuadraticHexahedron_GetParametricCoords_17(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override IntPtr GetParametricCoords()
	{
		return vtkBiQuadraticQuadraticHexahedron_GetParametricCoords_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiQuadraticQuadraticHexahedron_InterpolateDerivs_18(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// </summary>
	public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkBiQuadraticQuadraticHexahedron_InterpolateDerivs_18(GetCppThis(), pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiQuadraticQuadraticHexahedron_InterpolateFunctions_19(HandleRef pThis, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// </summary>
	public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
	{
		vtkBiQuadraticQuadraticHexahedron_InterpolateFunctions_19(GetCppThis(), pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiQuadraticQuadraticHexahedron_InterpolationDerivs_20(IntPtr pcoords, IntPtr derivs);

	/// <summary>
	/// Line-edge intersection. Intersection has to occur within [0,1] parametric
	/// coordinates and with specified tolerance.
	/// </summary>
	public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkBiQuadraticQuadraticHexahedron_InterpolationDerivs_20(pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiQuadraticQuadraticHexahedron_InterpolationFunctions_21(IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Line-edge intersection. Intersection has to occur within [0,1] parametric
	/// coordinates and with specified tolerance.
	/// </summary>
	public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
	{
		vtkBiQuadraticQuadraticHexahedron_InterpolationFunctions_21(pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiQuadraticQuadraticHexahedron_IntersectWithLine_22(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

	/// <summary>
	/// Line-edge intersection. Intersection has to occur within [0,1] parametric
	/// coordinates and with specified tolerance.
	/// </summary>
	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
	{
		return vtkBiQuadraticQuadraticHexahedron_IntersectWithLine_22(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiQuadraticQuadraticHexahedron_IsA_23(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBiQuadraticQuadraticHexahedron_IsA_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiQuadraticQuadraticHexahedron_IsTypeOf_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBiQuadraticQuadraticHexahedron_IsTypeOf_24(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiQuadraticQuadraticHexahedron_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBiQuadraticQuadraticHexahedron NewInstance()
	{
		vtkBiQuadraticQuadraticHexahedron result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiQuadraticQuadraticHexahedron_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBiQuadraticQuadraticHexahedron)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiQuadraticQuadraticHexahedron_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBiQuadraticQuadraticHexahedron SafeDownCast(vtkObjectBase o)
	{
		vtkBiQuadraticQuadraticHexahedron vtkBiQuadraticQuadraticHexahedron2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiQuadraticQuadraticHexahedron_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBiQuadraticQuadraticHexahedron2 = (vtkBiQuadraticQuadraticHexahedron)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBiQuadraticQuadraticHexahedron2.Register(null);
			}
		}
		return vtkBiQuadraticQuadraticHexahedron2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiQuadraticQuadraticHexahedron_Triangulate_28(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
	{
		return vtkBiQuadraticQuadraticHexahedron_Triangulate_28(GetCppThis(), index, ptIds?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef));
	}
}
