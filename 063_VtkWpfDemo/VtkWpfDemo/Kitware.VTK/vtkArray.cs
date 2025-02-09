using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkArray
/// </summary>
/// <remarks>
///    Abstract interface for N-dimensional arrays.
///
///
/// vtkArray is the root of a hierarchy of arrays that can be used to
/// store data with any number of dimensions.  It provides an abstract
/// interface for retrieving and setting array attributes that are
/// independent of the type of values stored in the array - such as the
/// number of dimensions, extents along each dimension, and number of
/// values stored in the array.
///
/// To get and set array values, the vtkTypedArray template class derives
/// from vtkArray and provides type-specific methods for retrieval and
/// update.
///
/// Two concrete derivatives of vtkTypedArray are provided at the moment:
/// vtkDenseArray and vtkSparseArray, which provide dense and sparse
/// storage for arbitrary-dimension data, respectively.  Toolkit users
/// can create their own concrete derivatives that implement alternative
/// storage strategies, such as compressed-sparse-row, etc.  You could
/// also create an array that provided read-only access to 'virtual' data,
/// such as an array that returned a Fibonacci sequence, etc.
///
/// </remarks>
/// <seealso>
///
/// vtkTypedArray, vtkDenseArray, vtkSparseArray
///
/// @par Thanks:
/// Developed by Timothy M. Shead (tsheadndia.gov) at  Sandia National
/// Laboratories.
/// </seealso>
public abstract class vtkArray : vtkObject
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum DENSE_WrapperEnum
	{
		/// <summary>enum member</summary>
		DENSE,
		/// <summary>enum member</summary>
		SPARSE
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkArray";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkArray()
	{
		MRClassNameKey = "class vtkArray";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkArray"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern IntPtr vtkArray_CreateArray_01(int StorageType, int ValueType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a new array where StorageType is one of vtkArray::DENSE
	/// or vtkArray::SPARSE, and ValueType is one of VTK_CHAR,
	/// VTK_UNSIGNED_CHAR, VTK_SHORT, VTK_UNSIGNED_SHORT,  VTK_INT,
	/// VTK_UNSIGNED_INT, VTK_LONG, VTK_UNSIGNED_LONG, VTK_DOUBLE,
	/// VTK_ID_TYPE, or VTK_STRING.  The caller is responsible for the
	/// lifetime of the returned object.
	/// </summary>
	public static vtkArray CreateArray(int StorageType, int ValueType)
	{
		vtkArray vtkArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArray_CreateArray_01(StorageType, ValueType, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkArray2 = (vtkArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkArray2.Register(null);
			}
		}
		return vtkArray2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArray_DeepCopy_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns a new array that is a deep copy of this array.
	/// </summary>
	public virtual vtkArray DeepCopy()
	{
		vtkArray vtkArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArray_DeepCopy_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkArray2 = (vtkArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkArray2.Register(null);
			}
		}
		return vtkArray2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkArray_GetDimensionLabel_03(HandleRef pThis, long i);

	/// <summary>
	/// Returns the label for the i-th array dimension.
	/// </summary>
	public string GetDimensionLabel(long i)
	{
		return vtkArray_GetDimensionLabel_03(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkArray_GetDimensions_04(HandleRef pThis);

	/// <summary>
	/// Returns the number of dimensions stored in the array.  Note that
	/// this is the same as calling GetExtents().GetDimensions().
	/// </summary>
	public long GetDimensions()
	{
		return vtkArray_GetDimensions_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkArray_GetName_05(HandleRef pThis);

	/// <summary>
	/// Returns the array name.
	/// </summary>
	public string GetName()
	{
		return vtkArray_GetName_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkArray_GetNonNullSize_06(HandleRef pThis);

	/// <summary>
	/// Returns the number of non-null values stored in the array.  Note
	/// that this value will equal GetSize() for dense arrays, and will be
	/// less-than-or-equal to GetSize() for sparse arrays.
	/// </summary>
	public virtual ulong GetNonNullSize()
	{
		return vtkArray_GetNonNullSize_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkArray_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkArray_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkArray_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkArray_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkArray_GetSize_09(HandleRef pThis);

	/// <summary>
	/// Returns the number of values stored in the array.  Note that this is
	/// the same as calling GetExtents().GetSize(), and represents the
	/// maximum number of values that could ever be stored using the current
	/// extents.  This is equal to the number of values stored in a dense
	/// array, but may be larger than the number of values stored in a
	/// sparse array.
	/// </summary>
	public ulong GetSize()
	{
		return vtkArray_GetSize_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArray_GetVariantValue_10(HandleRef pThis, long i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the value stored in the array at the given coordinates.
	/// Note that the number of dimensions in the supplied coordinates must
	/// match the number of dimensions in the array.
	/// </summary>
	public vtkVariant GetVariantValue(long i)
	{
		vtkVariant result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArray_GetVariantValue_10(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArray_GetVariantValue_11(HandleRef pThis, long i, long j, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the value stored in the array at the given coordinates.
	/// Note that the number of dimensions in the supplied coordinates must
	/// match the number of dimensions in the array.
	/// </summary>
	public vtkVariant GetVariantValue(long i, long j)
	{
		vtkVariant result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArray_GetVariantValue_11(GetCppThis(), i, j, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArray_GetVariantValue_12(HandleRef pThis, long i, long j, long k, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the value stored in the array at the given coordinates.
	/// Note that the number of dimensions in the supplied coordinates must
	/// match the number of dimensions in the array.
	/// </summary>
	public vtkVariant GetVariantValue(long i, long j, long k)
	{
		vtkVariant result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArray_GetVariantValue_12(GetCppThis(), i, j, k, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArray_GetVariantValueN_13(HandleRef pThis, ulong n, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the n-th value stored in the array, where n is in the
	/// range [0, GetNonNullSize()).  This is useful for efficiently
	/// visiting every value in the array.  Note that the order in which
	/// values are visited is undefined, but is guaranteed to match the
	/// order used by vtkArray::GetCoordinatesN().
	/// </summary>
	public virtual vtkVariant GetVariantValueN(ulong n)
	{
		vtkVariant result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArray_GetVariantValueN_13(GetCppThis(), n, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArray_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkArray_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkArray_IsDense_15(HandleRef pThis);

	/// <summary>
	/// Returns true iff the underlying array storage is "dense", i.e. that
	/// GetSize() and GetNonNullSize() will always return the same value.
	/// If not, the array is "sparse".
	/// </summary>
	public virtual bool IsDense()
	{
		return (vtkArray_IsDense_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArray_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkArray_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArray_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkArray NewInstance()
	{
		vtkArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArray_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArray_Resize_18(HandleRef pThis, long i);

	/// <summary>
	/// Resizes the array to the given extents (number of dimensions and
	/// size of each dimension).  Note that concrete implementations of
	/// vtkArray may place constraints on the extents that they will
	/// store, so you cannot assume that GetExtents() will always return
	/// the same value passed to Resize().
	///
	/// The contents of the array are undefined after calling Resize() - you
	/// should initialize its contents accordingly.  In particular,
	/// dimension-labels will be undefined, dense array values will be
	/// undefined, and sparse arrays will be empty.
	/// </summary>
	public void Resize(long i)
	{
		vtkArray_Resize_18(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArray_Resize_19(HandleRef pThis, long i, long j);

	/// <summary>
	/// Resizes the array to the given extents (number of dimensions and
	/// size of each dimension).  Note that concrete implementations of
	/// vtkArray may place constraints on the extents that they will
	/// store, so you cannot assume that GetExtents() will always return
	/// the same value passed to Resize().
	///
	/// The contents of the array are undefined after calling Resize() - you
	/// should initialize its contents accordingly.  In particular,
	/// dimension-labels will be undefined, dense array values will be
	/// undefined, and sparse arrays will be empty.
	/// </summary>
	public void Resize(long i, long j)
	{
		vtkArray_Resize_19(GetCppThis(), i, j);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArray_Resize_20(HandleRef pThis, long i, long j, long k);

	/// <summary>
	/// Resizes the array to the given extents (number of dimensions and
	/// size of each dimension).  Note that concrete implementations of
	/// vtkArray may place constraints on the extents that they will
	/// store, so you cannot assume that GetExtents() will always return
	/// the same value passed to Resize().
	///
	/// The contents of the array are undefined after calling Resize() - you
	/// should initialize its contents accordingly.  In particular,
	/// dimension-labels will be undefined, dense array values will be
	/// undefined, and sparse arrays will be empty.
	/// </summary>
	public void Resize(long i, long j, long k)
	{
		vtkArray_Resize_20(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArray_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkArray SafeDownCast(vtkObjectBase o)
	{
		vtkArray vtkArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArray_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkArray2 = (vtkArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkArray2.Register(null);
			}
		}
		return vtkArray2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArray_SetDimensionLabel_22(HandleRef pThis, long i, string label);

	/// <summary>
	/// Sets the label for the i-th array dimension.
	/// </summary>
	public void SetDimensionLabel(long i, string label)
	{
		vtkArray_SetDimensionLabel_22(GetCppThis(), i, label);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArray_SetName_23(HandleRef pThis, string name);

	/// <summary>
	/// Sets the array name.
	/// </summary>
	public void SetName(string name)
	{
		vtkArray_SetName_23(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArray_SetVariantValue_24(HandleRef pThis, long i, HandleRef value);

	/// <summary>
	/// Overwrites the value stored in the array at the given coordinates.
	/// Note that the number of dimensions in the supplied coordinates must
	/// match the number of dimensions in the array.
	/// </summary>
	public void SetVariantValue(long i, vtkVariant value)
	{
		vtkArray_SetVariantValue_24(GetCppThis(), i, value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArray_SetVariantValue_25(HandleRef pThis, long i, long j, HandleRef value);

	/// <summary>
	/// Overwrites the value stored in the array at the given coordinates.
	/// Note that the number of dimensions in the supplied coordinates must
	/// match the number of dimensions in the array.
	/// </summary>
	public void SetVariantValue(long i, long j, vtkVariant value)
	{
		vtkArray_SetVariantValue_25(GetCppThis(), i, j, value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArray_SetVariantValue_26(HandleRef pThis, long i, long j, long k, HandleRef value);

	/// <summary>
	/// Overwrites the value stored in the array at the given coordinates.
	/// Note that the number of dimensions in the supplied coordinates must
	/// match the number of dimensions in the array.
	/// </summary>
	public void SetVariantValue(long i, long j, long k, vtkVariant value)
	{
		vtkArray_SetVariantValue_26(GetCppThis(), i, j, k, value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArray_SetVariantValueN_27(HandleRef pThis, ulong n, HandleRef value);

	/// <summary>
	/// Overwrites the n-th value stored in the array, where n is in the
	/// range [0, GetNonNullSize()).  This is useful for efficiently
	/// visiting every value in the array.  Note that the order in which
	/// values are visited is undefined, but is guaranteed to match the
	/// order used by vtkArray::GetCoordinatesN().
	/// </summary>
	public virtual void SetVariantValueN(ulong n, vtkVariant value)
	{
		vtkArray_SetVariantValueN_27(GetCppThis(), n, value?.GetCppThis() ?? default(HandleRef));
	}
}
