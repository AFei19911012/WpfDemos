using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAbstractArray
/// </summary>
/// <remarks>
///    Abstract superclass for all arrays
///
///
///
/// vtkAbstractArray is an abstract superclass for data array objects.
/// This class defines an API that all subclasses must support.  The
/// data type must be assignable and copy-constructible, but no other
/// assumptions about its type are made.  Most of the subclasses of
/// this array deal with numeric data either as scalars or tuples of
/// scalars.  A program can use the IsNumeric() method to check whether
/// an instance of vtkAbstractArray contains numbers.  It is also
/// possible to test for this by attempting to SafeDownCast an array to
/// an instance of vtkDataArray, although this assumes that all numeric
/// arrays will always be descended from vtkDataArray.
///
/// &lt;p&gt;
///
/// Every array has a character-string name. The naming of the array
/// occurs automatically when it is instantiated, but you are free to
/// change this name using the SetName() method.  (The array name is
/// used for data manipulation.)
///
/// This class (and subclasses) use two forms of addressing elements:
/// - Value Indexing: The index of an element assuming an array-of-structs
///   memory layout.
/// - Tuple/Component Indexing: Explicitly specify the tuple and component
///   indices.
///
/// It is also worth pointing out that the behavior of the "Insert*" methods
/// of classes in this hierarchy may not behave as expected. They work exactly
/// as the corresponding "Set*" methods, except that memory allocation will
/// be performed if acting on a value past the end of the array. If the data
/// already exists, "inserting" will overwrite existing values, rather than shift
/// the array contents and insert the new data at the specified location.
///
/// If code is modifying contents of an existing array, it is
/// required that one calls `vtkAbstractArray::Modified()` explicitly
/// after the modifications to the contents are completed.
/// APIs like `SetTuple` etc. don't call `Modified` to avoid performance hits.
/// Unless `Modified` is called, various cached entities, like array range,
/// map created for `LookupValue` may become obsolete and yield incorrect results.
///
/// </remarks>
/// <seealso>
///
/// vtkDataArray vtkStringArray vtkCellArray
/// </seealso>
public abstract class vtkAbstractArray : vtkObject
{
	/// <summary>
	/// A key used to hold conditions under which cached discrete values were generated;
	/// the value is a 2-vector of doubles.
	/// The first entry corresponds to the maximum uncertainty that prominent values
	/// exist but have not been detected. The second entry corresponds to the smallest
	/// relative frequency a value is allowed to have and still appear on the list.
	/// </summary>
	public enum MAX_DISCRETE_VALUES_WrapperEnum
	{
		/// <summary>enum member</summary>
		MAX_DISCRETE_VALUES = 0x20
	}

	/// <summary>
	/// Get/Set the maximum number of prominent values this array may contain
	/// before it is considered continuous.  Default value is 32.
	/// </summary>
	public enum AbstractArray_WrapperEnum
	{
		/// <summary>enum member</summary>
		AbstractArray = 0,
		/// <summary>enum member</summary>
		AoSDataArrayTemplate = 2,
		/// <summary>enum member</summary>
		DataArray = 1,
		/// <summary>enum member</summary>
		DataArrayTemplate = 2,
		/// <summary>enum member</summary>
		MappedDataArray = 5,
		/// <summary>enum member</summary>
		ScaleSoADataArrayTemplate = 6,
		/// <summary>enum member</summary>
		SoADataArrayTemplate = 3,
		/// <summary>enum member</summary>
		TypedDataArray = 4
	}

