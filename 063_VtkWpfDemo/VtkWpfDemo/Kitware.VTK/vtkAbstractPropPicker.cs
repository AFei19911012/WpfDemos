using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAbstractPropPicker
/// </summary>
/// <remarks>
///    abstract API for pickers that can pick an instance of vtkProp
///
/// vtkAbstractPropPicker is an abstract superclass for pickers that can pick
/// an instance of vtkProp. Some pickers, like vtkWorldPointPicker (not a
/// subclass of this class), cannot identify the prop that is
/// picked. Subclasses of vtkAbstractPropPicker return a prop in the form of a
/// vtkAssemblyPath when a pick is invoked. Note that an vtkAssemblyPath
/// contain a list of vtkAssemblyNodes, each of which in turn contains a
/// reference to a vtkProp and a 4x4 transformation matrix. The path fully
/// describes the entire pick path, so you can pick assemblies or portions of
/// assemblies, or just grab the tail end of the vtkAssemblyPath (which is the
/// picked prop).
///
/// @warning
/// Because a vtkProp can be placed into different assemblies, or even in
/// different leaf positions of the same assembly, the vtkAssemblyPath is
/// used to fully qualify exactly which use of the vtkProp was picked,
/// including its position (since vtkAssemblyPath includes a transformation
/// matrix per node).
///
/// @warning
/// The class returns information about picked actors, props, etc. Note that
/// what is returned by these methods is the top level of the assembly
/// path. This can cause a lot of confusion! For example, if you pick a
/// vtkAssembly, and the returned vtkAssemblyPath has as a leaf a vtkActor,
/// then if you invoke GetActor(), you will get NULL, even though an actor was
/// indeed picked. (GetAssembly() will return something.) Note that the safest
/// thing to do is to do a GetViewProp(), which will always return something if
/// something was picked. A better way to manage picking is to work with
/// vtkAssemblyPath, since this completely defines the pick path from top to
/// bottom in a assembly hierarchy, and avoids confusion when the same prop is
/// used in different assemblies.
///
/// @warning
/// The returned assembly paths refer to assembly nodes that in turn refer
/// to vtkProp and vtkMatrix. This association to vtkProp is not a reference
/// counted association, meaning that dangling references are possible if
/// you do a pick, get an assembly path, and then delete a vtkProp. (Reason:
/// assembly paths create many self-referencing loops that destroy reference
/// counting.)
///
/// </remarks>
/// <seealso>
///
/// vtkPropPicker vtkPicker vtkWorldPointPicker vtkCellPicker vtkPointPicker
/// vtkAssemblyPath vtkAssemblyNode vtkAssemblyPaths vtkAbstractPicker
/// vtkRenderer
/// </seealso>
public abstract class vtkAbstractPropPicker : vtkAbstractPicker
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractPropPicker";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAbstractPropPicker()
	{
		MRClassNameKey = "class vtkAbstractPropPicker";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractPropPicker"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAbstractPropPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPropPicker_GetActor_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the vtkActor that has been picked. If NULL, no actor was picked.
	/// </summary>
	public virtual vtkActor GetActor()
	{
		vtkActor vtkActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPropPicker_GetActor_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkActor2 = (vtkActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkActor2.Register(null);
			}
		}
		return vtkActor2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPropPicker_GetActor2D_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the vtkActor2D that has been picked. If NULL, no actor2D was
	/// picked.
	/// </summary>
	public virtual vtkActor2D GetActor2D()
	{
		vtkActor2D vtkActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPropPicker_GetActor2D_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAbstractPropPicker_GetAssembly_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the vtkAssembly that has been picked. If NULL, no assembly
	/// was picked. (Note: the returned assembly is the first node in the
	/// assembly path. If the path is one node long, then the assembly and
	/// the prop are the same, assuming that the first node is a vtkAssembly.)
	/// </summary>
	public virtual vtkAssembly GetAssembly()
	{
		vtkAssembly vtkAssembly2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPropPicker_GetAssembly_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAssembly2 = (vtkAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAssembly2.Register(null);
			}
		}
		return vtkAssembly2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractPropPicker_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAbstractPropPicker_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractPropPicker_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAbstractPropPicker_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPropPicker_GetPath_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the vtkAssemblyPath that has been picked. The assembly path lists
	/// all the vtkProps that form an assembly. If no assembly is present, then
	/// the assembly path will have one node (which is the picked prop). The
	/// set method is used internally to set the path. (Note: the structure of
	/// an assembly path is a collection of vtkAssemblyNode, each node pointing
	/// to a vtkProp and (possibly) a transformation matrix.)
	/// </summary>
	public virtual vtkAssemblyPath GetPath()
	{
		vtkAssemblyPath vtkAssemblyPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPropPicker_GetPath_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAssemblyPath2 = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAssemblyPath2.Register(null);
			}
		}
		return vtkAssemblyPath2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPropPicker_GetProp3D_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the vtkProp that has been picked. If NULL, no vtkProp3D was picked.
	/// </summary>
	public virtual vtkProp3D GetProp3D()
	{
		vtkProp3D vtkProp3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPropPicker_GetProp3D_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProp3D2 = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProp3D2.Register(null);
			}
		}
		return vtkProp3D2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPropPicker_GetPropAssembly_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the vtkPropAssembly that has been picked. If NULL, no prop
	/// assembly was picked. (Note: the returned prop assembly is the first node
	/// in the assembly path. If the path is one node long, then the prop
	/// assembly and the prop are the same, assuming that the first node is a
	/// vtkPropAssembly.)
	/// </summary>
	public virtual vtkPropAssembly GetPropAssembly()
	{
		vtkPropAssembly vtkPropAssembly2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPropPicker_GetPropAssembly_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPropAssembly2 = (vtkPropAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPropAssembly2.Register(null);
			}
		}
		return vtkPropAssembly2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPropPicker_GetViewProp_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the vtkProp that has been picked. If NULL, nothing was picked.
	/// If anything at all was picked, this method will return something.
	/// </summary>
	public virtual vtkProp GetViewProp()
	{
		vtkProp vtkProp2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPropPicker_GetViewProp_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProp2 = (vtkProp)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProp2.Register(null);
			}
		}
		return vtkProp2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPropPicker_GetVolume_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the vtkVolume that has been picked. If NULL, no volume was picked.
	/// </summary>
	public virtual vtkVolume GetVolume()
	{
		vtkVolume vtkVolume2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPropPicker_GetVolume_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVolume2 = (vtkVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVolume2.Register(null);
			}
		}
		return vtkVolume2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractPropPicker_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAbstractPropPicker_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractPropPicker_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAbstractPropPicker_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPropPicker_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAbstractPropPicker NewInstance()
	{
		vtkAbstractPropPicker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPropPicker_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractPropPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPropPicker_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAbstractPropPicker SafeDownCast(vtkObjectBase o)
	{
		vtkAbstractPropPicker vtkAbstractPropPicker2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPropPicker_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractPropPicker2 = (vtkAbstractPropPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractPropPicker2.Register(null);
			}
		}
		return vtkAbstractPropPicker2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPropPicker_SetPath_15(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Return the vtkAssemblyPath that has been picked. The assembly path lists
	/// all the vtkProps that form an assembly. If no assembly is present, then
	/// the assembly path will have one node (which is the picked prop). The
	/// set method is used internally to set the path. (Note: the structure of
	/// an assembly path is a collection of vtkAssemblyNode, each node pointing
	/// to a vtkProp and (possibly) a transformation matrix.)
	/// </summary>
	public virtual void SetPath(vtkAssemblyPath arg0)
	{
		vtkAbstractPropPicker_SetPath_15(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
