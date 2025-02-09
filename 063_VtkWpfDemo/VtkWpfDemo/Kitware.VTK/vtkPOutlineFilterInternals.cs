using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPOutlineFilterInternals
/// </summary>
/// <remarks>
///    create wireframe outline (or corners) for arbitrary data set
///
/// vtkPOutlineFilterInternals has common code for vtkOutlineFilter and
/// vtkOutlineCornerFilter. It assumes the filter is operated in a data parallel
/// pipeline.
///
/// This class does not inherit from vtkObject and is not intended to be used
/// outside of VTK.
/// </remarks>
public class vtkPOutlineFilterInternals : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPOutlineFilterInternals";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPOutlineFilterInternals()
	{
		MRClassNameKey = "class vtkPOutlineFilterInternals";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPOutlineFilterInternals"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPOutlineFilterInternals(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPOutlineFilterInternals_SetController_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the controller to be used.
	/// Default is nullptr.
	/// </summary>
	public void SetController(vtkMultiProcessController arg0)
	{
		vtkPOutlineFilterInternals_SetController_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPOutlineFilterInternals_SetCornerFactor_02(HandleRef pThis, double cornerFactor);

	/// <summary>
	/// Set the corner factor to use when creating corner outline.
	/// Default is 0.2.
	/// </summary>
	public void SetCornerFactor(double cornerFactor)
	{
		vtkPOutlineFilterInternals_SetCornerFactor_02(GetCppThis(), cornerFactor);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPOutlineFilterInternals_SetIsCornerSource_03(HandleRef pThis, byte value);

	/// <summary>
	/// Set whether or not to generate a corner outline.
	/// Default is false.
	/// </summary>
	public void SetIsCornerSource(bool value)
	{
		vtkPOutlineFilterInternals_SetIsCornerSource_03(GetCppThis(), (byte)(value ? 1u : 0u));
	}
}
