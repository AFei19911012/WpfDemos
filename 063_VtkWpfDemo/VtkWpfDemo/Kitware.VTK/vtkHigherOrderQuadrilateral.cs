using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public abstract class vtkHigherOrderQuadrilateral : vtkNonLinearCell
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHigherOrderQuadrilateral";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHigherOrderQuadrilateral()
	{
		MRClassNameKey = "class vtkHigherOrderQuadrilateral";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHigherOrderQuadrilateral"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHigherOrderQuadrilateral(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern int vtkHigherOrderQuadrilateral_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

	public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
	{
		return vtkHigherOrderQuadrilateral_CellBoundary_01(GetCppThis(), subId, pcoords, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderQuadrilateral_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

	public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
	{
		vtkHigherOrderQuadrilateral_Clip_02(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef), insideOut);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderQuadrilateral_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

	public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
	{
		vtkHigherOrderQuadrilateral_Contour_03(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), verts?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderQuadrilateral_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

	public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
	{
		vtkHigherOrderQuadrilateral_Derivatives_04(GetCppThis(), subId, pcoords, values, dim, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderQuadrilateral_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

	public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
	{
		vtkHigherOrderQuadrilateral_EvaluateLocation_05(GetCppThis(), ref subId, pcoords, x, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderQuadrilateral_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

	public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
	{
		return vtkHigherOrderQuadrilateral_EvaluatePosition_06(GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderQuadrilateral_GetCellDimension_07(HandleRef pThis);

	public override int GetCellDimension()
	{
		return vtkHigherOrderQuadrilateral_GetCellDimension_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderQuadrilateral_GetCellType_08(HandleRef pThis);

	public override int GetCellType()
	{
		return vtkHigherOrderQuadrilateral_GetCellType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderQuadrilateral_GetEdge_09(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public override vtkCell GetEdge(int edgeId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderQuadrilateral_GetEdge_09(GetCppThis(), edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkHigherOrderQuadrilateral_GetEdgeCell_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public virtual vtkHigherOrderCurve GetEdgeCell()
	{
		vtkHigherOrderCurve vtkHigherOrderCurve2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderQuadrilateral_GetEdgeCell_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkHigherOrderQuadrilateral_GetFace_11(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public override vtkCell GetFace(int arg0)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderQuadrilateral_GetFace_11(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkHigherOrderQuadrilateral_GetNumberOfEdges_12(HandleRef pThis);

	public override int GetNumberOfEdges()
	{
		return vtkHigherOrderQuadrilateral_GetNumberOfEdges_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderQuadrilateral_GetNumberOfFaces_13(HandleRef pThis);

	public override int GetNumberOfFaces()
	{
		return vtkHigherOrderQuadrilateral_GetNumberOfFaces_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHigherOrderQuadrilateral_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHigherOrderQuadrilateral_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHigherOrderQuadrilateral_GetNumberOfGenerationsFromBaseType_15(string type);

	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHigherOrderQuadrilateral_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderQuadrilateral_GetOrder_16(HandleRef pThis);

	public virtual IntPtr GetOrder()
	{
		return vtkHigherOrderQuadrilateral_GetOrder_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderQuadrilateral_GetOrder_17(HandleRef pThis, int i);

	public virtual int GetOrder(int i)
	{
		return vtkHigherOrderQuadrilateral_GetOrder_17(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderQuadrilateral_GetParametricCenter_18(HandleRef pThis, IntPtr center);

	public override int GetParametricCenter(IntPtr center)
	{
		return vtkHigherOrderQuadrilateral_GetParametricCenter_18(GetCppThis(), center);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderQuadrilateral_GetParametricCoords_19(HandleRef pThis);

	public override IntPtr GetParametricCoords()
	{
		return vtkHigherOrderQuadrilateral_GetParametricCoords_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHigherOrderQuadrilateral_GetParametricDistance_20(HandleRef pThis, IntPtr pcoords);

	public override double GetParametricDistance(IntPtr pcoords)
	{
		return vtkHigherOrderQuadrilateral_GetParametricDistance_20(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderQuadrilateral_Initialize_21(HandleRef pThis);

	public override void Initialize()
	{
		vtkHigherOrderQuadrilateral_Initialize_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderQuadrilateral_InterpolateDerivs_22(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

	public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkHigherOrderQuadrilateral_InterpolateDerivs_22(GetCppThis(), pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderQuadrilateral_InterpolateFunctions_23(HandleRef pThis, IntPtr pcoords, IntPtr weights);

	public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
	{
		vtkHigherOrderQuadrilateral_InterpolateFunctions_23(GetCppThis(), pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderQuadrilateral_IntersectWithLine_24(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
	{
		return vtkHigherOrderQuadrilateral_IntersectWithLine_24(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderQuadrilateral_IsA_25(HandleRef pThis, string type);

	public override int IsA(string type)
	{
		return vtkHigherOrderQuadrilateral_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderQuadrilateral_IsTypeOf_26(string type);

	public new static int IsTypeOf(string type)
	{
		return vtkHigherOrderQuadrilateral_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderQuadrilateral_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new vtkHigherOrderQuadrilateral NewInstance()
	{
		vtkHigherOrderQuadrilateral result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderQuadrilateral_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHigherOrderQuadrilateral)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderQuadrilateral_PointIndexFromIJK_28(HandleRef pThis, int i, int j, int k);

	public int PointIndexFromIJK(int i, int j, int k)
	{
		return vtkHigherOrderQuadrilateral_PointIndexFromIJK_28(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderQuadrilateral_PointIndexFromIJK_29(int i, int j, IntPtr order);

	public static int PointIndexFromIJK(int i, int j, IntPtr order)
	{
		return vtkHigherOrderQuadrilateral_PointIndexFromIJK_29(i, j, order);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderQuadrilateral_RequiresInitialization_30(HandleRef pThis);

	public override int RequiresInitialization()
	{
		return vtkHigherOrderQuadrilateral_RequiresInitialization_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderQuadrilateral_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkHigherOrderQuadrilateral SafeDownCast(vtkObjectBase o)
	{
		vtkHigherOrderQuadrilateral vtkHigherOrderQuadrilateral2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderQuadrilateral_SafeDownCast_31(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkHigherOrderQuadrilateral_SetOrder_32(HandleRef pThis, int s, int t);

	public virtual void SetOrder(int s, int t)
	{
		vtkHigherOrderQuadrilateral_SetOrder_32(GetCppThis(), s, t);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderQuadrilateral_SetOrderFromCellData_33(HandleRef pThis, HandleRef cell_data, long numPts, long cell_id);

	public virtual void SetOrderFromCellData(vtkCellData cell_data, long numPts, long cell_id)
	{
		vtkHigherOrderQuadrilateral_SetOrderFromCellData_33(GetCppThis(), cell_data?.GetCppThis() ?? default(HandleRef), numPts, cell_id);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderQuadrilateral_SetParametricCoords_34(HandleRef pThis);

	public void SetParametricCoords()
	{
		vtkHigherOrderQuadrilateral_SetParametricCoords_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderQuadrilateral_SetUniformOrderFromNumPoints_35(HandleRef pThis, long numPts);

	public virtual void SetUniformOrderFromNumPoints(long numPts)
	{
		vtkHigherOrderQuadrilateral_SetUniformOrderFromNumPoints_35(GetCppThis(), numPts);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHigherOrderQuadrilateral_SubCellCoordinatesFromId_36(HandleRef pThis, vtkVector3i ijk, int subId);

	public bool SubCellCoordinatesFromId(vtkVector3i ijk, int subId)
	{
		return (vtkHigherOrderQuadrilateral_SubCellCoordinatesFromId_36(GetCppThis(), ijk, subId) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHigherOrderQuadrilateral_SubCellCoordinatesFromId_37(HandleRef pThis, ref int i, ref int j, ref int k, int subId);

	public bool SubCellCoordinatesFromId(ref int i, ref int j, ref int k, int subId)
	{
		return (vtkHigherOrderQuadrilateral_SubCellCoordinatesFromId_37(GetCppThis(), ref i, ref j, ref k, subId) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHigherOrderQuadrilateral_TransformApproxToCellParams_38(HandleRef pThis, int subCell, IntPtr pcoords);

	public bool TransformApproxToCellParams(int subCell, IntPtr pcoords)
	{
		return (vtkHigherOrderQuadrilateral_TransformApproxToCellParams_38(GetCppThis(), subCell, pcoords) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderQuadrilateral_Triangulate_39(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

	public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
	{
		return vtkHigherOrderQuadrilateral_Triangulate_39(GetCppThis(), index, ptIds?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef));
	}
}
