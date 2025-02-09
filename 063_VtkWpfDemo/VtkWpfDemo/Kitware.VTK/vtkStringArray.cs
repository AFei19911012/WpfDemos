using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStringArray
/// </summary>
/// <remarks>
///    a vtkAbstractArray subclass for strings
///
/// Points and cells may sometimes have associated data that are stored
/// as strings, e.g. labels for information visualization projects.
/// This class provides a clean way to store and access those strings.
/// @par Thanks:
/// </remarks>
/// <seealso>
/// Andy Wilson (atwilsondia.gov) wrote this class.
/// </seealso>
public class vtkStringArray : vtkAbstractArray
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
	public new const string MRFullTypeName = "Kitware.VTK.vtkStringArray";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStringArray()
	{
		MRClassNameKey = "class vtkStringArray";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStringArray"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStringArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStringArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStringArray New()
	{
		vtkStringArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStringArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkStringArray()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStringArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkStringArray_Allocate_01(HandleRef pThis, long sz, long ext);

	/// <summary>
	/// Allocate memory for this array. Delete old storage only if necessary.
	/// Note that ext is no longer used.
	/// </summary>
	public override int Allocate(long sz, long ext)
	{
		return vtkStringArray_Allocate_01(GetCppThis(), sz, ext);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_ClearLookup_02(HandleRef pThis);

	/// <summary>
	/// Delete the associated fast lookup data structure on this array,
	/// if it exists.  The lookup will be rebuilt on the next call to a lookup
	/// function.
	/// </summary>
	public override void ClearLookup()
	{
		vtkStringArray_ClearLookup_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_DataChanged_03(HandleRef pThis);

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
		vtkStringArray_DataChanged_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_DataElementChanged_04(HandleRef pThis, long id);

	/// <summary>
	/// Tell the array explicitly that a single data element has
	/// changed. Like DataChanged(), then is only necessary when you
	/// modify the array contents without using the array's API.
	/// </summary>
	public virtual void DataElementChanged(long id)
	{
		vtkStringArray_DataElementChanged_04(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_DeepCopy_05(HandleRef pThis, HandleRef aa);

	/// <summary>
	/// Deep copy of another string array.  Will complain and change nothing
	/// if the array passed in is not a vtkStringArray.
	/// </summary>
	public override void DeepCopy(vtkAbstractArray aa)
	{
		vtkStringArray_DeepCopy_05(GetCppThis(), aa?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStringArray_ExtendedNew_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static vtkStringArray ExtendedNew()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStringArray_ExtendedNew_06(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkStringArray_GetActualMemorySize_07(HandleRef pThis);

	/// <summary>
	/// Return the memory in kibibytes (1024 bytes) consumed by this data array. Used to
	/// support streaming and reading/writing data. The value returned is
	/// guaranteed to be greater than or equal to the memory required to
	/// actually represent the data represented by this object. The
	/// information returned is valid only after the pipeline has
	/// been updated.
	///
	/// This function takes into account the size of the contents of the
	/// strings as well as the string containers themselves.
	/// </summary>
	public override uint GetActualMemorySize()
	{
		return vtkStringArray_GetActualMemorySize_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStringArray_GetDataSize_08(HandleRef pThis);

	/// <summary>
	/// Returns the size of the data in DataTypeSize units. Thus, the number of bytes
	/// for the data can be computed by GetDataSize() * GetDataTypeSize().
	/// The size computation includes the string termination character for each string.
	/// </summary>
	public override long GetDataSize()
	{
		return vtkStringArray_GetDataSize_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStringArray_GetDataType_09(HandleRef pThis);

	/// <summary>
	/// Get the data type.
	/// </summary>
	public override int GetDataType()
	{
		return vtkStringArray_GetDataType_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStringArray_GetDataTypeSize_10(HandleRef pThis);

	/// <summary>
	/// Return the size of the data type.  WARNING: This may not mean
	/// what you expect with strings.  It will return
	/// sizeof(std::string) and not take into account the data
	/// included in any particular string.
	/// </summary>
	public override int GetDataTypeSize()
	{
		return vtkStringArray_GetDataTypeSize_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStringArray_GetElementComponentSize_11(HandleRef pThis);

	/// <summary>
	/// Return the number of values in the array.
	/// </summary>
	public override int GetElementComponentSize()
	{
		return vtkStringArray_GetElementComponentSize_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStringArray_GetNumberOfElementComponents_12(HandleRef pThis);

	/// <summary>
	/// Return the number of values in the array.
	/// </summary>
	public int GetNumberOfElementComponents()
	{
		return vtkStringArray_GetNumberOfElementComponents_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStringArray_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStringArray_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStringArray_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStringArray_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStringArray_GetNumberOfValues_15(HandleRef pThis);

	/// <summary>
	/// Return the number of values in the array.
	/// </summary>
	public new long GetNumberOfValues()
	{
		return vtkStringArray_GetNumberOfValues_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStringArray_GetPointer_16(HandleRef pThis, long id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the address of a particular data index. Performs no checks
	/// to verify that the memory has been allocated etc.
	/// </summary>
	public string GetPointer(long id)
	{
		string result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStringArray_GetPointer_16(GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (string)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: false, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_GetTuples_17(HandleRef pThis, HandleRef ptIds, HandleRef output);

	/// <summary>
	/// Given a list of indices, return an array of values.  You must
	/// ensure that the output array has been previously allocated with
	/// enough space to hold the data and that the types match
	/// sufficiently to allow conversion (if necessary).
	/// </summary>
	public override void GetTuples(vtkIdList ptIds, vtkAbstractArray output)
	{
		vtkStringArray_GetTuples_17(GetCppThis(), ptIds?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_GetTuples_18(HandleRef pThis, long p1, long p2, HandleRef output);

	/// <summary>
	/// Get the values for the range of indices specified (i.e.,
	/// p1-&gt;p2 inclusive). You must ensure that the output array has been
	/// previously allocated with enough space to hold the data and that
	/// the type of the output array is compatible with the type of this
	/// array.
	/// </summary>
	public override void GetTuples(long p1, long p2, vtkAbstractArray output)
	{
		vtkStringArray_GetTuples_18(GetCppThis(), p1, p2, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkStringArray_GetValue_19(HandleRef pThis, long id);

	/// <summary>
	/// Read-access of string at a particular index.
	/// </summary>
	public string GetValue(long id)
	{
		return vtkStringArray_GetValue_19(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStringArray_GetVoidPointer_20(HandleRef pThis, long id);

	/// <summary>
	/// Get the address of a particular data index. Performs no checks
	/// to verify that the memory has been allocated etc.
	/// </summary>
	public override IntPtr GetVoidPointer(long id)
	{
		return vtkStringArray_GetVoidPointer_20(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_Initialize_21(HandleRef pThis);

	/// <summary>
	/// Release storage and reset array to initial state.
	/// </summary>
	public override void Initialize()
	{
		vtkStringArray_Initialize_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStringArray_InsertNextTuple_22(HandleRef pThis, long j, HandleRef source);

	/// <summary>
	/// Insert the jth tuple in the source array, at the end in this array.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// Returns the location at which the data was inserted.
	/// </summary>
	public override long InsertNextTuple(long j, vtkAbstractArray source)
	{
		return vtkStringArray_InsertNextTuple_22(GetCppThis(), j, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStringArray_InsertNextValue_23(HandleRef pThis, string f);

	/// <summary>
	/// Insert data at the end of the array. Return its location in the array.
	/// </summary>
	public long InsertNextValue(string f)
	{
		return vtkStringArray_InsertNextValue_23(GetCppThis(), f);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_InsertTuple_24(HandleRef pThis, long i, long j, HandleRef source);

	/// <summary>
	/// Insert the jth tuple in the source array, at ith location in this array.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public override void InsertTuple(long i, long j, vtkAbstractArray source)
	{
		vtkStringArray_InsertTuple_24(GetCppThis(), i, j, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_InsertTuples_25(HandleRef pThis, HandleRef dstIds, HandleRef srcIds, HandleRef source);

	/// <summary>
	/// Copy the tuples indexed in srcIds from the source array to the tuple
	/// locations indexed by dstIds in this array.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public override void InsertTuples(vtkIdList dstIds, vtkIdList srcIds, vtkAbstractArray source)
	{
		vtkStringArray_InsertTuples_25(GetCppThis(), dstIds?.GetCppThis() ?? default(HandleRef), srcIds?.GetCppThis() ?? default(HandleRef), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_InsertTuples_26(HandleRef pThis, long dstStart, long n, long srcStart, HandleRef source);

	/// <summary>
	/// Copy n consecutive tuples starting at srcStart from the source array to
	/// this array, starting at the dstStart location.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public override void InsertTuples(long dstStart, long n, long srcStart, vtkAbstractArray source)
	{
		vtkStringArray_InsertTuples_26(GetCppThis(), dstStart, n, srcStart, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_InsertTuplesStartingAt_27(HandleRef pThis, long dstStart, HandleRef srcIds, HandleRef source);

	/// <summary>
	/// Copy the tuples indexed in srcIds from the source array to the tuple
	/// locations indexed by dstIds in this array.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public override void InsertTuplesStartingAt(long dstStart, vtkIdList srcIds, vtkAbstractArray source)
	{
		vtkStringArray_InsertTuplesStartingAt_27(GetCppThis(), dstStart, srcIds?.GetCppThis() ?? default(HandleRef), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_InsertValue_28(HandleRef pThis, long id, string f);

	/// <summary>
	/// Insert data at a specified position in the array.
	/// </summary>
	public void InsertValue(long id, string f)
	{
		vtkStringArray_InsertValue_28(GetCppThis(), id, f);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_InsertVariantValue_29(HandleRef pThis, long idx, HandleRef value);

	/// <summary>
	/// Safely set a value in the array form a variant.
	/// Safely insert a value into the array from a variant.
	/// </summary>
	public override void InsertVariantValue(long idx, vtkVariant value)
	{
		vtkStringArray_InsertVariantValue_29(GetCppThis(), idx, value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_InterpolateTuple_30(HandleRef pThis, long i, HandleRef ptIndices, HandleRef source, IntPtr weights);

	/// <summary>
	/// Set the ith tuple in this array as the interpolated tuple value,
	/// given the ptIndices in the source array and associated
	/// interpolation weights.
	/// This method assumes that the two arrays are of the same type
	/// and structure.
	/// </summary>
	public override void InterpolateTuple(long i, vtkIdList ptIndices, vtkAbstractArray source, IntPtr weights)
	{
		vtkStringArray_InterpolateTuple_30(GetCppThis(), i, ptIndices?.GetCppThis() ?? default(HandleRef), source?.GetCppThis() ?? default(HandleRef), weights);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_InterpolateTuple_31(HandleRef pThis, long i, long id1, HandleRef source1, long id2, HandleRef source2, double t);

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
		vtkStringArray_InterpolateTuple_31(GetCppThis(), i, id1, source1?.GetCppThis() ?? default(HandleRef), id2, source2?.GetCppThis() ?? default(HandleRef), t);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStringArray_IsA_32(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStringArray_IsA_32(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStringArray_IsNumeric_33(HandleRef pThis);

	/// <summary>
	/// Get the data type.
	/// </summary>
	public override int IsNumeric()
	{
		return vtkStringArray_IsNumeric_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStringArray_IsTypeOf_34(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStringArray_IsTypeOf_34(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStringArray_LookupValue_35(HandleRef pThis, HandleRef value);

	/// <summary>
	/// Return the indices where a specific value appears.
	/// </summary>
	public override long LookupValue(vtkVariant value)
	{
		return vtkStringArray_LookupValue_35(GetCppThis(), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_LookupValue_36(HandleRef pThis, HandleRef value, HandleRef ids);

	/// <summary>
	/// Return the indices where a specific value appears.
	/// </summary>
	public override void LookupValue(vtkVariant value, vtkIdList ids)
	{
		vtkStringArray_LookupValue_36(GetCppThis(), value?.GetCppThis() ?? default(HandleRef), ids?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStringArray_LookupValue_37(HandleRef pThis, string value);

	/// <summary>
	/// Return the indices where a specific value appears.
	/// </summary>
	public long LookupValue(string value)
	{
		return vtkStringArray_LookupValue_37(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_LookupValue_38(HandleRef pThis, string value, HandleRef ids);

	/// <summary>
	/// Return the indices where a specific value appears.
	/// </summary>
	public void LookupValue(string value, vtkIdList ids)
	{
		vtkStringArray_LookupValue_38(GetCppThis(), value, ids?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStringArray_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkStringArray NewInstance()
	{
		vtkStringArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStringArray_NewInstance_40(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStringArray_NewIterator_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns a vtkArrayIteratorTemplate&lt;vtkStdString&gt;.
	/// </summary>
	public override vtkArrayIterator NewIterator()
	{
		vtkArrayIterator vtkArrayIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStringArray_NewIterator_41(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkStringArray_Resize_42(HandleRef pThis, long numTuples);

	/// <summary>
	/// Resize the array while conserving the data.
	/// </summary>
	public override int Resize(long numTuples)
	{
		return vtkStringArray_Resize_42(GetCppThis(), numTuples);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStringArray_SafeDownCast_43(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStringArray SafeDownCast(vtkObjectBase o)
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStringArray_SafeDownCast_43(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_SetArray_44(HandleRef pThis, string array, long size, int save, int deleteMethod);

	/// <summary>
	/// This method lets the user specify data to be held by the array.  The
	/// array argument is a pointer to the data.  size is the size of
	/// the array supplied by the user.  Set save to 1 to keep the class
	/// from deleting the array when it cleans up or reallocates memory.
	/// The class uses the actual array provided; it does not copy the data
	/// from the supplied array. If save is 0, then this class is free to delete
	/// the array when it cleans up or reallocates using the provided free function
	/// If the delete method is VTK_DATA_ARRAY_USER_DEFINED
	/// a custom free function can be assigned to be called using SetArrayFreeFunction,
	/// if no custom function is assigned we will default to delete[].
	/// </summary>
	public void SetArray(string array, long size, int save, int deleteMethod)
	{
		vtkStringArray_SetArray_44(GetCppThis(), array, size, save, deleteMethod);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_SetNumberOfTuples_45(HandleRef pThis, long number);

	/// <summary>
	/// Set the number of tuples (a component group) in the array. Note that
	/// this may allocate space depending on the number of components.
	/// </summary>
	public override void SetNumberOfTuples(long number)
	{
		vtkStringArray_SetNumberOfTuples_45(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_SetTuple_46(HandleRef pThis, long i, long j, HandleRef source);

	/// <summary>
	/// Set the tuple at the ith location using the jth tuple in the source array.
	/// This method assumes that the two arrays have the same type
	/// and structure. Note that range checking and memory allocation is not
	/// performed; use in conjunction with SetNumberOfTuples() to allocate space.
	/// </summary>
	public override void SetTuple(long i, long j, vtkAbstractArray source)
	{
		vtkStringArray_SetTuple_46(GetCppThis(), i, j, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_SetValue_47(HandleRef pThis, long id, string value);

	/// <summary>
	/// Set the data at a particular index. Does not do range checking. Make sure
	/// you use the method SetNumberOfValues() before inserting data.
	/// </summary>
	public void SetValue(long id, string value)
	{
		vtkStringArray_SetValue_47(GetCppThis(), id, value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_SetVariantValue_48(HandleRef pThis, long idx, HandleRef value);

	/// <summary>
	/// Set a value in the array form a variant.
	/// Insert a value into the array from a variant.
	/// </summary>
	public override void SetVariantValue(long idx, vtkVariant value)
	{
		vtkStringArray_SetVariantValue_48(GetCppThis(), idx, value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_SetVoidArray_49(HandleRef pThis, IntPtr array, long size, int save);

	/// <summary>
	/// This method lets the user specify data to be held by the array.  The
	/// array argument is a pointer to the data.  size is the size of
	/// the array supplied by the user.  Set save to 1 to keep the class
	/// from deleting the array when it cleans up or reallocates memory.
	/// The class uses the actual array provided; it does not copy the data
	/// from the supplied array. If save is 0, then this class is free to delete
	/// the array when it cleans up or reallocates using the provided free function
	/// If the delete method is VTK_DATA_ARRAY_USER_DEFINED
	/// a custom free function can be assigned to be called using SetArrayFreeFunction,
	/// if no custom function is assigned we will default to delete[].
	/// </summary>
	public override void SetVoidArray(IntPtr array, long size, int save)
	{
		vtkStringArray_SetVoidArray_49(GetCppThis(), array, size, save);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_SetVoidArray_50(HandleRef pThis, IntPtr array, long size, int save, int deleteMethod);

	/// <summary>
	/// This method lets the user specify data to be held by the array.  The
	/// array argument is a pointer to the data.  size is the size of
	/// the array supplied by the user.  Set save to 1 to keep the class
	/// from deleting the array when it cleans up or reallocates memory.
	/// The class uses the actual array provided; it does not copy the data
	/// from the supplied array. If save is 0, then this class is free to delete
	/// the array when it cleans up or reallocates using the provided free function
	/// If the delete method is VTK_DATA_ARRAY_USER_DEFINED
	/// a custom free function can be assigned to be called using SetArrayFreeFunction,
	/// if no custom function is assigned we will default to delete[].
	/// </summary>
	public override void SetVoidArray(IntPtr array, long size, int save, int deleteMethod)
	{
		vtkStringArray_SetVoidArray_50(GetCppThis(), array, size, save, deleteMethod);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringArray_Squeeze_51(HandleRef pThis);

	/// <summary>
	/// Free any unnecessary memory.
	/// Resize object to just fit data requirement. Reclaims extra memory.
	/// </summary>
	public override void Squeeze()
	{
		vtkStringArray_Squeeze_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStringArray_WritePointer_52(HandleRef pThis, long id, long number, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the address of a particular data index. Make sure data is allocated
	/// for the number of items requested. Set MaxId according to the number of
	/// data values requested.
	/// </summary>
	public string WritePointer(long id, long number)
	{
		string result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStringArray_WritePointer_52(GetCppThis(), id, number, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (string)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: false, out var _);
		}
		return result;
	}
}
