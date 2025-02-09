using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWeightedTransformFilter
/// </summary>
/// <remarks>
///    transform based on per-point or per-cell weighting functions.
///
///
/// vtkWeightedTransformFilter is a filter that can be used to "skin"
/// structures and to create new and complex shapes.  Unlike a
/// traditional transform filter (which has one transform for a data
/// set) or an assembly (which has one transform per part or group of
/// parts), a weighted transform produces the weighted sum of
/// transforms on a per-point or per-cell basis.
///
/// Each point or cell in the filter's input has an attached DataArray
/// that contains tuples of weighting functions, one per point or cell.
/// The filter also has a set of fixed transforms.  When the filter
/// executes, each input point/cell is transformed by each of the
/// transforms.  These results are weighted by the point/cell's
/// weighting factors to produce final output data.
///
/// Linear transforms are performance-optimized.  Using arbitrary
/// transforms will work, but performance may suffer.
///
/// As an example of the utility of weighted transforms, here's how
/// this filter can be used for "skinning."  Skinning is the process of
/// putting a mesh cover over an underlying structure, like skin over
/// bone.  Joints are difficult to skin because deformation is hard to
/// do.  Visualize skin over an elbow joint.  Part of the skin moves
/// with one bone, part of the skin moves with the other bone, and the
/// skin in the middle moves a little with each.
///
/// Weighted filtering can be used for a simple and efficient kind of
/// skinning.  Begin with a cylindrical mesh.  Create a FloatArray with
/// two components per tuple, and one tuple for each point in the mesh.
/// Assign transform weights that linear interpolate the distance along
/// the cylinder (one component is the distance along the cylinder, the
/// other is one minus that distance).  Set the filter up to use two
/// transforms, the two used to transform the two bones.  Now, when the
/// transforms change, the mesh will deform so as to, hopefully,
/// continue to cover the bones.
///
/// vtkWeightedTransformFilter is also useful for creating "strange and
/// complex" shapes using pinching, bending, and blending.
///
/// @warning
/// Weighted combination of normals and vectors are probably not appropriate
/// in many cases.  Surface normals are treated somewhat specially, but
/// in many cases you may need to regenerate the surface normals.
///
/// @warning
/// Cell data can only be transformed if all transforms are linear.
///
///
/// </remarks>
/// <seealso>
///
/// vtkAbstractTransform vtkLinearTransform vtkTransformPolyDataFilter vtkActor
/// </seealso>
public class vtkWeightedTransformFilter : vtkPointSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWeightedTransformFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWeightedTransformFilter()
	{
		MRClassNameKey = "class vtkWeightedTransformFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWeightedTransformFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWeightedTransformFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWeightedTransformFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWeightedTransformFilter New()
	{
		vtkWeightedTransformFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWeightedTransformFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWeightedTransformFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkWeightedTransformFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkWeightedTransformFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWeightedTransformFilter_AddInputValuesOff_01(HandleRef pThis);

	/// <summary>
	/// If AddInputValues is true, the output values of this filter will be
	/// offset from the input values.  The effect is exactly equivalent to
	/// having an identity transform of weight 1 added into each output point.
	/// </summary>
	public virtual void AddInputValuesOff()
	{
		vtkWeightedTransformFilter_AddInputValuesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWeightedTransformFilter_AddInputValuesOn_02(HandleRef pThis);

	/// <summary>
	/// If AddInputValues is true, the output values of this filter will be
	/// offset from the input values.  The effect is exactly equivalent to
	/// having an identity transform of weight 1 added into each output point.
	/// </summary>
	public virtual void AddInputValuesOn()
	{
		vtkWeightedTransformFilter_AddInputValuesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWeightedTransformFilter_GetAddInputValues_03(HandleRef pThis);

	/// <summary>
	/// If AddInputValues is true, the output values of this filter will be
	/// offset from the input values.  The effect is exactly equivalent to
	/// having an identity transform of weight 1 added into each output point.
	/// </summary>
	public virtual int GetAddInputValues()
	{
		return vtkWeightedTransformFilter_GetAddInputValues_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWeightedTransformFilter_GetCellDataTransformIndexArray_04(HandleRef pThis);

	/// <summary>
	/// The CellDataTransformIndexArray is like a TransformIndexArray,
	/// except for cell data.  The array must have type UnsignedShort.
	/// </summary>
	public virtual string GetCellDataTransformIndexArray()
	{
		return Marshal.PtrToStringAnsi(vtkWeightedTransformFilter_GetCellDataTransformIndexArray_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWeightedTransformFilter_GetCellDataWeightArray_05(HandleRef pThis);

	/// <summary>
	/// The CellDataWeightArray is analogous to the WeightArray, except
	/// for CellData.  The array is searched for first in the CellData
	/// FieldData, then in the input's FieldData.  The data array must have
	/// a tuple for each cell.  This array is used to transform only normals
	/// and vectors.
	/// </summary>
	public virtual string GetCellDataWeightArray()
	{
		return Marshal.PtrToStringAnsi(vtkWeightedTransformFilter_GetCellDataWeightArray_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkWeightedTransformFilter_GetMTime_06(HandleRef pThis);

	/// <summary>
	/// Return the MTime also considering the filter's transforms.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkWeightedTransformFilter_GetMTime_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWeightedTransformFilter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWeightedTransformFilter_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWeightedTransformFilter_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWeightedTransformFilter_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWeightedTransformFilter_GetNumberOfTransforms_09(HandleRef pThis);

	/// <summary>
	/// Set the number of transforms for the filter.  References to non-existent
	/// filter numbers in the data array is equivalent to a weight of zero
	/// (i.e., no contribution of that filter or weight).  The maximum number of
	/// transforms is limited to 65536 if transform index arrays are used.
	/// </summary>
	public virtual int GetNumberOfTransforms()
	{
		return vtkWeightedTransformFilter_GetNumberOfTransforms_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWeightedTransformFilter_GetTransform_10(HandleRef pThis, int num, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set or Get one of the filter's transforms. The transform number must
	/// be less than the number of transforms allocated for the object.  Setting
	/// a transform slot to nullptr is equivalent to assigning an overriding weight
	/// of zero to that filter slot.
	/// </summary>
	public virtual vtkAbstractTransform GetTransform(int num)
	{
		vtkAbstractTransform vtkAbstractTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWeightedTransformFilter_GetTransform_10(GetCppThis(), num, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractTransform2 = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractTransform2.Register(null);
			}
		}
		return vtkAbstractTransform2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWeightedTransformFilter_GetTransformIndexArray_11(HandleRef pThis);

	/// <summary>
	/// TransformIndexArray is the string name of the DataArray in the input's
	/// FieldData that holds the indices for the transforms for each point.
	/// These indices are used to select which transforms each weight of
	/// the DataArray refers.  If the TransformIndexArray is not specified,
	/// the weights of each point are assumed to map directly to a transform.
	/// This DataArray must be of type UnsignedShort, which effectively
	/// limits the number of transforms to 65536 if a transform index
	/// array is used.
	///
	/// The filter will first look for the array in the input's PointData
	/// FieldData.  If the array isn't there, the filter looks in the
	/// input's FieldData.  The TransformIndexArray can have tuples of any
	/// length, but must have a tuple for every point in the input data set.
	/// This array transforms points, normals, and vectors.
	/// </summary>
	public virtual string GetTransformIndexArray()
	{
		return Marshal.PtrToStringAnsi(vtkWeightedTransformFilter_GetTransformIndexArray_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWeightedTransformFilter_GetWeightArray_12(HandleRef pThis);

	/// <summary>
	/// WeightArray is the string name of the DataArray in the input's
	/// FieldData that holds the weighting coefficients for each point.
	/// The filter will first look for the array in the input's PointData
	/// FieldData.  If the array isn't there, the filter looks in the
	/// input's FieldData.  The WeightArray can have tuples of any length,
	/// but must have a tuple for every point in the input data set.
	/// This array transforms points, normals, and vectors.
	/// </summary>
	public virtual string GetWeightArray()
	{
		return Marshal.PtrToStringAnsi(vtkWeightedTransformFilter_GetWeightArray_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWeightedTransformFilter_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWeightedTransformFilter_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWeightedTransformFilter_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWeightedTransformFilter_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWeightedTransformFilter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkWeightedTransformFilter NewInstance()
	{
		vtkWeightedTransformFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWeightedTransformFilter_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWeightedTransformFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWeightedTransformFilter_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWeightedTransformFilter SafeDownCast(vtkObjectBase o)
	{
		vtkWeightedTransformFilter vtkWeightedTransformFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWeightedTransformFilter_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWeightedTransformFilter2 = (vtkWeightedTransformFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWeightedTransformFilter2.Register(null);
			}
		}
		return vtkWeightedTransformFilter2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWeightedTransformFilter_SetAddInputValues_18(HandleRef pThis, int _arg);

	/// <summary>
	/// If AddInputValues is true, the output values of this filter will be
	/// offset from the input values.  The effect is exactly equivalent to
	/// having an identity transform of weight 1 added into each output point.
	/// </summary>
	public virtual void SetAddInputValues(int _arg)
	{
		vtkWeightedTransformFilter_SetAddInputValues_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWeightedTransformFilter_SetCellDataTransformIndexArray_19(HandleRef pThis, string _arg);

	/// <summary>
	/// The CellDataTransformIndexArray is like a TransformIndexArray,
	/// except for cell data.  The array must have type UnsignedShort.
	/// </summary>
	public virtual void SetCellDataTransformIndexArray(string _arg)
	{
		vtkWeightedTransformFilter_SetCellDataTransformIndexArray_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWeightedTransformFilter_SetCellDataWeightArray_20(HandleRef pThis, string _arg);

	/// <summary>
	/// The CellDataWeightArray is analogous to the WeightArray, except
	/// for CellData.  The array is searched for first in the CellData
	/// FieldData, then in the input's FieldData.  The data array must have
	/// a tuple for each cell.  This array is used to transform only normals
	/// and vectors.
	/// </summary>
	public virtual void SetCellDataWeightArray(string _arg)
	{
		vtkWeightedTransformFilter_SetCellDataWeightArray_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWeightedTransformFilter_SetNumberOfTransforms_21(HandleRef pThis, int num);

	/// <summary>
	/// Set the number of transforms for the filter.  References to non-existent
	/// filter numbers in the data array is equivalent to a weight of zero
	/// (i.e., no contribution of that filter or weight).  The maximum number of
	/// transforms is limited to 65536 if transform index arrays are used.
	/// </summary>
	public virtual void SetNumberOfTransforms(int num)
	{
		vtkWeightedTransformFilter_SetNumberOfTransforms_21(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWeightedTransformFilter_SetTransform_22(HandleRef pThis, HandleRef transform, int num);

	/// <summary>
	/// Set or Get one of the filter's transforms. The transform number must
	/// be less than the number of transforms allocated for the object.  Setting
	/// a transform slot to nullptr is equivalent to assigning an overriding weight
	/// of zero to that filter slot.
	/// </summary>
	public virtual void SetTransform(vtkAbstractTransform transform, int num)
	{
		vtkWeightedTransformFilter_SetTransform_22(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef), num);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWeightedTransformFilter_SetTransformIndexArray_23(HandleRef pThis, string _arg);

	/// <summary>
	/// TransformIndexArray is the string name of the DataArray in the input's
	/// FieldData that holds the indices for the transforms for each point.
	/// These indices are used to select which transforms each weight of
	/// the DataArray refers.  If the TransformIndexArray is not specified,
	/// the weights of each point are assumed to map directly to a transform.
	/// This DataArray must be of type UnsignedShort, which effectively
	/// limits the number of transforms to 65536 if a transform index
	/// array is used.
	///
	/// The filter will first look for the array in the input's PointData
	/// FieldData.  If the array isn't there, the filter looks in the
	/// input's FieldData.  The TransformIndexArray can have tuples of any
	/// length, but must have a tuple for every point in the input data set.
	/// This array transforms points, normals, and vectors.
	/// </summary>
	public virtual void SetTransformIndexArray(string _arg)
	{
		vtkWeightedTransformFilter_SetTransformIndexArray_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWeightedTransformFilter_SetWeightArray_24(HandleRef pThis, string _arg);

	/// <summary>
	/// WeightArray is the string name of the DataArray in the input's
	/// FieldData that holds the weighting coefficients for each point.
	/// The filter will first look for the array in the input's PointData
	/// FieldData.  If the array isn't there, the filter looks in the
	/// input's FieldData.  The WeightArray can have tuples of any length,
	/// but must have a tuple for every point in the input data set.
	/// This array transforms points, normals, and vectors.
	/// </summary>
	public virtual void SetWeightArray(string _arg)
	{
		vtkWeightedTransformFilter_SetWeightArray_24(GetCppThis(), _arg);
	}
}
