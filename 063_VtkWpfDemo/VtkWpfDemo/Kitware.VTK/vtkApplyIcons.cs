using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkApplyIcons
/// </summary>
/// <remarks>
///    apply icons to a data set.
///
///
/// vtkApplyIcons performs a iconing of the dataset using default icons,
/// lookup tables, annotations, and/or a selection. The output is a
/// vtkIntArray containing the icon index for each
/// element in the dataset. The first input is the dataset to be iconed, which
/// may be a vtkTable, vtkGraph subclass, or vtkDataSet subclass.
///
/// The second (optional) input is a vtkAnnotationLayers object, which stores
/// a list of annotation layers, with each layer holding a list of
/// vtkAnnotation objects. The annotation specifies a subset of data along with
/// other properties, including icon. For annotations with icon properties,
/// this algorithm will use the icon index of annotated elements,
/// using a "top one wins" strategy.
///
/// The third (optional) input is a vtkSelection object, meant for specifying
/// the current selection. You can control the icon of the selection, or whether
/// there is a set of selected icons at a particular offset in the icon sheet.
///
/// The algorithm takes an input array, specified with
/// SetInputArrayToProcess(0, 0, 0, vtkDataObject::FIELD_ASSOCIATION_POINTS, name)
/// This sets data arrays to use to icon the data with
/// the associated lookup table. For vtkGraph and vtkTable inputs, you would use
/// FIELD_ASSOCIATION_VERTICES, FIELD_ASSOCIATION_EDGES, or
/// FIELD_ASSOCIATION_ROWS as appropriate. The icon array will be added to the same
/// set of attributes that the input array came from. If there is no input array,
/// the icon array will be applied to the attributes associated with the
/// AttributeType parameter.
///
/// Icons are assigned with the following priorities:
/// &lt;ol&gt;
/// &lt;li&gt; If an item is part of the selection, it is glyphed with that icon.
/// &lt;li&gt; Otherwise, if the item is part of an annotation, it is glyphed
///      with the icon of the final (top) annotation in the set of layers.
/// &lt;li&gt; Otherwise, if a lookup table is used, it is glyphed using the
///      lookup table icon for the data value of the element.
/// &lt;li&gt; Otherwise it will be glyphed with the default icon.
/// &lt;/ol&gt;
/// </remarks>
public class vtkApplyIcons : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// The output array name for the point icon index array.
	/// Default is "vtkApplyIcons icon".
	/// </summary>
	public enum ANNOTATION_ICON_WrapperEnum
	{
		/// <summary>enum member</summary>
		ANNOTATION_ICON = 2,
		/// <summary>enum member</summary>
		IGNORE_SELECTION = 3,
		/// <summary>enum member</summary>
		SELECTED_ICON = 0,
		/// <summary>enum member</summary>
		SELECTED_OFFSET = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkApplyIcons";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkApplyIcons()
	{
		MRClassNameKey = "class vtkApplyIcons";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkApplyIcons"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkApplyIcons(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkApplyIcons_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkApplyIcons New()
	{
		vtkApplyIcons result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkApplyIcons_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkApplyIcons)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkApplyIcons()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkApplyIcons_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyIcons_ClearAllIconTypes_01(HandleRef pThis);

	/// <summary>
	/// Edits the lookup table to use for point icons. This is only used if
	/// input array 0 is set and UsePointLookupTable is on.
	/// </summary>
	public void ClearAllIconTypes()
	{
		vtkApplyIcons_ClearAllIconTypes_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkApplyIcons_GetAttributeType_02(HandleRef pThis);

	/// <summary>
	/// The attribute type to append the icon array to, used only if the
	/// input array is not specified or does not exist. This is set to one
	/// of the AttributeTypes enum in vtkDataObject (e.g. POINT, CELL, VERTEX
	/// EDGE, FIELD).
	/// </summary>
	public virtual int GetAttributeType()
	{
		return vtkApplyIcons_GetAttributeType_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkApplyIcons_GetDefaultIcon_03(HandleRef pThis);

	/// <summary>
	/// The default point icon for all unannotated, unselected elements
	/// of the data. This is used if UsePointLookupTable is off.
	/// </summary>
	public virtual int GetDefaultIcon()
	{
		return vtkApplyIcons_GetDefaultIcon_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkApplyIcons_GetIconOutputArrayName_04(HandleRef pThis);

	/// <summary>
	/// The output array name for the point icon index array.
	/// Default is "vtkApplyIcons icon".
	/// </summary>
	public virtual string GetIconOutputArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkApplyIcons_GetIconOutputArrayName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkApplyIcons_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkApplyIcons_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkApplyIcons_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkApplyIcons_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkApplyIcons_GetSelectedIcon_07(HandleRef pThis);

	/// <summary>
	/// The point icon for all selected elements of the data.
	/// This is used if the annotation input has a current selection.
	/// </summary>
	public virtual int GetSelectedIcon()
	{
		return vtkApplyIcons_GetSelectedIcon_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkApplyIcons_GetSelectionMode_08(HandleRef pThis);

	/// <summary>
	/// Changes the behavior of the icon to use for selected items.
	/// &lt;ul&gt;
	/// &lt;li&gt;SELECTED_ICON uses SelectedIcon as the icon for all selected elements.
	/// &lt;li&gt;SELECTED_OFFSET uses SelectedIcon as an offset to add to all selected elements.
	/// &lt;li&gt;ANNOTATION_ICON uses the ICON_INDEX() property of the current annotation.
	/// &lt;li&gt;IGNORE_SELECTION does not change the icon based on the current selection.
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual int GetSelectionMode()
	{
		return vtkApplyIcons_GetSelectionMode_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkApplyIcons_GetUseLookupTable_09(HandleRef pThis);

	/// <summary>
	/// If on, uses the point lookup table to set the colors of unannotated,
	/// unselected elements of the data.
	/// </summary>
	public virtual bool GetUseLookupTable()
	{
		return (vtkApplyIcons_GetUseLookupTable_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkApplyIcons_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkApplyIcons_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkApplyIcons_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkApplyIcons_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkApplyIcons_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkApplyIcons NewInstance()
	{
		vtkApplyIcons result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkApplyIcons_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkApplyIcons)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkApplyIcons_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkApplyIcons SafeDownCast(vtkObjectBase o)
	{
		vtkApplyIcons vtkApplyIcons2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkApplyIcons_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkApplyIcons2 = (vtkApplyIcons)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkApplyIcons2.Register(null);
			}
		}
		return vtkApplyIcons2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyIcons_SetAttributeType_15(HandleRef pThis, int _arg);

	/// <summary>
	/// The attribute type to append the icon array to, used only if the
	/// input array is not specified or does not exist. This is set to one
	/// of the AttributeTypes enum in vtkDataObject (e.g. POINT, CELL, VERTEX
	/// EDGE, FIELD).
	/// </summary>
	public virtual void SetAttributeType(int _arg)
	{
		vtkApplyIcons_SetAttributeType_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyIcons_SetDefaultIcon_16(HandleRef pThis, int _arg);

	/// <summary>
	/// The default point icon for all unannotated, unselected elements
	/// of the data. This is used if UsePointLookupTable is off.
	/// </summary>
	public virtual void SetDefaultIcon(int _arg)
	{
		vtkApplyIcons_SetDefaultIcon_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyIcons_SetIconOutputArrayName_17(HandleRef pThis, string _arg);

	/// <summary>
	/// The output array name for the point icon index array.
	/// Default is "vtkApplyIcons icon".
	/// </summary>
	public virtual void SetIconOutputArrayName(string _arg)
	{
		vtkApplyIcons_SetIconOutputArrayName_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyIcons_SetIconType_18(HandleRef pThis, HandleRef v, int icon);

	/// <summary>
	/// Edits the lookup table to use for point icons. This is only used if
	/// input array 0 is set and UsePointLookupTable is on.
	/// </summary>
	public void SetIconType(vtkVariant v, int icon)
	{
		vtkApplyIcons_SetIconType_18(GetCppThis(), v?.GetCppThis() ?? default(HandleRef), icon);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyIcons_SetIconType_19(HandleRef pThis, double v, int icon);

	/// <summary>
	/// Edits the lookup table to use for point icons. This is only used if
	/// input array 0 is set and UsePointLookupTable is on.
	/// </summary>
	public void SetIconType(double v, int icon)
	{
		vtkApplyIcons_SetIconType_19(GetCppThis(), v, icon);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyIcons_SetIconType_20(HandleRef pThis, string v, int icon);

	/// <summary>
	/// Edits the lookup table to use for point icons. This is only used if
	/// input array 0 is set and UsePointLookupTable is on.
	/// </summary>
	public void SetIconType(string v, int icon)
	{
		vtkApplyIcons_SetIconType_20(GetCppThis(), v, icon);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyIcons_SetSelectedIcon_21(HandleRef pThis, int _arg);

	/// <summary>
	/// The point icon for all selected elements of the data.
	/// This is used if the annotation input has a current selection.
	/// </summary>
	public virtual void SetSelectedIcon(int _arg)
	{
		vtkApplyIcons_SetSelectedIcon_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyIcons_SetSelectionMode_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Changes the behavior of the icon to use for selected items.
	/// &lt;ul&gt;
	/// &lt;li&gt;SELECTED_ICON uses SelectedIcon as the icon for all selected elements.
	/// &lt;li&gt;SELECTED_OFFSET uses SelectedIcon as an offset to add to all selected elements.
	/// &lt;li&gt;ANNOTATION_ICON uses the ICON_INDEX() property of the current annotation.
	/// &lt;li&gt;IGNORE_SELECTION does not change the icon based on the current selection.
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetSelectionMode(int _arg)
	{
		vtkApplyIcons_SetSelectionMode_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyIcons_SetSelectionModeToAnnotationIcon_23(HandleRef pThis);

	/// <summary>
	/// Changes the behavior of the icon to use for selected items.
	/// &lt;ul&gt;
	/// &lt;li&gt;SELECTED_ICON uses SelectedIcon as the icon for all selected elements.
	/// &lt;li&gt;SELECTED_OFFSET uses SelectedIcon as an offset to add to all selected elements.
	/// &lt;li&gt;ANNOTATION_ICON uses the ICON_INDEX() property of the current annotation.
	/// &lt;li&gt;IGNORE_SELECTION does not change the icon based on the current selection.
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetSelectionModeToAnnotationIcon()
	{
		vtkApplyIcons_SetSelectionModeToAnnotationIcon_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyIcons_SetSelectionModeToIgnoreSelection_24(HandleRef pThis);

	/// <summary>
	/// Changes the behavior of the icon to use for selected items.
	/// &lt;ul&gt;
	/// &lt;li&gt;SELECTED_ICON uses SelectedIcon as the icon for all selected elements.
	/// &lt;li&gt;SELECTED_OFFSET uses SelectedIcon as an offset to add to all selected elements.
	/// &lt;li&gt;ANNOTATION_ICON uses the ICON_INDEX() property of the current annotation.
	/// &lt;li&gt;IGNORE_SELECTION does not change the icon based on the current selection.
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetSelectionModeToIgnoreSelection()
	{
		vtkApplyIcons_SetSelectionModeToIgnoreSelection_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyIcons_SetSelectionModeToSelectedIcon_25(HandleRef pThis);

	/// <summary>
	/// Changes the behavior of the icon to use for selected items.
	/// &lt;ul&gt;
	/// &lt;li&gt;SELECTED_ICON uses SelectedIcon as the icon for all selected elements.
	/// &lt;li&gt;SELECTED_OFFSET uses SelectedIcon as an offset to add to all selected elements.
	/// &lt;li&gt;ANNOTATION_ICON uses the ICON_INDEX() property of the current annotation.
	/// &lt;li&gt;IGNORE_SELECTION does not change the icon based on the current selection.
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetSelectionModeToSelectedIcon()
	{
		vtkApplyIcons_SetSelectionModeToSelectedIcon_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyIcons_SetSelectionModeToSelectedOffset_26(HandleRef pThis);

	/// <summary>
	/// Changes the behavior of the icon to use for selected items.
	/// &lt;ul&gt;
	/// &lt;li&gt;SELECTED_ICON uses SelectedIcon as the icon for all selected elements.
	/// &lt;li&gt;SELECTED_OFFSET uses SelectedIcon as an offset to add to all selected elements.
	/// &lt;li&gt;ANNOTATION_ICON uses the ICON_INDEX() property of the current annotation.
	/// &lt;li&gt;IGNORE_SELECTION does not change the icon based on the current selection.
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetSelectionModeToSelectedOffset()
	{
		vtkApplyIcons_SetSelectionModeToSelectedOffset_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyIcons_SetUseLookupTable_27(HandleRef pThis, byte _arg);

	/// <summary>
	/// If on, uses the point lookup table to set the colors of unannotated,
	/// unselected elements of the data.
	/// </summary>
	public virtual void SetUseLookupTable(bool _arg)
	{
		vtkApplyIcons_SetUseLookupTable_27(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyIcons_UseLookupTableOff_28(HandleRef pThis);

	/// <summary>
	/// If on, uses the point lookup table to set the colors of unannotated,
	/// unselected elements of the data.
	/// </summary>
	public virtual void UseLookupTableOff()
	{
		vtkApplyIcons_UseLookupTableOff_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkApplyIcons_UseLookupTableOn_29(HandleRef pThis);

	/// <summary>
	/// If on, uses the point lookup table to set the colors of unannotated,
	/// unselected elements of the data.
	/// </summary>
	public virtual void UseLookupTableOn()
	{
		vtkApplyIcons_UseLookupTableOn_29(GetCppThis());
	}
}
