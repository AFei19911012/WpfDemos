using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericRenderWindowInteractor
/// </summary>
/// <remarks>
///    platform-independent programmable render window interactor.
///
///
/// vtkGenericRenderWindowInteractor provides a way to translate native
/// mouse and keyboard events into vtk Events.   By calling the methods on
/// this class, vtk events will be invoked.   This will allow scripting
/// languages to use vtkInteractorStyles and 3D widgets.
/// </remarks>
public class vtkGenericRenderWindowInteractor : vtkRenderWindowInteractor
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericRenderWindowInteractor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericRenderWindowInteractor()
	{
		MRClassNameKey = "class vtkGenericRenderWindowInteractor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericRenderWindowInteractor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericRenderWindowInteractor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericRenderWindowInteractor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenericRenderWindowInteractor New()
	{
		vtkGenericRenderWindowInteractor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericRenderWindowInteractor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGenericRenderWindowInteractor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGenericRenderWindowInteractor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericRenderWindowInteractor_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericRenderWindowInteractor_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericRenderWindowInteractor_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericRenderWindowInteractor_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericRenderWindowInteractor_GetTimerEventResetsTimer_03(HandleRef pThis);

	/// <summary>
	/// Flag that indicates whether the TimerEvent method should call ResetTimer
	/// to simulate repeating timers with an endless stream of one shot timers.
	/// By default this flag is on and all repeating timers are implemented as a
	/// stream of sequential one shot timers. If the observer of
	/// CreateTimerEvent actually creates a "natively repeating" timer, setting
	/// this flag to off will prevent (perhaps many many) unnecessary calls to
	/// ResetTimer. Having the flag on by default means that "natively one
	/// shot" timers can be either one shot or repeating timers with no
	/// additional work. Also, "natively repeating" timers still work with the
	/// default setting, but with potentially many create and destroy calls.
	/// </summary>
	public virtual int GetTimerEventResetsTimer()
	{
		return vtkGenericRenderWindowInteractor_GetTimerEventResetsTimer_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericRenderWindowInteractor_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericRenderWindowInteractor_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericRenderWindowInteractor_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericRenderWindowInteractor_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericRenderWindowInteractor_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGenericRenderWindowInteractor NewInstance()
	{
		vtkGenericRenderWindowInteractor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericRenderWindowInteractor_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericRenderWindowInteractor_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenericRenderWindowInteractor SafeDownCast(vtkObjectBase o)
	{
		vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericRenderWindowInteractor_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericRenderWindowInteractor2 = (vtkGenericRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericRenderWindowInteractor2.Register(null);
			}
		}
		return vtkGenericRenderWindowInteractor2;
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericRenderWindowInteractor_SetTimerEventResetsTimer_09(HandleRef pThis, int _arg);

	/// <summary>
	/// Flag that indicates whether the TimerEvent method should call ResetTimer
	/// to simulate repeating timers with an endless stream of one shot timers.
	/// By default this flag is on and all repeating timers are implemented as a
	/// stream of sequential one shot timers. If the observer of
	/// CreateTimerEvent actually creates a "natively repeating" timer, setting
	/// this flag to off will prevent (perhaps many many) unnecessary calls to
	/// ResetTimer. Having the flag on by default means that "natively one
	/// shot" timers can be either one shot or repeating timers with no
	/// additional work. Also, "natively repeating" timers still work with the
	/// default setting, but with potentially many create and destroy calls.
	/// </summary>
	public virtual void SetTimerEventResetsTimer(int _arg)
	{
		vtkGenericRenderWindowInteractor_SetTimerEventResetsTimer_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericRenderWindowInteractor_TimerEvent_10(HandleRef pThis);

	/// <summary>
	/// Fire TimerEvent. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void TimerEvent()
	{
		vtkGenericRenderWindowInteractor_TimerEvent_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericRenderWindowInteractor_TimerEventResetsTimerOff_11(HandleRef pThis);

	/// <summary>
	/// Flag that indicates whether the TimerEvent method should call ResetTimer
	/// to simulate repeating timers with an endless stream of one shot timers.
	/// By default this flag is on and all repeating timers are implemented as a
	/// stream of sequential one shot timers. If the observer of
	/// CreateTimerEvent actually creates a "natively repeating" timer, setting
	/// this flag to off will prevent (perhaps many many) unnecessary calls to
	/// ResetTimer. Having the flag on by default means that "natively one
	/// shot" timers can be either one shot or repeating timers with no
	/// additional work. Also, "natively repeating" timers still work with the
	/// default setting, but with potentially many create and destroy calls.
	/// </summary>
	public virtual void TimerEventResetsTimerOff()
	{
		vtkGenericRenderWindowInteractor_TimerEventResetsTimerOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericRenderWindowInteractor_TimerEventResetsTimerOn_12(HandleRef pThis);

	/// <summary>
	/// Flag that indicates whether the TimerEvent method should call ResetTimer
	/// to simulate repeating timers with an endless stream of one shot timers.
	/// By default this flag is on and all repeating timers are implemented as a
	/// stream of sequential one shot timers. If the observer of
	/// CreateTimerEvent actually creates a "natively repeating" timer, setting
	/// this flag to off will prevent (perhaps many many) unnecessary calls to
	/// ResetTimer. Having the flag on by default means that "natively one
	/// shot" timers can be either one shot or repeating timers with no
	/// additional work. Also, "natively repeating" timers still work with the
	/// default setting, but with potentially many create and destroy calls.
	/// </summary>
	public virtual void TimerEventResetsTimerOn()
	{
		vtkGenericRenderWindowInteractor_TimerEventResetsTimerOn_12(GetCppThis());
	}
}
