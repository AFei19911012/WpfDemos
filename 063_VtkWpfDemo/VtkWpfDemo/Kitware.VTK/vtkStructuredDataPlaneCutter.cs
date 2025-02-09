using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStructuredDataPlaneCutter
/// </summary>
/// <remarks>
///    fast plane cutting of vtkImageData/vtkRectilinearGrid/vtkStructuredGrid
///
/// vtkStructuredDataPlaneCutter is a specialized filter that cuts an input
/// vtkImageData/vtkRectilinearGrid/vtkStructuredGrid. The filter is designed for
/// high speed.
///
/// To use this filter you must specify an input vtkImageData/vtkRectilinearGrid/
/// vtkStructuredGrid and a plane to cut with.
///
/// This algorithm is linear with regard to cells. Tt may build (in a preprocessing step)
/// a spatial search structure that accelerates the plane cuts. The search structure, which
/// is typically a sphere tree, is used to quickly cull candidate cells.
///
/// @warning
/// This filter delegates to vtkFlyingEdgesPlaneCutter for vtkImageData if you DON'T
/// want to generate polygons.
///
/// @warning
/// This class is templated. It may run slower than serial execution if the code
/// is not optimized during compilation. Build in Release or ReleaseWithDebugInfo.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkCutter vtkPlaneCutter vtkFlyingEdgesPlaneCutter vtk3DLinearGridPlaneCutter
/// vtkPolyDataPlaneCutter
/// </seealso>
public class vtkStructuredDataPlaneCutter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredDataPlaneCutter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStructuredDataPlaneCutter()
	{
		MRClassNameKey = "class vtkStructuredDataPlaneCutter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredDataPlaneCutter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStructuredDataPlaneCutter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredDataPlaneCutter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public new static vtkStructuredDataPlaneCutter New()
	{
		vtkStructuredDataPlaneCutter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredDataPlaneCutter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStructuredDataPlaneCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public vtkStructuredDataPlaneCutter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStructuredDataPlaneCutter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkStructuredDataPlaneCutter_BuildHierarchyOff_01(HandleRef pThis);

	/// <summary>
	/// Indicate whether to build tree hierarchy. Computing the tree
	/// hierarchy can take some time on the first computation but if
	/// the input does not change, the computation of all further
	/// slice will be faster.
	///
	/// Default is on.
	/// </summary>
	public virtual void BuildHierarchyOff()
	{
		vtkStructuredDataPlaneCutter_BuildHierarchyOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredDataPlaneCutter_BuildHierarchyOn_02(HandleRef pThis);

	/// <summary>
	/// Indicate whether to build tree hierarchy. Computing the tree
	/// hierarchy can take some time on the first computation but if
	/// the input does not change, the computation of all further
	/// slice will be faster.
	///
	/// Default is on.
	/// </summary>
	public virtual void BuildHierarchyOn()
	{
		vtkStructuredDataPlaneCutter_BuildHierarchyOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredDataPlaneCutter_BuildTreeOff_03(HandleRef pThis);

	/// <summary>
	/// Indicate whether to build the sphere tree. Computing the sphere
	/// will take some time on the first computation
	/// but if the input does not change, the computation of all further
	/// slice will be much faster.
	///
	/// Default is on.
	/// </summary>
	public virtual void BuildTreeOff()
	{
		vtkStructuredDataPlaneCutter_BuildTreeOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredDataPlaneCutter_BuildTreeOn_04(HandleRef pThis);

	/// <summary>
	/// Indicate whether to build the sphere tree. Computing the sphere
	/// will take some time on the first computation
	/// but if the input does not change, the computation of all further
	/// slice will be much faster.
	///
	/// Default is on.
	/// </summary>
	public virtual void BuildTreeOn()
	{
		vtkStructuredDataPlaneCutter_BuildTreeOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredDataPlaneCutter_ComputeNormalsOff_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. The normal generated is simply the
	/// cut plane normal.
	///
	/// Default is off.
	/// </summary>
	public virtual void ComputeNormalsOff()
	{
		vtkStructuredDataPlaneCutter_ComputeNormalsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredDataPlaneCutter_ComputeNormalsOn_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. The normal generated is simply the
	/// cut plane normal.
	///
	/// Default is off.
	/// </summary>
	public virtual void ComputeNormalsOn()
	{
		vtkStructuredDataPlaneCutter_ComputeNormalsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredDataPlaneCutter_GeneratePolygonsOff_07(HandleRef pThis);

	/// <summary>
	/// Indicate whether to generate polygons instead of triangles
	///
	/// Default is on.
	/// </summary>
	public virtual void GeneratePolygonsOff()
	{
		vtkStructuredDataPlaneCutter_GeneratePolygonsOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredDataPlaneCutter_GeneratePolygonsOn_08(HandleRef pThis);

	/// <summary>
	/// Indicate whether to generate polygons instead of triangles
	///
	/// Default is on.
	/// </summary>
	public virtual void GeneratePolygonsOn()
	{
		vtkStructuredDataPlaneCutter_GeneratePolygonsOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkStructuredDataPlaneCutter_GetBatchSize_09(HandleRef pThis);

	/// <summary>
	/// Specify the number of input cells in a batch, where a batch defines
	/// a subset of the input cells operated on during threaded
	/// execution. Generally this is only used for debugging or performance
	/// studies (since batch size affects the thread workload).
	///
	/// Default is 1000.
	/// </summary>
	public virtual uint GetBatchSize()
	{
		return vtkStructuredDataPlaneCutter_GetBatchSize_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkStructuredDataPlaneCutter_GetBatchSizeMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Specify the number of input cells in a batch, where a batch defines
	/// a subset of the input cells operated on during threaded
	/// execution. Generally this is only used for debugging or performance
	/// studies (since batch size affects the thread workload).
	///
	/// Default is 1000.
	/// </summary>
	public virtual uint GetBatchSizeMaxValue()
	{
		return vtkStructuredDataPlaneCutter_GetBatchSizeMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkStructuredDataPlaneCutter_GetBatchSizeMinValue_11(HandleRef pThis);

	/// <summary>
	/// Specify the number of input cells in a batch, where a batch defines
	/// a subset of the input cells operated on during threaded
	/// execution. Generally this is only used for debugging or performance
	/// studies (since batch size affects the thread workload).
	///
	/// Default is 1000.
	/// </summary>
	public virtual uint GetBatchSizeMinValue()
	{
		return vtkStructuredDataPlaneCutter_GetBatchSizeMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStructuredDataPlaneCutter_GetBuildHierarchy_12(HandleRef pThis);

	/// <summary>
	/// Indicate whether to build tree hierarchy. Computing the tree
	/// hierarchy can take some time on the first computation but if
	/// the input does not change, the computation of all further
	/// slice will be faster.
	///
	/// Default is on.
	/// </summary>
	public virtual bool GetBuildHierarchy()
	{
		return (vtkStructuredDataPlaneCutter_GetBuildHierarchy_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStructuredDataPlaneCutter_GetBuildTree_13(HandleRef pThis);

	/// <summary>
	/// Indicate whether to build the sphere tree. Computing the sphere
	/// will take some time on the first computation
	/// but if the input does not change, the computation of all further
	/// slice will be much faster.
	///
	/// Default is on.
	/// </summary>
	public virtual bool GetBuildTree()
	{
		return (vtkStructuredDataPlaneCutter_GetBuildTree_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStructuredDataPlaneCutter_GetComputeNormals_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the computation of normals. The normal generated is simply the
	/// cut plane normal.
	///
	/// Default is off.
	/// </summary>
	public virtual bool GetComputeNormals()
	{
		return (vtkStructuredDataPlaneCutter_GetComputeNormals_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStructuredDataPlaneCutter_GetGeneratePolygons_15(HandleRef pThis);

	/// <summary>
	/// Indicate whether to generate polygons instead of triangles
	///
	/// Default is on.
	/// </summary>
	public virtual bool GetGeneratePolygons()
	{
		return (vtkStructuredDataPlaneCutter_GetGeneratePolygons_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStructuredDataPlaneCutter_GetInterpolateAttributes_16(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate attribute data. Note that both cell data
	/// and point data is interpolated and output
	///
	/// Default is on.
	/// </summary>
	public virtual bool GetInterpolateAttributes()
	{
		return (vtkStructuredDataPlaneCutter_GetInterpolateAttributes_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkStructuredDataPlaneCutter_GetMTime_17(HandleRef pThis);

	/// <summary>
	/// The modified time depends on the delegated cut plane.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkStructuredDataPlaneCutter_GetMTime_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredDataPlaneCutter_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStructuredDataPlaneCutter_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredDataPlaneCutter_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStructuredDataPlaneCutter_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredDataPlaneCutter_GetOutputPointsPrecision_20(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkStructuredDataPlaneCutter_GetOutputPointsPrecision_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredDataPlaneCutter_GetOutputPointsPrecisionMaxValue_21(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecisionMaxValue()
	{
		return vtkStructuredDataPlaneCutter_GetOutputPointsPrecisionMaxValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredDataPlaneCutter_GetOutputPointsPrecisionMinValue_22(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecisionMinValue()
	{
		return vtkStructuredDataPlaneCutter_GetOutputPointsPrecisionMinValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredDataPlaneCutter_GetPlane_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkStructuredDataPlaneCutter_GetPlane_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkStructuredDataPlaneCutter_GetSphereTree_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the sphere tree object. If defined, the sphere tree will not be built
	/// unless the dataset has changed.
	/// </summary>
	public virtual vtkSphereTree GetSphereTree()
	{
		vtkSphereTree vtkSphereTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredDataPlaneCutter_GetSphereTree_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSphereTree2 = (vtkSphereTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSphereTree2.Register(null);
			}
		}
		return vtkSphereTree2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredDataPlaneCutter_InterpolateAttributesOff_25(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate attribute data. Note that both cell data
	/// and point data is interpolated and output
	///
	/// Default is on.
	/// </summary>
	public virtual void InterpolateAttributesOff()
	{
		vtkStructuredDataPlaneCutter_InterpolateAttributesOff_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredDataPlaneCutter_InterpolateAttributesOn_26(HandleRef pThis);

	/// <summary>
	/// Indicate whether to interpolate attribute data. Note that both cell data
	/// and point data is interpolated and output
	///
	/// Default is on.
	/// </summary>
	public virtual void InterpolateAttributesOn()
	{
		vtkStructuredDataPlaneCutter_InterpolateAttributesOn_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredDataPlaneCutter_IsA_27(HandleRef pThis, string type);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStructuredDataPlaneCutter_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredDataPlaneCutter_IsTypeOf_28(string type);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStructuredDataPlaneCutter_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredDataPlaneCutter_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public new vtkStructuredDataPlaneCutter NewInstance()
	{
		vtkStructuredDataPlaneCutter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredDataPlaneCutter_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStructuredDataPlaneCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredDataPlaneCutter_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard construction and print methods.
	/// </summary>
	public new static vtkStructuredDataPlaneCutter SafeDownCast(vtkObjectBase o)
	{
		vtkStructuredDataPlaneCutter vtkStructuredDataPlaneCutter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredDataPlaneCutter_SafeDownCast_31(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStructuredDataPlaneCutter2 = (vtkStructuredDataPlaneCutter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStructuredDataPlaneCutter2.Register(null);
			}
		}
		return vtkStructuredDataPlaneCutter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredDataPlaneCutter_SetBatchSize_32(HandleRef pThis, uint _arg);

	/// <summary>
	/// Specify the number of input cells in a batch, where a batch defines
	/// a subset of the input cells operated on during threaded
	/// execution. Generally this is only used for debugging or performance
	/// studies (since batch size affects the thread workload).
	///
	/// Default is 1000.
	/// </summary>
	public virtual void SetBatchSize(uint _arg)
	{
		vtkStructuredDataPlaneCutter_SetBatchSize_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredDataPlaneCutter_SetBuildHierarchy_33(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to build tree hierarchy. Computing the tree
	/// hierarchy can take some time on the first computation but if
	/// the input does not change, the computation of all further
	/// slice will be faster.
	///
	/// Default is on.
	/// </summary>
	public virtual void SetBuildHierarchy(bool _arg)
	{
		vtkStructuredDataPlaneCutter_SetBuildHierarchy_33(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredDataPlaneCutter_SetBuildTree_34(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to build the sphere tree. Computing the sphere
	/// will take some time on the first computation
	/// but if the input does not change, the computation of all further
	/// slice will be much faster.
	///
	/// Default is on.
	/// </summary>
	public virtual void SetBuildTree(bool _arg)
	{
		vtkStructuredDataPlaneCutter_SetBuildTree_34(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredDataPlaneCutter_SetComputeNormals_35(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the computation of normals. The normal generated is simply the
	/// cut plane normal.
	///
	/// Default is off.
	/// </summary>
	public virtual void SetComputeNormals(bool _arg)
	{
		vtkStructuredDataPlaneCutter_SetComputeNormals_35(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredDataPlaneCutter_SetGeneratePolygons_36(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to generate polygons instead of triangles
	///
	/// Default is on.
	/// </summary>
	public virtual void SetGeneratePolygons(bool _arg)
	{
		vtkStructuredDataPlaneCutter_SetGeneratePolygons_36(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredDataPlaneCutter_SetInterpolateAttributes_37(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to interpolate attribute data. Note that both cell data
	/// and point data is interpolated and output
	///
	/// Default is on.
	/// </summary>
	public virtual void SetInterpolateAttributes(bool _arg)
	{
		vtkStructuredDataPlaneCutter_SetInterpolateAttributes_37(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredDataPlaneCutter_SetOutputPointsPrecision_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkStructuredDataPlaneCutter_SetOutputPointsPrecision_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredDataPlaneCutter_SetPlane_39(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the plane (an implicit function) to perform the cutting. The
	/// definition of the plane (its origin and normal) is controlled via this
	/// instance of vtkPlane.
	/// </summary>
	public virtual void SetPlane(vtkPlane arg0)
	{
		vtkStructuredDataPlaneCutter_SetPlane_39(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredDataPlaneCutter_SetSphereTree_40(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the sphere tree object. If defined, the sphere tree will not be built
	/// unless the dataset has changed.
	/// </summary>
	public virtual void SetSphereTree(vtkSphereTree arg0)
	{
		vtkStructuredDataPlaneCutter_SetSphereTree_40(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
