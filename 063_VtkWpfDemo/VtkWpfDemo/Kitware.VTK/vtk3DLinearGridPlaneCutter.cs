using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtk3DLinearGridPlaneCutter
/// </summary>
/// <remarks>
///    fast plane cutting of vtkUnstructuredGrid containing 3D linear cells
///
/// vtk3DLinearGridPlaneCutter is a specialized filter that cuts an input
/// vtkUnstructuredGrid consisting of 3D linear cells: tetrahedra, hexahedra,
/// voxels, pyramids, and/or wedges. (The cells are linear in the sense that
/// each cell edge is a straight line.)  The filter is designed for
/// high-speed, specialized operation. All other cell types are skipped and
/// produce no output.
///
/// To use this filter you must specify an input unstructured grid or
/// vtkCompositeDataSet (containing unstructured grids) and a plane to cut with.
///
/// The filter performance varies depending on optional output
/// information. Basically if point merging is required (when PointMerging is
/// set) a sorting process is required to eliminate duplicate output points in
/// the cut surface. Otherwise when point merging is not required, a fast path
/// process produces independent triangles representing the cut surface.
///
/// This algorithm is fast because it is threaded, and may perform operations
/// (in a preprocessing step) to accelerate the plane cutting.
///
/// Because this filter may build an initial data structure during a
/// preprocessing step, the first execution of the filter may take longer than
/// subsequent operations. Typically the first execution is still faster than
/// vtkCutter (especially with threading enabled), but for certain types of
/// data this may not be true. However if you are using the filter to cut a
/// dataset multiple times (as in an exploratory or interactive workflow) this
/// filter works well.
///
/// @warning
/// When the input is of type vtkCompositeDataSet the filter will process the
/// unstructured grid(s) contained in the composite data set. As a result the
/// output of this filter is then a vtkMultiBlockDataSet containing multiple
/// vtkPolyData. When a vtkUnstructuredGrid is provided as input the
/// output is a single vtkPolyData.
///
/// @warning
/// Input cells that are not of 3D linear type (tetrahedron, hexahedron,
/// wedge, pyramid, and voxel) are simply skipped and not processed.
///
/// @warning
/// The filter is templated on types of input and output points, and input
/// scalar type. To reduce object file bloat, only real points (float,double) are
/// processed.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkCutter vtkFlyingEdgesPlaneCutter vtkPlaneCutter vtkPlane
/// vtkContour3DLinearGrid
/// </seealso>
public class vtk3DLinearGridPlaneCutter : vtkDataObjectAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtk3DLinearGridPlaneCutter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtk3DLinearGridPlaneCutter()
	{
		MRClassNameKey = "class vtk3DLinearGridPlaneCutter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtk3DLinearGridPlaneCutter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtk3DLinearGridPlaneCutter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtk3DLinearGridPlaneCutter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static vtk3DLinearGridPlaneCutter New()
	{
		vtk3DLinearGridPlaneCutter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtk3DLinearGridPlaneCutter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtk3DLinearGridPlaneCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public vtk3DLinearGridPlaneCutter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtk3DLinearGridPlaneCutter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtk3DLinearGridPlaneCutter_CanFullyProcessDataObject_01(HandleRef arg0);

	/// <summary>
	/// Returns true if the data object passed in is fully supported by this
	/// filter, i.e., all cell types are linear. For composite datasets, this
	/// means all dataset leaves have only linear cell types that can be processed
	/// by this filter.
	/// </summary>
	public static bool CanFullyProcessDataObject(vtkDataObject arg0)
	{
		return (vtk3DLinearGridPlaneCutter_CanFullyProcessDataObject_01(arg0?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridPlaneCutter_ComputeNormalsOff_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. The normal generated is simply the
	/// cut plane normal. The normal, if generated, is defined by cell data
	/// associated with the output polygons. By default computing of normals is
	/// off.
	/// </summary>
	public virtual void ComputeNormalsOff()
	{
		vtk3DLinearGridPlaneCutter_ComputeNormalsOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridPlaneCutter_ComputeNormalsOn_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. The normal generated is simply the
	/// cut plane normal. The normal, if generated, is defined by cell data
	/// associated with the output polygons. By default computing of normals is
	/// off.
	/// </summary>
	public virtual void ComputeNormalsOn()
	{
		vtk3DLinearGridPlaneCutter_ComputeNormalsOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtk3DLinearGridPlaneCutter_GetComputeNormals_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. The normal generated is simply the
	/// cut plane normal. The normal, if generated, is defined by cell data
	/// associated with the output polygons. By default computing of normals is
	/// off.
	/// </summary>
	public virtual bool GetComputeNormals()
	{
		return (vtk3DLinearGridPlaneCutter_GetComputeNormals_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtk3DLinearGridPlaneCutter_GetInterpolateAttributes_05(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate input attributes onto the cut
	/// plane. By default this option is on.
	/// </summary>
	public virtual bool GetInterpolateAttributes()
	{
		return (vtk3DLinearGridPlaneCutter_GetInterpolateAttributes_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtk3DLinearGridPlaneCutter_GetLargeIds_06(HandleRef pThis);

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
		return (vtk3DLinearGridPlaneCutter_GetLargeIds_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtk3DLinearGridPlaneCutter_GetMTime_07(HandleRef pThis);

	/// <summary>
	/// Overloaded GetMTime() because of delegation to the helper
	/// vtkPlane.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtk3DLinearGridPlaneCutter_GetMTime_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtk3DLinearGridPlaneCutter_GetMergePoints_08(HandleRef pThis);

	/// <summary>
	/// Indicate whether to merge coincident points. Merging can take extra time
	/// and produces fewer output points, creating a "watertight" output
	/// surface. On the other hand, merging reduced output data size and may be
	/// just as fast especially for smaller data. By default this is off.
	/// </summary>
	public virtual bool GetMergePoints()
	{
		return (vtk3DLinearGridPlaneCutter_GetMergePoints_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtk3DLinearGridPlaneCutter_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtk3DLinearGridPlaneCutter_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtk3DLinearGridPlaneCutter_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtk3DLinearGridPlaneCutter_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtk3DLinearGridPlaneCutter_GetNumberOfThreadsUsed_11(HandleRef pThis);

	/// <summary>
	///  Return the number of threads actually used during execution. This is
	///  valid only after algorithm execution.
	/// </summary>
	public int GetNumberOfThreadsUsed()
	{
		return vtk3DLinearGridPlaneCutter_GetNumberOfThreadsUsed_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtk3DLinearGridPlaneCutter_GetOutputPointsPrecision_12(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points. See the
	/// documentation for the vtkAlgorithm::Precision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public int GetOutputPointsPrecision()
	{
		return vtk3DLinearGridPlaneCutter_GetOutputPointsPrecision_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtk3DLinearGridPlaneCutter_GetPlane_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the plane (an implicit function) to perform the cutting. The
	/// definition of the plane (its origin and normal) is controlled via this
	/// instance of vtkPlane.
	/// </summary>
	public virtual vtkPlane GetPlane()
	{
		vtkPlane vtkPlane2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtk3DLinearGridPlaneCutter_GetPlane_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlane2 = (vtkPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlane2.Register(null);
			}
		}
		return vtkPlane2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtk3DLinearGridPlaneCutter_GetSequentialProcessing_14(HandleRef pThis);

	/// <summary>
	/// Force sequential processing (i.e. single thread) of the contouring
	/// process. By default, sequential processing is off. Note this flag only
	/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
	/// set to something other than Sequential. (If set to Sequential, then the
	/// filter always runs in serial mode.) This flag is typically used for
	/// benchmarking purposes.
	/// </summary>
	public virtual bool GetSequentialProcessing()
	{
		return (vtk3DLinearGridPlaneCutter_GetSequentialProcessing_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridPlaneCutter_InterpolateAttributesOff_15(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate input attributes onto the cut
	/// plane. By default this option is on.
	/// </summary>
	public virtual void InterpolateAttributesOff()
	{
		vtk3DLinearGridPlaneCutter_InterpolateAttributesOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridPlaneCutter_InterpolateAttributesOn_16(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate input attributes onto the cut
	/// plane. By default this option is on.
	/// </summary>
	public virtual void InterpolateAttributesOn()
	{
		vtk3DLinearGridPlaneCutter_InterpolateAttributesOn_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtk3DLinearGridPlaneCutter_IsA_17(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtk3DLinearGridPlaneCutter_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtk3DLinearGridPlaneCutter_IsTypeOf_18(string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtk3DLinearGridPlaneCutter_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridPlaneCutter_MergePointsOff_19(HandleRef pThis);

	/// <summary>
	/// Indicate whether to merge coincident points. Merging can take extra time
	/// and produces fewer output points, creating a "watertight" output
	/// surface. On the other hand, merging reduced output data size and may be
	/// just as fast especially for smaller data. By default this is off.
	/// </summary>
	public virtual void MergePointsOff()
	{
		vtk3DLinearGridPlaneCutter_MergePointsOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridPlaneCutter_MergePointsOn_20(HandleRef pThis);

	/// <summary>
	/// Indicate whether to merge coincident points. Merging can take extra time
	/// and produces fewer output points, creating a "watertight" output
	/// surface. On the other hand, merging reduced output data size and may be
	/// just as fast especially for smaller data. By default this is off.
	/// </summary>
	public virtual void MergePointsOn()
	{
		vtk3DLinearGridPlaneCutter_MergePointsOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtk3DLinearGridPlaneCutter_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new vtk3DLinearGridPlaneCutter NewInstance()
	{
		vtk3DLinearGridPlaneCutter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtk3DLinearGridPlaneCutter_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtk3DLinearGridPlaneCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtk3DLinearGridPlaneCutter_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static vtk3DLinearGridPlaneCutter SafeDownCast(vtkObjectBase o)
	{
		vtk3DLinearGridPlaneCutter vtk3DLinearGridPlaneCutter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtk3DLinearGridPlaneCutter_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtk3DLinearGridPlaneCutter2 = (vtk3DLinearGridPlaneCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtk3DLinearGridPlaneCutter2.Register(null);
			}
		}
		return vtk3DLinearGridPlaneCutter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridPlaneCutter_SequentialProcessingOff_24(HandleRef pThis);

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
		vtk3DLinearGridPlaneCutter_SequentialProcessingOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridPlaneCutter_SequentialProcessingOn_25(HandleRef pThis);

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
		vtk3DLinearGridPlaneCutter_SequentialProcessingOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridPlaneCutter_SetComputeNormals_26(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the computation of normals. The normal generated is simply the
	/// cut plane normal. The normal, if generated, is defined by cell data
	/// associated with the output polygons. By default computing of normals is
	/// off.
	/// </summary>
	public virtual void SetComputeNormals(bool _arg)
	{
		vtk3DLinearGridPlaneCutter_SetComputeNormals_26(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridPlaneCutter_SetInterpolateAttributes_27(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to interpolate input attributes onto the cut
	/// plane. By default this option is on.
	/// </summary>
	public virtual void SetInterpolateAttributes(bool _arg)
	{
		vtk3DLinearGridPlaneCutter_SetInterpolateAttributes_27(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridPlaneCutter_SetMergePoints_28(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to merge coincident points. Merging can take extra time
	/// and produces fewer output points, creating a "watertight" output
	/// surface. On the other hand, merging reduced output data size and may be
	/// just as fast especially for smaller data. By default this is off.
	/// </summary>
	public virtual void SetMergePoints(bool _arg)
	{
		vtk3DLinearGridPlaneCutter_SetMergePoints_28(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridPlaneCutter_SetOutputPointsPrecision_29(HandleRef pThis, int precision);

	/// <summary>
	/// Set/get the desired precision for the output points. See the
	/// documentation for the vtkAlgorithm::Precision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public void SetOutputPointsPrecision(int precision)
	{
		vtk3DLinearGridPlaneCutter_SetOutputPointsPrecision_29(GetCppThis(), precision);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridPlaneCutter_SetPlane_30(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the plane (an implicit function) to perform the cutting. The
	/// definition of the plane (its origin and normal) is controlled via this
	/// instance of vtkPlane.
	/// </summary>
	public virtual void SetPlane(vtkPlane arg0)
	{
		vtk3DLinearGridPlaneCutter_SetPlane_30(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridPlaneCutter_SetSequentialProcessing_31(HandleRef pThis, byte _arg);

	/// <summary>
	/// Force sequential processing (i.e. single thread) of the contouring
	/// process. By default, sequential processing is off. Note this flag only
	/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
	/// set to something other than Sequential. (If set to Sequential, then the
	/// filter always runs in serial mode.) This flag is typically used for
	/// benchmarking purposes.
	/// </summary>
	public virtual void SetSequentialProcessing(bool _arg)
	{
		vtk3DLinearGridPlaneCutter_SetSequentialProcessing_31(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