	/// <summary>
	/// What is the maximum id currently in the array.
	/// </summary>
	public enum DeleteMethod
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
	public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractArray";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAbstractArray()
	{
		MRClassNameKey = "class vtkAbstractArray";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractArray"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAbstractArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern int vtkAbstractArray_Allocate_01(HandleRef pThis, long numValues, long ext);

	/// <summary>
	/// Allocate memory for this array. Delete old storage only if necessary.
	/// Note that ext is no longer used.
	/// This method will reset MaxId to -1 and resize the array capacity such that
	/// this-&gt;Size &gt;= numValues.
	/// If numValues is 0, all memory will be freed.
	/// Return 1 on success, 0 on failure.
	/// </summary>
	public virtual int Allocate(long numValues, long ext)
	{
		return vtkAbstractArray_Allocate_01(GetCppThis(), numValues, ext);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_ClearLookup_02(HandleRef pThis);

	/// <summary>
	/// Delete the associated fast lookup data structure on this array,
	/// if it exists.  The lookup will be rebuilt on the next call to a lookup
	/// function.
	/// </summary>
	public virtual void ClearLookup()
	{
		vtkAbstractArray_ClearLookup_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractArray_CopyComponentNames_03(HandleRef pThis, HandleRef da);

	/// <summary>
	/// Copies the component names from the inputted array to the current array
	/// make sure that the current array has the same number of components as the input array
	/// </summary>
	public int CopyComponentNames(vtkAbstractArray da)
	{
		return vtkAbstractArray_CopyComponentNames_03(GetCppThis(), da?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractArray_CopyInformation_04(HandleRef pThis, HandleRef infoFrom, int deep);

	/// <summary>
	/// Copy information instance. Arrays use information objects
	/// in a variety of ways. It is important to have flexibility in
	/// this regard because certain keys should not be copied, while
	/// others must be.
	///
	/// NOTE: Subclasses must always call their superclass's CopyInformation
	/// method, so that all classes in the hierarchy get a chance to remove
	/// keys they do not wish to be copied. The subclass will not need to
	/// explicitly copy the keys as it's handled here.
	/// </summary>
	public virtual int CopyInformation(vtkInformation infoFrom, int deep)
	{
		return vtkAbstractArray_CopyInformation_04(GetCppThis(), infoFrom?.GetCppThis() ?? default(HandleRef), deep);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractArray_CreateArray_05(int dataType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates an array for dataType where dataType is one of
	/// VTK_BIT, VTK_CHAR, VTK_UNSIGNED_CHAR, VTK_SHORT,
	/// VTK_UNSIGNED_SHORT, VTK_INT, VTK_UNSIGNED_INT, VTK_LONG,
	/// VTK_UNSIGNED_LONG, VTK_FLOAT, VTK_DOUBLE, VTK_ID_TYPE,
	/// VTK_STRING.
	/// Note that the data array returned has to be deleted by the
	/// user.
	/// </summary>
	public static vtkAbstractArray CreateArray(int dataType)
	{
		vtkAbstractArray vtkAbstractArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractArray_CreateArray_05(dataType, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractArray2 = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractArray2.Register(null);
			}
		}
		return vtkAbstractArray2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractArray_DISCRETE_VALUES_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// A key used to hold discrete values taken on either by the tuples of the
	/// array (when present in this-&gt;GetInformation()) or individual components
	/// (when present in one entry of the PER_COMPONENT() information vector).
	/// </summary>
	public static vtkInformationVariantVectorKey DISCRETE_VALUES()
	{
		vtkInformationVariantVectorKey vtkInformationVariantVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractArray_DISCRETE_VALUES_06(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationVariantVectorKey2 = (vtkInformationVariantVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationVariantVectorKey2.Register(null);
			}
		}
		return vtkInformationVariantVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractArray_DISCRETE_VALUE_SAMPLE_PARAMETERS_07(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// A key used to hold conditions under which cached discrete values were generated;
	/// the value is a 2-vector of doubles.
	/// The first entry corresponds to the maximum uncertainty that prominent values
	/// exist but have not been detected. The second entry corresponds to the smallest
	/// relative frequency a value is allowed to have and still appear on the list.
	/// </summary>
	public static vtkInformationDoubleVectorKey DISCRETE_VALUE_SAMPLE_PARAMETERS()
	{
		vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractArray_DISCRETE_VALUE_SAMPLE_PARAMETERS_07(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationDoubleVectorKey2 = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationDoubleVectorKey2.Register(null);
			}
		}
		return vtkInformationDoubleVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_DataChanged_08(HandleRef pThis);

	/// <summary>
	/// Tell the array explicitly that the data has changed.
	/// This is only necessary to call when you modify the array contents
	/// without using the array's API (i.e. you retrieve a pointer to the
	/// data and modify the array contents).  You need to call this so that
	/// the fast lookup will know to rebuild itself.  Otherwise, the lookup
	/// functions will give incorrect results.
	/// </summary>
	public virtual void DataChanged()
	{
		vtkAbstractArray_DataChanged_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_DeepCopy_09(HandleRef pThis, HandleRef da);

	/// <summary>
	/// Deep copy of data. Implementation left to subclasses, which
	/// should support as many type conversions as possible given the
	/// data type.
	///
	/// Subclasses should call vtkAbstractArray::DeepCopy() so that the
	/// information object (if one exists) is copied from \a da.
	/// </summary>
	public virtual void DeepCopy(vtkAbstractArray da)
	{
		vtkAbstractArray_DeepCopy_09(GetCppThis(), da?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_ExportToVoidPointer_10(HandleRef pThis, IntPtr out_ptr);

	/// <summary>
	/// This method copies the array data to the void pointer specified
	/// by the user.  It is up to the user to allocate enough memory for
	/// the void pointer.
	/// </summary>
	public virtual void ExportToVoidPointer(IntPtr out_ptr)
	{
		vtkAbstractArray_ExportToVoidPointer_10(GetCppThis(), out_ptr);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractArray_GUI_HIDE_11(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This key is a hint to end user interface that this array
	/// is internal and should not be shown to the end user.
	/// </summary>
	public static vtkInformationIntegerKey GUI_HIDE()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractArray_GUI_HIDE_11(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkAbstractArray_GetActualMemorySize_12(HandleRef pThis);

	/// <summary>
	/// Return the memory in kibibytes (1024 bytes) consumed by this data array. Used to
	/// support streaming and reading/writing data. The value returned is
	/// guaranteed to be greater than or equal to the memory required to
	/// actually represent the data represented by this object. The
	/// information returned is valid only after the pipeline has
	/// been updated.
	/// </summary>
	public virtual uint GetActualMemorySize()
	{
		return vtkAbstractArray_GetActualMemorySize_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractArray_GetArrayType_13(HandleRef pThis);

	/// <summary>
	/// Method for type-checking in FastDownCast implementations. See also
	/// vtkArrayDownCast.
	/// </summary>
	public virtual int GetArrayType()
	{
		return vtkAbstractArray_GetArrayType_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractArray_GetArrayTypeAsString_14(HandleRef pThis);

	/// <summary>
	/// Get the name for the array type as string
	/// </summary>
	public string GetArrayTypeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkAbstractArray_GetArrayTypeAsString_14(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractArray_GetComponentName_15(HandleRef pThis, long component);

	/// <summary>
	/// Get the component name for a given component.
	/// Note: will return the actual string that is stored
	/// </summary>
	public string GetComponentName(long component)
	{
		return Marshal.PtrToStringAnsi(vtkAbstractArray_GetComponentName_15(GetCppThis(), component));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractArray_GetDataSize_16(HandleRef pThis);

	/// <summary>
	/// Returns the size of the data in DataTypeSize units. Thus, the
	/// number of bytes for the data can be computed by GetDataSize() *
	/// GetDataTypeSize(). Non-contiguous or variable- size arrays need
	/// to override this method.
	/// </summary>
	public virtual long GetDataSize()
	{
		return vtkAbstractArray_GetDataSize_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractArray_GetDataType_17(HandleRef pThis);

	/// <summary>
	/// Return the underlying data type. An integer indicating data type is
	/// returned as specified in vtkType.h.
	/// </summary>
	public virtual int GetDataType()
	{
		return vtkAbstractArray_GetDataType_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractArray_GetDataTypeAsString_18(HandleRef pThis);

	/// <summary>
	/// Get the name of a data type as a string.
	/// </summary>
	public virtual string GetDataTypeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkAbstractArray_GetDataTypeAsString_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractArray_GetDataTypeSize_19(HandleRef pThis);

	/// <summary>
	/// Return the size of the underlying data type.  For a bit, 0 is
	/// returned.  For string 0 is returned. Arrays with variable length
	/// components return 0.
	/// </summary>
	public virtual int GetDataTypeSize()
	{
		return vtkAbstractArray_GetDataTypeSize_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractArray_GetDataTypeSize_20(int type);

	/// <summary>
	/// Return the size of the underlying data type.  For a bit, 0 is
	/// returned.  For string 0 is returned. Arrays with variable length
	/// components return 0.
	/// </summary>
	public static int GetDataTypeSize(int type)
	{
		return vtkAbstractArray_GetDataTypeSize_20(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractArray_GetElementComponentSize_21(HandleRef pThis);

	/// <summary>
	/// Return the size, in bytes, of the lowest-level element of an
	/// array.  For vtkDataArray and subclasses this is the size of the
	/// data type.  For vtkStringArray, this is
	/// sizeof(vtkStdString::value_type), which winds up being
	/// sizeof(char).
	/// </summary>
	public virtual int GetElementComponentSize()
	{
		return vtkAbstractArray_GetElementComponentSize_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractArray_GetInformation_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get an information object that can be used to annotate the array.
	/// This will always return an instance of vtkInformation, if one is
	/// not currently associated with the array it will be created.
	/// </summary>
	public vtkInformation GetInformation()
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractArray_GetInformation_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformation2 = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformation2.Register(null);
			}
		}
		return vtkInformation2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkAbstractArray_GetMaxDiscreteValues_23(HandleRef pThis);

	/// <summary>
	/// Get/Set the maximum number of prominent values this array may contain
	/// before it is considered continuous.  Default value is 32.
	/// </summary>
	public virtual uint GetMaxDiscreteValues()
	{
		return vtkAbstractArray_GetMaxDiscreteValues_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractArray_GetMaxId_24(HandleRef pThis);

	/// <summary>
	/// What is the maximum id currently in the array.
	/// </summary>
	public long GetMaxId()
	{
		return vtkAbstractArray_GetMaxId_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractArray_GetName_25(HandleRef pThis);

	/// <summary>
	/// Set/get array's name
	/// </summary>
	public virtual string GetName()
	{
		return Marshal.PtrToStringAnsi(vtkAbstractArray_GetName_25(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractArray_GetNumberOfComponents_26(HandleRef pThis);

	/// <summary>
	/// Set/Get the dimension (n) of the components. Must be &gt;= 1. Make sure that
	/// this is set before allocation.
	/// </summary>
	public int GetNumberOfComponents()
	{
		return vtkAbstractArray_GetNumberOfComponents_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractArray_GetNumberOfComponentsMaxValue_27(HandleRef pThis);

	/// <summary>
	/// Set/Get the dimension (n) of the components. Must be &gt;= 1. Make sure that
	/// this is set before allocation.
	/// </summary>
	public virtual int GetNumberOfComponentsMaxValue()
	{
		return vtkAbstractArray_GetNumberOfComponentsMaxValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractArray_GetNumberOfComponentsMinValue_28(HandleRef pThis);

	/// <summary>
	/// Set/Get the dimension (n) of the components. Must be &gt;= 1. Make sure that
	/// this is set before allocation.
	/// </summary>
	public virtual int GetNumberOfComponentsMinValue()
	{
		return vtkAbstractArray_GetNumberOfComponentsMinValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractArray_GetNumberOfGenerationsFromBase_29(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAbstractArray_GetNumberOfGenerationsFromBase_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractArray_GetNumberOfGenerationsFromBaseType_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAbstractArray_GetNumberOfGenerationsFromBaseType_30(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractArray_GetNumberOfTuples_31(HandleRef pThis);

	/// <summary>
	/// Get the number of complete tuples (a component group) in the array.
	/// </summary>
	public long GetNumberOfTuples()
	{
		return vtkAbstractArray_GetNumberOfTuples_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractArray_GetNumberOfValues_32(HandleRef pThis);

	/// <summary>
	/// Get the total number of values in the array. This is typically equivalent
	/// to (numTuples * numComponents). The exception is during incremental array
	/// construction for subclasses that support component insertion, which may
	/// result in an incomplete trailing tuple.
	/// </summary>
	public long GetNumberOfValues()
	{
		return vtkAbstractArray_GetNumberOfValues_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_GetProminentComponentValues_33(HandleRef pThis, int comp, HandleRef values, double uncertainty, double minimumProminence);

	/// <summary>
	/// Populate the given vtkVariantArray with a set of distinct values taken on
	/// by the requested component (or, when passed -1, by the tuples as a whole).
	/// If the set of prominent values has more than 32 entries, then the array
	/// is assumed to be continuous in nature and no values are returned.
	///
	/// This method takes 2 parameters: \a uncertainty and \a minimumProminence.
	/// Note that this set of returned values may not be complete if
	/// \a uncertainty and \a minimumProminence are both larger than 0.0;
	/// in order to perform interactively, a subsample of the array is
	/// used to determine the set of values.
	///
	/// The first parameter (\a uncertainty, U) is the maximum acceptable
	/// probability that a prominent value will not be detected.
	/// Setting this to 0 will cause every value in the array to be examined.
	///
	/// The second parameter (\a minimumProminence, P) specifies the smallest
	/// relative frequency (in [0,1]) with which a value in the array may
	/// occur and still be considered prominent. Setting this to 0
	/// will force every value in the array to be traversed.
	/// Using numbers close to 0 for this parameter quickly causes
	/// the number of samples required to obtain the given uncertainty to
	/// subsume the entire array, as rare occurrences require frequent
	/// sampling to detect.
	///
	/// For an array with T tuples and given uncertainty U and mininumum
	/// prominence P, we sample N values, with N = f(T; P, U).
	/// We want f to be sublinear in T in order to interactively handle large
	/// arrays; in practice, we can make f independent of T:
	/// \f$ N &gt;= \frac{5}{P}\mathrm{ln}\left(\frac{1}{PU}\right) \f$,
	/// but note that small values of P are costly to achieve.
	/// The default parameters will locate prominent values that occur at least
	/// 1 out of every 1000 samples with a confidence of 0.999999 (= 1 - 1e6).
	/// Thanks to Seshadri Comandur (Sandia National Laboratories) for the
	/// bounds on the number of samples.
	///
	/// The first time this is called, the array is examined and unique values
	/// are stored in the vtkInformation object associated with the array.
	/// The list of unique values will be updated on subsequent calls only if
	/// the array's MTime is newer than the associated vtkInformation object or
	/// if better sampling (lower \a uncertainty or \a minimumProminence) is
	/// requested.
	/// The DISCRETE_VALUE_SAMPLE_PARAMETERS() information key is used to
	/// store the numbers which produced any current set of prominent values.
	///
	/// Also, note that every value encountered is reported and counts toward
	/// the maximum of 32 distinct values, regardless of the value's frequency.
	/// This is required for an efficient implementation.
	/// Use the vtkOrderStatistics filter if you wish to threshold the set of
	/// distinct values to eliminate "unprominent" (infrequently-occurring)
	/// values.
	/// </summary>
	public virtual void GetProminentComponentValues(int comp, vtkVariantArray values, double uncertainty, double minimumProminence)
	{
		vtkAbstractArray_GetProminentComponentValues_33(GetCppThis(), comp, values?.GetCppThis() ?? default(HandleRef), uncertainty, minimumProminence);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractArray_GetSize_34(HandleRef pThis);

	/// <summary>
	/// Return the size of the data.
	/// </summary>
	public long GetSize()
	{
		return vtkAbstractArray_GetSize_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_GetTuples_35(HandleRef pThis, HandleRef tupleIds, HandleRef output);

	/// <summary>
	/// Given a list of tuple ids, return an array of tuples.
	/// You must ensure that the output array has been previously
	/// allocated with enough space to hold the data.
	/// </summary>
	public virtual void GetTuples(vtkIdList tupleIds, vtkAbstractArray output)
	{
		vtkAbstractArray_GetTuples_35(GetCppThis(), tupleIds?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_GetTuples_36(HandleRef pThis, long p1, long p2, HandleRef output);

	/// <summary>
	/// Get the tuples for the range of tuple ids specified
	/// (i.e., p1-&gt;p2 inclusive). You must ensure that the output array has
	/// been previously allocated with enough space to hold the data.
	/// </summary>
	public virtual void GetTuples(long p1, long p2, vtkAbstractArray output)
	{
		vtkAbstractArray_GetTuples_36(GetCppThis(), p1, p2, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractArray_GetVariantValue_37(HandleRef pThis, long valueIdx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve value from the array as a variant.
	/// </summary>
	public virtual vtkVariant GetVariantValue(long valueIdx)
	{
		vtkVariant result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractArray_GetVariantValue_37(GetCppThis(), valueIdx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractArray_GetVoidPointer_38(HandleRef pThis, long valueIdx);

	/// <summary>
	/// Return a void pointer. For image pipeline interface and other
	/// special pointer manipulation.
	/// Use of this method is discouraged, as newer arrays require a deep-copy of
	/// the array data in order to return a suitable pointer. See vtkArrayDispatch
	/// for a safer alternative for fast data access.
	/// </summary>
	public virtual IntPtr GetVoidPointer(long valueIdx)
	{
		return vtkAbstractArray_GetVoidPointer_38(GetCppThis(), valueIdx);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractArray_HasAComponentName_39(HandleRef pThis);

	/// <summary>
	/// Returns if any component has had a name assigned
	/// </summary>
	public bool HasAComponentName()
	{
		return (vtkAbstractArray_HasAComponentName_39(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractArray_HasInformation_40(HandleRef pThis);

	/// <summary>
	/// Inquire if this array has an instance of vtkInformation
	/// already associated with it.
	/// </summary>
	public bool HasInformation()
	{
		return (vtkAbstractArray_HasInformation_40(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractArray_HasStandardMemoryLayout_41(HandleRef pThis);

	/// <summary>
	/// Returns true if this array uses the standard memory layout defined in the
	/// VTK user guide, e.g. a contiguous array:
	/// {t1c1, t1c2, t1c3, ... t1cM, t2c1, ... tNcM}
	/// where t1c2 is the second component of the first tuple.
	/// </summary>
	public virtual bool HasStandardMemoryLayout()
	{
		return (vtkAbstractArray_HasStandardMemoryLayout_41(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_Initialize_42(HandleRef pThis);

	/// <summary>
	/// Release storage and reset array to initial state.
	/// </summary>
	public virtual void Initialize()
	{
		vtkAbstractArray_Initialize_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractArray_InsertNextTuple_43(HandleRef pThis, long srcTupleIdx, HandleRef source);

	/// <summary>
	/// Insert the tuple from srcTupleIdx in the source array at the end of this
	/// array. Note that memory allocation is performed as necessary to hold the
	/// data. Returns the tuple index at which the data was inserted.
	/// </summary>
	public virtual long InsertNextTuple(long srcTupleIdx, vtkAbstractArray source)
	{
		return vtkAbstractArray_InsertNextTuple_43(GetCppThis(), srcTupleIdx, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_InsertTuple_44(HandleRef pThis, long dstTupleIdx, long srcTupleIdx, HandleRef source);

	/// <summary>
	/// Insert the tuple at srcTupleIdx in the source array into this array at
	/// dstTupleIdx.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public virtual void InsertTuple(long dstTupleIdx, long srcTupleIdx, vtkAbstractArray source)
	{
		vtkAbstractArray_InsertTuple_44(GetCppThis(), dstTupleIdx, srcTupleIdx, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_InsertTuples_45(HandleRef pThis, HandleRef dstIds, HandleRef srcIds, HandleRef source);

	/// <summary>
	/// Copy the tuples indexed in srcIds from the source array to the tuple
	/// locations indexed by dstIds in this array.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public virtual void InsertTuples(vtkIdList dstIds, vtkIdList srcIds, vtkAbstractArray source)
	{
		vtkAbstractArray_InsertTuples_45(GetCppThis(), dstIds?.GetCppThis() ?? default(HandleRef), srcIds?.GetCppThis() ?? default(HandleRef), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_InsertTuples_46(HandleRef pThis, long dstStart, long n, long srcStart, HandleRef source);

	/// <summary>
	/// Copy n consecutive tuples starting at srcStart from the source array to
	/// this array, starting at the dstStart location.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public virtual void InsertTuples(long dstStart, long n, long srcStart, vtkAbstractArray source)
	{
		vtkAbstractArray_InsertTuples_46(GetCppThis(), dstStart, n, srcStart, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_InsertTuplesStartingAt_47(HandleRef pThis, long dstStart, HandleRef srcIds, HandleRef source);

	/// <summary>
	/// Copy the tuples indexed in srcIds from the source array to the tuple
	/// locations starting at index dstStart.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public virtual void InsertTuplesStartingAt(long dstStart, vtkIdList srcIds, vtkAbstractArray source)
	{
		vtkAbstractArray_InsertTuplesStartingAt_47(GetCppThis(), dstStart, srcIds?.GetCppThis() ?? default(HandleRef), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_InsertVariantValue_48(HandleRef pThis, long valueIdx, HandleRef value);

	/// <summary>
	/// Insert a value into the array from a variant.  This method does
	/// bounds checking.
	/// </summary>
	public virtual void InsertVariantValue(long valueIdx, vtkVariant value)
	{
		vtkAbstractArray_InsertVariantValue_48(GetCppThis(), valueIdx, value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_InterpolateTuple_49(HandleRef pThis, long dstTupleIdx, HandleRef ptIndices, HandleRef source, IntPtr weights);

	/// <summary>
	/// Set the tuple at dstTupleIdx in this array to the interpolated tuple value,
	/// given the ptIndices in the source array and associated interpolation
	/// weights.
	/// This method assumes that the two arrays are of the same type
	/// and structure.
	/// </summary>
	public virtual void InterpolateTuple(long dstTupleIdx, vtkIdList ptIndices, vtkAbstractArray source, IntPtr weights)
	{
		vtkAbstractArray_InterpolateTuple_49(GetCppThis(), dstTupleIdx, ptIndices?.GetCppThis() ?? default(HandleRef), source?.GetCppThis() ?? default(HandleRef), weights);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_InterpolateTuple_50(HandleRef pThis, long dstTupleIdx, long srcTupleIdx1, HandleRef source1, long srcTupleIdx2, HandleRef source2, double t);

	/// <summary>
	/// Insert the tuple at dstTupleIdx in this array to the tuple interpolated
	/// from the two tuple indices, srcTupleIdx1 and srcTupleIdx2, and an
	/// interpolation factor, t. The interpolation factor ranges from (0,1),
	/// with t=0 located at the tuple described by srcTupleIdx1. This method
	/// assumes that the three arrays are of the same type, srcTupleIdx1 is an
	/// index to array source1, and srcTupleIdx2 is an index to array source2.
	/// </summary>
	public virtual void InterpolateTuple(long dstTupleIdx, long srcTupleIdx1, vtkAbstractArray source1, long srcTupleIdx2, vtkAbstractArray source2, double t)
	{
		vtkAbstractArray_InterpolateTuple_50(GetCppThis(), dstTupleIdx, srcTupleIdx1, source1?.GetCppThis() ?? default(HandleRef), srcTupleIdx2, source2?.GetCppThis() ?? default(HandleRef), t);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractArray_IsA_51(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAbstractArray_IsA_51(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractArray_IsNumeric_52(HandleRef pThis);

	/// <summary>
	/// This method is here to make backward compatibility easier.  It
	/// must return true if and only if an array contains numeric data.
	/// </summary>
	public virtual int IsNumeric()
	{
		return vtkAbstractArray_IsNumeric_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractArray_IsTypeOf_53(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAbstractArray_IsTypeOf_53(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractArray_LookupValue_54(HandleRef pThis, HandleRef value);

	/// <summary>
	/// Return the value indices where a specific value appears.
	///
	/// @warning Make sure that the lookup structure is not outdated. Calls
	/// to `Modified` should be done appropriately so the array knows
	/// when to update its lookup structure.
	/// </summary>
	public virtual long LookupValue(vtkVariant value)
	{
		return vtkAbstractArray_LookupValue_54(GetCppThis(), value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_LookupValue_55(HandleRef pThis, HandleRef value, HandleRef valueIds);

	/// <summary>
	/// Return the value indices where a specific value appears.
	///
	/// @warning Make sure that the lookup structure is not outdated. Calls
	/// to `Modified` should be done appropriately so the array knows
	/// when to update its lookup structure.
	/// </summary>
	public virtual void LookupValue(vtkVariant value, vtkIdList valueIds)
	{
		vtkAbstractArray_LookupValue_55(GetCppThis(), value?.GetCppThis() ?? default(HandleRef), valueIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_Modified_56(HandleRef pThis);

	/// <summary>
	/// Removes out-of-date PER_COMPONENT() and PER_FINITE_COMPONENT() values.
	/// </summary>
	public override void Modified()
	{
		vtkAbstractArray_Modified_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractArray_NewInstance_57(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAbstractArray NewInstance()
	{
		vtkAbstractArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractArray_NewInstance_57(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractArray_NewIterator_58(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Subclasses must override this method and provide the right kind
	/// of templated vtkArrayIteratorTemplate.
	/// </summary>
	public virtual vtkArrayIterator NewIterator()
	{
		vtkArrayIterator vtkArrayIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractArray_NewIterator_58(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAbstractArray_PER_COMPONENT_59(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This key is used to hold a vector of COMPONENT_VALUES (and, for
	/// vtkDataArray subclasses, COMPONENT_RANGE) keys -- one
	/// for each component of the array.  You may add additional per-component
	/// key-value pairs to information objects in this vector. However if you
	/// do so, you must be sure to either (1) set COMPONENT_VALUES to
	/// an invalid variant and set COMPONENT_RANGE to
	/// {VTK_DOUBLE_MAX, VTK_DOUBLE_MIN} or (2) call ComputeUniqueValues(component)
	/// and ComputeRange(component) &lt;b&gt;before&lt;/b&gt; modifying the information object.
	/// Otherwise it is possible for modifications to the array to take place
	/// without the bounds on the component being updated.
	/// </summary>
	public static vtkInformationInformationVectorKey PER_COMPONENT()
	{
		vtkInformationInformationVectorKey vtkInformationInformationVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractArray_PER_COMPONENT_59(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationInformationVectorKey2 = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationInformationVectorKey2.Register(null);
			}
		}
		return vtkInformationInformationVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractArray_PER_FINITE_COMPONENT_60(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This key is used to hold a vector of COMPONENT_VALUES (and, for
	/// vtkDataArray subclasses, COMPONENT_RANGE) keys -- one
	/// for each component of the array.  You may add additional per-component
	/// key-value pairs to information objects in this vector. However if you
	/// do so, you must be sure to either (1) set COMPONENT_VALUES to
	/// an invalid variant and set COMPONENT_RANGE to
	/// {VTK_DOUBLE_MAX, VTK_DOUBLE_MIN} or (2) call ComputeUniqueValues(component)
	/// and ComputeFiniteRange(component) &lt;b&gt;before&lt;/b&gt; modifying the information object.
	/// Otherwise it is possible for modifications to the array to take place
	/// without the bounds on the component being updated.
	/// </summary>
	public static vtkInformationInformationVectorKey PER_FINITE_COMPONENT()
	{
		vtkInformationInformationVectorKey vtkInformationInformationVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractArray_PER_FINITE_COMPONENT_60(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationInformationVectorKey2 = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationInformationVectorKey2.Register(null);
			}
		}
		return vtkInformationInformationVectorKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_Reset_61(HandleRef pThis);

	/// <summary>
	/// Reset to an empty state, without freeing any memory.
	/// </summary>
	public void Reset()
	{
		vtkAbstractArray_Reset_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractArray_Resize_62(HandleRef pThis, long numTuples);

	/// <summary>
	/// Resize the array to the requested number of tuples and preserve data.
	/// Increasing the array size may allocate extra memory beyond what was
	/// requested. MaxId will not be modified when increasing array size.
	/// Decreasing the array size will trim memory to the requested size and
	/// may update MaxId if the valid id range is truncated.
	/// Requesting an array size of 0 will free all memory.
	/// Returns 1 if resizing succeeded and 0 otherwise.
	/// </summary>
	public virtual int Resize(long numTuples)
	{
		return vtkAbstractArray_Resize_62(GetCppThis(), numTuples);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractArray_SafeDownCast_63(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAbstractArray SafeDownCast(vtkObjectBase o)
	{
		vtkAbstractArray vtkAbstractArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractArray_SafeDownCast_63(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractArray2 = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractArray2.Register(null);
			}
		}
		return vtkAbstractArray2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_SetComponentName_64(HandleRef pThis, long component, string name);

	/// <summary>
	/// Set the name for a component. `component` must be &gt;= 0.
	/// </summary>
	public void SetComponentName(long component, string name)
	{
		vtkAbstractArray_SetComponentName_64(GetCppThis(), component, name);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_SetMaxDiscreteValues_65(HandleRef pThis, uint _arg);

	/// <summary>
	/// Get/Set the maximum number of prominent values this array may contain
	/// before it is considered continuous.  Default value is 32.
	/// </summary>
	public virtual void SetMaxDiscreteValues(uint _arg)
	{
		vtkAbstractArray_SetMaxDiscreteValues_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_SetName_66(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/get array's name
	/// </summary>
	public virtual void SetName(string _arg)
	{
		vtkAbstractArray_SetName_66(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_SetNumberOfComponents_67(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the dimension (n) of the components. Must be &gt;= 1. Make sure that
	/// this is set before allocation.
	/// </summary>
	public virtual void SetNumberOfComponents(int _arg)
	{
		vtkAbstractArray_SetNumberOfComponents_67(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_SetNumberOfTuples_68(HandleRef pThis, long numTuples);

	/// <summary>
	/// Set the number of tuples (a component group) in the array. Note that
	/// this may allocate space depending on the number of components.
	/// Also note that if allocation is performed no copy is performed so
	/// existing data will be lost (if data conservation is sought, one may
	/// use the Resize method instead).
	/// </summary>
	public virtual void SetNumberOfTuples(long numTuples)
	{
		vtkAbstractArray_SetNumberOfTuples_68(GetCppThis(), numTuples);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractArray_SetNumberOfValues_69(HandleRef pThis, long numValues);

	/// <summary>
	/// Specify the number of values (tuples * components) for this object to
	/// hold. Does an allocation as well as setting the MaxId ivar. Used in
	/// conjunction with SetValue() method for fast insertion. Preserves existing
	/// data and returns true if allocation succeeds, or false otherwise.
	/// </summary>
	public virtual bool SetNumberOfValues(long numValues)
	{
		return (vtkAbstractArray_SetNumberOfValues_69(GetCppThis(), numValues) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_SetTuple_70(HandleRef pThis, long dstTupleIdx, long srcTupleIdx, HandleRef source);

	/// <summary>
	/// Set the tuple at dstTupleIdx in this array to the tuple at srcTupleIdx in
	/// the source array. This method assumes that the two arrays have the same
	/// type and structure. Note that range checking and memory allocation is not
	/// performed; use in conjunction with SetNumberOfTuples() to allocate space.
	/// </summary>
	public virtual void SetTuple(long dstTupleIdx, long srcTupleIdx, vtkAbstractArray source)
	{
		vtkAbstractArray_SetTuple_70(GetCppThis(), dstTupleIdx, srcTupleIdx, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_SetVariantValue_71(HandleRef pThis, long valueIdx, HandleRef value);

	/// <summary>
	/// Set a value in the array from a variant.  This method does NOT do
	/// bounds checking.
	/// </summary>
	public virtual void SetVariantValue(long valueIdx, vtkVariant value)
	{
		vtkAbstractArray_SetVariantValue_71(GetCppThis(), valueIdx, value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_SetVoidArray_72(HandleRef pThis, IntPtr arg0, long arg1, int arg2);

	/// <summary>
	/// This method lets the user specify data to be held by the array.  The
	/// array argument is a pointer to the data.  size is the size of the array
	/// supplied by the user.  Set save to 1 to keep the class from deleting the
	/// array when it cleans up or reallocates memory.  The class uses the
	/// actual array provided; it does not copy the data from the supplied
	/// array. If specified, the delete method determines how the data array
	/// will be deallocated. If the delete method is VTK_DATA_ARRAY_FREE, free()
	/// will be used. If the delete method is VTK_DATA_ARRAY_DELETE, delete[]
	/// will be used. If the delete method is VTK_DATA_ARRAY_ALIGNED_FREE
	/// _aligned_free() will be used on windows, while free() will be used
	/// everywhere else. If the delete method is VTK_DATA_ARRAY_USER_DEFINED
	/// a custom free function can be assigned to be called using SetArrayFreeFunction,
	/// if no custom function is assigned we will default to free().
	/// The default is FREE.
	/// (Note not all subclasses can support deleteMethod.)
	/// </summary>
	public virtual void SetVoidArray(IntPtr arg0, long arg1, int arg2)
	{
		vtkAbstractArray_SetVoidArray_72(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_SetVoidArray_73(HandleRef pThis, IntPtr array, long size, int save, int arg3);

	/// <summary>
	/// This method lets the user specify data to be held by the array.  The
	/// array argument is a pointer to the data.  size is the size of the array
	/// supplied by the user.  Set save to 1 to keep the class from deleting the
	/// array when it cleans up or reallocates memory.  The class uses the
	/// actual array provided; it does not copy the data from the supplied
	/// array. If specified, the delete method determines how the data array
	/// will be deallocated. If the delete method is VTK_DATA_ARRAY_FREE, free()
	/// will be used. If the delete method is VTK_DATA_ARRAY_DELETE, delete[]
	/// will be used. If the delete method is VTK_DATA_ARRAY_ALIGNED_FREE
	/// _aligned_free() will be used on windows, while free() will be used
	/// everywhere else. If the delete method is VTK_DATA_ARRAY_USER_DEFINED
	/// a custom free function can be assigned to be called using SetArrayFreeFunction,
	/// if no custom function is assigned we will default to free().
	/// The default is FREE.
	/// (Note not all subclasses can support deleteMethod.)
	/// </summary>
	public virtual void SetVoidArray(IntPtr array, long size, int save, int arg3)
	{
		vtkAbstractArray_SetVoidArray_73(GetCppThis(), array, size, save, arg3);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractArray_Squeeze_74(HandleRef pThis);

	/// <summary>
	/// Free any unnecessary memory.
	/// Description:
	/// Resize object to just fit data requirement. Reclaims extra memory.
	/// </summary>
	public virtual void Squeeze()
	{
		vtkAbstractArray_Squeeze_74(GetCppThis());
	}
}
