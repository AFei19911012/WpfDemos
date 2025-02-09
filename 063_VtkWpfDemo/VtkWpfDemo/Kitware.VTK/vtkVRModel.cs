using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVRModel
/// </summary>
/// <remarks>
///    VR device model
///
/// Abstract class used to load models
/// such as for the trackers and controllers and to
/// render them in the scene
///
/// </remarks>
public abstract class vtkVRModel : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVRModel";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVRModel()
	{
		MRClassNameKey = "class vtkVRModel";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRModel"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVRModel(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern byte vtkVRModel_Build_01(HandleRef pThis, HandleRef win);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public bool Build(vtkOpenGLRenderWindow win)
	{
		return (vtkVRModel_Build_01(GetCppThis(), win?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkVRModel_GetName_02(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public string GetName()
	{
		return vtkVRModel_GetName_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRModel_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVRModel_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRModel_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVRModel_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRModel_GetRay_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkVRRay GetRay()
	{
		vtkVRRay vtkVRRay2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRModel_GetRay_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVRRay2 = (vtkVRRay)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVRRay2.Register(null);
			}
		}
		return vtkVRRay2;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVRModel_GetVisibility_06(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public bool GetVisibility()
	{
		return (vtkVRModel_GetVisibility_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRModel_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVRModel_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRModel_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVRModel_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRModel_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVRModel NewInstance()
	{
		vtkVRModel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRModel_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVRModel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRModel_ReleaseGraphicsResources_10(HandleRef pThis, HandleRef win);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void ReleaseGraphicsResources(vtkWindow win)
	{
		vtkVRModel_ReleaseGraphicsResources_10(GetCppThis(), win?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRModel_Render_11(HandleRef pThis, HandleRef win, HandleRef poseInTrackingCoordinates);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void Render(vtkOpenGLRenderWindow win, vtkMatrix4x4 poseInTrackingCoordinates)
	{
		vtkVRModel_Render_11(GetCppThis(), win?.GetCppThis() ?? default(HandleRef), poseInTrackingCoordinates?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRModel_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVRModel SafeDownCast(vtkObjectBase o)
	{
		vtkVRModel vtkVRModel2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRModel_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVRModel2 = (vtkVRModel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVRModel2.Register(null);
			}
		}
		return vtkVRModel2;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRModel_SetName_13(HandleRef pThis, string modelName);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetName(string modelName)
	{
		vtkVRModel_SetName_13(GetCppThis(), modelName);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRModel_SetRayColor_14(HandleRef pThis, double r, double g, double b);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetRayColor(double r, double g, double b)
	{
		vtkVRModel_SetRayColor_14(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRModel_SetRayLength_15(HandleRef pThis, double length);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetRayLength(double length)
	{
		vtkVRModel_SetRayLength_15(GetCppThis(), length);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRModel_SetShowRay_16(HandleRef pThis, byte v);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetShowRay(bool v)
	{
		vtkVRModel_SetShowRay_16(GetCppThis(), (byte)(v ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRModel_SetVisibility_17(HandleRef pThis, byte v);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetVisibility(bool v)
	{
		vtkVRModel_SetVisibility_17(GetCppThis(), (byte)(v ? 1u : 0u));
	}
}
