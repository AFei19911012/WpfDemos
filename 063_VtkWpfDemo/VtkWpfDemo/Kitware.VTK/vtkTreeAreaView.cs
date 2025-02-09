using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTreeAreaView
/// </summary>
/// <remarks>
///    Accepts a graph and a hierarchy - currently
/// a tree - and provides a hierarchy-aware display.  Currently, this means
/// displaying the hierarchy using a tree ring layout, then rendering the graph
/// vertices as leaves of the tree with curved graph edges between leaves.
///
///
/// Takes a graph and a hierarchy (currently a tree) and lays out the graph
/// vertices based on their categorization within the hierarchy.
///
/// .SEE ALSO
/// vtkGraphLayoutView
///
/// @par Thanks:
/// Thanks to Jason Shepherd for implementing this class
/// </remarks>
public class vtkTreeAreaView : vtkRenderView
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTreeAreaView";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTreeAreaView()
	{
		MRClassNameKey = "class vtkTreeAreaView";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeAreaView"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTreeAreaView(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeAreaView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeAreaView New()
	{
		vtkTreeAreaView result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeAreaView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeAreaView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTreeAreaView()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTreeAreaView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTreeAreaView_AreaLabelVisibilityOff_01(HandleRef pThis);

	/// <summary>
	/// Whether to show area labels.  Default is off.
	/// </summary>
	public virtual void AreaLabelVisibilityOff()
	{
		vtkTreeAreaView_AreaLabelVisibilityOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_AreaLabelVisibilityOn_02(HandleRef pThis);

	/// <summary>
	/// Whether to show area labels.  Default is off.
	/// </summary>
	public virtual void AreaLabelVisibilityOn()
	{
		vtkTreeAreaView_AreaLabelVisibilityOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_ColorAreasOff_03(HandleRef pThis);

	/// <summary>
	/// Whether to color vertices.  Default is off.
	/// </summary>
	public virtual void ColorAreasOff()
	{
		vtkTreeAreaView_ColorAreasOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_ColorAreasOn_04(HandleRef pThis);

	/// <summary>
	/// Whether to color vertices.  Default is off.
	/// </summary>
	public virtual void ColorAreasOn()
	{
		vtkTreeAreaView_ColorAreasOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_ColorEdgesOff_05(HandleRef pThis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public virtual void ColorEdgesOff()
	{
		vtkTreeAreaView_ColorEdgesOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_ColorEdgesOn_06(HandleRef pThis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public virtual void ColorEdgesOn()
	{
		vtkTreeAreaView_ColorEdgesOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_EdgeLabelVisibilityOff_07(HandleRef pThis);

	/// <summary>
	/// Whether to show edge labels.  Default is off.
	/// </summary>
	public virtual void EdgeLabelVisibilityOff()
	{
		vtkTreeAreaView_EdgeLabelVisibilityOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_EdgeLabelVisibilityOn_08(HandleRef pThis);

	/// <summary>
	/// Whether to show edge labels.  Default is off.
	/// </summary>
	public virtual void EdgeLabelVisibilityOn()
	{
		vtkTreeAreaView_EdgeLabelVisibilityOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeAreaView_GetAreaColorArrayName_09(HandleRef pThis);

	/// <summary>
	/// The array to use for coloring vertices.  Default is "color".
	/// </summary>
	public string GetAreaColorArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkTreeAreaView_GetAreaColorArrayName_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeAreaView_GetAreaHoverArrayName_10(HandleRef pThis);

	/// <summary>
	/// The name of the array whose value appears when the mouse hovers
	/// over a rectangle in the treemap.
	/// This must be a string array.
	/// </summary>
	public string GetAreaHoverArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkTreeAreaView_GetAreaHoverArrayName_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeAreaView_GetAreaLabelArrayName_11(HandleRef pThis);

	/// <summary>
	/// The array to use for area labeling.  Default is "label".
	/// </summary>
	public string GetAreaLabelArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkTreeAreaView_GetAreaLabelArrayName_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeAreaView_GetAreaLabelFontSize_12(HandleRef pThis);

	/// <summary>
	/// The size of the font used for area labeling
	/// </summary>
	public virtual int GetAreaLabelFontSize()
	{
		return vtkTreeAreaView_GetAreaLabelFontSize_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTreeAreaView_GetAreaLabelVisibility_13(HandleRef pThis);

	/// <summary>
	/// Whether to show area labels.  Default is off.
	/// </summary>
	public bool GetAreaLabelVisibility()
	{
		return (vtkTreeAreaView_GetAreaLabelVisibility_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeAreaView_GetAreaSizeArrayName_14(HandleRef pThis);

	/// <summary>
	/// The array to use for area sizes. Default is "size".
	/// </summary>
	public string GetAreaSizeArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkTreeAreaView_GetAreaSizeArrayName_14(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTreeAreaView_GetBundlingStrength_15(HandleRef pThis);

	/// <summary>
	/// Set the bundling strength.
	/// </summary>
	public double GetBundlingStrength()
	{
		return vtkTreeAreaView_GetBundlingStrength_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTreeAreaView_GetColorAreas_16(HandleRef pThis);

	/// <summary>
	/// Whether to color vertices.  Default is off.
	/// </summary>
	public bool GetColorAreas()
	{
		return (vtkTreeAreaView_GetColorAreas_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTreeAreaView_GetColorEdges_17(HandleRef pThis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public bool GetColorEdges()
	{
		return (vtkTreeAreaView_GetColorEdges_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeAreaView_GetEdgeColorArrayName_18(HandleRef pThis);

	/// <summary>
	/// The array to use for coloring edges.  Default is "color".
	/// </summary>
	public string GetEdgeColorArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkTreeAreaView_GetEdgeColorArrayName_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeAreaView_GetEdgeLabelArrayName_19(HandleRef pThis);

	/// <summary>
	/// The array to use for edge labeling.  Default is "label".
	/// </summary>
	public string GetEdgeLabelArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkTreeAreaView_GetEdgeLabelArrayName_19(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeAreaView_GetEdgeLabelFontSize_20(HandleRef pThis);

	/// <summary>
	/// The size of the font used for edge labeling
	/// </summary>
	public virtual int GetEdgeLabelFontSize()
	{
		return vtkTreeAreaView_GetEdgeLabelFontSize_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTreeAreaView_GetEdgeLabelVisibility_21(HandleRef pThis);

	/// <summary>
	/// Whether to show edge labels.  Default is off.
	/// </summary>
	public bool GetEdgeLabelVisibility()
	{
		return (vtkTreeAreaView_GetEdgeLabelVisibility_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTreeAreaView_GetEdgeScalarBarVisibility_22(HandleRef pThis);

	/// <summary>
	/// Visibility of scalar bar actor for edges.
	/// </summary>
	public virtual bool GetEdgeScalarBarVisibility()
	{
		return (vtkTreeAreaView_GetEdgeScalarBarVisibility_22(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeAreaView_GetLabelPriorityArrayName_23(HandleRef pThis);

	/// <summary>
	/// The array to use for area labeling priority.
	/// Default is "GraphVertexDegree".
	/// </summary>
	public string GetLabelPriorityArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkTreeAreaView_GetLabelPriorityArrayName_23(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeAreaView_GetLayoutStrategy_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The layout strategy for producing spatial regions for the tree.
	/// </summary>
	public virtual vtkAreaLayoutStrategy GetLayoutStrategy()
	{
		vtkAreaLayoutStrategy vtkAreaLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeAreaView_GetLayoutStrategy_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAreaLayoutStrategy2 = (vtkAreaLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAreaLayoutStrategy2.Register(null);
			}
		}
		return vtkAreaLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeAreaView_GetNumberOfGenerationsFromBase_25(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTreeAreaView_GetNumberOfGenerationsFromBase_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeAreaView_GetNumberOfGenerationsFromBaseType_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTreeAreaView_GetNumberOfGenerationsFromBaseType_26(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTreeAreaView_GetShrinkPercentage_27(HandleRef pThis);

	/// <summary>
	/// Set the region shrink percentage between 0.0 and 1.0.
	/// </summary>
	public double GetShrinkPercentage()
	{
		return vtkTreeAreaView_GetShrinkPercentage_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTreeAreaView_GetUseRectangularCoordinates_28(HandleRef pThis);

	/// <summary>
	/// Whether the area represents radial or rectangular coordinates.
	/// </summary>
	public virtual bool GetUseRectangularCoordinates()
	{
		return (vtkTreeAreaView_GetUseRectangularCoordinates_28(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeAreaView_IsA_29(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTreeAreaView_IsA_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeAreaView_IsTypeOf_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTreeAreaView_IsTypeOf_30(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeAreaView_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTreeAreaView NewInstance()
	{
		vtkTreeAreaView result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeAreaView_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeAreaView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeAreaView_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeAreaView SafeDownCast(vtkObjectBase o)
	{
		vtkTreeAreaView vtkTreeAreaView2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeAreaView_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTreeAreaView2 = (vtkTreeAreaView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTreeAreaView2.Register(null);
			}
		}
		return vtkTreeAreaView2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_SetAreaColorArrayName_34(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for coloring vertices.  Default is "color".
	/// </summary>
	public void SetAreaColorArrayName(string name)
	{
		vtkTreeAreaView_SetAreaColorArrayName_34(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_SetAreaHoverArrayName_35(HandleRef pThis, string name);

	/// <summary>
	/// The name of the array whose value appears when the mouse hovers
	/// over a rectangle in the treemap.
	/// This must be a string array.
	/// </summary>
	public void SetAreaHoverArrayName(string name)
	{
		vtkTreeAreaView_SetAreaHoverArrayName_35(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_SetAreaLabelArrayName_36(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for area labeling.  Default is "label".
	/// </summary>
	public void SetAreaLabelArrayName(string name)
	{
		vtkTreeAreaView_SetAreaLabelArrayName_36(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_SetAreaLabelFontSize_37(HandleRef pThis, int size);

	/// <summary>
	/// The size of the font used for area labeling
	/// </summary>
	public virtual void SetAreaLabelFontSize(int size)
	{
		vtkTreeAreaView_SetAreaLabelFontSize_37(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_SetAreaLabelVisibility_38(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to show area labels.  Default is off.
	/// </summary>
	public void SetAreaLabelVisibility(bool vis)
	{
		vtkTreeAreaView_SetAreaLabelVisibility_38(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_SetAreaSizeArrayName_39(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for area sizes. Default is "size".
	/// </summary>
	public void SetAreaSizeArrayName(string name)
	{
		vtkTreeAreaView_SetAreaSizeArrayName_39(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_SetBundlingStrength_40(HandleRef pThis, double strength);

	/// <summary>
	/// Set the bundling strength.
	/// </summary>
	public void SetBundlingStrength(double strength)
	{
		vtkTreeAreaView_SetBundlingStrength_40(GetCppThis(), strength);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_SetColorAreas_41(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to color vertices.  Default is off.
	/// </summary>
	public void SetColorAreas(bool vis)
	{
		vtkTreeAreaView_SetColorAreas_41(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_SetColorEdges_42(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to color edges.  Default is off.
	/// </summary>
	public void SetColorEdges(bool vis)
	{
		vtkTreeAreaView_SetColorEdges_42(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_SetEdgeColorArrayName_43(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for coloring edges.  Default is "color".
	/// </summary>
	public void SetEdgeColorArrayName(string name)
	{
		vtkTreeAreaView_SetEdgeColorArrayName_43(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_SetEdgeColorToSplineFraction_44(HandleRef pThis);

	/// <summary>
	/// Set the color to be the spline fraction
	/// </summary>
	public void SetEdgeColorToSplineFraction()
	{
		vtkTreeAreaView_SetEdgeColorToSplineFraction_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_SetEdgeLabelArrayName_45(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for edge labeling.  Default is "label".
	/// </summary>
	public void SetEdgeLabelArrayName(string name)
	{
		vtkTreeAreaView_SetEdgeLabelArrayName_45(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_SetEdgeLabelFontSize_46(HandleRef pThis, int size);

	/// <summary>
	/// The size of the font used for edge labeling
	/// </summary>
	public virtual void SetEdgeLabelFontSize(int size)
	{
		vtkTreeAreaView_SetEdgeLabelFontSize_46(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_SetEdgeLabelVisibility_47(HandleRef pThis, byte vis);

	/// <summary>
	/// Whether to show edge labels.  Default is off.
	/// </summary>
	public void SetEdgeLabelVisibility(bool vis)
	{
		vtkTreeAreaView_SetEdgeLabelVisibility_47(GetCppThis(), (byte)(vis ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_SetEdgeScalarBarVisibility_48(HandleRef pThis, byte b);

	/// <summary>
	/// Visibility of scalar bar actor for edges.
	/// </summary>
	public virtual void SetEdgeScalarBarVisibility(bool b)
	{
		vtkTreeAreaView_SetEdgeScalarBarVisibility_48(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeAreaView_SetGraphFromInput_49(HandleRef pThis, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the tree and graph representations to the appropriate input ports.
	/// </summary>
	public vtkDataRepresentation SetGraphFromInput(vtkGraph input)
	{
		vtkDataRepresentation vtkDataRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeAreaView_SetGraphFromInput_49(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataRepresentation2 = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataRepresentation2.Register(null);
			}
		}
		return vtkDataRepresentation2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeAreaView_SetGraphFromInputConnection_50(HandleRef pThis, HandleRef conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the tree and graph representations to the appropriate input ports.
	/// </summary>
	public vtkDataRepresentation SetGraphFromInputConnection(vtkAlgorithmOutput conn)
	{
		vtkDataRepresentation vtkDataRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeAreaView_SetGraphFromInputConnection_50(GetCppThis(), conn?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataRepresentation2 = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataRepresentation2.Register(null);
			}
		}
		return vtkDataRepresentation2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_SetLabelPriorityArrayName_51(HandleRef pThis, string name);

	/// <summary>
	/// The array to use for area labeling priority.
	/// Default is "GraphVertexDegree".
	/// </summary>
	public void SetLabelPriorityArrayName(string name)
	{
		vtkTreeAreaView_SetLabelPriorityArrayName_51(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_SetLayoutStrategy_52(HandleRef pThis, HandleRef strategy);

	/// <summary>
	/// The layout strategy for producing spatial regions for the tree.
	/// </summary>
	public virtual void SetLayoutStrategy(vtkAreaLayoutStrategy strategy)
	{
		vtkTreeAreaView_SetLayoutStrategy_52(GetCppThis(), strategy?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_SetShrinkPercentage_53(HandleRef pThis, double value);

	/// <summary>
	/// Set the region shrink percentage between 0.0 and 1.0.
	/// </summary>
	public void SetShrinkPercentage(double value)
	{
		vtkTreeAreaView_SetShrinkPercentage_53(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeAreaView_SetTreeFromInput_54(HandleRef pThis, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the tree and graph representations to the appropriate input ports.
	/// </summary>
	public vtkDataRepresentation SetTreeFromInput(vtkTree input)
	{
		vtkDataRepresentation vtkDataRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeAreaView_SetTreeFromInput_54(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataRepresentation2 = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataRepresentation2.Register(null);
			}
		}
		return vtkDataRepresentation2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeAreaView_SetTreeFromInputConnection_55(HandleRef pThis, HandleRef conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the tree and graph representations to the appropriate input ports.
	/// </summary>
	public vtkDataRepresentation SetTreeFromInputConnection(vtkAlgorithmOutput conn)
	{
		vtkDataRepresentation vtkDataRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeAreaView_SetTreeFromInputConnection_55(GetCppThis(), conn?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataRepresentation2 = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataRepresentation2.Register(null);
			}
		}
		return vtkDataRepresentation2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_SetUseRectangularCoordinates_56(HandleRef pThis, byte rect);

	/// <summary>
	/// Whether the area represents radial or rectangular coordinates.
	/// </summary>
	public virtual void SetUseRectangularCoordinates(bool rect)
	{
		vtkTreeAreaView_SetUseRectangularCoordinates_56(GetCppThis(), (byte)(rect ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_UseRectangularCoordinatesOff_57(HandleRef pThis);

	/// <summary>
	/// Whether the area represents radial or rectangular coordinates.
	/// </summary>
	public virtual void UseRectangularCoordinatesOff()
	{
		vtkTreeAreaView_UseRectangularCoordinatesOff_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeAreaView_UseRectangularCoordinatesOn_58(HandleRef pThis);

	/// <summary>
	/// Whether the area represents radial or rectangular coordinates.
	/// </summary>
	public virtual void UseRectangularCoordinatesOn()
	{
		vtkTreeAreaView_UseRectangularCoordinatesOn_58(GetCppThis());
	}
}
