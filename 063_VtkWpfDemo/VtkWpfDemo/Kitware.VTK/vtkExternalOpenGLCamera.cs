using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExternalOpenGLCamera
/// </summary>
/// <remarks>
///    OpenGL camera
///
/// vtkExternalOpenGLCamera is a concrete implementation of the abstract class
/// vtkCamera.  vtkExternalOpenGLCamera interfaces to the OpenGL rendering library.
/// This class extends vtkOpenGLCamera by introducing API wherein the camera
/// matrices can be set explicitly by the application.
/// </remarks>
public class vtkExternalOpenGLCamera : vtkOpenGLCamera
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExternalOpenGLCamera";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExternalOpenGLCamera()
	{
		MRClassNameKey = "class vtkExternalOpenGLCamera";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExternalOpenGLCamera"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExternalOpenGLCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExternalOpenGLCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExternalOpenGLCamera New()
	{
		vtkExternalOpenGLCamera result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExternalOpenGLCamera_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExternalOpenGLCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExternalOpenGLCamera()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExternalOpenGLCamera_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExternalOpenGLCamera_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExternalOpenGLCamera_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExternalOpenGLCamera_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExternalOpenGLCamera_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExternalOpenGLCamera_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExternalOpenGLCamera_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExternalOpenGLCamera_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExternalOpenGLCamera_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExternalOpenGLCamera_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExternalOpenGLCamera NewInstance()
	{
		vtkExternalOpenGLCamera result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExternalOpenGLCamera_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExternalOpenGLCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExternalOpenGLCamera_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExternalOpenGLCamera SafeDownCast(vtkObjectBase o)
	{
		vtkExternalOpenGLCamera vtkExternalOpenGLCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExternalOpenGLCamera_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExternalOpenGLCamera2 = (vtkExternalOpenGLCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExternalOpenGLCamera2.Register(null);
			}
		}
		return vtkExternalOpenGLCamera2;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalOpenGLCamera_SetProjectionTransformMatrix_08(HandleRef pThis, IntPtr elements);

	/// <summary>
	/// Set the projection matrix
	/// </summary>
	public void SetProjectionTransformMatrix(IntPtr elements)
	{
		vtkExternalOpenGLCamera_SetProjectionTransformMatrix_08(GetCppThis(), elements);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalOpenGLCamera_SetViewTransformMatrix_09(HandleRef pThis, IntPtr elements);

	/// <summary>
	/// Set the view transform matrix
	/// </summary>
	public void SetViewTransformMatrix(IntPtr elements)
	{
		vtkExternalOpenGLCamera_SetViewTransformMatrix_09(GetCppThis(), elements);
	}
}
