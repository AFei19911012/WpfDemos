using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStateStorage
/// </summary>
/// <remarks>
///    Class to make storing and comparing state quick and easy
///
/// vtkStateStorage is just a thin wrapper around std::vector&lt;unsigned char&gt;
/// It is best to use this class as an ivar so that allocs do not happen
/// too often.
///
/// Example usage:
/// @code
///
/// // compute the new state in a temp ivar
/// // note that clear does not free memory
/// this-&gt;TempState.Clear();
/// this-&gt;TempState.Append(act-&gt;GetProperty()-&gt;GetMTime(), "property mtime");
/// this-&gt;TempState.Append(
///   this-&gt;CurrentInput ? this-&gt;CurrentInput-&gt;GetMTime() : 0, "input mtime");
/// this-&gt;TempState.Append(
///   act-&gt;GetTexture() ? act-&gt;GetTexture()-&gt;GetMTime() : 0, "texture mtime");
///
/// // now compare against the last state value
///
/// if (this-&gt;VBOBuildState != this-&gt;TempState)
/// {
///   // set the ivar to the new state
///   this-&gt;VBOBuildState = this-&gt;TempState;
///   do something...
/// }
///
/// @endcode
///
/// </remarks>
public class vtkStateStorage : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStateStorage";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStateStorage()
	{
		MRClassNameKey = "class vtkStateStorage";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStateStorage"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStateStorage(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStateStorage_Clear_01(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void Clear()
	{
		vtkStateStorage_Clear_01(GetCppThis());
	}
}
