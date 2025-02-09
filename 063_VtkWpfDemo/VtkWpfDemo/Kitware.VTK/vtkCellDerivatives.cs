using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCellDerivatives
/// </summary>
/// <remarks>
///    compute derivatives of scalars and vectors
///
/// vtkCellDerivatives is a filter that computes derivatives of scalars
/// and vectors at the center of cells. You can choose to generate
/// different output including the scalar gradient (a vector), computed
/// tensor vorticity (a vector), gradient of input vectors (a tensor),
/// and strain matrix (linearized or Green-Lagrange) of the input vectors
/// (a tensor); or you may choose to pass data through to the output.
///
/// Note that it is assumed that on input scalars and vector point data
/// is available, which are then used to generate cell vectors and tensors.
/// (The interpolation functions of the cells are used to compute the
/// derivatives which is why point data is required.)
///
/// Note that the tensor components used to be sent out in column, but they
/// are now sent out not in row.
///
/// @warning
/// The computed derivatives are cell attribute data; you can convert them to
/// point attribute data by using the vtkCellDataToPointData filter.
/// Note that, due to the interpolation function used (obtained using
/// 1/r**2 normalized sum), the derivatives calculated for polygons
/// with more than 4 vertices are inaccurate in most cases.
///
/// @warning
/// The point data is passed through the filter to the output.
///
/// </remarks>
/// <seealso>
///
/// vtkVectorNorm
/// </seealso>
public class vtkCellDerivatives : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCellDerivatives";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCellDerivatives()
	{
		MRClassNameKey = "class vtkCellDerivatives";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellDerivatives"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCellDerivatives(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellDerivatives_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct to compute the gradient of the scalars and vectors.
	/// </summary>
	public new static vtkCellDerivatives New()
	{
		vtkCellDerivatives result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellDerivatives_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellDerivatives)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct to compute the gradient of the scalars and vectors.
	/// </summary>
	public vtkCellDerivatives()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCellDerivatives_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellDerivatives_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCellDerivatives_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellDerivatives_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCellDerivatives_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellDerivatives_GetTensorMode_03(HandleRef pThis);

	/// <summary>
	/// Control how the filter works to generate tensor cell data. You can
	/// choose to pass the input cell tensors, compute the gradient of
	/// the input vectors, or compute the strain tensor (linearized or
	/// Green-Lagrange strain)of the vector gradient tensor. By default
	/// (TensorModeToComputeGradient), the filter will take the gradient
	/// of the vector data to construct a tensor.
	/// </summary>
	public virtual int GetTensorMode()
	{
		return vtkCellDerivatives_GetTensorMode_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellDerivatives_GetTensorModeAsString_04(HandleRef pThis);

	/// <summary>
	/// Control how the filter works to generate tensor cell data. You can
	/// choose to pass the input cell tensors, compute the gradient of
	/// the input vectors, or compute the strain tensor (linearized or
	/// Green-Lagrange strain)of the vector gradient tensor. By default
	/// (TensorModeToComputeGradient), the filter will take the gradient
	/// of the vector data to construct a tensor.
	/// </summary>
	public string GetTensorModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkCellDerivatives_GetTensorModeAsString_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellDerivatives_GetVectorMode_05(HandleRef pThis);

	/// <summary>
	/// Control how the filter works to generate vector cell data. You
	/// can choose to pass the input cell vectors, compute the gradient
	/// of the input scalars, or extract the vorticity of the computed
	/// vector gradient tensor. By default (VectorModeToComputeGradient),
	/// the filter will take the gradient of the input scalar data.
	/// </summary>
	public virtual int GetVectorMode()
	{
		return vtkCellDerivatives_GetVectorMode_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellDerivatives_GetVectorModeAsString_06(HandleRef pThis);

	/// <summary>
	/// Control how the filter works to generate vector cell data. You
	/// can choose to pass the input cell vectors, compute the gradient
	/// of the input scalars, or extract the vorticity of the computed
	/// vector gradient tensor. By default (VectorModeToComputeGradient),
	/// the filter will take the gradient of the input scalar data.
	/// </summary>
	public string GetVectorModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkCellDerivatives_GetVectorModeAsString_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellDerivatives_IsA_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCellDerivatives_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellDerivatives_IsTypeOf_08(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCellDerivatives_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellDerivatives_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new vtkCellDerivatives NewInstance()
	{
		vtkCellDerivatives result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellDerivatives_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellDerivatives)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellDerivatives_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static vtkCellDerivatives SafeDownCast(vtkObjectBase o)
	{
		vtkCellDerivatives vtkCellDerivatives2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellDerivatives_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellDerivatives2 = (vtkCellDerivatives)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellDerivatives2.Register(null);
			}
		}
		return vtkCellDerivatives2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDerivatives_SetTensorMode_12(HandleRef pThis, int _arg);

	/// <summary>
	/// Control how the filter works to generate tensor cell data. You can
	/// choose to pass the input cell tensors, compute the gradient of
	/// the input vectors, or compute the strain tensor (linearized or
	/// Green-Lagrange strain)of the vector gradient tensor. By default
	/// (TensorModeToComputeGradient), the filter will take the gradient
	/// of the vector data to construct a tensor.
	/// </summary>
	public virtual void SetTensorMode(int _arg)
	{
		vtkCellDerivatives_SetTensorMode_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDerivatives_SetTensorModeToComputeGradient_13(HandleRef pThis);

	/// <summary>
	/// Control how the filter works to generate tensor cell data. You can
	/// choose to pass the input cell tensors, compute the gradient of
	/// the input vectors, or compute the strain tensor (linearized or
	/// Green-Lagrange strain)of the vector gradient tensor. By default
	/// (TensorModeToComputeGradient), the filter will take the gradient
	/// of the vector data to construct a tensor.
	/// </summary>
	public void SetTensorModeToComputeGradient()
	{
		vtkCellDerivatives_SetTensorModeToComputeGradient_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDerivatives_SetTensorModeToComputeGreenLagrangeStrain_14(HandleRef pThis);

	/// <summary>
	/// Control how the filter works to generate tensor cell data. You can
	/// choose to pass the input cell tensors, compute the gradient of
	/// the input vectors, or compute the strain tensor (linearized or
	/// Green-Lagrange strain)of the vector gradient tensor. By default
	/// (TensorModeToComputeGradient), the filter will take the gradient
	/// of the vector data to construct a tensor.
	/// </summary>
	public void SetTensorModeToComputeGreenLagrangeStrain()
	{
		vtkCellDerivatives_SetTensorModeToComputeGreenLagrangeStrain_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDerivatives_SetTensorModeToComputeStrain_15(HandleRef pThis);

	/// <summary>
	/// Control how the filter works to generate tensor cell data. You can
	/// choose to pass the input cell tensors, compute the gradient of
	/// the input vectors, or compute the strain tensor (linearized or
	/// Green-Lagrange strain)of the vector gradient tensor. By default
	/// (TensorModeToComputeGradient), the filter will take the gradient
	/// of the vector data to construct a tensor.
	/// </summary>
	public void SetTensorModeToComputeStrain()
	{
		vtkCellDerivatives_SetTensorModeToComputeStrain_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDerivatives_SetTensorModeToPassTensors_16(HandleRef pThis);

	/// <summary>
	/// Control how the filter works to generate tensor cell data. You can
	/// choose to pass the input cell tensors, compute the gradient of
	/// the input vectors, or compute the strain tensor (linearized or
	/// Green-Lagrange strain)of the vector gradient tensor. By default
	/// (TensorModeToComputeGradient), the filter will take the gradient
	/// of the vector data to construct a tensor.
	/// </summary>
	public void SetTensorModeToPassTensors()
	{
		vtkCellDerivatives_SetTensorModeToPassTensors_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDerivatives_SetVectorMode_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Control how the filter works to generate vector cell data. You
	/// can choose to pass the input cell vectors, compute the gradient
	/// of the input scalars, or extract the vorticity of the computed
	/// vector gradient tensor. By default (VectorModeToComputeGradient),
	/// the filter will take the gradient of the input scalar data.
	/// </summary>
	public virtual void SetVectorMode(int _arg)
	{
		vtkCellDerivatives_SetVectorMode_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDerivatives_SetVectorModeToComputeGradient_18(HandleRef pThis);

	/// <summary>
	/// Control how the filter works to generate vector cell data. You
	/// can choose to pass the input cell vectors, compute the gradient
	/// of the input scalars, or extract the vorticity of the computed
	/// vector gradient tensor. By default (VectorModeToComputeGradient),
	/// the filter will take the gradient of the input scalar data.
	/// </summary>
	public void SetVectorModeToComputeGradient()
	{
		vtkCellDerivatives_SetVectorModeToComputeGradient_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDerivatives_SetVectorModeToComputeVorticity_19(HandleRef pThis);

	/// <summary>
	/// Control how the filter works to generate vector cell data. You
	/// can choose to pass the input cell vectors, compute the gradient
	/// of the input scalars, or extract the vorticity of the computed
	/// vector gradient tensor. By default (VectorModeToComputeGradient),
	/// the filter will take the gradient of the input scalar data.
	/// </summary>
	public void SetVectorModeToComputeVorticity()
	{
		vtkCellDerivatives_SetVectorModeToComputeVorticity_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDerivatives_SetVectorModeToPassVectors_20(HandleRef pThis);

	/// <summary>
	/// Control how the filter works to generate vector cell data. You
	/// can choose to pass the input cell vectors, compute the gradient
	/// of the input scalars, or extract the vorticity of the computed
	/// vector gradient tensor. By default (VectorModeToComputeGradient),
	/// the filter will take the gradient of the input scalar data.
	/// </summary>
	public void SetVectorModeToPassVectors()
	{
		vtkCellDerivatives_SetVectorModeToPassVectors_20(GetCppThis());
	}
}
