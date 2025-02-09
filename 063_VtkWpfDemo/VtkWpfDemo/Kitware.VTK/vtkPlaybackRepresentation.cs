using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlaybackRepresentation
/// </summary>
/// <remarks>
///    represent the vtkPlaybackWidget
///
/// This class is used to represent the vtkPlaybackWidget. Besides defining
/// geometry, this class defines a series of virtual method stubs that are
/// meant to be subclassed by applications for controlling playback.
///
/// </remarks>
/// <seealso>
///
/// vtkPlaybackWidget
/// </seealso>
public class vtkPlaybackRepresentation : vtkBorderRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlaybackRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlaybackRepresentation()
	{
		MRClassNameKey = "class vtkPlaybackRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlaybackRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlaybackRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaybackRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkPlaybackRepresentation New()
	{
		vtkPlaybackRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlaybackRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlaybackRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkPlaybackRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPlaybackRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPlaybackRepresentation_BackwardOneFrame_01(HandleRef pThis);

	/// <summary>
	/// Virtual callbacks that subclasses should implement.
	/// </summary>
	public virtual void BackwardOneFrame()
	{
		vtkPlaybackRepresentation_BackwardOneFrame_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaybackRepresentation_BuildRepresentation_02(HandleRef pThis);

	/// <summary>
	/// Satisfy the superclasses' API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkPlaybackRepresentation_BuildRepresentation_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaybackRepresentation_ForwardOneFrame_03(HandleRef pThis);

	/// <summary>
	/// Virtual callbacks that subclasses should implement.
	/// </summary>
	public virtual void ForwardOneFrame()
	{
		vtkPlaybackRepresentation_ForwardOneFrame_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaybackRepresentation_GetActors2D_04(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override void GetActors2D(vtkPropCollection arg0)
	{
		vtkPlaybackRepresentation_GetActors2D_04(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlaybackRepresentation_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlaybackRepresentation_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlaybackRepresentation_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlaybackRepresentation_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaybackRepresentation_GetProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkPlaybackRepresentation_GetProperty_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPlaybackRepresentation_GetSize_08(HandleRef pThis, IntPtr size);

	/// <summary>
	/// Satisfy the superclasses' API.
	/// </summary>
	public override void GetSize(IntPtr size)
	{
		vtkPlaybackRepresentation_GetSize_08(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaybackRepresentation_HasTranslucentPolygonalGeometry_09(HandleRef pThis);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkPlaybackRepresentation_HasTranslucentPolygonalGeometry_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaybackRepresentation_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlaybackRepresentation_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaybackRepresentation_IsTypeOf_11(string type);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlaybackRepresentation_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaybackRepresentation_JumpToBeginning_12(HandleRef pThis);

	/// <summary>
	/// Virtual callbacks that subclasses should implement.
	/// </summary>
	public virtual void JumpToBeginning()
	{
		vtkPlaybackRepresentation_JumpToBeginning_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaybackRepresentation_JumpToEnd_13(HandleRef pThis);

	/// <summary>
	/// Virtual callbacks that subclasses should implement.
	/// </summary>
	public virtual void JumpToEnd()
	{
		vtkPlaybackRepresentation_JumpToEnd_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaybackRepresentation_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public new vtkPlaybackRepresentation NewInstance()
	{
		vtkPlaybackRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlaybackRepresentation_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlaybackRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaybackRepresentation_Play_16(HandleRef pThis);

	/// <summary>
	/// Virtual callbacks that subclasses should implement.
	/// </summary>
	public virtual void Play()
	{
		vtkPlaybackRepresentation_Play_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaybackRepresentation_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkPlaybackRepresentation_ReleaseGraphicsResources_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaybackRepresentation_RenderOpaqueGeometry_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkPlaybackRepresentation_RenderOpaqueGeometry_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaybackRepresentation_RenderOverlay_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkPlaybackRepresentation_RenderOverlay_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlaybackRepresentation_RenderTranslucentPolygonalGeometry_20(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkPlaybackRepresentation_RenderTranslucentPolygonalGeometry_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlaybackRepresentation_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public new static vtkPlaybackRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkPlaybackRepresentation vtkPlaybackRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlaybackRepresentation_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlaybackRepresentation2 = (vtkPlaybackRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlaybackRepresentation2.Register(null);
			}
		}
		return vtkPlaybackRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlaybackRepresentation_Stop_22(HandleRef pThis);

	/// <summary>
	/// Virtual callbacks that subclasses should implement.
	/// </summary>
	public virtual void Stop()
	{
		vtkPlaybackRepresentation_Stop_22(GetCppThis());
	}
}
