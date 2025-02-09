using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorStyleUnicam
/// </summary>
/// <remarks>
///    provides Unicam navigation style
///
/// UniCam is a camera interactor.  Here, just the primary features of the
/// UniCam technique are implemented.  UniCam requires just one mouse button
/// and supports context sensitive dollying, panning, and rotation.  (In this
/// implementation, it uses the right mouse button, leaving the middle and
/// left available for other functions.) For more information, see the paper
/// at:
///
///    ftp://ftp.cs.brown.edu/pub/papers/graphics/research/unicam.pdf
///
/// The following is a brief description of the UniCam Camera Controls.  You
/// can perform 3 operations on the camera: rotate, pan, and dolly the camera.
/// All operations are reached through the right mouse button &amp; mouse
/// movements.
///
/// IMPORTANT: UniCam assumes there is an axis that makes sense as a "up"
/// vector for the world.  By default, this axis is defined to be the
/// vector &lt;0,0,1&gt;.  You can set it explicitly for the data you are
/// viewing with the 'SetWorldUpVector(..)' method.
///
/// 1. ROTATE:
///
/// Position the cursor over the point you wish to rotate around and press and
/// release the left mouse button.  A 'focus dot' appears indicating the
/// point that will be the center of rotation.  To rotate, press and hold the
/// left mouse button and drag the mouse.. release the button to complete the
/// rotation.
///
/// Rotations can be done without placing a focus dot first by moving the
/// mouse cursor to within 10% of the window border &amp; pressing and holding the
/// left button followed by dragging the mouse.  The last focus dot position
/// will be re-used.
///
/// 2. PAN:
///
/// Click and hold the left mouse button, and initially move the mouse left
/// or right.  The point under the initial pick will pick correlate w/ the
/// mouse tip-- (i.e., direct manipulation).
///
/// 3. DOLLY (+ PAN):
///
/// Click and hold the left mouse button, and initially move the mouse up or
/// down.  Moving the mouse down will dolly towards the picked point, and moving
/// the mouse up will dolly away from it.  Dollying occurs relative to the
/// picked point which simplifies the task of dollying towards a region of
/// interest. Left and right mouse movements will pan the camera left and right.
///
/// @warning
/// (NOTE: This implementation of Unicam assumes a perspective camera.  It
/// could be modified relatively easily to also support an orthographic
/// projection.)
/// </remarks>
public class vtkInteractorStyleUnicam : vtkInteractorStyle
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum BUTTON_LEFT_WrapperEnum
	{
		/// <summary>enum member</summary>
		BUTTON_LEFT = 1,
		/// <summary>enum member</summary>
		BUTTON_MIDDLE = 2,
		/// <summary>enum member</summary>
		BUTTON_RIGHT = 3,
		/// <summary>enum member</summary>
		NONE = 0
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum CAM_INT_CHOOSE_WrapperEnum
	{
		/// <summary>enum member</summary>
		CAM_INT_CHOOSE = 1,
		/// <summary>enum member</summary>
		CAM_INT_DOLLY = 3,
		/// <summary>enum member</summary>
		CAM_INT_PAN = 2,
		/// <summary>enum member</summary>
		CAM_INT_ROT = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleUnicam";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorStyleUnicam()
	{
		MRClassNameKey = "class vtkInteractorStyleUnicam";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleUnicam"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorStyleUnicam(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleUnicam_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleUnicam New()
	{
		vtkInteractorStyleUnicam result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleUnicam_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleUnicam)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInteractorStyleUnicam()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInteractorStyleUnicam_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkInteractorStyleUnicam_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorStyleUnicam_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleUnicam_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorStyleUnicam_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleUnicam_GetWorldUpVector_03(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual double[] GetWorldUpVector()
	{
		IntPtr intPtr = vtkInteractorStyleUnicam_GetWorldUpVector_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUnicam_GetWorldUpVector_04(HandleRef pThis, IntPtr data);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void GetWorldUpVector(IntPtr data)
	{
		vtkInteractorStyleUnicam_GetWorldUpVector_04(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleUnicam_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorStyleUnicam_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleUnicam_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorStyleUnicam_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleUnicam_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInteractorStyleUnicam NewInstance()
	{
		vtkInteractorStyleUnicam result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleUnicam_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleUnicam)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUnicam_OnLeftButtonDown_09(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of event bindings
	/// </summary>
	public override void OnLeftButtonDown()
	{
		vtkInteractorStyleUnicam_OnLeftButtonDown_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUnicam_OnLeftButtonMove_10(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of event bindings
	/// </summary>
	public virtual void OnLeftButtonMove()
	{
		vtkInteractorStyleUnicam_OnLeftButtonMove_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUnicam_OnLeftButtonUp_11(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of event bindings
	/// </summary>
	public override void OnLeftButtonUp()
	{
		vtkInteractorStyleUnicam_OnLeftButtonUp_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUnicam_OnMouseMove_12(HandleRef pThis);

	/// <summary>
	/// Concrete implementation of event bindings
	/// </summary>
	public override void OnMouseMove()
	{
		vtkInteractorStyleUnicam_OnMouseMove_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUnicam_OnTimer_13(HandleRef pThis);

	/// <summary>
	/// OnTimer calls RotateCamera, RotateActor etc which should be overridden by
	/// style subclasses.
	/// </summary>
	public override void OnTimer()
	{
		vtkInteractorStyleUnicam_OnTimer_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleUnicam_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleUnicam SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorStyleUnicam vtkInteractorStyleUnicam2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleUnicam_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyleUnicam2 = (vtkInteractorStyleUnicam)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyleUnicam2.Register(null);
			}
		}
		return vtkInteractorStyleUnicam2;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUnicam_SetWorldUpVector_15(HandleRef pThis, IntPtr a);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetWorldUpVector(IntPtr a)
	{
		vtkInteractorStyleUnicam_SetWorldUpVector_15(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUnicam_SetWorldUpVector_16(HandleRef pThis, double x, double y, double z);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetWorldUpVector(double x, double y, double z)
	{
		vtkInteractorStyleUnicam_SetWorldUpVector_16(GetCppThis(), x, y, z);
	}
}
