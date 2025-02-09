using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCommunicator
/// </summary>
/// <remarks>
///    Used to send/receive messages in a multiprocess environment.
///
/// This is an abstract class which contains functionality for sending
/// and receiving inter-process messages. It contains methods for marshaling
/// an object into a string (currently used by the MPI communicator but
/// not the shared memory communicator).
///
/// @warning
/// Communication between systems with different vtkIdTypes is not
/// supported. All machines have to have the same vtkIdType.
///
/// </remarks>
/// <seealso>
///
/// vtkMPICommunicator
/// </seealso>
public abstract class vtkCommunicator : vtkObject
{
	/// <summary>
	/// Tells you which process [0, NumProcess) you are in.
	/// </summary>
	public enum StandardOperations
	{
		/// <summary>enum member</summary>
		BITWISE_AND_OP = 5,
		/// <summary>enum member</summary>
		BITWISE_OR_OP = 7,
		/// <summary>enum member</summary>
		BITWISE_XOR_OP = 9,
		/// <summary>enum member</summary>
		LOGICAL_AND_OP = 4,
		/// <summary>enum member</summary>
		LOGICAL_OR_OP = 6,
		/// <summary>enum member</summary>
		LOGICAL_XOR_OP = 8,
		/// <summary>enum member</summary>
		MAX_OP = 0,
		/// <summary>enum member</summary>
		MIN_OP = 1,
		/// <summary>enum member</summary>
		PRODUCT_OP = 3,
		/// <summary>enum member</summary>
		SUM_OP = 2
	}

