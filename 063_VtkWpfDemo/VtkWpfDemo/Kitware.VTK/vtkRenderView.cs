using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRenderView
/// </summary>
/// <remarks>
///    A view containing a renderer.
///
///
/// vtkRenderView is a view which contains a vtkRenderer.  You may add vtkActors
/// directly to the renderer, or add certain vtkDataRepresentation subclasses
/// to the renderer.  The render view supports drag selection with the mouse to
/// select cells.
///
/// This class is also the parent class for any more specialized view which uses
/// a renderer.
/// </remarks>
public class vtkRenderView : vtkRenderViewBase
{
	/// <summary>
	/// Set the render window for this view. Note that this requires special
	/// handling in order to do correctly - see the notes in the detailed
	/// description of vtkRenderViewBase.
	/// </summary>
	public enum INTERACTION_MODE_2D_WrapperEnum
	{
		/// <summary>enum member</summary>
		INTERACTION_MODE_2D,
		/// <summary>enum member</summary>
		INTERACTION_MODE_3D,
		/// <summary>enum member</summary>
		INTERACTION_MODE_UNKNOWN
	}

	/// <summary>
	/// Whether the view should display hover text.
	/// </summary>
	public enum FRUSTUM_WrapperEnum
	{
		/// <summary>enum member</summary>
		FRUSTUM = 1,
		/// <summary>enum member</summary>
		SURFACE = 0
	}

	/// <summary>
	/// Set the display size of the icon (which may be different from the icon
	/// size). By default, if this value is not set, the IconSize is used.
	/// </summary>
	public enum ALL_WrapperEnum
	{
		/// <summary>enum member</summary>
		ALL = 1,
		/// <summary>enum member</summary>
		NO_OVERLAP = 0
	}

