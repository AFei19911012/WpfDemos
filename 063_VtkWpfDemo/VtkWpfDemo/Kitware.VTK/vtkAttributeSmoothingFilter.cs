using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAttributeSmoothingFilter
/// </summary>
/// <remarks>
///    smooth mesh point attribute data using distance weighted Laplacian kernel
///
/// vtkAttributeSmoothingFilter is a filter that smooths point attribute data
/// using a Laplacian smoothing approach. The effect is to "relax" or "smooth"
/// the attributes, reducing high frequency information. Note that this filter
/// operates on all dataset types.
///
/// A central concept of this filter is the point smoothing stencil. A
/// smoothing stencil for a point p(i) is the list of points p(j) which
/// connect to p(i) via an edge. To smooth the attributes of point p(i),
/// p(i)'s attribute data a(i) are iteratively averaged using the distance
/// weighted average of the attributes of a(j) (the weights w[j] sum to
/// 1). This averaging process is repeated until the maximum number of
/// iterations is reached.
///
/// The relaxation factor R is also important as the smoothing process
/// proceeds in an iterative fashion. The a(i+1) attributes are determined
/// from the a(i) attributes as follows:
/// ```
/// a(i+1) = (1-R)*a(i) + R*sum(w(j)*a(j))
/// ```
///
/// Convergence occurs faster for larger relaxation factors. Typically a small
/// number of iterations is required for large relaxation factors, and in
/// cases where only points adjacent to the boundary are being smoothed, a
/// single iteration with R=1 may be adequate (i.e., just a distance weighted
/// average is computed).
///
/// To control what regions in the dataset have their attributes smoothed, it
/// is possible to specify which points (and their attributes) are allowed to
/// be smoothed (and therefore also those that are constrained). Typically
/// point data attributes may be constrained on the boundary, or only point
/// attributes directly connected (i.e., adjacent) to the boundary may be
/// allowed to change (this supports smooth transition of attributes from the
/// boundary into the interior of the mesh). Note that the meaning of a
/// boundary point (versus interior point) changes depending on the input
/// dataset type. For vtkPolyData, boundary *edges* are used to identify
/// boundary points; for all other dataset types, points used by a boundary
/// *face* are considered boundary points. It is also possible to expicitly
/// specify which points are smoothed, and those that are constrained, by
/// specifying a smooth mask associated with each input point.
///
/// To control which point data attributes are to be smoothed, specify in
/// ExcludedArrays which arrays should not be smoothed--these data arrays are
/// simply passed through to the output of the filter.
///
/// @warning
/// Certain data attributes cannot be correctly interpolated using this
/// filter.  For example, surface normals are expected to be |n|=1; after
/// attribute smoothing this constraint is likely to be violated. Other
/// vectors and tensors may suffer from similar issues. In such a situation,
/// specify ExcludedArrays which will not be smoothed (and simply passed
/// through to the output of the filter).
///
/// @warning
/// Currently the distance weighting function is based on averaging, 1/r, or
/// 1/(r**2) weights (user selectable), where r is the distance between the
/// point to be smoothed and an edge connected neighbor (defined by the
/// smoothing stencil). The weights are normalized so that sum(w(i))==1. When
/// smoothing based on averaging, the weights are simply 1/n, where n is the
/// number of connected points in the stencil.
///
/// @warning
/// The smoothing process reduces high frequency information in the data
/// attributes. With excessive smoothing (large numbers of iterations, and/or
/// a large relaxation factor) important details may be lost, and the
/// attributes will move towards an "average" value.
///
/// @warning
/// While this filter will process any dataset type, if the input data is a 3D
/// image volume, it's likely much faster to use an image-based algorithm to
/// perform data smoothing.
///
/// @warning
/// To determine boundary points in vtkPolyData, edges used by only one cell
/// are considered boundary (and hence the associated points defining the
/// edge). To determine boundary points for all other dataset types, a
/// vtkMarkBoundaryFilter is used to extract the boundary faces - this can be
/// time consuming for large data.
///
/// </remarks>
/// <seealso>
///
/// vtkConstrainedSmoothingFilter vtkWindowedSincPolyDataFilter
/// vtkSmoothPolyDataFilter vtkExtractEdges vtkMarkBoundaryFilter
/// </seealso>
public class vtkAttributeSmoothingFilter : vtkDataSetAlgorithm
{
	/// <summary>
	/// Specify the smoothing mask to use (which takes effect only when a
	/// SMOOTHING_MASK smoothing strategy is specified). The smoothing mask is a
	/// vtkUnsignedCharArray with a value ==1 at all points whose attributes are
	/// to be smoothed.  The size of the data array must match the number of
	/// input points. If there is a mismatch between the size of the smoothing
	/// mask, and the number of input points, then an ALL_POINTS smoothing
	/// strategy is used.
	/// </summary>
	public enum InterpolationWeightsType
	{
		/// <summary>enum member</summary>
		AVERAGE,
		/// <summary>enum member</summary>
		DISTANCE,
		/// <summary>enum member</summary>
		DISTANCE2
	}

