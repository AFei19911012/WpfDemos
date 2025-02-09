using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkDataArraySelection
/// </summary>
/// <remarks>
///  Store on/off settings for data arrays, etc.
///
/// vtkDataArraySelection is intended to be used by algorithms that want to
/// expose a API that allow the user to enable/disable a collection of entities,
/// such as arrays. Readers, for example, can use vtkDataArraySelection to let
/// the user choose which array to read from the file.
///
/// Originally intended for selecting data arrays (hence the name), this class
/// can be used for letting users choose other items too, for example,
/// vtkIOSSReader uses vtkDataArraySelection to let users choose
/// which blocks to read.
///
/// Unlike most other vtkObject subclasses, vtkDataArraySelection has public API
/// that need not modify the MTime for the object. These M-Time non-modifying
/// methods are typically intended for use within the algorithm or reader to
/// populate the vtkDataArraySelection instance with available array names and
/// their default values.
/// </remarks>
public class vtkDataArraySelection : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataArraySelection";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataArraySelection()
	{
		MRClassNameKey = "class vtkDataArraySelection";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataArraySelection"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataArraySelection(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArraySelection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataArraySelection New()
	{
		vtkDataArraySelection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataArraySelection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDataArraySelection()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDataArraySelection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDataArraySelection_AddArray_01(HandleRef pThis, string name, byte state);

	/// <summary>
	/// Add to the list of arrays that have entries.  For arrays that
	/// already have entries, the settings are untouched.  For arrays
	/// that don't already have an entry, they are assumed to be enabled
	/// by default. The state can also be passed as the second argument.
	/// This method should be called only by the filter owning this
	/// object.
	///
	/// This method **does not** call `this-&gt;Modified()`.
	///
	/// Also note for arrays already known to this instance (i.e.
	/// `this-&gt;ArrayExists(name) == true`, this method has no effect.
	/// </summary>
	public int AddArray(string name, bool state)
	{
		return vtkDataArraySelection_AddArray_01(GetCppThis(), name, (byte)(state ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataArraySelection_ArrayExists_02(HandleRef pThis, string name);

	/// <summary>
	/// Return whether the array with the given name exists.
	/// </summary>
	public int ArrayExists(string name)
	{
		return vtkDataArraySelection_ArrayExists_02(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataArraySelection_ArrayIsEnabled_03(HandleRef pThis, string name);

	/// <summary>
	/// Return whether the array with the given name is enabled.  If
	/// there is no entry, the array is assumed to be disabled.
	/// </summary>
	public int ArrayIsEnabled(string name)
	{
		return vtkDataArraySelection_ArrayIsEnabled_03(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArraySelection_CopySelections_04(HandleRef pThis, HandleRef selections);

	/// <summary>
	/// Copy the selections from the given vtkDataArraySelection instance.
	///
	/// This method will call `this-&gt;Modified()` if the array selections changed.
	/// </summary>
	public void CopySelections(vtkDataArraySelection selections)
	{
		vtkDataArraySelection_CopySelections_04(GetCppThis(), selections?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArraySelection_DeepCopy_05(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Copy contents of other. The MTime for this instance is modified only if
	/// values are different.
	/// </summary>
	public void DeepCopy(vtkDataArraySelection other)
	{
		vtkDataArraySelection_DeepCopy_05(GetCppThis(), other?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArraySelection_DisableAllArrays_06(HandleRef pThis);

	/// <summary>
	/// Disable all arrays that currently have an entry.
	///
	/// This method will call `this-&gt;Modified()` if the enable state for any of the known
	/// arrays is changed.
	/// </summary>
	public void DisableAllArrays()
	{
		vtkDataArraySelection_DisableAllArrays_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArraySelection_DisableArray_07(HandleRef pThis, string name);

	/// <summary>
	/// Disable the array with the given name.  Creates a new entry if
	/// none exists.
	///
	/// This method will call `this-&gt;Modified()` if the enable state for the
	/// array changed.
	/// </summary>
	public void DisableArray(string name)
	{
		vtkDataArraySelection_DisableArray_07(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArraySelection_EnableAllArrays_08(HandleRef pThis);

	/// <summary>
	/// Enable all arrays that currently have an entry.
	///
	/// This method will call `this-&gt;Modified()` if the enable state for any of the known
	/// arrays is changed.
	/// </summary>
	public void EnableAllArrays()
	{
		vtkDataArraySelection_EnableAllArrays_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArraySelection_EnableArray_09(HandleRef pThis, string name);

	/// <summary>
	/// Enable the array with the given name.  Creates a new entry if
	/// none exists.
	///
	/// This method will call `this-&gt;Modified()` if the enable state for the
	/// array changed.
	/// </summary>
	public void EnableArray(string name)
	{
		vtkDataArraySelection_EnableArray_09(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataArraySelection_GetArrayIndex_10(HandleRef pThis, string name);

	/// <summary>
	/// Get an index of the array with the given name.
	/// </summary>
	public int GetArrayIndex(string name)
	{
		return vtkDataArraySelection_GetArrayIndex_10(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArraySelection_GetArrayName_11(HandleRef pThis, int index);

	/// <summary>
	/// Get the name of the array entry at the given index.
	/// </summary>
	public string GetArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkDataArraySelection_GetArrayName_11(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataArraySelection_GetArraySetting_12(HandleRef pThis, int index);

	/// <summary>
	/// Get whether the array at the given index is enabled.
	/// </summary>
	public int GetArraySetting(int index)
	{
		return vtkDataArraySelection_GetArraySetting_12(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataArraySelection_GetArraySetting_13(HandleRef pThis, string name);

	/// <summary>
	/// Get whether the array is enabled/disable using its name.
	/// </summary>
	public int GetArraySetting(string name)
	{
		return vtkDataArraySelection_GetArraySetting_13(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataArraySelection_GetEnabledArrayIndex_14(HandleRef pThis, string name);

	/// <summary>
	/// Get the index of an array with the given name among those
	/// that are enabled.  Returns -1 if the array is not enabled.
	/// </summary>
	public int GetEnabledArrayIndex(string name)
	{
		return vtkDataArraySelection_GetEnabledArrayIndex_14(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataArraySelection_GetNumberOfArrays_15(HandleRef pThis);

	/// <summary>
	/// Get the number of arrays that currently have an entry.
	/// </summary>
	public int GetNumberOfArrays()
	{
		return vtkDataArraySelection_GetNumberOfArrays_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataArraySelection_GetNumberOfArraysEnabled_16(HandleRef pThis);

	/// <summary>
	/// Get the number of arrays that are enabled.
	/// </summary>
	public int GetNumberOfArraysEnabled()
	{
		return vtkDataArraySelection_GetNumberOfArraysEnabled_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataArraySelection_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataArraySelection_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataArraySelection_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataArraySelection_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataArraySelection_GetUnknownArraySetting_19(HandleRef pThis);

	/// <summary>
	/// Get/Set enabled state for any unknown arrays. Default is 0 i.e. not
	/// enabled. When set to 1, `ArrayIsEnabled` will return 1 for any
	/// array not explicitly specified.
	/// </summary>
	public virtual int GetUnknownArraySetting()
	{
		return vtkDataArraySelection_GetUnknownArraySetting_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataArraySelection_IsA_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataArraySelection_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataArraySelection_IsEqual_21(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Returns true if the two array selections are equivalent.
	/// </summary>
	public bool IsEqual(vtkDataArraySelection other)
	{
		return (vtkDataArraySelection_IsEqual_21(GetCppThis(), other?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataArraySelection_IsTypeOf_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataArraySelection_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArraySelection_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDataArraySelection NewInstance()
	{
		vtkDataArraySelection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataArraySelection_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArraySelection_RemoveAllArrays_25(HandleRef pThis);

	/// <summary>
	/// Remove all array entries.
	///
	/// This method will call `this-&gt;Modified()` if the arrays were cleared.
	/// </summary>
	public void RemoveAllArrays()
	{
		vtkDataArraySelection_RemoveAllArrays_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArraySelection_RemoveArrayByIndex_26(HandleRef pThis, int index);

	/// <summary>
	/// Remove an array setting given its index.
	///
	/// This method **does not** call `this-&gt;Modified()`.
	/// </summary>
	public void RemoveArrayByIndex(int index)
	{
		vtkDataArraySelection_RemoveArrayByIndex_26(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArraySelection_RemoveArrayByName_27(HandleRef pThis, string name);

	/// <summary>
	/// Remove an array setting given its name.
	///
	/// This method **does not** call `this-&gt;Modified()`.
	/// </summary>
	public void RemoveArrayByName(string name)
	{
		vtkDataArraySelection_RemoveArrayByName_27(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArraySelection_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataArraySelection SafeDownCast(vtkObjectBase o)
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataArraySelection_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArraySelection2 = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArraySelection2.Register(null);
			}
		}
		return vtkDataArraySelection2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArraySelection_SetArraySetting_29(HandleRef pThis, string name, int setting);

	/// <summary>
	/// Set array setting given the name. If the array doesn't exist, it will be
	/// added.
	///
	/// This method will call `this-&gt;Modified()` if the enable state for the
	/// array changed.
	/// </summary>
	public void SetArraySetting(string name, int setting)
	{
		vtkDataArraySelection_SetArraySetting_29(GetCppThis(), name, setting);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArraySelection_SetUnknownArraySetting_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set enabled state for any unknown arrays. Default is 0 i.e. not
	/// enabled. When set to 1, `ArrayIsEnabled` will return 1 for any
	/// array not explicitly specified.
	/// </summary>
	public virtual void SetUnknownArraySetting(int _arg)
	{
		vtkDataArraySelection_SetUnknownArraySetting_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArraySelection_Union_31(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Update `this` to include values from `other`. For arrays that don't
	/// exist in `this` but exist in `other`, they will get added to `this` with
	/// the same array setting as in `other`. Array settings for arrays already in
	/// `this` are left unchanged.
	///
	/// This method will call `this-&gt;Modified()` if the array selections changed
	/// unless @a skipModified is set to true (default is false).
	/// </summary>
	public void Union(vtkDataArraySelection other)
	{
		vtkDataArraySelection_Union_31(GetCppThis(), other?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArraySelection_Union_32(HandleRef pThis, HandleRef other, byte skipModified);

	/// <summary>
	/// Update `this` to include values from `other`. For arrays that don't
	/// exist in `this` but exist in `other`, they will get added to `this` with
	/// the same array setting as in `other`. Array settings for arrays already in
	/// `this` are left unchanged.
	///
	/// This method will call `this-&gt;Modified()` if the array selections changed
	/// unless @a skipModified is set to true (default is false).
	/// </summary>
	public void Union(vtkDataArraySelection other, bool skipModified)
	{
		vtkDataArraySelection_Union_32(GetCppThis(), other?.GetCppThis() ?? default(HandleRef), (byte)(skipModified ? 1u : 0u));
	}
}
