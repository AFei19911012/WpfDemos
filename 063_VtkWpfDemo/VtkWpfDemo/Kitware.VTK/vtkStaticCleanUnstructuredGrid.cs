using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStaticCleanUnstructuredGrid
/// </summary>
/// <remarks>
///    merge duplicate points, removed unused points, in an vtkUnstructuredGrid
///
/// vtkStaticCleanUnstructuredGrid is a filter that takes a
/// vtkUnstructuredGrid as input and produces a vtkUnstructuredGrid on output,
/// merging coincident points (as defined by a merging tolerance) and
/// optionally removing unused points. The filter does not modify the topology
/// of the input dataset, nor change the types of cells. It may however,
/// renumber the cell connectivity ids.
///
/// For better performance, this filter employs threading using
/// vtkStaticPointLocator and its associated threaded methods. When the
/// merging tolerances==0.0, execution speeds are much faster as compared to
/// non-zero tolerances. When the merging tolerance &gt; 0.0, there are issues
/// of processing order which can be controlled through the locator
/// (returned via GetLocator()). This behavior can be controlled by the
/// SetTraversalOrder() method - by default threading occurs via BIN_ORDER
/// (see vtkStaticPointLocator for more information).
///
/// @warning
/// Merging points can alter cell geometry and produce degenerate cells. The
/// tolerance should be chosen carefully to avoid these problems. For example,
/// in an extreme case with a relatively large tolerance, all points of a
/// vtkHexahedron could be merged to a single point, in which case the
/// resulting hexahedron would be defined by eight repeats of the same point.
///
/// @warning
/// If RemoveUnusedPoints is enabled, then any point not used by any of the
/// unstructured grid cells is eliminated (and not passed to the
/// output). Enabling this feature does impact performance.
///
/// @warning
/// If ProduceMergeMap is enabled, then an output data array is produced,
/// associated with the output field data, that maps each input point to an
/// output point (or to -1 if an input point is unused in the output).
///
/// @warning
/// Merging points affects point coordinates and data attributes. By default,
/// if points are merged, the point position and attribute data of only one
/// point (i.e., the point that all other points are merged to) is
/// retained. If AveragePointData is enabled, then the resulting point position
/// and attribute data values are determined by averaging the position and
/// attribute values of all the points that are merged together. This option
/// may have a significant performance impact if enabled.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkCleanPolyData vtkStaticCleanPolyData vtkStaticPointLocator
/// </seealso>
public class vtkStaticCleanUnstructuredGrid : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStaticCleanUnstructuredGrid";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStaticCleanUnstructuredGrid()
	{
		MRClassNameKey = "class vtkStaticCleanUnstructuredGrid";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStaticCleanUnstructuredGrid"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStaticCleanUnstructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticCleanUnstructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of the object.
	/// </summary>
	public new static vtkStaticCleanUnstructuredGrid New()
	{
		vtkStaticCleanUnstructuredGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStaticCleanUnstructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStaticCleanUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of the object.
	/// </summary>
	public vtkStaticCleanUnstructuredGrid()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStaticCleanUnstructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkStaticCleanUnstructuredGrid_AveragePointDataOff_01(HandleRef pThis);

	/// <summary>
	/// Indicate whether point coordinates and point data of merged points are
	/// averaged. By default, the point coordinates and attribute data are not
	/// averaged, and the point coordinate and data of the single, remaining
	/// merged point is retained. Otherwise, the data coordinates and attribute
	/// values of all merged points are averaged. By default this feature is
	/// disabled.
	/// </summary>
	public virtual void AveragePointDataOff()
	{
		vtkStaticCleanUnstructuredGrid_AveragePointDataOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanUnstructuredGrid_AveragePointDataOn_02(HandleRef pThis);

	/// <summary>
	/// Indicate whether point coordinates and point data of merged points are
	/// averaged. By default, the point coordinates and attribute data are not
	/// averaged, and the point coordinate and data of the single, remaining
	/// merged point is retained. Otherwise, the data coordinates and attribute
	/// values of all merged points are averaged. By default this feature is
	/// disabled.
	/// </summary>
	public virtual void AveragePointDataOn()
	{
		vtkStaticCleanUnstructuredGrid_AveragePointDataOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStaticCleanUnstructuredGrid_GetAbsoluteTolerance_03(HandleRef pThis);

	/// <summary>
	/// Specify the absolute point merging tolerance. The default value is
	/// 0. This tolerance is used then ToleranceIsAbsolute is true.
	/// </summary>
	public virtual double GetAbsoluteTolerance()
	{
		return vtkStaticCleanUnstructuredGrid_GetAbsoluteTolerance_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStaticCleanUnstructuredGrid_GetAbsoluteToleranceMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Specify the absolute point merging tolerance. The default value is
	/// 0. This tolerance is used then ToleranceIsAbsolute is true.
	/// </summary>
	public virtual double GetAbsoluteToleranceMaxValue()
	{
		return vtkStaticCleanUnstructuredGrid_GetAbsoluteToleranceMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStaticCleanUnstructuredGrid_GetAbsoluteToleranceMinValue_05(HandleRef pThis);

	/// <summary>
	/// Specify the absolute point merging tolerance. The default value is
	/// 0. This tolerance is used then ToleranceIsAbsolute is true.
	/// </summary>
	public virtual double GetAbsoluteToleranceMinValue()
	{
		return vtkStaticCleanUnstructuredGrid_GetAbsoluteToleranceMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStaticCleanUnstructuredGrid_GetAveragePointData_06(HandleRef pThis);

	/// <summary>
	/// Indicate whether point coordinates and point data of merged points are
	/// averaged. By default, the point coordinates and attribute data are not
	/// averaged, and the point coordinate and data of the single, remaining
	/// merged point is retained. Otherwise, the data coordinates and attribute
	/// values of all merged points are averaged. By default this feature is
	/// disabled.
	/// </summary>
	public virtual bool GetAveragePointData()
	{
		return (vtkStaticCleanUnstructuredGrid_GetAveragePointData_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticCleanUnstructuredGrid_GetLocator_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve the internal locator to manually configure it, for example
	/// specifying the number of points per bucket, or controlling the traversal
	/// order. This method is generally used for debugging or testing purposes.
	/// </summary>
	public virtual vtkStaticPointLocator GetLocator()
	{
		vtkStaticPointLocator vtkStaticPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStaticCleanUnstructuredGrid_GetLocator_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStaticPointLocator2 = (vtkStaticPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStaticPointLocator2.Register(null);
			}
		}
		return vtkStaticPointLocator2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkStaticCleanUnstructuredGrid_GetMTime_08(HandleRef pThis);

	/// <summary>
	/// Get the MTime of this object also considering the locator.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkStaticCleanUnstructuredGrid_GetMTime_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticCleanUnstructuredGrid_GetMergingArray_09(HandleRef pThis);

	/// <summary>
	/// Specify the name of a point data array associated with the point merging
	/// process. If a data array is specified, and exists in the input point
	/// data, then point merging will switch into a mode where merged points
	/// must be both geometrically coincident and have matching point data
	/// (i.e., an exact match of position and data - tolerances have no
	/// effect). Note that the number of tuples in the merging data array must
	/// be equal to the number of points in the input. By default, no data array
	/// is associated with the input points (i.e., the name of the data array is
	/// empty).
	/// </summary>
	public virtual string GetMergingArray()
	{
		return Marshal.PtrToStringAnsi(vtkStaticCleanUnstructuredGrid_GetMergingArray_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticCleanUnstructuredGrid_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of the object.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStaticCleanUnstructuredGrid_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticCleanUnstructuredGrid_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of the object.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStaticCleanUnstructuredGrid_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticCleanUnstructuredGrid_GetOutputPointsPrecision_12(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output point type. See the
	/// documentation for the vtkAlgorithm::DesiredOutputPrecision enum for an
	/// explanation of the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkStaticCleanUnstructuredGrid_GetOutputPointsPrecision_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStaticCleanUnstructuredGrid_GetPieceInvariant_13(HandleRef pThis);

	/// <summary>
	/// Retrieve the internal locator to manually configure it, for example
	/// specifying the number of points per bucket, or controlling the traversal
	/// order. This method is generally used for debugging or testing purposes.
	/// </summary>
	public virtual bool GetPieceInvariant()
	{
		return (vtkStaticCleanUnstructuredGrid_GetPieceInvariant_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStaticCleanUnstructuredGrid_GetProduceMergeMap_14(HandleRef pThis);

	/// <summary>
	/// Indicate whether a merge map should be produced on output. The merge
	/// map, if requested, maps each input point to its output point id, or
	/// provides a value of -1 if the input point is not used in the output.
	/// The merge map is associated with the filter's output field data and
	/// is named "PointMergeMap". By default, ProduceMergeMap is disabled.
	/// </summary>
	public virtual bool GetProduceMergeMap()
	{
		return (vtkStaticCleanUnstructuredGrid_GetProduceMergeMap_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStaticCleanUnstructuredGrid_GetRemoveUnusedPoints_15(HandleRef pThis);

	/// <summary>
	/// Indicate whether points unused by any cell are removed from the output.
	/// By default this point removal is on. Note that when this is off, the
	/// filter can successfully process datasets with no cells (and just
	/// points). If on in this case, and there are no cells, than the output
	/// will be empty.
	/// </summary>
	public virtual bool GetRemoveUnusedPoints()
	{
		return (vtkStaticCleanUnstructuredGrid_GetRemoveUnusedPoints_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStaticCleanUnstructuredGrid_GetTolerance_16(HandleRef pThis);

	/// <summary>
	/// Specify the point merging tolerance in terms of the fraction of the
	/// input dataset's bounding box length.  The default is 0. This tolerance
	/// is used then ToleranceIsAbsolute is false.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkStaticCleanUnstructuredGrid_GetTolerance_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStaticCleanUnstructuredGrid_GetToleranceIsAbsolute_17(HandleRef pThis);

	/// <summary>
	/// Specify how the point merging tolerance is defined. By default
	/// ToleranceIsAbsolute is false and the tolerance is a fraction of the
	/// input's bounding box diagonal. If true, AbsoluteTolerance is the
	/// tolerance used when performing point merging.
	/// </summary>
	public virtual bool GetToleranceIsAbsolute()
	{
		return (vtkStaticCleanUnstructuredGrid_GetToleranceIsAbsolute_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStaticCleanUnstructuredGrid_GetToleranceMaxValue_18(HandleRef pThis);

	/// <summary>
	/// Specify the point merging tolerance in terms of the fraction of the
	/// input dataset's bounding box length.  The default is 0. This tolerance
	/// is used then ToleranceIsAbsolute is false.
	/// </summary>
	public virtual double GetToleranceMaxValue()
	{
		return vtkStaticCleanUnstructuredGrid_GetToleranceMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStaticCleanUnstructuredGrid_GetToleranceMinValue_19(HandleRef pThis);

	/// <summary>
	/// Specify the point merging tolerance in terms of the fraction of the
	/// input dataset's bounding box length.  The default is 0. This tolerance
	/// is used then ToleranceIsAbsolute is false.
	/// </summary>
	public virtual double GetToleranceMinValue()
	{
		return vtkStaticCleanUnstructuredGrid_GetToleranceMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticCleanUnstructuredGrid_IsA_20(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of the object.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStaticCleanUnstructuredGrid_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticCleanUnstructuredGrid_IsTypeOf_21(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of the object.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStaticCleanUnstructuredGrid_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticCleanUnstructuredGrid_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of the object.
	/// </summary>
	public new vtkStaticCleanUnstructuredGrid NewInstance()
	{
		vtkStaticCleanUnstructuredGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStaticCleanUnstructuredGrid_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStaticCleanUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanUnstructuredGrid_PieceInvariantOff_24(HandleRef pThis);

	/// <summary>
	/// Retrieve the internal locator to manually configure it, for example
	/// specifying the number of points per bucket, or controlling the traversal
	/// order. This method is generally used for debugging or testing purposes.
	/// </summary>
	public virtual void PieceInvariantOff()
	{
		vtkStaticCleanUnstructuredGrid_PieceInvariantOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanUnstructuredGrid_PieceInvariantOn_25(HandleRef pThis);

	/// <summary>
	/// Retrieve the internal locator to manually configure it, for example
	/// specifying the number of points per bucket, or controlling the traversal
	/// order. This method is generally used for debugging or testing purposes.
	/// </summary>
	public virtual void PieceInvariantOn()
	{
		vtkStaticCleanUnstructuredGrid_PieceInvariantOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanUnstructuredGrid_ProduceMergeMapOff_26(HandleRef pThis);

	/// <summary>
	/// Indicate whether a merge map should be produced on output. The merge
	/// map, if requested, maps each input point to its output point id, or
	/// provides a value of -1 if the input point is not used in the output.
	/// The merge map is associated with the filter's output field data and
	/// is named "PointMergeMap". By default, ProduceMergeMap is disabled.
	/// </summary>
	public virtual void ProduceMergeMapOff()
	{
		vtkStaticCleanUnstructuredGrid_ProduceMergeMapOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanUnstructuredGrid_ProduceMergeMapOn_27(HandleRef pThis);

	/// <summary>
	/// Indicate whether a merge map should be produced on output. The merge
	/// map, if requested, maps each input point to its output point id, or
	/// provides a value of -1 if the input point is not used in the output.
	/// The merge map is associated with the filter's output field data and
	/// is named "PointMergeMap". By default, ProduceMergeMap is disabled.
	/// </summary>
	public virtual void ProduceMergeMapOn()
	{
		vtkStaticCleanUnstructuredGrid_ProduceMergeMapOn_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanUnstructuredGrid_RemoveUnusedPointsOff_28(HandleRef pThis);

	/// <summary>
	/// Indicate whether points unused by any cell are removed from the output.
	/// By default this point removal is on. Note that when this is off, the
	/// filter can successfully process datasets with no cells (and just
	/// points). If on in this case, and there are no cells, than the output
	/// will be empty.
	/// </summary>
	public virtual void RemoveUnusedPointsOff()
	{
		vtkStaticCleanUnstructuredGrid_RemoveUnusedPointsOff_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanUnstructuredGrid_RemoveUnusedPointsOn_29(HandleRef pThis);

	/// <summary>
	/// Indicate whether points unused by any cell are removed from the output.
	/// By default this point removal is on. Note that when this is off, the
	/// filter can successfully process datasets with no cells (and just
	/// points). If on in this case, and there are no cells, than the output
	/// will be empty.
	/// </summary>
	public virtual void RemoveUnusedPointsOn()
	{
		vtkStaticCleanUnstructuredGrid_RemoveUnusedPointsOn_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticCleanUnstructuredGrid_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing the state of the object.
	/// </summary>
	public new static vtkStaticCleanUnstructuredGrid SafeDownCast(vtkObjectBase o)
	{
		vtkStaticCleanUnstructuredGrid vtkStaticCleanUnstructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStaticCleanUnstructuredGrid_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStaticCleanUnstructuredGrid2 = (vtkStaticCleanUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStaticCleanUnstructuredGrid2.Register(null);
			}
		}
		return vtkStaticCleanUnstructuredGrid2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanUnstructuredGrid_SetAbsoluteTolerance_31(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the absolute point merging tolerance. The default value is
	/// 0. This tolerance is used then ToleranceIsAbsolute is true.
	/// </summary>
	public virtual void SetAbsoluteTolerance(double _arg)
	{
		vtkStaticCleanUnstructuredGrid_SetAbsoluteTolerance_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanUnstructuredGrid_SetAveragePointData_32(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether point coordinates and point data of merged points are
	/// averaged. By default, the point coordinates and attribute data are not
	/// averaged, and the point coordinate and data of the single, remaining
	/// merged point is retained. Otherwise, the data coordinates and attribute
	/// values of all merged points are averaged. By default this feature is
	/// disabled.
	/// </summary>
	public virtual void SetAveragePointData(bool _arg)
	{
		vtkStaticCleanUnstructuredGrid_SetAveragePointData_32(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanUnstructuredGrid_SetMergingArray_33(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the name of a point data array associated with the point merging
	/// process. If a data array is specified, and exists in the input point
	/// data, then point merging will switch into a mode where merged points
	/// must be both geometrically coincident and have matching point data
	/// (i.e., an exact match of position and data - tolerances have no
	/// effect). Note that the number of tuples in the merging data array must
	/// be equal to the number of points in the input. By default, no data array
	/// is associated with the input points (i.e., the name of the data array is
	/// empty).
	/// </summary>
	public virtual void SetMergingArray(string _arg)
	{
		vtkStaticCleanUnstructuredGrid_SetMergingArray_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanUnstructuredGrid_SetOutputPointsPrecision_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output point type. See the
	/// documentation for the vtkAlgorithm::DesiredOutputPrecision enum for an
	/// explanation of the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkStaticCleanUnstructuredGrid_SetOutputPointsPrecision_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanUnstructuredGrid_SetPieceInvariant_35(HandleRef pThis, byte _arg);

	/// <summary>
	/// Retrieve the internal locator to manually configure it, for example
	/// specifying the number of points per bucket, or controlling the traversal
	/// order. This method is generally used for debugging or testing purposes.
	/// </summary>
	public virtual void SetPieceInvariant(bool _arg)
	{
		vtkStaticCleanUnstructuredGrid_SetPieceInvariant_35(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanUnstructuredGrid_SetProduceMergeMap_36(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether a merge map should be produced on output. The merge
	/// map, if requested, maps each input point to its output point id, or
	/// provides a value of -1 if the input point is not used in the output.
	/// The merge map is associated with the filter's output field data and
	/// is named "PointMergeMap". By default, ProduceMergeMap is disabled.
	/// </summary>
	public virtual void SetProduceMergeMap(bool _arg)
	{
		vtkStaticCleanUnstructuredGrid_SetProduceMergeMap_36(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanUnstructuredGrid_SetRemoveUnusedPoints_37(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether points unused by any cell are removed from the output.
	/// By default this point removal is on. Note that when this is off, the
	/// filter can successfully process datasets with no cells (and just
	/// points). If on in this case, and there are no cells, than the output
	/// will be empty.
	/// </summary>
	public virtual void SetRemoveUnusedPoints(bool _arg)
	{
		vtkStaticCleanUnstructuredGrid_SetRemoveUnusedPoints_37(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanUnstructuredGrid_SetTolerance_38(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the point merging tolerance in terms of the fraction of the
	/// input dataset's bounding box length.  The default is 0. This tolerance
	/// is used then ToleranceIsAbsolute is false.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkStaticCleanUnstructuredGrid_SetTolerance_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanUnstructuredGrid_SetToleranceIsAbsolute_39(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify how the point merging tolerance is defined. By default
	/// ToleranceIsAbsolute is false and the tolerance is a fraction of the
	/// input's bounding box diagonal. If true, AbsoluteTolerance is the
	/// tolerance used when performing point merging.
	/// </summary>
	public virtual void SetToleranceIsAbsolute(bool _arg)
	{
		vtkStaticCleanUnstructuredGrid_SetToleranceIsAbsolute_39(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanUnstructuredGrid_ToleranceIsAbsoluteOff_40(HandleRef pThis);

	/// <summary>
	/// Specify how the point merging tolerance is defined. By default
	/// ToleranceIsAbsolute is false and the tolerance is a fraction of the
	/// input's bounding box diagonal. If true, AbsoluteTolerance is the
	/// tolerance used when performing point merging.
	/// </summary>
	public virtual void ToleranceIsAbsoluteOff()
	{
		vtkStaticCleanUnstructuredGrid_ToleranceIsAbsoluteOff_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanUnstructuredGrid_ToleranceIsAbsoluteOn_41(HandleRef pThis);

	/// <summary>
	/// Specify how the point merging tolerance is defined. By default
	/// ToleranceIsAbsolute is false and the tolerance is a fraction of the
	/// input's bounding box diagonal. If true, AbsoluteTolerance is the
	/// tolerance used when performing point merging.
	/// </summary>
	public virtual void ToleranceIsAbsoluteOn()
	{
		vtkStaticCleanUnstructuredGrid_ToleranceIsAbsoluteOn_41(GetCppThis());
	}
}
