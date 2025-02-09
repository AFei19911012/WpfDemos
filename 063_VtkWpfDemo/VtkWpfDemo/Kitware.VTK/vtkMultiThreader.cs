using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMultiThreader
/// </summary>
/// <remarks>
///    A class for performing multithreaded execution
///
/// vtkMultithreader is a class that provides support for multithreaded
/// execution using pthreads on POSIX systems, or Win32 threads on
/// Windows.  This class can be used to execute a single
/// method on multiple threads, or to specify a method per thread.
/// </remarks>
public class vtkMultiThreader : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMultiThreader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMultiThreader()
	{
		MRClassNameKey = "class vtkMultiThreader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiThreader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMultiThreader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiThreader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMultiThreader New()
	{
		vtkMultiThreader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiThreader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMultiThreader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMultiThreader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMultiThreader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern uint vtkMultiThreader_GetCurrentThreadID_01();

	/// <summary>
	/// Get the thread identifier of the calling thread.
	/// </summary>
	public static uint GetCurrentThreadID()
	{
		return vtkMultiThreader_GetCurrentThreadID_01();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiThreader_GetGlobalDefaultNumberOfThreads_02();

	/// <summary>
	/// Set/Get the value which is used to initialize the NumberOfThreads
	/// in the constructor.  Initially this default is set to the number of
	/// processors or VTK_MAX_THREADS (which ever is less).
	/// </summary>
	public static int GetGlobalDefaultNumberOfThreads()
	{
		return vtkMultiThreader_GetGlobalDefaultNumberOfThreads_02();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiThreader_GetGlobalMaximumNumberOfThreads_03();

	/// <summary>
	/// Set/Get the maximum number of threads to use when multithreading.
	/// This limits and overrides any other settings for multithreading.
	/// A value of zero indicates no limit.
	/// </summary>
	public static int GetGlobalMaximumNumberOfThreads()
	{
		return vtkMultiThreader_GetGlobalMaximumNumberOfThreads_03();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiThreader_GetGlobalStaticMaximumNumberOfThreads_04();

	/// <summary>
	/// Set/Get the maximum number of threads VTK was allocated to support.
	/// </summary>
	public static int GetGlobalStaticMaximumNumberOfThreads()
	{
		return vtkMultiThreader_GetGlobalStaticMaximumNumberOfThreads_04();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMultiThreader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMultiThreader_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMultiThreader_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMultiThreader_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiThreader_GetNumberOfThreads_07(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of threads to create. It will be clamped to the range
	/// 1 - VTK_MAX_THREADS, so the caller of this method should check that the
	/// requested number of threads was accepted.
	/// </summary>
	public virtual int GetNumberOfThreads()
	{
		return vtkMultiThreader_GetNumberOfThreads_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiThreader_GetNumberOfThreadsMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of threads to create. It will be clamped to the range
	/// 1 - VTK_MAX_THREADS, so the caller of this method should check that the
	/// requested number of threads was accepted.
	/// </summary>
	public virtual int GetNumberOfThreadsMaxValue()
	{
		return vtkMultiThreader_GetNumberOfThreadsMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiThreader_GetNumberOfThreadsMinValue_09(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of threads to create. It will be clamped to the range
	/// 1 - VTK_MAX_THREADS, so the caller of this method should check that the
	/// requested number of threads was accepted.
	/// </summary>
	public virtual int GetNumberOfThreadsMinValue()
	{
		return vtkMultiThreader_GetNumberOfThreadsMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiThreader_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMultiThreader_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiThreader_IsThreadActive_11(HandleRef pThis, int threadId);

	/// <summary>
	/// Determine if a thread is still active
	/// </summary>
	public int IsThreadActive(int threadId)
	{
		return vtkMultiThreader_IsThreadActive_11(GetCppThis(), threadId);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiThreader_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMultiThreader_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiThreader_MultipleMethodExecute_13(HandleRef pThis);

	/// <summary>
	/// Execute the MultipleMethods (as define by calling SetMultipleMethod
	/// for each of the required this-&gt;NumberOfThreads methods) using
	/// this-&gt;NumberOfThreads threads.
	/// </summary>
	public void MultipleMethodExecute()
	{
		vtkMultiThreader_MultipleMethodExecute_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiThreader_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMultiThreader NewInstance()
	{
		vtkMultiThreader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiThreader_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMultiThreader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiThreader_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMultiThreader SafeDownCast(vtkObjectBase o)
	{
		vtkMultiThreader vtkMultiThreader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiThreader_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiThreader2 = (vtkMultiThreader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiThreader2.Register(null);
			}
		}
		return vtkMultiThreader2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiThreader_SetGlobalDefaultNumberOfThreads_17(int val);

	/// <summary>
	/// Set/Get the value which is used to initialize the NumberOfThreads
	/// in the constructor.  Initially this default is set to the number of
	/// processors or VTK_MAX_THREADS (which ever is less).
	/// </summary>
	public static void SetGlobalDefaultNumberOfThreads(int val)
	{
		vtkMultiThreader_SetGlobalDefaultNumberOfThreads_17(val);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiThreader_SetGlobalMaximumNumberOfThreads_18(int val);

	/// <summary>
	/// Set/Get the maximum number of threads to use when multithreading.
	/// This limits and overrides any other settings for multithreading.
	/// A value of zero indicates no limit.
	/// </summary>
	public static void SetGlobalMaximumNumberOfThreads(int val)
	{
		vtkMultiThreader_SetGlobalMaximumNumberOfThreads_18(val);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiThreader_SetNumberOfThreads_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the number of threads to create. It will be clamped to the range
	/// 1 - VTK_MAX_THREADS, so the caller of this method should check that the
	/// requested number of threads was accepted.
	/// </summary>
	public virtual void SetNumberOfThreads(int _arg)
	{
		vtkMultiThreader_SetNumberOfThreads_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiThreader_SingleMethodExecute_20(HandleRef pThis);

	/// <summary>
	/// Execute the SingleMethod (as define by SetSingleMethod) using
	/// this-&gt;NumberOfThreads threads.
	/// </summary>
	public void SingleMethodExecute()
	{
		vtkMultiThreader_SingleMethodExecute_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiThreader_TerminateThread_21(HandleRef pThis, int threadId);

	/// <summary>
	/// Terminate the thread that was created with a SpawnThreadExecute()
	/// </summary>
	public void TerminateThread(int threadId)
	{
		vtkMultiThreader_TerminateThread_21(GetCppThis(), threadId);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiThreader_ThreadsEqual_22(uint t1, uint t2);

	/// <summary>
	/// Check whether two thread identifiers refer to the same thread.
	/// </summary>
	public static int ThreadsEqual(uint t1, uint t2)
	{
		return vtkMultiThreader_ThreadsEqual_22(t1, t2);
	}
}
