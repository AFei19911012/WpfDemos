using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSPHKernel
/// </summary>
/// <remarks>
///    a family of SPH interpolation kernels
///
///
/// vtkSPHKernel is an abstract superclass for smoothed-particle hydrodynamics
/// interpolation kernels as described by D.J. Price (see full reference
/// below).
///
/// Note that the kernel operates over a volume in space defined by a radius
/// at a sampling point. The kernel implicitly assumes that the particles
/// making up the input data satisfies physical properties such as
/// conservation of mass. Therefore subclasses of this kernel are not
/// generally applicable for interpolation processes, and therefore operate in
/// conjunction with the vthSPHInterpolator class.
///
/// By default the kernel computes local particle volume from the spatial step^3.
/// However, if both an optional mass and density arrays are provided then they are
/// used to compute local volume.
///
/// Also be default, the local neighborhood around a point to be interpolated is
/// computed as the CutoffFactor * SpatialStep. (Note the CutoffFactor varies for
/// each type of SPH kernel.) However, the user may specify a CutoffArray which
/// enables variable cutoff distances per each point.
///
/// @warning
/// For more information see D.J. Price, Smoothed particle hydrodynamics and
/// magnetohydrodynamics, J. Comput. Phys. 231:759-794, 2012. Especially
/// equation 49.
///
/// @par Acknowledgments:
/// The following work has been generously supported by Altair Engineering
/// and FluiDyna GmbH. Please contact Steve Cosgrove or Milos Stanic for
/// more information.
///
/// </remarks>
/// <seealso>
///
/// vtkSPHKernel vtkSPHQuinticKernel vtkInterpolationKernel vtkGaussianKernel
/// vtkShepardKernel vtkLinearKernel
/// </seealso>
public abstract class vtkSPHKernel : vtkInterpolationKernel
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSPHKernel";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSPHKernel()
	{
		MRClassNameKey = "class vtkSPHKernel";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSPHKernel"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSPHKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSPHKernel_ComputeBasis_01(HandleRef pThis, IntPtr x, HandleRef pIds, long ptId);

	/// <summary>
	/// Given a point x (and optional associated ptId), determine the points
	/// around x which form an interpolation basis. The user must provide the
	/// vtkIdList pIds, which will be dynamically resized as necessary. The
	/// method returns the number of points in the basis. Typically this method
	/// is called before ComputeWeights(). Note that while ptId is optional in most
	/// cases, if a cutoff array is provided, then ptId must be provided.
	/// </summary>
	public override long ComputeBasis(IntPtr x, vtkIdList pIds, long ptId)
	{
		return vtkSPHKernel_ComputeBasis_01(GetCppThis(), x, pIds?.GetCppThis() ?? default(HandleRef), ptId);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSPHKernel_ComputeDerivWeight_02(HandleRef pThis, double d);

	/// <summary>
	/// Compute weighting factor for derivative quantities given a normalized
	/// distance from a sample point.
	/// </summary>
	public virtual double ComputeDerivWeight(double d)
	{
		return vtkSPHKernel_ComputeDerivWeight_02(GetCppThis(), d);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSPHKernel_ComputeDerivWeights_03(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef weights, HandleRef gradWeights);

	/// <summary>
	/// Given a point x, and a list of basis points pIds, compute interpolation
	/// weights, plus derivative weights, associated with these basis points.
	/// </summary>
	public virtual long ComputeDerivWeights(IntPtr x, vtkIdList pIds, vtkDoubleArray weights, vtkDoubleArray gradWeights)
	{
		return vtkSPHKernel_ComputeDerivWeights_03(GetCppThis(), x, pIds?.GetCppThis() ?? default(HandleRef), weights?.GetCppThis() ?? default(HandleRef), gradWeights?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSPHKernel_ComputeFunctionWeight_04(HandleRef pThis, double d);

	/// <summary>
	/// Compute weighting factor given a normalized distance from a sample point.
	/// </summary>
	public virtual double ComputeFunctionWeight(double d)
	{
		return vtkSPHKernel_ComputeFunctionWeight_04(GetCppThis(), d);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSPHKernel_ComputeWeights_05(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef weights);

	/// <summary>
	/// Given a point x, and a list of basis points pIds, compute interpolation
	/// weights associated with these basis points.
	/// </summary>
	public override long ComputeWeights(IntPtr x, vtkIdList pIds, vtkDoubleArray weights)
	{
		return vtkSPHKernel_ComputeWeights_05(GetCppThis(), x, pIds?.GetCppThis() ?? default(HandleRef), weights?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSPHKernel_GetCutoffArray_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the (optional) array defining a cutoff distance. If provided this
	/// distance is used to find the interpolating points within the local
	/// neighborbood. Otherwise the cutoff distance is defined as the cutoff
	/// factor times the spatial step size.
	/// </summary>
	public virtual vtkDataArray GetCutoffArray()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSPHKernel_GetCutoffArray_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSPHKernel_GetCutoffFactor_07(HandleRef pThis);

	/// <summary>
	/// Return the cutoff factor. This is hard wired into the kernel (e.g., the
	/// vtkSPHQuinticKernel has a cutoff factor = 3.0).
	/// </summary>
	public virtual double GetCutoffFactor()
	{
		return vtkSPHKernel_GetCutoffFactor_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSPHKernel_GetDensityArray_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the (optional) density array. Used with the mass array to
	/// compute local particle volumes.
	/// </summary>
	public virtual vtkDataArray GetDensityArray()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSPHKernel_GetDensityArray_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSPHKernel_GetDimension_09(HandleRef pThis);

	/// <summary>
	/// The domain dimension, default to 3.
	/// </summary>
	public virtual int GetDimension()
	{
		return vtkSPHKernel_GetDimension_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSPHKernel_GetDimensionMaxValue_10(HandleRef pThis);

	/// <summary>
	/// The domain dimension, default to 3.
	/// </summary>
	public virtual int GetDimensionMaxValue()
	{
		return vtkSPHKernel_GetDimensionMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSPHKernel_GetDimensionMinValue_11(HandleRef pThis);

	/// <summary>
	/// The domain dimension, default to 3.
	/// </summary>
	public virtual int GetDimensionMinValue()
	{
		return vtkSPHKernel_GetDimensionMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSPHKernel_GetMassArray_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the (optional) mass array. Used with the density array to
	/// compute local particle volumes.
	/// </summary>
	public virtual vtkDataArray GetMassArray()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSPHKernel_GetMassArray_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSPHKernel_GetNormFactor_13(HandleRef pThis);

	/// <summary>
	/// Return the SPH normalization factor. This also includes the contribution
	/// of 1/h^d, where h is the smoothing length (i.e., spatial step) and d is
	/// the dimension of the kernel. The returned value is only valid after the
	/// kernel is initialized.
	/// </summary>
	public virtual double GetNormFactor()
	{
		return vtkSPHKernel_GetNormFactor_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSPHKernel_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSPHKernel_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSPHKernel_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSPHKernel_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSPHKernel_GetSpatialStep_16(HandleRef pThis);

	/// <summary>
	/// The user defined initial particle spatial step. This is also referred to as
	/// the smoothing length.
	/// </summary>
	public virtual double GetSpatialStep()
	{
		return vtkSPHKernel_GetSpatialStep_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSPHKernel_GetSpatialStepMaxValue_17(HandleRef pThis);

	/// <summary>
	/// The user defined initial particle spatial step. This is also referred to as
	/// the smoothing length.
	/// </summary>
	public virtual double GetSpatialStepMaxValue()
	{
		return vtkSPHKernel_GetSpatialStepMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSPHKernel_GetSpatialStepMinValue_18(HandleRef pThis);

	/// <summary>
	/// The user defined initial particle spatial step. This is also referred to as
	/// the smoothing length.
	/// </summary>
	public virtual double GetSpatialStepMinValue()
	{
		return vtkSPHKernel_GetSpatialStepMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHKernel_Initialize_19(HandleRef pThis, HandleRef loc, HandleRef ds, HandleRef pd);

	/// <summary>
	/// Produce the computational parameters for the kernel. Invoke this method
	/// after setting initial values like SpatialStep.
	/// </summary>
	public override void Initialize(vtkAbstractPointLocator loc, vtkDataSet ds, vtkPointData pd)
	{
		vtkSPHKernel_Initialize_19(GetCppThis(), loc?.GetCppThis() ?? default(HandleRef), ds?.GetCppThis() ?? default(HandleRef), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSPHKernel_IsA_20(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSPHKernel_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSPHKernel_IsTypeOf_21(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSPHKernel_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSPHKernel_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new vtkSPHKernel NewInstance()
	{
		vtkSPHKernel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSPHKernel_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSPHKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSPHKernel_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkSPHKernel SafeDownCast(vtkObjectBase o)
	{
		vtkSPHKernel vtkSPHKernel2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSPHKernel_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSPHKernel2 = (vtkSPHKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSPHKernel2.Register(null);
			}
		}
		return vtkSPHKernel2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHKernel_SetCutoffArray_24(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the (optional) array defining a cutoff distance. If provided this
	/// distance is used to find the interpolating points within the local
	/// neighborbood. Otherwise the cutoff distance is defined as the cutoff
	/// factor times the spatial step size.
	/// </summary>
	public virtual void SetCutoffArray(vtkDataArray arg0)
	{
		vtkSPHKernel_SetCutoffArray_24(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHKernel_SetDensityArray_25(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the (optional) density array. Used with the mass array to
	/// compute local particle volumes.
	/// </summary>
	public virtual void SetDensityArray(vtkDataArray arg0)
	{
		vtkSPHKernel_SetDensityArray_25(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHKernel_SetDimension_26(HandleRef pThis, int _arg);

	/// <summary>
	/// The domain dimension, default to 3.
	/// </summary>
	public virtual void SetDimension(int _arg)
	{
		vtkSPHKernel_SetDimension_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHKernel_SetMassArray_27(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the (optional) mass array. Used with the density array to
	/// compute local particle volumes.
	/// </summary>
	public virtual void SetMassArray(vtkDataArray arg0)
	{
		vtkSPHKernel_SetMassArray_27(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHKernel_SetSpatialStep_28(HandleRef pThis, double _arg);

	/// <summary>
	/// The user defined initial particle spatial step. This is also referred to as
	/// the smoothing length.
	/// </summary>
	public virtual void SetSpatialStep(double _arg)
	{
		vtkSPHKernel_SetSpatialStep_28(GetCppThis(), _arg);
	}
}
