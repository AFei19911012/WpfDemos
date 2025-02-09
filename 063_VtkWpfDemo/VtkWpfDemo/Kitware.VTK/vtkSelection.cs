using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkSelection
/// </summary>
/// <remarks>
///  data object that represents a "selection" in VTK.
///
/// vtkSelection defines a selection. A selection is a data-object that defines
/// which entities from another data-object are to treated as "selected". Filters like
/// `vtkExtractSelection` or `vtkExtractDataArraysOverTime` can then be used to
/// extract these selected entities from the *other* data-object.
///
/// vtkSelection comprises of `vtkSelectionNode`s and optionally, an expression
/// specified using `vtkSelection::SetExpression`. If non-empty, the expression
/// is a boolean expression that defines now the selection nodes present in the
/// selection are to be combined together to form the selection. If no expression
/// is specified and there are multiple selection nodes, then the default
/// expression simply combines all the selection nodes using an `or` operator.
///
/// Each vtkSelectionNode is used to define the selection criteria.
/// vtkSelectionNode API lets one select what kind of entities are being selected
/// (vtkSelectionNode::FieldType) and how they are being selected
/// (vtkSelectionNode::ContentType).
///
/// </remarks>
/// <seealso>
///
/// vtkSelectionNode
/// </seealso>
public class vtkSelection : vtkDataObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSelection";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSelection()
	{
		MRClassNameKey = "class vtkSelection";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSelection"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSelection(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSelection New()
	{
		vtkSelection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSelection()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSelection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern string vtkSelection_AddNode_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Adds a selection node. Assigns the node a unique name and returns that
	/// name. This API is primarily provided for backwards compatibility and
	/// `SetNode` is the preferred method.
	/// </summary>
	public virtual string AddNode(vtkSelectionNode arg0)
	{
		return vtkSelection_AddNode_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelection_DeepCopy_02(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Copy selection nodes of the input.
	/// </summary>
	public override void DeepCopy(vtkDataObject src)
	{
		vtkSelection_DeepCopy_02(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelection_Dump_03(HandleRef pThis);

	/// <summary>
	/// Dumps the contents of the selection, giving basic information only.
	/// </summary>
	public virtual void Dump()
	{
		vtkSelection_Dump_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelection_GetData_04(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve a vtkSelection stored inside an invormation object.
	/// </summary>
	public new static vtkSelection GetData(vtkInformation info)
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelection_GetData_04(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelection2 = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelection2.Register(null);
			}
		}
		return vtkSelection2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelection_GetData_05(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve a vtkSelection stored inside an invormation object.
	/// </summary>
	public new static vtkSelection GetData(vtkInformationVector v, int i)
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelection_GetData_05(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelection2 = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelection2.Register(null);
			}
		}
		return vtkSelection2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelection_GetDataObjectType_06(HandleRef pThis);

	/// <summary>
	/// Returns VTK_SELECTION enumeration value.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkSelection_GetDataObjectType_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkSelection_GetExpression_07(HandleRef pThis);

	/// <summary>
	/// Get/Set the expression that defines the boolean expression to combine the
	/// selection nodes. Expression consists of node name identifiers, `|` for
	/// boolean-or, '^' for boolean-xor, '&amp;' for boolean and, '!' for boolean not,
	/// and parenthesis `(` and `)`. If the expression consists of a node name identifier
	/// that is not assigned any `vtkSelectionNode` (using `SetNode`) then it is evaluates
	/// to `false`.
	///
	/// `SetExpression` does not validate the expression. It will be validated in
	/// `Evaluate` call.
	/// </summary>
	public virtual string GetExpression()
	{
		return vtkSelection_GetExpression_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkSelection_GetMTime_08(HandleRef pThis);

	/// <summary>
	/// Return the MTime taking into account changes to the properties
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkSelection_GetMTime_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelection_GetNode_09(HandleRef pThis, uint idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns a node given it's index. Performs bound checking
	/// and will return nullptr if out-of-bounds.
	/// </summary>
	public virtual vtkSelectionNode GetNode(uint idx)
	{
		vtkSelectionNode vtkSelectionNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelection_GetNode_09(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelectionNode2 = (vtkSelectionNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelectionNode2.Register(null);
			}
		}
		return vtkSelectionNode2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelection_GetNode_10(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns a node with the given name, if present, else nullptr is returned.
	/// </summary>
	public virtual vtkSelectionNode GetNode(string name)
	{
		vtkSelectionNode vtkSelectionNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelection_GetNode_10(GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelectionNode2 = (vtkSelectionNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelectionNode2.Register(null);
			}
		}
		return vtkSelectionNode2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkSelection_GetNodeNameAtIndex_11(HandleRef pThis, uint idx);

	/// <summary>
	/// Returns the name for a node at the given index.
	/// </summary>
	public virtual string GetNodeNameAtIndex(uint idx)
	{
		return vtkSelection_GetNodeNameAtIndex_11(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSelection_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSelection_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSelection_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSelection_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkSelection_GetNumberOfNodes_14(HandleRef pThis);

	/// <summary>
	/// Returns the number of nodes in this selection.
	/// Each node contains information about part of the selection.
	/// </summary>
	public uint GetNumberOfNodes()
	{
		return vtkSelection_GetNumberOfNodes_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelection_Initialize_15(HandleRef pThis);

	/// <summary>
	/// Restore data object to initial state,
	/// </summary>
	public override void Initialize()
	{
		vtkSelection_Initialize_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelection_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSelection_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSelection_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSelection_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelection_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSelection NewInstance()
	{
		vtkSelection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelection_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelection_RemoveAllNodes_20(HandleRef pThis);

	/// <summary>
	/// Removes all selection nodes.
	/// </summary>
	public virtual void RemoveAllNodes()
	{
		vtkSelection_RemoveAllNodes_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelection_RemoveNode_21(HandleRef pThis, uint idx);

	/// <summary>
	/// Removes a selection node.
	/// </summary>
	public virtual void RemoveNode(uint idx)
	{
		vtkSelection_RemoveNode_21(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelection_RemoveNode_22(HandleRef pThis, string name);

	/// <summary>
	/// Removes a selection node.
	/// </summary>
	public virtual void RemoveNode(string name)
	{
		vtkSelection_RemoveNode_22(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelection_RemoveNode_23(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Removes a selection node.
	/// </summary>
	public virtual void RemoveNode(vtkSelectionNode arg0)
	{
		vtkSelection_RemoveNode_23(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSelection_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSelection SafeDownCast(vtkObjectBase o)
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSelection_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelection2 = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelection2.Register(null);
			}
		}
		return vtkSelection2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelection_SetExpression_25(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the expression that defines the boolean expression to combine the
	/// selection nodes. Expression consists of node name identifiers, `|` for
	/// boolean-or, '^' for boolean-xor, '&amp;' for boolean and, '!' for boolean not,
	/// and parenthesis `(` and `)`. If the expression consists of a node name identifier
	/// that is not assigned any `vtkSelectionNode` (using `SetNode`) then it is evaluates
	/// to `false`.
	///
	/// `SetExpression` does not validate the expression. It will be validated in
	/// `Evaluate` call.
	/// </summary>
	public virtual void SetExpression(string _arg)
	{
		vtkSelection_SetExpression_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelection_SetNode_26(HandleRef pThis, string name, HandleRef arg1);

	/// <summary>
	/// Adds a vtkSelectionNode and assigns it the specified name. The name
	/// must be a non-empty string. If an item with the same name
	/// has already been added, it will be removed.
	/// </summary>
	public virtual void SetNode(string name, vtkSelectionNode arg1)
	{
		vtkSelection_SetNode_26(GetCppThis(), name, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelection_ShallowCopy_27(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Copy selection nodes of the input.
	/// This is a shallow copy: selection lists and pointers in the
	/// properties are passed by reference.
	/// </summary>
	public override void ShallowCopy(vtkDataObject src)
	{
		vtkSelection_ShallowCopy_27(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelection_Subtract_28(HandleRef pThis, HandleRef selection);

	/// <summary>
	/// Remove the nodes from the specified selection from this selection.
	/// Assumes that selection node internal arrays are vtkIdTypeArrays.
	/// </summary>
	public virtual void Subtract(vtkSelection selection)
	{
		vtkSelection_Subtract_28(GetCppThis(), selection?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelection_Subtract_29(HandleRef pThis, HandleRef node);

	/// <summary>
	/// Remove the nodes from the specified selection from this selection.
	/// Assumes that selection node internal arrays are vtkIdTypeArrays.
	/// </summary>
	public virtual void Subtract(vtkSelectionNode node)
	{
		vtkSelection_Subtract_29(GetCppThis(), node?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelection_Union_30(HandleRef pThis, HandleRef selection);

	/// <summary>
	/// Union this selection with the specified selection.
	/// Attempts to reuse selection nodes in this selection if properties
	/// match exactly. Otherwise, creates new selection nodes.
	/// </summary>
	public virtual void Union(vtkSelection selection)
	{
		vtkSelection_Union_30(GetCppThis(), selection?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSelection_Union_31(HandleRef pThis, HandleRef node);

	/// <summary>
	/// Union this selection with the specified selection node.
	/// Attempts to reuse a selection node in this selection if properties
	/// match exactly. Otherwise, creates a new selection node.
	/// </summary>
	public virtual void Union(vtkSelectionNode node)
	{
		vtkSelection_Union_31(GetCppThis(), node?.GetCppThis() ?? default(HandleRef));
	}
}
