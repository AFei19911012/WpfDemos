using System;
using System.Reflection;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGPUInfoListArray
/// </summary>
/// <remarks>
///    Internal class vtkGPUInfoList.
///
/// vtkGPUInfoListArray is just a PIMPL mechanism for vtkGPUInfoList.
/// </remarks>
public class vtkGPUInfoListArray : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGPUInfoListArray";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGPUInfoListArray()
	{
		MRClassNameKey = "class vtkGPUInfoListArray";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGPUInfoListArray"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGPUInfoListArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
}
