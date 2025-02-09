using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkServerSocket
/// </summary>
/// <remarks>
///    Encapsulate a socket that accepts connections.
///
///
/// </remarks>
public class vtkServerSocket : vtkSocket
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkServerSocket";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkServerSocket()
	{
		MRClassNameKey = "class vtkServerSocket";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkServerSocket"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkServerSocket(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkServerSocket_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkServerSocket New()
	{
		vtkServerSocket result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkServerSocket_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkServerSocket)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkServerSocket()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkServerSocket_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkServerSocket_CreateServer_01(HandleRef pThis, int port);

	/// <summary>
	/// Creates a server socket at a given port and binds to it.
	/// Returns -1 on error. 0 on success.
	/// </summary>
	public int CreateServer(int port)
	{
		return vtkServerSocket_CreateServer_01(GetCppThis(), port);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkServerSocket_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkServerSocket_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkServerSocket_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkServerSocket_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkServerSocket_GetServerPort_04(HandleRef pThis);

	/// <summary>
	/// Returns the port on which the server is running.
	/// </summary>
	public int GetServerPort()
	{
		return vtkServerSocket_GetServerPort_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkServerSocket_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkServerSocket_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkServerSocket_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkServerSocket_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkServerSocket_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkServerSocket NewInstance()
	{
		vtkServerSocket result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkServerSocket_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkServerSocket)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkServerSocket_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkServerSocket SafeDownCast(vtkObjectBase o)
	{
		vtkServerSocket vtkServerSocket2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkServerSocket_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkServerSocket2 = (vtkServerSocket)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkServerSocket2.Register(null);
			}
		}
		return vtkServerSocket2;
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkServerSocket_WaitForConnection_10(HandleRef pThis, uint msec, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Waits for a connection. When a connection is received
	/// a new vtkClientSocket object is created and returned.
	/// Returns nullptr on timeout.
	/// </summary>
	public vtkClientSocket WaitForConnection(uint msec)
	{
		vtkClientSocket vtkClientSocket2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkServerSocket_WaitForConnection_10(GetCppThis(), msec, ref mteStatus, ref mteIndex, ref rawRefCount);
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
