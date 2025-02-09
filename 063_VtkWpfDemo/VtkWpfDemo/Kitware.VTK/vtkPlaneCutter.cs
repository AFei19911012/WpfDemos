using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlaneCutter
/// </summary>
/// <remarks>
///    cut any dataset with a plane and generate a
/// polygonal cut surface
///
/// vtkPlaneCutter is a specialization of the vtkCutter algorithm to cut a
/// dataset grid with a single plane. It is designed for performance and an
/// exploratory, fast workflow. It produces output triangles/polygons that
/// result from cutting the input dataset with the specified plane.
///
/// This algorithm is fast because it is threaded, it may delegate to a
/// high-performance cutting algorithm, and/or it may build (in a
/// preprocessing step) a spatial search structure that accelerates the plane
/// cuts. The search structure, which is typically a sphere tree, is used to
/// quickly cull candidate cells.
///
/// Because this filter may build an initial data structure during a
/// preprocessing step, the first execution of the filter may take longer than
/// subsequent operations. Typically the first execution is still faster than
/// vtkCutter (especially with threading enabled), but for certain types of
/// data this may not be true. However if you are using the filter to cut a
/// dataset multiple times (as in an exploratory or interactive workflow) this
/// filter typically works well.
///
/// @warning
/// Polygons can NOT be generated when the input is vtkPolyData/vtkUnstructuredGridBase.
///
/// @warning
/// This filter chooses the output type based on the input type.
/// 1) if input is vtkDataSet, output is vtkPolyData.
/// 2) if input is vtkPartitionedDataSet, output is vtkPartitionedDataSet.
/// 3) if input is vtkPartitionedDataSetCollection, output is vtkPartitionedDataSetCollection.
/// 4) if input is vtkUniformGridAMR, output is vtkMultiBlockDataSet.
/// 5) if input is vtkMultiBlockDataSet, output is vtkMultiBlockDataSet.
///
/// @warning
/// Delegations to other filters:
/// 1) vtkImageData/vtkRectilinearGrid/vtkStructuredGrid delegates vtkStructuredDataPlaneCutter.
/// 2) vtkPolyData with convex cells delegates to vtkPolyDataPlaneCutter.
/// 3) vtkUnstructuredGrid with linear cells delegates to vtk3DLinearGridPlaneCutter.
///
/// @warning
/// This filter can optionally produce output, using MergePoints=false, that has duplicate points.
/// only for vtkUnstructuredGrid, and vtkPolyData that all of its input cells are NOT convex
/// polygons. For all the other input types, the output has unique points.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkFlyingEdgesPlaneCutter vtkStructuredDataPlaneCutter vtkPolyDataPlaneCutter
/// vtk3DLinearGridPlaneCutter vtkCutter vtkPlane
/// </seealso>
public class vtkPlaneCutter : vtkDataObjectAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlaneCutter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlaneCutter()
	{
		MRClassNameKey = "class vtkPlaneCutter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlaneCutter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlaneCutter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneCutter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public new static vtkPlaneCutter New()
	{
		vtkPlaneCutter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlaneCutter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlaneCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public vtkPlaneCutter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPlaneCutter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPlaneCutter_BuildHierarchyOff_01(HandleRef pThis);

	/// <summary>
	/// Indicate whether to build tree hierarchy. Computing the tree
	/// hierarchy can take some time on the first computation but if
	/// the input does not change, the computation of all further
	/// slice will be faster. Default is on.
	/// </summary>
	public virtual void BuildHierarchyOff()
	{
		vtkPlaneCutter_BuildHierarchyOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneCutter_BuildHierarchyOn_02(HandleRef pThis);

	/// <summary>
	/// Indicate whether to build tree hierarchy. Computing the tree
	/// hierarchy can take some time on the first computation but if
	/// the input does not change, the computation of all further
	/// slice will be faster. Default is on.
	/// </summary>
	public virtual void BuildHierarchyOn()
	{
		vtkPlaneCutter_BuildHierarchyOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneCutter_BuildTreeOff_03(HandleRef pThis);

	/// <summary>
	/// Indicate whether to build the sphere tree. Computing the sphere
	/// will take some time on the first computation
	/// but if the input does not change, the computation of all further
	/// slice will be much faster. Default is on.
	/// </summary>
	public virtual void BuildTreeOff()
	{
		vtkPlaneCutter_BuildTreeOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneCutter_BuildTreeOn_04(HandleRef pThis);

	/// <summary>
	/// Indicate whether to build the sphere tree. Computing the sphere
	/// will take some time on the first computation
	/// but if the input does not change, the computation of all further
	/// slice will be much faster. Default is on.
	/// </summary>
	public virtual void BuildTreeOn()
	{
		vtkPlaneCutter_BuildTreeOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneCutter_ComputeNormalsOff_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. The normal generated is simply the
	/// cut plane normal. The normal, if generated, is defined by cell data
	/// associated with the output polygons. By default computing of normals is
	/// disabled.
	/// </summary>
	public virtual void ComputeNormalsOff()
	{
		vtkPlaneCutter_ComputeNormalsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneCutter_ComputeNormalsOn_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. The normal generated is simply the
	/// cut plane normal. The normal, if generated, is defined by cell data
	/// associated with the output polygons. By default computing of normals is
	/// disabled.
	/// </summary>
	public virtual void ComputeNormalsOn()
	{
		vtkPlaneCutter_ComputeNormalsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneCutter_GeneratePolygonsOff_07(HandleRef pThis);

	/// <summary>
	/// Indicate whether to generate polygons instead of triangles when cutting
	/// structured and rectilinear grid.
	/// No effect with other kinds of inputs, enabled by default.
	/// </summary>
	public virtual void GeneratePolygonsOff()
	{
		vtkPlaneCutter_GeneratePolygonsOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneCutter_GeneratePolygonsOn_08(HandleRef pThis);

	/// <summary>
	/// Indicate whether to generate polygons instead of triangles when cutting
	/// structured and rectilinear grid.
	/// No effect with other kinds of inputs, enabled by default.
	/// </summary>
	public virtual void GeneratePolygonsOn()
	{
		vtkPlaneCutter_GeneratePolygonsOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlaneCutter_GetBuildHierarchy_09(HandleRef pThis);

	/// <summary>
	/// Indicate whether to build tree hierarchy. Computing the tree
	/// hierarchy can take some time on the first computation but if
	/// the input does not change, the computation of all further
	/// slice will be faster. Default is on.
	/// </summary>
	public virtual bool GetBuildHierarchy()
	{
		return (vtkPlaneCutter_GetBuildHierarchy_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlaneCutter_GetBuildTree_10(HandleRef pThis);

	/// <summary>
	/// Indicate whether to build the sphere tree. Computing the sphere
	/// will take some time on the first computation
	/// but if the input does not change, the computation of all further
	/// slice will be much faster. Default is on.
	/// </summary>
	public virtual bool GetBuildTree()
	{
		return (vtkPlaneCutter_GetBuildTree_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlaneCutter_GetComputeNormals_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. The normal generated is simply the
	/// cut plane normal. The normal, if generated, is defined by cell data
	/// associated with the output polygons. By default computing of normals is
	/// disabled.
	/// </summary>
	public virtual bool GetComputeNormals()
	{
		return (vtkPlaneCutter_GetComputeNormals_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlaneCutter_GetGeneratePolygons_12(HandleRef pThis);

	/// <summary>
	/// Indicate whether to generate polygons instead of triangles when cutting
	/// structured and rectilinear grid.
	/// No effect with other kinds of inputs, enabled by default.
	/// </summary>
	public virtual bool GetGeneratePolygons()
	{
		return (vtkPlaneCutter_GetGeneratePolygons_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlaneCutter_GetInterpolateAttributes_13(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate attribute data. By default this is
	/// enabled. Note that both cell data and point data is interpolated and
	/// output, except for image data input where only point data are output.
	/// </summary>
	public virtual bool GetInterpolateAttributes()
	{
		return (vtkPlaneCutter_GetInterpolateAttributes_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkPlaneCutter_GetMTime_14(HandleRef pThis);

	/// <summary>
	/// The modified time depends on the delegated cut plane.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkPlaneCutter_GetMTime_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlaneCutter_GetMergePoints_15(HandleRef pThis);

	/// <summary>
	/// Indicate whether to merge coincident points. Merging can take extra time
	/// and produces fewer output points, creating a "watertight" output
	/// surface. On the other hand, merging reduced output data size and may be
	/// just as fast. MergingPoints = off is meaningful only for vtkUnstructuredGrid,
	/// and vtkPolyData that all of its input cells are NOT convex polygons. For all the
	/// other input types, the output has unique points. Default is off.
	/// </summary>
	public virtual bool GetMergePoints()
	{
		return (vtkPlaneCutter_GetMergePoints_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlaneCutter_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlaneCutter_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlaneCutter_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlaneCutter_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaneCutter_GetOutputPointsPrecision_18(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkPlaneCutter_GetOutputPointsPrecision_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaneCutter_GetOutputPointsPrecisionMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecisionMaxValue()
	{
		return vtkPlaneCutter_GetOutputPointsPrecisionMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaneCutter_GetOutputPointsPrecisionMinValue_20(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecisionMinValue()
	{
		return vtkPlaneCutter_GetOutputPointsPrecisionMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneCutter_GetPlane_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkPlaneCutter_GetPlane_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPlaneCutter_InterpolateAttributesOff_22(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate attribute data. By default this is
	/// enabled. Note that both cell data and point data is interpolated and
	/// output, except for image data input where only point data are output.
	/// </summary>
	public virtual void InterpolateAttributesOff()
	{
		vtkPlaneCutter_InterpolateAttributesOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneCutter_InterpolateAttributesOn_23(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate attribute data. By default this is
	/// enabled. Note that both cell data and point data is interpolated and
	/// output, except for image data input where only point data are output.
	/// </summary>
	public virtual void InterpolateAttributesOn()
	{
		vtkPlaneCutter_InterpolateAttributesOn_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaneCutter_IsA_24(HandleRef pThis, string type);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlaneCutter_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaneCutter_IsTypeOf_25(string type);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlaneCutter_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneCutter_MergePointsOff_26(HandleRef pThis);

	/// <summary>
	/// Indicate whether to merge coincident points. Merging can take extra time
	/// and produces fewer output points, creating a "watertight" output
	/// surface. On the other hand, merging reduced output data size and may be
	/// just as fast. MergingPoints = off is meaningful only for vtkUnstructuredGrid,
	/// and vtkPolyData that all of its input cells are NOT convex polygons. For all the
	/// other input types, the output has unique points. Default is off.
	/// </summary>
	public virtual void MergePointsOff()
	{
		vtkPlaneCutter_MergePointsOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneCutter_MergePointsOn_27(HandleRef pThis);

	/// <summary>
	/// Indicate whether to merge coincident points. Merging can take extra time
	/// and produces fewer output points, creating a "watertight" output
	/// surface. On the other hand, merging reduced output data size and may be
	/// just as fast. MergingPoints = off is meaningful only for vtkUnstructuredGrid,
	/// and vtkPolyData that all of its input cells are NOT convex polygons. For all the
	/// other input types, the output has unique points. Default is off.
	/// </summary>
	public virtual void MergePointsOn()
	{
		vtkPlaneCutter_MergePointsOn_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneCutter_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public new vtkPlaneCutter NewInstance()
	{
		vtkPlaneCutter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlaneCutter_NewInstance_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlaneCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaneCutter_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public new static vtkPlaneCutter SafeDownCast(vtkObjectBase o)
	{
		vtkPlaneCutter vtkPlaneCutter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlaneCutter_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlaneCutter2 = (vtkPlaneCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlaneCutter2.Register(null);
			}
		}
		return vtkPlaneCutter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneCutter_SetBuildHierarchy_31(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to build tree hierarchy. Computing the tree
	/// hierarchy can take some time on the first computation but if
	/// the input does not change, the computation of all further
	/// slice will be faster. Default is on.
	/// </summary>
	public virtual void SetBuildHierarchy(bool _arg)
	{
		vtkPlaneCutter_SetBuildHierarchy_31(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneCutter_SetBuildTree_32(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to build the sphere tree. Computing the sphere
	/// will take some time on the first computation
	/// but if the input does not change, the computation of all further
	/// slice will be much faster. Default is on.
	/// </summary>
	public virtual void SetBuildTree(bool _arg)
	{
		vtkPlaneCutter_SetBuildTree_32(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneCutter_SetComputeNormals_33(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the computation of normals. The normal generated is simply the
	/// cut plane normal. The normal, if generated, is defined by cell data
	/// associated with the output polygons. By default computing of normals is
	/// disabled.
	/// </summary>
	public virtual void SetComputeNormals(bool _arg)
	{
		vtkPlaneCutter_SetComputeNormals_33(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneCutter_SetGeneratePolygons_34(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to generate polygons instead of triangles when cutting
	/// structured and rectilinear grid.
	/// No effect with other kinds of inputs, enabled by default.
	/// </summary>
	public virtual void SetGeneratePolygons(bool _arg)
	{
		vtkPlaneCutter_SetGeneratePolygons_34(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneCutter_SetInterpolateAttributes_35(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to interpolate attribute data. By default this is
	/// enabled. Note that both cell data and point data is interpolated and
	/// output, except for image data input where only point data are output.
	/// </summary>
	public virtual void SetInterpolateAttributes(bool _arg)
	{
		vtkPlaneCutter_SetInterpolateAttributes_35(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneCutter_SetMergePoints_36(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to merge coincident points. Merging can take extra time
	/// and produces fewer output points, creating a "watertight" output
	/// surface. On the other hand, merging reduced output data size and may be
	/// just as fast. MergingPoints = off is meaningful only for vtkUnstructuredGrid,
	/// and vtkPolyData that all of its input cells are NOT convex polygons. For all the
	/// other input types, the output has unique points. Default is off.
	/// </summary>
	public virtual void SetMergePoints(bool _arg)
	{
		vtkPlaneCutter_SetMergePoints_36(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneCutter_SetOutputPointsPrecision_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkPlaneCutter_SetOutputPointsPrecision_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaneCutter_SetPlane_38(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the plane (an implicit function) to perform the cutting. The
	/// definition of the plane (its origin and normal) is controlled via this
	/// instance of vtkPlane.
	/// </summary>
	public virtual void SetPlane(vtkPlane arg0)
	{
		vtkPlaneCutter_SetPlane_38(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
