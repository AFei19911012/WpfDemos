using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBitArray
/// </summary>
/// <remarks>
///    dynamic, self-adjusting array of bits
///
/// vtkBitArray is an array of bits (0/1 data value). The array is packed
/// so that each byte stores eight bits. vtkBitArray provides methods
/// for insertion and retrieval of bits, and will automatically resize
/// itself to hold new data.
/// </remarks>
public class vtkBitArray : vtkDataArray
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
	public new const string MRFullTypeName = "Kitware.VTK.vtkBitArray";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBitArray()
	{
		MRClassNameKey = "class vtkBitArray";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBitArray"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBitArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBitArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBitArray New()
	{
		vtkBitArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBitArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBitArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkBitArray()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBitArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkBitArray_Allocate_01(HandleRef pThis, long sz, long ext);

	/// <summary>
	/// Allocate memory for this array. Delete old storage only if necessary.
	/// Note that ext is no longer used.
	/// </summary>
	public override int Allocate(long sz, long ext)
	{
		return vtkBitArray_Allocate_01(GetCppThis(), sz, ext);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_ClearLookup_02(HandleRef pThis);

	/// <summary>
	/// Delete the associated fast lookup data structure on this array,
	/// if it exists.  The lookup will be rebuilt on the next call to a lookup
	/// function.
	/// </summary>
	public override void ClearLookup()
	{
		vtkBitArray_ClearLookup_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_DataChanged_03(HandleRef pThis);

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
		vtkBitArray_DataChanged_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_DeepCopy_04(HandleRef pThis, HandleRef da);

	/// <summary>
	/// Deep copy of another bit array.
	/// </summary>
	public override void DeepCopy(vtkDataArray da)
	{
		vtkBitArray_DeepCopy_04(GetCppThis(), da?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_DeepCopy_05(HandleRef pThis, HandleRef aa);

	/// <summary>
	/// Deep copy of another bit array.
	/// </summary>
	public override void DeepCopy(vtkAbstractArray aa)
	{
		vtkBitArray_DeepCopy_05(GetCppThis(), aa?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBitArray_GetDataType_06(HandleRef pThis);

	/// <summary>
	/// Release storage and reset array to initial state.
	/// </summary>
	public override int GetDataType()
	{
		return vtkBitArray_GetDataType_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBitArray_GetDataTypeSize_07(HandleRef pThis);

	/// <summary>
	/// Release storage and reset array to initial state.
	/// </summary>
	public override int GetDataTypeSize()
	{
		return vtkBitArray_GetDataTypeSize_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBitArray_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBitArray_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBitArray_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBitArray_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBitArray_GetPointer_10(HandleRef pThis, long id);

	/// <summary>
	/// Direct manipulation of the underlying data.
	/// </summary>
	public IntPtr GetPointer(long id)
	{
		return vtkBitArray_GetPointer_10(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBitArray_GetTuple_11(HandleRef pThis, long i);

	/// <summary>
	/// Get a pointer to a tuple at the ith location. This is a dangerous method
	/// (it is not thread safe since a pointer is returned).
	/// </summary>
	public override IntPtr GetTuple(long i)
	{
		return vtkBitArray_GetTuple_11(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_GetTuple_12(HandleRef pThis, long i, IntPtr tuple);

	/// <summary>
	/// Copy the tuple value into a user-provided array.
	/// </summary>
	public override void GetTuple(long i, IntPtr tuple)
	{
		vtkBitArray_GetTuple_12(GetCppThis(), i, tuple);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBitArray_GetValue_13(HandleRef pThis, long id);

	/// <summary>
	/// Get the data at a particular index.
	/// </summary>
	public int GetValue(long id)
	{
		return vtkBitArray_GetValue_13(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBitArray_GetVoidPointer_14(HandleRef pThis, long id);

	/// <summary>
	/// Get the address of a particular data index. Make sure data is allocated
	/// for the number of items requested. Set MaxId according to the number of
	/// data values requested.
	/// </summary>
	public override IntPtr GetVoidPointer(long id)
	{
		return vtkBitArray_GetVoidPointer_14(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_Initialize_15(HandleRef pThis);

	/// <summary>
	/// Release storage and reset array to initial state.
	/// </summary>
	public override void Initialize()
	{
		vtkBitArray_Initialize_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_InsertComponent_16(HandleRef pThis, long i, int j, double c);

	/// <summary>
	/// Insert the data component at ith tuple and jth component location.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public override void InsertComponent(long i, int j, double c)
	{
		vtkBitArray_InsertComponent_16(GetCppThis(), i, j, c);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBitArray_InsertNextTuple_17(HandleRef pThis, long j, HandleRef source);

	/// <summary>
	/// Insert the jth tuple in the source array, at the end in this array.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// Returns the location at which the data was inserted.
	/// </summary>
	public override long InsertNextTuple(long j, vtkAbstractArray source)
	{
		return vtkBitArray_InsertNextTuple_17(GetCppThis(), j, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBitArray_InsertNextTuple_18(HandleRef pThis, IntPtr tuple);

	/// <summary>
	/// Insert (memory allocation performed) the tuple onto the end of the array.
	/// </summary>
	public override long InsertNextTuple(IntPtr tuple)
	{
		return vtkBitArray_InsertNextTuple_18(GetCppThis(), tuple);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBitArray_InsertNextValue_19(HandleRef pThis, int i);

	/// <summary>
	/// Inserts values from a variant and checks to ensure there is enough memory
	/// </summary>
	public long InsertNextValue(int i)
	{
		return vtkBitArray_InsertNextValue_19(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_InsertTuple_20(HandleRef pThis, long i, long j, HandleRef source);

	/// <summary>
	/// Insert the jth tuple in the source array, at ith location in this array.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public override void InsertTuple(long i, long j, vtkAbstractArray source)
	{
		vtkBitArray_InsertTuple_20(GetCppThis(), i, j, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_InsertTuple_21(HandleRef pThis, long i, IntPtr tuple);

	/// <summary>
	/// Insert (memory allocation performed) the tuple into the ith location
	/// in the array.
	/// </summary>
	public override void InsertTuple(long i, IntPtr tuple)
	{
		vtkBitArray_InsertTuple_21(GetCppThis(), i, tuple);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_InsertTuples_22(HandleRef pThis, HandleRef dstIds, HandleRef srcIds, HandleRef source);

	/// <summary>
	/// Copy the tuples indexed in srcIds from the source array to the tuple
	/// locations indexed by dstIds in this array.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public override void InsertTuples(vtkIdList dstIds, vtkIdList srcIds, vtkAbstractArray source)
	{
		vtkBitArray_InsertTuples_22(GetCppThis(), dstIds?.GetCppThis() ?? default(HandleRef), srcIds?.GetCppThis() ?? default(HandleRef), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_InsertTuples_23(HandleRef pThis, long dstStart, long n, long srcStart, HandleRef source);

	/// <summary>
	/// Copy n consecutive tuples starting at srcStart from the source array to
	/// this array, starting at the dstStart location.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public override void InsertTuples(long dstStart, long n, long srcStart, vtkAbstractArray source)
	{
		vtkBitArray_InsertTuples_23(GetCppThis(), dstStart, n, srcStart, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_InsertTuplesStartingAt_24(HandleRef pThis, long dstStart, HandleRef srcIds, HandleRef source);

	/// <summary>
	/// Copy the tuples indexed in srcIds from the source array to the tuple
	/// locations starting at index dstStart.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public override void InsertTuplesStartingAt(long dstStart, vtkIdList srcIds, vtkAbstractArray source)
	{
		vtkBitArray_InsertTuplesStartingAt_24(GetCppThis(), dstStart, srcIds?.GetCppThis() ?? default(HandleRef), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_InsertValue_25(HandleRef pThis, long id, int i);

	/// <summary>
	/// Inserts values and checks to make sure there is enough memory
	/// </summary>
	public void InsertValue(long id, int i)
	{
		vtkBitArray_InsertValue_25(GetCppThis(), id, i);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_InsertVariantValue_26(HandleRef pThis, long idx, HandleRef value);

	/// <summary>
	/// Inserts values from a variant and checks to ensure there is enough memory
	/// </summary>
	public override void InsertVariantValue(long idx, vtkVariant value)
	{
		vtkBitArray_InsertVariantValue_26(GetCppThis(), idx, value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBitArray_IsA_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBitArray_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBitArray_IsTypeOf_28(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBitArray_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBitArray_LookupValue_29(HandleRef pThis, HandleRef value);

	/// <summary>
	/// Return the indices where a specific value appears.
	/// </summary>
	public override long LookupValue(vtkVariant value)
	{
		return vtkBitArray_LookupValue_29(GetCppThis(), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_LookupValue_30(HandleRef pThis, HandleRef value, HandleRef ids);

	/// <summary>
	/// Return the indices where a specific value appears.
	/// </summary>
	public override void LookupValue(vtkVariant value, vtkIdList ids)
	{
		vtkBitArray_LookupValue_30(GetCppThis(), value?.GetCppThis() ?? default(HandleRef), ids?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBitArray_LookupValue_31(HandleRef pThis, int value);

	/// <summary>
	/// Return the indices where a specific value appears.
	/// </summary>
	public long LookupValue(int value)
	{
		return vtkBitArray_LookupValue_31(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_LookupValue_32(HandleRef pThis, int value, HandleRef ids);

	/// <summary>
	/// Return the indices where a specific value appears.
	/// </summary>
	public void LookupValue(int value, vtkIdList ids)
	{
		vtkBitArray_LookupValue_32(GetCppThis(), value, ids?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBitArray_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBitArray NewInstance()
	{
		vtkBitArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBitArray_NewInstance_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBitArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBitArray_NewIterator_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns a new vtkBitArrayIterator instance.
	/// </summary>
	public override vtkArrayIterator NewIterator()
	{
		vtkArrayIterator vtkArrayIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBitArray_NewIterator_35(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBitArray_RemoveFirstTuple_36(HandleRef pThis);

	/// <summary>
	/// These methods remove tuples from the data array. They shift data and
	/// resize array, so the data array is still valid after this operation. Note,
	/// this operation is fairly slow.
	/// </summary>
	public override void RemoveFirstTuple()
	{
		vtkBitArray_RemoveFirstTuple_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_RemoveLastTuple_37(HandleRef pThis);

	/// <summary>
	/// These methods remove tuples from the data array. They shift data and
	/// resize array, so the data array is still valid after this operation. Note,
	/// this operation is fairly slow.
	/// </summary>
	public override void RemoveLastTuple()
	{
		vtkBitArray_RemoveLastTuple_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_RemoveTuple_38(HandleRef pThis, long id);

	/// <summary>
	/// These methods remove tuples from the data array. They shift data and
	/// resize array, so the data array is still valid after this operation. Note,
	/// this operation is fairly slow.
	/// </summary>
	public override void RemoveTuple(long id)
	{
		vtkBitArray_RemoveTuple_38(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBitArray_Resize_39(HandleRef pThis, long numTuples);

	/// <summary>
	/// Resize the array while conserving the data.
	/// </summary>
	public override int Resize(long numTuples)
	{
		return vtkBitArray_Resize_39(GetCppThis(), numTuples);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBitArray_SafeDownCast_40(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBitArray SafeDownCast(vtkObjectBase o)
	{
		vtkBitArray vtkBitArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBitArray_SafeDownCast_40(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBitArray2 = (vtkBitArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBitArray2.Register(null);
			}
		}
		return vtkBitArray2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_SetArray_41(HandleRef pThis, IntPtr array, long size, int save, int deleteMethod);

	/// <summary>
	/// This method lets the user specify data to be held by the array.  The
	/// array argument is a pointer to the data.  size is the size of
	/// the array supplied by the user.  Set save to 1 to keep the class
	/// from deleting the array when it cleans up or reallocates memory.
	/// The class uses the actual array provided; it does not copy the data
	/// from the supplied array.
	/// If the delete method is VTK_DATA_ARRAY_USER_DEFINED
	/// a custom free function can be assigned to be called using SetArrayFreeFunction,
	/// if no custom function is assigned we will default to delete[].
	/// </summary>
	public void SetArray(IntPtr array, long size, int save, int deleteMethod)
	{
		vtkBitArray_SetArray_41(GetCppThis(), array, size, save, deleteMethod);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_SetComponent_42(HandleRef pThis, long i, int j, double c);

	/// <summary>
	/// Set the data component at the ith tuple and jth component location.
	/// Note that i is less then NumberOfTuples and j is less then
	/// NumberOfComponents. Make sure enough memory has been allocated (use
	/// SetNumberOfTuples() and  SetNumberOfComponents()).
	/// </summary>
	public override void SetComponent(long i, int j, double c)
	{
		vtkBitArray_SetComponent_42(GetCppThis(), i, j, c);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_SetNumberOfTuples_43(HandleRef pThis, long number);

	/// <summary>
	/// Set the number of n-tuples in the array.
	/// </summary>
	public override void SetNumberOfTuples(long number)
	{
		vtkBitArray_SetNumberOfTuples_43(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkBitArray_SetNumberOfValues_44(HandleRef pThis, long number);

	/// <summary>
	/// In addition to setting the number of values, this method also sets the
	/// unused bits of the last byte of the array.
	/// </summary>
	public override bool SetNumberOfValues(long number)
	{
		return (vtkBitArray_SetNumberOfValues_44(GetCppThis(), number) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_SetTuple_45(HandleRef pThis, long i, long j, HandleRef source);

	/// <summary>
	/// Set the tuple at the ith location using the jth tuple in the source array.
	/// This method assumes that the two arrays have the same type
	/// and structure. Note that range checking and memory allocation is not
	/// performed; use in conjunction with SetNumberOfTuples() to allocate space.
	/// </summary>
	public override void SetTuple(long i, long j, vtkAbstractArray source)
	{
		vtkBitArray_SetTuple_45(GetCppThis(), i, j, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_SetTuple_46(HandleRef pThis, long i, IntPtr tuple);

	/// <summary>
	/// Set the tuple value at the ith location in the array.
	/// </summary>
	public override void SetTuple(long i, IntPtr tuple)
	{
		vtkBitArray_SetTuple_46(GetCppThis(), i, tuple);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_SetValue_47(HandleRef pThis, long id, int value);

	/// <summary>
	/// Set the data at a particular index. Does not do range checking. Make sure
	/// you use the method SetNumberOfValues() before inserting data.
	/// </summary>
	public void SetValue(long id, int value)
	{
		vtkBitArray_SetValue_47(GetCppThis(), id, value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_SetVariantValue_48(HandleRef pThis, long idx, HandleRef value);

	/// <summary>
	/// Set a value in the array from a variant.
	/// </summary>
	public override void SetVariantValue(long idx, vtkVariant value)
	{
		vtkBitArray_SetVariantValue_48(GetCppThis(), idx, value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_SetVoidArray_49(HandleRef pThis, IntPtr array, long size, int save);

	/// <summary>
	/// This method lets the user specify data to be held by the array.  The
	/// array argument is a pointer to the data.  size is the size of
	/// the array supplied by the user.  Set save to 1 to keep the class
	/// from deleting the array when it cleans up or reallocates memory.
	/// The class uses the actual array provided; it does not copy the data
	/// from the supplied array.
	/// If the delete method is VTK_DATA_ARRAY_USER_DEFINED
	/// a custom free function can be assigned to be called using SetArrayFreeFunction,
	/// if no custom function is assigned we will default to delete[].
	/// </summary>
	public override void SetVoidArray(IntPtr array, long size, int save)
	{
		vtkBitArray_SetVoidArray_49(GetCppThis(), array, size, save);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_SetVoidArray_50(HandleRef pThis, IntPtr array, long size, int save, int deleteMethod);

	/// <summary>
	/// This method lets the user specify data to be held by the array.  The
	/// array argument is a pointer to the data.  size is the size of
	/// the array supplied by the user.  Set save to 1 to keep the class
	/// from deleting the array when it cleans up or reallocates memory.
	/// The class uses the actual array provided; it does not copy the data
	/// from the supplied array.
	/// If the delete method is VTK_DATA_ARRAY_USER_DEFINED
	/// a custom free function can be assigned to be called using SetArrayFreeFunction,
	/// if no custom function is assigned we will default to delete[].
	/// </summary>
	public override void SetVoidArray(IntPtr array, long size, int save, int deleteMethod)
	{
		vtkBitArray_SetVoidArray_50(GetCppThis(), array, size, save, deleteMethod);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBitArray_Squeeze_51(HandleRef pThis);

	/// <summary>
	/// Free any unneeded memory.
	/// </summary>
	public override void Squeeze()
	{
		vtkBitArray_Squeeze_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBitArray_WritePointer_52(HandleRef pThis, long id, long number);

	/// <summary>
	/// Get the address of a particular data index. Make sure data is allocated
	/// for the number of items requested. Set MaxId according to the number of
	/// data values requested.
	/// </summary>
	public IntPtr WritePointer(long id, long number)
	{
		return vtkBitArray_WritePointer_52(GetCppThis(), id, number);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBitArray_WriteVoidPointer_53(HandleRef pThis, long id, long number);

	/// <summary>
	/// Get the address of a particular data index. Make sure data is allocated
	/// for the number of items requested. Set MaxId according to the number of
	/// data values requested.
	/// </summary>
	public override IntPtr WriteVoidPointer(long id, long number)
	{
		return vtkBitArray_WriteVoidPointer_53(GetCppThis(), id, number);
	}
}
