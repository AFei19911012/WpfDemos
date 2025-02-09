using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSocketCommunicator
/// </summary>
/// <remarks>
///    Process communication using Sockets
///
/// This is a concrete implementation of vtkCommunicator which supports
/// interprocess communication using BSD style sockets.
/// It supports byte swapping for the communication of machines
/// with different endianness.
///
/// @warning
/// Communication between 32 bit and 64 bit systems is not fully
/// supported. If a type does not have the same length on both
/// systems, this communicator can not be used to transfer data
/// of that type.
///
/// </remarks>
/// <seealso>
///
/// vtkCommunicator vtkSocketController
/// </seealso>
public class vtkSocketCommunicator : vtkCommunicator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSocketCommunicator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSocketCommunicator()
	{
		MRClassNameKey = "class vtkSocketCommunicator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSocketCommunicator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSocketCommunicator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSocketCommunicator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSocketCommunicator New()
	{
		vtkSocketCommunicator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSocketCommunicator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSocketCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSocketCommunicator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSocketCommunicator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkSocketCommunicator_AllGatherVVoidArray_01(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type);

	/// <summary>
	/// This class foolishly breaks the conventions of the superclass, so the
	/// default implementations of these methods do not work.  These just give
	/// errors instead.
	/// </summary>
	public override int AllGatherVVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type)
	{
		return vtkSocketCommunicator_AllGatherVVoidArray_01(GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_AllGatherVoidArray_02(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type);

	/// <summary>
	/// This class foolishly breaks the conventions of the superclass, so the
	/// default implementations of these methods do not work.  These just give
	/// errors instead.
	/// </summary>
	public override int AllGatherVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type)
	{
		return vtkSocketCommunicator_AllGatherVoidArray_02(GetCppThis(), sendBuffer, recvBuffer, length, type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_AllReduceVoidArray_03(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation);

	/// <summary>
	/// This class foolishly breaks the conventions of the superclass, so the
	/// default implementations of these methods do not work.  These just give
	/// errors instead.
	/// </summary>
	public override int AllReduceVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation)
	{
		return vtkSocketCommunicator_AllReduceVoidArray_03(GetCppThis(), sendBuffer, recvBuffer, length, type, operation);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocketCommunicator_Barrier_04(HandleRef pThis);

	/// <summary>
	/// This class foolishly breaks the conventions of the superclass, so this
	/// overload fixes the method.
	/// </summary>
	public override void Barrier()
	{
		vtkSocketCommunicator_Barrier_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_BroadcastVoidArray_05(HandleRef pThis, IntPtr data, long length, int type, int srcProcessId);

	/// <summary>
	/// This class foolishly breaks the conventions of the superclass, so the
	/// default implementations of these methods do not work.  These just give
	/// errors instead.
	/// </summary>
	public override int BroadcastVoidArray(IntPtr data, long length, int type, int srcProcessId)
	{
		return vtkSocketCommunicator_BroadcastVoidArray_05(GetCppThis(), data, length, type, srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocketCommunicator_BufferCurrentMessage_06(HandleRef pThis);

	/// <summary>
	/// This flag is cleared before vtkCommand::WrongTagEvent is fired when ever a
	/// message with mismatched tag is received. If the handler wants the message
	/// to be buffered for later use, it should set this flag to true. In which
	/// case the vtkSocketCommunicator will buffer the message and it will be
	/// automatically processed the next time one does a ReceiveTagged() with a
	/// matching tag.
	/// </summary>
	public void BufferCurrentMessage()
	{
		vtkSocketCommunicator_BufferCurrentMessage_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_ClientSideHandshake_07(HandleRef pThis);

	/// <summary>
	/// Performs ClientSide handshake.
	/// One should preferably use Handshake() which calls ServerSideHandshake or
	/// ClientSideHandshake as required.
	/// </summary>
	public int ClientSideHandshake()
	{
		return vtkSocketCommunicator_ClientSideHandshake_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocketCommunicator_CloseConnection_08(HandleRef pThis);

	/// <summary>
	/// Close a connection.
	/// </summary>
	public virtual void CloseConnection()
	{
		vtkSocketCommunicator_CloseConnection_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_ConnectTo_09(HandleRef pThis, string hostName, int port);

	/// <summary>
	/// Open a connection to host.
	/// </summary>
	public virtual int ConnectTo(string hostName, int port)
	{
		return vtkSocketCommunicator_ConnectTo_09(GetCppThis(), hostName, port);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_GatherVVoidArray_10(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type, int destProcessId);

	/// <summary>
	/// This class foolishly breaks the conventions of the superclass, so the
	/// default implementations of these methods do not work.  These just give
	/// errors instead.
	/// </summary>
	public override int GatherVVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type, int destProcessId)
	{
		return vtkSocketCommunicator_GatherVVoidArray_10(GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, type, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_GatherVoidArray_11(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int destProcessId);

	/// <summary>
	/// This class foolishly breaks the conventions of the superclass, so the
	/// default implementations of these methods do not work.  These just give
	/// errors instead.
	/// </summary>
	public override int GatherVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int destProcessId)
	{
		return vtkSocketCommunicator_GatherVoidArray_11(GetCppThis(), sendBuffer, recvBuffer, length, type, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_GetIsConnected_12(HandleRef pThis);

	/// <summary>
	/// Is the communicator connected?.
	/// </summary>
	public int GetIsConnected()
	{
		return vtkSocketCommunicator_GetIsConnected_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_GetIsServer_13(HandleRef pThis);

	/// <summary>
	/// Returns true if this side of the socket is the server.  The result
	/// is invalid if the socket is not connected.
	/// </summary>
	public virtual int GetIsServer()
	{
		return vtkSocketCommunicator_GetIsServer_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSocketCommunicator_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSocketCommunicator_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSocketCommunicator_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSocketCommunicator_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_GetPerformHandshake_16(HandleRef pThis);

	/// <summary>
	/// Set or get the PerformHandshake ivar. If it is on, the communicator
	/// will try to perform a handshake when connected.
	/// It is on by default.
	/// </summary>
	public virtual int GetPerformHandshake()
	{
		return vtkSocketCommunicator_GetPerformHandshake_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_GetPerformHandshakeMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Set or get the PerformHandshake ivar. If it is on, the communicator
	/// will try to perform a handshake when connected.
	/// It is on by default.
	/// </summary>
	public virtual int GetPerformHandshakeMaxValue()
	{
		return vtkSocketCommunicator_GetPerformHandshakeMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_GetPerformHandshakeMinValue_18(HandleRef pThis);

	/// <summary>
	/// Set or get the PerformHandshake ivar. If it is on, the communicator
	/// will try to perform a handshake when connected.
	/// It is on by default.
	/// </summary>
	public virtual int GetPerformHandshakeMinValue()
	{
		return vtkSocketCommunicator_GetPerformHandshakeMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_GetReportErrors_19(HandleRef pThis);

	/// <summary>
	/// If ReportErrors if false, all vtkErrorMacros are suppressed.
	/// </summary>
	public virtual int GetReportErrors()
	{
		return vtkSocketCommunicator_GetReportErrors_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSocketCommunicator_GetSocket_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the actual socket used for communication.
	/// </summary>
	public virtual vtkClientSocket GetSocket()
	{
		vtkClientSocket vtkClientSocket2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSocketCommunicator_GetSocket_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkClientSocket2 = (vtkClientSocket)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkClientSocket2.Register(null);
			}
		}
		return vtkClientSocket2;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_GetSwapBytesInReceivedData_21(HandleRef pThis);

	/// <summary>
	/// Returns 1 if bytes must be swapped in received ints, floats, etc
	/// </summary>
	public virtual int GetSwapBytesInReceivedData()
	{
		return vtkSocketCommunicator_GetSwapBytesInReceivedData_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_GetVersion_22();

	/// <summary>
	/// Uniquely identifies the version of this class.  If the versions match,
	/// then the socket communicators should be compatible.
	/// </summary>
	public static int GetVersion()
	{
		return vtkSocketCommunicator_GetVersion_22();
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_Handshake_23(HandleRef pThis);

	/// <summary>
	/// Performs handshake. This uses vtkClientSocket::ConnectingSide to decide
	/// whether to perform ServerSideHandshake or ClientSideHandshake.
	/// </summary>
	public int Handshake()
	{
		return vtkSocketCommunicator_Handshake_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSocketCommunicator_HasBufferredMessages_24(HandleRef pThis);

	/// <summary>
	/// Returns true if there are any messages in the receive buffer.
	/// </summary>
	public bool HasBufferredMessages()
	{
		return (vtkSocketCommunicator_HasBufferredMessages_24(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_IsA_25(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSocketCommunicator_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_IsTypeOf_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSocketCommunicator_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_LogToFile_27(HandleRef pThis, string name);

	/// <summary>
	/// Log messages to the given file.  The file is truncated unless the
	/// second argument is non-zero (default is to truncate).  If the
	/// file name is empty or nullptr, logging is disabled.  Returns 0 if
	/// the file failed to open, and 1 otherwise.
	/// </summary>
	public virtual int LogToFile(string name)
	{
		return vtkSocketCommunicator_LogToFile_27(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_LogToFile_28(HandleRef pThis, string name, int append);

	/// <summary>
	/// Log messages to the given file.  The file is truncated unless the
	/// second argument is non-zero (default is to truncate).  If the
	/// file name is empty or nullptr, logging is disabled.  Returns 0 if
	/// the file failed to open, and 1 otherwise.
	/// </summary>
	public virtual int LogToFile(string name, int append)
	{
		return vtkSocketCommunicator_LogToFile_28(GetCppThis(), name, append);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSocketCommunicator_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSocketCommunicator NewInstance()
	{
		vtkSocketCommunicator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSocketCommunicator_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSocketCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocketCommunicator_PerformHandshakeOff_31(HandleRef pThis);

	/// <summary>
	/// Set or get the PerformHandshake ivar. If it is on, the communicator
	/// will try to perform a handshake when connected.
	/// It is on by default.
	/// </summary>
	public virtual void PerformHandshakeOff()
	{
		vtkSocketCommunicator_PerformHandshakeOff_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocketCommunicator_PerformHandshakeOn_32(HandleRef pThis);

	/// <summary>
	/// Set or get the PerformHandshake ivar. If it is on, the communicator
	/// will try to perform a handshake when connected.
	/// It is on by default.
	/// </summary>
	public virtual void PerformHandshakeOn()
	{
		vtkSocketCommunicator_PerformHandshakeOn_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_ReceiveVoidArray_33(HandleRef pThis, IntPtr data, long length, int type, int remoteHandle, int tag);

	/// <summary>
	/// Performs the actual communication.  You will usually use the convenience
	/// Send functions defined in the superclass.
	/// </summary>
	public override int ReceiveVoidArray(IntPtr data, long length, int type, int remoteHandle, int tag)
	{
		return vtkSocketCommunicator_ReceiveVoidArray_33(GetCppThis(), data, length, type, remoteHandle, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_ReduceVoidArray_34(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation, int destProcessId);

	/// <summary>
	/// This class foolishly breaks the conventions of the superclass, so the
	/// default implementations of these methods do not work.  These just give
	/// errors instead.
	/// </summary>
	public override int ReduceVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation, int destProcessId)
	{
		return vtkSocketCommunicator_ReduceVoidArray_34(GetCppThis(), sendBuffer, recvBuffer, length, type, operation, destProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSocketCommunicator_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSocketCommunicator SafeDownCast(vtkObjectBase o)
	{
		vtkSocketCommunicator vtkSocketCommunicator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSocketCommunicator_SafeDownCast_35(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSocketCommunicator2 = (vtkSocketCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSocketCommunicator2.Register(null);
			}
		}
		return vtkSocketCommunicator2;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_ScatterVVoidArray_36(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int type, int srcProcessId);

	/// <summary>
	/// This class foolishly breaks the conventions of the superclass, so the
	/// default implementations of these methods do not work.  These just give
	/// errors instead.
	/// </summary>
	public override int ScatterVVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int type, int srcProcessId)
	{
		return vtkSocketCommunicator_ScatterVVoidArray_36(GetCppThis(), sendBuffer, recvBuffer, sendLengths, offsets, recvLength, type, srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_ScatterVoidArray_37(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int srcProcessId);

	/// <summary>
	/// This class foolishly breaks the conventions of the superclass, so the
	/// default implementations of these methods do not work.  These just give
	/// errors instead.
	/// </summary>
	public override int ScatterVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int srcProcessId)
	{
		return vtkSocketCommunicator_ScatterVoidArray_37(GetCppThis(), sendBuffer, recvBuffer, length, type, srcProcessId);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_SendVoidArray_38(HandleRef pThis, IntPtr data, long length, int type, int remoteHandle, int tag);

	/// <summary>
	/// Performs the actual communication.  You will usually use the convenience
	/// Send functions defined in the superclass.
	/// </summary>
	public override int SendVoidArray(IntPtr data, long length, int type, int remoteHandle, int tag)
	{
		return vtkSocketCommunicator_SendVoidArray_38(GetCppThis(), data, length, type, remoteHandle, tag);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_ServerSideHandshake_39(HandleRef pThis);

	/// <summary>
	/// Performs ServerSide handshake.
	/// One should preferably use Handshake() which calls ServerSideHandshake or
	/// ClientSideHandshake as required.
	/// </summary>
	public int ServerSideHandshake()
	{
		return vtkSocketCommunicator_ServerSideHandshake_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocketCommunicator_SetNumberOfProcesses_40(HandleRef pThis, int num);

	/// <summary>
	/// Set the number of processes you will be using.
	/// </summary>
	public override void SetNumberOfProcesses(int num)
	{
		vtkSocketCommunicator_SetNumberOfProcesses_40(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocketCommunicator_SetPerformHandshake_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Set or get the PerformHandshake ivar. If it is on, the communicator
	/// will try to perform a handshake when connected.
	/// It is on by default.
	/// </summary>
	public virtual void SetPerformHandshake(int _arg)
	{
		vtkSocketCommunicator_SetPerformHandshake_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocketCommunicator_SetReportErrors_42(HandleRef pThis, int _arg);

	/// <summary>
	/// If ReportErrors if false, all vtkErrorMacros are suppressed.
	/// </summary>
	public virtual void SetReportErrors(int _arg)
	{
		vtkSocketCommunicator_SetReportErrors_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocketCommunicator_SetSocket_43(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set the actual socket used for communication.
	/// </summary>
	public void SetSocket(vtkClientSocket arg0)
	{
		vtkSocketCommunicator_SetSocket_43(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_WaitForConnection_44(HandleRef pThis, int port);

	/// <summary>
	/// Wait for connection on a given port.
	/// These methods return 1 on success, 0 on error.
	/// </summary>
	public virtual int WaitForConnection(int port)
	{
		return vtkSocketCommunicator_WaitForConnection_44(GetCppThis(), port);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketCommunicator_WaitForConnection_45(HandleRef pThis, HandleRef socket, uint msec);

	/// <summary>
	/// Wait for connection on a given port.
	/// These methods return 1 on success, 0 on error.
	/// </summary>
	public virtual int WaitForConnection(vtkServerSocket socket, uint msec)
	{
		return vtkSocketCommunicator_WaitForConnection_45(GetCppThis(), socket?.GetCppThis() ?? default(HandleRef), msec);
	}
}
