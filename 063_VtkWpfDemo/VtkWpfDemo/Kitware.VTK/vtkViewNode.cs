using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkViewNode
/// </summary>
/// <remarks>
///    a node within a VTK scene graph
///
/// This is the superclass for all nodes within a VTK scene graph. It
/// contains the API for a node. It supports the essential operations such
/// as graph creation, state storage and traversal. Child classes adapt this
/// to VTK's major rendering classes. Grandchild classes adapt those to
/// for APIs of different rendering libraries.
/// </remarks>
public class vtkViewNode : vtkObject
{
	/// <summary>
	/// internal mechanics of graph traversal and actions
	/// </summary>
	public enum operation_type
	{
		/// <summary>enum member</summary>
		build = 1,
		/// <summary>enum member</summary>
		invalidate = 4,
		/// <summary>enum member</summary>
		noop = 0,
		/// <summary>enum member</summary>
		render = 3,
		/// <summary>enum member</summary>
		synchronize = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkViewNode";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkViewNode()
	{
		MRClassNameKey = "class vtkViewNode";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkViewNode"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkViewNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewNode_Build_01(HandleRef pThis, byte arg0);

	/// <summary>
	/// Builds myself.
	/// </summary>
	public virtual void Build(bool arg0)
	{
		vtkViewNode_Build_01(GetCppThis(), (byte)(arg0 ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewNode_GetFirstAncestorOfType_02(HandleRef pThis, string type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Find the first parent/grandparent of the desired type
	/// </summary>
	public vtkViewNode GetFirstAncestorOfType(string type)
	{
		vtkViewNode vtkViewNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewNode_GetFirstAncestorOfType_02(GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkViewNode2 = (vtkViewNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkViewNode2.Register(null);
			}
		}
		return vtkViewNode2;
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewNode_GetFirstChildOfType_03(HandleRef pThis, string type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Find the first child of the desired type
	/// </summary>
	public vtkViewNode GetFirstChildOfType(string type)
	{
		vtkViewNode vtkViewNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewNode_GetFirstChildOfType_03(GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkViewNode2 = (vtkViewNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkViewNode2.Register(null);
			}
		}
		return vtkViewNode2;
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewNode_GetMyFactory_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// A factory that creates particular subclasses for different
	/// rendering back ends.
	/// </summary>
	public virtual vtkViewNodeFactory GetMyFactory()
	{
		vtkViewNodeFactory vtkViewNodeFactory2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewNode_GetMyFactory_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkViewNodeFactory2 = (vtkViewNodeFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkViewNodeFactory2.Register(null);
			}
		}
		return vtkViewNodeFactory2;
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkViewNode_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkViewNode_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkViewNode_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkViewNode_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewNode_GetParent_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Access the node that owns this one.
	/// </summary>
	public virtual vtkViewNode GetParent()
	{
		vtkViewNode vtkViewNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewNode_GetParent_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkViewNode2 = (vtkViewNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkViewNode2.Register(null);
			}
		}
		return vtkViewNode2;
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewNode_GetRenderable_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This is the VTK class that this node stands in for.
	/// </summary>
	public virtual vtkObject GetRenderable()
	{
		vtkObject vtkObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewNode_GetRenderable_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewNode_GetViewNodeFor_09(HandleRef pThis, HandleRef arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the view node that corresponding to the provided object
	/// Will return NULL if a match is not found in self or descendents
	/// </summary>
	public vtkViewNode GetViewNodeFor(vtkObject arg0)
	{
		vtkViewNode vtkViewNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewNode_GetViewNodeFor_09(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkViewNode2 = (vtkViewNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkViewNode2.Register(null);
			}
		}
		return vtkViewNode2;
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewNode_Invalidate_10(HandleRef pThis, byte arg0);

	/// <summary>
	/// Clear any cached data.
	/// </summary>
	public virtual void Invalidate(bool arg0)
	{
		vtkViewNode_Invalidate_10(GetCppThis(), (byte)(arg0 ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkViewNode_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkViewNode_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkViewNode_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkViewNode_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewNode_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkViewNode NewInstance()
	{
		vtkViewNode result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewNode_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkViewNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewNode_Render_14(HandleRef pThis, byte arg0);

	/// <summary>
	/// Makes calls to make self visible.
	/// </summary>
	public virtual void Render(bool arg0)
	{
		vtkViewNode_Render_14(GetCppThis(), (byte)(arg0 ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewNode_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkViewNode SafeDownCast(vtkObjectBase o)
	{
		vtkViewNode vtkViewNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewNode_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkViewNode2 = (vtkViewNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkViewNode2.Register(null);
			}
		}
		return vtkViewNode2;
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewNode_SetMyFactory_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// A factory that creates particular subclasses for different
	/// rendering back ends.
	/// </summary>
	public virtual void SetMyFactory(vtkViewNodeFactory arg0)
	{
		vtkViewNode_SetMyFactory_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewNode_SetParent_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Access the node that owns this one.
	/// </summary>
	public virtual void SetParent(vtkViewNode arg0)
	{
		vtkViewNode_SetParent_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewNode_SetRenderable_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Allow explicit setting of the renderable for a
	/// view node.
	/// </summary>
	public virtual void SetRenderable(vtkObject arg0)
	{
		vtkViewNode_SetRenderable_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewNode_Synchronize_19(HandleRef pThis, byte arg0);

	/// <summary>
	/// Ensures that my state agrees with my Renderable's.
	/// </summary>
	public virtual void Synchronize(bool arg0)
	{
		vtkViewNode_Synchronize_19(GetCppThis(), (byte)(arg0 ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewNode_Traverse_20(HandleRef pThis, int operation);

	/// <summary>
	/// Allow explicit setting of the renderable for a
	/// view node.
	/// </summary>
	public virtual void Traverse(int operation)
	{
		vtkViewNode_Traverse_20(GetCppThis(), operation);
	}

	[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewNode_TraverseAllPasses_21(HandleRef pThis);

	/// <summary>
	/// Allow explicit setting of the renderable for a
	/// view node.
	/// </summary>
	public virtual void TraverseAllPasses()
	{
		vtkViewNode_TraverseAllPasses_21(GetCppThis());
	}
}
