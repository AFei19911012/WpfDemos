using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSocket
/// </summary>
/// <remarks>
///    BSD socket encapsulation.
///
/// This abstract class encapsulates a BSD socket. It provides an API for
/// basic socket operations.
/// </remarks>
public class vtkSocket : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSocket";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSocket()
	{
		MRClassNameKey = "class vtkSocket";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSocket"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSocket(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocket_CloseSocket_01(HandleRef pThis);

	/// <summary>
	/// Close the socket.
	/// </summary>
	public void CloseSocket()
	{
		vtkSocket_CloseSocket_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocket_GetConnected_02(HandleRef pThis);

	/// <summary>
	/// Check is the socket is alive.
	/// </summary>
	public int GetConnected()
	{
		return vtkSocket_GetConnected_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSocket_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSocket_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSocket_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSocket_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocket_GetSocketDescriptor_05(HandleRef pThis);

	/// <summary>
	/// Provides access to the internal socket descriptor. This is valid only when
	/// GetConnected() returns true.
	/// </summary>
	public virtual int GetSocketDescriptor()
	{
		return vtkSocket_GetSocketDescriptor_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocket_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSocket_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocket_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSocket_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSocket_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSocket NewInstance()
	{
		vtkSocket result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSocket_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSocket)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocket_Receive_09(HandleRef pThis, IntPtr data, int length, int readFully);

	/// <summary>
	/// Receive data from the socket.
	/// This call blocks until some data is read from the socket.
	/// When readFully is set, this call will block until all the
	/// requested data is read from the socket.
	/// 0 on error, else number of bytes read is returned. On error,
	/// vtkCommand::ErrorEvent is raised.
	/// </summary>
	public int Receive(IntPtr data, int length, int readFully)
	{
		return vtkSocket_Receive_09(GetCppThis(), data, length, readFully);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSocket_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSocket SafeDownCast(vtkObjectBase o)
	{
		vtkSocket vtkSocket2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSocket_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSocket2 = (vtkSocket)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSocket2.Register(null);
			}
		}
		return vtkSocket2;
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocket_SelectSockets_11(IntPtr sockets_to_select, int size, uint msec, IntPtr selected_index);

	/// <summary>
	/// Selects set of sockets. Returns 0 on timeout, -1 on error.
	/// 1 on success. Selected socket's index is returned through
	/// selected_index
	/// </summary>
	public static int SelectSockets(IntPtr sockets_to_select, int size, uint msec, IntPtr selected_index)
	{
		return vtkSocket_SelectSockets_11(sockets_to_select, size, msec, selected_index);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocket_Send_12(HandleRef pThis, IntPtr data, int length);

	/// <summary>
	/// These methods send data over the socket.
	/// Returns 1 on success, 0 on error and raises vtkCommand::ErrorEvent.
	/// </summary>
	public int Send(IntPtr data, int length)
	{
		return vtkSocket_Send_12(GetCppThis(), data, length);
	}
}
