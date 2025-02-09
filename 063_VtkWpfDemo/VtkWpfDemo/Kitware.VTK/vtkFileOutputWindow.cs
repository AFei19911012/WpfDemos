using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFileOutputWindow
/// </summary>
/// <remarks>
///    File Specific output window class
///
/// Writes debug/warning/error output to a log file instead of the console.
/// To use this class, instantiate it and then call SetInstance(this).
///
/// </remarks>
public class vtkFileOutputWindow : vtkOutputWindow
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFileOutputWindow";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFileOutputWindow()
	{
		MRClassNameKey = "class vtkFileOutputWindow";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFileOutputWindow"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFileOutputWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFileOutputWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFileOutputWindow New()
	{
		vtkFileOutputWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFileOutputWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFileOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFileOutputWindow()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFileOutputWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFileOutputWindow_AppendOff_01(HandleRef pThis);

	/// <summary>
	/// Setting append will cause the log file to be
	/// opened in append mode.  Otherwise, if the log file exists,
	/// it will be overwritten each time the vtkFileOutputWindow
	/// is created.
	/// </summary>
	public virtual void AppendOff()
	{
		vtkFileOutputWindow_AppendOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFileOutputWindow_AppendOn_02(HandleRef pThis);

	/// <summary>
	/// Setting append will cause the log file to be
	/// opened in append mode.  Otherwise, if the log file exists,
	/// it will be overwritten each time the vtkFileOutputWindow
	/// is created.
	/// </summary>
	public virtual void AppendOn()
	{
		vtkFileOutputWindow_AppendOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFileOutputWindow_DisplayText_03(HandleRef pThis, string arg0);

	/// <summary>
	/// Put the text into the log file.
	/// New lines are converted to carriage return new lines.
	/// </summary>
	public override void DisplayText(string arg0)
	{
		vtkFileOutputWindow_DisplayText_03(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFileOutputWindow_FlushOff_04(HandleRef pThis);

	/// <summary>
	/// Turns on buffer flushing for the output
	/// to the log file.
	/// </summary>
	public virtual void FlushOff()
	{
		vtkFileOutputWindow_FlushOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFileOutputWindow_FlushOn_05(HandleRef pThis);

	/// <summary>
	/// Turns on buffer flushing for the output
	/// to the log file.
	/// </summary>
	public virtual void FlushOn()
	{
		vtkFileOutputWindow_FlushOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFileOutputWindow_GetAppend_06(HandleRef pThis);

	/// <summary>
	/// Setting append will cause the log file to be
	/// opened in append mode.  Otherwise, if the log file exists,
	/// it will be overwritten each time the vtkFileOutputWindow
	/// is created.
	/// </summary>
	public virtual int GetAppend()
	{
		return vtkFileOutputWindow_GetAppend_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFileOutputWindow_GetFileName_07(HandleRef pThis);

	/// <summary>
	/// Sets the name for the log file.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkFileOutputWindow_GetFileName_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFileOutputWindow_GetFlush_08(HandleRef pThis);

	/// <summary>
	/// Turns on buffer flushing for the output
	/// to the log file.
	/// </summary>
	public virtual int GetFlush()
	{
		return vtkFileOutputWindow_GetFlush_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFileOutputWindow_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFileOutputWindow_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFileOutputWindow_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFileOutputWindow_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFileOutputWindow_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFileOutputWindow_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFileOutputWindow_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFileOutputWindow_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFileOutputWindow_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFileOutputWindow NewInstance()
	{
		vtkFileOutputWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFileOutputWindow_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFileOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFileOutputWindow_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFileOutputWindow SafeDownCast(vtkObjectBase o)
	{
		vtkFileOutputWindow vtkFileOutputWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFileOutputWindow_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFileOutputWindow2 = (vtkFileOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFileOutputWindow2.Register(null);
			}
		}
		return vtkFileOutputWindow2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFileOutputWindow_SetAppend_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Setting append will cause the log file to be
	/// opened in append mode.  Otherwise, if the log file exists,
	/// it will be overwritten each time the vtkFileOutputWindow
	/// is created.
	/// </summary>
	public virtual void SetAppend(int _arg)
	{
		vtkFileOutputWindow_SetAppend_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFileOutputWindow_SetFileName_17(HandleRef pThis, string _arg);

	/// <summary>
	/// Sets the name for the log file.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkFileOutputWindow_SetFileName_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFileOutputWindow_SetFlush_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Turns on buffer flushing for the output
	/// to the log file.
	/// </summary>
	public virtual void SetFlush(int _arg)
	{
		vtkFileOutputWindow_SetFlush_18(GetCppThis(), _arg);
	}
}
