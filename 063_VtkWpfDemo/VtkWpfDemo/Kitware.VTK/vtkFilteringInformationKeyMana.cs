using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFilteringInformationKeyManager
/// </summary>
/// <remarks>
///    Manages key types in vtkFiltering.
///
/// vtkFilteringInformationKeyManager is included in the header of any
/// subclass of vtkInformationKey defined in the vtkFiltering library.
/// It makes sure that the table of keys is created before and
/// destroyed after it is used.
/// </remarks>
public class vtkFilteringInformationKeyManager : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFilteringInformationKeyManager";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFilteringInformationKeyManager()
	{
		MRClassNameKey = "class vtkFilteringInformationKeyManager";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFilteringInformationKeyManager"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFilteringInformationKeyManager(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFilteringInformationKeyManager_Register_01(HandleRef key);

	/// <summary>
	/// Called by constructors of vtkInformationKey subclasses defined in
	/// vtkFiltering to register themselves with the manager.  The
	/// instances will be deleted when vtkFiltering is unloaded on
	/// program exit.
	/// </summary>
	public static void Register(vtkInformationKey key)
	{
		vtkFilteringInformationKeyManager_Register_01(key?.GetCppThis() ?? default(HandleRef));
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
