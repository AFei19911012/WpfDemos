using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVRHMDCamera
/// </summary>
/// <remarks>
///    A superclass for HMD style cameras
///
/// </remarks>
public abstract class vtkVRHMDCamera : vtkVRCamera
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVRHMDCamera";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVRHMDCamera()
	{
		MRClassNameKey = "class vtkVRHMDCamera";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRHMDCamera"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVRHMDCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkVRHMDCamera_GetKeyMatrices_01(HandleRef pThis, HandleRef ren, HandleRef WCVCMatrix, HandleRef normalMatrix, HandleRef VCDCMatrix, HandleRef WCDCMatrix);

	/// <summary>
	/// Implement base class method.
	/// </summary>
	public override void GetKeyMatrices(vtkRenderer ren, vtkMatrix4x4 WCVCMatrix, vtkMatrix3x3 normalMatrix, vtkMatrix4x4 VCDCMatrix, vtkMatrix4x4 WCDCMatrix)
	{
		vtkVRHMDCamera_GetKeyMatrices_01(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), WCVCMatrix?.GetCppThis() ?? default(HandleRef), normalMatrix?.GetCppThis() ?? default(HandleRef), VCDCMatrix?.GetCppThis() ?? default(HandleRef), WCDCMatrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRHMDCamera_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVRHMDCamera_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRHMDCamera_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVRHMDCamera_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRHMDCamera_GetPhysicalToProjectionMatrix_04(HandleRef pThis, HandleRef physicalToProjectionMatrtix);

	/// <summary>
	/// Provides a matrix to go from physical coordinates to projection coordinates
	/// for the eye currently being rendered. Just e.g. LeftEyeToProjection *
	/// PhysicalToLeftEye
	/// </summary>
	public override void GetPhysicalToProjectionMatrix(vtkMatrix4x4 physicalToProjectionMatrtix)
	{
		vtkVRHMDCamera_GetPhysicalToProjectionMatrix_04(GetCppThis(), physicalToProjectionMatrtix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRHMDCamera_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVRHMDCamera_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRHMDCamera_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVRHMDCamera_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRHMDCamera_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVRHMDCamera NewInstance()
	{
		vtkVRHMDCamera result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRHMDCamera_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVRHMDCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRHMDCamera_Render_08(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Implement base class method.
	/// </summary>
	public override void Render(vtkRenderer ren)
	{
		vtkVRHMDCamera_Render_08(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRHMDCamera_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVRHMDCamera SafeDownCast(vtkObjectBase o)
	{
		vtkVRHMDCamera vtkVRHMDCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRHMDCamera_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVRHMDCamera2 = (vtkVRHMDCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVRHMDCamera2.Register(null);
			}
		}
		return vtkVRHMDCamera2;
	}
}
