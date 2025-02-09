using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHeap
/// </summary>
/// <remarks>
///    replacement for malloc/free and new/delete
///
/// This class is a replacement for malloc/free and new/delete for software
/// that has inherent memory leak or performance problems. For example,
/// external software such as the PLY library (vtkPLY) and VRML importer
/// (vtkVRMLImporter) are often written with lots of malloc() calls but
/// without the corresponding free() invocations. The class
/// vtkOrderedTriangulator may create and delete millions of new/delete calls.
/// This class allows the overloading of the C++ new operator (or other memory
/// allocation requests) by using the method AllocateMemory(). Memory is
/// deleted with an invocation of CleanAll() (which deletes ALL memory; any
/// given memory allocation cannot be deleted). Note: a block size can be used
/// to control the size of each memory allocation. Requests for memory are
/// fulfilled from the block until the block runs out, then a new block is
/// created.
///
/// @warning
/// Do not use this class as a general replacement for system memory
/// allocation.  This class should be used only as a last resort if memory
/// leaks cannot be tracked down and eliminated by conventional means. Also,
/// deleting memory from vtkHeap is not supported. Only the deletion of
/// the entire heap is. (A Reset() method allows you to reuse previously
/// allocated memory.)
///
/// </remarks>
/// <seealso>
///
/// vtkVRMLImporter vtkPLY vtkOrderedTriangulator
/// </seealso>
public class vtkHeap : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHeap";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHeap()
	{
		MRClassNameKey = "class vtkHeap";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHeap"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHeap(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHeap_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHeap New()
	{
		vtkHeap result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHeap_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHeap)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkHeap()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkHeap_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHeap_AllocateMemory_01(HandleRef pThis, ulong n);

	/// <summary>
	/// Allocate the memory requested.
	/// </summary>
	public IntPtr AllocateMemory(ulong n)
	{
		return vtkHeap_AllocateMemory_01(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkHeap_GetBlockSize_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the size at which blocks are allocated. If a memory
	/// request is bigger than the block size, then that size
	/// will be allocated.
	/// </summary>
	public virtual ulong GetBlockSize()
	{
		return vtkHeap_GetBlockSize_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHeap_GetNumberOfAllocations_03(HandleRef pThis);

	/// <summary>
	/// Get the number of allocations thus far.
	/// </summary>
	public virtual int GetNumberOfAllocations()
	{
		return vtkHeap_GetNumberOfAllocations_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHeap_GetNumberOfBlocks_04(HandleRef pThis);

	/// <summary>
	/// Get the number of allocations thus far.
	/// </summary>
	public virtual int GetNumberOfBlocks()
	{
		return vtkHeap_GetNumberOfBlocks_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHeap_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHeap_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHeap_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHeap_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHeap_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHeap_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHeap_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHeap_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHeap_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHeap NewInstance()
	{
		vtkHeap result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHeap_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHeap)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHeap_Reset_11(HandleRef pThis);

	/// <summary>
	/// This methods resets the current allocation location
	/// back to the beginning of the heap. This allows
	/// reuse of previously allocated memory which may be
	/// beneficial to performance in many cases.
	/// </summary>
	public void Reset()
	{
		vtkHeap_Reset_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHeap_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHeap SafeDownCast(vtkObjectBase o)
	{
		vtkHeap vtkHeap2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHeap_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHeap2 = (vtkHeap)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHeap2.Register(null);
			}
		}
		return vtkHeap2;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHeap_SetBlockSize_13(HandleRef pThis, ulong arg0);

	/// <summary>
	/// Set/Get the size at which blocks are allocated. If a memory
	/// request is bigger than the block size, then that size
	/// will be allocated.
	/// </summary>
	public virtual void SetBlockSize(ulong arg0)
	{
		vtkHeap_SetBlockSize_13(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHeap_StringDup_14(HandleRef pThis, string str);

	/// <summary>
	/// Convenience method performs string duplication.
	/// </summary>
	public string StringDup(string str)
	{
		return Marshal.PtrToStringAnsi(vtkHeap_StringDup_14(GetCppThis(), str));
	}
}
