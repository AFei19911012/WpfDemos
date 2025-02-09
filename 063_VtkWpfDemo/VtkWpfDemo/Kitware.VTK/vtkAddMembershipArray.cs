using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAddMembershipArray
/// </summary>
/// <remarks>
///    Add an array to the output indicating
/// membership within an input selection.
///
///
/// This filter takes an input selection, vtkDataSetAttribute
/// information, and data object and adds a bit array to the output
/// vtkDataSetAttributes indicating whether each index was selected or not.
/// </remarks>
public class vtkAddMembershipArray : vtkPassInputTypeAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum CELL_DATA_WrapperEnum
	{
		/// <summary>enum member</summary>
		CELL_DATA = 2,
		/// <summary>enum member</summary>
		EDGE_DATA = 4,
		/// <summary>enum member</summary>
		FIELD_DATA = 0,
		/// <summary>enum member</summary>
		POINT_DATA = 1,
		/// <summary>enum member</summary>
		ROW_DATA = 5,
		/// <summary>enum member</summary>
		VERTEX_DATA = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAddMembershipArray";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAddMembershipArray()
	{
		MRClassNameKey = "class vtkAddMembershipArray";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAddMembershipArray"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAddMembershipArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAddMembershipArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAddMembershipArray New()
	{
		vtkAddMembershipArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAddMembershipArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAddMembershipArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAddMembershipArray()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAddMembershipArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAddMembershipArray_GetFieldType_01(HandleRef pThis);

	/// <summary>
	/// The field type to add the membership array to.
	/// </summary>
	public virtual int GetFieldType()
	{
		return vtkAddMembershipArray_GetFieldType_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAddMembershipArray_GetFieldTypeMaxValue_02(HandleRef pThis);

	/// <summary>
	/// The field type to add the membership array to.
	/// </summary>
	public virtual int GetFieldTypeMaxValue()
	{
		return vtkAddMembershipArray_GetFieldTypeMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAddMembershipArray_GetFieldTypeMinValue_03(HandleRef pThis);

	/// <summary>
	/// The field type to add the membership array to.
	/// </summary>
	public virtual int GetFieldTypeMinValue()
	{
		return vtkAddMembershipArray_GetFieldTypeMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAddMembershipArray_GetInputArrayName_04(HandleRef pThis);

	/// <summary>
	/// The name of the array added to the output vtkDataSetAttributes
	/// indicating membership. Defaults to "membership".
	/// </summary>
	public virtual string GetInputArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkAddMembershipArray_GetInputArrayName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAddMembershipArray_GetInputValues_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The name of the array added to the output vtkDataSetAttributes
	/// indicating membership. Defaults to "membership".
	/// </summary>
	public virtual vtkAbstractArray GetInputValues()
	{
		vtkAbstractArray vtkAbstractArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAddMembershipArray_GetInputValues_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractArray2 = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractArray2.Register(null);
			}
		}
		return vtkAbstractArray2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAddMembershipArray_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAddMembershipArray_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAddMembershipArray_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAddMembershipArray_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAddMembershipArray_GetOutputArrayName_08(HandleRef pThis);

	/// <summary>
	/// The name of the array added to the output vtkDataSetAttributes
	/// indicating membership. Defaults to "membership".
	/// </summary>
	public virtual string GetOutputArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkAddMembershipArray_GetOutputArrayName_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAddMembershipArray_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAddMembershipArray_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAddMembershipArray_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAddMembershipArray_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAddMembershipArray_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAddMembershipArray NewInstance()
	{
		vtkAddMembershipArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAddMembershipArray_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAddMembershipArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAddMembershipArray_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAddMembershipArray SafeDownCast(vtkObjectBase o)
	{
		vtkAddMembershipArray vtkAddMembershipArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAddMembershipArray_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAddMembershipArray2 = (vtkAddMembershipArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAddMembershipArray2.Register(null);
			}
		}
		return vtkAddMembershipArray2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAddMembershipArray_SetFieldType_14(HandleRef pThis, int _arg);

	/// <summary>
	/// The field type to add the membership array to.
	/// </summary>
	public virtual void SetFieldType(int _arg)
	{
		vtkAddMembershipArray_SetFieldType_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAddMembershipArray_SetInputArrayName_15(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the array added to the output vtkDataSetAttributes
	/// indicating membership. Defaults to "membership".
	/// </summary>
	public virtual void SetInputArrayName(string _arg)
	{
		vtkAddMembershipArray_SetInputArrayName_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAddMembershipArray_SetInputValues_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// The name of the array added to the output vtkDataSetAttributes
	/// indicating membership. Defaults to "membership".
	/// </summary>
	public void SetInputValues(vtkAbstractArray arg0)
	{
		vtkAddMembershipArray_SetInputValues_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAddMembershipArray_SetOutputArrayName_17(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the array added to the output vtkDataSetAttributes
	/// indicating membership. Defaults to "membership".
	/// </summary>
	public virtual void SetOutputArrayName(string _arg)
	{
		vtkAddMembershipArray_SetOutputArrayName_17(GetCppThis(), _arg);
	}
}
