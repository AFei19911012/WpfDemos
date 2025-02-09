using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSurfaceNets2D
/// </summary>
/// <remarks>
///    generate smoothed constours from segmented 2D image data (i.e., "label maps")
///
/// vtkSurfaceNets2D creates boundary/isocontour lines from a label map (e.g.,
/// a segmented image) using a threaded, 2D version of the multiple
/// regions/labels surface nets algorithm. The input is a 2D image where each
/// pixel is labeled (integer labels are preferred to real values), and the
/// output data is polygonal data separating labeled regions via line
/// segments. (Note that on output each region [corresponding to a different
/// segmented object] will share points/edges on a common boundary, i.e., two
/// objects next to each other will share the boundary that separates them.)
///
/// While this filter is similar to a contouring operation, classic contouring
/// methods assume a continuous scalar field. In comparison, label maps are
/// not continuous in scalar function value, meaning that usual data
/// interpolation (e.g., along edges) is not possible. Instead, when the edge
/// endpoint pixels are labeled in differing regions, the edge is split and
/// transected by a line segment that connects the center points of the squares
/// on either side of the edge. Later, using a energy minimization smoothing
/// process, these split edges will be adjusted to produce a smoother
/// result. (Constraints on smoothing displacements may be specified to
/// prevent excessive shrinkage and/or object distortion.)
///
/// The smoothing process is controlled by setting a convergence measure, the
/// number of smoothing iterations, the step size, and the allowed
/// (constraint) distance that points may move.  These can be adjusted to
/// provide the desired result. This class provides a method to access an
/// internal instance of vtkConstrainedSmoothingFilter, through which these
/// smoothing parameters may be specified, and which actually performs the
/// smoothing operation. (Note: it is possible to skip the smoothing process
/// altogether by disabling smoothing (e.g., invoking SmoothingOff()) or
/// setting the number of smoothing iterations to zero. This can
/// be useful when using a different smoothing filter like
/// vtkWindowedSincPolyDataFilter; or if an unsmoothed, aliased output is
/// desired. The reason the smoothing is built in to this filter is to remain
/// faithful to the published literature describing the surface nets
/// algorithm.)
///
/// The SurfaceNets algorithm was first proposed by Sarah Frisken.  Two
/// important papers include the description of surface nets for binary
/// objects (i.e., extracting just one segmented object from a volume) and
/// multi-label (multiple object extraction).
///
/// S. Frisken (Gibson), “Constrained Elastic SurfaceNets: Generating Smooth
/// Surfaces from Binary Segmented Data”, Proc. MICCAI, 1998, pp. 888-898.
///
/// S. Frisken, “SurfaceNets for Multi-Label Segmentations with Preservation
/// of Sharp Boundaries”, J. Computer Graphics Techniques, 2022.
///
/// Note that one nice feature of this filter is that algorithm execution
/// occurs only once no matter the number of object labels / contour
/// values. In many contouring-like algorithms, each separate contour value
/// requires an additional algorithm execution with a new contour value. So in
/// this filter large numbers of contour values do not significantly affect
/// overall speed. The user can specify which objects (i.e., labels) are to be
/// output to the filter. (Unspecified labels are treated as background and
/// not output.)
///
/// The filter can optionally output a two-component, cell data array
/// indicating the labels/regions on either side of the line segments
/// composing the output vtkPolyData. This can be used for advanced operations
/// like extracting shared/contacting boundaries between two objects. The name
/// of this cell data array is "BoundaryLabels".
///
/// Implementation note: For performance reasons, this filter is internally
/// implemented quite differently than described in the literature.  The main
/// difference is that concepts from the Flying Edges parallel isocontouring
/// algorithm are used. Namely, parallel, edge-by-edge processing is used to
/// define cell cases, generate smoothing stencils, and produce points and
/// output lines. The smoothing process is also threaded using a
/// double-buffering approach.
///
/// @warning
/// This filter is specialized to 2D images.
///
/// @warning
/// Subtle differences in the output may result when the number of objects /
/// labels changes. This is because the smoothing operation operates on all of
/// the boundaries simultaneously. If the boundaries change due to a
/// difference in the number of regions / labels, then the smoothing operation
/// can produce different results.
///
/// @warning
/// The filters vtkDiscreteMarchingCubes, vtkDiscreteFlyingEdges2D,
/// vtkDiscreteFlyingEdges3D, and vtkDiscreteFlyingEdgesClipper2D also
/// perform isocontour extraction. However these filters produce output
/// that may not share common boundary cells, and may produce "gaps"
/// between segmented regions. For example, vtkDiscreteMarchingCubes will
/// share points between adjacent regions, but not triangle cells (which
/// will be coincident). Also, no center point is inserted into voxels,
/// meaning that intermittent gaps may form between regions.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkSurfaceNets3D vtkDiscreteFlyingEdges2D vtkDiscreteFlyingEdgesClipper2D
/// vtkConstrainedSmoothingFilter vtkFlyingEdges2D vtkFlyingEdges3D
/// vtkWindowedSincPolyDataFilter
/// </seealso>
public class vtkSurfaceNets2D : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSurfaceNets2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSurfaceNets2D()
	{
		MRClassNameKey = "class vtkSurfaceNets2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSurfaceNets2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSurfaceNets2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSurfaceNets2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public new static vtkSurfaceNets2D New()
	{
		vtkSurfaceNets2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSurfaceNets2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSurfaceNets2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public vtkSurfaceNets2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSurfaceNets2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_ComputeScalarsOff_01(HandleRef pThis);

	/// <summary>
	/// Enable/disable an option to generate cell scalars in the output. The
	/// cell scalars are a two-tuple that indicates which labels (i.e.,
	/// segmented regions) are on either side of each (line) cell (l0,l1) with
	/// l0&lt;l1.  If an object is one-sided (meaning the background is on one side
	/// of the line) then l1=(OutsideLabel). The name of the output cell scalars is
	/// "BoundaryLabels". By default this flag is on.
	/// </summary>
	public virtual void ComputeScalarsOff()
	{
		vtkSurfaceNets2D_ComputeScalarsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_ComputeScalarsOn_02(HandleRef pThis);

	/// <summary>
	/// Enable/disable an option to generate cell scalars in the output. The
	/// cell scalars are a two-tuple that indicates which labels (i.e.,
	/// segmented regions) are on either side of each (line) cell (l0,l1) with
	/// l0&lt;l1.  If an object is one-sided (meaning the background is on one side
	/// of the line) then l1=(OutsideLabel). The name of the output cell scalars is
	/// "BoundaryLabels". By default this flag is on.
	/// </summary>
	public virtual void ComputeScalarsOn()
	{
		vtkSurfaceNets2D_ComputeScalarsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_DataCachingOff_03(HandleRef pThis);

	/// <summary>
	/// Enable caching of intermediate data. A common workflow using this filter
	/// requires extracting object boundaries, and then repeatedly rerunning the
	/// smoothing process with different parameters. To improve performance by
	/// avoiding repeated extraction of the boundary, the filter can cache
	/// intermediate data prior to the smoothing process. In this way, the
	/// boundary is only extracted once, and as long as only the internal
	/// constrained smoothing filter is modified, then boundary extraction will
	/// not be reexecuted. By default this is enabled.
	/// </summary>
	public virtual void DataCachingOff()
	{
		vtkSurfaceNets2D_DataCachingOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_DataCachingOn_04(HandleRef pThis);

	/// <summary>
	/// Enable caching of intermediate data. A common workflow using this filter
	/// requires extracting object boundaries, and then repeatedly rerunning the
	/// smoothing process with different parameters. To improve performance by
	/// avoiding repeated extraction of the boundary, the filter can cache
	/// intermediate data prior to the smoothing process. In this way, the
	/// boundary is only extracted once, and as long as only the internal
	/// constrained smoothing filter is modified, then boundary extraction will
	/// not be reexecuted. By default this is enabled.
	/// </summary>
	public virtual void DataCachingOn()
	{
		vtkSurfaceNets2D_DataCachingOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_GenerateLabels_05(HandleRef pThis, int numLabels, IntPtr range);

	/// <summary>
	/// Generate numLabels equally spaced labels between the specified
	/// range. The labels will include the min/max range values.
	/// </summary>
	public void GenerateLabels(int numLabels, IntPtr range)
	{
		vtkSurfaceNets2D_GenerateLabels_05(GetCppThis(), numLabels, range);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_GenerateLabels_06(HandleRef pThis, int numLabels, double rangeStart, double rangeEnd);

	/// <summary>
	/// Generate numLabels equally spaced labels between the specified
	/// range. The labels will include the min/max range values.
	/// </summary>
	public void GenerateLabels(int numLabels, double rangeStart, double rangeEnd)
	{
		vtkSurfaceNets2D_GenerateLabels_06(GetCppThis(), numLabels, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_GenerateValues_07(HandleRef pThis, int numContours, IntPtr range);

	/// <summary>
	/// Generate numLabels equally spaced labels between the specified
	/// range. The labels will include the min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, IntPtr range)
	{
		vtkSurfaceNets2D_GenerateValues_07(GetCppThis(), numContours, range);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_GenerateValues_08(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

	/// <summary>
	/// Generate numLabels equally spaced labels between the specified
	/// range. The labels will include the min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
	{
		vtkSurfaceNets2D_GenerateValues_08(GetCppThis(), numContours, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSurfaceNets2D_GetArrayComponent_09(HandleRef pThis);

	/// <summary>
	/// Set/get which component of a input multi-component scalar array to
	/// contour with; defaults to component 0.
	/// </summary>
	public virtual int GetArrayComponent()
	{
		return vtkSurfaceNets2D_GetArrayComponent_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSurfaceNets2D_GetBackgroundLabel_10(HandleRef pThis);

	/// <summary>
	/// If computing cell scalars, specify the label to use when referencing a
	/// labeled region outside any of the specified regions (i.e., when
	/// referencing the background region). By default this value is zero. Be
	/// very careful of the value being used here, it should not overlap an
	/// extracted label value, and because it is the same type as the input
	/// image scalars, make sure the value can be properly represented (i.e., if
	/// the input scalars are an unsigned type, then BackgroundLabel should not
	/// be negative).
	/// </summary>
	public virtual double GetBackgroundLabel()
	{
		return vtkSurfaceNets2D_GetBackgroundLabel_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSurfaceNets2D_GetComputeScalars_11(HandleRef pThis);

	/// <summary>
	/// Enable/disable an option to generate cell scalars in the output. The
	/// cell scalars are a two-tuple that indicates which labels (i.e.,
	/// segmented regions) are on either side of each (line) cell (l0,l1) with
	/// l0&lt;l1.  If an object is one-sided (meaning the background is on one side
	/// of the line) then l1=(OutsideLabel). The name of the output cell scalars is
	/// "BoundaryLabels". By default this flag is on.
	/// </summary>
	public virtual bool GetComputeScalars()
	{
		return (vtkSurfaceNets2D_GetComputeScalars_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSurfaceNets2D_GetDataCaching_12(HandleRef pThis);

	/// <summary>
	/// Enable caching of intermediate data. A common workflow using this filter
	/// requires extracting object boundaries, and then repeatedly rerunning the
	/// smoothing process with different parameters. To improve performance by
	/// avoiding repeated extraction of the boundary, the filter can cache
	/// intermediate data prior to the smoothing process. In this way, the
	/// boundary is only extracted once, and as long as only the internal
	/// constrained smoothing filter is modified, then boundary extraction will
	/// not be reexecuted. By default this is enabled.
	/// </summary>
	public virtual bool GetDataCaching()
	{
		return (vtkSurfaceNets2D_GetDataCaching_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSurfaceNets2D_GetLabel_13(HandleRef pThis, int i);

	/// <summary>
	/// Get the ith label value.
	/// </summary>
	public double GetLabel(int i)
	{
		return vtkSurfaceNets2D_GetLabel_13(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSurfaceNets2D_GetLabels_14(HandleRef pThis);

	/// <summary>
	/// Get a pointer to an array of labels. There will be
	/// GetNumberOfLabels() values in the list.
	/// </summary>
	public IntPtr GetLabels()
	{
		return vtkSurfaceNets2D_GetLabels_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_GetLabels_15(HandleRef pThis, IntPtr contourValues);

	/// <summary>
	/// Fill a supplied list with label values. There will be
	/// GetNumberOfLabels() values in the list. Make sure you allocate enough
	/// memory to hold the list.
	/// </summary>
	public void GetLabels(IntPtr contourValues)
	{
		vtkSurfaceNets2D_GetLabels_15(GetCppThis(), contourValues);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkSurfaceNets2D_GetMTime_16(HandleRef pThis);

	/// <summary>
	/// The modified time is also a function of the label values and
	/// the smoothing filter.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkSurfaceNets2D_GetMTime_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSurfaceNets2D_GetNumberOfContours_17(HandleRef pThis);

	/// <summary>
	/// Get the number of labels in the list of label values.
	/// </summary>
	public long GetNumberOfContours()
	{
		return vtkSurfaceNets2D_GetNumberOfContours_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSurfaceNets2D_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSurfaceNets2D_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSurfaceNets2D_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSurfaceNets2D_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSurfaceNets2D_GetNumberOfLabels_20(HandleRef pThis);

	/// <summary>
	/// Get the number of labels in the list of label values.
	/// </summary>
	public long GetNumberOfLabels()
	{
		return vtkSurfaceNets2D_GetNumberOfLabels_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSurfaceNets2D_GetSmoother_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the instance of vtkConstrainedSmoothingFilter used to smooth the
	/// extracted surface net. To control smoothing, access this instance and
	/// specify its parameters such as number of smoothing iterations and
	/// constraint distance. If you wish to disable smoothing, set
	/// SmoothingOff().
	/// </summary>
	public virtual vtkConstrainedSmoothingFilter GetSmoother()
	{
		vtkConstrainedSmoothingFilter vtkConstrainedSmoothingFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSurfaceNets2D_GetSmoother_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkConstrainedSmoothingFilter2 = (vtkConstrainedSmoothingFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkConstrainedSmoothingFilter2.Register(null);
			}
		}
		return vtkConstrainedSmoothingFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSurfaceNets2D_GetSmoothing_22(HandleRef pThis);

	/// <summary>
	/// Indicate whether smoothing should be enabled. By default, after the
	/// isoline is extracted, smoothing occurs using the built-in smoother.
	/// To disable smoothing, invoke SmoothingOff().
	/// </summary>
	public virtual bool GetSmoothing()
	{
		return (vtkSurfaceNets2D_GetSmoothing_22(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSurfaceNets2D_GetValue_23(HandleRef pThis, int i);

	/// <summary>
	/// Get the ith label value.
	/// </summary>
	public double GetValue(int i)
	{
		return vtkSurfaceNets2D_GetValue_23(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSurfaceNets2D_GetValues_24(HandleRef pThis);

	/// <summary>
	/// Get a pointer to an array of labels. There will be
	/// GetNumberOfLabels() values in the list.
	/// </summary>
	public IntPtr GetValues()
	{
		return vtkSurfaceNets2D_GetValues_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_GetValues_25(HandleRef pThis, IntPtr contourValues);

	/// <summary>
	/// Fill a supplied list with label values. There will be
	/// GetNumberOfLabels() values in the list. Make sure you allocate enough
	/// memory to hold the list.
	/// </summary>
	public void GetValues(IntPtr contourValues)
	{
		vtkSurfaceNets2D_GetValues_25(GetCppThis(), contourValues);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSurfaceNets2D_IsA_26(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSurfaceNets2D_IsA_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSurfaceNets2D_IsTypeOf_27(string type);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSurfaceNets2D_IsTypeOf_27(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSurfaceNets2D_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public new vtkSurfaceNets2D NewInstance()
	{
		vtkSurfaceNets2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSurfaceNets2D_NewInstance_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSurfaceNets2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSurfaceNets2D_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, printing, and type information.
	/// </summary>
	public new static vtkSurfaceNets2D SafeDownCast(vtkObjectBase o)
	{
		vtkSurfaceNets2D vtkSurfaceNets2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSurfaceNets2D_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSurfaceNets2D2 = (vtkSurfaceNets2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSurfaceNets2D2.Register(null);
			}
		}
		return vtkSurfaceNets2D2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_SetArrayComponent_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get which component of a input multi-component scalar array to
	/// contour with; defaults to component 0.
	/// </summary>
	public virtual void SetArrayComponent(int _arg)
	{
		vtkSurfaceNets2D_SetArrayComponent_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_SetBackgroundLabel_32(HandleRef pThis, double _arg);

	/// <summary>
	/// If computing cell scalars, specify the label to use when referencing a
	/// labeled region outside any of the specified regions (i.e., when
	/// referencing the background region). By default this value is zero. Be
	/// very careful of the value being used here, it should not overlap an
	/// extracted label value, and because it is the same type as the input
	/// image scalars, make sure the value can be properly represented (i.e., if
	/// the input scalars are an unsigned type, then BackgroundLabel should not
	/// be negative).
	/// </summary>
	public virtual void SetBackgroundLabel(double _arg)
	{
		vtkSurfaceNets2D_SetBackgroundLabel_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_SetComputeScalars_33(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable/disable an option to generate cell scalars in the output. The
	/// cell scalars are a two-tuple that indicates which labels (i.e.,
	/// segmented regions) are on either side of each (line) cell (l0,l1) with
	/// l0&lt;l1.  If an object is one-sided (meaning the background is on one side
	/// of the line) then l1=(OutsideLabel). The name of the output cell scalars is
	/// "BoundaryLabels". By default this flag is on.
	/// </summary>
	public virtual void SetComputeScalars(bool _arg)
	{
		vtkSurfaceNets2D_SetComputeScalars_33(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_SetDataCaching_34(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable caching of intermediate data. A common workflow using this filter
	/// requires extracting object boundaries, and then repeatedly rerunning the
	/// smoothing process with different parameters. To improve performance by
	/// avoiding repeated extraction of the boundary, the filter can cache
	/// intermediate data prior to the smoothing process. In this way, the
	/// boundary is only extracted once, and as long as only the internal
	/// constrained smoothing filter is modified, then boundary extraction will
	/// not be reexecuted. By default this is enabled.
	/// </summary>
	public virtual void SetDataCaching(bool _arg)
	{
		vtkSurfaceNets2D_SetDataCaching_34(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_SetLabel_35(HandleRef pThis, int i, double value);

	/// <summary>
	/// Set a particular label value at label number i. The index i ranges
	/// between 0 &lt;= i &lt;NumberOfLabels. (Note: while labels values are expressed
	/// as doubles, the underlying scalar data may be a different type. During
	/// execution the label values are cast to the type of the scalar data.)
	/// Note the use of "Value" and "Label" when specifying regions to
	/// extract. The use of "Value" is continuous with other VTK
	/// continuous-scalar field isocontouring algorithms; however the term
	/// "Label" is more consistent with label maps.
	/// </summary>
	public void SetLabel(int i, double value)
	{
		vtkSurfaceNets2D_SetLabel_35(GetCppThis(), i, value);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_SetNumberOfContours_36(HandleRef pThis, int number);

	/// <summary>
	/// Set the number of labels to place into the list. You only really need to
	/// use this method to reduce list size. The method SetValue() will
	/// automatically increase list size as needed. Note that for consistency
	/// with other isocountoring-related algorithms, some methods use
	/// "Labels" and "Contours" interchangeably.
	/// </summary>
	public void SetNumberOfContours(int number)
	{
		vtkSurfaceNets2D_SetNumberOfContours_36(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_SetNumberOfLabels_37(HandleRef pThis, int number);

	/// <summary>
	/// Set the number of labels to place into the list. You only really need to
	/// use this method to reduce list size. The method SetValue() will
	/// automatically increase list size as needed. Note that for consistency
	/// with other isocountoring-related algorithms, some methods use
	/// "Labels" and "Contours" interchangeably.
	/// </summary>
	public void SetNumberOfLabels(int number)
	{
		vtkSurfaceNets2D_SetNumberOfLabels_37(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_SetSmoothing_38(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether smoothing should be enabled. By default, after the
	/// isoline is extracted, smoothing occurs using the built-in smoother.
	/// To disable smoothing, invoke SmoothingOff().
	/// </summary>
	public virtual void SetSmoothing(bool _arg)
	{
		vtkSurfaceNets2D_SetSmoothing_38(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_SetValue_39(HandleRef pThis, int i, double value);

	/// <summary>
	/// Set a particular label value at label number i. The index i ranges
	/// between 0 &lt;= i &lt;NumberOfLabels. (Note: while labels values are expressed
	/// as doubles, the underlying scalar data may be a different type. During
	/// execution the label values are cast to the type of the scalar data.)
	/// Note the use of "Value" and "Label" when specifying regions to
	/// extract. The use of "Value" is continuous with other VTK
	/// continuous-scalar field isocontouring algorithms; however the term
	/// "Label" is more consistent with label maps.
	/// </summary>
	public void SetValue(int i, double value)
	{
		vtkSurfaceNets2D_SetValue_39(GetCppThis(), i, value);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_SmoothingOff_40(HandleRef pThis);

	/// <summary>
	/// Indicate whether smoothing should be enabled. By default, after the
	/// isoline is extracted, smoothing occurs using the built-in smoother.
	/// To disable smoothing, invoke SmoothingOff().
	/// </summary>
	public virtual void SmoothingOff()
	{
		vtkSurfaceNets2D_SmoothingOff_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSurfaceNets2D_SmoothingOn_41(HandleRef pThis);

	/// <summary>
	/// Indicate whether smoothing should be enabled. By default, after the
	/// isoline is extracted, smoothing occurs using the built-in smoother.
	/// To disable smoothing, invoke SmoothingOff().
	/// </summary>
	public virtual void SmoothingOn()
	{
		vtkSurfaceNets2D_SmoothingOn_41(GetCppThis());
	}
}
