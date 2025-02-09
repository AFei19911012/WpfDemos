using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHyperTreeCursor
/// </summary>
/// <remarks>
///    Objects for depth-first traversal HyperTrees.
///
///
/// Objects that can perform depth-first traversal of HyperTrees.
/// This is an abstract class.
/// Cursors are created by the HyperTree implementation.
///
/// </remarks>
/// <seealso>
///
/// vtkObject vtkHyperTree vtkHyperTreeGrid
///
/// @par Thanks:
/// This class was written by Philippe Pebay, Joachim Pouderoux, and Charles Law, Kitware 2013
/// This class was modified by Guenole Harel and Jacques-Bernard Lekien 2014
/// This class was revised by Philippe Pebay, 2016
/// This work was supported by Commissariat a l'Energie Atomique (CEA/DIF)
/// </seealso>
public abstract class vtkHyperTreeCursor : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHyperTreeCursor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHyperTreeCursor()
	{
		MRClassNameKey = "class vtkHyperTreeCursor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperTreeCursor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHyperTreeCursor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeCursor_Clone_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a copy of `this'.
	/// \post results_exists:result!=0
	/// \post same_tree: result-&gt;SameTree(this)
	/// </summary>
	public virtual vtkHyperTreeCursor Clone()
	{
		vtkHyperTreeCursor vtkHyperTreeCursor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeCursor_Clone_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHyperTreeCursor2 = (vtkHyperTreeCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHyperTreeCursor2.Register(null);
			}
		}
		return vtkHyperTreeCursor2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeCursor_GetChildIndex_02(HandleRef pThis);

	/// <summary>
	/// Return the child number of the current vertex relative to its parent.
	/// \pre not_root: !IsRoot().
	/// \post valid_range: result&gt;=0 &amp;&amp; result&lt;GetNumberOfChildren()
	/// </summary>
	public virtual int GetChildIndex()
	{
		return vtkHyperTreeCursor_GetChildIndex_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeCursor_GetDimension_03(HandleRef pThis);

	/// <summary>
	/// Return the dimension of the tree.
	/// \post positive_result: result&gt;0
	/// </summary>
	public virtual int GetDimension()
	{
		return vtkHyperTreeCursor_GetDimension_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkHyperTreeCursor_GetLevel_04(HandleRef pThis);

	/// <summary>
	/// Return the level of the vertex pointed by the cursor.
	/// \post positive_result: result&gt;=0
	/// </summary>
	public virtual uint GetLevel()
	{
		return vtkHyperTreeCursor_GetLevel_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeCursor_GetNumberOfChildren_05(HandleRef pThis);

	/// <summary>
	/// Return the number of children for each node (non-vertex leaf) of the tree.
	/// \post positive_number: result&gt;0
	/// </summary>
	public virtual int GetNumberOfChildren()
	{
		return vtkHyperTreeCursor_GetNumberOfChildren_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTreeCursor_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHyperTreeCursor_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTreeCursor_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHyperTreeCursor_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeCursor_GetTree_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the HyperTree to which the cursor is pointing.
	/// </summary>
	public virtual vtkHyperTree GetTree()
	{
		vtkHyperTree vtkHyperTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeCursor_GetTree_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHyperTree2 = (vtkHyperTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHyperTree2.Register(null);
			}
		}
		return vtkHyperTree2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTreeCursor_GetVertexId_09(HandleRef pThis);

	/// <summary>
	/// Return the index of the current vertex in the tree.
	/// </summary>
	public virtual long GetVertexId()
	{
		return vtkHyperTreeCursor_GetVertexId_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeCursor_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHyperTreeCursor_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeCursor_IsEqual_11(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Is `this' equal to `other'?
	/// \pre other_exists: other!=0
	/// \pre same_hypertree: this-&gt;SameTree(other);
	/// </summary>
	public virtual bool IsEqual(vtkHyperTreeCursor other)
	{
		return (vtkHyperTreeCursor_IsEqual_11(GetCppThis(), other?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeCursor_IsLeaf_12(HandleRef pThis);

	/// <summary>
	/// Is the cursor pointing to a leaf?
	/// </summary>
	public virtual bool IsLeaf()
	{
		return (vtkHyperTreeCursor_IsLeaf_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeCursor_IsRoot_13(HandleRef pThis);

	/// <summary>
	/// Is the cursor at tree root?
	/// </summary>
	public virtual bool IsRoot()
	{
		return (vtkHyperTreeCursor_IsRoot_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeCursor_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHyperTreeCursor_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeCursor_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHyperTreeCursor NewInstance()
	{
		vtkHyperTreeCursor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeCursor_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHyperTreeCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeCursor_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHyperTreeCursor SafeDownCast(vtkObjectBase o)
	{
		vtkHyperTreeCursor vtkHyperTreeCursor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeCursor_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHyperTreeCursor2 = (vtkHyperTreeCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHyperTreeCursor2.Register(null);
			}
		}
		return vtkHyperTreeCursor2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeCursor_SameTree_17(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Are `this' and `other' pointing on the same hypertree?
	/// \pre other_exists: other!=0
	/// </summary>
	public virtual int SameTree(vtkHyperTreeCursor other)
	{
		return vtkHyperTreeCursor_SameTree_17(GetCppThis(), other?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeCursor_SetTree_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the HyperTree to which the cursor is pointing.
	/// </summary>
	public virtual void SetTree(vtkHyperTree arg0)
	{
		vtkHyperTreeCursor_SetTree_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeCursor_ToChild_19(HandleRef pThis, int child);

	/// <summary>
	/// Move the cursor to child `child' of the current vertex.
	/// \pre not_leaf: !IsLeaf()
	/// \pre valid_child: child&gt;=0 &amp;&amp; child&lt;this-&gt;GetNumberOfChildren()
	/// </summary>
	public virtual void ToChild(int child)
	{
		vtkHyperTreeCursor_ToChild_19(GetCppThis(), child);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeCursor_ToParent_20(HandleRef pThis);

	/// <summary>
	/// Move the cursor to the parent of the current vertex.
	/// \pre not_root: !IsRoot()
	/// </summary>
	public virtual void ToParent()
	{
		vtkHyperTreeCursor_ToParent_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeCursor_ToRoot_21(HandleRef pThis);

	/// <summary>
	/// Move the cursor to the root vertex.
	/// \pre can be root
	/// \post is_root: IsRoot()
	/// </summary>
	public virtual void ToRoot()
	{
		vtkHyperTreeCursor_ToRoot_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeCursor_ToSameVertex_22(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Move the cursor to the same vertex pointed by `other'.
	/// \pre other_exists: other!=0
	/// \pre same_hypertree: this-&gt;SameTree(other);
	/// \post equal: this-&gt;IsEqual(other)
	/// </summary>
	public virtual void ToSameVertex(vtkHyperTreeCursor other)
	{
		vtkHyperTreeCursor_ToSameVertex_22(GetCppThis(), other?.GetCppThis() ?? default(HandleRef));
	}
}
