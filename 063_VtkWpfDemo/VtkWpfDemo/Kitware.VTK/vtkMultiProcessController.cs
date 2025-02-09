using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMultiProcessController
/// </summary>
/// <remarks>
///    Multiprocessing communication superclass
///
/// vtkMultiProcessController is used to control multiple processes
/// in a distributed computing environment. It has
/// methods for executing single/multiple method(s) on multiple processors,
/// triggering registered callbacks (Remote Methods) (AddRMI(), TriggerRMI())
/// and communication. Please note that the communication is done using
/// the communicator which is accessible to the user. Therefore it is
/// possible to get the communicator with GetCommunicator() and use
/// it to send and receive data. This is the encouraged communication method.
/// The internal (RMI) communications are done using a second internal
/// communicator (called RMICommunicator).
///
/// There are two modes for RMI communication: (1) Send/Receive mode and
/// (2) Broadcast (collective) mode. The Send/Receive mode arranges processes
/// in a binary tree using post-order traversal and propagates the RMI trigger
/// starting from the root (rank 0) to the children. It is commonly employed to
/// communicate between client/server over TCP. Although, the Send/Receive mode
/// can be employed transparently over TCP or MPI, it is not optimal for
/// triggering the RMIs on the satellite ranks. The Broadcast mode provides a
/// more desirable alternative, namely, it uses MPI_Broadcast for communication,
/// which is the nominal way of achieving this in an MPI context. The underlying
/// communication mode used for triggering RMIs is controlled by the
/// "BroadcastTriggerRMI" variable. Note, that mixing between the two modes
/// for RMI communication is not correct behavior. All processes within the
/// vtkMultiProcessController must use the same mode for triggering RMI.
///
/// </remarks>
/// <seealso>
///
/// vtkMPIController
/// vtkCommunicator vtkMPICommunicator
/// </seealso>
public abstract class vtkMultiProcessController : vtkObject
{
	/// <summary>
	/// Accessor to some default tags.
	/// </summary>
	public enum Consts
	{
		/// <summary>enum member</summary>
		ANY_SOURCE = -1,
		/// <summary>enum member</summary>
		INVALID_SOURCE = -2
	}

	/// <summary>
	/// Accessor to some default tags.
	/// </summary>
	public enum Errors
	{
		/// <summary>enum member</summary>
		RMI_ARG_ERROR = 2,
		/// <summary>enum member</summary>
		RMI_NO_ERROR = 0,
		/// <summary>enum member</summary>
		RMI_TAG_ERROR = 1
	}

