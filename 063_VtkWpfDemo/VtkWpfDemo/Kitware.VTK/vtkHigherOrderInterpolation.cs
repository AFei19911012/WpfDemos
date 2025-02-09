using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
/// </summary>
public abstract class vtkHigherOrderInterpolation : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHigherOrderInterpolation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHigherOrderInterpolation()
	{
		MRClassNameKey = "class vtkHigherOrderInterpolation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHigherOrderInterpolation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHigherOrderInterpolation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern IntPtr vtkHigherOrderInterpolation_GetEdgeIndicesBoundingHexFace_01(int faceId);

	/// <summary>
	/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
	/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
	/// </summary>
	public static IntPtr GetEdgeIndicesBoundingHexFace(int faceId)
	{
		return vtkHigherOrderInterpolation_GetEdgeIndicesBoundingHexFace_01(faceId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderInterpolation_GetEdgeIndicesBoundingWedgeFace_02(int faceId);

	/// <summary>
	/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
	/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
	/// </summary>
	public static IntPtr GetEdgeIndicesBoundingWedgeFace(int faceId)
	{
		return vtkHigherOrderInterpolation_GetEdgeIndicesBoundingWedgeFace_02(faceId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderInterpolation_GetFixedParameterOfHexFace_03(int faceId);

	/// <summary>
	/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
	/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
	/// </summary>
	public static int GetFixedParameterOfHexFace(int faceId)
	{
		return vtkHigherOrderInterpolation_GetFixedParameterOfHexFace_03(faceId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderInterpolation_GetFixedParameterOfWedgeFace_04(int faceId);

	/// <summary>
	/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
	/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
	/// </summary>
	public static int GetFixedParameterOfWedgeFace(int faceId)
	{
		return vtkHigherOrderInterpolation_GetFixedParameterOfWedgeFace_04(faceId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderInterpolation_GetFixedParametersOfHexEdge_05(int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
	/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
	/// </summary>
	public static vtkVector2i GetFixedParametersOfHexEdge(int edgeId)
	{
		vtkVector2i result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderInterpolation_GetFixedParametersOfHexEdge_05(edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderInterpolation_GetFixedParametersOfWedgeEdge_06(int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
	/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
	/// </summary>
	public static vtkVector2i GetFixedParametersOfWedgeEdge(int edgeId)
	{
		vtkVector2i result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderInterpolation_GetFixedParametersOfWedgeEdge_06(edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHigherOrderInterpolation_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHigherOrderInterpolation_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHigherOrderInterpolation_GetNumberOfGenerationsFromBaseType_08(string type);

	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHigherOrderInterpolation_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderInterpolation_GetParametricHexCoordinates_09(int vertexId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
	/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
	/// </summary>
	public static vtkVector3d GetParametricHexCoordinates(int vertexId)
	{
		vtkVector3d result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderInterpolation_GetParametricHexCoordinates_09(vertexId, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector3d)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderInterpolation_GetParametricWedgeCoordinates_10(int vertexId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
	/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
	/// </summary>
	public static vtkVector3d GetParametricWedgeCoordinates(int vertexId)
	{
		vtkVector3d result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderInterpolation_GetParametricWedgeCoordinates_10(vertexId, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector3d)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderInterpolation_GetPointIndicesBoundingHexEdge_11(int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
	/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
	/// </summary>
	public static vtkVector2i GetPointIndicesBoundingHexEdge(int edgeId)
	{
		vtkVector2i result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderInterpolation_GetPointIndicesBoundingHexEdge_11(edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderInterpolation_GetPointIndicesBoundingHexFace_12(int faceId);

	/// <summary>
	/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
	/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
	/// </summary>
	public static IntPtr GetPointIndicesBoundingHexFace(int faceId)
	{
		return vtkHigherOrderInterpolation_GetPointIndicesBoundingHexFace_12(faceId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderInterpolation_GetPointIndicesBoundingWedgeEdge_13(int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
	/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
	/// </summary>
	public static vtkVector2i GetPointIndicesBoundingWedgeEdge(int edgeId)
	{
		vtkVector2i result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderInterpolation_GetPointIndicesBoundingWedgeEdge_13(edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderInterpolation_GetPointIndicesBoundingWedgeFace_14(int faceId);

	/// <summary>
	/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
	/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
	/// </summary>
	public static IntPtr GetPointIndicesBoundingWedgeFace(int faceId)
	{
		return vtkHigherOrderInterpolation_GetPointIndicesBoundingWedgeFace_14(faceId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderInterpolation_GetVaryingParameterOfHexEdge_15(int edgeId);

	/// <summary>
	/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
	/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
	/// </summary>
	public static int GetVaryingParameterOfHexEdge(int edgeId)
	{
		return vtkHigherOrderInterpolation_GetVaryingParameterOfHexEdge_15(edgeId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderInterpolation_GetVaryingParameterOfWedgeEdge_16(int edgeId);

	/// <summary>
	/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
	/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
	/// </summary>
	public static int GetVaryingParameterOfWedgeEdge(int edgeId)
	{
		return vtkHigherOrderInterpolation_GetVaryingParameterOfWedgeEdge_16(edgeId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderInterpolation_GetVaryingParametersOfHexFace_17(int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
	/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
	/// </summary>
	public static vtkVector2i GetVaryingParametersOfHexFace(int faceId)
	{
		vtkVector2i result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderInterpolation_GetVaryingParametersOfHexFace_17(faceId, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderInterpolation_GetVaryingParametersOfWedgeFace_18(int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
	/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
	/// </summary>
	public static vtkVector2i GetVaryingParametersOfWedgeFace(int faceId)
	{
		vtkVector2i result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderInterpolation_GetVaryingParametersOfWedgeFace_18(faceId, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderInterpolation_IsA_19(HandleRef pThis, string type);

	public override int IsA(string type)
	{
		return vtkHigherOrderInterpolation_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHigherOrderInterpolation_IsTypeOf_20(string type);

	public new static int IsTypeOf(string type)
	{
		return vtkHigherOrderInterpolation_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderInterpolation_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new vtkHigherOrderInterpolation NewInstance()
	{
		vtkHigherOrderInterpolation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderInterpolation_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHigherOrderInterpolation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHigherOrderInterpolation_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkHigherOrderInterpolation SafeDownCast(vtkObjectBase o)
	{
		vtkHigherOrderInterpolation vtkHigherOrderInterpolation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHigherOrderInterpolation_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkHigherOrderInterpolation_Tensor3EvaluateDerivative_23(HandleRef pThis, IntPtr order, IntPtr pcoords, HandleRef points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs);

	public virtual void Tensor3EvaluateDerivative(IntPtr order, IntPtr pcoords, vtkPoints points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs)
	{
		vtkHigherOrderInterpolation_Tensor3EvaluateDerivative_23(GetCppThis(), order, pcoords, points?.GetCppThis() ?? default(HandleRef), fieldVals, fieldDim, fieldDerivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderInterpolation_WedgeEvaluate_24(HandleRef pThis, IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr fieldVals, int fieldDim, IntPtr fieldAtPCoords);

	/// <summary>
	/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
	/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
	/// </summary>
	public virtual void WedgeEvaluate(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr fieldVals, int fieldDim, IntPtr fieldAtPCoords)
	{
		vtkHigherOrderInterpolation_WedgeEvaluate_24(GetCppThis(), order, numberOfPoints, pcoords, fieldVals, fieldDim, fieldAtPCoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHigherOrderInterpolation_WedgeEvaluateDerivative_25(HandleRef pThis, IntPtr order, IntPtr pcoords, HandleRef points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs);

	/// <summary>
	/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
	/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
	/// </summary>
	public virtual void WedgeEvaluateDerivative(IntPtr order, IntPtr pcoords, vtkPoints points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs)
	{
		vtkHigherOrderInterpolation_WedgeEvaluateDerivative_25(GetCppThis(), order, pcoords, points?.GetCppThis() ?? default(HandleRef), fieldVals, fieldDim, fieldDerivs);
	}
}
