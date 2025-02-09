using System;
using System.Runtime.InteropServices;

namespace Kitware.mummy.Runtime;

public class WrappedException : Exception, IDisposable
{
	public const string MRFullTypeName = "Kitware.mummy.Runtime.WrappedException";

	public static readonly string MRClassNameKey;

	private HandleRef CppThis;

	private bool CallDisposalMethod;

	static WrappedException()
	{
		MRClassNameKey = "no equivalent unmanaged class";
	}

	protected WrappedException(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
	{
		SetCppThis(rawCppThis, callDisposalMethod, strong);
	}

	~WrappedException()
	{
		Dispose(disposing: false);
	}

	public HandleRef GetCppThis()
	{
		return CppThis;
	}

	protected void SetCppThis(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
	{
		CppThis = new HandleRef(this, rawCppThis);
		CallDisposalMethod = callDisposalMethod;
		if (rawCppThis != IntPtr.Zero)
		{
			Methods.AddTableReference(rawCppThis, this, strong);
		}
	}

	protected void ClearCppThis()
	{
		if (CppThis.Handle != IntPtr.Zero)
		{
			Methods.RemoveTableReference(CppThis.Handle);
		}
		CppThis = default(HandleRef);
		CallDisposalMethod = false;
	}

	protected bool GetCallDisposalMethod()
	{
		return CallDisposalMethod;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
	}
}
