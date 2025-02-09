using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSortDataArray
/// </summary>
/// <remarks>
///    provides several methods for sorting VTK arrays.
///
///
/// vtkSortDataArray is used to sort data, based on its value, or with an
/// associated key, into either ascending or descending order. This is useful
/// for operations like selection, or analysis, when evaluating and processing
/// data. A variety of sorting functions are provided, treating both arrays
/// (i.e., vtkAbstractArray) and id lists (vtkIdList). Note that complex arrays
/// like variants and string arrays are also handled.
///
/// Additional functionality is provided to generate data ordering, without
/// necessarily shuffling the data into a final, sorted position. Hence, the
/// sorting process is organized into three steps because of the complexity of
/// dealing with multiple types and multiple component data arrays. The first
/// step involves creating and initializing a sorted index array, and then
/// (second step) sorting this array to produce a map indicating the sorting
/// order.  In other words, the sorting index array is a permutation which can
/// be applied to other, associated data to shuffle it (third step) into an
/// order consistent with the sorting operation. Note that the generation of
/// the sorted index array is useful unto itself (even without the final
/// shuffling of data) because it generates an ordered list (from the data
/// values of any component in any array). So for example, it is possible to
/// find the top N cells with the largest scalar value simply by generating
/// the sorting index array from the call scalar values.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly on
/// multi-core machines.
///
/// @warning
/// The sort methods below are static, hence the sorting methods can be
/// used without instantiating the class. All methods are thread safe.
///
/// </remarks>
/// <seealso>
///
/// vtkSortFieldData
/// </seealso>
public class vtkSortDataArray : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSortDataArray";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSortDataArray()
	{
		MRClassNameKey = "class vtkSortDataArray";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSortDataArray"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSortDataArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSortDataArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods for instantiating, managing type, and printing
	/// information about this class.
	/// </summary>
	public new static vtkSortDataArray New()
	{
		vtkSortDataArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSortDataArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSortDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard VTK methods for instantiating, managing type, and printing
	/// information about this class.
	/// </summary>
	public vtkSortDataArray()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSortDataArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortDataArray_GenerateSortIndices_01(int dataType, IntPtr dataIn, long numKeys, int numComp, int k, IntPtr idx);

	/// <summary>
	/// The following are general functions which can be used to produce an
	/// ordering, and/or sort various types of VTK arrays. Don't use these
	/// methods unless you really know what you are doing. The basic idea is
	/// that an initial set of indices (InitializeSortIndices() that refer to
	/// the data contained in a vtkAbstractArray or vtkIdList) are sorted
	/// (GenerateSortIndices() based on the data values in the array). The
	/// result of the sort is the creation of a permutation array (the sort
	/// array idx) that indicates where the data tuples originated (e.g., after
	/// the sort, idx[0] indicates where in the array the tuple was originally
	/// located prior to sorting.) This sorted index array can be used to
	/// shuffle various types of VTK arrays (the types supported correspond to
	/// the various arrays which are subclasses of vtkDataArrayTemplate, use
	/// ShuffleArray() or for vtkIdList, use ShuffleIdList()). Also, the sort
	/// array, being an vtkIdType* (i.e., id list), can also be used to identify
	/// points or cells in sorted order (based on the data in the originating
	/// dataIn array). Note that sorting is always performed in ascending order,
	/// and the sorted index array reflects this; however the shuffling of data
	/// can be specified as either ascending (dir=0) or descending (dir=1)
	/// order. The user is responsible for taking ownership of the sort indices
	/// (i.e., free the idx array).
	/// </summary>
	public static void GenerateSortIndices(int dataType, IntPtr dataIn, long numKeys, int numComp, int k, IntPtr idx)
	{
		vtkSortDataArray_GenerateSortIndices_01(dataType, dataIn, numKeys, numComp, k, idx);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSortDataArray_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods for instantiating, managing type, and printing
	/// information about this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSortDataArray_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSortDataArray_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard VTK methods for instantiating, managing type, and printing
	/// information about this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSortDataArray_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSortDataArray_InitializeSortIndices_04(long numKeys);

	/// <summary>
	/// The following are general functions which can be used to produce an
	/// ordering, and/or sort various types of VTK arrays. Don't use these
	/// methods unless you really know what you are doing. The basic idea is
	/// that an initial set of indices (InitializeSortIndices() that refer to
	/// the data contained in a vtkAbstractArray or vtkIdList) are sorted
	/// (GenerateSortIndices() based on the data values in the array). The
	/// result of the sort is the creation of a permutation array (the sort
	/// array idx) that indicates where the data tuples originated (e.g., after
	/// the sort, idx[0] indicates where in the array the tuple was originally
	/// located prior to sorting.) This sorted index array can be used to
	/// shuffle various types of VTK arrays (the types supported correspond to
	/// the various arrays which are subclasses of vtkDataArrayTemplate, use
	/// ShuffleArray() or for vtkIdList, use ShuffleIdList()). Also, the sort
	/// array, being an vtkIdType* (i.e., id list), can also be used to identify
	/// points or cells in sorted order (based on the data in the originating
	/// dataIn array). Note that sorting is always performed in ascending order,
	/// and the sorted index array reflects this; however the shuffling of data
	/// can be specified as either ascending (dir=0) or descending (dir=1)
	/// order. The user is responsible for taking ownership of the sort indices
	/// (i.e., free the idx array).
	/// </summary>
	public static IntPtr InitializeSortIndices(long numKeys)
	{
		return vtkSortDataArray_InitializeSortIndices_04(numKeys);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSortDataArray_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods for instantiating, managing type, and printing
	/// information about this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSortDataArray_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSortDataArray_IsTypeOf_06(string type);

	/// <summary>
	/// Standard VTK methods for instantiating, managing type, and printing
	/// information about this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSortDataArray_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSortDataArray_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods for instantiating, managing type, and printing
	/// information about this class.
	/// </summary>
	public new vtkSortDataArray NewInstance()
	{
		vtkSortDataArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSortDataArray_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSortDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSortDataArray_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods for instantiating, managing type, and printing
	/// information about this class.
	/// </summary>
	public new static vtkSortDataArray SafeDownCast(vtkObjectBase o)
	{
		vtkSortDataArray vtkSortDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSortDataArray_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSortDataArray2 = (vtkSortDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSortDataArray2.Register(null);
			}
		}
		return vtkSortDataArray2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortDataArray_ShuffleArray_10(IntPtr idx, int dataType, long numKeys, int numComp, HandleRef arr, IntPtr dataIn, int dir);

	/// <summary>
	/// The following are general functions which can be used to produce an
	/// ordering, and/or sort various types of VTK arrays. Don't use these
	/// methods unless you really know what you are doing. The basic idea is
	/// that an initial set of indices (InitializeSortIndices() that refer to
	/// the data contained in a vtkAbstractArray or vtkIdList) are sorted
	/// (GenerateSortIndices() based on the data values in the array). The
	/// result of the sort is the creation of a permutation array (the sort
	/// array idx) that indicates where the data tuples originated (e.g., after
	/// the sort, idx[0] indicates where in the array the tuple was originally
	/// located prior to sorting.) This sorted index array can be used to
	/// shuffle various types of VTK arrays (the types supported correspond to
	/// the various arrays which are subclasses of vtkDataArrayTemplate, use
	/// ShuffleArray() or for vtkIdList, use ShuffleIdList()). Also, the sort
	/// array, being an vtkIdType* (i.e., id list), can also be used to identify
	/// points or cells in sorted order (based on the data in the originating
	/// dataIn array). Note that sorting is always performed in ascending order,
	/// and the sorted index array reflects this; however the shuffling of data
	/// can be specified as either ascending (dir=0) or descending (dir=1)
	/// order. The user is responsible for taking ownership of the sort indices
	/// (i.e., free the idx array).
	/// </summary>
	public static void ShuffleArray(IntPtr idx, int dataType, long numKeys, int numComp, vtkAbstractArray arr, IntPtr dataIn, int dir)
	{
		vtkSortDataArray_ShuffleArray_10(idx, dataType, numKeys, numComp, arr?.GetCppThis() ?? default(HandleRef), dataIn, dir);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortDataArray_ShuffleIdList_11(IntPtr idx, long sze, HandleRef arrayIn, IntPtr dataIn, int dir);

	/// <summary>
	/// The following are general functions which can be used to produce an
	/// ordering, and/or sort various types of VTK arrays. Don't use these
	/// methods unless you really know what you are doing. The basic idea is
	/// that an initial set of indices (InitializeSortIndices() that refer to
	/// the data contained in a vtkAbstractArray or vtkIdList) are sorted
	/// (GenerateSortIndices() based on the data values in the array). The
	/// result of the sort is the creation of a permutation array (the sort
	/// array idx) that indicates where the data tuples originated (e.g., after
	/// the sort, idx[0] indicates where in the array the tuple was originally
	/// located prior to sorting.) This sorted index array can be used to
	/// shuffle various types of VTK arrays (the types supported correspond to
	/// the various arrays which are subclasses of vtkDataArrayTemplate, use
	/// ShuffleArray() or for vtkIdList, use ShuffleIdList()). Also, the sort
	/// array, being an vtkIdType* (i.e., id list), can also be used to identify
	/// points or cells in sorted order (based on the data in the originating
	/// dataIn array). Note that sorting is always performed in ascending order,
	/// and the sorted index array reflects this; however the shuffling of data
	/// can be specified as either ascending (dir=0) or descending (dir=1)
	/// order. The user is responsible for taking ownership of the sort indices
	/// (i.e., free the idx array).
	/// </summary>
	public static void ShuffleIdList(IntPtr idx, long sze, vtkIdList arrayIn, IntPtr dataIn, int dir)
	{
		vtkSortDataArray_ShuffleIdList_11(idx, sze, arrayIn?.GetCppThis() ?? default(HandleRef), dataIn, dir);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortDataArray_Sort_12(HandleRef keys);

	/// <summary>
	/// Sorts the given array in ascending order. For this method, the keys must
	/// be single-component tuples.
	/// </summary>
	public static void Sort(vtkIdList keys)
	{
		vtkSortDataArray_Sort_12(keys?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortDataArray_Sort_13(HandleRef keys);

	/// <summary>
	/// Sorts the given array in ascending order. For this method, the keys must
	/// be single-component tuples.
	/// </summary>
	public static void Sort(vtkAbstractArray keys)
	{
		vtkSortDataArray_Sort_13(keys?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortDataArray_Sort_14(HandleRef keys, int dir);

	/// <summary>
	/// Sorts the given array in either ascending (dir=0) or descending (dir!=0)
	/// order. For this method, the keys must be single-component tuples.
	/// </summary>
	public static void Sort(vtkIdList keys, int dir)
	{
		vtkSortDataArray_Sort_14(keys?.GetCppThis() ?? default(HandleRef), dir);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortDataArray_Sort_15(HandleRef keys, int dir);

	/// <summary>
	/// Sorts the given array in either ascending (dir=0) or descending (dir!=0)
	/// order. For this method, the keys must be single-component tuples.
	/// </summary>
	public static void Sort(vtkAbstractArray keys, int dir)
	{
		vtkSortDataArray_Sort_15(keys?.GetCppThis() ?? default(HandleRef), dir);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortDataArray_Sort_16(HandleRef keys, HandleRef values);

	/// <summary>
	/// Sorts the given key/value pairs based on the keys (the keys are expected
	/// to be 1-tuples, values may have number of components &gt;= 1).
	/// Obviously, the two arrays must be of equal size. Sorts in ascending
	/// order.
	/// </summary>
	public static void Sort(vtkAbstractArray keys, vtkAbstractArray values)
	{
		vtkSortDataArray_Sort_16(keys?.GetCppThis() ?? default(HandleRef), values?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortDataArray_Sort_17(HandleRef keys, HandleRef values);

	/// <summary>
	/// Sorts the given key/value pairs based on the keys (the keys are expected
	/// to be 1-tuples, values may have number of components &gt;= 1).
	/// Obviously, the two arrays must be of equal size. Sorts in ascending
	/// order.
	/// </summary>
	public static void Sort(vtkAbstractArray keys, vtkIdList values)
	{
		vtkSortDataArray_Sort_17(keys?.GetCppThis() ?? default(HandleRef), values?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortDataArray_Sort_18(HandleRef keys, HandleRef values, int dir);

	/// <summary>
	/// Sorts the given key/value pairs based on the keys (the keys are expected
	/// to be 1-tuples, values may have number of components &gt;= 1).
	/// Obviously, the two arrays must be of equal size. Sorts in either
	/// ascending (dir=0) or descending (dir=1) order.
	/// </summary>
	public static void Sort(vtkAbstractArray keys, vtkAbstractArray values, int dir)
	{
		vtkSortDataArray_Sort_18(keys?.GetCppThis() ?? default(HandleRef), values?.GetCppThis() ?? default(HandleRef), dir);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortDataArray_Sort_19(HandleRef keys, HandleRef values, int dir);

	/// <summary>
	/// Sorts the given key/value pairs based on the keys (the keys are expected
	/// to be 1-tuples, values may have number of components &gt;= 1).
	/// Obviously, the two arrays must be of equal size. Sorts in either
	/// ascending (dir=0) or descending (dir=1) order.
	/// </summary>
	public static void Sort(vtkAbstractArray keys, vtkIdList values, int dir)
	{
		vtkSortDataArray_Sort_19(keys?.GetCppThis() ?? default(HandleRef), values?.GetCppThis() ?? default(HandleRef), dir);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortDataArray_SortArrayByComponent_20(HandleRef arr, int k);

	/// <summary>
	/// Sorts the given data array using the specified component as a key.
	/// Think of the array as a 2-D grid with each tuple representing a row.
	/// Tuples are swapped until the \a k-th column of the grid is
	/// monotonically increasing. Where two tuples have the same value for
	/// the \a k-th component, their order in the final result is unspecified.
	/// </summary>
	public static void SortArrayByComponent(vtkAbstractArray arr, int k)
	{
		vtkSortDataArray_SortArrayByComponent_20(arr?.GetCppThis() ?? default(HandleRef), k);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSortDataArray_SortArrayByComponent_21(HandleRef arr, int k, int dir);

	/// <summary>
	/// Sorts the given data array using the specified component as a key.
	/// Think of the array as a 2-D grid with each tuple representing a row.
	/// Tuples are swapped until the \a k-th column of the grid is ascending
	/// (dir=0) or descending (dir=1). Where two tuples have the same value for
	/// the \a k-th component, their order in the final result is unspecified.
	/// </summary>
	public static void SortArrayByComponent(vtkAbstractArray arr, int k, int dir)
	{
		vtkSortDataArray_SortArrayByComponent_21(arr?.GetCppThis() ?? default(HandleRef), k, dir);
	}
}
