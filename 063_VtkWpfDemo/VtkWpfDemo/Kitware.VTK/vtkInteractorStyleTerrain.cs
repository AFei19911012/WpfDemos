using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorStyleTerrain
/// </summary>
/// <remarks>
///    manipulate camera in scene with natural view up (e.g., terrain)
///
/// vtkInteractorStyleTerrain is used to manipulate a camera which is viewing
/// a scene with a natural view up, e.g., terrain. The camera in such a
/// scene is manipulated by specifying azimuth (angle around the view
/// up vector) and elevation (the angle from the horizon).
///
/// The mouse binding for this class is as follows. Left mouse click followed
/// rotates the camera around the focal point using both elevation and azimuth
/// invocations on the camera. Left mouse motion in the horizontal direction
/// results in azimuth motion; left mouse motion in the vertical direction
/// results in elevation motion. Therefore, diagonal motion results in a
/// combination of azimuth and elevation. (If the shift key is held during
/// motion, then only one of elevation or azimuth is invoked, depending on the
/// whether the mouse motion is primarily horizontal or vertical.) Middle
/// mouse button pans the camera across the scene (again the shift key has a
/// similar effect on limiting the motion to the vertical or horizontal
/// direction. The right mouse is used to dolly (e.g., a type of zoom) towards
/// or away from the focal point.
///
/// The class also supports some keypress events. The "r" key resets the
/// camera.  The "e" key invokes the exit callback and by default exits the
/// program. The "f" key sets a new camera focal point and flys towards that
/// point. The "u" key invokes the user event. The "3" key toggles between
/// stereo and non-stero mode. The "l" key toggles on/off a latitude/longitude
/// markers that can be used to estimate/control position.
///
///
/// </remarks>
/// <seealso>
///
/// vtkInteractorObserver vtkInteractorStyle vtk3DWidget
/// </seealso>
public class vtkInteractorStyleTerrain : vtkInteractorStyle
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleTerrain";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorStyleTerrain()
	{
		MRClassNameKey = "class vtkInteractorStyleTerrain";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleTerrain"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorStyleTerrain(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleTerrain_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkInteractorStyleTerrain New()
	{
		vtkInteractorStyleTerrain result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleTerrain_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleTerrain)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkInteractorStyleTerrain()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInteractorStyleTerrain_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTerrain_Dolly_01(HandleRef pThis);

	/// <summary>
	/// Override the "fly-to" (f keypress) for images.
	/// </summary>
	public override void Dolly()
	{
		vtkInteractorStyleTerrain_Dolly_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleTerrain_GetLatLongLines_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off the latitude/longitude lines.
	/// </summary>
	public virtual int GetLatLongLines()
	{
		return vtkInteractorStyleTerrain_GetLatLongLines_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleTerrain_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorStyleTerrain_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleTerrain_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorStyleTerrain_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleTerrain_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorStyleTerrain_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleTerrain_IsTypeOf_06(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorStyleTerrain_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTerrain_LatLongLinesOff_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off the latitude/longitude lines.
	/// </summary>
	public virtual void LatLongLinesOff()
	{
		vtkInteractorStyleTerrain_LatLongLinesOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTerrain_LatLongLinesOn_08(HandleRef pThis);

	/// <summary>
	/// Turn on/off the latitude/longitude lines.
	/// </summary>
	public virtual void LatLongLinesOn()
	{
		vtkInteractorStyleTerrain_LatLongLinesOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleTerrain_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new vtkInteractorStyleTerrain NewInstance()
	{
		vtkInteractorStyleTerrain result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleTerrain_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleTerrain)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTerrain_OnChar_11(HandleRef pThis);

	/// <summary>
	/// Override the "fly-to" (f keypress) for images.
	/// </summary>
	public override void OnChar()
	{
		vtkInteractorStyleTerrain_OnChar_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTerrain_OnLeftButtonDown_12(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnLeftButtonDown()
	{
		vtkInteractorStyleTerrain_OnLeftButtonDown_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTerrain_OnLeftButtonUp_13(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnLeftButtonUp()
	{
		vtkInteractorStyleTerrain_OnLeftButtonUp_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTerrain_OnMiddleButtonDown_14(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMiddleButtonDown()
	{
		vtkInteractorStyleTerrain_OnMiddleButtonDown_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTerrain_OnMiddleButtonUp_15(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMiddleButtonUp()
	{
		vtkInteractorStyleTerrain_OnMiddleButtonUp_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTerrain_OnMouseMove_16(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMouseMove()
	{
		vtkInteractorStyleTerrain_OnMouseMove_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTerrain_OnRightButtonDown_17(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnRightButtonDown()
	{
		vtkInteractorStyleTerrain_OnRightButtonDown_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTerrain_OnRightButtonUp_18(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnRightButtonUp()
	{
		vtkInteractorStyleTerrain_OnRightButtonUp_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTerrain_Pan_19(HandleRef pThis);

	/// <summary>
	/// Override the "fly-to" (f keypress) for images.
	/// </summary>
	public override void Pan()
	{
		vtkInteractorStyleTerrain_Pan_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTerrain_Rotate_20(HandleRef pThis);

	/// <summary>
	/// Override the "fly-to" (f keypress) for images.
	/// </summary>
	public override void Rotate()
	{
		vtkInteractorStyleTerrain_Rotate_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleTerrain_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkInteractorStyleTerrain SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorStyleTerrain vtkInteractorStyleTerrain2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleTerrain_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyleTerrain2 = (vtkInteractorStyleTerrain)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyleTerrain2.Register(null);
			}
		}
		return vtkInteractorStyleTerrain2;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTerrain_SetLatLongLines_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the latitude/longitude lines.
	/// </summary>
	public virtual void SetLatLongLines(int _arg)
	{
		vtkInteractorStyleTerrain_SetLatLongLines_22(GetCppThis(), _arg);
	}
}
