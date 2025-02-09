using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGradientFilter
/// </summary>
/// <remarks>
///    A general filter for gradient estimation.
///
///
/// This filter estimates the gradient of a field in a data set.  The gradient
/// calculation is dependent on the input dataset type.  The created gradient
/// array is of the same type as the array it is calculated from (e.g. point
/// data or cell data) but the data type will be either float or double.  At
/// the boundary the gradient does not use central differencing.  The output
/// gradient array has 3*number of components of the input data array.  The
/// ordering for the output gradient tuple will be {du/dx, du/dy, du/dz,
/// dv/dx, dv/dy, dv/dz, dw/dx, dw/dy, dw/dz} for an input array {u, v,
/// w}. There are also the options to additionally compute the vorticity and Q
/// criterion of a vector field.  Unstructured grids and polydata can have
/// cells of different dimensions.  To handle different use cases in this
/// situation, the user can specify which cells contribute to the
/// computation. The options for this are All (default), Patch and
/// DataSetMax. Patch uses only the highest dimension cells attached to a
/// point. DataSetMax uses the highest cell dimension in the entire data
/// set. For Patch or DataSetMax it is possible that some values will not be
/// computed. The ReplacementValueOption specifies what to use for these
/// values.
///
/// </remarks>
public class vtkGradientFilter : vtkDataSetAlgorithm
{
	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public enum ContributingCellEnum
	{
		/// <summary>enum member</summary>
		All = 0,
		/// <summary>enum member</summary>
		DataSetMax = 2,
		/// <summary>enum member</summary>
		Patch = 1
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public enum ReplacementValueEnum
	{
		/// <summary>enum member</summary>
		DataTypeMax = 3,
		/// <summary>enum member</summary>
		DataTypeMin = 2,
		/// <summary>enum member</summary>
		NaN = 1,
		/// <summary>enum member</summary>
		Zero = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGradientFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGradientFilter()
	{
		MRClassNameKey = "class vtkGradientFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGradientFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGradientFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGradientFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkGradientFilter New()
	{
		vtkGradientFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGradientFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGradientFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public vtkGradientFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGradientFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkGradientFilter_ComputeDivergenceOff_01(HandleRef pThis);

	/// <summary>
	/// Add divergence to the output field data.  The name of the array
	/// will be DivergenceArrayName and will be the same type as the input
	/// array.  The input array must have 3 components in order to
	/// compute this. The default is off.
	/// </summary>
	public virtual void ComputeDivergenceOff()
	{
		vtkGradientFilter_ComputeDivergenceOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_ComputeDivergenceOn_02(HandleRef pThis);

	/// <summary>
	/// Add divergence to the output field data.  The name of the array
	/// will be DivergenceArrayName and will be the same type as the input
	/// array.  The input array must have 3 components in order to
	/// compute this. The default is off.
	/// </summary>
	public virtual void ComputeDivergenceOn()
	{
		vtkGradientFilter_ComputeDivergenceOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_ComputeGradientOff_03(HandleRef pThis);

	/// <summary>
	/// Add the gradient to the output field data.  The name of the array
	/// will be ResultArrayName and will be the same type as the input
	/// array. The default is on.
	/// </summary>
	public virtual void ComputeGradientOff()
	{
		vtkGradientFilter_ComputeGradientOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_ComputeGradientOn_04(HandleRef pThis);

	/// <summary>
	/// Add the gradient to the output field data.  The name of the array
	/// will be ResultArrayName and will be the same type as the input
	/// array. The default is on.
	/// </summary>
	public virtual void ComputeGradientOn()
	{
		vtkGradientFilter_ComputeGradientOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_ComputeQCriterionOff_05(HandleRef pThis);

	/// <summary>
	/// Add Q-criterion to the output field data.  The name of the array
	/// will be QCriterionArrayName and will be the same type as the input
	/// array.  The input array must have 3 components in order to
	/// compute this.  Note that Q-citerion is a balance of the rate
	/// of vorticity and the rate of strain. The default is off.
	/// </summary>
	public virtual void ComputeQCriterionOff()
	{
		vtkGradientFilter_ComputeQCriterionOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_ComputeQCriterionOn_06(HandleRef pThis);

	/// <summary>
	/// Add Q-criterion to the output field data.  The name of the array
	/// will be QCriterionArrayName and will be the same type as the input
	/// array.  The input array must have 3 components in order to
	/// compute this.  Note that Q-citerion is a balance of the rate
	/// of vorticity and the rate of strain. The default is off.
	/// </summary>
	public virtual void ComputeQCriterionOn()
	{
		vtkGradientFilter_ComputeQCriterionOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_ComputeVorticityOff_07(HandleRef pThis);

	/// <summary>
	/// Add voriticity/curl to the output field data.  The name of the array
	/// will be VorticityArrayName and will be the same type as the input
	/// array.  The input array must have 3 components in order to
	/// compute this. The default is off.
	/// </summary>
	public virtual void ComputeVorticityOff()
	{
		vtkGradientFilter_ComputeVorticityOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_ComputeVorticityOn_08(HandleRef pThis);

	/// <summary>
	/// Add voriticity/curl to the output field data.  The name of the array
	/// will be VorticityArrayName and will be the same type as the input
	/// array.  The input array must have 3 components in order to
	/// compute this. The default is off.
	/// </summary>
	public virtual void ComputeVorticityOn()
	{
		vtkGradientFilter_ComputeVorticityOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_FasterApproximationOff_09(HandleRef pThis);

	/// <summary>
	/// When this flag is on (default is off), the gradient filter will provide a
	/// less accurate (but close) algorithm that performs fewer derivative
	/// calculations (and is therefore faster).  The error contains some smoothing
	/// of the output data and some possible errors on the boundary.  This
	/// parameter has no effect when performing the gradient of cell data.
	/// This only applies if the input grid is a vtkUnstructuredGrid or a
	/// vtkPolyData, and when point gradients are computed.
	/// </summary>
	public virtual void FasterApproximationOff()
	{
		vtkGradientFilter_FasterApproximationOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_FasterApproximationOn_10(HandleRef pThis);

	/// <summary>
	/// When this flag is on (default is off), the gradient filter will provide a
	/// less accurate (but close) algorithm that performs fewer derivative
	/// calculations (and is therefore faster).  The error contains some smoothing
	/// of the output data and some possible errors on the boundary.  This
	/// parameter has no effect when performing the gradient of cell data.
	/// This only applies if the input grid is a vtkUnstructuredGrid or a
	/// vtkPolyData, and when point gradients are computed.
	/// </summary>
	public virtual void FasterApproximationOn()
	{
		vtkGradientFilter_FasterApproximationOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGradientFilter_GetComputeDivergence_11(HandleRef pThis);

	/// <summary>
	/// Add divergence to the output field data.  The name of the array
	/// will be DivergenceArrayName and will be the same type as the input
	/// array.  The input array must have 3 components in order to
	/// compute this. The default is off.
	/// </summary>
	public virtual int GetComputeDivergence()
	{
		return vtkGradientFilter_GetComputeDivergence_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGradientFilter_GetComputeGradient_12(HandleRef pThis);

	/// <summary>
	/// Add the gradient to the output field data.  The name of the array
	/// will be ResultArrayName and will be the same type as the input
	/// array. The default is on.
	/// </summary>
	public virtual int GetComputeGradient()
	{
		return vtkGradientFilter_GetComputeGradient_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGradientFilter_GetComputeQCriterion_13(HandleRef pThis);

	/// <summary>
	/// Add Q-criterion to the output field data.  The name of the array
	/// will be QCriterionArrayName and will be the same type as the input
	/// array.  The input array must have 3 components in order to
	/// compute this.  Note that Q-citerion is a balance of the rate
	/// of vorticity and the rate of strain. The default is off.
	/// </summary>
	public virtual int GetComputeQCriterion()
	{
		return vtkGradientFilter_GetComputeQCriterion_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGradientFilter_GetComputeVorticity_14(HandleRef pThis);

	/// <summary>
	/// Add voriticity/curl to the output field data.  The name of the array
	/// will be VorticityArrayName and will be the same type as the input
	/// array.  The input array must have 3 components in order to
	/// compute this. The default is off.
	/// </summary>
	public virtual int GetComputeVorticity()
	{
		return vtkGradientFilter_GetComputeVorticity_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGradientFilter_GetContributingCellOption_15(HandleRef pThis);

	/// <summary>
	/// Option to specify what cells to include in the gradient computation.
	/// Options are all cells (All, Patch and DataSetMax). The default is All.
	/// </summary>
	public virtual int GetContributingCellOption()
	{
		return vtkGradientFilter_GetContributingCellOption_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGradientFilter_GetContributingCellOptionMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Option to specify what cells to include in the gradient computation.
	/// Options are all cells (All, Patch and DataSetMax). The default is All.
	/// </summary>
	public virtual int GetContributingCellOptionMaxValue()
	{
		return vtkGradientFilter_GetContributingCellOptionMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGradientFilter_GetContributingCellOptionMinValue_17(HandleRef pThis);

	/// <summary>
	/// Option to specify what cells to include in the gradient computation.
	/// Options are all cells (All, Patch and DataSetMax). The default is All.
	/// </summary>
	public virtual int GetContributingCellOptionMinValue()
	{
		return vtkGradientFilter_GetContributingCellOptionMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGradientFilter_GetDivergenceArrayName_18(HandleRef pThis);

	/// <summary>
	/// Get/Set the name of the divergence array to create. This is only
	/// used if ComputeDivergence is non-zero. If nullptr (the
	/// default) then the output array will be named "Divergence".
	/// </summary>
	public virtual string GetDivergenceArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkGradientFilter_GetDivergenceArrayName_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGradientFilter_GetFasterApproximation_19(HandleRef pThis);

	/// <summary>
	/// When this flag is on (default is off), the gradient filter will provide a
	/// less accurate (but close) algorithm that performs fewer derivative
	/// calculations (and is therefore faster).  The error contains some smoothing
	/// of the output data and some possible errors on the boundary.  This
	/// parameter has no effect when performing the gradient of cell data.
	/// This only applies if the input grid is a vtkUnstructuredGrid or a
	/// vtkPolyData, and when point gradients are computed.
	/// </summary>
	public virtual int GetFasterApproximation()
	{
		return vtkGradientFilter_GetFasterApproximation_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGradientFilter_GetNumberOfGenerationsFromBase_20(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGradientFilter_GetNumberOfGenerationsFromBase_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGradientFilter_GetNumberOfGenerationsFromBaseType_21(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGradientFilter_GetNumberOfGenerationsFromBaseType_21(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGradientFilter_GetQCriterionArrayName_22(HandleRef pThis);

	/// <summary>
	/// Get/Set the name of the Q criterion array to create. This is only
	/// used if ComputeQCriterion is non-zero. If nullptr (the
	/// default) then the output array will be named "Q-criterion".
	/// </summary>
	public virtual string GetQCriterionArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkGradientFilter_GetQCriterionArrayName_22(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGradientFilter_GetReplacementValueOption_23(HandleRef pThis);

	/// <summary>
	/// Option to specify what replacement value or entities that don't have any gradient computed
	/// over them based on the ContributingCellOption. Options are (Zero, NaN, DataTypeMin,
	/// DataTypeMax). The default is Zero.
	/// </summary>
	public virtual int GetReplacementValueOption()
	{
		return vtkGradientFilter_GetReplacementValueOption_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGradientFilter_GetReplacementValueOptionMaxValue_24(HandleRef pThis);

	/// <summary>
	/// Option to specify what replacement value or entities that don't have any gradient computed
	/// over them based on the ContributingCellOption. Options are (Zero, NaN, DataTypeMin,
	/// DataTypeMax). The default is Zero.
	/// </summary>
	public virtual int GetReplacementValueOptionMaxValue()
	{
		return vtkGradientFilter_GetReplacementValueOptionMaxValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGradientFilter_GetReplacementValueOptionMinValue_25(HandleRef pThis);

	/// <summary>
	/// Option to specify what replacement value or entities that don't have any gradient computed
	/// over them based on the ContributingCellOption. Options are (Zero, NaN, DataTypeMin,
	/// DataTypeMax). The default is Zero.
	/// </summary>
	public virtual int GetReplacementValueOptionMinValue()
	{
		return vtkGradientFilter_GetReplacementValueOptionMinValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGradientFilter_GetResultArrayName_26(HandleRef pThis);

	/// <summary>
	/// Get/Set the name of the gradient array to create.  This is only
	/// used if ComputeGradient is non-zero. If nullptr (the
	/// default) then the output array will be named "Gradients".
	/// </summary>
	public virtual string GetResultArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkGradientFilter_GetResultArrayName_26(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGradientFilter_GetVorticityArrayName_27(HandleRef pThis);

	/// <summary>
	/// Get/Set the name of the vorticity array to create. This is only
	/// used if ComputeVorticity is non-zero. If nullptr (the
	/// default) then the output array will be named "Vorticity".
	/// </summary>
	public virtual string GetVorticityArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkGradientFilter_GetVorticityArrayName_27(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGradientFilter_IsA_28(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGradientFilter_IsA_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGradientFilter_IsTypeOf_29(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGradientFilter_IsTypeOf_29(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGradientFilter_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new vtkGradientFilter NewInstance()
	{
		vtkGradientFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGradientFilter_NewInstance_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGradientFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGradientFilter_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkGradientFilter SafeDownCast(vtkObjectBase o)
	{
		vtkGradientFilter vtkGradientFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGradientFilter_SafeDownCast_32(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGradientFilter2 = (vtkGradientFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGradientFilter2.Register(null);
			}
		}
		return vtkGradientFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_SetComputeDivergence_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Add divergence to the output field data.  The name of the array
	/// will be DivergenceArrayName and will be the same type as the input
	/// array.  The input array must have 3 components in order to
	/// compute this. The default is off.
	/// </summary>
	public virtual void SetComputeDivergence(int _arg)
	{
		vtkGradientFilter_SetComputeDivergence_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_SetComputeGradient_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Add the gradient to the output field data.  The name of the array
	/// will be ResultArrayName and will be the same type as the input
	/// array. The default is on.
	/// </summary>
	public virtual void SetComputeGradient(int _arg)
	{
		vtkGradientFilter_SetComputeGradient_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_SetComputeQCriterion_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Add Q-criterion to the output field data.  The name of the array
	/// will be QCriterionArrayName and will be the same type as the input
	/// array.  The input array must have 3 components in order to
	/// compute this.  Note that Q-citerion is a balance of the rate
	/// of vorticity and the rate of strain. The default is off.
	/// </summary>
	public virtual void SetComputeQCriterion(int _arg)
	{
		vtkGradientFilter_SetComputeQCriterion_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_SetComputeVorticity_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Add voriticity/curl to the output field data.  The name of the array
	/// will be VorticityArrayName and will be the same type as the input
	/// array.  The input array must have 3 components in order to
	/// compute this. The default is off.
	/// </summary>
	public virtual void SetComputeVorticity(int _arg)
	{
		vtkGradientFilter_SetComputeVorticity_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_SetContributingCellOption_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Option to specify what cells to include in the gradient computation.
	/// Options are all cells (All, Patch and DataSetMax). The default is All.
	/// </summary>
	public virtual void SetContributingCellOption(int _arg)
	{
		vtkGradientFilter_SetContributingCellOption_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_SetDivergenceArrayName_38(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the name of the divergence array to create. This is only
	/// used if ComputeDivergence is non-zero. If nullptr (the
	/// default) then the output array will be named "Divergence".
	/// </summary>
	public virtual void SetDivergenceArrayName(string _arg)
	{
		vtkGradientFilter_SetDivergenceArrayName_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_SetFasterApproximation_39(HandleRef pThis, int _arg);

	/// <summary>
	/// When this flag is on (default is off), the gradient filter will provide a
	/// less accurate (but close) algorithm that performs fewer derivative
	/// calculations (and is therefore faster).  The error contains some smoothing
	/// of the output data and some possible errors on the boundary.  This
	/// parameter has no effect when performing the gradient of cell data.
	/// This only applies if the input grid is a vtkUnstructuredGrid or a
	/// vtkPolyData, and when point gradients are computed.
	/// </summary>
	public virtual void SetFasterApproximation(int _arg)
	{
		vtkGradientFilter_SetFasterApproximation_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_SetInputScalars_40(HandleRef pThis, int fieldAssociation, string name);

	/// <summary>
	/// These are basically a convenience method that calls SetInputArrayToProcess
	/// to set the array used as the input scalars.  The fieldAssociation comes
	/// from the vtkDataObject::FieldAssociations enum.  The fieldAttributeType
	/// comes from the vtkDataSetAttributes::AttributeTypes enum.
	/// </summary>
	public virtual void SetInputScalars(int fieldAssociation, string name)
	{
		vtkGradientFilter_SetInputScalars_40(GetCppThis(), fieldAssociation, name);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_SetInputScalars_41(HandleRef pThis, int fieldAssociation, int fieldAttributeType);

	/// <summary>
	/// These are basically a convenience method that calls SetInputArrayToProcess
	/// to set the array used as the input scalars.  The fieldAssociation comes
	/// from the vtkDataObject::FieldAssociations enum.  The fieldAttributeType
	/// comes from the vtkDataSetAttributes::AttributeTypes enum.
	/// </summary>
	public virtual void SetInputScalars(int fieldAssociation, int fieldAttributeType)
	{
		vtkGradientFilter_SetInputScalars_41(GetCppThis(), fieldAssociation, fieldAttributeType);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_SetQCriterionArrayName_42(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the name of the Q criterion array to create. This is only
	/// used if ComputeQCriterion is non-zero. If nullptr (the
	/// default) then the output array will be named "Q-criterion".
	/// </summary>
	public virtual void SetQCriterionArrayName(string _arg)
	{
		vtkGradientFilter_SetQCriterionArrayName_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_SetReplacementValueOption_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Option to specify what replacement value or entities that don't have any gradient computed
	/// over them based on the ContributingCellOption. Options are (Zero, NaN, DataTypeMin,
	/// DataTypeMax). The default is Zero.
	/// </summary>
	public virtual void SetReplacementValueOption(int _arg)
	{
		vtkGradientFilter_SetReplacementValueOption_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_SetResultArrayName_44(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the name of the gradient array to create.  This is only
	/// used if ComputeGradient is non-zero. If nullptr (the
	/// default) then the output array will be named "Gradients".
	/// </summary>
	public virtual void SetResultArrayName(string _arg)
	{
		vtkGradientFilter_SetResultArrayName_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGradientFilter_SetVorticityArrayName_45(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the name of the vorticity array to create. This is only
	/// used if ComputeVorticity is non-zero. If nullptr (the
	/// default) then the output array will be named "Vorticity".
	/// </summary>
	public virtual void SetVorticityArrayName(string _arg)
	{
		vtkGradientFilter_SetVorticityArrayName_45(GetCppThis(), _arg);
	}
}
