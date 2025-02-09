using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkBillboardTextActor3D
/// </summary>
/// <remarks>
///  Renders pixel-aligned text, facing the camera, anchored at a 3D point.
/// </remarks>
public class vtkBillboardTextActor3D : vtkProp3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBillboardTextActor3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBillboardTextActor3D()
	{
		MRClassNameKey = "class vtkBillboardTextActor3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBillboardTextActor3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBillboardTextActor3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBillboardTextActor3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBillboardTextActor3D New()
	{
		vtkBillboardTextActor3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBillboardTextActor3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBillboardTextActor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkBillboardTextActor3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBillboardTextActor3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBillboardTextActor3D_ForceOpaqueOff_01(HandleRef pThis);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public virtual void ForceOpaqueOff()
	{
		vtkBillboardTextActor3D_ForceOpaqueOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBillboardTextActor3D_ForceOpaqueOn_02(HandleRef pThis);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public virtual void ForceOpaqueOn()
	{
		vtkBillboardTextActor3D_ForceOpaqueOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBillboardTextActor3D_ForceTranslucentOff_03(HandleRef pThis);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public virtual void ForceTranslucentOff()
	{
		vtkBillboardTextActor3D_ForceTranslucentOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBillboardTextActor3D_ForceTranslucentOn_04(HandleRef pThis);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public virtual void ForceTranslucentOn()
	{
		vtkBillboardTextActor3D_ForceTranslucentOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBillboardTextActor3D_GetActors_05(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// For some exporters and other other operations we must be
	/// able to collect all the actors or volumes. These methods
	/// are used in that process.
	/// In case the viewport is not a consumer of this prop:
	/// call UpdateGeometry() first for updated viewport-specific
	/// billboard geometry.
	/// </summary>
	public override void GetActors(vtkPropCollection arg0)
	{
		vtkBillboardTextActor3D_GetActors_05(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBillboardTextActor3D_GetAnchorDC_06(HandleRef pThis);

	/// <summary>
	/// Returns the anchor position in display coordinates, with depth in NDC.
	/// Valid after calling RenderOpaqueGeometry.
	/// </summary>
	public virtual double[] GetAnchorDC()
	{
		IntPtr intPtr = vtkBillboardTextActor3D_GetAnchorDC_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBillboardTextActor3D_GetAnchorDC_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Returns the anchor position in display coordinates, with depth in NDC.
	/// Valid after calling RenderOpaqueGeometry.
	/// </summary>
	public virtual void GetAnchorDC(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkBillboardTextActor3D_GetAnchorDC_07(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBillboardTextActor3D_GetAnchorDC_08(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Returns the anchor position in display coordinates, with depth in NDC.
	/// Valid after calling RenderOpaqueGeometry.
	/// </summary>
	public virtual void GetAnchorDC(IntPtr _arg)
	{
		vtkBillboardTextActor3D_GetAnchorDC_08(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBillboardTextActor3D_GetBounds_09(HandleRef pThis);

	/// <summary>
	/// Just render in translucent pass, since it can execute multiple times
	/// (depth peeling, for instance).
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkBillboardTextActor3D_GetBounds_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBillboardTextActor3D_GetDisplayOffset_10(HandleRef pThis);

	/// <summary>
	/// Can be used to set a fixed offset from the anchor point.
	/// Use display coordinates.
	/// @{
	/// </summary>
	public virtual int[] GetDisplayOffset()
	{
		IntPtr intPtr = vtkBillboardTextActor3D_GetDisplayOffset_10(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBillboardTextActor3D_GetDisplayOffset_11(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Can be used to set a fixed offset from the anchor point.
	/// Use display coordinates.
	/// @{
	/// </summary>
	public virtual void GetDisplayOffset(ref int _arg1, ref int _arg2)
	{
		vtkBillboardTextActor3D_GetDisplayOffset_11(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBillboardTextActor3D_GetDisplayOffset_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Can be used to set a fixed offset from the anchor point.
	/// Use display coordinates.
	/// @{
	/// </summary>
	public virtual void GetDisplayOffset(IntPtr _arg)
	{
		vtkBillboardTextActor3D_GetDisplayOffset_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkBillboardTextActor3D_GetForceOpaque_13(HandleRef pThis);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public virtual bool GetForceOpaque()
	{
		return (vtkBillboardTextActor3D_GetForceOpaque_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkBillboardTextActor3D_GetForceTranslucent_14(HandleRef pThis);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public virtual bool GetForceTranslucent()
	{
		return (vtkBillboardTextActor3D_GetForceTranslucent_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBillboardTextActor3D_GetInput_15(HandleRef pThis);

	/// <summary>
	/// The UTF-8 encoded string to display.
	/// @{
	/// </summary>
	public virtual string GetInput()
	{
		return Marshal.PtrToStringAnsi(vtkBillboardTextActor3D_GetInput_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBillboardTextActor3D_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBillboardTextActor3D_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBillboardTextActor3D_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBillboardTextActor3D_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBillboardTextActor3D_GetTextProperty_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The vtkTextProperty object that controls the rendered text.
	/// @{
	/// </summary>
	public virtual vtkTextProperty GetTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBillboardTextActor3D_GetTextProperty_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextProperty2 = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextProperty2.Register(null);
			}
		}
		return vtkTextProperty2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBillboardTextActor3D_HasTranslucentPolygonalGeometry_19(HandleRef pThis);

	/// <summary>
	/// Defers to internal actor.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkBillboardTextActor3D_HasTranslucentPolygonalGeometry_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBillboardTextActor3D_IsA_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBillboardTextActor3D_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBillboardTextActor3D_IsTypeOf_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBillboardTextActor3D_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBillboardTextActor3D_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBillboardTextActor3D NewInstance()
	{
		vtkBillboardTextActor3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBillboardTextActor3D_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBillboardTextActor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBillboardTextActor3D_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef win);

	/// <summary>
	/// Just render in translucent pass, since it can execute multiple times
	/// (depth peeling, for instance).
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow win)
	{
		vtkBillboardTextActor3D_ReleaseGraphicsResources_24(GetCppThis(), win?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBillboardTextActor3D_RenderOpaqueGeometry_25(HandleRef pThis, HandleRef vp);

	/// <summary>
	/// Check/update geometry/texture in opaque pass, since it only happens once.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport vp)
	{
		return vtkBillboardTextActor3D_RenderOpaqueGeometry_25(GetCppThis(), vp?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBillboardTextActor3D_RenderTranslucentPolygonalGeometry_26(HandleRef pThis, HandleRef vp);

	/// <summary>
	/// Just render in translucent pass, since it can execute multiple times
	/// (depth peeling, for instance).
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport vp)
	{
		return vtkBillboardTextActor3D_RenderTranslucentPolygonalGeometry_26(GetCppThis(), vp?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBillboardTextActor3D_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBillboardTextActor3D SafeDownCast(vtkObjectBase o)
	{
		vtkBillboardTextActor3D vtkBillboardTextActor3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBillboardTextActor3D_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBillboardTextActor3D2 = (vtkBillboardTextActor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBillboardTextActor3D2.Register(null);
			}
		}
		return vtkBillboardTextActor3D2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBillboardTextActor3D_SetDisplayOffset_28(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Can be used to set a fixed offset from the anchor point.
	/// Use display coordinates.
	/// @{
	/// </summary>
	public virtual void SetDisplayOffset(int _arg1, int _arg2)
	{
		vtkBillboardTextActor3D_SetDisplayOffset_28(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBillboardTextActor3D_SetDisplayOffset_29(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Can be used to set a fixed offset from the anchor point.
	/// Use display coordinates.
	/// @{
	/// </summary>
	public void SetDisplayOffset(IntPtr _arg)
	{
		vtkBillboardTextActor3D_SetDisplayOffset_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBillboardTextActor3D_SetForceOpaque_30(HandleRef pThis, byte opaque);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public virtual void SetForceOpaque(bool opaque)
	{
		vtkBillboardTextActor3D_SetForceOpaque_30(GetCppThis(), (byte)(opaque ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBillboardTextActor3D_SetForceTranslucent_31(HandleRef pThis, byte trans);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public virtual void SetForceTranslucent(bool trans)
	{
		vtkBillboardTextActor3D_SetForceTranslucent_31(GetCppThis(), (byte)(trans ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBillboardTextActor3D_SetInput_32(HandleRef pThis, string arg0);

	/// <summary>
	/// The UTF-8 encoded string to display.
	/// @{
	/// </summary>
	public void SetInput(string arg0)
	{
		vtkBillboardTextActor3D_SetInput_32(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBillboardTextActor3D_SetTextProperty_33(HandleRef pThis, HandleRef tprop);

	/// <summary>
	/// The vtkTextProperty object that controls the rendered text.
	/// @{
	/// </summary>
	public void SetTextProperty(vtkTextProperty tprop)
	{
		vtkBillboardTextActor3D_SetTextProperty_33(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBillboardTextActor3D_UpdateGeometry_34(HandleRef pThis, HandleRef vp);

	/// <summary>
	/// Updates the billboard geometry without performing any rendering,
	/// to assist GetActors().
	/// </summary>
	public void UpdateGeometry(vtkViewport vp)
	{
		vtkBillboardTextActor3D_UpdateGeometry_34(GetCppThis(), vp?.GetCppThis() ?? default(HandleRef));
	}
}
