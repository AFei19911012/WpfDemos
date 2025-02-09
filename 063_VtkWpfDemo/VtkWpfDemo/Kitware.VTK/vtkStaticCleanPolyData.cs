using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStaticCleanPolyData
/// </summary>
/// <remarks>
///    merge duplicate points, and/or remove unused points and/or remove degenerate cells
///
/// vtkStaticCleanPolyData is a filter that takes polygonal data as input and
/// generates polygonal data as output. vtkStaticCleanPolyData will merge
/// duplicate points (within specified tolerance), and if enabled, transform
/// degenerate cells into appropriate forms (for example, a triangle is
/// converted into a line if two points of triangle are merged).
///
/// Conversion of degenerate cells is controlled by the flags
/// ConvertLinesToPoints, ConvertPolysToLines, ConvertStripsToPolys which act
/// cumulatively such that a degenerate strip may become a poly.
/// The full set is
/// Line with 1 points -&gt; Vert (if ConvertLinesToPoints)
/// Poly with 2 points -&gt; Line (if ConvertPolysToLines)
/// Poly with 1 points -&gt; Vert (if ConvertPolysToLines &amp;&amp; ConvertLinesToPoints)
/// Strp with 3 points -&gt; Poly (if ConvertStripsToPolys)
/// Strp with 2 points -&gt; Line (if ConvertStripsToPolys &amp;&amp; ConvertPolysToLines)
/// Strp with 1 points -&gt; Vert (if ConvertStripsToPolys &amp;&amp; ConvertPolysToLines
///   &amp;&amp; ConvertLinesToPoints)
///
/// Internally this class uses vtkStaticPointLocator, which is a threaded, and
/// much faster locator (especially for large data) than the incremental
/// locators that vtkCleanPolyData uses. Note because of these and other
/// differences, the output of this filter may be different than
/// vtkCleanPolyData.
///
/// @warning
/// Merging points can alter topology, including introducing non-manifold
/// forms. The tolerance should be chosen carefully to avoid these problems.
/// Large tolerances (of size &gt; locator bin width) may generate poor results.
///
/// @warning
/// Unlike vtkCleanPolyData, point merging is always performed (i.e., there
/// is no PointMergingOff()).
///
/// @warning
/// Unlike vtkCleanPolyData, conversion from one cell type to another is
/// disabled/off. This produces more predictable behavior in many applications.
///
/// @warning
/// The vtkStaticCleanPolyData filter is similar in operation to
/// vtkCleanPolyData. However, vtkStaticCleanPolyData is non-incremental and
/// uses a much faster (especially for larger datasets) threading approach and
/// when merging points with a non-zero tolerance. However because of the
/// difference in the traversal order in the point merging process, the output
/// of the filters may be different.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkCleanPolyData vtkStaticCleanUnstructuredGrid
/// </seealso>
public class vtkStaticCleanPolyData : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStaticCleanPolyData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStaticCleanPolyData()
	{
		MRClassNameKey = "class vtkStaticCleanPolyData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStaticCleanPolyData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStaticCleanPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticCleanPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, print, and provide type information.
	/// </summary>
	public new static vtkStaticCleanPolyData New()
	{
		vtkStaticCleanPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStaticCleanPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStaticCleanPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods to instantiate, print, and provide type information.
	/// </summary>
	public vtkStaticCleanPolyData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStaticCleanPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkStaticCleanPolyData_AveragePointDataOff_01(HandleRef pThis);

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
		vtkStaticCleanPolyData_AveragePointDataOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_AveragePointDataOn_02(HandleRef pThis);

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
		vtkStaticCleanPolyData_AveragePointDataOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_ConvertLinesToPointsOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off conversion of degenerate lines to points. Default is Off.
	/// </summary>
	public virtual void ConvertLinesToPointsOff()
	{
		vtkStaticCleanPolyData_ConvertLinesToPointsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_ConvertLinesToPointsOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off conversion of degenerate lines to points. Default is Off.
	/// </summary>
	public virtual void ConvertLinesToPointsOn()
	{
		vtkStaticCleanPolyData_ConvertLinesToPointsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_ConvertPolysToLinesOff_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off conversion of degenerate polys to lines. Default is Off.
	/// </summary>
	public virtual void ConvertPolysToLinesOff()
	{
		vtkStaticCleanPolyData_ConvertPolysToLinesOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_ConvertPolysToLinesOn_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off conversion of degenerate polys to lines. Default is Off.
	/// </summary>
	public virtual void ConvertPolysToLinesOn()
	{
		vtkStaticCleanPolyData_ConvertPolysToLinesOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_ConvertStripsToPolysOff_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off conversion of degenerate strips to polys. Default is Off.
	/// </summary>
	public virtual void ConvertStripsToPolysOff()
	{
		vtkStaticCleanPolyData_ConvertStripsToPolysOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_ConvertStripsToPolysOn_08(HandleRef pThis);

	/// <summary>
	/// Turn on/off conversion of degenerate strips to polys. Default is Off.
	/// </summary>
	public virtual void ConvertStripsToPolysOn()
	{
		vtkStaticCleanPolyData_ConvertStripsToPolysOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStaticCleanPolyData_GetAbsoluteTolerance_09(HandleRef pThis);

	/// <summary>
	/// Specify tolerance in absolute terms. Default is 1.0.
	/// </summary>
	public virtual double GetAbsoluteTolerance()
	{
		return vtkStaticCleanPolyData_GetAbsoluteTolerance_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStaticCleanPolyData_GetAbsoluteToleranceMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Specify tolerance in absolute terms. Default is 1.0.
	/// </summary>
	public virtual double GetAbsoluteToleranceMaxValue()
	{
		return vtkStaticCleanPolyData_GetAbsoluteToleranceMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStaticCleanPolyData_GetAbsoluteToleranceMinValue_11(HandleRef pThis);

	/// <summary>
	/// Specify tolerance in absolute terms. Default is 1.0.
	/// </summary>
	public virtual double GetAbsoluteToleranceMinValue()
	{
		return vtkStaticCleanPolyData_GetAbsoluteToleranceMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStaticCleanPolyData_GetAveragePointData_12(HandleRef pThis);

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
		return (vtkStaticCleanPolyData_GetAveragePointData_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStaticCleanPolyData_GetConvertLinesToPoints_13(HandleRef pThis);

	/// <summary>
	/// Turn on/off conversion of degenerate lines to points. Default is Off.
	/// </summary>
	public virtual bool GetConvertLinesToPoints()
	{
		return (vtkStaticCleanPolyData_GetConvertLinesToPoints_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStaticCleanPolyData_GetConvertPolysToLines_14(HandleRef pThis);

	/// <summary>
	/// Turn on/off conversion of degenerate polys to lines. Default is Off.
	/// </summary>
	public virtual bool GetConvertPolysToLines()
	{
		return (vtkStaticCleanPolyData_GetConvertPolysToLines_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStaticCleanPolyData_GetConvertStripsToPolys_15(HandleRef pThis);

	/// <summary>
	/// Turn on/off conversion of degenerate strips to polys. Default is Off.
	/// </summary>
	public virtual bool GetConvertStripsToPolys()
	{
		return (vtkStaticCleanPolyData_GetConvertStripsToPolys_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticCleanPolyData_GetLocator_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkStaticCleanPolyData_GetLocator_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkStaticCleanPolyData_GetMTime_17(HandleRef pThis);

	/// <summary>
	/// Get the MTime of this object also considering the locator.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkStaticCleanPolyData_GetMTime_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticCleanPolyData_GetMergingArray_18(HandleRef pThis);

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
		return Marshal.PtrToStringAnsi(vtkStaticCleanPolyData_GetMergingArray_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticCleanPolyData_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to instantiate, print, and provide type information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStaticCleanPolyData_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticCleanPolyData_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	/// Standard methods to instantiate, print, and provide type information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStaticCleanPolyData_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticCleanPolyData_GetOutputPointsPrecision_21(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkStaticCleanPolyData_GetOutputPointsPrecision_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStaticCleanPolyData_GetPieceInvariant_22(HandleRef pThis);

	/// <summary>
	/// Retrieve the internal locator to manually configure it, for example
	/// specifying the number of points per bucket, or controlling the traversal
	/// order. This method is generally used for debugging or testing purposes.
	/// </summary>
	public virtual bool GetPieceInvariant()
	{
		return (vtkStaticCleanPolyData_GetPieceInvariant_22(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStaticCleanPolyData_GetProduceMergeMap_23(HandleRef pThis);

	/// <summary>
	/// Indicate whether a merge map should be produced on output. The merge
	/// map, if requested, maps each input point to its output point id, or
	/// provides a value of -1 if the input point is not used in the output.
	/// The merge map is associated with the filter's output field data and
	/// is named "PointMergeMap". By default, ProduceMergeMap is disabled.
	/// </summary>
	public virtual bool GetProduceMergeMap()
	{
		return (vtkStaticCleanPolyData_GetProduceMergeMap_23(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStaticCleanPolyData_GetRemoveUnusedPoints_24(HandleRef pThis);

	/// <summary>
	/// Indicate whether points unused by any cell are removed from the output.
	/// By default this point removal is on. Note that when this is off, the
	/// filter can successfully process datasets with no cells (and just
	/// points). If on, and there are no cells, than the output will be empty.
	/// </summary>
	public virtual bool GetRemoveUnusedPoints()
	{
		return (vtkStaticCleanPolyData_GetRemoveUnusedPoints_24(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStaticCleanPolyData_GetTolerance_25(HandleRef pThis);

	/// <summary>
	/// Specify tolerance in terms of fraction of bounding box length.  Default
	/// is 0.0. This takes effect only if ToleranceIsAbsolute is false.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkStaticCleanPolyData_GetTolerance_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStaticCleanPolyData_GetToleranceIsAbsolute_26(HandleRef pThis);

	/// <summary>
	/// By default ToleranceIsAbsolute is false and Tolerance is
	/// a fraction of Bounding box diagonal, if true, AbsoluteTolerance is
	/// used when adding points to locator (merging)
	/// </summary>
	public virtual bool GetToleranceIsAbsolute()
	{
		return (vtkStaticCleanPolyData_GetToleranceIsAbsolute_26(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStaticCleanPolyData_GetToleranceMaxValue_27(HandleRef pThis);

	/// <summary>
	/// Specify tolerance in terms of fraction of bounding box length.  Default
	/// is 0.0. This takes effect only if ToleranceIsAbsolute is false.
	/// </summary>
	public virtual double GetToleranceMaxValue()
	{
		return vtkStaticCleanPolyData_GetToleranceMaxValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStaticCleanPolyData_GetToleranceMinValue_28(HandleRef pThis);

	/// <summary>
	/// Specify tolerance in terms of fraction of bounding box length.  Default
	/// is 0.0. This takes effect only if ToleranceIsAbsolute is false.
	/// </summary>
	public virtual double GetToleranceMinValue()
	{
		return vtkStaticCleanPolyData_GetToleranceMinValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticCleanPolyData_IsA_29(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to instantiate, print, and provide type information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStaticCleanPolyData_IsA_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticCleanPolyData_IsTypeOf_30(string type);

	/// <summary>
	/// Standard methods to instantiate, print, and provide type information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStaticCleanPolyData_IsTypeOf_30(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticCleanPolyData_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, print, and provide type information.
	/// </summary>
	public new vtkStaticCleanPolyData NewInstance()
	{
		vtkStaticCleanPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStaticCleanPolyData_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStaticCleanPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_PieceInvariantOff_33(HandleRef pThis);

	/// <summary>
	/// Retrieve the internal locator to manually configure it, for example
	/// specifying the number of points per bucket, or controlling the traversal
	/// order. This method is generally used for debugging or testing purposes.
	/// </summary>
	public virtual void PieceInvariantOff()
	{
		vtkStaticCleanPolyData_PieceInvariantOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_PieceInvariantOn_34(HandleRef pThis);

	/// <summary>
	/// Retrieve the internal locator to manually configure it, for example
	/// specifying the number of points per bucket, or controlling the traversal
	/// order. This method is generally used for debugging or testing purposes.
	/// </summary>
	public virtual void PieceInvariantOn()
	{
		vtkStaticCleanPolyData_PieceInvariantOn_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_ProduceMergeMapOff_35(HandleRef pThis);

	/// <summary>
	/// Indicate whether a merge map should be produced on output. The merge
	/// map, if requested, maps each input point to its output point id, or
	/// provides a value of -1 if the input point is not used in the output.
	/// The merge map is associated with the filter's output field data and
	/// is named "PointMergeMap". By default, ProduceMergeMap is disabled.
	/// </summary>
	public virtual void ProduceMergeMapOff()
	{
		vtkStaticCleanPolyData_ProduceMergeMapOff_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_ProduceMergeMapOn_36(HandleRef pThis);

	/// <summary>
	/// Indicate whether a merge map should be produced on output. The merge
	/// map, if requested, maps each input point to its output point id, or
	/// provides a value of -1 if the input point is not used in the output.
	/// The merge map is associated with the filter's output field data and
	/// is named "PointMergeMap". By default, ProduceMergeMap is disabled.
	/// </summary>
	public virtual void ProduceMergeMapOn()
	{
		vtkStaticCleanPolyData_ProduceMergeMapOn_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_RemoveUnusedPointsOff_37(HandleRef pThis);

	/// <summary>
	/// Indicate whether points unused by any cell are removed from the output.
	/// By default this point removal is on. Note that when this is off, the
	/// filter can successfully process datasets with no cells (and just
	/// points). If on, and there are no cells, than the output will be empty.
	/// </summary>
	public virtual void RemoveUnusedPointsOff()
	{
		vtkStaticCleanPolyData_RemoveUnusedPointsOff_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_RemoveUnusedPointsOn_38(HandleRef pThis);

	/// <summary>
	/// Indicate whether points unused by any cell are removed from the output.
	/// By default this point removal is on. Note that when this is off, the
	/// filter can successfully process datasets with no cells (and just
	/// points). If on, and there are no cells, than the output will be empty.
	/// </summary>
	public virtual void RemoveUnusedPointsOn()
	{
		vtkStaticCleanPolyData_RemoveUnusedPointsOn_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticCleanPolyData_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, print, and provide type information.
	/// </summary>
	public new static vtkStaticCleanPolyData SafeDownCast(vtkObjectBase o)
	{
		vtkStaticCleanPolyData vtkStaticCleanPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStaticCleanPolyData_SafeDownCast_39(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStaticCleanPolyData2 = (vtkStaticCleanPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStaticCleanPolyData2.Register(null);
			}
		}
		return vtkStaticCleanPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_SetAbsoluteTolerance_40(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify tolerance in absolute terms. Default is 1.0.
	/// </summary>
	public virtual void SetAbsoluteTolerance(double _arg)
	{
		vtkStaticCleanPolyData_SetAbsoluteTolerance_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_SetAveragePointData_41(HandleRef pThis, byte _arg);

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
		vtkStaticCleanPolyData_SetAveragePointData_41(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_SetConvertLinesToPoints_42(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off conversion of degenerate lines to points. Default is Off.
	/// </summary>
	public virtual void SetConvertLinesToPoints(bool _arg)
	{
		vtkStaticCleanPolyData_SetConvertLinesToPoints_42(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_SetConvertPolysToLines_43(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off conversion of degenerate polys to lines. Default is Off.
	/// </summary>
	public virtual void SetConvertPolysToLines(bool _arg)
	{
		vtkStaticCleanPolyData_SetConvertPolysToLines_43(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_SetConvertStripsToPolys_44(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off conversion of degenerate strips to polys. Default is Off.
	/// </summary>
	public virtual void SetConvertStripsToPolys(bool _arg)
	{
		vtkStaticCleanPolyData_SetConvertStripsToPolys_44(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_SetMergingArray_45(HandleRef pThis, string _arg);

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
		vtkStaticCleanPolyData_SetMergingArray_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_SetOutputPointsPrecision_46(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkStaticCleanPolyData_SetOutputPointsPrecision_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_SetPieceInvariant_47(HandleRef pThis, byte _arg);

	/// <summary>
	/// Retrieve the internal locator to manually configure it, for example
	/// specifying the number of points per bucket, or controlling the traversal
	/// order. This method is generally used for debugging or testing purposes.
	/// </summary>
	public virtual void SetPieceInvariant(bool _arg)
	{
		vtkStaticCleanPolyData_SetPieceInvariant_47(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_SetProduceMergeMap_48(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether a merge map should be produced on output. The merge
	/// map, if requested, maps each input point to its output point id, or
	/// provides a value of -1 if the input point is not used in the output.
	/// The merge map is associated with the filter's output field data and
	/// is named "PointMergeMap". By default, ProduceMergeMap is disabled.
	/// </summary>
	public virtual void SetProduceMergeMap(bool _arg)
	{
		vtkStaticCleanPolyData_SetProduceMergeMap_48(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_SetRemoveUnusedPoints_49(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether points unused by any cell are removed from the output.
	/// By default this point removal is on. Note that when this is off, the
	/// filter can successfully process datasets with no cells (and just
	/// points). If on, and there are no cells, than the output will be empty.
	/// </summary>
	public virtual void SetRemoveUnusedPoints(bool _arg)
	{
		vtkStaticCleanPolyData_SetRemoveUnusedPoints_49(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_SetTolerance_50(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify tolerance in terms of fraction of bounding box length.  Default
	/// is 0.0. This takes effect only if ToleranceIsAbsolute is false.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkStaticCleanPolyData_SetTolerance_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_SetToleranceIsAbsolute_51(HandleRef pThis, byte _arg);

	/// <summary>
	/// By default ToleranceIsAbsolute is false and Tolerance is
	/// a fraction of Bounding box diagonal, if true, AbsoluteTolerance is
	/// used when adding points to locator (merging)
	/// </summary>
	public virtual void SetToleranceIsAbsolute(bool _arg)
	{
		vtkStaticCleanPolyData_SetToleranceIsAbsolute_51(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_ToleranceIsAbsoluteOff_52(HandleRef pThis);

	/// <summary>
	/// By default ToleranceIsAbsolute is false and Tolerance is
	/// a fraction of Bounding box diagonal, if true, AbsoluteTolerance is
	/// used when adding points to locator (merging)
	/// </summary>
	public virtual void ToleranceIsAbsoluteOff()
	{
		vtkStaticCleanPolyData_ToleranceIsAbsoluteOff_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCleanPolyData_ToleranceIsAbsoluteOn_53(HandleRef pThis);

	/// <summary>
	/// By default ToleranceIsAbsolute is false and Tolerance is
	/// a fraction of Bounding box diagonal, if true, AbsoluteTolerance is
	/// used when adding points to locator (merging)
	/// </summary>
	public virtual void ToleranceIsAbsoluteOn()
	{
		vtkStaticCleanPolyData_ToleranceIsAbsoluteOn_53(GetCppThis());
	}
}
