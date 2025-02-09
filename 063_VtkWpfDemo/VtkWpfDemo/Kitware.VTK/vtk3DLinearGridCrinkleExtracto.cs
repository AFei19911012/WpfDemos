using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtk3DLinearGridCrinkleExtractor
/// </summary>
/// <remarks>
///    fast extraction of cells intersected by a plane
///
/// vtk3DLinearGridCrinkleExtractor is a specialized filter that, given a
/// specified implicit function, extracts unstructured grid cells that
/// intersect the implicit function. (Since the surface of these cells roughly
/// follows the implicit function but is "bumpy", it is referred to as a
/// "crinkle" surface.) This filter operates on vtkUnstructuredGrids consisting
/// of 3D linear cells: tetrahedra, hexahedra, voxels, pyramids, and/or
/// wedges. (The cells are linear in the sense that each cell edge is a
/// straight line.)  The filter is designed for high-speed, specialized
/// operation. All other cell types are skipped and produce no output.
///
/// To use this filter you must specify an input unstructured grid or
/// vtkCompositeDataSet (containing unstructured grids) and an implicit
/// function to cut with.
///
/// The RemoveUnusedPoints data member controls whether the filter remaps the
/// input points to the output. Since the algorithm simply extracts a subset
/// of the original data (points and cells), it is possible simply to pass the
/// input points to the output, which is much faster (factor of ~2X) then
/// mapping the input points to the output. Of course, not removing the unused
/// points means extra points in the output dataset, but because the input
/// points are shallow copied to the output, no additional memory is consumed.
///
/// @warning
/// When the input is of type vtkCompositeDataSet the filter will process the
/// unstructured grid(s) contained in the composite data set. As a result the
/// output of this filter is then a vtkMultiBlockDataSet containing multiple
/// vtkUnstructuredGrids. When a vtkUnstructuredGrid is provided as input the
/// output is a single vtkUnstructuredGrid.
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
/// @warning
/// The vtkExtractGeometry filter is similar to this filter when
/// ExtractOnlyBoundaryCells is enabled.
///
/// </remarks>
/// <seealso>
///
/// vtk3DLinearGrid vtk3DLinearGridPlaneCutter vtkExtractGeometry
/// </seealso>
public class vtk3DLinearGridCrinkleExtractor : vtkDataObjectAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtk3DLinearGridCrinkleExtractor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtk3DLinearGridCrinkleExtractor()
	{
		MRClassNameKey = "class vtk3DLinearGridCrinkleExtractor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtk3DLinearGridCrinkleExtractor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtk3DLinearGridCrinkleExtractor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtk3DLinearGridCrinkleExtractor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static vtk3DLinearGridCrinkleExtractor New()
	{
		vtk3DLinearGridCrinkleExtractor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtk3DLinearGridCrinkleExtractor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtk3DLinearGridCrinkleExtractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public vtk3DLinearGridCrinkleExtractor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtk3DLinearGridCrinkleExtractor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtk3DLinearGridCrinkleExtractor_CanFullyProcessDataObject_01(HandleRef arg0);

	/// <summary>
	/// Returns true if the data object passed in is fully supported by this
	/// filter, i.e., all cell types are linear. For composite datasets, this
	/// means all dataset leaves have only linear cell types that can be processed
	/// by this filter.
	/// </summary>
	public static bool CanFullyProcessDataObject(vtkDataObject arg0)
	{
		return (vtk3DLinearGridCrinkleExtractor_CanFullyProcessDataObject_01(arg0?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridCrinkleExtractor_CopyCellDataOff_02(HandleRef pThis);

	/// <summary>
	/// Indicate whether to copy input cell data/attributes onto the output
	/// cells. By default this option is off.
	/// </summary>
	public virtual void CopyCellDataOff()
	{
		vtk3DLinearGridCrinkleExtractor_CopyCellDataOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridCrinkleExtractor_CopyCellDataOn_03(HandleRef pThis);

	/// <summary>
	/// Indicate whether to copy input cell data/attributes onto the output
	/// cells. By default this option is off.
	/// </summary>
	public virtual void CopyCellDataOn()
	{
		vtk3DLinearGridCrinkleExtractor_CopyCellDataOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridCrinkleExtractor_CopyPointDataOff_04(HandleRef pThis);

	/// <summary>
	/// Indicate whether to copy input point data/attributes onto the output
	/// points. By default this option is on.
	/// </summary>
	public virtual void CopyPointDataOff()
	{
		vtk3DLinearGridCrinkleExtractor_CopyPointDataOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridCrinkleExtractor_CopyPointDataOn_05(HandleRef pThis);

	/// <summary>
	/// Indicate whether to copy input point data/attributes onto the output
	/// points. By default this option is on.
	/// </summary>
	public virtual void CopyPointDataOn()
	{
		vtk3DLinearGridCrinkleExtractor_CopyPointDataOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtk3DLinearGridCrinkleExtractor_GetCopyCellData_06(HandleRef pThis);

	/// <summary>
	/// Indicate whether to copy input cell data/attributes onto the output
	/// cells. By default this option is off.
	/// </summary>
	public virtual bool GetCopyCellData()
	{
		return (vtk3DLinearGridCrinkleExtractor_GetCopyCellData_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtk3DLinearGridCrinkleExtractor_GetCopyPointData_07(HandleRef pThis);

	/// <summary>
	/// Indicate whether to copy input point data/attributes onto the output
	/// points. By default this option is on.
	/// </summary>
	public virtual bool GetCopyPointData()
	{
		return (vtk3DLinearGridCrinkleExtractor_GetCopyPointData_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtk3DLinearGridCrinkleExtractor_GetImplicitFunction_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the implicit function which is used to select the output cell
	/// faces. Note that the implicit function invocation must be thread
	/// safe. Also, there is a fast path for vtkPlane implicit functions.
	/// </summary>
	public virtual vtkImplicitFunction GetImplicitFunction()
	{
		vtkImplicitFunction vtkImplicitFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtk3DLinearGridCrinkleExtractor_GetImplicitFunction_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitFunction2 = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitFunction2.Register(null);
			}
		}
		return vtkImplicitFunction2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtk3DLinearGridCrinkleExtractor_GetMTime_09(HandleRef pThis);

	/// <summary>
	/// Overloaded GetMTime() because of delegation to the helper
	/// vtkImplicitFunction.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtk3DLinearGridCrinkleExtractor_GetMTime_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtk3DLinearGridCrinkleExtractor_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtk3DLinearGridCrinkleExtractor_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtk3DLinearGridCrinkleExtractor_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtk3DLinearGridCrinkleExtractor_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtk3DLinearGridCrinkleExtractor_GetNumberOfThreadsUsed_12(HandleRef pThis);

	/// <summary>
	///  Return the number of threads actually used during execution. This is
	///  valid only after algorithm execution.
	/// </summary>
	public int GetNumberOfThreadsUsed()
	{
		return vtk3DLinearGridCrinkleExtractor_GetNumberOfThreadsUsed_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtk3DLinearGridCrinkleExtractor_GetOutputPointsPrecision_13(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points. See the
	/// documentation for the vtkAlgorithm::Precision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public int GetOutputPointsPrecision()
	{
		return vtk3DLinearGridCrinkleExtractor_GetOutputPointsPrecision_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtk3DLinearGridCrinkleExtractor_GetRemoveUnusedPoints_14(HandleRef pThis);

	/// <summary>
	/// Indicate whether to eliminate unused output points. When this flag is
	/// disabled, the input points and associated point data are simply shallow
	/// copied to the output (which improves performance).  When enabled, any
	/// points that are not used by the output cells are not sent to the output,
	/// nor is associated point data copied. By default this option is disabled.
	/// Removing unused points does have a significant performance impact.
	/// </summary>
	public virtual bool GetRemoveUnusedPoints()
	{
		return (vtk3DLinearGridCrinkleExtractor_GetRemoveUnusedPoints_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtk3DLinearGridCrinkleExtractor_GetSequentialProcessing_15(HandleRef pThis);

	/// <summary>
	/// Force sequential processing (i.e. single thread) of the crinkle cut
	/// process. By default, sequential processing is off. Note this flag only
	/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
	/// set to something other than Sequential. (If set to Sequential, then the
	/// filter always runs in serial mode.) This flag is typically used for
	/// benchmarking purposes.
	/// </summary>
	public virtual bool GetSequentialProcessing()
	{
		return (vtk3DLinearGridCrinkleExtractor_GetSequentialProcessing_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtk3DLinearGridCrinkleExtractor_IsA_16(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtk3DLinearGridCrinkleExtractor_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtk3DLinearGridCrinkleExtractor_IsTypeOf_17(string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtk3DLinearGridCrinkleExtractor_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtk3DLinearGridCrinkleExtractor_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new vtk3DLinearGridCrinkleExtractor NewInstance()
	{
		vtk3DLinearGridCrinkleExtractor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtk3DLinearGridCrinkleExtractor_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtk3DLinearGridCrinkleExtractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridCrinkleExtractor_RemoveUnusedPointsOff_20(HandleRef pThis);

	/// <summary>
	/// Indicate whether to eliminate unused output points. When this flag is
	/// disabled, the input points and associated point data are simply shallow
	/// copied to the output (which improves performance).  When enabled, any
	/// points that are not used by the output cells are not sent to the output,
	/// nor is associated point data copied. By default this option is disabled.
	/// Removing unused points does have a significant performance impact.
	/// </summary>
	public virtual void RemoveUnusedPointsOff()
	{
		vtk3DLinearGridCrinkleExtractor_RemoveUnusedPointsOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridCrinkleExtractor_RemoveUnusedPointsOn_21(HandleRef pThis);

	/// <summary>
	/// Indicate whether to eliminate unused output points. When this flag is
	/// disabled, the input points and associated point data are simply shallow
	/// copied to the output (which improves performance).  When enabled, any
	/// points that are not used by the output cells are not sent to the output,
	/// nor is associated point data copied. By default this option is disabled.
	/// Removing unused points does have a significant performance impact.
	/// </summary>
	public virtual void RemoveUnusedPointsOn()
	{
		vtk3DLinearGridCrinkleExtractor_RemoveUnusedPointsOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtk3DLinearGridCrinkleExtractor_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static vtk3DLinearGridCrinkleExtractor SafeDownCast(vtkObjectBase o)
	{
		vtk3DLinearGridCrinkleExtractor vtk3DLinearGridCrinkleExtractor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtk3DLinearGridCrinkleExtractor_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtk3DLinearGridCrinkleExtractor2 = (vtk3DLinearGridCrinkleExtractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtk3DLinearGridCrinkleExtractor2.Register(null);
			}
		}
		return vtk3DLinearGridCrinkleExtractor2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridCrinkleExtractor_SequentialProcessingOff_23(HandleRef pThis);

	/// <summary>
	/// Force sequential processing (i.e. single thread) of the crinkle cut
	/// process. By default, sequential processing is off. Note this flag only
	/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
	/// set to something other than Sequential. (If set to Sequential, then the
	/// filter always runs in serial mode.) This flag is typically used for
	/// benchmarking purposes.
	/// </summary>
	public virtual void SequentialProcessingOff()
	{
		vtk3DLinearGridCrinkleExtractor_SequentialProcessingOff_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridCrinkleExtractor_SequentialProcessingOn_24(HandleRef pThis);

	/// <summary>
	/// Force sequential processing (i.e. single thread) of the crinkle cut
	/// process. By default, sequential processing is off. Note this flag only
	/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
	/// set to something other than Sequential. (If set to Sequential, then the
	/// filter always runs in serial mode.) This flag is typically used for
	/// benchmarking purposes.
	/// </summary>
	public virtual void SequentialProcessingOn()
	{
		vtk3DLinearGridCrinkleExtractor_SequentialProcessingOn_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridCrinkleExtractor_SetCopyCellData_25(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to copy input cell data/attributes onto the output
	/// cells. By default this option is off.
	/// </summary>
	public virtual void SetCopyCellData(bool _arg)
	{
		vtk3DLinearGridCrinkleExtractor_SetCopyCellData_25(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridCrinkleExtractor_SetCopyPointData_26(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to copy input point data/attributes onto the output
	/// points. By default this option is on.
	/// </summary>
	public virtual void SetCopyPointData(bool _arg)
	{
		vtk3DLinearGridCrinkleExtractor_SetCopyPointData_26(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridCrinkleExtractor_SetImplicitFunction_27(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the implicit function which is used to select the output cell
	/// faces. Note that the implicit function invocation must be thread
	/// safe. Also, there is a fast path for vtkPlane implicit functions.
	/// </summary>
	public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
	{
		vtk3DLinearGridCrinkleExtractor_SetImplicitFunction_27(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridCrinkleExtractor_SetOutputPointsPrecision_28(HandleRef pThis, int precision);

	/// <summary>
	/// Set/get the desired precision for the output points. See the
	/// documentation for the vtkAlgorithm::Precision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public void SetOutputPointsPrecision(int precision)
	{
		vtk3DLinearGridCrinkleExtractor_SetOutputPointsPrecision_28(GetCppThis(), precision);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridCrinkleExtractor_SetRemoveUnusedPoints_29(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether to eliminate unused output points. When this flag is
	/// disabled, the input points and associated point data are simply shallow
	/// copied to the output (which improves performance).  When enabled, any
	/// points that are not used by the output cells are not sent to the output,
	/// nor is associated point data copied. By default this option is disabled.
	/// Removing unused points does have a significant performance impact.
	/// </summary>
	public virtual void SetRemoveUnusedPoints(bool _arg)
	{
		vtk3DLinearGridCrinkleExtractor_SetRemoveUnusedPoints_29(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtk3DLinearGridCrinkleExtractor_SetSequentialProcessing_30(HandleRef pThis, byte _arg);

	/// <summary>
	/// Force sequential processing (i.e. single thread) of the crinkle cut
	/// process. By default, sequential processing is off. Note this flag only
	/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
	/// set to something other than Sequential. (If set to Sequential, then the
	/// filter always runs in serial mode.) This flag is typically used for
	/// benchmarking purposes.
	/// </summary>
	public virtual void SetSequentialProcessing(bool _arg)
	{
		vtk3DLinearGridCrinkleExtractor_SetSequentialProcessing_30(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
