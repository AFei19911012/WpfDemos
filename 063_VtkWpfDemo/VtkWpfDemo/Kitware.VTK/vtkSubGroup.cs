using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSubGroup
/// </summary>
/// <remarks>
///    scalable collective communication for a
///      subset of members of a parallel VTK application
///
///
///     This class provides scalable broadcast, reduce, etc. using
///     only a vtkMultiProcessController. It does not require MPI.
///     Users are vtkPKdTree and vtkDistributedDataFilter.
///
/// @attention
/// This class will be deprecated soon.  Instead of using this class, use the
/// collective and subgrouping operations now built into
/// vtkMultiProcessController.  The only reason this class is not deprecated
/// already is because vtkPKdTree relies heavily on this class in ways that are
/// not easy to work around.  Since vtkPKdTree is due for a major overhaul
/// anyway, we are leaving things the way they are for now.
///
/// </remarks>
/// <seealso>
///
///      vtkPKdTree vtkDistributedDataFilter
/// </seealso>
public class vtkSubGroup : vtkObject
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum MAXOP_WrapperEnum
	{
		/// <summary>enum member</summary>
		MAXOP = 2,
		/// <summary>enum member</summary>
		MINOP = 1,
		/// <summary>enum member</summary>
		SUMOP = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSubGroup";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSubGroup()
	{
		MRClassNameKey = "class vtkSubGroup";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSubGroup"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSubGroup(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSubGroup_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSubGroup New()
	{
		vtkSubGroup result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSubGroup_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSubGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSubGroup()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSubGroup_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubGroup_Barrier_01(HandleRef pThis);

	/// <summary>
	/// Initialize a communication subgroup for the processes
	/// with rank p0 through p1 of the given communicator.  (So
	/// vtkSubGroup is limited to working with subgroups that
	/// are identified by a contiguous set of rank IDs.)
	/// The third argument is the callers rank, which must
	/// in the range from p0 through p1.
	/// </summary>
	public int Barrier()
	{
		return vtkSubGroup_Barrier_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubGroup_Broadcast_02(HandleRef pThis, IntPtr data, int length, int root);

	/// <summary>
	/// Initialize a communication subgroup for the processes
	/// with rank p0 through p1 of the given communicator.  (So
	/// vtkSubGroup is limited to working with subgroups that
	/// are identified by a contiguous set of rank IDs.)
	/// The third argument is the callers rank, which must
	/// in the range from p0 through p1.
	/// </summary>
	public int Broadcast(IntPtr data, int length, int root)
	{
		return vtkSubGroup_Broadcast_02(GetCppThis(), data, length, root);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubGroup_Broadcast_03(HandleRef pThis, string data, int length, int root);

	/// <summary>
	/// Initialize a communication subgroup for the processes
	/// with rank p0 through p1 of the given communicator.  (So
	/// vtkSubGroup is limited to working with subgroups that
	/// are identified by a contiguous set of rank IDs.)
	/// The third argument is the callers rank, which must
	/// in the range from p0 through p1.
	/// </summary>
	public int Broadcast(string data, int length, int root)
	{
		return vtkSubGroup_Broadcast_03(GetCppThis(), data, length, root);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubGroup_Gather_04(HandleRef pThis, IntPtr data, IntPtr to, int length, int root);

	/// <summary>
	/// Initialize a communication subgroup for the processes
	/// with rank p0 through p1 of the given communicator.  (So
	/// vtkSubGroup is limited to working with subgroups that
	/// are identified by a contiguous set of rank IDs.)
	/// The third argument is the callers rank, which must
	/// in the range from p0 through p1.
	/// </summary>
	public int Gather(IntPtr data, IntPtr to, int length, int root)
	{
		return vtkSubGroup_Gather_04(GetCppThis(), data, to, length, root);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubGroup_Gather_05(HandleRef pThis, string data, string to, int length, int root);

	/// <summary>
	/// Initialize a communication subgroup for the processes
	/// with rank p0 through p1 of the given communicator.  (So
	/// vtkSubGroup is limited to working with subgroups that
	/// are identified by a contiguous set of rank IDs.)
	/// The third argument is the callers rank, which must
	/// in the range from p0 through p1.
	/// </summary>
	public int Gather(string data, string to, int length, int root)
	{
		return vtkSubGroup_Gather_05(GetCppThis(), data, to, length, root);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSubGroup_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSubGroup_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSubGroup_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSubGroup_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubGroup_Initialize_08(HandleRef pThis, int p0, int p1, int me, int tag, HandleRef c);

	/// <summary>
	/// Initialize a communication subgroup for the processes
	/// with rank p0 through p1 of the given communicator.  (So
	/// vtkSubGroup is limited to working with subgroups that
	/// are identified by a contiguous set of rank IDs.)
	/// The third argument is the callers rank, which must
	/// in the range from p0 through p1.
	/// </summary>
	public int Initialize(int p0, int p1, int me, int tag, vtkCommunicator c)
	{
		return vtkSubGroup_Initialize_08(GetCppThis(), p0, p1, me, tag, c?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubGroup_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSubGroup_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubGroup_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSubGroup_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSubGroup_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSubGroup NewInstance()
	{
		vtkSubGroup result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSubGroup_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSubGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSubGroup_PrintSubGroup_13(HandleRef pThis);

	/// <summary>
	/// Initialize a communication subgroup for the processes
	/// with rank p0 through p1 of the given communicator.  (So
	/// vtkSubGroup is limited to working with subgroups that
	/// are identified by a contiguous set of rank IDs.)
	/// The third argument is the callers rank, which must
	/// in the range from p0 through p1.
	/// </summary>
	public void PrintSubGroup()
	{
		vtkSubGroup_PrintSubGroup_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubGroup_ReduceMax_14(HandleRef pThis, IntPtr data, IntPtr to, int length, int root);

	/// <summary>
	/// Initialize a communication subgroup for the processes
	/// with rank p0 through p1 of the given communicator.  (So
	/// vtkSubGroup is limited to working with subgroups that
	/// are identified by a contiguous set of rank IDs.)
	/// The third argument is the callers rank, which must
	/// in the range from p0 through p1.
	/// </summary>
	public int ReduceMax(IntPtr data, IntPtr to, int length, int root)
	{
		return vtkSubGroup_ReduceMax_14(GetCppThis(), data, to, length, root);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubGroup_ReduceMin_15(HandleRef pThis, IntPtr data, IntPtr to, int length, int root);

	/// <summary>
	/// Initialize a communication subgroup for the processes
	/// with rank p0 through p1 of the given communicator.  (So
	/// vtkSubGroup is limited to working with subgroups that
	/// are identified by a contiguous set of rank IDs.)
	/// The third argument is the callers rank, which must
	/// in the range from p0 through p1.
	/// </summary>
	public int ReduceMin(IntPtr data, IntPtr to, int length, int root)
	{
		return vtkSubGroup_ReduceMin_15(GetCppThis(), data, to, length, root);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubGroup_ReduceSum_16(HandleRef pThis, IntPtr data, IntPtr to, int length, int root);

	/// <summary>
	/// Initialize a communication subgroup for the processes
	/// with rank p0 through p1 of the given communicator.  (So
	/// vtkSubGroup is limited to working with subgroups that
	/// are identified by a contiguous set of rank IDs.)
	/// The third argument is the callers rank, which must
	/// in the range from p0 through p1.
	/// </summary>
	public int ReduceSum(IntPtr data, IntPtr to, int length, int root)
	{
		return vtkSubGroup_ReduceSum_16(GetCppThis(), data, to, length, root);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSubGroup_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSubGroup SafeDownCast(vtkObjectBase o)
	{
		vtkSubGroup vtkSubGroup2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSubGroup_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSubGroup2 = (vtkSubGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSubGroup2.Register(null);
			}
		}
		return vtkSubGroup2;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSubGroup_getLocalRank_18(HandleRef pThis, int processID);

	/// <summary>
	/// Initialize a communication subgroup for the processes
	/// with rank p0 through p1 of the given communicator.  (So
	/// vtkSubGroup is limited to working with subgroups that
	/// are identified by a contiguous set of rank IDs.)
	/// The third argument is the callers rank, which must
	/// in the range from p0 through p1.
	/// </summary>
	public int getLocalRank(int processID)
	{
		return vtkSubGroup_getLocalRank_18(GetCppThis(), processID);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSubGroup_setGatherPattern_19(HandleRef pThis, int root, int length);

	/// <summary>
	/// Initialize a communication subgroup for the processes
	/// with rank p0 through p1 of the given communicator.  (So
	/// vtkSubGroup is limited to working with subgroups that
	/// are identified by a contiguous set of rank IDs.)
	/// The third argument is the callers rank, which must
	/// in the range from p0 through p1.
	/// </summary>
	public void setGatherPattern(int root, int length)
	{
		vtkSubGroup_setGatherPattern_19(GetCppThis(), root, length);
	}
}
