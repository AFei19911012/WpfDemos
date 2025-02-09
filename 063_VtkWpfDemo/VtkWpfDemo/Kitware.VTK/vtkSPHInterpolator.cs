using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSPHInterpolator
/// </summary>
/// <remarks>
///    interpolate over point cloud using SPH kernels
///
///
/// This filter uses SPH (smooth particle hydrodynamics) kernels to
/// interpolate a data source onto an input structure. For example, while the
/// data source is a set of particles, the data from these particles can be
/// interpolated onto an input object such as a line, plane or volume. Then
/// the output (which consists of the input structure plus interpolated data)
/// can then be visualized using classical visualization techniques such as
/// isocontouring, slicing, heat maps and so on.
///
/// To use this filter, besides setting the input P and source Pc, specify a
/// point locator (which accelerates queries about points and their neighbors)
/// and an interpolation kernel (a subclass of vtkSPHKernel). In addition, the
/// name of the source's density and mass arrays can optionally be provided;
/// however if not provided then the local volume is computed from the
/// kernel's spatial step. Finally, a cutoff distance array can optionally be
/// provided (as part of the input P point data) when the local neighborhood
/// around each sample point varies. The cutoff distance defines a local
/// neighborhood in which the points in that neighborhood are used to
/// interpolate values. If not provided, then the cutoff distance is computed
/// from the spatial step size times the cutoff factor (see vtkSPHKernel).
///
/// Other options to the filter include specifying which data attributes to
/// interpolate from the source. By default, all data attributes contained in
/// the source are interpolated. However, by adding array names to the
/// exclusion list, these arrays will not be interpolated. Also, it is
/// possible to use a SPH derivative formulation to interpolate from the
/// source data attributes. This requires adding arrays (by name) to the
/// derivative list, in which case the derivative formulation will be applied
/// to create a new output array named "X_deriv" where X is the name of a
/// source point attribute array.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// @warning
/// For widely spaced points in Pc, or when p is located outside the bounding
/// region of Pc, the interpolation may behave badly and the interpolation
/// process will adapt as necessary to produce output. For example, if the N
/// closest points within R are requested to interpolate p, if N=0 then the
/// interpolation will switch to a different strategy (which can be controlled
/// as in the NullPointsStrategy).
///
/// @warning
/// For more information and technical reference, see D.J. Price, Smoothed
/// particle hydrodynamics and magnetohydrodynamics,
/// J. Comput. Phys. 231:759-794, 2012. Especially equation 49.
///
/// @par Acknowledgments:
/// The following work has been generously supported by Altair Engineering
/// and FluiDyna GmbH. Please contact Steve Cosgrove or Milos Stanic for
/// more information.
///
/// </remarks>
/// <seealso>
///
/// vtkPointInterpolator vtkSPHKernel vtkSPHQuinticKernel
/// </seealso>
public class vtkSPHInterpolator : vtkDataSetAlgorithm
{
	/// <summary>
	/// Return the name of the ith derivative array.
	/// </summary>
	public enum NullStrategy
	{
		/// <summary>enum member</summary>
		MASK_POINTS,
		/// <summary>enum member</summary>
		NULL_VALUE
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSPHInterpolator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSPHInterpolator()
	{
		MRClassNameKey = "class vtkSPHInterpolator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSPHInterpolator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSPHInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSPHInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public new static vtkSPHInterpolator New()
	{
		vtkSPHInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSPHInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSPHInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public vtkSPHInterpolator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSPHInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_AddDerivativeArray_01(HandleRef pThis, string derivArray);

	/// <summary>
	/// Adds an array to the list of arrays whose derivative is to be taken. If
	/// the name of the array is "derivArray" this will produce an output array
	/// with the name "derivArray_deriv" (after filter execution).
	/// </summary>
	public void AddDerivativeArray(string derivArray)
	{
		vtkSPHInterpolator_AddDerivativeArray_01(GetCppThis(), derivArray);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_AddExcludedArray_02(HandleRef pThis, string excludedArray);

	/// <summary>
	/// Adds an array to the list of arrays which are to be excluded from the
	/// interpolation process.
	/// </summary>
	public void AddExcludedArray(string excludedArray)
	{
		vtkSPHInterpolator_AddExcludedArray_02(GetCppThis(), excludedArray);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_ClearDerivativeArrays_03(HandleRef pThis);

	/// <summary>
	/// Clears the contents of derivative array list.
	/// </summary>
	public void ClearDerivativeArrays()
	{
		vtkSPHInterpolator_ClearDerivativeArrays_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_ClearExcludedArrays_04(HandleRef pThis);

	/// <summary>
	/// Clears the contents of excluded array list.
	/// </summary>
	public void ClearExcludedArrays()
	{
		vtkSPHInterpolator_ClearExcludedArrays_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_ComputeShepardSumOff_05(HandleRef pThis);

	/// <summary>
	/// Indicate whether to compute the summation of weighting coefficients (the
	/// so-called Shepard sum). In the interior of a SPH point cloud, the
	/// Shepard summation value should be ~1.0.  Towards the boundary, the
	/// Shepard summation generally falls off &lt;1.0. If ComputeShepardSum is specified, then the
	/// output will contain an array of summed Shepard weights for each output
	/// point. On by default.
	/// </summary>
	public virtual void ComputeShepardSumOff()
	{
		vtkSPHInterpolator_ComputeShepardSumOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_ComputeShepardSumOn_06(HandleRef pThis);

	/// <summary>
	/// Indicate whether to compute the summation of weighting coefficients (the
	/// so-called Shepard sum). In the interior of a SPH point cloud, the
	/// Shepard summation value should be ~1.0.  Towards the boundary, the
	/// Shepard summation generally falls off &lt;1.0. If ComputeShepardSum is specified, then the
	/// output will contain an array of summed Shepard weights for each output
	/// point. On by default.
	/// </summary>
	public virtual void ComputeShepardSumOn()
	{
		vtkSPHInterpolator_ComputeShepardSumOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSPHInterpolator_GetComputeShepardSum_07(HandleRef pThis);

	/// <summary>
	/// Indicate whether to compute the summation of weighting coefficients (the
	/// so-called Shepard sum). In the interior of a SPH point cloud, the
	/// Shepard summation value should be ~1.0.  Towards the boundary, the
	/// Shepard summation generally falls off &lt;1.0. If ComputeShepardSum is specified, then the
	/// output will contain an array of summed Shepard weights for each output
	/// point. On by default.
	/// </summary>
	public virtual int GetComputeShepardSum()
	{
		return vtkSPHInterpolator_GetComputeShepardSum_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkSPHInterpolator_GetCutoffArrayName_08(HandleRef pThis);

	/// <summary>
	/// Specify an (optional) cutoff distance for each point in the input P. If
	/// not specified, then the kernel cutoff is used.
	/// </summary>
	public virtual string GetCutoffArrayName()
	{
		return vtkSPHInterpolator_GetCutoffArrayName_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkSPHInterpolator_GetDensityArrayName_09(HandleRef pThis);

	/// <summary>
	/// Specify the density array name. This is optional. Typically both the density
	/// and mass arrays are specified together (in order to compute the local volume).
	/// Both the mass and density arrays must consist of tuples of 1-component. (Note that
	/// the density array name specifies a point array found in the Pc source.)
	/// </summary>
	public virtual string GetDensityArrayName()
	{
		return vtkSPHInterpolator_GetDensityArrayName_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSPHInterpolator_GetDerivativeArray_10(HandleRef pThis, int i);

	/// <summary>
	/// Return the name of the ith derivative array.
	/// </summary>
	public string GetDerivativeArray(int i)
	{
		return Marshal.PtrToStringAnsi(vtkSPHInterpolator_GetDerivativeArray_10(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSPHInterpolator_GetExcludedArray_11(HandleRef pThis, int i);

	/// <summary>
	/// Return the name of the ith excluded array.
	/// </summary>
	public string GetExcludedArray(int i)
	{
		return Marshal.PtrToStringAnsi(vtkSPHInterpolator_GetExcludedArray_11(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSPHInterpolator_GetKernel_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify an interpolation kernel. By default a vtkSPHQuinticKernel is used
	/// (i.e., closest point). The interpolation kernel changes the basis of the
	/// interpolation.
	/// </summary>
	public virtual vtkSPHKernel GetKernel()
	{
		vtkSPHKernel vtkSPHKernel2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSPHInterpolator_GetKernel_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkSPHInterpolator_GetLocator_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient searches to locate near a
	/// specified interpolation position.
	/// </summary>
	public virtual vtkAbstractPointLocator GetLocator()
	{
		vtkAbstractPointLocator vtkAbstractPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSPHInterpolator_GetLocator_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractPointLocator2 = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractPointLocator2.Register(null);
			}
		}
		return vtkAbstractPointLocator2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkSPHInterpolator_GetMTime_14(HandleRef pThis);

	/// <summary>
	/// Get the MTime of this object also considering the locator and kernel.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkSPHInterpolator_GetMTime_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkSPHInterpolator_GetMassArrayName_15(HandleRef pThis);

	/// <summary>
	/// Specify the mass array name. This is optional. Typically both the
	/// density and mass arrays are specified together (in order to compute the
	/// local volume).  Both the mass and density arrays must consist of tuples
	/// of 1-component. (Note that the mass array name specifies a point
	/// array found in the Pc source.)
	/// </summary>
	public virtual string GetMassArrayName()
	{
		return vtkSPHInterpolator_GetMassArrayName_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSPHInterpolator_GetNullPointsStrategy_16(HandleRef pThis);

	/// <summary>
	/// Specify a strategy to use when encountering a "null" point during the
	/// interpolation process. Null points occur when the local neighborhood (of
	/// nearby points to interpolate from) is empty. If the strategy is set to
	/// MaskPoints, then an output array is created that marks points as being
	/// valid (=1) or null (invalid =0) (and the NullValue is set as well). If
	/// the strategy is set to NullValue, then the output data value(s) are set
	/// to the NullPoint value.
	/// </summary>
	public virtual int GetNullPointsStrategy()
	{
		return vtkSPHInterpolator_GetNullPointsStrategy_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSPHInterpolator_GetNullValue_17(HandleRef pThis);

	/// <summary>
	/// Specify the null point value. When a null point is encountered then all
	/// components of each null tuple are set to this value. By default the
	/// null value is set to zero.
	/// </summary>
	public virtual double GetNullValue()
	{
		return vtkSPHInterpolator_GetNullValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSPHInterpolator_GetNumberOfDerivativeArrays_18(HandleRef pThis);

	/// <summary>
	/// Return the number of derivative arrays.
	/// </summary>
	public int GetNumberOfDerivativeArrays()
	{
		return vtkSPHInterpolator_GetNumberOfDerivativeArrays_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSPHInterpolator_GetNumberOfExcludedArrays_19(HandleRef pThis);

	/// <summary>
	/// Return the number of excluded arrays.
	/// </summary>
	public int GetNumberOfExcludedArrays()
	{
		return vtkSPHInterpolator_GetNumberOfExcludedArrays_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSPHInterpolator_GetNumberOfGenerationsFromBase_20(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSPHInterpolator_GetNumberOfGenerationsFromBase_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSPHInterpolator_GetNumberOfGenerationsFromBaseType_21(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSPHInterpolator_GetNumberOfGenerationsFromBaseType_21(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSPHInterpolator_GetPassCellArrays_22(HandleRef pThis);

	/// <summary>
	/// Indicate whether to shallow copy the input cell data arrays to the
	/// output. On by default.
	/// </summary>
	public virtual int GetPassCellArrays()
	{
		return vtkSPHInterpolator_GetPassCellArrays_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSPHInterpolator_GetPassFieldArrays_23(HandleRef pThis);

	/// <summary>
	/// Indicate whether to pass the field-data arrays from the input to the
	/// output. On by default.
	/// </summary>
	public virtual int GetPassFieldArrays()
	{
		return vtkSPHInterpolator_GetPassFieldArrays_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSPHInterpolator_GetPassPointArrays_24(HandleRef pThis);

	/// <summary>
	/// Indicate whether to shallow copy the input point data arrays to the
	/// output. On by default.
	/// </summary>
	public virtual int GetPassPointArrays()
	{
		return vtkSPHInterpolator_GetPassPointArrays_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSPHInterpolator_GetPromoteOutputArrays_25(HandleRef pThis);

	/// <summary>
	/// If enabled, then input arrays that are non-real types (i.e., not float
	/// or double) are promoted to float type on output. This is because the
	/// interpolation process may not be well behaved when integral types are
	/// combined using interpolation weights.
	/// </summary>
	public virtual int GetPromoteOutputArrays()
	{
		return vtkSPHInterpolator_GetPromoteOutputArrays_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSPHInterpolator_GetShepardNormalization_26(HandleRef pThis);

	/// <summary>
	/// Indicate whether to normalize all arrays with the Shepard coefficients
	/// (except the density array and the Shepard sum array). If the Shepard
	/// coefficient is 0, then the data value is set to zero. Note that enabling
	/// ShepardNormalization forces the computation of the ShepardSum array.
	/// </summary>
	public virtual int GetShepardNormalization()
	{
		return vtkSPHInterpolator_GetShepardNormalization_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkSPHInterpolator_GetShepardSumArrayName_27(HandleRef pThis);

	/// <summary>
	/// If ComputeShepardSum is on, then an array is generated with name
	/// ShepardSumArrayName for each input point. This vtkFloatArray is placed
	/// into the output of the filter, and NullPoints have value =0.0. The
	/// default name is "Shepard Summation".
	/// </summary>
	public virtual string GetShepardSumArrayName()
	{
		return vtkSPHInterpolator_GetShepardSumArrayName_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSPHInterpolator_GetSource_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the dataset Pc that will be probed by the input points P.  The
	/// Input P defines the dataset structure (the points and cells) for the
	/// output, while the Source Pc is probed (interpolated) to generate the
	/// scalars, vectors, etc. for the output points based on the point
	/// locations.
	/// </summary>
	public vtkDataObject GetSource()
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSPHInterpolator_GetSource_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObject2 = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObject2.Register(null);
			}
		}
		return vtkDataObject2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkSPHInterpolator_GetValidPointsMaskArrayName_29(HandleRef pThis);

	/// <summary>
	/// If the NullPointsStrategy == MASK_POINTS, then an array is generated for
	/// each input point. This vtkCharArray is placed into the output of the filter,
	/// with a non-zero value for a valid point, and zero otherwise. The name of
	/// this masking array is specified here.
	/// </summary>
	public virtual string GetValidPointsMaskArrayName()
	{
		return vtkSPHInterpolator_GetValidPointsMaskArrayName_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSPHInterpolator_IsA_30(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSPHInterpolator_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSPHInterpolator_IsTypeOf_31(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSPHInterpolator_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSPHInterpolator_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public new vtkSPHInterpolator NewInstance()
	{
		vtkSPHInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSPHInterpolator_NewInstance_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSPHInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_PassCellArraysOff_34(HandleRef pThis);

	/// <summary>
	/// Indicate whether to shallow copy the input cell data arrays to the
	/// output. On by default.
	/// </summary>
	public virtual void PassCellArraysOff()
	{
		vtkSPHInterpolator_PassCellArraysOff_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_PassCellArraysOn_35(HandleRef pThis);

	/// <summary>
	/// Indicate whether to shallow copy the input cell data arrays to the
	/// output. On by default.
	/// </summary>
	public virtual void PassCellArraysOn()
	{
		vtkSPHInterpolator_PassCellArraysOn_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_PassFieldArraysOff_36(HandleRef pThis);

	/// <summary>
	/// Indicate whether to pass the field-data arrays from the input to the
	/// output. On by default.
	/// </summary>
	public virtual void PassFieldArraysOff()
	{
		vtkSPHInterpolator_PassFieldArraysOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_PassFieldArraysOn_37(HandleRef pThis);

	/// <summary>
	/// Indicate whether to pass the field-data arrays from the input to the
	/// output. On by default.
	/// </summary>
	public virtual void PassFieldArraysOn()
	{
		vtkSPHInterpolator_PassFieldArraysOn_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_PassPointArraysOff_38(HandleRef pThis);

	/// <summary>
	/// Indicate whether to shallow copy the input point data arrays to the
	/// output. On by default.
	/// </summary>
	public virtual void PassPointArraysOff()
	{
		vtkSPHInterpolator_PassPointArraysOff_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_PassPointArraysOn_39(HandleRef pThis);

	/// <summary>
	/// Indicate whether to shallow copy the input point data arrays to the
	/// output. On by default.
	/// </summary>
	public virtual void PassPointArraysOn()
	{
		vtkSPHInterpolator_PassPointArraysOn_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_PromoteOutputArraysOff_40(HandleRef pThis);

	/// <summary>
	/// If enabled, then input arrays that are non-real types (i.e., not float
	/// or double) are promoted to float type on output. This is because the
	/// interpolation process may not be well behaved when integral types are
	/// combined using interpolation weights.
	/// </summary>
	public virtual void PromoteOutputArraysOff()
	{
		vtkSPHInterpolator_PromoteOutputArraysOff_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_PromoteOutputArraysOn_41(HandleRef pThis);

	/// <summary>
	/// If enabled, then input arrays that are non-real types (i.e., not float
	/// or double) are promoted to float type on output. This is because the
	/// interpolation process may not be well behaved when integral types are
	/// combined using interpolation weights.
	/// </summary>
	public virtual void PromoteOutputArraysOn()
	{
		vtkSPHInterpolator_PromoteOutputArraysOn_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSPHInterpolator_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public new static vtkSPHInterpolator SafeDownCast(vtkObjectBase o)
	{
		vtkSPHInterpolator vtkSPHInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSPHInterpolator_SafeDownCast_42(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSPHInterpolator2 = (vtkSPHInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSPHInterpolator2.Register(null);
			}
		}
		return vtkSPHInterpolator2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_SetComputeShepardSum_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether to compute the summation of weighting coefficients (the
	/// so-called Shepard sum). In the interior of a SPH point cloud, the
	/// Shepard summation value should be ~1.0.  Towards the boundary, the
	/// Shepard summation generally falls off &lt;1.0. If ComputeShepardSum is specified, then the
	/// output will contain an array of summed Shepard weights for each output
	/// point. On by default.
	/// </summary>
	public virtual void SetComputeShepardSum(int _arg)
	{
		vtkSPHInterpolator_SetComputeShepardSum_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_SetCutoffArrayName_44(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify an (optional) cutoff distance for each point in the input P. If
	/// not specified, then the kernel cutoff is used.
	/// </summary>
	public virtual void SetCutoffArrayName(string _arg)
	{
		vtkSPHInterpolator_SetCutoffArrayName_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_SetDensityArrayName_45(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the density array name. This is optional. Typically both the density
	/// and mass arrays are specified together (in order to compute the local volume).
	/// Both the mass and density arrays must consist of tuples of 1-component. (Note that
	/// the density array name specifies a point array found in the Pc source.)
	/// </summary>
	public virtual void SetDensityArrayName(string _arg)
	{
		vtkSPHInterpolator_SetDensityArrayName_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_SetKernel_46(HandleRef pThis, HandleRef kernel);

	/// <summary>
	/// Specify an interpolation kernel. By default a vtkSPHQuinticKernel is used
	/// (i.e., closest point). The interpolation kernel changes the basis of the
	/// interpolation.
	/// </summary>
	public void SetKernel(vtkSPHKernel kernel)
	{
		vtkSPHInterpolator_SetKernel_46(GetCppThis(), kernel?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_SetLocator_47(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient searches to locate near a
	/// specified interpolation position.
	/// </summary>
	public void SetLocator(vtkAbstractPointLocator locator)
	{
		vtkSPHInterpolator_SetLocator_47(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_SetMassArrayName_48(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the mass array name. This is optional. Typically both the
	/// density and mass arrays are specified together (in order to compute the
	/// local volume).  Both the mass and density arrays must consist of tuples
	/// of 1-component. (Note that the mass array name specifies a point
	/// array found in the Pc source.)
	/// </summary>
	public virtual void SetMassArrayName(string _arg)
	{
		vtkSPHInterpolator_SetMassArrayName_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_SetNullPointsStrategy_49(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify a strategy to use when encountering a "null" point during the
	/// interpolation process. Null points occur when the local neighborhood (of
	/// nearby points to interpolate from) is empty. If the strategy is set to
	/// MaskPoints, then an output array is created that marks points as being
	/// valid (=1) or null (invalid =0) (and the NullValue is set as well). If
	/// the strategy is set to NullValue, then the output data value(s) are set
	/// to the NullPoint value.
	/// </summary>
	public virtual void SetNullPointsStrategy(int _arg)
	{
		vtkSPHInterpolator_SetNullPointsStrategy_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_SetNullPointsStrategyToMaskPoints_50(HandleRef pThis);

	/// <summary>
	/// Specify a strategy to use when encountering a "null" point during the
	/// interpolation process. Null points occur when the local neighborhood (of
	/// nearby points to interpolate from) is empty. If the strategy is set to
	/// MaskPoints, then an output array is created that marks points as being
	/// valid (=1) or null (invalid =0) (and the NullValue is set as well). If
	/// the strategy is set to NullValue, then the output data value(s) are set
	/// to the NullPoint value.
	/// </summary>
	public void SetNullPointsStrategyToMaskPoints()
	{
		vtkSPHInterpolator_SetNullPointsStrategyToMaskPoints_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_SetNullPointsStrategyToNullValue_51(HandleRef pThis);

	/// <summary>
	/// Specify a strategy to use when encountering a "null" point during the
	/// interpolation process. Null points occur when the local neighborhood (of
	/// nearby points to interpolate from) is empty. If the strategy is set to
	/// MaskPoints, then an output array is created that marks points as being
	/// valid (=1) or null (invalid =0) (and the NullValue is set as well). If
	/// the strategy is set to NullValue, then the output data value(s) are set
	/// to the NullPoint value.
	/// </summary>
	public void SetNullPointsStrategyToNullValue()
	{
		vtkSPHInterpolator_SetNullPointsStrategyToNullValue_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_SetNullValue_52(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the null point value. When a null point is encountered then all
	/// components of each null tuple are set to this value. By default the
	/// null value is set to zero.
	/// </summary>
	public virtual void SetNullValue(double _arg)
	{
		vtkSPHInterpolator_SetNullValue_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_SetPassCellArrays_53(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether to shallow copy the input cell data arrays to the
	/// output. On by default.
	/// </summary>
	public virtual void SetPassCellArrays(int _arg)
	{
		vtkSPHInterpolator_SetPassCellArrays_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_SetPassFieldArrays_54(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether to pass the field-data arrays from the input to the
	/// output. On by default.
	/// </summary>
	public virtual void SetPassFieldArrays(int _arg)
	{
		vtkSPHInterpolator_SetPassFieldArrays_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_SetPassPointArrays_55(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether to shallow copy the input point data arrays to the
	/// output. On by default.
	/// </summary>
	public virtual void SetPassPointArrays(int _arg)
	{
		vtkSPHInterpolator_SetPassPointArrays_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_SetPromoteOutputArrays_56(HandleRef pThis, int _arg);

	/// <summary>
	/// If enabled, then input arrays that are non-real types (i.e., not float
	/// or double) are promoted to float type on output. This is because the
	/// interpolation process may not be well behaved when integral types are
	/// combined using interpolation weights.
	/// </summary>
	public virtual void SetPromoteOutputArrays(int _arg)
	{
		vtkSPHInterpolator_SetPromoteOutputArrays_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_SetShepardNormalization_57(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether to normalize all arrays with the Shepard coefficients
	/// (except the density array and the Shepard sum array). If the Shepard
	/// coefficient is 0, then the data value is set to zero. Note that enabling
	/// ShepardNormalization forces the computation of the ShepardSum array.
	/// </summary>
	public virtual void SetShepardNormalization(int _arg)
	{
		vtkSPHInterpolator_SetShepardNormalization_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_SetShepardSumArrayName_58(HandleRef pThis, string _arg);

	/// <summary>
	/// If ComputeShepardSum is on, then an array is generated with name
	/// ShepardSumArrayName for each input point. This vtkFloatArray is placed
	/// into the output of the filter, and NullPoints have value =0.0. The
	/// default name is "Shepard Summation".
	/// </summary>
	public virtual void SetShepardSumArrayName(string _arg)
	{
		vtkSPHInterpolator_SetShepardSumArrayName_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_SetSourceConnection_59(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify the dataset Pc that will be probed by the input points P.  The
	/// Input P defines the structure (the points and cells) for the output,
	/// while the Source Pc is probed (interpolated) to generate the scalars,
	/// vectors, etc. for the output points based on the point locations.
	/// </summary>
	public void SetSourceConnection(vtkAlgorithmOutput algOutput)
	{
		vtkSPHInterpolator_SetSourceConnection_59(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_SetSourceData_60(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Specify the dataset Pc that will be probed by the input points P.  The
	/// Input P defines the dataset structure (the points and cells) for the
	/// output, while the Source Pc is probed (interpolated) to generate the
	/// scalars, vectors, etc. for the output points based on the point
	/// locations.
	/// </summary>
	public void SetSourceData(vtkDataObject source)
	{
		vtkSPHInterpolator_SetSourceData_60(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_SetValidPointsMaskArrayName_61(HandleRef pThis, string _arg);

	/// <summary>
	/// If the NullPointsStrategy == MASK_POINTS, then an array is generated for
	/// each input point. This vtkCharArray is placed into the output of the filter,
	/// with a non-zero value for a valid point, and zero otherwise. The name of
	/// this masking array is specified here.
	/// </summary>
	public virtual void SetValidPointsMaskArrayName(string _arg)
	{
		vtkSPHInterpolator_SetValidPointsMaskArrayName_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_ShepardNormalizationOff_62(HandleRef pThis);

	/// <summary>
	/// Indicate whether to normalize all arrays with the Shepard coefficients
	/// (except the density array and the Shepard sum array). If the Shepard
	/// coefficient is 0, then the data value is set to zero. Note that enabling
	/// ShepardNormalization forces the computation of the ShepardSum array.
	/// </summary>
	public virtual void ShepardNormalizationOff()
	{
		vtkSPHInterpolator_ShepardNormalizationOff_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHInterpolator_ShepardNormalizationOn_63(HandleRef pThis);

	/// <summary>
	/// Indicate whether to normalize all arrays with the Shepard coefficients
	/// (except the density array and the Shepard sum array). If the Shepard
	/// coefficient is 0, then the data value is set to zero. Note that enabling
	/// ShepardNormalization forces the computation of the ShepardSum array.
	/// </summary>
	public virtual void ShepardNormalizationOn()
	{
		vtkSPHInterpolator_ShepardNormalizationOn_63(GetCppThis());
	}
}
