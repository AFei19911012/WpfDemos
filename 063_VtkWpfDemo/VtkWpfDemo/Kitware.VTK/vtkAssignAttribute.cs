using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAssignAttribute
/// </summary>
/// <remarks>
///    Labels/marks a field as an attribute
///
/// vtkAssignAttribute is used to label/mark a field (vtkDataArray) as an attribute.
/// A field name or an attribute to labeled can be specified. For example:
/// @verbatim
/// aa-&gt;Assign("foo", vtkDataSetAttributes::SCALARS,
///            vtkAssignAttribute::POINT_DATA);
/// @endverbatim
/// tells vtkAssignAttribute to make the array in the point data called
/// "foo" the active scalars. On the other hand,
/// @verbatim
/// aa-&gt;Assign(vtkDataSetAttributes::VECTORS, vtkDataSetAttributes::SCALARS,
///            vtkAssignAttribute::POINT_DATA);
/// @endverbatim
/// tells vtkAssignAttribute to make the active vectors also the active
/// scalars.
///
/// @warning
/// When using Java, Python or Visual Basic bindings, the array name
/// can not be one of the  AttributeTypes when calling Assign() which takes
/// strings as arguments. The wrapped command will
/// always assume the string corresponds to an attribute type when
/// the argument is one of the AttributeTypes. In this situation,
/// use the Assign() which takes enums.
///
/// </remarks>
/// <seealso>
///
/// vtkFieldData vtkDataSet vtkDataObjectToDataSetFilter
/// vtkDataSetAttributes vtkDataArray vtkRearrangeFields
/// vtkSplitField vtkMergeFields
/// </seealso>
public class vtkAssignAttribute : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Helper method used by other language bindings. Allows the caller to
	/// specify arguments as strings instead of enums.
	/// </summary>
	public enum AttributeLocation
	{
		/// <summary>enum member</summary>
		CELL_DATA = 1,
		/// <summary>enum member</summary>
		EDGE_DATA = 3,
		/// <summary>enum member</summary>
		NUM_ATTRIBUTE_LOCS = 4,
		/// <summary>enum member</summary>
		POINT_DATA = 0,
		/// <summary>enum member</summary>
		VERTEX_DATA = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAssignAttribute";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAssignAttribute()
	{
		MRClassNameKey = "class vtkAssignAttribute";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAssignAttribute"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAssignAttribute(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssignAttribute_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a new vtkAssignAttribute.
	/// </summary>
	public new static vtkAssignAttribute New()
	{
		vtkAssignAttribute result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssignAttribute_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAssignAttribute)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create a new vtkAssignAttribute.
	/// </summary>
	public vtkAssignAttribute()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAssignAttribute_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAssignAttribute_Assign_01(HandleRef pThis, int inputAttributeType, int attributeType, int attributeLoc);

	/// <summary>
	/// Label an attribute as another attribute.
	/// </summary>
	public void Assign(int inputAttributeType, int attributeType, int attributeLoc)
	{
		vtkAssignAttribute_Assign_01(GetCppThis(), inputAttributeType, attributeType, attributeLoc);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssignAttribute_Assign_02(HandleRef pThis, string fieldName, int attributeType, int attributeLoc);

	/// <summary>
	/// Label an array as an attribute.
	/// </summary>
	public void Assign(string fieldName, int attributeType, int attributeLoc)
	{
		vtkAssignAttribute_Assign_02(GetCppThis(), fieldName, attributeType, attributeLoc);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAssignAttribute_Assign_03(HandleRef pThis, string name, string attributeType, string attributeLoc);

	/// <summary>
	/// Helper method used by other language bindings. Allows the caller to
	/// specify arguments as strings instead of enums.
	/// </summary>
	public void Assign(string name, string attributeType, string attributeLoc)
	{
		vtkAssignAttribute_Assign_03(GetCppThis(), name, attributeType, attributeLoc);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAssignAttribute_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAssignAttribute_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAssignAttribute_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAssignAttribute_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAssignAttribute_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAssignAttribute_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAssignAttribute_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAssignAttribute_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssignAttribute_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAssignAttribute NewInstance()
	{
		vtkAssignAttribute result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssignAttribute_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAssignAttribute)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAssignAttribute_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAssignAttribute SafeDownCast(vtkObjectBase o)
	{
		vtkAssignAttribute vtkAssignAttribute2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAssignAttribute_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAssignAttribute2 = (vtkAssignAttribute)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAssignAttribute2.Register(null);
			}
		}
		return vtkAssignAttribute2;
	}
}
