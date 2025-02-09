using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFieldData
/// </summary>
/// <remarks>
///    represent and manipulate fields of data
///
/// vtkFieldData represents and manipulates fields of data. The model of a field
/// is a m x n matrix of data values, where m is the number of tuples, and n
/// is the number of components. (A tuple is a row of n components in the
/// matrix.) The field is assumed to be composed of a set of one or more data
/// arrays, where the data in the arrays are of different types (e.g., int,
/// double, char, etc.), and there may be variable numbers of components in
/// each array. Note that each data array is assumed to be "m" in length
/// (i.e., number of tuples), which typically corresponds to the number of
/// points or cells in a dataset. Also, each data array must have a
/// character-string name. (This is used to manipulate data.)
///
/// There are two ways of manipulating and interfacing to fields. You can do
/// it generically by manipulating components/tuples via a double-type data
/// exchange, or you can do it by grabbing the arrays and manipulating them
/// directly. The former is simpler but performs type conversion, which is bad
/// if your data has non-castable types like (void) pointers, or you lose
/// information as a result of the cast. The more efficient method means
/// managing each array in the field.  Using this method you can create
/// faster, more efficient algorithms that do not lose information.
///
/// </remarks>
/// <seealso>
///
/// vtkAbstractArray vtkDataSetAttributes vtkPointData vtkCellData
/// </seealso>
public class vtkFieldData : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFieldData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFieldData()
	{
		MRClassNameKey = "class vtkFieldData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFieldData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFieldData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFieldData New()
	{
		vtkFieldData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFieldData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFieldData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFieldData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldData_AddArray_01(HandleRef pThis, HandleRef array);

	/// <summary>
	/// Add an array to the array list. If an array with the same name
	/// already exists - then the added array will replace it.
	/// Return the index of the added array. If the given array is nullptr,
	/// does nothing and returns -1.
	/// </summary>
	public int AddArray(vtkAbstractArray array)
	{
		return vtkFieldData_AddArray_01(GetCppThis(), array?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldData_Allocate_02(HandleRef pThis, long sz, long ext);

	/// <summary>
	/// Allocate data for each array.
	/// Note that ext is no longer used.
	/// </summary>
	public int Allocate(long sz, long ext)
	{
		return vtkFieldData_Allocate_02(GetCppThis(), sz, ext);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldData_AllocateArrays_03(HandleRef pThis, int num);

	/// <summary>
	/// AllocateArrays actually sets the number of
	/// vtkAbstractArray pointers in the vtkFieldData object, not the
	/// number of used pointers (arrays). Adding more arrays will
	/// cause the object to dynamically adjust the number of pointers
	/// if it needs to extend. Although AllocateArrays can
	/// be used if the number of arrays which will be added is
	/// known, it can be omitted with a small computation cost.
	/// </summary>
	public void AllocateArrays(int num)
	{
		vtkFieldData_AllocateArrays_03(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldData_CopyAllOff_04(HandleRef pThis, int unused);

	/// <summary>
	/// Turn off copying of all data.
	/// During the copying/passing, the following rules are followed for each
	/// array:
	/// 1. If the copy flag for an array is set (on or off), it is applied.
	/// This overrides rule 2.
	/// 2. If CopyAllOn is set, copy the array.
	/// If CopyAllOff is set, do not copy the array.
	/// </summary>
	public virtual void CopyAllOff(int unused)
	{
		vtkFieldData_CopyAllOff_04(GetCppThis(), unused);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldData_CopyAllOn_05(HandleRef pThis, int unused);

	/// <summary>
	/// Turn on copying of all data.
	/// During the copying/passing, the following rules are followed for each
	/// array:
	/// 1. If the copy flag for an array is set (on or off), it is applied.
	/// This overrides rule 2.
	/// 2. If CopyAllOn is set, copy the array.
	/// If CopyAllOff is set, do not copy the array.
	/// </summary>
	public virtual void CopyAllOn(int unused)
	{
		vtkFieldData_CopyAllOn_05(GetCppThis(), unused);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldData_CopyFieldOff_06(HandleRef pThis, string name);

	/// <summary>
	/// Turn on/off the copying of the field specified by name.
	/// During the copying/passing, the following rules are followed for each
	/// array:
	/// 1. If the copy flag for an array is set (on or off), it is applied.
	/// This overrides rule 2.
	/// 2. If CopyAllOn is set, copy the array.
	/// If CopyAllOff is set, do not copy the array.
	/// </summary>
	public void CopyFieldOff(string name)
	{
		vtkFieldData_CopyFieldOff_06(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldData_CopyFieldOn_07(HandleRef pThis, string name);

	/// <summary>
	/// Turn on/off the copying of the field specified by name.
	/// During the copying/passing, the following rules are followed for each
	/// array:
	/// 1. If the copy flag for an array is set (on or off), it is applied.
	/// This overrides rule 2.
	/// 2. If CopyAllOn is set, copy the array.
	/// If CopyAllOff is set, do not copy the array.
	/// </summary>
	public void CopyFieldOn(string name)
	{
		vtkFieldData_CopyFieldOn_07(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldData_CopyStructure_08(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Copy data array structure from a given field.  The same arrays
	/// will exist with the same types, but will contain nothing in the
	/// copy.
	/// </summary>
	public void CopyStructure(vtkFieldData arg0)
	{
		vtkFieldData_CopyStructure_08(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldData_DeepCopy_09(HandleRef pThis, HandleRef da);

	/// <summary>
	/// Copy a field by creating new data arrays (i.e., duplicate storage).
	/// </summary>
	public virtual void DeepCopy(vtkFieldData da)
	{
		vtkFieldData_DeepCopy_09(GetCppThis(), da?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldData_ExtendedNew_10(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static vtkFieldData ExtendedNew()
	{
		vtkFieldData vtkFieldData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFieldData_ExtendedNew_10(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFieldData2 = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFieldData2.Register(null);
			}
		}
		return vtkFieldData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldData_GetAbstractArray_11(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the ith array in the field. Unlike GetArray(), this method returns
	/// a vtkAbstractArray and can be used to access any array type. A nullptr is
	/// returned only if the index i is out of range.
	/// </summary>
	public vtkAbstractArray GetAbstractArray(int i)
	{
		vtkAbstractArray vtkAbstractArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFieldData_GetAbstractArray_11(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldData_GetAbstractArray_12(HandleRef pThis, string arrayName, ref int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the array with the name given. Returns nullptr if array not found.
	/// Unlike GetArray(), this method returns a vtkAbstractArray and can be used
	/// to access any array type. Also returns index of array if found, -1
	/// otherwise.
	/// </summary>
	public vtkAbstractArray GetAbstractArray(string arrayName, ref int index)
	{
		vtkAbstractArray vtkAbstractArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFieldData_GetAbstractArray_12(GetCppThis(), arrayName, ref index, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldData_GetAbstractArray_13(HandleRef pThis, string arrayName, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the array with the name given. Returns nullptr if array not found.
	/// Unlike GetArray(), this method returns a vtkAbstractArray and can be used
	/// to access any array type.
	/// </summary>
	public vtkAbstractArray GetAbstractArray(string arrayName)
	{
		vtkAbstractArray vtkAbstractArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFieldData_GetAbstractArray_13(GetCppThis(), arrayName, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkFieldData_GetActualMemorySize_14(HandleRef pThis);

	/// <summary>
	/// Return the memory in kibibytes (1024 bytes) consumed by this field data. Used to
	/// support streaming and reading/writing data. The value returned is
	/// guaranteed to be greater than or equal to the memory required to
	/// actually represent the data represented by this object.
	/// </summary>
	public virtual uint GetActualMemorySize()
	{
		return vtkFieldData_GetActualMemorySize_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldData_GetArray_15(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Not recommended for use. Use GetAbstractArray(int i) instead.
	///
	/// Return the ith array in the field. A nullptr is returned if the
	/// index i is out of range, or if the array at the given
	/// index is not a vtkDataArray. To access vtkStringArray,
	/// or vtkVariantArray, use GetAbstractArray(int i).
	/// </summary>
	public vtkDataArray GetArray(int i)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFieldData_GetArray_15(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldData_GetArray_16(HandleRef pThis, string arrayName, ref int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Not recommended for use. Use
	/// GetAbstractArray(const char *arrayName, int &amp;index) instead.
	///
	/// Return the array with the name given. Returns nullptr if array not found.
	/// A nullptr is also returned if the array with the given name is not a
	/// vtkDataArray. To access vtkStringArray, or
	/// vtkVariantArray, use GetAbstractArray(const char* arrayName, int &amp;index).
	/// Also returns the index of the array if found, -1 otherwise.
	/// </summary>
	public vtkDataArray GetArray(string arrayName, ref int index)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFieldData_GetArray_16(GetCppThis(), arrayName, ref index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldData_GetArray_17(HandleRef pThis, string arrayName, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Not recommended for use. Use GetAbstractArray(const char *arrayName)
	/// instead.
	///
	/// Return the array with the name given. Returns nullptr if array not found.
	/// A nullptr is also returned if the array with the given name is not a
	/// vtkDataArray. To access vtkStringArray, or
	/// vtkVariantArray, use GetAbstractArray(const char *arrayName).
	/// </summary>
	public vtkDataArray GetArray(string arrayName)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFieldData_GetArray_17(GetCppThis(), arrayName, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldData_GetArrayContainingComponent_18(HandleRef pThis, int i, ref int arrayComp);

	/// <summary>
	/// Return the array containing the ith component of the field. The
	/// return value is an integer number n 0&lt;=n&lt;this-&gt;NumberOfArrays. Also,
	/// an integer value is returned indicating the component in the array
	/// is returned. Method returns -1 if specified component is not
	/// in the field.
	/// </summary>
	public int GetArrayContainingComponent(int i, ref int arrayComp)
	{
		return vtkFieldData_GetArrayContainingComponent_18(GetCppThis(), i, ref arrayComp);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldData_GetArrayName_19(HandleRef pThis, int i);

	/// <summary>
	/// Get the name of ith array.
	/// Note that this is equivalent to:
	/// GetAbstractArray(i)-&gt;GetName() if ith array pointer is not nullptr
	/// </summary>
	public string GetArrayName(int i)
	{
		return Marshal.PtrToStringAnsi(vtkFieldData_GetArrayName_19(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldData_GetField_20(HandleRef pThis, HandleRef ptId, HandleRef f);

	/// <summary>
	/// Get a field from a list of ids. Supplied field f should have same
	/// types and number of data arrays as this one (i.e., like
	/// CopyStructure() creates).  This method should not be used if the
	/// instance is from a subclass of vtkFieldData (vtkPointData or
	/// vtkCellData).  This is because in those cases, the attribute data
	/// is stored with the other fields and will cause the method to
	/// behave in an unexpected way.
	/// </summary>
	public void GetField(vtkIdList ptId, vtkFieldData f)
	{
		vtkFieldData_GetField_20(GetCppThis(), ptId?.GetCppThis() ?? default(HandleRef), f?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFieldData_GetFiniteRange_21(HandleRef pThis, string name, IntPtr range, int comp);

	/// <summary>
	/// Computes the range of the input data array (specified through its `name` or the `index`
	/// in this field data). If the targeted array is not polymorphic
	/// with a `vtkDataArray`, or if no array match the input `name` or `index`, or
	/// if `comp` is out of bounds, then the returned range is `[NaN, NaN]`.
	///
	/// The computed range is cached to avoid recomputing it. The range is recomputed
	/// if the held array has been modified, if `GhostsToSkip` has been changed, or if
	/// the ghost array has been changed / modified.
	///
	/// If a ghost array is present in the field data, then the binary mask `GhostsToSkip`
	/// is used to skip values associated with a ghost that intersects this mask.
	///
	/// `comp` targets which component of the array the range is to be computed on.
	/// Setting it to -1 results in computing the range of the magnitude of the array.
	///
	/// The `Finite` version of this method skips infinite values in the array in addition
	/// to ghosts matching with `GhostsToSkip`.
	/// </summary>
	public bool GetFiniteRange(string name, IntPtr range, int comp)
	{
		return (vtkFieldData_GetFiniteRange_21(GetCppThis(), name, range, comp) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFieldData_GetFiniteRange_22(HandleRef pThis, int index, IntPtr range, int comp);

	/// <summary>
	/// Computes the range of the input data array (specified through its `name` or the `index`
	/// in this field data). If the targeted array is not polymorphic
	/// with a `vtkDataArray`, or if no array match the input `name` or `index`, or
	/// if `comp` is out of bounds, then the returned range is `[NaN, NaN]`.
	///
	/// The computed range is cached to avoid recomputing it. The range is recomputed
	/// if the held array has been modified, if `GhostsToSkip` has been changed, or if
	/// the ghost array has been changed / modified.
	///
	/// If a ghost array is present in the field data, then the binary mask `GhostsToSkip`
	/// is used to skip values associated with a ghost that intersects this mask.
	///
	/// `comp` targets which component of the array the range is to be computed on.
	/// Setting it to -1 results in computing the range of the magnitude of the array.
	///
	/// The `Finite` version of this method skips infinite values in the array in addition
	/// to ghosts matching with `GhostsToSkip`.
	/// </summary>
	public bool GetFiniteRange(int index, IntPtr range, int comp)
	{
		return (vtkFieldData_GetFiniteRange_22(GetCppThis(), index, range, comp) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldData_GetGhostArray_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the ghost array, if present in this field data. If no ghost array is set,
	/// returns `nullptr`. A ghost array is a `vtkUnsignedCharArray` called `vtkGhostType`.
	/// See `vtkDataSetAttributes` for more context on ghost types.
	///
	/// @sa
	/// vtkDataSetAttributes
	/// </summary>
	public virtual vtkUnsignedCharArray GetGhostArray()
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFieldData_GetGhostArray_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFieldData_GetGhostsToSkip_24(HandleRef pThis);

	/// <summary>
	/// Set / Get the binary mask filtering out certain types of ghosts when calling `GetRange`.
	/// By default, it is set to 0xff for pure `vtkFieldData`. In `vtkCellData`, it is set to
	/// `HIDDENCELL` and in `vtkPointData`, it is set to `HIDDENPOINT` by default.
	/// See `vtkDataSetAttributes` for more context on ghost types definitions.
	///
	/// @sa
	/// vtkDataSetAttributes
	/// vtkPointData
	/// vtkCellData
	/// </summary>
	public virtual byte GetGhostsToSkip()
	{
		return vtkFieldData_GetGhostsToSkip_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkFieldData_GetMTime_25(HandleRef pThis);

	/// <summary>
	/// Check object's components for modified times.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkFieldData_GetMTime_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldData_GetNumberOfArrays_26(HandleRef pThis);

	/// <summary>
	/// Get the number of arrays of data available.
	/// This does not include nullptr array pointers therefore after
	/// fd-&gt;AllocateArray(n); nArrays = GetNumberOfArrays();
	/// nArrays is not necessarily equal to n.
	/// </summary>
	public int GetNumberOfArrays()
	{
		return vtkFieldData_GetNumberOfArrays_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldData_GetNumberOfComponents_27(HandleRef pThis);

	/// <summary>
	/// Get the number of components in the field. This is determined by adding
	/// up the components in each non-nullptr array.
	/// This method should not be used if the instance is from a
	/// subclass of vtkFieldData (vtkPointData or vtkCellData).
	/// This is because in those cases, the attribute data is
	/// stored with the other fields and will cause the method
	/// to behave in an unexpected way.
	/// </summary>
	public int GetNumberOfComponents()
	{
		return vtkFieldData_GetNumberOfComponents_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFieldData_GetNumberOfGenerationsFromBase_28(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFieldData_GetNumberOfGenerationsFromBase_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFieldData_GetNumberOfGenerationsFromBaseType_29(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFieldData_GetNumberOfGenerationsFromBaseType_29(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFieldData_GetNumberOfTuples_30(HandleRef pThis);

	/// <summary>
	/// Get the number of tuples in the field. Note: some fields have arrays with
	/// different numbers of tuples; this method returns the number of tuples in
	/// the first array. Mixed-length arrays may have to be treated specially.
	/// This method should not be used if the instance is from a
	/// subclass of vtkFieldData (vtkPointData or vtkCellData).
	/// This is because in those cases, the attribute data is
	/// stored with the other fields and will cause the method
	/// to behave in an unexpected way.
	/// </summary>
	public long GetNumberOfTuples()
	{
		return vtkFieldData_GetNumberOfTuples_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFieldData_GetRange_31(HandleRef pThis, string name, IntPtr range, int comp);

	/// <summary>
	/// Computes the range of the input data array (specified through its `name` or the `index`
	/// in this field data). If the targeted array is not polymorphic
	/// with a `vtkDataArray`, or if no array match the input `name` or `index`, or
	/// if `comp` is out of bounds, then the returned range is `[NaN, NaN]`.
	///
	/// The computed range is cached to avoid recomputing it. The range is recomputed
	/// if the held array has been modified, if `GhostsToSkip` has been changed, or if
	/// the ghost array has been changed / modified.
	///
	/// If a ghost array is present in the field data, then the binary mask `GhostsToSkip`
	/// is used to skip values associated with a ghost that intersects this mask.
	///
	/// `comp` targets which component of the array the range is to be computed on.
	/// Setting it to -1 results in computing the range of the magnitude of the array.
	///
	/// The `Finite` version of this method skips infinite values in the array in addition
	/// to ghosts matching with `GhostsToSkip`.
	/// </summary>
	public bool GetRange(string name, IntPtr range, int comp)
	{
		return (vtkFieldData_GetRange_31(GetCppThis(), name, range, comp) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFieldData_GetRange_32(HandleRef pThis, int index, IntPtr range, int comp);

	/// <summary>
	/// Computes the range of the input data array (specified through its `name` or the `index`
	/// in this field data). If the targeted array is not polymorphic
	/// with a `vtkDataArray`, or if no array match the input `name` or `index`, or
	/// if `comp` is out of bounds, then the returned range is `[NaN, NaN]`.
	///
	/// The computed range is cached to avoid recomputing it. The range is recomputed
	/// if the held array has been modified, if `GhostsToSkip` has been changed, or if
	/// the ghost array has been changed / modified.
	///
	/// If a ghost array is present in the field data, then the binary mask `GhostsToSkip`
	/// is used to skip values associated with a ghost that intersects this mask.
	///
	/// `comp` targets which component of the array the range is to be computed on.
	/// Setting it to -1 results in computing the range of the magnitude of the array.
	///
	/// The `Finite` version of this method skips infinite values in the array in addition
	/// to ghosts matching with `GhostsToSkip`.
	/// </summary>
	public bool GetRange(int index, IntPtr range, int comp)
	{
		return (vtkFieldData_GetRange_32(GetCppThis(), index, range, comp) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFieldData_HasAnyGhostBitSet_33(HandleRef pThis, int bitFlag);

	/// <summary>
	/// Helper function that tests if any of the values in ghost array has been set.
	/// The test performed is (value &amp; bitFlag).
	/// </summary>
	public bool HasAnyGhostBitSet(int bitFlag)
	{
		return (vtkFieldData_HasAnyGhostBitSet_33(GetCppThis(), bitFlag) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldData_HasArray_34(HandleRef pThis, string name);

	/// <summary>
	/// Return 1 if an array with the given name could be found. 0 otherwise.
	/// </summary>
	public int HasArray(string name)
	{
		return vtkFieldData_HasArray_34(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldData_Initialize_35(HandleRef pThis);

	/// <summary>
	/// Release all data but do not delete object.
	/// Also, clear the copy flags.
	/// </summary>
	public virtual void Initialize()
	{
		vtkFieldData_Initialize_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFieldData_InsertNextTuple_36(HandleRef pThis, long j, HandleRef source);

	/// <summary>
	/// Insert the jth tuple in source field data at the end of the
	/// tuple matrix. Range checking is performed and memory is allocated
	/// as necessary.
	/// </summary>
	public long InsertNextTuple(long j, vtkFieldData source)
	{
		return vtkFieldData_InsertNextTuple_36(GetCppThis(), j, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldData_InsertTuple_37(HandleRef pThis, long i, long j, HandleRef source);

	/// <summary>
	/// Insert the jth tuple in source field data at the ith location.
	/// Range checking is performed and memory allocates as necessary.
	/// </summary>
	public void InsertTuple(long i, long j, vtkFieldData source)
	{
		vtkFieldData_InsertTuple_37(GetCppThis(), i, j, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldData_IsA_38(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFieldData_IsA_38(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFieldData_IsTypeOf_39(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFieldData_IsTypeOf_39(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldData_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFieldData NewInstance()
	{
		vtkFieldData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFieldData_NewInstance_41(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldData_NullData_42(HandleRef pThis, long id);

	/// <summary>
	/// Sets every vtkDataArray at index id to a null tuple.
	/// </summary>
	public void NullData(long id)
	{
		vtkFieldData_NullData_42(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldData_PassData_43(HandleRef pThis, HandleRef fd);

	/// <summary>
	/// Pass entire arrays of input data through to output. Obey the "copy"
	/// flags.
	/// </summary>
	public virtual void PassData(vtkFieldData fd)
	{
		vtkFieldData_PassData_43(GetCppThis(), fd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldData_RemoveArray_44(HandleRef pThis, string name);

	/// <summary>
	/// Remove an array (with the given name) from the list of arrays.
	/// </summary>
	public virtual void RemoveArray(string name)
	{
		vtkFieldData_RemoveArray_44(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldData_RemoveArray_45(HandleRef pThis, int index);

	/// <summary>
	/// Remove an array (with the given index) from the list of arrays.
	/// </summary>
	public virtual void RemoveArray(int index)
	{
		vtkFieldData_RemoveArray_45(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldData_Reset_46(HandleRef pThis);

	/// <summary>
	/// Resets each data array in the field (Reset() does not release memory but
	/// it makes the arrays look like they are empty.)
	/// </summary>
	public void Reset()
	{
		vtkFieldData_Reset_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFieldData_SafeDownCast_47(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFieldData SafeDownCast(vtkObjectBase o)
	{
		vtkFieldData vtkFieldData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFieldData_SafeDownCast_47(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFieldData2 = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFieldData2.Register(null);
			}
		}
		return vtkFieldData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldData_SetGhostsToSkip_48(HandleRef pThis, byte arg0);

	/// <summary>
	/// Set / Get the binary mask filtering out certain types of ghosts when calling `GetRange`.
	/// By default, it is set to 0xff for pure `vtkFieldData`. In `vtkCellData`, it is set to
	/// `HIDDENCELL` and in `vtkPointData`, it is set to `HIDDENPOINT` by default.
	/// See `vtkDataSetAttributes` for more context on ghost types definitions.
	///
	/// @sa
	/// vtkDataSetAttributes
	/// vtkPointData
	/// vtkCellData
	/// </summary>
	public virtual void SetGhostsToSkip(byte arg0)
	{
		vtkFieldData_SetGhostsToSkip_48(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldData_SetNumberOfTuples_49(HandleRef pThis, long number);

	/// <summary>
	/// Set the number of tuples for each data array in the field.
	/// This method should not be used if the instance is from a
	/// subclass of vtkFieldData (vtkPointData or vtkCellData).
	/// This is because in those cases, the attribute data is
	/// stored with the other fields and will cause the method
	/// to behave in an unexpected way.
	/// </summary>
	public void SetNumberOfTuples(long number)
	{
		vtkFieldData_SetNumberOfTuples_49(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldData_SetTuple_50(HandleRef pThis, long i, long j, HandleRef source);

	/// <summary>
	/// Set the jth tuple in source field data at the ith location.
	/// Set operations mean that no range checking is performed, so
	/// they're faster.
	/// </summary>
	public void SetTuple(long i, long j, vtkFieldData source)
	{
		vtkFieldData_SetTuple_50(GetCppThis(), i, j, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldData_ShallowCopy_51(HandleRef pThis, HandleRef da);

	/// <summary>
	/// Copy a field by reference counting the data arrays.
	/// </summary>
	public virtual void ShallowCopy(vtkFieldData da)
	{
		vtkFieldData_ShallowCopy_51(GetCppThis(), da?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFieldData_Squeeze_52(HandleRef pThis);

	/// <summary>
	/// Squeezes each data array in the field (Squeeze() reclaims unused memory.)
	/// </summary>
	public void Squeeze()
	{
		vtkFieldData_Squeeze_52(GetCppThis());
	}
}
