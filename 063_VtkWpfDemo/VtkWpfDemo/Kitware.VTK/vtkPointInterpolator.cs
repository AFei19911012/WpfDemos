using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointInterpolator
/// </summary>
/// <remarks>
///    interpolate over point cloud using various kernels
///
///
/// vtkPointInterpolator probes a point cloud Pc (the filter Source) with a
/// set of points P (the filter Input), interpolating the data values from Pc
/// onto P. Note however that the descriptive phrase "point cloud" is a
/// misnomer: Pc can be represented by any vtkDataSet type, with the points of
/// the dataset forming Pc. Similarly, the output P can also be represented by
/// any vtkDataSet type; and the topology/geometry structure of P is passed
/// through to the output along with the newly interpolated arrays.
///
/// A key input to this filter is the specification of the interpolation
/// kernel, and the parameters which control the associated interpolation
/// process. Interpolation kernels include Voronoi, Gaussian, Shepard, and SPH
/// (smoothed particle hydrodynamics), with additional kernels to be added in
/// the future.
///
/// An overview of the algorithm is as follows. For each p from P, Np "close"
/// points to p are found. (The meaning of what is "close" can be specified as
/// either the N closest points, or all points within a given radius Rp. This
/// depends on how the kernel is defined.) Once the Np close points are found,
/// then the interpolation kernel is applied to compute new data values
/// located on p. Note that for reasonable performance, finding the Np closest
/// points requires a point locator. The locator may be specified as input to
/// the algorithm. (By default, a vtkStaticPointLocator is used because
/// generally it is much faster to build, delete, and search with. However,
/// with highly non-uniform point distributions, octree- or kd-tree based
/// locators may perform better.)
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
/// </remarks>
/// <seealso>
///
/// vtkPointInterpolator2D vtkProbeFilter vtkGaussianSplatter
/// vtkCheckerboardSplatter vtkShepardMethod vtkVoronoiKernel vtkShepardKernel
/// vtkGaussianKernel vtkSPHKernel
/// </seealso>
public class vtkPointInterpolator : vtkDataSetAlgorithm
{
	/// <summary>
	/// Specify an interpolation kernel. By default a vtkLinearKernel is used
	/// (i.e., linear combination of closest points). The interpolation kernel
	/// changes the basis of the interpolation.
	/// </summary>
	public enum Strategy
	{
		/// <summary>enum member</summary>
		CLOSEST_POINT = 2,
		/// <summary>enum member</summary>
		MASK_POINTS = 0,
		/// <summary>enum member</summary>
		NULL_VALUE = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointInterpolator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointInterpolator()
	{
		MRClassNameKey = "class vtkPointInterpolator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointInterpolator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public new static vtkPointInterpolator New()
	{
		vtkPointInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public vtkPointInterpolator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPointInterpolator_AddExcludedArray_01(HandleRef pThis, string excludedArray);

	/// <summary>
	/// Adds an array to the list of arrays which are to be excluded from the
	/// interpolation process.
	/// </summary>
	public void AddExcludedArray(string excludedArray)
	{
		vtkPointInterpolator_AddExcludedArray_01(GetCppThis(), excludedArray);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_ClearExcludedArrays_02(HandleRef pThis);

	/// <summary>
	/// Clears the contents of excluded array list.
	/// </summary>
	public void ClearExcludedArrays()
	{
		vtkPointInterpolator_ClearExcludedArrays_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointInterpolator_GetExcludedArray_03(HandleRef pThis, int i);

	/// <summary>
	/// Return the name of the ith excluded array.
	/// </summary>
	public string GetExcludedArray(int i)
	{
		return Marshal.PtrToStringAnsi(vtkPointInterpolator_GetExcludedArray_03(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointInterpolator_GetKernel_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify an interpolation kernel. By default a vtkLinearKernel is used
	/// (i.e., linear combination of closest points). The interpolation kernel
	/// changes the basis of the interpolation.
	/// </summary>
	public virtual vtkInterpolationKernel GetKernel()
	{
		vtkInterpolationKernel vtkInterpolationKernel2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointInterpolator_GetKernel_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInterpolationKernel2 = (vtkInterpolationKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInterpolationKernel2.Register(null);
			}
		}
		return vtkInterpolationKernel2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointInterpolator_GetLocator_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkPointInterpolator_GetLocator_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkPointInterpolator_GetMTime_06(HandleRef pThis);

	/// <summary>
	/// Get the MTime of this object also considering the locator and kernel.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkPointInterpolator_GetMTime_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointInterpolator_GetNullPointsStrategy_07(HandleRef pThis);

	/// <summary>
	/// Specify a strategy to use when encountering a "null" point during the
	/// interpolation process. Null points occur when the local neighborhood (of
	/// nearby points to interpolate from) is empty. If the strategy is set to
	/// MaskPoints, then an output array is created that marks points as being
	/// valid (=1) or null (invalid =0) (and the NullValue is set as well). If
	/// the strategy is set to NullValue (this is the default), then the output
	/// data value(s) are set to the NullPoint value (specified in the output
	/// point data). Finally, the strategy ClosestPoint is to simply use the
	/// closest point to perform the interpolation.
	/// </summary>
	public virtual int GetNullPointsStrategy()
	{
		return vtkPointInterpolator_GetNullPointsStrategy_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointInterpolator_GetNullValue_08(HandleRef pThis);

	/// <summary>
	/// Specify the null point value. When a null point is encountered then all
	/// components of each null tuple are set to this value. By default the
	/// null value is set to zero.
	/// </summary>
	public virtual double GetNullValue()
	{
		return vtkPointInterpolator_GetNullValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointInterpolator_GetNumberOfExcludedArrays_09(HandleRef pThis);

	/// <summary>
	/// Return the number of excluded arrays.
	/// </summary>
	public int GetNumberOfExcludedArrays()
	{
		return vtkPointInterpolator_GetNumberOfExcludedArrays_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointInterpolator_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointInterpolator_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointInterpolator_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointInterpolator_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointInterpolator_GetPassCellArrays_12(HandleRef pThis);

	/// <summary>
	/// Indicate whether to shallow copy the input cell data arrays to the
	/// output.  On by default.
	/// </summary>
	public virtual bool GetPassCellArrays()
	{
		return (vtkPointInterpolator_GetPassCellArrays_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointInterpolator_GetPassFieldArrays_13(HandleRef pThis);

	/// <summary>
	/// Indicate whether to pass the field-data arrays from the input to the
	/// output. On by default.
	/// </summary>
	public virtual bool GetPassFieldArrays()
	{
		return (vtkPointInterpolator_GetPassFieldArrays_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointInterpolator_GetPassPointArrays_14(HandleRef pThis);

	/// <summary>
	/// Indicate whether to shallow copy the input point data arrays to the
	/// output.  On by default.
	/// </summary>
	public virtual bool GetPassPointArrays()
	{
		return (vtkPointInterpolator_GetPassPointArrays_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointInterpolator_GetPromoteOutputArrays_15(HandleRef pThis);

	/// <summary>
	/// If enabled, then input arrays that are non-real types (i.e., not float
	/// or double) are promoted to float type on output. This is because the
	/// interpolation process may not be well behaved when integral types are
	/// combined using interpolation weights.
	/// </summary>
	public virtual bool GetPromoteOutputArrays()
	{
		return (vtkPointInterpolator_GetPromoteOutputArrays_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointInterpolator_GetSource_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkPointInterpolator_GetSource_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern string vtkPointInterpolator_GetValidPointsMaskArrayName_17(HandleRef pThis);

	/// <summary>
	/// If the NullPointsStrategy == MASK_POINTS, then an array is generated for
	/// each input point. This vtkCharArray is placed into the output of the filter,
	/// with a non-zero value for a valid point, and zero otherwise. The name of
	/// this masking array is specified here.
	/// </summary>
	public virtual string GetValidPointsMaskArrayName()
	{
		return vtkPointInterpolator_GetValidPointsMaskArrayName_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointInterpolator_IsA_18(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointInterpolator_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointInterpolator_IsTypeOf_19(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointInterpolator_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointInterpolator_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public new vtkPointInterpolator NewInstance()
	{
		vtkPointInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointInterpolator_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_PassCellArraysOff_22(HandleRef pThis);

	/// <summary>
	/// Indicate whether to shallow copy the input cell data arrays to the
	/// output.  On by default.
	/// </summary>
	public virtual void PassCellArraysOff()
	{
		vtkPointInterpolator_PassCellArraysOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_PassCellArraysOn_23(HandleRef pThis);

	/// <summary>
	/// Indicate whether to shallow copy the input cell data arrays to the
	/// output.  On by default.
	/// </summary>
	public virtual void PassCellArraysOn()
	{
		vtkPointInterpolator_PassCellArraysOn_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_PassFieldArraysOff_24(HandleRef pThis);

	/// <summary>
	/// Indicate whether to pass the field-data arrays from the input to the
	/// output. On by default.
	/// </summary>
	public virtual void PassFieldArraysOff()
	{
		vtkPointInterpolator_PassFieldArraysOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_PassFieldArraysOn_25(HandleRef pThis);

	/// <summary>
	/// Indicate whether to pass the field-data arrays from the input to the
	/// output. On by default.
	/// </summary>
	public virtual void PassFieldArraysOn()
	{
		vtkPointInterpolator_PassFieldArraysOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_PassPointArraysOff_26(HandleRef pThis);

	/// <summary>
	/// Indicate whether to shallow copy the input point data arrays to the
	/// output.  On by default.
	/// </summary>
	public virtual void PassPointArraysOff()
	{
		vtkPointInterpolator_PassPointArraysOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_PassPointArraysOn_27(HandleRef pThis);

	/// <summary>
	/// Indicate whether to shallow copy the input point data arrays to the
	/// output.  On by default.
	/// </summary>
	public virtual void PassPointArraysOn()
	{
		vtkPointInterpolator_PassPointArraysOn_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_PromoteOutputArraysOff_28(HandleRef pThis);

	/// <summary>
	/// If enabled, then input arrays that are non-real types (i.e., not float
	/// or double) are promoted to float type on output. This is because the
	/// interpolation process may not be well behaved when integral types are
	/// combined using interpolation weights.
	/// </summary>
	public virtual void PromoteOutputArraysOff()
	{
		vtkPointInterpolator_PromoteOutputArraysOff_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_PromoteOutputArraysOn_29(HandleRef pThis);

	/// <summary>
	/// If enabled, then input arrays that are non-real types (i.e., not float
	/// or double) are promoted to float type on output. This is because the
	/// interpolation process may not be well behaved when integral types are
	/// combined using interpolation weights.
	/// </summary>
	public virtual void PromoteOutputArraysOn()
	{
		vtkPointInterpolator_PromoteOutputArraysOn_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointInterpolator_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing.
	/// </summary>
	public new static vtkPointInterpolator SafeDownCast(vtkObjectBase o)
	{
		vtkPointInterpolator vtkPointInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointInterpolator_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointInterpolator2 = (vtkPointInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointInterpolator2.Register(null);
			}
		}
		return vtkPointInterpolator2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_SetKernel_31(HandleRef pThis, HandleRef kernel);

	/// <summary>
	/// Specify an interpolation kernel. By default a vtkLinearKernel is used
	/// (i.e., linear combination of closest points). The interpolation kernel
	/// changes the basis of the interpolation.
	/// </summary>
	public void SetKernel(vtkInterpolationKernel kernel)
	{
		vtkPointInterpolator_SetKernel_31(GetCppThis(), kernel?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_SetLocator_32(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient searches to locate near a
	/// specified interpolation position.
	/// </summary>
	public void SetLocator(vtkAbstractPointLocator locator)
	{
		vtkPointInterpolator_SetLocator_32(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_SetNullPointsStrategy_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify a strategy to use when encountering a "null" point during the
	/// interpolation process. Null points occur when the local neighborhood (of
	/// nearby points to interpolate from) is empty. If the strategy is set to
	/// MaskPoints, then an output array is created that marks points as being
	/// valid (=1) or null (invalid =0) (and the NullValue is set as well). If
	/// the strategy is set to NullValue (this is the default), then the output
	/// data value(s) are set to the NullPoint value (specified in the output
	/// point data). Finally, the strategy ClosestPoint is to simply use the
	/// closest point to perform the interpolation.
	/// </summary>
	public virtual void SetNullPointsStrategy(int _arg)
	{
		vtkPointInterpolator_SetNullPointsStrategy_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_SetNullPointsStrategyToClosestPoint_34(HandleRef pThis);

	/// <summary>
	/// Specify a strategy to use when encountering a "null" point during the
	/// interpolation process. Null points occur when the local neighborhood (of
	/// nearby points to interpolate from) is empty. If the strategy is set to
	/// MaskPoints, then an output array is created that marks points as being
	/// valid (=1) or null (invalid =0) (and the NullValue is set as well). If
	/// the strategy is set to NullValue (this is the default), then the output
	/// data value(s) are set to the NullPoint value (specified in the output
	/// point data). Finally, the strategy ClosestPoint is to simply use the
	/// closest point to perform the interpolation.
	/// </summary>
	public void SetNullPointsStrategyToClosestPoint()
	{
		vtkPointInterpolator_SetNullPointsStrategyToClosestPoint_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_SetNullPointsStrategyToMaskPoints_35(HandleRef pThis);

	/// <summary>
	/// Specify a strategy to use when encountering a "null" point during the
	/// interpolation process. Null points occur when the local neighborhood (of
	/// nearby points to interpolate from) is empty. If the strategy is set to
	/// MaskPoints, then an output array is created that marks points as being
	/// valid (=1) or null (invalid =0) (and the NullValue is set as well). If
	/// the strategy is set to NullValue (this is the default), then the output
	/// data value(s) are set to the NullPoint value (specified in the output
	/// point data). Finally, the strategy ClosestPoint is to simply use the
	/// closest point to perform the interpolation.
	/// </summary>
	public void SetNullPointsStrategyToMaskPoints()
	{
		vtkPointInterpolator_SetNullPointsStrategyToMaskPoints_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_SetNullPointsStrategyToNullValue_36(HandleRef pThis);

	/// <summary>
	/// Specify a strategy to use when encountering a "null" point during the
	/// interpolation process. Null points occur when the local neighborhood (of
	/// nearby points to interpolate from) is empty. If the strategy is set to
	/// MaskPoints, then an output array is created that marks points as being
	/// valid (=1) or null (invalid =0) (and the NullValue is set as well). If
	/// the strategy is set to NullValue (this is the default), then the output
	/// data value(s) are set to the NullPoint value (specified in the output
	/// point data). Finally, the strategy ClosestPoint is to simply use the
	/// closest point to perform the interpolation.
	/// </summary>
	public void SetNullPointsStrategyToNullValue()
	{
		vtkPointInterpolator_SetNullPointsStrategyToNullValue_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_SetNullValue_37(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the null point value. When a null point is encountered then all
	/// components of each null tuple are set to this value. By default the
	/// null value is set to zero.
	/// </summary>
	public virtual void SetNullValue(double _arg)
	{
		vtkPointInterpolator_SetNullValue_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_SetPassCellArrays_38(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to shallow copy the input cell data arrays to the
	/// output.  On by default.
	/// </summary>
	public virtual void SetPassCellArrays(bool _arg)
	{
		vtkPointInterpolator_SetPassCellArrays_38(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_SetPassFieldArrays_39(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to pass the field-data arrays from the input to the
	/// output. On by default.
	/// </summary>
	public virtual void SetPassFieldArrays(bool _arg)
	{
		vtkPointInterpolator_SetPassFieldArrays_39(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_SetPassPointArrays_40(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to shallow copy the input point data arrays to the
	/// output.  On by default.
	/// </summary>
	public virtual void SetPassPointArrays(bool _arg)
	{
		vtkPointInterpolator_SetPassPointArrays_40(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_SetPromoteOutputArrays_41(HandleRef pThis, byte _arg);

	/// <summary>
	/// If enabled, then input arrays that are non-real types (i.e., not float
	/// or double) are promoted to float type on output. This is because the
	/// interpolation process may not be well behaved when integral types are
	/// combined using interpolation weights.
	/// </summary>
	public virtual void SetPromoteOutputArrays(bool _arg)
	{
		vtkPointInterpolator_SetPromoteOutputArrays_41(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_SetSourceConnection_42(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify the dataset Pc that will be probed by the input points P.  The
	/// Input P defines the structure (the points and cells) for the output,
	/// while the Source Pc is probed (interpolated) to generate the scalars,
	/// vectors, etc. for the output points based on the point locations.
	/// </summary>
	public void SetSourceConnection(vtkAlgorithmOutput algOutput)
	{
		vtkPointInterpolator_SetSourceConnection_42(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_SetSourceData_43(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Specify the dataset Pc that will be probed by the input points P.  The
	/// Input P defines the dataset structure (the points and cells) for the
	/// output, while the Source Pc is probed (interpolated) to generate the
	/// scalars, vectors, etc. for the output points based on the point
	/// locations.
	/// </summary>
	public void SetSourceData(vtkDataObject source)
	{
		vtkPointInterpolator_SetSourceData_43(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointInterpolator_SetValidPointsMaskArrayName_44(HandleRef pThis, string _arg);

	/// <summary>
	/// If the NullPointsStrategy == MASK_POINTS, then an array is generated for
	/// each input point. This vtkCharArray is placed into the output of the filter,
	/// with a non-zero value for a valid point, and zero otherwise. The name of
	/// this masking array is specified here.
	/// </summary>
	public virtual void SetValidPointsMaskArrayName(string _arg)
	{
		vtkPointInterpolator_SetValidPointsMaskArrayName_44(GetCppThis(), _arg);
	}
}