	/// <summary>
	/// Tells you which process [0, NumProcess) you are in.
	/// </summary>
	public enum Tags
	{
		/// <summary>enum member</summary>
		BARRIER_TAG = 16,
		/// <summary>enum member</summary>
		BROADCAST_TAG = 10,
		/// <summary>enum member</summary>
		GATHERV_TAG = 12,
		/// <summary>enum member</summary>
		GATHER_TAG = 11,
		/// <summary>enum member</summary>
		REDUCE_TAG = 15,
		/// <summary>enum member</summary>
		SCATTERV_TAG = 14,
		/// <summary>enum member</summary>
		SCATTER_TAG = 13
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCommunicator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCommunicator()
	{
		MRClassNameKey = "class vtkCommunicator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCommunicator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCommunicator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern int vtkCommunicator_AllGather_01(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length);

	/// <summary>
	/// Same as gather except that the result ends up on all processes.
	/// </summary>
	public int AllGather(IntPtr sendBuffer, IntPtr recvBuffer, long length)
	{
		return vtkCommunicator_AllGather_01(GetCppThis(), sendBuffer, recvBuffer, length);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_AllGather_02(HandleRef pThis, string sendBuffer, string recvBuffer, long length);

	/// <summary>
	/// Same as gather except that the result ends up on all processes.
	/// </summary>
	public int AllGather(string sendBuffer, string recvBuffer, long length)
	{
		return vtkCommunicator_AllGather_02(GetCppThis(), sendBuffer, recvBuffer, length);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_AllGather_03(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer);

	/// <summary>
	/// Same as gather except that the result ends up on all processes.
	/// </summary>
	public int AllGather(vtkDataArray sendBuffer, vtkDataArray recvBuffer)
	{
		return vtkCommunicator_AllGather_03(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_AllGatherV_04(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets);

	/// <summary>
	/// Same as GatherV except that the result is placed in all processes.
	/// </summary>
	public int AllGatherV(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets)
	{
		return vtkCommunicator_AllGatherV_04(GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_AllGatherV_05(HandleRef pThis, string sendBuffer, string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets);

	/// <summary>
	/// Same as GatherV except that the result is placed in all processes.
	/// </summary>
	public int AllGatherV(string sendBuffer, string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets)
	{
		return vtkCommunicator_AllGatherV_05(GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_AllGatherV_06(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, IntPtr recvLengths, IntPtr offsets);

	/// <summary>
	/// Same as GatherV except that the result is placed in all processes.
	/// </summary>
	public int AllGatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, IntPtr recvLengths, IntPtr offsets)
	{
		return vtkCommunicator_AllGatherV_06(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef), recvLengths, offsets);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_AllGatherV_07(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer);

	/// <summary>
	/// Same as GatherV except that the result is placed in all processes.
	/// </summary>
	public int AllGatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer)
	{
		return vtkCommunicator_AllGatherV_07(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_AllGatherVVoidArray_08(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type);

	/// <summary>
	/// Subclasses should reimplement these if they have a more efficient
	/// implementation.
	/// </summary>
	public virtual int AllGatherVVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type)
	{
		return vtkCommunicator_AllGatherVVoidArray_08(GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_AllGatherVoidArray_09(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type);

	/// <summary>
	/// Subclasses should reimplement these if they have a more efficient
	/// implementation.
	/// </summary>
	public virtual int AllGatherVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type)
	{
		return vtkCommunicator_AllGatherVoidArray_09(GetCppThis(), sendBuffer, recvBuffer, length, type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_AllReduce_10(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation);

	/// <summary>
	/// Same as Reduce except that the result is placed in all of the processes.
	/// </summary>
	public int AllReduce(IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation)
	{
		return vtkCommunicator_AllReduce_10(GetCppThis(), sendBuffer, recvBuffer, length, operation);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_AllReduce_11(HandleRef pThis, string sendBuffer, string recvBuffer, long length, int operation);

	/// <summary>
	/// Same as Reduce except that the result is placed in all of the processes.
	/// </summary>
	public int AllReduce(string sendBuffer, string recvBuffer, long length, int operation)
	{
		return vtkCommunicator_AllReduce_11(GetCppThis(), sendBuffer, recvBuffer, length, operation);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_AllReduce_12(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int operation);

	/// <summary>
	/// Same as Reduce except that the result is placed in all of the processes.
	/// </summary>
	public int AllReduce(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int operation)
	{
		return vtkCommunicator_AllReduce_12(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef), operation);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_AllReduceVoidArray_13(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation);

	/// <summary>
	/// Subclasses should reimplement these if they have a more efficient
	/// implementation.
	/// </summary>
	public virtual int AllReduceVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation)
	{
		return vtkCommunicator_AllReduceVoidArray_13(GetCppThis(), sendBuffer, recvBuffer, length, type, operation);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommunicator_Barrier_14(HandleRef pThis);

	/// <summary>
	/// Will block the processes until all other processes reach the Barrier
	/// function.
	/// </summary>
	public virtual void Barrier()
	{
		vtkCommunicator_Barrier_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_Broadcast_15(HandleRef pThis, IntPtr data, long length, int srcProcessId);

	/// <summary>
	/// Broadcast sends the array in the process with id \c srcProcessId to all of
	/// the other processes.  All processes must call these method with the same
	/// arguments in order for it to complete.
	/// </summary>
	public int Broadcast(IntPtr data, long length, int srcProcessId)
	{
		return vtkCommunicator_Broadcast_15(GetCppThis(), data, length, srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_Broadcast_16(HandleRef pThis, string data, long length, int srcProcessId);

	/// <summary>
	/// Broadcast sends the array in the process with id \c srcProcessId to all of
	/// the other processes.  All processes must call these method with the same
	/// arguments in order for it to complete.
	/// </summary>
	public int Broadcast(string data, long length, int srcProcessId)
	{
		return vtkCommunicator_Broadcast_16(GetCppThis(), data, length, srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_Broadcast_17(HandleRef pThis, HandleRef data, int srcProcessId);

	/// <summary>
	/// Broadcast sends the array in the process with id \c srcProcessId to all of
	/// the other processes.  All processes must call these method with the same
	/// arguments in order for it to complete.
	/// </summary>
	public int Broadcast(vtkDataObject data, int srcProcessId)
	{
		return vtkCommunicator_Broadcast_17(GetCppThis(), data?.GetCppThis() ?? default(HandleRef), srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_Broadcast_18(HandleRef pThis, HandleRef data, int srcProcessId);

	/// <summary>
	/// Broadcast sends the array in the process with id \c srcProcessId to all of
	/// the other processes.  All processes must call these method with the same
	/// arguments in order for it to complete.
	/// </summary>
	public int Broadcast(vtkDataArray data, int srcProcessId)
	{
		return vtkCommunicator_Broadcast_18(GetCppThis(), data?.GetCppThis() ?? default(HandleRef), srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_BroadcastVoidArray_19(HandleRef pThis, IntPtr data, long length, int type, int srcProcessId);

	/// <summary>
	/// Subclasses should reimplement these if they have a more efficient
	/// implementation.
	/// </summary>
	public virtual int BroadcastVoidArray(IntPtr data, long length, int type, int srcProcessId)
	{
		return vtkCommunicator_BroadcastVoidArray_19(GetCppThis(), data, length, type, srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_Gather_20(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int destProcessId);

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
		return vtkCommunicator_Gather_20(GetCppThis(), sendBuffer, recvBuffer, length, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_Gather_21(HandleRef pThis, string sendBuffer, string recvBuffer, long length, int destProcessId);

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
		return vtkCommunicator_Gather_21(GetCppThis(), sendBuffer, recvBuffer, length, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_Gather_22(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int destProcessId);

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
		return vtkCommunicator_Gather_22(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef), destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_GatherV_23(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId);

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
		return vtkCommunicator_GatherV_23(GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_GatherV_24(HandleRef pThis, string sendBuffer, string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId);

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
		return vtkCommunicator_GatherV_24(GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_GatherV_25(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, IntPtr recvLengths, IntPtr offsets, int destProcessId);

	/// <summary>
	/// For the first GatherV variant, \c recvLengths and \c offsets known on
	/// \c destProcessId and are passed in as parameters
	/// For the second GatherV variant, \c recvLengths and \c offsets are not known
	/// on \c destProcessId.  The \c recvLengths is set using a gather operation
	/// and \c offsets is computed from \c recvLengths. recvLengths has
	/// \c NumberOfProcesses elements and \c offsets has NumberOfProcesses + 1 elements.
	/// The third variant is the same as the second variant but it does not expose
	/// \c recvLength and \c offsets
	/// </summary>
	public int GatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, IntPtr recvLengths, IntPtr offsets, int destProcessId)
	{
		return vtkCommunicator_GatherV_25(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef), recvLengths, offsets, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_GatherV_26(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, HandleRef recvLengths, HandleRef offsets, int destProcessId);

	/// <summary>
	/// For the first GatherV variant, \c recvLengths and \c offsets known on
	/// \c destProcessId and are passed in as parameters
	/// For the second GatherV variant, \c recvLengths and \c offsets are not known
	/// on \c destProcessId.  The \c recvLengths is set using a gather operation
	/// and \c offsets is computed from \c recvLengths. recvLengths has
	/// \c NumberOfProcesses elements and \c offsets has NumberOfProcesses + 1 elements.
	/// The third variant is the same as the second variant but it does not expose
	/// \c recvLength and \c offsets
	/// </summary>
	public int GatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, vtkIdTypeArray recvLengths, vtkIdTypeArray offsets, int destProcessId)
	{
		return vtkCommunicator_GatherV_26(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef), recvLengths?.GetCppThis() ?? default(HandleRef), offsets?.GetCppThis() ?? default(HandleRef), destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_GatherV_27(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int destProcessId);

	/// <summary>
	/// For the first GatherV variant, \c recvLengths and \c offsets known on
	/// \c destProcessId and are passed in as parameters
	/// For the second GatherV variant, \c recvLengths and \c offsets are not known
	/// on \c destProcessId.  The \c recvLengths is set using a gather operation
	/// and \c offsets is computed from \c recvLengths. recvLengths has
	/// \c NumberOfProcesses elements and \c offsets has NumberOfProcesses + 1 elements.
	/// The third variant is the same as the second variant but it does not expose
	/// \c recvLength and \c offsets
	/// </summary>
	public int GatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int destProcessId)
	{
		return vtkCommunicator_GatherV_27(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef), destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_GatherVVoidArray_28(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type, int destProcessId);

	/// <summary>
	/// Subclasses should reimplement these if they have a more efficient
	/// implementation.
	/// </summary>
	public virtual int GatherVVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type, int destProcessId)
	{
		return vtkCommunicator_GatherVVoidArray_28(GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, type, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_GatherVoidArray_29(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int destProcessId);

	/// <summary>
	/// Subclasses should reimplement these if they have a more efficient
	/// implementation.
	/// </summary>
	public virtual int GatherVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int destProcessId)
	{
		return vtkCommunicator_GatherVoidArray_29(GetCppThis(), sendBuffer, recvBuffer, length, type, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCommunicator_GetCount_30(HandleRef pThis);

	/// <summary>
	/// Returns the number of words received by the most recent Receive().
	/// Note that this is not the number of bytes received, but the number of items
	/// of the data-type received by the most recent Receive() eg. if
	/// Receive(int*,..) was used, then this returns the number of ints received;
	/// if Receive(double*,..) was used, then this returns the number of doubles
	/// received etc. The return value is valid only after a successful Receive().
	/// </summary>
	public virtual long GetCount()
	{
		return vtkCommunicator_GetCount_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_GetLeftChildProcessor_31(int pid);

	/// <summary>
	/// Some helper functions when dealing with heap tree - based
	/// algorithms - we don't need a function for getting the right
	/// processor since it is 1 + theLeftProcessor
	/// </summary>
	public static int GetLeftChildProcessor(int pid)
	{
		return vtkCommunicator_GetLeftChildProcessor_31(pid);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_GetLocalProcessId_32(HandleRef pThis);

	/// <summary>
	/// Tells you which process [0, NumProcess) you are in.
	/// </summary>
	public virtual int GetLocalProcessId()
	{
		return vtkCommunicator_GetLocalProcessId_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCommunicator_GetNumberOfGenerationsFromBase_33(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCommunicator_GetNumberOfGenerationsFromBase_33(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCommunicator_GetNumberOfGenerationsFromBaseType_34(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCommunicator_GetNumberOfGenerationsFromBaseType_34(type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_GetNumberOfProcesses_35(HandleRef pThis);

	/// <summary>
	/// Set the number of processes you will be using.  This defaults
	/// to the maximum number available.  If you set this to a value
	/// higher than the default, you will get an error.
	/// </summary>
	public virtual int GetNumberOfProcesses()
	{
		return vtkCommunicator_GetNumberOfProcesses_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_GetParentProcessor_36(int pid);

	/// <summary>
	/// Some helper functions when dealing with heap tree - based
	/// algorithms - we don't need a function for getting the right
	/// processor since it is 1 + theLeftProcessor
	/// </summary>
	public static int GetParentProcessor(int pid)
	{
		return vtkCommunicator_GetParentProcessor_36(pid);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_IsA_37(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCommunicator_IsA_37(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_IsTypeOf_38(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCommunicator_IsTypeOf_38(type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_MarshalDataObject_39(HandleRef arg0, HandleRef buffer);

	/// <summary>
	/// Convert a data object into a string that can be transmitted and vice versa.
	/// Returns 1 for success and 0 for failure.
	/// WARNING: This will only work for types that have a vtkDataWriter class.
	/// </summary>
	public static int MarshalDataObject(vtkDataObject arg0, vtkCharArray buffer)
	{
		return vtkCommunicator_MarshalDataObject_39(arg0?.GetCppThis() ?? default(HandleRef), buffer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCommunicator_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCommunicator NewInstance()
	{
		vtkCommunicator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCommunicator_NewInstance_40(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_Receive_41(HandleRef pThis, HandleRef data, int remoteHandle, int tag);

	/// <summary>
	/// This method receives a data object from a corresponding send. It blocks
	/// until the receive is finished.
	/// </summary>
	public int Receive(vtkDataObject data, int remoteHandle, int tag)
	{
		return vtkCommunicator_Receive_41(GetCppThis(), data?.GetCppThis() ?? default(HandleRef), remoteHandle, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_Receive_42(HandleRef pThis, HandleRef data, int remoteHandle, int tag);

	/// <summary>
	/// This method receives a data array from a corresponding send. It blocks
	/// until the receive is finished.
	/// </summary>
	public int Receive(vtkDataArray data, int remoteHandle, int tag)
	{
		return vtkCommunicator_Receive_42(GetCppThis(), data?.GetCppThis() ?? default(HandleRef), remoteHandle, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_Receive_43(HandleRef pThis, IntPtr data, long maxlength, int remoteHandle, int tag);

	/// <summary>
	/// Convenience methods for receiving data arrays.
	/// </summary>
	public int Receive(IntPtr data, long maxlength, int remoteHandle, int tag)
	{
		return vtkCommunicator_Receive_43(GetCppThis(), data, maxlength, remoteHandle, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_Receive_44(HandleRef pThis, string data, long maxlength, int remoteHandle, int tag);

	/// <summary>
	/// Convenience methods for receiving data arrays.
	/// </summary>
	public int Receive(string data, long maxlength, int remoteHandle, int tag)
	{
		return vtkCommunicator_Receive_44(GetCppThis(), data, maxlength, remoteHandle, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCommunicator_ReceiveDataObject_45(HandleRef pThis, int remoteHandle, int tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The caller does not have to know the data type before this call is made.
	/// It returns the newly created object.
	/// </summary>
	public vtkDataObject ReceiveDataObject(int remoteHandle, int tag)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCommunicator_ReceiveDataObject_45(GetCppThis(), remoteHandle, tag, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCommunicator_ReceiveVoidArray_46(HandleRef pThis, IntPtr data, long maxlength, int type, int remoteHandle, int tag);

	/// <summary>
	/// Subclasses have to supply this method to receive various arrays of data.
	/// The \c type arg is one of the VTK type constants recognized by the
	/// vtkTemplateMacro (VTK_FLOAT, VTK_INT, etc.).  \c maxlength is measured
	/// in number of values (as opposed to number of bytes) and is the maxmum
	/// length of the data to receive.  If the maxlength is less than the length
	/// of the message sent by the sender, an error will be flagged. Once a
	/// message is received, use the GetCount() method to determine the actual
	/// size of the data received.
	/// </summary>
	public virtual int ReceiveVoidArray(IntPtr data, long maxlength, int type, int remoteHandle, int tag)
	{
		return vtkCommunicator_ReceiveVoidArray_46(GetCppThis(), data, maxlength, type, remoteHandle, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_Reduce_47(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation, int destProcessId);

	/// <summary>
	/// Reduce an array to the given destination process.  This version of Reduce
	/// takes an identifier defined in the
	/// vtkCommunicator::StandardOperations enum to define the operation.
	/// </summary>
	public int Reduce(IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation, int destProcessId)
	{
		return vtkCommunicator_Reduce_47(GetCppThis(), sendBuffer, recvBuffer, length, operation, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_Reduce_48(HandleRef pThis, string sendBuffer, string recvBuffer, long length, int operation, int destProcessId);

	/// <summary>
	/// Reduce an array to the given destination process.  This version of Reduce
	/// takes an identifier defined in the
	/// vtkCommunicator::StandardOperations enum to define the operation.
	/// </summary>
	public int Reduce(string sendBuffer, string recvBuffer, long length, int operation, int destProcessId)
	{
		return vtkCommunicator_Reduce_48(GetCppThis(), sendBuffer, recvBuffer, length, operation, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_Reduce_49(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int operation, int destProcessId);

	/// <summary>
	/// Reduce an array to the given destination process.  This version of Reduce
	/// takes an identifier defined in the
	/// vtkCommunicator::StandardOperations enum to define the operation.
	/// </summary>
	public int Reduce(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int operation, int destProcessId)
	{
		return vtkCommunicator_Reduce_49(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef), operation, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_ReduceVoidArray_50(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation, int destProcessId);

	/// <summary>
	/// Subclasses should reimplement these if they have a more efficient
	/// implementation.
	/// </summary>
	public virtual int ReduceVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation, int destProcessId)
	{
		return vtkCommunicator_ReduceVoidArray_50(GetCppThis(), sendBuffer, recvBuffer, length, type, operation, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCommunicator_SafeDownCast_51(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCommunicator SafeDownCast(vtkObjectBase o)
	{
		vtkCommunicator vtkCommunicator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCommunicator_SafeDownCast_51(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCommunicator_Scatter_52(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int srcProcessId);

	/// <summary>
	/// Scatter takes an array in the process with id \c srcProcessId and
	/// distributes it.  Each process (including the source) receives a portion of
	/// the send buffer.  Process 0 receives the first \c length values, process 1
	/// receives the second \c length values, and so on.  Scatter is the inverse
	/// operation of Gather.
	/// </summary>
	public int Scatter(IntPtr sendBuffer, IntPtr recvBuffer, long length, int srcProcessId)
	{
		return vtkCommunicator_Scatter_52(GetCppThis(), sendBuffer, recvBuffer, length, srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_Scatter_53(HandleRef pThis, string sendBuffer, string recvBuffer, long length, int srcProcessId);

	/// <summary>
	/// Scatter takes an array in the process with id \c srcProcessId and
	/// distributes it.  Each process (including the source) receives a portion of
	/// the send buffer.  Process 0 receives the first \c length values, process 1
	/// receives the second \c length values, and so on.  Scatter is the inverse
	/// operation of Gather.
	/// </summary>
	public int Scatter(string sendBuffer, string recvBuffer, long length, int srcProcessId)
	{
		return vtkCommunicator_Scatter_53(GetCppThis(), sendBuffer, recvBuffer, length, srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_Scatter_54(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int srcProcessId);

	/// <summary>
	/// Scatter takes an array in the process with id \c srcProcessId and
	/// distributes it.  Each process (including the source) receives a portion of
	/// the send buffer.  Process 0 receives the first \c length values, process 1
	/// receives the second \c length values, and so on.  Scatter is the inverse
	/// operation of Gather.
	/// </summary>
	public int Scatter(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int srcProcessId)
	{
		return vtkCommunicator_Scatter_54(GetCppThis(), sendBuffer?.GetCppThis() ?? default(HandleRef), recvBuffer?.GetCppThis() ?? default(HandleRef), srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_ScatterV_55(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId);

	/// <summary>
	/// ScatterV is the vector variant of Scatter.  It extends the functionality of
	/// Scatter by allowing a varying count of data to each process.
	/// ScatterV takes an array in the process with id \c srcProcessId and
	/// distributes it.  Each process (including the source) receives a portion of
	/// the send buffer defined by the \c sendLengths and \c offsets arrays.
	/// </summary>
	public int ScatterV(IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId)
	{
		return vtkCommunicator_ScatterV_55(GetCppThis(), sendBuffer, recvBuffer, sendLengths, offsets, recvLength, srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_ScatterV_56(HandleRef pThis, string sendBuffer, string recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId);

	/// <summary>
	/// ScatterV is the vector variant of Scatter.  It extends the functionality of
	/// Scatter by allowing a varying count of data to each process.
	/// ScatterV takes an array in the process with id \c srcProcessId and
	/// distributes it.  Each process (including the source) receives a portion of
	/// the send buffer defined by the \c sendLengths and \c offsets arrays.
	/// </summary>
	public int ScatterV(string sendBuffer, string recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId)
	{
		return vtkCommunicator_ScatterV_56(GetCppThis(), sendBuffer, recvBuffer, sendLengths, offsets, recvLength, srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_ScatterVVoidArray_57(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int type, int srcProcessId);

	/// <summary>
	/// Subclasses should reimplement these if they have a more efficient
	/// implementation.
	/// </summary>
	public virtual int ScatterVVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int type, int srcProcessId)
	{
		return vtkCommunicator_ScatterVVoidArray_57(GetCppThis(), sendBuffer, recvBuffer, sendLengths, offsets, recvLength, type, srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_ScatterVoidArray_58(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int srcProcessId);

	/// <summary>
	/// Subclasses should reimplement these if they have a more efficient
	/// implementation.
	/// </summary>
	public virtual int ScatterVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int srcProcessId)
	{
		return vtkCommunicator_ScatterVoidArray_58(GetCppThis(), sendBuffer, recvBuffer, length, type, srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_Send_59(HandleRef pThis, HandleRef data, int remoteHandle, int tag);

	/// <summary>
	/// This method sends a data object to a destination.
	/// Tag eliminates ambiguity
	/// and is used to match sends to receives.
	/// </summary>
	public int Send(vtkDataObject data, int remoteHandle, int tag)
	{
		return vtkCommunicator_Send_59(GetCppThis(), data?.GetCppThis() ?? default(HandleRef), remoteHandle, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_Send_60(HandleRef pThis, HandleRef data, int remoteHandle, int tag);

	/// <summary>
	/// This method sends a data array to a destination.
	/// Tag eliminates ambiguity
	/// and is used to match sends to receives.
	/// </summary>
	public int Send(vtkDataArray data, int remoteHandle, int tag)
	{
		return vtkCommunicator_Send_60(GetCppThis(), data?.GetCppThis() ?? default(HandleRef), remoteHandle, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_Send_61(HandleRef pThis, IntPtr data, long length, int remoteHandle, int tag);

	/// <summary>
	/// Convenience methods for sending data arrays.
	/// </summary>
	public int Send(IntPtr data, long length, int remoteHandle, int tag)
	{
		return vtkCommunicator_Send_61(GetCppThis(), data, length, remoteHandle, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_Send_62(HandleRef pThis, string data, long length, int remoteHandle, int tag);

	/// <summary>
	/// Convenience methods for sending data arrays.
	/// </summary>
	public int Send(string data, long length, int remoteHandle, int tag)
	{
		return vtkCommunicator_Send_62(GetCppThis(), data, length, remoteHandle, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_SendVoidArray_63(HandleRef pThis, IntPtr data, long length, int type, int remoteHandle, int tag);

	/// <summary>
	/// Subclasses have to supply this method to send various arrays of data.
	/// The \c type arg is one of the VTK type constants recognized by the
	/// vtkTemplateMacro (VTK_FLOAT, VTK_INT, etc.).  \c length is measured
	/// in number of values (as opposed to number of bytes).
	/// </summary>
	public virtual int SendVoidArray(IntPtr data, long length, int type, int remoteHandle, int tag)
	{
		return vtkCommunicator_SendVoidArray_63(GetCppThis(), data, length, type, remoteHandle, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommunicator_SetNumberOfProcesses_64(HandleRef pThis, int num);

	/// <summary>
	/// Set the number of processes you will be using.  This defaults
	/// to the maximum number available.  If you set this to a value
	/// higher than the default, you will get an error.
	/// </summary>
	public virtual void SetNumberOfProcesses(int num)
	{
		vtkCommunicator_SetNumberOfProcesses_64(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommunicator_SetUseCopy_65(int useCopy);

	/// <summary>
	/// Subclasses should reimplement these if they have a more efficient
	/// implementation.
	/// </summary>
	public static void SetUseCopy(int useCopy)
	{
		vtkCommunicator_SetUseCopy_65(useCopy);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunicator_UnMarshalDataObject_66(HandleRef buffer, HandleRef arg1);

	/// <summary>
	/// Convert a data object into a string that can be transmitted and vice versa.
	/// Returns 1 for success and 0 for failure.
	/// WARNING: This will only work for types that have a vtkDataWriter class.
	/// </summary>
	public static int UnMarshalDataObject(vtkCharArray buffer, vtkDataObject arg1)
	{
		return vtkCommunicator_UnMarshalDataObject_66(buffer?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}
}
