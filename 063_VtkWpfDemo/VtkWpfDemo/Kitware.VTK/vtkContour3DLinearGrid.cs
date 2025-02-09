using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkContour3DLinearGrid
/// </summary>
/// <remarks>
///    fast generation of isosurface from 3D linear cells
///
/// vtkContour3DLinearGrid is a specialized filter that generates isocontours
/// from an input vtkUnstructuredGrid consisting of 3D linear cells:
/// tetrahedra, hexahedra, voxels, pyramids, and/or wedges. (The cells are
/// linear in the sense that each cell edge is a straight line.) The filter is
/// designed for high-speed, specialized operation. All other cell types are
/// skipped and produce no output. (Note: the filter will also process
/// input vtkCompositeDataSets containing vtkUnstructuredGrids.)
///
/// To use this filter you must specify an input unstructured grid or
/// vtkCompositeDataSet, and one or more contour values.  You can either use
/// the method SetValue() to specify each contour value, or use
/// GenerateValues() to generate a series of evenly spaced contours.
///
/// The filter performance varies depending on optional output
/// information. Basically if point merging is required (when PointMerging,
/// InterpolateAttributes, and/or ComputeNormals is enabled), a sorting
/// process is required to eliminate duplicate output points in the
/// isosurface. Otherwise when point merging is not required, a fast path
/// process produces independent triangles representing the isosurface. In
/// many situations the results of the fast path are quite good and do not
/// require additional processing.
///
/// Note that another performance option exists, using a vtkScalarTree, which
/// is an object that accelerates isosurface extraction, at the initial cost
/// of building the scalar tree. (This feature is useful for exploratory
/// isosurface extraction when the isovalue is frequently changed.) In some
/// cases this can improve performance, however this algorithm is so highly
/// tuned that random memory jumps (due to random access of cells provided by
/// the scalar tree) can actually negatively impact performance, especially if
/// the input dataset type consists of homogeneous cell types.
///
/// @warning
/// When the input is of type vtkCompositeDataSet the filter will process the
/// unstructured grid(s) contained in the composite data set. As a result the
/// output of this filter is then a vtkMultiBlockDataSet containing multiple
/// vtkPolyData. When a vtkUnstructuredGrid is provided as input the
/// output is a single vtkPolyData.
///
/// @warning
/// The fast path simply produces output points and triangles (the fast path
/// executes when MergePoints if off; InterpolateAttributes is off; and
/// ComputeNormals is off). Since the fast path does not merge points, it
/// produces many more output points, typically on the order of 5-6x more than
/// when MergePoints is enabled. Adding in the other options point merging,
/// field interpolation, and normal generation results in additional
/// performance impacts. By default the fast path is enabled.
///
/// @warning
/// When a vtkCompositeDataSet is provided as input, and UseScalarTree is
/// enabled and a ScalarTree specified, then the specified scalar tree is
/// cloned to create new ones for each dataset in the composite
/// dataset. Otherwise (i.e., when vtkUnstructuredGrid input) the specified
/// scalar tree is directly used (no cloning required).
///
/// @warning
/// Internal to this filter, a caching iterator is used to traverse the cells
/// that compose the vtkUnstructuredGrid. Maximum performance is obtained if
/// the cells are all of one type (i.e., input grid of homogeneous cell
/// types); repeated switching from different types may have detrimental
/// effects on performance.
///
/// @warning
/// For unstructured data, gradients are not computed. Normals are computed if
/// requested; they are "pseudo-normals" in that the normals of output
/// triangles that use a common point are averaged at the point. Alternatively
/// use vtkPolyDataNormals to compute the surface normals.
///
/// @warning
/// The output of this filter is subtly different than the more general filter
/// vtkContourGrid. vtkContourGrid eliminates small, degenerate triangles with
/// concident points which are consequently not sent to the output. In
/// practice this makes little impact on visual appearance but may have
/// repercussions if the output is used for modelling and/or analysis.
///
/// @warning
/// Input cells that are not of 3D linear type (tetrahedron, hexahedron,
/// wedge, pyramid, and voxel) are simply skipped and not processed.
///
/// @warning
/// The filter is templated on types of input and output points, and input
/// scalar type. To reduce object file bloat, only real points (float,double) are
/// processed, and a limited subset of scalar types.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkContourGrid vtkContourFilter vtkFlyingEdges3D vtkMarchingCubes
/// vtkPolyDataNormals vtkStaticEdgeLocatorTemplate.h vtkScalarTree
/// vtkSpanSpace
/// </seealso>
public class vtkContour3DLinearGrid : vtkDataObjectAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkContour3DLinearGrid";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkContour3DLinearGrid()
	{
		MRClassNameKey = "class vtkContour3DLinearGrid";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkContour3DLinearGrid"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkContour3DLinearGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContour3DLinearGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static vtkContour3DLinearGrid New()
	{
		vtkContour3DLinearGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContour3DLinearGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContour3DLinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public vtkContour3DLinearGrid()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkContour3DLinearGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkContour3DLinearGrid_CanFullyProcessDataObject_01(HandleRef arg0, string scalarArrayName);

	/// <summary>
	/// Returns true if the data object passed in is fully supported by this
	/// filter, i.e., all cell types are linear. For composite datasets, this
	/// means all dataset leaves have only linear cell types that can be processed
	/// by this filter. The second array is the name of the array to process.
	/// </summary>
	public static bool CanFullyProcessDataObject(vtkDataObject arg0, string scalarArrayName)
	{
		return (vtkContour3DLinearGrid_CanFullyProcessDataObject_01(arg0?.GetCppThis() ?? default(HandleRef), scalarArrayName) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_ComputeNormalsOff_02(HandleRef pThis);

	/// <summary>
	/// Indicate whether to compute output point normals. An averaging method is
	/// used to average shared triangle normals. By default this if off. This is
	/// a relatively expensive option so use judiciously.
	/// </summary>
	public virtual void ComputeNormalsOff()
	{
		vtkContour3DLinearGrid_ComputeNormalsOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_ComputeNormalsOn_03(HandleRef pThis);

	/// <summary>
	/// Indicate whether to compute output point normals. An averaging method is
	/// used to average shared triangle normals. By default this if off. This is
	/// a relatively expensive option so use judiciously.
	/// </summary>
	public virtual void ComputeNormalsOn()
	{
		vtkContour3DLinearGrid_ComputeNormalsOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_ComputeScalarsOff_04(HandleRef pThis);

	/// <summary>
	/// Set/Get flag to compute scalars. When enabled, and when the
	///             InterpolateAttributes option is on, vtkContour3DLinearGrid will add an
	///             array corresponding to the array used to compute the contour and
	///             populate it with values.
	/// </summary>
	public virtual void ComputeScalarsOff()
	{
		vtkContour3DLinearGrid_ComputeScalarsOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_ComputeScalarsOn_05(HandleRef pThis);

	/// <summary>
	/// Set/Get flag to compute scalars. When enabled, and when the
	///             InterpolateAttributes option is on, vtkContour3DLinearGrid will add an
	///             array corresponding to the array used to compute the contour and
	///             populate it with values.
	/// </summary>
	public virtual void ComputeScalarsOn()
	{
		vtkContour3DLinearGrid_ComputeScalarsOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_GenerateValues_06(HandleRef pThis, int numContours, IntPtr range);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public void GenerateValues(int numContours, IntPtr range)
	{
		vtkContour3DLinearGrid_GenerateValues_06(GetCppThis(), numContours, range);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_GenerateValues_07(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
	{
		vtkContour3DLinearGrid_GenerateValues_07(GetCppThis(), numContours, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContour3DLinearGrid_GetComputeNormals_08(HandleRef pThis);

	/// <summary>
	/// Indicate whether to compute output point normals. An averaging method is
	/// used to average shared triangle normals. By default this if off. This is
	/// a relatively expensive option so use judiciously.
	/// </summary>
	public virtual int GetComputeNormals()
	{
		return vtkContour3DLinearGrid_GetComputeNormals_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContour3DLinearGrid_GetComputeScalars_09(HandleRef pThis);

	/// <summary>
	/// Set/Get flag to compute scalars. When enabled, and when the
	///             InterpolateAttributes option is on, vtkContour3DLinearGrid will add an
	///             array corresponding to the array used to compute the contour and
	///             populate it with values.
	/// </summary>
	public virtual int GetComputeScalars()
	{
		return vtkContour3DLinearGrid_GetComputeScalars_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContour3DLinearGrid_GetInterpolateAttributes_10(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate input attributes onto the isosurface. By
	/// default this option is off.
	/// </summary>
	public virtual int GetInterpolateAttributes()
	{
		return vtkContour3DLinearGrid_GetInterpolateAttributes_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkContour3DLinearGrid_GetLargeIds_11(HandleRef pThis);

	/// <summary>
	/// Inform the user as to whether large ids were used during filter
	/// execution. This flag only has meaning after the filter has executed.
	/// Large ids are used when the id of the larges cell or point is greater
	/// than signed 32-bit precision. (Smaller ids reduce memory usage and speed
	/// computation. Note that LargeIds are only available on 64-bit
	/// architectures.)
	/// </summary>
	public bool GetLargeIds()
	{
		return (vtkContour3DLinearGrid_GetLargeIds_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkContour3DLinearGrid_GetMTime_12(HandleRef pThis);

	/// <summary>
	/// Overloaded GetMTime() because of delegation to the internal
	/// vtkContourValues class.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkContour3DLinearGrid_GetMTime_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContour3DLinearGrid_GetMergePoints_13(HandleRef pThis);

	/// <summary>
	/// Indicate whether to merge coincident points. This takes extra time and
	/// produces fewer output points, creating a "watertight" contour
	/// surface. By default this is off.
	/// </summary>
	public virtual int GetMergePoints()
	{
		return vtkContour3DLinearGrid_GetMergePoints_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContour3DLinearGrid_GetNumberOfContours_14(HandleRef pThis);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public long GetNumberOfContours()
	{
		return vtkContour3DLinearGrid_GetNumberOfContours_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContour3DLinearGrid_GetNumberOfGenerationsFromBase_15(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkContour3DLinearGrid_GetNumberOfGenerationsFromBase_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContour3DLinearGrid_GetNumberOfGenerationsFromBaseType_16(string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkContour3DLinearGrid_GetNumberOfGenerationsFromBaseType_16(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContour3DLinearGrid_GetNumberOfThreadsUsed_17(HandleRef pThis);

	/// <summary>
	///  Return the number of threads actually used during execution. This is
	///  valid only after algorithm execution.
	/// </summary>
	public int GetNumberOfThreadsUsed()
	{
		return vtkContour3DLinearGrid_GetNumberOfThreadsUsed_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContour3DLinearGrid_GetOutputPointsPrecision_18(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::Precision enum for an explanation of the available
	/// precision settings.
	/// </summary>
	public int GetOutputPointsPrecision()
	{
		return vtkContour3DLinearGrid_GetOutputPointsPrecision_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContour3DLinearGrid_GetScalarTree_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the scalar tree to use. By default a vtkSpanSpace scalar tree is
	/// used.
	/// </summary>
	public virtual vtkScalarTree GetScalarTree()
	{
		vtkScalarTree vtkScalarTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContour3DLinearGrid_GetScalarTree_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarTree2 = (vtkScalarTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarTree2.Register(null);
			}
		}
		return vtkScalarTree2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContour3DLinearGrid_GetSequentialProcessing_20(HandleRef pThis);

	/// <summary>
	/// Force sequential processing (i.e. single thread) of the contouring
	/// process. By default, sequential processing is off. Note this flag only
	/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
	/// set to something other than Sequential. (If set to Sequential, then the
	/// filter always runs in serial mode.) This flag is typically used for
	/// benchmarking purposes.
	/// </summary>
	public virtual int GetSequentialProcessing()
	{
		return vtkContour3DLinearGrid_GetSequentialProcessing_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContour3DLinearGrid_GetUseScalarTree_21(HandleRef pThis);

	/// <summary>
	/// Enable the use of a scalar tree to accelerate contour extraction. By
	/// default this is off. If enabled, and a scalar tree is not specified, then
	/// a vtkSpanSpace instance will be constructed and used.
	/// </summary>
	public virtual int GetUseScalarTree()
	{
		return vtkContour3DLinearGrid_GetUseScalarTree_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkContour3DLinearGrid_GetValue_22(HandleRef pThis, int i);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public double GetValue(int i)
	{
		return vtkContour3DLinearGrid_GetValue_22(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContour3DLinearGrid_GetValues_23(HandleRef pThis);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public IntPtr GetValues()
	{
		return vtkContour3DLinearGrid_GetValues_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_GetValues_24(HandleRef pThis, IntPtr contourValues);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public void GetValues(IntPtr contourValues)
	{
		vtkContour3DLinearGrid_GetValues_24(GetCppThis(), contourValues);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_InterpolateAttributesOff_25(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate input attributes onto the isosurface. By
	/// default this option is off.
	/// </summary>
	public virtual void InterpolateAttributesOff()
	{
		vtkContour3DLinearGrid_InterpolateAttributesOff_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_InterpolateAttributesOn_26(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate input attributes onto the isosurface. By
	/// default this option is off.
	/// </summary>
	public virtual void InterpolateAttributesOn()
	{
		vtkContour3DLinearGrid_InterpolateAttributesOn_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContour3DLinearGrid_IsA_27(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkContour3DLinearGrid_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContour3DLinearGrid_IsTypeOf_28(string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkContour3DLinearGrid_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_MergePointsOff_29(HandleRef pThis);

	/// <summary>
	/// Indicate whether to merge coincident points. This takes extra time and
	/// produces fewer output points, creating a "watertight" contour
	/// surface. By default this is off.
	/// </summary>
	public virtual void MergePointsOff()
	{
		vtkContour3DLinearGrid_MergePointsOff_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_MergePointsOn_30(HandleRef pThis);

	/// <summary>
	/// Indicate whether to merge coincident points. This takes extra time and
	/// produces fewer output points, creating a "watertight" contour
	/// surface. By default this is off.
	/// </summary>
	public virtual void MergePointsOn()
	{
		vtkContour3DLinearGrid_MergePointsOn_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContour3DLinearGrid_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new vtkContour3DLinearGrid NewInstance()
	{
		vtkContour3DLinearGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContour3DLinearGrid_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContour3DLinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContour3DLinearGrid_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static vtkContour3DLinearGrid SafeDownCast(vtkObjectBase o)
	{
		vtkContour3DLinearGrid vtkContour3DLinearGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContour3DLinearGrid_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContour3DLinearGrid2 = (vtkContour3DLinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContour3DLinearGrid2.Register(null);
			}
		}
		return vtkContour3DLinearGrid2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_SequentialProcessingOff_34(HandleRef pThis);

	/// <summary>
	/// Force sequential processing (i.e. single thread) of the contouring
	/// process. By default, sequential processing is off. Note this flag only
	/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
	/// set to something other than Sequential. (If set to Sequential, then the
	/// filter always runs in serial mode.) This flag is typically used for
	/// benchmarking purposes.
	/// </summary>
	public virtual void SequentialProcessingOff()
	{
		vtkContour3DLinearGrid_SequentialProcessingOff_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_SequentialProcessingOn_35(HandleRef pThis);

	/// <summary>
	/// Force sequential processing (i.e. single thread) of the contouring
	/// process. By default, sequential processing is off. Note this flag only
	/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
	/// set to something other than Sequential. (If set to Sequential, then the
	/// filter always runs in serial mode.) This flag is typically used for
	/// benchmarking purposes.
	/// </summary>
	public virtual void SequentialProcessingOn()
	{
		vtkContour3DLinearGrid_SequentialProcessingOn_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_SetComputeNormals_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether to compute output point normals. An averaging method is
	/// used to average shared triangle normals. By default this if off. This is
	/// a relatively expensive option so use judiciously.
	/// </summary>
	public virtual void SetComputeNormals(int _arg)
	{
		vtkContour3DLinearGrid_SetComputeNormals_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_SetComputeScalars_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get flag to compute scalars. When enabled, and when the
	///             InterpolateAttributes option is on, vtkContour3DLinearGrid will add an
	///             array corresponding to the array used to compute the contour and
	///             populate it with values.
	/// </summary>
	public virtual void SetComputeScalars(int _arg)
	{
		vtkContour3DLinearGrid_SetComputeScalars_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_SetInterpolateAttributes_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether to interpolate input attributes onto the isosurface. By
	/// default this option is off.
	/// </summary>
	public virtual void SetInterpolateAttributes(int _arg)
	{
		vtkContour3DLinearGrid_SetInterpolateAttributes_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_SetMergePoints_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether to merge coincident points. This takes extra time and
	/// produces fewer output points, creating a "watertight" contour
	/// surface. By default this is off.
	/// </summary>
	public virtual void SetMergePoints(int _arg)
	{
		vtkContour3DLinearGrid_SetMergePoints_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_SetNumberOfContours_40(HandleRef pThis, int number);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public void SetNumberOfContours(int number)
	{
		vtkContour3DLinearGrid_SetNumberOfContours_40(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_SetOutputPointsPrecision_41(HandleRef pThis, int precision);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::Precision enum for an explanation of the available
	/// precision settings.
	/// </summary>
	public void SetOutputPointsPrecision(int precision)
	{
		vtkContour3DLinearGrid_SetOutputPointsPrecision_41(GetCppThis(), precision);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_SetScalarTree_42(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the scalar tree to use. By default a vtkSpanSpace scalar tree is
	/// used.
	/// </summary>
	public virtual void SetScalarTree(vtkScalarTree arg0)
	{
		vtkContour3DLinearGrid_SetScalarTree_42(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_SetSequentialProcessing_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Force sequential processing (i.e. single thread) of the contouring
	/// process. By default, sequential processing is off. Note this flag only
	/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
	/// set to something other than Sequential. (If set to Sequential, then the
	/// filter always runs in serial mode.) This flag is typically used for
	/// benchmarking purposes.
	/// </summary>
	public virtual void SetSequentialProcessing(int _arg)
	{
		vtkContour3DLinearGrid_SetSequentialProcessing_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_SetUseScalarTree_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable the use of a scalar tree to accelerate contour extraction. By
	/// default this is off. If enabled, and a scalar tree is not specified, then
	/// a vtkSpanSpace instance will be constructed and used.
	/// </summary>
	public virtual void SetUseScalarTree(int _arg)
	{
		vtkContour3DLinearGrid_SetUseScalarTree_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_SetValue_45(HandleRef pThis, int i, double value);

	/// <summary>
	/// Methods to set / get contour values.
	/// </summary>
	public void SetValue(int i, double value)
	{
		vtkContour3DLinearGrid_SetValue_45(GetCppThis(), i, value);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_UseScalarTreeOff_46(HandleRef pThis);

	/// <summary>
	/// Enable the use of a scalar tree to accelerate contour extraction. By
	/// default this is off. If enabled, and a scalar tree is not specified, then
	/// a vtkSpanSpace instance will be constructed and used.
	/// </summary>
	public virtual void UseScalarTreeOff()
	{
		vtkContour3DLinearGrid_UseScalarTreeOff_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContour3DLinearGrid_UseScalarTreeOn_47(HandleRef pThis);

	/// <summary>
	/// Enable the use of a scalar tree to accelerate contour extraction. By
	/// default this is off. If enabled, and a scalar tree is not specified, then
	/// a vtkSpanSpace instance will be constructed and used.
	/// </summary>
	public virtual void UseScalarTreeOn()
	{
		vtkContour3DLinearGrid_UseScalarTreeOn_47(GetCppThis());
	}
}
