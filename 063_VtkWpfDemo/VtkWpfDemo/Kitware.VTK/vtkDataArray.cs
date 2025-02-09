using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDataArray
/// </summary>
/// <remarks>
///    abstract superclass for arrays of numeric data
///
///
/// vtkDataArray is an abstract superclass for data array objects
/// containing numeric data.  It extends the API defined in
/// vtkAbstractArray.  vtkDataArray is an abstract superclass for data
/// array objects. This class defines an API that all array objects
/// must support. Note that the concrete subclasses of this class
/// represent data in native form (char, int, etc.) and often have
/// specialized more efficient methods for operating on this data (for
/// example, getting pointers to data or getting/inserting data in
/// native form).  Subclasses of vtkDataArray are assumed to contain
/// data whose components are meaningful when cast to and from double.
///
/// </remarks>
/// <seealso>
///
/// vtkBitArray vtkGenericDataArray
/// </seealso>
public abstract class vtkDataArray : vtkAbstractArray
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataArray";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataArray()
	{
		MRClassNameKey = "class vtkDataArray";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataArray"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern IntPtr vtkDataArray_COMPONENT_RANGE_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This key is used to hold tight bounds on the range of
	/// one component over all tuples of the array.
	/// Two values (a minimum and maximum) are stored for each component.
	/// When GetRange() is called when no tuples are present in the array
	/// this value is set to { VTK_DOUBLE_MAX, VTK_DOUBLE_MIN }.
	/// </summary>
	public static vtkInformationDoubleVectorKey COMPONENT_RANGE()
	{
		vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataArray_COMPONENT_RANGE_01(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDataArray_CopyComponent_02(HandleRef pThis, int dstComponent, HandleRef src, int srcComponent);

	/// <summary>
	/// Copy a component from one data array into a component on this data array.
	/// This method copies the specified component ("srcComponent") from the
	/// specified data array ("src") to the specified component ("dstComponent")
	/// over all the tuples in this data array.  This method can be used to extract
	/// a component (column) from one data array and paste that data into
	/// a component on this data array.
	/// </summary>
	public virtual void CopyComponent(int dstComponent, vtkDataArray src, int srcComponent)
	{
		vtkDataArray_CopyComponent_02(GetCppThis(), dstComponent, src?.GetCppThis() ?? default(HandleRef), srcComponent);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataArray_CopyInformation_03(HandleRef pThis, HandleRef infoFrom, int deep);

	/// <summary>
	/// Copy information instance. Arrays use information objects
	/// in a variety of ways. It is important to have flexibility in
	/// this regard because certain keys should not be copied, while
	/// others must be. NOTE: Up to the implmenter to make sure that
	/// keys not intended to be copied are excluded here.
	/// </summary>
	public override int CopyInformation(vtkInformation infoFrom, int deep)
	{
		return vtkDataArray_CopyInformation_03(GetCppThis(), infoFrom?.GetCppThis() ?? default(HandleRef), deep);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArray_CreateDataArray_04(int dataType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates an array for dataType where dataType is one of
	/// VTK_BIT, VTK_CHAR, VTK_SIGNED_CHAR, VTK_UNSIGNED_CHAR, VTK_SHORT,
	/// VTK_UNSIGNED_SHORT, VTK_INT, VTK_UNSIGNED_INT, VTK_LONG,
	/// VTK_UNSIGNED_LONG, VTK_FLOAT, VTK_DOUBLE, VTK_ID_TYPE.
	/// Note that the data array returned has be deleted by the
	/// user.
	/// </summary>
	public static vtkDataArray CreateDataArray(int dataType)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataArray_CreateDataArray_04(dataType, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_CreateDefaultLookupTable_05(HandleRef pThis);

	/// <summary>
	/// Create default lookup table. Generally used to create one when none
	/// is available.
	/// </summary>
	public void CreateDefaultLookupTable()
	{
		vtkDataArray_CreateDefaultLookupTable_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_DeepCopy_06(HandleRef pThis, HandleRef aa);

	/// <summary>
	/// Deep copy of data. Copies data from different data arrays even if
	/// they are different types (using doubleing-point exchange).
	/// </summary>
	public override void DeepCopy(vtkAbstractArray aa)
	{
		vtkDataArray_DeepCopy_06(GetCppThis(), aa?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_DeepCopy_07(HandleRef pThis, HandleRef da);

	/// <summary>
	/// Deep copy of data. Copies data from different data arrays even if
	/// they are different types (using doubleing-point exchange).
	/// </summary>
	public virtual void DeepCopy(vtkDataArray da)
	{
		vtkDataArray_DeepCopy_07(GetCppThis(), da?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArray_FastDownCast_08(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Perform a fast, safe cast from a vtkAbstractArray to a vtkDataArray.
	/// This method checks if source-&gt;GetArrayType() returns DataArray
	/// or a more derived type, and performs a static_cast to return
	/// source as a vtkDataArray pointer. Otherwise, nullptr is returned.
	/// </summary>
	public static vtkDataArray FastDownCast(vtkAbstractArray source)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataArray_FastDownCast_08(source?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_Fill_09(HandleRef pThis, double value);

	/// <summary>
	/// Fill all values of a data array with a specified value.
	/// </summary>
	public virtual void Fill(double value)
	{
		vtkDataArray_Fill_09(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_FillComponent_10(HandleRef pThis, int compIdx, double value);

	/// <summary>
	/// Fill a component of a data array with a specified value. This method
	/// sets the specified component to specified value for all tuples in the
	/// data array.  This methods can be used to initialize or reinitialize a
	/// single component of a multi-component array.
	/// </summary>
	public virtual void FillComponent(int compIdx, double value)
	{
		vtkDataArray_FillComponent_10(GetCppThis(), compIdx, value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDataArray_GetActualMemorySize_11(HandleRef pThis);

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
		return vtkDataArray_GetActualMemorySize_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataArray_GetArrayType_12(HandleRef pThis);

	/// <summary>
	/// Method for type-checking in FastDownCast implementations.
	/// </summary>
	public override int GetArrayType()
	{
		return vtkDataArray_GetArrayType_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDataArray_GetComponent_13(HandleRef pThis, long tupleIdx, int compIdx);

	/// <summary>
	/// Return the data component at the location specified by tupleIdx and
	/// compIdx.
	/// </summary>
	public virtual double GetComponent(long tupleIdx, int compIdx)
	{
		return vtkDataArray_GetComponent_13(GetCppThis(), tupleIdx, compIdx);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_GetData_14(HandleRef pThis, long tupleMin, long tupleMax, int compMin, int compMax, HandleRef data);

	/// <summary>
	/// Get the data as a double array in the range (tupleMin,tupleMax) and
	/// (compMin, compMax). The resulting double array consists of all data in
	/// the tuple range specified and only the component range specified. This
	/// process typically requires casting the data from native form into
	/// doubleing point values. This method is provided as a convenience for data
	/// exchange, and is not very fast.
	/// </summary>
	public virtual void GetData(long tupleMin, long tupleMax, int compMin, int compMax, vtkDoubleArray data)
	{
		vtkDataArray_GetData_14(GetCppThis(), tupleMin, tupleMax, compMin, compMax, data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDataArray_GetDataTypeMax_15(HandleRef pThis);

	/// <summary>
	/// These methods return the Min and Max possible range of the native
	/// data type. For example if a vtkScalars consists of unsigned char
	/// data these will return (0,255).
	/// </summary>
	public double GetDataTypeMax()
	{
		return vtkDataArray_GetDataTypeMax_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDataArray_GetDataTypeMax_16(int type);

	/// <summary>
	/// These methods return the Min and Max possible range of the native
	/// data type. For example if a vtkScalars consists of unsigned char
	/// data these will return (0,255).
	/// </summary>
	public static double GetDataTypeMax(int type)
	{
		return vtkDataArray_GetDataTypeMax_16(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDataArray_GetDataTypeMin_17(HandleRef pThis);

	/// <summary>
	/// These methods return the Min and Max possible range of the native
	/// data type. For example if a vtkScalars consists of unsigned char
	/// data these will return (0,255).
	/// </summary>
	public double GetDataTypeMin()
	{
		return vtkDataArray_GetDataTypeMin_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDataArray_GetDataTypeMin_18(int type);

	/// <summary>
	/// These methods return the Min and Max possible range of the native
	/// data type. For example if a vtkScalars consists of unsigned char
	/// data these will return (0,255).
	/// </summary>
	public static double GetDataTypeMin(int type)
	{
		return vtkDataArray_GetDataTypeMin_18(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_GetDataTypeRange_19(HandleRef pThis, IntPtr range);

	/// <summary>
	/// These methods return the Min and Max possible range of the native
	/// data type. For example if a vtkScalars consists of unsigned char
	/// data these will return (0,255).
	/// </summary>
	public void GetDataTypeRange(IntPtr range)
	{
		vtkDataArray_GetDataTypeRange_19(GetCppThis(), range);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_GetDataTypeRange_20(int type, IntPtr range);

	/// <summary>
	/// These methods return the Min and Max possible range of the native
	/// data type. For example if a vtkScalars consists of unsigned char
	/// data these will return (0,255).
	/// </summary>
	public static void GetDataTypeRange(int type, IntPtr range)
	{
		vtkDataArray_GetDataTypeRange_20(type, range);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataArray_GetElementComponentSize_21(HandleRef pThis);

	/// <summary>
	/// Return the size, in bytes, of the lowest-level element of an
	/// array.  For vtkDataArray and subclasses this is the size of the
	/// data type.
	/// </summary>
	public override int GetElementComponentSize()
	{
		return vtkDataArray_GetElementComponentSize_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_GetFiniteRange_22(HandleRef pThis, IntPtr range, int comp);

	/// <summary>
	/// The range of the data array values for the given component will be
	/// returned in the provided range array argument. If comp is -1, the range
	/// of the magnitude (L2 norm) over all components will be provided. The
	/// range is computed and then cached, and will not be re-computed on
	/// subsequent calls to GetRange() unless the array is modified or the
	/// requested component changes.
	///
	/// The version of this method with `ghosts` and `ghostsToSkip` allows to skip
	/// values in the computation of the range. At a given id, if `ghosts[id] &amp; ghostsToSkip != 0`,
	/// then the corresponding tuple is not accounted for when computing the range.
	///
	/// Note that when the ghost array is provided, no cached value is stored inside
	/// this instance. See `vtkFieldData::GetRange`, which caches the computated range
	/// when using a ghost array.
	///
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public void GetFiniteRange(IntPtr range, int comp)
	{
		vtkDataArray_GetFiniteRange_22(GetCppThis(), range, comp);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_GetFiniteRange_23(HandleRef pThis, IntPtr range, int comp, IntPtr ghosts, byte ghostsToSkip);

	/// <summary>
	/// The range of the data array values for the given component will be
	/// returned in the provided range array argument. If comp is -1, the range
	/// of the magnitude (L2 norm) over all components will be provided. The
	/// range is computed and then cached, and will not be re-computed on
	/// subsequent calls to GetRange() unless the array is modified or the
	/// requested component changes.
	///
	/// The version of this method with `ghosts` and `ghostsToSkip` allows to skip
	/// values in the computation of the range. At a given id, if `ghosts[id] &amp; ghostsToSkip != 0`,
	/// then the corresponding tuple is not accounted for when computing the range.
	///
	/// Note that when the ghost array is provided, no cached value is stored inside
	/// this instance. See `vtkFieldData::GetRange`, which caches the computated range
	/// when using a ghost array.
	///
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public void GetFiniteRange(IntPtr range, int comp, IntPtr ghosts, byte ghostsToSkip)
	{
		vtkDataArray_GetFiniteRange_23(GetCppThis(), range, comp, ghosts, ghostsToSkip);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArray_GetFiniteRange_24(HandleRef pThis, int comp);

	/// <summary>
	/// Return the range of the data array values for the given component. If
	/// comp is -1, return the range of the magnitude (L2 norm) over all
	/// components.The range is computed and then cached, and will not be
	/// re-computed on subsequent calls to GetRange() unless the array is
	/// modified or the requested component changes.
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public IntPtr GetFiniteRange(int comp)
	{
		return vtkDataArray_GetFiniteRange_24(GetCppThis(), comp);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArray_GetFiniteRange_25(HandleRef pThis);

	/// <summary>
	/// Return the range of the data array. If the array has multiple components,
	/// then this will return the range of only the first component (component
	/// zero). The range is computed and then cached, and will not be re-computed
	/// on subsequent calls to GetRange() unless the array is modified.
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public IntPtr GetFiniteRange()
	{
		return vtkDataArray_GetFiniteRange_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_GetFiniteRange_26(HandleRef pThis, IntPtr range);

	/// <summary>
	/// The range of the data array values will be returned in the provided
	/// range array argument. If the data array has multiple components, then
	/// this will return the range of only the first component (component zero).
	/// The range is computend and then cached, and will not be re-computed on
	/// subsequent calls to GetRange() unless the array is modified.
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public void GetFiniteRange(IntPtr range)
	{
		vtkDataArray_GetFiniteRange_26(GetCppThis(), range);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArray_GetLookupTable_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the lookup table associated with this scalar data, if any.
	/// </summary>
	public virtual vtkLookupTable GetLookupTable()
	{
		vtkLookupTable vtkLookupTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataArray_GetLookupTable_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLookupTable2 = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLookupTable2.Register(null);
			}
		}
		return vtkLookupTable2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDataArray_GetMaxNorm_28(HandleRef pThis);

	/// <summary>
	/// Return the maximum norm for the tuples.
	/// Note that the max. is computed every time GetMaxNorm is called.
	/// </summary>
	public virtual double GetMaxNorm()
	{
		return vtkDataArray_GetMaxNorm_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataArray_GetNumberOfGenerationsFromBase_29(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataArray_GetNumberOfGenerationsFromBase_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataArray_GetNumberOfGenerationsFromBaseType_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataArray_GetNumberOfGenerationsFromBaseType_30(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_GetRange_31(HandleRef pThis, IntPtr range, int comp);

	/// <summary>
	/// The range of the data array values for the given component will be
	/// returned in the provided range array argument. If comp is -1, the range
	/// of the magnitude (L2 norm) over all components will be provided. The
	/// range is computed and then cached, and will not be re-computed on
	/// subsequent calls to GetRange() unless the array is modified or the
	/// requested component changes.
	///
	/// The version of this method with `ghosts` and `ghostsToSkip` allows to skip
	/// values in the computation of the range. At a given id, if `ghosts[id] &amp; ghostsToSkip != 0`,
	/// then the corresponding tuple is not accounted for when computing the range.
	/// Note that when the ghost array is provided, no cached value is stored inside
	/// this instance. See `vtkFieldData::GetRange`, which caches the computated range
	/// when using a ghost array.
	///
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public void GetRange(IntPtr range, int comp)
	{
		vtkDataArray_GetRange_31(GetCppThis(), range, comp);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_GetRange_32(HandleRef pThis, IntPtr range, int comp, IntPtr ghosts, byte ghostsToSkip);

	/// <summary>
	/// The range of the data array values for the given component will be
	/// returned in the provided range array argument. If comp is -1, the range
	/// of the magnitude (L2 norm) over all components will be provided. The
	/// range is computed and then cached, and will not be re-computed on
	/// subsequent calls to GetRange() unless the array is modified or the
	/// requested component changes.
	///
	/// The version of this method with `ghosts` and `ghostsToSkip` allows to skip
	/// values in the computation of the range. At a given id, if `ghosts[id] &amp; ghostsToSkip != 0`,
	/// then the corresponding tuple is not accounted for when computing the range.
	/// Note that when the ghost array is provided, no cached value is stored inside
	/// this instance. See `vtkFieldData::GetRange`, which caches the computated range
	/// when using a ghost array.
	///
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public void GetRange(IntPtr range, int comp, IntPtr ghosts, byte ghostsToSkip)
	{
		vtkDataArray_GetRange_32(GetCppThis(), range, comp, ghosts, ghostsToSkip);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArray_GetRange_33(HandleRef pThis, int comp);

	/// <summary>
	/// Return the range of the data array values for the given component. If
	/// comp is -1, return the range of the magnitude (L2 norm) over all
	/// components.The range is computed and then cached, and will not be
	/// re-computed on subsequent calls to GetRange() unless the array is
	/// modified or the requested component changes.
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public double[] GetRange(int comp)
	{
		IntPtr intPtr = vtkDataArray_GetRange_33(GetCppThis(), comp);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArray_GetRange_34(HandleRef pThis);

	/// <summary>
	/// Return the range of the data array. If the array has multiple components,
	/// then this will return the range of only the first component (component
	/// zero). The range is computed and then cached, and will not be re-computed
	/// on subsequent calls to GetRange() unless the array is modified.
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public double[] GetRange()
	{
		IntPtr intPtr = vtkDataArray_GetRange_34(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_GetRange_35(HandleRef pThis, IntPtr range);

	/// <summary>
	/// The range of the data array values will be returned in the provided
	/// range array argument. If the data array has multiple components, then
	/// this will return the range of only the first component (component zero).
	/// The range is computend and then cached, and will not be re-computed on
	/// subsequent calls to GetRange() unless the array is modified.
	/// THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public void GetRange(IntPtr range)
	{
		vtkDataArray_GetRange_35(GetCppThis(), range);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArray_GetTuple_36(HandleRef pThis, long tupleIdx);

	/// <summary>
	/// Get the data tuple at tupleIdx. Return it as a pointer to an array.
	/// Note: this method is not thread-safe, and the pointer is only valid
	/// as long as another method invocation to a vtk object is not performed.
	/// </summary>
	public virtual IntPtr GetTuple(long tupleIdx)
	{
		return vtkDataArray_GetTuple_36(GetCppThis(), tupleIdx);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_GetTuple_37(HandleRef pThis, long tupleIdx, IntPtr tuple);

	/// <summary>
	/// Get the data tuple at tupleIdx by filling in a user-provided array,
	/// Make sure that your array is large enough to hold the NumberOfComponents
	/// amount of data being returned.
	/// </summary>
	public virtual void GetTuple(long tupleIdx, IntPtr tuple)
	{
		vtkDataArray_GetTuple_37(GetCppThis(), tupleIdx, tuple);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDataArray_GetTuple1_38(HandleRef pThis, long tupleIdx);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// GetTuple() and SetTuple() which return/take arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public double GetTuple1(long tupleIdx)
	{
		return vtkDataArray_GetTuple1_38(GetCppThis(), tupleIdx);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArray_GetTuple2_39(HandleRef pThis, long tupleIdx);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// GetTuple() and SetTuple() which return/take arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public double[] GetTuple2(long tupleIdx)
	{
		IntPtr intPtr = vtkDataArray_GetTuple2_39(GetCppThis(), tupleIdx);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArray_GetTuple3_40(HandleRef pThis, long tupleIdx);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// GetTuple() and SetTuple() which return/take arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public double[] GetTuple3(long tupleIdx)
	{
		IntPtr intPtr = vtkDataArray_GetTuple3_40(GetCppThis(), tupleIdx);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArray_GetTuple4_41(HandleRef pThis, long tupleIdx);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// GetTuple() and SetTuple() which return/take arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public double[] GetTuple4(long tupleIdx)
	{
		IntPtr intPtr = vtkDataArray_GetTuple4_41(GetCppThis(), tupleIdx);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArray_GetTuple6_42(HandleRef pThis, long tupleIdx);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// GetTuple() and SetTuple() which return/take arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public double[] GetTuple6(long tupleIdx)
	{
		IntPtr intPtr = vtkDataArray_GetTuple6_42(GetCppThis(), tupleIdx);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArray_GetTuple9_43(HandleRef pThis, long tupleIdx);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// GetTuple() and SetTuple() which return/take arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public double[] GetTuple9(long tupleIdx)
	{
		IntPtr intPtr = vtkDataArray_GetTuple9_43(GetCppThis(), tupleIdx);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[9];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_GetTuples_44(HandleRef pThis, HandleRef tupleIds, HandleRef output);

	/// <summary>
	/// See documentation from parent class.
	/// This method assumes that the `source` inherits from `vtkDataArray`, but its value type doesn't
	/// have to match the type of the current instance.
	/// </summary>
	public override void GetTuples(vtkIdList tupleIds, vtkAbstractArray output)
	{
		vtkDataArray_GetTuples_44(GetCppThis(), tupleIds?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_GetTuples_45(HandleRef pThis, long p1, long p2, HandleRef output);

	/// <summary>
	/// See documentation from parent class.
	/// This method assumes that the `source` inherits from `vtkDataArray`, but its value type doesn't
	/// have to match the type of the current instance.
	/// </summary>
	public override void GetTuples(long p1, long p2, vtkAbstractArray output)
	{
		vtkDataArray_GetTuples_45(GetCppThis(), p1, p2, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_InsertComponent_46(HandleRef pThis, long tupleIdx, int compIdx, double value);

	/// <summary>
	/// Insert value at the location specified by tupleIdx and compIdx.
	/// Note that memory allocation is performed as necessary to hold the data.
	/// </summary>
	public virtual void InsertComponent(long tupleIdx, int compIdx, double value)
	{
		vtkDataArray_InsertComponent_46(GetCppThis(), tupleIdx, compIdx, value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataArray_InsertNextTuple_47(HandleRef pThis, long srcTupleIdx, HandleRef source);

	/// <summary>
	/// See documentation from parent class.
	/// This method assumes that the `source` inherits from `vtkDataArray`, but its value type doesn't
	/// have to match the type of the current instance.
	/// </summary>
	public override long InsertNextTuple(long srcTupleIdx, vtkAbstractArray source)
	{
		return vtkDataArray_InsertNextTuple_47(GetCppThis(), srcTupleIdx, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataArray_InsertNextTuple_48(HandleRef pThis, IntPtr tuple);

	/// <summary>
	/// Insert the data tuple at the end of the array and return the tuple index at
	/// which the data was inserted. Memory is allocated as necessary to hold
	/// the data.
	/// </summary>
	public virtual long InsertNextTuple(IntPtr tuple)
	{
		return vtkDataArray_InsertNextTuple_48(GetCppThis(), tuple);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_InsertNextTuple1_49(HandleRef pThis, double value);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// InsertTuple() which takes arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public void InsertNextTuple1(double value)
	{
		vtkDataArray_InsertNextTuple1_49(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_InsertNextTuple2_50(HandleRef pThis, double val0, double val1);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// InsertTuple() which takes arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public void InsertNextTuple2(double val0, double val1)
	{
		vtkDataArray_InsertNextTuple2_50(GetCppThis(), val0, val1);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_InsertNextTuple3_51(HandleRef pThis, double val0, double val1, double val2);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// InsertTuple() which takes arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public void InsertNextTuple3(double val0, double val1, double val2)
	{
		vtkDataArray_InsertNextTuple3_51(GetCppThis(), val0, val1, val2);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_InsertNextTuple4_52(HandleRef pThis, double val0, double val1, double val2, double val3);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// InsertTuple() which takes arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public void InsertNextTuple4(double val0, double val1, double val2, double val3)
	{
		vtkDataArray_InsertNextTuple4_52(GetCppThis(), val0, val1, val2, val3);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_InsertNextTuple6_53(HandleRef pThis, double val0, double val1, double val2, double val3, double val4, double val5);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// InsertTuple() which takes arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public void InsertNextTuple6(double val0, double val1, double val2, double val3, double val4, double val5)
	{
		vtkDataArray_InsertNextTuple6_53(GetCppThis(), val0, val1, val2, val3, val4, val5);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_InsertNextTuple9_54(HandleRef pThis, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// InsertTuple() which takes arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public void InsertNextTuple9(double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
	{
		vtkDataArray_InsertNextTuple9_54(GetCppThis(), val0, val1, val2, val3, val4, val5, val6, val7, val8);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_InsertTuple_55(HandleRef pThis, long dstTupleIdx, long srcTupleIdx, HandleRef source);

	/// <summary>
	/// See documentation from parent class.
	/// This method assumes that the `source` inherits from `vtkDataArray`, but its value type doesn't
	/// have to match the type of the current instance.
	/// </summary>
	public override void InsertTuple(long dstTupleIdx, long srcTupleIdx, vtkAbstractArray source)
	{
		vtkDataArray_InsertTuple_55(GetCppThis(), dstTupleIdx, srcTupleIdx, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_InsertTuple_56(HandleRef pThis, long tupleIdx, IntPtr tuple);

	/// <summary>
	/// Insert the data tuple at tupleIdx. Note that memory allocation
	/// is performed as necessary to hold the data.
	/// </summary>
	public virtual void InsertTuple(long tupleIdx, IntPtr tuple)
	{
		vtkDataArray_InsertTuple_56(GetCppThis(), tupleIdx, tuple);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_InsertTuple1_57(HandleRef pThis, long tupleIdx, double value);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// InsertTuple() which takes arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public void InsertTuple1(long tupleIdx, double value)
	{
		vtkDataArray_InsertTuple1_57(GetCppThis(), tupleIdx, value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_InsertTuple2_58(HandleRef pThis, long tupleIdx, double val0, double val1);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// InsertTuple() which takes arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public void InsertTuple2(long tupleIdx, double val0, double val1)
	{
		vtkDataArray_InsertTuple2_58(GetCppThis(), tupleIdx, val0, val1);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_InsertTuple3_59(HandleRef pThis, long tupleIdx, double val0, double val1, double val2);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// InsertTuple() which takes arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public void InsertTuple3(long tupleIdx, double val0, double val1, double val2)
	{
		vtkDataArray_InsertTuple3_59(GetCppThis(), tupleIdx, val0, val1, val2);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_InsertTuple4_60(HandleRef pThis, long tupleIdx, double val0, double val1, double val2, double val3);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// InsertTuple() which takes arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public void InsertTuple4(long tupleIdx, double val0, double val1, double val2, double val3)
	{
		vtkDataArray_InsertTuple4_60(GetCppThis(), tupleIdx, val0, val1, val2, val3);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_InsertTuple6_61(HandleRef pThis, long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// InsertTuple() which takes arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public void InsertTuple6(long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5)
	{
		vtkDataArray_InsertTuple6_61(GetCppThis(), tupleIdx, val0, val1, val2, val3, val4, val5);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_InsertTuple9_62(HandleRef pThis, long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// InsertTuple() which takes arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public void InsertTuple9(long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
	{
		vtkDataArray_InsertTuple9_62(GetCppThis(), tupleIdx, val0, val1, val2, val3, val4, val5, val6, val7, val8);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_InsertTuples_63(HandleRef pThis, HandleRef dstIds, HandleRef srcIds, HandleRef source);

	/// <summary>
	/// See documentation from parent class.
	/// This method assumes that the `source` inherits from `vtkDataArray`, but its value type doesn't
	/// have to match the type of the current instance.
	/// </summary>
	public override void InsertTuples(vtkIdList dstIds, vtkIdList srcIds, vtkAbstractArray source)
	{
		vtkDataArray_InsertTuples_63(GetCppThis(), dstIds?.GetCppThis() ?? default(HandleRef), srcIds?.GetCppThis() ?? default(HandleRef), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_InsertTuples_64(HandleRef pThis, long dstStart, long n, long srcStart, HandleRef source);

	/// <summary>
	/// See documentation from parent class.
	/// This method assumes that the `source` inherits from `vtkDataArray`, but its value type doesn't
	/// have to match the type of the current instance.
	/// </summary>
	public override void InsertTuples(long dstStart, long n, long srcStart, vtkAbstractArray source)
	{
		vtkDataArray_InsertTuples_64(GetCppThis(), dstStart, n, srcStart, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_InsertTuplesStartingAt_65(HandleRef pThis, long dstStart, HandleRef srcIds, HandleRef source);

	/// <summary>
	/// See documentation from parent class.
	/// This method assumes that the `source` inherits from `vtkDataArray`, but its value type doesn't
	/// have to match the type of the current instance.
	/// </summary>
	public override void InsertTuplesStartingAt(long dstStart, vtkIdList srcIds, vtkAbstractArray source)
	{
		vtkDataArray_InsertTuplesStartingAt_65(GetCppThis(), dstStart, srcIds?.GetCppThis() ?? default(HandleRef), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_InterpolateTuple_66(HandleRef pThis, long dstTupleIdx, HandleRef ptIndices, HandleRef source, IntPtr weights);

	/// <summary>
	/// See documentation from parent class.
	/// This method assumes that the `source` inherits from `vtkDataArray`, but its value type doesn't
	/// have to match the type of the current instance.
	/// </summary>
	public override void InterpolateTuple(long dstTupleIdx, vtkIdList ptIndices, vtkAbstractArray source, IntPtr weights)
	{
		vtkDataArray_InterpolateTuple_66(GetCppThis(), dstTupleIdx, ptIndices?.GetCppThis() ?? default(HandleRef), source?.GetCppThis() ?? default(HandleRef), weights);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_InterpolateTuple_67(HandleRef pThis, long dstTupleIdx, long srcTupleIdx1, HandleRef source1, long srcTupleIdx2, HandleRef source2, double t);

	/// <summary>
	/// See documentation from parent class.
	/// This method assumes that the `source` inherits from `vtkDataArray`, but its value type doesn't
	/// have to match the type of the current instance.
	/// </summary>
	public override void InterpolateTuple(long dstTupleIdx, long srcTupleIdx1, vtkAbstractArray source1, long srcTupleIdx2, vtkAbstractArray source2, double t)
	{
		vtkDataArray_InterpolateTuple_67(GetCppThis(), dstTupleIdx, srcTupleIdx1, source1?.GetCppThis() ?? default(HandleRef), srcTupleIdx2, source2?.GetCppThis() ?? default(HandleRef), t);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataArray_IsA_68(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataArray_IsA_68(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataArray_IsNumeric_69(HandleRef pThis);

	/// <summary>
	/// This method is here to make backward compatibility easier.  It
	/// must return true if and only if an array contains numeric data.
	/// All vtkDataArray subclasses contain numeric data, hence this method
	/// always returns 1(true).
	/// </summary>
	public override int IsNumeric()
	{
		return vtkDataArray_IsNumeric_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataArray_IsTypeOf_70(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataArray_IsTypeOf_70(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArray_L2_NORM_FINITE_RANGE_71(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This key is used to hold tight bounds on the $L_2$ norm
	/// of tuples in the array.
	/// Two values (a minimum and maximum) are stored for each component.
	/// When GetFiniteRange() is called when no tuples are present in the array
	/// this value is set to { VTK_DOUBLE_MAX, VTK_DOUBLE_MIN }.
	/// </summary>
	public static vtkInformationDoubleVectorKey L2_NORM_FINITE_RANGE()
	{
		vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataArray_L2_NORM_FINITE_RANGE_71(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataArray_L2_NORM_RANGE_72(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This key is used to hold tight bounds on the $L_2$ norm
	/// of tuples in the array.
	/// Two values (a minimum and maximum) are stored for each component.
	/// When GetRange() is called when no tuples are present in the array
	/// this value is set to { VTK_DOUBLE_MAX, VTK_DOUBLE_MIN }.
	/// </summary>
	public static vtkInformationDoubleVectorKey L2_NORM_RANGE()
	{
		vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataArray_L2_NORM_RANGE_72(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDataArray_Modified_73(HandleRef pThis);

	/// <summary>
	/// Removes out-of-date L2_NORM_RANGE() and L2_NORM_FINITE_RANGE() values.
	/// </summary>
	public override void Modified()
	{
		vtkDataArray_Modified_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArray_NewInstance_74(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDataArray NewInstance()
	{
		vtkDataArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataArray_NewInstance_74(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_RemoveFirstTuple_75(HandleRef pThis);

	/// <summary>
	/// These methods remove tuples from the data array. They shift data and
	/// resize array, so the data array is still valid after this operation. Note,
	/// this operation is fairly slow.
	/// </summary>
	public virtual void RemoveFirstTuple()
	{
		vtkDataArray_RemoveFirstTuple_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_RemoveLastTuple_76(HandleRef pThis);

	/// <summary>
	/// These methods remove tuples from the data array. They shift data and
	/// resize array, so the data array is still valid after this operation. Note,
	/// this operation is fairly slow.
	/// </summary>
	public virtual void RemoveLastTuple()
	{
		vtkDataArray_RemoveLastTuple_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_RemoveTuple_77(HandleRef pThis, long tupleIdx);

	/// <summary>
	/// These methods remove tuples from the data array. They shift data and
	/// resize array, so the data array is still valid after this operation. Note,
	/// this operation is fairly slow.
	/// </summary>
	public virtual void RemoveTuple(long tupleIdx)
	{
		vtkDataArray_RemoveTuple_77(GetCppThis(), tupleIdx);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArray_SafeDownCast_78(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataArray SafeDownCast(vtkObjectBase o)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataArray_SafeDownCast_78(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_SetComponent_79(HandleRef pThis, long tupleIdx, int compIdx, double value);

	/// <summary>
	/// Set the data component at the location specified by tupleIdx and compIdx
	/// to value.
	/// Note that i is less than NumberOfTuples and j is less than
	/// NumberOfComponents. Make sure enough memory has been allocated
	/// (use SetNumberOfTuples() and SetNumberOfComponents()).
	/// </summary>
	public virtual void SetComponent(long tupleIdx, int compIdx, double value)
	{
		vtkDataArray_SetComponent_79(GetCppThis(), tupleIdx, compIdx, value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_SetLookupTable_80(HandleRef pThis, HandleRef lut);

	/// <summary>
	/// Set/get the lookup table associated with this scalar data, if any.
	/// </summary>
	public void SetLookupTable(vtkLookupTable lut)
	{
		vtkDataArray_SetLookupTable_80(GetCppThis(), lut?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_SetTuple_81(HandleRef pThis, long dstTupleIdx, long srcTupleIdx, HandleRef source);

	/// <summary>
	/// See documentation from parent class.
	/// This method assumes that the `source` inherits from `vtkDataArray`, but its value type doesn't
	/// have to match the type of the current instance.
	/// </summary>
	public override void SetTuple(long dstTupleIdx, long srcTupleIdx, vtkAbstractArray source)
	{
		vtkDataArray_SetTuple_81(GetCppThis(), dstTupleIdx, srcTupleIdx, source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_SetTuple_82(HandleRef pThis, long tupleIdx, IntPtr tuple);

	/// <summary>
	/// Set the data tuple at tupleIdx. Note that range checking or
	/// memory allocation is not performed; use this method in conjunction
	/// with SetNumberOfTuples() to allocate space.
	/// </summary>
	public virtual void SetTuple(long tupleIdx, IntPtr tuple)
	{
		vtkDataArray_SetTuple_82(GetCppThis(), tupleIdx, tuple);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_SetTuple1_83(HandleRef pThis, long tupleIdx, double value);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// GetTuple() and SetTuple() which return/take arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public void SetTuple1(long tupleIdx, double value)
	{
		vtkDataArray_SetTuple1_83(GetCppThis(), tupleIdx, value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_SetTuple2_84(HandleRef pThis, long tupleIdx, double val0, double val1);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// GetTuple() and SetTuple() which return/take arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public void SetTuple2(long tupleIdx, double val0, double val1)
	{
		vtkDataArray_SetTuple2_84(GetCppThis(), tupleIdx, val0, val1);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_SetTuple3_85(HandleRef pThis, long tupleIdx, double val0, double val1, double val2);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// GetTuple() and SetTuple() which return/take arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public void SetTuple3(long tupleIdx, double val0, double val1, double val2)
	{
		vtkDataArray_SetTuple3_85(GetCppThis(), tupleIdx, val0, val1, val2);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_SetTuple4_86(HandleRef pThis, long tupleIdx, double val0, double val1, double val2, double val3);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// GetTuple() and SetTuple() which return/take arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public void SetTuple4(long tupleIdx, double val0, double val1, double val2, double val3)
	{
		vtkDataArray_SetTuple4_86(GetCppThis(), tupleIdx, val0, val1, val2, val3);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_SetTuple6_87(HandleRef pThis, long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// GetTuple() and SetTuple() which return/take arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public void SetTuple6(long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5)
	{
		vtkDataArray_SetTuple6_87(GetCppThis(), tupleIdx, val0, val1, val2, val3, val4, val5);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_SetTuple9_88(HandleRef pThis, long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8);

	/// <summary>
	/// These methods are included as convenience for the wrappers.
	/// GetTuple() and SetTuple() which return/take arrays can not be
	/// used from wrapped languages. These methods can be used instead.
	/// </summary>
	public void SetTuple9(long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
	{
		vtkDataArray_SetTuple9_88(GetCppThis(), tupleIdx, val0, val1, val2, val3, val4, val5, val6, val7, val8);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArray_ShallowCopy_89(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Create a shallow copy of other into this, if possible. Shallow copies are
	/// only possible:
	/// (a) if both arrays are the same data type
	/// (b) if both arrays are the same array type (e.g. AOS vs. SOA)
	/// (c) if both arrays support shallow copies (e.g. vtkBitArray currently
	/// does not.)
	/// If a shallow copy is not possible, a deep copy will be performed instead.
	/// </summary>
	public virtual void ShallowCopy(vtkDataArray other)
	{
		vtkDataArray_ShallowCopy_89(GetCppThis(), other?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArray_UNITS_LABEL_90(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// A human-readable string indicating the units for the array data.
	/// </summary>
	public static vtkInformationStringKey UNITS_LABEL()
	{
		vtkInformationStringKey vtkInformationStringKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataArray_UNITS_LABEL_90(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationStringKey2 = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationStringKey2.Register(null);
			}
		}
		return vtkInformationStringKey2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArray_WriteVoidPointer_91(HandleRef pThis, long valueIdx, long numValues);

	/// <summary>
	/// Get the address of a particular data index. Make sure data is allocated
	/// for the number of items requested. If needed, increase MaxId to mark any
	/// new value ranges as in-use.
	/// </summary>
	public virtual IntPtr WriteVoidPointer(long valueIdx, long numValues)
	{
		return vtkDataArray_WriteVoidPointer_91(GetCppThis(), valueIdx, numValues);
	}
}
