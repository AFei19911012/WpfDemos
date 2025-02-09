using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor
/// </summary>
/// <remarks>
///    Objects for traversal a HyperTreeGrid.
///
/// JB A REVOIR
/// NonOriented ne peut pas remonter plus haut qu'a sa creation.
/// Objects that can perform depth traversal of a hyper tree grid,
/// take into account more parameters (related to the grid structure) than
/// the compact hyper tree cursor implemented in vtkHyperTree can.
/// This is an abstract class.
/// Cursors are created by the HyperTreeGrid implementation.
///
/// Geometry cursors allow to retrieve origin, size, bounds
/// and central points
///
/// </remarks>
/// <seealso>
///
/// vtkHyperTreeCursor vtkHyperTree vtkHyperTreeGrid
///
/// @par Thanks:
/// This class was written by Guenole Harel and Jacques-Bernard Lekien, 2014.
/// This class was re-written by Philippe Pebay, 2016.
/// JB This class was re-written for more optimisation by Jacques-Bernard Lekien,
/// Guenole Harel and Jerome Dubois, 2018.
/// This work was supported by Commissariat a l'Energie Atomique
/// CEA, DAM, DIF, F-91297 Arpajon, France.
/// </seealso>
public class vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor()
	{
		MRClassNameKey = "class vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor New()
	{
		vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_Clone_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a copy of `this'.
	/// \post results_exists:result!=0
	/// </summary>
	public virtual vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor Clone()
	{
		vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_Clone_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor2 = (vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor2.Register(null);
			}
		}
		return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetBounds_02(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// JB
	/// </summary>
	public void GetBounds(IntPtr bounds)
	{
		vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetBounds_02(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetDimension_03(HandleRef pThis);

	/// <summary>
	/// Return the dimension of the tree.
	/// \post positive_result: result&gt;0
	/// </summary>
	public byte GetDimension()
	{
		return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetDimension_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetGlobalNodeIndex_04(HandleRef pThis);

	/// <summary>
	/// Return the global index (relative to the grid) of the
	/// current vertex in the tree.
	/// </summary>
	public long GetGlobalNodeIndex()
	{
		return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetGlobalNodeIndex_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetLastRealLevel_05(HandleRef pThis);

	/// <summary>
	/// Get the level of the tree vertex pointed by the cursor.
	/// </summary>
	public uint GetLastRealLevel()
	{
		return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetLastRealLevel_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetLevel_06(HandleRef pThis);

	/// <summary>
	/// Get the level of the tree vertex pointed by the cursor.
	/// </summary>
	public uint GetLevel()
	{
		return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetLevel_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetNumberOfChildren_07(HandleRef pThis);

	/// <summary>
	/// Return the number of children for each node (non-vertex leaf) of the tree.
	/// \post positive_number: result&gt;0
	/// </summary>
	public byte GetNumberOfChildren()
	{
		return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetNumberOfChildren_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetOrigin_10(HandleRef pThis);

	/// <summary>
	/// JB
	/// </summary>
	public IntPtr GetOrigin()
	{
		return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetOrigin_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetPoint_11(HandleRef pThis, IntPtr point);

	/// <summary>
	/// JB
	/// </summary>
	public void GetPoint(IntPtr point)
	{
		vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetPoint_11(GetCppThis(), point);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetSize_12(HandleRef pThis);

	/// <summary>
	/// JB
	/// </summary>
	public IntPtr GetSize()
	{
		return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetSize_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetTree_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the hyper tree to which the cursor is pointing.
	/// </summary>
	public vtkHyperTree GetTree()
	{
		vtkHyperTree vtkHyperTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetTree_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetVertexId_14(HandleRef pThis);

	/// <summary>
	/// Return the index of the current vertex in the tree.
	/// </summary>
	public long GetVertexId()
	{
		return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_GetVertexId_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_HasTree_15(HandleRef pThis);

	/// <summary>
	/// Return if a Tree pointing exist
	/// </summary>
	public bool HasTree()
	{
		return (vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_HasTree_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_Initialize_16(HandleRef pThis, HandleRef cursor);

	/// <summary>
	/// JB
	/// </summary>
	public void Initialize(vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor cursor)
	{
		vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_Initialize_16(GetCppThis(), cursor?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsLeaf_18(HandleRef pThis);

	/// <summary>
	/// Is the cursor pointing to a leaf?
	/// only respect depth limited, otherwise return false
	/// </summary>
	public bool IsLeaf()
	{
		return (vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsLeaf_18(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsMasked_19(HandleRef pThis);

	/// <summary>
	/// Determine whether blanking mask is empty or not
	/// </summary>
	public bool IsMasked()
	{
		return (vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsMasked_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsRealLeaf_20(HandleRef pThis);

	/// <summary>
	/// Is the cursor pointing to a leaf in the original tree ?
	/// Return false if the leaf is virtual.
	/// </summary>
	public bool IsRealLeaf()
	{
		return (vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsRealLeaf_20(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsRoot_21(HandleRef pThis);

	/// <summary>
	/// Is the cursor at tree root?
	/// </summary>
	public bool IsRoot()
	{
		return (vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsRoot_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsTypeOf_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsVirtualLeaf_23(HandleRef pThis);

	/// <summary>
	/// Is the cursor pointing to a subdivided leaf ?
	/// Return false if the leaf is a real one.
	/// </summary>
	public bool IsVirtualLeaf()
	{
		return (vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_IsVirtualLeaf_23(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor NewInstance()
	{
		vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor SafeDownCast(vtkObjectBase o)
	{
		vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor2 = (vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor2.Register(null);
			}
		}
		return vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_SetGlobalIndexFromLocal_27(HandleRef pThis, long index);

	/// <summary>
	/// JB
	/// </summary>
	public void SetGlobalIndexFromLocal(long index)
	{
		vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_SetGlobalIndexFromLocal_27(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_SetGlobalIndexStart_28(HandleRef pThis, long index);

	/// <summary>
	/// JB
	/// </summary>
	public void SetGlobalIndexStart(long index)
	{
		vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_SetGlobalIndexStart_28(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_SetMask_29(HandleRef pThis, byte state);

	/// <summary>
	/// Set the blanking mask is empty or not
	/// \pre not_tree: tree
	/// </summary>
	public void SetMask(bool state)
	{
		vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_SetMask_29(GetCppThis(), (byte)(state ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_ToChild_30(HandleRef pThis, byte ichild);

	/// <summary>
	/// Move the cursor to child `child' of the current vertex.
	/// \pre not_tree: HasTree()
	/// \pre not_leaf: !IsLeaf()
	/// \pre valid_child: ichild&gt;=0 &amp;&amp; ichild&lt;GetNumberOfChildren()
	/// \pre depth_limiter: GetLevel() &lt;= GetDepthLimiter()
	/// </summary>
	public void ToChild(byte ichild)
	{
		vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_ToChild_30(GetCppThis(), ichild);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_ToParent_31(HandleRef pThis);

	/// <summary>
	/// Move the cursor to the parent of the current vertex.
	/// Authorized if HasHistory return true.
	/// \pre Non_root: !IsRoot()
	/// </summary>
	public void ToParent()
	{
		vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_ToParent_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_ToRoot_32(HandleRef pThis);

	/// <summary>
	/// Move the cursor to the root vertex.
	/// \pre can be root
	/// \post is_root: IsRoot()
	/// </summary>
	public void ToRoot()
	{
		vtkHyperTreeGridNonOrientedUnlimitedGeometryCursor_ToRoot_32(GetCppThis());
	}
}
/// <summary>
///    vtkHyperTreeGridNonOrientedUnlimitedSuperCursor
/// </summary>
/// <remarks>
///    Objects for traversal a HyperTreeGrid.
///
/// </remarks>
/// <seealso>
///
/// vtkHyperTreeGridNonOrientedSuperCursor vtkHyperTreeCursor vtkHyperTree vtkHyperTreeGrid
/// </seealso>
public abstract class vtkHyperTreeGridNonOrientedUnlimitedSuperCursor : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHyperTreeGridNonOrientedUnlimitedSuperCursor()
	{
		MRClassNameKey = "class vtkHyperTreeGridNonOrientedUnlimitedSuperCursor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperTreeGridNonOrientedUnlimitedSuperCursor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHyperTreeGridNonOrientedUnlimitedSuperCursor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_Clone_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a copy of `this'.
	/// \post results_exists:result!=0
	/// </summary>
	public virtual vtkHyperTreeGridNonOrientedUnlimitedSuperCursor Clone()
	{
		vtkHyperTreeGridNonOrientedUnlimitedSuperCursor vtkHyperTreeGridNonOrientedUnlimitedSuperCursor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_Clone_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHyperTreeGridNonOrientedUnlimitedSuperCursor2 = (vtkHyperTreeGridNonOrientedUnlimitedSuperCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHyperTreeGridNonOrientedUnlimitedSuperCursor2.Register(null);
			}
		}
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetBounds_02(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// JB Coordonnees de la boite englobante
	/// </summary>
	public void GetBounds(IntPtr bounds)
	{
		vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetBounds_02(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetBounds_03(HandleRef pThis, uint icursor, IntPtr bounds);

	/// <summary>
	/// JB Coordonnees de la boite englobante
	/// </summary>
	public void GetBounds(uint icursor, IntPtr bounds)
	{
		vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetBounds_03(GetCppThis(), icursor, bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetDimension_04(HandleRef pThis);

	/// <summary>
	/// Return the dimension of the tree.
	/// \post positive_result: result&gt;0
	/// </summary>
	public byte GetDimension()
	{
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetDimension_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetExtensivePropertyRatio_05(HandleRef pThis);

	/// <summary>
	/// returns the value of the ratio to be applied to extensive
	/// value for the current cursor, related to the last real
	/// value of the cell. Return 1 for real cells, otherwise
	/// return the portion of the area covered by the subdivieded cell.
	/// For intensive valued fields this ratio should not be used.
	/// </summary>
	public double GetExtensivePropertyRatio()
	{
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetExtensivePropertyRatio_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetExtensivePropertyRatio_06(HandleRef pThis, long index);

	/// <summary>
	/// returns the value of the ratio to be applied to extensive
	/// value for the current cursor, related to the last real
	/// value of the cell. Return 1 for real cells, otherwise
	/// return the portion of the area covered by the subdivieded cell.
	/// For intensive valued fields this ratio should not be used.
	/// </summary>
	public double GetExtensivePropertyRatio(long index)
	{
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetExtensivePropertyRatio_06(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetGlobalNodeIndex_07(HandleRef pThis);

	/// <summary>
	/// Return the global index (relative to the grid) of the
	/// current vertex in the tree.
	/// </summary>
	public long GetGlobalNodeIndex()
	{
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetGlobalNodeIndex_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetGlobalNodeIndex_08(HandleRef pThis, uint icursor);

	/// <summary>
	/// JB Return the global index (relative to the grid) of the
	/// neighboor icursor current vertex in the tree.
	/// </summary>
	public long GetGlobalNodeIndex(uint icursor)
	{
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetGlobalNodeIndex_08(GetCppThis(), icursor);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetInformation_09(HandleRef pThis, uint icursor, ref uint level, ref byte leaf, ref long id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// JB
	/// </summary>
	public vtkHyperTree GetInformation(uint icursor, ref uint level, ref byte leaf, ref long id)
	{
		vtkHyperTree vtkHyperTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetInformation_09(GetCppThis(), icursor, ref level, ref leaf, ref id, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern uint vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetLastRealLevel_10(HandleRef pThis);

	/// <summary>
	/// Get the level of the tree vertex pointed by the cursor.
	/// </summary>
	public uint GetLastRealLevel()
	{
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetLastRealLevel_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetLastRealLevel_11(HandleRef pThis, uint icursor);

	/// <summary>
	/// Get the level of the tree vertex pointed by the cursor.
	/// </summary>
	public uint GetLastRealLevel(uint icursor)
	{
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetLastRealLevel_11(GetCppThis(), icursor);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetLevel_12(HandleRef pThis);

	/// <summary>
	/// Get the level of the tree vertex pointed by the cursor.
	/// </summary>
	public uint GetLevel()
	{
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetLevel_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetLevel_13(HandleRef pThis, uint icursor);

	/// <summary>
	/// Get the level of the tree vertex pointed by the cursor.
	/// </summary>
	public uint GetLevel(uint icursor)
	{
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetLevel_13(GetCppThis(), icursor);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetNumberOfChildren_14(HandleRef pThis);

	/// <summary>
	/// Return the number of children for each node (non-vertex leaf) of the tree.
	/// \post positive_number: result&gt;0
	/// </summary>
	public byte GetNumberOfChildren()
	{
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetNumberOfChildren_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetNumberOfCursors_15(HandleRef pThis);

	/// <summary>
	/// JB
	/// </summary>
	public uint GetNumberOfCursors()
	{
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetNumberOfCursors_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetOrigin_18(HandleRef pThis);

	/// <summary>
	/// JB
	/// </summary>
	public IntPtr GetOrigin()
	{
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetOrigin_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetPoint_19(HandleRef pThis, IntPtr point);

	/// <summary>
	/// JB Coordonnees du centre de la maille
	/// </summary>
	public void GetPoint(IntPtr point)
	{
		vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetPoint_19(GetCppThis(), point);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetPoint_20(HandleRef pThis, uint icursor, IntPtr point);

	/// <summary>
	/// JB Coordonnees du centre de la maille
	/// </summary>
	public void GetPoint(uint icursor, IntPtr point)
	{
		vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetPoint_20(GetCppThis(), icursor, point);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetSize_21(HandleRef pThis);

	/// <summary>
	/// JB
	/// </summary>
	public IntPtr GetSize()
	{
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetSize_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetTree_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the hyper tree to which the cursor is pointing.
	/// </summary>
	public vtkHyperTree GetTree()
	{
		vtkHyperTree vtkHyperTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetTree_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetTree_23(HandleRef pThis, uint icursor, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the hyper tree to which the cursor is pointing.
	/// </summary>
	public vtkHyperTree GetTree(uint icursor)
	{
		vtkHyperTree vtkHyperTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetTree_23(GetCppThis(), icursor, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetVertexId_24(HandleRef pThis);

	/// <summary>
	/// Return the index of the current vertex in the tree.
	/// </summary>
	public long GetVertexId()
	{
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetVertexId_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetVertexId_25(HandleRef pThis, uint icursor);

	/// <summary>
	/// Return the index of the current vertex in the tree.
	/// </summary>
	public long GetVertexId(uint icursor)
	{
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_GetVertexId_25(GetCppThis(), icursor);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_HasTree_26(HandleRef pThis);

	/// <summary>
	/// Return if a Tree pointing exist
	/// </summary>
	public bool HasTree()
	{
		return (vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_HasTree_26(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_HasTree_27(HandleRef pThis, uint icursor);

	/// <summary>
	/// JB Return if a Tree pointing exist
	/// </summary>
	public bool HasTree(uint icursor)
	{
		return (vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_HasTree_27(GetCppThis(), icursor) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsA_28(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsA_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsLeaf_29(HandleRef pThis);

	/// <summary>
	/// Is the cursor pointing to a leaf?
	/// </summary>
	public bool IsLeaf()
	{
		return (vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsLeaf_29(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsLeaf_30(HandleRef pThis, uint icursor);

	/// <summary>
	/// Is the cursor pointing to a leaf?
	/// </summary>
	public bool IsLeaf(uint icursor)
	{
		return (vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsLeaf_30(GetCppThis(), icursor) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsMasked_31(HandleRef pThis);

	/// <summary>
	/// Determine whether blanking mask is empty or not
	/// </summary>
	public bool IsMasked()
	{
		return (vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsMasked_31(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsMasked_32(HandleRef pThis, uint icursor);

	/// <summary>
	/// Determine whether blanking mask is empty or not
	/// </summary>
	public bool IsMasked(uint icursor)
	{
		return (vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsMasked_32(GetCppThis(), icursor) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsRealLeaf_33(HandleRef pThis);

	/// <summary>
	/// Is the cursor pointing to a leaf?
	/// </summary>
	public bool IsRealLeaf()
	{
		return (vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsRealLeaf_33(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsRealLeaf_34(HandleRef pThis, uint icursor);

	/// <summary>
	/// Is the cursor pointing to a leaf?
	/// </summary>
	public bool IsRealLeaf(uint icursor)
	{
		return (vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsRealLeaf_34(GetCppThis(), icursor) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsRoot_35(HandleRef pThis);

	/// <summary>
	/// Is the cursor at tree root?
	/// </summary>
	public bool IsRoot()
	{
		return (vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsRoot_35(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsTypeOf_36(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsTypeOf_36(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsVirtualLeaf_37(HandleRef pThis);

	/// <summary>
	/// Is the cursor pointing to a real node in the tree
	/// </summary>
	public bool IsVirtualLeaf()
	{
		return (vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsVirtualLeaf_37(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsVirtualLeaf_38(HandleRef pThis, uint icursor);

	/// <summary>
	/// Is the cursor pointing to a real node in the tree
	/// </summary>
	public bool IsVirtualLeaf(uint icursor)
	{
		return (vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_IsVirtualLeaf_38(GetCppThis(), icursor) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHyperTreeGridNonOrientedUnlimitedSuperCursor NewInstance()
	{
		vtkHyperTreeGridNonOrientedUnlimitedSuperCursor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_NewInstance_39(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHyperTreeGridNonOrientedUnlimitedSuperCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_SafeDownCast_40(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHyperTreeGridNonOrientedUnlimitedSuperCursor SafeDownCast(vtkObjectBase o)
	{
		vtkHyperTreeGridNonOrientedUnlimitedSuperCursor vtkHyperTreeGridNonOrientedUnlimitedSuperCursor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_SafeDownCast_40(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHyperTreeGridNonOrientedUnlimitedSuperCursor2 = (vtkHyperTreeGridNonOrientedUnlimitedSuperCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHyperTreeGridNonOrientedUnlimitedSuperCursor2.Register(null);
			}
		}
		return vtkHyperTreeGridNonOrientedUnlimitedSuperCursor2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_SetGlobalIndexFromLocal_41(HandleRef pThis, long index);

	/// <summary>
	/// JB
	/// </summary>
	public void SetGlobalIndexFromLocal(long index)
	{
		vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_SetGlobalIndexFromLocal_41(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_SetGlobalIndexStart_42(HandleRef pThis, long index);

	/// <summary>
	/// JB
	/// </summary>
	public void SetGlobalIndexStart(long index)
	{
		vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_SetGlobalIndexStart_42(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_SetMask_43(HandleRef pThis, byte state);

	/// <summary>
	/// Set the blanking mask is empty or not
	/// \pre not_tree: tree
	/// </summary>
	public void SetMask(bool state)
	{
		vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_SetMask_43(GetCppThis(), (byte)(state ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_SetMask_44(HandleRef pThis, uint icursor, byte state);

	/// <summary>
	/// Set the blanking mask is empty or not
	/// \pre not_tree: tree
	/// </summary>
	public void SetMask(uint icursor, bool state)
	{
		vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_SetMask_44(GetCppThis(), icursor, (byte)(state ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_ToChild_45(HandleRef pThis, byte ichild);

	/// <summary>
	/// Move the cursor to child `child' of the current vertex.
	/// \pre not_tree: HasTree()
	/// \pre not_leaf: !IsLeaf()
	/// \pre valid_child: ichild&gt;=0 &amp;&amp; ichild&lt;GetNumberOfChildren()
	/// \pre depth_limiter: GetLevel() &lt;= GetDepthLimiter()
	/// </summary>
	public void ToChild(byte ichild)
	{
		vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_ToChild_45(GetCppThis(), ichild);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_ToParent_46(HandleRef pThis);

	/// <summary>
	/// Move the cursor to the parent of the current vertex.
	/// Authorized if HasHistory return true.
	/// \pre Non_root: !IsRoot()
	/// </summary>
	public void ToParent()
	{
		vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_ToParent_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_ToRoot_47(HandleRef pThis);

	/// <summary>
	/// Move the cursor to the root vertex.
	/// \pre can be root
	/// \post is_root: IsRoot()
	/// </summary>
	public void ToRoot()
	{
		vtkHyperTreeGridNonOrientedUnlimitedSuperCursor_ToRoot_47(GetCppThis());
	}
}
/// <summary>
///    vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor
/// </summary>
/// <remarks>
///    Specific Moore super cursor that can subdivied neighboorhood
///
/// This supercursor behave like the Moore supercursor but relies on the
/// vtkHyperTreeGridNonOrientedUnlimitedSuperCursor so the neighboorhood
/// can be refined to reach the level of the current cell in any case.
///
/// </remarks>
/// <seealso>
///
/// vtkHyperTreeCursor vtkHyperTree vtkHyperTreeGrid vtkHyperTreeGridNonOrientedMooreSuperCursor
/// </seealso>
public class vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor : vtkHyperTreeGridNonOrientedUnlimitedSuperCursor
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor()
	{
		MRClassNameKey = "class vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor New()
	{
		vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_GetCornerCursors_01(HandleRef pThis, uint arg0, uint arg1, HandleRef arg2);

	/// <summary>
	/// Return the list of cursors pointing to the leaves touching a
	/// given corner of the cell.
	/// Return whether the considered cell is the owner of said corner.
	/// JB Utilise aujourd'hui dans les filtres vtkHyperTreeGridContour et vtkHyperTreeGridPlaneCutter.
	/// </summary>
	public bool GetCornerCursors(uint arg0, uint arg1, vtkIdList arg2)
	{
		return (vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_GetCornerCursors_01(GetCppThis(), arg0, arg1, arg2?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor NewInstance()
	{
		vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor SafeDownCast(vtkObjectBase o)
	{
		vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor2 = (vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor2.Register(null);
			}
		}
		return vtkHyperTreeGridNonOrientedUnlimitedMooreSuperCursor2;
	}
}