	/// <summary>
	/// Accessor to some default tags.
	/// </summary>
	public enum Tags
	{
		/// <summary>enum member</summary>
		BREAK_RMI_TAG = 3,
		/// <summary>enum member</summary>
		RMI_ARG_TAG = 2,
		/// <summary>enum member</summary>
		RMI_TAG = 1,
		/// <summary>enum member</summary>
		XML_WRITER_DATA_INFO = 4
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMultiProcessController";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMultiProcessController()
	{
		MRClassNameKey = "class vtkMultiProcessController";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiProcessController"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMultiProcessController(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_AllGather_01(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length);

	/// <summary>
	/// Same as gather except that the result ends up on all processes.
	/// </summary>
	public int AllGather(IntPtr sendBuffer, IntPtr recvBuffer, long length)
	{
		return vtkMultiProcessController_AllGather_01(GetCppThis(), sendBuffer, recvBuffer, length);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_AllGather_02(HandleRef pThis, string sendBuffer, string recvBuffer, long length);

	/// <summary>
	/// Same as gather except that the result ends up on all processes.
	/// </summary>
	public int AllGather(string sendBuffer, string recvBuffer, long length)
	{
		return vtkMultiProcessController_AllGather_02(GetCppThis(), sendBuffer, recvBuffer, length);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_AllGather_03(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer);

	/// <summary>
	/// Same as gather except that the result ends up on all processes.
	/// </summary>
	public int AllGather(vtkDataArray sendBuffer, vtkDataArray recvBuffer)
	{
		return vtkMultiProcessController_AllGather_03(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_AllGatherV_04(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets);

	/// <summary>
	/// Same as GatherV except that the result is placed in all processes.
	/// </summary>
	public int AllGatherV(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets)
	{
		return vtkMultiProcessController_AllGatherV_04(GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_AllGatherV_05(HandleRef pThis, string sendBuffer, string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets);

	/// <summary>
	/// Same as GatherV except that the result is placed in all processes.
	/// </summary>
	public int AllGatherV(string sendBuffer, string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets)
	{
		return vtkMultiProcessController_AllGatherV_05(GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_AllGatherV_06(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, IntPtr recvLengths, IntPtr offsets);

	/// <summary>
	/// Same as GatherV except that the result is placed in all processes.
	/// </summary>
	public int AllGatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, IntPtr recvLengths, IntPtr offsets)
	{
		return vtkMultiProcessController_AllGatherV_06(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef), recvLengths, offsets);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_AllGatherV_07(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer);

	/// <summary>
	/// This special form of AllGatherV will automatically determine \c recvLengths
	/// and \c offsets to tightly pack the data in the \c recvBuffer in process
	/// order.  It will also resize \c recvBuffer in order to accommodate the
	/// incoming data (unlike the other GatherV variants).
	/// </summary>
	public int AllGatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer)
	{
		return vtkMultiProcessController_AllGatherV_07(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_AllReduce_08(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation);

	/// <summary>
	/// Same as Reduce except that the result is placed in all of the processes.
	/// </summary>
	public int AllReduce(IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation)
	{
		return vtkMultiProcessController_AllReduce_08(GetCppThis(), sendBuffer, recvBuffer, length, operation);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_AllReduce_09(HandleRef pThis, string sendBuffer, string recvBuffer, long length, int operation);

	/// <summary>
	/// Same as Reduce except that the result is placed in all of the processes.
	/// </summary>
	public int AllReduce(string sendBuffer, string recvBuffer, long length, int operation)
	{
		return vtkMultiProcessController_AllReduce_09(GetCppThis(), sendBuffer, recvBuffer, length, operation);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_AllReduce_10(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int operation);

	/// <summary>
	/// Same as Reduce except that the result is placed in all of the processes.
	/// </summary>
	public int AllReduce(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int operation)
	{
		return vtkMultiProcessController_AllReduce_10(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef), operation);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_AllReduce_11(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer);

	/// <summary>
	/// Convenience methods to reduce vtkDataArraySelection.
	/// </summary>
	public int AllReduce(vtkDataArraySelection sendBuffer, vtkDataArraySelection recvBuffer)
	{
		return vtkMultiProcessController_AllReduce_11(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_Barrier_12(HandleRef pThis);

	/// <summary>
	/// This method can be used to synchronize processes.
	/// </summary>
	public void Barrier()
	{
		vtkMultiProcessController_Barrier_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Broadcast_13(HandleRef pThis, IntPtr data, long length, int srcProcessId);

	/// <summary>
	/// Broadcast sends the array in the process with id \c srcProcessId to all of
	/// the other processes.  All processes must call these method with the same
	/// arguments in order for it to complete.
	/// </summary>
	public int Broadcast(IntPtr data, long length, int srcProcessId)
	{
		return vtkMultiProcessController_Broadcast_13(GetCppThis(), data, length, srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Broadcast_14(HandleRef pThis, string data, long length, int srcProcessId);

	/// <summary>
	/// Broadcast sends the array in the process with id \c srcProcessId to all of
	/// the other processes.  All processes must call these method with the same
	/// arguments in order for it to complete.
	/// </summary>
	public int Broadcast(string data, long length, int srcProcessId)
	{
		return vtkMultiProcessController_Broadcast_14(GetCppThis(), data, length, srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Broadcast_15(HandleRef pThis, HandleRef data, int srcProcessId);

	/// <summary>
	/// Broadcast sends the array in the process with id \c srcProcessId to all of
	/// the other processes.  All processes must call these method with the same
	/// arguments in order for it to complete.
	/// </summary>
	public int Broadcast(vtkDataObject data, int srcProcessId)
	{
		return vtkMultiProcessController_Broadcast_15(GetCppThis(), data?.GetCppThis() ?? default(HandleRef), srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Broadcast_16(HandleRef pThis, HandleRef data, int srcProcessId);

	/// <summary>
	/// Broadcast sends the array in the process with id \c srcProcessId to all of
	/// the other processes.  All processes must call these method with the same
	/// arguments in order for it to complete.
	/// </summary>
	public int Broadcast(vtkDataArray data, int srcProcessId)
	{
		return vtkMultiProcessController_Broadcast_16(GetCppThis(), data?.GetCppThis() ?? default(HandleRef), srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_BroadcastProcessRMIs_17(HandleRef pThis, int reportErrors, int dont_loop);

	/// <summary>
	/// Calling this method gives control to the controller to start
	/// processing RMIs. Possible return values are:
	/// RMI_NO_ERROR,
	/// RMI_TAG_ERROR : rmi tag could not be received,
	/// RMI_ARG_ERROR : rmi arg could not be received.
	/// If reportErrors is false, no vtkErrorMacro is called.
	/// ProcessRMIs() calls ProcessRMIs(int) with reportErrors = 0.
	/// If dont_loop is 1, this call just process one RMI message
	/// and exits.
	/// </summary>
	public int BroadcastProcessRMIs(int reportErrors, int dont_loop)
	{
		return vtkMultiProcessController_BroadcastProcessRMIs_17(GetCppThis(), reportErrors, dont_loop);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_BroadcastTriggerRMIOff_18(HandleRef pThis);

	/// <summary>
	/// Setting this flag to 1 will cause the TriggerRMIOnAllChildren to use
	/// a collective broadcast operation to communicate the RMI tag to the
	/// satellites.
	/// </summary>
	public virtual void BroadcastTriggerRMIOff()
	{
		vtkMultiProcessController_BroadcastTriggerRMIOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_BroadcastTriggerRMIOn_19(HandleRef pThis);

	/// <summary>
	/// Setting this flag to 1 will cause the TriggerRMIOnAllChildren to use
	/// a collective broadcast operation to communicate the RMI tag to the
	/// satellites.
	/// </summary>
	public virtual void BroadcastTriggerRMIOn()
	{
		vtkMultiProcessController_BroadcastTriggerRMIOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_BroadcastTriggerRMIOnAllChildren_20(HandleRef pThis, IntPtr arg, int argLength, int tag);

	/// <summary>
	/// This is a convenicence method to trigger an RMI call on all the "children"
	/// of the current node. The children of the current node can be determined by
	/// drawing a binary tree starting at node 0 and then assigned nodes ids
	/// incrementally in a breadth-first fashion from left to right. This is
	/// designed to be used when trigger an RMI call on all satellites from the
	/// root node.
	/// </summary>
	public void BroadcastTriggerRMIOnAllChildren(IntPtr arg, int argLength, int tag)
	{
		vtkMultiProcessController_BroadcastTriggerRMIOnAllChildren_20(GetCppThis(), arg, argLength, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_CreateOutputWindow_21(HandleRef pThis);

	/// <summary>
	/// This method can be used to tell the controller to create
	/// a special output window in which all messages are preceded
	/// by the process id.
	/// </summary>
	public virtual void CreateOutputWindow()
	{
		vtkMultiProcessController_CreateOutputWindow_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiProcessController_CreateSubController_22(HandleRef pThis, HandleRef group, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a new controller with the processes specified by the given group.
	/// The new controller will already be initialized for you.  You are
	/// responsible for deleting the controller once you are done.  It is invalid
	/// to pass this method a group with a different communicator than is used by
	/// this controller.  This operation is collective across all processes
	/// defined in the group.  It is undefined what will happen if the group is not
	/// the same on all processes.  This method must be called by all processes in
	/// the controller regardless of whether they are in the group.  nullptr is
	/// returned on all process not in the group.
	/// </summary>
	public virtual vtkMultiProcessController CreateSubController(vtkProcessGroup group)
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiProcessController_CreateSubController_22(GetCppThis(), group?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiProcessController2 = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiProcessController2.Register(null);
			}
		}
		return vtkMultiProcessController2;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_Finalize_23(HandleRef pThis);

	/// <summary>
	/// This method is for cleaning up.
	/// If a subclass needs to clean up process communication (i.e. MPI)
	/// it would over ride this method.
	/// </summary>
	public virtual void FinalizeWrapper()
	{
		vtkMultiProcessController_Finalize_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_Finalize_24(HandleRef pThis, int finalizedExternally);

	/// <summary>
	/// This method is for cleaning up.
	/// If a subclass needs to clean up process communication (i.e. MPI)
	/// it would over ride this method.  Provided for finalization outside vtk.
	/// </summary>
	public virtual void FinalizeWrapper(int finalizedExternally)
	{
		vtkMultiProcessController_Finalize_24(GetCppThis(), finalizedExternally);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Gather_25(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int destProcessId);

	/// <summary>
	/// Gather collects arrays in the process with id \c destProcessId.  Each
	/// process (including the destination) sends the contents of its send buffer
	/// to the destination process.  The destination process receives the
	/// messages and stores them in rank order.  The \c length argument
	/// (which must be the same on all processes) is the length of the
	/// sendBuffers.  The \c recvBuffer (on the destination process) must be of
	/// length length*numProcesses.  Gather is the inverse operation of Scatter.
	/// </summary>
	public int Gather(IntPtr sendBuffer, IntPtr recvBuffer, long length, int destProcessId)
	{
		return vtkMultiProcessController_Gather_25(GetCppThis(), sendBuffer, recvBuffer, length, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Gather_26(HandleRef pThis, string sendBuffer, string recvBuffer, long length, int destProcessId);

	/// <summary>
	/// Gather collects arrays in the process with id \c destProcessId.  Each
	/// process (including the destination) sends the contents of its send buffer
	/// to the destination process.  The destination process receives the
	/// messages and stores them in rank order.  The \c length argument
	/// (which must be the same on all processes) is the length of the
	/// sendBuffers.  The \c recvBuffer (on the destination process) must be of
	/// length length*numProcesses.  Gather is the inverse operation of Scatter.
	/// </summary>
	public int Gather(string sendBuffer, string recvBuffer, long length, int destProcessId)
	{
		return vtkMultiProcessController_Gather_26(GetCppThis(), sendBuffer, recvBuffer, length, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Gather_27(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int destProcessId);

	/// <summary>
	/// Gather collects arrays in the process with id \c destProcessId.  Each
	/// process (including the destination) sends the contents of its send buffer
	/// to the destination process.  The destination process receives the
	/// messages and stores them in rank order.  The \c length argument
	/// (which must be the same on all processes) is the length of the
	/// sendBuffers.  The \c recvBuffer (on the destination process) must be of
	/// length length*numProcesses.  Gather is the inverse operation of Scatter.
	/// </summary>
	public int Gather(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int destProcessId)
	{
		return vtkMultiProcessController_Gather_27(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef), destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_GatherV_28(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId);

	/// <summary>
	/// GatherV is the vector variant of Gather.  It extends the functionality of
	/// Gather by allowing a varying count of data from each process.
	/// GatherV collects arrays in the process with id \c destProcessId.  Each
	/// process (including the destination) sends the contents of its send buffer
	/// to the destination process.  The destination process receives the
	/// messages and stores them in rank order.  The \c sendLength argument
	/// defines how much the local process sends to \c destProcessId and
	/// \c recvLengths is an array containing the amount \c destProcessId
	/// receives from each process, in rank order.
	/// </summary>
	public int GatherV(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId)
	{
		return vtkMultiProcessController_GatherV_28(GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_GatherV_29(HandleRef pThis, string sendBuffer, string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId);

	/// <summary>
	/// GatherV is the vector variant of Gather.  It extends the functionality of
	/// Gather by allowing a varying count of data from each process.
	/// GatherV collects arrays in the process with id \c destProcessId.  Each
	/// process (including the destination) sends the contents of its send buffer
	/// to the destination process.  The destination process receives the
	/// messages and stores them in rank order.  The \c sendLength argument
	/// defines how much the local process sends to \c destProcessId and
	/// \c recvLengths is an array containing the amount \c destProcessId
	/// receives from each process, in rank order.
	/// </summary>
	public int GatherV(string sendBuffer, string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId)
	{
		return vtkMultiProcessController_GatherV_29(GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_GatherV_30(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, IntPtr recvLengths, IntPtr offsets, int destProcessId);

	/// <summary>
	/// GatherV is the vector variant of Gather.  It extends the functionality of
	/// Gather by allowing a varying count of data from each process.
	/// GatherV collects arrays in the process with id \c destProcessId.  Each
	/// process (including the destination) sends the contents of its send buffer
	/// to the destination process.  The destination process receives the
	/// messages and stores them in rank order.  The \c sendLength argument
	/// defines how much the local process sends to \c destProcessId and
	/// \c recvLengths is an array containing the amount \c destProcessId
	/// receives from each process, in rank order.
	/// </summary>
	public int GatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, IntPtr recvLengths, IntPtr offsets, int destProcessId)
	{
		return vtkMultiProcessController_GatherV_30(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef), recvLengths, offsets, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_GatherV_31(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, HandleRef recvLengths, HandleRef offsets, int destProcessId);

	/// <summary>
	/// GatherV is the vector variant of Gather.  It extends the functionality of
	/// Gather by allowing a varying count of data from each process.
	/// GatherV collects arrays in the process with id \c destProcessId.  Each
	/// process (including the destination) sends the contents of its send buffer
	/// to the destination process.  The destination process receives the
	/// messages and stores them in rank order.  The \c sendLength argument
	/// defines how much the local process sends to \c destProcessId and
	/// \c recvLengths is an array containing the amount \c destProcessId
	/// receives from each process, in rank order.
	/// </summary>
	public int GatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, vtkIdTypeArray recvLengths, vtkIdTypeArray offsets, int destProcessId)
	{
		return vtkMultiProcessController_GatherV_31(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef), recvLengths?.GetCppThis() ?? default(HandleRef), offsets?.GetCppThis() ?? default(HandleRef), destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_GatherV_32(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int destProcessId);

	/// <summary>
	/// This special form of GatherV will automatically determine \c recvLengths
	/// and \c offsets to tightly pack the data in the \c recvBuffer in process
	/// order.  It will also resize \c recvBuffer in order to accommodate the
	/// incoming data (unlike the other GatherV variants).
	/// </summary>
	public int GatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int destProcessId)
	{
		return vtkMultiProcessController_GatherV_32(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef), destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_GetBreakFlag_33(HandleRef pThis);

	/// <summary>
	/// Setting this flag to 1 will cause the ProcessRMIs loop to return.
	/// This also causes vtkUpStreamPorts to return from
	/// their WaitForUpdate loops.
	/// </summary>
	public virtual int GetBreakFlag()
	{
		return vtkMultiProcessController_GetBreakFlag_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_GetBreakRMITag_34();

	/// <summary>
	/// Accessor to some default tags.
	/// </summary>
	public static int GetBreakRMITag()
	{
		return vtkMultiProcessController_GetBreakRMITag_34();
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMultiProcessController_GetBroadcastTriggerRMI_35(HandleRef pThis);

	/// <summary>
	/// Setting this flag to 1 will cause the TriggerRMIOnAllChildren to use
	/// a collective broadcast operation to communicate the RMI tag to the
	/// satellites.
	/// </summary>
	public virtual bool GetBroadcastTriggerRMI()
	{
		return (vtkMultiProcessController_GetBroadcastTriggerRMI_35(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiProcessController_GetCommunicator_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the communicator associated with this controller.
	/// A default communicator is created in constructor.
	/// </summary>
	public virtual vtkCommunicator GetCommunicator()
	{
		vtkCommunicator vtkCommunicator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiProcessController_GetCommunicator_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkMultiProcessController_GetCount_37(HandleRef pThis);

	/// <summary>
	/// Returns the number of words received by the most recent Receive().
	/// Note that this is not the number of bytes received, but the number of items
	/// of the data-type received by the most recent Receive() eg. if
	/// Receive(int*,..) was used, then this returns the number of ints received;
	/// if Receive(double*,..) was used, then this returns the number of doubles
	/// received etc. The return value is valid only after a successful Receive().
	/// </summary>
	public long GetCount()
	{
		return vtkMultiProcessController_GetCount_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiProcessController_GetGlobalController_38(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This convenience method returns the controller associated with the
	/// local process.  It returns nullptr until the processes are spawned.
	/// It is better if you hang on to the controller passed as an argument to the
	/// SingleMethod or MultipleMethod functions.
	/// </summary>
	public static vtkMultiProcessController GetGlobalController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiProcessController_GetGlobalController_38(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiProcessController2 = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiProcessController2.Register(null);
			}
		}
		return vtkMultiProcessController2;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_GetLocalProcessId_39(HandleRef pThis);

	/// <summary>
	/// Tells you which process [0, NumProcess) you are in.
	/// </summary>
	public int GetLocalProcessId()
	{
		return vtkMultiProcessController_GetLocalProcessId_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMultiProcessController_GetNumberOfGenerationsFromBase_40(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMultiProcessController_GetNumberOfGenerationsFromBase_40(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMultiProcessController_GetNumberOfGenerationsFromBaseType_41(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMultiProcessController_GetNumberOfGenerationsFromBaseType_41(type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_GetNumberOfProcesses_42(HandleRef pThis);

	/// <summary>
	/// Set the number of processes you will be using.  This defaults
	/// to the maximum number available.  If you set this to a value
	/// higher than the default, you will get an error.
	/// </summary>
	public int GetNumberOfProcesses()
	{
		return vtkMultiProcessController_GetNumberOfProcesses_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_GetRMIArgTag_43();

	/// <summary>
	/// Accessor to some default tags.
	/// </summary>
	public static int GetRMIArgTag()
	{
		return vtkMultiProcessController_GetRMIArgTag_43();
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_GetRMITag_44();

	/// <summary>
	/// Accessor to some default tags.
	/// </summary>
	public static int GetRMITag()
	{
		return vtkMultiProcessController_GetRMITag_44();
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_IsA_45(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMultiProcessController_IsA_45(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_IsTypeOf_46(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMultiProcessController_IsTypeOf_46(type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_MultipleMethodExecute_47(HandleRef pThis);

	/// <summary>
	/// Execute the MultipleMethods (as define by calling SetMultipleMethod
	/// for each of the required this-&gt;NumberOfProcesses methods) using
	/// this-&gt;NumberOfProcesses processes.
	/// </summary>
	public virtual void MultipleMethodExecute()
	{
		vtkMultiProcessController_MultipleMethodExecute_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiProcessController_NewInstance_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMultiProcessController NewInstance()
	{
		vtkMultiProcessController result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiProcessController_NewInstance_48(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiProcessController_PartitionController_49(HandleRef pThis, int localColor, int localKey, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Partitions this controller based on a coloring.  That is, each process
	/// passes in a color.  All processes with the same color are grouped into the
	/// same partition.  The processes are ordered by their self-assigned key.
	/// Lower keys have lower process ids.  Ties are broken by the current process
	/// ids.  (For example, if all the keys are 0, then the resulting processes
	/// will be ordered in the same way.)  This method returns a new controller to
	/// each process that represents the local partition.  This is basically the
	/// same operation as MPI_Comm_split.
	/// </summary>
	public virtual vtkMultiProcessController PartitionController(int localColor, int localKey)
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiProcessController_PartitionController_49(GetCppThis(), localColor, localKey, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiProcessController2 = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiProcessController2.Register(null);
			}
		}
		return vtkMultiProcessController2;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_ProcessRMIs_50(HandleRef pThis, int reportErrors, int dont_loop);

	/// <summary>
	/// Calling this method gives control to the controller to start
	/// processing RMIs. Possible return values are:
	/// RMI_NO_ERROR,
	/// RMI_TAG_ERROR : rmi tag could not be received,
	/// RMI_ARG_ERROR : rmi arg could not be received.
	/// If reportErrors is false, no vtkErrorMacro is called.
	/// ProcessRMIs() calls ProcessRMIs(int) with reportErrors = 0.
	/// If dont_loop is 1, this call just process one RMI message
	/// and exits.
	/// </summary>
	public int ProcessRMIs(int reportErrors, int dont_loop)
	{
		return vtkMultiProcessController_ProcessRMIs_50(GetCppThis(), reportErrors, dont_loop);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_ProcessRMIs_51(HandleRef pThis);

	/// <summary>
	/// Calling this method gives control to the controller to start
	/// processing RMIs. Possible return values are:
	/// RMI_NO_ERROR,
	/// RMI_TAG_ERROR : rmi tag could not be received,
	/// RMI_ARG_ERROR : rmi arg could not be received.
	/// If reportErrors is false, no vtkErrorMacro is called.
	/// ProcessRMIs() calls ProcessRMIs(int) with reportErrors = 0.
	/// If dont_loop is 1, this call just process one RMI message
	/// and exits.
	/// </summary>
	public int ProcessRMIs()
	{
		return vtkMultiProcessController_ProcessRMIs_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Receive_52(HandleRef pThis, HandleRef data, int remoteId, int tag);

	/// <summary>
	/// This method receives data from a corresponding send. It blocks
	/// until the receive is finished.  It calls methods in "data"
	/// to communicate the sending data. In the overrloads that take in a \c
	/// maxlength argument, this length is the maximum length of the message to
	/// receive. If the maxlength is less than the length of the message sent by
	/// the sender, an error will be flagged. Once a message is received, use the
	/// GetCount() method to determine the actual size of the data received.
	/// </summary>
	public int Receive(vtkDataArray data, int remoteId, int tag)
	{
		return vtkMultiProcessController_Receive_52(GetCppThis(), data?.GetCppThis() ?? default(HandleRef), remoteId, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Receive_53(HandleRef pThis, IntPtr data, long maxlength, int remoteProcessId, int tag);

	/// <summary>
	/// This method receives data from a corresponding send. It blocks
	/// until the receive is finished.  It calls methods in "data"
	/// to communicate the sending data. In the overrloads that take in a \c
	/// maxlength argument, this length is the maximum length of the message to
	/// receive. If the maxlength is less than the length of the message sent by
	/// the sender, an error will be flagged. Once a message is received, use the
	/// GetCount() method to determine the actual size of the data received.
	/// </summary>
	public int Receive(IntPtr data, long maxlength, int remoteProcessId, int tag)
	{
		return vtkMultiProcessController_Receive_53(GetCppThis(), data, maxlength, remoteProcessId, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Receive_54(HandleRef pThis, string data, long maxlength, int remoteProcessId, int tag);

	/// <summary>
	/// This method receives data from a corresponding send. It blocks
	/// until the receive is finished.  It calls methods in "data"
	/// to communicate the sending data. In the overrloads that take in a \c
	/// maxlength argument, this length is the maximum length of the message to
	/// receive. If the maxlength is less than the length of the message sent by
	/// the sender, an error will be flagged. Once a message is received, use the
	/// GetCount() method to determine the actual size of the data received.
	/// </summary>
	public int Receive(string data, long maxlength, int remoteProcessId, int tag)
	{
		return vtkMultiProcessController_Receive_54(GetCppThis(), data, maxlength, remoteProcessId, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Receive_55(HandleRef pThis, HandleRef data, int remoteId, int tag);

	/// <summary>
	/// This method receives data from a corresponding send. It blocks
	/// until the receive is finished.  It calls methods in "data"
	/// to communicate the sending data. In the overrloads that take in a \c
	/// maxlength argument, this length is the maximum length of the message to
	/// receive. If the maxlength is less than the length of the message sent by
	/// the sender, an error will be flagged. Once a message is received, use the
	/// GetCount() method to determine the actual size of the data received.
	/// </summary>
	public int Receive(vtkDataObject data, int remoteId, int tag)
	{
		return vtkMultiProcessController_Receive_55(GetCppThis(), data?.GetCppThis() ?? default(HandleRef), remoteId, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiProcessController_ReceiveDataObject_56(HandleRef pThis, int remoteId, int tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Receive a stream from the other processes.
	/// </summary>
	public vtkDataObject ReceiveDataObject(int remoteId, int tag)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiProcessController_ReceiveDataObject_56(GetCppThis(), remoteId, tag, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObject2 = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObject2.Register(null);
			}
		}
		return vtkDataObject2;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Reduce_57(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation, int destProcessId);

	/// <summary>
	/// Reduce an array to the given destination process.  This version of Reduce
	/// takes an identifier defined in the
	/// vtkCommunicator::StandardOperations enum to define the operation.
	/// </summary>
	public int Reduce(IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation, int destProcessId)
	{
		return vtkMultiProcessController_Reduce_57(GetCppThis(), sendBuffer, recvBuffer, length, operation, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Reduce_58(HandleRef pThis, string sendBuffer, string recvBuffer, long length, int operation, int destProcessId);

	/// <summary>
	/// Reduce an array to the given destination process.  This version of Reduce
	/// takes an identifier defined in the
	/// vtkCommunicator::StandardOperations enum to define the operation.
	/// </summary>
	public int Reduce(string sendBuffer, string recvBuffer, long length, int operation, int destProcessId)
	{
		return vtkMultiProcessController_Reduce_58(GetCppThis(), sendBuffer, recvBuffer, length, operation, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Reduce_59(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int operation, int destProcessId);

	/// <summary>
	/// Reduce an array to the given destination process.  This version of Reduce
	/// takes an identifier defined in the
	/// vtkCommunicator::StandardOperations enum to define the operation.
	/// </summary>
	public int Reduce(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int operation, int destProcessId)
	{
		return vtkMultiProcessController_Reduce_59(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef), operation, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Reduce_60(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int destProcessId);

	/// <summary>
	/// Convenience methods to reduce vtkDataArraySelection.
	/// </summary>
	public int Reduce(vtkDataArraySelection sendBuffer, vtkDataArraySelection recvBuffer, int destProcessId)
	{
		return vtkMultiProcessController_Reduce_60(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef), destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_RemoveAllRMICallbacks_61(HandleRef pThis, int tag);

	/// <summary>
	/// These methods are a part of the newer API to add multiple rmi callbacks.
	/// When the RMI is triggered, all the callbacks are called
	/// Removes all callbacks for the tag.
	/// </summary>
	public virtual void RemoveAllRMICallbacks(int tag)
	{
		vtkMultiProcessController_RemoveAllRMICallbacks_61(GetCppThis(), tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_RemoveFirstRMI_62(HandleRef pThis, int tag);

	/// <summary>
	/// Remove the first RMI matching the tag.
	/// </summary>
	public virtual int RemoveFirstRMI(int tag)
	{
		return vtkMultiProcessController_RemoveFirstRMI_62(GetCppThis(), tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_RemoveRMI_63(HandleRef pThis, uint id);

	/// <summary>
	/// Remove the RMI matching the id. The id is the same id returned by
	/// AddRMI().
	/// </summary>
	public virtual int RemoveRMI(uint id)
	{
		return vtkMultiProcessController_RemoveRMI_63(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMultiProcessController_RemoveRMICallback_64(HandleRef pThis, uint id);

	/// <summary>
	/// Remove a callback. Returns true is the remove was successful.
	/// </summary>
	public virtual bool RemoveRMICallback(uint id)
	{
		return (vtkMultiProcessController_RemoveRMICallback_64(GetCppThis(), id) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiProcessController_SafeDownCast_65(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMultiProcessController SafeDownCast(vtkObjectBase o)
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiProcessController_SafeDownCast_65(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiProcessController2 = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiProcessController2.Register(null);
			}
		}
		return vtkMultiProcessController2;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Scatter_66(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int srcProcessId);

	/// <summary>
	/// Scatter takes an array in the process with id \c srcProcessId and
	/// distributes it.  Each process (including the source) receives a portion of
	/// the send buffer.  Process 0 receives the first \c length values, process 1
	/// receives the second \c length values, and so on.  Scatter is the inverse
	/// operation of Gather.
	/// </summary>
	public int Scatter(IntPtr sendBuffer, IntPtr recvBuffer, long length, int srcProcessId)
	{
		return vtkMultiProcessController_Scatter_66(GetCppThis(), sendBuffer, recvBuffer, length, srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Scatter_67(HandleRef pThis, string sendBuffer, string recvBuffer, long length, int srcProcessId);

	/// <summary>
	/// Scatter takes an array in the process with id \c srcProcessId and
	/// distributes it.  Each process (including the source) receives a portion of
	/// the send buffer.  Process 0 receives the first \c length values, process 1
	/// receives the second \c length values, and so on.  Scatter is the inverse
	/// operation of Gather.
	/// </summary>
	public int Scatter(string sendBuffer, string recvBuffer, long length, int srcProcessId)
	{
		return vtkMultiProcessController_Scatter_67(GetCppThis(), sendBuffer, recvBuffer, length, srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Scatter_68(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int srcProcessId);

	/// <summary>
	/// Scatter takes an array in the process with id \c srcProcessId and
	/// distributes it.  Each process (including the source) receives a portion of
	/// the send buffer.  Process 0 receives the first \c length values, process 1
	/// receives the second \c length values, and so on.  Scatter is the inverse
	/// operation of Gather.
	/// </summary>
	public int Scatter(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int srcProcessId)
	{
		return vtkMultiProcessController_Scatter_68(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef), srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_ScatterV_69(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId);

	/// <summary>
	/// ScatterV is the vector variant of Scatter.  It extends the functionality of
	/// Scatter by allowing a varying count of data to each process.
	/// ScatterV takes an array in the process with id \c srcProcessId and
	/// distributes it.  Each process (including the source) receives a portion of
	/// the send buffer defined by the \c sendLengths and \c offsets arrays.
	/// </summary>
	public int ScatterV(IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId)
	{
		return vtkMultiProcessController_ScatterV_69(GetCppThis(), sendBuffer, recvBuffer, sendLengths, offsets, recvLength, srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_ScatterV_70(HandleRef pThis, string sendBuffer, string recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId);

	/// <summary>
	/// ScatterV is the vector variant of Scatter.  It extends the functionality of
	/// Scatter by allowing a varying count of data to each process.
	/// ScatterV takes an array in the process with id \c srcProcessId and
	/// distributes it.  Each process (including the source) receives a portion of
	/// the send buffer defined by the \c sendLengths and \c offsets arrays.
	/// </summary>
	public int ScatterV(string sendBuffer, string recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId)
	{
		return vtkMultiProcessController_ScatterV_70(GetCppThis(), sendBuffer, recvBuffer, sendLengths, offsets, recvLength, srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Send_71(HandleRef pThis, IntPtr data, long length, int remoteProcessId, int tag);

	/// <summary>
	/// This method sends data to another process.  Tag eliminates ambiguity
	/// when multiple sends or receives exist in the same process.
	/// It is recommended to use custom tag number over 100.
	/// vtkMultiProcessController has reserved tags between 1 and 4.
	/// vtkCommunicator has reserved tags between 10 and 16.
	/// </summary>
	public int Send(IntPtr data, long length, int remoteProcessId, int tag)
	{
		return vtkMultiProcessController_Send_71(GetCppThis(), data, length, remoteProcessId, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Send_72(HandleRef pThis, string data, long length, int remoteProcessId, int tag);

	/// <summary>
	/// This method sends data to another process.  Tag eliminates ambiguity
	/// when multiple sends or receives exist in the same process.
	/// It is recommended to use custom tag number over 100.
	/// vtkMultiProcessController has reserved tags between 1 and 4.
	/// vtkCommunicator has reserved tags between 10 and 16.
	/// </summary>
	public int Send(string data, long length, int remoteProcessId, int tag)
	{
		return vtkMultiProcessController_Send_72(GetCppThis(), data, length, remoteProcessId, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Send_73(HandleRef pThis, HandleRef data, int remoteId, int tag);

	/// <summary>
	/// This method sends data to another process.  Tag eliminates ambiguity
	/// when multiple sends or receives exist in the same process.
	/// It is recommended to use custom tag number over 100.
	/// vtkMultiProcessController has reserved tags between 1 and 4.
	/// vtkCommunicator has reserved tags between 10 and 16.
	/// </summary>
	public int Send(vtkDataObject data, int remoteId, int tag)
	{
		return vtkMultiProcessController_Send_73(GetCppThis(), data?.GetCppThis() ?? default(HandleRef), remoteId, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiProcessController_Send_74(HandleRef pThis, HandleRef data, int remoteId, int tag);

	/// <summary>
	/// This method sends data to another process.  Tag eliminates ambiguity
	/// when multiple sends or receives exist in the same process.
	/// It is recommended to use custom tag number over 100.
	/// vtkMultiProcessController has reserved tags between 1 and 4.
	/// vtkCommunicator has reserved tags between 10 and 16.
	/// </summary>
	public int Send(vtkDataArray data, int remoteId, int tag)
	{
		return vtkMultiProcessController_Send_74(GetCppThis(), data?.GetCppThis() ?? default(HandleRef), remoteId, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_SetBreakFlag_75(HandleRef pThis, int _arg);

	/// <summary>
	/// Setting this flag to 1 will cause the ProcessRMIs loop to return.
	/// This also causes vtkUpStreamPorts to return from
	/// their WaitForUpdate loops.
	/// </summary>
	public virtual void SetBreakFlag(int _arg)
	{
		vtkMultiProcessController_SetBreakFlag_75(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_SetBroadcastTriggerRMI_76(HandleRef pThis, byte _arg);

	/// <summary>
	/// Setting this flag to 1 will cause the TriggerRMIOnAllChildren to use
	/// a collective broadcast operation to communicate the RMI tag to the
	/// satellites.
	/// </summary>
	public virtual void SetBroadcastTriggerRMI(bool _arg)
	{
		vtkMultiProcessController_SetBroadcastTriggerRMI_76(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_SetGlobalController_77(HandleRef controller);

	/// <summary>
	/// This method can be used to synchronize processes.
	/// </summary>
	public static void SetGlobalController(vtkMultiProcessController controller)
	{
		vtkMultiProcessController_SetGlobalController_77(controller?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_SetNumberOfProcesses_78(HandleRef pThis, int num);

	/// <summary>
	/// Set the number of processes you will be using.  This defaults
	/// to the maximum number available.  If you set this to a value
	/// higher than the default, you will get an error.
	/// </summary>
	public void SetNumberOfProcesses(int num)
	{
		vtkMultiProcessController_SetNumberOfProcesses_78(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_SetSingleProcessObject_79(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Object-oriented flavor of SetSingleMethod(). Instead of passing
	/// some function pointer and user data, a vtkProcess object is passed
	/// where the method to execute is Execute() and the data the object itself.
	/// </summary>
	public void SetSingleProcessObject(vtkProcess p)
	{
		vtkMultiProcessController_SetSingleProcessObject_79(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_SingleMethodExecute_80(HandleRef pThis);

	/// <summary>
	/// Execute the SingleMethod (as define by SetSingleMethod) using
	/// this-&gt;NumberOfProcesses processes.  This will only return when
	/// all the processes finish executing their methods.
	/// </summary>
	public virtual void SingleMethodExecute()
	{
		vtkMultiProcessController_SingleMethodExecute_80(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_TriggerBreakRMIs_81(HandleRef pThis);

	/// <summary>
	/// A convenience method.  Called on process 0 to break "ProcessRMIs" loop
	/// on all other processes.
	/// </summary>
	public void TriggerBreakRMIs()
	{
		vtkMultiProcessController_TriggerBreakRMIs_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_TriggerRMI_82(HandleRef pThis, int remoteProcessId, IntPtr arg, int argLength, int tag);

	/// <summary>
	/// A method to trigger a method invocation in another process.
	/// </summary>
	public void TriggerRMI(int remoteProcessId, IntPtr arg, int argLength, int tag)
	{
		vtkMultiProcessController_TriggerRMI_82(GetCppThis(), remoteProcessId, arg, argLength, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_TriggerRMI_83(HandleRef pThis, int remoteProcessId, string arg, int tag);

	/// <summary>
	/// Convenience method when the arg is a string.
	/// </summary>
	public void TriggerRMI(int remoteProcessId, string arg, int tag)
	{
		vtkMultiProcessController_TriggerRMI_83(GetCppThis(), remoteProcessId, arg, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_TriggerRMI_84(HandleRef pThis, int remoteProcessId, int tag);

	/// <summary>
	/// Convenience method when there is no argument.
	/// </summary>
	public void TriggerRMI(int remoteProcessId, int tag)
	{
		vtkMultiProcessController_TriggerRMI_84(GetCppThis(), remoteProcessId, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_TriggerRMIOnAllChildren_85(HandleRef pThis, IntPtr arg, int argLength, int tag);

	/// <summary>
	/// This is a convenicence method to trigger an RMI call on all the "children"
	/// of the current node. The children of the current node can be determined by
	/// drawing a binary tree starting at node 0 and then assigned nodes ids
	/// incrementally in a breadth-first fashion from left to right. This is
	/// designed to be used when trigger an RMI call on all satellites from the
	/// root node.
	/// </summary>
	public void TriggerRMIOnAllChildren(IntPtr arg, int argLength, int tag)
	{
		vtkMultiProcessController_TriggerRMIOnAllChildren_85(GetCppThis(), arg, argLength, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_TriggerRMIOnAllChildren_86(HandleRef pThis, string arg, int tag);

	/// <summary>
	/// This is a convenicence method to trigger an RMI call on all the "children"
	/// of the current node. The children of the current node can be determined by
	/// drawing a binary tree starting at node 0 and then assigned nodes ids
	/// incrementally in a breadth-first fashion from left to right. This is
	/// designed to be used when trigger an RMI call on all satellites from the
	/// root node.
	/// </summary>
	public void TriggerRMIOnAllChildren(string arg, int tag)
	{
		vtkMultiProcessController_TriggerRMIOnAllChildren_86(GetCppThis(), arg, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiProcessController_TriggerRMIOnAllChildren_87(HandleRef pThis, int tag);

	/// <summary>
	/// This is a convenicence method to trigger an RMI call on all the "children"
	/// of the current node. The children of the current node can be determined by
	/// drawing a binary tree starting at node 0 and then assigned nodes ids
	/// incrementally in a breadth-first fashion from left to right. This is
	/// designed to be used when trigger an RMI call on all satellites from the
	/// root node.
	/// </summary>
	public void TriggerRMIOnAllChildren(int tag)
	{
		vtkMultiProcessController_TriggerRMIOnAllChildren_87(GetCppThis(), tag);
	}
}
