using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSocketController
/// </summary>
/// <remarks>
///    Process communication using Sockets
///
/// This is a concrete implementation of vtkMultiProcessController.
/// It supports one-to-one communication using sockets. Note that
/// process 0 will always correspond to self and process 1 to the
/// remote process. This class is best used with ports.
///
/// @bug
/// Note that because process 0 will always correspond to self, this class breaks
/// assumptions usually implied when using ad-hoc polymorphism.  That is, the
/// vtkSocketController will behave differently than other subclasses of
/// vtkMultiProcessController.  If you upcast vtkSocketController to
/// vtkMultiProcessController and send it to a method that does not know that the
/// object is actually a vtkSocketController, the object may not behave as
/// intended.  For example, if that oblivious class chose to identify a "root"
/// based on the local process id, then both sides of the controller will think
/// they are the root (and that will probably lead to deadlock).  If you plan to
/// upcast to vtkMultiProcessController, you should probably use the
/// CreateCompliantController instead.
///
/// </remarks>
/// <seealso>
///
/// vtkMultiProcessController vtkSocketCommunicator vtkInputPort vtkOutputPort
/// </seealso>
public class vtkSocketController : vtkMultiProcessController
{
	/// <summary>
	/// FOOLISH MORTALS!  Thou hast forsaken the sacred laws of ad-hoc polymorphism
	/// when thou broke a critical assumption of the superclass (namely, each
	/// process has thine own id).  The time frame to fix thy error has passed.
	/// Too much code has come to rely on this abhorrent behavior.  Instead, we
	/// offer this gift: a method for creating an equivalent communicator with
	/// correct process id semantics.  The calling code is responsible for
	/// deleting this controller.
	/// </summary>
	public new enum Consts
	{
		/// <summary>enum member</summary>
		ENDIAN_TAG = 1010580540,
		/// <summary>enum member</summary>
		HASH_TAG = 1061109567,
		/// <summary>enum member</summary>
		IDTYPESIZE_TAG = 1027423549,
		/// <summary>enum member</summary>
		VERSION_TAG = 1044266558
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSocketController";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSocketController()
	{
		MRClassNameKey = "class vtkSocketController";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSocketController"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSocketController(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSocketController_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSocketController New()
	{
		vtkSocketController result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSocketController_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSocketController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSocketController()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSocketController_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSocketController_CloseConnection_01(HandleRef pThis);

	/// <summary>
	/// Close a connection, forwarded
	/// to the communicator
	/// </summary>
	public virtual void CloseConnection()
	{
		vtkSocketController_CloseConnection_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketController_ConnectTo_02(HandleRef pThis, string hostName, int port);

	/// <summary>
	/// Open a connection to a give machine, forwarded
	/// to the communicator
	/// </summary>
	public virtual int ConnectTo(string hostName, int port)
	{
		return vtkSocketController_ConnectTo_02(GetCppThis(), hostName, port);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSocketController_CreateCompliantController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// FOOLISH MORTALS!  Thou hast forsaken the sacred laws of ad-hoc polymorphism
	/// when thou broke a critical assumption of the superclass (namely, each
	/// process has thine own id).  The time frame to fix thy error has passed.
	/// Too much code has come to rely on this abhorrent behavior.  Instead, we
	/// offer this gift: a method for creating an equivalent communicator with
	/// correct process id semantics.  The calling code is responsible for
	/// deleting this controller.
	/// </summary>
	public vtkMultiProcessController CreateCompliantController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSocketController_CreateCompliantController_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSocketController_CreateOutputWindow_04(HandleRef pThis);

	/// <summary>
	/// Does not apply to sockets. Does nothing.
	/// </summary>
	public override void CreateOutputWindow()
	{
		vtkSocketController_CreateOutputWindow_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocketController_Finalize_05(HandleRef pThis);

	/// <summary>
	/// Does not apply to sockets. Does nothing.
	/// </summary>
	public override void FinalizeWrapper()
	{
		vtkSocketController_Finalize_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocketController_Finalize_06(HandleRef pThis, int arg0);

	/// <summary>
	/// Does not apply to sockets. Does nothing.
	/// </summary>
	public override void FinalizeWrapper(int arg0)
	{
		vtkSocketController_Finalize_06(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSocketController_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSocketController_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSocketController_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSocketController_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketController_GetSwapBytesInReceivedData_09(HandleRef pThis);

	/// <summary>
	/// Open a connection to a give machine, forwarded
	/// to the communicator
	/// </summary>
	public int GetSwapBytesInReceivedData()
	{
		return vtkSocketController_GetSwapBytesInReceivedData_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocketController_Initialize_10(HandleRef pThis);

	/// <summary>
	/// This method is for initialiazing sockets.
	/// One of these is REQUIRED for Windows.
	/// </summary>
	public virtual void Initialize()
	{
		vtkSocketController_Initialize_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketController_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSocketController_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketController_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSocketController_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocketController_MultipleMethodExecute_13(HandleRef pThis);

	/// <summary>
	/// Does not apply to sockets.  Does nothing.
	/// </summary>
	public override void MultipleMethodExecute()
	{
		vtkSocketController_MultipleMethodExecute_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSocketController_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSocketController NewInstance()
	{
		vtkSocketController result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSocketController_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSocketController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSocketController_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSocketController SafeDownCast(vtkObjectBase o)
	{
		vtkSocketController vtkSocketController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSocketController_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSocketController2 = (vtkSocketController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSocketController2.Register(null);
			}
		}
		return vtkSocketController2;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocketController_SetCommunicator_17(HandleRef pThis, HandleRef comm);

	/// <summary>
	/// Set the communicator used in normal and rmi communications.
	/// </summary>
	public void SetCommunicator(vtkSocketCommunicator comm)
	{
		vtkSocketController_SetCommunicator_17(GetCppThis(), comm?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSocketController_SingleMethodExecute_18(HandleRef pThis);

	/// <summary>
	/// Does not apply to sockets. Does nothing.
	/// </summary>
	public override void SingleMethodExecute()
	{
		vtkSocketController_SingleMethodExecute_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSocketController_WaitForConnection_19(HandleRef pThis, int port);

	/// <summary>
	/// Wait for connection on a given port, forwarded
	/// to the communicator
	/// </summary>
	public virtual int WaitForConnection(int port)
	{
		return vtkSocketController_WaitForConnection_19(GetCppThis(), port);
	}
}
