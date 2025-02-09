using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPriorityQueue
/// </summary>
/// <remarks>
///    a list of ids arranged in priority order
///
/// vtkPriorityQueue is a general object for creating and manipulating lists
/// of object ids (e.g., point or cell ids). Object ids are sorted according
/// to a user-specified priority, where entries at the top of the queue have
/// the smallest values.
///
/// This implementation provides a feature beyond the usual ability to insert
/// and retrieve (or pop) values from the queue. It is also possible to
/// pop any item in the queue given its id number. This allows you to delete
/// entries in the queue which can useful for reinserting an item into the
/// queue.
///
/// @warning
/// This implementation is a variation of the priority queue described in
/// "Data Structures &amp; Algorithms" by Aho, Hopcroft, Ullman. It creates
/// a balanced, partially ordered binary tree implemented as an ordered
/// array. This avoids the overhead associated with parent/child pointers,
/// and frequent memory allocation and deallocation.
/// </remarks>
public class vtkPriorityQueue : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPriorityQueue";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPriorityQueue()
	{
		MRClassNameKey = "class vtkPriorityQueue";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPriorityQueue"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPriorityQueue(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPriorityQueue_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate priority queue with default size and extension size of 1000.
	/// </summary>
	public new static vtkPriorityQueue New()
	{
		vtkPriorityQueue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPriorityQueue_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPriorityQueue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate priority queue with default size and extension size of 1000.
	/// </summary>
	public vtkPriorityQueue()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPriorityQueue_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPriorityQueue_Allocate_01(HandleRef pThis, long sz, long ext);

	/// <summary>
	/// Allocate initial space for priority queue.
	/// </summary>
	public void Allocate(long sz, long ext)
	{
		vtkPriorityQueue_Allocate_01(GetCppThis(), sz, ext);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPriorityQueue_DeleteId_02(HandleRef pThis, long id);

	/// <summary>
	/// Delete entry in queue with specified id. Returns priority value
	/// associated with that id; or VTK_DOUBLE_MAX if not in queue.
	/// </summary>
	public double DeleteId(long id)
	{
		return vtkPriorityQueue_DeleteId_02(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPriorityQueue_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate priority queue with default size and extension size of 1000.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPriorityQueue_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPriorityQueue_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Instantiate priority queue with default size and extension size of 1000.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPriorityQueue_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPriorityQueue_GetNumberOfItems_05(HandleRef pThis);

	/// <summary>
	/// Return the number of items in this queue.
	/// </summary>
	public long GetNumberOfItems()
	{
		return vtkPriorityQueue_GetNumberOfItems_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPriorityQueue_GetPriority_06(HandleRef pThis, long id);

	/// <summary>
	/// Get the priority of an entry in the queue with specified id. Returns
	/// priority value of that id or VTK_DOUBLE_MAX if not in queue.
	/// </summary>
	public double GetPriority(long id)
	{
		return vtkPriorityQueue_GetPriority_06(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPriorityQueue_Insert_07(HandleRef pThis, double priority, long id);

	/// <summary>
	/// Insert id with priority specified. The id is generally an
	/// index like a point id or cell id.
	/// </summary>
	public void Insert(double priority, long id)
	{
		vtkPriorityQueue_Insert_07(GetCppThis(), priority, id);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPriorityQueue_IsA_08(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate priority queue with default size and extension size of 1000.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPriorityQueue_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPriorityQueue_IsTypeOf_09(string type);

	/// <summary>
	/// Instantiate priority queue with default size and extension size of 1000.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPriorityQueue_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPriorityQueue_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate priority queue with default size and extension size of 1000.
	/// </summary>
	public new vtkPriorityQueue NewInstance()
	{
		vtkPriorityQueue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPriorityQueue_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPriorityQueue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPriorityQueue_Peek_12(HandleRef pThis, long location, ref double priority);

	/// <summary>
	/// Peek into the queue without actually removing anything. Returns the
	/// id and the priority.
	/// </summary>
	public long Peek(long location, ref double priority)
	{
		return vtkPriorityQueue_Peek_12(GetCppThis(), location, ref priority);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPriorityQueue_Peek_13(HandleRef pThis, long location);

	/// <summary>
	/// Peek into the queue without actually removing anything. Returns the
	/// id.
	/// </summary>
	public long Peek(long location)
	{
		return vtkPriorityQueue_Peek_13(GetCppThis(), location);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPriorityQueue_Pop_14(HandleRef pThis, long location, ref double priority);

	/// <summary>
	/// Removes item at specified location from tree; then reorders and
	/// balances tree. The location == 0 is the root of the tree. If queue
	/// is exhausted, then a value &lt; 0 is returned. (Note: the location
	/// is not the same as deleting an id; id is mapped to location.)
	/// </summary>
	public long Pop(long location, ref double priority)
	{
		return vtkPriorityQueue_Pop_14(GetCppThis(), location, ref priority);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPriorityQueue_Pop_15(HandleRef pThis, long location);

	/// <summary>
	/// Same as above but simplified for easier wrapping into interpreted
	/// languages.
	/// </summary>
	public long Pop(long location)
	{
		return vtkPriorityQueue_Pop_15(GetCppThis(), location);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPriorityQueue_Reset_16(HandleRef pThis);

	/// <summary>
	/// Empty the queue but without releasing memory. This avoids the
	/// overhead of memory allocation/deletion.
	/// </summary>
	public void Reset()
	{
		vtkPriorityQueue_Reset_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPriorityQueue_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate priority queue with default size and extension size of 1000.
	/// </summary>
	public new static vtkPriorityQueue SafeDownCast(vtkObjectBase o)
	{
		vtkPriorityQueue vtkPriorityQueue2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPriorityQueue_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPriorityQueue2 = (vtkPriorityQueue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPriorityQueue2.Register(null);
			}
		}
		return vtkPriorityQueue2;
	}
}
