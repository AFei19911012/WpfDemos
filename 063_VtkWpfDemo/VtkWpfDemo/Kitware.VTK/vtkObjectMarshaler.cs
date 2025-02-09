using System;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
/// Custom marshaller for conversion to/from a System.IntPtr.
/// </summary>
public class vtkObjectMarshaler : ICustomMarshaler
{
	private static ICustomMarshaler TheInstance = new vtkObjectMarshaler();

	void ICustomMarshaler.CleanUpManagedData(object ManagedObj)
	{
	}

	void ICustomMarshaler.CleanUpNativeData(IntPtr pNativeData)
	{
	}

	int ICustomMarshaler.GetNativeDataSize()
	{
		return IntPtr.Size;
	}

	IntPtr ICustomMarshaler.MarshalManagedToNative(object ManagedObj)
	{
		return ((vtkObject)ManagedObj).GetCppThis().Handle;
	}

	object ICustomMarshaler.MarshalNativeToManaged(IntPtr pNativeData)
	{
		bool found;
		object obj = Methods.CreateWrappedObject(0u, uint.MaxValue, 4294967208u, pNativeData, callDisposalMethod: true, out found);
		if (obj == null)
		{
			Console.Error.WriteLine("error: *DID NOT FIND* o in MarshalNativeToManaged");
			obj = new vtkObject(pNativeData, callDisposalMethod: false, strong: false);
		}
		return obj;
	}

	/// <summary>
	/// Get the custom marshaller for vtkObject objects.
	/// </summary>
	public static ICustomMarshaler GetInstance(string cookie)
	{
		return TheInstance;
	}
}
