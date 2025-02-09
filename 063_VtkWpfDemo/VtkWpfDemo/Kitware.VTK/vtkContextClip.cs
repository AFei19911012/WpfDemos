using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkContextClip
/// </summary>
/// <remarks>
///    all children of this item are clipped
/// by the specified area.
///
///
/// This class can be used to clip the rendering of an item inside a rectangular
/// area.
/// </remarks>
public class vtkContextClip : vtkAbstractContextItem
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkContextClip";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkContextClip()
	{
		MRClassNameKey = "class vtkContextClip";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextClip"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkContextClip(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextClip_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a vtkContextClip object.
	/// </summary>
	public new static vtkContextClip New()
	{
		vtkContextClip result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextClip_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContextClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a vtkContextClip object.
	/// </summary>
	public vtkContextClip()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkContextClip_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkContextClip_GetHeight_01(HandleRef pThis);

	/// <summary>
	/// Get the clipping rectangle parameters in pixel coordinates:
	/// </summary>
	public virtual float GetHeight()
	{
		return vtkContextClip_GetHeight_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContextClip_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkContextClip_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContextClip_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkContextClip_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextClip_GetRect_04(HandleRef pThis, IntPtr rect);

	/// <summary>
	/// Get the clipping rectangle parameters in pixel coordinates:
	/// </summary>
	public virtual void GetRect(IntPtr rect)
	{
		vtkContextClip_GetRect_04(GetCppThis(), rect);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkContextClip_GetWidth_05(HandleRef pThis);

	/// <summary>
	/// Get the clipping rectangle parameters in pixel coordinates:
	/// </summary>
	public virtual float GetWidth()
	{
		return vtkContextClip_GetWidth_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkContextClip_GetX_06(HandleRef pThis);

	/// <summary>
	/// Get the clipping rectangle parameters in pixel coordinates:
	/// </summary>
	public virtual float GetX()
	{
		return vtkContextClip_GetX_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkContextClip_GetY_07(HandleRef pThis);

	/// <summary>
	/// Get the clipping rectangle parameters in pixel coordinates:
	/// </summary>
	public virtual float GetY()
	{
		return vtkContextClip_GetY_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextClip_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkContextClip_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextClip_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkContextClip_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextClip_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkContextClip NewInstance()
	{
		vtkContextClip result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextClip_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContextClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkContextClip_Paint_12(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the item, called whenever the item needs to be drawn.
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkContextClip_Paint_12(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextClip_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkContextClip SafeDownCast(vtkObjectBase o)
	{
		vtkContextClip vtkContextClip2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextClip_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContextClip2 = (vtkContextClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContextClip2.Register(null);
			}
		}
		return vtkContextClip2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextClip_SetClip_14(HandleRef pThis, float x, float y, float width, float height);

	/// <summary>
	/// Set the origin, width and height of the clipping rectangle. These are in
	/// pixel coordinates.
	/// </summary>
	public virtual void SetClip(float x, float y, float width, float height)
	{
		vtkContextClip_SetClip_14(GetCppThis(), x, y, width, height);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextClip_Update_15(HandleRef pThis);

	/// <summary>
	/// Perform any updates to the item that may be necessary before rendering.
	/// The scene should take care of calling this on all items before their
	/// Paint function is invoked.
	/// </summary>
	public override void Update()
	{
		vtkContextClip_Update_15(GetCppThis());
	}
}
