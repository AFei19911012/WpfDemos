using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAppendSelection
/// </summary>
/// <remarks>
///    appends one or more selections together
///
/// vtkAppendSelection is a filter that appends one of more selections into
/// a single selection.
///
/// If AppendByUnion is true, all selections must have the same content
/// type and they are combined together to form a single vtkSelection output.
///
/// If AppendByUnion is false, the output is a composite selection with
/// input selections as the children of the composite selection. This allows
/// for selections with different content types and properties.
///
/// If AppendByUnion is true, an Expression can be defined which uses the input
/// selection names to define the relation between the selections. If the Expression
/// is not defined, all the selection are combined using the '| 'boolean operator.
///
/// @warning It should be noted that this filter is not responsible for checking if
/// the field type is the same across all selections nodes of all selections.
/// </remarks>
public class vtkAppendSelection : vtkSelectionAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAppendSelection";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAppendSelection()
	{
		MRClassNameKey = "class vtkAppendSelection";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAppendSelection"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAppendSelection(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendSelection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAppendSelection New()
	{
		vtkAppendSelection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendSelection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAppendSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAppendSelection()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAppendSelection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendSelection_AddInputData_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add a dataset to the list of data to append. Should not be
	/// used when UserManagedInputs is true, use SetInputByNumber instead.
	/// </summary>
	public void AddInputData(vtkSelection arg0)
	{
		vtkAppendSelection_AddInputData_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendSelection_AppendByUnionOff_02(HandleRef pThis);

	/// <summary>
	/// When set to true, all the selections are combined together to form a single
	/// vtkSelection output.
	/// When set to false, the output is a composite selection with
	/// input selections as the children of the composite selection. This allows
	/// for selections with different content types and properties.
	///
	/// The default is true.
	/// </summary>
	public virtual void AppendByUnionOff()
	{
		vtkAppendSelection_AppendByUnionOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendSelection_AppendByUnionOn_03(HandleRef pThis);

	/// <summary>
	/// When set to true, all the selections are combined together to form a single
	/// vtkSelection output.
	/// When set to false, the output is a composite selection with
	/// input selections as the children of the composite selection. This allows
	/// for selections with different content types and properties.
	///
	/// The default is true.
	/// </summary>
	public virtual void AppendByUnionOn()
	{
		vtkAppendSelection_AppendByUnionOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendSelection_GetAppendByUnion_04(HandleRef pThis);

	/// <summary>
	/// When set to true, all the selections are combined together to form a single
	/// vtkSelection output.
	/// When set to false, the output is a composite selection with
	/// input selections as the children of the composite selection. This allows
	/// for selections with different content types and properties.
	///
	/// The default is true.
	/// </summary>
	public virtual int GetAppendByUnion()
	{
		return vtkAppendSelection_GetAppendByUnion_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendSelection_GetExpression_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the expression that defines the boolean expression to combine the
	/// selections. Expression consists of node name identifiers, `|` for
	/// boolean-or, '^' for boolean-xor, '&amp;' for boolean and, '!' for boolean not,
	/// and parenthesis `(` and `)`. If you want to set the expression, be sure to
	/// define the node names. If no expression is specified and there are multiple
	/// selections, then the default expression simply combines all the selection nodes
	/// using an `or` operator.
	///
	/// `SetExpression` does not validate the expression. It will be validated
	/// `internally.
	///
	/// NOTE: If you want to use the expression, AppendByUnion MUST be set to false,
	/// and the input selection names MUST be defined.
	/// </summary>
	public virtual string GetExpression()
	{
		return Marshal.PtrToStringAnsi(vtkAppendSelection_GetExpression_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendSelection_GetInput_06(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get any input of this filter.
	/// </summary>
	public vtkSelection GetInput(int idx)
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendSelection_GetInput_06(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendSelection_GetInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get any input of this filter.
	/// </summary>
	public vtkSelection GetInput()
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendSelection_GetInput_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendSelection_GetInputName_08(HandleRef pThis, int index);

	/// <summary>
	/// Set/Get names for inputs selections.
	///
	/// NOTE: Input selection names are useful only if you have set the Expression, and
	/// AppendByUnion is set to false.
	/// </summary>
	public string GetInputName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkAppendSelection_GetInputName_08(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAppendSelection_GetInverse_09(HandleRef pThis);

	/// <summary>
	/// Determines whether the selection describes what to include or exclude.
	///
	/// The default is false, meaning include.
	///
	/// NOTE: If you want to use Inverse, AppendByUnion MUST be set to false.
	/// If Expression is set, then the inverse flag inverses it (internally) without modifying it.
	/// </summary>
	public virtual bool GetInverse()
	{
		return (vtkAppendSelection_GetInverse_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAppendSelection_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAppendSelection_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAppendSelection_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAppendSelection_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendSelection_GetUserManagedInputs_12(HandleRef pThis);

	/// <summary>
	/// UserManagedInputs allows the user to set inputs by number instead of
	/// using the AddInput/RemoveInput functions. Calls to
	/// SetNumberOfInputs/SetInputByNumber should not be mixed with calls
	/// to AddInput/RemoveInput.
	///
	/// The default is false.
	/// </summary>
	public virtual int GetUserManagedInputs()
	{
		return vtkAppendSelection_GetUserManagedInputs_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendSelection_InverseOff_13(HandleRef pThis);

	/// <summary>
	/// Determines whether the selection describes what to include or exclude.
	///
	/// The default is false, meaning include.
	///
	/// NOTE: If you want to use Inverse, AppendByUnion MUST be set to false.
	/// If Expression is set, then the inverse flag inverses it (internally) without modifying it.
	/// </summary>
	public virtual void InverseOff()
	{
		vtkAppendSelection_InverseOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendSelection_InverseOn_14(HandleRef pThis);

	/// <summary>
	/// Determines whether the selection describes what to include or exclude.
	///
	/// The default is false, meaning include.
	///
	/// NOTE: If you want to use Inverse, AppendByUnion MUST be set to false.
	/// If Expression is set, then the inverse flag inverses it (internally) without modifying it.
	/// </summary>
	public virtual void InverseOn()
	{
		vtkAppendSelection_InverseOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendSelection_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAppendSelection_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAppendSelection_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAppendSelection_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendSelection_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAppendSelection NewInstance()
	{
		vtkAppendSelection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendSelection_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAppendSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendSelection_RemoveAllInputNames_19(HandleRef pThis);

	/// <summary>
	/// Remove all assigned input selection names.
	/// </summary>
	public void RemoveAllInputNames()
	{
		vtkAppendSelection_RemoveAllInputNames_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendSelection_RemoveInputData_20(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Remove a dataset from the list of data to append. Should not be
	/// used when UserManagedInputs is true, use SetInputByNumber (nullptr) instead.
	/// </summary>
	public void RemoveInputData(vtkSelection arg0)
	{
		vtkAppendSelection_RemoveInputData_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAppendSelection_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAppendSelection SafeDownCast(vtkObjectBase o)
	{
		vtkAppendSelection vtkAppendSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAppendSelection_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAppendSelection2 = (vtkAppendSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAppendSelection2.Register(null);
			}
		}
		return vtkAppendSelection2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendSelection_SetAppendByUnion_22(HandleRef pThis, int _arg);

	/// <summary>
	/// When set to true, all the selections are combined together to form a single
	/// vtkSelection output.
	/// When set to false, the output is a composite selection with
	/// input selections as the children of the composite selection. This allows
	/// for selections with different content types and properties.
	///
	/// The default is true.
	/// </summary>
	public virtual void SetAppendByUnion(int _arg)
	{
		vtkAppendSelection_SetAppendByUnion_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendSelection_SetExpression_23(HandleRef pThis, string arg);

	/// <summary>
	/// Set/Get the expression that defines the boolean expression to combine the
	/// selections. Expression consists of node name identifiers, `|` for
	/// boolean-or, '^' for boolean-xor, '&amp;' for boolean and, '!' for boolean not,
	/// and parenthesis `(` and `)`. If you want to set the expression, be sure to
	/// define the node names. If no expression is specified and there are multiple
	/// selections, then the default expression simply combines all the selection nodes
	/// using an `or` operator.
	///
	/// `SetExpression` does not validate the expression. It will be validated
	/// `internally.
	///
	/// NOTE: If you want to use the expression, AppendByUnion MUST be set to false,
	/// and the input selection names MUST be defined.
	/// </summary>
	public virtual void SetExpression(string arg)
	{
		vtkAppendSelection_SetExpression_23(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendSelection_SetInputConnectionByNumber_24(HandleRef pThis, int num, HandleRef input);

	/// <summary>
	/// Directly set(allocate) number of inputs, should only be used
	/// when UserManagedInputs is true.
	/// </summary>
	public void SetInputConnectionByNumber(int num, vtkAlgorithmOutput input)
	{
		vtkAppendSelection_SetInputConnectionByNumber_24(GetCppThis(), num, input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendSelection_SetInputName_25(HandleRef pThis, int index, string name);

	/// <summary>
	/// Set/Get names for inputs selections.
	///
	/// NOTE: Input selection names are useful only if you have set the Expression, and
	/// AppendByUnion is set to false.
	/// </summary>
	public void SetInputName(int index, string name)
	{
		vtkAppendSelection_SetInputName_25(GetCppThis(), index, name);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendSelection_SetInverse_26(HandleRef pThis, byte _arg);

	/// <summary>
	/// Determines whether the selection describes what to include or exclude.
	///
	/// The default is false, meaning include.
	///
	/// NOTE: If you want to use Inverse, AppendByUnion MUST be set to false.
	/// If Expression is set, then the inverse flag inverses it (internally) without modifying it.
	/// </summary>
	public virtual void SetInverse(bool _arg)
	{
		vtkAppendSelection_SetInverse_26(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendSelection_SetNumberOfInputs_27(HandleRef pThis, int num);

	/// <summary>
	/// Directly set(allocate) number of inputs, should only be used
	/// when UserManagedInputs is true.
	/// </summary>
	public void SetNumberOfInputs(int num)
	{
		vtkAppendSelection_SetNumberOfInputs_27(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendSelection_SetUserManagedInputs_28(HandleRef pThis, int _arg);

	/// <summary>
	/// UserManagedInputs allows the user to set inputs by number instead of
	/// using the AddInput/RemoveInput functions. Calls to
	/// SetNumberOfInputs/SetInputByNumber should not be mixed with calls
	/// to AddInput/RemoveInput.
	///
	/// The default is false.
	/// </summary>
	public virtual void SetUserManagedInputs(int _arg)
	{
		vtkAppendSelection_SetUserManagedInputs_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendSelection_UserManagedInputsOff_29(HandleRef pThis);

	/// <summary>
	/// UserManagedInputs allows the user to set inputs by number instead of
	/// using the AddInput/RemoveInput functions. Calls to
	/// SetNumberOfInputs/SetInputByNumber should not be mixed with calls
	/// to AddInput/RemoveInput.
	///
	/// The default is false.
	/// </summary>
	public virtual void UserManagedInputsOff()
	{
		vtkAppendSelection_UserManagedInputsOff_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAppendSelection_UserManagedInputsOn_30(HandleRef pThis);

	/// <summary>
	/// UserManagedInputs allows the user to set inputs by number instead of
	/// using the AddInput/RemoveInput functions. Calls to
	/// SetNumberOfInputs/SetInputByNumber should not be mixed with calls
	/// to AddInput/RemoveInput.
	///
	/// The default is false.
	/// </summary>
	public virtual void UserManagedInputsOn()
	{
		vtkAppendSelection_UserManagedInputsOn_30(GetCppThis());
	}
}
