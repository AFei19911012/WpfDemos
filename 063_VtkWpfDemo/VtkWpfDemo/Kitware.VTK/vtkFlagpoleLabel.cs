using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkFlagpoleLabel
/// </summary>
/// <remarks>
///  Renders a flagpole (line) with a label at the top that faces the camera
///
/// This class draws a line from the base to the top of the flagpole. It then
/// places a text annotation at the top, centered horizontally. The text is
/// always oriented with the flagpole but will rotate aroundthe flagpole to
/// face the camera.
/// </remarks>
public class vtkFlagpoleLabel : vtkActor
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFlagpoleLabel";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFlagpoleLabel()
	{
		MRClassNameKey = "class vtkFlagpoleLabel";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFlagpoleLabel"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFlagpoleLabel(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFlagpoleLabel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFlagpoleLabel New()
	{
		vtkFlagpoleLabel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFlagpoleLabel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFlagpoleLabel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFlagpoleLabel()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFlagpoleLabel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkFlagpoleLabel_ForceOpaqueOff_01(HandleRef pThis);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public override void ForceOpaqueOff()
	{
		vtkFlagpoleLabel_ForceOpaqueOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlagpoleLabel_ForceOpaqueOn_02(HandleRef pThis);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public override void ForceOpaqueOn()
	{
		vtkFlagpoleLabel_ForceOpaqueOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlagpoleLabel_ForceTranslucentOff_03(HandleRef pThis);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public override void ForceTranslucentOff()
	{
		vtkFlagpoleLabel_ForceTranslucentOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlagpoleLabel_ForceTranslucentOn_04(HandleRef pThis);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public override void ForceTranslucentOn()
	{
		vtkFlagpoleLabel_ForceTranslucentOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFlagpoleLabel_GetBasePosition_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the world coordinate position of the base
	/// </summary>
	public virtual double[] GetBasePosition()
	{
		IntPtr intPtr = vtkFlagpoleLabel_GetBasePosition_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlagpoleLabel_GetBasePosition_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the world coordinate position of the base
	/// </summary>
	public virtual void GetBasePosition(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkFlagpoleLabel_GetBasePosition_06(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlagpoleLabel_GetBasePosition_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the world coordinate position of the base
	/// </summary>
	public virtual void GetBasePosition(IntPtr _arg)
	{
		vtkFlagpoleLabel_GetBasePosition_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFlagpoleLabel_GetBounds_08(HandleRef pThis);

	/// <summary>
	/// Just render in translucent pass, since it can execute multiple times
	/// (depth peeling, for instance).
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkFlagpoleLabel_GetBounds_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFlagpoleLabel_GetFlagSize_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the size of the flag. 1.0 is the default size
	/// which corresponds to a preset texels/window value. Adjust this
	/// to increase or decrease the default size.
	/// </summary>
	public virtual double GetFlagSize()
	{
		return vtkFlagpoleLabel_GetFlagSize_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFlagpoleLabel_GetForceOpaque_10(HandleRef pThis);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public override bool GetForceOpaque()
	{
		return (vtkFlagpoleLabel_GetForceOpaque_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFlagpoleLabel_GetForceTranslucent_11(HandleRef pThis);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public override bool GetForceTranslucent()
	{
		return (vtkFlagpoleLabel_GetForceTranslucent_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFlagpoleLabel_GetInput_12(HandleRef pThis);

	/// <summary>
	/// The UTF-8 encoded string to display.
	/// @{
	/// </summary>
	public virtual string GetInput()
	{
		return Marshal.PtrToStringAnsi(vtkFlagpoleLabel_GetInput_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFlagpoleLabel_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFlagpoleLabel_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFlagpoleLabel_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFlagpoleLabel_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFlagpoleLabel_GetTextProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkFlagpoleLabel_GetTextProperty_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkFlagpoleLabel_GetTopPosition_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the world coordinate position of the top
	/// </summary>
	public virtual double[] GetTopPosition()
	{
		IntPtr intPtr = vtkFlagpoleLabel_GetTopPosition_16(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlagpoleLabel_GetTopPosition_17(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the world coordinate position of the top
	/// </summary>
	public virtual void GetTopPosition(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkFlagpoleLabel_GetTopPosition_17(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlagpoleLabel_GetTopPosition_18(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the world coordinate position of the top
	/// </summary>
	public virtual void GetTopPosition(IntPtr _arg)
	{
		vtkFlagpoleLabel_GetTopPosition_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlagpoleLabel_HasTranslucentPolygonalGeometry_19(HandleRef pThis);

	/// <summary>
	/// Defers to internal actor.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkFlagpoleLabel_HasTranslucentPolygonalGeometry_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlagpoleLabel_IsA_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFlagpoleLabel_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlagpoleLabel_IsTypeOf_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFlagpoleLabel_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFlagpoleLabel_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFlagpoleLabel NewInstance()
	{
		vtkFlagpoleLabel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFlagpoleLabel_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFlagpoleLabel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlagpoleLabel_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef win);

	/// <summary>
	/// Just render in translucent pass, since it can execute multiple times
	/// (depth peeling, for instance).
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow win)
	{
		vtkFlagpoleLabel_ReleaseGraphicsResources_24(GetCppThis(), win?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlagpoleLabel_RenderOpaqueGeometry_25(HandleRef pThis, HandleRef vp);

	/// <summary>
	/// Check/update geometry/texture in opaque pass, since it only happens once.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport vp)
	{
		return vtkFlagpoleLabel_RenderOpaqueGeometry_25(GetCppThis(), vp?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFlagpoleLabel_RenderTranslucentPolygonalGeometry_26(HandleRef pThis, HandleRef vp);

	/// <summary>
	/// Just render in translucent pass, since it can execute multiple times
	/// (depth peeling, for instance).
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport vp)
	{
		return vtkFlagpoleLabel_RenderTranslucentPolygonalGeometry_26(GetCppThis(), vp?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFlagpoleLabel_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFlagpoleLabel SafeDownCast(vtkObjectBase o)
	{
		vtkFlagpoleLabel vtkFlagpoleLabel2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFlagpoleLabel_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFlagpoleLabel2 = (vtkFlagpoleLabel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFlagpoleLabel2.Register(null);
			}
		}
		return vtkFlagpoleLabel2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlagpoleLabel_SetBasePosition_28(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the world coordinate position of the base
	/// </summary>
	public void SetBasePosition(double x, double y, double z)
	{
		vtkFlagpoleLabel_SetBasePosition_28(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlagpoleLabel_SetFlagSize_29(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the size of the flag. 1.0 is the default size
	/// which corresponds to a preset texels/window value. Adjust this
	/// to increase or decrease the default size.
	/// </summary>
	public virtual void SetFlagSize(double _arg)
	{
		vtkFlagpoleLabel_SetFlagSize_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlagpoleLabel_SetForceOpaque_30(HandleRef pThis, byte opaque);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public override void SetForceOpaque(bool opaque)
	{
		vtkFlagpoleLabel_SetForceOpaque_30(GetCppThis(), (byte)(opaque ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlagpoleLabel_SetForceTranslucent_31(HandleRef pThis, byte trans);

	/// <summary>
	/// Force the actor to render during the opaque or translucent pass.
	/// @{
	/// </summary>
	public override void SetForceTranslucent(bool trans)
	{
		vtkFlagpoleLabel_SetForceTranslucent_31(GetCppThis(), (byte)(trans ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlagpoleLabel_SetInput_32(HandleRef pThis, string arg0);

	/// <summary>
	/// The UTF-8 encoded string to display.
	/// @{
	/// </summary>
	public void SetInput(string arg0)
	{
		vtkFlagpoleLabel_SetInput_32(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlagpoleLabel_SetTextProperty_33(HandleRef pThis, HandleRef tprop);

	/// <summary>
	/// The vtkTextProperty object that controls the rendered text.
	/// @{
	/// </summary>
	public void SetTextProperty(vtkTextProperty tprop)
	{
		vtkFlagpoleLabel_SetTextProperty_33(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFlagpoleLabel_SetTopPosition_34(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the world coordinate position of the top
	/// </summary>
	public void SetTopPosition(double x, double y, double z)
	{
		vtkFlagpoleLabel_SetTopPosition_34(GetCppThis(), x, y, z);
	}
}
