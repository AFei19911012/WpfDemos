using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkScalarBarWidget
/// </summary>
/// <remarks>
///    2D widget for manipulating a scalar bar
///
/// This class provides support for interactively manipulating the position,
/// size, and orientation of a scalar bar. It listens to Left mouse events and
/// mouse movement. It also listens to Right mouse events and notifies any
/// observers of Right mouse events on this object when they occur.
/// It will change the cursor shape based on its location. If
/// the cursor is over an edge of the scalar bar it will change the cursor
/// shape to a resize edge shape. If the position of a scalar bar is moved to
/// be close to the center of one of the four edges of the viewport, then the
/// scalar bar will change its orientation to align with that edge. This
/// orientation is sticky in that it will stay that orientation until the
/// position is moved close to another edge.
///
/// </remarks>
/// <seealso>
///
/// vtkInteractorObserver
/// </seealso>
public class vtkScalarBarWidget : vtkBorderWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkScalarBarWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkScalarBarWidget()
	{
		MRClassNameKey = "class vtkScalarBarWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkScalarBarWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkScalarBarWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkScalarBarWidget New()
	{
		vtkScalarBarWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarBarWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkScalarBarWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkScalarBarWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkScalarBarWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkScalarBarWidget_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkScalarBarWidget_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScalarBarWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkScalarBarWidget_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScalarBarWidget_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkScalarBarWidget_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarWidget_GetProcessEvents_04(HandleRef pThis);

	/// <summary>
	/// Reimplement ProcessEvents to use vtkAbstractWidget instead of vtkBorderWidget,
	/// for interaction with the scalar bar, even when the scalar bar's position is not AnyLocation.
	/// </summary>
	public override int GetProcessEvents()
	{
		return vtkScalarBarWidget_GetProcessEvents_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarWidget_GetRepositionable_05(HandleRef pThis);

	/// <summary>
	/// Can the widget be moved. On by default. If off, the widget cannot be moved
	/// around.
	///
	/// TODO: This functionality should probably be moved to the superclass.
	/// </summary>
	public virtual int GetRepositionable()
	{
		return vtkScalarBarWidget_GetRepositionable_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarWidget_GetScalarBarActor_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the ScalarBar used by this Widget. One is created automatically.
	/// </summary>
	public virtual vtkScalarBarActor GetScalarBarActor()
	{
		vtkScalarBarActor vtkScalarBarActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarBarWidget_GetScalarBarActor_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarBarActor2 = (vtkScalarBarActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarBarActor2.Register(null);
			}
		}
		return vtkScalarBarActor2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarWidget_GetScalarBarRepresentation_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the representation as a vtkScalarBarRepresentation.
	/// </summary>
	public vtkScalarBarRepresentation GetScalarBarRepresentation()
	{
		vtkScalarBarRepresentation vtkScalarBarRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarBarWidget_GetScalarBarRepresentation_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarBarRepresentation2 = (vtkScalarBarRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarBarRepresentation2.Register(null);
			}
		}
		return vtkScalarBarRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarWidget_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkScalarBarWidget_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarBarWidget_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkScalarBarWidget_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarWidget_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkScalarBarWidget NewInstance()
	{
		vtkScalarBarWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarBarWidget_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkScalarBarWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarWidget_RepositionableOff_12(HandleRef pThis);

	/// <summary>
	/// Can the widget be moved. On by default. If off, the widget cannot be moved
	/// around.
	///
	/// TODO: This functionality should probably be moved to the superclass.
	/// </summary>
	public virtual void RepositionableOff()
	{
		vtkScalarBarWidget_RepositionableOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarWidget_RepositionableOn_13(HandleRef pThis);

	/// <summary>
	/// Can the widget be moved. On by default. If off, the widget cannot be moved
	/// around.
	///
	/// TODO: This functionality should probably be moved to the superclass.
	/// </summary>
	public virtual void RepositionableOn()
	{
		vtkScalarBarWidget_RepositionableOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarBarWidget_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkScalarBarWidget SafeDownCast(vtkObjectBase o)
	{
		vtkScalarBarWidget vtkScalarBarWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarBarWidget_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarBarWidget2 = (vtkScalarBarWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarBarWidget2.Register(null);
			}
		}
		return vtkScalarBarWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarWidget_SetRepositionable_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Can the widget be moved. On by default. If off, the widget cannot be moved
	/// around.
	///
	/// TODO: This functionality should probably be moved to the superclass.
	/// </summary>
	public virtual void SetRepositionable(int _arg)
	{
		vtkScalarBarWidget_SetRepositionable_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarWidget_SetRepresentation_16(HandleRef pThis, HandleRef rep);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public virtual void SetRepresentation(vtkScalarBarRepresentation rep)
	{
		vtkScalarBarWidget_SetRepresentation_16(GetCppThis(), rep?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarBarWidget_SetScalarBarActor_17(HandleRef pThis, HandleRef actor);

	/// <summary>
	/// Get the ScalarBar used by this Widget. One is created automatically.
	/// </summary>
	public virtual void SetScalarBarActor(vtkScalarBarActor actor)
	{
		vtkScalarBarWidget_SetScalarBarActor_17(GetCppThis(), actor?.GetCppThis() ?? default(HandleRef));
	}
}
