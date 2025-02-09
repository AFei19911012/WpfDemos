using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
/// Implement a relay handler for VTK events. This is a class
/// that receives events directly from the VTK object sender and
/// transforms them into calls to .NET delegates.
/// </summary>
public class vtkObjectEventRelay : WrappedObject
{
	/// <summary>
	/// Signature for method that vtkObject can call for VTK events.
	/// </summary>
	public delegate void RelayHandler(IntPtr caller, uint eventId, IntPtr callData);

	/// <summary>
	/// Type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkObjectEventRelay";

	/// <summary>
	/// Type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	private vtkObject Sender;

	private uint EventId;

	private vtkObject.vtkObjectEventHandler EventImpl;

	private uint ObserverId;

	private RelayHandler RelayHandlerDelegate;

	/// <summary>
	/// Type registration mechanics.
	/// </summary>
	static vtkObjectEventRelay()
	{
		MRClassNameKey = "class vtkObjectEventRelay";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkObjectEventRelay"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkObjectEventRelay(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObjectEventRelay_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a vtkObjectEventRelay object that will call "handler" when its
	/// Execute method gets called. Typically, it is not necessary to create
	/// instances of vtkObjectEventRelay from client applications. Usually, clients
	/// will just connect to ActiViz.NET events, which use vtkObjectEventRelay
	/// internally. However, vtkObjectEventRelay is suitable for use as the
	/// vtkCommand parameter to AddObserver calls.
	/// </summary>
	public vtkObjectEventRelay(vtkObject sender, uint eventId)
		: base(IntPtr.Zero, callDisposalMethod: true, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkObjectEventRelay_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		SetCppThis(rawCppThis, callDisposalMethod: true, (mteStatus != 0 && rawRefCount >= 2) ? true : false);
		Sender = sender;
		EventId = eventId;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObjectEventRelay_Delete(HandleRef pThis);

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (GetCallDisposalMethod())
			{
				vtkObjectEventRelay_Delete(GetCppThis());
				ClearCppThis();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkObjectEventRelay_AddObserver(HandleRef pThis, HandleRef sender, uint eventid, RelayHandler handler, float priority);

	private uint AddObserver()
	{
		if (null == RelayHandlerDelegate)
		{
			RelayHandlerDelegate = Execute;
		}
		return vtkObjectEventRelay_AddObserver(GetCppThis(), (Sender == null) ? default(HandleRef) : Sender.GetCppThis(), EventId, RelayHandlerDelegate, 0f);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkObjectEventRelay_RemoveObserver(HandleRef pThis, uint observerId);

	private void RemoveObserver(uint observerId)
	{
		vtkObjectEventRelay_RemoveObserver(GetCppThis(), observerId);
	}

	private void CallAddObserver()
	{
		if (ObserverId == 0 && Sender != null && IntPtr.Zero != Sender.GetCppThis().Handle)
		{
			ObserverId = AddObserver();
		}
	}

	private void CallRemoveObserver()
	{
		if (ObserverId != 0 && Sender != null && IntPtr.Zero != Sender.GetCppThis().Handle)
		{
			RemoveObserver(ObserverId);
			ObserverId = 0u;
		}
	}

	/// <summary>
	/// Do not call directly. This method is called from VTK library code when
	/// InvokeEvent is called on a vtkObject.
	/// </summary>
	public void Execute(IntPtr caller, uint eventId, IntPtr callData)
	{
		if (null != EventImpl)
		{
			bool found;
			vtkObject caller2 = (vtkObject)Methods.CreateWrappedObject(0u, uint.MaxValue, 4294967208u, caller, callDisposalMethod: true, out found);
			EventImpl(Sender, new vtkObjectEventArgs(caller2, eventId, callData));
		}
	}

	/// <summary>
	/// AddHandler adds a managed/.NET event handler to this event relay object.
	/// If this is the first time a handler is being added, we call AddObserver
	/// so that the underlying VTK object will invoke the event from now on.
	/// </summary>
	public void AddHandler(vtkObject.vtkObjectEventHandler handler)
	{
		if (null == EventImpl)
		{
			CallAddObserver();
		}
		EventImpl = (vtkObject.vtkObjectEventHandler)Delegate.Combine(EventImpl, handler);
	}

	/// <summary>
	/// RemoveHandler removes a managed/.NET event handler previously added to
	/// this event relay object.
	/// If this is the last handler being removed, we call RemoveObserver
	/// so that the underlying VTK object will no longer send the event to us.
	/// </summary>
	public void RemoveHandler(vtkObject.vtkObjectEventHandler handler)
	{
		EventImpl = (vtkObject.vtkObjectEventHandler)Delegate.Remove(EventImpl, handler);
		if (null == EventImpl)
		{
			CallRemoveObserver();
		}
	}

	/// <summary>
	/// HasHandlers returns true if this event presently has any managed/.NET
	/// handlers.
	/// </summary>
	public bool HasHandlers()
	{
		return null != EventImpl;
	}

	/// <summary>
	/// RemoveAllHandlers forcibly removes all existing handlers from its list.
	/// Sender should call this method from its Dispose if it has one.
	/// </summary>
	public void RemoveAllHandlers()
	{
		CallRemoveObserver();
		EventImpl = null;
		Sender = null;
	}
}
