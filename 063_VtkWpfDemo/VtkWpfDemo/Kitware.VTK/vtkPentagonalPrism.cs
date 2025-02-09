using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPentagonalPrism
/// </summary>
/// <remarks>
///    a 3D cell that represents a convex prism with
/// pentagonal base
///
/// vtkPentagonalPrism is a concrete implementation of vtkCell to represent a
/// linear convex 3D prism with pentagonal base. Such prism is defined by the
/// ten points (0-9), where (0,1,2,3,4) is the base of the prism which, using
/// the right hand rule, forms a pentagon whose normal points is in the direction
/// of the opposite face (5,6,7,8,9).
///
/// @par Thanks:
/// Thanks to Philippe Guerville who developed this class.
/// Thanks to Charles Pignerol (CEA-DAM, France) who ported this class under
/// VTK 4. &lt;br&gt;
/// Thanks to Jean Favre (CSCS, Switzerland) who contributed to integrate this
/// class in VTK. &lt;br&gt;
/// Please address all comments to Jean Favre (jfavre at cscs.ch).
///
/// @par Thanks:
/// The Interpolation functions and derivatives were changed in June
/// 2015 by Bill Lorensen. These changes follow the formulation in:
/// http://dilbert.engr.ucdavis.edu/~suku/nem/papers/polyelas.pdf
/// NOTE: An additional copy of this paper is located at:
/// http://www.vtk.org/Wiki/File:ApplicationOfPolygonalFiniteElementsInLinearElasticity.pdf
/// </remarks>
public class vtkPentagonalPrism : vtkCell3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPentagonalPrism";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPentagonalPrism()
	{
		MRClassNameKey = "class vtkPentagonalPrism";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPentagonalPrism"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPentagonalPrism(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPentagonalPrism_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPentagonalPrism New()
	{
		vtkPentagonalPrism result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPentagonalPrism_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPentagonalPrism)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPentagonalPrism()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPentagonalPrism_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPentagonalPrism_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

	/// <summary>
	/// See the vtkCell3D API for descriptions of these methods.
	/// </summary>
	public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
	{
		return vtkPentagonalPrism_CellBoundary_01(GetCppThis(), subId, pcoords, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPentagonalPrism_ComputeCentroid_02(HandleRef points, IntPtr pointIds, IntPtr centroid);

	/// <summary>
	/// Static method version of GetCentroid.
	/// </summary>
	public static bool ComputeCentroid(vtkPoints points, IntPtr pointIds, IntPtr centroid)
	{
		return (vtkPentagonalPrism_ComputeCentroid_02(points?.GetCppThis() ?? default(HandleRef), pointIds, centroid) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPentagonalPrism_Derivatives_03(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

	/// <summary>
	/// See the vtkCell3D API for descriptions of these methods.
	/// </summary>
	public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
	{
		vtkPentagonalPrism_Derivatives_03(GetCppThis(), subId, pcoords, values, dim, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPentagonalPrism_EvaluateLocation_04(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

	/// <summary>
	/// See the vtkCell3D API for descriptions of these methods.
	/// </summary>
	public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
	{
		vtkPentagonalPrism_EvaluateLocation_04(GetCppThis(), ref subId, pcoords, x, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPentagonalPrism_EvaluatePosition_05(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

	/// <summary>
	/// See the vtkCell3D API for descriptions of these methods.
	/// </summary>
	public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
	{
		return vtkPentagonalPrism_EvaluatePosition_05(GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPentagonalPrism_GetCellDimension_06(HandleRef pThis);

	/// <summary>
	/// See the vtkCell3D API for descriptions of these methods.
	/// </summary>
	public override int GetCellDimension()
	{
		return vtkPentagonalPrism_GetCellDimension_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPentagonalPrism_GetCellType_07(HandleRef pThis);

	/// <summary>
	/// See the vtkCell3D API for descriptions of these methods.
	/// </summary>
	public override int GetCellType()
	{
		return vtkPentagonalPrism_GetCellType_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPentagonalPrism_GetCentroid_08(HandleRef pThis, IntPtr centroid);

	/// <summary>
	/// See vtkCell3D API for description of these methods.
	/// </summary>
	public override bool GetCentroid(IntPtr centroid)
	{
		return (vtkPentagonalPrism_GetCentroid_08(GetCppThis(), centroid) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPentagonalPrism_GetEdge_09(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// See the vtkCell3D API for descriptions of these methods.
	/// </summary>
	public override vtkCell GetEdge(int edgeId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPentagonalPrism_GetEdge_09(GetCppThis(), edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPentagonalPrism_GetEdgeArray_10(long edgeId);

	/// <summary>
	/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
	/// Ids are related to the cell, not to the dataset.
	///
	/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
	/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
	/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
	/// </summary>
	public static IntPtr GetEdgeArray(long edgeId)
	{
		return vtkPentagonalPrism_GetEdgeArray_10(edgeId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPentagonalPrism_GetEdgeToAdjacentFacesArray_11(long edgeId);

	/// <summary>
	/// Static method version of GetEdgeToAdjacentFaces.
	/// </summary>
	public static IntPtr GetEdgeToAdjacentFacesArray(long edgeId)
	{
		return vtkPentagonalPrism_GetEdgeToAdjacentFacesArray_11(edgeId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPentagonalPrism_GetFace_12(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// See the vtkCell3D API for descriptions of these methods.
	/// </summary>
	public override vtkCell GetFace(int faceId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPentagonalPrism_GetFace_12(GetCppThis(), faceId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPentagonalPrism_GetFaceArray_13(long faceId);

	/// <summary>
	/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
	/// Ids are related to the cell, not to the dataset.
	///
	/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
	/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
	/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
	/// </summary>
	public static IntPtr GetFaceArray(long faceId)
	{
		return vtkPentagonalPrism_GetFaceArray_13(faceId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPentagonalPrism_GetFaceToAdjacentFacesArray_14(long faceId);

	/// <summary>
	/// Static method version of GetFaceToAdjacentFaces.
	/// </summary>
	public static IntPtr GetFaceToAdjacentFacesArray(long faceId)
	{
		return vtkPentagonalPrism_GetFaceToAdjacentFacesArray_14(faceId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPentagonalPrism_GetNumberOfEdges_15(HandleRef pThis);

	/// <summary>
	/// See the vtkCell3D API for descriptions of these methods.
	/// </summary>
	public override int GetNumberOfEdges()
	{
		return vtkPentagonalPrism_GetNumberOfEdges_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPentagonalPrism_GetNumberOfFaces_16(HandleRef pThis);

	/// <summary>
	/// See the vtkCell3D API for descriptions of these methods.
	/// </summary>
	public override int GetNumberOfFaces()
	{
		return vtkPentagonalPrism_GetNumberOfFaces_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPentagonalPrism_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPentagonalPrism_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPentagonalPrism_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPentagonalPrism_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPentagonalPrism_GetParametricCenter_19(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	/// Return the center of the wedge in parametric coordinates.
	/// </summary>
	public override int GetParametricCenter(IntPtr pcoords)
	{
		return vtkPentagonalPrism_GetParametricCenter_19(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPentagonalPrism_GetParametricCoords_20(HandleRef pThis);

	/// <summary>
	/// See the vtkCell3D API for descriptions of these methods.
	/// </summary>
	public override IntPtr GetParametricCoords()
	{
		return vtkPentagonalPrism_GetParametricCoords_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPentagonalPrism_GetPointToIncidentEdgesArray_21(long pointId);

	/// <summary>
	/// Static method version of GetPointToIncidentEdgesArray.
	/// </summary>
	public static IntPtr GetPointToIncidentEdgesArray(long pointId)
	{
		return vtkPentagonalPrism_GetPointToIncidentEdgesArray_21(pointId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPentagonalPrism_GetPointToIncidentFacesArray_22(long pointId);

	/// <summary>
	/// Static method version of GetPointToIncidentFacesArray.
	/// </summary>
	public static IntPtr GetPointToIncidentFacesArray(long pointId)
	{
		return vtkPentagonalPrism_GetPointToIncidentFacesArray_22(pointId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPentagonalPrism_GetPointToOneRingPointsArray_23(long pointId);

	/// <summary>
	/// Static method version of GetPointToOneRingPoints.
	/// </summary>
	public static IntPtr GetPointToOneRingPointsArray(long pointId)
	{
		return vtkPentagonalPrism_GetPointToOneRingPointsArray_23(pointId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPentagonalPrism_InterpolateDerivs_24(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// </summary>
	public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkPentagonalPrism_InterpolateDerivs_24(GetCppThis(), pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPentagonalPrism_InterpolateFunctions_25(HandleRef pThis, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// </summary>
	public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
	{
		vtkPentagonalPrism_InterpolateFunctions_25(GetCppThis(), pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPentagonalPrism_InterpolationDerivs_26(IntPtr pcoords, IntPtr derivs);

	/// <summary>
	/// Return the center of the wedge in parametric coordinates.
	/// </summary>
	public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
	{
		vtkPentagonalPrism_InterpolationDerivs_26(pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPentagonalPrism_InterpolationFunctions_27(IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Return the center of the wedge in parametric coordinates.
	/// </summary>
	public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
	{
		vtkPentagonalPrism_InterpolationFunctions_27(pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPentagonalPrism_IntersectWithLine_28(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

	/// <summary>
	/// See the vtkCell3D API for descriptions of these methods.
	/// </summary>
	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
	{
		return vtkPentagonalPrism_IntersectWithLine_28(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPentagonalPrism_IsA_29(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPentagonalPrism_IsA_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPentagonalPrism_IsInsideOut_30(HandleRef pThis);

	/// <summary>
	/// See vtkCell3D API for description of these methods.
	/// </summary>
	public override bool IsInsideOut()
	{
		return (vtkPentagonalPrism_IsInsideOut_30(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPentagonalPrism_IsTypeOf_31(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPentagonalPrism_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPentagonalPrism_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPentagonalPrism NewInstance()
	{
		vtkPentagonalPrism result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPentagonalPrism_NewInstance_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPentagonalPrism)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPentagonalPrism_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPentagonalPrism SafeDownCast(vtkObjectBase o)
	{
		vtkPentagonalPrism vtkPentagonalPrism2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPentagonalPrism_SafeDownCast_34(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPentagonalPrism2 = (vtkPentagonalPrism)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPentagonalPrism2.Register(null);
			}
		}
		return vtkPentagonalPrism2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPentagonalPrism_Triangulate_35(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

	/// <summary>
	/// See the vtkCell3D API for descriptions of these methods.
	/// </summary>
	public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
	{
		return vtkPentagonalPrism_Triangulate_35(GetCppThis(), index, ptIds?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef));
	}
}
