using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkPExtractExodusGlobalTemporalVariables
/// </summary>
/// <remarks>
///  parallel version of vtkExtractExodusGlobalTemporalVariables.
///
/// vtkPExtractExodusGlobalTemporalVariables is a parallel version of
/// vtkExtractExodusGlobalTemporalVariables that handles synchronization between
/// multiple ranks. Since vtkPExodusIIReader has explicit sycnchronization
/// between ranks its essential that downstream filters make consistent requests
/// on all ranks to avoid deadlocks. Since global variables need not be provided
/// on all ranks, without explicit coordination
/// vtkExtractExodusGlobalTemporalVariables may end up not making requests on
/// certain ranks causing deadlocks.
/// </remarks>
public class vtkPExtractExodusGlobalTemporalVariables : vtkExtractExodusGlobalTemporalVariables
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPExtractExodusGlobalTemporalVariables";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPExtractExodusGlobalTemporalVariables()
	{
		MRClassNameKey = "class vtkPExtractExodusGlobalTemporalVariables";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPExtractExodusGlobalTemporalVariables"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPExtractExodusGlobalTemporalVariables(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPExtractExodusGlobalTemporalVariables_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPExtractExodusGlobalTemporalVariables New()
	{
		vtkPExtractExodusGlobalTemporalVariables result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPExtractExodusGlobalTemporalVariables_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPExtractExodusGlobalTemporalVariables)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPExtractExodusGlobalTemporalVariables()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPExtractExodusGlobalTemporalVariables_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPExtractExodusGlobalTemporalVariables_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the controller to use. By default
	/// `vtkMultiProcessController::GlobalController` will be used.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPExtractExodusGlobalTemporalVariables_GetController_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPExtractExodusGlobalTemporalVariables_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPExtractExodusGlobalTemporalVariables_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPExtractExodusGlobalTemporalVariables_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPExtractExodusGlobalTemporalVariables_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPExtractExodusGlobalTemporalVariables_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPExtractExodusGlobalTemporalVariables_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPExtractExodusGlobalTemporalVariables_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPExtractExodusGlobalTemporalVariables_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPExtractExodusGlobalTemporalVariables_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPExtractExodusGlobalTemporalVariables NewInstance()
	{
		vtkPExtractExodusGlobalTemporalVariables result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPExtractExodusGlobalTemporalVariables_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPExtractExodusGlobalTemporalVariables)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPExtractExodusGlobalTemporalVariables_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPExtractExodusGlobalTemporalVariables SafeDownCast(vtkObjectBase o)
	{
		vtkPExtractExodusGlobalTemporalVariables vtkPExtractExodusGlobalTemporalVariables2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPExtractExodusGlobalTemporalVariables_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPExtractExodusGlobalTemporalVariables2 = (vtkPExtractExodusGlobalTemporalVariables)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPExtractExodusGlobalTemporalVariables2.Register(null);
			}
		}
		return vtkPExtractExodusGlobalTemporalVariables2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPExtractExodusGlobalTemporalVariables_SetController_09(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set the controller to use. By default
	/// `vtkMultiProcessController::GlobalController` will be used.
	/// </summary>
	public void SetController(vtkMultiProcessController arg0)
	{
		vtkPExtractExodusGlobalTemporalVariables_SetController_09(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
