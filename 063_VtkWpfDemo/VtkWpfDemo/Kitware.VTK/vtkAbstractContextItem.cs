using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAbstractContextItem
/// </summary>
/// <remarks>
///    base class for items that are part of a
/// vtkContextScene.
///
///
/// This class is the common base for all context scene items. You should
/// generally derive from vtkContextItem, rather than this class, as it provides
/// most of the commonly used API.
/// </remarks>
public class vtkAbstractContextItem : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractContextItem";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAbstractContextItem()
	{
		MRClassNameKey = "class vtkAbstractContextItem";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractContextItem"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAbstractContextItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern long vtkAbstractContextItem_AddItem_01(HandleRef pThis, HandleRef item);

	/// <summary>
	/// Add child items to this item. Increments reference count of item.
	/// \return the index of the child item.
	/// </summary>
	public long AddItem(vtkAbstractContextItem item)
	{
		return vtkAbstractContextItem_AddItem_01(GetCppThis(), item?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractContextItem_ClearItems_02(HandleRef pThis);

	/// <summary>
	/// Remove all child items from this item.
	/// </summary>
	public void ClearItems()
	{
		vtkAbstractContextItem_ClearItems_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractContextItem_GetInteractive_03(HandleRef pThis);

	/// <summary>
	/// Get if the item is interactive (should respond to mouse events).
	/// </summary>
	public virtual bool GetInteractive()
	{
		return (vtkAbstractContextItem_GetInteractive_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractContextItem_GetItem_04(HandleRef pThis, long index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the item at the specified index.
	/// \return the item at the specified index (null if index is invalid).
	/// </summary>
	public vtkAbstractContextItem GetItem(long index)
	{
		vtkAbstractContextItem vtkAbstractContextItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractContextItem_GetItem_04(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkAbstractContextItem_GetItemIndex_05(HandleRef pThis, HandleRef item);

	/// <summary>
	/// Get the index of the specified item in itemIndex.
	/// \return the item index if found or -1 if not.
	/// </summary>
	public long GetItemIndex(vtkAbstractContextItem item)
	{
		return vtkAbstractContextItem_GetItemIndex_05(GetCppThis(), item?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractContextItem_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAbstractContextItem_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractContextItem_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAbstractContextItem_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractContextItem_GetNumberOfItems_08(HandleRef pThis);

	/// <summary>
	/// Get the number of child items.
	/// </summary>
	public long GetNumberOfItems()
	{
		return vtkAbstractContextItem_GetNumberOfItems_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractContextItem_GetParent_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the parent item. The parent will be set for all items except top
	/// level items in a tree.
	/// </summary>
	public vtkAbstractContextItem GetParent()
	{
		vtkAbstractContextItem vtkAbstractContextItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractContextItem_GetParent_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAbstractContextItem_GetScene_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vtkContextScene for the item, always set for an item in a scene.
	/// </summary>
	public vtkContextScene GetScene()
	{
		vtkContextScene vtkContextScene2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractContextItem_GetScene_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkAbstractContextItem_GetVisible_11(HandleRef pThis);

	/// <summary>
	/// Get the visibility of the item (should it be drawn).
	/// </summary>
	public virtual bool GetVisible()
	{
		return (vtkAbstractContextItem_GetVisible_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractContextItem_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAbstractContextItem_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractContextItem_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAbstractContextItem_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractContextItem_Lower_14(HandleRef pThis, long index);

	/// <summary>
	/// Lowers the \a child to the bottom of the item's stack.
	/// \return The new index of the item
	/// \sa StackUnder(), Raise(), StackAbove()
	/// </summary>
	public long Lower(long index)
	{
		return vtkAbstractContextItem_Lower_14(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractContextItem_MapFromParent_15(HandleRef pThis, HandleRef point, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Maps the point from the parent coordinate system.
	/// </summary>
	public virtual vtkVector2f MapFromParent(vtkVector2f point)
	{
		vtkVector2f result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractContextItem_MapFromParent_15(GetCppThis(), point?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractContextItem_MapFromScene_16(HandleRef pThis, HandleRef point, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Maps the point from the scene coordinate system.
	/// </summary>
	public virtual vtkVector2f MapFromScene(vtkVector2f point)
	{
		vtkVector2f result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractContextItem_MapFromScene_16(GetCppThis(), point?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractContextItem_MapToParent_17(HandleRef pThis, HandleRef point, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Maps the point to the parent coordinate system.
	/// </summary>
	public virtual vtkVector2f MapToParent(vtkVector2f point)
	{
		vtkVector2f result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractContextItem_MapToParent_17(GetCppThis(), point?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractContextItem_MapToScene_18(HandleRef pThis, HandleRef point, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Maps the point to the scene coordinate system.
	/// </summary>
	public virtual vtkVector2f MapToScene(vtkVector2f point)
	{
		vtkVector2f result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractContextItem_MapToScene_18(GetCppThis(), point?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractContextItem_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAbstractContextItem NewInstance()
	{
		vtkAbstractContextItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractContextItem_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractContextItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractContextItem_Paint_20(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the item, called whenever the item needs to be drawn.
	/// </summary>
	public virtual bool Paint(vtkContext2D painter)
	{
		return (vtkAbstractContextItem_Paint_20(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractContextItem_PaintChildren_21(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint the children of the item, should be called whenever the children
	/// need to be rendered.
	/// </summary>
	public virtual bool PaintChildren(vtkContext2D painter)
	{
		return (vtkAbstractContextItem_PaintChildren_21(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractContextItem_Raise_22(HandleRef pThis, long index);

	/// <summary>
	/// Raises the \a child to the top of the item's stack.
	/// \return The new index of the item
	/// \sa StackAbove(), Lower(), LowerUnder()
	/// </summary>
	public long Raise(long index)
	{
		return vtkAbstractContextItem_Raise_22(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractContextItem_ReleaseGraphicsResources_23(HandleRef pThis);

	/// <summary>
	/// Release graphics resources hold by the item. The default implementation
	/// is empty.
	/// </summary>
	public virtual void ReleaseGraphicsResources()
	{
		vtkAbstractContextItem_ReleaseGraphicsResources_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractContextItem_RemoveItem_24(HandleRef pThis, HandleRef item);

	/// <summary>
	/// Remove child item from this item. Decrements reference count of item.
	/// \param item the item to be removed.
	/// \return true on success, false otherwise.
	/// </summary>
	public bool RemoveItem(vtkAbstractContextItem item)
	{
		return (vtkAbstractContextItem_RemoveItem_24(GetCppThis(), item?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractContextItem_RemoveItem_25(HandleRef pThis, long index);

	/// <summary>
	/// Remove child item from this item. Decrements reference count of item.
	/// \param index of the item to be removed.
	/// \return true on success, false otherwise.
	/// </summary>
	public bool RemoveItem(long index)
	{
		return (vtkAbstractContextItem_RemoveItem_25(GetCppThis(), index) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractContextItem_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAbstractContextItem SafeDownCast(vtkObjectBase o)
	{
		vtkAbstractContextItem vtkAbstractContextItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractContextItem_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAbstractContextItem_SetInteractive_27(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set if the item is interactive (should respond to mouse events).
	/// </summary>
	public virtual void SetInteractive(bool _arg)
	{
		vtkAbstractContextItem_SetInteractive_27(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractContextItem_SetParent_28(HandleRef pThis, HandleRef parent);

	/// <summary>
	/// Set the parent item. The parent will be set for all items except top
	/// level items in a scene.
	/// </summary>
	public virtual void SetParent(vtkAbstractContextItem parent)
	{
		vtkAbstractContextItem_SetParent_28(GetCppThis(), parent?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractContextItem_SetScene_29(HandleRef pThis, HandleRef scene);

	/// <summary>
	/// Set the vtkContextScene for the item, always set for an item in a scene.
	/// </summary>
	public virtual void SetScene(vtkContextScene scene)
	{
		vtkAbstractContextItem_SetScene_29(GetCppThis(), scene?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractContextItem_SetVisible_30(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set the visibility of the item (should it be drawn).
	/// Visible by default.
	/// </summary>
	public virtual void SetVisible(bool _arg)
	{
		vtkAbstractContextItem_SetVisible_30(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractContextItem_StackAbove_31(HandleRef pThis, long index, long under);

	/// <summary>
	/// Raises the \a child above the \a under sibling. If \a under is invalid,
	/// the item is raised to the top of the item's stack.
	/// \return The new index of the item
	/// \sa Raise(), Lower(), StackUnder()
	/// </summary>
	public virtual long StackAbove(long index, long under)
	{
		return vtkAbstractContextItem_StackAbove_31(GetCppThis(), index, under);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractContextItem_StackUnder_32(HandleRef pThis, long child, long above);

	/// <summary>
	/// Lowers the \a child under the \a above sibling. If \a above is invalid,
	/// the item is lowered to the bottom of the item's stack
	/// \return The new index of the item
	/// \sa Lower(), Raise(), StackAbove()
	/// </summary>
	public virtual long StackUnder(long child, long above)
	{
		return vtkAbstractContextItem_StackUnder_32(GetCppThis(), child, above);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractContextItem_Update_33(HandleRef pThis);

	/// <summary>
	/// Perform any updates to the item that may be necessary before rendering.
	/// The scene should take care of calling this on all items before their
	/// Paint function is invoked.
	/// </summary>
	public virtual void Update()
	{
		vtkAbstractContextItem_Update_33(GetCppThis());
	}
}
