using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHigherOrderTetra
/// </summary>
/// <remarks>
///    A 3D cell that represents an arbitrary order HigherOrder tetrahedron
///
/// vtkHigherOrderTetra is a concrete implementation of vtkCell to represent a
/// 3D tetrahedron using HigherOrder shape functions of user specified order.
///
/// The number of points in a HigherOrder cell determines the order over which they
/// are iterated relative to the parametric coordinate system of the cell. The
/// first points that are reported are vertices. They appear in the same order in
/// which they would appear in linear cells. Mid-edge points are reported next.
/// They are reported in sequence. For two- and three-dimensional (3D) cells, the
/// following set of points to be reported are face points. Finally, 3D cells
/// report points interior to their volume.
/// </remarks>
public abstract class vtkHigherOrderTetra : vtkNonLinearCell
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHigherOrderTetra";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHigherOrderTetra()
	{
		MRClassNameKey = "class vtkHigherOrderTetra";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHigherOrderTetra"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHigherOrderTetra(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkHigherOrderTetra_BarycentricIndex_01(long index, IntPtr bindex, long order);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static void BarycentricIndex(long index, IntPtr bindex, long order)
	{
		vtkHigherOrderTetra_BarycentricIndex_01(index, bindex, order);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderTetra_CellBoundary_02(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
	{
		return vtkHigherOrderTetra_CellBoundary_02(GetCppThis(), subId, pcoords, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderTetra_Clip_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
	{
		vtkHigherOrderTetra_Clip_03(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef), insideOut);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHigherOrderTetra_ComputeOrder_04(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public long ComputeOrder()
	{
		return vtkHigherOrderTetra_ComputeOrder_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHigherOrderTetra_ComputeOrder_05(long nPoints);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static long ComputeOrder(long nPoints)
	{
		return vtkHigherOrderTetra_ComputeOrder_05(nPoints);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderTetra_Contour_06(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
	{
		vtkHigherOrderTetra_Contour_06(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), verts?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderTetra_Derivatives_07(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
	{
		vtkHigherOrderTetra_Derivatives_07(GetCppThis(), subId, pcoords, values, dim, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderTetra_EvaluateLocation_08(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
	{
		vtkHigherOrderTetra_EvaluateLocation_08(GetCppThis(), ref subId, pcoords, x, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderTetra_EvaluatePosition_09(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
	{
		return vtkHigherOrderTetra_EvaluatePosition_09(GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderTetra_GetCellDimension_10(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int GetCellDimension()
	{
		return vtkHigherOrderTetra_GetCellDimension_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderTetra_GetCellType_11(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int GetCellType()
	{
		return vtkHigherOrderTetra_GetCellType_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderTetra_GetEdge_12(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override vtkCell GetEdge(int edgeId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderTetra_GetEdge_12(GetCppThis(), edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkHigherOrderTetra_GetEdgeCell_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual vtkHigherOrderCurve GetEdgeCell()
	{
		vtkHigherOrderCurve vtkHigherOrderCurve2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderTetra_GetEdgeCell_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkHigherOrderTetra_GetFace_14(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override vtkCell GetFace(int faceId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderTetra_GetFace_14(GetCppThis(), faceId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkHigherOrderTetra_GetFaceCell_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual vtkHigherOrderTriangle GetFaceCell()
	{
		vtkHigherOrderTriangle vtkHigherOrderTriangle2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderTetra_GetFaceCell_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkHigherOrderTetra_GetNumberOfEdges_16(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int GetNumberOfEdges()
	{
		return vtkHigherOrderTetra_GetNumberOfEdges_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderTetra_GetNumberOfFaces_17(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int GetNumberOfFaces()
	{
		return vtkHigherOrderTetra_GetNumberOfFaces_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHigherOrderTetra_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHigherOrderTetra_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHigherOrderTetra_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHigherOrderTetra_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHigherOrderTetra_GetOrder_20(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public long GetOrder()
	{
		return vtkHigherOrderTetra_GetOrder_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderTetra_GetParametricCenter_21(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int GetParametricCenter(IntPtr pcoords)
	{
		return vtkHigherOrderTetra_GetParametricCenter_21(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderTetra_GetParametricCoords_22(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override IntPtr GetParametricCoords()
	{
		return vtkHigherOrderTetra_GetParametricCoords_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHigherOrderTetra_GetParametricDistance_23(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override double GetParametricDistance(IntPtr pcoords)
	{
		return vtkHigherOrderTetra_GetParametricDistance_23(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHigherOrderTetra_Index_24(IntPtr bindex, long order);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static long Index(IntPtr bindex, long order)
	{
		return vtkHigherOrderTetra_Index_24(bindex, order);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderTetra_Initialize_25(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Initialize()
	{
		vtkHigherOrderTetra_Initialize_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderTetra_InterpolateDerivs_26(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkHigherOrderTetra_InterpolateDerivs_26(GetCppThis(), pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderTetra_InterpolateFunctions_27(HandleRef pThis, IntPtr pcoords, IntPtr weights);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
	{
		vtkHigherOrderTetra_InterpolateFunctions_27(GetCppThis(), pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderTetra_IntersectWithLine_28(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
	{
		return vtkHigherOrderTetra_IntersectWithLine_28(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderTetra_IsA_29(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHigherOrderTetra_IsA_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderTetra_IsTypeOf_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHigherOrderTetra_IsTypeOf_30(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderTetra_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHigherOrderTetra NewInstance()
	{
		vtkHigherOrderTetra result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderTetra_NewInstance_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHigherOrderTetra)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderTetra_RequiresInitialization_32(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int RequiresInitialization()
	{
		return vtkHigherOrderTetra_RequiresInitialization_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderTetra_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHigherOrderTetra SafeDownCast(vtkObjectBase o)
	{
		vtkHigherOrderTetra vtkHigherOrderTetra2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderTetra_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHigherOrderTetra2 = (vtkHigherOrderTetra)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHigherOrderTetra2.Register(null);
			}
		}
		return vtkHigherOrderTetra2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderTetra_SetParametricCoords_34(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetParametricCoords()
	{
		vtkHigherOrderTetra_SetParametricCoords_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderTetra_ToBarycentricIndex_35(HandleRef pThis, long index, IntPtr bindex);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void ToBarycentricIndex(long index, IntPtr bindex)
	{
		vtkHigherOrderTetra_ToBarycentricIndex_35(GetCppThis(), index, bindex);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHigherOrderTetra_ToIndex_36(HandleRef pThis, IntPtr bindex);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public long ToIndex(IntPtr bindex)
	{
		return vtkHigherOrderTetra_ToIndex_36(GetCppThis(), bindex);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderTetra_Triangulate_37(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
	{
		return vtkHigherOrderTetra_Triangulate_37(GetCppThis(), index, ptIds?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef));
	}
}
