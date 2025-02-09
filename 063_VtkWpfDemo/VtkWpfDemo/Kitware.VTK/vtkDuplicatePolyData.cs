using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDuplicatePolyData
/// </summary>
/// <remarks>
///    For distributed tiled displays.
///
/// This filter collects poly data and duplicates it on every node.
/// Converts data parallel so every node has a complete copy of the data.
/// The filter is used at the end of a pipeline for driving a tiled
/// display.
/// </remarks>
public class vtkDuplicatePolyData : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDuplicatePolyData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDuplicatePolyData()
	{
		MRClassNameKey = "class vtkDuplicatePolyData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDuplicatePolyData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDuplicatePolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDuplicatePolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDuplicatePolyData New()
	{
		vtkDuplicatePolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDuplicatePolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDuplicatePolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDuplicatePolyData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDuplicatePolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDuplicatePolyData_GetClientFlag_01(HandleRef pThis);

	/// <summary>
	/// This duplicate filter works in client server mode when this
	/// controller is set.  We have a client flag to differentiate the
	/// client and server because the socket controller is odd:
	/// Proth processes think their id is 0.
	/// </summary>
	public virtual int GetClientFlag()
	{
		return vtkDuplicatePolyData_GetClientFlag_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDuplicatePolyData_GetController_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// By default this filter uses the global controller,
	/// but this method can be used to set another instead.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDuplicatePolyData_GetController_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern uint vtkDuplicatePolyData_GetMemorySize_03(HandleRef pThis);

	/// <summary>
	/// This returns to size of the output (on this process).
	/// This method is not really used.  It is needed to have
	/// the same API as vtkCollectPolyData.
	/// </summary>
	public virtual uint GetMemorySize()
	{
		return vtkDuplicatePolyData_GetMemorySize_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDuplicatePolyData_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDuplicatePolyData_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDuplicatePolyData_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDuplicatePolyData_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDuplicatePolyData_GetSocketController_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This duplicate filter works in client server mode when this
	/// controller is set.  We have a client flag to differentiate the
	/// client and server because the socket controller is odd:
	/// Proth processes think their id is 0.
	/// </summary>
	public vtkSocketController GetSocketController()
	{
		vtkSocketController vtkSocketController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDuplicatePolyData_GetSocketController_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSocketController2 = (vtkSocketController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSocketController2.Register(null);
			}
		}
		return vtkSocketController2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDuplicatePolyData_GetSynchronous_07(HandleRef pThis);

	/// <summary>
	/// This flag causes sends and receives to be matched.
	/// When this flag is off, two sends occur then two receives.
	/// I want to see if it makes a difference in performance.
	/// The flag is on by default.
	/// </summary>
	public virtual int GetSynchronous()
	{
		return vtkDuplicatePolyData_GetSynchronous_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDuplicatePolyData_InitializeSchedule_08(HandleRef pThis, int numProcs);

	/// <summary>
	/// By default this filter uses the global controller,
	/// but this method can be used to set another instead.
	/// </summary>
	public void InitializeSchedule(int numProcs)
	{
		vtkDuplicatePolyData_InitializeSchedule_08(GetCppThis(), numProcs);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDuplicatePolyData_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDuplicatePolyData_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDuplicatePolyData_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDuplicatePolyData_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDuplicatePolyData_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDuplicatePolyData NewInstance()
	{
		vtkDuplicatePolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDuplicatePolyData_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDuplicatePolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDuplicatePolyData_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDuplicatePolyData SafeDownCast(vtkObjectBase o)
	{
		vtkDuplicatePolyData vtkDuplicatePolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDuplicatePolyData_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDuplicatePolyData2 = (vtkDuplicatePolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDuplicatePolyData2.Register(null);
			}
		}
		return vtkDuplicatePolyData2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDuplicatePolyData_SetClientFlag_14(HandleRef pThis, int _arg);

	/// <summary>
	/// This duplicate filter works in client server mode when this
	/// controller is set.  We have a client flag to differentiate the
	/// client and server because the socket controller is odd:
	/// Proth processes think their id is 0.
	/// </summary>
	public virtual void SetClientFlag(int _arg)
	{
		vtkDuplicatePolyData_SetClientFlag_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDuplicatePolyData_SetController_15(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// By default this filter uses the global controller,
	/// but this method can be used to set another instead.
	/// </summary>
	public virtual void SetController(vtkMultiProcessController arg0)
	{
		vtkDuplicatePolyData_SetController_15(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDuplicatePolyData_SetSocketController_16(HandleRef pThis, HandleRef controller);

	/// <summary>
	/// This duplicate filter works in client server mode when this
	/// controller is set.  We have a client flag to differentiate the
	/// client and server because the socket controller is odd:
	/// Proth processes think their id is 0.
	/// </summary>
	public void SetSocketController(vtkSocketController controller)
	{
		vtkDuplicatePolyData_SetSocketController_16(GetCppThis(), controller?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDuplicatePolyData_SetSynchronous_17(HandleRef pThis, int _arg);

	/// <summary>
	/// This flag causes sends and receives to be matched.
	/// When this flag is off, two sends occur then two receives.
	/// I want to see if it makes a difference in performance.
	/// The flag is on by default.
	/// </summary>
	public virtual void SetSynchronous(int _arg)
	{
		vtkDuplicatePolyData_SetSynchronous_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDuplicatePolyData_SynchronousOff_18(HandleRef pThis);

	/// <summary>
	/// This flag causes sends and receives to be matched.
	/// When this flag is off, two sends occur then two receives.
	/// I want to see if it makes a difference in performance.
	/// The flag is on by default.
	/// </summary>
	public virtual void SynchronousOff()
	{
		vtkDuplicatePolyData_SynchronousOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDuplicatePolyData_SynchronousOn_19(HandleRef pThis);

	/// <summary>
	/// This flag causes sends and receives to be matched.
	/// When this flag is off, two sends occur then two receives.
	/// I want to see if it makes a difference in performance.
	/// The flag is on by default.
	/// </summary>
	public virtual void SynchronousOn()
	{
		vtkDuplicatePolyData_SynchronousOn_19(GetCppThis());
	}
}
