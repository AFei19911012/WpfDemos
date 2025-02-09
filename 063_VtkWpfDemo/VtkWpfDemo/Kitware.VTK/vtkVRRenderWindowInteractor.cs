using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVRRenderWindowInteractor
/// </summary>
/// <remarks>
///    Implements VR specific functions required by vtkRenderWindowInteractor.
/// </remarks>
public abstract class vtkVRRenderWindowInteractor : vtkRenderWindowInteractor3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVRRenderWindowInteractor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVRRenderWindowInteractor()
	{
		MRClassNameKey = "class vtkVRRenderWindowInteractor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRRenderWindowInteractor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVRRenderWindowInteractor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindowInteractor_ConvertPoseToWorldCoordinates_01(HandleRef pThis, HandleRef poseInTrackingCoordinates, IntPtr pos, IntPtr wxyz, IntPtr ppos, IntPtr wdir);

	/// <summary>
	/// Set/get the physical scale (world / physical distance ratio)
	/// </summary>
	public void ConvertPoseToWorldCoordinates(vtkMatrix4x4 poseInTrackingCoordinates, IntPtr pos, IntPtr wxyz, IntPtr ppos, IntPtr wdir)
	{
		vtkVRRenderWindowInteractor_ConvertPoseToWorldCoordinates_01(GetCppThis(), poseInTrackingCoordinates?.GetCppThis() ?? default(HandleRef), pos, wxyz, ppos, wdir);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindowInteractor_DoOneEvent_02(HandleRef pThis, HandleRef renWin, HandleRef ren);

	/// <summary>
	/// Implements the event loop.
	/// </summary>
	public virtual void DoOneEvent(vtkVRRenderWindow renWin, vtkRenderer ren)
	{
		vtkVRRenderWindowInteractor_DoOneEvent_02(GetCppThis(), renWin?.GetCppThis() ?? default(HandleRef), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindowInteractor_ExitCallback_03(HandleRef pThis);

	/// <summary>
	/// This method corresponds to the Exit callback, allowing for the style to invoke it.
	/// </summary>
	public override void ExitCallback()
	{
		vtkVRRenderWindowInteractor_ExitCallback_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkVRRenderWindowInteractor_GetActionManifestFileName_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the .json file describing action bindings for events.
	/// Based on https://github.com/ValveSoftware/openvr/wiki/Action-manifest
	/// </summary>
	public virtual string GetActionManifestFileName()
	{
		return vtkVRRenderWindowInteractor_GetActionManifestFileName_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkVRRenderWindowInteractor_GetActionSetName_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the .json file describing the action set to use.
	/// </summary>
	public virtual string GetActionSetName()
	{
		return vtkVRRenderWindowInteractor_GetActionSetName_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRRenderWindowInteractor_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVRRenderWindowInteractor_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRRenderWindowInteractor_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVRRenderWindowInteractor_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVRRenderWindowInteractor_GetPhysicalScale_08(HandleRef pThis);

	/// <summary>
	/// Set/get the physical scale (world / physical distance ratio)
	/// </summary>
	public override double GetPhysicalScale()
	{
		return vtkVRRenderWindowInteractor_GetPhysicalScale_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindowInteractor_GetPhysicalTranslation_09(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/get position of the physical coordinate system origin in world coordinates.
	/// </summary>
	public override IntPtr GetPhysicalTranslation(vtkCamera arg0)
	{
		return vtkVRRenderWindowInteractor_GetPhysicalTranslation_09(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindowInteractor_GetPhysicalViewDirection_10(HandleRef pThis);

	/// <summary>
	/// Set/get the direction of the physical coordinate system -Z axis in world coordinates.
	/// </summary>
	public override IntPtr GetPhysicalViewDirection()
	{
		return vtkVRRenderWindowInteractor_GetPhysicalViewDirection_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindowInteractor_GetPhysicalViewUp_11(HandleRef pThis);

	/// <summary>
	/// Set/get the direction of the physical coordinate system +Y axis in world coordinates.
	/// </summary>
	public override IntPtr GetPhysicalViewUp()
	{
		return vtkVRRenderWindowInteractor_GetPhysicalViewUp_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkEventDataDevice vtkVRRenderWindowInteractor_GetPointerDevice_12(HandleRef pThis);

	/// <summary>
	/// Set/get the physical scale (world / physical distance ratio)
	/// </summary>
	public vtkEventDataDevice GetPointerDevice()
	{
		return vtkVRRenderWindowInteractor_GetPointerDevice_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindowInteractor_GetStartingPhysicalToWorldMatrix_13(HandleRef pThis, HandleRef startingPhysicalToWorldMatrix);

	/// <summary>
	/// Set/get the physical scale (world / physical distance ratio)
	/// </summary>
	public void GetStartingPhysicalToWorldMatrix(vtkMatrix4x4 startingPhysicalToWorldMatrix)
	{
		vtkVRRenderWindowInteractor_GetStartingPhysicalToWorldMatrix_13(GetCppThis(), startingPhysicalToWorldMatrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindowInteractor_Initialize_14(HandleRef pThis);

	/// <summary>
	/// Initialize the event handler.
	/// </summary>
	public override void Initialize()
	{
		vtkVRRenderWindowInteractor_Initialize_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRRenderWindowInteractor_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVRRenderWindowInteractor_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRRenderWindowInteractor_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVRRenderWindowInteractor_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindowInteractor_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVRRenderWindowInteractor NewInstance()
	{
		vtkVRRenderWindowInteractor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRRenderWindowInteractor_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVRRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindowInteractor_ProcessEvents_18(HandleRef pThis);

	/// <summary>
	/// Run the event loop and return. This is provided so that you can
	/// implement your own event loop but yet use the VTK event handling as well.
	/// </summary>
	public override void ProcessEvents()
	{
		vtkVRRenderWindowInteractor_ProcessEvents_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindowInteractor_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVRRenderWindowInteractor SafeDownCast(vtkObjectBase o)
	{
		vtkVRRenderWindowInteractor vtkVRRenderWindowInteractor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRRenderWindowInteractor_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVRRenderWindowInteractor2 = (vtkVRRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVRRenderWindowInteractor2.Register(null);
			}
		}
		return vtkVRRenderWindowInteractor2;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindowInteractor_SetActionManifestFileName_20(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the .json file describing action bindings for events.
	/// Based on https://github.com/ValveSoftware/openvr/wiki/Action-manifest
	/// </summary>
	public virtual void SetActionManifestFileName(string _arg)
	{
		vtkVRRenderWindowInteractor_SetActionManifestFileName_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindowInteractor_SetActionSetName_21(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the .json file describing the action set to use.
	/// </summary>
	public virtual void SetActionSetName(string _arg)
	{
		vtkVRRenderWindowInteractor_SetActionSetName_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindowInteractor_SetPhysicalScale_22(HandleRef pThis, double arg0);

	/// <summary>
	/// Set/get the physical scale (world / physical distance ratio)
	/// </summary>
	public override void SetPhysicalScale(double arg0)
	{
		vtkVRRenderWindowInteractor_SetPhysicalScale_22(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindowInteractor_SetPhysicalTranslation_23(HandleRef pThis, HandleRef arg0, double arg1, double arg2, double arg3);

	/// <summary>
	/// Set/get position of the physical coordinate system origin in world coordinates.
	/// </summary>
	public override void SetPhysicalTranslation(vtkCamera arg0, double arg1, double arg2, double arg3)
	{
		vtkVRRenderWindowInteractor_SetPhysicalTranslation_23(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1, arg2, arg3);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindowInteractor_SetPhysicalViewDirection_24(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Set/get the direction of the physical coordinate system -Z axis in world coordinates.
	/// </summary>
	public override void SetPhysicalViewDirection(double arg0, double arg1, double arg2)
	{
		vtkVRRenderWindowInteractor_SetPhysicalViewDirection_24(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindowInteractor_SetPhysicalViewUp_25(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Set/get the direction of the physical coordinate system +Y axis in world coordinates.
	/// </summary>
	public override void SetPhysicalViewUp(double arg0, double arg1, double arg2)
	{
		vtkVRRenderWindowInteractor_SetPhysicalViewUp_25(GetCppThis(), arg0, arg1, arg2);
	}
}
