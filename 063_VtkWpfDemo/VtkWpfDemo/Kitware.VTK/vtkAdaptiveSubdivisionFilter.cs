using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAdaptiveSubdivisionFilter
/// </summary>
/// <remarks>
///    subdivide triangles based on edge and/or area metrics
///
///
/// vtkAdaptiveSubdivisionFilter is a filter that subdivides triangles based
/// on maximum edge length and/or triangle area. It uses a simple case-based,
/// multi-pass approach to repeatedly subdivide the input triangle mesh to
/// meet the area and/or edge length criteria. New points may be inserted only
/// on edges; depending on the number of edges to be subdivided a different
/// number of triangles are inserted ranging from two (i.e., two triangles
/// replace the original one) to four.
///
/// Triangle subdivision is controlled by specifying a maximum edge length
/// and/or triangle area that any given triangle may have. Subdivision
/// proceeds until their criteria are satisfied. Note that using excessively
/// small criteria values can produce enormous meshes with the possibility of
/// exhausting system memory. Also, if you want to ignore a particular
/// criterion value (e.g., triangle area) then simply set the criterion value
/// to a very large value (e.g., VTK_DOUBLE_MAX).
///
/// An incremental point locator is used because as new points are created, a
/// search is made to ensure that a point has not already been created. This
/// ensures that the mesh remains compatible (watertight) as long as certain
/// criteria are not used (triangle area limit, and number of triangles limit).
///
/// To prevent overly large triangle meshes from being created, it is possible
/// to set a limit on the number of triangles created. By default this number
/// is a very large number (i.e., no limit). Further, a limit on the number of
/// passes can also be set, this is mostly useful to generated animations of
/// the algorithm.
///
/// Finally, the attribute data (point and cell data) is treated as follows.
/// The cell data from a parent triangle is assigned to its subdivided
/// children.  Point data is interpolated along edges as the edges are
/// subdivided.
///
/// @warning
/// The subdivision is linear along edges. Thus do not expect smoothing or
/// blending effects to occur. If you need to smooth the resulting mesh use an
/// algorithm like vtkWindowedSincPolyDataFilter or vtkSmoothPolyDataFilter.
///
/// The filter retains mesh compatibility (watertightness) if the mesh was
/// originally compatible; and the area, max triangles criteria are not used.
///
/// @warning
/// The filter requires a triangle mesh. Use vtkTriangleFilter to tessellate
/// the mesh if necessary.
///
/// </remarks>
/// <seealso>
///
/// vtkInterpolatingSubdivisionFilter vtkLinearSubdivisionFilter
/// vtkButterflySubdivisionFilter vtkTriangleFilter
/// </seealso>
public class vtkAdaptiveSubdivisionFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAdaptiveSubdivisionFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAdaptiveSubdivisionFilter()
	{
		MRClassNameKey = "class vtkAdaptiveSubdivisionFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAdaptiveSubdivisionFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAdaptiveSubdivisionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAdaptiveSubdivisionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type info, and printing.
	/// </summary>
	public new static vtkAdaptiveSubdivisionFilter New()
	{
		vtkAdaptiveSubdivisionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAdaptiveSubdivisionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAdaptiveSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type info, and printing.
	/// </summary>
	public vtkAdaptiveSubdivisionFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAdaptiveSubdivisionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAdaptiveSubdivisionFilter_CreateDefaultLocator_01(HandleRef pThis);

	/// <summary>
	/// Create a default locator. Used to create one when none is
	/// specified.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkAdaptiveSubdivisionFilter_CreateDefaultLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAdaptiveSubdivisionFilter_GetLocator_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / get a spatial locator for merging points. By default,
	/// an instance of vtkMergePoints is used. This is used to merge
	/// coincident points during subdivision.
	/// </summary>
	public virtual vtkIncrementalPointLocator GetLocator()
	{
		vtkIncrementalPointLocator vtkIncrementalPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAdaptiveSubdivisionFilter_GetLocator_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIncrementalPointLocator2 = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIncrementalPointLocator2.Register(null);
			}
		}
		return vtkIncrementalPointLocator2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkAdaptiveSubdivisionFilter_GetMTime_03(HandleRef pThis);

	/// <summary>
	/// Modified GetMTime because of the dependence on the locator.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkAdaptiveSubdivisionFilter_GetMTime_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAdaptiveSubdivisionFilter_GetMaximumEdgeLength_04(HandleRef pThis);

	/// <summary>
	/// Specify the maximum edge length that a triangle may have. Edges longer
	/// than this value are split in half and the associated triangles are
	/// modified accordingly.
	/// </summary>
	public virtual double GetMaximumEdgeLength()
	{
		return vtkAdaptiveSubdivisionFilter_GetMaximumEdgeLength_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAdaptiveSubdivisionFilter_GetMaximumEdgeLengthMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Specify the maximum edge length that a triangle may have. Edges longer
	/// than this value are split in half and the associated triangles are
	/// modified accordingly.
	/// </summary>
	public virtual double GetMaximumEdgeLengthMaxValue()
	{
		return vtkAdaptiveSubdivisionFilter_GetMaximumEdgeLengthMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAdaptiveSubdivisionFilter_GetMaximumEdgeLengthMinValue_06(HandleRef pThis);

	/// <summary>
	/// Specify the maximum edge length that a triangle may have. Edges longer
	/// than this value are split in half and the associated triangles are
	/// modified accordingly.
	/// </summary>
	public virtual double GetMaximumEdgeLengthMinValue()
	{
		return vtkAdaptiveSubdivisionFilter_GetMaximumEdgeLengthMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfPasses_07(HandleRef pThis);

	/// <summary>
	/// Set a limit on the number of passes (i.e., levels of subdivision).  If
	/// the limit is hit, then the subdivision process stops and additional
	/// passes (needed to meet other criteria) are aborted. The default limit is
	/// set to a very large number (i.e., no effective limit).
	/// </summary>
	public virtual long GetMaximumNumberOfPasses()
	{
		return vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfPasses_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfPassesMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set a limit on the number of passes (i.e., levels of subdivision).  If
	/// the limit is hit, then the subdivision process stops and additional
	/// passes (needed to meet other criteria) are aborted. The default limit is
	/// set to a very large number (i.e., no effective limit).
	/// </summary>
	public virtual long GetMaximumNumberOfPassesMaxValue()
	{
		return vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfPassesMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfPassesMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set a limit on the number of passes (i.e., levels of subdivision).  If
	/// the limit is hit, then the subdivision process stops and additional
	/// passes (needed to meet other criteria) are aborted. The default limit is
	/// set to a very large number (i.e., no effective limit).
	/// </summary>
	public virtual long GetMaximumNumberOfPassesMinValue()
	{
		return vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfPassesMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfTriangles_10(HandleRef pThis);

	/// <summary>
	/// Set a limit on the maximum number of triangles that can be created.  If
	/// the limit is hit, it may result in premature termination of the
	/// algorithm and the results may be less than satisfactory (for example
	/// non-watertight meshes may be created). By default, the limit is set to a
	/// very large number (i.e., no effective limit).
	/// </summary>
	public virtual long GetMaximumNumberOfTriangles()
	{
		return vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfTriangles_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfTrianglesMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Set a limit on the maximum number of triangles that can be created.  If
	/// the limit is hit, it may result in premature termination of the
	/// algorithm and the results may be less than satisfactory (for example
	/// non-watertight meshes may be created). By default, the limit is set to a
	/// very large number (i.e., no effective limit).
	/// </summary>
	public virtual long GetMaximumNumberOfTrianglesMaxValue()
	{
		return vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfTrianglesMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfTrianglesMinValue_12(HandleRef pThis);

	/// <summary>
	/// Set a limit on the maximum number of triangles that can be created.  If
	/// the limit is hit, it may result in premature termination of the
	/// algorithm and the results may be less than satisfactory (for example
	/// non-watertight meshes may be created). By default, the limit is set to a
	/// very large number (i.e., no effective limit).
	/// </summary>
	public virtual long GetMaximumNumberOfTrianglesMinValue()
	{
		return vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfTrianglesMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAdaptiveSubdivisionFilter_GetMaximumTriangleArea_13(HandleRef pThis);

	/// <summary>
	/// Specify the maximum area that a triangle may have. Triangles larger
	/// than this value are subdivided to meet this threshold. Note that if
	/// this criterion is used it may produce non-watertight meshes as a
	/// result.
	/// </summary>
	public virtual double GetMaximumTriangleArea()
	{
		return vtkAdaptiveSubdivisionFilter_GetMaximumTriangleArea_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAdaptiveSubdivisionFilter_GetMaximumTriangleAreaMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Specify the maximum area that a triangle may have. Triangles larger
	/// than this value are subdivided to meet this threshold. Note that if
	/// this criterion is used it may produce non-watertight meshes as a
	/// result.
	/// </summary>
	public virtual double GetMaximumTriangleAreaMaxValue()
	{
		return vtkAdaptiveSubdivisionFilter_GetMaximumTriangleAreaMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAdaptiveSubdivisionFilter_GetMaximumTriangleAreaMinValue_15(HandleRef pThis);

	/// <summary>
	/// Specify the maximum area that a triangle may have. Triangles larger
	/// than this value are subdivided to meet this threshold. Note that if
	/// this criterion is used it may produce non-watertight meshes as a
	/// result.
	/// </summary>
	public virtual double GetMaximumTriangleAreaMinValue()
	{
		return vtkAdaptiveSubdivisionFilter_GetMaximumTriangleAreaMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAdaptiveSubdivisionFilter_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type info, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAdaptiveSubdivisionFilter_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAdaptiveSubdivisionFilter_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	/// Standard methods for instantiation, type info, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAdaptiveSubdivisionFilter_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAdaptiveSubdivisionFilter_GetOutputPointsPrecision_18(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::Precision enum for an explanation of the available
	/// precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkAdaptiveSubdivisionFilter_GetOutputPointsPrecision_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAdaptiveSubdivisionFilter_IsA_19(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type info, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAdaptiveSubdivisionFilter_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAdaptiveSubdivisionFilter_IsTypeOf_20(string type);

	/// <summary>
	/// Standard methods for instantiation, type info, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAdaptiveSubdivisionFilter_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAdaptiveSubdivisionFilter_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type info, and printing.
	/// </summary>
	public new vtkAdaptiveSubdivisionFilter NewInstance()
	{
		vtkAdaptiveSubdivisionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAdaptiveSubdivisionFilter_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAdaptiveSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAdaptiveSubdivisionFilter_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type info, and printing.
	/// </summary>
	public new static vtkAdaptiveSubdivisionFilter SafeDownCast(vtkObjectBase o)
	{
		vtkAdaptiveSubdivisionFilter vtkAdaptiveSubdivisionFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAdaptiveSubdivisionFilter_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAdaptiveSubdivisionFilter2 = (vtkAdaptiveSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAdaptiveSubdivisionFilter2.Register(null);
			}
		}
		return vtkAdaptiveSubdivisionFilter2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAdaptiveSubdivisionFilter_SetLocator_24(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Set / get a spatial locator for merging points. By default,
	/// an instance of vtkMergePoints is used. This is used to merge
	/// coincident points during subdivision.
	/// </summary>
	public void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkAdaptiveSubdivisionFilter_SetLocator_24(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAdaptiveSubdivisionFilter_SetMaximumEdgeLength_25(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the maximum edge length that a triangle may have. Edges longer
	/// than this value are split in half and the associated triangles are
	/// modified accordingly.
	/// </summary>
	public virtual void SetMaximumEdgeLength(double _arg)
	{
		vtkAdaptiveSubdivisionFilter_SetMaximumEdgeLength_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAdaptiveSubdivisionFilter_SetMaximumNumberOfPasses_26(HandleRef pThis, long _arg);

	/// <summary>
	/// Set a limit on the number of passes (i.e., levels of subdivision).  If
	/// the limit is hit, then the subdivision process stops and additional
	/// passes (needed to meet other criteria) are aborted. The default limit is
	/// set to a very large number (i.e., no effective limit).
	/// </summary>
	public virtual void SetMaximumNumberOfPasses(long _arg)
	{
		vtkAdaptiveSubdivisionFilter_SetMaximumNumberOfPasses_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAdaptiveSubdivisionFilter_SetMaximumNumberOfTriangles_27(HandleRef pThis, long _arg);

	/// <summary>
	/// Set a limit on the maximum number of triangles that can be created.  If
	/// the limit is hit, it may result in premature termination of the
	/// algorithm and the results may be less than satisfactory (for example
	/// non-watertight meshes may be created). By default, the limit is set to a
	/// very large number (i.e., no effective limit).
	/// </summary>
	public virtual void SetMaximumNumberOfTriangles(long _arg)
	{
		vtkAdaptiveSubdivisionFilter_SetMaximumNumberOfTriangles_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAdaptiveSubdivisionFilter_SetMaximumTriangleArea_28(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the maximum area that a triangle may have. Triangles larger
	/// than this value are subdivided to meet this threshold. Note that if
	/// this criterion is used it may produce non-watertight meshes as a
	/// result.
	/// </summary>
	public virtual void SetMaximumTriangleArea(double _arg)
	{
		vtkAdaptiveSubdivisionFilter_SetMaximumTriangleArea_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAdaptiveSubdivisionFilter_SetOutputPointsPrecision_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::Precision enum for an explanation of the available
	/// precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkAdaptiveSubdivisionFilter_SetOutputPointsPrecision_29(GetCppThis(), _arg);
	}
}