	/// <summary>
	/// Label placement mode.
	/// NO_OVERLAP uses vtkLabelPlacementMapper, which has a faster startup time and
	/// works with 2D or 3D labels.
	/// ALL displays all labels (Warning: This may cause incredibly slow render
	/// times on datasets with more than a few hundred labels).
	/// </summary>
	public enum FREETYPE_WrapperEnum
	{
		/// <summary>enum member</summary>
		FREETYPE,
		/// <summary>enum member</summary>
		QT
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRenderView";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRenderView()
	{
		MRClassNameKey = "class vtkRenderView";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderView"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRenderView(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRenderView New()
	{
		vtkRenderView result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRenderView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRenderView()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRenderView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_AddLabels_01(HandleRef pThis, HandleRef conn);

	/// <summary>
	/// Add labels from an input connection with an associated text
	/// property. The output must be a vtkLabelHierarchy (normally the
	/// output of vtkPointSetToLabelHierarchy).
	/// </summary>
	public virtual void AddLabels(vtkAlgorithmOutput conn)
	{
		vtkRenderView_AddLabels_01(GetCppThis(), conn?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_ApplyViewTheme_02(HandleRef pThis, HandleRef theme);

	/// <summary>
	/// Applies a view theme to this view.
	/// </summary>
	public override void ApplyViewTheme(vtkViewTheme theme)
	{
		vtkRenderView_ApplyViewTheme_02(GetCppThis(), theme?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_DisplayHoverTextOff_03(HandleRef pThis);

	/// <summary>
	/// Whether the view should display hover text.
	/// </summary>
	public virtual void DisplayHoverTextOff()
	{
		vtkRenderView_DisplayHoverTextOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_DisplayHoverTextOn_04(HandleRef pThis);

	/// <summary>
	/// Whether the view should display hover text.
	/// </summary>
	public virtual void DisplayHoverTextOn()
	{
		vtkRenderView_DisplayHoverTextOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderView_GetDisplayHoverText_05(HandleRef pThis);

	/// <summary>
	/// Whether the view should display hover text.
	/// </summary>
	public virtual bool GetDisplayHoverText()
	{
		return (vtkRenderView_GetDisplayHoverText_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderView_GetDisplaySize_06(HandleRef pThis);

	/// <summary>
	/// Set the display size of the icon (which may be different from the icon
	/// size). By default, if this value is not set, the IconSize is used.
	/// </summary>
	public IntPtr GetDisplaySize()
	{
		return vtkRenderView_GetDisplaySize_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_GetDisplaySize_07(HandleRef pThis, ref int dsx, ref int dsy);

	/// <summary>
	/// Set the display size of the icon (which may be different from the icon
	/// size). By default, if this value is not set, the IconSize is used.
	/// </summary>
	public void GetDisplaySize(ref int dsx, ref int dsy)
	{
		vtkRenderView_GetDisplaySize_07(GetCppThis(), ref dsx, ref dsy);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderView_GetIconSize_08(HandleRef pThis);

	/// <summary>
	/// Set the size of each icon in the icon texture.
	/// </summary>
	public virtual int[] GetIconSize()
	{
		IntPtr intPtr = vtkRenderView_GetIconSize_08(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_GetIconSize_09(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Set the size of each icon in the icon texture.
	/// </summary>
	public virtual void GetIconSize(ref int _arg1, ref int _arg2)
	{
		vtkRenderView_GetIconSize_09(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_GetIconSize_10(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the size of each icon in the icon texture.
	/// </summary>
	public virtual void GetIconSize(IntPtr _arg)
	{
		vtkRenderView_GetIconSize_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderView_GetIconTexture_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the icon sheet to use for rendering icons.
	/// </summary>
	public virtual vtkTexture GetIconTexture()
	{
		vtkTexture vtkTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderView_GetIconTexture_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTexture2 = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTexture2.Register(null);
			}
		}
		return vtkTexture2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderView_GetInteractionMode_12(HandleRef pThis);

	/// <summary>
	/// Set the render window for this view. Note that this requires special
	/// handling in order to do correctly - see the notes in the detailed
	/// description of vtkRenderViewBase.
	/// </summary>
	public virtual int GetInteractionMode()
	{
		return vtkRenderView_GetInteractionMode_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderView_GetInteractorStyle_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the interactor style associated with the render view.
	/// </summary>
	public virtual vtkInteractorObserver GetInteractorStyle()
	{
		vtkInteractorObserver vtkInteractorObserver2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderView_GetInteractorStyle_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorObserver2 = (vtkInteractorObserver)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorObserver2.Register(null);
			}
		}
		return vtkInteractorObserver2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderView_GetLabelPlacementMode_14(HandleRef pThis);

	/// <summary>
	/// Label placement mode.
	/// NO_OVERLAP uses vtkLabelPlacementMapper, which has a faster startup time and
	/// works with 2D or 3D labels.
	/// ALL displays all labels (Warning: This may cause incredibly slow render
	/// times on datasets with more than a few hundred labels).
	/// </summary>
	public virtual int GetLabelPlacementMode()
	{
		return vtkRenderView_GetLabelPlacementMode_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderView_GetLabelRenderMode_15(HandleRef pThis);

	/// <summary>
	/// Label render mode.
	/// FREETYPE uses the freetype label rendering.
	/// QT uses more advanced Qt-based label rendering.
	/// </summary>
	public virtual int GetLabelRenderMode()
	{
		return vtkRenderView_GetLabelRenderMode_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRenderView_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRenderView_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRenderView_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRenderView_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderView_GetRenderOnMouseMove_18(HandleRef pThis);

	/// <summary>
	/// Whether to render on every mouse move.
	/// </summary>
	public virtual bool GetRenderOnMouseMove()
	{
		return (vtkRenderView_GetRenderOnMouseMove_18(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderView_GetSelectionMode_19(HandleRef pThis);

	/// <summary>
	/// Sets the selection mode for the render view.
	/// SURFACE selection uses vtkHardwareSelector to perform a selection
	/// of visible cells.
	/// FRUSTUM selection just creates a view frustum selection, which will
	/// select everything in the frustum.
	/// </summary>
	public virtual int GetSelectionMode()
	{
		return vtkRenderView_GetSelectionMode_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderView_GetSelectionModeMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Sets the selection mode for the render view.
	/// SURFACE selection uses vtkHardwareSelector to perform a selection
	/// of visible cells.
	/// FRUSTUM selection just creates a view frustum selection, which will
	/// select everything in the frustum.
	/// </summary>
	public virtual int GetSelectionModeMaxValue()
	{
		return vtkRenderView_GetSelectionModeMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderView_GetSelectionModeMinValue_21(HandleRef pThis);

	/// <summary>
	/// Sets the selection mode for the render view.
	/// SURFACE selection uses vtkHardwareSelector to perform a selection
	/// of visible cells.
	/// FRUSTUM selection just creates a view frustum selection, which will
	/// select everything in the frustum.
	/// </summary>
	public virtual int GetSelectionModeMinValue()
	{
		return vtkRenderView_GetSelectionModeMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderView_GetTransform_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the view's transform. All vtkRenderedRepresentations
	/// added to this view should use this transform.
	/// </summary>
	public virtual vtkAbstractTransform GetTransform()
	{
		vtkAbstractTransform vtkAbstractTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderView_GetTransform_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractTransform2 = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractTransform2.Register(null);
			}
		}
		return vtkAbstractTransform2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderView_IsA_23(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRenderView_IsA_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderView_IsTypeOf_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRenderView_IsTypeOf_24(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderView_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRenderView NewInstance()
	{
		vtkRenderView result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderView_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRenderView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_RemoveLabels_27(HandleRef pThis, HandleRef conn);

	/// <summary>
	/// Remove labels from an input connection.
	/// </summary>
	public virtual void RemoveLabels(vtkAlgorithmOutput conn)
	{
		vtkRenderView_RemoveLabels_27(GetCppThis(), conn?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_Render_28(HandleRef pThis);

	/// <summary>
	/// Updates the representations, then calls Render() on the render window
	/// associated with this view.
	/// </summary>
	public override void Render()
	{
		vtkRenderView_Render_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_RenderOnMouseMoveOff_29(HandleRef pThis);

	/// <summary>
	/// Whether to render on every mouse move.
	/// </summary>
	public virtual void RenderOnMouseMoveOff()
	{
		vtkRenderView_RenderOnMouseMoveOff_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_RenderOnMouseMoveOn_30(HandleRef pThis);

	/// <summary>
	/// Whether to render on every mouse move.
	/// </summary>
	public virtual void RenderOnMouseMoveOn()
	{
		vtkRenderView_RenderOnMouseMoveOn_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderView_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRenderView SafeDownCast(vtkObjectBase o)
	{
		vtkRenderView vtkRenderView2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderView_SafeDownCast_31(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderView2 = (vtkRenderView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderView2.Register(null);
			}
		}
		return vtkRenderView2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetDisplayHoverText_32(HandleRef pThis, byte b);

	/// <summary>
	/// Whether the view should display hover text.
	/// </summary>
	public virtual void SetDisplayHoverText(bool b)
	{
		vtkRenderView_SetDisplayHoverText_32(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetDisplaySize_33(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set the display size of the icon (which may be different from the icon
	/// size). By default, if this value is not set, the IconSize is used.
	/// </summary>
	public virtual void SetDisplaySize(int _arg1, int _arg2)
	{
		vtkRenderView_SetDisplaySize_33(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetDisplaySize_34(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the display size of the icon (which may be different from the icon
	/// size). By default, if this value is not set, the IconSize is used.
	/// </summary>
	public void SetDisplaySize(IntPtr _arg)
	{
		vtkRenderView_SetDisplaySize_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetIconSize_35(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set the size of each icon in the icon texture.
	/// </summary>
	public virtual void SetIconSize(int _arg1, int _arg2)
	{
		vtkRenderView_SetIconSize_35(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetIconSize_36(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the size of each icon in the icon texture.
	/// </summary>
	public void SetIconSize(IntPtr _arg)
	{
		vtkRenderView_SetIconSize_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetIconTexture_37(HandleRef pThis, HandleRef texture);

	/// <summary>
	/// Set the icon sheet to use for rendering icons.
	/// </summary>
	public virtual void SetIconTexture(vtkTexture texture)
	{
		vtkRenderView_SetIconTexture_37(GetCppThis(), texture?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetInteractionMode_38(HandleRef pThis, int mode);

	/// <summary>
	/// Set the render window for this view. Note that this requires special
	/// handling in order to do correctly - see the notes in the detailed
	/// description of vtkRenderViewBase.
	/// </summary>
	public void SetInteractionMode(int mode)
	{
		vtkRenderView_SetInteractionMode_38(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetInteractionModeTo2D_39(HandleRef pThis);

	/// <summary>
	/// Set the interaction mode for the view. Choices are:
	/// vtkRenderView::INTERACTION_MODE_2D - 2D interactor
	/// vtkRenderView::INTERACTION_MODE_3D - 3D interactor
	/// </summary>
	public virtual void SetInteractionModeTo2D()
	{
		vtkRenderView_SetInteractionModeTo2D_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetInteractionModeTo3D_40(HandleRef pThis);

	/// <summary>
	/// Set the interaction mode for the view. Choices are:
	/// vtkRenderView::INTERACTION_MODE_2D - 2D interactor
	/// vtkRenderView::INTERACTION_MODE_3D - 3D interactor
	/// </summary>
	public virtual void SetInteractionModeTo3D()
	{
		vtkRenderView_SetInteractionModeTo3D_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetInteractor_41(HandleRef pThis, HandleRef interactor);

	/// <summary>
	/// The render window interactor. Note that this requires special
	/// handling in order to do correctly - see the notes in the detailed
	/// description of vtkRenderViewBase.
	/// </summary>
	public override void SetInteractor(vtkRenderWindowInteractor interactor)
	{
		vtkRenderView_SetInteractor_41(GetCppThis(), interactor?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetInteractorStyle_42(HandleRef pThis, HandleRef style);

	/// <summary>
	/// The interactor style associated with the render view.
	/// </summary>
	public virtual void SetInteractorStyle(vtkInteractorObserver style)
	{
		vtkRenderView_SetInteractorStyle_42(GetCppThis(), style?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetLabelPlacementMode_43(HandleRef pThis, int mode);

	/// <summary>
	/// Label placement mode.
	/// NO_OVERLAP uses vtkLabelPlacementMapper, which has a faster startup time and
	/// works with 2D or 3D labels.
	/// ALL displays all labels (Warning: This may cause incredibly slow render
	/// times on datasets with more than a few hundred labels).
	/// </summary>
	public virtual void SetLabelPlacementMode(int mode)
	{
		vtkRenderView_SetLabelPlacementMode_43(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetLabelPlacementModeToAll_44(HandleRef pThis);

	/// <summary>
	/// Label placement mode.
	/// NO_OVERLAP uses vtkLabelPlacementMapper, which has a faster startup time and
	/// works with 2D or 3D labels.
	/// ALL displays all labels (Warning: This may cause incredibly slow render
	/// times on datasets with more than a few hundred labels).
	/// </summary>
	public virtual void SetLabelPlacementModeToAll()
	{
		vtkRenderView_SetLabelPlacementModeToAll_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetLabelPlacementModeToNoOverlap_45(HandleRef pThis);

	/// <summary>
	/// Label placement mode.
	/// NO_OVERLAP uses vtkLabelPlacementMapper, which has a faster startup time and
	/// works with 2D or 3D labels.
	/// ALL displays all labels (Warning: This may cause incredibly slow render
	/// times on datasets with more than a few hundred labels).
	/// </summary>
	public virtual void SetLabelPlacementModeToNoOverlap()
	{
		vtkRenderView_SetLabelPlacementModeToNoOverlap_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetLabelRenderMode_46(HandleRef pThis, int mode);

	/// <summary>
	/// Label render mode.
	/// FREETYPE uses the freetype label rendering.
	/// QT uses more advanced Qt-based label rendering.
	/// </summary>
	public virtual void SetLabelRenderMode(int mode)
	{
		vtkRenderView_SetLabelRenderMode_46(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetLabelRenderModeToFreetype_47(HandleRef pThis);

	/// <summary>
	/// Label render mode.
	/// FREETYPE uses the freetype label rendering.
	/// QT uses more advanced Qt-based label rendering.
	/// </summary>
	public virtual void SetLabelRenderModeToFreetype()
	{
		vtkRenderView_SetLabelRenderModeToFreetype_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetLabelRenderModeToQt_48(HandleRef pThis);

	/// <summary>
	/// Label render mode.
	/// FREETYPE uses the freetype label rendering.
	/// QT uses more advanced Qt-based label rendering.
	/// </summary>
	public virtual void SetLabelRenderModeToQt()
	{
		vtkRenderView_SetLabelRenderModeToQt_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetRenderOnMouseMove_49(HandleRef pThis, byte b);

	/// <summary>
	/// Whether to render on every mouse move.
	/// </summary>
	public void SetRenderOnMouseMove(bool b)
	{
		vtkRenderView_SetRenderOnMouseMove_49(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetRenderWindow_50(HandleRef pThis, HandleRef win);

	/// <summary>
	/// Set the render window for this view. Note that this requires special
	/// handling in order to do correctly - see the notes in the detailed
	/// description of vtkRenderViewBase.
	/// </summary>
	public override void SetRenderWindow(vtkRenderWindow win)
	{
		vtkRenderView_SetRenderWindow_50(GetCppThis(), win?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetSelectionMode_51(HandleRef pThis, int _arg);

	/// <summary>
	/// Sets the selection mode for the render view.
	/// SURFACE selection uses vtkHardwareSelector to perform a selection
	/// of visible cells.
	/// FRUSTUM selection just creates a view frustum selection, which will
	/// select everything in the frustum.
	/// </summary>
	public virtual void SetSelectionMode(int _arg)
	{
		vtkRenderView_SetSelectionMode_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetSelectionModeToFrustum_52(HandleRef pThis);

	/// <summary>
	/// Sets the selection mode for the render view.
	/// SURFACE selection uses vtkHardwareSelector to perform a selection
	/// of visible cells.
	/// FRUSTUM selection just creates a view frustum selection, which will
	/// select everything in the frustum.
	/// </summary>
	public void SetSelectionModeToFrustum()
	{
		vtkRenderView_SetSelectionModeToFrustum_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetSelectionModeToSurface_53(HandleRef pThis);

	/// <summary>
	/// Sets the selection mode for the render view.
	/// SURFACE selection uses vtkHardwareSelector to perform a selection
	/// of visible cells.
	/// FRUSTUM selection just creates a view frustum selection, which will
	/// select everything in the frustum.
	/// </summary>
	public void SetSelectionModeToSurface()
	{
		vtkRenderView_SetSelectionModeToSurface_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderView_SetTransform_54(HandleRef pThis, HandleRef transform);

	/// <summary>
	/// Set the view's transform. All vtkRenderedRepresentations
	/// added to this view should use this transform.
	/// </summary>
	public virtual void SetTransform(vtkAbstractTransform transform)
	{
		vtkRenderView_SetTransform_54(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef));
	}
}
