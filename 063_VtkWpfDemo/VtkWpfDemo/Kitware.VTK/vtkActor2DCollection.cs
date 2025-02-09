using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkActor2DCollection
/// </summary>
/// <remarks>
///     a list of 2D actors
///
/// vtkActor2DCollection is a subclass of vtkCollection.  vtkActor2DCollection
/// maintains a collection of vtkActor2D objects that is sorted by layer
/// number, with lower layer numbers at the start of the list.  This allows
/// the vtkActor2D objects to be rendered in the correct order.
///
/// </remarks>
/// <seealso>
///
/// vtkActor2D vtkCollection
/// </seealso>
public class vtkActor2DCollection : vtkPropCollection
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkActor2DCollection";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkActor2DCollection()
	{
		MRClassNameKey = "class vtkActor2DCollection";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkActor2DCollection"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkActor2DCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor2DCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Destructor for the vtkActor2DCollection class. This removes all
	/// objects from the collection.
	/// </summary>
	public new static vtkActor2DCollection New()
	{
		vtkActor2DCollection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor2DCollection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkActor2DCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Destructor for the vtkActor2DCollection class. This removes all
	/// objects from the collection.
	/// </summary>
	public vtkActor2DCollection()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkActor2DCollection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkActor2DCollection_AddItem_01(HandleRef pThis, HandleRef a);

	/// <summary>
	/// Add an actor to the list.  The new actor is inserted in the list
	/// according to it's layer number.
	/// </summary>
	public void AddItem(vtkActor2D a)
	{
		vtkActor2DCollection_AddItem_01(GetCppThis(), a?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor2DCollection_GetLastActor2D_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard Collection methods
	/// </summary>
	public vtkActor2D GetLastActor2D()
	{
		vtkActor2D vtkActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor2DCollection_GetLastActor2D_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkActor2D2 = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkActor2D2.Register(null);
			}
		}
		return vtkActor2D2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor2DCollection_GetLastItem_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Access routines that are provided for compatibility with previous
	/// version of VTK.  Please use the GetNextActor2D(), GetLastActor2D()
	/// variants where possible.
	/// </summary>
	public vtkActor2D GetLastItem()
	{
		vtkActor2D vtkActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor2DCollection_GetLastItem_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkActor2D2 = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkActor2D2.Register(null);
			}
		}
		return vtkActor2D2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor2DCollection_GetNextActor2D_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard Collection methods
	/// </summary>
	public vtkActor2D GetNextActor2D()
	{
		vtkActor2D vtkActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor2DCollection_GetNextActor2D_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkActor2D2 = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkActor2D2.Register(null);
			}
		}
		return vtkActor2D2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor2DCollection_GetNextItem_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Access routines that are provided for compatibility with previous
	/// version of VTK.  Please use the GetNextActor2D(), GetLastActor2D()
	/// variants where possible.
	/// </summary>
	public vtkActor2D GetNextItem()
	{
		vtkActor2D vtkActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor2DCollection_GetNextItem_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkActor2D2 = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkActor2D2.Register(null);
			}
		}
		return vtkActor2D2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkActor2DCollection_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Destructor for the vtkActor2DCollection class. This removes all
	/// objects from the collection.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkActor2DCollection_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkActor2DCollection_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Destructor for the vtkActor2DCollection class. This removes all
	/// objects from the collection.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkActor2DCollection_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkActor2DCollection_IsA_08(HandleRef pThis, string type);

	/// <summary>
	/// Destructor for the vtkActor2DCollection class. This removes all
	/// objects from the collection.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkActor2DCollection_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkActor2DCollection_IsItemPresent_09(HandleRef pThis, HandleRef a);

	/// <summary>
	/// Standard Collection methods
	/// </summary>
	public int IsItemPresent(vtkActor2D a)
	{
		return vtkActor2DCollection_IsItemPresent_09(GetCppThis(), a?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkActor2DCollection_IsTypeOf_10(string type);

	/// <summary>
	/// Destructor for the vtkActor2DCollection class. This removes all
	/// objects from the collection.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkActor2DCollection_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor2DCollection_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Destructor for the vtkActor2DCollection class. This removes all
	/// objects from the collection.
	/// </summary>
	public new vtkActor2DCollection NewInstance()
	{
		vtkActor2DCollection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor2DCollection_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkActor2DCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor2DCollection_RenderOverlay_13(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Sort and then render the collection of 2D actors.
	/// </summary>
	public void RenderOverlay(vtkViewport viewport)
	{
		vtkActor2DCollection_RenderOverlay_13(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor2DCollection_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Destructor for the vtkActor2DCollection class. This removes all
	/// objects from the collection.
	/// </summary>
	public new static vtkActor2DCollection SafeDownCast(vtkObjectBase o)
	{
		vtkActor2DCollection vtkActor2DCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor2DCollection_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkActor2DCollection2 = (vtkActor2DCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkActor2DCollection2.Register(null);
			}
		}
		return vtkActor2DCollection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor2DCollection_Sort_15(HandleRef pThis);

	/// <summary>
	/// Sorts the vtkActor2DCollection by layer number.  Smaller layer
	/// numbers are first.  Layer numbers can be any integer value.
	/// </summary>
	public void Sort()
	{
		vtkActor2DCollection_Sort_15(GetCppThis());
	}
}
