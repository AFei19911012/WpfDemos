using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkBezierInterpolation : vtkHigherOrderInterpolation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBezierInterpolation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBezierInterpolation()
	{
		MRClassNameKey = "class vtkBezierInterpolation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBezierInterpolation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBezierInterpolation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBezierInterpolation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkBezierInterpolation New()
	{
		vtkBezierInterpolation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBezierInterpolation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBezierInterpolation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	public vtkBezierInterpolation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBezierInterpolation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBezierInterpolation_DeCasteljauSimplex_01(int dim, int deg, IntPtr pcoords, IntPtr weights);

	public static void DeCasteljauSimplex(int dim, int deg, IntPtr pcoords, IntPtr weights)
	{
		vtkBezierInterpolation_DeCasteljauSimplex_01(dim, deg, pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBezierInterpolation_DeCasteljauSimplexDeriv_02(int dim, int deg, IntPtr pcoords, IntPtr weights);

	public static void DeCasteljauSimplexDeriv(int dim, int deg, IntPtr pcoords, IntPtr weights)
	{
		vtkBezierInterpolation_DeCasteljauSimplexDeriv_02(dim, deg, pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBezierInterpolation_EvaluateShapeAndGradient_03(int order, double pcoord, IntPtr shape, IntPtr grad);

	public static void EvaluateShapeAndGradient(int order, double pcoord, IntPtr shape, IntPtr grad)
	{
		vtkBezierInterpolation_EvaluateShapeAndGradient_03(order, pcoord, shape, grad);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBezierInterpolation_EvaluateShapeFunctions_04(int order, double pcoord, IntPtr shape);

	public static void EvaluateShapeFunctions(int order, double pcoord, IntPtr shape)
	{
		vtkBezierInterpolation_EvaluateShapeFunctions_04(order, pcoord, shape);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBezierInterpolation_FlattenSimplex_05(int dim, int deg, vtkVector3i coord);

	public static int FlattenSimplex(int dim, int deg, vtkVector3i coord)
	{
		return vtkBezierInterpolation_FlattenSimplex_05(dim, deg, coord);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBezierInterpolation_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBezierInterpolation_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBezierInterpolation_GetNumberOfGenerationsFromBaseType_07(string type);

	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBezierInterpolation_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBezierInterpolation_IsA_08(HandleRef pThis, string type);

	public override int IsA(string type)
	{
		return vtkBezierInterpolation_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBezierInterpolation_IsTypeOf_09(string type);

	public new static int IsTypeOf(string type)
	{
		return vtkBezierInterpolation_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBezierInterpolation_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new vtkBezierInterpolation NewInstance()
	{
		vtkBezierInterpolation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBezierInterpolation_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBezierInterpolation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBezierInterpolation_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkBezierInterpolation SafeDownCast(vtkObjectBase o)
	{
		vtkBezierInterpolation vtkBezierInterpolation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBezierInterpolation_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBezierInterpolation2 = (vtkBezierInterpolation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBezierInterpolation2.Register(null);
			}
		}
		return vtkBezierInterpolation2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBezierInterpolation_Tensor1ShapeDerivatives_13(IntPtr order, IntPtr pcoords, IntPtr derivs);

	public static int Tensor1ShapeDerivatives(IntPtr order, IntPtr pcoords, IntPtr derivs)
	{
		return vtkBezierInterpolation_Tensor1ShapeDerivatives_13(order, pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBezierInterpolation_Tensor1ShapeFunctions_14(IntPtr order, IntPtr pcoords, IntPtr shape);

	public static int Tensor1ShapeFunctions(IntPtr order, IntPtr pcoords, IntPtr shape)
	{
		return vtkBezierInterpolation_Tensor1ShapeFunctions_14(order, pcoords, shape);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBezierInterpolation_Tensor2ShapeDerivatives_15(IntPtr order, IntPtr pcoords, IntPtr derivs);

	public static int Tensor2ShapeDerivatives(IntPtr order, IntPtr pcoords, IntPtr derivs)
	{
		return vtkBezierInterpolation_Tensor2ShapeDerivatives_15(order, pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBezierInterpolation_Tensor2ShapeFunctions_16(IntPtr order, IntPtr pcoords, IntPtr shape);

	public static int Tensor2ShapeFunctions(IntPtr order, IntPtr pcoords, IntPtr shape)
	{
		return vtkBezierInterpolation_Tensor2ShapeFunctions_16(order, pcoords, shape);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBezierInterpolation_Tensor3EvaluateDerivative_17(HandleRef pThis, IntPtr order, IntPtr pcoords, HandleRef points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs);

	public override void Tensor3EvaluateDerivative(IntPtr order, IntPtr pcoords, vtkPoints points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs)
	{
		vtkBezierInterpolation_Tensor3EvaluateDerivative_17(GetCppThis(), order, pcoords, points?.GetCppThis() ?? default(HandleRef), fieldVals, fieldDim, fieldDerivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBezierInterpolation_Tensor3ShapeDerivatives_18(IntPtr order, IntPtr pcoords, IntPtr derivs);

	public static int Tensor3ShapeDerivatives(IntPtr order, IntPtr pcoords, IntPtr derivs)
	{
		return vtkBezierInterpolation_Tensor3ShapeDerivatives_18(order, pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBezierInterpolation_Tensor3ShapeFunctions_19(IntPtr order, IntPtr pcoords, IntPtr shape);

	public static int Tensor3ShapeFunctions(IntPtr order, IntPtr pcoords, IntPtr shape)
	{
		return vtkBezierInterpolation_Tensor3ShapeFunctions_19(order, pcoords, shape);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkVector3i vtkBezierInterpolation_UnFlattenSimplex_20(int dim, int deg, long flat);

	public static vtkVector3i UnFlattenSimplex(int dim, int deg, long flat)
	{
		return vtkBezierInterpolation_UnFlattenSimplex_20(dim, deg, flat);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBezierInterpolation_WedgeEvaluate_21(HandleRef pThis, IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr fieldVals, int fieldDim, IntPtr fieldAtPCoords);

	public override void WedgeEvaluate(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr fieldVals, int fieldDim, IntPtr fieldAtPCoords)
	{
		vtkBezierInterpolation_WedgeEvaluate_21(GetCppThis(), order, numberOfPoints, pcoords, fieldVals, fieldDim, fieldAtPCoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBezierInterpolation_WedgeEvaluateDerivative_22(HandleRef pThis, IntPtr order, IntPtr pcoords, HandleRef points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs);

	public override void WedgeEvaluateDerivative(IntPtr order, IntPtr pcoords, vtkPoints points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs)
	{
		vtkBezierInterpolation_WedgeEvaluateDerivative_22(GetCppThis(), order, pcoords, points?.GetCppThis() ?? default(HandleRef), fieldVals, fieldDim, fieldDerivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBezierInterpolation_WedgeShapeDerivatives_23(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr derivs);

	public static void WedgeShapeDerivatives(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr derivs)
	{
		vtkBezierInterpolation_WedgeShapeDerivatives_23(order, numberOfPoints, pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBezierInterpolation_WedgeShapeFunctions_24(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr shape);

	public static void WedgeShapeFunctions(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr shape)
	{
		vtkBezierInterpolation_WedgeShapeFunctions_24(order, numberOfPoints, pcoords, shape);
	}
}
