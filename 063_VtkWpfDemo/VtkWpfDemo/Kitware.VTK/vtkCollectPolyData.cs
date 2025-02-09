using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCollectPolyData
/// </summary>
/// <remarks>
///    Collect distributed polydata.
///
/// This filter has code to collect polydat from across processes onto node 0.
/// Collection can be turned on or off using the "PassThrough" flag.
/// </remarks>
public class vtkCollectPolyData : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCollectPolyData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCollectPolyData()
	{
		MRClassNameKey = "class vtkCollectPolyData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCollectPolyData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCollectPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollectPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCollectPolyData New()
	{
		vtkCollectPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollectPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCollectPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCollectPolyData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCollectPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCollectPolyData_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkCollectPolyData_GetController_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkCollectPolyData_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCollectPolyData_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCollectPolyData_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCollectPolyData_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollectPolyData_GetPassThrough_04(HandleRef pThis);

	/// <summary>
	/// To collect or just copy input to output. Off (collect) by default.
	/// </summary>
	public virtual int GetPassThrough()
	{
		return vtkCollectPolyData_GetPassThrough_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollectPolyData_GetSocketController_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// When this filter is being used in client-server mode,
	/// this is the controller used to communicate between
	/// client and server.  Client should not set the other controller.
	/// </summary>
	public virtual vtkSocketController GetSocketController()
	{
		vtkSocketController vtkSocketController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollectPolyData_GetSocketController_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCollectPolyData_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCollectPolyData_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollectPolyData_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCollectPolyData_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollectPolyData_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCollectPolyData NewInstance()
	{
		vtkCollectPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollectPolyData_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCollectPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollectPolyData_PassThroughOff_10(HandleRef pThis);

	/// <summary>
	/// To collect or just copy input to output. Off (collect) by default.
	/// </summary>
	public virtual void PassThroughOff()
	{
		vtkCollectPolyData_PassThroughOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollectPolyData_PassThroughOn_11(HandleRef pThis);

	/// <summary>
	/// To collect or just copy input to output. Off (collect) by default.
	/// </summary>
	public virtual void PassThroughOn()
	{
		vtkCollectPolyData_PassThroughOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollectPolyData_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCollectPolyData SafeDownCast(vtkObjectBase o)
	{
		vtkCollectPolyData vtkCollectPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollectPolyData_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCollectPolyData2 = (vtkCollectPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCollectPolyData2.Register(null);
			}
		}
		return vtkCollectPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollectPolyData_SetController_13(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// By default this filter uses the global controller,
	/// but this method can be used to set another instead.
	/// </summary>
	public virtual void SetController(vtkMultiProcessController arg0)
	{
		vtkCollectPolyData_SetController_13(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollectPolyData_SetPassThrough_14(HandleRef pThis, int _arg);

	/// <summary>
	/// To collect or just copy input to output. Off (collect) by default.
	/// </summary>
	public virtual void SetPassThrough(int _arg)
	{
		vtkCollectPolyData_SetPassThrough_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollectPolyData_SetSocketController_15(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// When this filter is being used in client-server mode,
	/// this is the controller used to communicate between
	/// client and server.  Client should not set the other controller.
	/// </summary>
	public virtual void SetSocketController(vtkSocketController arg0)
	{
		vtkCollectPolyData_SetSocketController_15(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
