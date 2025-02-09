using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorStyleDrawPolygon
/// </summary>
/// <remarks>
///    draw polygon during mouse move
///
/// This interactor style allows the user to draw a polygon in the render
/// window using the left mouse button while mouse is moving.
/// When the mouse button is released, a SelectionChangedEvent will be fired.
/// </remarks>
public class vtkInteractorStyleDrawPolygon : vtkInteractorStyle
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleDrawPolygon";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorStyleDrawPolygon()
	{
		MRClassNameKey = "class vtkInteractorStyleDrawPolygon";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleDrawPolygon"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorStyleDrawPolygon(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleDrawPolygon_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleDrawPolygon New()
	{
		vtkInteractorStyleDrawPolygon result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleDrawPolygon_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleDrawPolygon)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInteractorStyleDrawPolygon()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInteractorStyleDrawPolygon_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkInteractorStyleDrawPolygon_DrawPolygonPixelsOff_01(HandleRef pThis);

	/// <summary>
	/// Whether to draw polygon in screen pixels. Default is ON
	/// </summary>
	public virtual void DrawPolygonPixelsOff()
	{
		vtkInteractorStyleDrawPolygon_DrawPolygonPixelsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleDrawPolygon_DrawPolygonPixelsOn_02(HandleRef pThis);

	/// <summary>
	/// Whether to draw polygon in screen pixels. Default is ON
	/// </summary>
	public virtual void DrawPolygonPixelsOn()
	{
		vtkInteractorStyleDrawPolygon_DrawPolygonPixelsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkInteractorStyleDrawPolygon_GetDrawPolygonPixels_03(HandleRef pThis);

	/// <summary>
	/// Whether to draw polygon in screen pixels. Default is ON
	/// </summary>
	public virtual bool GetDrawPolygonPixels()
	{
		return (vtkInteractorStyleDrawPolygon_GetDrawPolygonPixels_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleDrawPolygon_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorStyleDrawPolygon_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleDrawPolygon_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorStyleDrawPolygon_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleDrawPolygon_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorStyleDrawPolygon_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleDrawPolygon_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorStyleDrawPolygon_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleDrawPolygon_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInteractorStyleDrawPolygon NewInstance()
	{
		vtkInteractorStyleDrawPolygon result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleDrawPolygon_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleDrawPolygon)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleDrawPolygon_OnLeftButtonDown_10(HandleRef pThis);

	/// <summary>
	/// Event bindings
	/// </summary>
	public override void OnLeftButtonDown()
	{
		vtkInteractorStyleDrawPolygon_OnLeftButtonDown_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleDrawPolygon_OnLeftButtonUp_11(HandleRef pThis);

	/// <summary>
	/// Event bindings
	/// </summary>
	public override void OnLeftButtonUp()
	{
		vtkInteractorStyleDrawPolygon_OnLeftButtonUp_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleDrawPolygon_OnMouseMove_12(HandleRef pThis);

	/// <summary>
	/// Event bindings
	/// </summary>
	public override void OnMouseMove()
	{
		vtkInteractorStyleDrawPolygon_OnMouseMove_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleDrawPolygon_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleDrawPolygon SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorStyleDrawPolygon vtkInteractorStyleDrawPolygon2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleDrawPolygon_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyleDrawPolygon2 = (vtkInteractorStyleDrawPolygon)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyleDrawPolygon2.Register(null);
			}
		}
		return vtkInteractorStyleDrawPolygon2;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleDrawPolygon_SetDrawPolygonPixels_14(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to draw polygon in screen pixels. Default is ON
	/// </summary>
	public virtual void SetDrawPolygonPixels(bool _arg)
	{
		vtkInteractorStyleDrawPolygon_SetDrawPolygonPixels_14(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
