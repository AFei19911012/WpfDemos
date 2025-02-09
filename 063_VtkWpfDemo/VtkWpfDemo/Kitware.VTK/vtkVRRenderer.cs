using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVRRenderer
/// </summary>
/// <remarks>
///    VR renderer
///
/// vtkVRRenderer is an abstract vtkRenderer class that is meant to be used in VR context.
/// It defines a floor actor with a grid fading with the distance.
///
/// Subclasses must define MakeCamera()
/// </remarks>
public abstract class vtkVRRenderer : vtkOpenGLRenderer
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVRRenderer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVRRenderer()
	{
		MRClassNameKey = "class vtkVRRenderer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRRenderer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVRRenderer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkVRRenderer_DeviceRender_01(HandleRef pThis);

	/// <summary>
	/// Render the floor using GetFloorTransform
	/// </summary>
	public override void DeviceRender()
	{
		vtkVRRenderer_DeviceRender_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderer_GetFloorTransform_02(HandleRef pThis, HandleRef transform);

	/// <summary>
	/// Store in \p transform the floor transform.
	/// </summary>
	public virtual void GetFloorTransform(vtkTransform transform)
	{
		vtkVRRenderer_GetFloorTransform_02(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRRenderer_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVRRenderer_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRRenderer_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVRRenderer_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVRRenderer_GetShowFloor_05(HandleRef pThis);

	/// <summary>
	/// Show the floor of the VR world
	/// </summary>
	public virtual bool GetShowFloor()
	{
		return (vtkVRRenderer_GetShowFloor_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRRenderer_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVRRenderer_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRRenderer_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVRRenderer_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderer_MakeCamera_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Abstract function that creates a new Camera suitable for use with this type of Renderer.
	/// </summary>
	public override vtkCamera MakeCamera()
	{
		vtkCamera vtkCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRRenderer_MakeCamera_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCamera2 = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCamera2.Register(null);
			}
		}
		return vtkCamera2;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderer_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVRRenderer NewInstance()
	{
		vtkVRRenderer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRRenderer_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVRRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderer_ResetCamera_10(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Automatically set up the camera based on a specified bounding box
	/// (xmin,xmax, ymin,ymax, zmin,zmax). Camera will reposition itself so
	/// that its focal point is the center of the bounding box, and adjust its
	/// distance and position to preserve its initial view plane normal
	/// (i.e., vector defined from camera position to focal point). Note: if
	/// the view plane is parallel to the view up axis, the view up axis will
	/// be reset to one of the three coordinate axes.
	/// </summary>
	public override void ResetCamera(IntPtr bounds)
	{
		vtkVRRenderer_ResetCamera_10(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderer_ResetCameraClippingRange_11(HandleRef pThis);

	/// <summary>
	/// Reset the camera clipping range based on a bounding box.
	/// </summary>
	public override void ResetCameraClippingRange()
	{
		vtkVRRenderer_ResetCameraClippingRange_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderer_ResetCameraClippingRange_12(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Reset the camera clipping range based on a bounding box.
	/// </summary>
	public override void ResetCameraClippingRange(IntPtr bounds)
	{
		vtkVRRenderer_ResetCameraClippingRange_12(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderer_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVRRenderer SafeDownCast(vtkObjectBase o)
	{
		vtkVRRenderer vtkVRRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRRenderer_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVRRenderer2 = (vtkVRRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVRRenderer2.Register(null);
			}
		}
		return vtkVRRenderer2;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderer_SetShowFloor_14(HandleRef pThis, byte arg0);

	/// <summary>
	/// Show the floor of the VR world
	/// </summary>
	public virtual void SetShowFloor(bool arg0)
	{
		vtkVRRenderer_SetShowFloor_14(GetCppThis(), (byte)(arg0 ? 1u : 0u));
	}
}
