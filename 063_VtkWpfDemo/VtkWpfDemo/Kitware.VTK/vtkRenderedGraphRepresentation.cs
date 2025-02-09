using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRenderedGraphRepresentation
///
///
/// </summary>
public class vtkRenderedGraphRepresentation : vtkRenderedRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRenderedGraphRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRenderedGraphRepresentation()
	{
		MRClassNameKey = "class vtkRenderedGraphRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderedGraphRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRenderedGraphRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRenderedGraphRepresentation New()
	{
		vtkRenderedGraphRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedGraphRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRenderedGraphRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRenderedGraphRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRenderedGraphRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkRenderedGraphRepresentation_AddEdgeIconType_01(HandleRef pThis, string name, int type);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void AddEdgeIconType(string name, int type)
	{
		vtkRenderedGraphRepresentation_AddEdgeIconType_01(GetCppThis(), name, type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_AddVertexIconType_02(HandleRef pThis, string name, int type);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void AddVertexIconType(string name, int type)
	{
		vtkRenderedGraphRepresentation_AddVertexIconType_02(GetCppThis(), name, type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_ApplyViewTheme_03(HandleRef pThis, HandleRef theme);

	/// <summary>
	/// Apply a theme to this representation.
	/// </summary>
	public override void ApplyViewTheme(vtkViewTheme theme)
	{
		vtkRenderedGraphRepresentation_ApplyViewTheme_03(GetCppThis(), theme?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_ClearEdgeIconTypes_04(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void ClearEdgeIconTypes()
	{
		vtkRenderedGraphRepresentation_ClearEdgeIconTypes_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_ClearVertexIconTypes_05(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void ClearVertexIconTypes()
	{
		vtkRenderedGraphRepresentation_ClearVertexIconTypes_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_ColorEdgesByArrayOff_06(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void ColorEdgesByArrayOff()
	{
		vtkRenderedGraphRepresentation_ColorEdgesByArrayOff_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_ColorEdgesByArrayOn_07(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void ColorEdgesByArrayOn()
	{
		vtkRenderedGraphRepresentation_ColorEdgesByArrayOn_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_ColorVerticesByArrayOff_08(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void ColorVerticesByArrayOff()
	{
		vtkRenderedGraphRepresentation_ColorVerticesByArrayOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_ColorVerticesByArrayOn_09(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void ColorVerticesByArrayOn()
	{
		vtkRenderedGraphRepresentation_ColorVerticesByArrayOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_ComputeSelectedGraphBounds_10(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Compute the bounding box of the selected subgraph.
	/// </summary>
	public void ComputeSelectedGraphBounds(IntPtr bounds)
	{
		vtkRenderedGraphRepresentation_ComputeSelectedGraphBounds_10(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_EdgeIconVisibilityOff_11(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void EdgeIconVisibilityOff()
	{
		vtkRenderedGraphRepresentation_EdgeIconVisibilityOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_EdgeIconVisibilityOn_12(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void EdgeIconVisibilityOn()
	{
		vtkRenderedGraphRepresentation_EdgeIconVisibilityOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_EdgeLabelVisibilityOff_13(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void EdgeLabelVisibilityOff()
	{
		vtkRenderedGraphRepresentation_EdgeLabelVisibilityOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_EdgeLabelVisibilityOn_14(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void EdgeLabelVisibilityOn()
	{
		vtkRenderedGraphRepresentation_EdgeLabelVisibilityOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_EdgeVisibilityOff_15(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void EdgeVisibilityOff()
	{
		vtkRenderedGraphRepresentation_EdgeVisibilityOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_EdgeVisibilityOn_16(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void EdgeVisibilityOn()
	{
		vtkRenderedGraphRepresentation_EdgeVisibilityOn_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_EnableEdgesByArrayOff_17(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void EnableEdgesByArrayOff()
	{
		vtkRenderedGraphRepresentation_EnableEdgesByArrayOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_EnableEdgesByArrayOn_18(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void EnableEdgesByArrayOn()
	{
		vtkRenderedGraphRepresentation_EnableEdgesByArrayOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_EnableVerticesByArrayOff_19(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void EnableVerticesByArrayOff()
	{
		vtkRenderedGraphRepresentation_EnableVerticesByArrayOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_EnableVerticesByArrayOn_20(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void EnableVerticesByArrayOn()
	{
		vtkRenderedGraphRepresentation_EnableVerticesByArrayOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedGraphRepresentation_GetColorEdgesByArray_21(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual bool GetColorEdgesByArray()
	{
		return (vtkRenderedGraphRepresentation_GetColorEdgesByArray_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedGraphRepresentation_GetColorVerticesByArray_22(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual bool GetColorVerticesByArray()
	{
		return (vtkRenderedGraphRepresentation_GetColorVerticesByArray_22(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeColorArrayName_23(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual string GetEdgeColorArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation_GetEdgeColorArrayName_23(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeHoverArrayName_24(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual string GetEdgeHoverArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation_GetEdgeHoverArrayName_24(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderedGraphRepresentation_GetEdgeIconAlignment_25(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual int GetEdgeIconAlignment()
	{
		return vtkRenderedGraphRepresentation_GetEdgeIconAlignment_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeIconArrayName_26(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual string GetEdgeIconArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation_GetEdgeIconArrayName_26(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeIconPriorityArrayName_27(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual string GetEdgeIconPriorityArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation_GetEdgeIconPriorityArrayName_27(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedGraphRepresentation_GetEdgeIconVisibility_28(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual bool GetEdgeIconVisibility()
	{
		return (vtkRenderedGraphRepresentation_GetEdgeIconVisibility_28(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeLabelArrayName_29(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual string GetEdgeLabelArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation_GetEdgeLabelArrayName_29(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeLabelPriorityArrayName_30(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual string GetEdgeLabelPriorityArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation_GetEdgeLabelPriorityArrayName_30(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeLabelTextProperty_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual vtkTextProperty GetEdgeLabelTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedGraphRepresentation_GetEdgeLabelTextProperty_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextProperty2 = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextProperty2.Register(null);
			}
		}
		return vtkTextProperty2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedGraphRepresentation_GetEdgeLabelVisibility_32(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual bool GetEdgeLabelVisibility()
	{
		return (vtkRenderedGraphRepresentation_GetEdgeLabelVisibility_32(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeLayoutStrategy_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the graph layout strategy.
	/// </summary>
	public virtual vtkEdgeLayoutStrategy GetEdgeLayoutStrategy()
	{
		vtkEdgeLayoutStrategy vtkEdgeLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedGraphRepresentation_GetEdgeLayoutStrategy_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEdgeLayoutStrategy2 = (vtkEdgeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEdgeLayoutStrategy2.Register(null);
			}
		}
		return vtkEdgeLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeLayoutStrategyName_34(HandleRef pThis);

	/// <summary>
	/// Set the edge layout strategy by name.
	/// </summary>
	public virtual string GetEdgeLayoutStrategyName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation_GetEdgeLayoutStrategyName_34(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeScalarBar_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Obtain the scalar bar widget used to draw a legend for the vertices/edges.
	/// </summary>
	public virtual vtkScalarBarWidget GetEdgeScalarBar()
	{
		vtkScalarBarWidget vtkScalarBarWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedGraphRepresentation_GetEdgeScalarBar_35(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarBarWidget2 = (vtkScalarBarWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarBarWidget2.Register(null);
			}
		}
		return vtkScalarBarWidget2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedGraphRepresentation_GetEdgeScalarBarVisibility_36(HandleRef pThis);

	/// <summary>
	/// Vertex/edge scalar bar visibility.
	/// </summary>
	public virtual bool GetEdgeScalarBarVisibility()
	{
		return (vtkRenderedGraphRepresentation_GetEdgeScalarBarVisibility_36(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedGraphRepresentation_GetEdgeSelection_37(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public bool GetEdgeSelection()
	{
		return (vtkRenderedGraphRepresentation_GetEdgeSelection_37(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedGraphRepresentation_GetEdgeVisibility_38(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual bool GetEdgeVisibility()
	{
		return (vtkRenderedGraphRepresentation_GetEdgeVisibility_38(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedGraphRepresentation_GetEnableEdgesByArray_39(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual bool GetEnableEdgesByArray()
	{
		return (vtkRenderedGraphRepresentation_GetEnableEdgesByArray_39(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedGraphRepresentation_GetEnableVerticesByArray_40(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual bool GetEnableVerticesByArray()
	{
		return (vtkRenderedGraphRepresentation_GetEnableVerticesByArray_40(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetEnabledEdgesArrayName_41(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual string GetEnabledEdgesArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation_GetEnabledEdgesArrayName_41(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetEnabledVerticesArrayName_42(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual string GetEnabledVerticesArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation_GetEnabledVerticesArrayName_42(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderedGraphRepresentation_GetGlyphType_43(HandleRef pThis);

	/// <summary>
	/// Set the graph vertex glyph type.
	/// </summary>
	public virtual int GetGlyphType()
	{
		return vtkRenderedGraphRepresentation_GetGlyphType_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedGraphRepresentation_GetHideEdgeLabelsOnInteraction_44(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual bool GetHideEdgeLabelsOnInteraction()
	{
		return (vtkRenderedGraphRepresentation_GetHideEdgeLabelsOnInteraction_44(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedGraphRepresentation_GetHideVertexLabelsOnInteraction_45(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual bool GetHideVertexLabelsOnInteraction()
	{
		return (vtkRenderedGraphRepresentation_GetHideVertexLabelsOnInteraction_45(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetLayoutStrategy_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the graph layout strategy.
	/// </summary>
	public virtual vtkGraphLayoutStrategy GetLayoutStrategy()
	{
		vtkGraphLayoutStrategy vtkGraphLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedGraphRepresentation_GetLayoutStrategy_46(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraphLayoutStrategy2 = (vtkGraphLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraphLayoutStrategy2.Register(null);
			}
		}
		return vtkGraphLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetLayoutStrategyName_47(HandleRef pThis);

	/// <summary>
	/// Get/set the layout strategy by name.
	/// </summary>
	public virtual string GetLayoutStrategyName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation_GetLayoutStrategyName_47(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRenderedGraphRepresentation_GetNumberOfGenerationsFromBase_48(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRenderedGraphRepresentation_GetNumberOfGenerationsFromBase_48(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRenderedGraphRepresentation_GetNumberOfGenerationsFromBaseType_49(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRenderedGraphRepresentation_GetNumberOfGenerationsFromBaseType_49(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedGraphRepresentation_GetScaling_50(HandleRef pThis);

	/// <summary>
	/// Set whether to scale vertex glyphs.
	/// </summary>
	public virtual bool GetScaling()
	{
		return (vtkRenderedGraphRepresentation_GetScaling_50(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetScalingArrayName_51(HandleRef pThis);

	/// <summary>
	/// Set the glyph scaling array name.
	/// </summary>
	public virtual string GetScalingArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation_GetScalingArrayName_51(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedGraphRepresentation_GetUseEdgeIconTypeMap_52(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual bool GetUseEdgeIconTypeMap()
	{
		return (vtkRenderedGraphRepresentation_GetUseEdgeIconTypeMap_52(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedGraphRepresentation_GetUseVertexIconTypeMap_53(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual bool GetUseVertexIconTypeMap()
	{
		return (vtkRenderedGraphRepresentation_GetUseVertexIconTypeMap_53(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexColorArrayName_54(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual string GetVertexColorArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation_GetVertexColorArrayName_54(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderedGraphRepresentation_GetVertexDefaultIcon_55(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual int GetVertexDefaultIcon()
	{
		return vtkRenderedGraphRepresentation_GetVertexDefaultIcon_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexHoverArrayName_56(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual string GetVertexHoverArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation_GetVertexHoverArrayName_56(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderedGraphRepresentation_GetVertexIconAlignment_57(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual int GetVertexIconAlignment()
	{
		return vtkRenderedGraphRepresentation_GetVertexIconAlignment_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexIconArrayName_58(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual string GetVertexIconArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation_GetVertexIconArrayName_58(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexIconPriorityArrayName_59(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual string GetVertexIconPriorityArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation_GetVertexIconPriorityArrayName_59(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderedGraphRepresentation_GetVertexIconSelectionMode_60(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual int GetVertexIconSelectionMode()
	{
		return vtkRenderedGraphRepresentation_GetVertexIconSelectionMode_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedGraphRepresentation_GetVertexIconVisibility_61(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual bool GetVertexIconVisibility()
	{
		return (vtkRenderedGraphRepresentation_GetVertexIconVisibility_61(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexLabelArrayName_62(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual string GetVertexLabelArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation_GetVertexLabelArrayName_62(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexLabelPriorityArrayName_63(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual string GetVertexLabelPriorityArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation_GetVertexLabelPriorityArrayName_63(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexLabelTextProperty_64(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual vtkTextProperty GetVertexLabelTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedGraphRepresentation_GetVertexLabelTextProperty_64(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextProperty2 = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextProperty2.Register(null);
			}
		}
		return vtkTextProperty2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedGraphRepresentation_GetVertexLabelVisibility_65(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual bool GetVertexLabelVisibility()
	{
		return (vtkRenderedGraphRepresentation_GetVertexLabelVisibility_65(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexScalarBar_66(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Obtain the scalar bar widget used to draw a legend for the vertices/edges.
	/// </summary>
	public virtual vtkScalarBarWidget GetVertexScalarBar()
	{
		vtkScalarBarWidget vtkScalarBarWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedGraphRepresentation_GetVertexScalarBar_66(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarBarWidget2 = (vtkScalarBarWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarBarWidget2.Register(null);
			}
		}
		return vtkScalarBarWidget2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedGraphRepresentation_GetVertexScalarBarVisibility_67(HandleRef pThis);

	/// <summary>
	/// Vertex/edge scalar bar visibility.
	/// </summary>
	public virtual bool GetVertexScalarBarVisibility()
	{
		return (vtkRenderedGraphRepresentation_GetVertexScalarBarVisibility_67(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderedGraphRepresentation_GetVertexSelectedIcon_68(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual int GetVertexSelectedIcon()
	{
		return vtkRenderedGraphRepresentation_GetVertexSelectedIcon_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_HideEdgeLabelsOnInteractionOff_69(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void HideEdgeLabelsOnInteractionOff()
	{
		vtkRenderedGraphRepresentation_HideEdgeLabelsOnInteractionOff_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_HideEdgeLabelsOnInteractionOn_70(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void HideEdgeLabelsOnInteractionOn()
	{
		vtkRenderedGraphRepresentation_HideEdgeLabelsOnInteractionOn_70(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_HideVertexLabelsOnInteractionOff_71(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void HideVertexLabelsOnInteractionOff()
	{
		vtkRenderedGraphRepresentation_HideVertexLabelsOnInteractionOff_71(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_HideVertexLabelsOnInteractionOn_72(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void HideVertexLabelsOnInteractionOn()
	{
		vtkRenderedGraphRepresentation_HideVertexLabelsOnInteractionOn_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderedGraphRepresentation_IsA_73(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRenderedGraphRepresentation_IsA_73(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderedGraphRepresentation_IsLayoutComplete_74(HandleRef pThis);

	/// <summary>
	/// Whether the current graph layout is complete.
	/// </summary>
	public virtual bool IsLayoutComplete()
	{
		return (vtkRenderedGraphRepresentation_IsLayoutComplete_74(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderedGraphRepresentation_IsTypeOf_75(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRenderedGraphRepresentation_IsTypeOf_75(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_NewInstance_77(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRenderedGraphRepresentation NewInstance()
	{
		vtkRenderedGraphRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedGraphRepresentation_NewInstance_77(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRenderedGraphRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderedGraphRepresentation_SafeDownCast_78(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRenderedGraphRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkRenderedGraphRepresentation vtkRenderedGraphRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderedGraphRepresentation_SafeDownCast_78(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderedGraphRepresentation2 = (vtkRenderedGraphRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderedGraphRepresentation2.Register(null);
			}
		}
		return vtkRenderedGraphRepresentation2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_ScalingOff_79(HandleRef pThis);

	/// <summary>
	/// Set whether to scale vertex glyphs.
	/// </summary>
	public virtual void ScalingOff()
	{
		vtkRenderedGraphRepresentation_ScalingOff_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_ScalingOn_80(HandleRef pThis);

	/// <summary>
	/// Set whether to scale vertex glyphs.
	/// </summary>
	public virtual void ScalingOn()
	{
		vtkRenderedGraphRepresentation_ScalingOn_80(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetColorEdgesByArray_81(HandleRef pThis, byte b);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetColorEdgesByArray(bool b)
	{
		vtkRenderedGraphRepresentation_SetColorEdgesByArray_81(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetColorVerticesByArray_82(HandleRef pThis, byte b);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetColorVerticesByArray(bool b)
	{
		vtkRenderedGraphRepresentation_SetColorVerticesByArray_82(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEdgeColorArrayName_83(HandleRef pThis, string name);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetEdgeColorArrayName(string name)
	{
		vtkRenderedGraphRepresentation_SetEdgeColorArrayName_83(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEdgeHoverArrayName_84(HandleRef pThis, string _arg);

	/// <summary>
	/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void SetEdgeHoverArrayName(string _arg)
	{
		vtkRenderedGraphRepresentation_SetEdgeHoverArrayName_84(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEdgeIconAlignment_85(HandleRef pThis, int align);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetEdgeIconAlignment(int align)
	{
		vtkRenderedGraphRepresentation_SetEdgeIconAlignment_85(GetCppThis(), align);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEdgeIconArrayName_86(HandleRef pThis, string name);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetEdgeIconArrayName(string name)
	{
		vtkRenderedGraphRepresentation_SetEdgeIconArrayName_86(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEdgeIconPriorityArrayName_87(HandleRef pThis, string name);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetEdgeIconPriorityArrayName(string name)
	{
		vtkRenderedGraphRepresentation_SetEdgeIconPriorityArrayName_87(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEdgeIconVisibility_88(HandleRef pThis, byte b);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetEdgeIconVisibility(bool b)
	{
		vtkRenderedGraphRepresentation_SetEdgeIconVisibility_88(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEdgeLabelArrayName_89(HandleRef pThis, string name);

	/// <summary>
	/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void SetEdgeLabelArrayName(string name)
	{
		vtkRenderedGraphRepresentation_SetEdgeLabelArrayName_89(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEdgeLabelPriorityArrayName_90(HandleRef pThis, string name);

	/// <summary>
	/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void SetEdgeLabelPriorityArrayName(string name)
	{
		vtkRenderedGraphRepresentation_SetEdgeLabelPriorityArrayName_90(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEdgeLabelTextProperty_91(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void SetEdgeLabelTextProperty(vtkTextProperty p)
	{
		vtkRenderedGraphRepresentation_SetEdgeLabelTextProperty_91(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEdgeLabelVisibility_92(HandleRef pThis, byte b);

	/// <summary>
	/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void SetEdgeLabelVisibility(bool b)
	{
		vtkRenderedGraphRepresentation_SetEdgeLabelVisibility_92(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEdgeLayoutStrategy_93(HandleRef pThis, HandleRef strategy);

	/// <summary>
	/// Set/get the graph layout strategy.
	/// </summary>
	public virtual void SetEdgeLayoutStrategy(vtkEdgeLayoutStrategy strategy)
	{
		vtkRenderedGraphRepresentation_SetEdgeLayoutStrategy_93(GetCppThis(), strategy?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEdgeLayoutStrategy_94(HandleRef pThis, string name);

	/// <summary>
	/// Set the edge layout strategy by name.
	/// </summary>
	public virtual void SetEdgeLayoutStrategy(string name)
	{
		vtkRenderedGraphRepresentation_SetEdgeLayoutStrategy_94(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEdgeLayoutStrategyToArcParallel_95(HandleRef pThis);

	/// <summary>
	/// Set/get the graph layout strategy.
	/// </summary>
	public void SetEdgeLayoutStrategyToArcParallel()
	{
		vtkRenderedGraphRepresentation_SetEdgeLayoutStrategyToArcParallel_95(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEdgeLayoutStrategyToGeo_96(HandleRef pThis, double explodeFactor);

	/// <summary>
	/// Set the edge layout strategy to a geospatial arced strategy
	/// appropriate for vtkGeoView.
	/// </summary>
	public virtual void SetEdgeLayoutStrategyToGeo(double explodeFactor)
	{
		vtkRenderedGraphRepresentation_SetEdgeLayoutStrategyToGeo_96(GetCppThis(), explodeFactor);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEdgeLayoutStrategyToPassThrough_97(HandleRef pThis);

	/// <summary>
	/// Set/get the graph layout strategy.
	/// </summary>
	public void SetEdgeLayoutStrategyToPassThrough()
	{
		vtkRenderedGraphRepresentation_SetEdgeLayoutStrategyToPassThrough_97(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEdgeScalarBarVisibility_98(HandleRef pThis, byte b);

	/// <summary>
	/// Vertex/edge scalar bar visibility.
	/// </summary>
	public virtual void SetEdgeScalarBarVisibility(bool b)
	{
		vtkRenderedGraphRepresentation_SetEdgeScalarBarVisibility_98(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEdgeSelection_99(HandleRef pThis, byte b);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public void SetEdgeSelection(bool b)
	{
		vtkRenderedGraphRepresentation_SetEdgeSelection_99(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEdgeVisibility_100(HandleRef pThis, byte b);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetEdgeVisibility(bool b)
	{
		vtkRenderedGraphRepresentation_SetEdgeVisibility_100(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEnableEdgesByArray_101(HandleRef pThis, byte b);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetEnableEdgesByArray(bool b)
	{
		vtkRenderedGraphRepresentation_SetEnableEdgesByArray_101(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEnableVerticesByArray_102(HandleRef pThis, byte b);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetEnableVerticesByArray(bool b)
	{
		vtkRenderedGraphRepresentation_SetEnableVerticesByArray_102(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEnabledEdgesArrayName_103(HandleRef pThis, string name);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetEnabledEdgesArrayName(string name)
	{
		vtkRenderedGraphRepresentation_SetEnabledEdgesArrayName_103(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetEnabledVerticesArrayName_104(HandleRef pThis, string name);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetEnabledVerticesArrayName(string name)
	{
		vtkRenderedGraphRepresentation_SetEnabledVerticesArrayName_104(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetGlyphType_105(HandleRef pThis, int type);

	/// <summary>
	/// Set the graph vertex glyph type.
	/// </summary>
	public virtual void SetGlyphType(int type)
	{
		vtkRenderedGraphRepresentation_SetGlyphType_105(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetHideEdgeLabelsOnInteraction_106(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void SetHideEdgeLabelsOnInteraction(bool _arg)
	{
		vtkRenderedGraphRepresentation_SetHideEdgeLabelsOnInteraction_106(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetHideVertexLabelsOnInteraction_107(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void SetHideVertexLabelsOnInteraction(bool _arg)
	{
		vtkRenderedGraphRepresentation_SetHideVertexLabelsOnInteraction_107(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategy_108(HandleRef pThis, HandleRef strategy);

	/// <summary>
	/// Set/get the graph layout strategy.
	/// </summary>
	public virtual void SetLayoutStrategy(vtkGraphLayoutStrategy strategy)
	{
		vtkRenderedGraphRepresentation_SetLayoutStrategy_108(GetCppThis(), strategy?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategy_109(HandleRef pThis, string name);

	/// <summary>
	/// Get/set the layout strategy by name.
	/// </summary>
	public virtual void SetLayoutStrategy(string name)
	{
		vtkRenderedGraphRepresentation_SetLayoutStrategy_109(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToAssignCoordinates_110(HandleRef pThis, string xarr, string yarr, string zarr);

	/// <summary>
	/// Set the layout strategy to use coordinates from arrays.
	/// The x array must be specified. The y and z arrays are optional.
	/// </summary>
	public virtual void SetLayoutStrategyToAssignCoordinates(string xarr, string yarr, string zarr)
	{
		vtkRenderedGraphRepresentation_SetLayoutStrategyToAssignCoordinates_110(GetCppThis(), xarr, yarr, zarr);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToCircular_111(HandleRef pThis);

	/// <summary>
	/// Set predefined layout strategies.
	/// </summary>
	public void SetLayoutStrategyToCircular()
	{
		vtkRenderedGraphRepresentation_SetLayoutStrategyToCircular_111(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToClustering2D_112(HandleRef pThis);

	/// <summary>
	/// Set predefined layout strategies.
	/// </summary>
	public void SetLayoutStrategyToClustering2D()
	{
		vtkRenderedGraphRepresentation_SetLayoutStrategyToClustering2D_112(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToCommunity2D_113(HandleRef pThis);

	/// <summary>
	/// Set predefined layout strategies.
	/// </summary>
	public void SetLayoutStrategyToCommunity2D()
	{
		vtkRenderedGraphRepresentation_SetLayoutStrategyToCommunity2D_113(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToCone_114(HandleRef pThis);

	/// <summary>
	/// Set predefined layout strategies.
	/// </summary>
	public void SetLayoutStrategyToCone()
	{
		vtkRenderedGraphRepresentation_SetLayoutStrategyToCone_114(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToCosmicTree_115(HandleRef pThis);

	/// <summary>
	/// Set predefined layout strategies.
	/// </summary>
	public void SetLayoutStrategyToCosmicTree()
	{
		vtkRenderedGraphRepresentation_SetLayoutStrategyToCosmicTree_115(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToCosmicTree_116(HandleRef pThis, string nodeSizeArrayName, byte sizeLeafNodesOnly, int layoutDepth, long layoutRoot);

	/// <summary>
	/// Set the layout strategy to a cosmic tree layout. nodeSizeArrayName is
	/// the array used to size the circles (default is nullptr, which makes leaf
	/// nodes the same size). sizeLeafNodesOnly only uses the leaf node sizes,
	/// and computes the parent size as the sum of the child sizes (default true).
	/// layoutDepth stops layout at a certain depth (default is 0, which does the
	/// entire tree). layoutRoot is the vertex that will be considered the root
	/// node of the layout (default is -1, which will use the tree's root).
	/// See vtkCosmicTreeLayoutStrategy for more information.
	/// </summary>
	public virtual void SetLayoutStrategyToCosmicTree(string nodeSizeArrayName, bool sizeLeafNodesOnly, int layoutDepth, long layoutRoot)
	{
		vtkRenderedGraphRepresentation_SetLayoutStrategyToCosmicTree_116(GetCppThis(), nodeSizeArrayName, (byte)(sizeLeafNodesOnly ? 1u : 0u), layoutDepth, layoutRoot);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToFast2D_117(HandleRef pThis);

	/// <summary>
	/// Set predefined layout strategies.
	/// </summary>
	public void SetLayoutStrategyToFast2D()
	{
		vtkRenderedGraphRepresentation_SetLayoutStrategyToFast2D_117(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToForceDirected_118(HandleRef pThis);

	/// <summary>
	/// Set predefined layout strategies.
	/// </summary>
	public void SetLayoutStrategyToForceDirected()
	{
		vtkRenderedGraphRepresentation_SetLayoutStrategyToForceDirected_118(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToPassThrough_119(HandleRef pThis);

	/// <summary>
	/// Set predefined layout strategies.
	/// </summary>
	public void SetLayoutStrategyToPassThrough()
	{
		vtkRenderedGraphRepresentation_SetLayoutStrategyToPassThrough_119(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToRandom_120(HandleRef pThis);

	/// <summary>
	/// Set predefined layout strategies.
	/// </summary>
	public void SetLayoutStrategyToRandom()
	{
		vtkRenderedGraphRepresentation_SetLayoutStrategyToRandom_120(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToSimple2D_121(HandleRef pThis);

	/// <summary>
	/// Set predefined layout strategies.
	/// </summary>
	public void SetLayoutStrategyToSimple2D()
	{
		vtkRenderedGraphRepresentation_SetLayoutStrategyToSimple2D_121(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToSpanTree_122(HandleRef pThis);

	/// <summary>
	/// Set predefined layout strategies.
	/// </summary>
	public void SetLayoutStrategyToSpanTree()
	{
		vtkRenderedGraphRepresentation_SetLayoutStrategyToSpanTree_122(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToTree_123(HandleRef pThis);

	/// <summary>
	/// Set predefined layout strategies.
	/// </summary>
	public void SetLayoutStrategyToTree()
	{
		vtkRenderedGraphRepresentation_SetLayoutStrategyToTree_123(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToTree_124(HandleRef pThis, byte radial, double angle, double leafSpacing, double logSpacing);

	/// <summary>
	/// Set the layout strategy to a tree layout. Radial indicates whether to
	/// do a radial or standard top-down tree layout. The angle parameter is the
	/// angular distance spanned by the tree. Leaf spacing is a
	/// value from 0 to 1 indicating how much of the radial layout should be
	/// allocated to leaf nodes (as opposed to between tree branches). The log spacing value is a
	/// non-negative value where &gt; 1 will create expanding levels, &lt; 1 will create
	/// contracting levels, and = 1 makes all levels the same size. See
	/// vtkTreeLayoutStrategy for more information.
	/// </summary>
	public virtual void SetLayoutStrategyToTree(bool radial, double angle, double leafSpacing, double logSpacing)
	{
		vtkRenderedGraphRepresentation_SetLayoutStrategyToTree_124(GetCppThis(), (byte)(radial ? 1u : 0u), angle, leafSpacing, logSpacing);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetScaling_125(HandleRef pThis, byte b);

	/// <summary>
	/// Set whether to scale vertex glyphs.
	/// </summary>
	public virtual void SetScaling(bool b)
	{
		vtkRenderedGraphRepresentation_SetScaling_125(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetScalingArrayName_126(HandleRef pThis, string name);

	/// <summary>
	/// Set the glyph scaling array name.
	/// </summary>
	public virtual void SetScalingArrayName(string name)
	{
		vtkRenderedGraphRepresentation_SetScalingArrayName_126(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetUseEdgeIconTypeMap_127(HandleRef pThis, byte b);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetUseEdgeIconTypeMap(bool b)
	{
		vtkRenderedGraphRepresentation_SetUseEdgeIconTypeMap_127(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetUseVertexIconTypeMap_128(HandleRef pThis, byte b);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void SetUseVertexIconTypeMap(bool b)
	{
		vtkRenderedGraphRepresentation_SetUseVertexIconTypeMap_128(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetVertexColorArrayName_129(HandleRef pThis, string name);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetVertexColorArrayName(string name)
	{
		vtkRenderedGraphRepresentation_SetVertexColorArrayName_129(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetVertexDefaultIcon_130(HandleRef pThis, int icon);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void SetVertexDefaultIcon(int icon)
	{
		vtkRenderedGraphRepresentation_SetVertexDefaultIcon_130(GetCppThis(), icon);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetVertexHoverArrayName_131(HandleRef pThis, string _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetVertexHoverArrayName(string _arg)
	{
		vtkRenderedGraphRepresentation_SetVertexHoverArrayName_131(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetVertexIconAlignment_132(HandleRef pThis, int align);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void SetVertexIconAlignment(int align)
	{
		vtkRenderedGraphRepresentation_SetVertexIconAlignment_132(GetCppThis(), align);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetVertexIconArrayName_133(HandleRef pThis, string name);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void SetVertexIconArrayName(string name)
	{
		vtkRenderedGraphRepresentation_SetVertexIconArrayName_133(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetVertexIconPriorityArrayName_134(HandleRef pThis, string name);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void SetVertexIconPriorityArrayName(string name)
	{
		vtkRenderedGraphRepresentation_SetVertexIconPriorityArrayName_134(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetVertexIconSelectionMode_135(HandleRef pThis, int mode);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetVertexIconSelectionMode(int mode)
	{
		vtkRenderedGraphRepresentation_SetVertexIconSelectionMode_135(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToAnnotationIcon_136(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetVertexIconSelectionModeToAnnotationIcon()
	{
		vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToAnnotationIcon_136(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToIgnoreSelection_137(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetVertexIconSelectionModeToIgnoreSelection()
	{
		vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToIgnoreSelection_137(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToSelectedIcon_138(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetVertexIconSelectionModeToSelectedIcon()
	{
		vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToSelectedIcon_138(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToSelectedOffset_139(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void SetVertexIconSelectionModeToSelectedOffset()
	{
		vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToSelectedOffset_139(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetVertexIconVisibility_140(HandleRef pThis, byte b);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void SetVertexIconVisibility(bool b)
	{
		vtkRenderedGraphRepresentation_SetVertexIconVisibility_140(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetVertexLabelArrayName_141(HandleRef pThis, string name);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetVertexLabelArrayName(string name)
	{
		vtkRenderedGraphRepresentation_SetVertexLabelArrayName_141(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetVertexLabelPriorityArrayName_142(HandleRef pThis, string name);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetVertexLabelPriorityArrayName(string name)
	{
		vtkRenderedGraphRepresentation_SetVertexLabelPriorityArrayName_142(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetVertexLabelTextProperty_143(HandleRef pThis, HandleRef p);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetVertexLabelTextProperty(vtkTextProperty p)
	{
		vtkRenderedGraphRepresentation_SetVertexLabelTextProperty_143(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetVertexLabelVisibility_144(HandleRef pThis, byte b);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetVertexLabelVisibility(bool b)
	{
		vtkRenderedGraphRepresentation_SetVertexLabelVisibility_144(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetVertexScalarBarVisibility_145(HandleRef pThis, byte b);

	/// <summary>
	/// Vertex/edge scalar bar visibility.
	/// </summary>
	public virtual void SetVertexScalarBarVisibility(bool b)
	{
		vtkRenderedGraphRepresentation_SetVertexScalarBarVisibility_145(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_SetVertexSelectedIcon_146(HandleRef pThis, int icon);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void SetVertexSelectedIcon(int icon)
	{
		vtkRenderedGraphRepresentation_SetVertexSelectedIcon_146(GetCppThis(), icon);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_UpdateLayout_147(HandleRef pThis);

	/// <summary>
	/// Performs another iteration on the graph layout.
	/// </summary>
	public virtual void UpdateLayout()
	{
		vtkRenderedGraphRepresentation_UpdateLayout_147(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_UseEdgeIconTypeMapOff_148(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void UseEdgeIconTypeMapOff()
	{
		vtkRenderedGraphRepresentation_UseEdgeIconTypeMapOff_148(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_UseEdgeIconTypeMapOn_149(HandleRef pThis);

	/// <summary>
	/// Set the mode to one of
	/// &lt;ul&gt;
	/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
	/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
	/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
	/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
	/// &lt;/ul&gt;
	/// The default is IGNORE_SELECTION.
	/// </summary>
	public virtual void UseEdgeIconTypeMapOn()
	{
		vtkRenderedGraphRepresentation_UseEdgeIconTypeMapOn_149(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_UseVertexIconTypeMapOff_150(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void UseVertexIconTypeMapOff()
	{
		vtkRenderedGraphRepresentation_UseVertexIconTypeMapOff_150(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_UseVertexIconTypeMapOn_151(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void UseVertexIconTypeMapOn()
	{
		vtkRenderedGraphRepresentation_UseVertexIconTypeMapOn_151(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_VertexIconVisibilityOff_152(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void VertexIconVisibilityOff()
	{
		vtkRenderedGraphRepresentation_VertexIconVisibilityOff_152(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_VertexIconVisibilityOn_153(HandleRef pThis);

	/// <summary>
	/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
	/// </summary>
	public virtual void VertexIconVisibilityOn()
	{
		vtkRenderedGraphRepresentation_VertexIconVisibilityOn_153(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_VertexLabelVisibilityOff_154(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void VertexLabelVisibilityOff()
	{
		vtkRenderedGraphRepresentation_VertexLabelVisibilityOff_154(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderedGraphRepresentation_VertexLabelVisibilityOn_155(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void VertexLabelVisibilityOn()
	{
		vtkRenderedGraphRepresentation_VertexLabelVisibilityOn_155(GetCppThis());
	}
}
