using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkClientSocket
/// </summary>
/// <remarks>
///    Encapsulates a client socket.
/// </remarks>
public class vtkClientSocket : vtkSocket
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkClientSocket";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkClientSocket()
	{
		MRClassNameKey = "class vtkClientSocket";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkClientSocket"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkClientSocket(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClientSocket_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkClientSocket New()
	{
		vtkClientSocket result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClientSocket_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkClientSocket)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkClientSocket()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkClientSocket_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClientSocket_ConnectToServer_01(HandleRef pThis, string hostname, int port);

	/// <summary>
	/// Connects to host. Returns 0 on success, -1 on error.
	/// </summary>
	public int ConnectToServer(string hostname, int port)
	{
		return vtkClientSocket_ConnectToServer_01(GetCppThis(), hostname, port);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkClientSocket_GetConnectingSide_02(HandleRef pThis);

	/// <summary>
	/// Returns if the socket is on the connecting side (the side that requests a
	/// ConnectToServer() or on the connected side (the side that was waiting for
	/// the client to connect). This is used to disambiguate the two ends of a socket
	/// connection.
	/// </summary>
	public virtual bool GetConnectingSide()
	{
		return (vtkClientSocket_GetConnectingSide_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkClientSocket_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkClientSocket_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkClientSocket_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkClientSocket_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClientSocket_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkClientSocket_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClientSocket_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkClientSocket_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClientSocket_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkClientSocket NewInstance()
	{
		vtkClientSocket result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClientSocket_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkClientSocket)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClientSocket_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkClientSocket SafeDownCast(vtkObjectBase o)
	{
		vtkClientSocket vtkClientSocket2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClientSocket_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
}
