using System;

namespace Kitware.VTK;

/// <summary>
/// The sender of each ActiViz.NET event passes itself as its "sender"
/// parameter and an instance of vtkObjectEventArgs as its "e" parameter.
/// </summary>
public class vtkObjectEventArgs : EventArgs
{
	private vtkObject m_Caller;

	private uint m_EventId;

	private IntPtr m_CallData;

	/// <summary>
	/// Caller is the object that invoked the event. Usually it is the same
	/// object as the event handler's "sender" parameter.
	/// </summary>
	public vtkObject Caller => m_Caller;

	/// <summary>
	/// EventId is usually a value in the vtkCommand.EventIds enum. It is
	/// primarily useful for handlers of the "Any" event. The "Any" event
	/// fires whenever any other event is invoked from a given vtkObject. In
	/// that case, the EventId passed with the event indicates the actual
	/// event that was invoked.
	///
	/// It is also useful in the case of user defined events, where the event
	/// id value is outside the pre-defined range of vtkCommand.EventIds.
	/// </summary>
	public uint EventId => m_EventId;

	/// <summary>
	/// CallData varies based on what event is firing. It is frequently
	/// IntPtr.Zero (NULL from C++)... If non-zero, see the documentation
	/// of the specific event for the type of the data.
	/// </summary>
	public IntPtr CallData => m_CallData;

	/// <summary>
	/// Each ActiViz.NET event automatically constructs a vtkObjectEventArgs to
	/// pass to its handlers. Client ActiViz.NET applications do not need to
	/// call this vtkObjectEventArgs constructor.
	/// </summary>
	public vtkObjectEventArgs(vtkObject caller, uint eventId, IntPtr callData)
	{
		m_Caller = caller;
		m_EventId = eventId;
		m_CallData = callData;
	}
}
