using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTessellatorFilter
/// </summary>
/// <remarks>
///    approximate nonlinear FEM elements with simplices
///
/// This class approximates nonlinear FEM elements with linear simplices.
///
/// &lt;b&gt;Warning&lt;/b&gt;: This class is temporary and will go away at some point
/// after ParaView 1.4.0.
///
/// This filter rifles through all the cells in an input vtkDataSet. It
/// tesselates each cell and uses the vtkStreamingTessellator and
/// vtkDataSetEdgeSubdivisionCriterion classes to generate simplices that
/// approximate the nonlinear mesh using some approximation metric (encoded
/// in the particular vtkDataSetEdgeSubdivisionCriterion::EvaluateLocationAndFields
/// implementation). The simplices are placed into the filter's output
/// vtkDataSet object by the callback routines AddATetrahedron,
/// AddATriangle, and AddALine, which are registered with the triangulator.
///
/// The output mesh will have geometry and any fields specified as
/// attributes in the input mesh's point data.  The attribute's copy flags
/// are honored, except for normals.
///
///
/// @par Internals:
/// The filter's main member function is RequestData(). This function first
/// calls SetupOutput() which allocates arrays and some temporary variables
/// for the primitive callbacks (OutputTriangle and OutputLine which are
/// called by AddATriangle and AddALine, respectively).  Each cell is given
/// an initial tessellation, which results in one or more calls to
/// OutputTetrahedron, OutputTriangle or OutputLine to add elements to the
/// OutputMesh. Finally, Teardown() is called to free the filter's working
/// space.
///
/// </remarks>
/// <seealso>
///
/// vtkDataSetToUnstructuredGridFilter vtkDataSet vtkStreamingTessellator
/// vtkDataSetEdgeSubdivisionCriterion
/// </seealso>
public class vtkTessellatorFilter : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTessellatorFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTessellatorFilter()
	{
		MRClassNameKey = "class vtkTessellatorFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTessellatorFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTessellatorFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTessellatorFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTessellatorFilter New()
	{
		vtkTessellatorFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTessellatorFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTessellatorFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTessellatorFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTessellatorFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTessellatorFilter_GetChordError_01(HandleRef pThis);

	/// <summary>
	/// These are convenience routines for setting properties maintained by the
	/// tessellator and subdivider. They are implemented here for ParaView's
	/// sake.
	/// </summary>
	public double GetChordError()
	{
		return vtkTessellatorFilter_GetChordError_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkTessellatorFilter_GetMTime_02(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkTessellatorFilter_GetMTime_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTessellatorFilter_GetMaximumNumberOfSubdivisions_03(HandleRef pThis);

	/// <summary>
	/// These are convenience routines for setting properties maintained by the
	/// tessellator and subdivider. They are implemented here for ParaView's
	/// sake.
	/// </summary>
	public int GetMaximumNumberOfSubdivisions()
	{
		return vtkTessellatorFilter_GetMaximumNumberOfSubdivisions_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTessellatorFilter_GetMergePoints_04(HandleRef pThis);

	/// <summary>
	/// The adaptive tessellation will output vertices that are not shared
	/// among cells, even where they should be. This can be corrected to
	/// some extents with a vtkMergeFilter.
	/// By default, the filter is off and vertices will not be shared.
	/// </summary>
	public virtual int GetMergePoints()
	{
		return vtkTessellatorFilter_GetMergePoints_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTessellatorFilter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTessellatorFilter_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTessellatorFilter_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTessellatorFilter_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTessellatorFilter_GetOutputDimension_07(HandleRef pThis);

	/// <summary>
	/// Set the dimension of the output tessellation.
	/// Cells in dimensions higher than the given value will have
	/// their boundaries of dimension \a OutputDimension tessellated.
	/// For example, if \a OutputDimension is 2, a hexahedron's
	/// quadrilateral faces would be tessellated rather than its
	/// interior.
	/// </summary>
	public virtual int GetOutputDimension()
	{
		return vtkTessellatorFilter_GetOutputDimension_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTessellatorFilter_GetOutputDimensionMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set the dimension of the output tessellation.
	/// Cells in dimensions higher than the given value will have
	/// their boundaries of dimension \a OutputDimension tessellated.
	/// For example, if \a OutputDimension is 2, a hexahedron's
	/// quadrilateral faces would be tessellated rather than its
	/// interior.
	/// </summary>
	public virtual int GetOutputDimensionMaxValue()
	{
		return vtkTessellatorFilter_GetOutputDimensionMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTessellatorFilter_GetOutputDimensionMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set the dimension of the output tessellation.
	/// Cells in dimensions higher than the given value will have
	/// their boundaries of dimension \a OutputDimension tessellated.
	/// For example, if \a OutputDimension is 2, a hexahedron's
	/// quadrilateral faces would be tessellated rather than its
	/// interior.
	/// </summary>
	public virtual int GetOutputDimensionMinValue()
	{
		return vtkTessellatorFilter_GetOutputDimensionMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTessellatorFilter_GetSubdivider_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual vtkDataSetEdgeSubdivisionCriterion GetSubdivider()
	{
		vtkDataSetEdgeSubdivisionCriterion vtkDataSetEdgeSubdivisionCriterion2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTessellatorFilter_GetSubdivider_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSetEdgeSubdivisionCriterion2 = (vtkDataSetEdgeSubdivisionCriterion)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSetEdgeSubdivisionCriterion2.Register(null);
			}
		}
		return vtkDataSetEdgeSubdivisionCriterion2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTessellatorFilter_GetTessellator_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual vtkStreamingTessellator GetTessellator()
	{
		vtkStreamingTessellator vtkStreamingTessellator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTessellatorFilter_GetTessellator_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStreamingTessellator2 = (vtkStreamingTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStreamingTessellator2.Register(null);
			}
		}
		return vtkStreamingTessellator2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTessellatorFilter_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTessellatorFilter_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTessellatorFilter_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTessellatorFilter_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatorFilter_MergePointsOff_14(HandleRef pThis);

	/// <summary>
	/// The adaptive tessellation will output vertices that are not shared
	/// among cells, even where they should be. This can be corrected to
	/// some extents with a vtkMergeFilter.
	/// By default, the filter is off and vertices will not be shared.
	/// </summary>
	public virtual void MergePointsOff()
	{
		vtkTessellatorFilter_MergePointsOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatorFilter_MergePointsOn_15(HandleRef pThis);

	/// <summary>
	/// The adaptive tessellation will output vertices that are not shared
	/// among cells, even where they should be. This can be corrected to
	/// some extents with a vtkMergeFilter.
	/// By default, the filter is off and vertices will not be shared.
	/// </summary>
	public virtual void MergePointsOn()
	{
		vtkTessellatorFilter_MergePointsOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTessellatorFilter_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTessellatorFilter NewInstance()
	{
		vtkTessellatorFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTessellatorFilter_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTessellatorFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatorFilter_ResetFieldCriteria_18(HandleRef pThis);

	/// <summary>
	/// These methods are for the ParaView client.
	/// </summary>
	public virtual void ResetFieldCriteria()
	{
		vtkTessellatorFilter_ResetFieldCriteria_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTessellatorFilter_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTessellatorFilter SafeDownCast(vtkObjectBase o)
	{
		vtkTessellatorFilter vtkTessellatorFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTessellatorFilter_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTessellatorFilter2 = (vtkTessellatorFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTessellatorFilter2.Register(null);
			}
		}
		return vtkTessellatorFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatorFilter_SetChordError_20(HandleRef pThis, double ce);

	/// <summary>
	/// These are convenience routines for setting properties maintained by the
	/// tessellator and subdivider. They are implemented here for ParaView's
	/// sake.
	/// </summary>
	public virtual void SetChordError(double ce)
	{
		vtkTessellatorFilter_SetChordError_20(GetCppThis(), ce);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatorFilter_SetFieldCriterion_21(HandleRef pThis, int field, double err);

	/// <summary>
	/// These methods are for the ParaView client.
	/// </summary>
	public virtual void SetFieldCriterion(int field, double err)
	{
		vtkTessellatorFilter_SetFieldCriterion_21(GetCppThis(), field, err);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatorFilter_SetMaximumNumberOfSubdivisions_22(HandleRef pThis, int num_subdiv_in);

	/// <summary>
	/// These are convenience routines for setting properties maintained by the
	/// tessellator and subdivider. They are implemented here for ParaView's
	/// sake.
	/// </summary>
	public virtual void SetMaximumNumberOfSubdivisions(int num_subdiv_in)
	{
		vtkTessellatorFilter_SetMaximumNumberOfSubdivisions_22(GetCppThis(), num_subdiv_in);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatorFilter_SetMergePoints_23(HandleRef pThis, int _arg);

	/// <summary>
	/// The adaptive tessellation will output vertices that are not shared
	/// among cells, even where they should be. This can be corrected to
	/// some extents with a vtkMergeFilter.
	/// By default, the filter is off and vertices will not be shared.
	/// </summary>
	public virtual void SetMergePoints(int _arg)
	{
		vtkTessellatorFilter_SetMergePoints_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatorFilter_SetOutputDimension_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the dimension of the output tessellation.
	/// Cells in dimensions higher than the given value will have
	/// their boundaries of dimension \a OutputDimension tessellated.
	/// For example, if \a OutputDimension is 2, a hexahedron's
	/// quadrilateral faces would be tessellated rather than its
	/// interior.
	/// </summary>
	public virtual void SetOutputDimension(int _arg)
	{
		vtkTessellatorFilter_SetOutputDimension_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatorFilter_SetSubdivider_25(HandleRef pThis, HandleRef arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetSubdivider(vtkDataSetEdgeSubdivisionCriterion arg0)
	{
		vtkTessellatorFilter_SetSubdivider_25(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTessellatorFilter_SetTessellator_26(HandleRef pThis, HandleRef arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetTessellator(vtkStreamingTessellator arg0)
	{
		vtkTessellatorFilter_SetTessellator_26(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
