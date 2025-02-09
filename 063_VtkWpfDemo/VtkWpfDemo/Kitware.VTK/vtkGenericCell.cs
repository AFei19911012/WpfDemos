using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericCell
/// </summary>
/// <remarks>
///    provides thread-safe access to cells
///
/// vtkGenericCell is a class that provides access to concrete types of cells.
/// It's main purpose is to allow thread-safe access to cells, supporting
/// the vtkDataSet::GetCell(vtkGenericCell *) method. vtkGenericCell acts
/// like any type of cell, it just dereferences an internal representation.
/// The SetCellType() methods use \#define constants; these are defined in
/// the file vtkCellType.h.
///
/// </remarks>
/// <seealso>
///
/// vtkCell vtkDataSet
/// </seealso>
public class vtkGenericCell : vtkCell
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericCell";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericCell()
	{
		MRClassNameKey = "class vtkGenericCell";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericCell"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericCell(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericCell_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create handle to any type of cell; by default a vtkEmptyCell.
	/// </summary>
	public new static vtkGenericCell New()
	{
		vtkGenericCell result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericCell_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create handle to any type of cell; by default a vtkEmptyCell.
	/// </summary>
	public vtkGenericCell()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGenericCell_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkGenericCell_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
	{
		return vtkGenericCell_CellBoundary_01(GetCppThis(), subId, pcoords, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef connectivity, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray connectivity, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
	{
		vtkGenericCell_Clip_02(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), connectivity?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef), insideOut);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
	{
		vtkGenericCell_Contour_03(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), verts?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_DeepCopy_04(HandleRef pThis, HandleRef c);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void DeepCopy(vtkCell c)
	{
		vtkGenericCell_DeepCopy_04(GetCppThis(), c?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_Derivatives_05(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
	{
		vtkGenericCell_Derivatives_05(GetCppThis(), subId, pcoords, values, dim, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_EvaluateLocation_06(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
	{
		vtkGenericCell_EvaluateLocation_06(GetCppThis(), ref subId, pcoords, x, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericCell_EvaluatePosition_07(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
	{
		return vtkGenericCell_EvaluatePosition_07(GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericCell_GetCellDimension_08(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetCellDimension()
	{
		return vtkGenericCell_GetCellDimension_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericCell_GetCellType_09(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetCellType()
	{
		return vtkGenericCell_GetCellType_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericCell_GetEdge_10(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override vtkCell GetEdge(int edgeId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericCell_GetEdge_10(GetCppThis(), edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkGenericCell_GetFace_11(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override vtkCell GetFace(int faceId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericCell_GetFace_11(GetCppThis(), faceId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkGenericCell_GetFaces_12(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override IntPtr GetFaces()
	{
		return vtkGenericCell_GetFaces_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericCell_GetNumberOfEdges_13(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetNumberOfEdges()
	{
		return vtkGenericCell_GetNumberOfEdges_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericCell_GetNumberOfFaces_14(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetNumberOfFaces()
	{
		return vtkGenericCell_GetNumberOfFaces_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericCell_GetNumberOfGenerationsFromBase_15(HandleRef pThis, string type);

	/// <summary>
	/// Create handle to any type of cell; by default a vtkEmptyCell.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericCell_GetNumberOfGenerationsFromBase_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericCell_GetNumberOfGenerationsFromBaseType_16(string type);

	/// <summary>
	/// Create handle to any type of cell; by default a vtkEmptyCell.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericCell_GetNumberOfGenerationsFromBaseType_16(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericCell_GetParametricCenter_17(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int GetParametricCenter(IntPtr pcoords)
	{
		return vtkGenericCell_GetParametricCenter_17(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericCell_GetParametricCoords_18(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override IntPtr GetParametricCoords()
	{
		return vtkGenericCell_GetParametricCoords_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericCell_GetRepresentativeCell_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate a new vtkCell based on it's cell type value
	/// </summary>
	public vtkCell GetRepresentativeCell()
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericCell_GetRepresentativeCell_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkGenericCell_Initialize_20(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void Initialize()
	{
		vtkGenericCell_Initialize_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericCell_InstantiateCell_21(int cellType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate a new vtkCell based on it's cell type value
	/// </summary>
	public static vtkCell InstantiateCell(int cellType)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericCell_InstantiateCell_21(cellType, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkGenericCell_InterpolateDerivs_22(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// </summary>
	public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkGenericCell_InterpolateDerivs_22(GetCppThis(), pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_InterpolateFunctions_23(HandleRef pThis, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// </summary>
	public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
	{
		vtkGenericCell_InterpolateFunctions_23(GetCppThis(), pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericCell_IntersectWithLine_24(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
	{
		return vtkGenericCell_IntersectWithLine_24(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericCell_IsA_25(HandleRef pThis, string type);

	/// <summary>
	/// Create handle to any type of cell; by default a vtkEmptyCell.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericCell_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericCell_IsLinear_26(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int IsLinear()
	{
		return vtkGenericCell_IsLinear_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericCell_IsPrimaryCell_27(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int IsPrimaryCell()
	{
		return vtkGenericCell_IsPrimaryCell_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericCell_IsTypeOf_28(string type);

	/// <summary>
	/// Create handle to any type of cell; by default a vtkEmptyCell.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericCell_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericCell_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create handle to any type of cell; by default a vtkEmptyCell.
	/// </summary>
	public new vtkGenericCell NewInstance()
	{
		vtkGenericCell result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericCell_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericCell_RequiresExplicitFaceRepresentation_31(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int RequiresExplicitFaceRepresentation()
	{
		return vtkGenericCell_RequiresExplicitFaceRepresentation_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericCell_RequiresInitialization_32(HandleRef pThis);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int RequiresInitialization()
	{
		return vtkGenericCell_RequiresInitialization_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericCell_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create handle to any type of cell; by default a vtkEmptyCell.
	/// </summary>
	public new static vtkGenericCell SafeDownCast(vtkObjectBase o)
	{
		vtkGenericCell vtkGenericCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericCell_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericCell2 = (vtkGenericCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericCell2.Register(null);
			}
		}
		return vtkGenericCell2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellType_34(HandleRef pThis, int cellType);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellType(int cellType)
	{
		vtkGenericCell_SetCellType_34(GetCppThis(), cellType);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToBezierCurve_35(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToBezierCurve()
	{
		vtkGenericCell_SetCellTypeToBezierCurve_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToBezierHexahedron_36(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToBezierHexahedron()
	{
		vtkGenericCell_SetCellTypeToBezierHexahedron_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToBezierQuadrilateral_37(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToBezierQuadrilateral()
	{
		vtkGenericCell_SetCellTypeToBezierQuadrilateral_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToBezierTetra_38(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToBezierTetra()
	{
		vtkGenericCell_SetCellTypeToBezierTetra_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToBezierTriangle_39(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToBezierTriangle()
	{
		vtkGenericCell_SetCellTypeToBezierTriangle_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToBezierWedge_40(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToBezierWedge()
	{
		vtkGenericCell_SetCellTypeToBezierWedge_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToBiQuadraticQuad_41(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToBiQuadraticQuad()
	{
		vtkGenericCell_SetCellTypeToBiQuadraticQuad_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToBiQuadraticQuadraticHexahedron_42(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToBiQuadraticQuadraticHexahedron()
	{
		vtkGenericCell_SetCellTypeToBiQuadraticQuadraticHexahedron_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToBiQuadraticQuadraticWedge_43(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToBiQuadraticQuadraticWedge()
	{
		vtkGenericCell_SetCellTypeToBiQuadraticQuadraticWedge_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToBiQuadraticTriangle_44(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToBiQuadraticTriangle()
	{
		vtkGenericCell_SetCellTypeToBiQuadraticTriangle_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToConvexPointSet_45(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToConvexPointSet()
	{
		vtkGenericCell_SetCellTypeToConvexPointSet_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToCubicLine_46(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToCubicLine()
	{
		vtkGenericCell_SetCellTypeToCubicLine_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToEmptyCell_47(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToEmptyCell()
	{
		vtkGenericCell_SetCellTypeToEmptyCell_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToHexagonalPrism_48(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToHexagonalPrism()
	{
		vtkGenericCell_SetCellTypeToHexagonalPrism_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToHexahedron_49(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToHexahedron()
	{
		vtkGenericCell_SetCellTypeToHexahedron_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToLagrangeCurve_50(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToLagrangeCurve()
	{
		vtkGenericCell_SetCellTypeToLagrangeCurve_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToLagrangeHexahedron_51(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToLagrangeHexahedron()
	{
		vtkGenericCell_SetCellTypeToLagrangeHexahedron_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToLagrangeQuadrilateral_52(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToLagrangeQuadrilateral()
	{
		vtkGenericCell_SetCellTypeToLagrangeQuadrilateral_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToLagrangeTetra_53(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToLagrangeTetra()
	{
		vtkGenericCell_SetCellTypeToLagrangeTetra_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToLagrangeTriangle_54(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToLagrangeTriangle()
	{
		vtkGenericCell_SetCellTypeToLagrangeTriangle_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToLagrangeWedge_55(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToLagrangeWedge()
	{
		vtkGenericCell_SetCellTypeToLagrangeWedge_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToLine_56(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToLine()
	{
		vtkGenericCell_SetCellTypeToLine_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToPentagonalPrism_57(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToPentagonalPrism()
	{
		vtkGenericCell_SetCellTypeToPentagonalPrism_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToPixel_58(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToPixel()
	{
		vtkGenericCell_SetCellTypeToPixel_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToPolyLine_59(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToPolyLine()
	{
		vtkGenericCell_SetCellTypeToPolyLine_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToPolyVertex_60(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToPolyVertex()
	{
		vtkGenericCell_SetCellTypeToPolyVertex_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToPolygon_61(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToPolygon()
	{
		vtkGenericCell_SetCellTypeToPolygon_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToPolyhedron_62(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToPolyhedron()
	{
		vtkGenericCell_SetCellTypeToPolyhedron_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToPyramid_63(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToPyramid()
	{
		vtkGenericCell_SetCellTypeToPyramid_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToQuad_64(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToQuad()
	{
		vtkGenericCell_SetCellTypeToQuad_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToQuadraticEdge_65(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToQuadraticEdge()
	{
		vtkGenericCell_SetCellTypeToQuadraticEdge_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToQuadraticHexahedron_66(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToQuadraticHexahedron()
	{
		vtkGenericCell_SetCellTypeToQuadraticHexahedron_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToQuadraticLinearQuad_67(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToQuadraticLinearQuad()
	{
		vtkGenericCell_SetCellTypeToQuadraticLinearQuad_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToQuadraticLinearWedge_68(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToQuadraticLinearWedge()
	{
		vtkGenericCell_SetCellTypeToQuadraticLinearWedge_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToQuadraticPolygon_69(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToQuadraticPolygon()
	{
		vtkGenericCell_SetCellTypeToQuadraticPolygon_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToQuadraticPyramid_70(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToQuadraticPyramid()
	{
		vtkGenericCell_SetCellTypeToQuadraticPyramid_70(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToQuadraticQuad_71(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToQuadraticQuad()
	{
		vtkGenericCell_SetCellTypeToQuadraticQuad_71(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToQuadraticTetra_72(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToQuadraticTetra()
	{
		vtkGenericCell_SetCellTypeToQuadraticTetra_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToQuadraticTriangle_73(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToQuadraticTriangle()
	{
		vtkGenericCell_SetCellTypeToQuadraticTriangle_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToQuadraticWedge_74(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToQuadraticWedge()
	{
		vtkGenericCell_SetCellTypeToQuadraticWedge_74(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToTetra_75(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToTetra()
	{
		vtkGenericCell_SetCellTypeToTetra_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToTriQuadraticHexahedron_76(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToTriQuadraticHexahedron()
	{
		vtkGenericCell_SetCellTypeToTriQuadraticHexahedron_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToTriQuadraticPyramid_77(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToTriQuadraticPyramid()
	{
		vtkGenericCell_SetCellTypeToTriQuadraticPyramid_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToTriangle_78(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToTriangle()
	{
		vtkGenericCell_SetCellTypeToTriangle_78(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToTriangleStrip_79(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToTriangleStrip()
	{
		vtkGenericCell_SetCellTypeToTriangleStrip_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToVertex_80(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToVertex()
	{
		vtkGenericCell_SetCellTypeToVertex_80(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToVoxel_81(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToVoxel()
	{
		vtkGenericCell_SetCellTypeToVoxel_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetCellTypeToWedge_82(HandleRef pThis);

	/// <summary>
	/// This method is used to support the vtkDataSet::GetCell(vtkGenericCell *)
	/// method. It allows vtkGenericCell to act like any cell type by
	/// dereferencing an internal instance of a concrete cell type. When
	/// you set the cell type, you are resetting a pointer to an internal
	/// cell which is then used for computation.
	/// </summary>
	public void SetCellTypeToWedge()
	{
		vtkGenericCell_SetCellTypeToWedge_82(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetFaces_83(HandleRef pThis, IntPtr faces);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void SetFaces(IntPtr faces)
	{
		vtkGenericCell_SetFaces_83(GetCppThis(), faces);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetPointIds_84(HandleRef pThis, HandleRef pointIds);

	/// <summary>
	/// Set the point ids to use for this cell. This updates the internal cell
	/// storage as well as the public member variable PointIds.
	/// </summary>
	public void SetPointIds(vtkIdList pointIds)
	{
		vtkGenericCell_SetPointIds_84(GetCppThis(), pointIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_SetPoints_85(HandleRef pThis, HandleRef points);

	/// <summary>
	/// Set the points object to use for this cell. This updates the internal cell
	/// storage as well as the public member variable Points.
	/// </summary>
	public void SetPoints(vtkPoints points)
	{
		vtkGenericCell_SetPoints_85(GetCppThis(), points?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCell_ShallowCopy_86(HandleRef pThis, HandleRef c);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override void ShallowCopy(vtkCell c)
	{
		vtkGenericCell_ShallowCopy_86(GetCppThis(), c?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericCell_Triangulate_87(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

	/// <summary>
	/// See the vtkCell API for descriptions of these methods.
	/// </summary>
	public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
	{
		return vtkGenericCell_Triangulate_87(GetCppThis(), index, ptIds?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef));
	}
}
