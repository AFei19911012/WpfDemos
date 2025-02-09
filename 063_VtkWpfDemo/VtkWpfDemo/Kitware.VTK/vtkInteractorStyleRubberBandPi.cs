using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorStyleRubberBandPick
/// </summary>
/// <remarks>
///    Like TrackBallCamera, but this can pick props underneath a rubber band selection
/// rectangle.
///
///
/// This interactor style allows the user to draw a rectangle in the render
/// window by hitting 'r' and then using the left mouse button.
/// When the mouse button is released, the attached picker operates on the pixel
/// in the center of the selection rectangle. If the picker happens to be a
/// vtkAreaPicker it will operate on the entire selection rectangle.
/// When the 'p' key is hit the above pick operation occurs on a 1x1 rectangle.
/// In other respects it behaves the same as its parent class.
///
/// </remarks>
/// <seealso>
///
/// vtkAreaPicker
/// </seealso>
public class vtkInteractorStyleRubberBandPick : vtkInteractorStyleTrackballCamera
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleRubberBandPick";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorStyleRubberBandPick()
	{
		MRClassNameKey = "class vtkInteractorStyleRubberBandPick";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleRubberBandPick"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorStyleRubberBandPick(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleRubberBandPick_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleRubberBandPick New()
	{
		vtkInteractorStyleRubberBandPick result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleRubberBandPick_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleRubberBandPick)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInteractorStyleRubberBandPick()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInteractorStyleRubberBandPick_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkInteractorStyleRubberBandPick_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorStyleRubberBandPick_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleRubberBandPick_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorStyleRubberBandPick_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleRubberBandPick_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorStyleRubberBandPick_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleRubberBandPick_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorStyleRubberBandPick_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleRubberBandPick_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInteractorStyleRubberBandPick NewInstance()
	{
		vtkInteractorStyleRubberBandPick result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleRubberBandPick_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleRubberBandPick)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBandPick_OnChar_07(HandleRef pThis);

	/// <summary>
	/// Event bindings
	/// </summary>
	public override void OnChar()
	{
		vtkInteractorStyleRubberBandPick_OnChar_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBandPick_OnLeftButtonDown_08(HandleRef pThis);

	/// <summary>
	/// Event bindings
	/// </summary>
	public override void OnLeftButtonDown()
	{
		vtkInteractorStyleRubberBandPick_OnLeftButtonDown_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBandPick_OnLeftButtonUp_09(HandleRef pThis);

	/// <summary>
	/// Event bindings
	/// </summary>
	public override void OnLeftButtonUp()
	{
		vtkInteractorStyleRubberBandPick_OnLeftButtonUp_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBandPick_OnMouseMove_10(HandleRef pThis);

	/// <summary>
	/// Event bindings
	/// </summary>
	public override void OnMouseMove()
	{
		vtkInteractorStyleRubberBandPick_OnMouseMove_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleRubberBandPick_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleRubberBandPick SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorStyleRubberBandPick vtkInteractorStyleRubberBandPick2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleRubberBandPick_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyleRubberBandPick2 = (vtkInteractorStyleRubberBandPick)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyleRubberBandPick2.Register(null);
			}
		}
		return vtkInteractorStyleRubberBandPick2;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBandPick_StartSelect_12(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void StartSelect()
	{
		vtkInteractorStyleRubberBandPick_StartSelect_12(GetCppThis());
	}
}
