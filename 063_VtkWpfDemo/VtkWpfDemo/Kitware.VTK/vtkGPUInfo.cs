using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGPUInfo
/// </summary>
/// <remarks>
///    Stores GPU VRAM information.
///
/// vtkGPUInfo stores information about GPU Video RAM. An host can have
/// several GPUs. The values are set by vtkGPUInfoList.
/// </remarks>
/// <seealso>
///
/// vtkGPUInfoList vtkDirectXGPUInfoList vtkCoreGraphicsGPUInfoList
/// </seealso>
public class vtkGPUInfo : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGPUInfo";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGPUInfo()
	{
		MRClassNameKey = "class vtkGPUInfo";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGPUInfo"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGPUInfo(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGPUInfo_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGPUInfo New()
	{
		vtkGPUInfo result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGPUInfo_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGPUInfo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGPUInfo()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGPUInfo_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkGPUInfo_GetDedicatedSystemMemory_01(HandleRef pThis);

	/// <summary>
	/// Set/Get dedicated system memory in bytes. Initial value is 0.
	/// This is slow memory. If it is not 0, this value should be taken into
	/// account only if there is no DedicatedVideoMemory and SharedSystemMemory
	/// should be ignored.
	/// </summary>
	public virtual ulong GetDedicatedSystemMemory()
	{
		return vtkGPUInfo_GetDedicatedSystemMemory_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkGPUInfo_GetDedicatedVideoMemory_02(HandleRef pThis);

	/// <summary>
	/// Set/Get dedicated video memory in bytes. Initial value is 0.
	/// Usually the fastest one. If it is not 0, it should be taken into
	/// account first and DedicatedSystemMemory or SharedSystemMemory should be
	/// ignored.
	/// </summary>
	public virtual ulong GetDedicatedVideoMemory()
	{
		return vtkGPUInfo_GetDedicatedVideoMemory_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGPUInfo_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGPUInfo_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGPUInfo_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGPUInfo_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkGPUInfo_GetSharedSystemMemory_05(HandleRef pThis);

	/// <summary>
	/// Set/Get shared system memory in bytes. Initial value is 0.
	/// Slowest memory. This value should be taken into account only if there is
	/// neither DedicatedVideoMemory nor DedicatedSystemMemory.
	/// </summary>
	public virtual ulong GetSharedSystemMemory()
	{
		return vtkGPUInfo_GetSharedSystemMemory_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUInfo_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGPUInfo_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUInfo_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGPUInfo_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGPUInfo_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGPUInfo NewInstance()
	{
		vtkGPUInfo result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGPUInfo_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGPUInfo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGPUInfo_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGPUInfo SafeDownCast(vtkObjectBase o)
	{
		vtkGPUInfo vtkGPUInfo2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGPUInfo_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGPUInfo2 = (vtkGPUInfo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGPUInfo2.Register(null);
			}
		}
		return vtkGPUInfo2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUInfo_SetDedicatedSystemMemory_11(HandleRef pThis, ulong _arg);

	/// <summary>
	/// Set/Get dedicated system memory in bytes. Initial value is 0.
	/// This is slow memory. If it is not 0, this value should be taken into
	/// account only if there is no DedicatedVideoMemory and SharedSystemMemory
	/// should be ignored.
	/// </summary>
	public virtual void SetDedicatedSystemMemory(ulong _arg)
	{
		vtkGPUInfo_SetDedicatedSystemMemory_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUInfo_SetDedicatedVideoMemory_12(HandleRef pThis, ulong _arg);

	/// <summary>
	/// Set/Get dedicated video memory in bytes. Initial value is 0.
	/// Usually the fastest one. If it is not 0, it should be taken into
	/// account first and DedicatedSystemMemory or SharedSystemMemory should be
	/// ignored.
	/// </summary>
	public virtual void SetDedicatedVideoMemory(ulong _arg)
	{
		vtkGPUInfo_SetDedicatedVideoMemory_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUInfo_SetSharedSystemMemory_13(HandleRef pThis, ulong _arg);

	/// <summary>
	/// Set/Get shared system memory in bytes. Initial value is 0.
	/// Slowest memory. This value should be taken into account only if there is
	/// neither DedicatedVideoMemory nor DedicatedSystemMemory.
	/// </summary>
	public virtual void SetSharedSystemMemory(ulong _arg)
	{
		vtkGPUInfo_SetSharedSystemMemory_13(GetCppThis(), _arg);
	}
}
