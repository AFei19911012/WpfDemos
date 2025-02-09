using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMagnifierRepresentation
/// </summary>
/// <remarks>
///    represent a vtkBorderWidget
///
/// This class is used to represent and render a vtkMagnifierWidget.  To use
/// this class, you need to specify a renderer in which to place the
/// magnifier, and a magnification factor. Optionally, you can specify the
/// size of the magnifier window, whether it has a border, and the particular
/// actors to render.
///
/// </remarks>
/// <seealso>
///
/// vtkMagnifierWidget
/// </seealso>
public class vtkMagnifierRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Define the various states that the representation can be in.
	/// </summary>
	public enum InteractionStateType
	{
		/// <summary>enum member</summary>
		Invisible,
		/// <summary>enum member</summary>
		Visible
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMagnifierRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMagnifierRepresentation()
	{
		MRClassNameKey = "class vtkMagnifierRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMagnifierRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMagnifierRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMagnifierRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkMagnifierRepresentation New()
	{
		vtkMagnifierRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMagnifierRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMagnifierRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkMagnifierRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMagnifierRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkMagnifierRepresentation_AddViewProp_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Optionally specify and maintain the list of view props (e.g., actors,
	/// volumes, etc).  By default, if nothing is specified, then the view props
	/// from the associated renderer are used. Note, by using view props
	/// different than that of the associated renderer, it is possible to create
	/// special effects and/or remove props from what is shown in the magnifier.
	/// </summary>
	public void AddViewProp(vtkProp arg0)
	{
		vtkMagnifierRepresentation_AddViewProp_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMagnifierRepresentation_BorderOff_02(HandleRef pThis);

	/// <summary>
	/// Optionally specify whether a border should be drawn on the outer edge of
	/// the magnifier viewport. By default this is off.
	/// </summary>
	public virtual void BorderOff()
	{
		vtkMagnifierRepresentation_BorderOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMagnifierRepresentation_BorderOn_03(HandleRef pThis);

	/// <summary>
	/// Optionally specify whether a border should be drawn on the outer edge of
	/// the magnifier viewport. By default this is off.
	/// </summary>
	public virtual void BorderOn()
	{
		vtkMagnifierRepresentation_BorderOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMagnifierRepresentation_BuildRepresentation_04(HandleRef pThis);

	/// <summary>
	/// Subclasses should implement these methods. See the superclasses'
	/// documentation for more information.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkMagnifierRepresentation_BuildRepresentation_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMagnifierRepresentation_GetBorder_05(HandleRef pThis);

	/// <summary>
	/// Optionally specify whether a border should be drawn on the outer edge of
	/// the magnifier viewport. By default this is off.
	/// </summary>
	public virtual bool GetBorder()
	{
		return (vtkMagnifierRepresentation_GetBorder_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMagnifierRepresentation_GetBorderProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the properties of the border.
	/// </summary>
	public virtual vtkProperty2D GetBorderProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMagnifierRepresentation_GetBorderProperty_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkMagnifierRepresentation_GetInteractionStateMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Specify the interaction state of the widget. This is generally performed
	/// by the associated vtkMagnifierWidget. (It is necessary for the widget
	/// to specify the interaction state in order to remove the internal
	/// magnification renderer from the render window).
	/// </summary>
	public virtual int GetInteractionStateMaxValue()
	{
		return vtkMagnifierRepresentation_GetInteractionStateMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMagnifierRepresentation_GetInteractionStateMinValue_08(HandleRef pThis);

	/// <summary>
	/// Specify the interaction state of the widget. This is generally performed
	/// by the associated vtkMagnifierWidget. (It is necessary for the widget
	/// to specify the interaction state in order to remove the internal
	/// magnification renderer from the render window).
	/// </summary>
	public virtual int GetInteractionStateMinValue()
	{
		return vtkMagnifierRepresentation_GetInteractionStateMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkMagnifierRepresentation_GetMTime_09(HandleRef pThis);

	/// <summary>
	/// Return the MTime of this object. It takes into account MTimes
	/// of the border's property.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkMagnifierRepresentation_GetMTime_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMagnifierRepresentation_GetMagnificationFactor_10(HandleRef pThis);

	/// <summary>
	/// Methods to control the magnification factor. The magnification factor
	/// is relative to the associated renderer's camera. The bump method
	/// enables small increments of magnification to be applied. If the bump
	/// is positive, it increases the magnification; if negative it decreases
	/// the magnification.
	/// </summary>
	public virtual double GetMagnificationFactor()
	{
		return vtkMagnifierRepresentation_GetMagnificationFactor_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMagnifierRepresentation_GetMagnificationFactorMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Methods to control the magnification factor. The magnification factor
	/// is relative to the associated renderer's camera. The bump method
	/// enables small increments of magnification to be applied. If the bump
	/// is positive, it increases the magnification; if negative it decreases
	/// the magnification.
	/// </summary>
	public virtual double GetMagnificationFactorMaxValue()
	{
		return vtkMagnifierRepresentation_GetMagnificationFactorMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMagnifierRepresentation_GetMagnificationFactorMinValue_12(HandleRef pThis);

	/// <summary>
	/// Methods to control the magnification factor. The magnification factor
	/// is relative to the associated renderer's camera. The bump method
	/// enables small increments of magnification to be applied. If the bump
	/// is positive, it increases the magnification; if negative it decreases
	/// the magnification.
	/// </summary>
	public virtual double GetMagnificationFactorMinValue()
	{
		return vtkMagnifierRepresentation_GetMagnificationFactorMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMagnifierRepresentation_GetMagnificationRenderer_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Provide access to the magnification renderer. This is so
	/// properties like background color can be set.
	/// </summary>
	public vtkRenderer GetMagnificationRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMagnifierRepresentation_GetMagnificationRenderer_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderer2 = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderer2.Register(null);
			}
		}
		return vtkRenderer2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMagnifierRepresentation_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	/// Define standard methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMagnifierRepresentation_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMagnifierRepresentation_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	/// Define standard methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMagnifierRepresentation_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMagnifierRepresentation_GetSize_16(HandleRef pThis);

	/// <summary>
	/// Specify the size of the magnifier viewport in pixels.
	/// </summary>
	public virtual int[] GetSize()
	{
		IntPtr intPtr = vtkMagnifierRepresentation_GetSize_16(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMagnifierRepresentation_GetSize_17(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Specify the size of the magnifier viewport in pixels.
	/// </summary>
	public virtual void GetSize(ref int _arg1, ref int _arg2)
	{
		vtkMagnifierRepresentation_GetSize_17(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMagnifierRepresentation_GetSize_18(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the size of the magnifier viewport in pixels.
	/// </summary>
	public virtual void GetSize(IntPtr _arg)
	{
		vtkMagnifierRepresentation_GetSize_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMagnifierRepresentation_GetViewProps_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Optionally specify and maintain the list of view props (e.g., actors,
	/// volumes, etc).  By default, if nothing is specified, then the view props
	/// from the associated renderer are used. Note, by using view props
	/// different than that of the associated renderer, it is possible to create
	/// special effects and/or remove props from what is shown in the magnifier.
	/// </summary>
	public vtkPropCollection GetViewProps()
	{
		vtkPropCollection vtkPropCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMagnifierRepresentation_GetViewProps_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPropCollection2 = (vtkPropCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPropCollection2.Register(null);
			}
		}
		return vtkPropCollection2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMagnifierRepresentation_HasTranslucentPolygonalGeometry_20(HandleRef pThis);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkMagnifierRepresentation_HasTranslucentPolygonalGeometry_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMagnifierRepresentation_HasViewProp_21(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Optionally specify and maintain the list of view props (e.g., actors,
	/// volumes, etc).  By default, if nothing is specified, then the view props
	/// from the associated renderer are used. Note, by using view props
	/// different than that of the associated renderer, it is possible to create
	/// special effects and/or remove props from what is shown in the magnifier.
	/// </summary>
	public int HasViewProp(vtkProp arg0)
	{
		return vtkMagnifierRepresentation_HasViewProp_21(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMagnifierRepresentation_IsA_22(HandleRef pThis, string type);

	/// <summary>
	/// Define standard methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMagnifierRepresentation_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMagnifierRepresentation_IsTypeOf_23(string type);

	/// <summary>
	/// Define standard methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMagnifierRepresentation_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMagnifierRepresentation_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Define standard methods.
	/// </summary>
	public new vtkMagnifierRepresentation NewInstance()
	{
		vtkMagnifierRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMagnifierRepresentation_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMagnifierRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMagnifierRepresentation_ReleaseGraphicsResources_26(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkMagnifierRepresentation_ReleaseGraphicsResources_26(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMagnifierRepresentation_RemoveAllViewProps_27(HandleRef pThis);

	/// <summary>
	/// Optionally specify and maintain the list of view props (e.g., actors,
	/// volumes, etc).  By default, if nothing is specified, then the view props
	/// from the associated renderer are used. Note, by using view props
	/// different than that of the associated renderer, it is possible to create
	/// special effects and/or remove props from what is shown in the magnifier.
	/// </summary>
	public void RemoveAllViewProps()
	{
		vtkMagnifierRepresentation_RemoveAllViewProps_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMagnifierRepresentation_RemoveViewProp_28(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Optionally specify and maintain the list of view props (e.g., actors,
	/// volumes, etc).  By default, if nothing is specified, then the view props
	/// from the associated renderer are used. Note, by using view props
	/// different than that of the associated renderer, it is possible to create
	/// special effects and/or remove props from what is shown in the magnifier.
	/// </summary>
	public void RemoveViewProp(vtkProp arg0)
	{
		vtkMagnifierRepresentation_RemoveViewProp_28(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMagnifierRepresentation_RenderOpaqueGeometry_29(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkMagnifierRepresentation_RenderOpaqueGeometry_29(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMagnifierRepresentation_RenderOverlay_30(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkMagnifierRepresentation_RenderOverlay_30(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMagnifierRepresentation_RenderTranslucentPolygonalGeometry_31(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkMagnifierRepresentation_RenderTranslucentPolygonalGeometry_31(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMagnifierRepresentation_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Define standard methods.
	/// </summary>
	public new static vtkMagnifierRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkMagnifierRepresentation vtkMagnifierRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMagnifierRepresentation_SafeDownCast_32(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMagnifierRepresentation2 = (vtkMagnifierRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMagnifierRepresentation2.Register(null);
			}
		}
		return vtkMagnifierRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMagnifierRepresentation_SetBorder_33(HandleRef pThis, byte _arg);

	/// <summary>
	/// Optionally specify whether a border should be drawn on the outer edge of
	/// the magnifier viewport. By default this is off.
	/// </summary>
	public virtual void SetBorder(bool _arg)
	{
		vtkMagnifierRepresentation_SetBorder_33(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMagnifierRepresentation_SetInteractionState_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the interaction state of the widget. This is generally performed
	/// by the associated vtkMagnifierWidget. (It is necessary for the widget
	/// to specify the interaction state in order to remove the internal
	/// magnification renderer from the render window).
	/// </summary>
	public virtual void SetInteractionState(int _arg)
	{
		vtkMagnifierRepresentation_SetInteractionState_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMagnifierRepresentation_SetMagnificationFactor_35(HandleRef pThis, double _arg);

	/// <summary>
	/// Methods to control the magnification factor. The magnification factor
	/// is relative to the associated renderer's camera. The bump method
	/// enables small increments of magnification to be applied. If the bump
	/// is positive, it increases the magnification; if negative it decreases
	/// the magnification.
	/// </summary>
	public virtual void SetMagnificationFactor(double _arg)
	{
		vtkMagnifierRepresentation_SetMagnificationFactor_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMagnifierRepresentation_SetRenderer_36(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Specify the renderer viewport in which to place the magnifier.
	/// </summary>
	public override void SetRenderer(vtkRenderer ren)
	{
		vtkMagnifierRepresentation_SetRenderer_36(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMagnifierRepresentation_SetSize_37(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Specify the size of the magnifier viewport in pixels.
	/// </summary>
	public virtual void SetSize(int _arg1, int _arg2)
	{
		vtkMagnifierRepresentation_SetSize_37(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMagnifierRepresentation_SetSize_38(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the size of the magnifier viewport in pixels.
	/// </summary>
	public void SetSize(IntPtr _arg)
	{
		vtkMagnifierRepresentation_SetSize_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMagnifierRepresentation_WidgetInteraction_39(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Subclasses should implement these methods. See the superclasses'
	/// documentation for more information.
	/// </summary>
	public override void WidgetInteraction(IntPtr eventPos)
	{
		vtkMagnifierRepresentation_WidgetInteraction_39(GetCppThis(), eventPos);
	}
}
