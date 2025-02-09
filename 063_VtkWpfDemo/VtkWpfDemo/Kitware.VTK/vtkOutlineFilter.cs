using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOutlineFilter
/// </summary>
/// <remarks>
///    create wireframe outline for an arbitrary data set or composite dataset
///
/// vtkOutlineFilter is a filter that generates a wireframe outline of any
/// dataset or composite dataset. An outline consists of the twelve edges of
/// the dataset bounding box. An option exists for generating faces instead of
/// a wireframe outline.
///
/// @warning
/// When an input composite dataset is provided, options exist for producing
/// different styles of outline(s). Also, if the composite dataset has
/// non-geometric members (like tables) the result is unpredictable.
///
/// @warning
/// Specialized versions of the outline filter are also available. For example
/// see vtkStructuredGridOutlineFilter, vtkRectilinearGridOutlineFilter, and
/// vtkImageDataOutlineFilter.
/// </remarks>
public class vtkOutlineFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Generate solid faces for the box. This is off by default.
	/// </summary>
	public enum CompositeOutlineStyle
	{
		/// <summary>enum member</summary>
		LEAF_DATASETS = 1,
		/// <summary>enum member</summary>
		ROOT_AND_LEAFS = 2,
		/// <summary>enum member</summary>
		ROOT_LEVEL = 0,
		/// <summary>enum member</summary>
		SPECIFIED_INDEX = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOutlineFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOutlineFilter()
	{
		MRClassNameKey = "class vtkOutlineFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOutlineFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOutlineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOutlineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public new static vtkOutlineFilter New()
	{
		vtkOutlineFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOutlineFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOutlineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public vtkOutlineFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOutlineFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkOutlineFilter_AddIndex_01(HandleRef pThis, uint index);

	/// <summary>
	/// If the composite style is set to SpecifiedIndex, then one or more flat
	/// indices can be specified, and bounding boxes will be drawn around those
	/// pieces of the composite dataset. (Recall that the flat index is a
	/// non-negative integer, with root index=0, increasing in perorder
	/// (depth-first) traversal order.
	/// </summary>
	public void AddIndex(uint index)
	{
		vtkOutlineFilter_AddIndex_01(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineFilter_GenerateFacesOff_02(HandleRef pThis);

	/// <summary>
	/// Generate solid faces for the box. This is off by default.
	/// </summary>
	public virtual void GenerateFacesOff()
	{
		vtkOutlineFilter_GenerateFacesOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineFilter_GenerateFacesOn_03(HandleRef pThis);

	/// <summary>
	/// Generate solid faces for the box. This is off by default.
	/// </summary>
	public virtual void GenerateFacesOn()
	{
		vtkOutlineFilter_GenerateFacesOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOutlineFilter_GetCompositeStyle_04(HandleRef pThis);

	/// <summary>
	/// Specify a style for creating bounding boxes around input composite
	/// datasets. (If the filter input is a vtkDataSet type these options have
	/// no effect.) There are four choices: 1) place a bounding box around the
	/// root of the vtkCompositeDataSet (i.e., all of the data); 2) place
	/// separate bounding boxes around each vtkDataSet leaf of the composite
	/// dataset; 3) place a bounding box around the root and all dataset leaves;
	/// and 4) place a bounding box around each (flat) index of the composite
	/// dataset. The default behavior is both root and leafs.
	/// </summary>
	public virtual int GetCompositeStyle()
	{
		return vtkOutlineFilter_GetCompositeStyle_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOutlineFilter_GetGenerateFaces_05(HandleRef pThis);

	/// <summary>
	/// Generate solid faces for the box. This is off by default.
	/// </summary>
	public virtual int GetGenerateFaces()
	{
		return vtkOutlineFilter_GetGenerateFaces_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOutlineFilter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOutlineFilter_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOutlineFilter_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOutlineFilter_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOutlineFilter_GetOutputPointsPrecision_08(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkOutlineFilter_GetOutputPointsPrecision_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOutlineFilter_IsA_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOutlineFilter_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOutlineFilter_IsTypeOf_10(string type);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOutlineFilter_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOutlineFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public new vtkOutlineFilter NewInstance()
	{
		vtkOutlineFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOutlineFilter_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOutlineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineFilter_RemoveAllIndices_13(HandleRef pThis);

	/// <summary>
	/// If the composite style is set to SpecifiedIndex, then one or more flat
	/// indices can be specified, and bounding boxes will be drawn around those
	/// pieces of the composite dataset. (Recall that the flat index is a
	/// non-negative integer, with root index=0, increasing in perorder
	/// (depth-first) traversal order.
	/// </summary>
	public void RemoveAllIndices()
	{
		vtkOutlineFilter_RemoveAllIndices_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineFilter_RemoveIndex_14(HandleRef pThis, uint index);

	/// <summary>
	/// If the composite style is set to SpecifiedIndex, then one or more flat
	/// indices can be specified, and bounding boxes will be drawn around those
	/// pieces of the composite dataset. (Recall that the flat index is a
	/// non-negative integer, with root index=0, increasing in perorder
	/// (depth-first) traversal order.
	/// </summary>
	public void RemoveIndex(uint index)
	{
		vtkOutlineFilter_RemoveIndex_14(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOutlineFilter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public new static vtkOutlineFilter SafeDownCast(vtkObjectBase o)
	{
		vtkOutlineFilter vtkOutlineFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOutlineFilter_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOutlineFilter2 = (vtkOutlineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOutlineFilter2.Register(null);
			}
		}
		return vtkOutlineFilter2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineFilter_SetCompositeStyle_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify a style for creating bounding boxes around input composite
	/// datasets. (If the filter input is a vtkDataSet type these options have
	/// no effect.) There are four choices: 1) place a bounding box around the
	/// root of the vtkCompositeDataSet (i.e., all of the data); 2) place
	/// separate bounding boxes around each vtkDataSet leaf of the composite
	/// dataset; 3) place a bounding box around the root and all dataset leaves;
	/// and 4) place a bounding box around each (flat) index of the composite
	/// dataset. The default behavior is both root and leafs.
	/// </summary>
	public virtual void SetCompositeStyle(int _arg)
	{
		vtkOutlineFilter_SetCompositeStyle_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineFilter_SetCompositeStyleToLeafs_17(HandleRef pThis);

	/// <summary>
	/// Specify a style for creating bounding boxes around input composite
	/// datasets. (If the filter input is a vtkDataSet type these options have
	/// no effect.) There are four choices: 1) place a bounding box around the
	/// root of the vtkCompositeDataSet (i.e., all of the data); 2) place
	/// separate bounding boxes around each vtkDataSet leaf of the composite
	/// dataset; 3) place a bounding box around the root and all dataset leaves;
	/// and 4) place a bounding box around each (flat) index of the composite
	/// dataset. The default behavior is both root and leafs.
	/// </summary>
	public void SetCompositeStyleToLeafs()
	{
		vtkOutlineFilter_SetCompositeStyleToLeafs_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineFilter_SetCompositeStyleToRoot_18(HandleRef pThis);

	/// <summary>
	/// Specify a style for creating bounding boxes around input composite
	/// datasets. (If the filter input is a vtkDataSet type these options have
	/// no effect.) There are four choices: 1) place a bounding box around the
	/// root of the vtkCompositeDataSet (i.e., all of the data); 2) place
	/// separate bounding boxes around each vtkDataSet leaf of the composite
	/// dataset; 3) place a bounding box around the root and all dataset leaves;
	/// and 4) place a bounding box around each (flat) index of the composite
	/// dataset. The default behavior is both root and leafs.
	/// </summary>
	public void SetCompositeStyleToRoot()
	{
		vtkOutlineFilter_SetCompositeStyleToRoot_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineFilter_SetCompositeStyleToRootAndLeafs_19(HandleRef pThis);

	/// <summary>
	/// Specify a style for creating bounding boxes around input composite
	/// datasets. (If the filter input is a vtkDataSet type these options have
	/// no effect.) There are four choices: 1) place a bounding box around the
	/// root of the vtkCompositeDataSet (i.e., all of the data); 2) place
	/// separate bounding boxes around each vtkDataSet leaf of the composite
	/// dataset; 3) place a bounding box around the root and all dataset leaves;
	/// and 4) place a bounding box around each (flat) index of the composite
	/// dataset. The default behavior is both root and leafs.
	/// </summary>
	public void SetCompositeStyleToRootAndLeafs()
	{
		vtkOutlineFilter_SetCompositeStyleToRootAndLeafs_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineFilter_SetCompositeStyleToSpecifiedIndex_20(HandleRef pThis);

	/// <summary>
	/// Specify a style for creating bounding boxes around input composite
	/// datasets. (If the filter input is a vtkDataSet type these options have
	/// no effect.) There are four choices: 1) place a bounding box around the
	/// root of the vtkCompositeDataSet (i.e., all of the data); 2) place
	/// separate bounding boxes around each vtkDataSet leaf of the composite
	/// dataset; 3) place a bounding box around the root and all dataset leaves;
	/// and 4) place a bounding box around each (flat) index of the composite
	/// dataset. The default behavior is both root and leafs.
	/// </summary>
	public void SetCompositeStyleToSpecifiedIndex()
	{
		vtkOutlineFilter_SetCompositeStyleToSpecifiedIndex_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineFilter_SetGenerateFaces_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Generate solid faces for the box. This is off by default.
	/// </summary>
	public virtual void SetGenerateFaces(int _arg)
	{
		vtkOutlineFilter_SetGenerateFaces_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineFilter_SetOutputPointsPrecision_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkOutlineFilter_SetOutputPointsPrecision_22(GetCppThis(), _arg);
	}
}
