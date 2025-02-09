using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCameraRepresentation
/// </summary>
/// <remarks>
///    represent the vtkCameraWidget
///
/// This class provides support for interactively saving a series of camera
/// views into an interpolated path (using vtkCameraInterpolator). The class
/// typically works in conjunction with vtkCameraWidget. To use this class
/// simply specify the camera to interpolate and use the methods
/// AddCameraToPath(), AnimatePath(), and InitializePath() to add a new camera
/// view, animate the current views, and initialize the interpolation.
///
/// </remarks>
/// <seealso>
///
/// vtkCameraWidget vtkCameraInterpolator
/// </seealso>
public class vtkCameraRepresentation : vtkBorderRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCameraRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCameraRepresentation()
	{
		MRClassNameKey = "class vtkCameraRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCameraRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkCameraRepresentation New()
	{
		vtkCameraRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCameraRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkCameraRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCameraRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraRepresentation_AddCameraToPath_01(HandleRef pThis);

	/// <summary>
	/// These methods are used to create interpolated camera paths.  The
	/// AddCameraToPath() method adds the view defined by the current camera
	/// (via SetCamera()) to the interpolated camera path. AnimatePath()
	/// interpolates NumberOfFrames along the current path. InitializePath()
	/// resets the interpolated path to its initial, empty configuration.
	/// </summary>
	public void AddCameraToPath()
	{
		vtkCameraRepresentation_AddCameraToPath_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraRepresentation_AnimatePath_02(HandleRef pThis, HandleRef rwi);

	/// <summary>
	/// These methods are used to create interpolated camera paths.  The
	/// AddCameraToPath() method adds the view defined by the current camera
	/// (via SetCamera()) to the interpolated camera path. AnimatePath()
	/// interpolates NumberOfFrames along the current path. InitializePath()
	/// resets the interpolated path to its initial, empty configuration.
	/// </summary>
	public void AnimatePath(vtkRenderWindowInteractor rwi)
	{
		vtkCameraRepresentation_AnimatePath_02(GetCppThis(), rwi?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraRepresentation_BuildRepresentation_03(HandleRef pThis);

	/// <summary>
	/// Satisfy the superclasses' API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkCameraRepresentation_BuildRepresentation_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraRepresentation_GetActors2D_04(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override void GetActors2D(vtkPropCollection arg0)
	{
		vtkCameraRepresentation_GetActors2D_04(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraRepresentation_GetCamera_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the camera to interpolate. This must be specified by
	/// the user.
	/// </summary>
	public virtual vtkCamera GetCamera()
	{
		vtkCamera vtkCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraRepresentation_GetCamera_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraRepresentation_GetInterpolator_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vtkCameraInterpolator used to interpolate and save the
	/// sequence of camera views. If not defined, one is created
	/// automatically. Note that you can access this object to set
	/// the interpolation type (linear, spline) and other instance
	/// variables.
	/// </summary>
	public virtual vtkCameraInterpolator GetInterpolator()
	{
		vtkCameraInterpolator vtkCameraInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraRepresentation_GetInterpolator_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCameraInterpolator2 = (vtkCameraInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCameraInterpolator2.Register(null);
			}
		}
		return vtkCameraInterpolator2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraRepresentation_GetNumberOfFrames_07(HandleRef pThis);

	/// <summary>
	/// Set the number of frames to generate when playback is initiated.
	/// </summary>
	public virtual int GetNumberOfFrames()
	{
		return vtkCameraRepresentation_GetNumberOfFrames_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraRepresentation_GetNumberOfFramesMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set the number of frames to generate when playback is initiated.
	/// </summary>
	public virtual int GetNumberOfFramesMaxValue()
	{
		return vtkCameraRepresentation_GetNumberOfFramesMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraRepresentation_GetNumberOfFramesMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set the number of frames to generate when playback is initiated.
	/// </summary>
	public virtual int GetNumberOfFramesMinValue()
	{
		return vtkCameraRepresentation_GetNumberOfFramesMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCameraRepresentation_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCameraRepresentation_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCameraRepresentation_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCameraRepresentation_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraRepresentation_GetProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// By obtaining this property you can specify the properties of the
	/// representation.
	/// </summary>
	public virtual vtkProperty2D GetProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraRepresentation_GetProperty_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2D2 = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2D2.Register(null);
			}
		}
		return vtkProperty2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraRepresentation_GetSize_13(HandleRef pThis, IntPtr size);

	/// <summary>
	/// Satisfy the superclasses' API.
	/// </summary>
	public override void GetSize(IntPtr size)
	{
		vtkCameraRepresentation_GetSize_13(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraRepresentation_HasTranslucentPolygonalGeometry_14(HandleRef pThis);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkCameraRepresentation_HasTranslucentPolygonalGeometry_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraRepresentation_InitializePath_15(HandleRef pThis);

	/// <summary>
	/// These methods are used to create interpolated camera paths.  The
	/// AddCameraToPath() method adds the view defined by the current camera
	/// (via SetCamera()) to the interpolated camera path. AnimatePath()
	/// interpolates NumberOfFrames along the current path. InitializePath()
	/// resets the interpolated path to its initial, empty configuration.
	/// </summary>
	public void InitializePath()
	{
		vtkCameraRepresentation_InitializePath_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraRepresentation_IsA_16(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCameraRepresentation_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraRepresentation_IsTypeOf_17(string type);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCameraRepresentation_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraRepresentation_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public new vtkCameraRepresentation NewInstance()
	{
		vtkCameraRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraRepresentation_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCameraRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraRepresentation_ReleaseGraphicsResources_20(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkCameraRepresentation_ReleaseGraphicsResources_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraRepresentation_RenderOpaqueGeometry_21(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkCameraRepresentation_RenderOpaqueGeometry_21(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraRepresentation_RenderOverlay_22(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkCameraRepresentation_RenderOverlay_22(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraRepresentation_RenderTranslucentPolygonalGeometry_23(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkCameraRepresentation_RenderTranslucentPolygonalGeometry_23(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraRepresentation_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public new static vtkCameraRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkCameraRepresentation vtkCameraRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraRepresentation_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCameraRepresentation2 = (vtkCameraRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCameraRepresentation2.Register(null);
			}
		}
		return vtkCameraRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraRepresentation_SetCamera_25(HandleRef pThis, HandleRef camera);

	/// <summary>
	/// Specify the camera to interpolate. This must be specified by
	/// the user.
	/// </summary>
	public void SetCamera(vtkCamera camera)
	{
		vtkCameraRepresentation_SetCamera_25(GetCppThis(), camera?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraRepresentation_SetInterpolator_26(HandleRef pThis, HandleRef camInt);

	/// <summary>
	/// Get the vtkCameraInterpolator used to interpolate and save the
	/// sequence of camera views. If not defined, one is created
	/// automatically. Note that you can access this object to set
	/// the interpolation type (linear, spline) and other instance
	/// variables.
	/// </summary>
	public void SetInterpolator(vtkCameraInterpolator camInt)
	{
		vtkCameraRepresentation_SetInterpolator_26(GetCppThis(), camInt?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraRepresentation_SetNumberOfFrames_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of frames to generate when playback is initiated.
	/// </summary>
	public virtual void SetNumberOfFrames(int _arg)
	{
		vtkCameraRepresentation_SetNumberOfFrames_27(GetCppThis(), _arg);
	}
}
