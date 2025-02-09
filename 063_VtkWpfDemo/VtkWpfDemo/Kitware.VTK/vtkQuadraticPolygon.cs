using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkQuadraticPolygon
/// </summary>
/// <remarks>
///    a cell that represents a parabolic n-sided polygon
///
/// vtkQuadraticPolygon is a concrete implementation of vtkNonLinearCell to
/// represent a 2D n-sided (2*n nodes) parabolic polygon. The polygon cannot
/// have any internal holes, and cannot self-intersect. The cell includes a
/// mid-edge node for each of the n edges of the cell. The ordering of the
/// 2*n points defining the cell are point ids (0..n-1 and n..2*n-1) where ids
/// 0..n-1 define the corner vertices of the polygon; ids n..2*n-1 define the
/// midedge nodes. Define the polygon with points ordered in the counter-
/// clockwise direction; do not repeat the last point.
///
/// </remarks>
/// <seealso>
///
/// vtkQuadraticEdge vtkQuadraticTriangle vtkQuadraticTetra
/// vtkQuadraticHexahedron vtkQuadraticWedge vtkQuadraticPyramid
/// </seealso>
public class vtkQuadraticPolygon : vtkNonLinearCell
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkQuadraticPolygon";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkQuadraticPolygon()
	{
		MRClassNameKey = "class vtkQuadraticPolygon";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadraticPolygon"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkQuadraticPolygon(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadraticPolygon_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkQuadraticPolygon New()
	{
		vtkQuadraticPolygon result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadraticPolygon_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkQuadraticPolygon)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkQuadraticPolygon()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkQuadraticPolygon_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkQuadraticPolygon_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

	/// <summary>
	/// These methods are based on the vtkPolygon ones :
	/// the vtkQuadraticPolygon (with n edges and 2*n points)
	/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
	/// and the vtkPolygon methods are called.
	/// </summary>
	public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
	{
		return vtkQuadraticPolygon_CellBoundary_01(GetCppThis(), subId, pcoords, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticPolygon_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

	/// <summary>
	/// These methods are based on the vtkPolygon ones :
	/// the vtkQuadraticPolygon (with n edges and 2*n points)
	/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
	/// and the vtkPolygon methods are called.
	/// </summary>
	public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
	{
		vtkQuadraticPolygon_Clip_02(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef), insideOut);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticPolygon_ComputeCentroid_03(HandleRef ids, HandleRef pts, IntPtr centroid);

	/// <summary>
	/// These methods are based on the vtkPolygon ones :
	/// the vtkQuadraticPolygon (with n edges and 2*n points)
	/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
	/// and the vtkPolygon methods are called.
	/// </summary>
	public static void ComputeCentroid(vtkIdTypeArray ids, vtkPoints pts, IntPtr centroid)
	{
		vtkQuadraticPolygon_ComputeCentroid_03(ids?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef), centroid);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticPolygon_Contour_04(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

	/// <summary>
	/// These methods are based on the vtkPolygon ones :
	/// the vtkQuadraticPolygon (with n edges and 2*n points)
	/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
	/// and the vtkPolygon methods are called.
	/// </summary>
	public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
	{
		vtkQuadraticPolygon_Contour_04(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), verts?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticPolygon_Derivatives_05(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

	/// <summary>
	/// These methods are based on the vtkPolygon ones :
	/// the vtkQuadraticPolygon (with n edges and 2*n points)
	/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
	/// and the vtkPolygon methods are called.
	/// </summary>
	public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
	{
		vtkQuadraticPolygon_Derivatives_05(GetCppThis(), subId, pcoords, values, dim, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuadraticPolygon_DistanceToPolygon_06(IntPtr x, int numPts, IntPtr pts, IntPtr bounds, IntPtr closest);

	/// <summary>
	/// These methods are based on the vtkPolygon ones :
	/// the vtkQuadraticPolygon (with n edges and 2*n points)
	/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
	/// and the vtkPolygon methods are called.
	/// </summary>
	public static double DistanceToPolygon(IntPtr x, int numPts, IntPtr pts, IntPtr bounds, IntPtr closest)
	{
		return vtkQuadraticPolygon_DistanceToPolygon_06(x, numPts, pts, bounds, closest);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticPolygon_EvaluateLocation_07(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

	/// <summary>
	/// These methods are based on the vtkPolygon ones :
	/// the vtkQuadraticPolygon (with n edges and 2*n points)
	/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
	/// and the vtkPolygon methods are called.
	/// </summary>
	public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
	{
		vtkQuadraticPolygon_EvaluateLocation_07(GetCppThis(), ref subId, pcoords, x, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticPolygon_EvaluatePosition_08(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

	/// <summary>
	/// These methods are based on the vtkPolygon ones :
	/// the vtkQuadraticPolygon (with n edges and 2*n points)
	/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
	/// and the vtkPolygon methods are called.
	/// </summary>
	public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
	{
		return vtkQuadraticPolygon_EvaluatePosition_08(GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticPolygon_GetCellDimension_09(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int GetCellDimension()
	{
		return vtkQuadraticPolygon_GetCellDimension_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticPolygon_GetCellType_10(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int GetCellType()
	{
		return vtkQuadraticPolygon_GetCellType_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadraticPolygon_GetEdge_11(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkQuadraticPolygon_GetEdge_11(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkQuadraticPolygon_GetFace_12(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkQuadraticPolygon_GetFace_12(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkQuadraticPolygon_GetNumberOfEdges_13(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int GetNumberOfEdges()
	{
		return vtkQuadraticPolygon_GetNumberOfEdges_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticPolygon_GetNumberOfFaces_14(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int GetNumberOfFaces()
	{
		return vtkQuadraticPolygon_GetNumberOfFaces_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkQuadraticPolygon_GetNumberOfGenerationsFromBase_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkQuadraticPolygon_GetNumberOfGenerationsFromBase_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkQuadraticPolygon_GetNumberOfGenerationsFromBaseType_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkQuadraticPolygon_GetNumberOfGenerationsFromBaseType_16(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkQuadraticPolygon_GetUseMVCInterpolation_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag indicating whether to use Mean Value Coordinate for the
	/// interpolation. If true, InterpolateFunctions() uses the Mean Value
	/// Coordinate to compute weights. Otherwise, the conventional 1/r^2 method
	/// is used. The UseMVCInterpolation parameter is set to true by default.
	/// </summary>
	public virtual bool GetUseMVCInterpolation()
	{
		return (vtkQuadraticPolygon_GetUseMVCInterpolation_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticPolygon_InterpolateFunctions_18(HandleRef pThis, IntPtr x, IntPtr weights);

	/// <summary>
	/// These methods are based on the vtkPolygon ones :
	/// the vtkQuadraticPolygon (with n edges and 2*n points)
	/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
	/// and the vtkPolygon methods are called.
	/// </summary>
	public override void InterpolateFunctions(IntPtr x, IntPtr weights)
	{
		vtkQuadraticPolygon_InterpolateFunctions_18(GetCppThis(), x, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticPolygon_IntersectConvex2DCells_19(HandleRef cell1, HandleRef cell2, double tol, IntPtr p0, IntPtr p1);

	/// <summary>
	/// These methods are based on the vtkPolygon ones :
	/// the vtkQuadraticPolygon (with n edges and 2*n points)
	/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
	/// and the vtkPolygon methods are called.
	/// </summary>
	public static int IntersectConvex2DCells(vtkCell cell1, vtkCell cell2, double tol, IntPtr p0, IntPtr p1)
	{
		return vtkQuadraticPolygon_IntersectConvex2DCells_19(cell1?.GetCppThis() ?? default(HandleRef), cell2?.GetCppThis() ?? default(HandleRef), tol, p0, p1);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticPolygon_IntersectPolygonWithPolygon_20(int npts, IntPtr pts, IntPtr bounds, int npts2, IntPtr pts2, IntPtr bounds2, double tol, IntPtr x);

	/// <summary>
	/// These methods are based on the vtkPolygon ones :
	/// the vtkQuadraticPolygon (with n edges and 2*n points)
	/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
	/// and the vtkPolygon methods are called.
	/// </summary>
	public static int IntersectPolygonWithPolygon(int npts, IntPtr pts, IntPtr bounds, int npts2, IntPtr pts2, IntPtr bounds2, double tol, IntPtr x)
	{
		return vtkQuadraticPolygon_IntersectPolygonWithPolygon_20(npts, pts, bounds, npts2, pts2, bounds2, tol, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticPolygon_IntersectWithLine_21(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

	/// <summary>
	/// These methods are based on the vtkPolygon ones :
	/// the vtkQuadraticPolygon (with n edges and 2*n points)
	/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
	/// and the vtkPolygon methods are called.
	/// </summary>
	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
	{
		return vtkQuadraticPolygon_IntersectWithLine_21(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticPolygon_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkQuadraticPolygon_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticPolygon_IsPrimaryCell_23(HandleRef pThis);

	/// <summary>
	/// Implement the vtkCell API. See the vtkCell API for descriptions
	/// of these methods.
	/// </summary>
	public override int IsPrimaryCell()
	{
		return vtkQuadraticPolygon_IsPrimaryCell_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticPolygon_IsTypeOf_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkQuadraticPolygon_IsTypeOf_24(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadraticPolygon_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkQuadraticPolygon NewInstance()
	{
		vtkQuadraticPolygon result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadraticPolygon_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkQuadraticPolygon)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticPolygon_NonDegenerateTriangulate_27(HandleRef pThis, HandleRef outTris);

	/// <summary>
	/// These methods are based on the vtkPolygon ones :
	/// the vtkQuadraticPolygon (with n edges and 2*n points)
	/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
	/// and the vtkPolygon methods are called.
	/// </summary>
	public int NonDegenerateTriangulate(vtkIdList outTris)
	{
		return vtkQuadraticPolygon_NonDegenerateTriangulate_27(GetCppThis(), outTris?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticPolygon_ParameterizePolygon_28(HandleRef pThis, IntPtr p0, IntPtr p10, ref double l10, IntPtr p20, ref double l20, IntPtr n);

	/// <summary>
	/// These methods are based on the vtkPolygon ones :
	/// the vtkQuadraticPolygon (with n edges and 2*n points)
	/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
	/// and the vtkPolygon methods are called.
	/// </summary>
	public int ParameterizePolygon(IntPtr p0, IntPtr p10, ref double l10, IntPtr p20, ref double l20, IntPtr n)
	{
		return vtkQuadraticPolygon_ParameterizePolygon_28(GetCppThis(), p0, p10, ref l10, p20, ref l20, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticPolygon_PointInPolygon_29(IntPtr x, int numPts, IntPtr pts, IntPtr bounds, IntPtr n);

	/// <summary>
	/// These methods are based on the vtkPolygon ones :
	/// the vtkQuadraticPolygon (with n edges and 2*n points)
	/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
	/// and the vtkPolygon methods are called.
	/// </summary>
	public static int PointInPolygon(IntPtr x, int numPts, IntPtr pts, IntPtr bounds, IntPtr n)
	{
		return vtkQuadraticPolygon_PointInPolygon_29(x, numPts, pts, bounds, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadraticPolygon_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkQuadraticPolygon SafeDownCast(vtkObjectBase o)
	{
		vtkQuadraticPolygon vtkQuadraticPolygon2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadraticPolygon_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkQuadraticPolygon2 = (vtkQuadraticPolygon)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkQuadraticPolygon2.Register(null);
			}
		}
		return vtkQuadraticPolygon2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadraticPolygon_SetUseMVCInterpolation_31(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the flag indicating whether to use Mean Value Coordinate for the
	/// interpolation. If true, InterpolateFunctions() uses the Mean Value
	/// Coordinate to compute weights. Otherwise, the conventional 1/r^2 method
	/// is used. The UseMVCInterpolation parameter is set to true by default.
	/// </summary>
	public virtual void SetUseMVCInterpolation(bool _arg)
	{
		vtkQuadraticPolygon_SetUseMVCInterpolation_31(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticPolygon_Triangulate_32(HandleRef pThis, HandleRef outTris);

	/// <summary>
	/// These methods are based on the vtkPolygon ones :
	/// the vtkQuadraticPolygon (with n edges and 2*n points)
	/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
	/// and the vtkPolygon methods are called.
	/// </summary>
	public int Triangulate(vtkIdList outTris)
	{
		return vtkQuadraticPolygon_Triangulate_32(GetCppThis(), outTris?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadraticPolygon_Triangulate_33(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

	/// <summary>
	/// These methods are based on the vtkPolygon ones :
	/// the vtkQuadraticPolygon (with n edges and 2*n points)
	/// is transform into a vtkPolygon (with 2*n edges and 2*n points)
	/// and the vtkPolygon methods are called.
	/// </summary>
	public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
	{
		return vtkQuadraticPolygon_Triangulate_33(GetCppThis(), index, ptIds?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef));
	}
}
