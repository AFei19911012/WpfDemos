using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkContextScene
/// </summary>
/// <remarks>
///    Provides a 2D scene for vtkContextItem objects.
///
///
/// Provides a 2D scene that vtkContextItem objects can be added to. Manages the
/// items, ensures that they are rendered at the right times and passes on mouse
/// events.
/// </remarks>
public class vtkContextScene : vtkObject
{
	/// <summary>
	/// Enum of valid selection modes for charts in the scene
	/// </summary>
	public enum SelectionModifier
	{
		/// <summary>enum member</summary>
		SELECTION_ADDITION = 1,
		/// <summary>enum member</summary>
		SELECTION_DEFAULT = 0,
		/// <summary>enum member</summary>
		SELECTION_SUBTRACTION = 2,
		/// <summary>enum member</summary>
		SELECTION_TOGGLE = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkContextScene";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkContextScene()
	{
		MRClassNameKey = "class vtkContextScene";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextScene"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkContextScene(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextScene_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a 2D Painter object.
	/// </summary>
	public new static vtkContextScene New()
	{
		vtkContextScene result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextScene_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContextScene)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a 2D Painter object.
	/// </summary>
	public vtkContextScene()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkContextScene_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern uint vtkContextScene_AddItem_01(HandleRef pThis, HandleRef item);

	/// <summary>
	/// Add child items to this item. Increments reference count of item.
	/// \return the index of the child item.
	/// </summary>
	public uint AddItem(vtkAbstractContextItem item)
	{
		return vtkContextScene_AddItem_01(GetCppThis(), item?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextScene_ClearItems_02(HandleRef pThis);

	/// <summary>
	/// Remove all child items from this item.
	/// </summary>
	public void ClearItems()
	{
		vtkContextScene_ClearItems_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextScene_GetAnnotationLink_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vtkAnnotationLink for the chart.
	/// </summary>
	public virtual vtkAnnotationLink GetAnnotationLink()
	{
		vtkAnnotationLink vtkAnnotationLink2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextScene_GetAnnotationLink_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAnnotationLink2 = (vtkAnnotationLink)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAnnotationLink2.Register(null);
			}
		}
		return vtkAnnotationLink2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextScene_GetBufferId_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return buffer id.
	/// Not part of the end-user API. Can be used by context items to
	/// initialize their own colorbuffer id (when a context item is a container).
	/// </summary>
	public vtkAbstractContextBufferId GetBufferId()
	{
		vtkAbstractContextBufferId vtkAbstractContextBufferId2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextScene_GetBufferId_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractContextBufferId2 = (vtkAbstractContextBufferId)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractContextBufferId2.Register(null);
			}
		}
		return vtkAbstractContextBufferId2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkContextScene_GetDirty_05(HandleRef pThis);

	/// <summary>
	/// Inform the scene that something changed that requires a repaint of the
	/// scene. This should only be used by the vtkContextItem derived objects in
	/// a scene in their event handlers.
	/// </summary>
	public bool GetDirty()
	{
		return (vtkContextScene_GetDirty_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextScene_GetGeometry_06(HandleRef pThis);

	/// <summary>
	/// Get the width and height of the scene in pixels.
	/// </summary>
	public virtual int[] GetGeometry()
	{
		IntPtr intPtr = vtkContextScene_GetGeometry_06(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextScene_GetGeometry_07(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Get the width and height of the scene in pixels.
	/// </summary>
	public virtual void GetGeometry(ref int _arg1, ref int _arg2)
	{
		vtkContextScene_GetGeometry_07(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextScene_GetGeometry_08(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the width and height of the scene in pixels.
	/// </summary>
	public virtual void GetGeometry(IntPtr _arg)
	{
		vtkContextScene_GetGeometry_08(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextScene_GetItem_09(HandleRef pThis, uint index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the item at the specified index.
	/// \return the item at the specified index (null if index is invalid).
	/// </summary>
	public vtkAbstractContextItem GetItem(uint index)
	{
		vtkAbstractContextItem vtkAbstractContextItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextScene_GetItem_09(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractContextItem2 = (vtkAbstractContextItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractContextItem2.Register(null);
			}
		}
		return vtkAbstractContextItem2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextScene_GetLogicalTileScale_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The tile scale of the target vtkRenderWindow. Hardcoded pixel offsets, etc
	/// should properly account for these &lt;x, y&gt; scale factors. This will simply
	/// return vtkVector2i(1, 1) if ScaleTiles is false or if this-&gt;Renderer is
	/// NULL.
	/// </summary>
	public vtkVector2i GetLogicalTileScale()
	{
		vtkVector2i result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextScene_GetLogicalTileScale_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContextScene_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkContextScene_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContextScene_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkContextScene_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkContextScene_GetNumberOfItems_13(HandleRef pThis);

	/// <summary>
	/// Get the number of child items.
	/// </summary>
	public uint GetNumberOfItems()
	{
		return vtkContextScene_GetNumberOfItems_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContextScene_GetPickedItem_14(HandleRef pThis, int x, int y);

	/// <summary>
	/// Return the item id under mouse cursor at position (x,y).
	/// Return -1 if there is no item under the mouse cursor.
	/// \post valid_result: result&gt;=-1 &amp;&amp; result&lt;this-&gt;GetNumberOfItems()
	/// </summary>
	public long GetPickedItem(int x, int y)
	{
		return vtkContextScene_GetPickedItem_14(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextScene_GetPickedItem_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the item under the mouse.
	/// If no item is under the mouse, the method returns a null pointer.
	/// </summary>
	public vtkAbstractContextItem GetPickedItem()
	{
		vtkAbstractContextItem vtkAbstractContextItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextScene_GetPickedItem_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractContextItem2 = (vtkAbstractContextItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractContextItem2.Register(null);
			}
		}
		return vtkAbstractContextItem2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextScene_GetRenderer_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This should not be necessary as the context view should take care of
	/// rendering.
	/// </summary>
	public virtual vtkRenderer GetRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextScene_GetRenderer_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkContextScene_GetScaleTiles_17(HandleRef pThis);

	/// <summary>
	/// Whether to scale the scene transform when tiling, for example when
	/// using vtkWindowToImageFilter to take a large screenshot.
	/// The default is true.
	/// </summary>
	public virtual bool GetScaleTiles()
	{
		return (vtkContextScene_GetScaleTiles_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextScene_GetSceneHeight_18(HandleRef pThis);

	/// <summary>
	/// Get the height of the scene.
	/// </summary>
	public int GetSceneHeight()
	{
		return vtkContextScene_GetSceneHeight_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextScene_GetSceneWidth_19(HandleRef pThis);

	/// <summary>
	/// Get the width of the scene.
	/// </summary>
	public int GetSceneWidth()
	{
		return vtkContextScene_GetSceneWidth_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextScene_GetTransform_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the transform for the scene.
	/// </summary>
	public vtkTransform2D GetTransform()
	{
		vtkTransform2D vtkTransform2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextScene_GetTransform_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransform2D2 = (vtkTransform2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransform2D2.Register(null);
			}
		}
		return vtkTransform2D2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkContextScene_GetUseBufferId_21(HandleRef pThis);

	/// <summary>
	/// Get whether the scene is using the color buffer. Default is true.
	/// </summary>
	public virtual bool GetUseBufferId()
	{
		return (vtkContextScene_GetUseBufferId_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextScene_GetViewHeight_22(HandleRef pThis);

	/// <summary>
	/// Get the height of the view
	/// </summary>
	public virtual int GetViewHeight()
	{
		return vtkContextScene_GetViewHeight_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextScene_GetViewWidth_23(HandleRef pThis);

	/// <summary>
	/// Get the width of the view
	/// </summary>
	public virtual int GetViewWidth()
	{
		return vtkContextScene_GetViewWidth_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkContextScene_HasTransform_24(HandleRef pThis);

	/// <summary>
	/// Check whether the scene has a transform.
	/// </summary>
	public bool HasTransform()
	{
		return (vtkContextScene_HasTransform_24(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextScene_IsA_25(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkContextScene_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextScene_IsTypeOf_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkContextScene_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextScene_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkContextScene NewInstance()
	{
		vtkContextScene result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextScene_NewInstance_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContextScene)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkContextScene_Paint_29(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the chart, called whenever the chart needs to be drawn
	/// </summary>
	public virtual bool Paint(vtkContext2D painter)
	{
		return (vtkContextScene_Paint_29(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextScene_ReleaseGraphicsResources_30(HandleRef pThis);

	/// <summary>
	/// Release graphics resources hold by the scene.
	/// </summary>
	public void ReleaseGraphicsResources()
	{
		vtkContextScene_ReleaseGraphicsResources_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkContextScene_RemoveItem_31(HandleRef pThis, HandleRef item);

	/// <summary>
	/// Remove child item from this item. Decrements reference count of item.
	/// \param item the item to be removed.
	/// \return true on success, false otherwise.
	/// </summary>
	public bool RemoveItem(vtkAbstractContextItem item)
	{
		return (vtkContextScene_RemoveItem_31(GetCppThis(), item?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkContextScene_RemoveItem_32(HandleRef pThis, uint index);

	/// <summary>
	/// Remove child item from this item. Decrements reference count of item.
	/// \param index of the item to be removed.
	/// \return true on success, false otherwise.
	/// </summary>
	public bool RemoveItem(uint index)
	{
		return (vtkContextScene_RemoveItem_32(GetCppThis(), index) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextScene_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkContextScene SafeDownCast(vtkObjectBase o)
	{
		vtkContextScene vtkContextScene2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextScene_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContextScene2 = (vtkContextScene)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContextScene2.Register(null);
			}
		}
		return vtkContextScene2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextScene_ScaleTilesOff_34(HandleRef pThis);

	/// <summary>
	/// Whether to scale the scene transform when tiling, for example when
	/// using vtkWindowToImageFilter to take a large screenshot.
	/// The default is true.
	/// </summary>
	public virtual void ScaleTilesOff()
	{
		vtkContextScene_ScaleTilesOff_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextScene_ScaleTilesOn_35(HandleRef pThis);

	/// <summary>
	/// Whether to scale the scene transform when tiling, for example when
	/// using vtkWindowToImageFilter to take a large screenshot.
	/// The default is true.
	/// </summary>
	public virtual void ScaleTilesOn()
	{
		vtkContextScene_ScaleTilesOn_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextScene_SetAnnotationLink_36(HandleRef pThis, HandleRef link);

	/// <summary>
	/// Set the vtkAnnotationLink for the chart.
	/// </summary>
	public virtual void SetAnnotationLink(vtkAnnotationLink link)
	{
		vtkContextScene_SetAnnotationLink_36(GetCppThis(), link?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextScene_SetDirty_37(HandleRef pThis, byte isDirty);

	/// <summary>
	/// Inform the scene that something changed that requires a repaint of the
	/// scene. This should only be used by the vtkContextItem derived objects in
	/// a scene in their event handlers.
	/// </summary>
	public void SetDirty(bool isDirty)
	{
		vtkContextScene_SetDirty_37(GetCppThis(), (byte)(isDirty ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextScene_SetGeometry_38(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set the width and height of the scene in pixels.
	/// </summary>
	public virtual void SetGeometry(int _arg1, int _arg2)
	{
		vtkContextScene_SetGeometry_38(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextScene_SetGeometry_39(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the width and height of the scene in pixels.
	/// </summary>
	public void SetGeometry(IntPtr _arg)
	{
		vtkContextScene_SetGeometry_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextScene_SetRenderer_40(HandleRef pThis, HandleRef renderer);

	/// <summary>
	/// This should not be necessary as the context view should take care of
	/// rendering.
	/// </summary>
	public virtual void SetRenderer(vtkRenderer renderer)
	{
		vtkContextScene_SetRenderer_40(GetCppThis(), renderer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextScene_SetScaleTiles_41(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to scale the scene transform when tiling, for example when
	/// using vtkWindowToImageFilter to take a large screenshot.
	/// The default is true.
	/// </summary>
	public virtual void SetScaleTiles(bool _arg)
	{
		vtkContextScene_SetScaleTiles_41(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextScene_SetTransform_42(HandleRef pThis, HandleRef transform);

	/// <summary>
	/// Set the transform for the scene.
	/// </summary>
	public virtual void SetTransform(vtkTransform2D transform)
	{
		vtkContextScene_SetTransform_42(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextScene_SetUseBufferId_43(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set whether the scene should use the color buffer. Default is true.
	/// </summary>
	public virtual void SetUseBufferId(bool _arg)
	{
		vtkContextScene_SetUseBufferId_43(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
