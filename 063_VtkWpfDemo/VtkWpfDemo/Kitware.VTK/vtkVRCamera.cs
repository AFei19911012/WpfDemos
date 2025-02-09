using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVRCamera
/// </summary>
/// <remarks>
///    VR camera
///
/// vtkVRCamera is a concrete implementation of the abstract class
/// vtkCamera.  vtkVRCamera interfaces to the VR rendering library.
/// </remarks>
public abstract class vtkVRCamera : vtkOpenGLCamera
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVRCamera";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVRCamera()
	{
		MRClassNameKey = "class vtkVRCamera";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRCamera"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVRCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern long vtkVRCamera_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVRCamera_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRCamera_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVRCamera_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRCamera_GetPhysicalToProjectionMatrix_03(HandleRef pThis, HandleRef physicalToProjectionMatrix);

	/// <summary>
	/// Provides a matrix to go from physical coordinates to projection coordinates
	/// for the eye currently being rendered. Just e.g. LeftEyeToProjection *
	/// PhysicalToLeftEye
	/// </summary>
	public virtual void GetPhysicalToProjectionMatrix(vtkMatrix4x4 physicalToProjectionMatrix)
	{
		vtkVRCamera_GetPhysicalToProjectionMatrix_03(GetCppThis(), physicalToProjectionMatrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRCamera_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVRCamera_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRCamera_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVRCamera_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRCamera_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVRCamera NewInstance()
	{
		vtkVRCamera result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRCamera_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVRCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRCamera_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVRCamera SafeDownCast(vtkObjectBase o)
	{
		vtkVRCamera vtkVRCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRCamera_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVRCamera2 = (vtkVRCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVRCamera2.Register(null);
			}
		}
		return vtkVRCamera2;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRCamera_SetCameraFromDeviceToWorldMatrix_08(HandleRef pThis, HandleRef mat, double distance);

	/// <summary>
	/// Provides a matrix to go from physical coordinates to projection coordinates
	/// for the eye currently being rendered. Just e.g. LeftEyeToProjection *
	/// PhysicalToLeftEye
	/// </summary>
	public void SetCameraFromDeviceToWorldMatrix(vtkMatrix4x4 mat, double distance)
	{
		vtkVRCamera_SetCameraFromDeviceToWorldMatrix_08(GetCppThis(), mat?.GetCppThis() ?? default(HandleRef), distance);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRCamera_SetCameraFromWorldToDeviceMatrix_09(HandleRef pThis, HandleRef mat, double distance);

	/// <summary>
	/// Provides a matrix to go from physical coordinates to projection coordinates
	/// for the eye currently being rendered. Just e.g. LeftEyeToProjection *
	/// PhysicalToLeftEye
	/// </summary>
	public void SetCameraFromWorldToDeviceMatrix(vtkMatrix4x4 mat, double distance)
	{
		vtkVRCamera_SetCameraFromWorldToDeviceMatrix_09(GetCppThis(), mat?.GetCppThis() ?? default(HandleRef), distance);
	}
}
