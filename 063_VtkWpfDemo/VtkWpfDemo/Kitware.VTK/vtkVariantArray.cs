using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVariantArray
/// </summary>
/// <remarks>
///    An array holding vtkVariants.
///
///
///
/// @par Thanks:
/// Thanks to Patricia Crossno, Ken Moreland, Andrew Wilson and Brian Wylie from
/// Sandia National Laboratories for their help in developing this class.
/// </remarks>
public class vtkVariantArray : vtkAbstractArray
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new enum DeleteMethod
	{
		/// <summary>enum member</summary>
		VTK_DATA_ARRAY_ALIGNED_FREE = 2,
		/// <summary>enum member</summary>
		VTK_DATA_ARRAY_DELETE = 1,
		/// <summary>enum member</summary>
		VTK_DATA_ARRAY_FREE = 0,
		/// <summary>enum member</summary>
		VTK_DATA_ARRAY_USER_DEFINED = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVariantArray";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVariantArray()
	{
		MRClassNameKey = "class vtkVariantArray";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVariantArray"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVariantArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVariantArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVariantArray New()
	{
		vtkVariantArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVariantArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariantArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkVariantArray()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVariantArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkVariantArray_Allocate_01(HandleRef pThis, long sz, long ext);

	/// <summary>
	/// Allocate memory for this array. Delete old storage only if necessary.
	/// Note that ext is no longer used.
	/// </summary>
	public override int Allocate(long sz, long ext)
	{
		return vtkVariantArray_Allocate_01(GetCppThis(), sz, ext);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_ClearLookup_02(HandleRef pThis);

	/// <summary>
	/// Delete the associated fast lookup data structure on this array,
	/// if it exists.  The lookup will be rebuilt on the next call to a lookup
	/// function.
	/// </summary>
	public override void ClearLookup()
	{
		vtkVariantArray_ClearLookup_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_DataChanged_03(HandleRef pThis);

	/// <summary>
	/// Tell the array explicitly that the data has changed.
	/// This is only necessary to call when you modify the array contents
	/// without using the array's API (i.e. you retrieve a pointer to the
	/// data and modify the array contents).  You need to call this so that
	/// the fast lookup will know to rebuild itself.  Otherwise, the lookup
	/// functions will give incorrect results.
	/// </summary>
	public override void DataChanged()
	{
		vtkVariantArray_DataChanged_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_DataElementChanged_04(HandleRef pThis, long id);

	/// <summary>
	/// Tell the array explicitly that a single data element has
	/// changed. Like DataChanged(), then is only necessary when you
	/// modify the array contents without using the array's API.
	/// </summary>
	public virtual void DataElementChanged(long id)
	{
		vtkVariantArray_DataElementChanged_04(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_DeepCopy_05(HandleRef pThis, HandleRef da);

	/// <summary>
	/// Deep copy of data. Implementation left to subclasses, which
	/// should support as many type conversions as possible given the
	/// data type.
	/// </summary>
	public override void DeepCopy(vtkAbstractArray da)
	{
		vtkVariantArray_DeepCopy_05(GetCppThis(), da?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVariantArray_ExtendedNew_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static vtkVariantArray ExtendedNew()
	{
		vtkVariantArray vtkVariantArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVariantArray_ExtendedNew_06(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVariantArray2 = (vtkVariantArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVariantArray2.Register(null);
			}
		}
		return vtkVariantArray2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkVariantArray_GetActualMemorySize_07(HandleRef pThis);

	/// <summary>
	/// Return the memory in kibibytes (1024 bytes) consumed by this data array. Used to
	/// support streaming and reading/writing data. The value returned is
	/// guaranteed to be greater than or equal to the memory required to
	/// actually represent the data represented by this object. The
	/// information returned is valid only after the pipeline has
	/// been updated.
	/// </summary>
	public override uint GetActualMemorySize()
	{
		return vtkVariantArray_GetActualMemorySize_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVariantArray_GetDataType_08(HandleRef pThis);

	/// <summary>
	/// Return the underlying data type. An integer indicating data type is
	/// returned as specified in vtkSetGet.h.
	/// </summary>
	public override int GetDataType()
	{
		return vtkVariantArray_GetDataType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVariantArray_GetDataTypeSize_09(HandleRef pThis);

	/// <summary>
	/// Return the size of the underlying data type.  For a bit, 1 is
	/// returned.  For string 0 is returned. Arrays with variable length
	/// components return 0.
	/// </summary>
	public override int GetDataTypeSize()
	{
		return vtkVariantArray_GetDataTypeSize_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVariantArray_GetElementComponentSize_10(HandleRef pThis);

	/// <summary>
	/// Return the size, in bytes, of the lowest-level element of an
	/// array.  For vtkDataArray and subclasses this is the size of the
	/// data type.  For vtkStringArray, this is
	/// sizeof(vtkStdString::value_type), which winds up being
	/// sizeof(char).
	/// </summary>
	public override int GetElementComponentSize()
	{
		return vtkVariantArray_GetElementComponentSize_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVariantArray_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVariantArray_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVariantArray_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVariantArray_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVariantArray_GetNumberOfValues_13(HandleRef pThis);

	/// <summary>
	/// Return the number of values in the array.
	/// </summary>
	public new long GetNumberOfValues()
	{
		return vtkVariantArray_GetNumberOfValues_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVariantArray_GetPointer_14(HandleRef pThis, long id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a pointer to the location in the internal array at the specified index.
	/// </summary>
	public vtkVariant GetPointer(long id)
	{
		vtkVariant result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVariantArray_GetPointer_14(GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: false, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVariantArray_GetValue_15(HandleRef pThis, long id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the data at a particular index.
	/// </summary>
	public vtkVariant GetValue(long id)
	{
		vtkVariant result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVariantArray_GetValue_15(GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVariantArray_GetVoidPointer_16(HandleRef pThis, long id);

	/// <summary>
	/// Return a void pointer. For image pipeline interface and other
	/// special pointer manipulation.
	/// </summary>
	public override IntPtr GetVoidPointer(long id)
	{
		return vtkVariantArray_GetVoidPointer_16(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_Initialize_17(HandleRef pThis);

	/// <summary>
	/// Release storage and reset array to initial state.
	/// </summary>
	public override void Initialize()
	{
		vtkVariantArray_Initialize_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVariantArray_InsertNextTuple_18(HandleRef pThis, long j, HandleRef source);

	/// <summary>
	/// Insert the jth tuple in the source array, at the end in this array.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// Returns the location at which the data was inserted.
	/// </summary>
	public override long InsertNextTuple(long j, vtkAbstractArray source)
	{
		return vtkVariantArray_InsertNextTuple_18(GetCppThis(), j, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVariantArray_InsertNextValue_19(HandleRef pThis, HandleRef value);

	/// <summary>
	/// Expand the array by one and set the value at that location.
	/// Return the array index of the inserted value.
	/// </summary>
	public long InsertNextValue(vtkVariant value)
	{
		return vtkVariantArray_InsertNextValue_19(GetCppThis(), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_InsertTuple_20(HandleRef pThis, long i, long j, HandleRef source);

	/// <summary>
	/// Insert the jth tuple in the source array, at ith location in this array.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public override void InsertTuple(long i, long j, vtkAbstractArray source)
	{
		vtkVariantArray_InsertTuple_20(GetCppThis(), i, j, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_InsertTuples_21(HandleRef pThis, HandleRef dstIds, HandleRef srcIds, HandleRef source);

	/// <summary>
	/// Copy the tuples indexed in srcIds from the source array to the tuple
	/// locations indexed by dstIds in this array.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public override void InsertTuples(vtkIdList dstIds, vtkIdList srcIds, vtkAbstractArray source)
	{
		vtkVariantArray_InsertTuples_21(GetCppThis(), dstIds?.GetCppThis() ?? default(HandleRef), srcIds?.GetCppThis() ?? default(HandleRef), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_InsertTuples_22(HandleRef pThis, long dstStart, long n, long srcStart, HandleRef source);

	/// <summary>
	/// Copy n consecutive tuples starting at srcStart from the source array to
	/// this array, starting at the dstStart location.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public override void InsertTuples(long dstStart, long n, long srcStart, vtkAbstractArray source)
	{
		vtkVariantArray_InsertTuples_22(GetCppThis(), dstStart, n, srcStart, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_InsertTuplesStartingAt_23(HandleRef pThis, long dstStart, HandleRef srcIds, HandleRef source);

	/// <summary>
	/// Copy the tuples indexed in srcIds from the source array to the tuple
	/// locations indexed by dstIds in this array.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public override void InsertTuplesStartingAt(long dstStart, vtkIdList srcIds, vtkAbstractArray source)
	{
		vtkVariantArray_InsertTuplesStartingAt_23(GetCppThis(), dstStart, srcIds?.GetCppThis() ?? default(HandleRef), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_InsertValue_24(HandleRef pThis, long id, HandleRef value);

	/// <summary>
	/// If id &lt; GetNumberOfValues(), overwrite the array at that index.
	/// If id &gt;= GetNumberOfValues(), expand the array size to id+1
	/// and set the final value to the specified value.
	/// </summary>
	public void InsertValue(long id, vtkVariant value)
	{
		vtkVariantArray_InsertValue_24(GetCppThis(), id, value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_InsertVariantValue_25(HandleRef pThis, long idx, HandleRef value);

	/// <summary>
	/// Safely insert a value into the array from a variant.
	/// </summary>
	public override void InsertVariantValue(long idx, vtkVariant value)
	{
		vtkVariantArray_InsertVariantValue_25(GetCppThis(), idx, value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_InterpolateTuple_26(HandleRef pThis, long i, HandleRef ptIndices, HandleRef source, IntPtr weights);

	/// <summary>
	/// Set the ith tuple in this array as the interpolated tuple value,
	/// given the ptIndices in the source array and associated
	/// interpolation weights.
	/// This method assumes that the two arrays are of the same type
	/// and structure.
	/// </summary>
	public override void InterpolateTuple(long i, vtkIdList ptIndices, vtkAbstractArray source, IntPtr weights)
	{
		vtkVariantArray_InterpolateTuple_26(GetCppThis(), i, ptIndices?.GetCppThis() ?? default(HandleRef), source?.GetCppThis() ?? default(HandleRef), weights);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_InterpolateTuple_27(HandleRef pThis, long i, long id1, HandleRef source1, long id2, HandleRef source2, double t);

	/// <summary>
	/// Insert the ith tuple in this array as interpolated from the two values,
	/// p1 and p2, and an interpolation factor, t.
	/// The interpolation factor ranges from (0,1),
	/// with t=0 located at p1. This method assumes that the three arrays are of
	/// the same type. p1 is value at index id1 in source1, while, p2 is
	/// value at index id2 in source2.
	/// </summary>
	public override void InterpolateTuple(long i, long id1, vtkAbstractArray source1, long id2, vtkAbstractArray source2, double t)
	{
		vtkVariantArray_InterpolateTuple_27(GetCppThis(), i, id1, source1?.GetCppThis() ?? default(HandleRef), id2, source2?.GetCppThis() ?? default(HandleRef), t);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVariantArray_IsA_28(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVariantArray_IsA_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVariantArray_IsNumeric_29(HandleRef pThis);

	/// <summary>
	/// Since each item can be of a different type, we say that a variant array is not numeric.
	/// </summary>
	public override int IsNumeric()
	{
		return vtkVariantArray_IsNumeric_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVariantArray_IsTypeOf_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVariantArray_IsTypeOf_30(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVariantArray_LookupValue_31(HandleRef pThis, HandleRef value);

	/// <summary>
	/// Return the indices where a specific value appears.
	/// </summary>
	public override long LookupValue(vtkVariant value)
	{
		return vtkVariantArray_LookupValue_31(GetCppThis(), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_LookupValue_32(HandleRef pThis, HandleRef value, HandleRef ids);

	/// <summary>
	/// Return the indices where a specific value appears.
	/// </summary>
	public override void LookupValue(vtkVariant value, vtkIdList ids)
	{
		vtkVariantArray_LookupValue_32(GetCppThis(), value?.GetCppThis() ?? default(HandleRef), ids?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVariantArray_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVariantArray NewInstance()
	{
		vtkVariantArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVariantArray_NewInstance_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariantArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVariantArray_NewIterator_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Subclasses must override this method and provide the right
	/// kind of templated vtkArrayIteratorTemplate.
	/// </summary>
	public override vtkArrayIterator NewIterator()
	{
		vtkArrayIterator vtkArrayIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVariantArray_NewIterator_35(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkArrayIterator2 = (vtkArrayIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkArrayIterator2.Register(null);
			}
		}
		return vtkArrayIterator2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVariantArray_Resize_36(HandleRef pThis, long numTuples);

	/// <summary>
	/// Resize the array while conserving the data.  Returns 1 if
	/// resizing succeeded and 0 otherwise.
	/// </summary>
	public override int Resize(long numTuples)
	{
		return vtkVariantArray_Resize_36(GetCppThis(), numTuples);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVariantArray_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVariantArray SafeDownCast(vtkObjectBase o)
	{
		vtkVariantArray vtkVariantArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVariantArray_SafeDownCast_37(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVariantArray2 = (vtkVariantArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVariantArray2.Register(null);
			}
		}
		return vtkVariantArray2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_SetArray_38(HandleRef pThis, HandleRef arr, long size, int save, int deleteMethod);

	/// <summary>
	/// Set the internal array used by this object.
	/// </summary>
	public void SetArray(vtkVariant arr, long size, int save, int deleteMethod)
	{
		vtkVariantArray_SetArray_38(GetCppThis(), arr?.GetCppThis() ?? default(HandleRef), size, save, deleteMethod);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_SetNumberOfTuples_39(HandleRef pThis, long number);

	/// <summary>
	/// Set the number of tuples (a component group) in the array. Note that
	/// this may allocate space depending on the number of components.
	/// </summary>
	public override void SetNumberOfTuples(long number)
	{
		vtkVariantArray_SetNumberOfTuples_39(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_SetTuple_40(HandleRef pThis, long i, long j, HandleRef source);

	/// <summary>
	/// Set the tuple at the ith location using the jth tuple in the source array.
	/// This method assumes that the two arrays have the same type
	/// and structure. Note that range checking and memory allocation is not
	/// performed; use in conjunction with SetNumberOfTuples() to allocate space.
	/// </summary>
	public override void SetTuple(long i, long j, vtkAbstractArray source)
	{
		vtkVariantArray_SetTuple_40(GetCppThis(), i, j, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_SetValue_41(HandleRef pThis, long id, HandleRef value);

	/// <summary>
	/// Set the data at a particular index. Does not do range checking. Make sure
	/// you use the method SetNumberOfValues() before inserting data.
	/// </summary>
	public void SetValue(long id, vtkVariant value)
	{
		vtkVariantArray_SetValue_41(GetCppThis(), id, value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_SetVariantValue_42(HandleRef pThis, long idx, HandleRef value);

	/// <summary>
	/// Insert a value into the array from a variant.
	/// </summary>
	public override void SetVariantValue(long idx, vtkVariant value)
	{
		vtkVariantArray_SetVariantValue_42(GetCppThis(), idx, value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_SetVoidArray_43(HandleRef pThis, IntPtr arr, long size, int save);

	/// <summary>
	/// This method lets the user specify data to be held by the array.  The
	/// array argument is a pointer to the data.  size is the size of
	/// the array supplied by the user.  Set save to 1 to keep the class
	/// from deleting the array when it cleans up or reallocates memory.
	/// The class uses the actual array provided; it does not copy the data
	/// from the supplied array.
	/// </summary>
	public override void SetVoidArray(IntPtr arr, long size, int save)
	{
		vtkVariantArray_SetVoidArray_43(GetCppThis(), arr, size, save);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_SetVoidArray_44(HandleRef pThis, IntPtr arr, long size, int save, int deleteM);

	/// <summary>
	/// This method lets the user specify data to be held by the array.  The
	/// array argument is a pointer to the data.  size is the size of
	/// the array supplied by the user.  Set save to 1 to keep the class
	/// from deleting the array when it cleans up or reallocates memory.
	/// The class uses the actual array provided; it does not copy the data
	/// from the supplied array.
	/// </summary>
	public override void SetVoidArray(IntPtr arr, long size, int save, int deleteM)
	{
		vtkVariantArray_SetVoidArray_44(GetCppThis(), arr, size, save, deleteM);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVariantArray_Squeeze_45(HandleRef pThis);

	/// <summary>
	/// Free any unnecessary memory.
	/// Description:
	/// Resize object to just fit data requirement. Reclaims extra memory.
	/// </summary>
	public override void Squeeze()
	{
		vtkVariantArray_Squeeze_45(GetCppThis());
	}
}
