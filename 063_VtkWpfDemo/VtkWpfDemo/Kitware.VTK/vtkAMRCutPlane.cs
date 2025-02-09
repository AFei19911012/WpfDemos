using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAMRCutPlane
///
///
///  A concrete instance of vtkMultiBlockDataSet that provides functionality for
/// cutting an AMR dataset (an instance of vtkOverlappingAMR) with user supplied
/// implicit plane function defined by a normal and center.
/// </summary>
public class vtkAMRCutPlane : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAMRCutPlane";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAMRCutPlane()
	{
		MRClassNameKey = "class vtkAMRCutPlane";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRCutPlane"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAMRCutPlane(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRCutPlane_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAMRCutPlane New()
	{
		vtkAMRCutPlane result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRCutPlane_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAMRCutPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAMRCutPlane()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAMRCutPlane_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRCutPlane_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Set/Get a multiprocess controller for parallel processing.
	/// By default this parameter is set to nullptr by the constructor.
	/// </summary>
	public virtual int FillInputPortInformation(int port, vtkInformation info)
	{
		return vtkAMRCutPlane_FillInputPortInformation_01(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRCutPlane_FillOutputPortInformation_02(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Set/Get a multiprocess controller for parallel processing.
	/// By default this parameter is set to nullptr by the constructor.
	/// </summary>
	public virtual int FillOutputPortInformation(int port, vtkInformation info)
	{
		return vtkAMRCutPlane_FillOutputPortInformation_02(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRCutPlane_GetController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get a multiprocess controller for parallel processing.
	/// By default this parameter is set to nullptr by the constructor.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRCutPlane_GetController_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRCutPlane_GetLevelOfResolution_04(HandleRef pThis);

	/// <summary>
	/// Sets the level of resolution
	/// </summary>
	public virtual int GetLevelOfResolution()
	{
		return vtkAMRCutPlane_GetLevelOfResolution_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMRCutPlane_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAMRCutPlane_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMRCutPlane_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAMRCutPlane_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAMRCutPlane_GetUseNativeCutter_07(HandleRef pThis);

	/// <summary>
	/// Sets if plane cutter is used instead of the specialized AMR cutter.
	///
	/// Default is true.
	/// </summary>
	public virtual bool GetUseNativeCutter()
	{
		return (vtkAMRCutPlane_GetUseNativeCutter_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRCutPlane_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAMRCutPlane_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRCutPlane_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAMRCutPlane_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRCutPlane_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAMRCutPlane NewInstance()
	{
		vtkAMRCutPlane result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRCutPlane_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAMRCutPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRCutPlane_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAMRCutPlane SafeDownCast(vtkObjectBase o)
	{
		vtkAMRCutPlane vtkAMRCutPlane2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRCutPlane_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAMRCutPlane2 = (vtkAMRCutPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAMRCutPlane2.Register(null);
			}
		}
		return vtkAMRCutPlane2;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRCutPlane_SetCenter_13(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Sets the center
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkAMRCutPlane_SetCenter_13(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRCutPlane_SetCenter_14(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Sets the center
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkAMRCutPlane_SetCenter_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRCutPlane_SetController_15(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get a multiprocess controller for parallel processing.
	/// By default this parameter is set to nullptr by the constructor.
	/// </summary>
	public virtual void SetController(vtkMultiProcessController arg0)
	{
		vtkAMRCutPlane_SetController_15(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRCutPlane_SetInitialRequest_16(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set if it's the initial request.
	/// </summary>
	public virtual void SetInitialRequest(bool _arg)
	{
		vtkAMRCutPlane_SetInitialRequest_16(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRCutPlane_SetLevelOfResolution_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Sets the level of resolution
	/// </summary>
	public virtual void SetLevelOfResolution(int _arg)
	{
		vtkAMRCutPlane_SetLevelOfResolution_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRCutPlane_SetNormal_18(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Sets the normal
	/// </summary>
	public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
	{
		vtkAMRCutPlane_SetNormal_18(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRCutPlane_SetNormal_19(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Sets the normal
	/// </summary>
	public virtual void SetNormal(IntPtr _arg)
	{
		vtkAMRCutPlane_SetNormal_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRCutPlane_SetUseNativeCutter_20(HandleRef pThis, byte _arg);

	/// <summary>
	/// Sets if plane cutter is used instead of the specialized AMR cutter.
	///
	/// Default is true.
	/// </summary>
	public virtual void SetUseNativeCutter(bool _arg)
	{
		vtkAMRCutPlane_SetUseNativeCutter_20(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRCutPlane_UseNativeCutterOff_21(HandleRef pThis);

	/// <summary>
	/// Sets if plane cutter is used instead of the specialized AMR cutter.
	///
	/// Default is true.
	/// </summary>
	public virtual void UseNativeCutterOff()
	{
		vtkAMRCutPlane_UseNativeCutterOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRCutPlane_UseNativeCutterOn_22(HandleRef pThis);

	/// <summary>
	/// Sets if plane cutter is used instead of the specialized AMR cutter.
	///
	/// Default is true.
	/// </summary>
	public virtual void UseNativeCutterOn()
	{
		vtkAMRCutPlane_UseNativeCutterOn_22(GetCppThis());
	}
}
