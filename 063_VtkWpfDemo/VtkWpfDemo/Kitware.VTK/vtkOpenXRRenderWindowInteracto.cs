using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenXRRenderWindowInteractor
/// </summary>
/// <remarks>
///    implements OpenXR specific functions
/// required by vtkRenderWindowInteractor.
///
/// </remarks>
public class vtkOpenXRRenderWindowInteractor : vtkVRRenderWindowInteractor
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenXRRenderWindowInteractor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenXRRenderWindowInteractor()
	{
		MRClassNameKey = "class vtkOpenXRRenderWindowInteractor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenXRRenderWindowInteractor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenXRRenderWindowInteractor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenXRRenderWindowInteractor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenXRRenderWindowInteractor New()
	{
		vtkOpenXRRenderWindowInteractor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenXRRenderWindowInteractor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenXRRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenXRRenderWindowInteractor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenXRRenderWindowInteractor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenXRRenderWindowInteractor_ApplyVibration_01(HandleRef pThis, string actionName, int hand, float amplitude, float duration, float frequency);

	/// <summary>
	/// Apply haptic vibration using the provided action
	/// \p action to emit vibration on \p hand to emit on \p amplitude 0.0 to 1.0.
	/// \p duration nanoseconds, default 25ms \p frequency (hz)
	/// </summary>
	public bool ApplyVibration(string actionName, int hand, float amplitude, float duration, float frequency)
	{
		return (vtkOpenXRRenderWindowInteractor_ApplyVibration_01(GetCppThis(), actionName, hand, amplitude, duration, frequency) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenXRRenderWindowInteractor_DoOneEvent_02(HandleRef pThis, HandleRef renWin, HandleRef ren);

	/// <summary>
	/// Initialize the event handler
	/// </summary>
	public override void DoOneEvent(vtkVRRenderWindow renWin, vtkRenderer ren)
	{
		vtkOpenXRRenderWindowInteractor_DoOneEvent_02(GetCppThis(), renWin?.GetCppThis() ?? default(HandleRef), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenXRRenderWindowInteractor_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenXRRenderWindowInteractor_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenXRRenderWindowInteractor_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenXRRenderWindowInteractor_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenXRRenderWindowInteractor_Initialize_05(HandleRef pThis);

	/// <summary>
	/// Initialize the event handler
	/// </summary>
	public override void Initialize()
	{
		vtkOpenXRRenderWindowInteractor_Initialize_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenXRRenderWindowInteractor_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenXRRenderWindowInteractor_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenXRRenderWindowInteractor_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenXRRenderWindowInteractor_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenXRRenderWindowInteractor_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenXRRenderWindowInteractor NewInstance()
	{
		vtkOpenXRRenderWindowInteractor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenXRRenderWindowInteractor_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenXRRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenXRRenderWindowInteractor_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenXRRenderWindowInteractor SafeDownCast(vtkObjectBase o)
	{
		vtkOpenXRRenderWindowInteractor vtkOpenXRRenderWindowInteractor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenXRRenderWindowInteractor_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenXRRenderWindowInteractor2 = (vtkOpenXRRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenXRRenderWindowInteractor2.Register(null);
			}
		}
		return vtkOpenXRRenderWindowInteractor2;
	}
}
