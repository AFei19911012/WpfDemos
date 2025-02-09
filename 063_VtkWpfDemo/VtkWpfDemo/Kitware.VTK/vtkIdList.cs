using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkIdList
/// </summary>
/// <remarks>
///    list of point or cell ids
///
/// vtkIdList is used to represent and pass data id's between
/// objects. vtkIdList may represent any type of integer id, but
/// usually represents point and cell ids.
/// </remarks>
public class vtkIdList : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkIdList";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkIdList()
	{
		MRClassNameKey = "class vtkIdList";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkIdList"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkIdList(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIdList_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkIdList New()
	{
		vtkIdList result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIdList_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIdList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public vtkIdList()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkIdList_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkIdList_Allocate_01(HandleRef pThis, long sz, int strategy);

	/// <summary>
	/// Allocate a capacity for sz ids in the list and
	/// set the number of stored ids in the list to 0.
	/// strategy is not used.
	/// </summary>
	public int Allocate(long sz, int strategy)
	{
		return vtkIdList_Allocate_01(GetCppThis(), sz, strategy);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdList_DeepCopy_02(HandleRef pThis, HandleRef ids);

	/// <summary>
	/// Copy an id list by explicitly copying the internal array.
	/// </summary>
	public void DeepCopy(vtkIdList ids)
	{
		vtkIdList_DeepCopy_02(GetCppThis(), ids?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdList_DeleteId_03(HandleRef pThis, long vtkid);

	/// <summary>
	/// Delete specified id from list. Will remove all occurrences of id in list.
	/// </summary>
	public void DeleteId(long vtkid)
	{
		vtkIdList_DeleteId_03(GetCppThis(), vtkid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdList_Fill_04(HandleRef pThis, long value);

	/// <summary>
	/// Fill the ids with the input value. This method uses
	/// vtkSMPTools::Fill() so it can be sped up if built properly.
	/// </summary>
	public void Fill(long value)
	{
		vtkIdList_Fill_04(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIdList_FindIdLocation_05(HandleRef pThis, long id);

	/// <summary>
	/// Find the location i of the provided id.
	/// </summary>
	public long FindIdLocation(long id)
	{
		return vtkIdList_FindIdLocation_05(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIdList_GetId_06(HandleRef pThis, long i);

	/// <summary>
	/// Return the id at location i.
	/// </summary>
	public long GetId(long i)
	{
		return vtkIdList_GetId_06(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIdList_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkIdList_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIdList_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkIdList_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIdList_GetNumberOfIds_09(HandleRef pThis);

	/// <summary>
	/// Return the number of id's in the list.
	/// </summary>
	public long GetNumberOfIds()
	{
		return vtkIdList_GetNumberOfIds_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIdList_GetPointer_10(HandleRef pThis, long i);

	/// <summary>
	/// Get a pointer to a particular data index.
	/// </summary>
	public IntPtr GetPointer(long i)
	{
		return vtkIdList_GetPointer_10(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdList_Initialize_11(HandleRef pThis);

	/// <summary>
	/// Release memory and restore to unallocated state.
	/// </summary>
	public void Initialize()
	{
		vtkIdList_Initialize_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdList_InsertId_12(HandleRef pThis, long i, long vtkid);

	/// <summary>
	/// Set the id at location i. Does range checking and allocates memory
	/// as necessary.
	/// </summary>
	public void InsertId(long i, long vtkid)
	{
		vtkIdList_InsertId_12(GetCppThis(), i, vtkid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIdList_InsertNextId_13(HandleRef pThis, long vtkid);

	/// <summary>
	/// Add the id specified to the end of the list. Range checking is performed.
	/// </summary>
	public long InsertNextId(long vtkid)
	{
		return vtkIdList_InsertNextId_13(GetCppThis(), vtkid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIdList_InsertUniqueId_14(HandleRef pThis, long vtkid);

	/// <summary>
	/// If id is not already in list, insert it and return location in
	/// list. Otherwise return just location in list.
	/// </summary>
	public long InsertUniqueId(long vtkid)
	{
		return vtkIdList_InsertUniqueId_14(GetCppThis(), vtkid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdList_IntersectWith_15(HandleRef pThis, HandleRef otherIds);

	/// <summary>
	/// Intersect this list with another vtkIdList. Updates current list according
	/// to result of intersection operation.
	/// </summary>
	public void IntersectWith(vtkIdList otherIds)
	{
		vtkIdList_IntersectWith_15(GetCppThis(), otherIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIdList_IsA_16(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkIdList_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIdList_IsId_17(HandleRef pThis, long vtkid);

	/// <summary>
	/// Return -1 if id specified is not contained in the list; otherwise return
	/// the position in the list.
	/// </summary>
	public long IsId(long vtkid)
	{
		return vtkIdList_IsId_17(GetCppThis(), vtkid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIdList_IsTypeOf_18(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkIdList_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIdList_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new vtkIdList NewInstance()
	{
		vtkIdList result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIdList_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIdList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIdList_Release_21(HandleRef pThis);

	/// <summary>
	/// This releases the ownership of the internal vtkIdType array and returns the
	/// pointer to it. The caller is responsible of calling `delete []` on the
	/// returned value. This vtkIdList will be set to initialized state after this
	/// call.
	/// </summary>
	public IntPtr Release()
	{
		return vtkIdList_Release_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdList_Reset_22(HandleRef pThis);

	/// <summary>
	/// Reset to an empty state but retain previously allocated memory.
	/// </summary>
	public void Reset()
	{
		vtkIdList_Reset_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIdList_Resize_23(HandleRef pThis, long sz);

	/// <summary>
	/// Adjust the size of the id list while maintaining its content (except
	/// when being truncated).
	/// </summary>
	public IntPtr Resize(long sz)
	{
		return vtkIdList_Resize_23(GetCppThis(), sz);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIdList_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkIdList SafeDownCast(vtkObjectBase o)
	{
		vtkIdList vtkIdList2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIdList_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdList2 = (vtkIdList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdList2.Register(null);
			}
		}
		return vtkIdList2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdList_SetArray_25(HandleRef pThis, IntPtr array, long size, byte save);

	/// <summary>
	/// Specify an array of vtkIdType to use as the id list. This replaces the
	/// underlying array. This instance of vtkIdList takes ownership of the
	/// array, meaning that it deletes it on destruction (using delete[]).
	/// </summary>
	public void SetArray(IntPtr array, long size, bool save)
	{
		vtkIdList_SetArray_25(GetCppThis(), array, size, (byte)(save ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdList_SetId_26(HandleRef pThis, long i, long vtkid);

	/// <summary>
	/// Set the id at location i. Doesn't do range checking so it's a bit
	/// faster than InsertId. Make sure you use SetNumberOfIds() to allocate
	/// memory prior to using SetId().
	/// </summary>
	public void SetId(long i, long vtkid)
	{
		vtkIdList_SetId_26(GetCppThis(), i, vtkid);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdList_SetNumberOfIds_27(HandleRef pThis, long number);

	/// <summary>
	/// Specify the number of ids for this object to hold. Does an
	/// allocation as well as setting the number of ids.
	/// </summary>
	public void SetNumberOfIds(long number)
	{
		vtkIdList_SetNumberOfIds_27(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdList_Sort_28(HandleRef pThis);

	/// <summary>
	/// Sort the ids in the list in ascending id order. This method uses
	/// vtkSMPTools::Sort() so it can be sped up if built properly.
	/// </summary>
	public void Sort()
	{
		vtkIdList_Sort_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIdList_Squeeze_29(HandleRef pThis);

	/// <summary>
	/// Free any unused memory.
	/// </summary>
	public void Squeeze()
	{
		vtkIdList_Squeeze_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIdList_WritePointer_30(HandleRef pThis, long i, long number);

	/// <summary>
	/// Get a pointer to a particular data index. Make sure data is allocated
	/// for the number of items requested. Set MaxId according to the number of
	/// data values requested.
	/// </summary>
	public IntPtr WritePointer(long i, long number)
	{
		return vtkIdList_WritePointer_30(GetCppThis(), i, number);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIdList_begin_31(HandleRef pThis);

	/// <summary>
	/// To support range-based `for` loops
	/// </summary>
	public IntPtr begin()
	{
		return vtkIdList_begin_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIdList_end_32(HandleRef pThis);

	/// <summary>
	/// To support range-based `for` loops
	/// </summary>
	public IntPtr end()
	{
		return vtkIdList_end_32(GetCppThis());
	}
}
