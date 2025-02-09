using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCollection
/// </summary>
/// <remarks>
///    create and manipulate ordered lists of objects
///
/// vtkCollection is a general object for creating and manipulating lists
/// of objects. The lists are ordered and allow duplicate entries.
/// vtkCollection also serves as a base class for lists of specific types
/// of objects.
///
/// </remarks>
/// <seealso>
///
/// vtkActorCollection vtkAssemblyPaths vtkDataSetCollection
/// vtkImplicitFunctionCollection vtkLightCollection vtkPolyDataCollection
/// vtkRenderWindowCollection vtkRendererCollection
/// vtkStructuredPointsCollection vtkTransformCollection vtkVolumeCollection
/// </seealso>
public class vtkCollection : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCollection";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCollection()
	{
		MRClassNameKey = "class vtkCollection";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCollection"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with empty list.
	/// </summary>
	public new static vtkCollection New()
	{
		vtkCollection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with empty list.
	/// </summary>
	public vtkCollection()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCollection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollection_AddItem_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add an object to the bottom of the list. Does not prevent duplicate entries.
	/// </summary>
	public void AddItem(vtkObject arg0)
	{
		vtkCollection_AddItem_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollection_GetItemAsObject_02(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the i'th item in the collection. nullptr is returned if i is out
	/// of range
	/// </summary>
	public vtkObject GetItemAsObject(int i)
	{
		vtkObject vtkObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollection_GetItemAsObject_02(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkObject2 = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkObject2.Register(null);
			}
		}
		return vtkObject2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollection_GetNextItemAsObject_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the next item in the collection. nullptr is returned if the collection
	/// is exhausted.
	/// </summary>
	public vtkObject GetNextItemAsObject()
	{
		vtkObject vtkObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollection_GetNextItemAsObject_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkObject2 = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkObject2.Register(null);
			}
		}
		return vtkObject2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCollection_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCollection_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCollection_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCollection_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollection_GetNumberOfItems_06(HandleRef pThis);

	/// <summary>
	/// Return the number of objects in the list.
	/// </summary>
	public int GetNumberOfItems()
	{
		return vtkCollection_GetNumberOfItems_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollection_InitTraversal_07(HandleRef pThis);

	/// <summary>
	/// Initialize the traversal of the collection. This means the data pointer
	/// is set at the beginning of the list.
	/// </summary>
	public void InitTraversal()
	{
		vtkCollection_InitTraversal_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollection_InsertItem_08(HandleRef pThis, int i, HandleRef arg1);

	/// <summary>
	/// Insert item into the list after the i'th item. Does not prevent duplicate entries.
	/// If i &lt; 0 the item is placed at the top of the list.
	/// </summary>
	public void InsertItem(int i, vtkObject arg1)
	{
		vtkCollection_InsertItem_08(GetCppThis(), i, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollection_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCollection_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollection_IsItemPresent_10(HandleRef pThis, HandleRef a);

	/// <summary>
	/// Search for an object and return location in list. If the return value is
	/// 0, the object was not found. If the object was found, the location is
	/// the return value-1.
	/// </summary>
	public int IsItemPresent(vtkObject a)
	{
		return vtkCollection_IsItemPresent_10(GetCppThis(), a?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollection_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCollection_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollection_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCollection NewInstance()
	{
		vtkCollection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollection_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollection_NewIterator_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get an iterator to traverse the objects in this collection.
	/// </summary>
	public vtkCollectionIterator NewIterator()
	{
		vtkCollectionIterator vtkCollectionIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollection_NewIterator_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCollectionIterator2 = (vtkCollectionIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCollectionIterator2.Register(null);
			}
		}
		return vtkCollectionIterator2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollection_RemoveAllItems_15(HandleRef pThis);

	/// <summary>
	/// Remove all objects from the list.
	/// </summary>
	public void RemoveAllItems()
	{
		vtkCollection_RemoveAllItems_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollection_RemoveItem_16(HandleRef pThis, int i);

	/// <summary>
	/// Remove the i'th item in the list.
	/// Be careful if using this function during traversal of the list using
	/// GetNextItemAsObject (or GetNextItem in derived class).  The list WILL
	/// be shortened if a valid index is given!  If this-&gt;Current is equal to the
	/// element being removed, have it point to then next element in the list.
	/// </summary>
	public void RemoveItem(int i)
	{
		vtkCollection_RemoveItem_16(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollection_RemoveItem_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Remove an object from the list. Removes the first object found, not
	/// all occurrences. If no object found, list is unaffected.  See warning
	/// in description of RemoveItem(int).
	/// </summary>
	public void RemoveItem(vtkObject arg0)
	{
		vtkCollection_RemoveItem_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollection_ReplaceItem_18(HandleRef pThis, int i, HandleRef arg1);

	/// <summary>
	/// Replace the i'th item in the collection with another item.
	/// </summary>
	public void ReplaceItem(int i, vtkObject arg1)
	{
		vtkCollection_ReplaceItem_18(GetCppThis(), i, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollection_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCollection SafeDownCast(vtkObjectBase o)
	{
		vtkCollection vtkCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollection_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCollection2 = (vtkCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCollection2.Register(null);
			}
		}
		return vtkCollection2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCollection_UsesGarbageCollector_20(HandleRef pThis);

	/// <summary>
	/// Participate in garbage collection.
	/// </summary>
	public override bool UsesGarbageCollector()
	{
		return (vtkCollection_UsesGarbageCollector_20(GetCppThis()) != 0) ? true : false;
	}
}
