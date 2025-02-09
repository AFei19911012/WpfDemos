using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <remarks>
///  OpenGL2 override for vtkRenderTimerLog.
/// </remarks>
public class vtkOpenGLRenderTimerLog : vtkRenderTimerLog
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLRenderTimerLog";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLRenderTimerLog()
	{
		MRClassNameKey = "class vtkOpenGLRenderTimerLog";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLRenderTimerLog"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLRenderTimerLog(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderTimerLog_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLRenderTimerLog New()
	{
		vtkOpenGLRenderTimerLog result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderTimerLog_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLRenderTimerLog)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLRenderTimerLog()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLRenderTimerLog_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLRenderTimerLog_FrameReady_01(HandleRef pThis);

	/// <summary>
	/// Overridden to do support check before returning.
	/// </summary>
	public override bool FrameReady()
	{
		return (vtkOpenGLRenderTimerLog_FrameReady_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLRenderTimerLog_GetLoggingEnabled_02(HandleRef pThis);

	/// <summary>
	/// Overridden to do support check before returning.
	/// </summary>
	public override bool GetLoggingEnabled()
	{
		return (vtkOpenGLRenderTimerLog_GetLoggingEnabled_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkOpenGLRenderTimerLog_GetMinTimerPoolSize_03(HandleRef pThis);

	/// <summary>
	/// This implementations keeps a pool of vtkRenderTimers around, recycling them
	/// to avoid constantly allocating/freeing them. The pool is sometimes trimmed
	/// to free up memory if the number of timers in the pool is much greater the
	/// the number of timers currently used. This setting controls the minimum
	/// number of timers that will be kept. More may be kept if they are being
	/// used, but the pool will never be trimmed below this amount.
	///
	/// Default value is 32, but can be adjusted for specific use cases.
	/// </summary>
	public virtual ulong GetMinTimerPoolSize()
	{
		return vtkOpenGLRenderTimerLog_GetMinTimerPoolSize_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLRenderTimerLog_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLRenderTimerLog_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLRenderTimerLog_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLRenderTimerLog_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderTimerLog_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLRenderTimerLog_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLRenderTimerLog_IsSupported_07(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override bool IsSupported()
	{
		return (vtkOpenGLRenderTimerLog_IsSupported_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderTimerLog_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLRenderTimerLog_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderTimerLog_MarkEndEvent_09(HandleRef pThis);

	/// <summary>
	/// Overridden to do support check before returning.
	/// </summary>
	public override void MarkEndEvent()
	{
		vtkOpenGLRenderTimerLog_MarkEndEvent_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderTimerLog_MarkFrame_10(HandleRef pThis);

	/// <summary>
	/// Overridden to do support check before returning.
	/// </summary>
	public override void MarkFrame()
	{
		vtkOpenGLRenderTimerLog_MarkFrame_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderTimerLog_MarkStartEvent_11(HandleRef pThis, string name);

	/// <summary>
	/// Overridden to do support check before returning.
	/// </summary>
	public override void MarkStartEvent(string name)
	{
		vtkOpenGLRenderTimerLog_MarkStartEvent_11(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderTimerLog_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLRenderTimerLog NewInstance()
	{
		vtkOpenGLRenderTimerLog result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderTimerLog_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLRenderTimerLog)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderTimerLog_ReleaseGraphicsResources_14(HandleRef pThis);

	/// <summary>
	/// Releases any resources allocated on the graphics device.
	/// </summary>
	public override void ReleaseGraphicsResources()
	{
		vtkOpenGLRenderTimerLog_ReleaseGraphicsResources_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderTimerLog_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLRenderTimerLog SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLRenderTimerLog vtkOpenGLRenderTimerLog2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderTimerLog_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLRenderTimerLog2 = (vtkOpenGLRenderTimerLog)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLRenderTimerLog2.Register(null);
			}
		}
		return vtkOpenGLRenderTimerLog2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderTimerLog_SetMinTimerPoolSize_16(HandleRef pThis, ulong _arg);

	/// <summary>
	/// This implementations keeps a pool of vtkRenderTimers around, recycling them
	/// to avoid constantly allocating/freeing them. The pool is sometimes trimmed
	/// to free up memory if the number of timers in the pool is much greater the
	/// the number of timers currently used. This setting controls the minimum
	/// number of timers that will be kept. More may be kept if they are being
	/// used, but the pool will never be trimmed below this amount.
	///
	/// Default value is 32, but can be adjusted for specific use cases.
	/// </summary>
	public virtual void SetMinTimerPoolSize(ulong _arg)
	{
		vtkOpenGLRenderTimerLog_SetMinTimerPoolSize_16(GetCppThis(), _arg);
	}
}
