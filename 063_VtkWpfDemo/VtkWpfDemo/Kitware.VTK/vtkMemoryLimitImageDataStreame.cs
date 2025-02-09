using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMemoryLimitImageDataStreamer
/// </summary>
/// <remarks>
///    Initiates streaming on image data.
///
/// To satisfy a request, this filter calls update on its input
/// many times with smaller update extents.  All processing up stream
/// streams smaller pieces.
/// </remarks>
public class vtkMemoryLimitImageDataStreamer : vtkImageDataStreamer
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMemoryLimitImageDataStreamer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMemoryLimitImageDataStreamer()
	{
		MRClassNameKey = "class vtkMemoryLimitImageDataStreamer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMemoryLimitImageDataStreamer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMemoryLimitImageDataStreamer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMemoryLimitImageDataStreamer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMemoryLimitImageDataStreamer New()
	{
		vtkMemoryLimitImageDataStreamer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMemoryLimitImageDataStreamer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMemoryLimitImageDataStreamer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMemoryLimitImageDataStreamer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMemoryLimitImageDataStreamer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkMemoryLimitImageDataStreamer_GetMemoryLimit_01(HandleRef pThis);

	/// <summary>
	/// Set / Get the memory limit in kibibytes (1024 bytes).
	/// </summary>
	public virtual uint GetMemoryLimit()
	{
		return vtkMemoryLimitImageDataStreamer_GetMemoryLimit_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMemoryLimitImageDataStreamer_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMemoryLimitImageDataStreamer_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMemoryLimitImageDataStreamer_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMemoryLimitImageDataStreamer_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMemoryLimitImageDataStreamer_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMemoryLimitImageDataStreamer_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMemoryLimitImageDataStreamer_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMemoryLimitImageDataStreamer_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMemoryLimitImageDataStreamer_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMemoryLimitImageDataStreamer NewInstance()
	{
		vtkMemoryLimitImageDataStreamer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMemoryLimitImageDataStreamer_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMemoryLimitImageDataStreamer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMemoryLimitImageDataStreamer_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMemoryLimitImageDataStreamer SafeDownCast(vtkObjectBase o)
	{
		vtkMemoryLimitImageDataStreamer vtkMemoryLimitImageDataStreamer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMemoryLimitImageDataStreamer_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMemoryLimitImageDataStreamer2 = (vtkMemoryLimitImageDataStreamer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMemoryLimitImageDataStreamer2.Register(null);
			}
		}
		return vtkMemoryLimitImageDataStreamer2;
	}

	[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMemoryLimitImageDataStreamer_SetMemoryLimit_09(HandleRef pThis, uint _arg);

	/// <summary>
	/// Set / Get the memory limit in kibibytes (1024 bytes).
	/// </summary>
	public virtual void SetMemoryLimit(uint _arg)
	{
		vtkMemoryLimitImageDataStreamer_SetMemoryLimit_09(GetCppThis(), _arg);
	}
}
