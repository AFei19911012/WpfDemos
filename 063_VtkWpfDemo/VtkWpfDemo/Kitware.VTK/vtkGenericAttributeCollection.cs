using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericAttributeCollection
/// </summary>
/// <remarks>
///    a collection of attributes
///
/// vtkGenericAttributeCollection is a class that collects attributes
/// (represented by vtkGenericAttribute).
/// </remarks>
public class vtkGenericAttributeCollection : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericAttributeCollection";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericAttributeCollection()
	{
		MRClassNameKey = "class vtkGenericAttributeCollection";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericAttributeCollection"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericAttributeCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericAttributeCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create an empty collection.
	/// </summary>
	public new static vtkGenericAttributeCollection New()
	{
		vtkGenericAttributeCollection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericAttributeCollection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericAttributeCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create an empty collection.
	/// </summary>
	public vtkGenericAttributeCollection()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGenericAttributeCollection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkGenericAttributeCollection_DeepCopy_01(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Copy, without reference counting, the other attribute array.
	/// \pre other_exists: other!=0
	/// \pre not_self: other!=this
	/// \post same_size: GetNumberOfAttributes()==other-&gt;GetNumberOfAttributes()
	/// </summary>
	public void DeepCopy(vtkGenericAttributeCollection other)
	{
		vtkGenericAttributeCollection_DeepCopy_01(GetCppThis(), other?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAttributeCollection_FindAttribute_02(HandleRef pThis, string name);

	/// <summary>
	/// Return the index of the attribute named `name'. Return the non-negative
	/// index if found. Return -1 otherwise.
	/// \pre name_exists: name!=0
	/// \post valid_result: (result==-1) || (result&gt;=0) &amp;&amp; (result&lt;=GetNumberOfAttributes())
	/// </summary>
	public int FindAttribute(string name)
	{
		return vtkGenericAttributeCollection_FindAttribute_02(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAttributeCollection_GetActiveAttribute_03(HandleRef pThis);

	/// <summary>
	/// Index of the attribute to be processed (not necessarily scalar).
	/// \pre not_empty: !IsEmpty()
	/// \post valid_result: result&gt;=0 &amp;&amp; result&lt;GetNumberOfAttributes()
	/// </summary>
	public virtual int GetActiveAttribute()
	{
		return vtkGenericAttributeCollection_GetActiveAttribute_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAttributeCollection_GetActiveComponent_04(HandleRef pThis);

	/// <summary>
	/// Component of the active attribute to be processed. -1 means module.
	/// \pre not_empty: GetNumberOfAttributes()&gt;0
	/// \post valid_result: result&gt;=-1 &amp;&amp;
	/// result&lt;GetAttribute(GetActiveAttribute())-&gt;GetNumberOfComponents()
	/// </summary>
	public virtual int GetActiveComponent()
	{
		return vtkGenericAttributeCollection_GetActiveComponent_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkGenericAttributeCollection_GetActualMemorySize_05(HandleRef pThis);

	/// <summary>
	/// Actual size of the data in kibibytes (1024 bytes); only valid after the pipeline has
	/// updated. It is guaranteed to be greater than or equal to the memory
	/// required to represent the data.
	/// </summary>
	public uint GetActualMemorySize()
	{
		return vtkGenericAttributeCollection_GetActualMemorySize_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericAttributeCollection_GetAttribute_06(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a pointer to the ith instance of vtkGenericAttribute.
	/// \pre not_empty: !IsEmpty()
	/// \pre valid_i: i&gt;=0 &amp;&amp; i&lt;GetNumberOfAttributes()
	/// \post result_exists: result!=0
	/// </summary>
	public vtkGenericAttribute GetAttribute(int i)
	{
		vtkGenericAttribute vtkGenericAttribute2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericAttributeCollection_GetAttribute_06(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericAttribute2 = (vtkGenericAttribute)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericAttribute2.Register(null);
			}
		}
		return vtkGenericAttribute2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAttributeCollection_GetAttributeIndex_07(HandleRef pThis, int i);

	/// <summary>
	/// Return the index of the first component of attribute `i' in an array of
	/// format attrib0comp0 attrib0comp1 ... attrib4comp0 ...
	/// \pre valid_i: i&gt;=0 &amp;&amp; i&lt;GetNumberOfAttributes()
	/// \pre is_point_centered: GetAttribute(i)-&gt;GetCentering()==vtkPointCentered
	/// </summary>
	public int GetAttributeIndex(int i)
	{
		return vtkGenericAttributeCollection_GetAttributeIndex_07(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericAttributeCollection_GetAttributesToInterpolate_08(HandleRef pThis);

	/// <summary>
	/// Indices of attributes to interpolate.
	/// \pre not_empty: !IsEmpty()
	/// \post valid_result: GetNumberOfAttributesToInterpolate()&gt;0
	/// </summary>
	public IntPtr GetAttributesToInterpolate()
	{
		return vtkGenericAttributeCollection_GetAttributesToInterpolate_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkGenericAttributeCollection_GetMTime_09(HandleRef pThis);

	/// <summary>
	/// vtkAttributeCollection is a composite object and needs to check each
	/// member of its collection for modified time.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkGenericAttributeCollection_GetMTime_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAttributeCollection_GetMaxNumberOfComponents_10(HandleRef pThis);

	/// <summary>
	/// Maximum number of components encountered among all attributes.
	/// \post positive_result: result&gt;=0
	/// \post valid_result: result&lt;=GetNumberOfComponents()
	/// </summary>
	public int GetMaxNumberOfComponents()
	{
		return vtkGenericAttributeCollection_GetMaxNumberOfComponents_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAttributeCollection_GetNumberOfAttributes_11(HandleRef pThis);

	/// <summary>
	/// Return the number of attributes (e.g., instances of vtkGenericAttribute)
	/// in the collection.
	/// \post positive_result: result&gt;=0
	/// </summary>
	public int GetNumberOfAttributes()
	{
		return vtkGenericAttributeCollection_GetNumberOfAttributes_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAttributeCollection_GetNumberOfAttributesToInterpolate_12(HandleRef pThis);

	/// <summary>
	/// Number of attributes to interpolate.
	/// \pre not_empty: !IsEmpty()
	/// \post positive_result: result&gt;=0
	/// </summary>
	public virtual int GetNumberOfAttributesToInterpolate()
	{
		return vtkGenericAttributeCollection_GetNumberOfAttributesToInterpolate_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAttributeCollection_GetNumberOfComponents_13(HandleRef pThis);

	/// <summary>
	/// Return the number of components. This is the sum of all components
	/// found in all attributes.
	/// \post positive_result: result&gt;=0
	/// </summary>
	public int GetNumberOfComponents()
	{
		return vtkGenericAttributeCollection_GetNumberOfComponents_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericAttributeCollection_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard type definition and print methods for a VTK class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericAttributeCollection_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericAttributeCollection_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	/// Standard type definition and print methods for a VTK class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericAttributeCollection_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAttributeCollection_GetNumberOfPointCenteredComponents_16(HandleRef pThis);

	/// <summary>
	/// Return the number of components. This is the sum of all components
	/// found in all point centered attributes.
	/// \post positive_result: result&gt;=0
	/// </summary>
	public int GetNumberOfPointCenteredComponents()
	{
		return vtkGenericAttributeCollection_GetNumberOfPointCenteredComponents_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAttributeCollection_HasAttribute_17(HandleRef pThis, int size, IntPtr attributes, int attribute);

	/// <summary>
	/// Does the array `attributes' of size `size' have `attribute'?
	/// \pre positive_size: size&gt;=0
	/// \pre valid_attributes: size&gt;0 implies attributes!=0
	/// </summary>
	public int HasAttribute(int size, IntPtr attributes, int attribute)
	{
		return vtkGenericAttributeCollection_HasAttribute_17(GetCppThis(), size, attributes, attribute);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAttributeCollection_InsertAttribute_18(HandleRef pThis, int i, HandleRef a);

	/// <summary>
	/// Replace the attribute at index `i' by `a'.
	/// \pre not_empty: !IsEmpty()
	/// \pre a_exists: a!=0
	/// \pre valid_i: i&gt;=0 &amp;&amp; i&lt;GetNumberOfAttributes()
	/// \post same_size: GetNumberOfAttributes()==old GetNumberOfAttributes()
	/// \post item_is_set: GetAttribute(i)==a
	/// </summary>
	public void InsertAttribute(int i, vtkGenericAttribute a)
	{
		vtkGenericAttributeCollection_InsertAttribute_18(GetCppThis(), i, a?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAttributeCollection_InsertNextAttribute_19(HandleRef pThis, HandleRef a);

	/// <summary>
	/// Add the attribute `a' to the end of the collection.
	/// \pre a_exists: a!=0
	/// \post more_items: GetNumberOfAttributes()==old GetNumberOfAttributes()+1
	/// \post a_is_set: GetAttribute(GetNumberOfAttributes()-1)==a
	/// </summary>
	public void InsertNextAttribute(vtkGenericAttribute a)
	{
		vtkGenericAttributeCollection_InsertNextAttribute_19(GetCppThis(), a?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAttributeCollection_IsA_20(HandleRef pThis, string type);

	/// <summary>
	/// Standard type definition and print methods for a VTK class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericAttributeCollection_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAttributeCollection_IsEmpty_21(HandleRef pThis);

	/// <summary>
	/// Indicate whether the collection contains any attributes.
	/// \post definition: result==(GetNumberOfAttributes()==0)
	/// </summary>
	public int IsEmpty()
	{
		return vtkGenericAttributeCollection_IsEmpty_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAttributeCollection_IsTypeOf_22(string type);

	/// <summary>
	/// Standard type definition and print methods for a VTK class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericAttributeCollection_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericAttributeCollection_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type definition and print methods for a VTK class.
	/// </summary>
	public new vtkGenericAttributeCollection NewInstance()
	{
		vtkGenericAttributeCollection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericAttributeCollection_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericAttributeCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAttributeCollection_RemoveAttribute_25(HandleRef pThis, int i);

	/// <summary>
	/// Remove the attribute at `i'.
	/// \pre not_empty: !IsEmpty()
	/// \pre valid_i: i&gt;=0 &amp;&amp; i&lt;GetNumberOfAttributes()
	/// \post fewer_items: GetNumberOfAttributes()==old GetNumberOfAttributes()-1
	/// </summary>
	public void RemoveAttribute(int i)
	{
		vtkGenericAttributeCollection_RemoveAttribute_25(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAttributeCollection_Reset_26(HandleRef pThis);

	/// <summary>
	/// Remove all attributes.
	/// \post is_empty: GetNumberOfAttributes()==0
	/// </summary>
	public void Reset()
	{
		vtkGenericAttributeCollection_Reset_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericAttributeCollection_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type definition and print methods for a VTK class.
	/// </summary>
	public new static vtkGenericAttributeCollection SafeDownCast(vtkObjectBase o)
	{
		vtkGenericAttributeCollection vtkGenericAttributeCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericAttributeCollection_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericAttributeCollection2 = (vtkGenericAttributeCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericAttributeCollection2.Register(null);
			}
		}
		return vtkGenericAttributeCollection2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAttributeCollection_SetActiveAttribute_28(HandleRef pThis, int attribute, int component);

	/// <summary>
	/// Set the scalar attribute to be processed. -1 means module.
	/// \pre not_empty: !IsEmpty()
	/// \pre valid_attribute: attribute&gt;=0 &amp;&amp; attribute&lt;GetNumberOfAttributes()
	/// \pre valid_component: component&gt;=-1 &amp;&amp;
	/// component&lt;GetAttribute(attribute)-&gt;GetNumberOfComponents()
	/// \post is_set: GetActiveAttribute()==attribute &amp;&amp;
	/// GetActiveComponent()==component
	/// </summary>
	public void SetActiveAttribute(int attribute, int component)
	{
		vtkGenericAttributeCollection_SetActiveAttribute_28(GetCppThis(), attribute, component);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAttributeCollection_SetAttributesToInterpolate_29(HandleRef pThis, int size, IntPtr attributes);

	/// <summary>
	/// Set the attributes to interpolate.
	/// \pre not_empty: !IsEmpty()
	/// \pre positive_size: size&gt;=0
	/// \pre valid_attributes: size&gt;0 implies attributes!=0
	/// \pre valid_attributes_contents: attributes!=0 implies
	/// !HasAttributes(size,attributes,GetActiveAttribute())
	/// \post is_set: (GetNumberOfAttributesToInterpolate()==size)&amp;&amp;
	/// (GetAttributesToInterpolate()==attributes)
	/// </summary>
	public void SetAttributesToInterpolate(int size, IntPtr attributes)
	{
		vtkGenericAttributeCollection_SetAttributesToInterpolate_29(GetCppThis(), size, attributes);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAttributeCollection_SetAttributesToInterpolateToAll_30(HandleRef pThis);

	/// <summary>
	/// Set the attributes to interpolate.
	/// \pre not_empty: !IsEmpty()
	/// \pre positive_size: size&gt;=0
	/// \pre valid_attributes: size&gt;0 implies attributes!=0
	/// \pre valid_attributes_contents: attributes!=0 implies
	/// !HasAttributes(size,attributes,GetActiveAttribute())
	/// \post is_set: (GetNumberOfAttributesToInterpolate()==size)&amp;&amp;
	/// (GetAttributesToInterpolate()==attributes)
	/// </summary>
	public void SetAttributesToInterpolateToAll()
	{
		vtkGenericAttributeCollection_SetAttributesToInterpolateToAll_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAttributeCollection_ShallowCopy_31(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Copy, via reference counting, the other attribute array.
	/// \pre other_exists: other!=0
	/// \pre not_self: other!=this
	/// \post same_size: GetNumberOfAttributes()==other-&gt;GetNumberOfAttributes()
	/// </summary>
	public void ShallowCopy(vtkGenericAttributeCollection other)
	{
		vtkGenericAttributeCollection_ShallowCopy_31(GetCppThis(), other?.GetCppThis() ?? default(HandleRef));
	}
}
