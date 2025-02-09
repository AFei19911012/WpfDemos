using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGraphLayoutView
/// </summary>
/// <remarks>
///    Lays out and displays a graph
///
///
/// vtkGraphLayoutView performs graph layout and displays a vtkGraph.
/// You may color and label the vertices and edges using fields in the graph.
/// If coordinates are already assigned to the graph vertices in your graph,
/// set the layout strategy to PassThrough in this view. The default layout
/// is Fast2D which is fast but not that good, for better layout set the
/// layout to Simple2D or ForceDirected. There are also tree and circle
/// layout strategies. :)
///
/// .SEE ALSO
/// vtkFast2DLayoutStrategy
/// vtkSimple2DLayoutStrategy
/// vtkForceDirectedLayoutStrategy
///
/// @par Thanks:
/// Thanks a bunch to the holographic unfolding pattern.
/// </remarks>
public class vtkGraphLayoutView : vtkRenderView
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGraphLayoutView";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGraphLayoutView()
	{
		MRClassNameKey = "class vtkGraphLayoutView";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphLayoutView"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGraphLayoutView(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayoutView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGraphLayoutView New()
	{
		vtkGraphLayoutView result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphLayoutView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGraphLayoutView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGraphLayoutView()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGraphLayoutView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkGraphLayoutView_AddIconType_01(HandleRef pThis, string type, int index);

	/// <summary>
	/// Associate the icon at index "index" in the vtkTexture to all vertices
	/// containing "type" as a value in the vertex attribute array specified by
	/// IconArrayName.
	/// </summary>
	public void AddIconType(string type, int index)
	{
		vtkGraphLayoutView_AddIconType_01(GetCppThis(), type, index);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_ClearIconTypes_02(HandleRef pThis);

	/// <summary>
	/// Clear all icon mappings.
	/// </summary>
	public void ClearIconTypes()
	{
		vtkGraphLayoutView_ClearIconTypes_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_ColorEdgesOff_03(HandleRef pThis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public virtual void ColorEdgesOff()
	{
		vtkGraphLayoutView_ColorEdgesOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_ColorEdgesOn_04(HandleRef pThis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public virtual void ColorEdgesOn()
	{
		vtkGraphLayoutView_ColorEdgesOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_ColorVerticesOff_05(HandleRef pThis);

	/// <summary>
	/// Whether to color vertices.  Default is off.
	/// </summary>
	public virtual void ColorVerticesOff()
	{
		vtkGraphLayoutView_ColorVerticesOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_ColorVerticesOn_06(HandleRef pThis);

	/// <summary>
	/// Whether to color vertices.  Default is off.
	/// </summary>
	public virtual void ColorVerticesOn()
	{
		vtkGraphLayoutView_ColorVerticesOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_EdgeLabelVisibilityOff_07(HandleRef pThis);

	/// <summary>
	/// Whether to show edge labels.  Default is off.
	/// </summary>
	public virtual void EdgeLabelVisibilityOff()
	{
		vtkGraphLayoutView_EdgeLabelVisibilityOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_EdgeLabelVisibilityOn_08(HandleRef pThis);

	/// <summary>
	/// Whether to show edge labels.  Default is off.
	/// </summary>
	public virtual void EdgeLabelVisibilityOn()
	{
		vtkGraphLayoutView_EdgeLabelVisibilityOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_EdgeSelectionOff_09(HandleRef pThis);

	/// <summary>
	/// Whether edges are selectable. Default is on.
	/// </summary>
	public virtual void EdgeSelectionOff()
	{
		vtkGraphLayoutView_EdgeSelectionOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_EdgeSelectionOn_10(HandleRef pThis);

	/// <summary>
	/// Whether edges are selectable. Default is on.
	/// </summary>
	public virtual void EdgeSelectionOn()
	{
		vtkGraphLayoutView_EdgeSelectionOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_EdgeVisibilityOff_11(HandleRef pThis);

	/// <summary>
	/// Whether to show the edges at all. Default is on
	/// </summary>
	public virtual void EdgeVisibilityOff()
	{
		vtkGraphLayoutView_EdgeVisibilityOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_EdgeVisibilityOn_12(HandleRef pThis);

	/// <summary>
	/// Whether to show the edges at all. Default is on
	/// </summary>
	public virtual void EdgeVisibilityOn()
	{
		vtkGraphLayoutView_EdgeVisibilityOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphLayoutView_GetColorEdges_13(HandleRef pThis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public bool GetColorEdges()
	{
		return (vtkGraphLayoutView_GetColorEdges_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphLayoutView_GetColorVertices_14(HandleRef pThis);

	/// <summary>
	/// Whether to color vertices.  Default is off.
	/// </summary>
	public bool GetColorVertices()
	{
		return (vtkGraphLayoutView_GetColorVertices_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayoutView_GetEdgeColorArrayName_15(HandleRef pThis);

	/// <summary>
	/// The array to use for coloring edges.  Default is "color".
	/// </summary>
	public string GetEdgeColorArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkGraphLayoutView_GetEdgeColorArrayName_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayoutView_GetEdgeLabelArrayName_16(HandleRef pThis);

	/// <summary>
	/// The array to use for edge labeling.  Default is "LabelText".
	/// </summary>
	public string GetEdgeLabelArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkGraphLayoutView_GetEdgeLabelArrayName_16(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayoutView_GetEdgeLabelFontSize_17(HandleRef pThis);

	/// <summary>
	/// The size of the font used for edge labeling
	/// </summary>
	public virtual int GetEdgeLabelFontSize()
	{
		return vtkGraphLayoutView_GetEdgeLabelFontSize_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphLayoutView_GetEdgeLabelVisibility_18(HandleRef pThis);

	/// <summary>
	/// Whether to show edge labels.  Default is off.
	/// </summary>
	public bool GetEdgeLabelVisibility()
	{
		return (vtkGraphLayoutView_GetEdgeLabelVisibility_18(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayoutView_GetEdgeLayoutStrategy_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The layout strategy to use when performing the edge layout.
	/// This signature allows an application to create a layout
	/// object directly and simply set the pointer through this method.
	/// </summary>
	public vtkEdgeLayoutStrategy GetEdgeLayoutStrategy()
	{
		vtkEdgeLayoutStrategy vtkEdgeLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphLayoutView_GetEdgeLayoutStrategy_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkGraphLayoutView_GetEdgeLayoutStrategyName_20(HandleRef pThis);

	/// <summary>
	/// The layout strategy to use when performing the edge layout.
	/// The possible strings are:
	/// "Arc Parallel"   - Arc parallel edges and self loops.
	/// "Pass Through"   - Use edge routes assigned to the input.
	/// Default is "Arc Parallel".
	/// </summary>
	public string GetEdgeLayoutStrategyName()
	{
		return Marshal.PtrToStringAnsi(vtkGraphLayoutView_GetEdgeLayoutStrategyName_20(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphLayoutView_GetEdgeScalarBarVisibility_21(HandleRef pThis);

	/// <summary>
	/// Whether the scalar bar for edges is visible.  Default is off.
	/// </summary>
	public bool GetEdgeScalarBarVisibility()
	{
		return (vtkGraphLayoutView_GetEdgeScalarBarVisibility_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphLayoutView_GetEdgeSelection_22(HandleRef pThis);

	/// <summary>
	/// Whether edges are selectable. Default is on.
	/// </summary>
	public bool GetEdgeSelection()
	{
		return (vtkGraphLayoutView_GetEdgeSelection_22(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphLayoutView_GetEdgeVisibility_23(HandleRef pThis);

	/// <summary>
	/// Whether to show the edges at all. Default is on
	/// </summary>
	public bool GetEdgeVisibility()
	{
		return (vtkGraphLayoutView_GetEdgeVisibility_23(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayoutView_GetEnableEdgesByArray_24(HandleRef pThis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public int GetEnableEdgesByArray()
	{
		return vtkGraphLayoutView_GetEnableEdgesByArray_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayoutView_GetEnableVerticesByArray_25(HandleRef pThis);

	/// <summary>
	/// Whether to color vertices.  Default is off.
	/// </summary>
	public int GetEnableVerticesByArray()
	{
		return vtkGraphLayoutView_GetEnableVerticesByArray_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayoutView_GetEnabledEdgesArrayName_26(HandleRef pThis);

	/// <summary>
	/// The array to use for coloring edges.
	/// </summary>
	public string GetEnabledEdgesArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkGraphLayoutView_GetEnabledEdgesArrayName_26(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayoutView_GetEnabledVerticesArrayName_27(HandleRef pThis);

	/// <summary>
	/// The array to use for coloring vertices.
	/// </summary>
	public string GetEnabledVerticesArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkGraphLayoutView_GetEnabledVerticesArrayName_27(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayoutView_GetGlyphType_28(HandleRef pThis);

	/// <summary>
	/// The type of glyph to use for the vertices
	/// </summary>
	public int GetGlyphType()
	{
		return vtkGraphLayoutView_GetGlyphType_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphLayoutView_GetHideEdgeLabelsOnInteraction_29(HandleRef pThis);

	/// <summary>
	/// Whether to hide edge labels during mouse interactions.  Default is off.
	/// </summary>
	public bool GetHideEdgeLabelsOnInteraction()
	{
		return (vtkGraphLayoutView_GetHideEdgeLabelsOnInteraction_29(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphLayoutView_GetHideVertexLabelsOnInteraction_30(HandleRef pThis);

	/// <summary>
	/// Whether to hide vertex labels during mouse interactions.  Default is off.
	/// </summary>
	public bool GetHideVertexLabelsOnInteraction()
	{
		return (vtkGraphLayoutView_GetHideVertexLabelsOnInteraction_30(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayoutView_GetIconArrayName_31(HandleRef pThis);

	/// <summary>
	/// The array used for assigning icons
	/// </summary>
	public string GetIconArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkGraphLayoutView_GetIconArrayName_31(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphLayoutView_GetIconVisibility_32(HandleRef pThis);

	/// <summary>
	/// Whether icons are visible (default off).
	/// </summary>
	public bool GetIconVisibility()
	{
		return (vtkGraphLayoutView_GetIconVisibility_32(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayoutView_GetLayoutStrategy_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The layout strategy to use when performing the graph layout.
	/// This signature allows an application to create a layout
	/// object directly and simply set the pointer through this method.
	/// </summary>
	public vtkGraphLayoutStrategy GetLayoutStrategy()
	{
		vtkGraphLayoutStrategy vtkGraphLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphLayoutView_GetLayoutStrategy_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkGraphLayoutView_GetLayoutStrategyName_34(HandleRef pThis);

	/// <summary>
	/// The layout strategy to use when performing the graph layout.
	/// The possible strings are:
	/// - "Random"         Randomly places vertices in a box.
	/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
	/// - "Simple 2D"      A simple 2D force directed layout.
	/// - "Clustering 2D"  A 2D force directed layout that's just like
	/// simple 2D but uses some techniques to cluster better.
	/// - "Community 2D"   A linear-time 2D layout that's just like
	/// Fast 2D but looks for and uses a community
	/// array to 'accentuate' clusters.
	/// - "Fast 2D"       A linear-time 2D layout.
	/// - "Pass Through"  Use locations assigned to the input.
	/// - "Circular"      Places vertices uniformly on a circle.
	/// - "Cone"          Cone tree layout.
	/// - "Span Tree"     Span Tree Layout.
	/// Default is "Simple 2D".
	/// </summary>
	public string GetLayoutStrategyName()
	{
		return Marshal.PtrToStringAnsi(vtkGraphLayoutView_GetLayoutStrategyName_34(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphLayoutView_GetNumberOfGenerationsFromBase_35(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGraphLayoutView_GetNumberOfGenerationsFromBase_35(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphLayoutView_GetNumberOfGenerationsFromBaseType_36(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGraphLayoutView_GetNumberOfGenerationsFromBaseType_36(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphLayoutView_GetScaledGlyphs_37(HandleRef pThis);

	/// <summary>
	/// Whether to use scaled glyphs or not.  Default is off.
	/// </summary>
	public bool GetScaledGlyphs()
	{
		return (vtkGraphLayoutView_GetScaledGlyphs_37(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayoutView_GetScalingArrayName_38(HandleRef pThis);

	/// <summary>
	/// The array used for scaling (if ScaledGlyphs is ON)
	/// </summary>
	public string GetScalingArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkGraphLayoutView_GetScalingArrayName_38(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayoutView_GetVertexColorArrayName_39(HandleRef pThis);

	/// <summary>
	/// The array to use for coloring vertices.  The default behavior
	/// is to color by vertex degree.
	/// </summary>
	public string GetVertexColorArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkGraphLayoutView_GetVertexColorArrayName_39(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayoutView_GetVertexLabelArrayName_40(HandleRef pThis);

	/// <summary>
	/// The array to use for vertex labeling.  Default is "VertexDegree".
	/// </summary>
	public string GetVertexLabelArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkGraphLayoutView_GetVertexLabelArrayName_40(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayoutView_GetVertexLabelFontSize_41(HandleRef pThis);

	/// <summary>
	/// The size of the font used for vertex labeling
	/// </summary>
	public virtual int GetVertexLabelFontSize()
	{
		return vtkGraphLayoutView_GetVertexLabelFontSize_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphLayoutView_GetVertexLabelVisibility_42(HandleRef pThis);

	/// <summary>
	/// Whether to show vertex labels.  Default is off.
	/// </summary>
	public bool GetVertexLabelVisibility()
	{
		return (vtkGraphLayoutView_GetVertexLabelVisibility_42(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphLayoutView_GetVertexScalarBarVisibility_43(HandleRef pThis);

	/// <summary>
	/// Whether the scalar bar for vertices is visible.  Default is off.
	/// </summary>
	public bool GetVertexScalarBarVisibility()
	{
		return (vtkGraphLayoutView_GetVertexScalarBarVisibility_43(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_HideEdgeLabelsOnInteractionOff_44(HandleRef pThis);

	/// <summary>
	/// Whether to hide edge labels during mouse interactions.  Default is off.
	/// </summary>
	public virtual void HideEdgeLabelsOnInteractionOff()
	{
		vtkGraphLayoutView_HideEdgeLabelsOnInteractionOff_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_HideEdgeLabelsOnInteractionOn_45(HandleRef pThis);

	/// <summary>
	/// Whether to hide edge labels during mouse interactions.  Default is off.
	/// </summary>
	public virtual void HideEdgeLabelsOnInteractionOn()
	{
		vtkGraphLayoutView_HideEdgeLabelsOnInteractionOn_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_HideVertexLabelsOnInteractionOff_46(HandleRef pThis);

	/// <summary>
	/// Whether to hide vertex labels during mouse interactions.  Default is off.
	/// </summary>
	public virtual void HideVertexLabelsOnInteractionOff()
	{
		vtkGraphLayoutView_HideVertexLabelsOnInteractionOff_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_HideVertexLabelsOnInteractionOn_47(HandleRef pThis);

	/// <summary>
	/// Whether to hide vertex labels during mouse interactions.  Default is off.
	/// </summary>
	public virtual void HideVertexLabelsOnInteractionOn()
	{
		vtkGraphLayoutView_HideVertexLabelsOnInteractionOn_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_IconVisibilityOff_48(HandleRef pThis);

	/// <summary>
	/// Whether icons are visible (default off).
	/// </summary>
	public virtual void IconVisibilityOff()
	{
		vtkGraphLayoutView_IconVisibilityOff_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_IconVisibilityOn_49(HandleRef pThis);

	/// <summary>
	/// Whether icons are visible (default off).
	/// </summary>
	public virtual void IconVisibilityOn()
	{
		vtkGraphLayoutView_IconVisibilityOn_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayoutView_IsA_50(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGraphLayoutView_IsA_50(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayoutView_IsLayoutComplete_51(HandleRef pThis);

	/// <summary>
	/// Is the graph layout complete? This method is useful
	/// for when the strategy is iterative and the application
	/// wants to show the iterative progress of the graph layout
	/// See Also: UpdateLayout();
	/// </summary>
	public virtual int IsLayoutComplete()
	{
		return vtkGraphLayoutView_IsLayoutComplete_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayoutView_IsTypeOf_52(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGraphLayoutView_IsTypeOf_52(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayoutView_NewInstance_54(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGraphLayoutView NewInstance()
	{
		vtkGraphLayoutView result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphLayoutView_NewInstance_54(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGraphLayoutView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayoutView_SafeDownCast_55(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGraphLayoutView SafeDownCast(vtkObjectBase o)
	{
		vtkGraphLayoutView vtkGraphLayoutView2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphLayoutView_SafeDownCast_55(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraphLayoutView2 = (vtkGraphLayoutView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraphLayoutView2.Register(null);
			}
		}
		return vtkGraphLayoutView2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_ScaledGlyphsOff_56(HandleRef pThis);

	/// <summary>
	/// Whether to use scaled glyphs or not.  Default is off.
	/// </summary>
	public virtual void ScaledGlyphsOff()
	{
		vtkGraphLayoutView_ScaledGlyphsOff_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_ScaledGlyphsOn_57(HandleRef pThis);

	/// <summary>
	/// Whether to use scaled glyphs or not.  Default is off.
	/// </summary>
	public virtual void ScaledGlyphsOn()
	{
		vtkGraphLayoutView_ScaledGlyphsOn_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetColorEdges_58(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public void SetColorEdges(bool vis)
	{
		vtkGraphLayoutView_SetColorEdges_58(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetColorVertices_59(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to color vertices.  Default is off.
	/// </summary>
	public void SetColorVertices(bool vis)
	{
		vtkGraphLayoutView_SetColorVertices_59(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetEdgeColorArrayName_60(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for coloring edges.  Default is "color".
	/// </summary>
	public void SetEdgeColorArrayName(string name)
	{
		vtkGraphLayoutView_SetEdgeColorArrayName_60(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetEdgeLabelArrayName_61(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for edge labeling.  Default is "LabelText".
	/// </summary>
	public void SetEdgeLabelArrayName(string name)
	{
		vtkGraphLayoutView_SetEdgeLabelArrayName_61(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetEdgeLabelFontSize_62(HandleRef pThis, int size);

	/// <summary>
	/// The size of the font used for edge labeling
	/// </summary>
	public virtual void SetEdgeLabelFontSize(int size)
	{
		vtkGraphLayoutView_SetEdgeLabelFontSize_62(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetEdgeLabelVisibility_63(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to show edge labels.  Default is off.
	/// </summary>
	public void SetEdgeLabelVisibility(bool vis)
	{
		vtkGraphLayoutView_SetEdgeLabelVisibility_63(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetEdgeLayoutStrategy_64(HandleRef pThis, string name);

	/// <summary>
	/// The layout strategy to use when performing the edge layout.
	/// The possible strings are:
	/// "Arc Parallel"   - Arc parallel edges and self loops.
	/// "Pass Through"   - Use edge routes assigned to the input.
	/// Default is "Arc Parallel".
	/// </summary>
	public void SetEdgeLayoutStrategy(string name)
	{
		vtkGraphLayoutView_SetEdgeLayoutStrategy_64(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetEdgeLayoutStrategy_65(HandleRef pThis, HandleRef s);

	/// <summary>
	/// The layout strategy to use when performing the edge layout.
	/// This signature allows an application to create a layout
	/// object directly and simply set the pointer through this method.
	/// </summary>
	public void SetEdgeLayoutStrategy(vtkEdgeLayoutStrategy s)
	{
		vtkGraphLayoutView_SetEdgeLayoutStrategy_65(GetCppThis(), s?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetEdgeLayoutStrategyToArcParallel_66(HandleRef pThis);

	/// <summary>
	/// The layout strategy to use when performing the edge layout.
	/// The possible strings are:
	/// "Arc Parallel"   - Arc parallel edges and self loops.
	/// "Pass Through"   - Use edge routes assigned to the input.
	/// Default is "Arc Parallel".
	/// </summary>
	public void SetEdgeLayoutStrategyToArcParallel()
	{
		vtkGraphLayoutView_SetEdgeLayoutStrategyToArcParallel_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetEdgeLayoutStrategyToPassThrough_67(HandleRef pThis);

	/// <summary>
	/// The layout strategy to use when performing the edge layout.
	/// The possible strings are:
	/// "Arc Parallel"   - Arc parallel edges and self loops.
	/// "Pass Through"   - Use edge routes assigned to the input.
	/// Default is "Arc Parallel".
	/// </summary>
	public void SetEdgeLayoutStrategyToPassThrough()
	{
		vtkGraphLayoutView_SetEdgeLayoutStrategyToPassThrough_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetEdgeScalarBarVisibility_68(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether the scalar bar for edges is visible.  Default is off.
	/// </summary>
	public void SetEdgeScalarBarVisibility(bool vis)
	{
		vtkGraphLayoutView_SetEdgeScalarBarVisibility_68(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetEdgeSelection_69(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether edges are selectable. Default is on.
	/// </summary>
	public void SetEdgeSelection(bool vis)
	{
		vtkGraphLayoutView_SetEdgeSelection_69(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetEdgeVisibility_70(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to show the edges at all. Default is on
	/// </summary>
	public void SetEdgeVisibility(bool vis)
	{
		vtkGraphLayoutView_SetEdgeVisibility_70(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetEnableEdgesByArray_71(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public void SetEnableEdgesByArray(bool vis)
	{
		vtkGraphLayoutView_SetEnableEdgesByArray_71(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetEnableVerticesByArray_72(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to color vertices.  Default is off.
	/// </summary>
	public void SetEnableVerticesByArray(bool vis)
	{
		vtkGraphLayoutView_SetEnableVerticesByArray_72(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetEnabledEdgesArrayName_73(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for coloring edges.
	/// </summary>
	public void SetEnabledEdgesArrayName(string name)
	{
		vtkGraphLayoutView_SetEnabledEdgesArrayName_73(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetEnabledVerticesArrayName_74(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for coloring vertices.
	/// </summary>
	public void SetEnabledVerticesArrayName(string name)
	{
		vtkGraphLayoutView_SetEnabledVerticesArrayName_74(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetGlyphType_75(HandleRef pThis, int type);

	/// <summary>
	/// The type of glyph to use for the vertices
	/// </summary>
	public void SetGlyphType(int type)
	{
		vtkGraphLayoutView_SetGlyphType_75(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetHideEdgeLabelsOnInteraction_76(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to hide edge labels during mouse interactions.  Default is off.
	/// </summary>
	public void SetHideEdgeLabelsOnInteraction(bool vis)
	{
		vtkGraphLayoutView_SetHideEdgeLabelsOnInteraction_76(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetHideVertexLabelsOnInteraction_77(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to hide vertex labels during mouse interactions.  Default is off.
	/// </summary>
	public void SetHideVertexLabelsOnInteraction(bool vis)
	{
		vtkGraphLayoutView_SetHideVertexLabelsOnInteraction_77(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetIconAlignment_78(HandleRef pThis, int alignment);

	/// <summary>
	/// Specify where the icons should be placed in relation to the vertex.
	/// See vtkIconGlyphFilter.h for possible values.
	/// </summary>
	public void SetIconAlignment(int alignment)
	{
		vtkGraphLayoutView_SetIconAlignment_78(GetCppThis(), alignment);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetIconArrayName_79(HandleRef pThis, string name);

	/// <summary>
	/// The array used for assigning icons
	/// </summary>
	public void SetIconArrayName(string name)
	{
		vtkGraphLayoutView_SetIconArrayName_79(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetIconVisibility_80(HandleRef pThis, byte b);

	/// <summary>
	/// Whether icons are visible (default off).
	/// </summary>
	public void SetIconVisibility(bool b)
	{
		vtkGraphLayoutView_SetIconVisibility_80(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetLayoutStrategy_81(HandleRef pThis, string name);

	/// <summary>
	/// The layout strategy to use when performing the graph layout.
	/// The possible strings are:
	/// - "Random"         Randomly places vertices in a box.
	/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
	/// - "Simple 2D"      A simple 2D force directed layout.
	/// - "Clustering 2D"  A 2D force directed layout that's just like
	/// simple 2D but uses some techniques to cluster better.
	/// - "Community 2D"   A linear-time 2D layout that's just like
	/// Fast 2D but looks for and uses a community
	/// array to 'accentuate' clusters.
	/// - "Fast 2D"       A linear-time 2D layout.
	/// - "Pass Through"  Use locations assigned to the input.
	/// - "Circular"      Places vertices uniformly on a circle.
	/// - "Cone"          Cone tree layout.
	/// - "Span Tree"     Span Tree Layout.
	/// Default is "Simple 2D".
	/// </summary>
	public void SetLayoutStrategy(string name)
	{
		vtkGraphLayoutView_SetLayoutStrategy_81(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetLayoutStrategy_82(HandleRef pThis, HandleRef s);

	/// <summary>
	/// The layout strategy to use when performing the graph layout.
	/// This signature allows an application to create a layout
	/// object directly and simply set the pointer through this method.
	/// </summary>
	public void SetLayoutStrategy(vtkGraphLayoutStrategy s)
	{
		vtkGraphLayoutView_SetLayoutStrategy_82(GetCppThis(), s?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetLayoutStrategyToCircular_83(HandleRef pThis);

	/// <summary>
	/// The layout strategy to use when performing the graph layout.
	/// The possible strings are:
	/// - "Random"         Randomly places vertices in a box.
	/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
	/// - "Simple 2D"      A simple 2D force directed layout.
	/// - "Clustering 2D"  A 2D force directed layout that's just like
	/// simple 2D but uses some techniques to cluster better.
	/// - "Community 2D"   A linear-time 2D layout that's just like
	/// Fast 2D but looks for and uses a community
	/// array to 'accentuate' clusters.
	/// - "Fast 2D"       A linear-time 2D layout.
	/// - "Pass Through"  Use locations assigned to the input.
	/// - "Circular"      Places vertices uniformly on a circle.
	/// - "Cone"          Cone tree layout.
	/// - "Span Tree"     Span Tree Layout.
	/// Default is "Simple 2D".
	/// </summary>
	public void SetLayoutStrategyToCircular()
	{
		vtkGraphLayoutView_SetLayoutStrategyToCircular_83(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetLayoutStrategyToClustering2D_84(HandleRef pThis);

	/// <summary>
	/// The layout strategy to use when performing the graph layout.
	/// The possible strings are:
	/// - "Random"         Randomly places vertices in a box.
	/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
	/// - "Simple 2D"      A simple 2D force directed layout.
	/// - "Clustering 2D"  A 2D force directed layout that's just like
	/// simple 2D but uses some techniques to cluster better.
	/// - "Community 2D"   A linear-time 2D layout that's just like
	/// Fast 2D but looks for and uses a community
	/// array to 'accentuate' clusters.
	/// - "Fast 2D"       A linear-time 2D layout.
	/// - "Pass Through"  Use locations assigned to the input.
	/// - "Circular"      Places vertices uniformly on a circle.
	/// - "Cone"          Cone tree layout.
	/// - "Span Tree"     Span Tree Layout.
	/// Default is "Simple 2D".
	/// </summary>
	public void SetLayoutStrategyToClustering2D()
	{
		vtkGraphLayoutView_SetLayoutStrategyToClustering2D_84(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetLayoutStrategyToCommunity2D_85(HandleRef pThis);

	/// <summary>
	/// The layout strategy to use when performing the graph layout.
	/// The possible strings are:
	/// - "Random"         Randomly places vertices in a box.
	/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
	/// - "Simple 2D"      A simple 2D force directed layout.
	/// - "Clustering 2D"  A 2D force directed layout that's just like
	/// simple 2D but uses some techniques to cluster better.
	/// - "Community 2D"   A linear-time 2D layout that's just like
	/// Fast 2D but looks for and uses a community
	/// array to 'accentuate' clusters.
	/// - "Fast 2D"       A linear-time 2D layout.
	/// - "Pass Through"  Use locations assigned to the input.
	/// - "Circular"      Places vertices uniformly on a circle.
	/// - "Cone"          Cone tree layout.
	/// - "Span Tree"     Span Tree Layout.
	/// Default is "Simple 2D".
	/// </summary>
	public void SetLayoutStrategyToCommunity2D()
	{
		vtkGraphLayoutView_SetLayoutStrategyToCommunity2D_85(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetLayoutStrategyToCone_86(HandleRef pThis);

	/// <summary>
	/// The layout strategy to use when performing the graph layout.
	/// The possible strings are:
	/// - "Random"         Randomly places vertices in a box.
	/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
	/// - "Simple 2D"      A simple 2D force directed layout.
	/// - "Clustering 2D"  A 2D force directed layout that's just like
	/// simple 2D but uses some techniques to cluster better.
	/// - "Community 2D"   A linear-time 2D layout that's just like
	/// Fast 2D but looks for and uses a community
	/// array to 'accentuate' clusters.
	/// - "Fast 2D"       A linear-time 2D layout.
	/// - "Pass Through"  Use locations assigned to the input.
	/// - "Circular"      Places vertices uniformly on a circle.
	/// - "Cone"          Cone tree layout.
	/// - "Span Tree"     Span Tree Layout.
	/// Default is "Simple 2D".
	/// </summary>
	public void SetLayoutStrategyToCone()
	{
		vtkGraphLayoutView_SetLayoutStrategyToCone_86(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetLayoutStrategyToCosmicTree_87(HandleRef pThis);

	/// <summary>
	/// The layout strategy to use when performing the graph layout.
	/// The possible strings are:
	/// - "Random"         Randomly places vertices in a box.
	/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
	/// - "Simple 2D"      A simple 2D force directed layout.
	/// - "Clustering 2D"  A 2D force directed layout that's just like
	/// simple 2D but uses some techniques to cluster better.
	/// - "Community 2D"   A linear-time 2D layout that's just like
	/// Fast 2D but looks for and uses a community
	/// array to 'accentuate' clusters.
	/// - "Fast 2D"       A linear-time 2D layout.
	/// - "Pass Through"  Use locations assigned to the input.
	/// - "Circular"      Places vertices uniformly on a circle.
	/// - "Cone"          Cone tree layout.
	/// - "Span Tree"     Span Tree Layout.
	/// Default is "Simple 2D".
	/// </summary>
	public void SetLayoutStrategyToCosmicTree()
	{
		vtkGraphLayoutView_SetLayoutStrategyToCosmicTree_87(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetLayoutStrategyToFast2D_88(HandleRef pThis);

	/// <summary>
	/// The layout strategy to use when performing the graph layout.
	/// The possible strings are:
	/// - "Random"         Randomly places vertices in a box.
	/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
	/// - "Simple 2D"      A simple 2D force directed layout.
	/// - "Clustering 2D"  A 2D force directed layout that's just like
	/// simple 2D but uses some techniques to cluster better.
	/// - "Community 2D"   A linear-time 2D layout that's just like
	/// Fast 2D but looks for and uses a community
	/// array to 'accentuate' clusters.
	/// - "Fast 2D"       A linear-time 2D layout.
	/// - "Pass Through"  Use locations assigned to the input.
	/// - "Circular"      Places vertices uniformly on a circle.
	/// - "Cone"          Cone tree layout.
	/// - "Span Tree"     Span Tree Layout.
	/// Default is "Simple 2D".
	/// </summary>
	public void SetLayoutStrategyToFast2D()
	{
		vtkGraphLayoutView_SetLayoutStrategyToFast2D_88(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetLayoutStrategyToForceDirected_89(HandleRef pThis);

	/// <summary>
	/// The layout strategy to use when performing the graph layout.
	/// The possible strings are:
	/// - "Random"         Randomly places vertices in a box.
	/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
	/// - "Simple 2D"      A simple 2D force directed layout.
	/// - "Clustering 2D"  A 2D force directed layout that's just like
	/// simple 2D but uses some techniques to cluster better.
	/// - "Community 2D"   A linear-time 2D layout that's just like
	/// Fast 2D but looks for and uses a community
	/// array to 'accentuate' clusters.
	/// - "Fast 2D"       A linear-time 2D layout.
	/// - "Pass Through"  Use locations assigned to the input.
	/// - "Circular"      Places vertices uniformly on a circle.
	/// - "Cone"          Cone tree layout.
	/// - "Span Tree"     Span Tree Layout.
	/// Default is "Simple 2D".
	/// </summary>
	public void SetLayoutStrategyToForceDirected()
	{
		vtkGraphLayoutView_SetLayoutStrategyToForceDirected_89(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetLayoutStrategyToPassThrough_90(HandleRef pThis);

	/// <summary>
	/// The layout strategy to use when performing the graph layout.
	/// The possible strings are:
	/// - "Random"         Randomly places vertices in a box.
	/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
	/// - "Simple 2D"      A simple 2D force directed layout.
	/// - "Clustering 2D"  A 2D force directed layout that's just like
	/// simple 2D but uses some techniques to cluster better.
	/// - "Community 2D"   A linear-time 2D layout that's just like
	/// Fast 2D but looks for and uses a community
	/// array to 'accentuate' clusters.
	/// - "Fast 2D"       A linear-time 2D layout.
	/// - "Pass Through"  Use locations assigned to the input.
	/// - "Circular"      Places vertices uniformly on a circle.
	/// - "Cone"          Cone tree layout.
	/// - "Span Tree"     Span Tree Layout.
	/// Default is "Simple 2D".
	/// </summary>
	public void SetLayoutStrategyToPassThrough()
	{
		vtkGraphLayoutView_SetLayoutStrategyToPassThrough_90(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetLayoutStrategyToRandom_91(HandleRef pThis);

	/// <summary>
	/// The layout strategy to use when performing the graph layout.
	/// The possible strings are:
	/// - "Random"         Randomly places vertices in a box.
	/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
	/// - "Simple 2D"      A simple 2D force directed layout.
	/// - "Clustering 2D"  A 2D force directed layout that's just like
	/// simple 2D but uses some techniques to cluster better.
	/// - "Community 2D"   A linear-time 2D layout that's just like
	/// Fast 2D but looks for and uses a community
	/// array to 'accentuate' clusters.
	/// - "Fast 2D"       A linear-time 2D layout.
	/// - "Pass Through"  Use locations assigned to the input.
	/// - "Circular"      Places vertices uniformly on a circle.
	/// - "Cone"          Cone tree layout.
	/// - "Span Tree"     Span Tree Layout.
	/// Default is "Simple 2D".
	/// </summary>
	public void SetLayoutStrategyToRandom()
	{
		vtkGraphLayoutView_SetLayoutStrategyToRandom_91(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetLayoutStrategyToSimple2D_92(HandleRef pThis);

	/// <summary>
	/// The layout strategy to use when performing the graph layout.
	/// The possible strings are:
	/// - "Random"         Randomly places vertices in a box.
	/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
	/// - "Simple 2D"      A simple 2D force directed layout.
	/// - "Clustering 2D"  A 2D force directed layout that's just like
	/// simple 2D but uses some techniques to cluster better.
	/// - "Community 2D"   A linear-time 2D layout that's just like
	/// Fast 2D but looks for and uses a community
	/// array to 'accentuate' clusters.
	/// - "Fast 2D"       A linear-time 2D layout.
	/// - "Pass Through"  Use locations assigned to the input.
	/// - "Circular"      Places vertices uniformly on a circle.
	/// - "Cone"          Cone tree layout.
	/// - "Span Tree"     Span Tree Layout.
	/// Default is "Simple 2D".
	/// </summary>
	public void SetLayoutStrategyToSimple2D()
	{
		vtkGraphLayoutView_SetLayoutStrategyToSimple2D_92(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetLayoutStrategyToSpanTree_93(HandleRef pThis);

	/// <summary>
	/// The layout strategy to use when performing the graph layout.
	/// The possible strings are:
	/// - "Random"         Randomly places vertices in a box.
	/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
	/// - "Simple 2D"      A simple 2D force directed layout.
	/// - "Clustering 2D"  A 2D force directed layout that's just like
	/// simple 2D but uses some techniques to cluster better.
	/// - "Community 2D"   A linear-time 2D layout that's just like
	/// Fast 2D but looks for and uses a community
	/// array to 'accentuate' clusters.
	/// - "Fast 2D"       A linear-time 2D layout.
	/// - "Pass Through"  Use locations assigned to the input.
	/// - "Circular"      Places vertices uniformly on a circle.
	/// - "Cone"          Cone tree layout.
	/// - "Span Tree"     Span Tree Layout.
	/// Default is "Simple 2D".
	/// </summary>
	public void SetLayoutStrategyToSpanTree()
	{
		vtkGraphLayoutView_SetLayoutStrategyToSpanTree_93(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetLayoutStrategyToTree_94(HandleRef pThis);

	/// <summary>
	/// The layout strategy to use when performing the graph layout.
	/// The possible strings are:
	/// - "Random"         Randomly places vertices in a box.
	/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
	/// - "Simple 2D"      A simple 2D force directed layout.
	/// - "Clustering 2D"  A 2D force directed layout that's just like
	/// simple 2D but uses some techniques to cluster better.
	/// - "Community 2D"   A linear-time 2D layout that's just like
	/// Fast 2D but looks for and uses a community
	/// array to 'accentuate' clusters.
	/// - "Fast 2D"       A linear-time 2D layout.
	/// - "Pass Through"  Use locations assigned to the input.
	/// - "Circular"      Places vertices uniformly on a circle.
	/// - "Cone"          Cone tree layout.
	/// - "Span Tree"     Span Tree Layout.
	/// Default is "Simple 2D".
	/// </summary>
	public void SetLayoutStrategyToTree()
	{
		vtkGraphLayoutView_SetLayoutStrategyToTree_94(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetScaledGlyphs_95(HandleRef pThis, byte arg);

	/// <summary>
	/// Whether to use scaled glyphs or not.  Default is off.
	/// </summary>
	public void SetScaledGlyphs(bool arg)
	{
		vtkGraphLayoutView_SetScaledGlyphs_95(GetCppThis(), (byte)(arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetScalingArrayName_96(HandleRef pThis, string name);

	/// <summary>
	/// The array used for scaling (if ScaledGlyphs is ON)
	/// </summary>
	public void SetScalingArrayName(string name)
	{
		vtkGraphLayoutView_SetScalingArrayName_96(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetVertexColorArrayName_97(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for coloring vertices.  The default behavior
	/// is to color by vertex degree.
	/// </summary>
	public void SetVertexColorArrayName(string name)
	{
		vtkGraphLayoutView_SetVertexColorArrayName_97(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetVertexLabelArrayName_98(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for vertex labeling.  Default is "VertexDegree".
	/// </summary>
	public void SetVertexLabelArrayName(string name)
	{
		vtkGraphLayoutView_SetVertexLabelArrayName_98(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetVertexLabelFontSize_99(HandleRef pThis, int size);

	/// <summary>
	/// The size of the font used for vertex labeling
	/// </summary>
	public virtual void SetVertexLabelFontSize(int size)
	{
		vtkGraphLayoutView_SetVertexLabelFontSize_99(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetVertexLabelVisibility_100(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to show vertex labels.  Default is off.
	/// </summary>
	public void SetVertexLabelVisibility(bool vis)
	{
		vtkGraphLayoutView_SetVertexLabelVisibility_100(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_SetVertexScalarBarVisibility_101(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether the scalar bar for vertices is visible.  Default is off.
	/// </summary>
	public void SetVertexScalarBarVisibility(bool vis)
	{
		vtkGraphLayoutView_SetVertexScalarBarVisibility_101(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_UpdateLayout_102(HandleRef pThis);

	/// <summary>
	/// This method is useful for when the strategy is iterative
	/// and the application wants to show the iterative progress
	/// of the graph layout. The application would have something like
	/// while(!IsLayoutComplete())
	/// {
	/// UpdateLayout();
	/// }
	/// See Also: IsLayoutComplete();
	/// </summary>
	public virtual void UpdateLayout()
	{
		vtkGraphLayoutView_UpdateLayout_102(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_VertexLabelVisibilityOff_103(HandleRef pThis);

	/// <summary>
	/// Whether to show vertex labels.  Default is off.
	/// </summary>
	public virtual void VertexLabelVisibilityOff()
	{
		vtkGraphLayoutView_VertexLabelVisibilityOff_103(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_VertexLabelVisibilityOn_104(HandleRef pThis);

	/// <summary>
	/// Whether to show vertex labels.  Default is off.
	/// </summary>
	public virtual void VertexLabelVisibilityOn()
	{
		vtkGraphLayoutView_VertexLabelVisibilityOn_104(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutView_ZoomToSelection_105(HandleRef pThis);

	/// <summary>
	/// Reset the camera based on the bounds of the selected region.
	/// </summary>
	public void ZoomToSelection()
	{
		vtkGraphLayoutView_ZoomToSelection_105(GetCppThis());
	}
}