	/// <summary>
	/// Specify the relaxation factor for smoothing. As in all iterative
	/// methods, the stability of the process is sensitive to this parameter. In
	/// general, small relaxation factors and large numbers of iterations are
	/// more stable than larger relaxation factors and smaller numbers of
	/// iterations. The default value is 0.10.
	/// </summary>
	public enum SmoothingStrategyType
	{
		/// <summary>enum member</summary>
		ADJACENT_TO_BOUNDARY = 2,
		/// <summary>enum member</summary>
		ALL_BUT_BOUNDARY = 1,
		/// <summary>enum member</summary>
		ALL_POINTS = 0,
		/// <summary>enum member</summary>
		SMOOTHING_MASK = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAttributeSmoothingFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAttributeSmoothingFilter()
	{
		MRClassNameKey = "class vtkAttributeSmoothingFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAttributeSmoothingFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAttributeSmoothingFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAttributeSmoothingFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, to obtain type information, and
	/// print the state of a class instance.
	/// </summary>
	public new static vtkAttributeSmoothingFilter New()
	{
		vtkAttributeSmoothingFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAttributeSmoothingFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAttributeSmoothingFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, to obtain type information, and
	/// print the state of a class instance.
	/// </summary>
	public vtkAttributeSmoothingFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAttributeSmoothingFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeSmoothingFilter_AddExcludedArray_01(HandleRef pThis, string excludedArray);

	/// <summary>
	/// Adds an array to the list of arrays which are to be excluded from the
	/// interpolation process. Any specified arrays are simply passed through
	/// to the filter output.
	/// </summary>
	public void AddExcludedArray(string excludedArray)
	{
		vtkAttributeSmoothingFilter_AddExcludedArray_01(GetCppThis(), excludedArray);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeSmoothingFilter_ClearExcludedArrays_02(HandleRef pThis);

	/// <summary>
	/// Clears the contents of excluded array list.
	/// </summary>
	public void ClearExcludedArrays()
	{
		vtkAttributeSmoothingFilter_ClearExcludedArrays_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAttributeSmoothingFilter_GetExcludedArray_03(HandleRef pThis, int i);

	/// <summary>
	/// Return the name of the ith excluded array.
	/// </summary>
	public string GetExcludedArray(int i)
	{
		return Marshal.PtrToStringAnsi(vtkAttributeSmoothingFilter_GetExcludedArray_03(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeSmoothingFilter_GetNumberOfExcludedArrays_04(HandleRef pThis);

	/// <summary>
	/// Return the number of excluded arrays.
	/// </summary>
	public int GetNumberOfExcludedArrays()
	{
		return vtkAttributeSmoothingFilter_GetNumberOfExcludedArrays_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAttributeSmoothingFilter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, to obtain type information, and
	/// print the state of a class instance.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAttributeSmoothingFilter_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAttributeSmoothingFilter_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Standard methods for instantiation, to obtain type information, and
	/// print the state of a class instance.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAttributeSmoothingFilter_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeSmoothingFilter_GetNumberOfIterations_07(HandleRef pThis);

	/// <summary>
	/// Specify the maximum number of iterations for smoothing.  The default
	/// value is 5.
	/// </summary>
	public virtual int GetNumberOfIterations()
	{
		return vtkAttributeSmoothingFilter_GetNumberOfIterations_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeSmoothingFilter_GetNumberOfIterationsMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Specify the maximum number of iterations for smoothing.  The default
	/// value is 5.
	/// </summary>
	public virtual int GetNumberOfIterationsMaxValue()
	{
		return vtkAttributeSmoothingFilter_GetNumberOfIterationsMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeSmoothingFilter_GetNumberOfIterationsMinValue_09(HandleRef pThis);

	/// <summary>
	/// Specify the maximum number of iterations for smoothing.  The default
	/// value is 5.
	/// </summary>
	public virtual int GetNumberOfIterationsMinValue()
	{
		return vtkAttributeSmoothingFilter_GetNumberOfIterationsMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAttributeSmoothingFilter_GetRelaxationFactor_10(HandleRef pThis);

	/// <summary>
	/// Specify the relaxation factor for smoothing. As in all iterative
	/// methods, the stability of the process is sensitive to this parameter. In
	/// general, small relaxation factors and large numbers of iterations are
	/// more stable than larger relaxation factors and smaller numbers of
	/// iterations. The default value is 0.10.
	/// </summary>
	public virtual double GetRelaxationFactor()
	{
		return vtkAttributeSmoothingFilter_GetRelaxationFactor_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAttributeSmoothingFilter_GetRelaxationFactorMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Specify the relaxation factor for smoothing. As in all iterative
	/// methods, the stability of the process is sensitive to this parameter. In
	/// general, small relaxation factors and large numbers of iterations are
	/// more stable than larger relaxation factors and smaller numbers of
	/// iterations. The default value is 0.10.
	/// </summary>
	public virtual double GetRelaxationFactorMaxValue()
	{
		return vtkAttributeSmoothingFilter_GetRelaxationFactorMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAttributeSmoothingFilter_GetRelaxationFactorMinValue_12(HandleRef pThis);

	/// <summary>
	/// Specify the relaxation factor for smoothing. As in all iterative
	/// methods, the stability of the process is sensitive to this parameter. In
	/// general, small relaxation factors and large numbers of iterations are
	/// more stable than larger relaxation factors and smaller numbers of
	/// iterations. The default value is 0.10.
	/// </summary>
	public virtual double GetRelaxationFactorMinValue()
	{
		return vtkAttributeSmoothingFilter_GetRelaxationFactorMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAttributeSmoothingFilter_GetSmoothingMask_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the smoothing mask to use (which takes effect only when a
	/// SMOOTHING_MASK smoothing strategy is specified). The smoothing mask is a
	/// vtkUnsignedCharArray with a value ==1 at all points whose attributes are
	/// to be smoothed.  The size of the data array must match the number of
	/// input points. If there is a mismatch between the size of the smoothing
	/// mask, and the number of input points, then an ALL_POINTS smoothing
	/// strategy is used.
	/// </summary>
	public virtual vtkUnsignedCharArray GetSmoothingMask()
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAttributeSmoothingFilter_GetSmoothingMask_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeSmoothingFilter_GetSmoothingStrategy_14(HandleRef pThis);

	/// <summary>
	/// Indicate how to constrain smoothing of the attribute data. By default,
	/// all point data attributes are smoothed (ALL_POINTS). If ALL_BUT_BOUNDARY
	/// is selected, then all point attribute data except those on the boundary
	/// of the mesh are smoothed.  If ADJACENT_TO_BOUNDARY is selected, then
	/// only point data connected to a boundary point are smoothed, but boundary
	/// and interior points are not. (ALL_BUT_BOUNDARY and ADJACENT_TO_BOUNDARY
	/// are useful for transitioning from fixed boundary conditions to interior
	/// data.) If desired, it is possible to explicitly specify a smoothing mask
	/// controlling which points are smoothed and not smoothed. The default
	/// constraint strategy is ALL_POINTS.
	/// </summary>
	public virtual int GetSmoothingStrategy()
	{
		return vtkAttributeSmoothingFilter_GetSmoothingStrategy_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeSmoothingFilter_GetSmoothingStrategyMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Indicate how to constrain smoothing of the attribute data. By default,
	/// all point data attributes are smoothed (ALL_POINTS). If ALL_BUT_BOUNDARY
	/// is selected, then all point attribute data except those on the boundary
	/// of the mesh are smoothed.  If ADJACENT_TO_BOUNDARY is selected, then
	/// only point data connected to a boundary point are smoothed, but boundary
	/// and interior points are not. (ALL_BUT_BOUNDARY and ADJACENT_TO_BOUNDARY
	/// are useful for transitioning from fixed boundary conditions to interior
	/// data.) If desired, it is possible to explicitly specify a smoothing mask
	/// controlling which points are smoothed and not smoothed. The default
	/// constraint strategy is ALL_POINTS.
	/// </summary>
	public virtual int GetSmoothingStrategyMaxValue()
	{
		return vtkAttributeSmoothingFilter_GetSmoothingStrategyMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeSmoothingFilter_GetSmoothingStrategyMinValue_16(HandleRef pThis);

	/// <summary>
	/// Indicate how to constrain smoothing of the attribute data. By default,
	/// all point data attributes are smoothed (ALL_POINTS). If ALL_BUT_BOUNDARY
	/// is selected, then all point attribute data except those on the boundary
	/// of the mesh are smoothed.  If ADJACENT_TO_BOUNDARY is selected, then
	/// only point data connected to a boundary point are smoothed, but boundary
	/// and interior points are not. (ALL_BUT_BOUNDARY and ADJACENT_TO_BOUNDARY
	/// are useful for transitioning from fixed boundary conditions to interior
	/// data.) If desired, it is possible to explicitly specify a smoothing mask
	/// controlling which points are smoothed and not smoothed. The default
	/// constraint strategy is ALL_POINTS.
	/// </summary>
	public virtual int GetSmoothingStrategyMinValue()
	{
		return vtkAttributeSmoothingFilter_GetSmoothingStrategyMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeSmoothingFilter_GetWeightsType_17(HandleRef pThis);

	/// <summary>
	/// Indicate how to compute weights, using 1) a simple average of all
	/// connected points in the stencil; 2) a distance-weighted (i.e., 1/r)
	/// approach; or 3) distance**2-weighted (i.e., 1/(r**2) interpolation
	/// weights). The default constraint strategy is distance**2-weighted (i.e.,
	/// DISTANCE2).
	/// </summary>
	public virtual int GetWeightsType()
	{
		return vtkAttributeSmoothingFilter_GetWeightsType_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeSmoothingFilter_GetWeightsTypeMaxValue_18(HandleRef pThis);

	/// <summary>
	/// Indicate how to compute weights, using 1) a simple average of all
	/// connected points in the stencil; 2) a distance-weighted (i.e., 1/r)
	/// approach; or 3) distance**2-weighted (i.e., 1/(r**2) interpolation
	/// weights). The default constraint strategy is distance**2-weighted (i.e.,
	/// DISTANCE2).
	/// </summary>
	public virtual int GetWeightsTypeMaxValue()
	{
		return vtkAttributeSmoothingFilter_GetWeightsTypeMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeSmoothingFilter_GetWeightsTypeMinValue_19(HandleRef pThis);

	/// <summary>
	/// Indicate how to compute weights, using 1) a simple average of all
	/// connected points in the stencil; 2) a distance-weighted (i.e., 1/r)
	/// approach; or 3) distance**2-weighted (i.e., 1/(r**2) interpolation
	/// weights). The default constraint strategy is distance**2-weighted (i.e.,
	/// DISTANCE2).
	/// </summary>
	public virtual int GetWeightsTypeMinValue()
	{
		return vtkAttributeSmoothingFilter_GetWeightsTypeMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeSmoothingFilter_IsA_20(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, to obtain type information, and
	/// print the state of a class instance.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAttributeSmoothingFilter_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeSmoothingFilter_IsTypeOf_21(string type);

	/// <summary>
	/// Standard methods for instantiation, to obtain type information, and
	/// print the state of a class instance.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAttributeSmoothingFilter_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAttributeSmoothingFilter_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, to obtain type information, and
	/// print the state of a class instance.
	/// </summary>
	public new vtkAttributeSmoothingFilter NewInstance()
	{
		vtkAttributeSmoothingFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAttributeSmoothingFilter_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAttributeSmoothingFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAttributeSmoothingFilter_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, to obtain type information, and
	/// print the state of a class instance.
	/// </summary>
	public new static vtkAttributeSmoothingFilter SafeDownCast(vtkObjectBase o)
	{
		vtkAttributeSmoothingFilter vtkAttributeSmoothingFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAttributeSmoothingFilter_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAttributeSmoothingFilter2 = (vtkAttributeSmoothingFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAttributeSmoothingFilter2.Register(null);
			}
		}
		return vtkAttributeSmoothingFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeSmoothingFilter_SetNumberOfIterations_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the maximum number of iterations for smoothing.  The default
	/// value is 5.
	/// </summary>
	public virtual void SetNumberOfIterations(int _arg)
	{
		vtkAttributeSmoothingFilter_SetNumberOfIterations_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeSmoothingFilter_SetRelaxationFactor_26(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the relaxation factor for smoothing. As in all iterative
	/// methods, the stability of the process is sensitive to this parameter. In
	/// general, small relaxation factors and large numbers of iterations are
	/// more stable than larger relaxation factors and smaller numbers of
	/// iterations. The default value is 0.10.
	/// </summary>
	public virtual void SetRelaxationFactor(double _arg)
	{
		vtkAttributeSmoothingFilter_SetRelaxationFactor_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeSmoothingFilter_SetSmoothingMask_27(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// Specify the smoothing mask to use (which takes effect only when a
	/// SMOOTHING_MASK smoothing strategy is specified). The smoothing mask is a
	/// vtkUnsignedCharArray with a value ==1 at all points whose attributes are
	/// to be smoothed.  The size of the data array must match the number of
	/// input points. If there is a mismatch between the size of the smoothing
	/// mask, and the number of input points, then an ALL_POINTS smoothing
	/// strategy is used.
	/// </summary>
	public virtual void SetSmoothingMask(vtkUnsignedCharArray _arg)
	{
		vtkAttributeSmoothingFilter_SetSmoothingMask_27(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeSmoothingFilter_SetSmoothingStrategy_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate how to constrain smoothing of the attribute data. By default,
	/// all point data attributes are smoothed (ALL_POINTS). If ALL_BUT_BOUNDARY
	/// is selected, then all point attribute data except those on the boundary
	/// of the mesh are smoothed.  If ADJACENT_TO_BOUNDARY is selected, then
	/// only point data connected to a boundary point are smoothed, but boundary
	/// and interior points are not. (ALL_BUT_BOUNDARY and ADJACENT_TO_BOUNDARY
	/// are useful for transitioning from fixed boundary conditions to interior
	/// data.) If desired, it is possible to explicitly specify a smoothing mask
	/// controlling which points are smoothed and not smoothed. The default
	/// constraint strategy is ALL_POINTS.
	/// </summary>
	public virtual void SetSmoothingStrategy(int _arg)
	{
		vtkAttributeSmoothingFilter_SetSmoothingStrategy_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeSmoothingFilter_SetSmoothingStrategyToAdjacentToBoundary_29(HandleRef pThis);

	/// <summary>
	/// Indicate how to constrain smoothing of the attribute data. By default,
	/// all point data attributes are smoothed (ALL_POINTS). If ALL_BUT_BOUNDARY
	/// is selected, then all point attribute data except those on the boundary
	/// of the mesh are smoothed.  If ADJACENT_TO_BOUNDARY is selected, then
	/// only point data connected to a boundary point are smoothed, but boundary
	/// and interior points are not. (ALL_BUT_BOUNDARY and ADJACENT_TO_BOUNDARY
	/// are useful for transitioning from fixed boundary conditions to interior
	/// data.) If desired, it is possible to explicitly specify a smoothing mask
	/// controlling which points are smoothed and not smoothed. The default
	/// constraint strategy is ALL_POINTS.
	/// </summary>
	public void SetSmoothingStrategyToAdjacentToBoundary()
	{
		vtkAttributeSmoothingFilter_SetSmoothingStrategyToAdjacentToBoundary_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeSmoothingFilter_SetSmoothingStrategyToAllButBoundary_30(HandleRef pThis);

	/// <summary>
	/// Indicate how to constrain smoothing of the attribute data. By default,
	/// all point data attributes are smoothed (ALL_POINTS). If ALL_BUT_BOUNDARY
	/// is selected, then all point attribute data except those on the boundary
	/// of the mesh are smoothed.  If ADJACENT_TO_BOUNDARY is selected, then
	/// only point data connected to a boundary point are smoothed, but boundary
	/// and interior points are not. (ALL_BUT_BOUNDARY and ADJACENT_TO_BOUNDARY
	/// are useful for transitioning from fixed boundary conditions to interior
	/// data.) If desired, it is possible to explicitly specify a smoothing mask
	/// controlling which points are smoothed and not smoothed. The default
	/// constraint strategy is ALL_POINTS.
	/// </summary>
	public void SetSmoothingStrategyToAllButBoundary()
	{
		vtkAttributeSmoothingFilter_SetSmoothingStrategyToAllButBoundary_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeSmoothingFilter_SetSmoothingStrategyToAllPoints_31(HandleRef pThis);

	/// <summary>
	/// Indicate how to constrain smoothing of the attribute data. By default,
	/// all point data attributes are smoothed (ALL_POINTS). If ALL_BUT_BOUNDARY
	/// is selected, then all point attribute data except those on the boundary
	/// of the mesh are smoothed.  If ADJACENT_TO_BOUNDARY is selected, then
	/// only point data connected to a boundary point are smoothed, but boundary
	/// and interior points are not. (ALL_BUT_BOUNDARY and ADJACENT_TO_BOUNDARY
	/// are useful for transitioning from fixed boundary conditions to interior
	/// data.) If desired, it is possible to explicitly specify a smoothing mask
	/// controlling which points are smoothed and not smoothed. The default
	/// constraint strategy is ALL_POINTS.
	/// </summary>
	public void SetSmoothingStrategyToAllPoints()
	{
		vtkAttributeSmoothingFilter_SetSmoothingStrategyToAllPoints_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeSmoothingFilter_SetSmoothingStrategyToSmoothingMask_32(HandleRef pThis);

	/// <summary>
	/// Indicate how to constrain smoothing of the attribute data. By default,
	/// all point data attributes are smoothed (ALL_POINTS). If ALL_BUT_BOUNDARY
	/// is selected, then all point attribute data except those on the boundary
	/// of the mesh are smoothed.  If ADJACENT_TO_BOUNDARY is selected, then
	/// only point data connected to a boundary point are smoothed, but boundary
	/// and interior points are not. (ALL_BUT_BOUNDARY and ADJACENT_TO_BOUNDARY
	/// are useful for transitioning from fixed boundary conditions to interior
	/// data.) If desired, it is possible to explicitly specify a smoothing mask
	/// controlling which points are smoothed and not smoothed. The default
	/// constraint strategy is ALL_POINTS.
	/// </summary>
	public void SetSmoothingStrategyToSmoothingMask()
	{
		vtkAttributeSmoothingFilter_SetSmoothingStrategyToSmoothingMask_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeSmoothingFilter_SetWeightsType_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate how to compute weights, using 1) a simple average of all
	/// connected points in the stencil; 2) a distance-weighted (i.e., 1/r)
	/// approach; or 3) distance**2-weighted (i.e., 1/(r**2) interpolation
	/// weights). The default constraint strategy is distance**2-weighted (i.e.,
	/// DISTANCE2).
	/// </summary>
	public virtual void SetWeightsType(int _arg)
	{
		vtkAttributeSmoothingFilter_SetWeightsType_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeSmoothingFilter_SetWeightsTypeToAverage_34(HandleRef pThis);

	/// <summary>
	/// Indicate how to compute weights, using 1) a simple average of all
	/// connected points in the stencil; 2) a distance-weighted (i.e., 1/r)
	/// approach; or 3) distance**2-weighted (i.e., 1/(r**2) interpolation
	/// weights). The default constraint strategy is distance**2-weighted (i.e.,
	/// DISTANCE2).
	/// </summary>
	public void SetWeightsTypeToAverage()
	{
		vtkAttributeSmoothingFilter_SetWeightsTypeToAverage_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeSmoothingFilter_SetWeightsTypeToDistance_35(HandleRef pThis);

	/// <summary>
	/// Indicate how to compute weights, using 1) a simple average of all
	/// connected points in the stencil; 2) a distance-weighted (i.e., 1/r)
	/// approach; or 3) distance**2-weighted (i.e., 1/(r**2) interpolation
	/// weights). The default constraint strategy is distance**2-weighted (i.e.,
	/// DISTANCE2).
	/// </summary>
	public void SetWeightsTypeToDistance()
	{
		vtkAttributeSmoothingFilter_SetWeightsTypeToDistance_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeSmoothingFilter_SetWeightsTypeToDistance2_36(HandleRef pThis);

	/// <summary>
	/// Indicate how to compute weights, using 1) a simple average of all
	/// connected points in the stencil; 2) a distance-weighted (i.e., 1/r)
	/// approach; or 3) distance**2-weighted (i.e., 1/(r**2) interpolation
	/// weights). The default constraint strategy is distance**2-weighted (i.e.,
	/// DISTANCE2).
	/// </summary>
	public void SetWeightsTypeToDistance2()
	{
		vtkAttributeSmoothingFilter_SetWeightsTypeToDistance2_36(GetCppThis());
	}
}
