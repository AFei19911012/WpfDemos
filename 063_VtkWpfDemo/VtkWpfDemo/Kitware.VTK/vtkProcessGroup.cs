using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProcessGroup
/// </summary>
/// <remarks>
///    A subgroup of processes from a communicator.
///
///
///
/// This class is used for creating groups of processes.  A vtkProcessGroup is
/// initialized by passing the controller or communicator on which the group is
/// based off of.  You can then use the group to subset and reorder the
/// processes.  Eventually, you can pass the group object to the
/// CreateSubController method of vtkMultiProcessController to create a
/// controller for the defined group of processes.  You must use the same
/// controller (or attached communicator) from which this group was initialized
/// with.
///
/// </remarks>
/// <seealso>
///
/// vtkMultiProcessController, vtkCommunicator
///
/// @par Thanks:
/// This class was originally written by Kenneth Moreland (kmorelndia.gov)
/// from Sandia National Laboratories.
///
/// </seealso>
public class vtkProcessGroup : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProcessGroup";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProcessGroup()
	{
		MRClassNameKey = "class vtkProcessGroup";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProcessGroup"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProcessGroup(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProcessGroup_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProcessGroup New()
	{
		vtkProcessGroup result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProcessGroup_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProcessGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkProcessGroup()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProcessGroup_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkProcessGroup_AddProcessId_01(HandleRef pThis, int processId);

	/// <summary>
	/// Add a process id to the end of the group (if it is not already in the
	/// group).  Returns the location where the id was stored.
	/// </summary>
	public int AddProcessId(int processId)
	{
		return vtkProcessGroup_AddProcessId_01(GetCppThis(), processId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProcessGroup_Copy_02(HandleRef pThis, HandleRef group);

	/// <summary>
	/// Copies the given group's communicator and process ids.
	/// </summary>
	public void Copy(vtkProcessGroup group)
	{
		vtkProcessGroup_Copy_02(GetCppThis(), group?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProcessGroup_FindProcessId_03(HandleRef pThis, int processId);

	/// <summary>
	/// Given a process id in the communicator, this method returns its location in
	/// the group or -1 if it is not in the group.  For example, if this group
	/// contains {6, 2, 8, 1}, then FindProcessId(2) will return 1 and
	/// FindProcessId(3) will return -1.
	/// </summary>
	public int FindProcessId(int processId)
	{
		return vtkProcessGroup_FindProcessId_03(GetCppThis(), processId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProcessGroup_GetCommunicator_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the communicator on which this group is based on.
	/// </summary>
	public virtual vtkCommunicator GetCommunicator()
	{
		vtkCommunicator vtkCommunicator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProcessGroup_GetCommunicator_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCommunicator2 = (vtkCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCommunicator2.Register(null);
			}
		}
		return vtkCommunicator2;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProcessGroup_GetLocalProcessId_05(HandleRef pThis);

	/// <summary>
	/// Get the process id for the local process (as defined by the group's
	/// communicator).  Returns -1 if the local process is not in the group.
	/// </summary>
	public int GetLocalProcessId()
	{
		return vtkProcessGroup_GetLocalProcessId_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProcessGroup_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProcessGroup_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProcessGroup_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProcessGroup_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProcessGroup_GetNumberOfProcessIds_08(HandleRef pThis);

	/// <summary>
	/// Returns the size of this group (the number of processes defined in it).
	/// </summary>
	public virtual int GetNumberOfProcessIds()
	{
		return vtkProcessGroup_GetNumberOfProcessIds_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProcessGroup_GetProcessId_09(HandleRef pThis, int pos);

	/// <summary>
	/// Given a position in the group, returns the id of the process in the
	/// communicator this group is based on.  For example, if this group contains
	/// {6, 2, 8, 1}, then GetProcessId(2) will return 8 and GetProcessId(3) will
	/// return 1.
	/// </summary>
	public int GetProcessId(int pos)
	{
		return vtkProcessGroup_GetProcessId_09(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProcessGroup_Initialize_10(HandleRef pThis, HandleRef controller);

	/// <summary>
	/// Initialize the group to the given controller or communicator.  The group
	/// will be set to contain all of the processes in the controller/communicator
	/// in the same order.
	/// </summary>
	public void Initialize(vtkMultiProcessController controller)
	{
		vtkProcessGroup_Initialize_10(GetCppThis(), controller?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProcessGroup_Initialize_11(HandleRef pThis, HandleRef communicator);

	/// <summary>
	/// Initialize the group to the given controller or communicator.  The group
	/// will be set to contain all of the processes in the controller/communicator
	/// in the same order.
	/// </summary>
	public void Initialize(vtkCommunicator communicator)
	{
		vtkProcessGroup_Initialize_11(GetCppThis(), communicator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProcessGroup_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProcessGroup_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProcessGroup_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProcessGroup_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProcessGroup_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkProcessGroup NewInstance()
	{
		vtkProcessGroup result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProcessGroup_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProcessGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProcessGroup_RemoveAllProcessIds_16(HandleRef pThis);

	/// <summary>
	/// Removes all the processes ids from the group, leaving the group empty.
	/// </summary>
	public void RemoveAllProcessIds()
	{
		vtkProcessGroup_RemoveAllProcessIds_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProcessGroup_RemoveProcessId_17(HandleRef pThis, int processId);

	/// <summary>
	/// Remove the given process id from the group (assuming it is in the group).
	/// All ids to the "right" of the removed id are shifted over.  Returns 1
	/// if the process id was removed, 0 if the process id was not in the group
	/// in the first place.
	/// </summary>
	public int RemoveProcessId(int processId)
	{
		return vtkProcessGroup_RemoveProcessId_17(GetCppThis(), processId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProcessGroup_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProcessGroup SafeDownCast(vtkObjectBase o)
	{
		vtkProcessGroup vtkProcessGroup2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProcessGroup_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProcessGroup2 = (vtkProcessGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProcessGroup2.Register(null);
			}
		}
		return vtkProcessGroup2;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProcessGroup_SetCommunicator_19(HandleRef pThis, HandleRef communicator);

	/// <summary>
	/// Set the communicator.  This has the same effect as Initialize except that
	/// the contents of the group will not be modified (although they may be
	/// truncated if the new communicator is smaller than the current group).
	/// Note that this can lead to an invalid group if there are values in the
	/// group that are not valid in the new communicator.
	/// </summary>
	public void SetCommunicator(vtkCommunicator communicator)
	{
		vtkProcessGroup_SetCommunicator_19(GetCppThis(), communicator?.GetCppThis() ?? default(HandleRef));
	}
}
