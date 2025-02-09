using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVoidArray
/// </summary>
/// <remarks>
///    dynamic, self-adjusting array of void* pointers
///
/// vtkVoidArray is an array of pointers to void. It provides methods
/// for insertion and retrieval of these pointers values, and will
/// automatically resize itself to hold new data.
/// </remarks>
public class vtkVoidArray : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVoidArray";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVoidArray()
	{
		MRClassNameKey = "class vtkVoidArray";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVoidArray"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVoidArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoidArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Initialize with empty array.
	/// </summary>
	public new static vtkVoidArray New()
	{
		vtkVoidArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoidArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVoidArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Initialize with empty array.
	/// </summary>
	public vtkVoidArray()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVoidArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkVoidArray_Allocate_01(HandleRef pThis, long sz, long ext);

	/// <summary>
	/// Allocate memory for this array. Delete old storage only if necessary.
	/// Note that the parameter ext is no longer used.
	/// </summary>
	public int Allocate(long sz, long ext)
	{
		return vtkVoidArray_Allocate_01(GetCppThis(), sz, ext);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoidArray_DeepCopy_02(HandleRef pThis, HandleRef va);

	/// <summary>
	/// Deep copy of another void array.
	/// </summary>
	public void DeepCopy(vtkVoidArray va)
	{
		vtkVoidArray_DeepCopy_02(GetCppThis(), va?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoidArray_ExtendedNew_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Initialize with empty array.
	/// </summary>
	public static vtkVoidArray ExtendedNew()
	{
		vtkVoidArray vtkVoidArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoidArray_ExtendedNew_03(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVoidArray2 = (vtkVoidArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVoidArray2.Register(null);
			}
		}
		return vtkVoidArray2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoidArray_GetDataType_04(HandleRef pThis);

	/// <summary>
	/// Return the type of data.
	/// </summary>
	public int GetDataType()
	{
		return vtkVoidArray_GetDataType_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoidArray_GetDataTypeSize_05(HandleRef pThis);

	/// <summary>
	/// Return the size of the data contained in the array.
	/// </summary>
	public int GetDataTypeSize()
	{
		return vtkVoidArray_GetDataTypeSize_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVoidArray_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Initialize with empty array.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVoidArray_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVoidArray_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Initialize with empty array.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVoidArray_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVoidArray_GetNumberOfPointers_08(HandleRef pThis);

	/// <summary>
	/// Get the number of void* pointers held in the array.
	/// </summary>
	public long GetNumberOfPointers()
	{
		return vtkVoidArray_GetNumberOfPointers_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoidArray_GetVoidPointer_09(HandleRef pThis, long id);

	/// <summary>
	/// Get the void* pointer at the ith location.
	/// </summary>
	public IntPtr GetVoidPointer(long id)
	{
		return vtkVoidArray_GetVoidPointer_09(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoidArray_Initialize_10(HandleRef pThis);

	/// <summary>
	/// Release storage and reset array to initial state.
	/// </summary>
	public void Initialize()
	{
		vtkVoidArray_Initialize_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVoidArray_InsertNextVoidPointer_11(HandleRef pThis, IntPtr tuple);

	/// <summary>
	/// Insert (memory allocation performed) the void* pointer at the
	/// end of the array.
	/// </summary>
	public long InsertNextVoidPointer(IntPtr tuple)
	{
		return vtkVoidArray_InsertNextVoidPointer_11(GetCppThis(), tuple);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoidArray_InsertVoidPointer_12(HandleRef pThis, long i, IntPtr ptr);

	/// <summary>
	/// Insert (memory allocation performed) the void* into the ith location
	/// in the array.
	/// </summary>
	public void InsertVoidPointer(long i, IntPtr ptr)
	{
		vtkVoidArray_InsertVoidPointer_12(GetCppThis(), i, ptr);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoidArray_IsA_13(HandleRef pThis, string type);

	/// <summary>
	/// Initialize with empty array.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVoidArray_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoidArray_IsTypeOf_14(string type);

	/// <summary>
	/// Initialize with empty array.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVoidArray_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoidArray_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Initialize with empty array.
	/// </summary>
	public new vtkVoidArray NewInstance()
	{
		vtkVoidArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoidArray_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVoidArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoidArray_Reset_17(HandleRef pThis);

	/// <summary>
	/// Reuse already allocated data; make the container look like it is
	/// empty.
	/// </summary>
	public void Reset()
	{
		vtkVoidArray_Reset_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoidArray_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Initialize with empty array.
	/// </summary>
	public new static vtkVoidArray SafeDownCast(vtkObjectBase o)
	{
		vtkVoidArray vtkVoidArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoidArray_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVoidArray2 = (vtkVoidArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVoidArray2.Register(null);
			}
		}
		return vtkVoidArray2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoidArray_SetNumberOfPointers_19(HandleRef pThis, long number);

	/// <summary>
	/// Set the number of void* pointers held in the array.
	/// </summary>
	public void SetNumberOfPointers(long number)
	{
		vtkVoidArray_SetNumberOfPointers_19(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoidArray_SetVoidPointer_20(HandleRef pThis, long id, IntPtr ptr);

	/// <summary>
	/// Set the void* pointer value at the ith location in the array.
	/// </summary>
	public void SetVoidPointer(long id, IntPtr ptr)
	{
		vtkVoidArray_SetVoidPointer_20(GetCppThis(), id, ptr);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoidArray_Squeeze_21(HandleRef pThis);

	/// <summary>
	/// Resize the array to just fit the inserted memory. Reclaims extra memory.
	/// </summary>
	public void Squeeze()
	{
		vtkVoidArray_Squeeze_21(GetCppThis());
	}
}
