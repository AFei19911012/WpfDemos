using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenerateIndexArray
///
///
/// Generates a new vtkIdTypeArray containing zero-base indices.
///
/// vtkGenerateIndexArray operates in one of two distinct "modes".
/// By default, it simply generates an index array containing
/// monotonically-increasing integers in the range [0, N), where N
/// is appropriately sized for the field type that will store the
/// results.  This mode is useful for generating a unique ID field
/// for datasets that have none.
///
/// The second "mode" uses an existing array from the input data
/// object as a "reference".  Distinct values from the reference
/// array are sorted in ascending order, and an integer index in
/// the range [0, N) is assigned to each.  The resulting map is
/// used to populate the output index array, mapping each value
/// in the reference array to its corresponding index and storing
/// the result in the output array.  This mode is especially
/// useful when generating tensors, since it allows us to "map"
/// from an array with arbitrary contents to an index that can
/// be used as tensor coordinates.
/// </summary>
public class vtkGenerateIndexArray : vtkDataObjectAlgorithm
{
	/// <summary>
	/// Specifies whether the index array should be marked as
	/// pedigree ids.  Default: false.
	/// </summary>
	public enum CELL_DATA_WrapperEnum
	{
		/// <summary>enum member</summary>
		CELL_DATA = 2,
		/// <summary>enum member</summary>
		EDGE_DATA = 4,
		/// <summary>enum member</summary>
		POINT_DATA = 1,
		/// <summary>enum member</summary>
		ROW_DATA = 0,
		/// <summary>enum member</summary>
		VERTEX_DATA = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenerateIndexArray";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenerateIndexArray()
	{
		MRClassNameKey = "class vtkGenerateIndexArray";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenerateIndexArray"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenerateIndexArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenerateIndexArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenerateIndexArray New()
	{
		vtkGenerateIndexArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenerateIndexArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenerateIndexArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGenerateIndexArray()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGenerateIndexArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkGenerateIndexArray_GetArrayName_01(HandleRef pThis);

	/// <summary>
	/// Control the output index array name.  Default: "index".
	/// </summary>
	public virtual string GetArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkGenerateIndexArray_GetArrayName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenerateIndexArray_GetFieldType_02(HandleRef pThis);

	/// <summary>
	/// Control the location where the index array will be stored.
	/// </summary>
	public virtual int GetFieldType()
	{
		return vtkGenerateIndexArray_GetFieldType_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenerateIndexArray_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenerateIndexArray_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenerateIndexArray_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenerateIndexArray_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenerateIndexArray_GetPedigreeID_05(HandleRef pThis);

	/// <summary>
	/// Specifies whether the index array should be marked as
	/// pedigree ids.  Default: false.
	/// </summary>
	public virtual int GetPedigreeID()
	{
		return vtkGenerateIndexArray_GetPedigreeID_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenerateIndexArray_GetReferenceArrayName_06(HandleRef pThis);

	/// <summary>
	/// Specifies an optional reference array for index-generation.
	/// </summary>
	public virtual string GetReferenceArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkGenerateIndexArray_GetReferenceArrayName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenerateIndexArray_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenerateIndexArray_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenerateIndexArray_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenerateIndexArray_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenerateIndexArray_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGenerateIndexArray NewInstance()
	{
		vtkGenerateIndexArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenerateIndexArray_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenerateIndexArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenerateIndexArray_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenerateIndexArray SafeDownCast(vtkObjectBase o)
	{
		vtkGenerateIndexArray vtkGenerateIndexArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenerateIndexArray_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenerateIndexArray2 = (vtkGenerateIndexArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenerateIndexArray2.Register(null);
			}
		}
		return vtkGenerateIndexArray2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenerateIndexArray_SetArrayName_12(HandleRef pThis, string _arg);

	/// <summary>
	/// Control the output index array name.  Default: "index".
	/// </summary>
	public virtual void SetArrayName(string _arg)
	{
		vtkGenerateIndexArray_SetArrayName_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenerateIndexArray_SetFieldType_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the location where the index array will be stored.
	/// </summary>
	public virtual void SetFieldType(int _arg)
	{
		vtkGenerateIndexArray_SetFieldType_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenerateIndexArray_SetPedigreeID_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Specifies whether the index array should be marked as
	/// pedigree ids.  Default: false.
	/// </summary>
	public virtual void SetPedigreeID(int _arg)
	{
		vtkGenerateIndexArray_SetPedigreeID_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenerateIndexArray_SetReferenceArrayName_15(HandleRef pThis, string _arg);

	/// <summary>
	/// Specifies an optional reference array for index-generation.
	/// </summary>
	public virtual void SetReferenceArrayName(string _arg)
	{
		vtkGenerateIndexArray_SetReferenceArrayName_15(GetCppThis(), _arg);
	}
}
