using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkLagrangeInterpolation : vtkHigherOrderInterpolation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLagrangeInterpolation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLagrangeInterpolation()
	{
		MRClassNameKey = "class vtkLagrangeInterpolation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLagrangeInterpolation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLagrangeInterpolation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangeInterpolation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkLagrangeInterpolation New()
	{
		vtkLagrangeInterpolation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangeInterpolation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLagrangeInterpolation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	public vtkLagrangeInterpolation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLagrangeInterpolation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkLagrangeInterpolation_EvaluateShapeAndGradient_01(int order, double pcoord, IntPtr shape, IntPtr grad);

	public static void EvaluateShapeAndGradient(int order, double pcoord, IntPtr shape, IntPtr grad)
	{
		vtkLagrangeInterpolation_EvaluateShapeAndGradient_01(order, pcoord, shape, grad);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangeInterpolation_EvaluateShapeFunctions_02(int order, double pcoord, IntPtr shape);

	public static void EvaluateShapeFunctions(int order, double pcoord, IntPtr shape)
	{
		vtkLagrangeInterpolation_EvaluateShapeFunctions_02(order, pcoord, shape);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLagrangeInterpolation_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLagrangeInterpolation_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLagrangeInterpolation_GetNumberOfGenerationsFromBaseType_04(string type);

	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLagrangeInterpolation_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLagrangeInterpolation_IsA_05(HandleRef pThis, string type);

	public override int IsA(string type)
	{
		return vtkLagrangeInterpolation_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLagrangeInterpolation_IsTypeOf_06(string type);

	public new static int IsTypeOf(string type)
	{
		return vtkLagrangeInterpolation_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangeInterpolation_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new vtkLagrangeInterpolation NewInstance()
	{
		vtkLagrangeInterpolation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangeInterpolation_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLagrangeInterpolation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLagrangeInterpolation_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkLagrangeInterpolation SafeDownCast(vtkObjectBase o)
	{
		vtkLagrangeInterpolation vtkLagrangeInterpolation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLagrangeInterpolation_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLagrangeInterpolation2 = (vtkLagrangeInterpolation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLagrangeInterpolation2.Register(null);
			}
		}
		return vtkLagrangeInterpolation2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLagrangeInterpolation_Tensor1ShapeDerivatives_10(IntPtr order, IntPtr pcoords, IntPtr derivs);

	public static int Tensor1ShapeDerivatives(IntPtr order, IntPtr pcoords, IntPtr derivs)
	{
		return vtkLagrangeInterpolation_Tensor1ShapeDerivatives_10(order, pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLagrangeInterpolation_Tensor1ShapeFunctions_11(IntPtr order, IntPtr pcoords, IntPtr shape);

	public static int Tensor1ShapeFunctions(IntPtr order, IntPtr pcoords, IntPtr shape)
	{
		return vtkLagrangeInterpolation_Tensor1ShapeFunctions_11(order, pcoords, shape);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLagrangeInterpolation_Tensor2ShapeDerivatives_12(IntPtr order, IntPtr pcoords, IntPtr derivs);

	public static int Tensor2ShapeDerivatives(IntPtr order, IntPtr pcoords, IntPtr derivs)
	{
		return vtkLagrangeInterpolation_Tensor2ShapeDerivatives_12(order, pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLagrangeInterpolation_Tensor2ShapeFunctions_13(IntPtr order, IntPtr pcoords, IntPtr shape);

	public static int Tensor2ShapeFunctions(IntPtr order, IntPtr pcoords, IntPtr shape)
	{
		return vtkLagrangeInterpolation_Tensor2ShapeFunctions_13(order, pcoords, shape);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangeInterpolation_Tensor3EvaluateDerivative_14(HandleRef pThis, IntPtr order, IntPtr pcoords, HandleRef points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs);

	public override void Tensor3EvaluateDerivative(IntPtr order, IntPtr pcoords, vtkPoints points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs)
	{
		vtkLagrangeInterpolation_Tensor3EvaluateDerivative_14(GetCppThis(), order, pcoords, points?.GetCppThis() ?? default(HandleRef), fieldVals, fieldDim, fieldDerivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLagrangeInterpolation_Tensor3ShapeDerivatives_15(IntPtr order, IntPtr pcoords, IntPtr derivs);

	public static int Tensor3ShapeDerivatives(IntPtr order, IntPtr pcoords, IntPtr derivs)
	{
		return vtkLagrangeInterpolation_Tensor3ShapeDerivatives_15(order, pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLagrangeInterpolation_Tensor3ShapeFunctions_16(IntPtr order, IntPtr pcoords, IntPtr shape);

	public static int Tensor3ShapeFunctions(IntPtr order, IntPtr pcoords, IntPtr shape)
	{
		return vtkLagrangeInterpolation_Tensor3ShapeFunctions_16(order, pcoords, shape);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangeInterpolation_WedgeEvaluate_17(HandleRef pThis, IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr fieldVals, int fieldDim, IntPtr fieldAtPCoords);

	public override void WedgeEvaluate(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr fieldVals, int fieldDim, IntPtr fieldAtPCoords)
	{
		vtkLagrangeInterpolation_WedgeEvaluate_17(GetCppThis(), order, numberOfPoints, pcoords, fieldVals, fieldDim, fieldAtPCoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangeInterpolation_WedgeEvaluateDerivative_18(HandleRef pThis, IntPtr order, IntPtr pcoords, HandleRef points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs);

	public override void WedgeEvaluateDerivative(IntPtr order, IntPtr pcoords, vtkPoints points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs)
	{
		vtkLagrangeInterpolation_WedgeEvaluateDerivative_18(GetCppThis(), order, pcoords, points?.GetCppThis() ?? default(HandleRef), fieldVals, fieldDim, fieldDerivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangeInterpolation_WedgeShapeDerivatives_19(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr derivs);

	public static void WedgeShapeDerivatives(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr derivs)
	{
		vtkLagrangeInterpolation_WedgeShapeDerivatives_19(order, numberOfPoints, pcoords, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLagrangeInterpolation_WedgeShapeFunctions_20(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr shape);

	public static void WedgeShapeFunctions(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr shape)
	{
		vtkLagrangeInterpolation_WedgeShapeFunctions_20(order, numberOfPoints, pcoords, shape);
	}
}
